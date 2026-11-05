# Rizia/Turn 8/A_SalInvestigationResults

- **ID konwersacji:** `406`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Rizia/Turn_08/406_A_SalInvestigationResults.md`
- **Liczba węzłów dialogowych:** 825
- **Liczba wyborów gracza:** 127

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLCIsolated.SalInvestigation_Alone`
- `RiziaDLCIsolated.SalInvestigation_Paper_1`
- `RiziaDLCIsolated.SalInvestigation_Paper_2`
- `RiziaDLCIsolated.SalInvestigation_Paper_3`
- `RiziaDLCIsolated.SalInvestigation_Paper_4`
- `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyName`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork`
- `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne`
- `RiziaDLCIsolated.SalInvestigation_Sal_Sorry`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare`
- `RiziaDLCIsolated.Turn07_TitusChat_Derdia`
- `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PoisonInvestigation_Continues`
- `RiziaDLC.Religious_WruhecsGuardians_Sal`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.SalExonerated`
- `RiziaDLC.Sal_Arrested`
- `RiziaDLC.Sal_MentionsProphecy`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLCIsolated.SalInvestigation_Alone`
- `RiziaDLCIsolated.SalInvestigation_Paper_1`
- `RiziaDLCIsolated.SalInvestigation_Paper_2`
- `RiziaDLCIsolated.SalInvestigation_Paper_3`
- `RiziaDLCIsolated.SalInvestigation_Paper_4`
- `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation`
- `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity`
- `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure`
- `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne`
- `RiziaDLCIsolated.SalInvestigation_Sal_Sorry`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt`
- `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare`
- `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus`
- `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested`
- `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo`
- `RiziaDLCSupport.News_Turn08_RH_SalArrested`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[6]` | **""What's so urgent that it keeps me from enjoying my lunch in peace and quiet?""** | `[10]` **Lucita Azaro**: ""I'm sorry to disrupt you, Your ..."<br>`[11]` **Titus Gordion**: ""I'm sorry to disrupt you, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "She gestured at Pabel."<br>`[295]` **Narrator**: "He gestured at Pabel." |
| `[12]` | **""Speak.""** | `[10]` **Lucita Azaro**: ""I'm sorry to disrupt you, Your ..."<br>`[11]` **Titus Gordion**: ""I'm sorry to disrupt you, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "She gestured at Pabel."<br>`[295]` **Narrator**: "He gestured at Pabel." |
| `[13]` | **""No worries at all. What can I do for you?""** | `[10]` **Lucita Azaro**: ""I'm sorry to disrupt you, Your ..."<br>`[11]` **Titus Gordion**: ""I'm sorry to disrupt you, sir."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "She gestured at Pabel."<br>`[295]` **Narrator**: "He gestured at Pabel." |
| `[21]` | **""Out. Now.""** | `[14]` **Lucita Azaro**: ""Even the palace walls have ears..."<br>`[18]` **Titus Gordion**: ""Even the palace walls have ears..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[717]` **Narrator**: "With a look of annoyance only I ..."<br>`[296]` **Narrator**: "Pabel bowed respectfully before ..." |
| `[28]` | **""Where was the bottle found?""** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false`<br>`(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_Bottle...` | `[53]` **Lucita Azaro**: ""The boy took us to a secret cha..."<br>`[54]` **Titus Gordion**: ""The boy took us to a secret cha..." |
| `[33]` | **""Mandragora. So Pabel was right...""** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false`<br>`(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCan...` | `[57]` **Titus Gordion**: ""Your butler told you about this..."<br>`[56]` **Lucita Azaro**: ""Your butler told you this? It's..."<br>*(oraz 1 innych odgałęzień)* |
| `[38]` | **""Who is the boy that told you about this?""** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false`<br>`(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIde...` | `[741]` **Lucita Azaro**: ""Alfreth Tilda. An orphan taken ..."<br>`[59]` **Lucita Azaro**: ""Alfreth Tilda. An orphan taken ..."<br>*(oraz 2 innych odgałęzień)* |
| `[43]` | **""I'm still not convinced. Is the bottle the only evidence you have?""** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 6 innych węzłów)* | `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true` | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""That's not all. There is someth..."<br>`[73]` **Titus Gordion**: ""That's not all. There's somethi..." |
| `[68]` | **""That's quite the revelation. Please go on.""** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true) == false`<br>`(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""That's not all. There is someth..."<br>`[73]` **Titus Gordion**: ""That's not all. There's somethi..." |
| `[76]` | **"Take it and read it."** | `[74]` **Narrator**: "She presented what appeared to b..."<br>`[75]` **Narrator**: "He presented what appeared to be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "There were dates and short descr..." |
| `[79]` | **"Read the first entry."** | `[77]` **Narrator**: "There were dates and short descr..."<br>`[99]` **Narrator**: ""We will see if he is the one. I..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] = t...` | `[96]` **Narrator**: ""October 16th, late afternoon."" |
| `[84]` | **"Read the second entry."** | `[77]` **Narrator**: "There were dates and short descr..."<br>`[99]` **Narrator**: ""We will see if he is the one. I..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] = t...` | `[95]` **Narrator**: ""October 24th, sunset."" |
| `[89]` | **"Read the third entry."** | `[77]` **Narrator**: "There were dates and short descr..."<br>`[99]` **Narrator**: ""We will see if he is the one. I..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] = t...` | `[97]` **Narrator**: ""November 1st, close to midnight."" |
| `[102]` | **"Read the fourth entry."** | `[77]` **Narrator**: "There were dates and short descr..."<br>`[99]` **Narrator**: ""We will see if he is the one. I..."<br>*(oraz 3 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false` | `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] = t...` | `[107]` **Narrator**: ""November 18th, late evening."" |
| `[121]` | **""What do you think I should do?""** | `[119]` **Lucita Azaro**: ""Your orders?""<br>`[120]` **Titus Gordion**: ""Your orders, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Lucita Azaro**: ""If it were up to me, I'd say he..."<br>`[129]` **Titus Gordion**: ""I find it hard to believe the G..." |
| `[122]` | **""What he has or hasn't allegedly done is irrelevant. You're not to mention a word ..."** | `[119]` **Lucita Azaro**: ""Your orders?""<br>`[120]` **Titus Gordion**: ""Your orders, sir?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigation...` | `[133]` **Lucita Azaro**: ""This is... unexpected, but I sh..."<br>`[134]` **Titus Gordion**: ""This is... not the direction I'..." |
| `[123]` | **""Arrest the Grand Wiseman immediately and throw him in prison to rot.""** | `[119]` **Lucita Azaro**: ""Your orders?""<br>`[120]` **Titus Gordion**: ""Your orders, sir?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lucita Azaro**: ""As you wish, Your Majesty.""<br>`[139]` **Titus Gordion**: ""As you wish, sir."" |
| `[124]` | **""Bring him to me. I will talk to him first.""** | `[119]` **Lucita Azaro**: ""Your orders?""<br>`[120]` **Titus Gordion**: ""Your orders, sir?""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResul...` | `[150]` **Lucita Azaro**: ""I'll fetch him at once, Your Ma..."<br>`[151]` **Titus Gordion**: ""I'll bring him at once, Your Ma..." |
| `[161]` | **""Everyone except Sal. Out. I wish to speak to him in private.""** | `[160]` **Narrator**: "The guards held Sal firmly by bo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] = true;` | `[163]` **Narrator**: "It took a few tries to convince ..." |
| `[162]` | **""Keep him close in case he tries anything.""** | `[160]` **Narrator**: "The guards held Sal firmly by bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "The guards held his arms tighter." |
| `[167]` | **""Why did you give my father that poison?""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"]...` | `[207]` **Sal Ignacius**: ""It is not poison, Your Majesty...."<br>`[575]` **Sal Ignacius**: ""It is not poison, Your Majesty,..." |
| `[168]` | **""Why should I spare you?""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"...` | `[213]` **Sal Ignacius**: ""Because there is still hope, Ro..."<br>`[221]` **Sal Ignacius**: ""Do what you must, Your Majesty."" |
| `[169]` | **""Tell me more about this prophecy you were trying to fulfill.""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne...` | `[231]` **Sal Ignacius**: ""This has been passed down for c..." |
| `[182]` | **"“Do you feel remorse for what you've done?”"** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] =...` | `[255]` **Sal Ignacius**: ""I do. Every day, I offer prayer..." |
| `[191]` | **""I'm finished with this interrogation. Everyone, please return.""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | *Brak zmian stanu* | `[603]` **Narrator**: "Lucita and the other guards came..."<br>`[206]` **Narrator**: "Titus and his men came back into..." |
| `[204]` | **""I'm finished with this interrogation. Here is my verdict.""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 10 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`<br>`(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false` | *Brak zmian stanu* | `[761]` **Narrator**: "Suddenly, I heard a commotion ou..."<br>`[256]` **Player_Romus**: ""Arrest Grand Wiseman Sal Ignaci..."<br>*(oraz 1 innych odgałęzień)* |
| `[205]` | **""Here is my verdict.""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 10 innych węzłów)* | `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false`<br>`(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false` | *Brak zmian stanu* | `[761]` **Narrator**: "Suddenly, I heard a commotion ou..."<br>`[256]` **Player_Romus**: ""Arrest Grand Wiseman Sal Ignaci..."<br>*(oraz 1 innych odgałęzień)* |
| `[254]` | **""I don't care what he has or hasn't done. You're not to mention a word of this to ..."** | `[204]` **Player_Romus**: ""I'm finished with this interrog..."<br>`[205]` **Player_Romus**: ""Here is my verdict.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` | `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigation...` | `[269]` **Lucita Azaro**: ""I must admit, this is rather un..."<br>`[270]` **Titus Gordion**: ""I must say, this is not the dir..." |
| `[256]` | **""Arrest Grand Wiseman Sal Ignacius immediately. Let him rot in prison for the rest..."** | `[204]` **Player_Romus**: ""I'm finished with this interrog..."<br>`[205]` **Player_Romus**: ""Here is my verdict.""<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false` | `Variable["RiziaDLC.Sal_Arrested"] = true; Variable["Rizia...` | `[260]` **Lucita Azaro**: ""As you wish, Your Majesty.""<br>`[261]` **Titus Gordion**: ""As you wish, sir."" |
| `[298]` | **""Sal! I knew it was him!""** | `[20]` **Lucita Azaro**: ""It turns out your suspicions we..."<br>`[26]` **Titus Gordion**: ""As it turns out, your suspicion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Lucita Azaro**: ""I had many of his priests inter..."<br>`[733]` **Titus Gordion**: ""Via Sevrio Castellanus, I gaine..."<br>*(oraz 1 innych odgałęzień)* |
| `[299]` | **""Please go on.""** | `[20]` **Lucita Azaro**: ""It turns out your suspicions we..."<br>`[26]` **Titus Gordion**: ""As it turns out, your suspicion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Lucita Azaro**: ""I had many of his priests inter..."<br>`[733]` **Titus Gordion**: ""Via Sevrio Castellanus, I gaine..."<br>*(oraz 1 innych odgałęzień)* |
| `[300]` | **""I have a hard time believing that.""** | `[20]` **Lucita Azaro**: ""It turns out your suspicions we..."<br>`[26]` **Titus Gordion**: ""As it turns out, your suspicion..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[409]` **Lucita Azaro**: ""I had many of his priests inter..."<br>`[733]` **Titus Gordion**: ""Via Sevrio Castellanus, I gaine..."<br>*(oraz 1 innych odgałęzień)* |
| `[304]` | **""Mr. Adria is a trusted confidante, not a wall. He will stay.""** | `[14]` **Lucita Azaro**: ""Even the palace walls have ears..."<br>`[18]` **Titus Gordion**: ""Even the palace walls have ears..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[722]` **Pabel Adria**: ""Thank you, Your Majesty, but it..." |
| `[305]` | **""Thank you, Pabel. You may leave.""** | `[14]` **Lucita Azaro**: ""Even the palace walls have ears..."<br>`[18]` **Titus Gordion**: ""Even the palace walls have ears..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[721]` **Pabel Adria**: ""Right away, Your Majesty."" |
| `[308]` | **""I am not sparing you out of charity. You will help me when the time comes. Just a..."** | `[273]` **Sal Ignacius**: ""Thank you, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Sal Ignacius**: ""Of course."" |
| `[309]` | **""Go now and leave me be.""** | `[273]` **Sal Ignacius**: ""Thank you, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Sal Ignacius**: ""Of course."" |
| `[311]` | **"Nod and gesture for him to leave."** | `[273]` **Sal Ignacius**: ""Thank you, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Sal Ignacius**: ""The path chosen for us will pre..." |
| `[325]` | **""You can disrupt me any time, Lucita. Day or night.""** | `[10]` **Lucita Azaro**: ""I'm sorry to disrupt you, Your ..." | `Variable["RiziaDLC.Relations_Lucita_Together"] == true` | *Brak zmian stanu* | `[326]` **Lucita Azaro**: ""Unfortunately, this disruption ..." |
| `[355]` | **""Everything's a matter of great importance with her. But very well. Send her in.""** | `[332]` **Pabel Adria**: ""She insists it's a matter of gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Narrator**: "He promptly turned to open the d..." |
| `[356]` | **""Send her in right away.""** | `[332]` **Pabel Adria**: ""She insists it's a matter of gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Narrator**: "He quickly turned to open the do..." |
| `[357]` | **""Tell her I'm not here.""** | `[332]` **Pabel Adria**: ""She insists it's a matter of gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Pabel Adria**: ""I'm afraid she knows you are."" |
| `[359]` | **""In that case, just send her in.""** | `[358]` **Pabel Adria**: ""I'm afraid she knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Narrator**: "He swiftly pivoted to open the d..." |
| `[360]` | **""Fine. Let's hear what she has to say.""** | `[358]` **Pabel Adria**: ""I'm afraid she knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Narrator**: "He swiftly pivoted to open the d..." |
| `[361]` | **""Inform her regardless.""** | `[358]` **Pabel Adria**: ""I'm afraid she knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Narrator**: "He promptly left to relay the me..." |
| `[365]` | **""I'm still eating. Ask her to come back later.""** | `[332]` **Pabel Adria**: ""She insists it's a matter of gr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Narrator**: "He promptly left to relay the me..." |
| `[370]` | **""Everything's a matter of great importance with him. But very well. Send him in.""** | `[333]` **Pabel Adria**: ""He insists it's a matter of gre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "He promptly turned to open the d..." |
| `[371]` | **""Send him in right away.""** | `[333]` **Pabel Adria**: ""He insists it's a matter of gre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Narrator**: "He quickly turned to open the do..." |
| `[372]` | **""Tell him I'm not here.""** | `[333]` **Pabel Adria**: ""He insists it's a matter of gre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Pabel Adria**: ""I'm afraid he knows you are."" |
| `[373]` | **""Fine. Let's hear what he has to say.""** | `[377]` **Pabel Adria**: ""I'm afraid he knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Narrator**: "He swiftly pivoted to open the d..." |
| `[378]` | **""In that case, just send him in.""** | `[377]` **Pabel Adria**: ""I'm afraid he knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[376]` **Narrator**: "He swiftly pivoted to open the d..." |
| `[379]` | **""Inform him regardless.""** | `[377]` **Pabel Adria**: ""I'm afraid he knows you are."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Narrator**: "He promptly left to relay the me..." |
| `[380]` | **""I'm still eating. Ask him to come back later.""** | `[333]` **Pabel Adria**: ""He insists it's a matter of gre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Narrator**: "He promptly left to relay the me..." |
| `[391]` | **""Let me guess... in the billiard room... with the candlestick...""** | `[20]` **Lucita Azaro**: ""It turns out your suspicions we..."<br>`[26]` **Titus Gordion**: ""As it turns out, your suspicion..." | `Variable["RiziaDLC.Trait_FunnyKing"]` | *Brak zmian stanu* | `[398]` **Lucita Azaro**: ""I'm sorry, Your Majesty, but I ..."<br>`[399]` **Titus Gordion**: ""If only it were that easy... In..." |
| `[417]` | **""Can't say I'm surprised. Their loyalty is to their wiscerer, not their king.""** | `[410]` **Lucita Azaro**: ""They remained tight-lipped.""<br>`[414]` **Titus Gordion**: ""Every one of them remained tigh..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Lucita Azaro**: ""They'd sooner lose a limb than ..."<br>`[435]` **Titus Gordion**: ""Yes, they'd sooner part with th..." |
| `[418]` | **""Interrogating priests? Are we staging a holy inquisition now?""** | `[410]` **Lucita Azaro**: ""They remained tight-lipped.""<br>`[414]` **Titus Gordion**: ""Every one of them remained tigh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[439]` **Lucita Azaro**: ""I wouldn't go that far... But I..."<br>`[440]` **Titus Gordion**: ""I wouldn't go that far... But I..." |
| `[419]` | **""Hah! Bring them to me. I'll handle them personally.""** | `[410]` **Lucita Azaro**: ""They remained tight-lipped.""<br>`[414]` **Titus Gordion**: ""Every one of them remained tigh..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Lucita Azaro**: ""Fortunately, that won't be nece..."<br>`[430]` **Titus Gordion**: ""Thankfully, that won't be neede..." |
| `[420]` | **""Have you no respect for the sanctity of Wruhecism?""** | `[729]` **Lucita Azaro**: ""Whether under the instructions ..."<br>`[733]` **Titus Gordion**: ""Via Sevrio Castellanus, I gaine..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[424]` **Lucita Azaro**: ""I did what had to be done. In a..."<br>`[425]` **Titus Gordion**: ""Believe me, I took no pleasure ..." |
| `[454]` | **"“You’re unusually quiet. Something on your mind?”"** | `[166]` **Narrator**: "On seeing the journal in my hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[478]` **Sal Ignacius**: ""Your Majesty... please. What ha..." |
| `[455]` | **"“You've been keeping secrets from me, Grand Wiseman.""** | `[166]` **Narrator**: "On seeing the journal in my hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Sal Ignacius**: ""Your Majesty... I assure you I ..." |
| `[456]` | **"“I assume you know why you’re here.”"** | `[166]` **Narrator**: "On seeing the journal in my hand..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[480]` **Sal Ignacius**: ""If I said I did not, would you ..." |
| `[457]` | **"“Would you like to start or should I?""** | `[166]` **Narrator**: "On seeing the journal in my hand..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[462]` **Narrator**: "Sal remained silent." |
| `[458]` | **"“I must say… I've come across some rather intriguing literature lately. Care to in..."** | `[166]` **Narrator**: "On seeing the journal in my hand..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[466]` **Sal Ignacius**: ""Wh... where did you get that?"" |
| `[463]` | **""I suppose the honor is mine.""** | `[462]` **Narrator**: "Sal remained silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[464]` | **""Coward.""** | `[462]` **Narrator**: "Sal remained silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[465]` | **""You might want to say a silent prayer while you're at it.""** | `[462]` **Narrator**: "Sal remained silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[467]` | **""So you do recognize it.""** | `[466]` **Sal Ignacius**: ""Wh... where did you get that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[468]` | **""I'll ask the questions, not you.""** | `[466]` **Sal Ignacius**: ""Wh... where did you get that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[469]` | **""Where you last left it. You've been careless. Sal.""** | `[466]` **Sal Ignacius**: ""Wh... where did you get that?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[471]` | **""Please. Groveling is beneath a man of your stature.""** | `[470]` **Sal Ignacius**: ""Your Majesty... I assure you I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[472]` | **""Silence!""** | `[470]` **Sal Ignacius**: ""Your Majesty... I assure you I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[473]` | **""So you *do* know why I summoned you here. Tell me...""** | `[470]` **Sal Ignacius**: ""Your Majesty... I assure you I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[475]` | **""Well, well... it appears you've been blessed with the gift of foresight after all.""** | `[474]` **Narrator**: "He never looked up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[476]` | **""It was a rhetorical question.""** | `[474]` **Narrator**: "He never looked up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[477]` | **""Look at me when you address your king!""** | `[474]` **Narrator**: "He never looked up." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Narrator**: "His gaze slowly met mine." |
| `[481]` | **""From now on, I'll be the one asking the questions.""** | `[484]` **Narrator**: "His gaze met mine." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[482]` | **""I believe the man I've come to know would do the righteous thing and confess to w..."** | `[484]` **Narrator**: "His gaze met mine." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[483]` | **""Do not toy with me, Sal. Your insolence will not protect you from the consequence..."** | `[484]` **Narrator**: "His gaze met mine." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>`[548]` **Narrator**: "The guards looked at me question..." |
| `[492]` | **""I hope that with time I'll find the strength to forgive you.""** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Sal Ignacius**: ""As do I, Your Majesty."" |
| `[493]` | **""Like God, I too am forgiving. Now go. Reclaim the righteous path so that you too ..."** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[509]` **Sal Ignacius**: ""Thank you, Your Majesty. I will..." |
| `[494]` | **""Unlike your God, I'm not so easily forgiving.""** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[505]` **Sal Ignacius**: ""I understand. But I hope that w..." |
| `[498]` | **""Unlike God, I'm not so easily forgiving.""** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[508]` **Sal Ignacius**: ""I understand. However, I hope t..." |
| `[499]` | **""Like your God, I too am forgiving. Now go. Reclaim the righteous path so that you..."** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[509]` **Sal Ignacius**: ""Thank you, Your Majesty. I will..." |
| `[503]` | **""I may have allowed you to walk free, but forgiveness is something I'll never grant.""** | `[491]` **Sal Ignacius**: ""For what it's worth, I am deepl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Sal Ignacius**: ""Well, I hope with time you will."" |
| `[546]` | **""So old Sal took a consciousness-expanding trip every now and again. Who doesn't? ..."** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true` | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""That's not all. There is someth..."<br>`[73]` **Titus Gordion**: ""That's not all. There's somethi..." |
| `[547]` | **""The fact that such a close advisor was hiding this substance is very worrying ind..."** | `[489]` **Titus Gordion**: ""It was here where we found the ..."<br>`[490]` **Lucita Azaro**: ""It was here where we discovered..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true`<br>`(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | *Brak zmian stanu* | `[72]` **Lucita Azaro**: ""That's not all. There is someth..."<br>`[73]` **Titus Gordion**: ""That's not all. There's somethi..." |
| `[556]` | **""What happened on the night of November 18, 1949? I want to know every detail.""** | `[548]` **Narrator**: "The guards looked at me question..."<br>`[549]` **Narrator**: "He bowed his head, awaiting my n..."<br>*(oraz 17 innych węzłów)* | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false`<br>`Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true` | `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExact...` | `[557]` **Narrator**: "Sal trembled. His eyes darted to..." |
| `[563]` | **""And you just left him like that? You complete and utter coward.""** | `[562]` **Sal Ignacius**: ""He began slipping in and out of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Sal Ignacius**: ""I know. I have rendered my garm..." |
| `[564]` | **""Why didn't you alert the guards?""** | `[562]` **Sal Ignacius**: ""He began slipping in and out of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[566]` **Sal Ignacius**: ""His Majesty had made me swear t..." |
| `[565]` | **""He summoned you. He brought this on himself.""** | `[562]` **Sal Ignacius**: ""He began slipping in and out of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[568]` **Sal Ignacius**: ""I convinced him to do it. He wa..." |
| `[577]` | **""Your 'visions' are nothing but hallucinations. They don't mean a damn thing.""** | `[209]` **Sal Ignacius**: ""Unfortunately, that did not tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Sal Ignacius**: ""Think of what I foretold at Pla..."<br>`[210]` **Lucita Azaro**: ""You are insane, Grand Wiseman. ..."<br>*(oraz 1 innych odgałęzień)* |
| `[582]` | **""He always was anxious about the future. I can see why he wanted to take this risk.""** | `[209]` **Sal Ignacius**: ""Unfortunately, that did not tra..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[210]` **Lucita Azaro**: ""You are insane, Grand Wiseman. ..."<br>`[211]` **Titus Gordion**: ""I cannot believe a psychoactive..."<br>*(oraz 5 innych odgałęzień)* |
| `[583]` | **""Sounds like some real strong stuff. Mind if I have a swig?""** | `[209]` **Sal Ignacius**: ""Unfortunately, that did not tra..." | `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]` | *Brak zmian stanu* | `[587]` **Sal Ignacius**: ""Your Majesty, performing this s..." |
| `[588]` | **""I wouldn't mind receiving that gift myself.""** | `[209]` **Sal Ignacius**: ""Unfortunately, that did not tra..." | `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false` | *Brak zmian stanu* | `[587]` **Sal Ignacius**: ""Your Majesty, performing this s..." |
| `[594]` | **""He was still alive when you left. Someone else could have gotten to him afterward.""** | `[562]` **Sal Ignacius**: ""He began slipping in and out of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Sal Ignacius**: ""I wish I could believe that, Yo..." |
| `[613]` | **""He's indebted to me for sparing him. I can use that to my advantage.""** | `[611]` **Lucita Azaro**: ""This doesn't sit right with me."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[711]` **Lucita Azaro**: ""Good thinking, Your Majesty. It..."<br>`[712]` **Titus Gordion**: ""The Sanctuary's cooperation can..." |
| `[614]` | **""I'm not convinced he's actually our culprit. We need to continue this investigati..."** | `[611]` **Lucita Azaro**: ""This doesn't sit right with me.""<br>`[612]` **Titus Gordion**: ""I trust your judgement, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Lucita Azaro**: ""Really? The case for the Grand ..."<br>`[624]` **Titus Gordion**: ""Are you certain? It seems like ..." |
| `[618]` | **""I believe him. My father was not the king who was prophesied. Myself, on the othe..."** | `[611]` **Lucita Azaro**: ""This doesn't sit right with me.""<br>`[612]` **Titus Gordion**: ""I trust your judgement, Your Ma..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[697]` **Narrator**: "Lucita struggled to hold in her ..."<br>`[698]` **Narrator**: "Titus nodded seriously." |
| `[619]` | **""I believe that he killed my father by complete accident. And he seems remorseful ..."** | `[611]` **Lucita Azaro**: ""This doesn't sit right with me.""<br>`[612]` **Titus Gordion**: ""I trust your judgement, Your Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[707]` **Lucita Azaro**: ""I wouldn't be so sure. But he w..."<br>`[706]` **Titus Gordion**: ""He's an old man. He's suffered ..." |
| `[625]` | **""There's still the mystery of why Duchess Azaro snuck into my father's room.""** | `[624]` **Titus Gordion**: ""Are you certain? It seems like ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[634]` **Titus Gordion**: ""I confess I've been wondering a..." |
| `[626]` | **""Hugo and my father were arguing that night. It can't be a coincidence that he die..."** | `[623]` **Lucita Azaro**: ""Really? The case for the Grand ..."<br>`[624]` **Titus Gordion**: ""Are you certain? It seems like ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[638]` **Lucita Azaro**: ""Perhaps not.""<br>`[639]` **Titus Gordion**: ""I would hate to think the Grand..." |
| `[630]` | **""There's still the matter of Titus' unexplained absence.""** | `[623]` **Lucita Azaro**: ""Really? The case for the Grand ..." | `Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false` | *Brak zmian stanu* | `[633]` **Lucita Azaro**: ""Yes, I'm still wondering about ..." |
| `[631]` | **""Titus explained why he had to leave his post, but I'm not sure I believe him.""** | `[623]` **Lucita Azaro**: ""Really? The case for the Grand ..." | `(Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false) == false` | *Brak zmian stanu* | `[633]` **Lucita Azaro**: ""Yes, I'm still wondering about ..." |
| `[632]` | **""You're right. It's too risky to continue investigating people in my inner circle ..."** | `[623]` **Lucita Azaro**: ""Really? The case for the Grand ..."<br>`[624]` **Titus Gordion**: ""Are you certain? It seems like ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[702]` **Lucita Azaro**: ""We've got our hands full with t..."<br>`[716]` **Titus Gordion**: ""Everyone has something to hide,..." |
| `[650]` | **""Spare no expense. I want all your investigatory focus on the Grand Vizier." [-1 B..."** | `[648]` **Titus Gordion**: ""However, the Golden Guard can't..."<br>`[649]` **Lucita Azaro**: ""With that said, my team can't c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[656]` **Lucita Azaro**: ""Your wish is our command.""<br>`[657]` **Titus Gordion**: ""As you wish, sir."" |
| `[651]` | **""So be it. You have my blessing and my funding to investigate Titus Gordion as the..."** | `[649]` **Lucita Azaro**: ""With that said, my team can't c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[659]` **Lucita Azaro**: ""We'll get on it straight away."" |
| `[652]` | **""So be it. You have my blessing and my funding to investigate Lucita Azaro as the ..."** | `[648]` **Titus Gordion**: ""However, the Golden Guard can't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[681]` **Titus Gordion**: ""With great pleasure, Your Majes..." |
| `[658]` | **""Never mind, then. I'm not going to throw any more money at this.""** | `[648]` **Titus Gordion**: ""However, the Golden Guard can't..."<br>`[649]` **Lucita Azaro**: ""With that said, my team can't c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[686]` **Lucita Azaro**: ""Understandable. I'm sorry we co..."<br>`[687]` **Titus Gordion**: ""I understand. Please excuse our..." |
| `[667]` | **""Why is it always about the money with you?! If anything, your people should be pa..."** | `[646]` **Lucita Azaro**: ""With that said, my team can't c..."<br>`[647]` **Titus Gordion**: ""However, the Golden Guard can't..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[672]` **Narrator**: "Lucita backed away."<br>`[673]` **Narrator**: "Titus backed away." |
| `[668]` | **""What a pity. I was really hoping to get to the bottom of my father's death.""** | `[647]` **Titus Gordion**: ""However, the Golden Guard can't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[691]` **Lucita Azaro**: ""If you ask me, we did.""<br>`[692]` **Titus Gordion**: ""I have the feeling we already d..." |
| `[693]` | **""I wouldn't throw any more money down this rabbit hole even if I could.""** | `[647]` **Titus Gordion**: ""However, the Golden Guard can't..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[686]` **Lucita Azaro**: ""Understandable. I'm sorry we co..."<br>`[687]` **Titus Gordion**: ""I understand. Please excuse our..." |
| `[751]` | **""Yes. Are you disappointed?""** | `[750]` **Titus Gordion**: ""I suppose this means the end of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[755]` **Narrator**: "He shook his head." |
| `[752]` | **""Sal was manipulating me this entire time. Just as he manipulated my father.""** | `[750]` **Titus Gordion**: ""I suppose this means the end of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[757]` **Titus Gordion**: ""And myself, Your Majesty. He de..." |
| `[753]` | **""Maybe I shouldn't be so hasty to disband my trusted holy army. Let's hear what th..."** | `[750]` **Titus Gordion**: ""I suppose this means the end of..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResul...` | `[150]` **Lucita Azaro**: ""I'll fetch him at once, Your Ma..."<br>`[151]` **Titus Gordion**: ""I'll bring him at once, Your Ma..." |
| `[763]` | **""The Grand Wiseman has been accused of murdering my father. King Valero.""** | `[762]` **Sevrio Castellanus**: ""Your Majesty... What is the mea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[773]` **Sevrio Castellanus**: ""What?! Surely there's been a mi..." |
| `[764]` | **""Don't act like you don't know. You were in on this scheme the whole time, weren't..."** | `[762]` **Sevrio Castellanus**: ""Your Majesty... What is the mea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[772]` **Sevrio Castellanus**: ""Scheme? I still don't understan..." |
| `[765]` | **""Nothing you need to be worried about, Sevrio. You may leave.""** | `[762]` **Sevrio Castellanus**: ""Your Majesty... What is the mea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[774]` **Sevrio Castellanus**: ""Please, Your Majesty. I swore t..." |
| `[766]` | **""A mere misunderstanding. The Grand Wiseman has been accused of something he did n..."** | `[762]` **Sevrio Castellanus**: ""Your Majesty... What is the mea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[770]` **Lucita Azaro**: ""What? We have concrete evidence..."<br>`[771]` **Titus Gordion**: ""Your Majesty, Sevrio... I wish ..." |
| `[788]` | **""The Grand Wiseman played us all for fools. He shall be placed under immediate arr..."** | `[787]` **Narrator**: "Sal quietly shook his head." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Sal_Arrested"] = true; Variable["Rizia...` | `[260]` **Lucita Azaro**: ""As you wish, Your Majesty.""<br>`[261]` **Titus Gordion**: ""As you wish, sir."" |
| `[789]` | **""Yes, Sal administered the drug that ended my father's life. But he did so out of ..."** | `[787]` **Narrator**: "Sal quietly shook his head." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[790]` **Narrator**: "The others gasped." |
| `[791]` | **""My father was weak, Captain Castellanus. He had to die so that Rizia could be reb..."** | `[787]` **Narrator**: "Sal quietly shook his head." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[790]` **Narrator**: "The others gasped." |
| `[807]` | **""You still have the Wruhecist community's respect. I need you to make sure they we..."** | `[805]` **Sevrio Castellanus**: ""It has been an honor serving yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[813]` **Sevrio Castellanus**: ""I will talk to them. But I cann..." |
| `[808]` | **""Thank you, Sevrio. You're dismissed.""** | `[805]` **Sevrio Castellanus**: ""It has been an honor serving yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[812]` **Sevrio Castellanus**: ""Divus zaitu."" |
| `[809]` | **""Go with God.""** | `[805]` **Sevrio Castellanus**: ""It has been an honor serving yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[812]` **Sevrio Castellanus**: ""Divus zaitu."" |
| `[810]` | **""With Sal gone, Rizia is in the market for a new Grand Wiseman.""** | `[805]` **Sevrio Castellanus**: ""It has been an honor serving yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Sevrio Castellanus**: ""I-- I could never. Not after th..." |
| `[817]` | **""Nothing less than his duty. My father had to die so that Rizia could be reborn. T..."** | `[816]` **Sevrio Castellanus**: ""His guilt? What did he do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[790]` **Narrator**: "The others gasped." |
| `[818]` | **""As I said, this is all a misunderstanding. The Grand Wiseman is to be released im..."** | `[816]` **Sevrio Castellanus**: ""His guilt? What did he do?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigation...` | `[269]` **Lucita Azaro**: ""I must admit, this is rather un..."<br>`[270]` **Titus Gordion**: ""I must say, this is not the dir..." |
| `[819]` | **""My father asked him to assist in the conduction of a sacred ritual. The fact that..."** | `[816]` **Sevrio Castellanus**: ""His guilt? What did he do?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[820]` **Narrator**: "Sevrio's jaw dropped." |

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
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Learning the truth behind their father’s..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so urgent that it keeps me from enjoying my lunch in peace and quiet?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro), `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Letting out a sigh, I threw down my fork and speared the roast chicken with my knife before turning to find out what the hell she wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Lucita hurried into the room and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "LucitaEnter_Hub"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Titus hurried into the room and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "TitusEnter_Hub"*)

### Węzeł `[10]`
Mówca: **Lucita Azaro**
> ""I'm sorry to disrupt you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[6]` (*Player_Romus: ""What's so urgent that it keeps me from enjoying my lunch..."*)
  - -> `[12]` (*Player_Romus: ""Speak.""*)
  - -> `[13]` (*Player_Romus: ""No worries at all. What can I do for you?""*)

### Węzeł `[11]`
Mówca: **Titus Gordion**
> ""I'm sorry to disrupt you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Player_Romus: ""What's so urgent that it keeps me from enjoying my lunch..."*)
  - -> `[12]` (*Player_Romus: ""Speak.""*)
  - -> `[13]` (*Player_Romus: ""No worries at all. What can I do for you?""*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speak.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro), `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No worries at all. What can I do for you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro), `[11]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[14]`
Mówca: **Lucita Azaro**
> ""Even the palace walls have ears, Your Majesty. If you wouldn't mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""Mr. Adria is a trusted confidante, not a wall. He will s..."*)
  - -> `[305]` (*Player_Romus: ""Thank you, Pabel. You may leave.""*)
  - -> `[21]` (*Player_Romus: ""Out. Now.""*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "She gestured at Pabel."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Narrator: "He gestured at Pabel."*)

### Węzeł `[18]`
Mówca: **Titus Gordion**
> ""Even the palace walls have ears, sir. If you wouldn't mind...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""Mr. Adria is a trusted confidante, not a wall. He will s..."*)
  - -> `[305]` (*Player_Romus: ""Thank you, Pabel. You may leave.""*)
  - -> `[21]` (*Player_Romus: ""Out. Now.""*)

### Węzeł `[19]`
Mówca: **Lucita Azaro**
> ""I've finished my investigation into Grand Wiseman Ignacius.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Lucita Azaro: ""It turns out your suspicions were correct. I now have so..."*)

### Węzeł `[20]`
Mówca: **Lucita Azaro**
> ""It turns out your suspicions were correct. I now have solid evidence that he was involved in your late father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""I have a hard time believing that.""*)
  - -> `[298]` (*Player_Romus: ""Sal! I knew it was him!""*)
  - -> `[299]` (*Player_Romus: ""Please go on.""*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing"*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Out. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucita Azaro), `[18]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucita Azaro: ""I've finished my investigation into Grand Wiseman Ignaci..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Titus Gordion: ""My investigation into the Grand Wiseman has concluded.""*)

### Węzeł `[25]`
Mówca: **Titus Gordion**
> ""My investigation into the Grand Wiseman has concluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Titus Gordion: ""As it turns out, your suspicions about him were correct...."*)

### Węzeł `[26]`
Mówca: **Titus Gordion**
> ""As it turns out, your suspicions about him were correct. I now have solid evidence that he was involved in your late father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""I have a hard time believing that.""*)
  - -> `[298]` (*Player_Romus: ""Sal! I knew it was him!""*)
  - -> `[299]` (*Player_Romus: ""Please go on.""*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Sal Investigation Results Questions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation =..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure ..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == f..."*)
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation =..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where was the bottle found?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false` AND `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation =..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation =..."*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player_Romus: ""Where was the bottle found?""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandragora. So Pabel was right...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false` AND `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure ..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure ..."*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSur..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""Mandragora. So Pabel was right...""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who is the boy that told you about this?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false` AND `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity = true"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == f..."*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity ==..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""Who is the boy that told you about this?""*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced. Is the bottle the only evidence you have?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucita Azaro: ""The boy took us to a secret chamber within the capital's..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Titus Gordion: ""The boy took us to a secret chamber within the capital's..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Titus Gordion: ""Your butler told you about this substance? His insight s..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[53]`
Mówca: **Lucita Azaro**
> ""The boy took us to a secret chamber within the capital's Archsanctuary which Sal apparently used as a study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Lucita Azaro: ""It was here where we discovered the bottle, tucked away ..."*)

### Węzeł `[54]`
Mówca: **Titus Gordion**
> ""The boy took us to a secret chamber within the capital's Archsanctuary, which Sal seemingly utilized as a study.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Titus Gordion: ""It was here where we found the bottle, tucked away in a ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Investigation Results Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Results Questions"*)

### Węzeł `[56]`
Mówca: **Lucita Azaro**
> ""Your butler told you this? It's no wonder you're so fond of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[57]`
Mówca: **Titus Gordion**
> ""Your butler told you about this substance? His insight should be rewarded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Investigation Results Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Results Questions"*)

### Węzeł `[59]`
Mówca: **Lucita Azaro**
> ""Alfreth Tilda. An orphan taken in years ago. He was pursuing the path of a seminarian -- training to become a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: "“Initially hesitant to divulge what he knew, he eventuall..."*)

### Węzeł `[60]`
Mówca: **Titus Gordion**
> "“Alfreth Tilda. An orphan who was taken in years ago. He was training to become a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Titus Gordion: "“Initially hesitant to divulge what he knew, the kid even..."*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> "“Initially hesitant to divulge what he knew, he eventually opened up when we stressed that we were investigating a potential homicide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lucita Azaro: ""He knew nothing about this substance or how it was used.""*)

### Węzeł `[62]`
Mówca: **Lucita Azaro**
> ""He knew nothing about this substance or how it was used.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Lucita Azaro: "“Considering his age, he exhibited remarkable courage, de..."*)

### Węzeł `[63]`
Mówca: **Titus Gordion**
> "“Initially hesitant to divulge what he knew, the kid eventually opened up when we stressed that we were investigating a potential homicide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Titus Gordion: ""He was unaware of what this substance was or how it was ..."*)

### Węzeł `[64]`
Mówca: **Titus Gordion**
> ""He was unaware of what this substance was or how it was used.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Titus Gordion: "“Considering his age, he exhibited remarkable courage, de..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation =..."*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[547]` (*Player_Romus: ""The fact that such a close advisor was hiding this subst..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation == true || RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity == true || RiziaDLCIsolated.SalInvestigation_Poison_BoyName == true || RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""That's quite the revelation. Please go on.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite the revelation. Please go on.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true) == false` AND `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucita Azaro: ""That's not all. There is something else.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Titus Gordion: ""That's not all. There's something else you should see.""*)

### Węzeł `[72]`
Mówca: **Lucita Azaro**
> ""That's not all. There is something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "She presented what appeared to be an old journal."*)

### Węzeł `[73]`
Mówca: **Titus Gordion**
> ""That's not all. There's something else you should see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "He presented what appeared to be an old journal."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "She presented what appeared to be an old journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus_Italic: "Take it and read it."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "He presented what appeared to be an old journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus_Italic: "Take it and read it."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "Take it and read it."]** — Mówca: **Player_Romus_Italic**
> "I took it and began reading its contents."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator), `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "There were dates and short descriptions underneath."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "There were dates and short descriptions underneath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Paper"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Sal Investigation Paper`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_1 == false"*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_2 == false"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_3 == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_4 == false"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_1 == true && Rizi..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "Read the first entry."]** — Mówca: **Player_Romus_Italic**
> "I read the first entry."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[99]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_1 = true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_1 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_1 == false"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Paper_1 == false)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_1 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus_Italic: "Read the first entry."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Paper_1 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: ""October 16th, late afternoon.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "Read the second entry."]** — Mówca: **Player_Romus_Italic**
> "I read the second entry."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[99]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_2 = true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_2 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_2 == false"*)
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Paper_2 == false)"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_2 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player_Romus_Italic: "Read the second entry."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Paper_2 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: ""October 24th, sunset.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "Read the third entry."]** — Mówca: **Player_Romus_Italic**
> "Read the third entry."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[99]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_3 = true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_3 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_3 == false"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Paper_3 == false)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_3 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus_Italic: "Read the third entry."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Paper_3 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: ""November 1st, close to midnight.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> ""Valero agreed to go through the trials that I proposed. I fear what may come, yet I remain steadfast in the knowledge that the prophesied king will eventually return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: ""While he exhibits signs of joy and laughter, it appears ..."*)

### Węzeł `[95]`
Mówca: **Narrator**
> ""October 24th, sunset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: ""It's hard to believe the king has entrusted me with this..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> ""October 16th, late afternoon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: ""Valero agreed to go through the trials that I proposed. ..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> ""November 1st, close to midnight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: ""The King is having convulsions. The dosage might be too ..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> ""It's hard to believe the king has entrusted me with this sacred task. Sometimes I think that I take his faith in me for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: ""We will see if he is the one. I pray that it is true. I ..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> ""We will see if he is the one. I pray that it is true. I must up the dosage further. We are getting closer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Paper]"*)

### Węzeł `[100]`
Mówca: **Narrator**
> ""While he exhibits signs of joy and laughter, it appears that the dosage is insufficient. I will augment it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Paper]"*)

### Węzeł `[101]`
Mówca: **Narrator**
> ""The King is having convulsions. The dosage might be too high. But we are so close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: ""Everything depends on this now. I will administer the fi..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "Read the fourth entry."]** — Mówca: **Player_Romus_Italic**
> "Read the fourth entry."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false`
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator), `[99]` (Narrator), `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_4 = true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_4 = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: ""November 18th, late evening.""*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_4 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_4 == false"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Paper_4 == false)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_4 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player_Romus_Italic: "Read the fourth entry."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Paper_4 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[107]`
Mówca: **Narrator**
> ""November 18th, late evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: ""Not long after administering the final dose, I knew some..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> ""The king whispered my name before I left his chambers. It still echoes in my head. 'Sal, Sal... look after Romus.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: ""Valero was not the chosen one. I have failed. Perhaps hi..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> ""Not long after administering the final dose, I knew something was wrong -- a darkness began consuming him as if he had been cursed!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: ""The king whispered my name before I left his chambers. I..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> ""Everything depends on this now. I will administer the final dose on the 18th. Oh God, I pray to you for a successful outcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Paper]"*)

### Węzeł `[111]`
Mówca: **Narrator**
> ""Valero was not the chosen one. I have failed. Perhaps his son. Time will tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Paper]"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Paper_1 == true && Rizi..."*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Paper_1 == true && Ri..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Paper_1 == true && RiziaDLCIsolated.SalInvestigation_Paper_2 == true && RiziaDLCIsolated.SalInvestigation_Paper_3 == true && RiziaDLCIsolated.SalInvestigation_Paper_4 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Paper_1"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_2"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_3"] == true  and  Variable["RiziaDLCIsolated.SalInvestigation_Paper_4"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Investigation Paper]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Paper"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucita Azaro: ""Your orders?""*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Titus Gordion: ""Your orders, sir?""*)

### Węzeł `[119]`
Mówca: **Lucita Azaro**
> ""Your orders?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""What do you think I should do?""*)
  - -> `[124]` (*Player_Romus: ""Bring him to me. I will talk to him first.""*)
  - -> `[123]` (*Player_Romus: ""Arrest the Grand Wiseman immediately and throw him in pr..."*)
  - -> `[122]` (*Player_Romus: ""What he has or hasn't allegedly done is irrelevant. You'..."*)

### Węzeł `[120]`
Mówca: **Titus Gordion**
> ""Your orders, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""What do you think I should do?""*)
  - -> `[124]` (*Player_Romus: ""Bring him to me. I will talk to him first.""*)
  - -> `[123]` (*Player_Romus: ""Arrest the Grand Wiseman immediately and throw him in pr..."*)
  - -> `[122]` (*Player_Romus: ""What he has or hasn't allegedly done is irrelevant. You'..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think I should do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[120]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What he has or hasn't allegedly done is irrelevant. You're not to mention a word of this to anyone. Sal walks free.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[120]` (Titus Gordion), `[128]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Le..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest the Grand Wiseman immediately and throw him in prison to rot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[120]` (Titus Gordion), `[128]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bring him to me. I will talk to him first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Lucita Azaro), `[120]` (Titus Gordion), `[128]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucita Azaro: ""If it were up to me, I'd say he should be arrested for t..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Titus Gordion: ""I find it hard to believe the Grand Wiseman could be gui..."*)

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""If it were up to me, I'd say he should be arrested for treason against the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Bring him to me. I will talk to him first.""*)
  - -> `[123]` (*Player_Romus: ""Arrest the Grand Wiseman immediately and throw him in pr..."*)
  - -> `[122]` (*Player_Romus: ""What he has or hasn't allegedly done is irrelevant. You'..."*)

### Węzeł `[129]`
Mówca: **Titus Gordion**
> ""I find it hard to believe the Grand Wiseman could be guilty of such treason. But the evidence speaks for itself...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Bring him to me. I will talk to him first.""*)
  - -> `[123]` (*Player_Romus: ""Arrest the Grand Wiseman immediately and throw him in pr..."*)
  - -> `[122]` (*Player_Romus: ""What he has or hasn't allegedly done is irrelevant. You'..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Lucita Azaro: ""This is... unexpected, but I shall abide by your command..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Titus Gordion: ""This is... not the direction I'd expected you to take.""*)

### Węzeł `[133]`
Mówca: **Lucita Azaro**
> ""This is... unexpected, but I shall abide by your command, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "She bowed and left the room."*)

### Węzeł `[134]`
Mówca: **Titus Gordion**
> ""This is... not the direction I'd expected you to take.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucita Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Titus Gordion: ""As you wish, sir.""*)

### Węzeł `[138]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Tur..."*)

### Węzeł `[139]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Sal Questioning`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[141]`
Mówca: **Narrator**
> "She bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "He bowed and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Alone in the room where my father passed, I wondered if arresting Sal was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Did I act justly, or was I swayed by personal feelings?"*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Did I act justly, or was I swayed by personal feelings?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true ||..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "And if Sal didn't kill my father... who did?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Lucita Azaro: ""I'll fetch him at once, Your Majesty.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Titus Gordion: ""I'll bring him at once, Your Majesty.""*)

### Węzeł `[150]`
Mówca: **Lucita Azaro**
> ""I'll fetch him at once, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[151]`
Mówca: **Titus Gordion**
> ""I'll bring him at once, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questioning]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Sal Questioning"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Several hours later, Lucita and a few guards arrived, as did my esteemed guest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Narrator: "I had him brought to the King's quarters. The very place ..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Several hours later, Titus and a few guards arrived, as did my esteemed guest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Narrator: "I had him brought to the King's quarters. The very place ..."*)

### Węzeł `[158]`
Mówca: **Lucita Azaro**
> ""Here you are, Your Majesty. We brought him to you as ordered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[159]`
Mówca: **Titus Gordion**
> ""Here you are, Your Majesty, as instructed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[160]`
Mówca: **Narrator**
> "The guards held Sal firmly by both arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""Everyone except Sal. Out. I wish to speak to him in priv..."*)
  - -> `[162]` (*Player_Romus: ""Keep him close in case he tries anything.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone except Sal. Out. I wish to speak to him in private.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone = true"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep him close in case he tries anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "The guards held his arms tighter."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "It took a few tries to convince everyone to leave. Eventually, though, Sal and I were alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "On seeing the journal in my hands, Sal's eyes filled with..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "The guards held his arms tighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "On seeing the journal in my hands, Sal's eyes filled with..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Sal Questions Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false"*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false"*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[166]`
Mówca: **Narrator**
> "On seeing the journal in my hands, Sal's eyes filled with fear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Player_Romus: "“I assume you know why you’re here.”"*)
  - -> `[454]` (*Player_Romus: "“You’re unusually quiet. Something on your mind?”"*)
  - -> `[455]` (*Player_Romus: "“You've been keeping secrets from me, Grand Wiseman.""*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why did you give my father that poison?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt = true"*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why should I spare you?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhySpare = true"*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me more about this prophecy you were trying to fulfill.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne = true"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false"*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false)"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""Why did you give my father that poison?""*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player_Romus: ""Why should I spare you?""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhySpare = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""Tell me more about this prophecy you were trying to fulf..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Sal Ignacius: ""This has been passed down for centuries, Your Majesty, a..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Do you feel remorse for what you've done?”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_Sorry = true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: "“Do you feel remorse for what you've done?”"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_Sorry == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_Sorry = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Sal Ignacius: ""I do. Every day, I offer prayers to God for forgiveness.""*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "It took a few tries to convince everyone to leave. Eventu..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || ..."*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true |..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""I'm finished with this interrogation. Everyone, please r..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm finished with this interrogation. Everyone, please return.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lucita Azaro: ""You are insane, Grand Wiseman. Pure and simple.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Titus Gordion: ""I cannot believe a psychoactive substance would play suc..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || ..."*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true |..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Player_Romus: ""I'm finished with this interrogation. Here is my verdict.""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt == true || RiziaDLCIsolated.SalInvestigation_Sal_WhySpare == true || RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne == true || RiziaDLCIsolated.SalInvestigation_Sal_Sorry == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Here is my verdict.""*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm finished with this interrogation. Here is my verdict.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true` AND `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here is my verdict.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhyDoIt"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhySpare"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_ChosenOne"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Sal_Sorry"] == true) == false` AND `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Titus and his men came back into the room, eager to hear my verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[207]`
Mówca: **Sal Ignacius**
> ""It is not poison, Your Majesty. As you have already witnessed, it is a tool to prepare one's mind to receive the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Sal Ignacius: ""When a Grand Wiseman such as myself partakes of it, such..."*)

### Węzeł `[208]`
Mówca: **Sal Ignacius**
> ""When a Grand Wiseman such as myself partakes of it, such visions come in flashes, their meaning shrouded in mystery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Sal Ignacius: ""Yet it is said that when the king who was prophesied dri..."*)

### Węzeł `[209]`
Mówca: **Sal Ignacius**
> ""Unfortunately, that did not transpire with His Majesty Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Player_Romus: ""Your 'visions' are nothing but hallucinations. They don'..."*)
  - -> `[582]` (*Player_Romus: ""He always was anxious about the future. I can see why he..."*)
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)

### Węzeł `[210]`
Mówca: **Lucita Azaro**
> ""You are insane, Grand Wiseman. Pure and simple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[211]`
Mówca: **Titus Gordion**
> ""I cannot believe a psychoactive substance would play such a significant role in our religion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questions Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[213]`
Mówca: **Sal Ignacius**
> ""Because there is still hope, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Sal Ignacius: ""Your father may not have been the one, but as it is fore..."*)

### Węzeł `[214]`
Mówca: **Sal Ignacius**
> ""Your father may not have been the one, but as it is foretold, it may very well be you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""The prophecy is real. All the events are falling into pl..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lucita Azaro: ""Did God tell you to murder the monarch of Rizia, kingsla..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Titus Gordion: ""What kind of God commands a man to slay his king?""*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Sal Ignacius: ""Because there is still hope, Romus.""*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Sal Ignacius: ""Do what you must, Your Majesty.""*)

### Węzeł `[221]`
Mówca: **Sal Ignacius**
> ""Do what you must, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Sal Ignacius: ""I am a humble servant of God and he alone knows my path.""*)

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""I am a humble servant of God and he alone knows my path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[223]`
Mówca: **Sal Ignacius**
> ""The prophecy is real. All the events are falling into place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[224]`
Mówca: **Lucita Azaro**
> ""Did God tell you to murder the monarch of Rizia, kingslayer?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[225]`
Mówca: **Titus Gordion**
> ""What kind of God commands a man to slay his king?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questions Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[227]`
Mówca: **Sal Ignacius**
> ""'Beneath the watchful gaze of the ancients, upon the hallowed altar, the king will partake of the sacred draught, its composition known only to the cloistered few.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Sal Ignacius: ""'As the elixir courses through his veins, the world arou..."*)

### Węzeł `[228]`
Mówca: **Sal Ignacius**
> ""'As the elixir courses through his veins, the world around him shall dissolve.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Sal Ignacius: ""'In this expanse, the whispers of the ancients will fore..."*)

### Węzeł `[229]`
Mówca: **Sal Ignacius**
> ""'In this expanse, the whispers of the ancients will foretell the trials and triumphs of his reign.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Sal Ignacius: ""'Amidst this ethereal void, a silhouette will emerge, a ..."*)

### Węzeł `[230]`
Mówca: **Sal Ignacius**
> ""'Amidst this ethereal void, a silhouette will emerge, a boy, born of his lineage, reaching for a crown that dances like a flame...'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Sal Ignacius: ""'Its form blurring the lines between now and what is yet..."*)

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""This has been passed down for centuries, Your Majesty, and I shall recite it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Sal Ignacius: ""'Beneath the watchful gaze of the ancients, upon the hal..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Sal Ignacius: ""What happened with your father was a tragedy, but his de..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Lucita Azaro: ""Such bullshit.... How dare you call yourself a priest.""*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Titus Gordion: ""As a Wruhecist myself, this smells strongly to me of her..."*)

### Węzeł `[238]`
Mówca: **Lucita Azaro**
> ""Such bullshit.... How dare you call yourself a priest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[239]`
Mówca: **Titus Gordion**
> ""As a Wruhecist myself, this smells strongly to me of heresy. And you dare call yourself a priest...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questions Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[241]`
Mówca: **Sal Ignacius**
> ""Valero was kind... and a friend, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Sal Ignacius: ""One of the few I could call upon. He entrusted his life ..."*)

### Węzeł `[242]`
Mówca: **Sal Ignacius**
> ""One of the few I could call upon. He entrusted his life to me, and I failed him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Lucita Azaro: ""Yes, you did.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Titus Gordion: ""God will never forgive you.""*)

### Węzeł `[249]`
Mówca: **Lucita Azaro**
> ""Yes, you did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[250]`
Mówca: **Titus Gordion**
> ""God will never forgive you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questions Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[252]`
Mówca: **Sal Ignacius**
> ""What happened with your father was a tragedy, but his death doesn't have to be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Sal Ignacius: ""By picking up where he left off, we not only honor his m..."*)

### Węzeł `[253]`
Mówca: **Sal Ignacius**
> ""By keeping the faith, together we will unlock the secrets to Rizia’s glory and her salvation!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_MentionsProphecy = true"*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care what he has or hasn't done. You're not to mention a word of this to anyone. Sal walks free.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[204]` (Player_Romus), `[205]` (Player_Romus), `[206]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Le..."*)

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""I do. Every day, I offer prayers to God for forgiveness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Sal Ignacius: ""Valero was kind... and a friend, Your Majesty.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Arrest Grand Wiseman Sal Ignacius immediately. Let him rot in prison for the rest of his wretched life.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[204]` (Player_Romus), `[205]` (Player_Romus), `[206]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Tur..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lucita Azaro: ""As you wish, Your Majesty.""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Titus Gordion: ""As you wish, sir.""*)

### Węzeł `[260]`
Mówca: **Lucita Azaro**
> ""As you wish, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lucita Azaro: ""It shall be done.""*)

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Titus Gordion: ""Consider it done.""*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLCSupport.News_Turn08_RH_SalArrested = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.PoisonInvestigation_Continues = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_SalArrested"] = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[263]`
Mówca: **Lucita Azaro**
> ""It shall be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Narrator: "Lucita bowed before leaving."*)

### Węzeł `[264]`
Mówca: **Titus Gordion**
> ""Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "Titus bowed before leaving."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "The guards forcibly escorted Sal away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lucita Azaro: ""I must admit, this is rather unexpected. Nevertheless, I..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Titus Gordion: ""I must say, this is not the direction I'd expected you t..."*)

### Węzeł `[269]`
Mówca: **Lucita Azaro**
> ""I must admit, this is rather unexpected. Nevertheless, I will comply with your orders, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lucita Azaro: ""The Grand Wiseman shall be released.""*)

### Węzeł `[270]`
Mówca: **Titus Gordion**
> ""I must say, this is not the direction I'd expected you to take. But I understand wholeheartedly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Titus Gordion: ""The Grand Wiseman shall be released.""*)

### Węzeł `[271]`
Mówca: **Lucita Azaro**
> ""The Grand Wiseman shall be released.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Narrator: "Lucita gestured for Sal to leave. The wiscerer bowed low ..."*)

### Węzeł `[272]`
Mówca: **Titus Gordion**
> ""The Grand Wiseman shall be released.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Narrator: "Titus gestured for Sal to leave. The wiscerer bowed low b..."*)

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player_Romus: ""Go now and leave me be.""*)
  - -> `[308]` (*Player_Romus: ""I am not sparing you out of charity. You will help me wh..."*)
  - -> `[311]` (*Player_Romus_Italic: "Nod and gesture for him to leave."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Sal bowed and began to leave before turning back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Sal Ignacius: ""For what it's worth, I am deeply sorry.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_MentionsProphecy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Sal_MentionsProphecy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Lucita hurried into the room and bowed."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Titus hurried into the room and bowed."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questioning]"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questioning]"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Several hours later, Lucita and a few guards arrived, as ..."*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Several hours later, Titus and a few guards arrived, as d..."*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "The guards held Sal firmly by both arms."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "The guards forcibly escorted Sal away."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Sal Ignacius: ""Pass all the judgment you like, Romus the First, but you..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Sal Ignacius: ""Pass all the judgment you like, Romus the First, but you..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[289]`
Mówca: **Narrator**
> "As I dined in the palace's Hall of Nobility, adorned with paintings of Rizian royal figures, I was interrupted by Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "I dabbed my mouth and rose to welcome her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[294]`
Mówca: **Narrator**
> "She gestured at Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Lucita Azaro: ""Even the palace walls have ears, Your Majesty. If you wo..."*)

### Węzeł `[295]`
Mówca: **Narrator**
> "He gestured at Pabel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Titus Gordion: ""Even the palace walls have ears, sir. If you wouldn't mi..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "Pabel bowed respectfully before exiting the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[297]`
Mówca: **Narrator**
> "He flashed me a look of gratitude before bowing respectfully and leaving the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal! I knew it was him!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro), `[26]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro), `[26]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a hard time believing that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro), `[26]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lucita Azaro: ""I had many of his priests interrogated. Unfortunately, g..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Adria is a trusted confidante, not a wall. He will stay.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucita Azaro), `[18]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Pabel Adria: ""Thank you, Your Majesty, but it's quite all right. I'll ..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Pabel. You may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Lucita Azaro), `[18]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Pabel Adria: ""Right away, Your Majesty.""*)

### Węzeł `[306]`
Mówca: **Sal Ignacius**
> ""Pass all the judgment you like, Romus the First, but you can't evade the judgment of God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Sal Ignacius: ""For He is the ultimate arbiter who punishes those who st..."*)

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Mark my words.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not sparing you out of charity. You will help me when the time comes. Just as I helped you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Sal Ignacius: ""Of course.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go now and leave me be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Sal Ignacius: ""Of course.""*)

### Węzeł `[310]`
Mówca: **Sal Ignacius**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Sal Ignacius: ""The path chosen for us will prevail, Your Majesty. We al..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA: "Nod and gesture for him to leave."]** — Mówca: **Player_Romus_Italic**
> "I nodded and gestured for him to leave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Sal Ignacius: ""The path chosen for us will prevail, Your Majesty. We al..."*)

### Węzeł `[312]`
Mówca: **Sal Ignacius**
> ""The path chosen for us will prevail, Your Majesty. We all have a purpose in this world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Sal Ignacius: ""Yours has yet to unfold.""*)

### Węzeł `[313]`
Mówca: **Sal Ignacius**
> ""Yours has yet to unfold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Sal bowed and began to leave before turning back."*)

### Węzeł `[314]`
Mówca: **Narrator**
> "Lucita gestured for Sal to leave. The wiscerer bowed low before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""Thank you, Your Majesty.""*)

### Węzeł `[315]`
Mówca: **Narrator**
> "Titus gestured for Sal to leave. The wiscerer bowed low before me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""Thank you, Your Majesty.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "As I dined in the palace's Hall of Nobility, adorned with..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "AddConversant("Pabel Adria");"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_GridlockLight", "R_GridlockLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_GridlockLight","R_GridlockLight_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo = true;
RiziaDLC.SalExonerated = true;
RiziaDLC.PoisonInvestigation_Continues = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo"] = true;
Variable["RiziaDLC.SalExonerated"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo = true;
RiziaDLC.SalExonerated = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_LetHimGo"] = true;
Variable["RiziaDLC.SalExonerated"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Player_Romus: ""You can disrupt me any time, Lucita. Day or night.""*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can disrupt me any time, Lucita. Day or night.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Kontekst wejściowy (poprzednik):** `[10]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Lucita Azaro: ""Unfortunately, this disruption is a rather serious one.""*)

### Węzeł `[326]`
Mówca: **Lucita Azaro**
> ""Unfortunately, this disruption is a rather serious one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "She gestured at Pabel."*)

### Węzeł `[327]`
Mówca: **Pabel Adria**
> ""Pardon the interruption, Your Majesty. But Duchess Azaro is here seeking your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Pabel Adria: ""She insists it's a matter of great importance.""*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Pabel Adria: ""Pardon the interruption, Your Majesty. But Duchess Azaro..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Pabel Adria: ""Pardon the interruption, Your Majesty. But Captain Gordi..."*)

### Węzeł `[331]`
Mówca: **Pabel Adria**
> ""Pardon the interruption, Your Majesty. But Captain Gordion is here seeking your immediate attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Pabel Adria: ""He insists it's a matter of great importance.""*)

### Węzeł `[332]`
Mówca: **Pabel Adria**
> ""She insists it's a matter of great importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""I'm still eating. Ask her to come back later.""*)
  - -> `[355]` (*Player_Romus: ""Everything's a matter of great importance with her. But ..."*)
  - -> `[356]` (*Player_Romus: ""Send her in right away.""*)
  - -> `[357]` (*Player_Romus: ""Tell her I'm not here.""*)

### Węzeł `[333]`
Mówca: **Pabel Adria**
> ""He insists it's a matter of great importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Player_Romus: ""I'm still eating. Ask him to come back later.""*)
  - -> `[370]` (*Player_Romus: ""Everything's a matter of great importance with him. But ..."*)
  - -> `[371]` (*Player_Romus: ""Send him in right away.""*)
  - -> `[372]` (*Player_Romus: ""Tell him I'm not here.""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "I drained the last of my wine, then turned to find out wh..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Letting out a sigh, I threw down my fork and speared the ..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "After a final sip of wine, I rose to welcome her."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "I dabbed my mouth and rose to welcome her."*)

### Węzeł `[340]`
Mówca: **Narrator**
> "After a final sip of wine, I rose to welcome her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[341]`
Mówca: **Narrator**
> "I drained the last of my wine, then turned to find out what the hell she wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "I drained the last of my wine, then turned to find out wh..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Narrator: "Letting out a sigh, I threw down my fork and speared the ..."*)

### Węzeł `[348]`
Mówca: **Narrator**
> "Letting out a sigh, I threw down my fork and speared the roast chicken with my knife before turning to find out what the hell he wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[349]`
Mówca: **Narrator**
> "I dabbed my mouth and rose to welcome him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalVal..."*)
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalV..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "After a final sip of wine, I rose to welcome him."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == false || RiziaDLC.PersonalValues_FellOffWagon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == false  or  Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "I dabbed my mouth and rose to welcome him."*)

### Węzeł `[353]`
Mówca: **Narrator**
> "After a final sip of wine, I rose to welcome him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[354]`
Mówca: **Narrator**
> "I drained the last of my wine, then turned to find out what the hell he wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything's a matter of great importance with her. But very well. Send her in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Narrator: "He promptly turned to open the door, bringing Lucita inside."*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send her in right away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Narrator: "He quickly turned to open the door and ushered Lucita ins..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell her I'm not here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Pabel Adria: ""I'm afraid she knows you are.""*)

### Węzeł `[358]`
Mówca: **Pabel Adria**
> ""I'm afraid she knows you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""In that case, just send her in.""*)
  - -> `[360]` (*Player_Romus: ""Fine. Let's hear what she has to say.""*)
  - -> `[361]` (*Player_Romus: ""Inform her regardless.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that case, just send her in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "He swiftly pivoted to open the door and ushered Lucita in..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Let's hear what she has to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "He swiftly pivoted to open the door and ushered Lucita in..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Inform her regardless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "He promptly left to relay the message. However, Lucita pu..."*)

### Węzeł `[362]`
Mówca: **Narrator**
> "He promptly turned to open the door, bringing Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[363]`
Mówca: **Narrator**
> "He quickly turned to open the door and ushered Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[364]`
Mówca: **Narrator**
> "He swiftly pivoted to open the door and ushered Lucita inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still eating. Ask her to come back later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "He promptly left to relay the message. However, Lucita pu..."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Lucita pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[367]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Lucita pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "Jump to: [LucitaEnter_Hub]"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "Jump to: [LucitaEnter_Hub]"*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everything's a matter of great importance with him. But very well. Send him in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "He promptly turned to open the door, bringing Titus inside."*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Send him in right away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Narrator: "He quickly turned to open the door and ushered Titus inside."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell him I'm not here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Pabel Adria: ""I'm afraid he knows you are.""*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. Let's hear what he has to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "He swiftly pivoted to open the door and ushered Titus ins..."*)

### Węzeł `[374]`
Mówca: **Narrator**
> "He promptly turned to open the door, bringing Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[375]`
Mówca: **Narrator**
> "He quickly turned to open the door and ushered Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[376]`
Mówca: **Narrator**
> "He swiftly pivoted to open the door and ushered Titus inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[377]`
Mówca: **Pabel Adria**
> ""I'm afraid he knows you are.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player_Romus: ""In that case, just send him in.""*)
  - -> `[373]` (*Player_Romus: ""Fine. Let's hear what he has to say.""*)
  - -> `[379]` (*Player_Romus: ""Inform him regardless.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In that case, just send him in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Narrator: "He swiftly pivoted to open the door and ushered Titus ins..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Inform him regardless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "He promptly left to relay the message. However, Titus pus..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still eating. Ask him to come back later.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[333]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "He promptly left to relay the message. However, Titus pus..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Titus pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "Jump to: [TitusEnter_Hub]"*)

### Węzeł `[383]`
Mówca: **Narrator**
> "He promptly left to relay the message. However, Titus pushed past him and came inside anyway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LucitaEnter_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Lucita Azaro: ""I'm sorry to disrupt you, Your Majesty.""*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `TitusEnter_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Titus Gordion: ""I'm sorry to disrupt you, sir.""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [TitusEnter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "TitusEnter_Hub"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [TitusEnter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "TitusEnter_Hub"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "Jump to: [TitusEnter_Hub]"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LucitaEnter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "LucitaEnter_Hub"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [LucitaEnter_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "LucitaEnter_Hub"*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me guess... in the billiard room... with the candlestick...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"]`
- **Kontekst wejściowy (poprzednik):** `[20]` (Lucita Azaro), `[26]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing"*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing)"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Player_Romus: ""Let me guess... in the billiard room... with the candles..."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Lucita Azaro: ""I'm sorry, Your Majesty, but I don't have a clue what yo..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Titus Gordion: ""If only it were that easy... In any case...""*)

### Węzeł `[398]`
Mówca: **Lucita Azaro**
> ""I'm sorry, Your Majesty, but I don't have a clue what you're alluding to. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[399]`
Mówca: **Titus Gordion**
> ""If only it were that easy... In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[400]`
Mówca: **Narrator**
> "She pulled out an evidence bag that contained a small brown bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucita Azaro: ""Our toxicologists identified this as Mandragora. A deadl..."*)

### Węzeł `[401]`
Mówca: **Narrator**
> "He pulled out an evidence bag that contained a small brown bottle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Titus Gordion: ""Toxicologists identified this as Mandragora. It's a dead..."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "Hallucinations... I wondered whether this was somehow related to the holy wine Sal drank at my consecration ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_MandragoraExtract");"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_MandragoraExtract");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_MandragoraExtract");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Results Questions"*)

### Węzeł `[404]`
Mówca: **Narrator**
> "She handed me the bag with the bottle. It still had a little bit of liquid left in it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[405]`
Mówca: **Narrator**
> "He handed me bag with the bottle. It still had a little bit of liquid left in it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "Hallucinations... I wondered whether this was somehow rel..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_MandragoraExtract");"*)

### Węzeł `[409]`
Mówca: **Lucita Azaro**
> ""I had many of his priests interrogated. Unfortunately, getting through to them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""They remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[419]` (*Player_Romus: ""Hah! Bring them to me. I'll handle them personally.""*)
  - -> `[417]` (*Player_Romus: ""Can't say I'm surprised. Their loyalty is to their wisce..."*)
  - -> `[418]` (*Player_Romus: ""Interrogating priests? Are we staging a holy inquisition..."*)

### Węzeł `[411]`
Mówca: **Lucita Azaro**
> "“Just when it seemed we’d exhausted all of our leads, a surprise witness who worked for the clergy came forward -- a boy, actually -- and gave us the break we desperately needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Lucita Azaro: ""He led us to this, Your Majesty. It belongs to the Grand..."*)

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""He led us to this, Your Majesty. It belongs to the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "She pulled out an evidence bag that contained a small bro..."*)

### Węzeł `[413]`
Mówca: **Titus Gordion**
> ""I subjected many of his priests to interrogation. Unfortunately, eliciting any useful information from them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Titus Gordion: ""Every one of them remained tight-lipped.""*)

### Węzeł `[414]`
Mówca: **Titus Gordion**
> ""Every one of them remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Player_Romus: ""Hah! Bring them to me. I'll handle them personally.""*)
  - -> `[417]` (*Player_Romus: ""Can't say I'm surprised. Their loyalty is to their wisce..."*)
  - -> `[418]` (*Player_Romus: ""Interrogating priests? Are we staging a holy inquisition..."*)

### Węzeł `[415]`
Mówca: **Titus Gordion**
> "“Just when it seemed we’d exhausted all of our leads, a surprise witness who worked for the clergy came forward -- a boy, actually -- and gave us the break we needed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Titus Gordion: ""He led us to this, sir. It belongs to the Grand Wiseman.""*)

### Węzeł `[416]`
Mówca: **Titus Gordion**
> ""He led us to this, sir. It belongs to the Grand Wiseman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "He pulled out an evidence bag that contained a small brow..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say I'm surprised. Their loyalty is to their wiscerer, not their king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Lucita Azaro), `[414]` (Titus Gordion), `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Interrogating priests? Are we staging a holy inquisition now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Lucita Azaro), `[414]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hah! Bring them to me. I'll handle them personally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Lucita Azaro), `[414]` (Titus Gordion), `[729]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you no respect for the sanctity of Wruhecism?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[729]` (Lucita Azaro), `[733]` (Titus Gordion), `[410]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Lucita Azaro: ""I did what had to be done. In any case...""*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Titus Gordion: ""Believe me, I took no pleasure in resorting to such meas..."*)

### Węzeł `[424]`
Mówca: **Lucita Azaro**
> ""I did what had to be done. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[425]`
Mówca: **Titus Gordion**
> ""Believe me, I took no pleasure in resorting to such measures. But it had to be done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Titus Gordion: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Lucita Azaro: ""Fortunately, that won't be necessary. You see...""*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Titus Gordion: ""Thankfully, that won't be needed. You see...""*)

### Węzeł `[429]`
Mówca: **Lucita Azaro**
> ""Fortunately, that won't be necessary. You see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[430]`
Mówca: **Titus Gordion**
> ""Thankfully, that won't be needed. You see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Titus Gordion: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Lucita Azaro: ""They'd sooner lose a limb than betray the Grand Wiseman...."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Titus Gordion: ""Yes, they'd sooner part with their limbs than betray the..."*)

### Węzeł `[434]`
Mówca: **Lucita Azaro**
> ""They'd sooner lose a limb than betray the Grand Wiseman. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[435]`
Mówca: **Titus Gordion**
> ""Yes, they'd sooner part with their limbs than betray the Grand Wiseman. Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Titus Gordion: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Lucita Azaro: ""I wouldn't go that far... But I assure you., it was a me..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Titus Gordion: ""I wouldn't go that far... But I assure you, it was out o..."*)

### Węzeł `[439]`
Mówca: **Lucita Azaro**
> ""I wouldn't go that far... But I assure you., it was a measure taken out of necessity. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Lucita Azaro: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[440]`
Mówca: **Titus Gordion**
> ""I wouldn't go that far... But I assure you, it was out of necessity. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Titus Gordion: "“Just when it seemed we’d exhausted all of our leads, a s..."*)

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""Our toxicologists identified this as Mandragora. A deadly nightshade historically used to induce hallucinations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Lucita Azaro: ""The slightest overdose can result in death.""*)

### Węzeł `[442]`
Mówca: **Titus Gordion**
> ""Toxicologists identified this as Mandragora. It's a deadly nightshade historically used to induce hallucinations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Titus Gordion: ""The slightest overdose can result in death.""*)

### Węzeł `[443]`
Mówca: **Sal Ignacius**
> ""By picking up where he left off, we not only honor his memory but open the door to succeeding where he failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Sal Ignacius: ""By keeping the faith, together we will unlock the secret..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true || RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Sal Ignacius: ""You've had your doubts when it comes to matters of faith..."*)

### Węzeł `[447]`
Mówca: **Sal Ignacius**
> ""You've had your doubts when it comes to matters of faith, so instead I ask you to put your trust in me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Sal Ignacius: ""Together we will unlock the secrets to Rizia’s glory and..."*)

### Węzeł `[448]`
Mówca: **Sal Ignacius**
> ""For He is the ultimate arbiter who punishes those who stray from the righteous path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Sal Ignacius: ""Mark my words.""*)

### Węzeł `[449]`
Mówca: **Sal Ignacius**
> ""'He stands as a king above all others -- the living embodiment of divine decree.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Sal Ignacius: ""'Through him, Rizia shall achieve a greatness unparallel..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "AssignConnection("Page_Council", "Position_GrandWiseman",..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AssignConnection("Page_Council", "Position_GrandWiseman", "");`
- **Efekt skryptowy (`userScript`):** `AssignConnection("Page_Council","Position_GrandWiseman","");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You’re unusually quiet. Something on your mind?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Sal Ignacius: ""Your Majesty... please. What happened to your father was..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“You've been keeping secrets from me, Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Sal Ignacius: ""Your Majesty... I assure you I was loyal to your father ..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I assume you know why you’re here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Sal Ignacius: ""If I said I did not, would you believe me?""*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Would you like to start or should I?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Narrator: "Sal remained silent."*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I must say… I've come across some rather intriguing literature lately. Care to interpret it?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Sal Ignacius: ""Wh... where did you get that?""*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Player_Romus: "“I must say… I've come across some rather intriguing lite..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus: "“Would you like to start or should I?""*)

### Węzeł `[462]`
Mówca: **Narrator**
> "Sal remained silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player_Romus: ""I suppose the honor is mine.""*)
  - -> `[464]` (*Player_Romus: ""Coward.""*)
  - -> `[465]` (*Player_Romus: ""You might want to say a silent prayer while you're at it.""*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose the honor is mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[462]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[464]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Coward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[462]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[465]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might want to say a silent prayer while you're at it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[462]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[466]`
Mówca: **Sal Ignacius**
> ""Wh... where did you get that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player_Romus: ""I'll ask the questions, not you.""*)
  - -> `[467]` (*Player_Romus: ""So you do recognize it.""*)
  - -> `[469]` (*Player_Romus: ""Where you last left it. You've been careless. Sal.""*)

### Węzeł `[467]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you do recognize it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll ask the questions, not you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where you last left it. You've been careless. Sal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[466]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[470]`
Mówca: **Sal Ignacius**
> ""Your Majesty... I assure you I was loyal to your father until the very end. I never meant to harm him...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Player_Romus: ""So you *do* know why I summoned you here. Tell me...""*)
  - -> `[471]` (*Player_Romus: ""Please. Groveling is beneath a man of your stature.""*)
  - -> `[472]` (*Player_Romus: ""Silence!""*)

### Węzeł `[471]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please. Groveling is beneath a man of your stature.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[472]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Silence!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[473]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you *do* know why I summoned you here. Tell me...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[470]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[474]`
Mówca: **Narrator**
> "He never looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""It was a rhetorical question.""*)
  - -> `[475]` (*Player_Romus: ""Well, well... it appears you've been blessed with the gi..."*)
  - -> `[477]` (*Player_Romus: ""Look at me when you address your king!""*)

### Węzeł `[475]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, well... it appears you've been blessed with the gift of foresight after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a rhetorical question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[477]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at me when you address your king!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[474]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Narrator: "His gaze slowly met mine."*)

### Węzeł `[478]`
Mówca: **Sal Ignacius**
> ""Your Majesty... please. What happened to your father was a mistake, not murder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Narrator: "He never looked up."*)

### Węzeł `[479]`
Mówca: **Narrator**
> "His gaze slowly met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[480]`
Mówca: **Sal Ignacius**
> ""If I said I did not, would you believe me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Narrator: "His gaze met mine."*)

### Węzeł `[481]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""From now on, I'll be the one asking the questions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[482]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe the man I've come to know would do the righteous thing and confess to what he's done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[483]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not toy with me, Sal. Your insolence will not protect you from the consequences of your actions.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[484]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[484]`
Mówca: **Narrator**
> "His gaze met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Player_Romus: ""I believe the man I've come to know would do the righteo..."*)
  - -> `[481]` (*Player_Romus: ""From now on, I'll be the one asking the questions.""*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[485]`
Mówca: **Narrator**
> "I had him brought to the King's quarters. The very place where my father took his last breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "I looked around at my bed, chairs and wardrobe, trying to..."*)

### Węzeł `[486]`
Mówca: **Narrator**
> "I had him brought to the King's quarters. The very place where my father took his last breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Narrator: "I looked around at my bed, chairs and wardrobe, trying to..."*)

### Węzeł `[487]`
Mówca: **Sal Ignacius**
> ""'Its form blurring the lines between now and what is yet to come, a symbol of a legacy shrouded in the mists of destiny.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Sal Ignacius: ""'He stands as a king above all others -- the living embo..."*)

### Węzeł `[488]`
Mówca: **Sal Ignacius**
> ""'Through him, Rizia shall achieve a greatness unparalleled in the annals of history -- the likes of which the world has never seen!'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[489]`
Mówca: **Titus Gordion**
> ""It was here where we found the bottle, tucked away in a drawer alongside some of the Grand Wiseman's other belongings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[490]`
Mówca: **Lucita Azaro**
> ""It was here where we discovered the bottle, tucked away in a drawer alongside some of Sal's other belongings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[491]`
Mówca: **Sal Ignacius**
> ""For what it's worth, I am deeply sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Player_Romus: ""I may have allowed you to walk free, but forgiveness is ..."*)
  - -> `[492]` (*Player_Romus: ""I hope that with time I'll find the strength to forgive ..."*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope that with time I'll find the strength to forgive you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Sal Ignacius: ""As do I, Your Majesty.""*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like God, I too am forgiving. Now go. Reclaim the righteous path so that you too may find forgiveness in His eyes.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Sal Ignacius: ""Thank you, Your Majesty. I will strive to make amends an..."*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unlike your God, I'm not so easily forgiving.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Sal Ignacius: ""I understand. But I hope that with time you will.""*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Player_Romus: ""Unlike God, I'm not so easily forgiving.""*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Player_Romus: ""Unlike your God, I'm not so easily forgiving.""*)

### Węzeł `[498]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unlike God, I'm not so easily forgiving.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Sal Ignacius: ""I understand. However, I hope that with time, forgivenes..."*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Like your God, I too am forgiving. Now go. Reclaim the righteous path so that you too may find forgiveness in His eyes.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Sal Ignacius: ""Thank you, Your Majesty. I will strive to make amends an..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Like God, I too am forgiving. Now go. Reclaim the righte..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Player_Romus: ""Like your God, I too am forgiving. Now go. Reclaim the r..."*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may have allowed you to walk free, but forgiveness is something I'll never grant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[491]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Sal Ignacius: ""Well, I hope with time you will.""*)

### Węzeł `[504]`
Mówca: **Sal Ignacius**
> ""Well, I hope with time you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "And with that, Sal departed."*)

### Węzeł `[505]`
Mówca: **Sal Ignacius**
> ""I understand. But I hope that with time you will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "And with that, Sal departed."*)

### Węzeł `[506]`
Mówca: **Narrator**
> "And with that, Sal departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[507]`
Mówca: **Sal Ignacius**
> ""As do I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "And with that, Sal departed."*)

### Węzeł `[508]`
Mówca: **Sal Ignacius**
> ""I understand. However, I hope that with time, forgiveness may come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "And with that, Sal departed."*)

### Węzeł `[509]`
Mówca: **Sal Ignacius**
> ""Thank you, Your Majesty. I will strive to make amends and walk the righteous path once more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Narrator: "And with that, Sal departed."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Alone in the room where my father passed, I wondered if a..."*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Narrator: "Alone in the room where my father passed, I wondered if l..."*)

### Węzeł `[513]`
Mówca: **Narrator**
> "Alone in the room where my father passed, I wondered if letting Sal walk free was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Did I act justly, or was I swayed by personal feelings?"*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn08_SalInvesestigationResults_Bring..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Sal_Arrested == true)"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Sal_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Narrator: "Alone, I wondered if arresting Sal was the right decision."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Sal_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Sal_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Narrator: "Alone, I wondered if letting Sal walk free was the right ..."*)

### Węzeł `[521]`
Mówca: **Narrator**
> "Alone, I wondered if arresting Sal was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Did I act justly, or was I swayed by personal feelings?"*)

### Węzeł `[522]`
Mówca: **Narrator**
> "Alone, I wondered if letting Sal walk free was the right decision."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Did I act justly, or was I swayed by personal feelings?"*)

### Węzeł `[523]`
Mówca: **Narrator**
> "I looked around at my bed, chairs and wardrobe, trying to imagine the room as it was on the night Valero passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lucita Azaro: ""Here you are, Your Majesty. We brought him to you as ord..."*)

### Węzeł `[524]`
Mówca: **Narrator**
> "I looked around at my bed, chairs and wardrobe, trying to imagine the room as it was on the night Valero passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Titus Gordion: ""Here you are, Your Majesty, as instructed.""*)

### Węzeł `[525]`
Mówca: **Sal Ignacius**
> ""Together we will unlock the secrets to Rizia’s glory and her salvation!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_MentionsProphecy = true"*)

### Węzeł `[526]`
Mówca: **Narrator**
> "Lucita bowed before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[527]`
Mówca: **Narrator**
> "Titus bowed before leaving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Player_Romus: ""Do not toy with me, Sal. Your insolence will not protect..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""Have you no respect for the sanctity of Wruhecism?""*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
Mówca: **Lucita Azaro**
> ""The slightest overdose can result in death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "She handed me the bag with the bottle. It still had a lit..."*)

### Węzeł `[535]`
Mówca: **Titus Gordion**
> ""The slightest overdose can result in death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "He handed me bag with the bottle. It still had a little b..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucita Azaro: ""Your butler told you this? It's no wonder you're so fond..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Lucita Azaro: ""Your butler told you this? You ought to reward him.""*)

### Węzeł `[539]`
Mówca: **Lucita Azaro**
> ""Your butler told you this? You ought to reward him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[540]`
Mówca: **Lucita Azaro**
> "“Considering his age, he exhibited remarkable courage, despite possible repercussions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[541]`
Mówca: **Titus Gordion**
> "“Considering his age, he exhibited remarkable courage, despite possible consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Investigation Results Questions]"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Investigation Results Questions]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Sal Investigation Results Questions"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player_Romus: ""So old Sal took a consciousness-expanding trip every now..."*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""I'm still not convinced. Is the bottle the only evidence..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So old Sal took a consciousness-expanding trip every now and again. Who doesn't? Is that all the evidence you've got?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"] == true` AND `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The fact that such a close advisor was hiding this substance is very worrying indeed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Poison_BottleLocation"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowCanYouBeSure"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyIdentity"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_BoyName"] == true  or  Variable["RiziaDLCIsolated.SalInvestigation_Poison_HowDoesItWork"] == true` AND `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true  or  Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[489]` (Titus Gordion), `[490]` (Lucita Azaro), `[56]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[548]`
Mówca: **Narrator**
> "The guards looked at me questioningly, awaiting my judgement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[549]`
Mówca: **Narrator**
> "He bowed his head, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Alone == true)"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Alone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Narrator: "He bowed his head, awaiting my next words."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Alone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Narrator: "The guards looked at me questioningly, awaiting my judgem..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened..."*)
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappen..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Player_Romus: ""What happened on the night of November 18, 1949? I want ..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What happened on the night of November 18, 1949? I want to know every detail.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] == false` AND `Variable["RiziaDLCIsolated.SalInvestigation_Alone"] == true`
- **Kontekst wejściowy (poprzednik):** `[548]` (Narrator), `[549]` (Narrator), `[210]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened..."*)

### Węzeł `[557]`
Mówca: **Narrator**
> "Sal trembled. His eyes darted to the journal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Sal Ignacius: ""It is exactly as I wrote it, Your Majesty.""*)

### Węzeł `[558]`
Mówca: **Sal Ignacius**
> ""It is exactly as I wrote it, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Sal Ignacius: ""The King summoned me to his chambers for our final attem..."*)

### Węzeł `[559]`
Mówca: **Sal Ignacius**
> ""The King summoned me to his chambers for our final attempt at the sacred ritual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Sal Ignacius: ""As instructed by holy scripture, I prepared the tincture..."*)

### Węzeł `[560]`
Mówca: **Sal Ignacius**
> ""As instructed by holy scripture, I prepared the tincture and administered it to His Majesty in a glass of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Sal Ignacius: ""As soon as he consumed it, his eyes became wild with ter..."*)

### Węzeł `[561]`
Mówca: **Sal Ignacius**
> ""As soon as he consumed it, his eyes became wild with terror, as if witnessing something no man should ever see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Sal Ignacius: ""He began slipping in and out of consciousness... when he..."*)

### Węzeł `[562]`
Mówca: **Sal Ignacius**
> ""He began slipping in and out of consciousness... when he spoke, it was unintelligible. 'Look after Romus' were the only words I could make out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Player_Romus: ""And you just left him like that? You complete and utter ..."*)
  - -> `[564]` (*Player_Romus: ""Why didn't you alert the guards?""*)
  - -> `[565]` (*Player_Romus: ""He summoned you. He brought this on himself.""*)
  - -> `[594]` (*Player_Romus: ""He was still alive when you left. Someone else could hav..."*)

### Węzeł `[563]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you just left him like that? You complete and utter coward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Sal Ignacius: ""I know. I have rendered my garments so many times in rep..."*)

### Węzeł `[564]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you alert the guards?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Sal Ignacius: ""His Majesty had made me swear to keep the ritual a secre..."*)

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He summoned you. He brought this on himself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Sal Ignacius: ""I convinced him to do it. He was so desperate for answer..."*)

### Węzeł `[566]`
Mówca: **Sal Ignacius**
> ""His Majesty had made me swear to keep the ritual a secret from everyone. And I was sure he would recover after a good night's sleep...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Sal Ignacius: ""But I am afraid I underestimated how weak he was.""*)

### Węzeł `[567]`
Mówca: **Sal Ignacius**
> ""I know. I have rendered my garments so many times in repentance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Sal Ignacius: ""His Majesty had made me swear to keep the ritual a secre..."*)

### Węzeł `[568]`
Mówca: **Sal Ignacius**
> ""I convinced him to do it. He was so desperate for answers, and I thought the prophecy would provide them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Sal Ignacius: ""But I am afraid I underestimated how weak he was.""*)

### Węzeł `[569]`
Mówca: **Sal Ignacius**
> ""But I am afraid I underestimated how weak he was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sal Questions Hub]"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SalInvestigation_Sal_WhatExactlyHappened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Narrator: "Sal trembled. His eyes darted to the journal."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sal Questions Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "Sal Questions Hub"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == t..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Sal Ignacius: ""It is not poison, Your Majesty. As you have already witn..."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Sal Ignacius: ""It is not poison, Your Majesty, but a tool to prepare on..."*)

### Węzeł `[575]`
Mówca: **Sal Ignacius**
> ""It is not poison, Your Majesty, but a tool to prepare one's mind to receive the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Sal Ignacius: ""When a Grand Wiseman such as myself partakes of it, such..."*)

### Węzeł `[576]`
Mówca: **Sal Ignacius**
> ""Yet it is said that when the king who was prophesied drinks the holy elixir, the future shall be revealed to him as clearly as the past or present.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Sal Ignacius: ""Unfortunately, that did not transpire with His Majesty V..."*)

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your 'visions' are nothing but hallucinations. They don't mean a damn thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)

### Węzeł `[578]`
Mówca: **Sal Ignacius**
> ""Think of what I foretold at Plavo. Is it not coming true?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == t..."*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Sal Ignacius: ""Think of what I foretold at Plavo. Is it not coming true?""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He always was anxious about the future. I can see why he wanted to take this risk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like some real strong stuff. Mind if I have a swig?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Kontekst wejściowy (poprzednik):** `[209]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Sal Ignacius: ""Your Majesty, performing this sacred ritual requires mon..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince)"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Player_Romus: ""Sounds like some real strong stuff. Mind if I have a swig?""*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Player_Romus: ""I wouldn't mind receiving that gift myself.""*)

### Węzeł `[587]`
Mówca: **Sal Ignacius**
> ""Your Majesty, performing this sacred ritual requires months of preparation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't mind receiving that gift myself.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Kontekst wejściowy (poprzednik):** `[209]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Sal Ignacius: ""Your Majesty, performing this sacred ritual requires mon..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Sal Ignacius: ""Spare my life. Then we can talk about it.""*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Sal Ignacius: ""And a piety, that, I am sorry to say, you yourself lack.""*)

### Węzeł `[592]`
Mówca: **Sal Ignacius**
> ""And a piety, that, I am sorry to say, you yourself lack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[593]`
Mówca: **Sal Ignacius**
> ""Spare my life. Then we can talk about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SalInvestigation_Alone == true"*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He was still alive when you left. Someone else could have gotten to him afterward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[562]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Sal Ignacius: ""I wish I could believe that, Your Majesty. I was so cert..."*)

### Węzeł `[595]`
Mówca: **Sal Ignacius**
> ""I wish I could believe that, Your Majesty. I was so certain the dose I had given the King was non-lethal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Sal Ignacius: ""But I am afraid I underestimated how weak he was.""*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true ||..."*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true ..."*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "And if Sal didn't kill my father... who did?"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true || RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true || RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "And what horrors did my father see before he drew his fin..."*)

### Węzeł `[599]`
Mówca: **Narrator**
> "And what horrors did my father see before he drew his final breaths?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested == true"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Narrator: "Lucita and the other guards came back into the room, eage..."*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Titus and his men came back into the room, eager to hear ..."*)

### Węzeł `[603]`
Mówca: **Narrator**
> "Lucita and the other guards came back into the room, eager to hear my verdict."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true )"*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Narrator: "Lucita watched him leave with an obvious look of dissatis..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Narrator: "Titus watched him leave with an obvious look of dissatisf..."*)

### Węzeł `[609]`
Mówca: **Narrator**
> "Lucita watched him leave with an obvious look of dissatisfaction on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Lucita Azaro: ""This doesn't sit right with me.""*)

### Węzeł `[610]`
Mówca: **Narrator**
> "Titus watched him leave with an obvious look of dissatisfaction on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Titus Gordion: ""I trust your judgement, Your Majesty. But I feel uneasy ..."*)

### Węzeł `[611]`
Mówca: **Lucita Azaro**
> ""This doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Player_Romus: ""I'm not convinced he's actually our culprit. We need to ..."*)
  - -> `[613]` (*Player_Romus: ""He's indebted to me for sparing him. I can use that to m..."*)
  - -> `[619]` (*Player_Romus: ""I believe that he killed my father by complete accident...."*)
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[612]`
Mówca: **Titus Gordion**
> ""I trust your judgement, Your Majesty. But I feel uneasy letting that man walk free.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Player_Romus: ""I'm not convinced he's actually our culprit. We need to ..."*)
  - -> `[619]` (*Player_Romus: ""I believe that he killed my father by complete accident...."*)
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's indebted to me for sparing him. I can use that to my advantage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not convinced he's actually our culprit. We need to continue this investigation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucita Azaro), `[612]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Player_Romus: ""I believe him. My father was not the king who was prophe..."*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[618]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe him. My father was not the king who was prophesied. Myself, on the other hand...""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucita Azaro), `[612]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe that he killed my father by complete accident. And he seems remorseful for his actions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucita Azaro), `[612]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Lucita Azaro: ""Really? The case for the Grand Wiseman poisoning the Kin..."*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Titus Gordion: ""Are you certain? It seems like a clear-cut case to me, e..."*)

### Węzeł `[623]`
Mówca: **Lucita Azaro**
> ""Really? The case for the Grand Wiseman poisoning the King -- whether accidentally or on purpose -- seems very strong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Player_Romus: ""Hugo and my father were arguing that night. It can't be ..."*)
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_TitusChat_Derdia == false"*)
  - -> `[632]` (*Player_Romus: ""You're right. It's too risky to continue investigating p..."*)

### Węzeł `[624]`
Mówca: **Titus Gordion**
> ""Are you certain? It seems like a clear-cut case to me, even if the Grand Wiseman acted unintentionally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Player_Romus: ""Hugo and my father were arguing that night. It can't be ..."*)
  - -> `[625]` (*Player_Romus: ""There's still the mystery of why Duchess Azaro snuck int..."*)
  - -> `[632]` (*Player_Romus: ""You're right. It's too risky to continue investigating p..."*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's still the mystery of why Duchess Azaro snuck into my father's room.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[624]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[634]` (*Titus Gordion: ""I confess I've been wondering about that myself.""*)

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo and my father were arguing that night. It can't be a coincidence that he died so soon afterward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Lucita Azaro), `[624]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_TitusChat_Derdia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn07_TitusChat_Derdia == false"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn07_TitusChat_Derdia == false)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn07_TitusChat_Derdia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Player_Romus: ""There's still the matter of Titus' unexplained absence.""*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn07_TitusChat_Derdia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Player_Romus: ""Titus explained why he had to leave his post, but I'm no..."*)

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There's still the matter of Titus' unexplained absence.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false`
- **Kontekst wejściowy (poprzednik):** `[623]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Lucita Azaro: ""Yes, I'm still wondering about that myself.""*)

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus explained why he had to leave his post, but I'm not sure I believe him.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLCIsolated.Turn07_TitusChat_Derdia"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[623]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Lucita Azaro: ""Yes, I'm still wondering about that myself.""*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. It's too risky to continue investigating people in my inner circle anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[623]` (Lucita Azaro), `[624]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[633]`
Mówca: **Lucita Azaro**
> ""Yes, I'm still wondering about that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[634]`
Mówca: **Titus Gordion**
> ""I confess I've been wondering about that myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Lucita Azaro: ""Perhaps not.""*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Titus Gordion: ""I would hate to think the Grand Vizier played a role. Bu..."*)

### Węzeł `[638]`
Mówca: **Lucita Azaro**
> ""Perhaps not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[639]`
Mówca: **Titus Gordion**
> ""I would hate to think the Grand Vizier played a role. But you have a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Lucita Azaro: ""With that said, my team can't continue our investigation..."*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Lucita Azaro: ""With that said, my team can't continue this investigatio..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)
  - -> `[645]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 1)"*)

### Węzeł `[644]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Titus Gordion: ""However, the Golden Guard can't continue our investigati..."*)

### Węzeł `[645]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Titus Gordion: ""However, the Golden Guard can't continue this investigat..."*)

### Węzeł `[646]`
Mówca: **Lucita Azaro**
> ""With that said, my team can't continue this investigation without further funding. And it appears the Crown is pinching pennies at the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[647]`
Mówca: **Titus Gordion**
> ""However, the Golden Guard can't continue this investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[693]` (*Player_Romus: ""I wouldn't throw any more money down this rabbit hole ev..."*)
  - -> `[668]` (*Player_Romus: ""What a pity. I was really hoping to get to the bottom of..."*)

### Węzeł `[648]`
Mówca: **Titus Gordion**
> ""However, the Golden Guard can't continue our investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player_Romus: ""Spare no expense. I want all your investigatory focus on..."*)
  - -> `[652]` (*Player_Romus: ""So be it. You have my blessing and my funding to investi..."*)
  - -> `[658]` (*Player_Romus: ""Never mind, then. I'm not going to throw any more money ..."*)
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[649]`
Mówca: **Lucita Azaro**
> ""With that said, my team can't continue our investigation without further funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[650]` (*Player_Romus: ""Spare no expense. I want all your investigatory focus on..."*)
  - -> `[651]` (*Player_Romus: ""So be it. You have my blessing and my funding to investi..."*)
  - -> `[658]` (*Player_Romus: ""Never mind, then. I'm not going to throw any more money ..."*)

### Węzeł `[650]`
**[WYBÓR GRACZA: ""Spare no expense. I want all your investigatory focus on the Grand Vizier." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Spare no expense. I want all your investigatory focus on the Grand Vizier.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Titus Gordion), `[649]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[651]`
**[WYBÓR GRACZA: ""So be it. You have my blessing and my funding to investigate Titus Gordion as the primary suspect." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""So be it. You have my blessing and my funding to investigate Titus Gordion as the primary suspect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[649]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Lucita Azaro: ""We'll get on it straight away.""*)

### Węzeł `[652]`
**[WYBÓR GRACZA: ""So be it. You have my blessing and my funding to investigate Lucita Azaro as the primary suspect." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""So be it. You have my blessing and my funding to investigate Lucita Azaro as the primary suspect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Titus Gordion: ""With great pleasure, Your Majesty.""*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Lucita Azaro: ""Your wish is our command.""*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Titus Gordion: ""As you wish, sir.""*)

### Węzeł `[656]`
Mówca: **Lucita Azaro**
> ""Your wish is our command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""As you wish, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never mind, then. I'm not going to throw any more money at this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[648]` (Titus Gordion), `[649]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[659]`
Mówca: **Lucita Azaro**
> ""We'll get on it straight away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Arrested == true"*)
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Arrested == true)"*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Arrested == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Arrested"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Titus Gordion: ""Duchess Azaro is already in prison, of course, but it ma..."*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Arrested == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Arrested"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[663]`
Mówca: **Titus Gordion**
> ""Duchess Azaro is already in prison, of course, but it may be useful to find more charges to bring against her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 1"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[665]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Player_Romus: ""Why is it always about the money with you?! If anything,..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[667]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why is it always about the money with you?! If anything, your people should be paying *me* for the pleasure of serving their monarch!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[646]` (Lucita Azaro), `[647]` (Titus Gordion), `[648]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[668]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a pity. I was really hoping to get to the bottom of my father's death.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "Lucita backed away."*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Narrator: "Titus backed away."*)

### Węzeł `[672]`
Mówca: **Narrator**
> "Lucita backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Lucita Azaro: ""My apologies, Your Majesty. You've had quite the shock t..."*)

### Węzeł `[673]`
Mówca: **Narrator**
> "Titus backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Titus Gordion: ""My apologies, Your Majesty. You've had quite the shock t..."*)

### Węzeł `[674]`
Mówca: **Lucita Azaro**
> ""My apologies, Your Majesty. You've had quite the shock today. I'll give you some time to get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[675]`
Mówca: **Titus Gordion**
> ""My apologies, Your Majesty. You've had quite the shock today. I'll give you some time to get over it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[676]`
Mówca: **Narrator**
> "She and her guards bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[677]`
Mówca: **Narrator**
> "He and his guards bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true; RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Narrator: "She and her guards bowed and left."*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus = true; RiziaDLC.Turn05_MurderInvest_InvestigateTitus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Narrator: "She and her guards bowed and left."*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita = true; RiziaDLC.Turn05_MurderInvest_InvestigateLucita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Narrator: "He and his guards bowed and left."*)

### Węzeł `[681]`
Mówca: **Titus Gordion**
> ""With great pleasure, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget -= 1; RiziaDLCSupport.Journal_T..."*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget -= 1;
RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true; RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Resources_Budget"] = Variable["RiziaDLC.Resources_Budget"] - 1;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Narrator: "He and his guards bowed and left."*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Lucita Azaro: ""Understandable. I'm sorry we couldn't solve this case to..."*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Titus Gordion: ""I understand. Please excuse our failure to tie up every ..."*)

### Węzeł `[686]`
Mówca: **Lucita Azaro**
> ""Understandable. I'm sorry we couldn't solve this case to your liking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[687]`
Mówca: **Titus Gordion**
> ""I understand. Please excuse our failure to tie up every loose end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Lucita Azaro: ""If you ask me, we did.""*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Titus Gordion: ""I have the feeling we already did so.""*)

### Węzeł `[691]`
Mówca: **Lucita Azaro**
> ""If you ask me, we did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[692]`
Mówca: **Titus Gordion**
> ""I have the feeling we already did so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[693]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't throw any more money down this rabbit hole even if I could.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[647]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Narrator: "Lucita struggled to hold in her skepticism."*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Narrator: "Titus nodded seriously."*)

### Węzeł `[697]`
Mówca: **Narrator**
> "Lucita struggled to hold in her skepticism."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Lucita Azaro: ""We'll leave it at that, then. I'll have my team destroy ..."*)

### Węzeł `[698]`
Mówca: **Narrator**
> "Titus nodded seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Titus Gordion: ""All right. With the King's blessing, the Grand Wiseman s..."*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Lucita Azaro: ""We've got our hands full with threats from outside the p..."*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Titus Gordion: ""Everyone has something to hide, Your Majesty. But it's n..."*)

### Węzeł `[702]`
Mówca: **Lucita Azaro**
> ""We've got our hands full with threats from outside the palace. We can't let paranoia take over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Lucita Azaro: ""We'll leave it at that, then. I'll have my team destroy ..."*)

### Węzeł `[703]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Lucita Azaro: ""I wouldn't be so sure. But he wouldn't dare to pull the ..."*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Titus Gordion: ""He's an old man. He's suffered enough.""*)

### Węzeł `[706]`
Mówca: **Titus Gordion**
> ""He's an old man. He's suffered enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Titus Gordion: ""All right. With the King's blessing, the Grand Wiseman s..."*)

### Węzeł `[707]`
Mówca: **Lucita Azaro**
> ""I wouldn't be so sure. But he wouldn't dare to pull the same trick twice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Lucita Azaro: ""We'll leave it at that, then. I'll have my team destroy ..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Lucita Azaro: ""Good thinking, Your Majesty. It wouldn't hurt to have th..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Titus Gordion: ""The Sanctuary's cooperation can indeed be a powerful tool.""*)

### Węzeł `[711]`
Mówca: **Lucita Azaro**
> ""Good thinking, Your Majesty. It wouldn't hurt to have the Sanctuary in your back pocket.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Lucita Azaro: ""We'll leave it at that, then. I'll have my team destroy ..."*)

### Węzeł `[712]`
Mówca: **Titus Gordion**
> ""The Sanctuary's cooperation can indeed be a powerful tool.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Titus Gordion: ""All right. With the King's blessing, the Grand Wiseman s..."*)

### Węzeł `[713]`
Mówca: **Lucita Azaro**
> ""We'll leave it at that, then. I'll have my team destroy all records of this investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[714]` (*Lucita Azaro: ""Nobody besides us and the Grand Wiseman will know ever h..."*)

### Węzeł `[714]`
Mówca: **Lucita Azaro**
> ""Nobody besides us and the Grand Wiseman will know ever happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[715]`
Mówca: **Titus Gordion**
> ""All right. With the King's blessing, the Grand Wiseman shall be cleared of all charges. It'll be as if this investigation never happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigation_Continues = false"*)

### Węzeł `[716]`
Mówca: **Titus Gordion**
> ""Everyone has something to hide, Your Majesty. But it's not always worth finding out what that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Titus Gordion: ""All right. With the King's blessing, the Grand Wiseman s..."*)

### Węzeł `[717]`
Mówca: **Narrator**
> "With a look of annoyance only I could detect, Pabel bowed and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Narrator: "With a look of annoyance only I could detect, Pabel bowed..."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Pabel bowed respectfully before exiting the room."*)

### Węzeł `[721]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Pabel bowed respectfully before exiting the room."*)

### Węzeł `[722]`
Mówca: **Pabel Adria**
> ""Thank you, Your Majesty, but it's quite all right. I'll see myself out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "He flashed me a look of gratitude before bowing respectfu..."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "Pabel bowed respectfully before exiting the room."*)

### Węzeł `[726]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[728]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[727]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Lucita Azaro: ""Whether under the instructions of Sevrio Castellanus or ..."*)

### Węzeł `[728]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Lucita Azaro: ""They remained tight-lipped.""*)

### Węzeł `[729]`
Mówca: **Lucita Azaro**
> ""Whether under the instructions of Sevrio Castellanus or those of the Grand Wiseman himself, they remained tight-lipped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""Have you no respect for the sanctity of Wruhecism?""*)
  - -> `[419]` (*Player_Romus: ""Hah! Bring them to me. I'll handle them personally.""*)
  - -> `[417]` (*Player_Romus: ""Can't say I'm surprised. Their loyalty is to their wisce..."*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Titus Gordion: ""Via Sevrio Castellanus, I gained access to his network o..."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Titus Gordion: ""I subjected many of his priests to interrogation. Unfort..."*)

### Węzeł `[733]`
Mówca: **Titus Gordion**
> ""Via Sevrio Castellanus, I gained access to his network of priests. Unfortunately, eliciting any useful information from them proved impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""Have you no respect for the sanctity of Wruhecism?""*)
  - -> `[419]` (*Player_Romus: ""Hah! Bring them to me. I'll handle them personally.""*)
  - -> `[417]` (*Player_Romus: ""Can't say I'm surprised. Their loyalty is to their wisce..."*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[736]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[735]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Titus Gordion: "“Alfreth Tilda. An orphan who was taken in years ago. He ..."*)

### Węzeł `[736]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Titus Gordion: "“Alfreth Tilda. An orphan who was taken in years ago. He ..."*)

### Węzeł `[737]`
Mówca: **Titus Gordion**
> "“Alfreth Tilda. An orphan who was taken in years ago. He was training to become a member of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Titus Gordion: "“Initially hesitant to divulge what he knew, the kid even..."*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Lucita Azaro: ""Alfreth Tilda. An orphan taken in years ago. He was trai..."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucita Azaro: ""Alfreth Tilda. An orphan taken in years ago. He was purs..."*)

### Węzeł `[741]`
Mówca: **Lucita Azaro**
> ""Alfreth Tilda. An orphan taken in years ago. He was training to become a member of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: "“Initially hesitant to divulge what he knew, he eventuall..."*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[744]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Titus Gordion: ""But if Wruhec's Guardians is to continue, perhaps it's i..."*)

### Węzeł `[744]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Titus Gordion: ""But I shall abide by your command.""*)

### Węzeł `[745]`
Mówca: **Titus Gordion**
> ""But if Wruhec's Guardians is to continue, perhaps it's indeed best to overlook the Grand Wiseman's transgressions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[746]`
Mówca: **Titus Gordion**
> ""But I shall abide by your command.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Titus Gordion: ""I suppose this means the end of Wruhec's Guardians.""*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_SalIgnacius_Arrested..."*)

### Węzeł `[750]`
Mówca: **Titus Gordion**
> ""I suppose this means the end of Wruhec's Guardians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Player_Romus: ""Yes. Are you disappointed?""*)
  - -> `[752]` (*Player_Romus: ""Sal was manipulating me this entire time. Just as he man..."*)
  - -> `[753]` (*Player_Romus: ""Maybe I shouldn't be so hasty to disband my trusted holy..."*)

### Węzeł `[751]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Are you disappointed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Narrator: "He shook his head."*)

### Węzeł `[752]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal was manipulating me this entire time. Just as he manipulated my father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Titus Gordion: ""And myself, Your Majesty. He deserves whatever hell awai..."*)

### Węzeł `[753]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe I shouldn't be so hasty to disband my trusted holy army. Let's hear what the Grand Wiseman has to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.Sal_Arrested = true;
RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLC.PoisonInvestigation_Continues = false;`
- **Efekt skryptowy (`userScript`):** `EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He bowed and left the room."*)

### Węzeł `[755]`
Mówca: **Narrator**
> "He shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Titus Gordion: ""If the Grand Wiseman truly is a murderer, I was a fool t..."*)

### Węzeł `[756]`
Mówca: **Titus Gordion**
> ""If the Grand Wiseman truly is a murderer, I was a fool to have followed him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_SalIgnacius_Arrested..."*)

### Węzeł `[757]`
Mówca: **Titus Gordion**
> ""And myself, Your Majesty. He deserves whatever hell awaits him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "EnableCodexEntry("Characters_Council_SalIgnacius_Arrested..."*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[760]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Narrator: "Suddenly, I heard a commotion outside the door. Sevrio Ca..."*)

### Węzeł `[760]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""Arrest Grand Wiseman Sal Ignacius immediately. Let him r..."*)
  - -> `[254]` (*Player_Romus: ""I don't care what he has or hasn't done. You're not to m..."*)

### Węzeł `[761]`
Mówca: **Narrator**
> "Suddenly, I heard a commotion outside the door. Sevrio Castellanus burst in and surveyed the scene in dismay."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Sevrio Castellanus: ""Your Majesty... What is the meaning of this?""*)

### Węzeł `[762]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty... What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Player_Romus: ""The Grand Wiseman has been accused of murdering my fathe..."*)
  - -> `[764]` (*Player_Romus: ""Don't act like you don't know. You were in on this schem..."*)
  - -> `[765]` (*Player_Romus: ""Nothing you need to be worried about, Sevrio. You may le..."*)
  - -> `[766]` (*Player_Romus: ""A mere misunderstanding. The Grand Wiseman has been accu..."*)

### Węzeł `[763]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman has been accused of murdering my father. King Valero.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[762]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Sevrio Castellanus: ""What?! Surely there's been a mistake.""*)

### Węzeł `[764]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't act like you don't know. You were in on this scheme the whole time, weren't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[762]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Sevrio Castellanus: ""Scheme? I still don't understand. Why have you detained ..."*)

### Węzeł `[765]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing you need to be worried about, Sevrio. You may leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[762]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Sevrio Castellanus: ""Please, Your Majesty. I swore to uphold religious order ..."*)

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A mere misunderstanding. The Grand Wiseman has been accused of something he did not do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[762]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Lucita Azaro: ""What? We have concrete evidence of his guilt.""*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Titus Gordion: ""Your Majesty, Sevrio... I wish that were the case, but t..."*)

### Węzeł `[770]`
Mówca: **Lucita Azaro**
> ""What? We have concrete evidence of his guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Sevrio Castellanus: ""His guilt? What did he do?""*)

### Węzeł `[771]`
Mówca: **Titus Gordion**
> ""Your Majesty, Sevrio... I wish that were the case, but the evidence clearly points toward his guilt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Sevrio Castellanus: ""His guilt? What did he do?""*)

### Węzeł `[772]`
Mówca: **Sevrio Castellanus**
> ""Scheme? I still don't understand. Why have you detained the Grand Wiseman?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[773]`
Mówca: **Sevrio Castellanus**
> ""What?! Surely there's been a mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[774]`
Mówca: **Sevrio Castellanus**
> ""Please, Your Majesty. I swore to uphold religious order in Rizia. If something concerns the holiest figure in the kingdom, it concerns me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Lucita Azaro: ""He's right, Your Majesty. As the leader of Wruhec's Guar..."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Titus Gordion: ""Sevrio is right, Your Majesty. He deserves to know what ..."*)

### Węzeł `[778]`
Mówca: **Lucita Azaro**
> ""He's right, Your Majesty. As the leader of Wruhec's Guardians, he deserves to know what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Narrator: "Lucita showed him the Grand Wiseman's journal and the bot..."*)

### Węzeł `[779]`
Mówca: **Titus Gordion**
> ""Sevrio is right, Your Majesty. He deserves to know what happened.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Narrator: "Titus showed him the Grand Wiseman's journal and the bott..."*)

### Węzeł `[780]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[782]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[781]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Narrator: "Lucita showed him the Grand Wiseman's journal and the bot..."*)

### Węzeł `[782]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Titus Gordion: ""I wish there had been a mistake, Captain Castellanus. Bu..."*)

### Węzeł `[783]`
Mówca: **Narrator**
> "Lucita showed him the Grand Wiseman's journal and the bottle that had been found among his belongings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Sevrio Castellanus: ""It can't be. The Grand Wiseman of the Wruhecist Sanctuar..."*)

### Węzeł `[784]`
Mówca: **Narrator**
> "Titus showed him the Grand Wiseman's journal and the bottle that had been found among his belongings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Sevrio Castellanus: ""It can't be. The Grand Wiseman of the Wruhecist Sanctuar..."*)

### Węzeł `[785]`
Mówca: **Titus Gordion**
> ""I wish there had been a mistake, Captain Castellanus. But the evidence speaks for itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Narrator: "Titus showed him the Grand Wiseman's journal and the bott..."*)

### Węzeł `[786]`
Mówca: **Sevrio Castellanus**
> ""It can't be. The Grand Wiseman of the Wruhecist Sanctuary of Rizia would never do such a thing. Tell him, Grand Wiseman...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Narrator: "Sal quietly shook his head."*)

### Węzeł `[787]`
Mówca: **Narrator**
> "Sal quietly shook his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Player_Romus: ""The Grand Wiseman played us all for fools. He shall be p..."*)
  - -> `[789]` (*Player_Romus: ""Yes, Sal administered the drug that ended my father's li..."*)
  - -> `[791]` (*Player_Romus: ""My father was weak, Captain Castellanus. He had to die s..."*)

### Węzeł `[788]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman played us all for fools. He shall be placed under immediate arrest.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Tur..."*)

### Węzeł `[789]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Sal administered the drug that ended my father's life. But he did so out of love for God and for this country. He shall walk free.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Narrator: "The others gasped."*)

### Węzeł `[790]`
Mówca: **Narrator**
> "The others gasped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Le..."*)

### Węzeł `[791]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father was weak, Captain Castellanus. He had to die so that Rizia could be reborn. The Grand Wiseman's actions were entirely justified.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[787]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Narrator: "The others gasped."*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[793]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Sevrio Castellanus: ""This shall stay between us, Your Majesty. The other Wruh..."*)

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[795]`
Mówca: **Sevrio Castellanus**
> ""This shall stay between us, Your Majesty. The other Wruhec's Guardians don't have to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Narrator: "Sevrio bowed and followed Sal out."*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[797]`
Mówca: **Narrator**
> "Sevrio bowed and followed Sal out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sevrio Castellanus");"*)

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal == true"*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)"*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Narrator: "Sevrio turned to me, seemingly in a daze."*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Religious_WruhecsGuardians_Sal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[801]`
Mówca: **Narrator**
> "Sevrio turned to me, seemingly in a daze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Sevrio Castellanus: ""He was my teacher. My mentor. And all this time, he was ..."*)

### Węzeł `[802]`
Mówca: **Sevrio Castellanus**
> ""He was my teacher. My mentor. And all this time, he was a fraud.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Narrator: "He violently tore off the gold chain that was hanging aro..."*)

### Węzeł `[803]`
Mówca: **Narrator**
> "He violently tore off the gold chain that was hanging around his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Sevrio Castellanus: ""Wruhec's Guardians were built on a foundation of lies. W..."*)

### Węzeł `[804]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians were built on a foundation of lies. We must disband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Sevrio Castellanus: ""It has been an honor serving you, Your Majesty. Despite ..."*)

### Węzeł `[805]`
Mówca: **Sevrio Castellanus**
> ""It has been an honor serving you, Your Majesty. Despite everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Player_Romus: ""You still have the Wruhecist community's respect. I need..."*)
  - -> `[808]` (*Player_Romus: ""Thank you, Sevrio. You're dismissed.""*)
  - -> `[809]` (*Player_Romus: ""Go with God.""*)
  - -> `[810]` (*Player_Romus: ""With Sal gone, Rizia is in the market for a new Grand Wi..."*)

### Węzeł `[806]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Religious_WruhecsGuardians_Sal = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Religious_WruhecsGuardians_Sal"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Narrator: "He bowed his head and rushed out."*)

### Węzeł `[807]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You still have the Wruhecist community's respect. I need you to make sure they weather this scandal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[805]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Sevrio Castellanus: ""I will talk to them. But I cannot promise they'll listen.""*)

### Węzeł `[808]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Sevrio. You're dismissed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[805]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Sevrio Castellanus: ""Divus zaitu.""*)

### Węzeł `[809]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go with God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[805]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Sevrio Castellanus: ""Divus zaitu.""*)

### Węzeł `[810]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With Sal gone, Rizia is in the market for a new Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[805]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Sevrio Castellanus: ""I-- I could never. Not after this.""*)

### Węzeł `[811]`
Mówca: **Sevrio Castellanus**
> ""I-- I could never. Not after this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal = false;"*)

### Węzeł `[812]`
Mówca: **Sevrio Castellanus**
> ""Divus zaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal = false;"*)

### Węzeł `[813]`
Mówca: **Sevrio Castellanus**
> ""I will talk to them. But I cannot promise they'll listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Religious_WruhecsGuardians_Sal = false;"*)

### Węzeł `[814]`
Mówca: **Narrator**
> "He bowed his head and rushed out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sevrio Castellanus");"*)

### Węzeł `[815]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sevrio Castellanus");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sevrio Castellanus");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn08_SalInvesestigationResults_BringSa..."*)

### Węzeł `[816]`
Mówca: **Sevrio Castellanus**
> ""His guilt? What did he do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Player_Romus: ""My father asked him to assist in the conduction of a sac..."*)
  - -> `[818]` (*Player_Romus: ""As I said, this is all a misunderstanding. The Grand Wis..."*)
  - -> `[817]` (*Player_Romus: ""Nothing less than his duty. My father had to die so that..."*)

### Węzeł `[817]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nothing less than his duty. My father had to die so that Rizia could be reborn. The Grand Wiseman's actions were entirely justified.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[816]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Narrator: "The others gasped."*)

### Węzeł `[818]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As I said, this is all a misunderstanding. The Grand Wiseman is to be released immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[816]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Le..."*)

### Węzeł `[819]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father asked him to assist in the conduction of a sacred ritual. The fact that the ritual took his life is no fault of Sal's.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[816]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Narrator: "Sevrio's jaw dropped."*)

### Węzeł `[820]`
Mówca: **Narrator**
> "Sevrio's jaw dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Le..."*)

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigation_Continues = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Narrator: "He and his guards bowed and left."*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigation_Continues = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Narrator: "She and her guards bowed and left."*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Sal_Arrested = true; RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested = true;
RiziaDLCSupport.News_Turn08_RH_SalArrested = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
RiziaDLC.PoisonInvestigation_Continues = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Sal_Arrested"] = true;
Variable["RiziaDLCSupport.Journal_Turn08_SalInvestigationResults_Arrested"] = true;
Variable["RiziaDLCSupport.News_Turn08_RH_SalArrested"] = true;
EnableCodexEntry("Characters_Council_SalIgnacius_Arrested");
Variable["RiziaDLC.PoisonInvestigation_Continues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "She bowed and left the room."*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Learning the truth behind their father’s death", "Dining Hall", "Palace Rezna");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Learning the truth behind their father’s death","Dining Hall","Palace Rezna");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)
