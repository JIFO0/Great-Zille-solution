# Sordland/Turn10/AloneWithTarquinSoll

- **ID konwersacji:** `223`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/223_AloneWithTarquinSoll.md`
- **Liczba węzłów dialogowych:** 429
- **Liczba wyborów gracza:** 102

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[48]** Tarquin Soll

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.ChiefJustice_OrsoHawker`
- `BaseGame.Decision_Turn08_ExtendEmergency_Extend`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.EconomicDirection_Nationalization`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Ending_Coup`
- `BaseGame.Ending_ImpeachmentTrial`
- `BaseGame.Faction_Oligarchs_Ally`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Policy_Welfare_HealthPrivatization`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Veto_Loophole`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Turn02_FPnT_Consulate_Condemn`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn07_PTV_SollConfrontation`
- `BaseGame.Turn07_Results_Decision_TrySoll`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_Action_Court_OldGuardReplaced`
- `BaseGame.Turn08_Action_Court_Shuffled`
- `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas`
- `BaseGame.Turn09_EnT_SordishDepression`
- `BaseGame.Turn09_EnT_SordishRecovery`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGame.Turn11_Election_AssassinationHappened`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.Turn09_SollTrial_Acquitted`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.AMorgnaWesCore`
- `BaseGame.TarquinSoll_AidsWar`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[222] Sordland/Turn10/Personal_FCAnricaDerby** (../Turn_10/222_Personal_FCAnricaDerby.md), Węzeł `[56]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""To what do we owe this pleasure, Colonel?""** | `[3]` **Narrator**: "Tarquin Soll was already seated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "Tarquin Soll leaned on his cane ..." |
| `[6]` | **""It is good to see you here, Mr. Soll.""** | `[3]` **Narrator**: "Tarquin Soll was already seated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "Tarquin Soll leaned on his cane ..." |
| `[7]` | **""We seem to be crossing each other's paths on the oddest of occasions.""** | `[3]` **Narrator**: "Tarquin Soll was already seated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Narrator**: "Tarquin Soll leaned on his cane ..." |
| `[8]` | **""Are you going to pretend I'm not here?""** | `[3]` **Narrator**: "Tarquin Soll was already seated ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "Tarquin Soll leaned on his cane ..." |
| `[26]` | **""I don't need your respect.""** | `[22]` **Tarquin Soll**: ""I suppose that demands some res..."<br>`[33]` **Tarquin Soll**: ""You have my respect. Albeit beg..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The corner of his mouth curled u..." |
| `[27]` | **""You cannot escape justice forever, Mr. Soll.""** | `[33]` **Tarquin Soll**: ""You have my respect. Albeit beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Tarquin Soll**: ""Your resolve to punish me is pi..." |
| `[31]` | **""That was in the past. I believe we can put it behind us.""** | `[22]` **Tarquin Soll**: ""I suppose that demands some res..."<br>`[33]` **Tarquin Soll**: ""You have my respect. Albeit beg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The corner of his mouth curled u..." |
| `[35]` | **""That's very kind of you, Colonel.""** | `[22]` **Tarquin Soll**: ""I suppose that demands some res..."<br>`[33]` **Tarquin Soll**: ""You have my respect. Albeit beg..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The corner of his mouth curled u..." |
| `[36]` | **""Thank you. I know he had the utmost respect and admiration for you, Colonel.""** | `[43]` **Tarquin Soll**: ""My condolences on the death of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "He nodded." |
| `[44]` | **""His name was Serge. And he wasn't just good; he was the best.""** | `[43]` **Tarquin Soll**: ""My condolences on the death of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "He nodded." |
| `[45]` | **""Everyone involved in the attack will pay for what they've done.""** | `[43]` **Tarquin Soll**: ""My condolences on the death of ..."<br>`[57]` **Tarquin Soll**: ""You have my deepest sympathies."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "He nodded." |
| `[47]` | **""I didn't come here to face you, Mr. Soll. I came here for FC Anrica.""** | `[22]` **Tarquin Soll**: ""I suppose that demands some res..."<br>`[33]` **Tarquin Soll**: ""You have my respect. Albeit beg..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Tarquin Soll**: ""You knew I'd be here."" |
| `[51]` | **"Stay silent."** | `[43]` **Tarquin Soll**: ""My condolences on the death of ..."<br>`[57]` **Tarquin Soll**: ""You have my deepest sympathies."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Tarquin Soll**: ""I must say..."" |
| `[58]` | **""Thank you for your sympathy. It truly means a lot.""** | `[57]` **Tarquin Soll**: ""You have my deepest sympathies."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "He nodded." |
| `[66]` | **""Why? Did you think a few armed men would stop me from going out in public again?""** | `[65]` **Tarquin Soll**: ""It is heartening to see that yo..." | `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true` | *Brak zmian stanu* | `[81]` **Tarquin Soll**: ""I was referring to your *busy* ..." |
| `[67]` | **""I could say the same for you, Mr. Soll.""** | `[65]` **Tarquin Soll**: ""It is heartening to see that yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Narrator**: "The corner of his mouth curled u..." |
| `[68]` | **""I didn't know you were a football fan.""** | `[65]` **Tarquin Soll**: ""It is heartening to see that yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Tarquin Soll**: ""You know I couldn't miss this h..." |
| `[72]` | **""I thought you returned to your island. What are you still doing around here?""** | `[65]` **Tarquin Soll**: ""It is heartening to see that yo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Tarquin Soll**: ""Can't an old man still travel?"" |
| `[73]` | **""Especially when everyone's favorite former president is in the stands.""** | `[34]` **Tarquin Soll**: ""Your support for FC Anrica and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Tarquin Soll**: ""You must be referring to Alphon..." |
| `[74]` | **""I wouldn't have taken you for a football fan, sir.""** | `[34]` **Tarquin Soll**: ""Your support for FC Anrica and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[411]` **Tarquin Soll**: ""I don't watch all the games. Bu..." |
| `[75]` | **""For a retired man, you certainly get around a lot.""** | `[34]` **Tarquin Soll**: ""Your support for FC Anrica and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Tarquin Soll**: ""I would never miss this histori..." |
| `[83]` | **""You can't suppress everything with military power.""** | `[38]` **Tarquin Soll**: ""I thought you would have known ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Tarquin Soll**: ""It doesn't suit you to be so fu..." |
| `[84]` | **""I was naive enough to think justice could be served under the system you'd built...."** | `[38]` **Tarquin Soll**: ""I thought you would have known ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Tarquin Soll**: ""My system is nothing but just. ..." |
| `[85]` | **""You think you're above everything, don't you? Including the law.""** | `[38]` **Tarquin Soll**: ""I thought you would have known ..."<br>`[46]` **Tarquin Soll**: ""You talk of injustice only when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Tarquin Soll**: ""It doesn't suit you to be so fu..." |
| `[86]` | **""Don't speak to me about the courts. We both know that you owe the result to your ..."** | `[46]` **Tarquin Soll**: ""You talk of injustice only when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Tarquin Soll**: ""If that's what you think of the..." |
| `[87]` | **""Are you really going to take me for a fool and tell me that the Court is just and..."** | `[46]` **Tarquin Soll**: ""You talk of injustice only when..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Tarquin Soll**: ""If that's what you think of the..." |
| `[96]` | **""It's great to see you here, sir. Our conversation at the cinema in Erlory was far..."** | `[34]` **Tarquin Soll**: ""Your support for FC Anrica and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Narrator**: "He had a barely visible smile on..." |
| `[109]` | **""It seems that you and I are on the same side.""** | `[101]` **Narrator**: "He gestured to the FC Anrica pin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Tarquin Soll**: ""When it comes to football, yes."" |
| `[113]` | **""Be honest. Does it ever bother you that I'm one of the owners of FC Anrica?""** | `[101]` **Narrator**: "He gestured to the FC Anrica pin..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[114]` **Tarquin Soll**: ""Hah!"" |
| `[116]` | **""I'm sure the team will give it their all, knowing that you and I are watching them.""** | `[101]` **Narrator**: "He gestured to the FC Anrica pin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Tarquin Soll**: ""Unless they crack under pressur..." |
| `[117]` | **""I'm happy to see you so excited, sir.""** | `[101]` **Narrator**: "He gestured to the FC Anrica pin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Tarquin Soll**: ""I'll be more excited when our b..." |
| `[119]` | **""It seems that once again, you and I are on the same side.""** | `[118]` **Narrator**: "He gestured to the FC Anrica pin..."<br>`[408]` **Narrator**: "He chuckled lightly at his joke,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[272]` **Tarquin Soll**: ""The only correct side, Mr. Rayne."" |
| `[123]` | **""As a partner of the club, I must say I am humbled to see that pin on your jacket.""** | `[118]` **Narrator**: "He gestured to the FC Anrica pin..."<br>`[408]` **Narrator**: "He chuckled lightly at his joke,..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[409]` **Tarquin Soll**: ""Ah, yes. I always found it unbe..." |
| `[124]` | **""I'm sure the team will give it their all, knowing that you and I are watching.""** | `[118]` **Narrator**: "He gestured to the FC Anrica pin..."<br>`[408]` **Narrator**: "He chuckled lightly at his joke,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Tarquin Soll**: ""Unless they crack under the pre..." |
| `[125]` | **""I'm happy to see you so excited, sir.""** | `[118]` **Narrator**: "He gestured to the FC Anrica pin..."<br>`[408]` **Narrator**: "He chuckled lightly at his joke,..." | `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false` | *Brak zmian stanu* | `[410]` **Tarquin Soll**: ""I'll be even more excited if th..." |
| `[126]` | **""As a partner of the club, I must say I am humbled to see that pin on your jacket.""** | `[101]` **Narrator**: "He gestured to the FC Anrica pin..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[127]` **Tarquin Soll**: ""Ah, yes. I always found it unbe..." |
| `[131]` | **""Yes, you won. No need to rub that in my face, Colonel.""** | `[105]` **Tarquin Soll**: ""Is everything faring well after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Tarquin Soll**: ""Don't be a fool, Mr. Rayne."" |
| `[132]` | **""I may have not changed the constitution, but I've done my best to reform Sordland..."** | `[105]` **Tarquin Soll**: ""Is everything faring well after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Tarquin Soll**: ""So I have seen. And the results..."<br>`[146]` **Tarquin Soll**: ""So I have seen. But at what exp..." |
| `[133]` | **""That's nothing for you to worry about, Mr. Soll.""** | `[105]` **Tarquin Soll**: ""Is everything faring well after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Tarquin Soll**: ""I will decide what I worry abou..." |
| `[134]` | **""I'll admit. The term could have gone better.""** | `[105]` **Tarquin Soll**: ""Is everything faring well after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Tarquin Soll**: ""We cannot reverse time."" |
| `[135]` | **""Are you still sore because you lost?""** | `[100]` **Tarquin Soll**: ""Is everything faring well with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Tarquin Soll**: ""Don't be a fool, Mr. Rayne."" |
| `[136]` | **""Now that we've put the 1929 Constitution behind us, things are only going to get ..."** | `[100]` **Tarquin Soll**: ""Is everything faring well with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Tarquin Soll**: ""You assume too much."" |
| `[137]` | **""That's nothing for you to worry about, Mr. Soll.""** | `[100]` **Tarquin Soll**: ""Is everything faring well with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Tarquin Soll**: ""I will decide what I worry abou..." |
| `[138]` | **""I'll admit. I'm starting to doubt the effectiveness of some of my reforms.""** | `[100]` **Tarquin Soll**: ""Is everything faring well with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Tarquin Soll**: ""We cannot reverse time."" |
| `[139]` | **""Tell me the truth, Colonel Soll. You knew about the attack, didn't you?""** | `[57]` **Tarquin Soll**: ""You have my deepest sympathies."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Narrator**: "His brow furrowed as he looked a..." |
| `[140]` | **""If you don't mind, Colonel, I'd prefer to watch the match in silence.""** | `[256]` **Tarquin Soll**: ""I rebuilt this Republic with my..."<br>`[321]` **Tarquin Soll**: ""All tyrants get what is coming ..."<br>*(oraz 10 innych węzłów)* | `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`<br>`(Variable["BaseGame.Ending_Coup"] == true) == false` | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[141]` | **""Enough about me. Tell me more about how you and Lileas Graf conspired to throw So..."** | `[256]` **Tarquin Soll**: ""I rebuilt this Republic with my..."<br>`[321]` **Tarquin Soll**: ""All tyrants get what is coming ..."<br>*(oraz 7 innych węzłów)* | `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true` | *Brak zmian stanu* | `[382]` **Tarquin Soll**: ""You made the mistake of your ca..." |
| `[190]` | **""My path is my own to tread. You have no influence over my presidency, Colonel.""** | `[180]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>`[181]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[192]` | **""I understand your concerns, sir, but I beg to differ.""** | `[180]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>`[181]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[193]` | **""I didn't come here to listen to your criticism.""** | `[180]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>`[181]` **Tarquin Soll**: ""I am warning you, Anton. The pa..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[194]` | **""No superpower can match the amount of abuse you've already inflicted on this nati..."** | `[184]` **Tarquin Soll**: ""I am warning you, Anton. The pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[195]` | **""I'm sorry but I'm done with the warmongering and paranoia.""** | `[180]` **Tarquin Soll**: ""I am warning you, Anton. The pa..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[196]` | **""You're one to talk. I've been too busy fixing your messes to make the progress So..."** | `[181]` **Tarquin Soll**: ""I am warning you, Anton. The pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[197]` | **""Regression? How many years did your reign set Sordland back?""** | `[182]` **Tarquin Soll**: ""I am warning you, Anton. The pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[198]` | **""I seriously don't believe I have strayed from the USP's values. All I wanted to d..."** | `[183]` **Tarquin Soll**: ""I am warning you, Anton. Don't ..." | `Variable["BaseGame.Archetype_SollistRayne"] == true` | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[202]` | **""I don't need to hear your threats.""** | `[183]` **Tarquin Soll**: ""I am warning you, Anton. Don't ..." | `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false` | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[226]` | **""That's rich, coming from you of all people.""** | `[224]` **Tarquin Soll**: ""It didn't even take four years ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Tarquin Soll**: ""You believe you are special, do..." |
| `[227]` | **""I am not you, Colonel.""** | `[224]` **Tarquin Soll**: ""It didn't even take four years ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Tarquin Soll**: ""You believe you are special, do..." |
| `[228]` | **""Everything I did was for the development of Sordland.""** | `[224]` **Tarquin Soll**: ""It didn't even take four years ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Tarquin Soll**: ""You alone know what's best for ..." |
| `[229]` | **""I must say, your lack of faith in Sordland is disturbing.""** | `[223]` **Tarquin Soll**: ""I truly hope you are ready for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[255]` **Tarquin Soll**: ""I have nothing but faith in thi..." |
| `[235]` | **""I am doing everything I can to prevent a conflict with them.""** | `[223]` **Tarquin Soll**: ""I truly hope you are ready for ..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[259]` **Tarquin Soll**: ""You must try harder before it's..." |
| `[236]` | **""Why are you so scared, Colonel? If the Rums come, we will show them hell.""** | `[223]` **Tarquin Soll**: ""I truly hope you are ready for ..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[255]` **Tarquin Soll**: ""I have nothing but faith in thi..." |
| `[240]` | **""It's the path that Queen Beatrice chose, not me.""** | `[180]` **Tarquin Soll**: ""I am warning you, Anton. The pa..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[170]` **Tarquin Soll**: ""I don't mean to overstep. But I..."<br>`[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>*(oraz 1 innych odgałęzień)* |
| `[250]` | **""We are ready to crush Rumburg's armies once and for all.""** | `[223]` **Tarquin Soll**: ""I truly hope you are ready for ..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[258]` **Tarquin Soll**: ""The only future is victory."" |
| `[251]` | **""I didn't want it to come to this...""** | `[223]` **Tarquin Soll**: ""I truly hope you are ready for ..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[257]` **Tarquin Soll**: ""It's too late for regrets."" |
| `[252]` | **""I always thought you'd understand me. It's sad to see you be so combative.""** | `[224]` **Tarquin Soll**: ""It didn't even take four years ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[253]` **Tarquin Soll**: ""Oh, but I understand you, Anton..." |
| `[261]` | **""It's nothing for you to worry about, Mr. Soll.""** | `[260]` **Tarquin Soll**: ""Is everything faring well after..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Tarquin Soll**: ""I will decide what I worry abou..." |
| `[262]` | **""Not everyone has been on board with it. But I'm still confident it's the right co..."** | `[267]` **Tarquin Soll**: ""How is everything faring with y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Tarquin Soll**: ""Every decision you make will be..." |
| `[263]` | **""I'll be honest. I am starting to doubt that it was the right decision.""** | `[260]` **Tarquin Soll**: ""Is everything faring well after..."<br>`[267]` **Tarquin Soll**: ""How is everything faring with y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Tarquin Soll**: ""We cannot reverse time."" |
| `[280]` | **""That's not for you to question, sir.""** | `[189]` **Tarquin Soll**: ""I hope your heart is in the rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>`[313]` **Tarquin Soll**: ""In any case... None of that rea..." |
| `[281]` | **""My heart belongs to Sordland.""** | `[189]` **Tarquin Soll**: ""I hope your heart is in the rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>`[313]` **Tarquin Soll**: ""In any case... None of that rea..." |
| `[282]` | **""You know it is, Colonel.""** | `[189]` **Tarquin Soll**: ""I hope your heart is in the rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>`[313]` **Tarquin Soll**: ""In any case... None of that rea..." |
| `[283]` | **""I hope yours is as well.""** | `[189]` **Tarquin Soll**: ""I hope your heart is in the rig..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Tarquin Soll**: ""Be careful, Mr. Rayne. You are ..."<br>`[313]` **Tarquin Soll**: ""In any case... None of that rea..." |
| `[286]` | **""Everything's running as smoothly as possible.""** | `[260]` **Tarquin Soll**: ""Is everything faring well after..."<br>`[267]` **Tarquin Soll**: ""How is everything faring with y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Tarquin Soll**: ""That's very good to hear. I hop..." |
| `[288]` | **""My emergency? I thought it was *your* idea.""** | `[260]` **Tarquin Soll**: ""Is everything faring well after..."<br>`[267]` **Tarquin Soll**: ""How is everything faring with y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Tarquin Soll**: ""Ha! Are you saying you're not r..." |
| `[294]` | **""A Morgna wes core.""** | `[291]` **Tarquin Soll**: ""We must look to the future."" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame....` | `[305]` **Tarquin Soll**: ""Vectern sis da."" |
| `[295]` | **""The future is bright.""** | `[291]` **Tarquin Soll**: ""We must look to the future."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[296]` | **""I'll drink to that.""** | `[291]` **Tarquin Soll**: ""We must look to the future."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Tarquin Soll**: ""Speaking of drinks..."" |
| `[298]` | **""Your wisdom rings true as always, Mr. Soll.""** | `[291]` **Tarquin Soll**: ""We must look to the future."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[301]` | **""You know what? I think I need a drink.""** | `[216]` **Tarquin Soll**: ""Say what you will. Deep down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Tarquin Soll**: ""Speaking of drinks..."" |
| `[302]` | **""You're wrong.""** | `[216]` **Tarquin Soll**: ""Say what you will. Deep down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Tarquin Soll**: ""You still have a lot to learn."" |
| `[303]` | **""You're talking past me, not to me.""** | `[216]` **Tarquin Soll**: ""Say what you will. Deep down in..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Tarquin Soll**: ""You don't know how to listen."" |
| `[339]` | **""The Court now works the way it is supposed to. True justice will be served in Sor..."** | `[338]` **Tarquin Soll**: ""Still, you have my respect. Alb..."<br>`[342]` **Tarquin Soll**: ""I suppose you have my respect."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "The corner of his mouth curled u..." |
| `[346]` | **""I had nothing to do with Hawker's removal. I only appointed a new justice.""** | `[338]` **Tarquin Soll**: ""Still, you have my respect. Alb..."<br>`[342]` **Tarquin Soll**: ""I suppose you have my respect."" | `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true` | *Brak zmian stanu* | `[353]` **Narrator**: "He smiled." |
| `[350]` | **""Whether you respect it or not, you will be next.""** | `[338]` **Tarquin Soll**: ""Still, you have my respect. Alb..."<br>`[342]` **Tarquin Soll**: ""I suppose you have my respect."" | `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true` | *Brak zmian stanu* | `[351]` **Narrator**: "His hand curled into a fist." |
| `[355]` | **""If something will collapse, it will be Rumburg.""** | `[256]` **Tarquin Soll**: ""I rebuilt this Republic with my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." |
| `[356]` | **""And I will never let that happen.""** | `[256]` **Tarquin Soll**: ""I rebuilt this Republic with my..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." |
| `[357]` | **""And I will make sure that it is achieved.""** | `[258]` **Tarquin Soll**: ""The only future is victory."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." |
| `[358]` | **""Vectern sis da.""** | `[258]` **Tarquin Soll**: ""The only future is victory."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." |
| `[359]` | **""We will give them hell, Colonel.""** | `[258]` **Tarquin Soll**: ""The only future is victory."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." |
| `[362]` | **""Thank you.""** | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[363]` | **""I know we have had our differences, to say the least. But I cannot argue with you..."** | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." | `Variable["BaseGame.RumburgIncident_DeclareWar"] == true` | *Brak zmian stanu* | `[370]` **Tarquin Soll**: ""You could certainly use the hel..."<br>`[420]` **Tarquin Soll**: ""You are taking a risk going ove..." |
| `[367]` | **""I know we have had our differences, to say the least. But I cannot argue with you..."** | `[360]` **Tarquin Soll**: ""Good. At least you have the spi..." | `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false` | *Brak zmian stanu* | `[370]` **Tarquin Soll**: ""You could certainly use the hel..."<br>`[420]` **Tarquin Soll**: ""You are taking a risk going ove..." |
| `[371]` | **""Your threats mean nothing to me, Mr. Soll.""** | `[321]` **Tarquin Soll**: ""All tyrants get what is coming ..."<br>`[323]` **Tarquin Soll**: ""The system I built still works...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[372]` | **""I will not give in to your threats.""** | `[324]` **Tarquin Soll**: ""All incompetent leaders get wha..."<br>`[325]` **Tarquin Soll**: ""You who claim to champion justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[375]` | **""Perhaps I do. But what makes you think you should be the one to teach me?""** | `[326]` **Tarquin Soll**: ""You still have a lot to learn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[376]` | **""I respect you, Colonel. I still wish the feeling was mutual.""** | `[304]` **Tarquin Soll**: ""You don't know how to listen.""<br>`[326]` **Tarquin Soll**: ""You still have a lot to learn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[377]` | **""I'm willing to listen.""** | `[304]` **Tarquin Soll**: ""You don't know how to listen.""<br>`[326]` **Tarquin Soll**: ""You still have a lot to learn."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[378]` | **""Whatever you say, I respect you Colonel. I wish we had some understanding.""** | `[324]` **Tarquin Soll**: ""All incompetent leaders get wha..."<br>`[325]` **Tarquin Soll**: ""You who claim to champion justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Narrator**: "A sudden burst of cheering from ..." |
| `[383]` | **""I forgot that you were from Anrica.""** | `[381]` **Narrator**: "Under the portrait, the bottom r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Tarquin Soll**: ""It's been some time."" |
| `[384]` | **"Keep watching."** | `[381]` **Narrator**: "Under the portrait, the bottom r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Tarquin Soll**: ""As if plastering my name everyw..." |
| `[385]` | **""If you're wondering, I didn't organize that.""** | `[381]` **Narrator**: "Under the portrait, the bottom r..." | `Variable["BaseGame.Turn05_P_FCAnrica"] == true` | *Brak zmian stanu* | `[389]` **Tarquin Soll**: ""Of course. It wouldn't have bee..." |

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
  - -> `[3]` (*Narrator: "Tarquin Soll was already seated on the leather sofa, cast..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Tarquin Soll: ""I didn't have the opportunity to extend my support to yo..."*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Tarquin Soll was already seated on the leather sofa, casting his hawk-like gaze out onto the field. He did not react when I entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""To what do we owe this pleasure, Colonel?""*)
  - -> `[6]` (*Player: ""It is good to see you here, Mr. Soll.""*)
  - -> `[7]` (*Player: ""We seem to be crossing each other's paths on the oddest ..."*)
  - -> `[8]` (*Player: ""Are you going to pretend I'm not here?""*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To what do we owe this pleasure, Colonel?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Tarquin Soll leaned on his cane and turned his head to lo..."*)

### Węzeł `[5]`
Mówca: **Tarquin Soll**
> ""Mr. Rayne. I didn't hear you come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He smiled at me and gestured at the vacant spot beside him."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to see you here, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Tarquin Soll leaned on his cane and turned his head to lo..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We seem to be crossing each other's paths on the oddest of occasions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Tarquin Soll leaned on his cane and turned his head to lo..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you going to pretend I'm not here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Tarquin Soll leaned on his cane and turned his head to lo..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_PTV_SollConfrontation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_PTV_SollConfrontation == true"*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_PTV_SollConfrontation == true )"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_PTV_SollConfrontation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_PTV_SollConfrontation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Tarquin Soll: ""I am surprised that you have the audacity to face me aft..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_PTV_SollConfrontation == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_PTV_SollConfrontation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Tarquin Soll: ""I didn't expect you to show up today.""*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Tarquin Soll leaned on his cane and turned his head to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Tarquin Soll: ""Mr. Rayne. I didn't hear you come in.""*)

### Węzeł `[13]`
Mówca: **Narrator**
> "He smiled at me and gestured at the vacant spot beside him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Tarquin Soll: ""Please. Join me.""*)

### Węzeł `[14]`
Mówca: **Tarquin Soll**
> ""Please. Join me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I approached the sofa and sat next to him."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Tarquin Soll leaned on his cane and turned his head to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)

### Węzeł `[16]`
Mówca: **Tarquin Soll**
> ""Movies and football. Well, a pair of strivers like us have earned the right to a little leisure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He smiled at me and gestured at the vacant spot beside him."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Results_Decision_TrySoll == true)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Results_Decision_TrySoll == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Tarquin Soll: ""I am surprised that you have the audacity to face me aft..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Results_Decision_TrySoll == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Results_Decision_TrySoll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I approached the sofa and sat next to him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)

### Węzeł `[21]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after that farce of a trial that you put me through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Tarquin Soll: ""You have my respect. Albeit begrudgingly.""*)

### Węzeł `[22]`
Mówca: **Tarquin Soll**
> ""I suppose that demands some respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: ""That was in the past. I believe we can put it behind us.""*)
  - -> `[35]` (*Player: ""That's very kind of you, Colonel.""*)
  - -> `[26]` (*Player: ""I don't need your respect.""*)
  - -> `[47]` (*Player: ""I didn't come here to face you, Mr. Soll. I came here fo..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == tru..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Tarquin Soll: ""Your support for FC Anrica and Sordish sports is hearten..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Results_Decision_TrySoll == true"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't need your respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Tarquin Soll), `[33]` (Tarquin Soll), `[338]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You cannot escape justice forever, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[33]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Tarquin Soll: ""Your resolve to punish me is pitiable, Mr. Rayne.""*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Acquitted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Tarquin Soll: ""The Courts have already acquitted me.""*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Acquitted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Acquitted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Tarquin Soll: ""I have already been acquitted in the eyes and hearts of ..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That was in the past. I believe we can put it behind us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Tarquin Soll), `[33]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[32]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the way our last meeting ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Tarquin Soll: ""I suppose that demands some respect.""*)

### Węzeł `[33]`
Mówca: **Tarquin Soll**
> ""You have my respect. Albeit begrudgingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: ""You cannot escape justice forever, Mr. Soll.""*)
  - -> `[31]` (*Player: ""That was in the past. I believe we can put it behind us.""*)
  - -> `[35]` (*Player: ""That's very kind of you, Colonel.""*)
  - -> `[26]` (*Player: ""I don't need your respect.""*)
  - -> `[47]` (*Player: ""I didn't come here to face you, Mr. Soll. I came here fo..."*)

### Węzeł `[34]`
Mówca: **Tarquin Soll**
> ""Your support for FC Anrica and Sordish sports is heartening. Nothing brings the country together like watching their football team win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Player: ""Especially when everyone's favorite former president is ..."*)
  - -> `[75]` (*Player: ""For a retired man, you certainly get around a lot.""*)
  - -> `[74]` (*Player: ""I wouldn't have taken you for a football fan, sir.""*)
  - -> `[96]` (*Player: ""It's great to see you here, sir. Our conversation at the..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's very kind of you, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Tarquin Soll), `[33]` (Tarquin Soll), `[338]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you. I know he had the utmost respect and admiration for you, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He nodded."*)

### Węzeł `[37]`
Mówca: **Tarquin Soll**
> ""The Courts have already acquitted me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Tarquin Soll: ""You talk of injustice only when the result doesn't suit ..."*)

### Węzeł `[38]`
Mówca: **Tarquin Soll**
> ""I thought you would have known by now how Sordish politics work on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: ""I was naive enough to think justice could be served unde..."*)
  - -> `[83]` (*Player: ""You can't suppress everything with military power.""*)
  - -> `[85]` (*Player: ""You think you're above everything, don't you? Including ..."*)

### Węzeł `[39]`
Mówca: **Tarquin Soll**
> ""Your resolve to punish me is pitiable, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Acquitted == true"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn11_Election_AssassinationHappened == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Tarquin Soll: ""I didn't have the opportunity to extend my support to yo..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn11_Election_AssassinationHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)

### Węzeł `[43]`
Mówca: **Tarquin Soll**
> ""My condolences on the death of your driver. I heard he was a good one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player: ""Thank you. I know he had the utmost respect and admirati..."*)
  - -> `[44]` (*Player: ""His name was Serge. And he wasn't just good; he was the ..."*)
  - -> `[51]` (*Player_Italic: "Stay silent."*)
  - -> `[45]` (*Player: ""Everyone involved in the attack will pay for what they'v..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""His name was Serge. And he wasn't just good; he was the best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He nodded."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everyone involved in the attack will pay for what they've done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Tarquin Soll), `[57]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He nodded."*)

### Węzeł `[46]`
Mówca: **Tarquin Soll**
> ""You talk of injustice only when the result doesn't suit your agenda. How righteous of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Player: ""Are you really going to take me for a fool and tell me t..."*)
  - -> `[86]` (*Player: ""Don't speak to me about the courts. We both know that yo..."*)
  - -> `[85]` (*Player: ""You think you're above everything, don't you? Including ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't come here to face you, Mr. Soll. I came here for FC Anrica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Tarquin Soll), `[33]` (Tarquin Soll), `[338]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Tarquin Soll: ""You knew I'd be here.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Tarquin Soll: ""Is everything faring well with your new Constitution, Mr..."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Tarquin Soll: ""Is everything faring well after the defeat of your refor..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Tarquin Soll), `[57]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Tarquin Soll: ""I must say...""*)

### Węzeł `[52]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Tarquin Soll: ""I must say...""*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_MilitaryParade_SergeDead == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_MilitaryParade_SergeDead == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Tarquin Soll: ""My condolences on the death of your driver. I heard he w..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_MilitaryParade_SergeDead == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Tarquin Soll: ""You have my deepest sympathies.""*)

### Węzeł `[56]`
Mówca: **Tarquin Soll**
> ""I didn't have the opportunity to extend my support to you after that dastardly attack against Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_MilitaryParade_SergeDead == true"*)

### Węzeł `[57]`
Mówca: **Tarquin Soll**
> ""You have my deepest sympathies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Player_Italic: "Stay silent."*)
  - -> `[45]` (*Player: ""Everyone involved in the attack will pay for what they'v..."*)
  - -> `[58]` (*Player: ""Thank you for your sympathy. It truly means a lot.""*)
  - -> `[139]` (*Player: ""Tell me the truth, Colonel Soll. You knew about the atta..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for your sympathy. It truly means a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "He nodded."*)

### Węzeł `[59]`
Mówca: **Tarquin Soll**
> ""I must say...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)

### Węzeł `[60]`
Mówca: **Tarquin Soll**
> ""I didn't expect you to show up today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Tarquin Soll: ""It is heartening to see that you're a supporter of FC An..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == ..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas =..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: ""Enough about me. Tell me more about how you and Lileas G..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Tarquin Soll**
> ""I have already been acquitted in the eyes and hearts of the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Tarquin Soll: ""I thought you would have known by now how Sordish politi..."*)

### Węzeł `[65]`
Mówca: **Tarquin Soll**
> ""It is heartening to see that you're a supporter of FC Anrica and Sordish sports.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""I could say the same for you, Mr. Soll.""*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[72]` (*Player: ""I thought you returned to your island. What are you stil..."*)
  - -> `[68]` (*Player: ""I didn't know you were a football fan.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why? Did you think a few armed men would stop me from going out in public again?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Kontekst wejściowy (poprzednik):** `[65]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Tarquin Soll: ""I was referring to your *busy* schedule.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I could say the same for you, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't know you were a football fan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Tarquin Soll: ""You know I couldn't miss this historic moment.""*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn11_Election_AssassinationHappened == true"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn11_Election_AssassinationHappened == true)"*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn11_Election_AssassinationHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""Why? Did you think a few armed men would stop me from go..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn11_Election_AssassinationHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn11_Election_AssassinationHappened"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you returned to your island. What are you still doing around here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Tarquin Soll: ""Can't an old man still travel?""*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Especially when everyone's favorite former president is in the stands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Tarquin Soll: ""You must be referring to Alphonso. Sordland couldn't get..."*)

### Węzeł `[74]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wouldn't have taken you for a football fan, sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Tarquin Soll: ""I don't watch all the games. But I do have a soft spot f..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""For a retired man, you certainly get around a lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Tarquin Soll: ""I would never miss this historic occasion.""*)

### Węzeł `[76]`
Mówca: **Tarquin Soll**
> ""You knew I'd be here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[78]`
Mówca: **Tarquin Soll**
> ""Tell me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[79]`
Mówca: **Tarquin Soll**
> ""Can't an old man still travel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Tarquin Soll: ""You know I couldn't miss this historic moment.""*)

### Węzeł `[80]`
Mówca: **Tarquin Soll**
> ""You know I couldn't miss this historic moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "He gestured to the FC Anrica pin on his suit lapel."*)

### Węzeł `[81]`
Mówca: **Tarquin Soll**
> ""I was referring to your *busy* schedule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[82]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can't suppress everything with military power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Tarquin Soll: ""It doesn't suit you to be so full of spite, Mr. Rayne...""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I was naive enough to think justice could be served under the system you'd built. I won't make the same mistake again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Tarquin Soll: ""My system is nothing but just. It keeps power-mad tyrant..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You think you're above everything, don't you? Including the law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[38]` (Tarquin Soll), `[46]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Tarquin Soll: ""It doesn't suit you to be so full of spite, Mr. Rayne...""*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't speak to me about the courts. We both know that you owe the result to your cronies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Tarquin Soll: ""If that's what you think of them, why did you order a tr..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you really going to take me for a fool and tell me that the Court is just and lawful?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Tarquin Soll: ""If that's what you think of them, why did you order a tr..."*)

### Węzeł `[88]`
Mówca: **Tarquin Soll**
> ""It doesn't suit you to be so full of spite, Mr. Rayne...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "The corner of his mouth curled up mirthlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[90]`
Mówca: **Tarquin Soll**
> ""My system is nothing but just. It keeps power-mad tyrants from throwing innocent old men in prison.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "He had a barely visible smile on his face."*)

### Węzeł `[91]`
Mówca: **Tarquin Soll**
> ""If that's what you think of them, why did you order a trial at all? Did you somehow believe your narrow view of 'justice' would prevail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "He heaved a sigh."*)

### Węzeł `[92]`
Mówca: **Tarquin Soll**
> ""I had such high hopes for you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[93]`
Mówca: **Narrator**
> "He heaved a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Tarquin Soll: ""I had such high hopes for you, Anton.""*)

### Węzeł `[94]`
Mówca: **Narrator**
> "He had a barely visible smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[95]`
Mówca: **Tarquin Soll**
> ""I would never miss this historic occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He gestured to the FC Anrica pin on his suit lapel."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to see you here, sir. Our conversation at the cinema in Erlory was far too brief.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Narrator: "He had a barely visible smile on his face."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == t..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Tarquin Soll: ""And you are turning Sordland into a puppet for superpowe..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)

### Węzeł `[100]`
Mówca: **Tarquin Soll**
> ""Is everything faring well with your new Constitution, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: ""Are you still sore because you lost?""*)
  - -> `[136]` (*Player: ""Now that we've put the 1929 Constitution behind us, thin..."*)
  - -> `[137]` (*Player: ""That's nothing for you to worry about, Mr. Soll.""*)
  - -> `[138]` (*Player: ""I'll admit. I'm starting to doubt the effectiveness of s..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "He gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""It seems that you and I are on the same side.""*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[117]` (*Player: ""I'm happy to see you so excited, sir.""*)
  - -> `[116]` (*Player: ""I'm sure the team will give it their all, knowing that y..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == false"*)
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == false)"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Tarquin Soll: ""You couldn't stop Alphonso's mess, and you left the nati..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[105]`
Mówca: **Tarquin Soll**
> ""Is everything faring well after the defeat of your reforms, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""Yes, you won. No need to rub that in my face, Colonel.""*)
  - -> `[132]` (*Player: ""I may have not changed the constitution, but I've done m..."*)
  - -> `[133]` (*Player: ""That's nothing for you to worry about, Mr. Soll.""*)
  - -> `[134]` (*Player: ""I'll admit. The term could have gone better.""*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishDepression == true)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishDepression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishDepression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Tarquin Soll: ""You continued on the path that Ewald Alphonso started, o..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishDepression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishDepression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == false"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems that you and I are on the same side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Tarquin Soll: ""When it comes to football, yes.""*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: ""Be honest. Does it ever bother you that I'm one of the o..."*)
  - -> `[126]` (*Player: ""As a partner of the club, I must say I am humbled to see..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Be honest. Does it ever bother you that I'm one of the owners of FC Anrica?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Tarquin Soll: ""Hah!""*)

### Węzeł `[114]`
Mówca: **Tarquin Soll**
> ""Hah!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Tarquin Soll: ""You must have been doing something right for our boys to..."*)

### Węzeł `[115]`
Mówca: **Tarquin Soll**
> ""You must have been doing something right for our boys to progress this far. I wish I could say the same for your leadership of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure the team will give it their all, knowing that you and I are watching them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Tarquin Soll: ""Unless they crack under pressure, of course.""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm happy to see you so excited, sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Tarquin Soll: ""I'll be more excited when our boys win.""*)

### Węzeł `[118]`
Mówca: **Narrator**
> "He gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""It seems that once again, you and I are on the same side.""*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[124]` (*Player: ""I'm sure the team will give it their all, knowing that y..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It seems that once again, you and I are on the same side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[408]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Tarquin Soll: ""The only correct side, Mr. Rayne.""*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: ""As a partner of the club, I must say I am humbled to see..."*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""I'm happy to see you so excited, sir.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As a partner of the club, I must say I am humbled to see that pin on your jacket.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[408]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Tarquin Soll: ""Ah, yes. I always found it unbecoming for sitting presid..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure the team will give it their all, knowing that you and I are watching.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[408]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Tarquin Soll: ""Unless they crack under the pressure, of course.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm happy to see you so excited, sir.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[118]` (Narrator), `[408]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Tarquin Soll: ""I'll be even more excited if they win.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""As a partner of the club, I must say I am humbled to see that pin on your jacket.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Tarquin Soll: ""Ah, yes. I always found it unbecoming for sitting presid..."*)

### Węzeł `[127]`
Mówca: **Tarquin Soll**
> ""Ah, yes. I always found it unbecoming for sitting presidents to engage in such schemes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Tarquin Soll: ""But you must have been doing something right for our boy..."*)

### Węzeł `[128]`
Mówca: **Tarquin Soll**
> ""We can find a more suitable occasion for a deeper conversation, if you so desire.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Tarquin Soll: ""But today is for football, not politics.""*)

### Węzeł `[129]`
Mówca: **Narrator**
> "He had a barely visible smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Tarquin Soll: ""We can find a more suitable occasion for a deeper conver..."*)

### Węzeł `[130]`
Mówca: **Tarquin Soll**
> ""But today is for football, not politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He gestured to the FC Anrica pin on his suit lapel."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, you won. No need to rub that in my face, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Tarquin Soll: ""Don't be a fool, Mr. Rayne.""*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I may have not changed the constitution, but I've done my best to reform Sordland in my own way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == f..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's nothing for you to worry about, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Tarquin Soll: ""I will decide what I worry about, Mr. Rayne.""*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll admit. The term could have gone better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Tarquin Soll: ""We cannot reverse time.""*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you still sore because you lost?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Tarquin Soll: ""Don't be a fool, Mr. Rayne.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now that we've put the 1929 Constitution behind us, things are only going to get better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Tarquin Soll: ""You assume too much.""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's nothing for you to worry about, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Tarquin Soll: ""I will decide what I worry about, Mr. Rayne.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll admit. I'm starting to doubt the effectiveness of some of my reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Tarquin Soll: ""We cannot reverse time.""*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me the truth, Colonel Soll. You knew about the attack, didn't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "His brow furrowed as he looked at me."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you don't mind, Colonel, I'd prefer to watch the match in silence.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false` AND `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[256]` (Tarquin Soll), `[321]` (Tarquin Soll), `[323]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough about me. Tell me more about how you and Lileas Graf conspired to throw Sordland into instability.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas"] == true`
- **Kontekst wejściowy (poprzednik):** `[256]` (Tarquin Soll), `[321]` (Tarquin Soll), `[323]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Tarquin Soll: ""You made the mistake of your career imprisoning her, Mr...."*)

### Węzeł `[142]`
Mówca: **Tarquin Soll**
> ""Don't be a fool, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Tarquin Soll: ""Such childish games don't interest me. I am interested i..."*)

### Węzeł `[143]`
Mówca: **Tarquin Soll**
> ""We cannot reverse time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[144]`
Mówca: **Tarquin Soll**
> ""You continued on the path that Ewald Alphonso started, obliterating our economy and throwing the nation into a quagmire of poverty and depression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[145]`
Mówca: **Tarquin Soll**
> ""I will decide what I worry about, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[146]`
Mówca: **Tarquin Soll**
> ""So I have seen. But at what expense?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == f..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Joined_ATO == false && BaseGame.Joined_CSP ==..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Tarquin Soll: ""So I have seen. And the results have been impressive.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) && BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)  and  Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Tarquin Soll: ""So I have seen. But at what expense?""*)

### Węzeł `[150]`
Mówca: **Tarquin Soll**
> ""So I have seen. And the results have been impressive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Tarquin Soll: ""But I can't help but feel troubled about the future.""*)

### Węzeł `[151]`
Mówca: **Tarquin Soll**
> ""You assume too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)

### Węzeł `[153]`
Mówca: **Tarquin Soll**
> ""Such childish games don't interest me. I am interested in results from this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[154]`
Mówca: **Tarquin Soll**
> ""But I can't help but feel troubled about the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He sighed."*)

### Węzeł `[155]`
Mówca: **Tarquin Soll**
> ""You couldn't stop Alphonso's mess, and you left the nation in a recession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[156]`
Mówca: **Tarquin Soll**
> ""And you are turning Sordland into a puppet for superpowers to play with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)

### Węzeł `[157]`
Mówca: **Tarquin Soll**
> ""I never would have thought I'd live to see Sordland invaded by imperialists. Especially at the invitation of a Sordish president...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Tarquin Soll: ""I am warning you, Anton. The path you've chosen will onl..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Tarquin Soll: ""Furthermore, you chose to defund our national defense in..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Ally == true && BaseGame.Econo..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true"*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true)"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Tarquin Soll: ""I never would have thought I'd live to see Sordland inva..."*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Tarquin Soll: ""I never would have thought I'd live to see Sordland infe..."*)

### Węzeł `[164]`
Mówca: **Tarquin Soll**
> ""I never would have thought I'd live to see Sordland infected by Malenyevism. Especially at the invitation of a Sordish president...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Tarquin Soll: ""I am warning you, Anton. The path you've chosen will onl..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true && BaseGame.Joi..."*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Tarquin Soll: ""Despite all my concerns, your achievements for this coun..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)

### Węzeł `[168]`
Mówca: **Tarquin Soll**
> ""Despite all my concerns, your achievements for this country have been commendable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || B..."*)

### Węzeł `[169]`
Mówca: **Tarquin Soll**
> ""Furthermore, you chose to defund our national defense in a time when Eastern Merkopa is waiting to explode in our faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Tarquin Soll: ""I am warning you, Anton. The path you've chosen will onl..."*)

### Węzeł `[170]`
Mówca: **Tarquin Soll**
> ""I don't mean to overstep. But I can't sit still while your *reforms* are killing what's left of our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true ||..."*)
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Welfare_EducationPrivatization == true ..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Tarquin Soll: ""You are running the country as if it's a business -- des..."*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Tarquin Soll: ""You have strayed from the values of the party.""*)

### Węzeł `[174]`
Mówca: **Tarquin Soll**
> ""You are running the country as if it's a business -- destroying free Sordish welfare, and with it, the life of the average Sord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Tarquin Soll: ""I am warning you, Anton. The path you've chosen will onl..."*)

### Węzeł `[175]`
Mówca: **Tarquin Soll**
> ""Furthermore, you sold the country and yourself to a few corrupt businessmen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Tarquin Soll: ""I am warning you, Anton. The path you've chosen will onl..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Ally == true && BaseGame.Econo..."*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Ally == true && BaseGame.Eco..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Ally"] == true  and  Variable["BaseGame.EconomicDirection_Nationalization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Tarquin Soll: ""Furthermore, you sold the country and yourself to a few ..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Ally == true && BaseGame.EconomicDirection_Nationalization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Ally"] == true  and  Variable["BaseGame.EconomicDirection_Nationalization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationPrivatization == true ||..."*)

### Węzeł `[179]`
Mówca: **Tarquin Soll**
> ""You have strayed from the values of the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Tarquin Soll: ""I am warning you, Anton. Don't you dare go too far.""*)

### Węzeł `[180]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about death and misery.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "GenericOptions"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[181]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about disparity and exploitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "GenericOptions"*)
  - -> `[196]` (*Player: ""You're one to talk. I've been too busy fixing your messe..."*)

### Węzeł `[182]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about disparity and regression.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "GenericOptions"*)
  - -> `[197]` (*Player: ""Regression? How many years did your reign set Sordland b..."*)

### Węzeł `[183]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. Don't you dare go too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "GenericOptions"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)

### Węzeł `[184]`
Mówca: **Tarquin Soll**
> ""I am warning you, Anton. The path you've chosen will only bring about exploitation and abuse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "GenericOptions"*)
  - -> `[194]` (*Player: ""No superpower can match the amount of abuse you've alrea..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || B..."*)
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true ||..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Tarquin Soll: ""Apart from your willingness to ignore the Sordish public..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Faction_Oligarchs_Ally == true ||BaseGame.Policy_Welfare_EducationPrivatization == true || BaseGame.Policy_Welfare_HealthPrivatization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Faction_Oligarchs_Ally"] == true  or Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true  or  Variable["BaseGame.Policy_Welfare_HealthPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Tarquin Soll: ""I hope your heart is in the right place, Mr. Rayne.""*)

### Węzeł `[188]`
Mówca: **Tarquin Soll**
> ""Apart from your willingness to ignore the Sordish public's wishes, of course...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[189]`
Mówca: **Tarquin Soll**
> ""I hope your heart is in the right place, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Player: ""You know it is, Colonel.""*)
  - -> `[280]` (*Player: ""That's not for you to question, sir.""*)
  - -> `[281]` (*Player: ""My heart belongs to Sordland.""*)
  - -> `[283]` (*Player: ""I hope yours is as well.""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My path is my own to tread. You have no influence over my presidency, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Tarquin Soll), `[181]` (Tarquin Soll), `[182]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GenericOptions`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""I didn't come here to listen to your criticism.""*)
  - -> `[190]` (*Player: ""My path is my own to tread. You have no influence over m..."*)
  - -> `[192]` (*Player: ""I understand your concerns, sir, but I beg to differ.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your concerns, sir, but I beg to differ.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Tarquin Soll), `[181]` (Tarquin Soll), `[182]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't come here to listen to your criticism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Tarquin Soll), `[181]` (Tarquin Soll), `[182]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No superpower can match the amount of abuse you've already inflicted on this nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry but I'm done with the warmongering and paranoia.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[180]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're one to talk. I've been too busy fixing your messes to make the progress Sordland needs.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Regression? How many years did your reign set Sordland back?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I seriously don't believe I have strayed from the USP's values. All I wanted to do was follow in your footsteps.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[183]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true)"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player: ""I seriously don't believe I have strayed from the USP's ..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: ""I don't need to hear your threats.""*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't need to hear your threats.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[183]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGa..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Tarquin Soll: ""I don't mean to overstep. But I can't sit still while yo..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Stronger == true && (BaseGame.Reform_Law_Veto_Loophole == true || BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Policy_Order_SecretStatePolice == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  (Variable["BaseGame.Reform_Law_Veto_Loophole"] == true  or  Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[209]`
Mówca: **Tarquin Soll**
> ""Be careful, Mr. Rayne. You are pulling all of Eastern Merkopa into a bloody conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[210]`
Mówca: **Tarquin Soll**
> ""Don't get me wrong. I may have reacted the same way in your stead. But I would have made sure the Sordish military was well and ready for such a fight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Tarquin Soll: ""I truly hope you are ready for what's coming. For all of..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && Base..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Tarquin Soll: ""To say nothing of the bloody conflict with Rumburg that ..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Tarquin Soll: ""It didn't even take four years for your mind to become p..."*)

### Węzeł `[214]`
Mówca: **Tarquin Soll**
> ""To say nothing of the bloody conflict with Rumburg that you insist on pulling all of Eastern Merkopa into.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[215]`
Mówca: **Tarquin Soll**
> ""Despite all the warning signs, you adamantly followed your own pigheaded vision for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishDepression == true"*)

### Węzeł `[216]`
Mówca: **Tarquin Soll**
> ""Say what you will. Deep down inside, you know I'm right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Player: ""You're talking past me, not to me.""*)
  - -> `[302]` (*Player: ""You're wrong.""*)
  - -> `[301]` (*Player: ""You know what? I think I need a drink.""*)
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "Jump to: [OptionsWSoll]"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && Base..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Tarquin Soll: ""Be careful, Mr. Rayne. You are pulling all of Eastern Me..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGame.Wehlen_JointOperation == false && BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true) == false && (BaseGame.Enable_RumburgIncident == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false) == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn02_FPnT_Consulate_Condemn"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false  and  (Variable["BaseGame.Enable_RumburgIncident"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false) == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Tarquin Soll: ""I truly hope you are ready for what's coming. For all of..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Tarquin Soll: ""Don't get me wrong. I may have reacted the same way in y..."*)

### Węzeł `[223]`
Mówca: **Tarquin Soll**
> ""I truly hope you are ready for what's coming. For all of our sakes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""I must say, your lack of faith in Sordland is disturbing.""*)
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[224]`
Mówca: **Tarquin Soll**
> ""It didn't even take four years for your mind to become poisoned with power fantasies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player: ""That's rich, coming from you of all people.""*)
  - -> `[227]` (*Player: ""I am not you, Colonel.""*)
  - -> `[228]` (*Player: ""Everything I did was for the development of Sordland.""*)
  - -> `[252]` (*Player: ""I always thought you'd understand me. It's sad to see yo..."*)

### Węzeł `[225]`
Mówca: **Tarquin Soll**
> ""You believe you are special, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's rich, coming from you of all people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Tarquin Soll: ""You believe you are special, don't you?""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am not you, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Tarquin Soll: ""You believe you are special, don't you?""*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything I did was for the development of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Tarquin Soll: ""You alone know what's best for Sordland, don't you?""*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, your lack of faith in Sordland is disturbing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Tarquin Soll: ""I have nothing but faith in this country and its fine mi..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "His brow furrowed as he looked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Tarquin Soll: ""You cannot simply throw around such accusations, Mr. Ray..."*)

### Węzeł `[231]`
Mówca: **Tarquin Soll**
> ""You cannot simply throw around such accusations, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Tarquin Soll: ""The idea that I would wield such power from my little is..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am doing everything I can to prevent a conflict with them.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Tarquin Soll: ""You must try harder before it's too late.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why are you so scared, Colonel? If the Rums come, we will show them hell.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Tarquin Soll: ""I have nothing but faith in this country and its fine mi..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player: ""It's the path that Queen Beatrice chose, not me.""*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""I'm sorry but I'm done with the warmongering and paranoia.""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's the path that Queen Beatrice chose, not me.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[180]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Tarquin Soll: ""To say nothing of the bloody conflict with Rumburg that ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Tarquin Soll: ""Be careful, Mr. Rayne. You are pulling all of Eastern Me..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn02_FPnT_Consulate_Condemn == true && BaseGa..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player: ""We are ready to crush Rumburg's armies once and for all.""*)
  - -> `[251]` (*Player: ""I didn't want it to come to this...""*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""I am doing everything I can to prevent a conflict with t..."*)
  - -> `[236]` (*Player: ""Why are you so scared, Colonel? If the Rums come, we wil..."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We are ready to crush Rumburg's armies once and for all.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Tarquin Soll: ""The only future is victory.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't want it to come to this...""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[223]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Tarquin Soll: ""It's too late for regrets.""*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always thought you'd understand me. It's sad to see you be so combative.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[224]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Tarquin Soll: ""Oh, but I understand you, Anton. That is precisely the r..."*)

### Węzeł `[253]`
Mówca: **Tarquin Soll**
> ""Oh, but I understand you, Anton. That is precisely the reason for my stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[254]`
Mówca: **Tarquin Soll**
> ""You alone know what's best for Sordland, don't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)

### Węzeł `[255]`
Mówca: **Tarquin Soll**
> ""I have nothing but faith in this country and its fine military. But both are nothing without a strong leader to guide them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Tarquin Soll: ""I rebuilt this Republic with my own sweat and blood. I w..."*)

### Węzeł `[256]`
Mówca: **Tarquin Soll**
> ""I rebuilt this Republic with my own sweat and blood. I will not see it collapse again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)
  - -> `[356]` (*Player: ""And I will never let that happen.""*)
  - -> `[355]` (*Player: ""If something will collapse, it will be Rumburg.""*)

### Węzeł `[257]`
Mówca: **Tarquin Soll**
> ""It's too late for regrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Tarquin Soll: ""The only future is victory.""*)

### Węzeł `[258]`
Mówca: **Tarquin Soll**
> ""The only future is victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Player: ""And I will make sure that it is achieved.""*)
  - -> `[359]` (*Player: ""We will give them hell, Colonel.""*)
  - -> `[358]` (*Player: ""Vectern sis da.""*)

### Węzeł `[259]`
Mówca: **Tarquin Soll**
> ""You must try harder before it's too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Tarquin Soll: ""I rebuilt this Republic with my own sweat and blood. I w..."*)

### Węzeł `[260]`
Mówca: **Tarquin Soll**
> ""Is everything faring well after your emergency, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""My emergency? I thought it was *your* idea.""*)
  - -> `[286]` (*Player: ""Everything's running as smoothly as possible.""*)
  - -> `[263]` (*Player: ""I'll be honest. I am starting to doubt that it was the r..."*)
  - -> `[261]` (*Player: ""It's nothing for you to worry about, Mr. Soll.""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's nothing for you to worry about, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Tarquin Soll: ""I will decide what I worry about, Mr. Rayne.""*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Not everyone has been on board with it. But I'm still confident it's the right course of action.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[267]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Tarquin Soll: ""Every decision you make will be faced with dissent. You ..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. I am starting to doubt that it was the right decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Tarquin Soll), `[267]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Tarquin Soll: ""We cannot reverse time.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_ExtendEmergency_Extend == true"*)
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_ExtendEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Tarquin Soll: ""How is everything faring with your emergency, Mr. Rayne?""*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Tarquin Soll: ""Is everything faring well after your emergency, Mr. Rayne?""*)

### Węzeł `[267]`
Mówca: **Tarquin Soll**
> ""How is everything faring with your emergency, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""My emergency? I thought it was *your* idea.""*)
  - -> `[262]` (*Player: ""Not everyone has been on board with it. But I'm still co..."*)
  - -> `[286]` (*Player: ""Everything's running as smoothly as possible.""*)
  - -> `[263]` (*Player: ""I'll be honest. I am starting to doubt that it was the r..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == tru..."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Tarquin Soll: ""Despite all the warning signs, you adamantly followed yo..."*)

### Węzeł `[271]`
Mówca: **Tarquin Soll**
> ""Unless they crack under the pressure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "Jump to: [Tarquin Soll: ""Tell me...""]"*)

### Węzeł `[272]`
Mówca: **Tarquin Soll**
> ""The only correct side, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "Jump to: [Tarquin Soll: ""Tell me...""]"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Tarquin Soll: ""Tell me...""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true && BaseGame.Joi..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Tarquin Soll: ""In any case... None of that really matters now.""*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true && BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false &&
BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true  and  Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false  and 
Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == tru..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Tarquin Soll: ""In any case... None of that really matters now.""*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Tarquin Soll: ""Say what you will. Deep down inside, you know I'm right.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's not for you to question, sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My heart belongs to Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know it is, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope yours is as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[189]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[284]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Tarquin Soll: ""We must look to the future.""*)

### Węzeł `[285]`
Mówca: **Tarquin Soll**
> ""The idea that I would wield such power from my little island -- let alone that I would use it to do harm to a sitting president -- is preposterous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "Jump to: [Tarquin Soll: ""Tell me...""]"*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Everything's running as smoothly as possible.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Tarquin Soll), `[267]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Tarquin Soll: ""That's very good to hear. I hope it stays that way.""*)

### Węzeł `[287]`
Mówca: **Tarquin Soll**
> ""That's very good to hear. I hope it stays that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My emergency? I thought it was *your* idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Tarquin Soll), `[267]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Tarquin Soll: ""Ha! Are you saying you're not responsible for declaring ..."*)

### Węzeł `[289]`
Mówca: **Tarquin Soll**
> ""Ha! Are you saying you're not responsible for declaring it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "He smirked."*)

### Węzeł `[290]`
Mówca: **Narrator**
> "He smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Tarquin Soll: ""To be quite precise, it wasn't my idea. It was a rare sh..."*)

### Węzeł `[291]`
Mówca: **Tarquin Soll**
> ""We must look to the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""A Morgna wes core.""*)
  - -> `[295]` (*Player: ""The future is bright.""*)
  - -> `[296]` (*Player: ""I'll drink to that.""*)
  - -> `[298]` (*Player: ""Your wisdom rings true as always, Mr. Soll.""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `OptionsWSoll`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: ""If you don't mind, Colonel, I'd prefer to watch the matc..."*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_A_Investigation_OldGuard_Trial_Lileas == ..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [OptionsWSoll]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""A Morgna wes core.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.AMorgnaWesCore += 1"*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The future is bright.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll drink to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Tarquin Soll: ""Speaking of drinks...""*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.AMorgnaWesCore += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.AMorgnaWesCore"] = Variable["BaseGame.AMorgnaWesCore"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Tarquin Soll: ""Vectern sis da.""*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your wisdom rings true as always, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[291]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[299]`
Mówca: **Tarquin Soll**
> ""Speaking of drinks...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Tarquin Soll: ""I wonder if your predecessor got too inebriated to remem..."*)

### Węzeł `[300]`
Mówca: **Tarquin Soll**
> ""I wonder if your predecessor got too inebriated to remember today's match. Where is he?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? I think I need a drink.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Tarquin Soll: ""Speaking of drinks...""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're wrong.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Tarquin Soll: ""You still have a lot to learn.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're talking past me, not to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Tarquin Soll: ""You don't know how to listen.""*)

### Węzeł `[304]`
Mówca: **Tarquin Soll**
> ""You don't know how to listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""I'm willing to listen.""*)
  - -> `[376]` (*Player: ""I respect you, Colonel. I still wish the feeling was mut..."*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [OptionsWSoll]"*)

### Węzeł `[305]`
Mówca: **Tarquin Soll**
> ""Vectern sis da.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Tarquin Soll: ""In any case... None of that really matters anymore.""*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Tarquin Soll: ""In any case... None of that really matters anymore.""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)

### Węzeł `[312]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Tarquin Soll: ""You who claim to champion justice will soon get a taste ..."*)

### Węzeł `[313]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Tarquin Soll: ""All incompetent leaders get what's coming to them in the..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_Coup == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_Coup == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_Coup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Tarquin Soll: ""In any case... None of that really matters anymore.""*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_Coup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.Ending_ImpeachmentTrial == true"*)
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Ending_ImpeachmentTrial == true)"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Ending_ImpeachmentTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Ending_ImpeachmentTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Tarquin Soll: ""In any case... None of that really matters anymore.""*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Ending_ImpeachmentTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Ending_ImpeachmentTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[320]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Tarquin Soll: ""All tyrants get what is coming to them in the end. You i..."*)

### Węzeł `[321]`
Mówca: **Tarquin Soll**
> ""All tyrants get what is coming to them in the end. You included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player: ""Your threats mean nothing to me, Mr. Soll.""*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[322]`
Mówca: **Tarquin Soll**
> ""In any case... None of that really matters anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Tarquin Soll: ""The system I built still works. Sooner or later, you wil..."*)

### Węzeł `[323]`
Mówca: **Tarquin Soll**
> ""The system I built still works. Sooner or later, you will face justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player: ""Your threats mean nothing to me, Mr. Soll.""*)
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[324]`
Mówca: **Tarquin Soll**
> ""All incompetent leaders get what's coming to them in the end. Yourself included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "Jump to: [OptionsWSoll]"*)
  - -> `[372]` (*Player: ""I will not give in to your threats.""*)
  - -> `[378]` (*Player: ""Whatever you say, I respect you Colonel. I wish we had s..."*)

### Węzeł `[325]`
Mówca: **Tarquin Soll**
> ""You who claim to champion justice will soon get a taste of your own medicine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "Jump to: [OptionsWSoll]"*)
  - -> `[372]` (*Player: ""I will not give in to your threats.""*)
  - -> `[378]` (*Player: ""Whatever you say, I respect you Colonel. I wish we had s..."*)

### Węzeł `[326]`
Mówca: **Tarquin Soll**
> ""You still have a lot to learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""I'm willing to listen.""*)
  - -> `[376]` (*Player: ""I respect you, Colonel. I still wish the feeling was mut..."*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "Jump to: [OptionsWSoll]"*)
  - -> `[375]` (*Player: ""Perhaps I do. But what makes you think you should be the..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_Shuffled == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_Shuffled == true)"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_Shuffled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Tarquin Soll: ""I am surprised that you have the audacity to face me aft..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_Shuffled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_Shuffled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_Action_Court_OldGuardReplaced == true"*)
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_Action_Court_OldGuardReplaced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Tarquin Soll: ""I am surprised that you have the audacity to face me aft..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_Action_Court_OldGuardReplaced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_Action_Court_OldGuardReplaced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == false"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OrsoHawker == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OrsoHawker == false"*)
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OrsoHawker == false)"*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OrsoHawker == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OrsoHawker"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Tarquin Soll: ""I am surprised that you have the audacity to face me aft..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OrsoHawker == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OrsoHawker"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_PTV_SollConfrontation == true"*)

### Węzeł `[336]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the stunt you pulled with the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Tarquin Soll: ""Putting good, experienced officials out of work, in the ..."*)

### Węzeł `[337]`
Mówca: **Tarquin Soll**
> ""Putting good, experienced officials out of work, in the name of so-called justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Tarquin Soll: ""Still, you have my respect. Albeit begrudgingly.""*)

### Węzeł `[338]`
Mówca: **Tarquin Soll**
> ""Still, you have my respect. Albeit begrudgingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""That's very kind of you, Colonel.""*)
  - -> `[26]` (*Player: ""I don't need your respect.""*)
  - -> `[47]` (*Player: ""I didn't come here to face you, Mr. Soll. I came here fo..."*)
  - -> `[339]` (*Player: ""The Court now works the way it is supposed to. True just..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseG..."*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true"*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Court now works the way it is supposed to. True justice will be served in Sordland for the first time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Tarquin Soll), `[342]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The corner of his mouth curled up mirthlessly."*)

### Węzeł `[340]`
Mówca: **Tarquin Soll**
> ""I am surprised that you have the audacity to face me after the stunt you pulled with Chief Justice Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Tarquin Soll: ""Between you and me, I never actually liked the man. He r..."*)

### Węzeł `[341]`
Mówca: **Tarquin Soll**
> ""Between you and me, I never actually liked the man. He reminded me of a dog, helpless without its master.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Tarquin Soll: ""I suppose you have my respect.""*)

### Węzeł `[342]`
Mówca: **Tarquin Soll**
> ""I suppose you have my respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""That's very kind of you, Colonel.""*)
  - -> `[26]` (*Player: ""I don't need your respect.""*)
  - -> `[47]` (*Player: ""I didn't come here to face you, Mr. Soll. I came here fo..."*)
  - -> `[339]` (*Player: ""The Court now works the way it is supposed to. True just..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseG..."*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true"*)
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player: ""I had nothing to do with Hawker's removal. I only appoin..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I had nothing to do with Hawker's removal. I only appointed a new justice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true`
- **Kontekst wejściowy (poprzednik):** `[338]` (Tarquin Soll), `[342]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "He smiled."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseG..."*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Honorary_NoImmunity == true || Bas..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player: ""Whether you respect it or not, you will be next.""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Honorary_NoImmunity == true || BaseGame.Reform_Law_Honorary_Abolished == true) && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whether you respect it or not, you will be next.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true  or  Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true)  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[338]` (Tarquin Soll), `[342]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "His hand curled into a fist."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "His hand curled into a fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Tarquin Soll: ""I wouldn't get my hopes up.""*)

### Węzeł `[352]`
Mówca: **Tarquin Soll**
> ""I wouldn't get my hopes up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[353]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Tarquin Soll: ""Yes. Of course.""*)

### Węzeł `[354]`
Mówca: **Tarquin Soll**
> ""Yes. Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If something will collapse, it will be Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""Good. At least you have the spirit.""*)

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I will never let that happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""Good. At least you have the spirit.""*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And I will make sure that it is achieved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""Good. At least you have the spirit.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Vectern sis da.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""Good. At least you have the spirit.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We will give them hell, Colonel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Tarquin Soll: ""Good. At least you have the spirit.""*)

### Węzeł `[360]`
Mówca: **Tarquin Soll**
> ""Good. At least you have the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)
  - -> `[362]` (*Player: ""Thank you.""*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [OptionsWSoll]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[360]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know we have had our differences, to say the least. But I cannot argue with your brilliance on the battlefield. Would you consider offering your military guidance as we enter this conflict?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Kontekst wejściowy (poprzednik):** `[360]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player: ""I know we have had our differences, to say the least. Bu..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player: ""I know we have had our differences, to say the least. Bu..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know we have had our differences, to say the least. But I cannot argue with your brilliance on the battlefield. If we do go to war, would you consider offering your guidance?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[360]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[368]`
Mówca: **Tarquin Soll**
> ""If and when that fateful day comes, I will not stand idly by and watch my country fall. I will tell you that much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.TarquinSoll_AidsWar = true"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.TarquinSoll_AidsWar = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.TarquinSoll_AidsWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[370]`
Mówca: **Tarquin Soll**
> ""You could certainly use the help after your ill-advised purge of the general staff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your threats mean nothing to me, Mr. Soll.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Tarquin Soll), `[323]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will not give in to your threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Tarquin Soll), `[325]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [OptionsWSoll]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "OptionsWSoll"*)

### Węzeł `[374]`
Mówca: **Narrator**
> "A sudden burst of cheering from the stadium made both of us look out the window. The players had begun walking out onto the field."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Tarquin Soll: ""Look, Mr. Rayne. It's starting.""*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Perhaps I do. But what makes you think you should be the one to teach me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I respect you, Colonel. I still wish the feeling was mutual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Tarquin Soll), `[326]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm willing to listen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[304]` (Tarquin Soll), `[326]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whatever you say, I respect you Colonel. I wish we had some understanding.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[324]` (Tarquin Soll), `[325]` (Tarquin Soll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[379]`
Mówca: **Tarquin Soll**
> ""Look, Mr. Rayne. It's starting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "He pointed directly at a group of FC Anrica fans who stoo..."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "He pointed directly at a group of FC Anrica fans who stood up holding colored boards, creating a massive illustration of Tarquin Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "Under the portrait, the bottom row of boards slowly revea..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "Under the portrait, the bottom row of boards slowly revealed the words: "Welcome Home Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Player_Italic: "Keep watching."*)
  - -> `[383]` (*Player: ""I forgot that you were from Anrica.""*)
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)

### Węzeł `[382]`
Mówca: **Tarquin Soll**
> ""You made the mistake of your career imprisoning her, Mr. Rayne. That woman is one of the truest Sordish patriots I have ever met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)

### Węzeł `[383]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I forgot that you were from Anrica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Tarquin Soll: ""It's been some time.""*)

### Węzeł `[384]`
**[WYBÓR GRACZA: "Keep watching."]** — Mówca: **Player_Italic**
> "I kept watching the stadium."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Tarquin Soll: ""As if plastering my name everywhere in this city wasn't ..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you're wondering, I didn't organize that.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Kontekst wejściowy (poprzednik):** `[381]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Tarquin Soll: ""Of course. It wouldn't have been genuine otherwise.""*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_FCAnrica == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_FCAnrica == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_FCAnrica"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Player: ""If you're wondering, I didn't organize that.""*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_FCAnrica == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_FCAnrica"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[389]`
Mówca: **Tarquin Soll**
> ""Of course. It wouldn't have been genuine otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[390]`
Mówca: **Tarquin Soll**
> ""If it weren't for my name plastered everywhere in this city, I might have forgotten myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[391]`
Mówca: **Tarquin Soll**
> ""It's been some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Tarquin Soll: ""If it weren't for my name plastered everywhere in this c..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Tarquin Soll: ""Tell me...""]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[393]`
Mówca: **Tarquin Soll**
> ""As if plastering my name everywhere in this city wasn't enough. I suppose I'm flattered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[394]`
Mówca: **Tarquin Soll**
> ""To be quite precise, it wasn't my idea. It was a rare show of initiative from Mr. Hawker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "His face turned serious."*)

### Węzeł `[395]`
Mówca: **Narrator**
> "His face turned serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reform_Court_Success == true && BaseGame...."*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reform_Court_Success == true && BaseGam..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Tarquin Soll: ""You made a grave mistake by removing the national identi..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reform_Court_Success == true && BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)

### Węzeł `[399]`
Mówca: **Tarquin Soll**
> ""You made a grave mistake by removing the national identity of this country from its constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Tarquin Soll: ""With one pen stroke, you destroyed a unified Sordish ide..."*)

### Węzeł `[400]`
Mówca: **Tarquin Soll**
> ""With one pen stroke, you destroyed a unified Sordish identity that took centuries to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Tarquin Soll: ""And for what? To appease a minority that shows no respec..."*)

### Węzeł `[401]`
Mówca: **Narrator**
> "He locked eyes with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true && BaseGame.Joine..."*)

### Węzeł `[402]`
Mówca: **Tarquin Soll**
> ""And for what? To appease a minority that shows no respect or gratitude towards this great county of ours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Narrator: "He locked eyes with me."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true ..."*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == tru..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Tarquin Soll: ""Movies and football. Well, a pair of strivers like us ha..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Decision_Turn08_ExtendEmergency_Extend == true &&
BaseGame.Archetype_SollistRayne == true) && (BaseGame.Joined_ATO == false && BaseGame.Joined_CSP == false))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Decision_Turn08_ExtendEmergency_Extend"] == true  and 
Variable["BaseGame.Archetype_SollistRayne"] == true)  and  (Variable["BaseGame.Joined_ATO"] == false  and  Variable["BaseGame.Joined_CSP"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Tarquin Soll: ""Movies and football. Well, a retired man like me has ear..."*)

### Węzeł `[406]`
Mówca: **Tarquin Soll**
> ""Movies and football. Well, a retired man like me has earned the right to a little leisure. You, though...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "He smiled at me and gestured at the vacant spot beside him."*)

### Węzeł `[407]`
Mówca: **Tarquin Soll**
> ""You must be referring to Alphonso. Sordland couldn't get enough of him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Narrator: "He chuckled lightly at his joke, then gestured to the FC ..."*)

### Węzeł `[408]`
Mówca: **Narrator**
> "He chuckled lightly at his joke, then gestured to the FC Anrica pin on his suit lapel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""It seems that once again, you and I are on the same side.""*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_FCAnrica == true"*)
  - -> `[124]` (*Player: ""I'm sure the team will give it their all, knowing that y..."*)

### Węzeł `[409]`
Mówca: **Tarquin Soll**
> ""Ah, yes. I always found it unbecoming for sitting presidents to engage in such schemes. But you must have been doing something right for our boys to progress this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "Jump to: [Tarquin Soll: ""Tell me...""]"*)

### Węzeł `[410]`
Mówca: **Tarquin Soll**
> ""I'll be even more excited if they win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "Jump to: [Tarquin Soll: ""Tell me...""]"*)

### Węzeł `[411]`
Mówca: **Tarquin Soll**
> ""I don't watch all the games. But I do have a soft spot for these hometown heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He gestured to the FC Anrica pin on his suit lapel."*)

### Węzeł `[412]`
Mówca: **Tarquin Soll**
> ""But you must have been doing something right for our boys to progress this far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[413]`
Mówca: **Tarquin Soll**
> ""When it comes to football, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[414]`
Mówca: **Tarquin Soll**
> ""Unless they crack under pressure, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[415]`
Mówca: **Tarquin Soll**
> ""I'll be more excited when our boys win.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Tarquin Soll: ""Tell me...""*)

### Węzeł `[416]`
Mówca: **Tarquin Soll**
> ""Every decision you make will be faced with dissent. You must not let yourself succumb to doubt because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Narrator: "His face turned serious."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Tarquin Soll: ""You could certainly use the help after your ill-advised ..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Tarquin Soll: ""You are taking a risk going over the head of General Kru..."*)

### Węzeł `[420]`
Mówca: **Tarquin Soll**
> ""You are taking a risk going over the head of General Kruger, son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_EnT_SordishRecovery == true"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_EnT_SordishRecovery == true)"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_EnT_SordishRecovery == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Tarquin Soll: ""Despite all my concerns, your achievements for this coun..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_EnT_SordishRecovery == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_EnT_SordishRecovery"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Tarquin Soll: ""Despite the state of our economy and my concerns, your a..."*)

### Węzeł `[424]`
Mówca: **Tarquin Soll**
> ""Despite the state of our economy and my concerns, your achievements for this country have still been commendable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || B..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == t..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Tarquin Soll: ""But you should ask your new band of international allies..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Joined_ATO == true || BaseGame.Joined_CSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true  or  Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Tarquin Soll: ""If and when that fateful day comes, I will not stand idl..."*)

### Węzeł `[428]`
Mówca: **Tarquin Soll**
> ""But you should ask your new band of international allies instead. I'm sure they care just as much about Sordland's fate as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Narrator: "A sudden burst of cheering from the stadium made both of ..."*)
