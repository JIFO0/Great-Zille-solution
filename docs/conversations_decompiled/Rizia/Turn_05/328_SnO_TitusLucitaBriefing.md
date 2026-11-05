# Rizia/Turn 5/SnO_TitusLucitaBriefing

- **ID konwersacji:** `328`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Rizia/Turn_05/328_SnO_TitusLucitaBriefing.md`
- **Liczba węzłów dialogowych:** 920
- **Liczba wyborów gracza:** 162

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[73]** Lucita Azaro
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.InvestigatePoisoning_NoPabel`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Lucita_PromisedDate`
- `RiziaDLC.Relations_Lucita_Together`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`
- `RiziaDLC.Turn05_MurderInvest_SuspectLucita`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Turn05_MurderInvest_SuspectSal`
- `RiziaDLC.Turn05_MurderInvest_SuspectTitus`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Argument`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Lying`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Timing`
- `RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PoisonInvestigation_Continues`
- `RiziaDLC.PoisonInvestigator_Lucita`
- `RiziaDLC.PoisonInvestigator_Titus`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Turn05_MurderInvest_InvestigateHugo`
- `RiziaDLC.Turn05_MurderInvest_InvestigateLucita`
- `RiziaDLC.Turn05_MurderInvest_InvestigateNoone`
- `RiziaDLC.Turn05_MurderInvest_InvestigateSal`
- `RiziaDLC.Turn05_MurderInvest_InvestigateTitus`
- `RiziaDLC.Turn05_MurderInvest_SuspectEstela`
- `RiziaDLC.Turn05_MurderInvest_SuspectHugo`
- `RiziaDLC.Turn05_MurderInvest_SuspectLucita`
- `RiziaDLC.Turn05_MurderInvest_SuspectPabel`
- `RiziaDLC.Turn05_MurderInvest_SuspectSal`
- `RiziaDLC.Turn05_MurderInvest_SuspectTitus`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Argument`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Lying`
- `RiziaDLCIsolated.Investigation_SuspectHugo_Timing`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal`
- `RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""So you *do* suspect foul play.""** | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[5]` **Lucita Azaro**: ""Unfortunately, yes. There are s..."<br>`[197]` **Titus Gordion**: ""Regrettably, yes. Multiple indi..." |
| `[8]` | **""You're conveniently forgetting yourself.""** | `[6]` **Lucita Azaro**: ""My initial list comprised five ..."<br>`[198]` **Titus Gordion**: ""My initial list of suspects com..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Lucita Azaro**: ""You wouldn't have asked me to i..."<br>`[226]` **Titus Gordion**: ""Presumably, you tasked me with ..." |
| `[9]` | **""I hope you've narrowed it down from there.""** | `[6]` **Lucita Azaro**: ""My initial list comprised five ..."<br>`[198]` **Titus Gordion**: ""My initial list of suspects com..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Lucita Azaro**: ""As a matter of fact, I have.""<br>`[404]` **Titus Gordion**: ""Yes, that's what I'm here to ta..." |
| `[10]` | **""My mother? How dare you insinuate such an awful thing.""** | `[6]` **Lucita Azaro**: ""My initial list comprised five ..."<br>`[198]` **Titus Gordion**: ""My initial list of suspects com..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Lucita Azaro**: ""I meant no offense. You instruc..."<br>`[400]` **Titus Gordion**: ""I meant no offense, sir. You to..." |
| `[12]` | **""Tell me what you’ve learned -- no matter how hard it is to hear.""** | `[11]` **Lucita Azaro**: ""You wouldn't have asked me to i..."<br>`[15]` **Lucita Azaro**: ""As a matter of fact, I have.""<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?"" |
| `[13]` | **""Alright, let's go down the list.""** | `[11]` **Lucita Azaro**: ""You wouldn't have asked me to i..."<br>`[15]` **Lucita Azaro**: ""As a matter of fact, I have.""<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?"" |
| `[14]` | **""I hope you're armed with substantial evidence.""** | `[11]` **Lucita Azaro**: ""You wouldn't have asked me to i..."<br>`[15]` **Lucita Azaro**: ""As a matter of fact, I have.""<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?"" |
| `[22]` | **""Tell me about my uncle. Why him?""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false` | *Brak zmian stanu* | `[277]` **Lucita Azaro**: ""Of all the individuals I've bee..."<br>`[763]` **Titus Gordion**: ""I don't truly believe your este..." |
| `[23]` | **""This is all too vague. I want cold, hard facts.""** | `[815]` **Lucita Azaro**: ""But as you well know, there was..."<br>`[816]` **Titus Gordion**: ""But King Valero's paranoia at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[298]` **Lucita Azaro**: ""If we keep pursuing this lead, ..."<br>`[302]` **Titus Gordion**: ""If we continue our investigatio..." |
| `[24]` | **""I seriously find it hard to believe that my uncle would murder his brother.""** | `[815]` **Lucita Azaro**: ""But as you well know, there was..."<br>`[816]` **Titus Gordion**: ""But King Valero's paranoia at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Lucita Azaro**: ""Believe it or not, but facts ar..."<br>`[292]` **Titus Gordion**: ""I only present the facts."" |
| `[25]` | **""If your account is accurate, we need to find out more.""** | `[815]` **Lucita Azaro**: ""But as you well know, there was..."<br>`[816]` **Titus Gordion**: ""But King Valero's paranoia at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Lucita Azaro**: ""I agree completely.""<br>`[287]` **Titus Gordion**: ""I share your sentiment."" |
| `[26]` | **""I'm glad you did. If what you're saying is true, we must handle this delicately.""** | `[303]` **Lucita Azaro**: ""Given the severity of accusing ..."<br>`[307]` **Titus Gordion**: ""Given the potential uproar from..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[28]` | **""Sorry, but what you're implying sounds too far-fetched.""** | `[303]` **Lucita Azaro**: ""Given the severity of accusing ..."<br>`[307]` **Titus Gordion**: ""Given the potential uproar from..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[29]` | **""Tell me all the details about my mother's whereabouts on the night my father pass..."** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false` | *Brak zmian stanu* | `[31]` **Lucita Azaro**: ""Your Majesty, our investigative..."<br>`[230]` **Titus Gordion**: ""Sir, our investigation has unco..." |
| `[30]` | **""Let's hear why you suspect Titus.""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true` | *Brak zmian stanu* | `[61]` **Lucita Azaro**: ""Yes, of course."" |
| `[33]` | **""That's good right?""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Lucita Azaro**: ""Not so fast, Your Majesty. This..."<br>`[241]` **Titus Gordion**: ""That depends on how you look at..." |
| `[34]` | **""Dastnurist? Are you sure?""** | `[425]` **Lucita Azaro**: ""A Dastnurist service.""<br>`[429]` **Titus Gordion**: ""But it wasn't a Wruhecist servi..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..." |
| `[35]` | **""If this is your idea of a joke, I'm not laughing.""** | `[425]` **Lucita Azaro**: ""A Dastnurist service.""<br>`[429]` **Titus Gordion**: ""But it wasn't a Wruhecist servi..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[252]` **Lucita Azaro**: ""It's no joke. Credible eyewitne..."<br>`[256]` **Titus Gordion**: ""It's no joke, sir. One of my Go..." |
| `[36]` | **""Well, they must have been mistaken.""** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>*(oraz 8 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Lucita Azaro**: ""No mistake. The information is ..."<br>`[430]` **Titus Gordion**: ""My guardsmen don't make mistakes."" |
| `[39]` | **""I find this accusation hard to believe. Titus has been nothing but loyal from day..."** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `Variable["RiziaDLC.Relations_Titus"] >= 0` | *Brak zmian stanu* | `[316]` **Lucita Azaro**: ""I understand. But my responsibi..." |
| `[41]` | **""He probably just went to the toilet.""** | `[914]` **Lucita Azaro**: ""The guardsman assumed Titus' du..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Lucita Azaro**: ""For half an hour?"" |
| `[42]` | **""He wasn't at his post? That's not like Titus at all.""** | `[914]` **Lucita Azaro**: ""The guardsman assumed Titus' du..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Lucita Azaro**: ""It is, which raises questions a..." |
| `[43]` | **""Did he or anyone else enter my father's room during that time?""** | `[914]` **Lucita Azaro**: ""The guardsman assumed Titus' du..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Lucita Azaro**: ""The other guardsman claims noth..." |
| `[50]` | **""Not in the palace? Then where the hell was she?""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""This may come as a shock, but i..."<br>`[246]` **Titus Gordion**: ""This may come as a surprise, bu..." |
| `[51]` | **""So my mother has her own share of secrets... guess that makes her human after all.""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[232]` **Lucita Azaro**: ""It certainly does. That said, y..."<br>`[236]` **Titus Gordion**: ""It certainly does. As for the n..." |
| `[52]` | **""He's often taken it upon himself to personally oversee the king's security.""** | `[40]` **Lucita Azaro**: ""On the night of King Valero's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Lucita Azaro**: ""Yes. He stuck to His Majesty li..." |
| `[53]` | **""Okay, I'm listening.""** | `[40]` **Lucita Azaro**: ""On the night of King Valero's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Lucita Azaro**: ""Titus guarded your father's qua..." |
| `[54]` | **""Yes. And?""** | `[40]` **Lucita Azaro**: ""On the night of King Valero's d..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Lucita Azaro**: ""There's nothing unusual about t..." |
| `[55]` | **""This only confirms my suspicions that he can't be trusted.""** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false` | *Brak zmian stanu* | `[317]` **Lucita Azaro**: ""Yes. We proceed with caution."" |
| `[56]` | **""This is troubling news indeed. I've always taken Titus to be a loyal protector.""** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `Variable["RiziaDLC.Relations_Titus"] >= 0` | *Brak zmian stanu* | `[315]` **Lucita Azaro**: ""I understand your reservations,..." |
| `[57]` | **""There must be some mistake. As far as I'm concerned he is the epitome of honor an..."** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `Variable["RiziaDLC.Relations_Titus"] >= 0` | *Brak zmian stanu* | `[314]` **Lucita Azaro**: ""Your admiration of Captain Gord..." |
| `[62]` | **""I want to know why you suspect Pabel.""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false` | *Brak zmian stanu* | `[65]` **Lucita Azaro**: ""As you know, it is my duty to e..."<br>`[340]` **Titus Gordion**: ""As you know, I've been tasked w..." |
| `[66]` | **""Just because he was unaccounted for doesn't mean he had anything to do with my fa..."** | `[68]` **Lucita Azaro**: ""During the time leading up to V..."<br>`[341]` **Titus Gordion**: ""Prior to Valero's passing, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Lucita Azaro**: ""I'm merely presenting the facts..."<br>`[343]` **Titus Gordion**: ""I'm merely presenting the facts..." |
| `[67]` | **""Unaccounted for? Please explain.""** | `[68]` **Lucita Azaro**: ""During the time leading up to V..."<br>`[341]` **Titus Gordion**: ""Prior to Valero's passing, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Lucita Azaro**: ""As you know, to have someone of..."<br>`[342]` **Titus Gordion**: ""Having someone of his status go..." |
| `[69]` | **""I'm sure there's a reasonable explanation.""** | `[68]` **Lucita Azaro**: ""During the time leading up to V..."<br>`[341]` **Titus Gordion**: ""Prior to Valero's passing, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Lucita Azaro**: ""Yes, however, it's unusual for ..."<br>`[347]` **Titus Gordion**: ""Yes, although it's uncommon for..." |
| `[70]` | **""That sounds very un-Pabel.""** | `[68]` **Lucita Azaro**: ""During the time leading up to V..."<br>`[341]` **Titus Gordion**: ""Prior to Valero's passing, ther..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lucita Azaro**: ""I'm sure. But for an individual..."<br>`[357]` **Titus Gordion**: ""I'm sure, but it's unusual for ..." |
| `[78]` | **""What aren't you telling me?""** | `[872]` **Narrator**: "There was a note of uncertainty ..."<br>`[873]` **Narrator**: "There was a strangely somber ton..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[533]` **Lucita Azaro**: ""Well, Your Majesty...""<br>`[537]` **Titus Gordion**: ""Well, sir, in the course of cha..." |
| `[84]` | **""Is that all? That doesn't prove he had a hand in anything.""** | `[815]` **Lucita Azaro**: ""But as you well know, there was..."<br>`[816]` **Titus Gordion**: ""But King Valero's paranoia at t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Lucita Azaro**: ""Forgive my bluntness, but what ..."<br>`[297]` **Titus Gordion**: ""I believe that such behavior is..." |
| `[85]` | **""You were right to come to me, however, we need something more concrete before jum..."** | `[303]` **Lucita Azaro**: ""Given the severity of accusing ..."<br>`[307]` **Titus Gordion**: ""Given the potential uproar from..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[86]` | **""Then I was correct in believing my father's untimely end was no accident.""** | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Lucita Azaro**: ""Yes, it seems you were right af..."<br>`[214]` **Titus Gordion**: ""That appears to be the case. I'..." |
| `[87]` | **""That quickly? Tell me more.""** | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Lucita Azaro**: ""I've identified several individ..."<br>`[216]` **Titus Gordion**: ""I've pinpointed several individ..." |
| `[88]` | **""An eyewitness? What led you to find that out?""** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[252]` **Lucita Azaro**: ""It's no joke. Credible eyewitne..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Lucita Azaro**: ""The investigation into her wher..." |
| `[89]` | **""If this information is inaccurate in any way, there will  be hell to pay.""** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[483]` **Lucita Azaro**: ""The gathered information has un..."<br>`[474]` **Titus Gordion**: ""The information is indeed accur..." |
| `[90]` | **""This is a lot to process. I'm having a hard time believing any of it.""** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[484]` **Lucita Azaro**: ""I understand how disconcerting ..."<br>`[475]` **Titus Gordion**: ""I know how disconcerting this n..."<br>*(oraz 1 innych odgałęzień)* |
| `[91]` | **""My God... A Dastnurist service? How can this be?""** | `[425]` **Lucita Azaro**: ""A Dastnurist service.""<br>`[429]` **Titus Gordion**: ""But it wasn't a Wruhecist servi..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[257]` **Lucita Azaro**: ""All I know is that multiple eye..."<br>`[261]` **Titus Gordion**: ""All I know is that one of my Go..." |
| `[95]` | **""I want to hear about what you found on the Grand Wiseman.""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false` | *Brak zmian stanu* | `[96]` **Lucita Azaro**: ""Your Majesty, multiple sources ..."<br>`[323]` **Titus Gordion**: ""Your Majesty, I myself admitted..." |
| `[98]` | **""Makes sense. He had plenty to atone for.""** | `[824]` **Lucita Azaro**: ""According to the Grand Wiseman ..."<br>`[825]` **Titus Gordion**: ""According to the Grand Wiseman ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""What's interesting is that asid..."<br>`[329]` **Titus Gordion**: ""What's interesting is that asid..." |
| `[109]` | **""How wise of my father. I hope he found the serenity he was seeking.""** | `[824]` **Lucita Azaro**: ""According to the Grand Wiseman ..."<br>`[825]` **Titus Gordion**: ""According to the Grand Wiseman ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""What's interesting is that asid..."<br>`[329]` **Titus Gordion**: ""What's interesting is that asid..." |
| `[110]` | **""My father turned towards God... and away from everyone else.""** | `[824]` **Lucita Azaro**: ""According to the Grand Wiseman ..."<br>`[825]` **Titus Gordion**: ""According to the Grand Wiseman ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Lucita Azaro**: ""It's not surprising. God forgiv..."<br>`[325]` **Titus Gordion**: ""Religion is often a source of c..." |
| `[116]` | **""Here are the next steps for your investigation.""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true` | *Brak zmian stanu* | `[866]` **Narrator**: "Lucita leaned forward, listening..."<br>`[867]` **Narrator**: "Titus stood at full attention, a..." |
| `[117]` | **""Hugo is obviously our primary suspect, so focus your investigation on him.""** | `[866]` **Narrator**: "Lucita leaned forward, listening..."<br>`[867]` **Narrator**: "Titus stood at full attention, a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] ...` | `[128]` **Lucita Azaro**: ""Consider it already done.""<br>`[181]` **Titus Gordion**: ""Consider it handled."" |
| `[118]` | **""Discreetly continue your investigation into Titus. He has eyes and ears everywhere.""** | `[866]` **Narrator**: "Lucita leaned forward, listening..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"]...` | `[125]` **Lucita Azaro**: ""Yes, Your Majesty. I'll get my ..." |
| `[119]` | **""This investigation has gone as far as it can go. Cease all further efforts, effec..."** | `[866]` **Narrator**: "Lucita leaned forward, listening..."<br>`[867]` **Narrator**: "Titus stood at full attention, a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateNoone"]...` | `[127]` **Lucita Azaro**: ""Very well. But for the record, ..."<br>`[180]` **Titus Gordion**: ""Very well. For the record, I st..." |
| `[120]` | **""I hate to say it, but keep looking into Sal. There's more to the Grand Wiseman th..."** | `[866]` **Narrator**: "Lucita leaned forward, listening..."<br>`[867]` **Narrator**: "Titus stood at full attention, a..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] =...` | `[126]` **Lucita Azaro**: ""Very good, Your Majesty. Rest a..."<br>`[179]` **Titus Gordion**: ""Very good, Your Majesty. I'll w..." |
| `[124]` | **""Keep digging into Sal. There's more to the Wiseman than he's letting on.""** | `[866]` **Narrator**: "Lucita leaned forward, listening..."<br>`[867]` **Narrator**: "Titus stood at full attention, a..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] =...` | `[126]` **Lucita Azaro**: ""Very good, Your Majesty. Rest a..."<br>`[179]` **Titus Gordion**: ""Very good, Your Majesty. I'll w..." |
| `[133]` | **""I had a funny feeling about that Golden Guardsman. There was something about him ..."** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false` | *Brak zmian stanu* | `[318]` **Lucita Azaro**: ""I've had my reservations about ..." |
| `[134]` | **""If what you're saying is true, this angers me to no end.""** | `[38]` **Lucita Azaro**: ""Your guardsman's behavior was s..." | `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false` | *Brak zmian stanu* | `[319]` **Lucita Azaro**: ""I share your frustration. If th..." |
| `[138]` | **""I still haven't found a setting befitting the beauty and majesty of the Duchess o..."** | `[137]` **Lucita Azaro**: ""Investigation aside... I would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Lucita Azaro**: ""Leave that to me, then."" |
| `[139]` | **""The King of Rizia has no time for such frivolities. And neither do you, Duchess.""** | `[137]` **Lucita Azaro**: ""Investigation aside... I would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Lucita Azaro**: ""Yes... of course. I'll look for..." |
| `[140]` | **""I haven't forgotten. But we've both been busy.""** | `[137]` **Lucita Azaro**: ""Investigation aside... I would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lucita Azaro**: ""I'm still looking forward to th..." |
| `[154]` | **""You've already uncovered enough unpleasant secrets about the people around me. I'..."** | `[127]` **Lucita Azaro**: ""Very well. But for the record, ..."<br>`[180]` **Titus Gordion**: ""Very well. For the record, I st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Lucita gave a slight bow."<br>`[194]` **Narrator**: "Titus bowed and bid me good day ..."<br>*(oraz 1 innych odgałęzień)* |
| `[155]` | **""I'll keep all of what you said in mind. But I don't see grounds for a full-blown ..."** | `[127]` **Lucita Azaro**: ""Very well. But for the record, ..."<br>`[180]` **Titus Gordion**: ""Very well. For the record, I st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Lucita gave a slight bow."<br>`[194]` **Narrator**: "Titus bowed and bid me good day ..."<br>*(oraz 1 innych odgałęzień)* |
| `[156]` | **""For the record, I don't. My father was an old, sick man. That's all there is to it.""** | `[127]` **Lucita Azaro**: ""Very well. But for the record, ..."<br>`[180]` **Titus Gordion**: ""Very well. For the record, I st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "Lucita gave a slight bow."<br>`[194]` **Narrator**: "Titus bowed and bid me good day ..."<br>*(oraz 1 innych odgałęzień)* |
| `[271]` | **""Dastnurity aside, it's a relief to hear she's no longer a suspect.""** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[272]` | **""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering. It's ..."** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[273]` | **""Your slow approach to sharing crucial information is frustrating. Get to the poin..."** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[274]` | **""Then I suppose I'll have to find another suspect.""** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[365]` | **""Let's hear why you suspect Lucita.""** | `[17]` **Lucita Azaro**: ""With whom should I begin?""<br>`[200]` **Titus Gordion**: ""Starting with whom?""<br>*(oraz 31 innych węzłów)* | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true` | *Brak zmian stanu* | `[369]` **Titus Gordion**: ""My suspicions stem from Lucita ..." |
| `[370]` | **""I see... Go on.""** | `[369]` **Titus Gordion**: ""My suspicions stem from Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[644]` **Titus Gordion**: ""As is my duty, I was standing g..." |
| `[372]` | **""You're implying they were secret lovers or something?""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[376]` **Titus Gordion**: ""I would never suggest such a th..." |
| `[373]` | **""Allegedly? You were guarding my father's chambers. Wouldn't you know if she visit..."** | `[369]` **Titus Gordion**: ""My suspicions stem from Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[644]` **Titus Gordion**: ""As is my duty, I was standing g..." |
| `[374]` | **""Well, what of it?""** | `[369]` **Titus Gordion**: ""My suspicions stem from Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[644]` **Titus Gordion**: ""As is my duty, I was standing g..." |
| `[375]` | **""What was she doing in there?""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Titus Gordion**: ""That's what concerned me."" |
| `[378]` | **""An order? What for?""** | `[377]` **Titus Gordion**: ""When I questioned the guardsman..."<br>`[762]` **Titus Gordion**: ""In his defense, he claimed that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[381]` **Titus Gordion**: ""I suspect she may have been car..." |
| `[379]` | **""And you believed him?""** | `[377]` **Titus Gordion**: ""When I questioned the guardsman..."<br>`[762]` **Titus Gordion**: ""In his defense, he claimed that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Titus Gordion**: ""I have no reason not to. Being ..." |
| `[380]` | **""If true, we need to verify its authenticity.""** | `[377]` **Titus Gordion**: ""When I questioned the guardsman..."<br>`[762]` **Titus Gordion**: ""In his defense, he claimed that..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Titus Gordion**: ""My thoughts exactly."" |
| `[384]` | **""This is deeply troubling. What could Lucita be hiding?""** | `[383]` **Titus Gordion**: ""When we searched your father's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Titus Gordion**: ""That's a question I hope to fin..." |
| `[385]` | **""I have a hard time wrapping my head around Lucita doing something so drastic.""** | `[383]` **Titus Gordion**: ""When we searched your father's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[390]` **Titus Gordion**: ""People can surprise us, for bet..." |
| `[386]` | **""I always suspected that, when it came to the throne, House Azaro was out for blood.""** | `[383]` **Titus Gordion**: ""When we searched your father's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[646]` **Titus Gordion**: ""I can't attest to that. I'm onl..." |
| `[392]` | **""Keep looking into Lucita's motivation. You might be onto something there.""** | `[867]` **Narrator**: "Titus stood at full attention, a..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"...` | `[394]` **Titus Gordion**: ""Considered it already handled."" |
| `[406]` | **"Say nothing."** | `[423]` **Titus Gordion**: ""The one concerning His Majesty,..."<br>`[684]` **Narrator**: "Business only, it seemed."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false` | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." |
| `[407]` | **""Lucita. To what do I owe this pleasure?""** | `[680]` **Lucita Azaro**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Lucita Azaro**: ""'This pleasure' happens to be t..." |
| `[408]` | **""Yes? Something on your mind?""** | `[680]` **Lucita Azaro**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[412]` **Lucita Azaro**: ""Only that I may have some infor..." |
| `[409]` | **""Please tell me you're here because you have information on my father's passing.""** | `[680]` **Lucita Azaro**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[410]` **Lucita Azaro**: ""Yes, I have, in fact, made sign..." |
| `[411]` | **""Oh, do tell! I'm eager to know what you've uncovered.""** | `[423]` **Titus Gordion**: ""The one concerning His Majesty,..."<br>`[684]` **Narrator**: "Business only, it seemed."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false` | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." |
| `[413]` | **""Really? In that case, let's hear it.""** | `[423]` **Titus Gordion**: ""The one concerning His Majesty,..."<br>`[684]` **Narrator**: "Business only, it seemed."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false` | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." |
| `[414]` | **""Well, what are you waiting for? Spit it out.""** | `[423]` **Titus Gordion**: ""The one concerning His Majesty,..."<br>`[684]` **Narrator**: "Business only, it seemed."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false` | *Brak zmian stanu* | `[3]` **Lucita Azaro**: ""Let me start by saying that I'v..."<br>`[196]` **Titus Gordion**: ""Allow me to begin by stating th..." |
| `[419]` | **""What are you doing lurking in the dark?""** | `[418]` **Titus Gordion**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[687]` **Titus Gordion**: ""I apologize if I startled you."" |
| `[420]` | **""To what do I owe the pleasure, Captain?""** | `[418]` **Titus Gordion**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Titus Gordion**: ""I'm here to discuss that *perso..." |
| `[421]` | **""Ah, it's you. Is everything all right?""** | `[418]` **Titus Gordion**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Titus Gordion**: ""Everything's fine. No need to w..." |
| `[422]` | **""If you have something to report, make it quick.""** | `[418]` **Titus Gordion**: ""Good evening, Your Majesty."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[686]` **Titus Gordion**: ""Gladly."" |
| `[435]` | **""Looks like our next family chat is about to get interesting.""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[436]` **Lucita Azaro**: ""It could lead to an even more i..."<br>`[440]` **Titus Gordion**: ""It could lead to an even more i..." |
| `[443]` | **""Okay, I'm listening...""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Lucita Azaro**: ""Brace yourself, but it turns ou..."<br>`[451]` **Titus Gordion**: ""As it happens, she was particip..." |
| `[458]` | **""Well, that's certainly not what I expected to hear. You can verify the accuracy o..."** | `[441]` **Lucita Azaro**: ""...attending a clandestine Dast..."<br>`[442]` **Titus Gordion**: ""...attending a Dastnurist relig..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Lucita Azaro**: ""Without question. Multiple eyew..."<br>`[463]` **Titus Gordion**: ""Absolutely. One of my Golden Gu..." |
| `[469]` | **""I must admit I'm quite surprised by this revelation. It could spark quite a scand..."** | `[441]` **Lucita Azaro**: ""...attending a clandestine Dast..."<br>`[442]` **Titus Gordion**: ""...attending a Dastnurist relig..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[464]` **Lucita Azaro**: ""Which is why I came to you as s..."<br>`[468]` **Titus Gordion**: ""All the more reason I thought i..." |
| `[476]` | **""And how reliable is this Golden Guardsman of yours?""** | `[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>`[256]` **Titus Gordion**: ""It's no joke, sir. One of my Go..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[479]` **Titus Gordion**: ""The individual of which I speak..." |
| `[489]` | **""As a man of faith, forgive me when I say, I have a hard time relying solely on th..."** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>*(oraz 8 innych węzłów)* | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[484]` **Lucita Azaro**: ""I understand how disconcerting ..."<br>`[475]` **Titus Gordion**: ""I know how disconcerting this n..."<br>*(oraz 1 innych odgałęzień)* |
| `[493]` | **""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering!""** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[495]` | **""Well then, I guess there's no need to place Mother in the royal dungeon. I suppos..."** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[502]` | **""Your meticulous approach to sharing important information is valued, but please a..."** | `[275]` **Lucita Azaro**: ""Needless to say, this proves yo..."<br>`[276]` **Titus Gordion**: ""Needless to say, this establish..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = ...` | `[22]` **Player_Romus**: ""Tell me about my uncle. Why him?""<br>`[29]` **Player_Romus**: ""Tell me all the details about m..."<br>*(oraz 5 innych odgałęzień)* |
| `[503]` | **""The plot thickens.""** | `[872]` **Narrator**: "There was a note of uncertainty ..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[528]` **Lucita Azaro**: ""Of course, Your Majesty. We're ..."<br>`[532]` **Titus Gordion**: ""I'm pleased to have put your su..." |
| `[504]` | **""Hmm, so he won't be the star of our treasonous play after all. The plot thickens.""** | `[872]` **Narrator**: "There was a note of uncertainty ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[528]` **Lucita Azaro**: ""Of course, Your Majesty. We're ..."<br>`[532]` **Titus Gordion**: ""I'm pleased to have put your su..." |
| `[505]` | **""Why didn't you say so in the first place?""** | `[872]` **Narrator**: "There was a note of uncertainty ..."<br>`[873]` **Narrator**: "There was a strangely somber ton..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[523]` **Lucita Azaro**: ""My apologies for the delay, You..."<br>`[527]` **Titus Gordion**: ""My apologies for the delay, sir."" |
| `[506]` | **""Well, that is good news. You can lead with that next time.""** | `[872]` **Narrator**: "There was a note of uncertainty ..."<br>`[873]` **Narrator**: "There was a strangely somber ton..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[523]` **Lucita Azaro**: ""My apologies for the delay, You..."<br>`[527]` **Titus Gordion**: ""My apologies for the delay, sir."" |
| `[513]` | **""The truth always prevails, as our faith teaches us. Pabel's innocence is a testam..."** | `[872]` **Narrator**: "There was a note of uncertainty ..."<br>`[873]` **Narrator**: "There was a strangely somber ton..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[518]` **Lucita Azaro**: ""Indeed, it's heartening to see ..."<br>`[522]` **Titus Gordion**: ""Indeed. The truth always prevai..." |
| `[514]` | **""The truth always prevails. Pabel's innocence is a testament to this.""** | `[872]` **Narrator**: "There was a note of uncertainty ..."<br>`[873]` **Narrator**: "There was a strangely somber ton..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[518]` **Lucita Azaro**: ""Indeed, it's heartening to see ..."<br>`[522]` **Titus Gordion**: ""Indeed. The truth always prevai..." |
| `[538]` | **""That's ridiculous. You will tell me at once.""** | `[874]` **Lucita Azaro**: ""Perhaps you're better off not k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[882]` **Lucita Azaro**: ""Very well. Though this has abso..." |
| `[539]` | **""Why not? Was he involved in illegal activity?""** | `[874]` **Lucita Azaro**: ""Perhaps you're better off not k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[876]` **Lucita Azaro**: ""In a manner of speaking..."" |
| `[540]` | **""All right, let's hear it.""** | `[537]` **Titus Gordion**: ""Well, sir, in the course of cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[893]` **Narrator**: "He drew in a breath through clen..." |
| `[548]` | **""That old dog… Good for him! Who was the lucky lady?""** | `[702]` **Titus Gordion**: "“Some suspect him of having a se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Lucita Azaro**: ""More like lucky gentleman, if y..."<br>`[565]` **Titus Gordion**: ""Actually, sir, he wasn't with a..." |
| `[549]` | **""If my butler had a secret lover, I would know.""** | `[701]` **Lucita Azaro**: ""The scuttlebutt has it that he ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[703]` **Lucita Azaro**: ""This was months before your cor..."<br>`[704]` **Titus Gordion**: ""This occurred months before you..." |
| `[550]` | **""How very unprofessional -- not to mention, inappropriate. With whom was he engage..."** | `[701]` **Lucita Azaro**: ""The scuttlebutt has it that he ..."<br>`[702]` **Titus Gordion**: "“Some suspect him of having a se..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..." |
| `[557]` | **""In the wine cellar? With whom was he engaged in this… 'rendezvous?'""** | `[701]` **Lucita Azaro**: ""The scuttlebutt has it that he ..."<br>`[702]` **Titus Gordion**: "“Some suspect him of having a se..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..." |
| `[558]` | **""My faith guides me to condemn such actions. I'm highly disappointed in Pabel's be..."** | `[701]` **Lucita Azaro**: ""The scuttlebutt has it that he ..."<br>`[702]` **Titus Gordion**: "“Some suspect him of having a se..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[607]` **Lucita Azaro**: ""The other individual was suppos..."<br>`[611]` **Titus Gordion**: ""The other person was supposedly..." |
| `[559]` | **""I'm highly disappointed in Pabel's behavior.""** | `[701]` **Lucita Azaro**: ""The scuttlebutt has it that he ..."<br>`[702]` **Titus Gordion**: "“Some suspect him of having a se..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[607]` **Lucita Azaro**: ""The other individual was suppos..."<br>`[611]` **Titus Gordion**: ""The other person was supposedly..." |
| `[560]` | **""Pabel and I are old friends, so I'll bring this up with him myself. No need to dr..."** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true` | *Brak zmian stanu* | `[582]` **Lucita Azaro**: ""That's your prerogative.""<br>`[583]` **Titus Gordion**: ""Certainly, sir."" |
| `[568]` | **""Let's keep this between us to avoid it from becoming public and causing a scandal.""** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Lucita Azaro**: ""I won’t tell anyone. You have m..."<br>`[578]` **Titus Gordion**: ""I won't disclose this to anyone."" |
| `[569]` | **""A pervert residing in front of my very nose. Keep an eye on him.""** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[587]` **Lucita Azaro**: ""Very well, Your Majesty.""<br>`[588]` **Titus Gordion**: ""Very well, sir."" |
| `[570]` | **""Keep an eye on him. The last thing I need is my butler flaunting his criminal lif..."** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[587]` **Lucita Azaro**: ""Very well, Your Majesty.""<br>`[588]` **Titus Gordion**: ""Very well, sir."" |
| `[595]` | **""As long as it doesn't interfere with his duties, I don’t see an issue. Let's stay..."** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[596]` **Lucita Azaro**: ""You're right. Pabel's love life..."<br>`[600]` **Titus Gordion**: ""Of course. We shouldn't lose si..." |
| `[612]` | **""I’ll see to it that she’s reported to the Cantuavos for her indiscretion.""** | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[620]` **Lucita Azaro**: ""Not 'she.'""<br>`[624]` **Titus Gordion**: ""Actually, sir, the 'she' is a *..." |
| `[613]` | **""Her heedless and disrespectful actions should be conveyed to the Cantuavos.""** | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucita Azaro**: ""Not 'her.'""<br>`[619]` **Titus Gordion**: ""Actually, sir, the 'her' is a *..." |
| `[614]` | **""She should be fired, immediately.""** | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[620]` **Lucita Azaro**: ""Not 'she.'""<br>`[624]` **Titus Gordion**: ""Actually, sir, the 'she' is a *..." |
| `[630]` | **""What?! I had no idea.""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true` | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[631]` | **""As long as Pabel didn't kill my father, I don't care what he was doing that night.""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[632]` | **""I knew it.""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false` | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[633]` | **""Well, this just keeps getting better and better.""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[647]` | **""I do hope you're not suggesting they were doing something... impure.""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[376]` **Titus Gordion**: ""I would never suggest such a th..." |
| `[651]` | **""So you left your post while on duty? Not the best way to start your case.""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[652]` **Titus Gordion**: ""And I take full responsibility ..." |
| `[655]` | **""Sounds like a lot of speculation and no sustenance.""** | `[383]` **Titus Gordion**: ""When we searched your father's ..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[656]` **Titus Gordion**: ""I'm only presenting what I've b..." |
| `[658]` | **""Sounds like a lot of speculation and no sustenance. I was expecting more from you.""** | `[383]` **Titus Gordion**: ""When we searched your father's ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[656]` **Titus Gordion**: ""I'm only presenting what I've b..." |
| `[726]` | **""No need to raise an alarm because of some palace scuttlebutt. I'll ask Pabel abou..."** | `[716]` **Titus Gordion**: ""But if we catch him in a simila..."<br>`[722]` **Lucita Azaro**: ""But if we catch him in a simila..." | `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false` | *Brak zmian stanu* | `[582]` **Lucita Azaro**: ""That's your prerogative.""<br>`[583]` **Titus Gordion**: ""Certainly, sir."" |
| `[727]` | **""Not in the palace? Well, if she wasn't here, then where was she?""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[242]` **Lucita Azaro**: ""This may come as a shock, but i..."<br>`[246]` **Titus Gordion**: ""This may come as a surprise, bu..." |
| `[728]` | **""Really? Wouldn't have guessed that Mother was still full of surprises.""** | `[915]` **Lucita Azaro**: ""In between, however, Madam Este..."<br>`[916]` **Titus Gordion**: ""In between, however, Madam Este..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[732]` **Lucita Azaro**: ""Speaking of surprises, you'll b..."<br>`[733]` **Titus Gordion**: ""Speaking of surprises, you'll w..." |
| `[734]` | **""You're kidding, right?""** | `[425]` **Lucita Azaro**: ""A Dastnurist service.""<br>`[429]` **Titus Gordion**: ""But it wasn't a Wruhecist servi..."<br>*(oraz 4 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[252]` **Lucita Azaro**: ""It's no joke. Credible eyewitne..."<br>`[256]` **Titus Gordion**: ""It's no joke, sir. One of my Go..." |
| `[735]` | **""A Dastnurist service? How can this be?""** | `[425]` **Lucita Azaro**: ""A Dastnurist service.""<br>`[429]` **Titus Gordion**: ""But it wasn't a Wruhecist servi..."<br>*(oraz 2 innych węzłów)* | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[257]` **Lucita Azaro**: ""All I know is that multiple eye..."<br>`[261]` **Titus Gordion**: ""All I know is that one of my Go..." |
| `[736]` | **""A part of me hopes this information is inaccurate.""** | `[247]` **Lucita Azaro**: ""We managed to find credible eye..."<br>`[251]` **Titus Gordion**: ""One of my Golden Guards, who wa..."<br>*(oraz 8 innych węzłów)* | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[483]` **Lucita Azaro**: ""The gathered information has un..."<br>`[474]` **Titus Gordion**: ""The information is indeed accur..." |
| `[755]` | **""What? Please tell me you fired him.""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[756]` **Titus Gordion**: ""Of course I did."" |
| `[760]` | **""His head will roll for that blunder.""** | `[371]` **Titus Gordion**: ""When I returned, he informed me..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[761]` **Titus Gordion**: ""He has been dishonorably discha..." |
| `[766]` | **""An argument? About what?""** | `[764]` **Titus Gordion**: ""I did not listen in to their co..."<br>`[765]` **Lucita Azaro**: ""Your Golden Guardsman claims no..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false` | *Brak zmian stanu* | `[776]` **Lucita Azaro**: ""Apparently, the King shouted, '..."<br>`[780]` **Titus Gordion**: ""Apparently, the King shouted ou..." |
| `[767]` | **""Dinner was hours before the time of death. How could Hugo have killed him?""** | `[764]` **Titus Gordion**: ""I did not listen in to their co..."<br>`[765]` **Lucita Azaro**: ""Your Golden Guardsman claims no..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false` | *Brak zmian stanu* | `[770]` **Lucita Azaro**: ""He could have slipped him a slo..."<br>`[775]` **Titus Gordion**: ""He could have slipped him a slo..." |
| `[768]` | **""Are you saying Titus was lying?""** | `[764]` **Titus Gordion**: ""I did not listen in to their co..."<br>`[765]` **Lucita Azaro**: ""Your Golden Guardsman claims no..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true` | *Brak zmian stanu* | `[774]` **Lucita Azaro**: ""Hard to say. He may have though..." |
| `[769]` | **""Could this maid have been lying?""** | `[764]` **Titus Gordion**: ""I did not listen in to their co..."<br>`[765]` **Lucita Azaro**: ""Your Golden Guardsman claims no..."<br>*(oraz 6 innych węzłów)* | `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true` | *Brak zmian stanu* | `[783]` **Titus Gordion**: ""I don't see why she would have ..." |
| `[806]` | **""Enough about the maid. Is there any other reason to suspect Hugo?""** | `[764]` **Titus Gordion**: ""I did not listen in to their co..."<br>`[765]` **Lucita Azaro**: ""Your Golden Guardsman claims no..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Lucita Azaro**: ""Well...""<br>`[813]` **Titus Gordion**: ""Well..."" |
| `[817]` | **""I'm not sure I believe that.""** | `[824]` **Lucita Azaro**: ""According to the Grand Wiseman ..."<br>`[825]` **Titus Gordion**: ""According to the Grand Wiseman ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lucita Azaro**: ""What's interesting is that asid..."<br>`[329]` **Titus Gordion**: ""What's interesting is that asid..." |
| `[826]` | **""He wanted his enlightenment straight from the tap. I don't blame him.""** | `[100]` **Lucita Azaro**: ""He was even skipping services s..."<br>`[336]` **Titus Gordion**: ""He was even skipping services s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[837]` **Lucita Azaro**: ""Maybe... but I believe this inc..."<br>`[839]` **Titus Gordion**: ""I nonetheless believe this inco..." |
| `[827]` | **""Are you implying that the two of them were planning something?""** | `[100]` **Lucita Azaro**: ""He was even skipping services s..."<br>`[336]` **Titus Gordion**: ""He was even skipping services s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[844]` **Lucita Azaro**: ""I don't know. But the inconsist..."<br>`[846]` **Titus Gordion**: ""It strikes me as unlikely. But ..." |
| `[831]` | **""Blasphemy! I myself have attended every single service since my coronation.""** | `[100]` **Lucita Azaro**: ""He was even skipping services s..."<br>`[336]` **Titus Gordion**: ""He was even skipping services s..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[852]` **Lucita Azaro**: ""I'm impressed. I could never si..."<br>`[851]` **Titus Gordion**: ""Yes, your commitment to spiritu..." |
| `[832]` | **""That proves nothing. I myself skip services all the time.""** | `[100]` **Lucita Azaro**: ""He was even skipping services s..."<br>`[336]` **Titus Gordion**: ""He was even skipping services s..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[856]` **Lucita Azaro**: ""Same here.""<br>`[857]` **Titus Gordion**: ""The Lord will forgive you. You'..." |
| `[833]` | **""The Grand Wiseman is one of the most respected figures in our kingdom. We should ..."** | `[100]` **Lucita Azaro**: ""He was even skipping services s..."<br>`[336]` **Titus Gordion**: ""He was even skipping services s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[858]` **Lucita Azaro**: ""I am hesitant to cast blame on ..."<br>`[859]` **Titus Gordion**: ""I do not want to soil the Grand..." |
| `[868]` | **""Right. Dinner and a movie, then?""** | `[137]` **Lucita Azaro**: ""Investigation aside... I would ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[869]` **Lucita Azaro**: ""I can do better than that."" |
| `[875]` | **""If you think I shouldn't know, I trust you. Spare me the details.""** | `[874]` **Lucita Azaro**: ""Perhaps you're better off not k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[881]` **Narrator**: "She nodded forcefully." |
| `[877]` | **""Actually, forget it. I don't want to know. Case closed on Pabel.""** | `[876]` **Lucita Azaro**: ""In a manner of speaking..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[878]` **Narrator**: "She nodded forcefully." |
| `[883]` | **""Saying that has only made me more curious.""** | `[874]` **Lucita Azaro**: ""Perhaps you're better off not k..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[884]` **Narrator**: "She shook her head ruefully." |
| `[885]` | **""All right, now you definitely have to tell me.""** | `[876]` **Lucita Azaro**: ""In a manner of speaking..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[884]` **Narrator**: "She shook her head ruefully." |
| `[889]` | **""I think I know what you're getting at. I've already given him a talking-to about ..."** | `[876]` **Lucita Azaro**: ""In a manner of speaking..."" | `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true` | *Brak zmian stanu* | `[890]` **Narrator**: "She nodded forcefully." |
| `[892]` | **""Good interesting, or bad interesting?""** | `[537]` **Titus Gordion**: ""Well, sir, in the course of cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[894]` **Titus Gordion**: ""I'll let you be the judge."" |
| `[895]` | **""If it's not germane to the case, I don't want to hear about it.""** | `[537]` **Titus Gordion**: ""Well, sir, in the course of cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[896]` **Titus Gordion**: ""Really, Your Majesty? This conc..." |
| `[900]` | **""Yes, gladly. I knew Pabel was innocent all along.""** | `[899]` **Lucita Azaro**: ""Let's move on, shall we?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[890]` **Narrator**: "She nodded forcefully." |
| `[907]` | **""My butler lies with men? He must repent his sodomous ways before it's too late!""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true`<br>`(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false` | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[911]` | **""But that's disgusting. I let him dress me and everything.""** | `[901]` **Narrator**: "She peered at me closely, trying..."<br>`[902]` **Narrator**: "He peered at me closely, trying ..." | `Variable["RiziaDLC.Relations_Pabel"] <= 0` | *Brak zmian stanu* | `[567]` **Titus Gordion**: ""We didn't turn up any conclusiv..."<br>`[566]` **Lucita Azaro**: ""I have to confess, I had a feel..."<br>*(oraz 1 innych odgałęzień)* |
| `[918]` | **""Meh. Her behavior isn’t worth bringing to the Cantuavos’ attention.""** | `[602]` **Lucita Azaro**: ""A delivery person from Cantuavo..."<br>`[606]` **Titus Gordion**: ""As it happens, it was a deliver..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucita Azaro**: ""Not 'her.'""<br>`[619]` **Titus Gordion**: ""Actually, sir, the 'her' is a *..." |

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
  - -> `[919]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Investigating the former king’s suspicio..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Lucita Azaro**
> ""Let me start by saying that I've made significant progress into who may be responsible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""That quickly? Tell me more.""*)
  - -> `[86]` (*Player_Romus: ""Then I was correct in believing my father's untimely end..."*)
  - -> `[4]` (*Player_Romus: ""So you *do* suspect foul play.""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you *do* suspect foul play.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucita Azaro), `[196]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[5]`
Mówca: **Lucita Azaro**
> ""Unfortunately, yes. There are several individuals I find highly suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[6]`
Mówca: **Lucita Azaro**
> ""My initial list comprised five individuals: Captain Gordion, Grand Wiseman Ignacius, your butler, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""My mother? How dare you insinuate such an awful thing.""*)
  - -> `[9]` (*Player_Romus: ""I hope you've narrowed it down from there.""*)
  - -> `[8]` (*Player_Romus: ""You're conveniently forgetting yourself.""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Lucita discreetly glanced around as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false"*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're conveniently forgetting yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucita Azaro), `[198]` (Titus Gordion), `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you've narrowed it down from there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucita Azaro), `[198]` (Titus Gordion), `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother? How dare you insinuate such an awful thing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Lucita Azaro), `[198]` (Titus Gordion), `[750]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[11]`
Mówca: **Lucita Azaro**
> ""You wouldn't have asked me to investigate if you thought I was guilty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me what you’ve learned -- no matter how hard it is to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucita Azaro), `[15]` (Lucita Azaro), `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright, let's go down the list.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucita Azaro), `[15]` (Lucita Azaro), `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're armed with substantial evidence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[11]` (Lucita Azaro), `[15]` (Lucita Azaro), `[16]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[15]`
Mówca: **Lucita Azaro**
> ""As a matter of fact, I have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[16]`
Mówca: **Lucita Azaro**
> ""I meant no offense. You instructed me to investigate everyone present at the palace during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[17]`
Mówca: **Lucita Azaro**
> ""With whom should I begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Suspects Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == false"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == false"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && Riz..."*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && Ri..."*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal == false"*)
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false && RiziaDL..."*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || Rizia..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == false"*)
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == false)"*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""Tell me about my uncle. Why him?""*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about my uncle. Why him?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all too vague. I want cold, hard facts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[815]` (Lucita Azaro), `[816]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I seriously find it hard to believe that my uncle would murder his brother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[815]` (Lucita Azaro), `[816]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If your account is accurate, we need to find out more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[815]` (Lucita Azaro), `[816]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you did. If what you're saying is true, we must handle this delicately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Lucita Azaro), `[307]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo = true;"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but what you're implying sounds too far-fetched.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Lucita Azaro), `[307]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo = true;"*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me all the details about my mother's whereabouts on the night my father passed.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear why you suspect Titus.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lucita Azaro: ""Yes, of course.""*)

### Węzeł `[31]`
Mówca: **Lucita Azaro**
> ""Your Majesty, our investigative efforts have unveiled a rather unexpected revelation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucita Azaro: ""The Queen Mother was at dinner that night. Later, as ver..."*)

### Węzeł `[32]`
Mówca: **Lucita Azaro**
> ""The Queen Mother was at dinner that night. Later, as verified by Titus Gordion, she opened the door to your father's chambers and immediately alerted the Golden Guard that he was unconscious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Lucita Azaro: ""In between, however, Madam Estela was not in the Palace ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's good right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dastnurist? Are you sure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[425]` (Lucita Azaro), `[429]` (Titus Gordion), `[441]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this is your idea of a joke, I'm not laughing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[425]` (Lucita Azaro), `[429]` (Titus Gordion), `[441]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, they must have been mistaken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[251]` (Titus Gordion), `[252]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[38]`
Mówca: **Lucita Azaro**
> ""Your guardsman's behavior was suspicious, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 0"*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I find this accusation hard to believe. Titus has been nothing but loyal from day one.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 0`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lucita Azaro: ""I understand. But my responsibility is to unveil the tru..."*)

### Węzeł `[40]`
Mówca: **Lucita Azaro**
> ""On the night of King Valero's death, Captain Gordion was charged with guarding his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""Yes. And?""*)
  - -> `[52]` (*Player_Romus: ""He's often taken it upon himself to personally oversee t..."*)
  - -> `[53]` (*Player_Romus: ""Okay, I'm listening.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He probably just went to the toilet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[914]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Lucita Azaro: ""For half an hour?""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wasn't at his post? That's not like Titus at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[914]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Lucita Azaro: ""It is, which raises questions about his loyalty and the ..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did he or anyone else enter my father's room during that time?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[914]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Lucita Azaro: ""The other guardsman claims nothing happened. But he coul..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela == false"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == false)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Tell me all the details about my mother's whereabouts on..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectEstela == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && Riz..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && R..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""Let's hear why you suspect Titus.""*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectTitus == false && RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the palace? Then where the hell was she?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So my mother has her own share of secrets... guess that makes her human after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's often taken it upon himself to personally oversee the king's security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Lucita Azaro: ""Yes. He stuck to His Majesty like glue, much as he curre..."*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Lucita Azaro: ""Titus guarded your father's quarters almost every night...."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lucita Azaro: ""There's nothing unusual about that fact.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This only confirms my suspicions that he can't be trusted.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Lucita Azaro: ""Yes. We proceed with caution.""*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is troubling news indeed. I've always taken Titus to be a loyal protector.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 0`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Lucita Azaro: ""I understand your reservations, but my duty is to uncove..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There must be some mistake. As far as I'm concerned he is the epitome of honor and loyalty.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Titus"] >= 0`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Lucita Azaro: ""Your admiration of Captain Gordion is notable, but our d..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus >= 0"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Titus >= 0)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus >= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Titus"] >= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""There must be some mistake. As far as I'm concerned he i..."*)
  - -> `[56]` (*Player_Romus: ""This is troubling news indeed. I've always taken Titus t..."*)
  - -> `[39]` (*Player_Romus: ""I find this accusation hard to believe. Titus has been n..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Titus >= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player_Romus: ""This only confirms my suspicions that he can't be trusted.""*)
  - -> `[133]` (*Player_Romus: ""I had a funny feeling about that Golden Guardsman. There..."*)
  - -> `[134]` (*Player_Romus: ""If what you're saying is true, this angers me to no end.""*)

### Węzeł `[61]`
Mówca: **Lucita Azaro**
> ""Yes, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "She took a quick look around before proceeding."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to know why you suspect Pabel.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "She took a quick look around before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lucita Azaro: ""On the night of King Valero's death, Captain Gordion was..."*)

### Węzeł `[64]`
Mówca: **Lucita Azaro**
> ""I'm merely presenting the facts, Your Majesty. It's unusual for someone in Pabel's position to be absent for such a long period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lucita Azaro: ""He has access to the inner workings of the palace, which..."*)

### Węzeł `[65]`
Mówca: **Lucita Azaro**
> ""As you know, it is my duty to explore every possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lucita Azaro: ""During the time leading up to Valero's death, there was ..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just because he was unaccounted for doesn't mean he had anything to do with my father's death.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucita Azaro), `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unaccounted for? Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucita Azaro), `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[68]`
Mówca: **Lucita Azaro**
> ""During the time leading up to Valero's death, there was a significant period when he couldn't be accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""Unaccounted for? Please explain.""*)
  - -> `[66]` (*Player_Romus: ""Just because he was unaccounted for doesn't mean he had ..."*)
  - -> `[69]` (*Player_Romus: ""I'm sure there's a reasonable explanation.""*)
  - -> `[70]` (*Player_Romus: ""That sounds very un-Pabel.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure there's a reasonable explanation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucita Azaro), `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That sounds very un-Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lucita Azaro), `[341]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[71]`
Mówca: **Lucita Azaro**
> ""He has access to the inner workings of the palace, which made him a person of interest -- a detail that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[72]`
Mówca: **Narrator**
> "She paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Lucita Azaro: ""Further investigation, however, revealed that Pabel had ..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "He paused."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Titus Gordion: ""Further investigation, however, revealed that your butle..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "She paused."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "He paused."*)

### Węzeł `[77]`
Mówca: **Lucita Azaro**
> ""Further investigation, however, revealed that Pabel had a solid alibi. His whereabouts during that time can be completely accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Narrator: "There was a note of uncertainty in her voice."*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What aren't you telling me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator), `[873]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[79]`
Mówca: **Narrator**
> "Lucita gave a slight bow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucita Azaro: ""Investigation aside... I would humbly remind you of that..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Lucita bowed and bid me good day before she turned and left my side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_PromisedDate == true && Rizia..."*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "Lucita gave a slight bow."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_PromisedDate"] == true  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all? That doesn't prove he had a hand in anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[815]` (Lucita Azaro), `[816]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You were right to come to me, however, we need something more concrete before jumping to conclusions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Lucita Azaro), `[307]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo = true;"*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I was correct in believing my father's untimely end was no accident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucita Azaro), `[196]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That quickly? Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Lucita Azaro), `[196]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[88]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An eyewitness? What led you to find that out?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[252]` (Lucita Azaro), `[257]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Lucita Azaro: ""The investigation into her whereabouts began when Dastnu..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If this information is inaccurate in any way, there will  be hell to pay.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[251]` (Titus Gordion), `[252]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is a lot to process. I'm having a hard time believing any of it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[251]` (Titus Gordion), `[252]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My God... A Dastnurist service? How can this be?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[425]` (Lucita Azaro), `[429]` (Titus Gordion), `[470]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectSal == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal == false"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectSal == false)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectSal == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player_Romus: ""I want to hear about what you found on the Grand Wiseman.""*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectSal == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I want to hear about what you found on the Grand Wiseman.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == false`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "Suspect Sal Hub"*)

### Węzeł `[96]`
Mówca: **Lucita Azaro**
> ""Your Majesty, multiple sources have confirmed to me that the Grand Wiseman visited the king's chambers the night of his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lucita Azaro: ""In fact, at that time he was consulting privately with t..."*)

### Węzeł `[97]`
Mówca: **Lucita Azaro**
> ""In fact, at that time he was consulting privately with the King on a near-nightly basis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Lucita Azaro: ""According to the Grand Wiseman himself, Valero turned to..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Makes sense. He had plenty to atone for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[824]` (Lucita Azaro), `[825]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[99]`
Mówca: **Lucita Azaro**
> ""What's interesting is that aside from those meetings, witnesses describe your father's behavior as no more religious than usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucita Azaro: ""He was even skipping services some weeks.""*)

### Węzeł `[100]`
Mówca: **Lucita Azaro**
> ""He was even skipping services some weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Player_Romus: ""He wanted his enlightenment straight from the tap. I don..."*)
  - -> `[827]` (*Player_Romus: ""Are you implying that the two of them were planning some..."*)
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[833]` (*Player_Romus: ""The Grand Wiseman is one of the most respected figures i..."*)

### Węzeł `[101]`
Mówca: **Lucita Azaro**
> ""Yes, however, it's unusual for someone in Pabel's position to remain absent for an extended duration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucita Azaro: ""He has access to the palace's internal operations, which..."*)

### Węzeł `[102]`
Mówca: **Lucita Azaro**
> ""I'm sure. But for an individual in Pabel's position to be away for such a prolonged period raised questions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucita Azaro: ""He possesses knowledge of the palace's internal workings..."*)

### Węzeł `[103]`
Mówca: **Lucita Azaro**
> ""As you know, to have someone of his status go missing for such an extended duration would raise suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucita Azaro: ""Especially with Pabel's knowledge of the inner workings ..."*)

### Węzeł `[104]`
Mówca: **Lucita Azaro**
> ""Especially with Pabel's knowledge of the inner workings of the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucita Azaro: ""Could his absence be a coincidence? Sure. But it was som..."*)

### Węzeł `[105]`
Mówca: **Lucita Azaro**
> ""Could his absence be a coincidence? Sure. But it was something I couldn't overlook.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[106]`
Mówca: **Lucita Azaro**
> ""He has access to the palace's internal operations, which made him a noteworthy figure in my inquiry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucita Azaro: ""While it might be coincidental, it was a detail we could..."*)

### Węzeł `[107]`
Mówca: **Lucita Azaro**
> ""While it might be coincidental, it was a detail we couldn't ignore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[108]`
Mówca: **Lucita Azaro**
> ""He possesses knowledge of the palace's internal workings, which rendered him a significant figure in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How wise of my father. I hope he found the serenity he was seeking.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[824]` (Lucita Azaro), `[825]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My father turned towards God... and away from everyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[824]` (Lucita Azaro), `[825]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[111]`
Mówca: **Lucita Azaro**
> ""It's not surprising. God forgives where humans don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || Rizia..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || Riz..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player_Romus: ""Here are the next steps for your investigation.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectHugo == true || RiziaDLC.Turn05_MurderInvest_SuspectSal == true || 
RiziaDLC.Turn05_MurderInvest_SuspectTitus == true || RiziaDLC.Turn05_MurderInvest_SuspectLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here are the next steps for your investigation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] == true  or  
Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] == true  or  Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[863]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo is obviously our primary suspect, so focus your investigation on him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[866]` (Narrator), `[867]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true; Rizi..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Discreetly continue your investigation into Titus. He has eyes and ears everywhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[866]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateTitus = true; Riz..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This investigation has gone as far as it can go. Cease all further efforts, effective immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[866]` (Narrator), `[867]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateNoone = true; Riz..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hate to say it, but keep looking into Sal. There's more to the Grand Wiseman than he's letting on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[866]` (Narrator), `[867]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; Rizia..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Player_Romus: ""I hate to say it, but keep looking into Sal. There's mor..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""Keep digging into Sal. There's more to the Wiseman than ..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep digging into Sal. There's more to the Wiseman than he's letting on.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[866]` (Narrator), `[867]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; Rizia..."*)

### Węzeł `[125]`
Mówca: **Lucita Azaro**
> ""Yes, Your Majesty. I'll get my stealthiest agents on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[126]`
Mówca: **Lucita Azaro**
> ""Very good, Your Majesty. Rest assured, I will get to the bottom of this as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[127]`
Mówca: **Lucita Azaro**
> ""Very well. But for the record, I still believe the actions of our suspects warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""You've already uncovered enough unpleasant secrets about..."*)
  - -> `[155]` (*Player_Romus: ""I'll keep all of what you said in mind. But I don't see ..."*)
  - -> `[156]` (*Player_Romus: ""For the record, I don't. My father was an old, sick man...."*)

### Węzeł `[128]`
Mówca: **Lucita Azaro**
> ""Consider it already done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectEstela"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectHugo = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectHugo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Suspect Sal Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I had a funny feeling about that Golden Guardsman. There was something about him that never sat right with me.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Lucita Azaro: ""I've had my reservations about him as well. It's always ..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If what you're saying is true, this angers me to no end.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Titus"] >= 0) == false`
- **Kontekst wejściowy (poprzednik):** `[38]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Lucita Azaro: ""I share your frustration. If these allegations hold up, ..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectTitus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[136]`
Mówca: **Narrator**
> "I didn't want to think about what would happen if Titus' suspicions were proven right."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[137]`
Mówca: **Lucita Azaro**
> ""Investigation aside... I would humbly remind you of that date you owe me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Player_Romus: ""The King of Rizia has no time for such frivolities. And ..."*)
  - -> `[138]` (*Player_Romus: ""I still haven't found a setting befitting the beauty and..."*)
  - -> `[140]` (*Player_Romus: ""I haven't forgotten. But we've both been busy.""*)
  - -> `[868]` (*Player_Romus: ""Right. Dinner and a movie, then?""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still haven't found a setting befitting the beauty and majesty of the Duchess of House Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lucita Azaro: ""Leave that to me, then.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The King of Rizia has no time for such frivolities. And neither do you, Duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Lucita Azaro: ""Yes... of course. I'll look for something that fits into..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't forgotten. But we've both been busy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lucita Azaro: ""I'm still looking forward to the day when we're not.""*)

### Węzeł `[141]`
Mówca: **Lucita Azaro**
> ""Yes... of course. I'll look for something that fits into both of our schedules.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She flashed a suggestive smile as she left the chambers."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "She flashed a suggestive smile as she left the chambers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Lucita Azaro");"*)

### Węzeł `[143]`
Mówca: **Lucita Azaro**
> ""Leave that to me, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She flashed a suggestive smile as she left the chambers."*)

### Węzeł `[144]`
Mówca: **Lucita Azaro**
> ""I'm still looking forward to the day when we're not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She flashed a suggestive smile as she left the chambers."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Now alone, my thoughts, once again, returned to the investigation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "Investigate Hub"*)

### Węzeł `[146]`
Mówca: **Narrator**
> "I assured myself that investigating Lucita was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Now alone, my thoughts, once again, returned to the inves..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Lucita Azaro");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "Alone once again, my thoughts returned to the investigation."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateNoone = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateNoone"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateNoone"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal = true;
RiziaDLC.PoisonInvestigation_Continues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal = true;
RiziaDLC.PoisonInvestigation_Continues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateSal"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateTitus = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus = true;
RiziaDLC.PoisonInvestigation_Continues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateTitus"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucita Azaro: ""Yes, Your Majesty. I'll get my stealthiest agents on the..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo = true;
RiziaDLC.PoisonInvestigation_Continues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateHugo"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've already uncovered enough unpleasant secrets about the people around me. I'd rather not learn more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro), `[180]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll keep all of what you said in mind. But I don't see grounds for a full-blown investigation into any of these suspects.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro), `[180]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For the record, I don't. My father was an old, sick man. That's all there is to it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Lucita Azaro), `[180]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Investigate Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "I assured myself that investigating Lucita was the right ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I assured myself that investigating Titus was the right c..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateTitus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateTitus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)

### Węzeł `[164]`
Mówca: **Narrator**
> "If he was to remain my bodyguard, I wanted to make sure he had no skeletons in his closet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "I didn't want to think about what would happen if Lucita'..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I assured myself that investigating Titus was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "If he was to remain my bodyguard, I wanted to make sure h..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "I didn't want to think about what would happen if Lucita's suspicions were proven right?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateSal == true"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateSal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "I assured myself that investigating Sal was the right cou..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateSal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateSal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "I assured myself that halting the investigation was the r..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "I took no pleasure in it, but I was duty-bound to dispens..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "But it had to be done."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "I took no pleasure in it, but I was duty-bound to dispense God's justice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "And if my suspicions turned out to be true, especially re..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "But it had to be done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "And if my suspicions turned out to be true, especially re..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "I assured myself that investigating Sal was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "And if my suspicions turned out to be true, especially regarding a man of faith, it begged the question... who could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "I assured myself that halting the investigation was the right thing to do."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "I was becoming as paranoid as my father. For the sake of ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "I was becoming as paranoid as my father. For the sake of my own well-being, it had to stop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita = false; RiziaDLC.Pois..."*)

### Węzeł `[179]`
Mówca: **Titus Gordion**
> ""Very good, Your Majesty. I'll work diligently to uncover the truth as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[180]`
Mówca: **Titus Gordion**
> ""Very well. For the record, I still believe the actions of our suspects warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player_Romus: ""You've already uncovered enough unpleasant secrets about..."*)
  - -> `[155]` (*Player_Romus: ""I'll keep all of what you said in mind. But I don't see ..."*)
  - -> `[156]` (*Player_Romus: ""For the record, I don't. My father was an old, sick man...."*)

### Węzeł `[181]`
Mówca: **Titus Gordion**
> ""Consider it handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Lucita Azaro: ""Consider it already done.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Titus Gordion: ""Consider it handled.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucita Azaro: ""Very good, Your Majesty. Rest assured, I will get to the..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Titus Gordion: ""Very good, Your Majesty. I'll work diligently to uncover..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Lucita Azaro: ""Very well. But for the record, I still believe the actio..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Titus Gordion: ""Very well. For the record, I still believe the actions o..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Titus == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Titus == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "Titus bowed and bid me good day before he turned and left."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Lucita bowed and bid me good day before she turned and le..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "Titus bowed and bid me good day before he turned and left."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Narrator: "Alone once again, my thoughts returned to the investigation."*)

### Węzeł `[196]`
Mówca: **Titus Gordion**
> ""Allow me to begin by stating that I've made significant headway in identifying potential culprits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player_Romus: ""That quickly? Tell me more.""*)
  - -> `[86]` (*Player_Romus: ""Then I was correct in believing my father's untimely end..."*)
  - -> `[4]` (*Player_Romus: ""So you *do* suspect foul play.""*)

### Węzeł `[197]`
Mówca: **Titus Gordion**
> ""Regrettably, yes. Multiple individuals raised strong suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[198]`
Mówca: **Titus Gordion**
> ""My initial list of suspects comprised five individuals. Lucita Azaro, Grand Wiseman Ignacius, your butler, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""My mother? How dare you insinuate such an awful thing.""*)
  - -> `[9]` (*Player_Romus: ""I hope you've narrowed it down from there.""*)
  - -> `[8]` (*Player_Romus: ""You're conveniently forgetting yourself.""*)

### Węzeł `[199]`
Mówca: **Narrator**
> "Titus discreetly looked around as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Titus Gordion: ""My initial list of suspects comprised five individuals. ..."*)

### Węzeł `[200]`
Mówca: **Titus Gordion**
> ""Starting with whom?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Lucita Azaro: ""Let me start by saying that I've made significant progre..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Titus Gordion: ""Allow me to begin by stating that I've made significant ..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucita Azaro: ""Unfortunately, yes. There are several individuals I find..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Titus Gordion: ""Regrettably, yes. Multiple individuals raised strong sus..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lucita Azaro: ""Yes, it seems you were right after all. And I believe I'..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Titus Gordion: ""That appears to be the case. I've narrowed it down to a ..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lucita Azaro: ""I've identified several individuals who initially raised..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Titus Gordion: ""I've pinpointed several individuals who initially arouse..."*)

### Węzeł `[213]`
Mówca: **Lucita Azaro**
> ""Yes, it seems you were right after all. And I believe I've narrowed it down to a handful of possible suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[214]`
Mówca: **Titus Gordion**
> ""That appears to be the case. I've narrowed it down to a handful of possible suspects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[215]`
Mówca: **Lucita Azaro**
> ""I've identified several individuals who initially raised significant suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[216]`
Mówca: **Titus Gordion**
> ""I've pinpointed several individuals who initially aroused considerable suspicion and warranted closer examination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Lucita discreetly glanced around as if making sure there ..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[746]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucita Azaro: ""With whom should I begin?""*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Titus Gordion: ""Starting with whom?""*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Lucita Azaro: ""You wouldn't have asked me to investigate if you thought..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Titus Gordion: ""Presumably, you tasked me with the investigation because..."*)

### Węzeł `[226]`
Mówca: **Titus Gordion**
> ""Presumably, you tasked me with the investigation because I'm not under suspicion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucita Azaro: ""Your Majesty, our investigative efforts have unveiled a ..."*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Titus Gordion: ""Sir, our investigation has uncovered some intriguing fin..."*)

### Węzeł `[230]`
Mówca: **Titus Gordion**
> ""Sir, our investigation has uncovered some intriguing findings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Titus Gordion: ""The Queen Mother was at dinner that night. Later, as I p..."*)

### Węzeł `[231]`
Mówca: **Titus Gordion**
> ""The Queen Mother was at dinner that night. Later, as I personally witnessed, she opened the door to your father's chambers and immediately alerted the Golden Guard that he was unconscious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]` (*Titus Gordion: ""In between, however, Madam Estela was not in the Palace ..."*)

### Węzeł `[232]`
Mówca: **Lucita Azaro**
> ""It certainly does. That said, you might be shocked to learn the nature of her secret outing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Lucita Azaro: ""She was attending Dastnurist religious service just outs..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lucita Azaro: ""It certainly does. That said, you might be shocked to le..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Titus Gordion: ""It certainly does. As for the nature of her whereabouts,..."*)

### Węzeł `[236]`
Mówca: **Titus Gordion**
> ""It certainly does. As for the nature of her whereabouts, you might be surprised to learn that she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Titus Gordion: ""Specifically, a Dastnurist religious service.""*)

### Węzeł `[237]`
Mówca: **Lucita Azaro**
> ""Not so fast, Your Majesty. This may come as a shock, but as it happens, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Lucita Azaro: ""A Dastnurist service.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lucita Azaro: ""Not so fast, Your Majesty. This may come as a shock, but..."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Titus Gordion: ""That depends on how you look at it. This may come as a s..."*)

### Węzeł `[241]`
Mówca: **Titus Gordion**
> ""That depends on how you look at it. This may come as a surprise, but as it happens, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Titus Gordion: ""But it wasn't a Wruhecist service. It was a Dastnurist.""*)

### Węzeł `[242]`
Mówca: **Lucita Azaro**
> ""This may come as a shock, but it turns out, she was attending a clandestine religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Lucita Azaro: ""A Dastnurist service.""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucita Azaro: ""This may come as a shock, but it turns out, she was atte..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Titus Gordion: ""This may come as a surprise, but it turns out, she was a..."*)

### Węzeł `[246]`
Mówca: **Titus Gordion**
> ""This may come as a surprise, but it turns out, she was attending a religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Titus Gordion: ""But it wasn't a Wruhecist service. It was a Dastnurist.""*)

### Węzeł `[247]`
Mówca: **Lucita Azaro**
> ""We managed to find credible eyewitnesses at the Dastnurist archsanctuary that night who can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""An eyewitness? What led you to find that out?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucita Azaro: ""We managed to find credible eyewitnesses at the Dastnuri..."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Titus Gordion: ""One of my Golden Guards, who was assigned to protect her..."*)

### Węzeł `[251]`
Mówca: **Titus Gordion**
> ""One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""And how reliable is this Golden Guardsman of yours?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[252]`
Mówca: **Lucita Azaro**
> ""It's no joke. Credible eyewitnesses were present at the archsanctuary that night who can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""An eyewitness? What led you to find that out?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Lucita Azaro: ""It's no joke. Credible eyewitnesses were present at the ..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Titus Gordion: ""It's no joke, sir. One of my Golden Guards, who was assi..."*)

### Węzeł `[256]`
Mówca: **Titus Gordion**
> ""It's no joke, sir. One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""And how reliable is this Golden Guardsman of yours?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[257]`
Mówca: **Lucita Azaro**
> ""All I know is that multiple eyewitnesses at the Dastnurist archsanctuary that night can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""An eyewitness? What led you to find that out?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Lucita Azaro: ""All I know is that multiple eyewitnesses at the Dastnuri..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Titus Gordion: ""All I know is that one of my Golden Guards, who was assi..."*)

### Węzeł `[261]`
Mówca: **Titus Gordion**
> ""All I know is that one of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""And how reliable is this Golden Guardsman of yours?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Lucita Azaro: ""No mistake. The information is solid.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Titus Gordion: ""My guardsmen don't make mistakes.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Lucita Azaro: ""The gathered information has undergone rigorous scrutiny..."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Titus Gordion: ""The information is indeed accurate. The guardsman who ac..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lucita Azaro: ""I understand how disconcerting this news might be.""*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dastnurity aside, it's a relief to hear she's no longer a suspect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering. It's an affront to our faith!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your slow approach to sharing crucial information is frustrating. Get to the point faster next time.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I suppose I'll have to find another suspect.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[275]`
Mówca: **Lucita Azaro**
> ""Needless to say, this proves your mother had an alibi, and had nothing to do with your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[271]` (*Player_Romus: ""Dastnurity aside, it's a relief to hear she's no longer ..."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[276]`
Mówca: **Titus Gordion**
> ""Needless to say, this establishes an alibi for your mother -- that she had no involvement in your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[271]` (*Player_Romus: ""Dastnurity aside, it's a relief to hear she's no longer ..."*)
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[277]`
Mówca: **Lucita Azaro**
> ""Of all the individuals I've been looking into, your Uncle Hugo stands out the most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Lucita Azaro: ""After supper on the night Valero died, His Grace accompa..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucita Azaro: ""Of all the individuals I've been looking into, your Uncl..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Titus Gordion: ""I don't truly believe your esteemed uncle would commit f..."*)

### Węzeł `[281]`
Mówca: **Titus Gordion**
> ""After supper on the night Valero died, His Grace accompanied the King to his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Titus Gordion: ""I did not listen in to their conversation. But a maid wh..."*)

### Węzeł `[282]`
Mówca: **Lucita Azaro**
> ""After supper on the night Valero died, His Grace accompanied the King to his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Lucita Azaro: ""Your Golden Guardsman claims not to remember what they w..."*)

### Węzeł `[283]`
Mówca: **Lucita Azaro**
> ""I agree completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Lucita Azaro: ""I agree completely.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Titus Gordion: ""I share your sentiment.""*)

### Węzeł `[287]`
Mówca: **Titus Gordion**
> ""I share your sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[288]`
Mówca: **Lucita Azaro**
> ""Believe it or not, but facts are facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Lucita Azaro: ""Believe it or not, but facts are facts.""*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Titus Gordion: ""I only present the facts.""*)

### Węzeł `[292]`
Mówca: **Titus Gordion**
> ""I only present the facts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[293]`
Mówca: **Lucita Azaro**
> ""Forgive my bluntness, but what more do you need? We must get to the bottom of what happened between the two of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Lucita Azaro: ""Forgive my bluntness, but what more do you need? We must..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Titus Gordion: ""I believe that such behavior is enough to warrant furthe..."*)

### Węzeł `[297]`
Mówca: **Titus Gordion**
> ""I believe that such behavior is enough to warrant further scrutiny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[298]`
Mówca: **Lucita Azaro**
> ""If we keep pursuing this lead, we will get them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Lucita Azaro: ""If we keep pursuing this lead, we will get them.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Titus Gordion: ""If we continue our investigation, we will deliver them.""*)

### Węzeł `[302]`
Mówca: **Titus Gordion**
> ""If we continue our investigation, we will deliver them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[303]`
Mówca: **Lucita Azaro**
> ""Given the severity of accusing the Grand Vizier of murder, I wanted to inform you first before proceeding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""I'm glad you did. If what you're saying is true, we must..."*)
  - -> `[28]` (*Player_Romus: ""Sorry, but what you're implying sounds too far-fetched.""*)
  - -> `[85]` (*Player_Romus: ""You were right to come to me, however, we need something..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Lucita Azaro: ""Given the severity of accusing the Grand Vizier of murde..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Titus Gordion: ""Given the potential uproar from accusing the Grand Vizie..."*)

### Węzeł `[307]`
Mówca: **Titus Gordion**
> ""Given the potential uproar from accusing the Grand Vizier of murder, I wanted to inform you before proceeding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""I'm glad you did. If what you're saying is true, we must..."*)
  - -> `[28]` (*Player_Romus: ""Sorry, but what you're implying sounds too far-fetched.""*)
  - -> `[85]` (*Player_Romus: ""You were right to come to me, however, we need something..."*)

### Węzeł `[308]`
Mówca: **Lucita Azaro**
> ""There's nothing unusual about that fact.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]` (*Lucita Azaro: ""But when I questioned the other Golden Guardsmen, one of..."*)

### Węzeł `[309]`
Mówca: **Lucita Azaro**
> ""Yes. He stuck to His Majesty like glue, much as he currently sticks to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]` (*Lucita Azaro: ""But when I questioned the other Golden Guardsmen, one of..."*)

### Węzeł `[310]`
Mówca: **Lucita Azaro**
> ""Titus guarded your father's quarters almost every night. Without fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]` (*Lucita Azaro: ""But when I questioned the other Golden Guardsmen, one of..."*)

### Węzeł `[311]`
Mówca: **Lucita Azaro**
> ""It is, which raises questions about his loyalty and the circumstances surrounding the king's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucita Azaro: ""Your guardsman's behavior was suspicious, to say the lea..."*)

### Węzeł `[312]`
Mówca: **Lucita Azaro**
> ""For half an hour?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucita Azaro: ""Your guardsman's behavior was suspicious, to say the lea..."*)

### Węzeł `[313]`
Mówca: **Lucita Azaro**
> ""The other guardsman claims nothing happened. But he could have been covering for his colleague...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucita Azaro: ""Your guardsman's behavior was suspicious, to say the lea..."*)

### Węzeł `[314]`
Mówca: **Lucita Azaro**
> ""Your admiration of Captain Gordion is notable, but our duty sometimes requires us to question even the most loyal among us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[315]`
Mówca: **Lucita Azaro**
> ""I understand your reservations, but my duty is to uncover the truth, no matter how uncomfortable it may be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[316]`
Mówca: **Lucita Azaro**
> ""I understand. But my responsibility is to unveil the truth, no matter how unsettling it might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[317]`
Mówca: **Lucita Azaro**
> ""Yes. We proceed with caution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[318]`
Mówca: **Lucita Azaro**
> ""I've had my reservations about him as well. It's always best to trust your instincts in such matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[319]`
Mówca: **Lucita Azaro**
> ""I share your frustration. If these allegations hold up, it's a betrayal that none of us could have foreseen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Lucita Azaro: ""Trust can be a double-edged sword, and it's disheartenin..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucita Azaro: ""Your Majesty, multiple sources have confirmed to me that..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Titus Gordion: ""Your Majesty, I myself admitted the Grand Wiseman into t..."*)

### Węzeł `[323]`
Mówca: **Titus Gordion**
> ""Your Majesty, I myself admitted the Grand Wiseman into the king's chambers the night of his death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Titus Gordion: ""I thought nothing of it at the time. The two of them had..."*)

### Węzeł `[324]`
Mówca: **Titus Gordion**
> ""I thought nothing of it at the time. The two of them had been consulting privately on a near-nightly basis.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Titus Gordion: ""According to the Grand Wiseman himself, Valero turned to..."*)

### Węzeł `[325]`
Mówca: **Titus Gordion**
> ""Religion is often a source of comfort to those who feel abandoned by everything and everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""What's interesting is that aside from those meetings, witnesses describe your father's behavior as no more religious than usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Titus Gordion: ""He was even skipping services some weeks.""*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Lucita Azaro: ""It's not surprising. God forgives where humans don't.""*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Titus Gordion: ""Religion is often a source of comfort to those who feel ..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[336]`
Mówca: **Titus Gordion**
> ""He was even skipping services some weeks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Player_Romus: ""He wanted his enlightenment straight from the tap. I don..."*)
  - -> `[827]` (*Player_Romus: ""Are you implying that the two of them were planning some..."*)
  - -> `[828]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[833]` (*Player_Romus: ""The Grand Wiseman is one of the most respected figures i..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucita Azaro: ""As you know, it is my duty to explore every possibility.""*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Titus Gordion: ""As you know, I've been tasked with exploring every possi..."*)

### Węzeł `[340]`
Mówca: **Titus Gordion**
> ""As you know, I've been tasked with exploring every possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Titus Gordion: ""Prior to Valero's passing, there was an extended period ..."*)

### Węzeł `[341]`
Mówca: **Titus Gordion**
> ""Prior to Valero's passing, there was an extended period during which his movements couldn't be traced.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""Unaccounted for? Please explain.""*)
  - -> `[66]` (*Player_Romus: ""Just because he was unaccounted for doesn't mean he had ..."*)
  - -> `[69]` (*Player_Romus: ""I'm sure there's a reasonable explanation.""*)
  - -> `[70]` (*Player_Romus: ""That sounds very un-Pabel.""*)

### Węzeł `[342]`
Mówca: **Titus Gordion**
> ""Having someone of his status go missing for such an extended duration indeed raises suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Titus Gordion: ""And with Pabel's grasp of the palace's internal workings..."*)

### Węzeł `[343]`
Mówca: **Titus Gordion**
> ""I'm merely presenting the facts, sir. It's unusual for someone in Pabel's position to be absent for such a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Titus Gordion: ""His access to the inner workings of the palace made him ..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucita Azaro: ""Yes, however, it's unusual for someone in Pabel's positi..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Titus Gordion: ""Yes, although it's uncommon for someone in Pabel's posit..."*)

### Węzeł `[347]`
Mówca: **Titus Gordion**
> ""Yes, although it's uncommon for someone in Pabel's position to be absent for an extended period...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Titus Gordion: ""Having access to the inner workings of the palace elevat..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucita Azaro: ""As you know, to have someone of his status go missing fo..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Titus Gordion: ""Having someone of his status go missing for such an exte..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucita Azaro: ""I'm merely presenting the facts, Your Majesty. It's unus..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Titus Gordion: ""I'm merely presenting the facts, sir. It's unusual for s..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lucita Azaro: ""I'm sure. But for an individual in Pabel's position to b..."*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Titus Gordion: ""I'm sure, but it's unusual for someone in Pabel's positi..."*)

### Węzeł `[357]`
Mówca: **Titus Gordion**
> ""I'm sure, but it's unusual for someone in Pabel's position to be absent for such an extended period. It raised concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Titus Gordion: ""He possesses knowledge of the palace's internal workings..."*)

### Węzeł `[358]`
Mówca: **Titus Gordion**
> ""Having access to the inner workings of the palace elevated his importance in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Titus Gordion: ""Because of this, it was a detail that couldn't be ignored.""*)

### Węzeł `[359]`
Mówca: **Titus Gordion**
> ""Because of this, it was a detail that couldn't be ignored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[360]`
Mówca: **Titus Gordion**
> ""He possesses knowledge of the palace's internal workings, which makes him a significant figure in my investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[361]`
Mówca: **Titus Gordion**
> ""His access to the inner workings of the palace made him a person of interest. It was a detail that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[362]`
Mówca: **Titus Gordion**
> ""And with Pabel's grasp of the palace's internal workings, this took on added significance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Titus Gordion: ""It's possible that his absence during that time was a me..."*)

### Węzeł `[363]`
Mówca: **Titus Gordion**
> ""It's possible that his absence during that time was a mere coincidence. However, it's something that couldn't be overlooked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[364]`
Mówca: **Titus Gordion**
> ""Further investigation, however, revealed that your butler had a solid alibi. His whereabouts during that time can be completely accounted for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[873]` (*Narrator: "There was a strangely somber tone to his voice."*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's hear why you suspect Lucita.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[17]` (Lucita Azaro), `[200]` (Titus Gordion), `[26]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Titus Gordion: ""My suspicions stem from Lucita allegedly visiting King V..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && Ri..."*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && ..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Player_Romus: ""Let's hear why you suspect Lucita.""*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_SuspectLucita == false && RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[369]`
Mówca: **Titus Gordion**
> ""My suspicions stem from Lucita allegedly visiting King Valero's chambers on the night of his passing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player_Romus: ""Allegedly? You were guarding my father's chambers. Would..."*)
  - -> `[370]` (*Player_Romus: ""I see... Go on.""*)
  - -> `[374]` (*Player_Romus: ""Well, what of it?""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see... Go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Titus Gordion: ""As is my duty, I was standing guard outside your father'..."*)

### Węzeł `[371]`
Mówca: **Titus Gordion**
> ""When I returned, he informed me nothing out of the ordinary had occurred. But pressed for details during this investigation, he admitted he had allowed Duchess Azaro access to the room for a brief period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player_Romus: ""What was she doing in there?""*)
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[757]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[651]` (*Player_Romus: ""So you left your post while on duty? Not the best way to..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're implying they were secret lovers or something?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Titus Gordion: ""I would never suggest such a thing. However...""*)

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Allegedly? You were guarding my father's chambers. Wouldn't you know if she visited?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Titus Gordion: ""As is my duty, I was standing guard outside your father'..."*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, what of it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Titus Gordion: ""As is my duty, I was standing guard outside your father'..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What was she doing in there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Titus Gordion: ""That's what concerned me.""*)

### Węzeł `[376]`
Mówca: **Titus Gordion**
> ""I would never suggest such a thing. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Titus Gordion: ""When I questioned the guardsman, he claimed Lucita had p..."*)

### Węzeł `[377]`
Mówca: **Titus Gordion**
> ""When I questioned the guardsman, he claimed Lucita had provided him with an order signed by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""And you believed him?""*)
  - -> `[378]` (*Player_Romus: ""An order? What for?""*)
  - -> `[380]` (*Player_Romus: ""If true, we need to verify its authenticity.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An order? What for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Titus Gordion), `[762]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Titus Gordion: ""I suspect she may have been carrying a correspondence le..."*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you believed him?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Titus Gordion), `[762]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Titus Gordion: ""I have no reason not to. Being a Golden Guardsman means ..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If true, we need to verify its authenticity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Titus Gordion), `[762]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Titus Gordion: ""My thoughts exactly.""*)

### Węzeł `[381]`
Mówca: **Titus Gordion**
> ""I suspect she may have been carrying a correspondence letter, but I cannot confirm it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Titus Gordion: ""When we searched your father's chambers later, we found ..."*)

### Węzeł `[382]`
Mówca: **Titus Gordion**
> ""I have no reason not to. Being a Golden Guardsman means maintaining the highest level of integrity and loyalty. But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Titus Gordion: ""I had my suspicions that she might have been carrying le..."*)

### Węzeł `[383]`
Mówca: **Titus Gordion**
> ""When we searched your father's chambers later, we found no evidence of a summons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player_Romus: ""I have a hard time wrapping my head around Lucita doing ..."*)
  - -> `[384]` (*Player_Romus: ""This is deeply troubling. What could Lucita be hiding?""*)
  - -> `[386]` (*Player_Romus: ""I always suspected that, when it came to the throne, Hou..."*)
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is deeply troubling. What could Lucita be hiding?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Titus Gordion: ""That's a question I hope to find out.""*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have a hard time wrapping my head around Lucita doing something so drastic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Titus Gordion: ""People can surprise us, for better or for worse. In any ..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I always suspected that, when it came to the throne, House Azaro was out for blood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Titus Gordion: ""I can't attest to that. I'm only presenting what I've be..."*)

### Węzeł `[387]`
Mówca: **Titus Gordion**
> ""My thoughts exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Titus Gordion: ""I suspect she may have been carrying a letter, but I can..."*)

### Węzeł `[388]`
Mówca: **Titus Gordion**
> ""That's what concerned me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Titus Gordion: ""When I questioned the guardsman, he claimed Lucita had p..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[390]`
Mówca: **Titus Gordion**
> ""People can surprise us, for better or for worse. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Titus Gordion: ""Given her high rank in your cabinet and access to sensit..."*)

### Węzeł `[391]`
Mówca: **Titus Gordion**
> ""That's a question I hope to find out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Titus Gordion: ""Given her high rank in your cabinet and access to sensit..."*)

### Węzeł `[392]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep looking into Lucita's motivation. You might be onto something there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[867]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita = true; Ri..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateLucita = true; RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita = true;
RiziaDLC.PoisonInvestigation_Continues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateLucita"] = true;
Variable["RiziaDLCSupport.Journal_Turn05_Security_InvestigateLucita"] = true;
Variable["RiziaDLC.PoisonInvestigation_Continues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Titus Gordion: ""Considered it already handled.""*)

### Węzeł `[394]`
Mówca: **Titus Gordion**
> ""Considered it already handled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_PromisedDate == true && RiziaDL..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectSal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectSal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[396]`
Mówca: **Narrator**
> "Alone once again, my thoughts returned to the investigation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "Investigate Hub"*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucita Azaro: ""I meant no offense. You instructed me to investigate eve..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Titus Gordion: ""I meant no offense, sir. You told me to investigate ever..."*)

### Węzeł `[400]`
Mówca: **Titus Gordion**
> ""I meant no offense, sir. You told me to investigate everyone present at the palace during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucita Azaro: ""As a matter of fact, I have.""*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Titus Gordion: ""Yes, that's what I'm here to talk about.""*)

### Węzeł `[404]`
Mówca: **Titus Gordion**
> ""Yes, that's what I'm here to talk about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Romus: ""I hope you're armed with substantial evidence.""*)
  - -> `[13]` (*Player_Romus: ""Alright, let's go down the list.""*)
  - -> `[12]` (*Player_Romus: ""Tell me what you’ve learned -- no matter how hard it is ..."*)

### Węzeł `[405]`
Mówca: **Lucita Azaro**
> ""Trust can be a double-edged sword, and it's disheartening when broken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectTitus = true;"*)

### Węzeł `[406]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Romus_Italic**
> "I said nothing, silently waiting for them to continue."
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Kontekst wejściowy (poprzednik):** `[423]` (Titus Gordion), `[684]` (Narrator), `[410]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[407]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucita. To what do I owe this pleasure?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Lucita Azaro: ""'This pleasure' happens to be the information you reques..."*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes? Something on your mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Lucita Azaro: ""Only that I may have some information regarding your fat..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me you're here because you have information on my father's passing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[680]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Lucita Azaro: ""Yes, I have, in fact, made significant progress on the i..."*)

### Węzeł `[410]`
Mówca: **Lucita Azaro**
> ""Yes, I have, in fact, made significant progress on the investigation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, do tell! I'm eager to know what you've uncovered.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Kontekst wejściowy (poprzednik):** `[423]` (Titus Gordion), `[684]` (Narrator), `[410]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[412]`
Mówca: **Lucita Azaro**
> ""Only that I may have some information regarding your father's demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? In that case, let's hear it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Kontekst wejściowy (poprzednik):** `[423]` (Titus Gordion), `[684]` (Narrator), `[410]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, what are you waiting for? Spit it out.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Kontekst wejściowy (poprzednik):** `[423]` (Titus Gordion), `[684]` (Narrator), `[410]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[415]`
Mówca: **Lucita Azaro**
> ""'This pleasure' happens to be the information you requested about your father's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "And the city's distant lights shimmered, a testament to life continuing beyond the palace walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[664]` (*Narrator: "Amid this tranquil backdrop, I found a brief respite from..."*)

### Węzeł `[417]`
Mówca: **Narrator**
> "His presence on the balcony hinted at an urgent matter, a reminder that, as a monarch, even moments of solitude could be fleeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Titus Gordion: ""Good evening, Your Majesty.""*)

### Węzeł `[418]`
Mówca: **Titus Gordion**
> ""Good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""To what do I owe the pleasure, Captain?""*)
  - -> `[419]` (*Player_Romus: ""What are you doing lurking in the dark?""*)
  - -> `[421]` (*Player_Romus: ""Ah, it's you. Is everything all right?""*)
  - -> `[422]` (*Player_Romus: ""If you have something to report, make it quick.""*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing lurking in the dark?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Titus Gordion: ""I apologize if I startled you.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To what do I owe the pleasure, Captain?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Titus Gordion: ""I'm here to discuss that *personal matter* you asked me ..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ah, it's you. Is everything all right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Titus Gordion: ""Everything's fine. No need to worry.""*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have something to report, make it quick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[418]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Titus Gordion: ""Gladly.""*)

### Węzeł `[423]`
Mówca: **Titus Gordion**
> ""The one concerning His Majesty, King Valero.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""Well, what are you waiting for? Spit it out.""*)
  - -> `[413]` (*Player_Romus: ""Really? In that case, let's hear it.""*)
  - -> `[411]` (*Player_Romus: ""Oh, do tell! I'm eager to know what you've uncovered.""*)
  - -> `[406]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[424]`
Mówca: **Titus Gordion**
> ""I'm here to discuss that *personal matter* you asked me to look into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Titus Gordion: ""The one concerning His Majesty, King Valero.""*)

### Węzeł `[425]`
Mówca: **Lucita Azaro**
> ""A Dastnurist service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[426]`
Mówca: **Lucita Azaro**
> ""I didn't think much of it until I stumbled across the name and address of a Dastnurist sanctuary handwritten on the inside cover of one such book.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Lucita Azaro: ""My curiosity piqued, I thoroughly investigated the event..."*)

### Węzeł `[427]`
Mówca: **Lucita Azaro**
> ""The investigation into her whereabouts began when Dastnurist literature was found hidden in her bedchamber during a secret search.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucita Azaro: ""I didn't think much of it until I stumbled across the na..."*)

### Węzeł `[428]`
Mówca: **Lucita Azaro**
> ""My curiosity piqued, I thoroughly investigated the events of that night by gathering records, logs, cross-referencing attendance lists, and witness accounts to solve the puzzle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucita Azaro: ""Needless to say, this proves your mother had an alibi, a..."*)

### Węzeł `[429]`
Mówca: **Titus Gordion**
> ""But it wasn't a Wruhecist service. It was a Dastnurist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[430]`
Mówca: **Titus Gordion**
> ""My guardsmen don't make mistakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)

### Węzeł `[431]`
Mówca: **Titus Gordion**
> ""Given that Wruhecism is not only a faith but a state institution, I understand the gravity of this contradiction. However...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Titus Gordion: ""Considering her upbringing in Zille, where Dastnurity is..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Player_Romus: ""Looks like our next family chat is about to get interest..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Player_Romus: ""Really? Wouldn't have guessed that Mother was still full..."*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looks like our next family chat is about to get interesting.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[436]`
Mówca: **Lucita Azaro**
> ""It could lead to an even more interesting discussion, when I tell you where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucita Azaro: ""...attending a clandestine Dastnurist religious service ..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lucita Azaro: ""It could lead to an even more interesting discussion, wh..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Titus Gordion: ""It could lead to an even more interesting discussion, wh..."*)

### Węzeł `[440]`
Mówca: **Titus Gordion**
> ""It could lead to an even more interesting discussion, when I disclose her actual whereabouts...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Titus Gordion: ""...attending a Dastnurist religious service just outside..."*)

### Węzeł `[441]`
Mówca: **Lucita Azaro**
> ""...attending a clandestine Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[458]` (*Player_Romus: ""Well, that's certainly not what I expected to hear. You ..."*)
  - -> `[469]` (*Player_Romus: ""I must admit I'm quite surprised by this revelation. It ..."*)

### Węzeł `[442]`
Mówca: **Titus Gordion**
> ""...attending a Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[458]` (*Player_Romus: ""Well, that's certainly not what I expected to hear. You ..."*)
  - -> `[469]` (*Player_Romus: ""I must admit I'm quite surprised by this revelation. It ..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""Not in the palace? Then where the hell was she?""*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Player_Romus: ""Not in the palace? Well, if she wasn't here, then where ..."*)

### Węzeł `[447]`
Mówca: **Lucita Azaro**
> ""Brace yourself, but it turns out, she was attending a secret religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Lucita Azaro: ""A Dastnurist service.""*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lucita Azaro: ""Brace yourself, but it turns out, she was attending a se..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Titus Gordion: ""As it happens, she was participating in a covert religio..."*)

### Węzeł `[451]`
Mówca: **Titus Gordion**
> ""As it happens, she was participating in a covert religious gathering just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Titus Gordion: ""But it wasn't a Wruhecist service. It was a Dastnurist.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player_Romus: ""If this is your idea of a joke, I'm not laughing.""*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[734]` (*Player_Romus: ""You're kidding, right?""*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""My God... A Dastnurist service? How can this be?""*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Player_Romus: ""A Dastnurist service? How can this be?""*)

### Węzeł `[458]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that's certainly not what I expected to hear. You can verify the accuracy of this information?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Lucita Azaro), `[442]` (Titus Gordion), `[470]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[459]`
Mówca: **Lucita Azaro**
> ""Without question. Multiple eyewitnesses at the Dastnurist archsanctuary that night can verify it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player_Romus: ""An eyewitness? What led you to find that out?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Lucita Azaro: ""Without question. Multiple eyewitnesses at the Dastnuris..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Titus Gordion: ""Absolutely. One of my Golden Guards, who was assigned to..."*)

### Węzeł `[463]`
Mówca: **Titus Gordion**
> ""Absolutely. One of my Golden Guards, who was assigned to protect her, can confirm it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""And how reliable is this Golden Guardsman of yours?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[464]`
Mówca: **Lucita Azaro**
> ""Which is why I came to you as soon as I could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Lucita Azaro: ""Credible eyewitnesses were present at the archsanctuary ..."*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Lucita Azaro: ""Which is why I came to you as soon as I could.""*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Titus Gordion: ""All the more reason I thought it necessary to brief you ..."*)

### Węzeł `[468]`
Mówca: **Titus Gordion**
> ""All the more reason I thought it necessary to brief you as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Titus Gordion: ""One of my Golden Guards, who was assigned to protect her..."*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must admit I'm quite surprised by this revelation. It could spark quite a scandal if it became public.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[441]` (Lucita Azaro), `[442]` (Titus Gordion), `[470]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[470]`
Mówca: **Lucita Azaro**
> ""She was attending Dastnurist religious service just outside the capital.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[458]` (*Player_Romus: ""Well, that's certainly not what I expected to hear. You ..."*)
  - -> `[469]` (*Player_Romus: ""I must admit I'm quite surprised by this revelation. It ..."*)

### Węzeł `[471]`
Mówca: **Titus Gordion**
> ""Specifically, a Dastnurist religious service.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Dastnurist? Are you sure?""*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[458]` (*Player_Romus: ""Well, that's certainly not what I expected to hear. You ..."*)
  - -> `[469]` (*Player_Romus: ""I must admit I'm quite surprised by this revelation. It ..."*)

### Węzeł `[472]`
Mówca: **Lucita Azaro**
> ""Credible eyewitnesses were present at the archsanctuary that night who can verify her attendance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[473]`
Mówca: **Titus Gordion**
> ""One of my Golden Guards, who was assigned to protect her, confirmed it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Player_Romus: ""And how reliable is this Golden Guardsman of yours?""*)
  - -> `[36]` (*Player_Romus: ""Well, they must have been mistaken.""*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[474]`
Mówca: **Titus Gordion**
> ""The information is indeed accurate. The guardsman who accompanied her is among my most trustworthy subordinates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)

### Węzeł `[475]`
Mówca: **Titus Gordion**
> ""I know how disconcerting this news might be, especially considering it goes against the official state religion of Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Titus Gordion: ""However, the information is reliable. The guardsman who ..."*)

### Węzeł `[476]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And how reliable is this Golden Guardsman of yours?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[251]` (Titus Gordion), `[256]` (Titus Gordion), `[261]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Titus Gordion: ""The individual of which I speak is very reliable.""*)

### Węzeł `[477]`
Mówca: **Lucita Azaro**
> ""No mistake. The information is solid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lucita Azaro: ""I was first made aware of her beliefs when we conducted ..."*)

### Węzeł `[478]`
Mówca: **Lucita Azaro**
> ""I was first made aware of her beliefs when we conducted a search of her bedchamber, where hidden Dastnurist literature was found.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Lucita Azaro: ""I didn't think much of it until I stumbled across the na..."*)

### Węzeł `[479]`
Mówca: **Titus Gordion**
> ""The individual of which I speak is very reliable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""If this information is inaccurate in any way, there will..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Player_Romus: ""A part of me hopes this information is inaccurate.""*)

### Węzeł `[483]`
Mówca: **Lucita Azaro**
> ""The gathered information has undergone rigorous scrutiny. I wouldn't approach you with anything less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lucita Azaro: ""I was first made aware of her beliefs when we conducted ..."*)

### Węzeł `[484]`
Mówca: **Lucita Azaro**
> ""I understand how disconcerting this news might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lucita Azaro: ""I was first made aware of her beliefs when we conducted ..."*)

### Węzeł `[485]`
Mówca: **Titus Gordion**
> ""However, the information is reliable. The guardsman who was with her is one of my most dependable subordinates.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Titus Gordion: ""Considering her upbringing in Zille, where Dastnurity is..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Player_Romus: ""As a man of faith, forgive me when I say, I have a hard ..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""This is a lot to process. I'm having a hard time believi..."*)

### Węzeł `[489]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a man of faith, forgive me when I say, I have a hard time relying solely on that... faith.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[251]` (Titus Gordion), `[252]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Player_Romus: ""Sure, but it still doesn't excuse her attendance at a Da..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Player_Romus: ""Sure, but it still doesn't excuse her attendance at a Da..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sure, but it still doesn't excuse her attendance at a Dastnurist gathering!""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[494]`
Mówca: **Titus Gordion**
> ""Considering her upbringing in Zille, where Dastnurity is the prevailing religion, this revelation is quite understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Titus Gordion: ""Needless to say, this establishes an alibi for your moth..."*)

### Węzeł `[495]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well then, I guess there's no need to place Mother in the royal dungeon. I suppose I'll have to find another suspect.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true )"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Player_Romus: ""Well then, I guess there's no need to place Mother in th..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""Then I suppose I'll have to find another suspect.""*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: ""Your slow approach to sharing crucial information is fru..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Player_Romus: ""Your meticulous approach to sharing important informatio..."*)

### Węzeł `[502]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your meticulous approach to sharing important information is valued, but please aim for more concise summaries in future discussions.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[275]` (Lucita Azaro), `[276]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectEstela = true;"*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The plot thickens.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm, so he won't be the star of our treasonous play after all. The plot thickens.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you say so in the first place?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator), `[873]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, that is good news. You can lead with that next time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator), `[873]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""Hmm, so he won't be the star of our treasonous play afte..."*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Player_Romus: ""The plot thickens.""*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus: ""Why didn't you say so in the first place?""*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Player_Romus: ""Well, that is good news. You can lead with that next time.""*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth always prevails, as our faith teaches us. Pabel's innocence is a testament to this.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator), `[873]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[514]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The truth always prevails. Pabel's innocence is a testament to this.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[872]` (Narrator), `[873]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Player_Romus: ""The truth always prevails, as our faith teaches us. Pabe..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Player_Romus: ""The truth always prevails. Pabel's innocence is a testam..."*)

### Węzeł `[518]`
Mówca: **Lucita Azaro**
> ""Indeed, it's heartening to see the truth come to light. Pabel can finally put this behind him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Lucita Azaro: ""Indeed, it's heartening to see the truth come to light. ..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Titus Gordion: ""Indeed. The truth always prevails.""*)

### Węzeł `[522]`
Mówca: **Titus Gordion**
> ""Indeed. The truth always prevails.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[523]`
Mówca: **Lucita Azaro**
> ""My apologies for the delay, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Lucita Azaro: ""My apologies for the delay, Your Majesty.""*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Titus Gordion: ""My apologies for the delay, sir.""*)

### Węzeł `[527]`
Mówca: **Titus Gordion**
> ""My apologies for the delay, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[528]`
Mówca: **Lucita Azaro**
> ""Of course, Your Majesty. We're keeping our eyes on the unfolding drama.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Lucita Azaro: ""Of course, Your Majesty. We're keeping our eyes on the u..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Titus Gordion: ""I'm pleased to have put your suspicion of Pabel to rest,..."*)

### Węzeł `[532]`
Mówca: **Titus Gordion**
> ""I'm pleased to have put your suspicion of Pabel to rest, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[533]`
Mówca: **Lucita Azaro**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[874]` (*Lucita Azaro: ""Perhaps you're better off not knowing where your butler ..."*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Lucita Azaro: ""Well, Your Majesty...""*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Titus Gordion: ""Well, sir, in the course of charting out Mr. Adria's exa..."*)

### Węzeł `[537]`
Mówca: **Titus Gordion**
> ""Well, sir, in the course of charting out Mr. Adria's exact activities on that night, my team made a rather... interesting discovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Player_Romus: ""If it's not germane to the case, I don't want to hear ab..."*)
  - -> `[892]` (*Player_Romus: ""Good interesting, or bad interesting?""*)
  - -> `[540]` (*Player_Romus: ""All right, let's hear it.""*)

### Węzeł `[538]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's ridiculous. You will tell me at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[874]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Lucita Azaro: ""Very well. Though this has absolutely no bearing on the ..."*)

### Węzeł `[539]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why not? Was he involved in illegal activity?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[874]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Lucita Azaro: ""In a manner of speaking...""*)

### Węzeł `[540]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, let's hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[537]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Narrator: "He drew in a breath through clenched teeth."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]` (*Lucita Azaro: ""Let's move on, shall we?""*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]` (*Titus Gordion: ""I am, however, obliged to tell you that in the course of..."*)

### Węzeł `[546]`
Mówca: **Lucita Azaro**
> "“After extensive interviews with palace staff, it was determined that Pabel was in the wine cellar the entire time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Lucita Azaro: ""The scuttlebutt has it that he was having a secret rende..."*)

### Węzeł `[547]`
Mówca: **Titus Gordion**
> "“After extensive interviews with palace staff, it was determined that Pabel spent an inordinate amount of time in the wine cellar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Titus Gordion: "“Some suspect him of having a secret rendezvous.""*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That old dog… Good for him! Who was the lucky lady?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[702]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If my butler had a secret lover, I would know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[701]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[550]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How very unprofessional -- not to mention, inappropriate. With whom was he engaged in this… 'rendezvous?'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[701]` (Lucita Azaro), `[702]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player_Romus: ""How very unprofessional -- not to mention, inappropriate..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Player_Romus: ""In the wine cellar? With whom was he engaged in this… 'r..."*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Player_Romus: ""My faith guides me to condemn such actions. I'm highly d..."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Player_Romus: ""I'm highly disappointed in Pabel's behavior.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the wine cellar? With whom was he engaged in this… 'rendezvous?'""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[701]` (Lucita Azaro), `[702]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My faith guides me to condemn such actions. I'm highly disappointed in Pabel's behavior.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[701]` (Lucita Azaro), `[702]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm highly disappointed in Pabel's behavior.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[701]` (Lucita Azaro), `[702]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel and I are old friends, so I'll bring this up with him myself. No need to drag the law into it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[561]`
Mówca: **Lucita Azaro**
> ""More like lucky gentleman, if you catch my meaning...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Lucita Azaro: ""More like lucky gentleman, if you catch my meaning...""*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Titus Gordion: ""Actually, sir, he wasn't with a woman.""*)

### Węzeł `[565]`
Mówca: **Titus Gordion**
> ""Actually, sir, he wasn't with a woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[566]`
Mówca: **Lucita Azaro**
> ""I have to confess, I had a feeling about Pabel since our trip to Qalus. I'm not surprised at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Lucita Azaro: ""That said... we were unable to turn up any conclusive ev..."*)

### Węzeł `[567]`
Mówca: **Titus Gordion**
> ""We didn't turn up any conclusive evidence of what your butler and the courier were doing together. So this is all pure speculation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let's keep this between us to avoid it from becoming public and causing a scandal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pervert residing in front of my very nose. Keep an eye on him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep an eye on him. The last thing I need is my butler flaunting his criminal lifestyle.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Player_Romus: ""A pervert residing in front of my very nose. Keep an eye..."*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Player_Romus: ""Keep an eye on him. The last thing I need is my butler f..."*)

### Węzeł `[574]`
Mówca: **Lucita Azaro**
> ""I won’t tell anyone. You have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Lucita Azaro: ""I won’t tell anyone. You have my word.""*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Titus Gordion: ""I won't disclose this to anyone.""*)

### Węzeł `[578]`
Mówca: **Titus Gordion**
> ""I won't disclose this to anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Lucita Azaro: ""That's your prerogative.""*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Titus Gordion: ""Certainly, sir.""*)

### Węzeł `[582]`
Mówca: **Lucita Azaro**
> ""That's your prerogative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[583]`
Mówca: **Titus Gordion**
> ""Certainly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Lucita Azaro: ""Very well, Your Majesty.""*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Titus Gordion: ""Very well, sir.""*)

### Węzeł `[587]`
Mówca: **Lucita Azaro**
> ""Very well, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[588]`
Mówca: **Titus Gordion**
> ""Very well, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[589]`
Mówca: **Lucita Azaro**
> ""In any case, Pabel is innocent -- of murdering His Majesty King Valero, at least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true; RiziaDL..."*)

### Węzeł `[590]`
Mówca: **Titus Gordion**
> ""In any case, what we discovered about Pabel absolves him of any culpability in King Valero's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true; RiziaDL..."*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Lucita Azaro: ""In any case, Pabel is innocent -- of murdering His Majes..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Titus Gordion: ""In any case, what we discovered about Pabel absolves him..."*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspects Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "Suspects Hub"*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as it doesn't interfere with his duties, I don’t see an issue. Let's stay focused on the task at hand, please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[596]`
Mówca: **Lucita Azaro**
> ""You're right. Pabel's love life or lack thereof is not relevant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Lucita Azaro: ""You're right. Pabel's love life or lack thereof is not r..."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Titus Gordion: ""Of course. We shouldn't lose sight of our main objective.""*)

### Węzeł `[600]`
Mówca: **Titus Gordion**
> ""Of course. We shouldn't lose sight of our main objective.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectPabel = true; RiziaDLC.Relations_Pabel_OutedToPlayer = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] = true;
Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[602]`
Mówca: **Lucita Azaro**
> ""A delivery person from Cantuavo vineyards who was dropping off casks of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""I’ll see to it that she’s reported to the Cantuavos for ..."*)
  - -> `[614]` (*Player_Romus: ""She should be fired, immediately.""*)
  - -> `[613]` (*Player_Romus: ""Her heedless and disrespectful actions should be conveye..."*)
  - -> `[918]` (*Player_Romus: ""Meh. Her behavior isn’t worth bringing to the Cantuavos’..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Lucita Azaro: ""A delivery person from Cantuavo vineyards who was droppi..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Titus Gordion: ""As it happens, it was a delivery person from Cantuavo vi..."*)

### Węzeł `[606]`
Mówca: **Titus Gordion**
> ""As it happens, it was a delivery person from Cantuavo vineyards who was dropping off casks of wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""I’ll see to it that she’s reported to the Cantuavos for ..."*)
  - -> `[614]` (*Player_Romus: ""She should be fired, immediately.""*)
  - -> `[613]` (*Player_Romus: ""Her heedless and disrespectful actions should be conveye..."*)
  - -> `[918]` (*Player_Romus: ""Meh. Her behavior isn’t worth bringing to the Cantuavos’..."*)

### Węzeł `[607]`
Mówca: **Lucita Azaro**
> ""The other individual was supposedly a Cantuavo vineyards' delivery person dropping off wine casks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""I’ll see to it that she’s reported to the Cantuavos for ..."*)
  - -> `[614]` (*Player_Romus: ""She should be fired, immediately.""*)
  - -> `[613]` (*Player_Romus: ""Her heedless and disrespectful actions should be conveye..."*)
  - -> `[918]` (*Player_Romus: ""Meh. Her behavior isn’t worth bringing to the Cantuavos’..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Lucita Azaro: ""The other individual was supposedly a Cantuavo vineyards..."*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Titus Gordion: ""The other person was supposedly a Cantuavo vineyards' de..."*)

### Węzeł `[611]`
Mówca: **Titus Gordion**
> ""The other person was supposedly a Cantuavo vineyards' delivery person dropping off wine casks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""I’ll see to it that she’s reported to the Cantuavos for ..."*)
  - -> `[614]` (*Player_Romus: ""She should be fired, immediately.""*)
  - -> `[613]` (*Player_Romus: ""Her heedless and disrespectful actions should be conveye..."*)
  - -> `[918]` (*Player_Romus: ""Meh. Her behavior isn’t worth bringing to the Cantuavos’..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I’ll see to it that she’s reported to the Cantuavos for her indiscretion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Lucita Azaro), `[606]` (Titus Gordion), `[607]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[613]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Her heedless and disrespectful actions should be conveyed to the Cantuavos.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Lucita Azaro), `[606]` (Titus Gordion), `[607]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[614]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She should be fired, immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Lucita Azaro), `[606]` (Titus Gordion), `[607]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[615]`
Mówca: **Lucita Azaro**
> ""Not 'her.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Lucita Azaro: ""'He.'""*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Lucita Azaro: ""Not 'her.'""*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Titus Gordion: ""Actually, sir, the 'her' is a *he*.""*)

### Węzeł `[619]`
Mówca: **Titus Gordion**
> ""Actually, sir, the 'her' is a *he*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Narrator: "He peered at me closely, trying to gauge my reaction to t..."*)

### Węzeł `[620]`
Mówca: **Lucita Azaro**
> ""Not 'she.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Lucita Azaro: ""He.""*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Lucita Azaro: ""Not 'she.'""*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Titus Gordion: ""Actually, sir, the 'she' is a *he*.""*)

### Węzeł `[624]`
Mówca: **Titus Gordion**
> ""Actually, sir, the 'she' is a *he*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Narrator: "He peered at me closely, trying to gauge my reaction to t..."*)

### Węzeł `[625]`
Mówca: **Lucita Azaro**
> ""He.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Narrator: "She peered at me closely, trying to gauge my reaction to ..."*)

### Węzeł `[626]`
Mówca: **Lucita Azaro**
> ""'He.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Narrator: "She peered at me closely, trying to gauge my reaction to ..."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true"*)
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedToPlayer == true)"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Player_Romus: ""What?! I had no idea.""*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedToPlayer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Player_Romus: ""I knew it.""*)
  - -> `[904]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[630]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?! I had no idea.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[631]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as Pabel didn't kill my father, I don't care what he was doing that night.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[632]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[633]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, this just keeps getting better and better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[634]`
Mówca: **Lucita Azaro**
> ""If this assignation occurred, it was with a courier from the Cantuavo vineyards. A man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Narrator: "She peered at me closely, trying to gauge my reaction to ..."*)

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
  - -> `[634]` (*Lucita Azaro: ""If this assignation occurred, it was with a courier from..."*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Titus Gordion: ""If this assignation occurred, it was with a courier from..."*)

### Węzeł `[638]`
Mówca: **Titus Gordion**
> ""If this assignation occurred, it was with a courier from the Cantuavo vineyards. A male one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Narrator: "He peered at me closely, trying to gauge my reaction to t..."*)

### Węzeł `[639]`
Mówca: **Lucita Azaro**
> ""It was supposedly a man, by the way. A courier from the Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Narrator: "She peered at me closely, trying to gauge my reaction to ..."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Lucita Azaro: ""This was months before your coronation. And the individu..."*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Titus Gordion: ""This occurred months before your coronation, and the ind..."*)

### Węzeł `[643]`
Mówca: **Titus Gordion**
> ""You might be surprised to know that it was a man. A courier from the Cantuavo vineyards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Narrator: "He peered at me closely, trying to gauge my reaction to t..."*)

### Węzeł `[644]`
Mówca: **Titus Gordion**
> ""As is my duty, I was standing guard outside your father's room that night, but departed for half an hour to attend a personal matter, leaving one of my guardsmen in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Titus Gordion: ""When I returned, he informed me nothing out of the ordin..."*)

### Węzeł `[645]`
Mówca: **Titus Gordion**
> ""Given her high rank in your cabinet and access to sensitive government information, her exact activities on that night should be ascertained as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectLucita = true;"*)

### Węzeł `[646]`
Mówca: **Titus Gordion**
> ""I can't attest to that. I'm only presenting what I've been able to gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectLucita = true;"*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do hope you're not suggesting they were doing something... impure.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Titus Gordion: ""I would never suggest such a thing. However...""*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Player_Romus: ""I do hope you're not suggesting they were doing somethin..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player_Romus: ""You're implying they were secret lovers or something?""*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you left your post while on duty? Not the best way to start your case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Titus Gordion: ""And I take full responsibility for it. I can assure you ..."*)

### Węzeł `[652]`
Mówca: **Titus Gordion**
> ""And I take full responsibility for it. I can assure you that it was an exceptional circumstance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Titus Gordion: ""But as I was saying...""*)

### Węzeł `[653]`
Mówca: **Titus Gordion**
> ""But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Titus Gordion: ""When I questioned the guardsman, he claimed Lucita had p..."*)

### Węzeł `[654]`
Mówca: **Titus Gordion**
> ""I suspect she may have been carrying a letter, but I cannot confirm its contents, recipient, or sender.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Titus Gordion: ""When we searched your father's chambers later, we found ..."*)

### Węzeł `[655]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a lot of speculation and no sustenance.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[383]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Titus Gordion: ""I'm only presenting what I've been able to gather.""*)

### Węzeł `[656]`
Mówca: **Titus Gordion**
> ""I'm only presenting what I've been able to gather.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectLucita = true;"*)

### Węzeł `[657]`
Mówca: **Titus Gordion**
> ""I had my suspicions that she might have been carrying letters, but I couldn't ascertain the sender, the recipients, or the contents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Titus Gordion: ""When we searched your father's chambers later, we found ..."*)

### Węzeł `[658]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds like a lot of speculation and no sustenance. I was expecting more from you.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[383]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Titus Gordion: ""I'm only presenting what I've been able to gather.""*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Player_Romus: ""Sounds like a lot of speculation and no sustenance. I wa..."*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Player_Romus: ""Sounds like a lot of speculation and no sustenance.""*)

### Węzeł `[662]`
Mówca: **Narrator**
> "On the palace balcony, I sought refuge from the relentless affairs of the state."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Narrator: "The grandeur of the night sky spread before me, stars pun..."*)

### Węzeł `[663]`
Mówca: **Narrator**
> "The grandeur of the night sky spread before me, stars punctuating the obsidian expanse like celestial jewels."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "And the city's distant lights shimmered, a testament to l..."*)

### Węzeł `[664]`
Mówca: **Narrator**
> "Amid this tranquil backdrop, I found a brief respite from the responsibilities that weighed on my shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[665]`
Mówca: **Narrator**
> "It was during this peaceful interlude that Captain Gordion approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Narrator: "His presence on the balcony hinted at an urgent matter, a..."*)

### Węzeł `[666]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "AddConversant("Lucita Azaro");"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Narrator: "On the palace balcony, I sought refuge from the relentles..."*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[671]`
Mówca: **Narrator**
> "It was during this peaceful interlude that Lucita approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Narrator: "Her presence on the balcony was a reminder that, as a mon..."*)

### Węzeł `[672]`
Mówca: **Narrator**
> "Her presence on the balcony was a reminder that, as a monarch, even moments of solitude could be fleeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)

### Węzeł `[673]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Narrator: "It was during this peaceful interlude that Captain Gordio..."*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Lucita Azaro");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Lucita Azaro");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Narrator: "It was during this peaceful interlude that Lucita approac..."*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC...."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Narrator: "The only question was whether she was here for an urgent ..."*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Lucita Azaro: ""Good evening, Your Majesty.""*)

### Węzeł `[678]`
Mówca: **Narrator**
> "The only question was whether she was here for an urgent matter or..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Narrator: "...something else."*)

### Węzeł `[679]`
Mówca: **Narrator**
> "...something else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Lucita Azaro: ""Good evening, Your Majesty.""*)

### Węzeł `[680]`
Mówca: **Lucita Azaro**
> ""Good evening, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Player_Romus: ""Lucita. To what do I owe this pleasure?""*)
  - -> `[408]` (*Player_Romus: ""Yes? Something on your mind?""*)
  - -> `[409]` (*Player_Romus: ""Please tell me you're here because you have information ..."*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Re..."*)
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC...."*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Narrator: "Business only, it seemed."*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true || RiziaDLC.Relations_Lucita_PromisedDate)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true  or  Variable["RiziaDLC.Relations_Lucita_PromisedDate"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""Well, what are you waiting for? Spit it out.""*)
  - -> `[413]` (*Player_Romus: ""Really? In that case, let's hear it.""*)
  - -> `[411]` (*Player_Romus: ""Oh, do tell! I'm eager to know what you've uncovered.""*)
  - -> `[406]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[684]`
Mówca: **Narrator**
> "Business only, it seemed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Player_Romus: ""Well, what are you waiting for? Spit it out.""*)
  - -> `[413]` (*Player_Romus: ""Really? In that case, let's hear it.""*)
  - -> `[411]` (*Player_Romus: ""Oh, do tell! I'm eager to know what you've uncovered.""*)
  - -> `[406]` (*Player_Romus_Italic: "Say nothing."*)

### Węzeł `[685]`
Mówca: **Titus Gordion**
> ""Everything's fine. No need to worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Titus Gordion: ""I'm here to discuss that *personal matter* you asked me ..."*)

### Węzeł `[686]`
Mówca: **Titus Gordion**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Titus Gordion: ""I'm here to discuss that *personal matter* you asked me ..."*)

### Węzeł `[687]`
Mówca: **Titus Gordion**
> ""I apologize if I startled you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Titus Gordion: ""I'm here to discuss that *personal matter* you asked me ..."*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false && RiziaDL..."*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.InvestigatePoisoning_NoPabel == false && Rizia..."*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player_Romus: ""I want to know why you suspect Pabel.""*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.InvestigatePoisoning_NoPabel == false &&
RiziaDLC.Turn05_MurderInvest_SuspectPabel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false  and 
Variable["RiziaDLC.Turn05_MurderInvest_SuspectPabel"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Lucita_Together == true"*)
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Lucita_Together == true)"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Lucita_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Lucita_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]` (*Narrator: "If our relationship was to continue, I wanted to make sur..."*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Lucita_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Lucita_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Narrator: "I took no pleasure in suspecting my own councilor, but it..."*)

### Węzeł `[694]`
Mówca: **Narrator**
> "But if Titus' suspicions were true, it raised a significant question... whom in my inner circle could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true"*)
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)"*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Narrator: "I assured myself that investigating Hugo was the right co..."*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn05_MurderInvest_InvestigateHugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn05_MurderInvest_InvestigateHugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_InvestigateLucita == true"*)

### Węzeł `[698]`
Mówca: **Narrator**
> "I took no pleasure in suspecting a member of my own family, but the evidence had been laid out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Narrator: "And if my suspicions turned out to be true, it begged the..."*)

### Węzeł `[699]`
Mówca: **Narrator**
> "I assured myself that investigating Hugo was the right course of action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[698]` (*Narrator: "I took no pleasure in suspecting a member of my own famil..."*)

### Węzeł `[700]`
Mówca: **Narrator**
> "And if my suspicions turned out to be true, it begged the question... whom in my inner circle could I trust?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[701]`
Mówca: **Lucita Azaro**
> ""The scuttlebutt has it that he was having a secret rendezvous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Player_Romus: ""If my butler had a secret lover, I would know.""*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[702]`
Mówca: **Titus Gordion**
> "“Some suspect him of having a secret rendezvous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Player_Romus: ""That old dog… Good for him! Who was the lucky lady?""*)
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[703]`
Mówca: **Lucita Azaro**
> ""This was months before your coronation. And the individual in question hasn't returned to the palace since.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Lucita Azaro: ""It was supposedly a man, by the way. A courier from the ..."*)

### Węzeł `[704]`
Mówca: **Titus Gordion**
> ""This occurred months before your coronation, and the individual in question hasn't returned to the palace since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Titus Gordion: ""You might be surprised to know that it was a man. A cour..."*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[707]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"*)

### Węzeł `[707]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Titus Gordion: ""We didn't turn up any conclusive evidence of what your b..."*)

### Węzeł `[708]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"*)
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel)"*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Lucita Azaro: ""I have to confess, I had a feeling about Pabel since our..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn04_Winery_DrinkingGamePabel"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Lucita Azaro: ""I have to confess, I'm not surprised. Your butler is too..."*)

### Węzeł `[711]`
Mówca: **Lucita Azaro**
> ""I have to confess, I'm not surprised. Your butler is too dapper for his own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Lucita Azaro: ""That said... we were unable to turn up any conclusive ev..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true)"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "He looked me straight in the eye."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Titus Gordion: ""But if we catch him in a similar act again, we'll ensure..."*)

### Węzeł `[715]`
Mówca: **Narrator**
> "He looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Titus Gordion: ""But if we catch him in a similar act again, we'll ensure..."*)

### Węzeł `[716]`
Mówca: **Titus Gordion**
> ""But if we catch him in a similar act again, we'll ensure he is adequately punished for his crime.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""Let's keep this between us to avoid it from becoming pub..."*)
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[595]` (*Player_Romus: ""As long as it doesn't interfere with his duties, I don’t..."*)

### Węzeł `[717]`
Mówca: **Lucita Azaro**
> ""That said... we were unable to turn up any conclusive evidence of what he and the courier were doing in the cellar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]` (*Lucita Azaro: ""It could be there's a perfectly innocuous reason they we..."*)

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
  - -> `[721]` (*Narrator: "She looked me straight in the eye."*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Lucita Azaro: ""But if we catch him in a similar act again, you'll be no..."*)

### Węzeł `[721]`
Mówca: **Narrator**
> "She looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Lucita Azaro: ""But if we catch him in a similar act again, you'll be no..."*)

### Węzeł `[722]`
Mówca: **Lucita Azaro**
> ""But if we catch him in a similar act again, you'll be notified right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player_Romus: ""Let's keep this between us to avoid it from becoming pub..."*)
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[595]` (*Player_Romus: ""As long as it doesn't interfere with his duties, I don’t..."*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""Pabel and I are old friends, so I'll bring this up with ..."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Player_Romus: ""No need to raise an alarm because of some palace scuttle..."*)

### Węzeł `[726]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to raise an alarm because of some palace scuttlebutt. I'll ask Pabel about this myself.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[716]` (Titus Gordion), `[722]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[727]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the palace? Well, if she wasn't here, then where was she?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[728]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? Wouldn't have guessed that Mother was still full of surprises.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[915]` (Lucita Azaro), `[916]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Lucita Azaro: ""Speaking of surprises, you'll be interested in hearing w..."*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Titus Gordion: ""Speaking of surprises, you'll want to hear where she rea..."*)

### Węzeł `[732]`
Mówca: **Lucita Azaro**
> ""Speaking of surprises, you'll be interested in hearing where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lucita Azaro: ""...attending a clandestine Dastnurist religious service ..."*)

### Węzeł `[733]`
Mówca: **Titus Gordion**
> ""Speaking of surprises, you'll want to hear where she really was...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Titus Gordion: ""...attending a Dastnurist religious service just outside..."*)

### Węzeł `[734]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're kidding, right?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[425]` (Lucita Azaro), `[429]` (Titus Gordion), `[441]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[735]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Dastnurist service? How can this be?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[425]` (Lucita Azaro), `[429]` (Titus Gordion), `[470]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[736]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A part of me hopes this information is inaccurate.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[247]` (Lucita Azaro), `[251]` (Titus Gordion), `[252]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[737]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[739]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)"*)

### Węzeł `[738]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Titus Gordion: ""I know how disconcerting this news might be, especially ..."*)

### Węzeł `[739]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Titus Gordion: ""I understand how unsettling this might be.""*)

### Węzeł `[740]`
Mówca: **Titus Gordion**
> ""I understand how unsettling this might be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Titus Gordion: ""However, the information is reliable. The guardsman who ..."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == true"*)
  - -> `[743]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)"*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Titus Gordion: ""Given that Wruhecism is not only a faith but a state ins..."*)

### Węzeł `[743]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Titus Gordion: ""I understand how disconcerting this news might be. But...""*)

### Węzeł `[744]`
Mówca: **Titus Gordion**
> ""I understand how disconcerting this news might be. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Titus Gordion: ""Considering her upbringing in Zille, where Dastnurity is..."*)

### Węzeł `[745]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn05_MurderInvest_SuspectLucita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn05_MurderInvest_SuspectLucita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspects Hub]"*)

### Węzeł `[746]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false"*)
  - -> `[748]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.InvestigatePoisoning_NoPabel == false)"*)

### Węzeł `[747]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "Titus discreetly looked around as if making sure there wa..."*)

### Węzeł `[748]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.InvestigatePoisoning_NoPabel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Narrator: "Titus looked around discreetly as if making sure there wa..."*)

### Węzeł `[749]`
Mówca: **Narrator**
> "Titus looked around discreetly as if making sure there was no one else with us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Titus Gordion: ""My initial list of suspects comprised four individuals. ..."*)

### Węzeł `[750]`
Mówca: **Titus Gordion**
> ""My initial list of suspects comprised four individuals. Lucita Azaro, Grand Wiseman Ignacius, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""My mother? How dare you insinuate such an awful thing.""*)
  - -> `[9]` (*Player_Romus: ""I hope you've narrowed it down from there.""*)
  - -> `[8]` (*Player_Romus: ""You're conveniently forgetting yourself.""*)

### Węzeł `[751]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.InvestigatePoisoning_NoPabel == false"*)
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.InvestigatePoisoning_NoPabel == false)"*)

### Węzeł `[752]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.InvestigatePoisoning_NoPabel == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Lucita Azaro: ""My initial list comprised five individuals: Captain Gord..."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.InvestigatePoisoning_NoPabel == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.InvestigatePoisoning_NoPabel"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Lucita Azaro: ""My initial list comprised four individuals: Captain Gord..."*)

### Węzeł `[754]`
Mówca: **Lucita Azaro**
> ""My initial list comprised four individuals: Captain Gordion, Grand Wiseman Ignacius, your uncle, and your mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""My mother? How dare you insinuate such an awful thing.""*)
  - -> `[9]` (*Player_Romus: ""I hope you've narrowed it down from there.""*)

### Węzeł `[755]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Please tell me you fired him.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Titus Gordion: ""Of course I did.""*)

### Węzeł `[756]`
Mówca: **Titus Gordion**
> ""Of course I did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Titus Gordion: ""In his defense, he claimed that Lucita had shown him an ..."*)

### Węzeł `[757]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[759]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[758]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[760]` (*Player_Romus: ""His head will roll for that blunder.""*)

### Węzeł `[759]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[755]` (*Player_Romus: ""What? Please tell me you fired him.""*)

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His head will roll for that blunder.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[371]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[761]` (*Titus Gordion: ""He has been dishonorably discharged from his duties, You..."*)

### Węzeł `[761]`
Mówca: **Titus Gordion**
> ""He has been dishonorably discharged from his duties, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Titus Gordion: ""In his defense, he claimed that Lucita had shown him an ..."*)

### Węzeł `[762]`
Mówca: **Titus Gordion**
> ""In his defense, he claimed that Lucita had shown him an official order signed by your father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Player_Romus: ""And you believed him?""*)
  - -> `[378]` (*Player_Romus: ""An order? What for?""*)
  - -> `[380]` (*Player_Romus: ""If true, we need to verify its authenticity.""*)

### Węzeł `[763]`
Mówca: **Titus Gordion**
> ""I don't truly believe your esteemed uncle would commit fratricide, but no stone must be left unturned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Titus Gordion: ""After supper on the night Valero died, His Grace accompa..."*)

### Węzeł `[764]`
Mówca: **Titus Gordion**
> ""I did not listen in to their conversation. But a maid who was on duty at the time claims she overheard snippets of an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "Suspect Hugo"*)

### Węzeł `[765]`
Mówca: **Lucita Azaro**
> ""Your Golden Guardsman claims not to remember what they were talking about. But the maid who was on duty at the time says she overheard snippets of an argument.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "Suspect Hugo"*)

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An argument? About what?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false`
- **Kontekst wejściowy (poprzednik):** `[764]` (Titus Gordion), `[765]` (Lucita Azaro), `[804]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[767]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Dinner was hours before the time of death. How could Hugo have killed him?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false`
- **Kontekst wejściowy (poprzednik):** `[764]` (Titus Gordion), `[765]` (Lucita Azaro), `[804]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[768]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying Titus was lying?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[764]` (Titus Gordion), `[765]` (Lucita Azaro), `[804]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Lucita Azaro: ""Hard to say. He may have thought it inappropriate to lis..."*)

### Węzeł `[769]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could this maid have been lying?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Kontekst wejściowy (poprzednik):** `[764]` (Titus Gordion), `[765]` (Lucita Azaro), `[804]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[783]` (*Titus Gordion: ""I don't see why she would have been. Unless...""*)

### Węzeł `[770]`
Mówca: **Lucita Azaro**
> ""He could have slipped him a slow-acting poison. Either on the stairs or while escorting the King into his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Lucita Azaro: ""Captain Gordion claims to have witnessed no such thing. ..."*)

### Węzeł `[771]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[772]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[773]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[772]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Lucita Azaro: ""He could have slipped him a slow-acting poison. Either o..."*)

### Węzeł `[773]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Titus Gordion: ""He could have slipped him a slow-acting poison. Either o..."*)

### Węzeł `[774]`
Mówca: **Lucita Azaro**
> ""Hard to say. He may have thought it inappropriate to listen in on the Royal Family's conversations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Lucita Azaro: ""Or there's something about the content of this argument ..."*)

### Węzeł `[775]`
Mówca: **Titus Gordion**
> ""He could have slipped him a slow-acting poison. Either on the stairs or while escorting the King into his chambers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Titus Gordion: ""I personally witnessed no such thing. But there's a slim..."*)

### Węzeł `[776]`
Mówca: **Lucita Azaro**
> ""Apparently, the King shouted, 'He is not yet ready!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[781]` (*Narrator: "She shrugged."*)

### Węzeł `[777]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[779]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[778]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[776]` (*Lucita Azaro: ""Apparently, the King shouted, 'He is not yet ready!""*)

### Węzeł `[779]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Titus Gordion: ""Apparently, the King shouted out, 'He is not yet ready!""*)

### Węzeł `[780]`
Mówca: **Titus Gordion**
> ""Apparently, the King shouted out, 'He is not yet ready!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Titus Gordion: ""Those are the only words she remembered.""*)

### Węzeł `[781]`
Mówca: **Narrator**
> "She shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[782]` (*Lucita Azaro: ""Which doesn't clear anything up.""*)

### Węzeł `[782]`
Mówca: **Lucita Azaro**
> ""Which doesn't clear anything up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Argument = true"*)

### Węzeł `[783]`
Mówca: **Titus Gordion**
> ""I don't see why she would have been. Unless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Titus Gordion: ""Someone might have convinced her to give this statement...."*)

### Węzeł `[784]`
Mówca: **Titus Gordion**
> ""Those are the only words she remembered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Argument = true"*)

### Węzeł `[785]`
Mówca: **Lucita Azaro**
> ""Captain Gordion claims to have witnessed no such thing. But a lot gets by him, it seems...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Timing = true"*)

### Węzeł `[786]`
Mówca: **Titus Gordion**
> ""I personally witnessed no such thing. But there's a slim possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Timing = true"*)

### Węzeł `[787]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false..."*)
  - -> `[789]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == fal..."*)

### Węzeł `[788]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Player_Romus: ""Are you saying Titus was lying?""*)

### Węzeł `[789]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspect Hugo]"*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false"*)
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Investigation_SuspectHugo_Argument == ..."*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[766]` (*Player_Romus: ""An argument? About what?""*)

### Węzeł `[793]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Argument = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Argument"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspect Hugo]"*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false"*)
  - -> `[797]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Investigation_SuspectHugo_Timing == fa..."*)

### Węzeł `[796]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Player_Romus: ""Dinner was hours before the time of death. How could Hug..."*)

### Węzeł `[797]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[798]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Suspect Hugo`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false..."*)
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Argument == false"*)
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Timing == false"*)
  - -> `[800]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false..."*)
  - -> `[806]` (*Player_Romus: ""Enough about the maid. Is there any other reason to susp..."*)

### Węzeł `[799]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Timing = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Timing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspect Hugo]"*)

### Węzeł `[800]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false..."*)
  - -> `[802]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == fal..."*)

### Węzeł `[801]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[769]` (*Player_Romus: ""Could this maid have been lying?""*)

### Węzeł `[802]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Investigation_SuspectHugo_Lying == false && RiziaDLC.PoisonInvestigator_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] == false  and  Variable["RiziaDLC.PoisonInvestigator_Titus"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[803]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Investigation_SuspectHugo_Lying"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "Jump to: [Suspect Hugo]"*)

### Węzeł `[804]`
Mówca: **Lucita Azaro**
> ""Or there's something about the content of this argument that he wants to hide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true"*)

### Węzeł `[805]`
Mówca: **Titus Gordion**
> ""Someone might have convinced her to give this statement. Someone who wanted to cast aspersions on Hugo to throw us off her -- their -- trail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Investigation_SuspectHugo_Lying = true"*)

### Węzeł `[806]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough about the maid. Is there any other reason to suspect Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[764]` (Titus Gordion), `[765]` (Lucita Azaro), `[804]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Suspect Hugo]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Węzeł Logiki Narracyjnej: "Suspect Hugo"*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Lucita Azaro: ""Well...""*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Titus Gordion: ""Well...""*)

### Węzeł `[811]`
Mówca: **Lucita Azaro**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Lucita Azaro: ""The councilors and aides I questioned admitted to sensin..."*)

### Węzeł `[812]`
Mówca: **Lucita Azaro**
> ""The councilors and aides I questioned admitted to sensing mistrust between the two brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Lucita Azaro: ""But as you well know, there was almost nobody King Valer..."*)

### Węzeł `[813]`
Mówca: **Titus Gordion**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[814]` (*Titus Gordion: ""The councilors and aides I questioned admitted to sensin..."*)

### Węzeł `[814]`
Mówca: **Titus Gordion**
> ""The councilors and aides I questioned admitted to sensing mistrust between the two brothers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[816]` (*Titus Gordion: ""But King Valero's paranoia at that stage of his life is ..."*)

### Węzeł `[815]`
Mówca: **Lucita Azaro**
> ""But as you well know, there was almost nobody King Valero trusted by then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""If your account is accurate, we need to find out more.""*)
  - -> `[24]` (*Player_Romus: ""I seriously find it hard to believe that my uncle would ..."*)
  - -> `[84]` (*Player_Romus: ""Is that all? That doesn't prove he had a hand in anything.""*)
  - -> `[23]` (*Player_Romus: ""This is all too vague. I want cold, hard facts.""*)

### Węzeł `[816]`
Mówca: **Titus Gordion**
> ""But King Valero's paranoia at that stage of his life is well documented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player_Romus: ""If your account is accurate, we need to find out more.""*)
  - -> `[24]` (*Player_Romus: ""I seriously find it hard to believe that my uncle would ..."*)
  - -> `[84]` (*Player_Romus: ""Is that all? That doesn't prove he had a hand in anything.""*)
  - -> `[23]` (*Player_Romus: ""This is all too vague. I want cold, hard facts.""*)

### Węzeł `[817]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sure I believe that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[824]` (Lucita Azaro), `[825]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[821]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[818]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[820]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[819]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player_Romus: ""How wise of my father. I hope he found the serenity he w..."*)

### Węzeł `[820]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[821]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[822]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[823]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[822]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lucita Azaro: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[823]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""What's interesting is that aside from those meetings, wi..."*)

### Węzeł `[824]`
Mówca: **Lucita Azaro**
> ""According to the Grand Wiseman himself, Valero turned towards God when he sensed that the end of his life was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""My father turned towards God... and away from everyone e..."*)
  - -> `[98]` (*Player_Romus: ""Makes sense. He had plenty to atone for.""*)
  - -> `[817]` (*Player_Romus: ""I'm not sure I believe that.""*)
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[825]`
Mówca: **Titus Gordion**
> ""According to the Grand Wiseman himself, Valero turned toward God when he sensed that the end of his life was coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""My father turned towards God... and away from everyone e..."*)
  - -> `[98]` (*Player_Romus: ""Makes sense. He had plenty to atone for.""*)
  - -> `[817]` (*Player_Romus: ""I'm not sure I believe that.""*)
  - -> `[818]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[826]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He wanted his enlightenment straight from the tap. I don't blame him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucita Azaro), `[336]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[827]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you implying that the two of them were planning something?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucita Azaro), `[336]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[828]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Player_Romus: ""Blasphemy! I myself have attended every single service s..."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[832]` (*Player_Romus: ""That proves nothing. I myself skip services all the time.""*)

### Węzeł `[831]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Blasphemy! I myself have attended every single service since my coronation.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucita Azaro), `[336]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[832]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That proves nothing. I myself skip services all the time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucita Azaro), `[336]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[833]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Grand Wiseman is one of the most respected figures in our kingdom. We should think twice before pointing the finger at him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Lucita Azaro), `[336]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Lucita Azaro: ""Maybe... but I believe this inconsistency is worth looki..."*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Titus Gordion: ""I nonetheless believe this inconsistency is worth lookin..."*)

### Węzeł `[837]`
Mówca: **Lucita Azaro**
> ""Maybe... but I believe this inconsistency is worth looking into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[838]` (*Lucita Azaro: ""Especially since Grand Wiseman Ignacius was one of the l..."*)

### Węzeł `[838]`
Mówca: **Lucita Azaro**
> ""Especially since Grand Wiseman Ignacius was one of the last people to see your father alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[839]`
Mówca: **Titus Gordion**
> ""I nonetheless believe this inconsistency is worth looking into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Titus Gordion: ""Especially since Grand Wiseman Ignacius was one of the l..."*)

### Węzeł `[840]`
Mówca: **Titus Gordion**
> ""Especially since Grand Wiseman Ignacius was one of the last people to see your father alive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[841]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[842]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Lucita Azaro: ""I don't know. But the inconsistency sticks out to me.""*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Titus Gordion: ""It strikes me as unlikely. But the inconsistency sticks ..."*)

### Węzeł `[844]`
Mówca: **Lucita Azaro**
> ""I don't know. But the inconsistency sticks out to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Lucita Azaro: ""I haven't been able to establish a motive for the Grand ..."*)

### Węzeł `[845]`
Mówca: **Lucita Azaro**
> ""I haven't been able to establish a motive for the Grand Wiseman. But the means were there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[846]`
Mówca: **Titus Gordion**
> ""It strikes me as unlikely. But the inconsistency sticks out to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[847]` (*Titus Gordion: ""I haven't been able to establish a motive for the Grand ..."*)

### Węzeł `[847]`
Mówca: **Titus Gordion**
> ""I haven't been able to establish a motive for the Grand Wiseman. But the means were there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[848]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[850]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Lucita Azaro: ""I'm impressed. I could never sit through them myself.""*)

### Węzeł `[850]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Titus Gordion: ""Yes, your commitment to spirituality is a shining exampl..."*)

### Węzeł `[851]`
Mówca: **Titus Gordion**
> ""Yes, your commitment to spirituality is a shining example for the rest of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Titus Gordion: ""I do not want to soil the Grand Wiseman's good name. But..."*)

### Węzeł `[852]`
Mówca: **Lucita Azaro**
> ""I'm impressed. I could never sit through them myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Lucita Azaro: ""I am hesitant to cast blame on the Sanctuary. But I'd li..."*)

### Węzeł `[853]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[854]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[855]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[854]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Lucita Azaro: ""Same here.""*)

### Węzeł `[855]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Titus Gordion: ""The Lord will forgive you. You're a busy man.""*)

### Węzeł `[856]`
Mówca: **Lucita Azaro**
> ""Same here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Lucita Azaro: ""I am hesitant to cast blame on the Sanctuary. But I'd li..."*)

### Węzeł `[857]`
Mówca: **Titus Gordion**
> ""The Lord will forgive you. You're a busy man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Titus Gordion: ""I do not want to soil the Grand Wiseman's good name. But..."*)

### Węzeł `[858]`
Mówca: **Lucita Azaro**
> ""I am hesitant to cast blame on the Sanctuary. But I'd like to find out more about the nature of these meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[859]`
Mówca: **Titus Gordion**
> ""I do not want to soil the Grand Wiseman's good name. But I'm willing to dig further to find out the exact nature of these meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectSal = true;"*)

### Węzeł `[860]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[862]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[861]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Lucita Azaro: ""I am hesitant to cast blame on the Sanctuary. But I'd li..."*)

### Węzeł `[862]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[859]` (*Titus Gordion: ""I do not want to soil the Grand Wiseman's good name. But..."*)

### Węzeł `[863]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PoisonInvestigator_Lucita == true)"*)

### Węzeł `[864]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Narrator: "Lucita leaned forward, listening eagerly."*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PoisonInvestigator_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PoisonInvestigator_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Narrator: "Titus stood at full attention, awaiting my next words."*)

### Węzeł `[866]`
Mówca: **Narrator**
> "Lucita leaned forward, listening eagerly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Hugo is obviously our primary suspect, so focus your inv..."*)
  - -> `[118]` (*Player_Romus: ""Discreetly continue your investigation into Titus. He ha..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[119]` (*Player_Romus: ""This investigation has gone as far as it can go. Cease a..."*)

### Węzeł `[867]`
Mówca: **Narrator**
> "Titus stood at full attention, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player_Romus: ""Hugo is obviously our primary suspect, so focus your inv..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[119]` (*Player_Romus: ""This investigation has gone as far as it can go. Cease a..."*)
  - -> `[392]` (*Player_Romus: ""Keep looking into Lucita's motivation. You might be onto..."*)

### Węzeł `[868]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Right. Dinner and a movie, then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Lucita Azaro: ""I can do better than that.""*)

### Węzeł `[869]`
Mówca: **Lucita Azaro**
> ""I can do better than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She flashed a suggestive smile as she left the chambers."*)

### Węzeł `[870]`
Mówca: **Narrator**
> "If our relationship was to continue, I wanted to make sure she didn't have any skeletons in her closet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "I didn't want to think about what would happen if Titus' ..."*)

### Węzeł `[871]`
Mówca: **Narrator**
> "I took no pleasure in suspecting my own councilor, but it had to be done."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Narrator: "But if Titus' suspicions were true, it raised a significa..."*)

### Węzeł `[872]`
Mówca: **Narrator**
> "There was a note of uncertainty in her voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""What aren't you telling me?""*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[873]`
Mówca: **Narrator**
> "There was a strangely somber tone to his voice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""What aren't you telling me?""*)
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[874]`
Mówca: **Lucita Azaro**
> ""Perhaps you're better off not knowing where your butler was that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Player_Romus: ""If you think I shouldn't know, I trust you. Spare me the..."*)
  - -> `[539]` (*Player_Romus: ""Why not? Was he involved in illegal activity?""*)
  - -> `[538]` (*Player_Romus: ""That's ridiculous. You will tell me at once.""*)
  - -> `[883]` (*Player_Romus: ""Saying that has only made me more curious.""*)

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you think I shouldn't know, I trust you. Spare me the details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[874]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Narrator: "She nodded forcefully."*)

### Węzeł `[876]`
Mówca: **Lucita Azaro**
> ""In a manner of speaking...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[877]` (*Player_Romus: ""Actually, forget it. I don't want to know. Case closed o..."*)
  - -> `[885]` (*Player_Romus: ""All right, now you definitely have to tell me.""*)
  - -> `[886]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true"*)

### Węzeł `[877]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, forget it. I don't want to know. Case closed on Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Narrator: "She nodded forcefully."*)

### Węzeł `[878]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[879]` (*Lucita Azaro: ""Case closed.""*)

### Węzeł `[879]`
Mówca: **Lucita Azaro**
> ""Case closed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;"*)

### Węzeł `[880]`
Mówca: **Lucita Azaro**
> ""Yes, let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;"*)

### Węzeł `[881]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[880]` (*Lucita Azaro: ""Yes, let's move on.""*)

### Węzeł `[882]`
Mówca: **Lucita Azaro**
> ""Very well. Though this has absolutely no bearing on the murder case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Lucita Azaro: "“After extensive interviews with palace staff, it was det..."*)

### Węzeł `[883]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Saying that has only made me more curious.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[874]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Narrator: "She shook her head ruefully."*)

### Węzeł `[884]`
Mówca: **Narrator**
> "She shook her head ruefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Lucita Azaro: ""Very well. Though this has absolutely no bearing on the ..."*)

### Węzeł `[885]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, now you definitely have to tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Narrator: "She shook her head ruefully."*)

### Węzeł `[886]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true"*)
  - -> `[888]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_OutedToPlayer == true )"*)

### Węzeł `[887]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_OutedToPlayer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[889]` (*Player_Romus: ""I think I know what you're getting at. I've already give..."*)

### Węzeł `[888]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_OutedToPlayer == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[889]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I know what you're getting at. I've already given him a talking-to about it.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true`
- **Kontekst wejściowy (poprzednik):** `[876]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Narrator: "She nodded forcefully."*)

### Węzeł `[890]`
Mówca: **Narrator**
> "She nodded forcefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[891]` (*Lucita Azaro: ""If something similar happens again, I don't need or want..."*)

### Węzeł `[891]`
Mówca: **Lucita Azaro**
> ""If something similar happens again, I don't need or want to know about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;"*)

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good interesting, or bad interesting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[537]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]` (*Titus Gordion: ""I'll let you be the judge.""*)

### Węzeł `[893]`
Mówca: **Narrator**
> "He drew in a breath through clenched teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Titus Gordion: "“After extensive interviews with palace staff, it was det..."*)

### Węzeł `[894]`
Mówca: **Titus Gordion**
> ""I'll let you be the judge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Narrator: "He drew in a breath through clenched teeth."*)

### Węzeł `[895]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If it's not germane to the case, I don't want to hear about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[537]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[896]` (*Titus Gordion: ""Really, Your Majesty? This concerns your personal attend..."*)

### Węzeł `[896]`
Mówca: **Titus Gordion**
> ""Really, Your Majesty? This concerns your personal attendant...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]` (*Titus Gordion: ""But as you wish. Let's move on.""*)

### Węzeł `[897]`
Mówca: **Titus Gordion**
> ""But as you wish. Let's move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn05_MurderInvest_SuspectPabel = true;"*)

### Węzeł `[898]`
Mówca: **Titus Gordion**
> ""I am, however, obliged to tell you that in the course of charting out Mr. Adria's exact activities on that night, my team made a rather... interesting discovery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Titus Gordion: "“After extensive interviews with palace staff, it was det..."*)

### Węzeł `[899]`
Mówca: **Lucita Azaro**
> ""Let's move on, shall we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]` (*Player_Romus: ""Yes, gladly. I knew Pabel was innocent all along.""*)

### Węzeł `[900]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, gladly. I knew Pabel was innocent all along.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[899]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Narrator: "She nodded forcefully."*)

### Węzeł `[901]`
Mówca: **Narrator**
> "She peered at me closely, trying to gauge my reaction to the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[902]`
Mówca: **Narrator**
> "He peered at me closely, trying to gauge my reaction to the news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[903]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[903]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_OutedToPlayer == true"*)
  - -> `[631]` (*Player_Romus: ""As long as Pabel didn't kill my father, I don't care wha..."*)
  - -> `[633]` (*Player_Romus: ""Well, this just keeps getting better and better.""*)
  - -> `[908]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)

### Węzeł `[904]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[906]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[905]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]` (*Player_Romus: ""My butler lies with men? He must repent his sodomous way..."*)

### Węzeł `[906]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[907]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My butler lies with men? He must repent his sodomous ways before it's too late!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true` AND `(Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[908]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel <= 0"*)
  - -> `[910]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel <= 0)"*)

### Węzeł `[909]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[911]` (*Player_Romus: ""But that's disgusting. I let him dress me and everything.""*)

### Węzeł `[910]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] <= 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[911]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But that's disgusting. I let him dress me and everything.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Pabel"] <= 0`
- **Kontekst wejściowy (poprzednik):** `[901]` (Narrator), `[902]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[912]`
Mówca: **Lucita Azaro**
> ""It could be there's a perfectly innocuous reason they were down there, and the staff we talked to were spreading rumors out of boredom or spite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true"*)

### Węzeł `[913]`
Mówca: **Lucita Azaro**
> ""But when I questioned the other Golden Guardsmen, one of them admitted that Captain Gordion left his post that night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Lucita Azaro: ""The guardsman assumed Titus' duties for a half hour. The..."*)

### Węzeł `[914]`
Mówca: **Lucita Azaro**
> ""The guardsman assumed Titus' duties for a half hour. The Captain could have gone anywhere during that time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Player_Romus: ""He wasn't at his post? That's not like Titus at all.""*)
  - -> `[41]` (*Player_Romus: ""He probably just went to the toilet.""*)
  - -> `[43]` (*Player_Romus: ""Did he or anyone else enter my father's room during that..."*)

### Węzeł `[915]`
Mówca: **Lucita Azaro**
> ""In between, however, Madam Estela was not in the Palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[33]` (*Player_Romus: ""That's good right?""*)
  - -> `[443]` (*Player_Romus: ""Okay, I'm listening...""*)
  - -> `[51]` (*Player_Romus: ""So my mother has her own share of secrets... guess that ..."*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[916]`
Mówca: **Titus Gordion**
> ""In between, however, Madam Estela was not in the Palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[33]` (*Player_Romus: ""That's good right?""*)
  - -> `[443]` (*Player_Romus: ""Okay, I'm listening...""*)
  - -> `[51]` (*Player_Romus: ""So my mother has her own share of secrets... guess that ..."*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[917]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PoisonInvestigator_Lucita = false;
RiziaDLC.PoisonInvestigator_Titus = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PoisonInvestigator_Lucita"] = false;
Variable["RiziaDLC.PoisonInvestigator_Titus"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meh. Her behavior isn’t worth bringing to the Cantuavos’ attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[602]` (Lucita Azaro), `[606]` (Titus Gordion), `[607]` (Lucita Azaro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PoisonInvestigator_Lucita == true"*)

### Węzeł `[919]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Investigating the former king’s suspicious death", "Palace Balcony", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Investigating the former king’s suspicious death","Palace Balcony","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)
