# Sordland/Turn08/A_WomensRightsMeeting

- **ID konwersacji:** `152`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/152_A_WomensRightsMeeting.md`
- **Liczba węzłów dialogowych:** 566
- **Liczba wyborów gracza:** 92

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[40]** Ciara Walda

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Faction_USP_Obstructionist`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Law_Decree_Stronger`
- `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism`
- `BaseGame.Policy_Welfare_EvolutionNotMandatory`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Prologue_University_SupportWomensRights`
- `BaseGame.Reform_Assembly_Vote`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Relations_Monica_SupportIntentionAtBall`
- `BaseGame.Situation_Welfare_FailedEducationReform`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn06_P_SupportedMonicaAtConfrontation`
- `BaseGame.Turn08_SecondScandal_DenyEverything`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_PetrSelfResigned`
- `BaseGame.Turn08_SecondScandal_PetrTrialled`
- `BaseGame.Turn08_WomensRights_ThroughAssembly`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Education`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Violence`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bill_Turn09_StrongWomensRights_Signed`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Enable_LeagueOfWomenDonation`
- `BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2`
- `BaseGame.Enable_WomensRightsBill_Strong`
- `BaseGame.Enable_WomensRightsBill_Weak`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.Policy_Law_WomenLiberation`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_LeadsWomensRights`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Situation_Law_AverageWomenRights`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Situation_Law_LimitedWomenRights`
- `BaseGame.Situation_Welfare_GenderEqualityInEducation`
- `BaseGame.Sollist`
- `BaseGame.Turn08_WomensRights_ThroughAssembly`
- `BaseGame.WomensRightCommission`
- `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Education`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Violence`
- `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace`
- `BaseGameSupport.Codex_Characters_Family_Monica`
- `BaseGameSupport.Codex_Characters_Family_Monica_WomensRights`
- `BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished`
- `BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads`
- `GameCondition.Turn08_A_WomensRightsMeeting`
- `GameCondition.Turn08_Decision_LeagueOfWomenDonation`
- `GameCondition.Turn09_Bill_WomensRights`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[31]` | **"“You could've at least told me.”"** | `[30]` **Narrator**: "Right before she made her way ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Monica**: "“I know, but...I just thought yo..." |
| `[32]` | **""How dare you show up here after what we agreed!""** | `[30]` **Narrator**: "Right before she made her way ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Monica**: "“Ciara approached me about it. I..." |
| `[33]` | **"“Explain yourself.""** | `[30]` **Narrator**: "Right before she made her way ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Monica**: "“You know how much I want to hel..." |
| `[35]` | **"“You were damn right. I would say no, and I am saying no.""** | `[34]` **Monica**: "“I know, but...I just thought yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Monica**: "“You know how much I want to hel..." |
| `[36]` | **"“Don't we have any trust in each other anymore?”"** | `[34]` **Monica**: "“I know, but...I just thought yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Monica**: "“You have my trust always. But t..." |
| `[37]` | **"“So you went behind my back to join this meeting?”"** | `[34]` **Monica**: "“I know, but...I just thought yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Monica**: "“Anton, please try to understand..." |
| `[45]` | **"“Ciara needs to learn that she can't interfere with my family.”"** | `[44]` **Monica**: "“So when Ciara asked me to join ..."<br>`[78]` **Monica**: "“Do you think she'd take that fo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Monica**: "“Don't blame her. She just did w..." |
| `[46]` | **"“This doesn't change the fact that you didn't trust me.”"** | `[44]` **Monica**: "“So when Ciara asked me to join ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Monica**: "“I know. And I'm sorry. Will you..." |
| `[47]` | **"“To be honest, I would've done the same if that is what it took to get my word acr..."** | `[44]` **Monica**: "“So when Ciara asked me to join ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Monica**: "“I knew you would understand.”" |
| `[51]` | **"“No.”"** | `[48]` **Monica**: "“I know. And I'm sorry. Will you..."<br>`[81]` **Monica**: "“Can you forgive me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Narrator**: "Monica looked down at the floor,..." |
| `[52]` | **"“If you promise never to surprise me like this again.""** | `[48]` **Monica**: "“I know. And I'm sorry. Will you..."<br>`[81]` **Monica**: "“Can you forgive me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Monica**: "“I promise.”" |
| `[55]` | **"“Yes. I forgive you.”"** | `[48]` **Monica**: "“I know. And I'm sorry. Will you..."<br>`[81]` **Monica**: "“Can you forgive me?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Monica**: "“Thank you, Anton. I will tell y..." |
| `[58]` | **"“All right. Let's discuss this together.”"** | `[57]` **Monica**: "“Please, Anton. Let me stay."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "She hugged me and kissed me on t..." |
| `[59]` | **"“My answer is still no. You will not go into politics.”"** | `[57]` **Monica**: "“Please, Anton. Let me stay."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Monica**: "“But why? This is about Sordish ..." |
| `[61]` | **"“It's simply too dangerous. I don't want you to get hurt.”"** | `[60]` **Monica**: "“But why? This is about Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Monica**: "“I understand the danger, but so..." |
| `[62]` | **"“Don't be naive. Everything comes down to politics in the end.”"** | `[60]` **Monica**: "“But why? This is about Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Monica**: "“I know I don't understand polit..." |
| `[66]` | **"“No canoodling at work, Mrs. First Lady.”"** | `[65]` **Narrator**: "She hugged me and kissed me on t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Monica**: "“Right.”" |
| `[67]` | **"“All right. Can you call Ciara back?”"** | `[65]` **Narrator**: "She hugged me and kissed me on t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Monica**: "“Of course. I'll go get her."" |
| `[76]` | **"“Without asking my permission!?""** | `[75]` **Monica**: "“Ciara approached me about it. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Monica**: "“See, that's why this meeting is..." |
| `[77]` | **""Why didn't you tell her I forbade it?""** | `[75]` **Monica**: "“Ciara approached me about it. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Monica**: "“Do you think she'd take that fo..." |
| `[79]` | **"“Look, I'm sorry for yelling. But we talked about this before and I clearly said i..."** | `[75]` **Monica**: "“Ciara approached me about it. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Monica**: "“I know it was a surprise to you..." |
| `[83]` | **"“What are you going to do? Leave me? You wouldn't dare.""** | `[263]` **Monica**: ""I'm starting to think it wasn't..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[84]` **Monica**: "“Just watch me."" |
| `[86]` | **"“Please don't say that. I'm sorry.”"** | `[263]` **Monica**: ""I'm starting to think it wasn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Monica**: "“There are things at play here t..." |
| `[90]` | **"“Can't you let Ciara do that? She is more experienced.”"** | `[89]` **Monica**: "“I want to be their voice.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Monica**: "“Ciara has the experience, but p..." |
| `[91]` | **"“You don't know how hard it is to be in that position. I'm trying to protect you.”"** | `[89]` **Monica**: "“I want to be their voice.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Monica**: "“I understand that. At least I t..." |
| `[94]` | **"“I'm sorry, but I can't let you do that. Please understand.”"** | `[95]` **Monica**: "“This is my line in the sand, An..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Monica**: "“Then I hope you will understand..." |
| `[96]` | **"“Very well. If it's that important to you, stay.""** | `[95]` **Monica**: "“This is my line in the sand, An..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[101]` **Monica**: "“Thank you, Anton.”" |
| `[107]` | **"“Do you trust me?”"** | `[57]` **Monica**: "“Please, Anton. Let me stay."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Monica**: "“Yes, of course I do.”" |
| `[109]` | **"“Then believe me when I say: don't get involved in politics.""** | `[108]` **Monica**: "“Yes, of course I do.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Monica**: "“But why? This is about Sordish ..." |
| `[110]` | **"“Very well. I will allow it.”"** | `[108]` **Monica**: "“Yes, of course I do.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Narrator**: "She hugged me and kissed me on t..." |
| `[116]` | **"“We are getting close to the elections. I can't handle any possible bad press.”"** | `[60]` **Monica**: "“But why? This is about Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Monica**: "“I know Benfi may have crossed a..." |
| `[118]` | **"“This is my final answer. You will not do it.”"** | `[120]` **Narrator**: "I leaned forward." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Narrator**: "Monica's eyes narrowed." |
| `[119]` | **"“All right. If you are willing to take the risk, I will let you do it.”"** | `[120]` **Narrator**: "I leaned forward." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Monica**: "“I was born ready.”" |
| `[130]` | **"“Anything to make you happy.""** | `[129]` **Monica**: "“I've been dreaming about this e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Monica**: ""Not just me, Anton. All of us."" |
| `[131]` | **"“I think both of you together could finally bring change to Sordland.”"** | `[129]` **Monica**: "“I've been dreaming about this e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Monica**: "“I hope you're right."" |
| `[134]` | **"“I hope you thought this through. Real change requires carefully considered plans.”"** | `[129]` **Monica**: "“I've been dreaming about this e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Monica**: "“We did.”" |
| `[169]` | **"“It feels too much like you're comparing Sordland to other nations. We must choose..."** | `[174]` **Ciara Walda**: "“What are your thoughts so far?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Ciara Walda**: "“I agree completely. We must aim..." |
| `[170]` | **"“You've made a good case for all of these changes.”"** | `[174]` **Ciara Walda**: "“What are your thoughts so far?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Ciara Walda**: "“Thank you.”" |
| `[175]` | **"“I'm not sure I can risk passing laws like these so close to the election.”"** | `[174]` **Ciara Walda**: "“What are your thoughts so far?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Ciara Walda**: "“These laws would result in grea..." |
| `[197]` | **"“Why bother with a commission? I can pass the laws you want here and now.""** | `[196]` **Ciara Walda**: "“The organization's name will be..." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | *Brak zmian stanu* | `[199]` **Ciara Walda**: "“You'll still need to make sure ..." |
| `[198]` | **"“It's going to be damn hard getting your laws past the Assembly.""** | `[196]` **Ciara Walda**: "“The organization's name will be..." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | *Brak zmian stanu* | `[435]` **Narrator**: "Ciara leaned toward me." |
| `[222]` | **"“I'm on your side. But I want to go through the Assembly. Can't risk a backlash th..."** | `[218]` **Narrator**: "I took a few minutes to think." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] ...`<br>`Variable["BaseGame.WomensRightCommission"] = true;`<br>*(+1 skryptów)* | `[460]` **Ciara Walda**: ""You're making a mistake by not ..." |
| `[223]` | **"“I hereby declare your laws passed and your commission established. Good luck." [S..."** | `[218]` **Narrator**: "I took a few minutes to think." | `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....`<br>`Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] = ...` | `[524]` **Narrator**: "Ciara let out a lengthy exhale. ..." |
| `[224]` | **"“I will approve the creation of the commission and support your bill in the Assemb..."** | `[218]` **Narrator**: "I took a few minutes to think." | `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false` | `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] ...`<br>`Variable["BaseGame.WomensRightCommission"] = true;`<br>*(+1 skryptów)* | `[460]` **Ciara Walda**: ""You're making a mistake by not ..." |
| `[247]` | **"“I know. That's why I already signed the decree to give women an equal education.""** | `[129]` **Monica**: "“I've been dreaming about this e..." | `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true` | *Brak zmian stanu* | `[248]` **Monica**: "“Yes, and that was a major step ..." |
| `[249]` | **""What are you doing here?""** | `[26]` **Narrator**: "Monica entered the room and stoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Monica turned to Ciara." |
| `[250]` | **""Ciara, what is she doing here?""** | `[26]` **Narrator**: "Monica entered the room and stoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Monica turned to Ciara." |
| `[251]` | **""No. No! Monica, go home!""** | `[26]` **Narrator**: "Monica entered the room and stoo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "Monica turned to Ciara." |
| `[253]` | **"“Someone has to stay home and look after Deana.”"** | `[60]` **Monica**: "“But why? This is about Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Monica**: "“I'm doing this *for* Deana. And..." |
| `[255]` | **""This isn't about joining a knitting circle or having a friend for tea. It's about..."** | `[82]` **Monica**: "“Why should a wife need her husb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Monica**: ""I had dreams of a career too, b..."<br>`[261]` **Monica**: ""Your career. For which you have..." |
| `[256]` | **""I promise I take women's rights seriously. Just let Ciara handle this.""** | `[82]` **Monica**: "“Why should a wife need her husb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Monica**: "“Ciara has the experience, but p..." |
| `[257]` | **""Because you'll make me look foolish otherwise -- like you did at the Benfi Festiv..."** | `[82]` **Monica**: "“Why should a wife need her husb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Monica**: "“I know Benfi may have crossed a..." |
| `[261]` | **""Your career. For which you have consistently sidelined me and your children.""** | `[255]` **Player**: ""This isn't about joining a knit..." | `(Variable["BaseGame.Prologue_Family_Important"] == true) == false` | *Brak zmian stanu* | `[262]` **Monica**: ""I had dreams of a career too, b..." |
| `[262]` | **""I had dreams of a career too, back in university. But I gave those up for you.""** | `[261]` **Monica**: ""Your career. For which you have..."<br>`[255]` **Player**: ""This isn't about joining a knit..." | `Variable["BaseGame.Prologue_Family_Important"] == true` | *Brak zmian stanu* | `[263]` **Monica**: ""I'm starting to think it wasn't..." |
| `[263]` | **""I'm starting to think it wasn't worth it.""** | `[262]` **Monica**: ""I had dreams of a career too, b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Player**: "“What are you going to do? Leave..."<br>`[264]` **Player**: "“I gave you a life most woman ca..."<br>*(oraz 1 innych odgałęzień)* |
| `[264]` | **"“I gave you a life most woman can only dream of, and this is how you thank me?”"** | `[263]` **Monica**: ""I'm starting to think it wasn't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Monica**: "“There are things at play here t..." |
| `[271]` | **"“It's for her own good.”"** | `[267]` **Narrator**: "She shot me a sharp, meaningful ..."<br>`[19]` **Ciara Walda**: ""It's a pity your wife won't be ..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[140]` **Ciara Walda**: "“Not a particularly auspicious s..." |
| `[272]` | **"“This is between Monica and myself. Stay out of it.”"** | `[267]` **Narrator**: "She shot me a sharp, meaningful ..."<br>`[19]` **Ciara Walda**: ""It's a pity your wife won't be ..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[140]` **Ciara Walda**: "“Not a particularly auspicious s..." |
| `[273]` | **""Monica would only be a liability to your cause.”"** | `[267]` **Narrator**: "She shot me a sharp, meaningful ..."<br>`[19]` **Ciara Walda**: ""It's a pity your wife won't be ..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[140]` **Ciara Walda**: "“Not a particularly auspicious s..." |
| `[274]` | **""Be thankful I'm not firing you for approaching her behind my back.”"** | `[267]` **Narrator**: "She shot me a sharp, meaningful ..."<br>`[19]` **Ciara Walda**: ""It's a pity your wife won't be ..." | `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false` | *Brak zmian stanu* | `[140]` **Ciara Walda**: "“Not a particularly auspicious s..." |
| `[285]` | **""Criminalizing domestic violence.""** | `[334]` **Ciara Walda**: ""We can discuss the particulars ..."<br>`[335]` **Ciara Walda**: ""I assure you it is. But I'll gi..."<br>*(oraz 9 innych węzłów)* | `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false`<br>`(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false` | *Brak zmian stanu* | `[304]` **Ciara Walda**: ""I shouldn't have to tell you ho..." |
| `[286]` | **""Support for working mothers.""** | `[334]` **Ciara Walda**: ""We can discuss the particulars ..."<br>`[335]` **Ciara Walda**: ""I assure you it is. But I'll gi..."<br>*(oraz 9 innych węzłów)* | `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false`<br>`(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false` | *Brak zmian stanu* | `[337]` **Narrator**: "Ciara nodded." |
| `[287]` | **""Equal treatment in the workforce.""** | `[334]` **Ciara Walda**: ""We can discuss the particulars ..."<br>`[335]` **Ciara Walda**: ""I assure you it is. But I'll gi..."<br>*(oraz 9 innych węzłów)* | `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false`<br>`(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false` | *Brak zmian stanu* | `[366]` **Monica**: ""That's an easy one.""<br>`[367]` **Ciara Walda**: ""Right now, Sordland has one of ..." |
| `[288]` | **""Gender equality in public education.""** | `[334]` **Ciara Walda**: ""We can discuss the particulars ..."<br>`[335]` **Ciara Walda**: ""I assure you it is. But I'll gi..."<br>*(oraz 9 innych węzłów)* | `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false`<br>`(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false` | *Brak zmian stanu* | `[398]` **Narrator**: "Ciara grinned." |
| `[309]` | **""I agree. It's a travesty.""** | `[305]` **Narrator**: "Ciara looked at me closely, as i..."<br>`[304]` **Ciara Walda**: ""I shouldn't have to tell you ho..." | `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[314]` **Monica**: ""I'm happy we're on the same page.""<br>`[361]` **Ciara Walda**: ""I'm happy you agree. In theory,..."<br>*(oraz 1 innych odgałęzień)* |
| `[310]` | **""What families do in their own homes is none of our concern.""** | `[305]` **Narrator**: "Ciara looked at me closely, as i..."<br>`[304]` **Ciara Walda**: ""I shouldn't have to tell you ho..." | `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false` | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[317]` **Narrator**: "Ciara looked disgusted."<br>`[316]` **Narrator**: "Monica and Ciara both looked dis..." |
| `[323]` | **""Interfering in Bludish matters has landed us in enough trouble already.""** | `[322]` **Ciara Walda**: ""Monica, I'm surprised at you! W..."<br>`[319]` **Ciara Walda**: ""As incidences are especially hi..." | `Variable["BaseGame.Bludish_Opinion"] < 1`<br>`(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[334]` **Ciara Walda**: ""We can discuss the particulars ..." |
| `[327]` | **""The Bluds have their own ways of settling these issues.""** | `[322]` **Ciara Walda**: ""Monica, I'm surprised at you! W..."<br>`[319]` **Ciara Walda**: ""As incidences are especially hi..." | `(Variable["BaseGame.Bludish_Opinion"] < 1) == false`<br>`(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[334]` **Ciara Walda**: ""We can discuss the particulars ..." |
| `[328]` | **""We should lift up all Sordish women, Bluds included.""** | `[322]` **Ciara Walda**: ""Monica, I'm surprised at you! W..."<br>`[319]` **Ciara Walda**: ""As incidences are especially hi..." | `(Variable["BaseGame.Bludish_Opinion"] < 1) == false`<br>`(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[334]` **Ciara Walda**: ""We can discuss the particulars ..." |
| `[329]` | **""The Bluds must conform to Sordish law.""** | `[322]` **Ciara Walda**: ""Monica, I'm surprised at you! W..."<br>`[319]` **Ciara Walda**: ""As incidences are especially hi..." | `Variable["BaseGame.Bludish_Opinion"] < 1`<br>`(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[334]` **Ciara Walda**: ""We can discuss the particulars ..." |
| `[330]` | **""I'm still not sure criminalizing domestic violence is a good idea. For the Bluds ..."** | `[322]` **Ciara Walda**: ""Monica, I'm surprised at you! W..."<br>`[319]` **Ciara Walda**: ""As incidences are especially hi..." | `Variable["BaseGame.Bludish_Opinion"] < 1`<br>`(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[335]` **Ciara Walda**: ""I assure you it is. But I'll gi..." |
| `[344]` | **""I don't want to reward women for choosing work over raising their children.""** | `[343]` **Ciara Walda**: ""Paid maternity leave and state-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Ciara Walda**: ""What about women who have to wo..." |
| `[345]` | **""It's true -- having children never hindered my career prospects. It shouldn't hin..."** | `[343]` **Ciara Walda**: ""Paid maternity leave and state-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Ciara Walda**: ""Exactly."" |
| `[346]` | **""I'll have to think about this.""** | `[343]` **Ciara Walda**: ""Paid maternity leave and state-..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Ciara Walda**: ""Please do. Moving on."" |
| `[350]` | **""Monica, you always said you never regretted giving up a career to raise Franc and..."** | `[343]` **Ciara Walda**: ""Paid maternity leave and state-..." | `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true` | *Brak zmian stanu* | `[351]` **Monica**: ""Anton, I never had a choice."" |
| `[376]` | **""Quotas are a terrible idea. People should be hired on merit, not simply because o..."** | `[374]` **Ciara Walda**: ""Women are starving because they..."<br>`[375]` **Ciara Walda**: ""A quota for women in positions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Narrator**: "Monica and Ciara looked at me st..."<br>`[393]` **Narrator**: "Ciara looked at me strangely." |
| `[377]` | **""I don't see a problem with quotas, but tackling the pay gap is much more urgent.""** | `[374]` **Ciara Walda**: ""Women are starving because they..."<br>`[375]` **Ciara Walda**: ""A quota for women in positions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Narrator**: "Monica gritted her teeth."<br>`[380]` **Narrator**: "Ciara smiled." |
| `[378]` | **""Quotas seem far easier to implement than equal pay laws. We should start there.""** | `[374]` **Ciara Walda**: ""Women are starving because they..."<br>`[375]` **Ciara Walda**: ""A quota for women in positions ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Narrator**: "Ciara gritted her teeth." |
| `[408]` | **""We can't force schools what to teach to whom.""** | `[407]` **Monica**: ""Imagine Franc in an apron!""<br>`[400]` **Ciara Walda**: ""The way girls are shut out of a..." | `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[418]` **Ciara Walda**: ""We can if not doing so puts us ..."<br>`[419]` **Ciara Walda**: ""We can if not doing so puts us ..." |
| `[409]` | **""Yes, we've had this conversation. I'm entirely on your side.""** | `[400]` **Ciara Walda**: ""The way girls are shut out of a..." | `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[420]` **Ciara Walda**: ""Good. Then we see eye to eye on..." |
| `[410]` | **""But Deana loves her handicrafts classes.""** | `[400]` **Ciara Walda**: ""The way girls are shut out of a..." | `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false` | *Brak zmian stanu* | `[411]` **Ciara Walda**: ""I'm not saying we'll take those..." |
| `[412]` | **""We've had this conversation, Ciara. I'm entirely on your side.""** | `[407]` **Monica**: ""Imagine Franc in an apron!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Ciara Walda**: ""Good. Then we see eye to eye on..." |
| `[413]` | **""My voters won't want to see their sons in an apron.""** | `[411]` **Ciara Walda**: ""I'm not saying we'll take those..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Ciara Walda**: ""But maybe they'll want to see t..." |
| `[414]` | **""You've got a point.""** | `[411]` **Ciara Walda**: ""I'm not saying we'll take those..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Ciara Walda**: ""Good. Then we see eye to eye on..." |
| `[433]` | **"“It's going to be damn hard getting your laws past the Assembly.""** | `[196]` **Ciara Walda**: "“The organization's name will be..." | `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false` | *Brak zmian stanu* | `[443]` **Ciara Walda**: ""I know. But even a watered-down..." |
| `[434]` | **""What do you need a commission for? I'll run your laws past the Assembly.""** | `[196]` **Ciara Walda**: "“The organization's name will be..." | `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false` | *Brak zmian stanu* | `[445]` **Ciara Walda**: ""Even if that's successful, you'..." |
| `[437]` | **""What exactly is going on between you and Mrs. Morgna, anyway?""** | `[436]` **Ciara Walda**: ""Nia would kill me for saying th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Narrator**: "She shrugged uncomfortably." |
| `[440]` | **""I'll be the judge of that.""** | `[436]` **Ciara Walda**: ""Nia would kill me for saying th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Ciara Walda**: "“Mr. President, I know we've had..."<br>`[202]` **Ciara Walda**: "“Mr. President, I know we've had..."<br>*(oraz 1 innych odgałęzień)* |
| `[441]` | **""Look who's suddenly off her moral high horse.""** | `[436]` **Ciara Walda**: ""Nia would kill me for saying th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Ciara Walda**: ""If it's for the greater good, I..." |
| `[442]` | **""You're right. The Assembly would only pass a weak version of these laws, if at all.""** | `[436]` **Ciara Walda**: ""Nia would kill me for saying th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Ciara Walda**: "“Mr. President, I know we've had..."<br>`[202]` **Ciara Walda**: "“Mr. President, I know we've had..."<br>*(oraz 1 innych odgałęzień)* |
| `[453]` | **""I've already given women equal access to education. I want to see how that decisi..."** | `[218]` **Narrator**: "I took a few minutes to think." | `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`<br>`Variable["BaseGame.Policy_Law_Decree_Stronger"] == true` | *Brak zmian stanu* | `[481]` **Narrator**: "Ciara folded her arms." |
| `[454]` | **""Sorry, but the answer is no. You can try and run your laws by the Assembly, but t..."** | `[218]` **Narrator**: "I took a few minutes to think." | `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false` | *Brak zmian stanu* | `[226]` **Ciara Walda**: "“Then all is lost for the future..." |

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
  - -> `[18]` (*Narrator: "I was sitting in my office. I looked at the clock."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Monica entered the room and stood next to Ciara."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_P_SupportedMonicaAtConfrontation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Monica entered the room and stood next to Ciara. I was co..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "After a couple of knocks at the door, Ciara entered the r..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "There was a knock at the door. Ciara entered the room wit..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Ciara Walda: "“One more thing to consider before making your decision. ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_PetrSelfResigned == true || BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Turn08_SecondScandal_PetrTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrSelfResigned"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Turn08_SecondScandal_PetrTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_DenyEverything == true"*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_DenyEverything == true)"*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_DenyEverything == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Ciara Walda: "“One more thing to consider before making your decision. ..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_DenyEverything == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_DenyEverything"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionNotMandatory == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionNotMandatory == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EvolutionNotMandatory == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionNotMandatory == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Ciara Walda: "“Mr. President, I know we've had friction in the past. Bu..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EvolutionNotMandatory == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I was sitting in my office. I looked at the clock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "2:26 PM. It was almost time for my appointment with Ciara..."*)

### Węzeł `[19]`
Mówca: **Ciara Walda**
> ""It's a pity your wife won't be joining us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FailedEducationReform == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Ciara Walda: "“Mr. President, I know we've had friction in the past. Bu..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FailedEducationReform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionNotMandatory == true"*)

### Węzeł `[23]`
Mówca: **Narrator**
> "2:26 PM. It was almost time for my appointment with Ciara on women's rights."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "There was a knock at the door. Ciara entered the room with folders in her hand. The door did not close behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_P_SupportedMonicaAtConfrontation == true"*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Monica entered the room and stood next to Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Ciara Walda: "“Mr. President.”"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Monica entered the room and stood next to Ciara. I was confused. This was the opposite of what we had agreed after the Benfi Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player: ""What are you doing here?""*)
  - -> `[250]` (*Player: ""Ciara, what is she doing here?""*)
  - -> `[251]` (*Player: ""No. No! Monica, go home!""*)

### Węzeł `[27]`
Mówca: **Narrator**
> "Monica turned to Ciara."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Monica: "“Could you give us a minute?”"*)

### Węzeł `[28]`
Mówca: **Monica**
> "“Could you give us a minute?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Ciara Walda: "“Of course.”"*)

### Węzeł `[29]`
Mówca: **Ciara Walda**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Right before she made her way out, her eyes met with Moni..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Right before she made her way out, her eyes met with Monica's and the two women exchanged nods. The door closed, leaving Monica and me alone in the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: ""How dare you show up here after what we agreed!""*)
  - -> `[33]` (*Player: "“Explain yourself.""*)
  - -> `[31]` (*Player: "“You could've at least told me.”"*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“You could've at least told me.”"]** — Mówca: **Player**
> "“You could've at least told me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Monica: "“I know, but...I just thought you would say no again.”"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: ""How dare you show up here after what we agreed!""]** — Mówca: **Player**
> ""How dare you show up here after what we agreed!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Monica: "“Ciara approached me about it. I had to accept.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Explain yourself.""]** — Mówca: **Player**
> "“Explain yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Monica: "“You know how much I want to help women in Sordland. I ha..."*)

### Węzeł `[34]`
Mówca: **Monica**
> "“I know, but...I just thought you would say no again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: "“You were damn right. I would say no, and I am saying no.""*)
  - -> `[37]` (*Player: "“So you went behind my back to join this meeting?”"*)
  - -> `[36]` (*Player: "“Don't we have any trust in each other anymore?”"*)

### Węzeł `[35]`
**[WYBÓR GRACZA: "“You were damn right. I would say no, and I am saying no.""]** — Mówca: **Player**
> "“You were damn right. I would say no, and I am saying no.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Monica: "“You know how much I want to help women in Sordland. I ha..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Don't we have any trust in each other anymore?”"]** — Mówca: **Player**
> "“Don't we have any trust in each other anymore?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Monica: "“You have my trust always. But this is a greater cause th..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“So you went behind my back to join this meeting?”"]** — Mówca: **Player**
> "“So you went behind my back to join this meeting?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Monica: "“Anton, please try to understand. I wouldn't do this if I..."*)

### Węzeł `[38]`
Mówca: **Monica**
> "“You know how much I want to help women in Sordland. I had an opportunity and I couldn't let it pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: "“You also know how stubborn I am. Once I set my mind on s..."*)

### Węzeł `[39]`
Mówca: **Monica**
> "“You also know how stubborn I am. Once I set my mind on something, I won't budge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“So when Ciara asked me to join her today, I had to accept.""*)

### Węzeł `[40]`
Mówca: **Monica**
> "“You have my trust always. But this is a greater cause than just the two of us. I wouldn't have done this if I didn't believe that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“We finally have the chance to change things for Sordish ..."*)

### Węzeł `[41]`
Mówca: **Monica**
> "“We finally have the chance to change things for Sordish women. There's no way I was going to let that opportunity pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“So when Ciara asked me to join her today, I had to accept.""*)

### Węzeł `[42]`
Mówca: **Monica**
> "“Anton, please try to understand. I wouldn't do this if I didn't think this was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Monica: "“We're at a place where we can finally change the status ..."*)

### Węzeł `[43]`
Mówca: **Monica**
> "“We're at a place where we can finally change the status of Sordish women. I couldn't let this opportunity pass.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“So when Ciara asked me to join her today, I had to accept.""*)

### Węzeł `[44]`
Mówca: **Monica**
> "“So when Ciara asked me to join her today, I had to accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“Ciara needs to learn that she can't interfere with my fa..."*)
  - -> `[47]` (*Player: "“To be honest, I would've done the same if that is what i..."*)
  - -> `[46]` (*Player: "“This doesn't change the fact that you didn't trust me.”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Ciara needs to learn that she can't interfere with my family.”"]** — Mówca: **Player**
> "“Ciara needs to learn that she can't interfere with my family.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Monica), `[78]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: "“Don't blame her. She just did what was necessary for the..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: "“This doesn't change the fact that you didn't trust me.”"]** — Mówca: **Player**
> "“This doesn't change the fact that you didn't trust me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Monica: "“I know. And I'm sorry. Will you...will you forgive me?”"*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“To be honest, I would've done the same if that is what it took to get my word across.”"]** — Mówca: **Player**
> "“To be honest, I would've done the same if that was what it took to get my word across.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Monica: "“I knew you would understand.”"*)

### Węzeł `[48]`
Mówca: **Monica**
> "“I know. And I'm sorry. Will you...will you forgive me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“No.”"*)
  - -> `[52]` (*Player: "“If you promise never to surprise me like this again.""*)
  - -> `[55]` (*Player: "“Yes. I forgive you.”"*)

### Węzeł `[49]`
Mówca: **Monica**
> "“Don't blame her. She just did what was necessary for the future of Sordish women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“Please, Anton. Let me stay.""*)

### Węzeł `[50]`
Mówca: **Monica**
> "“I knew you would understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“Please, Anton. Let me stay.""*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“No.”"]** — Mówca: **Player**
> "“No.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Monica), `[81]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "Monica looked down at the floor, then back up at me."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“If you promise never to surprise me like this again.""]** — Mówca: **Player**
> "“If you promise never to surprise me like this again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Monica), `[81]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Monica: "“I promise.”"*)

### Węzeł `[53]`
Mówca: **Monica**
> "“I promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Her eyes were shining."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "Her eyes were shining."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“Yes. I forgive you.”"]** — Mówca: **Player**
> "“Yes. I forgive you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Monica), `[81]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Monica: "“Thank you, Anton. I will tell you everything from now on.”"*)

### Węzeł `[56]`
Mówca: **Monica**
> "“Thank you, Anton. I will tell you everything from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "Her eyes were shining."*)

### Węzeł `[57]`
Mówca: **Monica**
> "“Please, Anton. Let me stay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: "“All right. Let's discuss this together.”"*)
  - -> `[107]` (*Player: "“Do you trust me?”"*)
  - -> `[59]` (*Player: "“My answer is still no. You will not go into politics.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“All right. Let's discuss this together.”"]** — Mówca: **Player**
> "“All right. Let's discuss this together.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "She hugged me and kissed me on the cheek."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“My answer is still no. You will not go into politics.”"]** — Mówca: **Player**
> "“My answer is still no. You will not go into politics.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Monica: "“But why? This is about Sordish women. This is bigger tha..."*)

### Węzeł `[60]`
Mówca: **Monica**
> "“But why? This is about Sordish women. This is bigger than just politics.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: "“We are getting close to the elections. I can't handle an..."*)
  - -> `[62]` (*Player: "“Don't be naive. Everything comes down to politics in the..."*)
  - -> `[61]` (*Player: "“It's simply too dangerous. I don't want you to get hurt.”"*)
  - -> `[253]` (*Player: "“Someone has to stay home and look after Deana.”"*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“It's simply too dangerous. I don't want you to get hurt.”"]** — Mówca: **Player**
> "“It's simply too dangerous. I don't want you to get hurt.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Monica: "“I understand the danger, but someone has to do it.”"*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Don't be naive. Everything comes down to politics in the end.”"]** — Mówca: **Player**
> "“Don't be naive. Everything comes down to politics in the end.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Monica: "“I know I don't understand politics the way you and Ciara..."*)

### Węzeł `[63]`
Mówca: **Monica**
> "“I understand the danger, but someone has to do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I leaned forward."*)

### Węzeł `[64]`
Mówca: **Monica**
> "“Right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Monica: "“I'll fetch Ciara so we can get started.""*)

### Węzeł `[65]`
Mówca: **Narrator**
> "She hugged me and kissed me on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "“No canoodling at work, Mrs. First Lady.”"*)
  - -> `[67]` (*Player: "“All right. Can you call Ciara back?”"*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“No canoodling at work, Mrs. First Lady.”"]** — Mówca: **Player**
> "“No canoodling at work, Mrs. First Lady.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Monica: "“Right.”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“All right. Can you call Ciara back?”"]** — Mówca: **Player**
> "“All right. Can you call Ciara back?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Monica: "“Of course. I'll go get her.""*)

### Węzeł `[68]`
Mówca: **Monica**
> "“I'll fetch Ciara so we can get started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Monica left the office and returned with Ciara. Both wome..."*)

### Węzeł `[69]`
Mówca: **Monica**
> "“Of course. I'll go get her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Monica left the office and returned with Ciara. Both wome..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Monica left the office and returned with Ciara. Both women were smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Ciara Womens Rights Monica Feedback`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Ciara Walda: ""It's a pity your wife won't be joining us.""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Womens Rights Discussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Womens Rights Discussion"*)

### Węzeł `[73]`
Mówca: **Monica**
> "“I know I don't understand politics the way you and Ciara do. But my role would be that of a spokeswoman. That's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I leaned forward."*)

### Węzeł `[74]`
Mówca: **Monica**
> "“You know how much I want to help women in Sordland. I had an opportunity, and I couldn't let it pass.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“So when Ciara asked me to join her today, I had to accept.""*)

### Węzeł `[75]`
Mówca: **Monica**
> "“Ciara approached me about it. I had to accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“Without asking my permission!?""*)
  - -> `[77]` (*Player: ""Why didn't you tell her I forbade it?""*)
  - -> `[79]` (*Player: "“Look, I'm sorry for yelling. But we talked about this be..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Without asking my permission!?""]** — Mówca: **Player**
> "“Without asking my permission!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Monica: "“See, that's why this meeting is so necessary!""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Why didn't you tell her I forbade it?""]** — Mówca: **Player**
> ""Why didn't you tell her I forbade it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: "“Do you think she'd take that for an answer?""*)

### Węzeł `[78]`
Mówca: **Monica**
> "“Do you think she'd take that for an answer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Player: "“Ciara needs to learn that she can't interfere with my fa..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Look, I'm sorry for yelling. But we talked about this before and I clearly said it would be a bad idea.""]** — Mówca: **Player**
> "“Look, I'm sorry for yelling. But we talked about this before and I clearly said it would be a bad idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Monica: "“I know it was a surprise to you. I'm sorry. I will tell ..."*)

### Węzeł `[80]`
Mówca: **Monica**
> "“I know it was a surprise to you. I'm sorry. I will tell you everything from now on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Monica: "“Can you forgive me?""*)

### Węzeł `[81]`
Mówca: **Monica**
> "“Can you forgive me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player: "“No.”"*)
  - -> `[52]` (*Player: "“If you promise never to surprise me like this again.""*)
  - -> `[55]` (*Player: "“Yes. I forgive you.”"*)

### Węzeł `[82]`
Mówca: **Monica**
> "“Why should a wife need her husband's permission to do something?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player: ""This isn't about joining a knitting circle or having a f..."*)
  - -> `[256]` (*Player: ""I promise I take women's rights seriously. Just let Ciar..."*)
  - -> `[257]` (*Player: ""Because you'll make me look foolish otherwise -- like yo..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“What are you going to do? Leave me? You wouldn't dare.""]** — Mówca: **Player**
> "“What are you going to do? Leave me? You wouldn't dare.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 5;"*)

### Węzeł `[84]`
Mówca: **Monica**
> "“Just watch me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "She walked to the door and wrenched it open. She walked a..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "She walked to the door and wrenched it open. She walked away and closed the door with a loud slam."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "“Please don't say that. I'm sorry.”"]** — Mówca: **Player**
> "“Please don't say that. I'm sorry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Monica: "“There are things at play here that are greater than just..."*)

### Węzeł `[87]`
Mówca: **Monica**
> "“There are things at play here that are greater than just us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: "“Look. I will be blunt. If you want to remain happily mar..."*)

### Węzeł `[88]`
Mówca: **Monica**
> "“Look. I will be blunt. If you want to remain happily married, you will let me do this. I need this. Sordish women need this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Monica: "“I want to be their voice.”"*)

### Węzeł `[89]`
Mówca: **Monica**
> "“I want to be their voice.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“You don't know how hard it is to be in that position. I'..."*)
  - -> `[90]` (*Player: "“Can't you let Ciara do that? She is more experienced.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Can't you let Ciara do that? She is more experienced.”"]** — Mówca: **Player**
> "“Can't you let Ciara do that? She is more experienced.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Monica: "“Ciara has the experience, but people think she's a radic..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“You don't know how hard it is to be in that position. I'm trying to protect you.”"]** — Mówca: **Player**
> "“You don't know how hard it is to be in that position. I'm trying to protect you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Monica: "“I understand that. At least I think I do. But I really n..."*)

### Węzeł `[92]`
Mówca: **Monica**
> "“I understand that. At least I think I do. But I really need to do this. For my own dignity as a Sordish woman and to root out the evil inside people like Curtan Leste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“This is my line in the sand, Anton. Now that I'm here, I..."*)

### Węzeł `[93]`
Mówca: **Monica**
> "“Ciara has the experience, but people think she's a radical, and un-feminine at that. She's not popular enough with the public to get this message across. I am.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“This is my line in the sand, Anton. Now that I'm here, I..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“I'm sorry, but I can't let you do that. Please understand.”"]** — Mówca: **Player**
> "“I'm sorry, but I can't let you do that. Please understand.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Monica: "“Then I hope you will understand this.”"*)

### Węzeł `[95]`
Mówca: **Monica**
> "“This is my line in the sand, Anton. Now that I'm here, I won't back down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“I'm sorry, but I can't let you do that. Please understand.”"*)
  - -> `[96]` (*Player: "“Very well. If it's that important to you, stay.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“Very well. If it's that important to you, stay.""]** — Mówca: **Player**
> "“Very well. If it's that important to you, stay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 2;"*)

### Węzeł `[97]`
Mówca: **Monica**
> "“Then I hope you will understand this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Before I could say anything, she got up and left my office."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Before I could say anything, she got up and left my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Divorce = true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "I stood in silence for a few minutes, contemplating what ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Divorce = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Divorce"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "I stood there for a few minutes as I contemplated what ha..."*)

### Węzeł `[101]`
Mówca: **Monica**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Monica: "“I'll go fetch Ciara so we can get started.”"*)

### Węzeł `[102]`
Mówca: **Monica**
> "“I'll go fetch Ciara so we can get started.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Monica briefly left the office and returned with Ciara. T..."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Monica briefly left the office and returned with Ciara. The two women were smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Womens Rights Discussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Womens Rights Discussion"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ciara Womens Rights Monica Feedback]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Ciara Womens Rights Monica Feedback"*)

### Węzeł `[106]`
Mówca: **Narrator**
> "Monica looked down at the floor, then back up at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Do you trust me?”"]** — Mówca: **Player**
> "“Do you trust me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Monica: "“Yes, of course I do.”"*)

### Węzeł `[108]`
Mówca: **Monica**
> "“Yes, of course I do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Very well. I will allow it.”"*)
  - -> `[109]` (*Player: "“Then believe me when I say: don't get involved in politi..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Then believe me when I say: don't get involved in politics.""]** — Mówca: **Player**
> "“Then believe me when I say: don't get involved in politics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Monica: "“But why? This is about Sordish women. This is bigger tha..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Very well. I will allow it.”"]** — Mówca: **Player**
> "“Very well. I will allow it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "She hugged me and kissed me on the cheek."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "I stood there for a few minutes as I contemplated what had just happened. Eventually, Ciara knocked and entered my office again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ciara Womens Rights Monica Feedback]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Ciara Womens Rights Monica Feedback"*)

### Węzeł `[113]`
Mówca: **Narrator**
> "I stood in silence for a few minutes, contemplating what had just happened, Eventually, Ciara knocked and entered my office again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "Monica left the office. A short time later, Ciara knocked on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights ..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ciara Womens Rights Monica Feedback]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Ciara Womens Rights Monica Feedback"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“We are getting close to the elections. I can't handle any possible bad press.”"]** — Mówca: **Player**
> "“We are getting close to the elections. I can't handle any possible bad press.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Monica: "“I know Benfi may have crossed a line, but this is differ..."*)

### Węzeł `[117]`
Mówca: **Monica**
> "“I know Benfi may have crossed a line, but this is different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I leaned forward."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“This is my final answer. You will not do it.”"]** — Mówca: **Player**
> "“This is my final answer. You will not do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Monica's eyes narrowed."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“All right. If you are willing to take the risk, I will let you do it.”"]** — Mówca: **Player**
> "“All right. If you are willing to take the risk, I will let you do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Monica: "“I was born ready.”"*)

### Węzeł `[120]`
Mówca: **Narrator**
> "I leaned forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“All right. If you are willing to take the risk, I will l..."*)
  - -> `[118]` (*Player: "“This is my final answer. You will not do it.”"*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Monica's eyes narrowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Monica: ""All right.""*)

### Węzeł `[122]`
Mówca: **Monica**
> ""All right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true ..."*)

### Węzeł `[123]`
Mówca: **Monica**
> "“I was born ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "She hugged me and kissed me on the cheek."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "She made her way to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Monica: ""I'll fetch Ciara so you two can get on with your business.""*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_ConvincedNotToLeadWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[126]`
Mówca: **Monica**
> "“Anton, before we start...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: "“I just wanted to thank you for agreeing to this meeting.""*)

### Węzeł `[127]`
Mówca: **Monica**
> "“I just wanted to thank you for agreeing to this meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Monica: "“I've been dreaming about this ever since I volunteered w..."*)

### Węzeł `[128]`
Mówca: **Ciara Walda**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Monica: "“Anton, before we start...”"*)

### Węzeł `[129]`
Mówca: **Monica**
> "“I've been dreaming about this ever since I volunteered with the Sordish League of Women. I can't believe the moment's finally here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“Anything to make you happy.""*)
  - -> `[131]` (*Player: "“I think both of you together could finally bring change ..."*)
  - -> `[134]` (*Player: "“I hope you thought this through. Real change requires ca..."*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Anything to make you happy.""]** — Mówca: **Player**
> "“Anything to make you happy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Monica: ""Not just me, Anton. All of us.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I think both of you together could finally bring change to Sordland.”"]** — Mówca: **Player**
> "“I think both of you together could finally bring change to Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Monica: "“I hope you're right.""*)

### Węzeł `[132]`
Mówca: **Monica**
> "“I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[133]`
Mówca: **Monica**
> ""Not just me, Anton. All of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“I hope you thought this through. Real change requires carefully considered plans.”"]** — Mówca: **Player**
> "“I hope you thought this through. Real change requires carefully considered plans.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Monica: "“We did.”"*)

### Węzeł `[135]`
Mówca: **Monica**
> "“We did.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Womens Rights Discussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Womens Rights Discussion"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "After a couple of knocks at the door, Ciara entered the room with folders in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Ciara Walda: "“Mr. President.”"*)

### Węzeł `[138]`
Mówca: **Ciara Walda**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ciara Womens Rights Monica Feedback]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "Ciara Womens Rights Monica Feedback"*)

### Węzeł `[140]`
Mówca: **Ciara Walda**
> "“Not a particularly auspicious start to this meeting. But let's begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "Jump to: [Womens Rights Discussion]"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ciara Womens Rights Monica Feedback]"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [Womens Rights Discussion]"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ciara Womens Rights Monica Feedback]"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ciara Womens Rights Monica Feedback]"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "Jump to: [Womens Rights Discussion]"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "Jump to: [Womens Rights Discussion]"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ciara Womens Rights Monica Feedback]"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Womens Rights Discussion`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Ciara sat down on a chair and laid down the folder she wa..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Womens Rights Discussion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "Womens Rights Discussion"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“Why bother with a commission? I can pass the laws you wa..."*)
  - -> `[198]` (*Player: "“It's going to be damn hard getting your laws past the As..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Player: "“It's going to be damn hard getting your laws past the As..."*)
  - -> `[434]` (*Player: ""What do you need a commission for? I'll run your laws pa..."*)

### Węzeł `[153]`
Mówca: **Ciara Walda**
> "“And this isn't only a moral issue. I have seen enough revolutions in this world to understand the main driver of any change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Ciara Walda: "“Money.”"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Ciara sat down on a chair and laid down the folder she was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "She flipped a folder open and started pulling out documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Ciara Walda: "“In United Contana, law dictates that women earn the same..."*)

### Węzeł `[156]`
Mówca: **Ciara Walda**
> "“In United Contana, law dictates that women earn the same wages as men in their respective fields. My research shows that this led to a 15.5% increase in productivity. You could say this had a direct influence on their superpower status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Ciara Walda: ""Arcasia passed laws ensuring maternity leave rights, chi..."*)

### Węzeł `[157]`
Mówca: **Ciara Walda**
> ""Arcasia passed laws ensuring maternity leave rights, child day care centers and tax deductions for working families. In turn, they experienced a 12.6% productivity boost and a flourishing economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Ciara Walda: "“Both countries also have significantly lower infant mort..."*)

### Węzeł `[158]`
Mówca: **Ciara Walda**
> "“Both countries also have significantly lower infant mortality rates, a statistic I believe is directly linked to the improved status of women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy > 6"*)

### Węzeł `[159]`
Mówca: **Ciara Walda**
> "“Our administration has successfully managed to pull Sordland back from the brink of economic ruin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "She leaned back in her chair."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy > 6"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy > 6)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy > 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] > 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Ciara Walda: "“Our administration has successfully managed to pull Sord..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy > 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] > 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Ciara Walda: "“Our administration has thus far failed to pull Sordland ..."*)

### Węzeł `[163]`
Mówca: **Ciara Walda**
> "“Our administration has thus far failed to pull Sordland out of its economic recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "She leaned back in her chair."*)

### Węzeł `[164]`
Mówca: **Ciara Walda**
> "“So I am asking: Why stop there? Why not improve our economy and modernize our society at the same time?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ciara Walda: "“It's only logical.""*)

### Węzeł `[165]`
Mówca: **Ciara Walda**
> "“So I am asking: Why not try passing similar laws? At worst, even if they fail to improve the economy, it'll still be a significant step forward for our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Ciara Walda: "“It's only logical.""*)

### Węzeł `[166]`
Mówca: **Narrator**
> "She leaned back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Ciara Walda: "“So I am asking: Why stop there? Why not improve our econ..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "She leaned back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Ciara Walda: "“So I am asking: Why not try passing similar laws? At wor..."*)

### Węzeł `[168]`
Mówca: **Ciara Walda**
> "“It's only logical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“It feels too much like you're comparing Sordland to other nations. We must choose our own path.”"]** — Mówca: **Player**
> "“It feels too much like you're comparing Sordland to other nations. We must choose our own path.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Ciara Walda: "“I agree completely. We must aim to be better than them. ..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“You've made a good case for all of these changes.”"]** — Mówca: **Player**
> "“You've made a good case for all of these changes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Ciara Walda: "“Thank you.”"*)

### Węzeł `[171]`
Mówca: **Ciara Walda**
> "“I want to establish a commission for women's rights in Sordland with me as its head. Our goal shall be passing and implementing a set of laws to solve the problems we just discussed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Ciara handed me one of the documents. It had a list of bullet points on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Ciara Walda: ""These are the measures I believe are most urgently needed.""*)

### Węzeł `[173]`
Mówca: **Monica**
> "“Or even as their counterparts in Arcasia and United Contana. We've been lagging behind on this for decades, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Ciara Walda: "“And this isn't only a moral issue. I have seen enough re..."*)

### Węzeł `[174]`
Mówca: **Ciara Walda**
> "“What are your thoughts so far?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player: "“You've made a good case for all of these changes.”"*)
  - -> `[175]` (*Player: "“I'm not sure I can risk passing laws like these so close..."*)
  - -> `[169]` (*Player: "“It feels too much like you're comparing Sordland to othe..."*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“I'm not sure I can risk passing laws like these so close to the election.”"]** — Mówca: **Player**
> "“I'm not sure I can risk passing laws like these so close to the election.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Ciara Walda: "“These laws would result in greater productivity, a bette..."*)

### Węzeł `[176]`
Mówca: **Ciara Walda**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Ciara Walda: "“If we can pull this off before the elections, the Rayne ..."*)

### Węzeł `[177]`
Mówca: **Ciara Walda**
> "“These laws would result in greater productivity, a better economy *and* happier women -- to be frank, Mr. President, you'd have to be a fool not to pass them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Ciara Walda: "“If we can pull this off before the elections, the Rayne ..."*)

### Węzeł `[178]`
Mówca: **Ciara Walda**
> "“If we can pull this off before the elections, the Rayne administration will make history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: "“Let's talk about how to proceed.""*)

### Węzeł `[179]`
Mówca: **Ciara Walda**
> "“I agree completely. We must aim to be better than them. Better than all the superpowers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Ciara Walda: "“None of them have yet managed to achieve true parity amo..."*)

### Węzeł `[180]`
Mówca: **Ciara Walda**
> "“None of them have yet managed to achieve true parity among the sexes. If we can do that, we'll make history.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Ciara Walda: "“Let's talk about how to proceed.""*)

### Węzeł `[181]`
Mówca: **Ciara Walda**
> "“Let's talk about how to proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Ciara Walda: "“I want to establish a commission for women's rights in S..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Monica: "“Or even as their counterparts in Arcasia and United Cont..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Ciara Walda: "“Or even as their counterparts in Arcasia and United Cont..."*)

### Węzeł `[185]`
Mówca: **Ciara Walda**
> "“Or even as their counterparts in Arcasia and United Contana. We've been lagging behind on this for decades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Ciara Walda: "“And this isn't only a moral issue. I have seen enough re..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Monica handed me one of the documents. It had a list of b..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Ciara handed me one of the documents. It had a list of bu..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Monica handed me one of the documents. It had a list of bullet points on it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Monica: ""The two of us talked it over, and these are the measures..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Monica: "“As the commission's spokeswoman, my responsibility will ..."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Ciara Walda: "“The organization's name will be 'Commission on the Statu..."*)

### Węzeł `[193]`
Mówca: **Monica**
> "“As the commission's spokeswoman, my responsibility will be to make speeches and organize fundraisers. I will be the face of this movement while Ciara handles the groundwork.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Monica: "“If I can show that the First Lady is behind this movemen..."*)

### Węzeł `[194]`
Mówca: **Monica**
> "“If I can show that the First Lady is behind this movement, many women will feel encouraged.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "Ciara gestured down at her outfit."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "Ciara gestured down at her outfit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Ciara Walda: ""Especially those who aren't keen on pantsuits.""*)

### Węzeł `[196]`
Mówca: **Ciara Walda**
> "“The organization's name will be 'Commission on the Status of Women'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Why bother with a commission? I can pass the laws you want here and now.""]** — Mówca: **Player**
> "“Why bother with a commission? I can pass the laws you want here and now.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[196]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Ciara Walda: "“You'll still need to make sure they're effectively imple..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“It's going to be damn hard getting your laws past the Assembly.""]** — Mówca: **Player**
> "“It's going to be damn hard getting your laws past the Assembly.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[196]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Narrator: "Ciara leaned toward me."*)

### Węzeł `[199]`
Mówca: **Ciara Walda**
> "“You'll still need to make sure they're effectively implemented.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[200]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past -- whether over the failed education reform, or the teaching of creationism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ciara Walda: "“This is a completely separate topic and it should be han..."*)

### Węzeł `[201]`
Mówca: **Ciara Walda**
> "“This is a completely separate topic and it should be handled as such.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_PetrSelfResigned == true ||..."*)

### Węzeł `[202]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past. But this has nothing to do with the failed education reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ciara Walda: "“This is a completely separate topic and it should be han..."*)

### Węzeł `[203]`
Mówca: **Ciara Walda**
> "“Mr. President, I know we've had friction in the past. But this has nothing to do with your decisions on creationism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Ciara Walda: "“This is a completely separate topic and it should be han..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Welfare_FailedEducationReform == tru..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true  and  Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Ciara Walda: "“Mr. President, I know we've had friction in the past -- ..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Welfare_FailedEducationReform == true && BaseGame.Policy_Welfare_EvolutionNotMandatory == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Welfare_FailedEducationReform"] == true  and  Variable["BaseGame.Policy_Welfare_EvolutionNotMandatory"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true"*)

### Węzeł `[207]`
Mówca: **Ciara Walda**
> "“One more thing to consider before making your decision. This could help silence any of the public's lingering questions regarding your former vice president and the Livia Suno affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[208]`
Mówca: **Ciara Walda**
> "“One more thing to consider before making your decision. This could help silence any of the public's lingering questions regarding your vice president and the Livia Suno affair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[209]`
Mówca: **Ciara Walda**
> "“You have the chance to be a hero. Think about your daughter and her future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Ciara Walda: "“I hope you will make the right decision.”"*)

### Węzeł `[210]`
Mówca: **Ciara Walda**
> "“I hope you will make the right decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Ciara rose from her seat expectantly."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < -5"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Ciara Walda: "“You have the chance to be a hero. Think about your daugh..."*)

### Węzeł `[214]`
Mówca: **Monica**
> "“And that man would want a better future for his daughter and her daughters. No matter what else he's said or done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Monica: "“I hope you'll make the right decision. We both do.""*)

### Węzeł `[215]`
Mówca: **Monica**
> "“I hope you'll make the right decision. We both do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Narrator: "Ciara was looking studiously at a scratch on my desk. She..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "They rose from their seats expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "I took a few minutes to think."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Ciara rose from her seat expectantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "I took a few minutes to think."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "I took a few minutes to think."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player: "“I hereby declare your laws passed and your commission es..."*)
  - -> `[222]` (*Player: "“I'm on your side. But I want to go through the Assembly...."*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: "“I will approve the creation of the commission and suppor..."*)
  - -> `[454]` (*Player: ""Sorry, but the answer is no. You can try and run your la..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“I'm on your side. But I want to go through the Assembly. Can't risk a backlash this close to the election.”"]** — Mówca: **Player**
> "“I'm on your side. But I want to go through the Assembly. Can't risk a backlash this close to the election.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_WomensRights_ThroughAssembly = true"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I hereby declare your laws passed and your commission established. Good luck." [Sign Decree. -2 Government Budget]"]** — Mówca: **Player**
> "“Very well. I hereby decree your laws passed and your commission established. Good luck.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1; BaseGame.Democratic += 2; B..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I will approve the creation of the commission and support your bill in the Assembly.”"]** — Mówca: **Player**
> "“I will approve the creation of the commission and support your bill in the Assembly.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_WomensRights_ThroughAssembly = true"*)

### Węzeł `[225]`
Mówca: **Ciara Walda**
> "“Great. Amazing. You won't regret this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "As she made eye contact with me, her professional side to..."*)

### Węzeł `[226]`
Mówca: **Ciara Walda**
> "“Then all is lost for the future of women in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Ciara Walda: "“Your female constituents will remember you as a failure.”"*)

### Węzeł `[227]`
Mówca: **Ciara Walda**
> "“Your female constituents will remember you as a failure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Ciara Walda: "“And so will I.”"*)

### Węzeł `[228]`
Mówca: **Ciara Walda**
> "“And so will I.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "She looked at Monica. She was silent for a moment."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "Ciara furiously gathered up her documents."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "She looked at Monica. She was silent for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Monica: "“How do I explain this to Deana, once she's old enough to..."*)

### Węzeł `[233]`
Mówca: **Monica**
> "“How do I explain this to Deana, once she's old enough to understand? How do I tell her about all the opportunities she could have had, that her own father denied her?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "Without waiting for my answer, she pushed her chair aside..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "Without waiting for my answer, she pushed her chair aside and stormed out. Ciara followed suit, and I could hear the two of them talking angrily as the door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "I sagged back in my chair and exhaled. It was a clear day..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "Ciara furiously gathered up her documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Ciara Walda: ""I suggest you think long and hard about how you're going..."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "I sagged back in my chair and exhaled. It was a clear day outside, but the perfect view over Holsord provided little comfort."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_WomensRightsMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_WomensRightsMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)

### Węzeł `[238]`
Mówca: **Ciara Walda**
> "“Money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "She flipped a folder open and started pulling out documents."*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth > 0"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth > 0)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_LeagueOfWomenDonation = true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_Decision_LeagueOfWomenDonation = true"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_LeagueOfWomenDonation = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_LeagueOfWomenDonation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn08_Decree_WomensRights == false && Ba..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_Decision_LeagueOfWomenDonation = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_Decision_LeagueOfWomenDonation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn08_Decree_WomensRights == false && Ba..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduc..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player: "“I know. That's why I already signed the decree to give w..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WYBÓR GRACZA: "“I know. That's why I already signed the decree to give women an equal education.""]** — Mówca: **Player**
> "“I know. That's why I already signed the decree to give women an equal education.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Monica: "“Yes, and that was a major step forward. But there's so m..."*)

### Węzeł `[248]`
Mówca: **Monica**
> "“Yes, and that was a major step forward. But there's so much more work that must be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[249]`
**[WYBÓR GRACZA: ""What are you doing here?""]** — Mówca: **Player**
> ""What are you doing here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Monica turned to Ciara."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Ciara, what is she doing here?""]** — Mówca: **Player**
> ""Ciara, what is she doing here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Monica turned to Ciara."*)

### Węzeł `[251]`
**[WYBÓR GRACZA: ""No. No! Monica, go home!""]** — Mówca: **Player**
> ""No. No! Monica, go home!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "Monica turned to Ciara."*)

### Węzeł `[252]`
Mówca: **Monica**
> "“See, that's why this meeting is so necessary!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Monica: "“Why should a wife need her husband's permission to do so..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA: "“Someone has to stay home and look after Deana.”"]** — Mówca: **Player**
> "“Someone has to stay home and look after Deana.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Monica: "“I'm doing this *for* Deana. And for so many other girls ..."*)

### Węzeł `[254]`
Mówca: **Monica**
> "“I'm doing this *for* Deana. And for so many other girls like her.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "I leaned forward."*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""This isn't about joining a knitting circle or having a friend for tea. It's about my career!""]** — Mówca: **Player**
> ""This isn't about joining a knitting circle or having a friend for tea. It's about my career!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important == true"*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""I promise I take women's rights seriously. Just let Ciara handle this.""]** — Mówca: **Player**
> ""I promise I take women's rights seriously. Just let Ciara handle this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Monica: "“Ciara has the experience, but people think she's a radic..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA: ""Because you'll make me look foolish otherwise -- like you did at the Benfi Festival.""]** — Mówca: **Player**
> ""Because you'll make me look foolish otherwise -- like you did at the Benfi Festival.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Monica: "“I know Benfi may have crossed a line, but this is differ..."*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Family_Important == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Family_Important == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Family_Important == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Family_Important"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Monica: ""I had dreams of a career too, back in university. But I ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Family_Important == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Family_Important"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""Your career. For which you have consistently sidelined m..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""Your career. For which you have consistently sidelined me and your children.""]** — Mówca: **Monica**
> ""Your career. For which you have consistently sidelined me and your children.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Family_Important"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[255]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Monica: ""I had dreams of a career too, back in university. But I ..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""I had dreams of a career too, back in university. But I gave those up for you.""]** — Mówca: **Monica**
> ""I had dreams of a career too, back in university. But I gave those up for you.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Family_Important"] == true`
- **Kontekst wejściowy (poprzednik):** `[261]` (Monica), `[255]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Monica: ""I'm starting to think it wasn't worth it.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""I'm starting to think it wasn't worth it.""]** — Mówca: **Monica**
> ""I'm starting to think it wasn't worth it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“What are you going to do? Leave me? You wouldn't dare.""*)
  - -> `[264]` (*Player: "“I gave you a life most woman can only dream of, and this..."*)
  - -> `[86]` (*Player: "“Please don't say that. I'm sorry.”"*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "“I gave you a life most woman can only dream of, and this is how you thank me?”"]** — Mówca: **Player**
> "“I gave you a life most woman can only dream of, and this is how you thank me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[263]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Monica: "“There are things at play here that are greater than just..."*)

### Węzeł `[265]`
Mówca: **Monica**
> ""I'll fetch Ciara so you two can get on with your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "Monica left the office. A short time later, Ciara knocked..."*)

### Węzeł `[266]`
Mówca: **Ciara Walda**
> ""I did ask her to come to the meeting, as I thought her media traction after the Benfi Festival would make her a valuable spokeswoman. But she told me she was, and I quote, 'barred from politics'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "She shot me a sharp, meaningful look."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "She shot me a sharp, meaningful look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: "“It's for her own good.”"*)
  - -> `[272]` (*Player: "“This is between Monica and myself. Stay out of it.”"*)
  - -> `[273]` (*Player: ""Monica would only be a liability to your cause.”"*)
  - -> `[274]` (*Player: ""Be thankful I'm not firing you for approaching her behin..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Ciara Walda: ""I did ask her to come to the meeting, as I thought her m..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: "“It's for her own good.”"*)
  - -> `[272]` (*Player: "“This is between Monica and myself. Stay out of it.”"*)
  - -> `[273]` (*Player: ""Monica would only be a liability to your cause.”"*)
  - -> `[274]` (*Player: ""Be thankful I'm not firing you for approaching her behin..."*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“It's for her own good.”"]** — Mówca: **Player**
> "“It's for her own good.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ciara Walda: "“Not a particularly auspicious start to this meeting. But..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“This is between Monica and myself. Stay out of it.”"]** — Mówca: **Player**
> "“This is between Monica and myself. Stay out of it.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ciara Walda: "“Not a particularly auspicious start to this meeting. But..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA: ""Monica would only be a liability to your cause.”"]** — Mówca: **Player**
> ""Monica would only be a liability to your cause.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ciara Walda: "“Not a particularly auspicious start to this meeting. But..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Be thankful I'm not firing you for approaching her behind my back.”"]** — Mówca: **Player**
> ""Be thankful I'm not firing you for approaching her behind my back.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[267]` (Narrator), `[19]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Ciara Walda: "“Not a particularly auspicious start to this meeting. But..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduc..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Ciara Walda: ""First off, Mr. President, I wish to thank you for pushin..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Ciara Walda: ""We still have a long way to go before Sordish women are ..."*)

### Węzeł `[278]`
Mówca: **Ciara Walda**
> ""First off, Mr. President, I wish to thank you for pushing a decree on establishing gender equality in education. You know this is something I've been trying to accomplish since my appointment as minister. The situation in the public schools was disturbing for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Ciara Walda: ""With that said, we still have a long way to go before So..."*)

### Węzeł `[279]`
Mówca: **Ciara Walda**
> ""With that said, we still have a long way to go before Sordish women are able to enjoy the same rights and privileges as men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[280]`
Mówca: **Ciara Walda**
> ""These are the measures I believe are most urgently needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "I let my eyes wander down the list."*)

### Węzeł `[281]`
Mówca: **Monica**
> ""The two of us talked it over, and these are the measures we believe are most urgently needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "I let my eyes wander down the list."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Women's Issues Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "Women's Issues Hub"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Women's Issues Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence ==..."*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == ..."*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence ==..."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "I let my eyes wander down the list."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: ""Criminalizing domestic violence.""]** — Mówca: **Player**
> ""Criminalizing domestic violence.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false` AND `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Ciara Walda), `[335]` (Ciara Walda), `[352]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Ciara Walda: ""I shouldn't have to tell you how crucial this is. It is ..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA: ""Support for working mothers.""]** — Mówca: **Player**
> ""Support for working mothers.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false` AND `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Ciara Walda), `[335]` (Ciara Walda), `[352]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Ciara nodded."*)

### Węzeł `[287]`
**[WYBÓR GRACZA: ""Equal treatment in the workforce.""]** — Mówca: **Player**
> ""Equal treatment in the workforce.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false` AND `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Ciara Walda), `[335]` (Ciara Walda), `[352]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA: ""Gender equality in public education.""]** — Mówca: **Player**
> ""Gender equality in public education.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false` AND `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[334]` (Ciara Walda), `[335]` (Ciara Walda), `[352]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "Ciara grinned."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduc..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""Gender equality in public education.""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == false && BaseGameIsolated.Turn08_WomensRights_Listened_Education == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == false  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_WomensRights_Listened_Workplace..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Player: ""Equal treatment in the workforce.""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == ..."*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_WomensRights_Listened_Mothers =..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player: ""Support for working mothers.""*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence ==..."*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_WomensRights_Listened_Violence ..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: ""Criminalizing domestic violence.""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_WomensRights_Listened_Violence == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Slapped == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Ciara looked at me closely, as if she were scrutinizing m..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Slapped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""I agree. It's a travesty.""*)
  - -> `[310]` (*Player: ""What families do in their own homes is none of our conce..."*)

### Węzeł `[304]`
Mówca: **Ciara Walda**
> ""I shouldn't have to tell you how crucial this is. It is utterly unbelievable that, in this day and age, Sordish men are legally allowed to beat their wives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Ciara looked at me closely, as if she were scrutinizing my reaction. How much had Monica told her?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""I agree. It's a travesty.""*)
  - -> `[310]` (*Player: ""What families do in their own homes is none of our conce..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""I agree. It's a travesty.""]** — Mówca: **Player**
> ""I agree. It's a travesty.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[305]` (Narrator), `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""What families do in their own homes is none of our concern.""]** — Mówca: **Player**
> ""What families do in their own homes is none of our concern.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[305]` (Narrator), `[304]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1;"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "Ciara looked disgusted."*)

### Węzeł `[314]`
Mówca: **Monica**
> ""I'm happy we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ciara Walda: ""As incidences are especially high within Bludish communi..."*)

### Węzeł `[315]`
Mówca: **Ciara Walda**
> ""I'm happy we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ciara Walda: ""As incidences are especially high within Bludish communi..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Monica and Ciara both looked disgusted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Ciara Walda: ""With all due respect, Mr. President, it is. By staying l..."*)

### Węzeł `[317]`
Mówca: **Narrator**
> "Ciara looked disgusted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Ciara Walda: ""With all due respect, Mr. President, it is. By staying l..."*)

### Węzeł `[318]`
Mówca: **Ciara Walda**
> ""With all due respect, Mr. President, it is. By staying lenient on this we are essentially telling Sordish women that the state doesn't care about them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ciara Walda: ""As incidences are especially high within Bludish communi..."*)

### Węzeł `[319]`
Mówca: **Ciara Walda**
> ""As incidences are especially high within Bludish communities, I would also advocate for setting up a special domestic violence task force in collaboration with Bludish women's rights organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[320]`
Mówca: **Monica**
> ""Are you sure that's something we ought to focus on? The Bluds are... different. They have their own rules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Ciara Walda: ""Monica, I'm surprised at you! We can't let women suffer ..."*)

### Węzeł `[321]`
Mówca: **Narrator**
> "Monica looked at her strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Monica: ""Are you sure that's something we ought to focus on? The ..."*)

### Węzeł `[322]`
Mówca: **Ciara Walda**
> ""Monica, I'm surprised at you! We can't let women suffer under the patriarchy, no matter their ethnicity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 1"*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Interfering in Bludish matters has landed us in enough trouble already.""]** — Mówca: **Player**
> ""Interfering in Bludish matters has landed us in enough trouble already.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bludish_Opinion"] < 1` AND `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Ciara Walda), `[319]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Ciara Walda: ""We can discuss the particulars once the law has passed.""*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 1"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 1)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""Interfering in Bludish matters has landed us in enough t..."*)
  - -> `[329]` (*Player: ""The Bluds must conform to Sordish law.""*)
  - -> `[330]` (*Player: ""I'm still not sure criminalizing domestic violence is a ..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""I'm still not sure criminalizing domestic violence is a ..."*)
  - -> `[328]` (*Player: ""We should lift up all Sordish women, Bluds included.""*)
  - -> `[327]` (*Player: ""The Bluds have their own ways of settling these issues.""*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""The Bluds have their own ways of settling these issues.""]** — Mówca: **Player**
> ""The Bluds have their own ways of settling these issues.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bludish_Opinion"] < 1) == false` AND `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Ciara Walda), `[319]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Ciara Walda: ""We can discuss the particulars once the law has passed.""*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""We should lift up all Sordish women, Bluds included.""]** — Mówca: **Player**
> ""We should lift up all Sordish women, Bluds included.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Bludish_Opinion"] < 1) == false` AND `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Ciara Walda), `[319]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Ciara Walda: ""We can discuss the particulars once the law has passed.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA: ""The Bluds must conform to Sordish law.""]** — Mówca: **Player**
> ""The Bluds must conform to Sordish law.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bludish_Opinion"] < 1` AND `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Ciara Walda), `[319]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Ciara Walda: ""We can discuss the particulars once the law has passed.""*)

### Węzeł `[330]`
**[WYBÓR GRACZA: ""I'm still not sure criminalizing domestic violence is a good idea. For the Bluds or anyone else.""]** — Mówca: **Player**
> ""I'm still not sure criminalizing domestic violence is a good idea. For the Bluds or anyone else.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bludish_Opinion"] < 1` AND `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[322]` (Ciara Walda), `[319]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Ciara Walda: ""I assure you it is. But I'll give you some time to think..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Narrator: "Monica looked at her strangely."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 1"*)

### Węzeł `[334]`
Mówca: **Ciara Walda**
> ""We can discuss the particulars once the law has passed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence = ..."*)

### Węzeł `[335]`
Mówca: **Ciara Walda**
> ""I assure you it is. But I'll give you some time to think about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence = ..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Women's Issues Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "Women's Issues Hub"*)

### Węzeł `[337]`
Mówca: **Narrator**
> "Ciara nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Ciara Walda: ""It simply isn't fair that women in the workforce are pun..."*)

### Węzeł `[338]`
Mówca: **Ciara Walda**
> ""It simply isn't fair that women in the workforce are punished for having children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Monica: ""Remember what I told you about Janice? My friend who bas..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ciara Walda: ""Paid maternity leave and state-subsidized daycare center..."*)

### Węzeł `[342]`
Mówca: **Monica**
> ""Remember what I told you about Janice? My friend who basically got fired for becoming pregnant? That would never happen to a man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Ciara Walda: ""Paid maternity leave and state-subsidized daycare center..."*)

### Węzeł `[343]`
Mówca: **Ciara Walda**
> ""Paid maternity leave and state-subsidized daycare centers could be key to keeping more mothers employed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player: ""I don't want to reward women for choosing work over rais..."*)
  - -> `[345]` (*Player: ""It's true -- having children never hindered my career pr..."*)
  - -> `[346]` (*Player: ""I'll have to think about this.""*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA: ""I don't want to reward women for choosing work over raising their children.""]** — Mówca: **Player**
> ""I don't want to reward women for choosing work over raising their children.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Ciara Walda: ""What about women who have to work to provide for their c..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA: ""It's true -- having children never hindered my career prospects. It shouldn't hinder a woman either.""]** — Mówca: **Player**
> ""It's true -- having children never hindered my career prospects. It shouldn't hinder a woman either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Ciara Walda: ""Exactly.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA: ""I'll have to think about this.""]** — Mówca: **Player**
> ""I'll have to think about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Ciara Walda: ""Please do. Moving on.""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: ""Monica, you always said you never regretted giving up a ..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA: ""Monica, you always said you never regretted giving up a career to raise Franc and Deana.""]** — Mówca: **Player**
> ""Monica, you always said you never regretted giving up a career to raise Franc and Deana.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Kontekst wejściowy (poprzednik):** `[343]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Monica: ""Anton, I never had a choice.""*)

### Węzeł `[351]`
Mówca: **Monica**
> ""Anton, I never had a choice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Ciara Walda: ""Moving on.""*)

### Węzeł `[352]`
Mówca: **Ciara Walda**
> ""Please do. Moving on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Mothers = true"*)

### Węzeł `[353]`
Mówca: **Ciara Walda**
> ""What about women who have to work to provide for their children? This could lead to healthier families and a healthier economy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Ciara Walda: ""Moving on.""*)

### Węzeł `[354]`
Mówca: **Ciara Walda**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Ciara Walda: ""Moving on.""*)

### Węzeł `[355]`
Mówca: **Ciara Walda**
> ""Moving on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Mothers = true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Mothers = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Violence = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Slapped == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Ciara Walda: ""I'm happy you agree. In theory, at least.""*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Slapped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Ciara Walda: ""I'm happy we're on the same page.""*)

### Węzeł `[361]`
Mówca: **Ciara Walda**
> ""I'm happy you agree. In theory, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Ciara Walda: ""As incidences are especially high within Bludish communi..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Women's Issues Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "Women's Issues Hub"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Monica: ""That's an easy one.""*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ciara Walda: ""Right now, Sordland has one of the continent's largest p..."*)

### Węzeł `[366]`
Mówca: **Monica**
> ""That's an easy one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Ciara Walda: ""Right now, Sordland has one of the continent's largest p..."*)

### Węzeł `[367]`
Mówca: **Ciara Walda**
> ""Right now, Sordland has one of the continent's largest pay gaps between men and women. We need legislation ensuring that a woman doing the same job as a man is paid the same wage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[368]`
Mówca: **Monica**
> ""We would also introduce quotas to get more women into positions of power -- in the Assembly, for instance, or on the boards of corporations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Ciara Walda: ""Eventually. Narrowing the pay gap is a far more pressing..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Monica: ""We would also introduce quotas to get more women into po..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Ciara Walda: ""A quota for women in positions of power -- on the boards..."*)

### Węzeł `[372]`
Mówca: **Ciara Walda**
> ""Eventually. Narrowing the pay gap is a far more pressing issue, as it would bring financial independence to countless lower-income women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Monica: ""Ciara, we never talked about this. But I always thought ..."*)

### Węzeł `[373]`
Mówca: **Monica**
> ""Ciara, we never talked about this. But I always thought that with more women in power, higher status for all women would naturally follow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Ciara Walda: ""Women are starving because they don't make a living wage..."*)

### Węzeł `[374]`
Mówca: **Ciara Walda**
> ""Women are starving because they don't make a living wage. That's a damn sight more important than your friend Janice being passed over for a promotion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""I don't see a problem with quotas, but tackling the pay ..."*)
  - -> `[378]` (*Player: ""Quotas seem far easier to implement than equal pay laws...."*)
  - -> `[376]` (*Player: ""Quotas are a terrible idea. People should be hired on me..."*)

### Węzeł `[375]`
Mówca: **Ciara Walda**
> ""A quota for women in positions of power -- on the boards of large corporations, for instance, or even within the Assembly -- would also be advisable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""I don't see a problem with quotas, but tackling the pay ..."*)
  - -> `[378]` (*Player: ""Quotas seem far easier to implement than equal pay laws...."*)
  - -> `[376]` (*Player: ""Quotas are a terrible idea. People should be hired on me..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA: ""Quotas are a terrible idea. People should be hired on merit, not simply because of their sex.""]** — Mówca: **Player**
> ""Quotas are a terrible idea. People should be hired on merit, not simply because of their sex.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Ciara Walda), `[375]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I don't see a problem with quotas, but tackling the pay gap is much more urgent.""]** — Mówca: **Player**
> ""I don't see a problem with quotas, but tackling the pay gap is much more urgent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Ciara Walda), `[375]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Quotas seem far easier to implement than equal pay laws. We should start there.""]** — Mówca: **Player**
> ""Quotas seem far easier to implement than equal pay laws. We should start there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[374]` (Ciara Walda), `[375]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "Ciara gritted her teeth."*)

### Węzeł `[379]`
Mówca: **Narrator**
> "Ciara gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Ciara Walda: ""We'll see about that.""*)

### Węzeł `[380]`
Mówca: **Narrator**
> "Ciara smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Ciara Walda: ""My thoughts exactly.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "Monica gritted her teeth."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "Ciara smiled."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "Monica gritted her teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Ciara Walda: ""Thank you, Mr. President.""*)

### Węzeł `[385]`
Mówca: **Ciara Walda**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)

### Węzeł `[386]`
Mówca: **Ciara Walda**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)

### Węzeł `[387]`
Mówca: **Ciara Walda**
> ""We'll see about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "Monica and Ciara looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Monica: ""Men are hired on the basis of their sex all the time. Ju..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "Monica and Ciara looked at me strangely."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Ciara looked at me strangely."*)

### Węzeł `[392]`
Mówca: **Monica**
> ""Men are hired on the basis of their sex all the time. Just not consciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Ciara Walda: ""There are more than enough qualified women to fill any p..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Ciara looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Ciara Walda: ""Men are hired on the basis of their sex all the time. Ju..."*)

### Węzeł `[394]`
Mówca: **Ciara Walda**
> ""Men are hired on the basis of their sex all the time. Just not consciously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Ciara Walda: ""There are more than enough qualified women to fill any p..."*)

### Węzeł `[395]`
Mówca: **Ciara Walda**
> ""There are more than enough qualified women to fill any position you can think of. It's up to us to give them the opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Workplace =..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Workplace = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Women's Issues Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "Women's Issues Hub"*)

### Węzeł `[398]`
Mówca: **Narrator**
> "Ciara grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Ciara Walda: ""You know how much this means to me. And you've witnessed..."*)

### Węzeł `[399]`
Mówca: **Ciara Walda**
> ""You know how much this means to me. And you've witnessed the dangers firsthand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Ciara Walda: ""The way girls are shut out of a real education unless th..."*)

### Węzeł `[400]`
Mówca: **Ciara Walda**
> ""The way girls are shut out of a real education unless their parents have the means to get them out of the public school system -- so many bright minds are being lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Monica: ""I wouldn't entirely demean the old system, Ciara. Deana ..."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Player: ""We can't force schools what to teach to whom.""*)
  - -> `[409]` (*Player: ""Yes, we've had this conversation. I'm entirely on your s..."*)
  - -> `[410]` (*Player: ""But Deana loves her handicrafts classes.""*)

### Węzeł `[404]`
Mówca: **Monica**
> ""I wouldn't entirely demean the old system, Ciara. Deana still loves her handicrafts classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Ciara Walda: ""I'm not saying we'll take those away. Maybe boys should ..."*)

### Węzeł `[405]`
Mówca: **Ciara Walda**
> ""I'm not saying we'll take those away. Maybe boys should learn handicrafts too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "Monica burst out laughing."*)

### Węzeł `[406]`
Mówca: **Narrator**
> "Monica burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Monica: ""Imagine Franc in an apron!""*)

### Węzeł `[407]`
Mówca: **Monica**
> ""Imagine Franc in an apron!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Player: ""We've had this conversation, Ciara. I'm entirely on your..."*)
  - -> `[408]` (*Player: ""We can't force schools what to teach to whom.""*)

### Węzeł `[408]`
**[WYBÓR GRACZA: ""We can't force schools what to teach to whom.""]** — Mówca: **Player**
> ""We can't force schools what to teach to whom.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[407]` (Monica), `[400]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA: ""Yes, we've had this conversation. I'm entirely on your side.""]** — Mówca: **Player**
> ""Yes, we've had this conversation. I'm entirely on your side.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[400]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Ciara Walda: ""Good. Then we see eye to eye on the matter.""*)

### Węzeł `[410]`
**[WYBÓR GRACZA: ""But Deana loves her handicrafts classes.""]** — Mówca: **Player**
> ""But Deana loves her handicrafts classes.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[400]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Ciara Walda: ""I'm not saying we'll take those away. Maybe boys should ..."*)

### Węzeł `[411]`
Mówca: **Ciara Walda**
> ""I'm not saying we'll take those away. Maybe boys should learn handicrafts too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Player: ""My voters won't want to see their sons in an apron.""*)
  - -> `[414]` (*Player: ""You've got a point.""*)

### Węzeł `[412]`
**[WYBÓR GRACZA: ""We've had this conversation, Ciara. I'm entirely on your side.""]** — Mówca: **Player**
> ""We've had this conversation, Ciara. I'm entirely on your side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Ciara Walda: ""Good. Then we see eye to eye on the matter.""*)

### Węzeł `[413]`
**[WYBÓR GRACZA: ""My voters won't want to see their sons in an apron.""]** — Mówca: **Player**
> ""My voters won't want to see their sons in an apron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Ciara Walda: ""But maybe they'll want to see their daughters become the..."*)

### Węzeł `[414]`
**[WYBÓR GRACZA: ""You've got a point.""]** — Mówca: **Player**
> ""You've got a point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[411]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Ciara Walda: ""Good. Then we see eye to eye on the matter.""*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationis..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Ciara Walda: ""We can if not doing so puts us on the wrong side of hist..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Ciara Walda: ""We can if not doing so puts us on the wrong side of hist..."*)

### Węzeł `[418]`
Mówca: **Ciara Walda**
> ""We can if not doing so puts us on the wrong side of history. Have you forgotten what we decided about evolution?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Ciara Walda: ""Let's move on for now.""*)

### Węzeł `[419]`
Mówca: **Ciara Walda**
> ""We can if not doing so puts us on the wrong side of history. I still believe you made a mistake with your creationism decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Ciara Walda: ""Let's move on for now.""*)

### Węzeł `[420]`
Mówca: **Ciara Walda**
> ""Good. Then we see eye to eye on the matter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Education =..."*)

### Węzeł `[421]`
Mówca: **Ciara Walda**
> ""But maybe they'll want to see their daughters become the next Artvin Einstavn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Ciara Walda: ""Let's move on for now.""*)

### Węzeł `[422]`
Mówca: **Ciara Walda**
> ""Let's move on for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Education =..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Education = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Women's Issues Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "Women's Issues Hub"*)

### Węzeł `[425]`
Mówca: **Ciara Walda**
> ""That covers all subjects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "Jump to: [Listened to Issues - Next Steps]"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Listened to Issues - Next Steps`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Ciara Walda: "“What are your thoughts so far?”"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Listened to Issues - Next Steps]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "Listened to Issues - Next Steps"*)

### Węzeł `[428]`
Mówca: **Ciara Walda**
> ""Especially those who aren't keen on pantsuits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Ciara Walda: "“The organization's name will be 'Commission on the Statu..."*)

### Węzeł `[429]`
Mówca: **Monica**
> ""And convince the public the changes will be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Ciara Walda: ""Nia would kill me for saying this, but... this is one ca..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Monica: ""And convince the public the changes will be beneficial.""*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Ciara Walda: ""Nia would kill me for saying this, but... this is one ca..."*)

### Węzeł `[433]`
**[WYBÓR GRACZA: "“It's going to be damn hard getting your laws past the Assembly.""]** — Mówca: **Player**
> "“It's going to be damn hard getting your laws past the Assembly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Ciara Walda: ""I know. But even a watered-down version would be better ..."*)

### Węzeł `[434]`
**[WYBÓR GRACZA: ""What do you need a commission for? I'll run your laws past the Assembly.""]** — Mówca: **Player**
> ""What do you need a commission for? I'll run your laws past the Assembly.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[196]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Ciara Walda: ""Even if that's successful, you'll still need the commiss..."*)

### Węzeł `[435]`
Mówca: **Narrator**
> "Ciara leaned toward me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Ciara Walda: ""Nia would kill me for saying this, but... this is one ca..."*)

### Węzeł `[436]`
Mówca: **Ciara Walda**
> ""Nia would kill me for saying this, but... this is one case where using your decree powers would be fully justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player: ""What exactly is going on between you and Mrs. Morgna, an..."*)
  - -> `[440]` (*Player: ""I'll be the judge of that.""*)
  - -> `[441]` (*Player: ""Look who's suddenly off her moral high horse.""*)
  - -> `[442]` (*Player: ""You're right. The Assembly would only pass a weak versio..."*)

### Węzeł `[437]`
**[WYBÓR GRACZA: ""What exactly is going on between you and Mrs. Morgna, anyway?""]** — Mówca: **Player**
> ""What exactly is going on between you and Mrs. Morgna, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Narrator: "She shrugged uncomfortably."*)

### Węzeł `[438]`
Mówca: **Narrator**
> "She shrugged uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Ciara Walda: ""We're friends. That's all.""*)

### Węzeł `[439]`
Mówca: **Ciara Walda**
> ""We're friends. That's all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[440]`
**[WYBÓR GRACZA: ""I'll be the judge of that.""]** — Mówca: **Player**
> ""I'll be the judge of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA: ""Look who's suddenly off her moral high horse.""]** — Mówca: **Player**
> ""Look who's suddenly off her moral high horse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Ciara Walda: ""If it's for the greater good, I have no problem bypassin..."*)

### Węzeł `[442]`
**[WYBÓR GRACZA: ""You're right. The Assembly would only pass a weak version of these laws, if at all.""]** — Mówca: **Player**
> ""You're right. The Assembly would only pass a weak version of these laws, if at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[443]`
Mówca: **Ciara Walda**
> ""I know. But even a watered-down version would be better than nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[444]`
Mówca: **Ciara Walda**
> ""If it's for the greater good, I have no problem bypassing the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[445]`
Mówca: **Ciara Walda**
> ""Even if that's successful, you'll still need the commission to ensure the laws are successfully implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Monica: ""And convince the public the changes will be beneficial.""*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[449]`
Mówca: **Monica**
> ""And convince the public the changes will be beneficial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_FailedEducationReform == true ..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduc..."*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Player: ""I've already given women equal access to education. I wa..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player: ""Sorry, but the answer is no. You can try and run your la..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA: ""I've already given women equal access to education. I want to see how that decision shakes out before making any new laws.""]** — Mówca: **Player**
> ""I've already given women equal access to education. I want to see how that decision shakes out before making any new laws.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true` AND `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Narrator: "Ciara folded her arms."*)

### Węzeł `[454]`
**[WYBÓR GRACZA: ""Sorry, but the answer is no. You can try and run your laws by the Assembly, but they'll get no support from me.""]** — Mówca: **Player**
> ""Sorry, but the answer is no. You can try and run your laws by the Assembly, but they'll get no support from me.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Ciara Walda: "“Then all is lost for the future of women in Sordland.”"*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn08_Decree_WomensRights = true; BaseGame.Policy_Law_WomenLiberation = true; BaseGame.Situation_Law_ExcellentWomenRights = true; BaseGame.Situation_Law_AverageWomenRights = false; BaseGame.Situation_Law_LimitedWomenRights = false;
BaseGame.Situation_Welfare_GenderEqualityInEducation = true;
BaseGame.Bill_Turn09_StrongWomensRights_Signed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] = true;
Variable["BaseGame.Policy_Law_WomenLiberation"] = true;
Variable["BaseGame.Situation_Law_ExcellentWomenRights"] = true;
Variable["BaseGame.Situation_Law_AverageWomenRights"] = false;
Variable["BaseGame.Situation_Law_LimitedWomenRights"] = false;
Variable["BaseGame.Situation_Welfare_GenderEqualityInEducation"] = true;
Variable["BaseGame.Bill_Turn09_StrongWomensRights_Signed"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "Ciara let out a lengthy exhale. Her face had started to t..."*)

### Węzeł `[456]`
Mówca: **Narrator**
> "Monica turned to her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Monica: ""That's all the excitement you can muster? You did it! We..."*)

### Węzeł `[457]`
Mówca: **Monica**
> ""That's all the excitement you can muster? You did it! We did it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "Monica hugged Ciara. She smiled uncomfortably."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "Monica hugged Ciara. She smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_LeadsWomensRights = true"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.WomensRightCommission = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.WomensRightCommission"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_WomensRights_ComissionEsta..."*)

### Węzeł `[460]`
Mówca: **Ciara Walda**
> ""You're making a mistake by not pushing this through right away. But I'm happy for your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.WomensRightCommission = true"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Narrator: "Monica turned to her."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Ciara Walda: ""We still have a long way to go. I'll start gathering nam..."*)

### Węzeł `[464]`
Mówca: **Ciara Walda**
> ""We still have a long way to go. I'll start gathering names for the commission tonight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Ciara started collecting her documents."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_LeadsWomensRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_LeadsWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads =..."*)

### Węzeł `[466]`
Mówca: **Narrator**
> "Ciara started collecting her documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[467]`
Mówca: **Narrator**
> "She and Monica headed towards the door. Monica paused before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 0"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversa..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Narrator: "She and Monica headed towards the door. Monica paused bef..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Narrator: "She headed towards the door, then paused and turned back ..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion > 0"*)
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion > 0)"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Monica: ""I love you, Anton.""*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Monica: ""Whatever our differences, I'm glad you were able to set ..."*)

### Węzeł `[474]`
Mówca: **Monica**
> ""I love you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Monica: ""I'll see you at home.""*)

### Węzeł `[475]`
Mówca: **Monica**
> ""Whatever our differences, I'm glad you were able to set them aside and act for the good of Sordish women.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Monica: ""I'll see you at home.""*)

### Węzeł `[476]`
Mówca: **Monica**
> ""I'll see you at home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Narrator: "I could hear Monica and Ciara talking excitedly to each o..."*)

### Węzeł `[477]`
Mówca: **Narrator**
> "She headed towards the door, then paused and turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Ciara Walda: ""I wish your wife could be here right now to celebrate yo..."*)

### Węzeł `[478]`
Mówca: **Ciara Walda**
> ""I wish your wife could be here right now to celebrate your decision. We both know how much this means to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Narrator: "She looked at me one last time before walking out."*)

### Węzeł `[479]`
Mówca: **Narrator**
> "She looked at me one last time before walking out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "I took a long sip from the bottle of whiskey in my office..."*)

### Węzeł `[480]`
Mówca: **Narrator**
> "I could hear Monica and Ciara talking excitedly to each other as the door closed behind them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Narrator: "I looked out my window over the city of Holsord. It was a..."*)

### Węzeł `[481]`
Mówca: **Narrator**
> "Ciara folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Ciara Walda: ""We've waited long enough, Mr. President. If you aren't r..."*)

### Węzeł `[482]`
Mówca: **Ciara Walda**
> ""We've waited long enough, Mr. President. If you aren't re-elected, this opportunity will be lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Ciara Walda: "“Your female constituents will remember you as a failure.”"*)

### Węzeł `[483]`
Mówca: **Ciara Walda**
> ""I suggest you think long and hard about how you're going to explain yourself to your wife. We both know how much this means to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Narrator: "She looked at me one last time before leaving the office."*)

### Węzeł `[484]`
Mówca: **Narrator**
> "She looked at me one last time before leaving the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "I sagged back in my chair and exhaled. It was a clear day..."*)

### Węzeł `[485]`
Mówca: **Narrator**
> "I took a long sip from the bottle of whiskey in my office desk drawer, then picked up the phone and called Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)

### Węzeł `[486]`
Mówca: **Narrator**
> "I looked out my window over the city of Holsord. It was a clear day outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Violence ==..."*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn08_WomensRights_Listened_Violence ..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Ciara Walda: ""That covers all subjects.""*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn08_WomensRights_Listened_Violence == true && BaseGameIsolated.Turn08_WomensRights_Listened_Mothers == true && BaseGameIsolated.Turn08_WomensRights_Listened_Workplace == true && BaseGameIsolated.Turn08_WomensRights_Listened_Education == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Violence"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Mothers"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Workplace"] == true  and  Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn08_WomensRights_Listened_Education = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn08_WomensRights_Listened_Education"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_GenderEqualityInEducat..."*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEduc..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_WomensRights_Listened_Education =..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "Jump to: [Women's Issues Hub]"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_WomensRightsBill_Weak = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_WomensRightsBill_Weak"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 13`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 13"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote >= 13)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 13`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 13`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_WomensRightsBill_Weak = true"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote >= 13)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 13) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Bill_WomensRights = true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 17"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Assembly_Vote >= 17)"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Assembly_Vote >= 17`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Assembly_Vote"] >= 17`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_WomensRightsBill_Strong = true"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Assembly_Vote >= 17)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Assembly_Vote"] >= 17) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 13"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_WomensRightsBill_Strong = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_WomensRightsBill_Strong"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn08_Decree_WomensRights == false && Ba..."*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Turn08_Decree_WomensRights == false && ..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_Bill_WomensRights = true"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_Bill_WomensRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_Bill_WomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[506]`
Mówca: **Ciara Walda**
> ""We still have a long way to go before Sordish women are able to enjoy the same rights and privileges as men.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_WomensRights_ComissionEstablished"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn08_A_WomensRights_MonicaInConversati..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads = true;
BaseGameSupport.Codex_Characters_Family_Monica_WomensRights = true;
BaseGameSupport.Codex_Characters_Family_Monica = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_WomensRights_MonicaLeads"] = true;
Variable["BaseGameSupport.Codex_Characters_Family_Monica_WomensRights"] = true;
Variable["BaseGameSupport.Codex_Characters_Family_Monica"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_WomensRights_ThroughAssembly == true"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;
BaseGame.Democratic += 2;
BaseGame.Malenyevist += 1;
BaseGame.Sollist -= 1;
BaseGame.GovernmentBudget -= 2;
BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Turn08_Decree_WomensRights = true; BaseGa..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Monica and Ciara both looked disgusted."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Monica: ""I'm happy we're on the same page.""*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Monica: "“Just watch me.""*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Monica: "“Thank you, Anton.”"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“Please, Anton. Let me stay.""*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Monica: "“Please, Anton. Let me stay.""*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth >= 2"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.PersonalWealth >= 2)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.PersonalWealth >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_WomensRightsMeeting = true"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Enable_Turn08LeagueOfWomenDonationOption_Donate2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_WomensRightsMeeting = true"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_WomensRights_ThroughAssembly = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Decree_Stronger == true"*)
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Decree_Stronger == true)"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Decree_Stronger == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Decree_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Ciara Walda: ""You're making a mistake by not pushing this through righ..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Decree_Stronger == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Decree_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.WomensRightCommission = true"*)

### Węzeł `[524]`
Mówca: **Narrator**
> "Ciara let out a lengthy exhale. Her face had started to turn red from holding her breath for so long."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Ciara Walda: "“Great. Amazing. You won't regret this, Mr. President.""*)

### Węzeł `[525]`
Mówca: **Narrator**
> "As she made eye contact with me, her professional side took hold. She swiftly straightened her posture and put on the icy mask of an experienced politician."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.WomensRightCommission = true"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_WomensRights_ThroughAssembly == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_WomensRights_ThroughAssembly == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_WomensRights_ThroughAssembly == true)"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_WomensRights_ThroughAssembly == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Ciara Walda: ""It's not over yet, Monica. The true battle is in the Ass..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_WomensRights_ThroughAssembly == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_WomensRights_ThroughAssembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Ciara Walda: ""We still have a long way to go. I'll start gathering nam..."*)

### Węzeł `[529]`
Mówca: **Ciara Walda**
> ""It's not over yet, Monica. The true battle is in the Assembly. We'll celebrate once that's over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Ciara Walda: ""I'll start gathering names for the commission tonight.""*)

### Węzeł `[530]`
Mówca: **Ciara Walda**
> ""I'll start gathering names for the commission tonight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Narrator: "Ciara started collecting her documents."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true ..."*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_SupportWomensRights == tru..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true  or  Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Monica: ""I hope this is still as important to you as it used to b..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_SupportWomensRights == true || BaseGame.Relations_Monica_SupportIntentionAtBall == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true  or  Variable["BaseGame.Relations_Monica_SupportIntentionAtBall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Monica: ""You never did listen to me about the importance of woman..."*)

### Węzeł `[534]`
Mówca: **Monica**
> ""I hope this is still as important to you as it used to be. And I trust you to do the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She made her way to the door."*)

### Węzeł `[535]`
Mówca: **Monica**
> ""You never did listen to me about the importance of woman's rights. Maybe you'll take your own minister more seriously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "She made her way to the door."*)

### Węzeł `[536]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Monica: ""Anton, I think you'll agree that I've put up with quite ..."*)

### Węzeł `[537]`
Mówca: **Monica**
> ""Anton, I think you'll agree that I've put up with quite a lot over the course of your presidency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Monica: ""But despite it all, I look at you and I still see the id..."*)

### Węzeł `[538]`
Mówca: **Monica**
> ""And that man would want a better future for his daughter and her daughters. Just like you told me you did all those years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Monica: "“I hope you'll make the right decision. We both do.""*)

### Węzeł `[539]`
Mówca: **Monica**
> ""But despite it all, I look at you and I still see the idealistic, driven man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true"*)
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_SupportWomensRights == true)"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Monica: ""And that man would want a better future for his daughter..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_SupportWomensRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Monica: "“And that man would want a better future for his daughter..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion < -5"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion < -5)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion < -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Narrator: "Monica lowered her voice."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion < -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true |..."*)

### Węzeł `[546]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Monica: ""Anton, I think you'll agree that I've put up with quite ..."*)

### Węzeł `[547]`
Mówca: **Monica**
> ""Anton, I think you'll agree that I've put up with quite a lot over the course of our marriage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Monica: ""But some part of me still sees you as the idealistic, dr..."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true |..."*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  or  Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Narrator: "Monica lowered her voice."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true || BaseGame.Democratic < -10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  or  Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Narrator: "Monica lowered her voice."*)

### Węzeł `[551]`
Mówca: **Monica**
> ""But some part of me still sees you as the idealistic, driven man I married.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true"*)

### Węzeł `[552]`
Mówca: **Narrator**
> "Monica lowered her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Monica: ""Anton, I'm not completely naive. I know what we're propo..."*)

### Węzeł `[553]`
Mówca: **Monica**
> ""Anton, I'm not completely naive. I know what we're proposing would have its downsides.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Monica: ""But every time I look at our daughter, I think about how..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true"*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_SupportWomensRights == true)"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Monica: ""I know you would too. Just like you told me all those ye..."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_SupportWomensRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_SupportWomensRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Monica: "“I know you would too. Even if you might not admit it.""*)

### Węzeł `[557]`
Mówca: **Monica**
> ""But every time I look at our daughter, I think about how I'd do anything to grant her a better future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights == true"*)

### Węzeł `[558]`
Mówca: **Monica**
> "“I know you would too. Even if you might not admit it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Monica: "“I hope you'll make the right decision. We both do.""*)

### Węzeł `[559]`
Mówca: **Monica**
> ""I know you would too. Just like you told me all those years ago.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Monica: "“I hope you'll make the right decision. We both do.""*)

### Węzeł `[560]`
Mówca: **Narrator**
> "Ciara was looking studiously at a scratch on my desk. She blinked and turned back to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Ciara Walda: "“That's right, Mr. President.”"*)

### Węzeł `[561]`
Mówca: **Ciara Walda**
> "“That's right, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "They rose from their seats expectantly."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_USP_Obstructionist == true"*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_USP_Obstructionist == true)"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_USP_Obstructionist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_USP_Obstructionist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Enable_WomensRightsBill_Weak = true"*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_USP_Obstructionist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_USP_Obstructionist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Assembly_Vote >= 17"*)
