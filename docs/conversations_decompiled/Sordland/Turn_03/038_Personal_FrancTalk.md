# Sordland/Turn03/Personal_FrancTalk

- **ID konwersacji:** `38`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/038_Personal_FrancTalk.md`
- **Liczba węzłów dialogowych:** 402
- **Liczba wyborów gracza:** 99

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed`
- `BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed`
- `BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Protest_Girl_Crushed`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_1stCoup_Protested`
- `BaseGame.Prologue_University_Group_HumanRights`
- `BaseGame.Prologue_University_Group_StudentCouncil`
- `BaseGame.Prologue_University_Political_Active`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Relations_Franc_MadAtDinner`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGameIsolated.Turn03_Franc_Coup27_Listened`
- `BaseGameIsolated.Turn03_Franc_Coup28_Listened`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Situation_Law_FreedomOfPress`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGameIsolated.Turn03_Franc_Coup27_Listened`
- `BaseGameIsolated.Turn03_Franc_Coup28_Listened`
- `BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer`
- `BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia`
- `BaseGameSupport.News_Turn03_E_Gasom_Critique`
- `BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth`
- `BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments`
- `BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique`
- `BaseGameSupport.News_Turn03_HP_AttackerOpenedFire`
- `BaseGameSupport.News_Turn03_HP_GreenBillCritique`
- `BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS`
- `BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan`
- `BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest`
- `BaseGameSupport.News_Turn03_R_GreenBill_Support`
- `BaseGameSupport.News_Turn03_R_UndemocraticElections`
- `BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto`
- `BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign`
- `BaseGameSupport.Report_Turn03_Antel_PrisonRiot`
- `BaseGameSupport.Report_Turn03_Holsord_L1_SSC`
- `BaseGameSupport.Report_Turn03_Holsord_L1_Underhall`
- `BaseGameSupport.Report_Turn03_Holsord_USPReport`
- `BaseGameSupport.Report_Turn03_Lachaven_H3_SSC`
- `BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall`
- `BaseGameSupport.Report_Turn03_Morna_IndustrialOutput`
- `GameCondition.Turn03_Personal_FrancTalk`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“And that, my boy, is how bribery works.”"** | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Franc**: "“Ha. What a great example you're..." |
| `[9]` | **"“Well, you're going to have to work for them. Help me fan these flames.”"** | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "Franc sighed and waved the fan l..." |
| `[10]` | **"“Children who talk back to their fathers don't get dinner. Fan these flames, will ..."** | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..."<br>`[318]` **Franc**: ""Sure, if you can spare a few mi..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[11]` **Narrator**: "Franc sighed and waved the fan l..." |
| `[12]` | **"“You keep it up at that rate and we'll never have dinner. Put your back into it!”"** | `[11]` **Narrator**: "Franc sighed and waved the fan l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Franc**: "“I am trying.”" |
| `[13]` | **""Never mind, I'll do it myself. Just bring the large serving platter from the kitc..."** | `[11]` **Narrator**: "Franc sighed and waved the fan l..."<br>`[19]` **Narrator**: "He continued just as listlessly ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Franc**: "“Oh, I'm one of your employees n..." |
| `[14]` | **""It worked, didn't it? Everyone has their price. Remember that.""** | `[8]` **Franc**: "“Ha. What a great example you're..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He looked like he was going to s..." |
| `[15]` | **"“It's politics, Franc. You're old enough to learn the ways of the world.'"** | `[8]` **Franc**: "“Ha. What a great example you're..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "He looked like he was going to s..." |
| `[21]` | **"Show him how to do it properly."** | `[11]` **Narrator**: "Franc sighed and waved the fan l..."<br>`[19]` **Narrator**: "He continued just as listlessly ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[22]` **Player**: "“See? It's easy.""<br>`[23]` **Player**: "“My father would have slapped me..."<br>*(oraz 1 innych odgałęzień)* |
| `[22]` | **"“See? It's easy.""** | `[21]` **Player_Italic**: "I yanked the fan out of Franc's ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[401]` **Franc**: "“Looks like it.”" |
| `[23]` | **"“My father would have slapped me for this.”"** | `[21]` **Player_Italic**: "I yanked the fan out of Franc's ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[25]` **Franc**: "“I guess I should be grateful th..." |
| `[24]` | **"“Hard work usually pays off.”"** | `[21]` **Player_Italic**: "I yanked the fan out of Franc's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Franc**: "“Right, Dad. *Usually*.”" |
| `[27]` | **"“Don't make me angry. Do as I say.”"** | `[20]` **Franc**: "“Oh, I'm one of your employees n..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[208]` **Franc**: "“Geez, you're barely ever here, ..." |
| `[28]` | **"“Can't I even request something from my son now?”"** | `[20]` **Franc**: "“Oh, I'm one of your employees n..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[209]` **Franc**: "“As long as it's a request, not ..."<br>`[253]` **Franc**: "“You will have to go through my ..." |
| `[33]` | **"“Good job.”"** | `[35]` **Narrator**: "He turned to look at me with a g..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[241]` **Narrator**: "He nodded."<br>`[37]` **Franc**: "“Thank you, sir. It is in our ut..." |
| `[34]` | **"“Not bad, son, not bad.”"** | `[35]` **Narrator**: "He turned to look at me with a g..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[241]` **Narrator**: "He nodded."<br>`[37]` **Franc**: "“Thank you, sir. It is in our ut..." |
| `[36]` | **"Say nothing."** | `[35]` **Narrator**: "He turned to look at me with a g..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[41]` **Narrator**: "I realized my throat was parched..." |
| `[39]` | **"Stare at Franc angrily."** | `[20]` **Franc**: "“Oh, I'm one of your employees n..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[29]` **Franc**: "“Uh oh. I know that look.”" |
| `[42]` | **""Franc, can you get me a beer?""** | `[41]` **Narrator**: "I realized my throat was parched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "Franc got up without saying anyt..." |
| `[43]` | **""Why don't you bring us a couple of beers?""** | `[41]` **Narrator**: "I realized my throat was parched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Narrator**: "He looked at me in disbelief." |
| `[45]` | **"Get up and grab a beer."** | `[41]` **Narrator**: "I realized my throat was parched..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "I opened it, sat down, and gazed..." |
| `[47]` | **"“Thank you.”"** | `[46]` **Narrator**: "Franc got up without saying anyt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "I opened the beer and gazed out ..." |
| `[48]` | **"Open the beer."** | `[46]` **Narrator**: "Franc got up without saying anyt..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "For a moment, my thoughts flashe..." |
| `[67]` | **"“Go on.”"** | `[54]` **Franc**: "“Dad, can I ask you something?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Franc**: "“It's just... I feel like there'..." |
| `[68]` | **"“We are family. You can ask anything.”"** | `[54]` **Franc**: "“Dad, can I ask you something?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Franc**: "“It's just... I feel like there'..." |
| `[69]` | **"Wait for him to continue."** | `[54]` **Franc**: "“Dad, can I ask you something?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Franc**: "“It's just... I feel like there'..." |
| `[76]` | **"“I don't want to talk about it.”"** | `[75]` **Narrator**: "And that little girl's face..."<br>`[339]` **Narrator**: "The shock and grief on the faces..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Hearing the faint trembling in m..." |
| `[77]` | **"“Those were dark times.”"** | `[75]` **Narrator**: "And that little girl's face..."<br>`[339]` **Narrator**: "The shock and grief on the faces..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Franc**: "“It seems like it.”" |
| `[80]` | **"“But you're nearly a grown man. Let's talk about it.”"** | `[79]` **Franc**: "“It seems like it.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Narrator**: "Franc leaned forward in his chai..." |
| `[81]` | **"“Let's change the subject.”"** | `[79]` **Franc**: "“It seems like it.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Franc**: "“It's okay. I'm sorry. I shouldn..." |
| `[83]` | **""I was barely older than you are now...""** | `[92]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true` | *Brak zmian stanu* | `[95]` **Player**: ""I had just left the classroom t..." |
| `[90]` | **""I was barely older than you are now...""** | `[92]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`<br>`(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false` | *Brak zmian stanu* | `[95]` **Player**: ""I had just left the classroom t..." |
| `[92]` | **"Tell Franc about the coup of 1927."** | `[160]` **Narrator**: "Franc leaned forward in his chai..."<br>`[100]` **Narrator**: "I stopped there and turned my he..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false` | *Brak zmian stanu* | `[83]` **Player**: ""I was barely older than you are..."<br>`[90]` **Player**: ""I was barely older than you are..."<br>*(oraz 1 innych odgałęzień)* |
| `[93]` | **"Tell Franc about the civil war."** | `[160]` **Narrator**: "Franc leaned forward in his chai..."<br>`[100]` **Narrator**: "I stopped there and turned my he..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false` | *Brak zmian stanu* | `[102]` **Player**: ""It was right after I met your m..."<br>`[127]` **Player**: ""It was right after I met your m..."<br>*(oraz 3 innych odgałęzień)* |
| `[94]` | **"“Actually, never mind. Now is not the time to talk about the past.”"** | `[160]` **Narrator**: "Franc leaned forward in his chai..."<br>`[100]` **Narrator**: "I stopped there and turned my he..."<br>*(oraz 8 innych węzłów)* | `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false` | *Brak zmian stanu* | `[82]` **Franc**: "“It's okay. I'm sorry. I shouldn..." |
| `[95]` | **""I had just left the classroom...""** | `[83]` **Player**: ""I was barely older than you are..."<br>`[90]` **Player**: ""I was barely older than you are..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Player**: ""The same soldiers that were sup..." |
| `[96]` | **""The same soldiers that were supposed to protect Sordland's citizens pointed their..."** | `[95]` **Player**: ""I had just left the classroom t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Narrator**: "Franc kept listening, a shocked ..." |
| `[102]` | **""It was right after I met your mother...""** | `[93]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`<br>`Variable["BaseGame.Prologue_University_Group_HumanRights"] == true` | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[127]` | **""It was right after I met your mother...""** | `[93]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`<br>`(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`<br>`Variable["BaseGame.Prologue_University_Group_HumanRights"] == true` | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[128]` | **""It was right after I met your mother...""** | `[93]` **Player_Italic**: "It was time to tell him about th..." | `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`<br>`(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`<br>`Variable["BaseGame.Prologue_University_Group_HumanRights"] == true` | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[129]` | **""It was right after I met your mother...""** | `[93]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`<br>`Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true`<br>`(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false` | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[130]` | **""It was right after I met your mother...""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[131]` | **""It was right after I met your mother...""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[132]` | **"Tell Franc about the clash between Luderin and Rikard."** | `[102]` **Player**: ""It was right after I met your m..."<br>`[127]` **Player**: ""It was right after I met your m..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "Franc shifted in his seat, visib..." |
| `[133]` | **""So we organized a protest...""** | `[186]` **Narrator**: "Franc shifted in his seat, visib..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`<br>`Variable["BaseGame.Prologue_University_Political_Active"] == true` | *Brak zmian stanu* | `[168]` **Player_Italic**: "I paused for a moment before con..."<br>`[172]` **Player_Italic**: "I paused for a moment before con..."<br>*(oraz 2 innych odgałęzień)* |
| `[137]` | **""So we organized a protest...""** | `[186]` **Narrator**: "Franc shifted in his seat, visib..." | `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`<br>`Variable["BaseGame.Prologue_University_Political_Active"] == true` | *Brak zmian stanu* | `[168]` **Player_Italic**: "I paused for a moment before con..."<br>`[172]` **Player_Italic**: "I paused for a moment before con..."<br>*(oraz 2 innych odgałęzień)* |
| `[144]` | **"“That's enough for today.”"** | `[160]` **Narrator**: "Franc leaned forward in his chai..."<br>`[100]` **Narrator**: "I stopped there and turned my he..."<br>*(oraz 8 innych węzłów)* | `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true` | *Brak zmian stanu* | `[82]` **Franc**: "“It's okay. I'm sorry. I shouldn..." |
| `[148]` | **"“What problems?”"** | `[147]` **Franc**: ""I know I complain sometimes, bu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Narrator**: "Before Franc could say anything ..." |
| `[161]` | **"Tell him about the soldiers beating you."** | `[348]` **Narrator**: "Franc kept listening, a shocked ..." | `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true` | *Brak zmian stanu* | `[165]` **Player**: ""I was still one of the lucky on..."<br>`[357]` **Player**: ""I tried my best to stay strong...." |
| `[162]` | **"Refrain from telling him the brutality."** | `[348]` **Narrator**: "Franc kept listening, a shocked ..." | `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true` | *Brak zmian stanu* | `[100]` **Narrator**: "I stopped there and turned my he..." |
| `[163]` | **"Tell him that you ran for your life like a coward."** | `[348]` **Narrator**: "Franc kept listening, a shocked ..." | `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false` | *Brak zmian stanu* | `[166]` **Player**: ""I still feel my flight was just..."<br>`[356]` **Player**: ""I still feel my flight was sham..." |
| `[164]` | **"Refrain from telling him about your quick escape."** | `[348]` **Narrator**: "Franc kept listening, a shocked ..." | `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false` | *Brak zmian stanu* | `[167]` **Narrator**: "I stopped there and turned my he..." |
| `[165]` | **""I was lucky...""** | `[161]` **Player_Italic**: ""I was there with the protesters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "Franc leaned back in his chair. ..." |
| `[166]` | **""I still feel my flight was justified -- anyone would do the same...""** | `[163]` **Player_Italic**: ""Seeing the crowd gathering, I k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Franc leaned back in his chair. ..." |
| `[168]` | **"Tell him about the girl."** | `[133]` **Player**: ""So we organised a protest one d..."<br>`[137]` **Player**: ""So we organised a protest one d..." | `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true` | *Brak zmian stanu* | `[343]` **Player**: ""It was horrible. They were wait..." |
| `[172]` | **"Refrain from telling him about the girl."** | `[133]` **Player**: ""So we organised a protest one d..."<br>`[137]` **Player**: ""So we organised a protest one d..." | `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true` | *Brak zmian stanu* | `[344]` **Player**: ""It was horrible. They were wait..." |
| `[180]` | **""I stayed out of it...""** | `[186]` **Narrator**: "Franc shifted in his seat, visib..." | `(Variable["BaseGame.Prologue_University_Political_Active"] == true) == false` | `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"]...` | `[92]` **Player_Italic**: "It was time to tell him about th..."<br>`[93]` **Player_Italic**: "It was time to tell him about th..."<br>*(oraz 2 innych odgałęzień)* |
| `[181]` | **"Refrain from telling him about your escape."** | `[133]` **Player**: ""So we organised a protest one d..."<br>`[137]` **Player**: ""So we organised a protest one d..." | `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false` | *Brak zmian stanu* | `[346]` **Player**: ""We were ready to face them. I h..." |
| `[182]` | **"Tell him that you ran away."** | `[133]` **Player**: ""So we organised a protest one d..."<br>`[137]` **Player**: ""So we organised a protest one d..." | `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false` | *Brak zmian stanu* | `[345]` **Player**: ""Soldiers were waiting for us. I..." |
| `[192]` | **"“I hope not.”"** | `[191]` **Franc**: "“Dad, is there going to be a civ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Narrator**: "He let out a sigh." |
| `[193]` | **"“No. I will never let that happen.”"** | `[191]` **Franc**: "“Dad, is there going to be a civ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Franc**: ""Good."" |
| `[194]` | **"Say nothing and avoid his question."** | `[191]` **Franc**: "“Dad, is there going to be a civ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[197]` **Narrator**: "He let out a sigh." |
| `[204]` | **"“I didn't say bribery was good, did I? You can always make the moral choice and tu..."** | `[8]` **Franc**: "“Ha. What a great example you're..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Narrator**: "Franc smiled for a second. I tur..." |
| `[211]` | **"Ask again more politely."** | `[208]` **Franc**: "“Geez, you're barely ever here, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[212]` **Franc**: "“See, was that so hard?”" |
| `[213]` | **"“Franc! I said don't make me angry!”"** | `[208]` **Franc**: "“Geez, you're barely ever here, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[214]` **Franc**: "“Stop yelling at me. Why are you..." |
| `[215]` | **"“I'm sorry. Work is overwhelming sometimes. I shouldn't have taken it out on you.”"** | `[208]` **Franc**: "“Geez, you're barely ever here, ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[216]` **Franc**: "“Yeah, sure, it's okay. You know..." |
| `[217]` | **"“I can only imagine. I'm proud of how well you've been handling everything.”"** | `[226]` **Franc**: ""You never even asked me how it ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[30]` **Narrator**: "Franc returned with a tray large..." |
| `[218]` | **"“We can talk about it more later. For now, will you please go fetch the tray so we..."** | `[226]` **Franc**: ""You never even asked me how it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Franc**: "“Aye aye, cap'n.”" |
| `[221]` | **"“No. You're my son and I'm asking you. Can you bring the tray now, please?”"** | `[20]` **Franc**: "“Oh, I'm one of your employees n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Franc**: "“Yes, Father.”"<br>`[222]` **Franc**: "“Ah. *Please*. The magic word.”" |
| `[224]` | **"“Damn your generation. You are all the same. Weak.”"** | `[19]` **Narrator**: "He continued just as listlessly ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[225]` **Franc**: ""Weak?! Dad, can't you see you'r..." |
| `[227]` | **"“Oh, cry me a river. Grow a spine and make something of yourself.”"** | `[226]` **Franc**: ""You never even asked me how it ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[228]` **Franc**: "“I'm sorry for being spineless, ..." |
| `[234]` | **"“I've warned you. Shut up and do as I say -- or else.”"** | `[226]` **Franc**: ""You never even asked me how it ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[236]` **Franc**: "“Or else what? You're going to s..." |
| `[267]` | **"“Yes, I do mind. I don't want to talk about it.”"** | `[258]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Franc**: "“Okay. I was just curious, that'..." |
| `[268]` | **"“Sordland was under attack by communists and I had to defend the country.”"** | `[258]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[271]` | **"“I had to survive somehow in that environment and I made a choice.”"** | `[258]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[272]` | **"“Yes, I do mind. I don't want to talk about it.”"** | `[265]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Franc**: "“Okay. I was just curious, that'..." |
| `[274]` | **"“A communist revolution for Sordland was and still is the only way.”"** | `[265]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[276]` | **"“I had to survive somehow in that environment, and I made a choice.”"** | `[265]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[277]` | **"“Yes, I do mind. I don't want to talk about it.”"** | `[266]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Franc**: "“Okay. I was just curious, that'..." |
| `[280]` | **"“I didn't want to be part of the violence.""** | `[266]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[281]` | **"“They are two sides of the same coin.”"** | `[266]` **Franc**: "“One more thing, though -- I kno..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Narrator**: "Franc raised his eyebrows, his c..." |
| `[283]` | **"“Don't act like you've done something special, Franc.”"** | `[35]` **Narrator**: "He turned to look at me with a g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Narrator**: "He gave me a blank stare and the..." |
| `[311]` | **""So, you've finally decided to speak to me again?""** | `[5]` **Narrator**: "Sure enough, as soon as Franc gl..."<br>`[187]` **Narrator**: "Sure enough, as soon as Franc gl..." | `Variable["BaseGame.Relations_Franc_MadAtDinner"]` | *Brak zmian stanu* | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..." |
| `[312]` | **""Well, look who's finally out of his room.""** | `[5]` **Narrator**: "Sure enough, as soon as Franc gl..."<br>`[187]` **Narrator**: "Sure enough, as soon as Franc gl..." | `Variable["BaseGame.Relations_Franc_MadAtDinner"]` | *Brak zmian stanu* | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..."<br>`[317]` **Franc**: ""You should talk, Dad. I never s..." |
| `[313]` | **""Come to spend some quality time with your old man, have you?""** | `[5]` **Narrator**: "Sure enough, as soon as Franc gl..."<br>`[187]` **Narrator**: "Sure enough, as soon as Franc gl..." | `(Variable["BaseGame.Relations_Franc_MadAtDinner"]) == false` | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[6]` **Franc**: ""Don't get any ideas, Dad. I'm o..."<br>`[318]` **Franc**: ""Sure, if you can spare a few mi..." |
| `[322]` | **""I'm sorry, I know I haven't been around very often lately. But I'm happy to see y..."** | `[317]` **Franc**: ""You should talk, Dad. I never s..."<br>`[318]` **Franc**: ""Sure, if you can spare a few mi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[328]` **Franc**: ""It's okay. I know you've got th..." |
| `[323]` | **""Look, son, I'm preoccupied with matters of national importance.""** | `[317]` **Franc**: ""You should talk, Dad. I never s..."<br>`[318]` **Franc**: ""Sure, if you can spare a few mi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Franc**: ""Yes, Mr. President. Whatever yo..." |
| `[326]` | **""But right now, nothing's more important than these ribs.""** | `[324]` **Franc**: ""Yes, Mr. President. Whatever yo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[329]` **Narrator**: "We both chuckled. I turned to te..." |
| `[340]` | **""It was right after I met your mother...""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[341]` | **""It was right after I met your mother...""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[342]` | **""It was right after I met your mother...""** | `[93]` **Player_Italic**: "It was time to tell him about th..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`<br>`(Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true) == false`<br>`(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false` | *Brak zmian stanu* | `[132]` **Player_Italic**: ""Then, one night, it happened. T..." |
| `[343]` | **""It was horrible...""** | `[168]` **Player_Italic**: "I paused for a moment before con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Narrator**: "Franc's face had grown pale. He ..." |
| `[344]` | **""It was horrible...""** | `[172]` **Player_Italic**: "I paused for a moment before con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "I trailed off. There were some t..." |
| `[345]` | **""Soldiers were waiting for us...""** | `[182]` **Player_Italic**: "I paused for a moment before con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "Years later, I still felt that I..." |
| `[346]` | **""We were ready to face them...""** | `[181]` **Player_Italic**: "I paused for a moment before con..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Narrator**: "I trailed off, hoping Franc woul..." |
| `[347]` | **""I was barely older than you are now...""** | `[92]` **Player_Italic**: "It was time to tell him about th..." | `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`<br>`(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false` | *Brak zmian stanu* | `[95]` **Player**: ""I had just left the classroom t..." |
| `[349]` | **""I'm here to listen to them, no matter what they are.""** | `[147]` **Franc**: ""I know I complain sometimes, bu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[149]` **Narrator**: "Before Franc could say anything ..." |
| `[350]` | **""You're damn right. Your generation will never understand.""** | `[147]` **Franc**: ""I know I complain sometimes, bu..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[149]` **Narrator**: "Before Franc could say anything ..." |
| `[356]` | **""I still feel my flight was shameful -- I should have stood my ground...""** | `[163]` **Player_Italic**: ""Seeing the crowd gathering, I k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Narrator**: "Franc leaned back in his chair. ..." |
| `[357]` | **""I stayed strong...""** | `[161]` **Player_Italic**: ""I was there with the protesters..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "Franc leaned back in his chair. ..." |

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
  - -> `[3]` (*Narrator: "It was a Saturday afternoon, my first break from work in ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was a Saturday afternoon, my first break from work in what felt like years, and the weather couldn't have been more perfect. Trying to keep my mind off the upheaval sparked by the Circas assassination, I lit the backyard grill."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == ..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Monica and Deana were out shopping for craft supplies, and I'd given the staff the day off. It was just myself and Franc at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "I wasn't sure how he felt about me at the moment. But I d..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Sure enough, as soon as Franc glimpsed the grill and the meat, he stepped outside to join me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner"*)

### Węzeł `[6]`
Mówca: **Franc**
> ""Don't get any ideas, Dad. I'm only here for the ribs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“And that, my boy, is how bribery works.”"*)
  - -> `[9]` (*Player: "“Well, you're going to have to work for them. Help me fan..."*)
  - -> `[10]` (*Player: "“Children who talk back to their fathers don't get dinner..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“And that, my boy, is how bribery works.”"]** — Mówca: **Player**
> "“And that, my boy, is how bribery works.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Franc: "“Ha. What a great example you're setting.”"*)

### Węzeł `[8]`
Mówca: **Franc**
> "“Ha. What a great example you're setting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""It worked, didn't it? Everyone has their price. Remember..."*)
  - -> `[15]` (*Player: "“It's politics, Franc. You're old enough to learn the way..."*)
  - -> `[204]` (*Player: "“I didn't say bribery was good, did I? You can always mak..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Well, you're going to have to work for them. Help me fan these flames.”"]** — Mówca: **Player**
> "“Well, you're going to have to work for them. Help me fan these flames.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Franc sighed and waved the fan lazily, almost causing the..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Children who talk back to their fathers don't get dinner. Fan these flames, will you?”"]** — Mówca: **Player**
> "“Children who talk back to their fathers don't get dinner. Fan these flames, will you?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Franc), `[318]` (Franc), `[324]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Franc sighed and waved the fan lazily, almost causing the fire to die out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: "“You keep it up at that rate and we'll never have dinner...."*)
  - -> `[21]` (*Player_Italic: "Show him how to do it properly."*)
  - -> `[13]` (*Player: ""Never mind, I'll do it myself. Just bring the large serv..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "“You keep it up at that rate and we'll never have dinner. Put your back into it!”"]** — Mówca: **Player**
> "“You keep it up at that rate and we'll never have dinner. Put your back into it!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Franc: "“I am trying.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""Never mind, I'll do it myself. Just bring the large serving platter from the kitchen.”"]** — Mówca: **Player**
> ""Never mind, I'll do it myself. Just bring the large serving platter from the kitchen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Franc: "“Oh, I'm one of your employees now?”"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""It worked, didn't it? Everyone has their price. Remember that.""]** — Mówca: **Player**
> ""It worked, didn't it? Everyone has their price. Remember that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He looked like he was going to say something, but quickly..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“It's politics, Franc. You're old enough to learn the ways of the world.'"]** — Mówca: **Player**
> "“It's politics, Franc. You're old enough to learn the ways of the world.'"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "He looked like he was going to say something, but quickly..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "He looked like he was going to say something, but quickly closed his mouth and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Franc: "“Point taken.”"*)

### Węzeł `[17]`
Mówca: **Franc**
> "“Point taken.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "It was rare for Franc to agree with anything I said nowad..."*)

### Węzeł `[18]`
Mówca: **Franc**
> "“I am trying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "He continued just as listlessly as before."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "He continued just as listlessly as before."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Italic: "Show him how to do it properly."*)
  - -> `[13]` (*Player: ""Never mind, I'll do it myself. Just bring the large serv..."*)
  - -> `[224]` (*Player: "“Damn your generation. You are all the same. Weak.”"*)

### Węzeł `[20]`
Mówca: **Franc**
> "“Oh, I'm one of your employees now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: "“No. You're my son and I'm asking you. Can you bring the ..."*)
  - -> `[28]` (*Player: "“Can't I even request something from my son now?”"*)
  - -> `[39]` (*Player_Italic: "Stare at Franc angrily."*)
  - -> `[27]` (*Player: "“Don't make me angry. Do as I say.”"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "Show him how to do it properly."]** — Mówca: **Player_Italic**
> "I yanked the fan out of Franc's hands and started vigorously fanning the flames."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Narrator), `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[22]`
**[WYBÓR GRACZA: "“See? It's easy.""]** — Mówca: **Player**
> "“See? It's easy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“My father would have slapped me for this.”"]** — Mówca: **Player**
> "“My father would have slapped me for this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Hard work usually pays off.”"]** — Mówca: **Player**
> "“Hard work usually pays off.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Franc: "“Right, Dad. *Usually*.”"*)

### Węzeł `[25]`
Mówca: **Franc**
> "“I guess I should be grateful that you don't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[26]`
Mówca: **Franc**
> "“Right, Dad. *Usually*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Don't make me angry. Do as I say.”"]** — Mówca: **Player**
> "“Don't make me angry. Do as I say.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“Can't I even request something from my son now?”"]** — Mówca: **Player**
> "“Can't I request a favor from my son?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2"*)

### Węzeł `[29]`
Mówca: **Franc**
> "“Uh oh. I know that look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Franc returned with a tray large enough to hold all the meat and vegetables. The fire was still burning weakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[31]`
Mówca: **Franc**
> "“Here, let me try.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "He grabbed the fan and started quickly waving it over the..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "He grabbed the fan and started quickly waving it over the coals. The fire roared to life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He turned to look at me with a grin on his face, as if he..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Good job.”"]** — Mówca: **Player**
> "“Good job.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“Not bad, son, not bad.”"]** — Mówca: **Player**
> "“Not bad, son, not bad.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He turned to look at me with a grin on his face, as if he was expecting praise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player: "“Good job.”"*)
  - -> `[34]` (*Player: "“Not bad, son, not bad.”"*)
  - -> `[283]` (*Player: "“Don't act like you've done something special, Franc.”"*)
  - -> `[36]` (*Player_Italic: "Say nothing."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and Franc's smile faded. We both stared into the fire."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2"*)

### Węzeł `[37]`
Mówca: **Franc**
> "“Thank you, sir. It is in our utmost interest to fulfill our duties with precision. The grilling shall commence in exactly 1 minute and 32 seconds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "That was a spot-on impersonation of Lucian. We looked at ..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "That was a spot-on impersonation of Lucian. We looked at each other for a second, then burst out laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "I realized my throat was parched. There was a six-pack of..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "Stare at Franc angrily."]** — Mówca: **Player_Italic**
> "I said nothing and turned to Franc, looking straight into his eyes. He immediately understood."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "It was rare for Franc to agree with anything I said nowadays. I turmed to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "I realized my throat was parched. There was a six-pack of beer in the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player: ""Franc, can you get me a beer?""*)
  - -> `[43]` (*Player: ""Why don't you bring us a couple of beers?""*)
  - -> `[45]` (*Player_Italic: "Get up and grab a beer."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""Franc, can you get me a beer?""]** — Mówca: **Player**
> ""Franc, can you get me a beer?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Franc got up without saying anything, went to the kitchen..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Why don't you bring us a couple of beers?""]** — Mówca: **Player**
> ""Why don't you bring us a couple of beers?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He looked at me in disbelief."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He looked at me in disbelief."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Franc: ""You mean, I can--? But Mom told me--""*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Get up and grab a beer."]** — Mówca: **Player_Italic**
> "I got up, grabbed myself a beer and returned to the grill."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I opened it, sat down, and gazed out at the city skyline ..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Franc got up without saying anything, went to the kitchen and returned with a cold beer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "“Thank you.”"*)
  - -> `[48]` (*Player_Italic: "Open the beer."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "I opened the beer and gazed out at the city skyline. Fath..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Open the beer."]** — Mówca: **Player_Italic**
> "I opened the beer and gazed out at the city skyline. Father and son, we enjoyed the silence together."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "For a moment, my thoughts flashed back to my childhood an..."*)

### Węzeł `[49]`
Mówca: **Franc**
> ""You mean, I can--? But Mom told me--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He stopped himself, quickly ran inside and returned with ..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "He stopped himself, quickly ran inside and returned with two beers. We cracked them open, clinked the bottles and gazed out at the city skyline."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "I opened the beer and gazed out at the city skyline. Father and son, we enjoyed the silence together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "For a moment, my thoughts flashed back to my childhood an..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I opened it, sat down, and gazed out at the city skyline with my son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "For a moment, my thoughts flashed back to my childhood an..."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "For a moment, my thoughts flashed back to my childhood and my relationship with my own father."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[54]`
Mówca: **Franc**
> "“Dad, can I ask you something?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“Go on.”"*)
  - -> `[68]` (*Player: "“We are family. You can ask anything.”"*)
  - -> `[69]` (*Player_Italic: "Wait for him to continue."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "My father was a poor man who struggled to provide for us ..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "My father was a rich man. We never had to worry about foo..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "My father was a hard-working man and always had our best ..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "My father was a poor man who struggled to provide for us on his meager income. He put me to work on the farm long before I was Franc's age, and even then, we couldn't always make ends meet. Yet, we were always close as a family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Now that I was the president, I knew Franc would never fa..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "My father was a rich man. We never had to worry about food, clothes, or anything else. Yet he was nearly always away -- and constantly distracted on the rare occasions when he was at home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "Now that I was the president, I was worried that I would ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "My father was a hard-working man and always had our best interests in mind -- or at least, that's what he always said. But he had a temper, and would lash out at my mother in fights I could hear from my bedroom. By the time I was Franc's age, we seldom spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "Now that I was the president, I was facing more stress th..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Now that I was the president, I knew Franc would never face the same hardships I had. I couldn't deny that I felt a bit jealous."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Franc: "“Dad, can I ask you something?”"*)

### Węzeł `[65]`
Mówca: **Narrator**
> "Now that I was the president, I was worried that I would end up just like my father. Distant and absent from Franc's life."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Franc: "“Dad, can I ask you something?”"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "Now that I was the president, I was facing more stress than my father ever had. I would have to work hard not to take my frustrations out on my family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Franc: "“Dad, can I ask you something?”"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Franc: "“It's just... I feel like there's so much you've been hid..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“We are family. You can ask anything.”"]** — Mówca: **Player**
> "“We are family. You can ask anything.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Franc: "“It's just... I feel like there's so much you've been hid..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wait for him to continue."]** — Mówca: **Player_Italic**
> "I waited for him to think about what to say."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Franc: "“It's just... I feel like there's so much you've been hid..."*)

### Węzeł `[70]`
Mówca: **Franc**
> "“It's just... I feel like there's so much you've been hiding from me. About your past, and about what's going on right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner == true"*)

### Węzeł `[71]`
Mówca: **Franc**
> "“But... what was it like, back then? Uncle Petr said the two of you went through a lot...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Franc: "“I'm not a kid anymore. You can tell me.""*)

### Węzeł `[72]`
Mówca: **Franc**
> "“I'm not a kid anymore. You can tell me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Before I could gather my thoughts, the familiar images st..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Before I could gather my thoughts, the familiar images started flashing before my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Images of soldiers advancing towards me and my friends, w..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Images of soldiers advancing towards me and my friends, weapons drawn. Of people I knew -- friends and neighbors -- being dragged through streets and murdered in alleyways."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed == true"*)

### Węzeł `[75]`
Mówca: **Narrator**
> "And that little girl's face..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“Those were dark times.”"*)
  - -> `[76]` (*Player: "“I don't want to talk about it.”"*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“I don't want to talk about it.”"]** — Mówca: **Player**
> "“I don't want to talk about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator), `[339]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Hearing the faint trembling in my voice, Franc understood..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Those were dark times.”"]** — Mówca: **Player**
> "“Those were dark times.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator), `[339]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Franc: "“It seems like it.”"*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Hearing the faint trembling in my voice, Franc understood and pushed no further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Franc: "“It's okay. I'm sorry. I shouldn't have asked you about it.”"*)

### Węzeł `[79]`
Mówca: **Franc**
> "“It seems like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player: "“But you're nearly a grown man. Let's talk about it.”"*)
  - -> `[81]` (*Player: "“Let's change the subject.”"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "“But you're nearly a grown man. Let's talk about it.”"]** — Mówca: **Player**
> "“But you're nearly a grown man. Let's talk about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Franc leaned forward in his chair, his eyes wide."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Let's change the subject.”"]** — Mówca: **Player**
> "“Let's change the subject.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Franc: "“It's okay. I'm sorry. I shouldn't have asked you about it.”"*)

### Węzeł `[82]`
Mówca: **Franc**
> "“It's okay. I'm sorry. I shouldn't have asked you about it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Franc: "“I know I don't understand how easy my life is sometimes.”"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying law at the Holsord State University. I was a freshman. Excited and young.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Kontekst wejściowy (poprzednik):** `[92]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""I had just left the classroom...""*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""I was barely older than you are now...""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: ""I was barely older than you are now...""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: ""I was barely older than you are now...""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying economics at the Lachaven Business School. I was a freshman. Excited and young.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true` AND `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[92]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""I had just left the classroom...""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Presidents Past Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == false"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened == false"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || ..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "Tell Franc about the coup of 1927."]** — Mówca: **Player_Italic**
> "It was time to tell him about the coup of 1927."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false`
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator), `[100]` (Narrator), `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "Tell Franc about the civil war."]** — Mówca: **Player_Italic**
> "It was time to tell him about the civil war."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false`
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator), `[100]` (Narrator), `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_HumanRights == true"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“Actually, never mind. Now is not the time to talk about the past.”"]** — Mówca: **Player**
> "“Actually, never mind. Now is not the time to talk about the past.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator), `[100]` (Narrator), `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Franc: "“It's okay. I'm sorry. I shouldn't have asked you about it.”"*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I had just left the classroom...""]** — Mówca: **Player**
> ""I had just left the classroom to go back home as I heard the sound of multiple vehicles approaching the campus gates. As they got closer, I realized they were military camouflaged trucks and tanks, carrying hundreds of soldiers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Player), `[90]` (Player), `[347]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player: ""The same soldiers that were supposed to protect Sordland..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""The same soldiers that were supposed to protect Sordland's citizens pointed their guns at us...""]** — Mówca: **Player**
> ""The same soldiers that were supposed to protect Sordland's citizens pointed their guns at us. They immediately took control of the facilities. One of my friends asked what was going on and was arrested immediately. More people got angry and gathered in protest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "Franc kept listening, a shocked look on his face."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_1stCoup_Protested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_1stCoup_Protested == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_1stCoup_Protested == true)"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_1stCoup_Protested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Italic: "Tell him about the soldiers beating you."*)
  - -> `[162]` (*Player_Italic: "Refrain from telling him the brutality."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_1stCoup_Protested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Italic: "Tell him that you ran for your life like a coward."*)
  - -> `[164]` (*Player_Italic: "Refrain from telling him about your quick escape."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I stopped there and turned my head away from Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened = true"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Presidents Past Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "Presidents Past Hub"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` AND `Variable["BaseGame.Prologue_University_Group_HumanRights"] == true`
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_HumanRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_HumanRights == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Group_HumanRights == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_HumanRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Group_HumanRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Group_HumanRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_StudentCouncil == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_StudentCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_StudentCouncil == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Group_StudentCouncil == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_StudentCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Group_StudentCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player: ""It was right after I met your mother...""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true` AND `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false` AND `Variable["BaseGame.Prologue_University_Group_HumanRights"] == true`
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same human rights group to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false` AND `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false` AND `Variable["BaseGame.Prologue_University_Group_HumanRights"] == true`
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother. We had both joined the student council to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` AND `Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true` AND `(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother. We had both joined the student council to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the student council to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "Tell Franc about the clash between Luderin and Rikard."]** — Mówca: **Player_Italic**
> ""Then, one night, it happened. Two different factions in the army, one of them led by maximist general Luderin and the other by socialist general Rikard, started fighting against each other. It was a bloodbath. Nowhere was safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Player), `[127]` (Player), `[128]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "Franc shifted in his seat, visibly uncomfortable."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""So we organized a protest...""]** — Mówca: **Player**
> ""So we organised a protest one day in support of Rikard. In our minds, he was the better of the two and a true socialist.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` AND `Variable["BaseGame.Prologue_University_Political_Active"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed == true"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: ""So we organized a protest...""*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: ""So we organized a protest...""*)

### Węzeł `[137]`
**[WYBÓR GRACZA: ""So we organized a protest...""]** — Mówca: **Player**
> ""So we organised a protest one day against Rikard. We were fed up with the army toying with the country again.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false` AND `Variable["BaseGame.Prologue_University_Political_Active"] == true`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Presidents Past Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "Presidents Past Hub"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup28_Listened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "Jump to: [Presidents Past Hub]"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "Jump to: [Presidents Past Hub]"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || ..."*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true |..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Player: "“That's enough for today.”"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: "“Actually, never mind. Now is not the time to talk about ..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "“That's enough for today.”"]** — Mówca: **Player**
> "“That's enough for today.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true`
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator), `[100]` (Narrator), `[167]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Franc: "“It's okay. I'm sorry. I shouldn't have asked you about it.”"*)

### Węzeł `[145]`
Mówca: **Franc**
> "“I know I don't understand how easy my life is sometimes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Franc hesitated, then moved over to where I was sitting and gave me an awkward pat on the back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[147]`
Mówca: **Franc**
> ""I know I complain sometimes, but my problems are nothing compared to what you went through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: ""I'm here to listen to them, no matter what they are.""*)
  - -> `[148]` (*Player: "“What problems?”"*)
  - -> `[350]` (*Player: ""You're damn right. Your generation will never understand.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "“What problems?”"]** — Mówca: **Player**
> "“What problems?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "Before Franc could say anything else, I heard the front d..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "Before Franc could say anything else, I heard the front door unlock. Deana and Monica's voices and the sounds of rustling shopping bags filled the house."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)

### Węzeł `[150]`
Mówca: **Franc**
> "“I should get some studying done before dinner. But thanks for this, Dad. I mean it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Franc went in and dashed upstairs."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "Franc went in and dashed upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "I took a long sip from my beer, looking at the city and t..."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "I took a long sip from my beer, looking at the city and the now-setting sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || ..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "I hoped that talking to Franc about my past had been the right decision. Part of me felt as if some sort of burden had been lifted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "But I had the same nightmares again that night."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "But I had the same nightmares again that night."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "But I had the same nightmares again that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "But I had the same nightmares again that night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;
BaseGameSupport.Report_Turn03_Antel_PrisonRiot = true;
BaseGameSupport.Report_Turn03_Morna_IndustrialOutput = true;
BaseGameSupport.Report_Turn03_Holsord_USPReport = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_HP_AttackerOpenedFire"] = true;
Variable["BaseGameSupport.Report_Turn03_Antel_PrisonRiot"] = true;
Variable["BaseGameSupport.Report_Turn03_Morna_IndustrialOutput"] = true;
Variable["BaseGameSupport.Report_Turn03_Holsord_USPReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "AddTokenStatus("Sordland_City_Morna", "City_LowIndustrial..."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Franc leaned forward in his chair, his eyes wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "Presidents Past Hub"*)

### Węzeł `[161]`
**[WYBÓR GRACZA: "Tell him about the soldiers beating you."]** — Mówca: **Player_Italic**
> ""I was there with the protesters as they declared martial law. We marched towards them. They threatened to use force, but we stood our ground. So they started beating anyone they saw, including me. The physical wounds took a few weeks to heal, but the mental scars have stayed with me to this day.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true`
- **Kontekst wejściowy (poprzednik):** `[348]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: ""I was lucky...""*)
  - -> `[357]` (*Player: ""I stayed strong...""*)

### Węzeł `[162]`
**[WYBÓR GRACZA: "Refrain from telling him the brutality."]** — Mówca: **Player_Italic**
> ""I was there with the protesters as they declared martial law. We marched towards them. They threatened to use force but we stood our ground. ""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true`
- **Kontekst wejściowy (poprzednik):** `[348]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I stopped there and turned my head away from Franc."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "Tell him that you ran for your life like a coward."]** — Mówca: **Player_Italic**
> ""Seeing the crowd gathering, I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and ran away from the scene. Ran away from my friends who were getting arrested and shot to save my own dear life like a coward.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[348]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""I still feel my flight was justified -- anyone would do ..."*)
  - -> `[356]` (*Player: ""I still feel my flight was shameful -- I should have sto..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: "Refrain from telling him about your quick escape."]** — Mówca: **Player_Italic**
> ""Seeing the crowd gathering, I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and departed.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_1stCoup_Protested"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[348]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "I stopped there and turned my head away from Franc."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""I was lucky...""]** — Mówca: **Player**
> ""I was still one of the lucky ones. Some of my friends were shot; many more were arrested. I can't forget the screams to this day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Franc leaned back in his chair. His shoulders slumped hea..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I still feel my flight was justified -- anyone would do the same...""]** — Mówca: **Player**
> ""I still feel my flight was justified -- anyone would do the same. No one could sleep that night because of gunshots and sounds of boots. I can't forget the screams to this day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Franc leaned back in his chair. His shoulders slumped hea..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "I stopped there and turned my head away from Franc."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened = true"*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "Tell him about the girl."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Kontekst wejściowy (poprzednik):** `[133]` (Player), `[137]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: ""It was horrible...""*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Protest_Girl_Crushed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed == true"*)
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Protest_Girl_Crushed == true)"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Protest_Girl_Crushed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Italic: "Tell him about the girl."*)
  - -> `[172]` (*Player_Italic: "Refrain from telling him about the girl."*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Protest_Girl_Crushed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Italic: "Tell him that you ran away."*)
  - -> `[181]` (*Player_Italic: "Refrain from telling him about your escape."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "Refrain from telling him about the girl."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Kontekst wejściowy (poprzednik):** `[133]` (Player), `[137]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player: ""It was horrible...""*)

### Węzeł `[173]`
Mówca: **Narrator**
> "I trailed off. There were some things my son didn't have to know."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened = true"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "Franc leaned back in his chair. His shoulders slumped heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened = true"*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Franc leaned back in his chair. His shoulders slumped heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened = true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "Franc's face had grown pale. He turned his eyes away from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Active == true)"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Active"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Active == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Active"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: ""I stayed out of it...""*)

### Węzeł `[180]`
**[WYBÓR GRACZA: ""I stayed out of it...""]** — Mówca: **Player**
> ""People organised protests either for or against Rikard. I heard about the clashes the next day. Many of my friends were shot or arrested. I isolated myself for months.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_University_Political_Active"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[186]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened = true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "Refrain from telling him about your escape."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[133]` (Player), `[137]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player: ""We were ready to face them...""*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "Tell him that you ran away."]** — Mówca: **Player_Italic**
> "I paused for a moment before continuing."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[133]` (Player), `[137]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Player: ""Soldiers were waiting for us...""*)

### Węzeł `[183]`
Mówca: **Narrator**
> "I trailed off, hoping Franc wouldn't ask for any more details."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened = true"*)

### Węzeł `[184]`
Mówca: **Narrator**
> "Years later, I still felt that I was right. How could mere civilians go against a fully trained army, regardless of how just their cause was?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Franc turned away, lost in his own thoughts."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Franc turned away, lost in his own thoughts."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened = true"*)

### Węzeł `[186]`
Mówca: **Narrator**
> "Franc shifted in his seat, visibly uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active == true"*)

### Węzeł `[187]`
Mówca: **Narrator**
> "Sure enough, as soon as Franc glimpsed the grill and the meat, he stepped outside to join me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner"*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Sure enough, as soon as Franc glimpsed the grill and the ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "Sure enough, as soon as Franc glimpsed the grill and the ..."*)

### Węzeł `[191]`
Mówca: **Franc**
> "“Dad, is there going to be a civil war in Sordland?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“I hope not.”"*)
  - -> `[193]` (*Player: "“No. I will never let that happen.”"*)
  - -> `[194]` (*Player_Italic: "Say nothing and avoid his question."*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“I hope not.”"]** — Mówca: **Player**
> "“I hope not.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "He let out a sigh."*)

### Węzeł `[193]`
**[WYBÓR GRACZA: "“No. I will never let that happen.”"]** — Mówca: **Player**
> "“No. I will never let that happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Franc: ""Good.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "Say nothing and avoid his question."]** — Mówca: **Player_Italic**
> "I said nothing and turned my head away from him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[195]`
Mówca: **Franc**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Franc: "“But... what was it like, back then? Uncle Petr said the ..."*)

### Węzeł `[196]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Franc: "“But... what was it like, back then? Uncle Petr said the ..."*)

### Węzeł `[197]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Franc: "“But... what was it like, back then? Uncle Petr said the ..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup28_Listened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup28_Listened == false"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_Franc_Coup28_Listened == false)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup28_Listened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player_Italic: "Tell Franc about the civil war."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_Franc_Coup28_Listened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == false"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == false)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player_Italic: "Tell Franc about the coup of 1927."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WYBÓR GRACZA: "“I didn't say bribery was good, did I? You can always make the moral choice and turn these delicious ribs down...”"]** — Mówca: **Player**
> "“I didn't say bribery was good, did I? You can always make the moral choice and turn these delicious ribs down...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "Franc smiled for a second. I turned to tend to the fire."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "Franc smiled for a second. I turned to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "For a moment, my thoughts flashed back to my childhood an..."*)

### Węzeł `[208]`
Mówca: **Franc**
> "“Geez, you're barely ever here, and when you are you order me around like I'm the butler?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Player_Italic: "Ask again more politely."*)
  - -> `[213]` (*Player: "“Franc! I said don't make me angry!”"*)
  - -> `[215]` (*Player: "“I'm sorry. Work is overwhelming sometimes. I shouldn't h..."*)

### Węzeł `[209]`
Mówca: **Franc**
> "“As long as it's a request, not an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Franc: "“Stop yelling at me. Why are you always like this?""*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "Ask again more politely."]** — Mówca: **Player_Italic**
> "“Let me try again. Franc, it would be a great help if you would bring the tray from the kitchen. Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[212]`
Mówca: **Franc**
> "“See, was that so hard?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Franc! I said don't make me angry!”"]** — Mówca: **Player**
> "<shout>“Franc! I said don't make me angry!”</shout>"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2"*)

### Węzeł `[214]`
Mówca: **Franc**
> "“Stop yelling at me. Why are you always like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Franc: ""You never even asked me how it feels -- being treated di..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“I'm sorry. Work is overwhelming sometimes. I shouldn't have taken it out on you.”"]** — Mówca: **Player**
> "“I'm sorry. Work has been overwhelming, but I shouldn't take that out on you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2"*)

### Węzeł `[216]`
Mówca: **Franc**
> "“Yeah, sure, it's okay. You know, being the president's son isn't exactly a picnic either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Franc: ""You never even asked me how it feels -- being treated di..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "“I can only imagine. I'm proud of how well you've been handling everything.”"]** — Mówca: **Player**
> "“I can only imagine. I'm proud of how you've been handling all the changes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 2"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: "“We can talk about it more later. For now, will you please go fetch the tray so we can eat?”"]** — Mówca: **Player**
> "“We can talk about it more later. For now, will you please go fetch the tray so we can eat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Franc: "“Aye aye, cap'n.”"*)

### Węzeł `[219]`
Mówca: **Franc**
> "“Aye aye, cap'n.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: "“No. You're my son and I'm asking you. Can you bring the tray now, please?”"]** — Mówca: **Player**
> "“No. You're my son and I'm asking you. Can you bring the tray now, please?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)

### Węzeł `[222]`
Mówca: **Franc**
> "“Ah. *Please*. The magic word.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Franc: "“Fine, I'll be back.”"*)

### Węzeł `[223]`
Mówca: **Franc**
> "“Fine, I'll be back.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Damn your generation. You are all the same. Weak.”"]** — Mówca: **Player**
> "“Damn your generation. You are all the same. Weak.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[225]`
Mówca: **Franc**
> ""Weak?! Dad, can't you see you're not the only one having a hard time here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Franc: ""You never even asked me how it feels -- being treated di..."*)

### Węzeł `[226]`
Mówca: **Franc**
> ""You never even asked me how it feels -- being treated differently in school, everyone asking me about the riots all the time, not even being able to take a piss without those guards following me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Player: "“I can only imagine. I'm proud of how well you've been ha..."*)
  - -> `[218]` (*Player: "“We can talk about it more later. For now, will you pleas..."*)
  - -> `[227]` (*Player: "“Oh, cry me a river. Grow a spine and make something of y..."*)
  - -> `[234]` (*Player: "“I've warned you. Shut up and do as I say -- or else.”"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Oh, cry me a river. Grow a spine and make something of yourself.”"]** — Mówca: **Player**
> "“Oh, cry me a river. Grow a spine and make something of yourself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[228]`
Mówca: **Franc**
> "“I'm sorry for being spineless, okay? Are you happy now? I'll get your goddamn tray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "Franc returned with a tray large enough to hold all the meat and vegetables. He shoved it at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Franc: "“I'm going to my room.”"*)

### Węzeł `[230]`
Mówca: **Franc**
> "“I'm going to my room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Narrator: "He ran inside the house before I could say anything. The ..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Franc: "“I'm sorry for being spineless, okay? Are you happy now? ..."*)

### Węzeł `[232]`
Mówca: **Narrator**
> "He ran inside the house before I could say anything. The door slammed behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "I took a long sip from my beer."*)

### Węzeł `[233]`
Mówca: **Narrator**
> "I took a long sip from my beer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“I've warned you. Shut up and do as I say -- or else.”"]** — Mówca: **Player**
> "“I've warned you. Shut up and do as I say -- or else.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Franc: "“Or else what? You're going to slap me? Beat me?”"*)

### Węzeł `[236]`
Mówca: **Franc**
> "“Or else what? You're going to slap me? Beat me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Franc: "“Fine. I'll go get your goddamn tray.""*)

### Węzeł `[237]`
Mówca: **Franc**
> "“Fine. I'll go get your goddamn tray.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -5)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "He nodded."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Franc: "“Thank you, sir. It is in our utmost interest to fulfill ..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "I realized my throat was parched. There was a six-pack of..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -5)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Franc: "“I should get some studying done before dinner. But thank..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Franc: "“Alright. I'll be upstairs until dinner.”"*)

### Węzeł `[245]`
Mówca: **Franc**
> "“Alright. I'll be upstairs until dinner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "Franc went in and dashed upstairs."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -5)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Franc: "“Yes, Father.”"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Franc: "“Ah. *Please*. The magic word.”"*)

### Węzeł `[249]`
Mówca: **Franc**
> "“Yes, Father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -5)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Franc: "“As long as it's a request, not an order.”"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Franc: "“You will have to go through my secretary first.”"*)

### Węzeł `[253]`
Mówca: **Franc**
> "“You will have to go through my secretary first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "He laughed and started making his way to the kitchen."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "He laughed and started making his way to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Franc returned with a tray large enough to hold all the m..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -5)"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Franc hesitated, then moved over to where I was sitting a..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[258]`
Mówca: **Franc**
> "“One more thing, though -- I know you joined the Young Sords back then. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player: "“Yes, I do mind. I don't want to talk about it.”"*)
  - -> `[268]` (*Player: "“Sordland was under attack by communists and I had to def..."*)
  - -> `[271]` (*Player: "“I had to survive somehow in that environment and I made ..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Franc: "“One more thing, though -- I know you joined the Young So..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Franc: "“One more thing, though -- I know that you joined Red You..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Franc: "“One more thing, though -- I know that you managed to not..."*)

### Węzeł `[265]`
Mówca: **Franc**
> "“One more thing, though -- I know that you joined Red Youth back then. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player: "“Yes, I do mind. I don't want to talk about it.”"*)
  - -> `[274]` (*Player: "“A communist revolution for Sordland was and still is the..."*)
  - -> `[276]` (*Player: "“I had to survive somehow in that environment, and I made..."*)

### Węzeł `[266]`
Mówca: **Franc**
> "“One more thing, though -- I know that you managed to not take any sides. Do you mind if I ask why?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: "“Yes, I do mind. I don't want to talk about it.”"*)
  - -> `[280]` (*Player: "“I didn't want to be part of the violence.""*)
  - -> `[281]` (*Player: "“They are two sides of the same coin.”"*)

### Węzeł `[267]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Franc: "“Okay. I was just curious, that's all.”"*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“Sordland was under attack by communists and I had to defend the country.”"]** — Mówca: **Player**
> "“Sordland was under attack by communists and I had to defend the country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[269]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[270]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“I had to survive somehow in that environment and I made a choice.”"]** — Mówca: **Player**
> "“I had to survive somehow in that environment and I made a choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Franc: "“Okay. I was just curious, that's all.”"*)

### Węzeł `[273]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA: "“A communist revolution for Sordland was and still is the only way.”"]** — Mówca: **Player**
> "“A communist revolution for Sordland was and still is the only way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA: "“I had to survive somehow in that environment, and I made a choice.”"]** — Mówca: **Player**
> "“I had to survive somehow in that environment, and I made a choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[265]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: "“Yes, I do mind. I don't want to talk about it.”"]** — Mówca: **Player**
> "“Yes, I do mind. I don't want to talk about it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Franc: "“Okay. I was just curious, that's all.”"*)

### Węzeł `[278]`
Mówca: **Franc**
> "“Okay. I was just curious, that's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[279]`
Mówca: **Narrator**
> "Franc raised his eyebrows, his curiosity still not satisfied. But sensing my reluctance to go on, he simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Franc: "“Sorry for bombarding you with questions.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA: "“I didn't want to be part of the violence.""]** — Mówca: **Player**
> "“I didn't want to be part of the violence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "“They are two sides of the same coin.”"]** — Mówca: **Player**
> "“They are two sides of the same coin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "Franc raised his eyebrows, his curiosity still not satisf..."*)

### Węzeł `[282]`
Mówca: **Franc**
> "“Sorry for bombarding you with questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Franc: ""I know I complain sometimes, but my problems are nothing..."*)

### Węzeł `[283]`
**[WYBÓR GRACZA: "“Don't act like you've done something special, Franc.”"]** — Mówca: **Player**
> "“Don't act like you've done anything special, Franc.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "He gave me a blank stare and then turned his eyes away."*)

### Węzeł `[284]`
Mówca: **Narrator**
> "He gave me a blank stare and then turned his eyes away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 2"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "I realized my throat was parched. There was a six-pack of..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_R_UndemocraticElections = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_R_UndemocraticElections"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_FreedomOfPress = false; BaseGame.S..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Monica and Deana were out shopping for craft supplies, an..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_FreedomOfPress = false; BaseGame.Situation_Law_MediaBias = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_FreedomOfPress"] = false;
Variable["BaseGame.Situation_Law_MediaBias"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Monica and Deana were out shopping for craft supplies, an..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_Personal_FrancTalk = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_Personal_FrancTalk"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnoli..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Lachaven_H3_SSC = true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Holsord_L1_SSC = true"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Holsord_L1_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Holsord_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Lachaven_H3_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lachaven_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[307]`
Mówca: **Narrator**
> "I wasn't sure how he felt about me at the moment. But I did know how he felt about barbecued ribs. Our cook had left some marinating in the refrigerator."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_R_UndemocraticElections = true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_MadAtDinner)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""So, you've finally decided to speak to me again?""*)
  - -> `[312]` (*Player: ""Well, look who's finally out of his room.""*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_MadAtDinner)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player: ""Well, look who's finally out of his room.""*)
  - -> `[313]` (*Player: ""Come to spend some quality time with your old man, have ..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""So, you've finally decided to speak to me again?""]** — Mówca: **Player**
> ""So, you've decided to speak to me again?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Franc_MadAtDinner"]`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Franc: ""Don't get any ideas, Dad. I'm only here for the ribs.""*)

### Węzeł `[312]`
**[WYBÓR GRACZA: ""Well, look who's finally out of his room.""]** — Mówca: **Player**
> ""Well, look who's finally out of his room.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Franc_MadAtDinner"]`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -1"*)

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Come to spend some quality time with your old man, have you?""]** — Mówca: **Player**
> ""Come to spend some quality time with your old man, have you?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"]) == false`
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator), `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -1"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -1)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Franc: ""Don't get any ideas, Dad. I'm only here for the ribs.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Franc: ""You should talk, Dad. I never see you at home anymore.""*)

### Węzeł `[317]`
Mówca: **Franc**
> ""You should talk, Dad. I never see you at home anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player: ""Look, son, I'm preoccupied with matters of national impo..."*)
  - -> `[322]` (*Player: ""I'm sorry, I know I haven't been around very often latel..."*)

### Węzeł `[318]`
Mówca: **Franc**
> ""Sure, if you can spare a few minutes out of your busy schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Children who talk back to their fathers don't get dinner..."*)
  - -> `[323]` (*Player: ""Look, son, I'm preoccupied with matters of national impo..."*)
  - -> `[322]` (*Player: ""I'm sorry, I know I haven't been around very often latel..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -1"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_Opinion <= -1)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion <= -1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_Opinion"] <= -1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Franc: ""Don't get any ideas, Dad. I'm only here for the ribs.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_Opinion <= -1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_Opinion"] <= -1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Franc: ""Sure, if you can spare a few minutes out of your busy sc..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA: ""I'm sorry, I know I haven't been around very often lately. But I'm happy to see you now.""]** — Mówca: **Player**
> ""I'm sorry, I know I haven't been around very often lately. But I'm happy to see you now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Franc), `[318]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[323]`
**[WYBÓR GRACZA: ""Look, son, I'm preoccupied with matters of national importance.""]** — Mówca: **Player**
> ""Look, son, I'm preoccupied with matters of national importance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Franc), `[318]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Franc: ""Yes, Mr. President. Whatever you say, Mr. President.""*)

### Węzeł `[324]`
Mówca: **Franc**
> ""Yes, Mr. President. Whatever you say, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Children who talk back to their fathers don't get dinner..."*)
  - -> `[326]` (*Player: ""But right now, nothing's more important than these ribs.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Franc: ""It's okay. I know you've got the most stressful job in t..."*)

### Węzeł `[326]`
**[WYBÓR GRACZA: ""But right now, nothing's more important than these ribs.""]** — Mówca: **Player**
> ""But right now, nothing's more important than these ribs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Franc sighed and waved the fan lazily, almost causing the..."*)

### Węzeł `[328]`
Mówca: **Franc**
> ""It's okay. I know you've got the most stressful job in the country. And you've got to feed your family on top of it all...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "We both chuckled. I turned to tend to the fire."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "We both chuckled. I turned to tend to the fire."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)

### Węzeł `[330]`
Mówca: **Franc**
> ""Like at dinner that night after the ball. You told me everything was under control, but it wasn't, was it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Franc: ""I know what happened in the '20s -- we learned all about..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner == true"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_MadAtDinner == true)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Franc: ""Like at dinner that night after the ball. Maybe I should..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_MadAtDinner == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Franc: ""Like at dinner that night after the ball. You told me ev..."*)

### Węzeł `[334]`
Mówca: **Franc**
> ""I know what happened in the '20s -- we learned all about it in school. Now, with the protests and the riots, is it going to be the same thing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Franc: "“Dad, is there going to be a civil war in Sordland?”"*)

### Węzeł `[335]`
Mówca: **Franc**
> ""Like at dinner that night after the ball. Maybe I shouldn't have brought it up in front of Deana, but I was right, wasn't I? It's bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Franc: ""I know what happened in the '20s -- we learned all about..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Protest_Girl_Crushed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed == true"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Protest_Girl_Crushed == true)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Protest_Girl_Crushed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "And that little girl's face..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Protest_Girl_Crushed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Protest_Girl_Crushed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "The shock and grief on the faces of fathers, mothers and ..."*)

### Węzeł `[339]`
Mówca: **Narrator**
> "The shock and grief on the faces of fathers, mothers and orphaned children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: "“Those were dark times.”"*)
  - -> `[76]` (*Player: "“I don't want to talk about it.”"*)

### Węzeł `[340]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. But over the next year, the state of Sordland deteriorated. People started picking sides, and I tried to stay away as much as I could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Young Sords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""It was right after I met your mother...""]** — Mówca: **Player**
> ""It was right after I met your mother -- we had both joined the same political debate group to push for change after the coup of '27. Eventually, I became convinced I wasn't doing enough. So I joined the Red Youth.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true` AND `(Variable["BaseGame.Prologue_University_Group_StudentCouncil"] == true) == false` AND `(Variable["BaseGame.Prologue_University_Group_HumanRights"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[93]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player_Italic: "Tell Franc about the clash between Luderin and Rikard."*)

### Węzeł `[343]`
**[WYBÓR GRACZA: ""It was horrible...""]** — Mówca: **Player**
> ""It was horrible. They were waiting for us. Soldiers started beating and shooting at everyone, and plowing their tanks into the crowd. Amid the chaos, there was this girl. I never forgot her face. I tried to save her, but I couldn't reach her in time...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "Franc's face had grown pale. He turned his eyes away from..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA: ""It was horrible...""]** — Mówca: **Player**
> ""It was horrible. They were waiting for us. Everything plunged into chaos. Soldiers started beating and shooting at everyone....""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "I trailed off. There were some things my son didn't have ..."*)

### Węzeł `[345]`
**[WYBÓR GRACZA: ""Soldiers were waiting for us...""]** — Mówca: **Player**
> ""Soldiers were waiting for us. I knew something was going to happen. Something bad. I decided that it was impossible to go against armed men and ran away from the scene.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "Years later, I still felt that I was right. How could mer..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: ""We were ready to face them...""]** — Mówca: **Player**
> ""We were ready to face them. I had no time for bad feelings, they rushed at us. We stood and fought but many were arrested and shot...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "I trailed off, hoping Franc wouldn't ask for any more det..."*)

### Węzeł `[347]`
**[WYBÓR GRACZA: ""I was barely older than you are now...""]** — Mówca: **Player**
> ""I was barely older than you are now, studying history at the Deyr University of Culture. I was a freshman. Excited and young.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false` AND `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[92]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: ""I had just left the classroom...""*)

### Węzeł `[348]`
Mówca: **Narrator**
> "Franc kept listening, a shocked look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_1stCoup_Protested == true"*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""I'm here to listen to them, no matter what they are.""]** — Mówca: **Player**
> ""I'm here to listen to them, no matter what they are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[350]`
**[WYBÓR GRACZA: ""You're damn right. Your generation will never understand.""]** — Mówca: **Player**
> ""You're damn right. Your generation will never understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "Before Franc could say anything else, I heard the front d..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "Before Franc could say anything else, I heard the front d..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || ..."*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true |..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "I hoped that talking to Franc about my past had been the ..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn03_Franc_Coup27_Listened == true || BaseGameIsolated.Turn03_Franc_Coup28_Listened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn03_Franc_Coup27_Listened"] == true  or  Variable["BaseGameIsolated.Turn03_Franc_Coup28_Listened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_HP_AttackerOpenedFire = true;..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""I still feel my flight was shameful -- I should have stood my ground...""]** — Mówca: **Player**
> ""I still feel my flight was shameful -- I should have stood my ground. No one could sleep that night because of gunshots and sounds of boots. I can't forget the screams to this day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Franc leaned back in his chair. His shoulders slumped hea..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""I stayed strong...""]** — Mówca: **Player**
> ""I tried my best to stay strong. Some of my friends were shot; many more were arrested. I can't forget the screams to this day. But I'm proud not to have faltered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Player_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "Franc leaned back in his chair. His shoulders slumped hea..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == ..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan =..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn02_EconomicRelief_DontEnactPlan"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -1"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "We both chuckled. I turned to tend to the fire."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "“See? It's easy.""*)
  - -> `[23]` (*Player: "“My father would have slapped me for this.”"*)
  - -> `[24]` (*Player: "“Hard work usually pays off.”"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Franc: "“Looks like it.”"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Franc: "“I guess I should be grateful that you don't...”"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Franc: "“Uh oh. I know that look.”"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Franc: "“Geez, you're barely ever here, and when you are you orde..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Franc: ""Weak?! Dad, can't you see you're not the only one having..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Franc: "“See, was that so hard?”"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Franc: "“Yeah, sure, it's okay. You know, being the president's s..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion <= -5"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "He let out a sigh."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Lachaven_H3_Underhall = true"*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn03_Holsord_L1_Underhall = true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn03_Holsord_L1_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn03_Holsord_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_Personal_FrancTalk = true"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS = true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == false"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_DerbyPostponedBanYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == false"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == false)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_DerbyPostponedNoRYBan = true"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddTokenStatus("Sordland_City_Morna", "City_LowIndustrialOutput");`
- **Efekt skryptowy (`userScript`):** `AddTokenStatus("Sordland_City_Morna","City_LowIndustrialOutput");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia = true;
BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer = true;
BaseGameSupport.News_Turn03_E_Gasom_Critique = true;
BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth = true;
BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments = true;
BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique = true;
BaseGameSupport.News_Turn03_HP_GreenBillCritique = true;
BaseGameSupport.News_Turn03_R_GreenBill_Support = true;
BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn03_ATO_AidSupportAgnolia"] = true;
Variable["BaseGameSupport.CountryReport_Turn03_Rizia_EnergyCooperationOffer"] = true;
Variable["BaseGameSupport.News_Turn03_E_Gasom_Critique"] = true;
Variable["BaseGameSupport.News_Turn03_E_GreenBill_BadForGrowth"] = true;
Variable["BaseGameSupport.News_Turn03_G_AnrakaDiversifiesInvestments"] = true;
Variable["BaseGameSupport.News_Turn03_G_CSPWorkerReportCritique"] = true;
Variable["BaseGameSupport.News_Turn03_HP_GreenBillCritique"] = true;
Variable["BaseGameSupport.News_Turn03_R_GreenBill_Support"] = true;
Variable["BaseGameSupport.News_Turn03_LT_Gasom_RiziaInvestInterest"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill..."*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == true && BaseGame.Bi..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_TourismBill_SupportSign = ..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == true && BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false && BaseGame.Bil..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaBias == false && BaseGame.Bil..."*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaBias == false && BaseGame.B..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == false  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_ST_TourismBill_CritiqueVeto =..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaBias == false && BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == false  and  Variable["BaseGame.Bill_Turn02_TourismCulturalPreservation_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[401]`
Mówca: **Franc**
> "“Looks like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Franc: "“Here, let me try.”"*)
