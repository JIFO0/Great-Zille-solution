# Sordland/Turn07/A_DayofDescension

- **ID konwersacji:** `92`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/092_A_DayofDescension.md`
- **Liczba węzłów dialogowych:** 333
- **Liczba wyborów gracza:** 61

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade
- **[55]** Archpriest

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_MediaDeal`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_Reformist_Path`
- `BaseGame.Relations_Albin_Bribed`
- `BaseGame.Relations_Albin_PromisedVP`
- `BaseGame.Relations_Frens_Bribed`
- `BaseGame.Relations_Monica_Slapped`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Relations_Walter_Promise_BailBusiness`
- `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled`
- `BaseGame.Relations_Walter_Promise_Company`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Relations_Walter_Promise_PrivatizationFulfilled`
- `BaseGame.Relations_Walter_Promise_TaxFulfilled`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn04_InT_HighwayIssue_Solved`
- `BaseGame.Turn04_InT_RailwayIssue_Solved`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGame.Turn05_Admin_Monica_Barred`
- `BaseGame.Turn07_GrantedShares_MarcelKoronti`
- `BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually`
- `BaseGame.Turn07_GrantedShares_WalterTusk`
- `BaseGameIsolated.Turn07_A_Confessed_BadHusband`
- `BaseGameIsolated.Turn07_A_Confessed_Bribery`
- `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual1`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual2`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual3`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual4`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual5`
- `BaseGameSupport.Journal_Turn06_HighwayOpening`
- `BaseGameSupport.Journal_Turn06_RailwayOpening`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Public_Opinion`
- `BaseGameIsolated.Turn07_A_Confessed_BadHusband`
- `BaseGameIsolated.Turn07_A_Confessed_Bribery`
- `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual1`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual2`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual3`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual4`
- `BaseGameIsolated.Turn07_A_SuccessfulRitual5`
- `BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual`
- `BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency`
- `BaseGameSupport.News_Turn07_LT_RitualWin`
- `BaseGameSupport.News_Turn07_R_RitualFailed`
- `BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal`
- `GameCondition.Turn07_A_DayOfDescension`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[11]` | **"“Yeah, sure.”"** | `[10]` **Lucian Galade**: "“Pretty straightforward, isn't it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucian Galade**: "“Very good.”" |
| `[12]` | **"“It's just a ceremony. Whatever.”"** | `[10]` **Lucian Galade**: "“Pretty straightforward, isn't it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucian Galade**: "“It's 'just' one of the most imp..." |
| `[13]` | **"“I didn't understand a word you just said.”"** | `[10]` **Lucian Galade**: "“Pretty straightforward, isn't it?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Lucian Galade**: "“Just do your best to remember i..." |
| `[18]` | **"Exit the car."** | `[17]` **Lucian Galade**: "“You will have to go first. I wi..." | `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false` | *Brak zmian stanu* | `[19]` **Narrator**: "The Archsanctuary was a sight to..." |
| `[23]` | **"“Thank you. It is nice to be here in Deyr again.”"** | `[21]` **Archpriest**: "“Mr. President. Praise God! It i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "The crowd was still booing angri..."<br>`[32]` **Narrator**: "The crowd was still cheering lou..." |
| `[24]` | **"“Archpriest.”"** | `[21]` **Archpriest**: "“Mr. President. Praise God! It i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "The crowd was still booing angri..."<br>`[32]` **Narrator**: "The crowd was still cheering lou..." |
| `[25]` | **"Bow your head before the Archpriest."** | `[21]` **Archpriest**: "“Mr. President. Praise God! It i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Narrator**: "The crowd was still booing angri..."<br>`[32]` **Narrator**: "The crowd was still cheering lou..." |
| `[27]` | **"“Sure. Let's get this over with.”"** | `[26]` **Archpriest**: "“Shall we move inside for your c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Archpriest**: "“Most excellent.”" |
| `[28]` | **"Pull the Archpriest aside for a photo."** | `[26]` **Archpriest**: "“Shall we move inside for your c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Archpriest**: "“Most excellent.”" |
| `[38]` | **"Grab the sceptre with your left hand, then touch the altar with your right."** | `[37]` **Narrator**: "I started my walk, bowed and app..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] =...` | `[41]` **Player_Italic**: "Sceptre in hand, I bowed to the ..."<br>`[40]` **Player_Italic**: "Sceptre in hand, I knelt before ..."<br>*(oraz 1 innych odgałęzień)* |
| `[39]` | **"Grab the sceptre with your right hand, then touch the altar with your left."** | `[37]` **Narrator**: "I started my walk, bowed and app..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Player_Italic**: "Sceptre in hand, I bowed to the ..."<br>`[40]` **Player_Italic**: "Sceptre in hand, I knelt before ..."<br>*(oraz 1 innych odgałęzień)* |
| `[40]` | **"Kneel before the Archpriest."** | `[39]` **Player_Italic**: "I grabbed the sceptre with my ri..."<br>`[38]` **Player_Italic**: "I grabbed the sceptre with my le..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] =...` | `[276]` **Narrator**: "The Archpriest lay the sword on ..." |
| `[41]` | **"Bow to the Archpriest."** | `[39]` **Player_Italic**: "I grabbed the sceptre with my ri..."<br>`[38]` **Player_Italic**: "I grabbed the sceptre with my le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The Archpriest lay the sword on ..." |
| `[42]` | **"Kiss the ring of the Archpriest."** | `[39]` **Player_Italic**: "I grabbed the sceptre with my ri..."<br>`[38]` **Player_Italic**: "I grabbed the sceptre with my le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Narrator**: "The Archpriest lay the sword on ..." |
| `[43]` | **"Touch the sword with your right hand."** | `[276]` **Narrator**: "The Archpriest lay the sword on ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] =...` | `[278]` **Player_Italic**: "I handed the sceptre to the Arch..."<br>`[279]` **Player_Italic**: "I handed the sceptre to the disc..." |
| `[44]` | **"Touch the sword with your left hand."** | `[276]` **Narrator**: "The Archpriest lay the sword on ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Player_Italic**: "I handed the sceptre to the Arch..."<br>`[279]` **Player_Italic**: "I handed the sceptre to the disc..." |
| `[83]` | **"“I hope we are not placing a target on our backs by coming here.”"** | `[10]` **Lucian Galade**: "“Pretty straightforward, isn't it?”" | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[84]` **Lucian Galade**: "“Don't worry sir. I have taken t..." |
| `[97]` | **"Exit the car."** | `[17]` **Lucian Galade**: "“You will have to go first. I wi..." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true` | *Brak zmian stanu* | `[19]` **Narrator**: "The Archsanctuary was a sight to..." |
| `[100]` | **"“My confession?”"** | `[26]` **Archpriest**: "“Shall we move inside for your c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Archpriest**: "“Yes. Just like last year. Every..." |
| `[107]` | **"“I confess that I have been a bad husband.”"** | `[106]` **Archpriest**: "“Anton Rayne. Speak. Speak and c..."<br>`[175]` **Player**: "“Fine. I will confess.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false` | *Brak zmian stanu* | `[120]` **Archpriest**: "“Family is the cornerstone of so..." |
| `[108]` | **"“I confess nothing. I haven't sinned.”"** | `[106]` **Archpriest**: "“Anton Rayne. Speak. Speak and c..."<br>`[175]` **Player**: "“Fine. I will confess.”"<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true) == false` | *Brak zmian stanu* | `[172]` **Archpriest**: "“Any man sins. We must all come ..." |
| `[109]` | **"“I confess that I was involved in shady dealings.”"** | `[106]` **Archpriest**: "“Anton Rayne. Speak. Speak and c..."<br>`[175]` **Player**: "“Fine. I will confess.”" | `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true`<br>`Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false` | *Brak zmian stanu* | `[113]` **Archpriest**: "“We all sin at one point in our ..." |
| `[115]` | **"“Walter Tusk.”"** | `[114]` **Archpriest**: "“Who was this sin committed with?”" | `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true` | *Brak zmian stanu* | `[118]` **Archpriest**: "“Hmm I see. This must've been do..." |
| `[116]` | **"“That is between me and God.”"** | `[114]` **Archpriest**: "“Who was this sin committed with?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Archpriest**: "“Very well. I shall not pry.”" |
| `[119]` | **"“I confess that I am not sure what I am doing for Sordland is enough.”"** | `[106]` **Archpriest**: "“Anton Rayne. Speak. Speak and c..."<br>`[175]` **Player**: "“Fine. I will confess.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false` | *Brak zmian stanu* | `[156]` **Archpriest**: "“You do carry a heavy burden on ..." |
| `[122]` | **"“I've been neglecting my family due to the stress of my position.”"** | `[121]` **Archpriest**: "“But God created us as complex c..." | `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false` | *Brak zmian stanu* | `[133]` **Archpriest**: "“Tragedy of neglect happens to a..." |
| `[123]` | **"“Against the wishes of my wife, I banned her from involvement in politics.”"** | `[121]` **Archpriest**: "“But God created us as complex c..." | `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true` | *Brak zmian stanu* | `[134]` **Archpriest**: "“As you know, this is not a sin...." |
| `[127]` | **"“I failed to support my wife at the Benfi Festival.”"** | `[121]` **Archpriest**: "“But God created us as complex c..." | `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false` | *Brak zmian stanu* | `[135]` **Archpriest**: "“A husband must support his wife..." |
| `[132]` | **"“That is between me and God.”"** | `[121]` **Archpriest**: "“But God created us as complex c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Archpriest**: "“Very well. I shall not pry.”" |
| `[141]` | **"“I am trying to reform the country, but I don't know if the country is ready for i..."** | `[139]` **Archpriest**: "“What you have confessed is not ..." | `Variable["BaseGame.Reform_Reformist_Path"] == true` | *Brak zmian stanu* | `[154]` **Archpriest**: "“Reformation is one of the tenet..." |
| `[151]` | **"“I still don't know if I am doing the right thing.”"** | `[139]` **Archpriest**: "“What you have confessed is not ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Archpriest**: "“Absolute certainty only belongs..." |
| `[152]` | **"“I want to centralize power, but I am not sure if I am ready for it.”"** | `[139]` **Archpriest**: "“What you have confessed is not ..." | `Variable["BaseGame.Reform_Dictator_Path"] == true` | *Brak zmian stanu* | `[155]` **Archpriest**: "“More power always means more re..." |
| `[153]` | **"“Everywhere I look, I see threats. I'm not sure I can handle them.”"** | `[139]` **Archpriest**: "“What you have confessed is not ..." | `Variable["BaseGame.Reform_Autocrat_Path"] == true` | *Brak zmian stanu* | `[157]` **Archpriest**: "“We must not falter against thre..." |
| `[159]` | **"“That's all for today.”"** | `[106]` **Archpriest**: "“Anton Rayne. Speak. Speak and c..."<br>`[175]` **Player**: "“Fine. I will confess.”"<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true` | *Brak zmian stanu* | `[170]` **Archpriest**: "“Before God, I thank you for sha..." |
| `[173]` | **"“I do not beg, Archpriest.”"** | `[174]` **Archpriest**: "“Please repent, Mr. President an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Archpriest**: "“Pride is the most dangerous vic..." |
| `[175]` | **"“Fine. I will confess.”"** | `[174]` **Archpriest**: "“Please repent, Mr. President an..." | `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false` | *Brak zmian stanu* | `[107]` **Player**: "“I confess that I have been a ba..."<br>`[119]` **Player**: "“I confess that I am not sure wh..."<br>*(oraz 3 innych odgałęzień)* |
| `[183]` | **"Extinguish the candles."** | `[182]` **Archpriest**: "“With this, the once burning sin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Archpriest**: "“Well done, Mr. President. Let's..." |
| `[188]` | **"“Absolutely.”"** | `[189]` **Archpriest**: "“Are you ready for the ceremony?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Archpriest**: "“Very good to hear.”" |
| `[190]` | **"“Yes. Let's get on with it.”"** | `[189]` **Archpriest**: "“Are you ready for the ceremony?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Archpriest**: "“Patience is a virtue, Mr. Presi..." |
| `[191]` | **"“I am a bit nervous.”"** | `[189]` **Archpriest**: "“Are you ready for the ceremony?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Archpriest**: "“Happens to the best of us. It w..." |
| `[209]` | **"“That's none of your business.”"** | `[208]` **Archpriest**: "“Of course we cannot ask you to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Archpriest**: "“You are right, Mr. President. I..." |
| `[211]` | **"“I agree. It was my fault. Won't happen again.”"** | `[208]` **Archpriest**: "“Of course we cannot ask you to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Archpriest**: "“Wonderful. Thank you for listen..." |
| `[212]` | **"“I let her do the speech because people like you still exist in Sordland.”"** | `[208]` **Archpriest**: "“Of course we cannot ask you to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Narrator**: "His face soured and he did not r..." |
| `[222]` | **"“Religion doesn't belong in schools. Just like it doesn't belong in my government'..."** | `[221]` **Archpriest**: "“The possibility that entire gen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Archpriest**: "“Well, I was just a--”" |
| `[223]` | **"“I didn't want to ban creationism. There were extenuating circumstances.""** | `[221]` **Archpriest**: "“The possibility that entire gen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Archpriest**: "“What kind of circumstances allo..." |
| `[224]` | **"“I did not ask you for your opinion.”"** | `[221]` **Archpriest**: "“The possibility that entire gen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Archpriest**: "“Yes, that is precisely why I--.”" |
| `[235]` | **"“Thank you. It is an honor.”"** | `[234]` **Archpriest**: "“This dagger belonged to King Eg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Archpriest**: "“Think of the past and think of ..." |
| `[236]` | **"“I can not accept this.”"** | `[234]` **Archpriest**: "“This dagger belonged to King Eg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Archpriest**: "“Yes you can, sir. It is now you..." |
| `[240]` | **"“Frens Ricter.”"** | `[114]` **Archpriest**: "“Who was this sin committed with?”" | `Variable["BaseGame.Relations_Frens_Bribed"] == true` | *Brak zmian stanu* | `[118]` **Archpriest**: "“Hmm I see. This must've been do..." |
| `[250]` | **"“I couldn't control myself and hit my wife.”"** | `[121]` **Archpriest**: "“But God created us as complex c..." | `Variable["BaseGame.Relations_Monica_Slapped"] == true` | *Brak zmian stanu* | `[251]` **Archpriest**: "“Physical abuse is a sin. But ev..." |
| `[268]` | **"“I take it you don't approve of the Religious Harmony bill.”"** | `[267]` **Archpriest**: "“So does every president.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Archpriest**: "“Yes, that's right. But today is..." |
| `[269]` | **"“So does every Archpriest, it seems.”"** | `[267]` **Archpriest**: "“So does every president.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Archpriest**: "“But of course. I am but a simpl..." |
| `[270]` | **"“Let's continue with the ceremony, Archpriest.”"** | `[267]` **Archpriest**: "“So does every president.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Archpriest**: "“Very well, Mr. President.”" |
| `[278]` | **"Hand the sceptre to the Archpriest."** | `[44]` **Player_Italic**: "I touched the sword with my left..."<br>`[43]` **Player_Italic**: "I touched the sword with my righ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] =...` | `[281]` **Narrator**: "The Archpriest handed me the sword." |
| `[279]` | **"Hand the sceptre to the disciples."** | `[44]` **Player_Italic**: "I touched the sword with my left..."<br>`[43]` **Player_Italic**: "I touched the sword with my righ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "The Archpriest handed me the sword." |
| `[282]` | **"Pass the sword to a disciple."** | `[281]` **Narrator**: "The Archpriest handed me the sword." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] =...` | `[45]` **Narrator**: "I got up and proceeded to my des..." |
| `[283]` | **"Hand the sword back to the Archpriest."** | `[281]` **Narrator**: "The Archpriest handed me the sword." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I got up and proceeded to my des..." |
| `[284]` | **"Place the sword on the altar."** | `[281]` **Narrator**: "The Archpriest handed me the sword." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "I got up and proceeded to my des..." |
| `[307]` | **"“Albin Clavin.”"** | `[114]` **Archpriest**: "“Who was this sin committed with?”" | `Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true` | *Brak zmian stanu* | `[118]` **Archpriest**: "“Hmm I see. This must've been do..." |
| `[314]` | **"“Marcel Koronti.”"** | `[114]` **Archpriest**: "“Who was this sin committed with?”" | `Variable["BaseGame.Accepted_MediaDeal"] == true` | *Brak zmian stanu* | `[118]` **Archpriest**: "“Hmm I see. This must've been do..." |
| `[325]` | **"“Do not test my limits. I kindly ask of you.”"** | `[174]` **Archpriest**: "“Please repent, Mr. President an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Archpriest**: "“Pride is the most dangerous vic..." |

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
  - -> `[3]` (*Narrator: "Morning haze surrounded the city of Deyr as the sun dawne..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Morning haze surrounded the city of Deyr as the sun dawned on the Day of Descension. The holiest day of the Nurity religion, it celebrated the first message received from God by Saint Dast and his thirty disciples."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As per tradition, the celebration was held inside the Arc..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "As per tradition, the celebration was held inside the Archsanctuary of Dastnurity, closed to the public eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "That was Lucian's idea. As he saw it, granting the people a rare glimpse of the Grand Ceremony, and showing them how seriously their President took this holy event, would ease any tensions that lingered in the region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "And so we arrived at the largest cathedral in Sordland. A..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "And so we arrived at the largest cathedral in Sordland. A huge crowd gathered around our convoy as our car pulled up to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: "“This will work out well. Trust me, sir.”"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“This will work out well. Trust me, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lucian Galade: "“Of course, that's only if the prayer is done completely ..."*)

### Węzeł `[8]`
Mówca: **Lucian Galade**
> "“Of course, that's only if the prayer is done completely correctly. Please don't forget the order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Lucian Galade: "“First, you will need to grasp the holy sceptre with your..."*)

### Węzeł `[9]`
Mówca: **Lucian Galade**
> "“First, you will need to grasp the holy sceptre with your left hand, then touch the altar with your right. Kneel before the Archpriest and wait for him to put the sword on your shoulder.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucian Galade: "“Then touch the sword with the hand you touched the altar..."*)

### Węzeł `[10]`
Mówca: **Lucian Galade**
> "“Pretty straightforward, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“It's just a ceremony. Whatever.”"*)
  - -> `[11]` (*Player: "“Yeah, sure.”"*)
  - -> `[13]` (*Player: "“I didn't understand a word you just said.”"*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Yeah, sure.”"]** — Mówca: **Player**
> "“Yeah, sure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: "“Very good.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“It's just a ceremony. Whatever.”"]** — Mówca: **Player**
> "“It's just a ceremony. Whatever.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: "“It's 'just' one of the most important ceremonies in Sord..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“I didn't understand a word you just said.”"]** — Mówca: **Player**
> "“I didn't understand a word you just said.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucian Galade: "“Just do your best to remember it. We can't afford to los..."*)

### Węzeł `[14]`
Mówca: **Lucian Galade**
> "“Just do your best to remember it. We can't afford to lose our religious base over this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“You will have to go first. I will come inside later and ..."*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“You will have to go first. I will come inside later and ..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> "“It's 'just' one of the most important ceremonies in Sordland. Especially for Deyr's Bludish residents.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“You will have to go first. I will come inside later and ..."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> "“You will have to go first. I will come inside later and we will meet up after your part is done. Good luck, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "Exit the car."]** — Mówca: **Player_Italic**
> "I exited the car and I was greeted by a chorus of cheers and camera flashes. I waved to the people as I made my way to the grand gates."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The Archsanctuary was a sight to see. With its towering v..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "The Archsanctuary was a sight to see. With its towering visage, it cast a shadow over a large portion of the city. I had to crane my neck to see the narrow spires at the top. Just standing next to it made me feel awe and dread in equal measure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "As I reached the gates, I spotted my welcoming committee...."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "As I reached the gates, I spotted my welcoming committee. The Archpriest and his disciples were waiting for my arrival. At my approach, they all bowed their heads in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "The Archpriest gave me an infectious smile as he straight..."*)

### Węzeł `[21]`
Mówca: **Archpriest**
> "“Mr. President. Praise God! It is a blessing to see you on our most holy day again. Welcome, welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Italic: "Bow your head before the Archpriest."*)
  - -> `[24]` (*Player: "“Archpriest.”"*)
  - -> `[23]` (*Player: "“Thank you. It is nice to be here in Deyr again.”"*)

### Węzeł `[22]`
Mówca: **Narrator**
> "He led me through the main hall, which had a stratospheric ceiling and Nurist icons lining the walls. We walked up a creaking spiral staircase to the top floor and finally arrived in front of the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Archpriest: "“Right this way.”"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Thank you. It is nice to be here in Deyr again.”"]** — Mówca: **Player**
> "“Thank you. It is nice to be here in Deyr again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Archpriest.”"]** — Mówca: **Player**
> "“Archpriest.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "Bow your head before the Archpriest."]** — Mówca: **Player_Italic**
> "I bowed my head before the Archpriest, which triggered a few murmurs of approval from the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[26]`
Mówca: **Archpriest**
> "“Shall we move inside for your confession?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Italic: "Pull the Archpriest aside for a photo."*)
  - -> `[27]` (*Player: "“Sure. Let's get this over with.”"*)
  - -> `[100]` (*Player: "“My confession?”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Sure. Let's get this over with.”"]** — Mówca: **Player**
> "“Sure. Let's get this over with.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Archpriest: "“Most excellent.”"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "Pull the Archpriest aside for a photo."]** — Mówca: **Player_Italic**
> "I pulled the Archpriest aside for a photo. Many flashbulbs burned my eyes at the same time. I heard whistles, claps and cheers from the crowd."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Archpriest: "“Most excellent.”"*)

### Węzeł `[29]`
Mówca: **Archpriest**
> "“Most excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[30]`
Mówca: **Narrator**
> "The Archpriest gave me an infectious smile as he straightened back up. Tall and handsome, in his mid-50s, he was one of the youngest and most popular Archpriests in history. Some of his more avid followers even likened him to Saint Dast."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Archpriest: "“Mr. President. Praise God! It is a blessing to see you o..."*)

### Węzeł `[31]`
Mówca: **Archpriest**
> "“Oh, great people of Sordland! Once again we are gathered here to honor the Day of Descension!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Archpriest: "“I am indescribably happy to be sharing this moment with ..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The crowd was still cheering loudly. The Archpriest turned and raised both of his hands, and everyone immediately fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Archpriest: "“Oh, great people of Sordland! Once again we are gathered..."*)

### Węzeł `[33]`
Mówca: **Archpriest**
> "“I am indescribably happy to be sharing this moment with you as well as every Blud and Sord, old and young, tuning in to their television to watch this holy commemoration!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Archpriest: "“Along with the leader of our great nation, I say: Let th..."*)

### Węzeł `[34]`
Mówca: **Archpriest**
> "“Along with the leader of our great nation, I say: Let the holy day begin!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Archpriest: "“Stay far from evil, oh sons and daughters, for evil hide..."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He smiled beatifically as the crowd burst into rapturous applause. After it subsided, he turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Archpriest: "“Shall we move inside for your confession?”"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "We made our way downstairs where the ceremony was already in progress. The choir sang angelically as the Archpriest took his position beside the altar. When they finished their hymn, an expectant silence fell over the room. It was time for my part."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "I started my walk, bowed and approached the altar."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "I started my walk, bowed and approached the altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Italic: "Grab the sceptre with your left hand, then touch the alta..."*)
  - -> `[39]` (*Player_Italic: "Grab the sceptre with your right hand, then touch the alt..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Grab the sceptre with your left hand, then touch the altar with your right."]** — Mówca: **Player_Italic**
> "I grabbed the sceptre with my left hand, then touched the altar with my right."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 = true"*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "Grab the sceptre with your right hand, then touch the altar with your left."]** — Mówca: **Player_Italic**
> "I grabbed the sceptre with my right hand then touched the altar with left."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Italic: "Bow to the Archpriest."*)
  - -> `[40]` (*Player_Italic: "Kneel before the Archpriest."*)
  - -> `[42]` (*Player_Italic: "Kiss the ring of the Archpriest."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "Kneel before the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I knelt before the Archpriest."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Player_Italic), `[38]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual2 = true"*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "Bow to the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I bowed to the Archpriest."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Player_Italic), `[38]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The Archpriest lay the sword on my shoulder."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "Kiss the ring of the Archpriest."]** — Mówca: **Player_Italic**
> "Sceptre in hand, I kissed the ring of the Archpriest."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Player_Italic), `[38]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The Archpriest lay the sword on my shoulder."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Touch the sword with your right hand."]** — Mówca: **Player_Italic**
> "I touched the sword with my right hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual3 = true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Touch the sword with your left hand."]** — Mówca: **Player_Italic**
> "I touched the sword with my left hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Italic: "Hand the sceptre to the Archpriest."*)
  - -> `[279]` (*Player_Italic: "Hand the sceptre to the disciples."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "I got up and proceeded to my designated spot next to Lucian. He leaned over and whispered in my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Italic: "Bow to the Archpriest."*)
  - -> `[40]` (*Player_Italic: "Kneel before the Archpriest."*)
  - -> `[42]` (*Player_Italic: "Kiss the ring of the Archpriest."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Narrator: "The Archpriest lay the sword on my shoulder."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player_Italic: "Hand the sceptre to the Archpriest."*)
  - -> `[279]` (*Player_Italic: "Hand the sceptre to the disciples."*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> "“Compared to last year, that went surprisingly well, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 1;"*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Unfortunately that was not quite correct, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 3; BaseGame.Bludish_Opinion -= 1;"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && ..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and 
Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: "“Compared to last year, that went surprisingly well, sir.”"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true &&
BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and 
Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: "“Unfortunately that was not quite correct, sir.”"*)

### Węzeł `[54]`
Mówca: **Narrator**
> "My eyes met the Archpriest's and he very slightly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The ceremony went on for another hour and a half. Finally..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "My eyes met the Archpriest's and he very slightly nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The ceremony went on for another hour and a half. Finally..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The ceremony went on for another hour and a half. Finally, the noon bells chimed, marking the end of the cathedral service."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "We entered our cars and drove back to our suites in Deyr."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn07_A_DayOfDescension = true"*)

### Węzeł `[58]`
Mówca: **Narrator**
> "We left the cathedral to greet the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && ..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowd");"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BooScatter");"*)

### Węzeł `[62]`
Mówca: **Narrator**
> "As I walked outside, I heard scattered boos. A man in a Worker's Party of Bludia shirt shouted that I was only here for show, that I couldn't even bother to get the ceremony right. Others yelled in agreement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: "“We should go before things get heated.”"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "As I stepped outside, I heard everyone cheering and chanting my name. Lucian's gambit seemed to have been a success. We waved proudly for a minute or two."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucian Galade: "“See, sir. I told you it would work.”"*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "We entered our cars and drove back to our suites in Deyr."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)

### Węzeł `[68]`
Mówca: **Lucian Galade**
> "“See, sir. I told you it would work.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "We entered our cars and drove back to our suites in Deyr."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && Ba..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && ..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BooScatter");"*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_SuccessfulRitual1 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual2 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual3 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual4 == true && BaseGameIsolated.Turn07_A_SuccessfulRitual5 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual1"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual2"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual3"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] == true  and  Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("FuriousJeers");"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "As I walked outside, I heard scattered boos. A man in a shirt bearing the colors of the Bludish flag shouted that I'd only done the ceremony for show. Lucian hadn't been exactly right about my presence easing tensions, it seemed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: "“We should go before things get heated.”"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "As I stepped outside, I heard furious jeers. Guards shielded me as people in the crowd began throwing cans and bottles in my direction. Because I'd messed up the ceremony so badly, my presence here hadn't eased tensions -- it had done the opposite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lucian Galade: "“We should go before things get heated.”"*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "We entered our cars and drove back to our suites in Deyr."*)

### Węzeł `[75]`
Mówca: **Lucian Galade**
> "“We should go before things get heated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "We entered our cars and drove back to our suites in Deyr."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "That was Lucian's idea. As he saw it, granting the people..."*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "That was Lucian's idea. As he saw it, granting the people..."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "That was Lucian's idea. As he saw it, granting the people a rare glimpse of the Grand Ceremony, and showing them how seriously their President took this holy event, would ease the tensions that lingered following my decree to ban the Workers' Party of Bludia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "And so we arrived at the largest cathedral in Sordland. A..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“I hope we are not placing a target on our backs by comin..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I hope we are not placing a target on our backs by coming here.”"]** — Mówca: **Player**
> "“I hope we are not placing a target on our backs by coming here.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: "“Don't worry sir. I have taken the required precautions.”"*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> "“Don't worry sir. I have taken the required precautions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: "“You will have to go first. I will come inside later and ..."*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "The crowd was still booing angrily. The Archpriest turned..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The crowd was still cheering loudly. The Archpriest turne..."*)

### Węzeł `[88]`
Mówca: **Archpriest**
> "“Oh, great people of Sordland! Once again we are gathered here to honor the Day of Descension!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Archpriest: "“I am indescribably happy to be sharing this moment with ..."*)

### Węzeł `[89]`
Mówca: **Archpriest**
> "“I am indescribably happy to be sharing this moment with you as well as every Blud and Sord, old and young, tuning in to their television to watch this holy commemoration!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Archpriest: "“In these times of turmoil, we must unite! By the grace o..."*)

### Węzeł `[90]`
Mówca: **Archpriest**
> "“In these times of turmoil, we must unite! By the grace of God, the president is here today to show his will to unify our great country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Archpriest: "“Stay far from evil, oh sons and daughters, for evil hide..."*)

### Węzeł `[91]`
Mówca: **Archpriest**
> "“Stay far from evil, oh sons and daughters, for evil hides itself under many disguises. Disguises such as blasphemy, apostasy and even alcohol!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Archpriest: "“Be good, my children! Praise God! Praise Sordland!”"*)

### Węzeł `[92]`
Mówca: **Archpriest**
> "“Be good, my children! Praise God! Praise Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He smiled beatifically as the crowd burst into rapturous ..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "The crowd was still booing angrily. The Archpriest turned and raised both of his hands, and everyone immediately fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Archpriest: "“Oh, great people of Sordland! Once again we are gathered..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("BooCrowd");"*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("CheerCrowdCamera");"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Exit the car."]** — Mówca: **Player_Italic**
> "I exited the car and was greeted by a chorus of boos. Some people in the crowd began raising signs and chanting in protest of my ban. I ducked my head as the guards quickly ushered me to the grand gates."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "The Archsanctuary was a sight to see. With its towering v..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn07_A_DayOfDescension = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn07_A_DayOfDescension"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_..."*)

### Węzeł `[99]`
Mówca: **Lucian Galade**
> "“Then touch the sword with the hand you touched the altar with. Hand the sceptre over to the Archpriest and receive the sword before passing it on to a disciple.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucian Galade: "“Pretty straightforward, isn't it?”"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“My confession?”"]** — Mówca: **Player**
> "“My confession?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Archpriest: "“Yes. Just like last year. Every man must confess before ..."*)

### Węzeł `[101]`
Mówca: **Archpriest**
> "“Yes. Just like last year. Every man must confess before the holy ceremony starts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[102]`
Mówca: **Narrator**
> "He gestured towards a chair in the dark room. The room smelled of old mahogany and scented candles. The Archpriest proceeded to light each and every one of the candles. One for each virtue and vice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Archpriest: "“I will be right with you.”"*)

### Węzeł `[103]`
Mówca: **Archpriest**
> "“Right this way.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "He gestured towards a chair in the dark room. The room sm..."*)

### Węzeł `[104]`
Mówca: **Archpriest**
> "“I will be right with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "He left the room. A minute later, I heard the sound of a ..."*)

### Węzeł `[105]`
Mówca: **Narrator**
> "He left the room. A minute later, I heard the sound of a sliding window right next to me. He spoke with a very soft voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Archpriest: "“Anton Rayne. Speak. Speak and confess now before the one..."*)

### Węzeł `[106]`
Mówca: **Archpriest**
> "“Anton Rayne. Speak. Speak and confess now before the one God and may He repent your sins on the most holy Day of Descension.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "Jump to: [Confession Hub]"*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“I confess that I have been a bad husband.”"]** — Mówca: **Player**
> "“I confess that I have been a bad husband.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Archpriest), `[175]` (Player), `[158]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Archpriest: "“Family is the cornerstone of society. Under the watchful..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: "“I confess nothing. I haven't sinned.”"]** — Mówca: **Player**
> "“I confess nothing. I haven't sinned.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Archpriest), `[175]` (Player), `[158]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Archpriest: "“Any man sins. We must all come to terms with it. This is..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: "“I confess that I was involved in shady dealings.”"]** — Mówca: **Player**
> "“I confess that I was involved in shady dealings.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true` AND `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Archpriest), `[175]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Archpriest: "“We all sin at one point in our lives. Such is the human ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Bribed == true || BaseGame.Rel..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: "“I confess that I was involved in shady dealings.”"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Bribed == true || BaseGame.Relations_Walter_Promise_BailBusiness == true || BaseGame.Relations_Walter_Promise_Company == true || BaseGame.Turn07_GrantedShares_MarcelKoronti == true || BaseGame.Turn07_GrantedShares_WalterTusk == true || BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually == true || BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true || BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true  or  Variable["BaseGame.Relations_Walter_Promise_BailBusiness"] == true  or  Variable["BaseGame.Relations_Walter_Promise_Company"] == true  or  Variable["BaseGame.Turn07_GrantedShares_MarcelKoronti"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterTusk"] == true  or  Variable["BaseGame.Turn07_GrantedShares_WalterAndMarcelEqually"] == true  or  Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"]  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true  or  Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
Mówca: **Archpriest**
> "“We all sin at one point in our lives. Such is the human nature as deemed by God. We sometimes sin because of necessity. Yet like all, we must repent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Archpriest: "“Who was this sin committed with?”"*)

### Węzeł `[114]`
Mówca: **Archpriest**
> "“Who was this sin committed with?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_Bribed == true || BaseGame.Relat..."*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[116]` (*Player: "“That is between me and God.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Walter Tusk.”"]** — Mówca: **Player**
> "“Walter Tusk.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Kontekst wejściowy (poprzednik):** `[114]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Archpriest: "“Hmm I see. This must've been done out of necessity for t..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“That is between me and God.”"]** — Mówca: **Player**
> "“That is between me and God.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Archpriest: "“Very well. I shall not pry.”"*)

### Węzeł `[117]`
Mówca: **Archpriest**
> "“Very well. I shall not pry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[118]`
Mówca: **Archpriest**
> "“Hmm I see. This must've been done out of necessity for the greater good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I confess that I am not sure what I am doing for Sordland is enough.”"]** — Mówca: **Player**
> "“I confess that I am not sure what I am doing for Sordland is enough.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false`
- **Kontekst wejściowy (poprzednik):** `[106]` (Archpriest), `[175]` (Player), `[158]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Archpriest: "“You do carry a heavy burden on your shoulders.”"*)

### Węzeł `[120]`
Mówca: **Archpriest**
> "“Family is the cornerstone of society. Under the watchful eyes of the God, men are required to protect their wives and family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Archpriest: "“But God created us as complex creatures. At times, confl..."*)

### Węzeł `[121]`
Mówca: **Archpriest**
> "“But God created us as complex creatures. At times, conflicts rise among us. Tell me, what was your sin?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[132]` (*Player: "“That is between me and God.”"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == false"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“I've been neglecting my family due to the stress of my position.”"]** — Mówca: **Player**
> "“I've been neglecting my family due to the stress of my position.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[121]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Archpriest: "“Tragedy of neglect happens to all working men that feeds..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“Against the wishes of my wife, I banned her from involvement in politics.”"]** — Mówca: **Player**
> "“Against the wishes of my wife, I banned her from involvement in politics.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Kontekst wejściowy (poprzednik):** `[121]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Archpriest: "“As you know, this is not a sin. In fact it is the exact ..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Admin_Monica_Barred == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Admin_Monica_Barred == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Admin_Monica_Barred == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“Against the wishes of my wife, I banned her from involve..."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Admin_Monica_Barred == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Admin_Monica_Barred"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[127]`
**[WYBÓR GRACZA: "“I failed to support my wife at the Benfi Festival.”"]** — Mówca: **Player**
> "“I failed to support my wife at the Benfi Festival.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Kontekst wejściowy (poprzednik):** `[121]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Archpriest: "“A husband must support his wife. You have taken the vows..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == false"*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == false)"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: "“I failed to support my wife at the Benfi Festival.”"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[131]`
Mówca: **Archpriest**
> "“Very well. I shall not pry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“That is between me and God.”"]** — Mówca: **Player**
> "“That is between me and God.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Archpriest: "“Very well. I shall not pry.”"*)

### Węzeł `[133]`
Mówca: **Archpriest**
> "“Tragedy of neglect happens to all working men that feeds his family. Rejoice. God is kind in the matters of family.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[134]`
Mówca: **Archpriest**
> "“As you know, this is not a sin. In fact it is the exact opposite. A woman's place is beside her family. Not political podiums. You need not repent for this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[135]`
Mówca: **Archpriest**
> "“A husband must support his wife. You have taken the vows and you must uphold them. In this case, however, it is different. A woman's place is beside her family. Not political podiums.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[136]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_Bribery = true"*)

### Węzeł `[137]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_BadHusband = true"*)

### Węzeł `[138]`
Mówca: **Archpriest**
> "“Absolute certainty only belongs to God. All else feels uncertainty many times in their lives. This is especially true for men of power.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[139]`
Mówca: **Archpriest**
> "“What you have confessed is not a sin. But you may share your burden with me if you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“I still don't know if I am doing the right thing.”"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Confession Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_Bribery == false"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_BadHusband == false"*)
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_Bribery == true || Ba..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“I am trying to reform the country, but I don't know if the country is ready for it yet.”"]** — Mówca: **Player**
> "“I am trying to reform the country, but I don't know if the country is ready for that yet.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Archpriest: "“Reformation is one of the tenets of Nurity. Yet it must ..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Path == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“I am trying to reform the country, but I don't know if t..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Path == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "“I want to centralize power, but I am not sure if I am re..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "“I want to centralize power, but I am not sure if I am re..."*)
  - -> `[153]` (*Player: "“Everywhere I look, I see threats. I'm not sure I can han..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I still don't know if I am doing the right thing.”"]** — Mówca: **Player**
> "“I still don't know if I am doing the right thing.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Archpriest: "“Absolute certainty only belongs to God. All else feels u..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“I want to centralize power, but I am not sure if I am ready for it.”"]** — Mówca: **Player**
> "“I want to centralize power, but I am not sure if I am ready for it.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Archpriest: "“More power always means more responsibility. We are only..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA: "“Everywhere I look, I see threats. I'm not sure I can handle them.”"]** — Mówca: **Player**
> "“Everywhere I look, I see threats. I'm not sure I can handle them.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Archpriest: "“We must not falter against threats. Otherwise, we shall ..."*)

### Węzeł `[154]`
Mówca: **Archpriest**
> "“Reformation is one of the tenets of Nurity. Yet it must come slowly but surely.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[155]`
Mówca: **Archpriest**
> "“More power always means more responsibility. We are only men after all. Leading men carry this on their shoulders and you are no different.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[156]`
Mówca: **Archpriest**
> "“You do carry a heavy burden on your shoulders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Archpriest: "“What you have confessed is not a sin. But you may share ..."*)

### Węzeł `[157]`
Mówca: **Archpriest**
> "“We must not falter against threats. Otherwise, we shall be consumed by evil. Without eliminating the threats, there can be no serenity.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[158]`
Mówca: **Archpriest**
> "“Anything else you would like to confess?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_SelfDoubt = true"*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“That's all for today.”"]** — Mówca: **Player**
> "“That's all for today.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true`
- **Kontekst wejściowy (poprzednik):** `[106]` (Archpriest), `[175]` (Player), `[158]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Archpriest: "“Before God, I thank you for sharing.”"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Confession Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Confession Hub"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Confession Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Confession Hub"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_Bribery == true || Ba..."*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Confessed_Bribery == true || ..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player: "“That's all for today.”"*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Confessed_Bribery == true || BaseGameIsolated.Turn07_A_Confessed_BadHusband == true || BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == true  or  Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Player: "“I confess nothing. I haven't sinned.”"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "Jump to: [Confession Hub]"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Confession Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Confession Hub"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_BadHusband = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "Jump to: [Confession Hub]"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Confession Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Confession Hub"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_Bribery = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "Jump to: [Confession Hub]"*)

### Węzeł `[170]`
Mówca: **Archpriest**
> "“Before God, I thank you for sharing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Archpriest: "“You are now forgiven before God, Anton Rayne. May you ne..."*)

### Węzeł `[171]`
Mówca: **Archpriest**
> "“You are now forgiven before God, Anton Rayne. May you never sin again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The sliding window closed, and the Archpriest entered the..."*)

### Węzeł `[172]`
Mówca: **Archpriest**
> "“Any man sins. We must all come to terms with it. This is your chance to repent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Archpriest: "“Please repent, Mr. President and you shall be freed of t..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "“I do not beg, Archpriest.”"]** — Mówca: **Player**
> "“I do not beg, Archpriest.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Archpriest: "“Pride is the most dangerous vice of all. Perhaps you wil..."*)

### Węzeł `[174]`
Mówca: **Archpriest**
> "“Please repent, Mr. President and you shall be freed of the burden of your sins. If you beg for forgiveness from God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: "“I do not beg, Archpriest.”"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false ||..."*)
  - -> `[325]` (*Player: "“Do not test my limits. I kindly ask of you.”"*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "“Fine. I will confess.”"]** — Mówca: **Player**
> "“Fine. I will confess.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Kontekst wejściowy (poprzednik):** `[174]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump to: [Confession Hub]"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Confession Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Confession Hub"*)

### Węzeł `[177]`
Mówca: **Archpriest**
> "“Pride is the most dangerous vice of all. Perhaps you will come to this realization at one point in your life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "The sliding window closed, and the Archpriest entered the..."*)

### Węzeł `[178]`
Mówca: **Archpriest**
> "“For the confession to end, you must extinguish the candles representing each one of your virtues and vices.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Archpriest: "“With this, the once burning sins connected to you are no..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "The sliding window closed, and the Archpriest entered the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Archpriest: "“For the confession to end, you must extinguish the candl..."*)

### Węzeł `[180]`
Mówca: **Narrator**
> "The sliding window closed, and the Archpriest entered the confession chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Archpriest: "“Let's move on to my quarters before the ceremony.”"*)

### Węzeł `[181]`
Mówca: **Archpriest**
> "“Let's move on to my quarters before the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "He led me through the thousand-year-old corridors to his ..."*)

### Węzeł `[182]`
Mówca: **Archpriest**
> "“With this, the once burning sins connected to you are now smoke and then nothing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Italic: "Extinguish the candles."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "Extinguish the candles."]** — Mówca: **Player_Italic**
> "One by one, I extinguished the candles."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Archpriest: "“Well done, Mr. President. Let's move on to my quarters b..."*)

### Węzeł `[184]`
Mówca: **Archpriest**
> "“Well done, Mr. President. Let's move on to my quarters before the ceremony.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "He led me through the thousand-year-old corridors to his ..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "He led me through the thousand-year-old corridors to his office. The smell of dust and old tomes was in the air, along with the scent of burning incense being prepared for the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Archpriest: "“Well then, please have a seat.”"*)

### Węzeł `[186]`
Mówca: **Archpriest**
> "“Well then, please have a seat.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "The wooden chair next to him looked like it might turn to..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "The wooden chair next to him looked like it might turn to dust at a single touch. I sat down gingerly. It was surprisingly sturdy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Archpriest: "“Are you ready for the ceremony?”"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“Absolutely.”"]** — Mówca: **Player**
> "“Absolutely.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Archpriest: "“Very good to hear.”"*)

### Węzeł `[189]`
Mówca: **Archpriest**
> "“Are you ready for the ceremony?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "“Absolutely.”"*)
  - -> `[191]` (*Player: "“I am a bit nervous.”"*)
  - -> `[190]` (*Player: "“Yes. Let's get on with it.”"*)

### Węzeł `[190]`
**[WYBÓR GRACZA: "“Yes. Let's get on with it.”"]** — Mówca: **Player**
> "“Yes. Let's get on with it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Archpriest: "“Patience is a virtue, Mr. President.”"*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "“I am a bit nervous.”"]** — Mówca: **Player**
> "“I am a bit nervous.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Archpriest: "“Happens to the best of us. It will be televised, after a..."*)

### Węzeł `[192]`
Mówca: **Archpriest**
> "“Happens to the best of us. It will be televised, after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "He leaned back in his chair comfortably."*)

### Węzeł `[193]`
Mówca: **Archpriest**
> "“Patience is a virtue, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "He leaned back in his chair comfortably."*)

### Węzeł `[194]`
Mówca: **Archpriest**
> "“Very good to hear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "He leaned back in his chair comfortably."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Archpriest: "“I wanted to talk to you about something.”"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)

### Węzeł `[198]`
Mówca: **Archpriest**
> "“I wanted to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Archpriest: "“I realize it has been months since the Benfi Festival, b..."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "He leaned back in his chair comfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationis..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Archpriest: "“I wanted to talk to you about something.”"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Archpriest: "“I wanted to give you something. A gift to celebrate this..."*)

### Węzeł `[203]`
Mówca: **Archpriest**
> "“I wanted to talk to you about something.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Archpriest: "“I heard you decided on the new school curriculum...”"*)

### Węzeł `[204]`
Mówca: **Archpriest**
> "“I realize it has been months since the Benfi Festival, but this is my first chance to bring it up with you. It's about the actions of the First Lady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Archpriest: "“As you know, the festival is a holy event. Letting a wom..."*)

### Węzeł `[205]`
Mówca: **Archpriest**
> "“I wanted to give you something. A gift to celebrate this special day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "He pulled out a large rectangular box from his desk drawe..."*)

### Węzeł `[206]`
Mówca: **Archpriest**
> "“As you know, the festival is a holy event. Letting a woman make the opening speech did not sit well with us. We share the same concerns as Mr. Leste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Archpriest: "“A woman's place is beside her family, not giving public ..."*)

### Węzeł `[207]`
Mówca: **Archpriest**
> "“A woman's place is beside her family, not giving public speeches in revealing dresses. Certainly not insulting the important traditions behind such an event.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Disgust was apparent on his face."*)

### Węzeł `[208]`
Mówca: **Archpriest**
> "“Of course we cannot ask you to do anything about it. She is your wife. But I just wanted to voice our disproval of the situation. A woman presiding over such an important religious event. What have we become?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: "“I let her do the speech because people like you still ex..."*)
  - -> `[209]` (*Player: "“That's none of your business.”"*)
  - -> `[211]` (*Player: "“I agree. It was my fault. Won't happen again.”"*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "“That's none of your business.”"]** — Mówca: **Player**
> "“That's none of your business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Archpriest: "“You are right, Mr. President. I just wanted to voice our..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Disgust was apparent on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Archpriest: "“Of course we cannot ask you to do anything about it. She..."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“I agree. It was my fault. Won't happen again.”"]** — Mówca: **Player**
> "“I agree. It was my fault. Won't happen again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Archpriest: "“Wonderful. Thank you for listening to our concerns, Mr. ..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA: "“I let her do the speech because people like you still exist in Sordland.”"]** — Mówca: **Player**
> "“I let her do the speech because people like you still exist in Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "His face soured and he did not reply. He looked me up and..."*)

### Węzeł `[213]`
Mówca: **Archpriest**
> "“Wonderful. Thank you for listening to our concerns, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)

### Węzeł `[214]`
Mówca: **Archpriest**
> "“You are right, Mr. President. I just wanted to voice our opinion on the matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "His face soured and he did not reply. He looked me up and down for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism ..."*)
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationis..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Archpriest: "“I also heard you decided on the new curriculum...”"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EvolutionMandatoryBanCreationism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "A couple of knocks were heard on the door and a young boy..."*)

### Węzeł `[219]`
Mówca: **Archpriest**
> "“I also heard you decided on the new curriculum...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Archpriest: "“...And decided that creationism shall no longer be taugh..."*)

### Węzeł `[220]`
Mówca: **Archpriest**
> "“...And decided that creationism shall no longer be taught in Sordland's schools. Needless to say, both I and the Sanctuary are outraged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Archpriest: "“The possibility that entire generations of schoolchildre..."*)

### Węzeł `[221]`
Mówca: **Archpriest**
> "“The possibility that entire generations of schoolchildren will have their minds filled with nonsense about 'evolution' while failing to learn one of the main tenets of Nurity... it will hurt us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: "“Religion doesn't belong in schools. Just like it doesn't..."*)
  - -> `[223]` (*Player: "“I didn't want to ban creationism. There were extenuating..."*)
  - -> `[224]` (*Player: "“I did not ask you for your opinion.”"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“Religion doesn't belong in schools. Just like it doesn't belong in my government's policies.”"]** — Mówca: **Player**
> "“Religion doesn't belong in schools. Just like it doesn't belong in my government's policies.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Archpriest: "“Well, I was just a--”"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I didn't want to ban creationism. There were extenuating circumstances.""]** — Mówca: **Player**
> "“I didn't want to ban creationism. There were extenuating circumstances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Archpriest: "“What kind of circumstances allow such a--.”"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“I did not ask you for your opinion.”"]** — Mówca: **Player**
> "“I did not ask you for your opinion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Archpriest: "“Yes, that is precisely why I--.”"*)

### Węzeł `[225]`
Mówca: **Archpriest**
> "“What kind of circumstances allow such a--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "A couple of knocks were heard on the door and a young boy..."*)

### Węzeł `[226]`
Mówca: **Archpriest**
> "“Well, I was just a--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "A couple of knocks were heard on the door and a young boy..."*)

### Węzeł `[227]`
Mówca: **Archpriest**
> "“Yes, that is precisely why I--.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "A couple of knocks were heard on the door and a young boy..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "A couple of knocks were heard on the door and a young boy came in. He bowed before the Archpriest, then me, before letting us know that the ceremony was about to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We made our way downstairs where the ceremony was already..."*)

### Węzeł `[229]`
Mówca: **Archpriest**
> "“I heard you decided on the new school curriculum...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Archpriest: "“...And decided that creationism shall no longer be taugh..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "He pulled out a large rectangular box from his desk drawer. The box was lined with gold and expensive gemstones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Archpriest: "“A beautiful sight, isn't it?”"*)

### Węzeł `[231]`
Mówca: **Archpriest**
> "“A beautiful sight, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "He opened the box and showed me what was inside."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "He opened the box and showed me what was inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "It was a dagger. The handle looked like it was made of pu..."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "It was a dagger. The handle looked like it was made of pure gold and had a very large gem at the end. On the blade, the words were inscribed: "Vectern sis da!". Victory is close. On the other side, another set of words: "King Egmund"."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Archpriest: "“This dagger belonged to King Egmund. It is a very import..."*)

### Węzeł `[234]`
Mówca: **Archpriest**
> "“This dagger belonged to King Egmund. It is a very important artifact of the Kingdom of Sordland era. It is now yours, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: "“Thank you. It is an honor.”"*)
  - -> `[236]` (*Player: "“I can not accept this.”"*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "“Thank you. It is an honor.”"]** — Mówca: **Player**
> "“Thank you. It is an honor.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Archpriest: "“Think of the past and think of who we are. Traditions ar..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: "“I can not accept this.”"]** — Mówca: **Player**
> "“I cannot accept this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[234]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Archpriest: "“Yes you can, sir. It is now yours. Think of the past and..."*)

### Węzeł `[237]`
Mówca: **Archpriest**
> "“Yes you can, sir. It is now yours. Think of the past and think of who we are. Traditions are what brought us to this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Archpriest: "“Now then, it should be right about time.”"*)

### Węzeł `[238]`
Mówca: **Archpriest**
> "“Think of the past and think of who we are. Traditions are what brought us to this point.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Archpriest: "“Now then, it should be right about time.”"*)

### Węzeł `[239]`
Mówca: **Archpriest**
> "“Now then, it should be right about time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_Dagger");"*)

### Węzeł `[240]`
**[WYBÓR GRACZA: "“Frens Ricter.”"]** — Mówca: **Player**
> "“Frens Ricter.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Kontekst wejściowy (poprzednik):** `[114]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Archpriest: "“Hmm I see. This must've been done out of necessity for t..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Frens_Bribed == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Frens_Bribed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Frens_Bribed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: "“Frens Ricter.”"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Frens_Bribed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Frens_Bribed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Walter_Promise_BailBusinessFulfilled =..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“Walter Tusk.”"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Walter_Promise_BailBusinessFulfilled == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Relations_Walter_Promise_PrivatizationFulfilled == true || BaseGame.Relations_Walter_Promise_TaxFulfilled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Walter_Promise_BailBusinessFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_PrivatizationFulfilled"] == true  or  Variable["BaseGame.Relations_Walter_Promise_TaxFulfilled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Slapped == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Slapped == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Slapped == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: "“I couldn't control myself and hit my wife.”"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Slapped == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Slapped"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: "“I've been neglecting my family due to the stress of my p..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA: "“I couldn't control myself and hit my wife.”"]** — Mówca: **Player**
> "“I couldn't control myself and hit my wife.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Monica_Slapped"] == true`
- **Kontekst wejściowy (poprzednik):** `[121]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Archpriest: "“Physical abuse is a sin. But every man can lose his temp..."*)

### Węzeł `[251]`
Mówca: **Archpriest**
> "“Physical abuse is a sin. But every man can lose his temper. A husband must always support and protect his wife. You have taken the vows and you must uphold them. Repent, and God may forgive you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Archpriest: "“Anything else you would like to confess?”"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_BadHusband == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_BadHusband == false"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Confessed_BadHusband == false)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_BadHusband == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“I confess that I have been a bad husband.”"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Confessed_BadHusband == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_Bribery == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_Bribery == false"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Confessed_Bribery == false)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_Bribery == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Frens_Bribed == true || BaseGame.Relat..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Confessed_Bribery == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: "“I confess that I am not sure what I am doing for Sordlan..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[261]`
Mówca: **Narrator**
> "Before we went in, the Archpriest looked at the crowd and pointed at one man. I turned and followed his finger with my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "It was a man holding a picket sign that said: 'Stop The R..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "Before we went in, the Archpriest looked at the crowd and..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He led me through the main hall, which had a stratospheri..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "It was a man holding a picket sign that said: 'Stop The Religious Disharmony Bill'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Archpriest: "“As you can see, every man has his faults.”"*)

### Węzeł `[266]`
Mówca: **Archpriest**
> "“As you can see, every man has his faults.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Archpriest: "“So does every president.”"*)

### Węzeł `[267]`
Mówca: **Archpriest**
> "“So does every president.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“So does every Archpriest, it seems.”"*)
  - -> `[268]` (*Player: "“I take it you don't approve of the Religious Harmony bill.”"*)
  - -> `[270]` (*Player: "“Let's continue with the ceremony, Archpriest.”"*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“I take it you don't approve of the Religious Harmony bill.”"]** — Mówca: **Player**
> "“I take it you don't approve of the Religious Harmony bill.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Archpriest: "“Yes, that's right. But today is not the day to discuss t..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“So does every Archpriest, it seems.”"]** — Mówca: **Player**
> "“So does every Archpriest, it seems.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Archpriest: "“But of course. I am but a simple man and a mere servant ..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Let's continue with the ceremony, Archpriest.”"]** — Mówca: **Player**
> "“Let's continue with the ceremony, Archpriest.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Archpriest: "“Very well, Mr. President.”"*)

### Węzeł `[271]`
Mówca: **Archpriest**
> "“Yes, that's right. But today is not the day to discuss that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He led me through the main hall, which had a stratospheri..."*)

### Węzeł `[272]`
Mówca: **Archpriest**
> "“But of course. I am but a simple man and a mere servant of God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He led me through the main hall, which had a stratospheri..."*)

### Węzeł `[273]`
Mówca: **Archpriest**
> "“Very well, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "He led me through the main hall, which had a stratospheri..."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_LT_RitualWin = true; BaseGame..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 3;
BaseGame.Bludish_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_R_RitualFailed = true"*)

### Węzeł `[276]`
Mówca: **Narrator**
> "The Archpriest lay the sword on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Player_Italic: "Touch the sword with your left hand."*)
  - -> `[43]` (*Player_Italic: "Touch the sword with your right hand."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual4 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "The Archpriest handed me the sword."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: "Hand the sceptre to the Archpriest."]** — Mówca: **Player_Italic**
> "I handed the sceptre to the Archpriest and waited for him to give me the sword."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic), `[43]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual4 = true"*)

### Węzeł `[279]`
**[WYBÓR GRACZA: "Hand the sceptre to the disciples."]** — Mówca: **Player_Italic**
> "I handed the sceptre to the disciple next to me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Player_Italic), `[43]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "The Archpriest handed me the sword."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_SuccessfulRitual5 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn07_A_SuccessfulRitual5"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got up and proceeded to my designated spot next to Luci..."*)

### Węzeł `[281]`
Mówca: **Narrator**
> "The Archpriest handed me the sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player_Italic: "Pass the sword to a disciple."*)
  - -> `[283]` (*Player_Italic: "Hand the sword back to the Archpriest."*)
  - -> `[284]` (*Player_Italic: "Place the sword on the altar."*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "Pass the sword to a disciple."]** — Mówca: **Player_Italic**
> "I passed the sword to a disciple."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_SuccessfulRitual5 = true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "Hand the sword back to the Archpriest."]** — Mówca: **Player_Italic**
> "I handed the sword back to the Archpriest. He took it and passed it to a disciple."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got up and proceeded to my designated spot next to Luci..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA: "Place the sword on the altar."]** — Mówca: **Player_Italic**
> "I placed the sword on the altar. The Archpriest picked it back up and handed it to one of the disciples."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[281]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "I got up and proceeded to my designated spot next to Luci..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_LT_RitualWin = true;
BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_LT_RitualWin"] = true;
Variable["BaseGameSupport.CountryReport_Turn07_Derdia_BlessesCongratulatesRitual"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "My eyes met the Archpriest's and he very slightly nodded."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_R_RitualFailed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_R_RitualFailed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == false"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == false)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal = true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "My eyes met the Archpriest's and he very slightly shook h..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_ST_RitualFailed_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "My eyes met the Archpriest's and he very slightly shook h..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_..."*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn0..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency =..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= 0 && BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0  and  Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn07_HP_ProtestsDespiteEmergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseG..."*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_RailwayIssue_Solved == false && Bas..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "This year, however, for the first time ever, it was going..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_RailwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseG..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseG..."*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_InT_HighwayIssue_Solved == false && Bas..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "This year, however, for the first time ever, it was going..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_InT_HighwayIssue_Solved"] == false  and  Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[301]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Railway", 75);  // Updates token..."*)

### Węzeł `[302]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "UpdateProgress("Progress_Highway", 75);  // Updates token..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] == false  and  Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_RailwayIssue_Solved == false && BaseG..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true && BaseGameSupport.Journal_Turn06_RailwayOpening == false && BaseGameSupport.Journal_Turn06_HighwayOpening == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true  and  Variable["BaseGameSupport.Journal_Turn06_RailwayOpening"] == false  and  Variable["BaseGameSupport.Journal_Turn06_HighwayOpening"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "This year, however, for the first time ever, it was going..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "This year, however, for the first time ever, it was going to be televised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[307]`
**[WYBÓR GRACZA: "“Albin Clavin.”"]** — Mówca: **Player**
> "“Albin Clavin.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Kontekst wejściowy (poprzednik):** `[114]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Archpriest: "“Hmm I see. This must've been done out of necessity for t..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Albin_Bribed == true || BaseGame.Relat..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Albin_Bribed == true || BaseGame.Rel..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Player: "“Albin Clavin.”"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Albin_Bribed == true || BaseGame.Relations_Albin_PromisedVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Albin_Bribed"] == true  or  Variable["BaseGame.Relations_Albin_PromisedVP"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Accepted_MediaDeal == true"*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Accepted_MediaDeal == true)"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Accepted_MediaDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Player: "“Marcel Koronti.”"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Accepted_MediaDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Accepted_MediaDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[314]`
**[WYBÓR GRACZA: "“Marcel Koronti.”"]** — Mówca: **Player**
> "“Marcel Koronti.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Accepted_MediaDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[114]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Archpriest: "“Hmm I see. This must've been done out of necessity for t..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum..."*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsyl..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "We left the cathedral to greet the waiting crowd."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_GrantAsylum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "We left the cathedral to greet the waiting crowd."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "We left the cathedral to greet the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false ||..."*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false ..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "“Fine. I will confess.”"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn07_A_Confessed_SelfDoubt == false || BaseGameIsolated.Turn07_A_Confessed_BadHusband == false || BaseGameIsolated.Turn07_A_Confessed_Bribery == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn07_A_Confessed_SelfDoubt"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_BadHusband"] == false  or  Variable["BaseGameIsolated.Turn07_A_Confessed_Bribery"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Railway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Railway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_InT_HighwayIssue_Solved == false && BaseG..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateProgress("Progress_Highway", 75);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%)`
- **Efekt skryptowy (`userScript`):** `UpdateProgress("Progress_Highway", 75);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_Dagger");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_Dagger");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "A couple of knocks were heard on the door and a young boy..."*)

### Węzeł `[325]`
**[WYBÓR GRACZA: "“Do not test my limits. I kindly ask of you.”"]** — Mówca: **Player**
> "“Do not test my limits. I kindly ask of you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[174]` (Archpriest)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Archpriest: "“Pride is the most dangerous vice of all. Perhaps you wil..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BooCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BooCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Italic: "Exit the car."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowdCamera");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowdCamera");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player_Italic: "Exit the car."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BooScatter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BooScatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "As I walked outside, I heard scattered boos. A man in a s..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("FuriousJeers");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("FuriousJeers");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "As I stepped outside, I heard furious jeers. Guards shiel..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("CheerCrowd");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("CheerCrowd");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "As I stepped outside, I heard everyone cheering and chant..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("BooScatter");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("BooScatter");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "As I walked outside, I heard scattered boos. A man in a W..."*)
