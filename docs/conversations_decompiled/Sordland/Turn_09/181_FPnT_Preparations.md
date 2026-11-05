# Sordland/Turn09/FPnT_Preparations

- **ID konwersacji:** `181`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/181_FPnT_Preparations.md`
- **Liczba węzłów dialogowych:** 528
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[21]** Deivid Wisci
- **[38]** Lucian Galade
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Arcasia_AcceptedVisit`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Bill_Turn08_HarsherSecurity_Signed`
- `BaseGame.Bill_Turn08_TobaccoTax_Signed`
- `BaseGame.Bill_Turn09_AlcoholTax_Signed`
- `BaseGame.Bill_Turn09_LighterSecurity_Signed`
- `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks`
- `BaseGame.Economy`
- `BaseGame.Enable_RumburgIncident`
- `BaseGame.Hegel_PutInAGoodWordWithMalenyev`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_Agnolia_Alliance`
- `BaseGame.Policy_Diplomacy_Lespia_Alliance`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_Valgsland_Alliance`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Law_EducationUnification`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Law_MinorityRights`
- `BaseGame.Policy_Law_Prostitution_Illegal`
- `BaseGame.Policy_Law_ReligiousHarmony`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Policy_Law_WomenLiberation`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_FreedomAct`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecurityAct`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGame.Turn08_SecondScandal_LiviaStays`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.UnitedContana_AcceptedVisit`
- `BaseGame.UnitedContana_MeetingOffer`
- `BaseGame.Valgsland_Alliance`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Arcasia_AcceptedVisit`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.RumburgIncident_RumburgKnows`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExpandedHumanRights`
- `BaseGame.Situation_Law_LimitedHumanRights`
- `BaseGame.Situation_Law_SomeHumanRights`
- `BaseGame.Situation_Order_CrimeWave`
- `BaseGame.Situation_Order_LittleSecurityPowers`
- `BaseGame.Situation_Order_OrganisedCrime`
- `BaseGame.Situation_Order_OrganisedCrimeContained`
- `BaseGame.Situation_Order_ReductionOfCrimeCommunities`
- `BaseGame.Situation_Order_SomeSecurityPowers`
- `BaseGame.Situation_Order_WideRangingSecurityPowers`
- `BaseGame.Situation_Welfare_IncreasedDepression`
- `BaseGame.SuperpowerVisit_ExtravagantWelcome`
- `BaseGame.SuperpowerVisit_MilitaryWelcome`
- `BaseGame.SuperpowerVisit_PlainWelcome`
- `BaseGame.Turn09_Military_WeakAgainstRumburg`
- `BaseGame.UnitedContana_AcceptedVisit`
- `BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft`
- `BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept`
- `BaseGameSupport.Journal_Turn09_Preparations_UCAccept`
- `BaseGameSupport.News_Turn09_HP_SordishPlaneShot`
- `BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead`
- `BaseGameSupport.Report_Turn09_Valgen_SuicideRates`
- `GameCondition.Turn09_FPnT_Preparations`
- `GameCondition.Turn09_FPnT_SuperpowerVisit`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[24]` | **"“I want the perpetrator found and questioned. Immediately.”"** | `[22]` **Deivid Wisci**: "“Someone is trying to sabotage t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Deivid Wisci**: "“Mr. Galade.”" |
| `[25]` | **"“Getting closer with Valgsland is paying off.”"** | `[22]` **Deivid Wisci**: "“Someone is trying to sabotage t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Deivid Wisci**: "“I think so too.”" |
| `[27]` | **"“Looks like I am not the only one who is not keen on the idea.”"** | `[22]` **Deivid Wisci**: "“Someone is trying to sabotage t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Deivid Wisci**: "“This looks like it is much more..." |
| `[43]` | **"“It's about time. I wanted to meet with him as well.”"** | `[23]` **Deivid Wisci**: "“In addition, as part of this st..." | `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false` | *Brak zmian stanu* | `[48]` **Iosef Lancea**: "“With all due respect...”"<br>`[42]` **Iosef Lancea**: "“I bet he will come asking us fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **"“It's about time. I wanted to meet with Comrade Malenyev as well.”"** | `[23]` **Deivid Wisci**: "“In addition, as part of this st..." | `Variable["BaseGame.Archetype_ComradeRayne"] == true` | *Brak zmian stanu* | `[61]` **Iosef Lancea**: "“*Comrade* Malenyev?”" |
| `[67]` | **"“Are you threatening me?”"** | `[66]` **Iosef Lancea**: "“I will personally make sure of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Iosef Lancea**: "“In the name of the Sordish sove..." |
| `[68]` | **"“Your hands are tied. What power do you even have, Iosef?”"** | `[66]` **Iosef Lancea**: "“I will personally make sure of ..." | `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false` | *Brak zmian stanu* | `[72]` **Iosef Lancea**: "“You will see.”" |
| `[69]` | **"“This is all a misunderstanding. Let's keep civil.”"** | `[66]` **Iosef Lancea**: "“I will personally make sure of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Iosef Lancea**: "“No. There are no more misunders..." |
| `[78]` | **"“Your hands are tied, Iosef. You won't find any allies in the General Staff.”"** | `[66]` **Iosef Lancea**: "“I will personally make sure of ..." | `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true` | *Brak zmian stanu* | `[72]` **Iosef Lancea**: "“You will see.”" |
| `[81]` | **"“Watch your tone, Iosef.”"** | `[50]` **Lucian Galade**: "“Mr. Lancea.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Iosef Lancea**: "“I'm just saying that we can not..." |
| `[82]` | **"Let him continue."** | `[50]` **Lucian Galade**: "“Mr. Lancea.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Iosef Lancea**: "“This is madness. We can not eve..." |
| `[104]` | **"“I won't negotiate with communists.”"** | `[23]` **Deivid Wisci**: "“In addition, as part of this st..." | `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false` | *Brak zmian stanu* | `[154]` **Iosef Lancea**: "“Well said, Mr. President!”"<br>`[157]` **Iosef Lancea**: "“Well said, Mr. President!”"<br>*(oraz 1 innych odgałęzień)* |
| `[105]` | **"“As much as I share their ideals, we need to be wary.”"** | `[23]` **Deivid Wisci**: "“In addition, as part of this st..." | `Variable["BaseGame.Archetype_ComradeRayne"] == true` | *Brak zmian stanu* | `[110]` **Iosef Lancea**: "“You are right about that. We ne..." |
| `[114]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[106]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Iosef Lancea**: "“I hope that will be enough.”" |
| `[115]` | **"“Have no doubt, Iosef. I have sworn an oath to this country.”"** | `[106]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Iosef Lancea**: "“Very well. I trust that you wil..." |
| `[116]` | **"“Everything is on the table if it ensures the well-being of Sordland.”"** | `[106]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Iosef Lancea**: "“If we can't hold onto that much..." |
| `[121]` | **"“We don't need any outside help.”"** | `[106]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Iosef Lancea**: "“I'd like to agree but the situa..." |
| `[123]` | **"“I trust your judgement and our troops.”"** | `[98]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[125]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[98]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Iosef Lancea**: "“We need to be careful.”" |
| `[127]` | **"“I want to take the least amount of risks for Sordland.”"** | `[98]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[130]` | **"“I trust your judgement and our troops.”"** | `[57]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[131]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[132]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[57]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Iosef Lancea**: "“We need to be careful.”" |
| `[133]` | **"“I want to take the least amount of risks for Sordland.”"** | `[57]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[136]` | **"“Watch his every single move. I want to know if he is plotting something.”"** | `[135]` **Lucian Galade**: "“Sir? He has threatened you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lucian Galade**: "“Very well.”" |
| `[137]` | **"“It was simply an unfortunate disagreement in opinion. Carry on.”"** | `[135]` **Lucian Galade**: "“Sir? He has threatened you.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Lucian Galade**: "“Very well.”" |
| `[166]` | **"“I trust your judgement and our troops.”"** | `[159]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[168]` | **"“Exactly. We have nothing to fear.”"** | `[159]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Iosef Lancea**: "“We stand ready.”" |
| `[169]` | **"“Our allies will come in handy in our time of need.”"** | `[159]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Iosef Lancea**: "“Exactly. We don't need more all..." |
| `[171]` | **"“Although I said what I said before, it might still be good to hear what he will s..."** | `[159]` **Iosef Lancea**: "“We don't need any outside *help*.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Iosef Lancea**: "“I bet he will try to persuade y..." |
| `[181]` | **"“I want to take the least amount of risks for Sordland.”"** | `[422]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[182]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[422]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Iosef Lancea**: "“We need to be careful.”" |
| `[183]` | **"“I trust your judgement and our troops.”"** | `[422]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[187]` | **"“Very well. Accept their offer.”"** | `[184]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[186]` **Lucian Galade**: "“We heard our experts. You are t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.UnitedContana_AcceptedVisit"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_Preparations_UCA...` | `[190]` **Deivid Wisci**: "“I will send our response immedi..." |
| `[188]` | **"“I don't want to involve ourselves with superpowers. Decline their offer.”"** | `[184]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[186]` **Lucian Galade**: "“We heard our experts. You are t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[437]` **Deivid Wisci**: "“I will send our response immedi..."<br>`[192]` **Deivid Wisci**: "“I will send our response immedi..." |
| `[189]` | **"“Lucian. What do you think?”"** | `[184]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[413]` **Deivid Wisci**: "“I say we should consider this o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Lucian Galade**: "“We heard our experts. You are t..." |
| `[195]` | **"“Make it as extravagant as you can. We need to impress them.”"** | `[194]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] =...` | `[201]` **Lucian Galade**: "“As you wish. I have taken a note.”" |
| `[196]` | **"“A military welcome is in order. They need to see our might.”"** | `[194]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;` | `[201]` **Lucian Galade**: "“As you wish. I have taken a note.”" |
| `[197]` | **"“A plain welcome will suffice. They are the ones who are requesting this.”"** | `[194]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;` | `[201]` **Lucian Galade**: "“As you wish. I have taken a note.”" |
| `[209]` | **"“It will be glorious.”"** | `[207]` **Deivid Wisci**: "“To announce the declaration and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Deivid Wisci**: "“It will be a historic day for s..." |
| `[210]` | **"“As long as it sways the public support, I am fine with it.”"** | `[207]` **Deivid Wisci**: "“To announce the declaration and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Deivid Wisci**: "“Excellent.”" |
| `[211]` | **"“Good work.”"** | `[207]` **Deivid Wisci**: "“To announce the declaration and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Deivid Wisci**: "“Thank you, Mr. President.”" |
| `[213]` | **"“We need to make sure we have the public support.”"** | `[212]` **Lucian Galade**: "“I was generally successful in i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucian Galade**: "“I'm on it, sir.”" |
| `[214]` | **"“Keep at it. We still have much to do.”"** | `[212]` **Lucian Galade**: "“I was generally successful in i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucian Galade**: "“I'm on it, sir.”" |
| `[215]` | **"“Good job. I am expecting good results.”"** | `[212]` **Lucian Galade**: "“I was generally successful in i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Lucian Galade**: "“I'm on it, sir.”" |
| `[227]` | **"“Looks like I am not the only one who is not keen on the idea.”"** | `[14]` **Deivid Wisci**: "“That is until the United Contan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Deivid Wisci**: "“This looks like it is much more..." |
| `[228]` | **"“I want the perpetrator found and questioned. Immediately.”"** | `[14]` **Deivid Wisci**: "“That is until the United Contan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Deivid Wisci**: "“Mr. Galade.”" |
| `[264]` | **"“God damn it! Can't you do anything right?”"** | `[14]` **Deivid Wisci**: "“That is until the United Contan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Narrator**: "I slammed the table and the room..." |
| `[268]` | **"“You are making me nervous, Iosef.”"** | `[258]` **Iosef Lancea**: "“Good. Because, we will need all..."<br>`[259]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucian Galade**: "“That doesn't exactly inspire co..." |
| `[269]` | **"“This is not the worst threat Sordland has ever faced. We will survive this too.”"** | `[258]` **Iosef Lancea**: "“Good. Because, we will need all..."<br>`[259]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Lucian Galade**: "“We will, sir.”" |
| `[270]` | **"“Otherwise, we are doomed.”"** | `[258]` **Iosef Lancea**: "“Good. Because, we will need all..."<br>`[259]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Lucian Galade**: "“That doesn't exactly inspire co..." |
| `[271]` | **"“We don't need them. Why do we have the Sordish army for?”"** | `[261]` **Iosef Lancea**: "“We need everything we can get.”"<br>`[263]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Lucian Galade**: "“We need to be careful. Too much..." |
| `[272]` | **"“That's right. Rumburg is still a very real threat.”"** | `[261]` **Iosef Lancea**: "“We need everything we can get.”"<br>`[263]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Lucian Galade**: "“Exactly. As part of our enactme..." |
| `[273]` | **"“You are making me nervous, Iosef.”"** | `[261]` **Iosef Lancea**: "“We need everything we can get.”"<br>`[263]` **Iosef Lancea**: "“With the current state our mili..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Lucian Galade**: "“That doesn't exactly inspire co..." |
| `[285]` | **"“It's about time. I wanted to meet with him as well.”"** | `[284]` **Deivid Wisci**: "“In addition, as part of this st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Iosef Lancea**: "“With all due respect...”"<br>`[333]` **Iosef Lancea**: "“I bet he will come asking us fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[286]` | **"“As much as I share their ideals, we need to be wary.”"** | `[284]` **Deivid Wisci**: "“In addition, as part of this st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Iosef Lancea**: "“I agree. At first chance, they ..."<br>`[333]` **Iosef Lancea**: "“I bet he will come asking us fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[287]` | **"“There is something we could gain from this state visit.”"** | `[284]` **Deivid Wisci**: "“In addition, as part of this st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Iosef Lancea**: "“With all due respect...”"<br>`[333]` **Iosef Lancea**: "“I bet he will come asking us fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[288]` | **"“There is something we could gain from this state visit.”"** | `[23]` **Deivid Wisci**: "“In addition, as part of this st..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Iosef Lancea**: "“With all due respect...”"<br>`[42]` **Iosef Lancea**: "“I bet he will come asking us fo..."<br>*(oraz 1 innych odgałęzień)* |
| `[290]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[325]` **Iosef Lancea**: "“I assure you, we don't need any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Iosef Lancea**: "“We need to be careful.”" |
| `[296]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[292]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Iosef Lancea**: "“I hope that will be enough.”" |
| `[300]` | **"“Have no doubt, Iosef. I have sworn an oath to this country.”"** | `[292]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[308]` **Iosef Lancea**: "“Very well. I trust that you wil..." |
| `[302]` | **"“Everything is on the table if it ensures the well-being of Sordland.”"** | `[292]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Iosef Lancea**: "“If we can't hold onto that much..." |
| `[309]` | **"Let him continue."** | `[343]` **Lucian Galade**: "“Mr. Lancea.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Iosef Lancea**: "“This is madness. We can not eve..." |
| `[312]` | **"“We don't need any outside help.”"** | `[292]` **Iosef Lancea**: "“Otherwise our sovereignty will ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Iosef Lancea**: "“I'd like to agree but the situa..." |
| `[321]` | **"“Watch your tone, Iosef.”"** | `[343]` **Lucian Galade**: "“Mr. Lancea.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[327]` **Iosef Lancea**: "“I'm just saying that we can not..." |
| `[337]` | **"“I want to take the least amount of risks for Sordland.”"** | `[325]` **Iosef Lancea**: "“I assure you, we don't need any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[341]` | **"“I trust your judgement and our troops.”"** | `[325]` **Iosef Lancea**: "“I assure you, we don't need any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[346]` | **"“I trust your judgement and our troops.”"** | `[423]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[348]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[423]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Iosef Lancea**: "“We need to be careful.”" |
| `[349]` | **"“I want to take the least amount of risks for Sordland.”"** | `[423]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[365]` | **"“I trust your judgement and our troops.”"** | `[424]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Iosef Lancea**: "“Thank you, Mr. President.”" |
| `[366]` | **"“I want to take the least amount of risks for Sordland.”"** | `[424]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Iosef Lancea**: "“There is way more risk in enter..." |
| `[368]` | **"“Let's see what he wants first. I will decide when I talk to him.”"** | `[424]` **Iosef Lancea**: "“We will make do somehow.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Iosef Lancea**: "“We need to be careful.”" |
| `[384]` | **"“A military welcome is in order. They need to see our might.”"** | `[382]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;` | `[379]` **Lucian Galade**: "“As you wish. I have taken a note.”" |
| `[386]` | **"“Very well. Accept their offer.”"** | `[383]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[385]` **Lucian Galade**: "“We heard our experts. You are t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Arcasia_AcceptedVisit"] = true;`<br>`Variable["BaseGameSupport.Journal_Turn09_Preparations_Arc...` | `[392]` **Deivid Wisci**: "“I will send our response immedi..." |
| `[387]` | **"“I don't want to involve ourselves with superpowers. Decline their offer.”"** | `[383]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[385]` **Lucian Galade**: "“We heard our experts. You are t..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Deivid Wisci**: "“I will send our response immedi..."<br>`[389]` **Deivid Wisci**: "“I will send our response immedi..." |
| `[390]` | **"“Lucian. What do you think?”"** | `[383]` **Deivid Wisci**: "“But, I say we should at least l..."<br>`[414]` **Deivid Wisci**: "“I say we should consider this o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Lucian Galade**: "“We heard our experts. You are t..." |
| `[393]` | **"“A plain welcome will suffice. They are the ones who are requesting this.”"** | `[382]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;` | `[379]` **Lucian Galade**: "“As you wish. I have taken a note.”" |
| `[394]` | **"“Make it as extravagant as you can. We need to impress them.”"** | `[382]` **Lucian Galade**: "“How should we welcome their del..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] =...` | `[379]` **Lucian Galade**: "“As you wish. I have taken a note.”" |

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
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Prostitution_Illegal == true && BaseG..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lucian entered the room with Iosef by his side."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Iosef Lancea: "“Mr. President. We came as fast as we could.”"*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Mr. President. Mr. Wisci.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: "“What is going on?”"*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> "“What is going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Deivid cleared his throat."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.UnitedContana_MeetingOffer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.UnitedContana_MeetingOffer == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.UnitedContana_MeetingOffer == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.UnitedContana_MeetingOffer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.UnitedContana_MeetingOffer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Archety..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.UnitedContana_MeetingOffer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.UnitedContana_MeetingOffer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Deivid Wisci: "“We have received an envoy from Arcasia. They are request..."*)

### Węzeł `[9]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Deivid Wisci: "“To be precise, they *were* requesting a state visit.”"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true && BaseGame.Archety..."*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Arche..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDe..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true && BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true  and  Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Deivid Wisci: "“We have received an envoy from the United Contana. They ..."*)

### Węzeł `[13]`
Mówca: **Deivid Wisci**
> "“To be precise, they *were* requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Deivid Wisci: "“That is until the United Contanan ambassador was assassi..."*)

### Węzeł `[14]`
Mówca: **Deivid Wisci**
> "“That is until the United Contanan ambassador was assassinated in broad daylight in the capital half an hour ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Player: "“God damn it! Can't you do anything right?”"*)
  - -> `[228]` (*Player: "“I want the perpetrator found and questioned. Immediately.”"*)
  - -> `[227]` (*Player: "“Looks like I am not the only one who is not keen on the ..."*)

### Węzeł `[15]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deivid Wisci: "“Judging from the current climate, it is not hard to see ..."*)

### Węzeł `[16]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from Arcasia. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Deivid Wisci: "“Judging from the current climate, it is not hard to see ..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == false"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == false)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Hegel_PutInAGoodWordWithMalenyev == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Deivid Wisci: "“We have received an envoy from the United Contana. They ..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Hegel_PutInAGoodWordWithMalenyev == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Hegel_PutInAGoodWordWithMalenyev"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Deivid Wisci: "“We have received an envoy from the United Contana. They ..."*)

### Węzeł `[20]`
Mówca: **Deivid Wisci**
> "“We have received an envoy from the United Contana. They are requesting a state visit.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Deivid Wisci: "“Subsequently the United Contanan ambassador was shot in ..."*)

### Węzeł `[21]`
Mówca: **Deivid Wisci**
> "“Subsequently the United Contanan ambassador was shot in broad daylight in the capital half an hour ago.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deivid Wisci: "“Someone is trying to sabotage this meet. Regardless, the..."*)

### Węzeł `[22]`
Mówca: **Deivid Wisci**
> "“Someone is trying to sabotage this meet. Regardless, the request was not retracted.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“I want the perpetrator found and questioned. Immediately.”"*)
  - -> `[25]` (*Player: "“Getting closer with Valgsland is paying off.”"*)
  - -> `[27]` (*Player: "“Looks like I am not the only one who is not keen on the ..."*)

### Węzeł `[23]`
Mówca: **Deivid Wisci**
> "“In addition, as part of this state visit, Malenyev will, of course, meet with you in person, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[288]` (*Player: "“There is something we could gain from this state visit.”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I want the perpetrator found and questioned. Immediately.”"]** — Mówca: **Player**
> "“I want the perpetrator found and questioned. Immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Deivid Wisci: "“Mr. Galade.”"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Getting closer with Valgsland is paying off.”"]** — Mówca: **Player**
> "“Getting closer with Valgsland is paying off.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Deivid Wisci: "“I think so too.”"*)

### Węzeł `[26]`
Mówca: **Deivid Wisci**
> "“I think so too.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Regardless, one thing is clear.”"*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Looks like I am not the only one who is not keen on the idea.”"]** — Mówca: **Player**
> "“Looks like I am not the only one who is not keen on the idea.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Deivid Wisci: "“This looks like it is much more than a simple disagreeme..."*)

### Węzeł `[28]`
Mówca: **Deivid Wisci**
> "“Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: "“We are on it.”"*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Regardless, one thing is clear.”"*)

### Węzeł `[30]`
Mówca: **Deivid Wisci**
> "“This looks like it is much more than a simple disagreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Deivid Wisci: "“Regardless, one thing is clear.”"*)

### Węzeł `[31]`
Mówca: **Deivid Wisci**
> "“Regardless, one thing is clear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Deivid Wisci: "“Judging from the current climate, it is not hard to see ..."*)

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Mr. President. We came as fast as we could.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Mr. President. Mr. Wisci.”"*)

### Węzeł `[33]`
Mówca: **Narrator**
> "I was sitting right across from Deivid in the White Room after he scheduled an urgent meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He insisted on waiting for Iosef and Lucian so we did."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Lucian entered the room with Iosef by his side."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "I knew that the matter must've been serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "UpdateCountryRelationship("Sordland_Country_Rumburg", "Ne..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Deivid cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Deivid Wisci: "“Welcome, everyone.”"*)

### Węzeł `[37]`
Mówca: **Deivid Wisci**
> "“Due to the potential ramifications, I wanted everyone to be present for this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.UnitedContana_MeetingOffer == true"*)

### Węzeł `[38]`
Mówca: **Deivid Wisci**
> "“Welcome, everyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Deivid Wisci: "“Due to the potential ramifications, I wanted everyone to..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“As much as I share their ideals, we need to be wary.”"*)
  - -> `[44]` (*Player: "“It's about time. I wanted to meet with Comrade Malenyev ..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“It's about time. I wanted to meet with him as well.”"*)
  - -> `[104]` (*Player: "“I won't negotiate with communists.”"*)

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Iosef Lancea: "“This will antagonise half of the world against us and we..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with him as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with him as well.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with Comrade Malenyev as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with Comrade Malenyev as well.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Iosef Lancea: "“*Comrade* Malenyev?”"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Iosef Lancea: "“With all due respect...”"*)

### Węzeł `[48]`
Mówca: **Iosef Lancea**
> "“With all due respect...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Iosef Lancea: "“Are you out of your mind?”"*)

### Węzeł `[49]`
Mówca: **Iosef Lancea**
> "“Are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lucian Galade: "“Mr. Lancea.”"*)

### Węzeł `[50]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "“Watch your tone, Iosef.”"*)
  - -> `[82]` (*Player_Italic: "Let him continue."*)

### Węzeł `[51]`
Mówca: **Iosef Lancea**
> "“This is madness. We can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Al..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Iosef Lancea: "“Normally, I would be very much against the influence of ..."*)

### Węzeł `[55]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Iosef Lancea: "“We don't need any outside *help*.”"*)

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“We don't need any outside *help*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[130]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[133]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Iosef Lancea: "“If you are worried, don't worry about the war with Rumbu..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Iosef Lancea: "“With the courage of our troops and our allies, we can de..."*)

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“*Comrade* Malenyev?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Iosef Lancea: "“Watch out, Mr. President. You have started to show your ..."*)

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“Watch out, Mr. President. You have started to show your true colours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Iosef Lancea: "“But, I understand now. I see your intentions.”"*)

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“But, I understand now. I see your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Iosef Lancea: "“You mean to bring a communist revolution to Sordland.”"*)

### Węzeł `[64]`
Mówca: **Iosef Lancea**
> "“Let me say something then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Iosef Lancea: "“You and your plans with your *comrades* won't fly in Sor..."*)

### Węzeł `[65]`
Mówca: **Iosef Lancea**
> "“You and your plans with your *comrades* won't fly in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Iosef Lancea: "“I will personally make sure of that.”"*)

### Węzeł `[66]`
Mówca: **Iosef Lancea**
> "“I will personally make sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: "“Are you threatening me?”"*)
  - -> `[69]` (*Player: "“This is all a misunderstanding. Let's keep civil.”"*)
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)

### Węzeł `[67]`
**[WYBÓR GRACZA: "“Are you threatening me?”"]** — Mówca: **Player**
> "“Are you threatening me?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Iosef Lancea: "“In the name of the Sordish sovereignty, yes, I am, Mr. P..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA: "“Your hands are tied. What power do you even have, Iosef?”"]** — Mówca: **Player**
> "“Your hands are tied. What power do you even have, Iosef?”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[66]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Iosef Lancea: "“You will see.”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“This is all a misunderstanding. Let's keep civil.”"]** — Mówca: **Player**
> "“This is all a misunderstanding. Let's keep civil.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[66]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Iosef Lancea: "“No. There are no more misunderstandings.”"*)

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“In the name of the Sordish sovereignty, yes, I am, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“I swore an oath to protect Sordland and I will follow th..."*)

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“I swore an oath to protect Sordland and I will follow that oath until the end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Iosef Lancea: "“You better remember yours as well.”"*)

### Węzeł `[72]`
Mówca: **Iosef Lancea**
> "“You will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“I swore an oath to protect Sordland and I will follow th..."*)

### Węzeł `[73]`
Mówca: **Iosef Lancea**
> "“No. There are no more misunderstandings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Iosef Lancea: "“I understand everything clearly. I see where you are dir..."*)

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“I understand everything clearly. I see where you are directing this country towards.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Iosef Lancea: "“I swore an oath to protect Sordland and I will follow th..."*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == ..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“Your hands are tied, Iosef. You won't find any allies in..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "“Your hands are tied. What power do you even have, Iosef?”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Your hands are tied, Iosef. You won't find any allies in the General Staff.”"]** — Mówca: **Player**
> "“Your hands are tied, Iosef. You won't find any allies in the General Staff.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Kontekst wejściowy (poprzednik):** `[66]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Iosef Lancea: "“You will see.”"*)

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“You better remember yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Iosef got up and left the room. He banged the door so har..."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Iosef got up and left the room. He banged the door so hard that I was sure anyone could hear it in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft = true"*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Watch your tone, Iosef.”"]** — Mówca: **Player**
> "“Watch your tone, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Iosef Lancea: "“I'm just saying that we can not even consider accepting ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I did not say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Iosef Lancea: "“This is madness. We can not even consider accepting this.”"*)

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“I'm just saying that we can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[84]`
Mówca: **Iosef Lancea**
> "“Normally, I would be very much against the influence of any superpower, let alone United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Iosef Lancea: "“But as much as I hate to admit...”"*)

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“But as much as I hate to admit...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“We need help in our war against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Iosef Lancea: "“Especially since we don't have any allies.”"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Iosef Lancea: "“We need help in our war against Rumburg.”"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Iosef Lancea: "“We need allies to bolster our defense.”"*)

### Węzeł `[90]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Iosef Lancea: "“That's why I am not against the idea of him coming here ..."*)

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“We need allies to bolster our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Iosef Lancea: "“That's why I am not against the idea of him coming here ..."*)

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Iosef Lancea: "“This will antagonise half of the world against us and we..."*)

### Węzeł `[93]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Iosef Lancea: "“As for the war with Rumburg; our troops are armed well a..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Iosef Lancea: "“If you are approaching this from the perspective of nati..."*)

### Węzeł `[97]`
Mówca: **Iosef Lancea**
> "“If you are approaching this from the perspective of national defense then don't. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[123]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[127]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“That's why I am not against the idea of him coming here to extend his *helping hand*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Iosef Lancea: "“On one condition...”"*)

### Węzeł `[100]`
Mówca: **Iosef Lancea**
> "“On one condition...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Iosef Lancea: "“Sordish military command must belong to Sordland at all ..."*)

### Węzeł `[101]`
Mówca: **Iosef Lancea**
> "“Sordish military command must belong to Sordland at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Iosef Lancea: "“Otherwise our sovereignty will be in grave danger.”"*)

### Węzeł `[102]`
Mówca: **Deivid Wisci**
> "“Judging from the current climate, it is not hard to see what this is about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Deivid Wisci: "“CSP is always trying to expand its influence after all. ..."*)

### Węzeł `[103]`
Mówca: **Deivid Wisci**
> "“CSP is always trying to expand its influence after all. They will most likely try to convince us to join.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Deivid Wisci: "“In addition, as part of this state visit, Malenyev will,..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“I won't negotiate with communists.”"]** — Mówca: **Player**
> "“I won't negotiate with communists.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[23]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“As much as I share their ideals, we need to be wary.”"]** — Mówca: **Player**
> "“As much as I share their ideals, we need to be wary.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Kontekst wejściowy (poprzednik):** `[23]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Iosef Lancea: "“You are right about that. We need to be extremely cautio..."*)

### Węzeł `[106]`
Mówca: **Iosef Lancea**
> "“Otherwise our sovereignty will be in grave danger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“Have no doubt, Iosef. I have sworn an oath to this count..."*)
  - -> `[114]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[116]` (*Player: "“Everything is on the table if it ensures the well-being ..."*)
  - -> `[121]` (*Player: "“We don't need any outside help.”"*)

### Węzeł `[107]`
Mówca: **Iosef Lancea**
> "“But, *share* their ideals?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Iosef Lancea: "“Watch out, Mr. President. You have started to show your ..."*)

### Węzeł `[108]`
Mówca: **Iosef Lancea**
> "“Watch out, Mr. President. You have started to show your true colours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Iosef Lancea: "“But, I understand now. I see your intentions.”"*)

### Węzeł `[109]`
Mówca: **Iosef Lancea**
> "“But, I understand now. I see your intentions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Iosef Lancea: "“You mean to bring a communist revolution to Sordland.”"*)

### Węzeł `[110]`
Mówca: **Iosef Lancea**
> "“You are right about that. We need to be extremely cautious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Iosef Lancea: "“But, *share* their ideals?”"*)

### Węzeł `[111]`
Mówca: **Iosef Lancea**
> "“You mean to bring a communist revolution to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Iosef Lancea: "“Let me say something then.”"*)

### Węzeł `[112]`
Mówca: **Iosef Lancea**
> "“Let me say something then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Iosef Lancea: "“You and your plans won't fly in Sordland.”"*)

### Węzeł `[113]`
Mówca: **Iosef Lancea**
> "“You and your plans won't fly in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Iosef Lancea: "“I will personally make sure of that.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Iosef Lancea: "“I hope that will be enough.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Have no doubt, Iosef. I have sworn an oath to this country.”"]** — Mówca: **Player**
> "“Have no doubt, Iosef. I have sworn an oath to this country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Iosef Lancea: "“Very well. I trust that you will be vigilant.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Everything is on the table if it ensures the well-being of Sordland.”"]** — Mówca: **Player**
> "“Everything is on the table if it ensures the well-being of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Iosef Lancea: "“If we can't hold onto that much, all is already lost for..."*)

### Węzeł `[117]`
Mówca: **Iosef Lancea**
> "“I hope that will be enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "“Very well. I trust that you will be vigilant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“If we can't hold onto that much, all is already lost for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[120]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“We don't need any outside help.”"]** — Mówca: **Player**
> "“We don't need any outside help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Iosef Lancea: "“I'd like to agree but the situation is apparent.”"*)

### Węzeł `[122]`
Mówca: **Iosef Lancea**
> "“I'd like to agree but the situation is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[124]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[126]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Iosef Lancea: "“There is way more risk in entering a pact with CSP.”"*)

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[131]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Iosef Lancea: "“There is way more risk in entering a pact with CSP.”"*)

### Węzeł `[134]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[135]`
Mówca: **Lucian Galade**
> "“Sir? He has threatened you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“It was simply an unfortunate disagreement in opinion. Ca..."*)
  - -> `[136]` (*Player: "“Watch his every single move. I want to know if he is plo..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Watch his every single move. I want to know if he is plotting something.”"]** — Mówca: **Player**
> "“Watch his every single move. I want to know if he is plotting something.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“It was simply an unfortunate disagreement in opinion. Carry on.”"]** — Mówca: **Player**
> "“It was simply an unfortunate disagreement. Carry on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Lucian Galade: "“Very well.”"*)

### Węzeł `[138]`
Mówca: **Lucian Galade**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: "“Mr. Wisci. Please continue.”"*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> "“Mr. Wisci. Please continue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Deivid Wisci: "“As you wish.”"*)

### Węzeł `[140]`
Mówca: **Deivid Wisci**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_..."*)

### Węzeł `[141]`
Mówca: **Deivid Wisci**
> "“It all boils down to your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Deivid Wisci: "“But, I say we should at least listen to what Malenyev ha..."*)

### Węzeł `[142]`
Mówca: **Deivid Wisci**
> "“World tension is increasing rapidly, Mr. President, and I am worried about the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Deivid Wisci: "“One misstep and the whole world might be engulfed in cha..."*)

### Węzeł `[143]`
Mówca: **Deivid Wisci**
> "“If we don't pick a side, we may end up right in the middle of a potential conflict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Deivid Wisci: "“I am of the opinion that this is an opportunity that we ..."*)

### Węzeł `[144]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stay neutral in this case. Our geopolitical position is simply too important. Soon, we will have to take a side. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Deivid Wisci: "“If we don't pick a side, we may end up right in the midd..."*)

### Węzeł `[145]`
Mówca: **Deivid Wisci**
> "“One misstep and the whole world might be engulfed in chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Deivid Wisci: "“I am afraid it might not be possible to stay neutral in ..."*)

### Węzeł `[146]`
Mówca: **Deivid Wisci**
> "“I am of the opinion that this is an opportunity that we can't miss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Deivid Wisci: "“It all boils down to your decision.”"*)

### Węzeł `[147]`
Mówca: **Lucian Galade**
> "“Mr. Wisci. We rely a lot on you as you are an expert in your field with a proven track record.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Lucian Galade: "“What's your take on this? What do you think is the right..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Iosef Lancea: "“Well said, Mr. President!”"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Al..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Iosef Lancea: "“Well said, Mr. President!”"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Iosef Lancea: "“Well said, Mr. President!”"*)

### Węzeł `[154]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[155]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[156]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Iosef Lancea: "“But as much as I hate to admit...”"*)

### Węzeł `[157]`
Mówca: **Iosef Lancea**
> "“Well said, Mr. President!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Iosef Lancea: "“With the courage of our troops and our allies, we can de..."*)

### Węzeł `[158]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Iosef Lancea: "“We don't need any outside *help*.”"*)

### Węzeł `[159]`
Mówca: **Iosef Lancea**
> "“We don't need any outside *help*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: "“Our allies will come in handy in our time of need.”"*)
  - -> `[166]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[168]` (*Player: "“Exactly. We have nothing to fear.”"*)
  - -> `[171]` (*Player: "“Although I said what I said before, it might still be go..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Iosef Lancea: "“If you are worried, don't worry about the war with Rumbu..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Iosef Lancea: "“We don't need any outside *help*.”"*)

### Węzeł `[163]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Iosef Lancea: "“We don't need any outside *help*.”"*)

### Węzeł `[164]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[165]`
Mówca: **Iosef Lancea**
> "“We stand ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[167]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "“Exactly. We have nothing to fear.”"]** — Mówca: **Player**
> "“Exactly. We have nothing to fear.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Iosef Lancea: "“We stand ready.”"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Our allies will come in handy in our time of need.”"]** — Mówca: **Player**
> "“Our allies will come in handy in our time of need.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Iosef Lancea: "“Exactly. We don't need more allies in return for servitu..."*)

### Węzeł `[170]`
Mówca: **Iosef Lancea**
> "“Exactly. We don't need more allies in return for servitude.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: "“Although I said what I said before, it might still be good to hear what he will say.”"]** — Mówca: **Player**
> "“Although I said what I said before, it might still be good to hear what he will say.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Iosef Lancea: "“I bet he will try to persuade you with his snake tongue.”"*)

### Węzeł `[172]`
Mówca: **Iosef Lancea**
> "“I bet he will try to persuade you with his snake tongue.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[173]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Iosef Lancea: "“As for the war with Rumburg; our troops are armed well a..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[177]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Iosef Lancea: "“We will make do somehow.”"*)

### Węzeł `[178]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with CSP.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[179]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[180]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Lucian Galade: "“Mr. Wisci. We rely a lot on you as you are an expert in ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Iosef Lancea: "“There is way more risk in entering a pact with CSP.”"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[422]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[184]`
Mówca: **Deivid Wisci**
> "“But, I say we should at least listen to what Malenyev has to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: "“Lucian. What do you think?”"*)
  - -> `[187]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[188]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn09_FPnT_Preparations_IosefLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Iosef_Enemy = true"*)

### Węzeł `[186]`
Mówca: **Lucian Galade**
> "“We heard our experts. You are the one who has to decide, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[188]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "“Very well. Accept their offer.”"]** — Mówca: **Player**
> "“Very well. Accept their offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Deivid Wisci), `[186]` (Lucian Galade), `[413]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.UnitedContana_AcceptedVisit = true"*)

### Węzeł `[188]`
**[WYBÓR GRACZA: "“I don't want to involve ourselves with superpowers. Decline their offer.”"]** — Mówca: **Player**
> "“I don't want to involve ourselves with superpowers. Decline their offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Deivid Wisci), `[186]` (Lucian Galade), `[413]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Lucian. What do you think?”"]** — Mówca: **Player**
> "“Lucian. What do you think?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[184]` (Deivid Wisci), `[413]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Lucian Galade: "“We heard our experts. You are the one who has to decide,..."*)

### Węzeł `[190]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Lucian Galade: "“Then there is a tiny detail we need to get over with it.”"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.UnitedContana_AcceptedVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.UnitedContana_AcceptedVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Preparations_UCAccept = true"*)

### Węzeł `[192]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[193]`
Mówca: **Lucian Galade**
> "“Then there is a tiny detail we need to get over with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lucian Galade: "“How should we welcome their delegation, sir?”"*)

### Węzeł `[194]`
Mówca: **Lucian Galade**
> "“How should we welcome their delegation, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: "“Make it as extravagant as you can. We need to impress th..."*)
  - -> `[196]` (*Player: "“A military welcome is in order. They need to see our mig..."*)
  - -> `[197]` (*Player: "“A plain welcome will suffice. They are the ones who are ..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Make it as extravagant as you can. We need to impress them.”"]** — Mówca: **Player**
> "“Make it as extravagant as you can. We need to impress them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_ExtravagantWelcome = true"*)

### Węzeł `[196]`
**[WYBÓR GRACZA: "“A military welcome is in order. They need to see our might.”"]** — Mówca: **Player**
> "“A military welcome is in order. They need to see our might.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome = true"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“A plain welcome will suffice. They are the ones who are requesting this.”"]** — Mówca: **Player**
> "“A plain welcome will suffice. They are the ones who are requesting this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_PlainWelcome = true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_ExtravagantWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_PlainWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[201]`
Mówca: **Lucian Galade**
> "“As you wish. I have taken a note.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Deivid Wisci: "“There is another matter.”"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Deivid Wisci: "“I think that is all for today.”"*)

### Węzeł `[205]`
Mówca: **Deivid Wisci**
> "“There is another matter.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Deivid Wisci: "“We had discussions with Mr. Lancea on the declaration of..."*)

### Węzeł `[206]`
Mówca: **Deivid Wisci**
> "“We had discussions with Mr. Lancea on the declaration of war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Deivid Wisci: "“To announce the declaration and the start of the operati..."*)

### Węzeł `[207]`
Mówca: **Deivid Wisci**
> "“To announce the declaration and the start of the operation, we are scheduling a televised speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: "“It will be glorious.”"*)
  - -> `[210]` (*Player: "“As long as it sways the public support, I am fine with it.”"*)
  - -> `[211]` (*Player: "“Good work.”"*)

### Węzeł `[208]`
Mówca: **Lucian Galade**
> "“Apart from that, my propaganda efforts are still underway.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lucian Galade: "“I was generally successful in increasing the public supp..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA: "“It will be glorious.”"]** — Mówca: **Player**
> "“It will be glorious.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deivid Wisci: "“It will be a historic day for sure.”"*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "“As long as it sways the public support, I am fine with it.”"]** — Mówca: **Player**
> "“As long as it sways the public support, I am fine with it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Deivid Wisci: "“Excellent.”"*)

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Good work.”"]** — Mówca: **Player**
> "“Good work.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Deivid Wisci: "“Thank you, Mr. President.”"*)

### Węzeł `[212]`
Mówca: **Lucian Galade**
> "“I was generally successful in increasing the public support for the war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: "“Good job. I am expecting good results.”"*)
  - -> `[214]` (*Player: "“Keep at it. We still have much to do.”"*)
  - -> `[213]` (*Player: "“We need to make sure we have the public support.”"*)

### Węzeł `[213]`
**[WYBÓR GRACZA: "“We need to make sure we have the public support.”"]** — Mówca: **Player**
> "“We need to make sure we have the public support.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“I'm on it, sir.”"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Keep at it. We still have much to do.”"]** — Mówca: **Player**
> "“Keep at it. We still have much to do.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“I'm on it, sir.”"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Good job. I am expecting good results.”"]** — Mówca: **Player**
> "“Good job. I am expecting good results.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lucian Galade: "“I'm on it, sir.”"*)

### Węzeł `[216]`
Mówca: **Deivid Wisci**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deivid Wisci: "“It will be a historic day for sure.”"*)

### Węzeł `[217]`
Mówca: **Deivid Wisci**
> "“Excellent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deivid Wisci: "“It will be a historic day for sure.”"*)

### Węzeł `[218]`
Mówca: **Deivid Wisci**
> "“It will be a historic day for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lucian Galade: "“Apart from that, my propaganda efforts are still underway.”"*)

### Węzeł `[219]`
Mówca: **Lucian Galade**
> "“I'm on it, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Deivid Wisci: "“I think that is all for today.”"*)

### Węzeł `[220]`
Mówca: **Deivid Wisci**
> "“I think that is all for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Deivid Wisci: "“Thank you all for attending.”"*)

### Węzeł `[221]`
Mówca: **Deivid Wisci**
> "“Thank you all for attending.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "As we dispersed, the world map hanging on the wall in the..."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "As we dispersed, the world map hanging on the wall in the room caught my attention. I walked over to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "How often were the lines on the world map redrawn over th..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "How often were the lines on the world map redrawn over the recent decades?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "What about the future?"*)

### Węzeł `[224]`
Mówca: **Narrator**
> "What about the future?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_Preparations = true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Iosef_Enemy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Iosef_Enemy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Lucian Galade: "“Sir? He has threatened you.”"*)

### Węzeł `[226]`
Mówca: **Deivid Wisci**
> "“This looks like it is much more than a simple disagreement.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[227]`
**[WYBÓR GRACZA: "“Looks like I am not the only one who is not keen on the idea.”"]** — Mówca: **Player**
> "“Looks like I am not the only one who is not keen on the idea.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Deivid Wisci: "“This looks like it is much more than a simple disagreeme..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA: "“I want the perpetrator found and questioned. Immediately.”"]** — Mówca: **Player**
> "“I want the perpetrator found and questioned. Immediately.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Deivid Wisci: "“Mr. Galade.”"*)

### Węzeł `[229]`
Mówca: **Deivid Wisci**
> "“Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lucian Galade: "“We are on it.”"*)

### Węzeł `[230]`
Mówca: **Lucian Galade**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Iosef Lancea: "“This is a clear sabotage to our international status.”"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Iosef Lancea: "“Good riddance.”"*)

### Węzeł `[234]`
Mówca: **Iosef Lancea**
> "“Good riddance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Iosef Lancea: "“This way we won't need to deal with the snake-tongued Ma..."*)

### Węzeł `[235]`
Mówca: **Iosef Lancea**
> "“This is a clear sabotage to our international status.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Iosef Lancea: "“We need to get to the bottom of this.”"*)

### Węzeł `[236]`
Mówca: **Iosef Lancea**
> "“We need to get to the bottom of this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: "“We will, I assure you.”"*)

### Węzeł `[237]`
Mówca: **Iosef Lancea**
> "“This way we won't need to deal with the snake-tongued Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Lucian raised an eyebrow and stared at Iosef."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Lucian raised an eyebrow and stared at Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Iosef Lancea: "“Why are you looking at me like that, Mr. Galade?”"*)

### Węzeł `[239]`
Mówca: **Iosef Lancea**
> "“Why are you looking at me like that, Mr. Galade?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Iosef Lancea: "“If you are trying to imply something you shouldn't then ..."*)

### Węzeł `[240]`
Mówca: **Iosef Lancea**
> "“If you are trying to imply something you shouldn't then you shouldn't.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Lucian Galade: "“I haven't said anything, Mr. Lancea.”"*)

### Węzeł `[241]`
Mówca: **Lucian Galade**
> "“We will, I assure you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lucian Galade: "“But for now, the situation we are in is apparent.”"*)

### Węzeł `[242]`
Mówca: **Lucian Galade**
> "“I haven't said anything, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Lucian Galade: "“Regardless, the situation we are in is apparent.”"*)

### Węzeł `[243]`
Mówca: **Lucian Galade**
> "“Regardless, the situation we are in is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Deivid Wisci: "“Indeed. We have now lost the opportunity to side with a ..."*)

### Węzeł `[244]`
Mówca: **Deivid Wisci**
> "“Indeed. We have now lost the opportunity to side with a very strong ally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[245]`
Mówca: **Deivid Wisci**
> "“That means we are all alone. We have no allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Al..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Deivid Wisci: "“Thankfully we still have allies in the region.”"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Deivid Wisci: "“That means we are all alone. We have no allies.”"*)

### Węzeł `[249]`
Mówca: **Deivid Wisci**
> "“Thankfully we still have allies in the region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Deivid Wisci: "“They will be helpful in the upcoming war with Rumburg.”"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Deivid Wisci: "“They will be helpful in acting as a deterrence.”"*)

### Węzeł `[253]`
Mówca: **Deivid Wisci**
> "“They will be helpful in the upcoming war with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Iosef Lancea: "“Good. Because, we will need all the help we can get.”"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Deivid Wisci: "“As if that is not already bad news, there is also the fa..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Deivid Wisci: "“In the case of a war, we will not get any help.”"*)

### Węzeł `[257]`
Mówca: **Deivid Wisci**
> "“As if that is not already bad news, there is also the fact that we are going to war with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[258]`
Mówca: **Iosef Lancea**
> "“Good. Because, we will need all the help we can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“This is not the worst threat Sordland has ever faced. We..."*)
  - -> `[268]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[270]` (*Player: "“Otherwise, we are doomed.”"*)

### Węzeł `[259]`
Mówca: **Iosef Lancea**
> "“With the current state our military is in, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“This is not the worst threat Sordland has ever faced. We..."*)
  - -> `[268]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[270]` (*Player: "“Otherwise, we are doomed.”"*)

### Węzeł `[260]`
Mówca: **Deivid Wisci**
> "“They will be helpful in acting as a deterrence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Iosef Lancea: "“We need everything we can get.”"*)

### Węzeł `[261]`
Mówca: **Iosef Lancea**
> "“We need everything we can get.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[272]` (*Player: "“That's right. Rumburg is still a very real threat.”"*)
  - -> `[271]` (*Player: "“We don't need them. Why do we have the Sordish army for?”"*)

### Węzeł `[262]`
Mówca: **Deivid Wisci**
> "“In the case of a war, we will not get any help.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[263]`
Mówca: **Iosef Lancea**
> "“With the current state our military is in, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[272]` (*Player: "“That's right. Rumburg is still a very real threat.”"*)
  - -> `[271]` (*Player: "“We don't need them. Why do we have the Sordish army for?”"*)

### Węzeł `[264]`
**[WYBÓR GRACZA: "“God damn it! Can't you do anything right?”"]** — Mówca: **Player**
> "“God damn it! Can't you do anything right?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "I slammed the table and the room fell silent."*)

### Węzeł `[265]`
Mówca: **Lucian Galade**
> "“We are very sorry, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[266]`
Mówca: **Narrator**
> "I slammed the table and the room fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lucian Galade: "“We are very sorry, sir.”"*)

### Węzeł `[267]`
Mówca: **Lucian Galade**
> "“But for now, the situation we are in is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Deivid Wisci: "“Indeed. We have now lost the opportunity to side with a ..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA: "“You are making me nervous, Iosef.”"]** — Mówca: **Player**
> "“You are making me nervous, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Iosef Lancea), `[259]` (Iosef Lancea), `[429]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“That doesn't exactly inspire confidence, Mr. Lancea.”"*)

### Węzeł `[269]`
**[WYBÓR GRACZA: "“This is not the worst threat Sordland has ever faced. We will survive this too.”"]** — Mówca: **Player**
> "“This is not the worst threat Sordland has ever faced. We will survive this too.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Iosef Lancea), `[259]` (Iosef Lancea), `[429]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Lucian Galade: "“We will, sir.”"*)

### Węzeł `[270]`
**[WYBÓR GRACZA: "“Otherwise, we are doomed.”"]** — Mówca: **Player**
> "“Otherwise, we are doomed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[258]` (Iosef Lancea), `[259]` (Iosef Lancea), `[429]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Lucian Galade: "“That doesn't exactly inspire confidence, Mr. President.”"*)

### Węzeł `[271]`
**[WYBÓR GRACZA: "“We don't need them. Why do we have the Sordish army for?”"]** — Mówca: **Player**
> "“We don't need them. Why do we have the Sordish army for?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Iosef Lancea), `[263]` (Iosef Lancea), `[428]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lucian Galade: "“We need to be careful. Too much is at stake.”"*)

### Węzeł `[272]`
**[WYBÓR GRACZA: "“That's right. Rumburg is still a very real threat.”"]** — Mówca: **Player**
> "“That's right. Rumburg is still a very real threat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Iosef Lancea), `[263]` (Iosef Lancea), `[428]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Lucian Galade: "“Exactly. As part of our enactments during our term, we w..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA: "“You are making me nervous, Iosef.”"]** — Mówca: **Player**
> "“You are making me nervous, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[261]` (Iosef Lancea), `[263]` (Iosef Lancea), `[428]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Lucian Galade: "“That doesn't exactly inspire confidence, Mr. Lancea.”"*)

### Węzeł `[274]`
Mówca: **Lucian Galade**
> "“We will, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: "“Well then.”"*)

### Węzeł `[275]`
Mówca: **Lucian Galade**
> "“That doesn't exactly inspire confidence, Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: "“Well then.”"*)

### Węzeł `[276]`
Mówca: **Lucian Galade**
> "“That doesn't exactly inspire confidence, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: "“Well then.”"*)

### Węzeł `[277]`
Mówca: **Lucian Galade**
> "“Exactly. As part of our enactments during our term, we worked on strengthening our military.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: "“Well then.”"*)

### Węzeł `[278]`
Mówca: **Lucian Galade**
> "“We need to be careful. Too much is at stake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deivid Wisci: "“Well then.”"*)

### Węzeł `[279]`
Mówca: **Deivid Wisci**
> "“Well then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[280]`
Mówca: **Deivid Wisci**
> "“We need to look at the future at this point and let bygones be bygones.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucian Galade: "“Agreed. Was that all for today, Mr. Wisci?”"*)

### Węzeł `[281]`
Mówca: **Lucian Galade**
> "“Agreed. Was that all for today, Mr. Wisci?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[282]`
Mówca: **Deivid Wisci**
> "“Judging from the current climate, it is not hard to see what this is about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Deivid Wisci: "“ATO is always trying to expand its influence after all. ..."*)

### Węzeł `[283]`
Mówca: **Deivid Wisci**
> "“ATO is always trying to expand its influence after all. They will most likely try to convince us to join.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Deivid Wisci: "“In addition, as part of this state visit, Dwight Walker ..."*)

### Węzeł `[284]`
Mówca: **Deivid Wisci**
> "“In addition, as part of this state visit, Dwight Walker will, of course, meet with you in person, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player: "“It's about time. I wanted to meet with him as well.”"*)
  - -> `[287]` (*Player: "“There is something we could gain from this state visit.”"*)
  - -> `[286]` (*Player: "“As much as I share their ideals, we need to be wary.”"*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "“It's about time. I wanted to meet with him as well.”"]** — Mówca: **Player**
> "“It's about time. I wanted to meet with him as well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA: "“As much as I share their ideals, we need to be wary.”"]** — Mówca: **Player**
> "“As much as I share their ideals, we need to be wary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[287]`
**[WYBÓR GRACZA: "“There is something we could gain from this state visit.”"]** — Mówca: **Player**
> "“There is something we could gain from this state visit.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[288]`
**[WYBÓR GRACZA: "“There is something we could gain from this state visit.”"]** — Mówca: **Player**
> "“There is something we could gain from this state visit.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)

### Węzeł `[289]`
Mówca: **Iosef Lancea**
> "“You mean to bring a communist revolution to Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Iosef Lancea: "“Let me say something then.”"*)

### Węzeł `[290]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[291]`
Mówca: **Iosef Lancea**
> "“Sordish military command must belong to Sordland at all costs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Iosef Lancea: "“Otherwise our sovereignty will be in grave danger.”"*)

### Węzeł `[292]`
Mówca: **Iosef Lancea**
> "“Otherwise our sovereignty will be in grave danger.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player: "“Have no doubt, Iosef. I have sworn an oath to this count..."*)
  - -> `[296]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[302]` (*Player: "“Everything is on the table if it ensures the well-being ..."*)
  - -> `[312]` (*Player: "“We don't need any outside help.”"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Iosef Lancea: "“With all due respect...”"*)

### Węzeł `[296]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Iosef Lancea: "“I hope that will be enough.”"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Iosef Lancea: "“If you are worried, don't worry about the war with Rumbu..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Iosef Lancea: "“With the courage of our troops and our allies, we can de..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA: "“Have no doubt, Iosef. I have sworn an oath to this country.”"]** — Mówca: **Player**
> "“Have no doubt, Iosef. I have sworn an oath to this country.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Iosef Lancea: "“Very well. I trust that you will be vigilant.”"*)

### Węzeł `[301]`
Mówca: **Iosef Lancea**
> "“We need allies to bolster our defense.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Iosef Lancea: "“That's why I am not against the idea of him coming here ..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA: "“Everything is on the table if it ensures the well-being of Sordland.”"]** — Mówca: **Player**
> "“Everything is on the table if it ensures the well-being of Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Iosef Lancea: "“If we can't hold onto that much, all is already lost for..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Iosef Lancea: "“As for the war with Rumburg; our troops are armed well a..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Iosef Lancea: "“If you are approaching this from the perspective of nati..."*)

### Węzeł `[306]`
Mówca: **Iosef Lancea**
> "“I hope that will be enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[307]`
Mówca: **Iosef Lancea**
> "“If you are approaching this from the perspective of national defense then don't. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[308]`
Mówca: **Iosef Lancea**
> "“Very well. I trust that you will be vigilant.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: "Let him continue."]** — Mówca: **Player_Italic**
> "I did not say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Iosef Lancea: "“This is madness. We can not even consider accepting this.”"*)

### Węzeł `[310]`
Mówca: **Iosef Lancea**
> "“If we can't hold onto that much, all is already lost for Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[311]`
Mówca: **Iosef Lancea**
> "“This is madness. We can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA: "“We don't need any outside help.”"]** — Mówca: **Player**
> "“We don't need any outside help.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Iosef Lancea: "“I'd like to agree but the situation is apparent.”"*)

### Węzeł `[313]`
Mówca: **Iosef Lancea**
> "“With all due respect...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Iosef Lancea: "“Are you out of your mind?”"*)

### Węzeł `[314]`
Mówca: **Iosef Lancea**
> "“I'd like to agree but the situation is apparent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Al..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Iosef Lancea: "“Normally, I would be very much against the influence of ..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Iosef Lancea: "“We need help in our war against Rumburg.”"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Iosef Lancea: "“We need allies to bolster our defense.”"*)

### Węzeł `[321]`
**[WYBÓR GRACZA: "“Watch your tone, Iosef.”"]** — Mówca: **Player**
> "“Watch your tone, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Iosef Lancea: "“I'm just saying that we can not even consider accepting ..."*)

### Węzeł `[322]`
Mówca: **Iosef Lancea**
> "“On one condition...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Iosef Lancea: "“Sordish military command must belong to Sordland at all ..."*)

### Węzeł `[323]`
Mówca: **Iosef Lancea**
> "“Are you out of your mind?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lucian Galade: "“Mr. Lancea.”"*)

### Węzeł `[324]`
Mówca: **Iosef Lancea**
> "“With the courage of our troops and our allies, we can defend our nation against anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[325]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[341]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[337]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[326]`
Mówca: **Iosef Lancea**
> "“Normally, I would be very much against the influence of any superpower.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Iosef Lancea: "“But as much as I hate to admit...”"*)

### Węzeł `[327]`
Mówca: **Iosef Lancea**
> "“I'm just saying that we can not even consider accepting this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[328]`
Mówca: **Iosef Lancea**
> "“We need help in our war against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Iosef Lancea: "“Especially since we don't have any allies.”"*)

### Węzeł `[329]`
Mówca: **Iosef Lancea**
> "“Especially since we don't have any allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Iosef Lancea: "“That's why I am not against the idea of him coming here ..."*)

### Węzeł `[330]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Iosef Lancea: "“We will make do somehow.”"*)

### Węzeł `[331]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[332]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Iosef Lancea: "“This will antagonise half of the world against us and we..."*)

### Węzeł `[333]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Iosef Lancea: "“This will antagonise half of the world against us and we..."*)

### Węzeł `[334]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[335]`
Mówca: **Iosef Lancea**
> "“As for the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[336]`
Mówca: **Iosef Lancea**
> "“That's why I am not against the idea of him coming here to extend his *helping hand*.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Iosef Lancea: "“On one condition...”"*)

### Węzeł `[337]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Iosef Lancea: "“There is way more risk in entering a pact with ATO.”"*)

### Węzeł `[338]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[339]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[340]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[342]`
Mówca: **Iosef Lancea**
> "“But as much as I hate to admit...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[343]`
Mówca: **Lucian Galade**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player: "“Watch your tone, Iosef.”"*)
  - -> `[309]` (*Player_Italic: "Let him continue."*)

### Węzeł `[344]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[345]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[347]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[349]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Iosef Lancea: "“There is way more risk in entering a pact with ATO.”"*)

### Węzeł `[350]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Iosef Lancea: "“I agree. At first chance, they would pounce on the oppor..."*)

### Węzeł `[354]`
Mówca: **Iosef Lancea**
> "“I agree. At first chance, they would pounce on the opportunity to enslave us to their will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Iosef Lancea: "“I bet he will come asking us for *cooperation* under the..."*)

### Węzeł `[355]`
Mówca: **Iosef Lancea**
> "“I bet he will come asking us for *cooperation* under the guise of enforcing their demands to join ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Iosef Lancea: "“This will antagonise half of the world against us and we..."*)

### Węzeł `[356]`
Mówca: **Iosef Lancea**
> "“This will antagonise half of the world against us and we are going to be at the forefront of the battle!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.RumburgIncident_DeclareWar == true)"*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_DeclareWar == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Iosef Lancea: "“From the perspective of the war with Rumburg; our troops..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.RumburgIncident_DeclareWar == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Iosef Lancea: "“From the perspective of national defense; we are in a be..."*)

### Węzeł `[360]`
Mówca: **Iosef Lancea**
> "“From the perspective of national defense; we are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[361]`
Mówca: **Iosef Lancea**
> "“From the perspective of the war with Rumburg; our troops are armed well and ready for combat. We are in a better shape than we were ever before!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Iosef Lancea: "“I assure you, we don't need any outside *help*. Definite..."*)

### Węzeł `[362]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Dwight Walker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Iosef Lancea: "“We will make do somehow.”"*)

### Węzeł `[363]`
Mówca: **Iosef Lancea**
> "“There is way more risk in entering a pact with ATO.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[364]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[365]`
**[WYBÓR GRACZA: "“I trust your judgement and our troops.”"]** — Mówca: **Player**
> "“I trust your judgement and our troops.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Iosef Lancea: "“Thank you, Mr. President.”"*)

### Węzeł `[366]`
**[WYBÓR GRACZA: "“I want to take the least amount of risks for Sordland.”"]** — Mówca: **Player**
> "“I want to take the least amount of risks for Sordland.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Iosef Lancea: "“There is way more risk in entering a pact with ATO.”"*)

### Węzeł `[367]`
Mówca: **Iosef Lancea**
> "“We need to be careful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Lucian Galade: "“Mr. Walker never gives anything for free. There will be ..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA: "“Let's see what he wants first. I will decide when I talk to him.”"]** — Mówca: **Player**
> "“Let's see what he wants first. I will decide when I talk to him.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Iosef Lancea: "“We need to be careful.”"*)

### Węzeł `[369]`
Mówca: **Lucian Galade**
> "“Mr. Walker never gives anything for free. There will be some concessions for sure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Lucian Galade: "“Mr. Wisci you are our most experienced foreign policy ex..."*)

### Węzeł `[370]`
Mówca: **Lucian Galade**
> "“Mr. Wisci you are our most experienced foreign policy expert. What's your take on this? What do you think is the right action?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_..."*)

### Węzeł `[371]`
Mówca: **Lucian Galade**
> "“What's your take on this? What do you think is the right action?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_..."*)

### Węzeł `[372]`
Mówca: **Deivid Wisci**
> "“It all boils down to your decision.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Deivid Wisci: "“But, I say we should at least listen to what Dwight Walk..."*)

### Węzeł `[373]`
Mówca: **Deivid Wisci**
> "“World tension is increasing rapidly, Mr. President, and I am worried about the future.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Deivid Wisci: "“One misstep and the whole world might be engulfed in cha..."*)

### Węzeł `[374]`
Mówca: **Deivid Wisci**
> "“If we don't pick a side, we may end up right in the middle of a potential conflict.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Deivid Wisci: "“I am of the opinion that this is an opportunity that we ..."*)

### Węzeł `[375]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stay neutral in this case. Our geopolitical position is simply too important. Soon, we will have to take a side. ”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Deivid Wisci: "“If we don't pick a side, we may end up right in the midd..."*)

### Węzeł `[376]`
Mówca: **Deivid Wisci**
> "“One misstep and the whole world might be engulfed in chaos.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Deivid Wisci: "“I am afraid it might not be possible to stay neutral in ..."*)

### Węzeł `[377]`
Mówca: **Deivid Wisci**
> "“I am of the opinion that this is an opportunity that we can't miss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Deivid Wisci: "“It all boils down to your decision.”"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arcasia_AcceptedVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Arcasia_AcceptedVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept..."*)

### Węzeł `[379]`
Mówca: **Lucian Galade**
> "“As you wish. I have taken a note.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_ExtravagantWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_ExtravagantWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_MilitaryWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_MilitaryWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[382]`
Mówca: **Lucian Galade**
> "“How should we welcome their delegation, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: "“Make it as extravagant as you can. We need to impress th..."*)
  - -> `[384]` (*Player: "“A military welcome is in order. They need to see our mig..."*)
  - -> `[393]` (*Player: "“A plain welcome will suffice. They are the ones who are ..."*)

### Węzeł `[383]`
Mówca: **Deivid Wisci**
> "“But, I say we should at least listen to what Dwight Walker has to say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player: "“Lucian. What do you think?”"*)
  - -> `[386]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[387]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA: "“A military welcome is in order. They need to see our might.”"]** — Mówca: **Player**
> "“A military welcome is in order. They need to see our might.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_MilitaryWelcome = true"*)

### Węzeł `[385]`
Mówca: **Lucian Galade**
> "“We heard our experts. You are the one who has to decide, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[387]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA: "“Very well. Accept their offer.”"]** — Mówca: **Player**
> "“Very well. Accept their offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Deivid Wisci), `[385]` (Lucian Galade), `[414]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arcasia_AcceptedVisit = true"*)

### Węzeł `[387]`
**[WYBÓR GRACZA: "“I don't want to involve ourselves with superpowers. Decline their offer.”"]** — Mówca: **Player**
> "“I don't want to involve ourselves with superpowers. Decline their offer.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Deivid Wisci), `[385]` (Lucian Galade), `[414]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerVisit_PlainWelcome = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.SuperpowerVisit_PlainWelcome"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Lucian Galade: "“As you wish. I have taken a note.”"*)

### Węzeł `[389]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[390]`
**[WYBÓR GRACZA: "“Lucian. What do you think?”"]** — Mówca: **Player**
> "“Lucian. What do you think?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Deivid Wisci), `[414]` (Deivid Wisci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Lucian Galade: "“We heard our experts. You are the one who has to decide,..."*)

### Węzeł `[391]`
Mówca: **Lucian Galade**
> "“Then there is a tiny detail we need to get over with it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Lucian Galade: "“How should we welcome their delegation, sir?”"*)

### Węzeł `[392]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Lucian Galade: "“Then there is a tiny detail we need to get over with it.”"*)

### Węzeł `[393]`
**[WYBÓR GRACZA: "“A plain welcome will suffice. They are the ones who are requesting this.”"]** — Mówca: **Player**
> "“A plain welcome will suffice. They are the ones who are requesting this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_PlainWelcome = true"*)

### Węzeł `[394]`
**[WYBÓR GRACZA: "“Make it as extravagant as you can. We need to impress them.”"]** — Mówca: **Player**
> "“Make it as extravagant as you can. We need to impress them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[382]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerVisit_ExtravagantWelcome = true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_FPnT_Preparations = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_FPnT_Preparations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.UnitedContana_AcceptedVisit == false && BaseGame..."*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.UnitedContana_AcceptedVisit == false && BaseGame..."*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.UnitedContana_AcceptedVisit == false && BaseGa..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.UnitedContana_AcceptedVisit"] == false  and  Variable["BaseGame.Arcasia_AcceptedVisit"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn09_FPnT_SuperpowerVisit = true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.UnitedContana_AcceptedVisit == false && BaseGame.Arcasia_AcceptedVisit == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.UnitedContana_AcceptedVisit"] == false  and  Variable["BaseGame.Arcasia_AcceptedVisit"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn09_FPnT_SuperpowerVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn09_FPnT_SuperpowerVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[400]`
Mówca: **Narrator**
> "I knew that the matter must've been serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He insisted on waiting for Iosef and Lucian so we did."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "I knew that the matter must've been serious."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "I knew that the matter must've been serious."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Preparations_UCAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Preparations_UCAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Deivid Wisci: "“I will send our response immediately.”"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Preparations_ArcasiaAccept"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Deivid Wisci: "“I will send our response immediately.”"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_LT_UnitedContana_AmbassadorDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Hegel_PutInAGoodWordWithMalenyev == false"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_..."*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Lespia_Alliance == true || (BaseGame.Valgslan..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Deivid Wisci: "“World tension is increasing rapidly, Mr. President, and ..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Deivid Wisci: "“Rumburg is bound to increase diplomatic pressure in the ..."*)

### Węzeł `[410]`
Mówca: **Deivid Wisci**
> "“And I recently found out of a planned meeting between the Queen and President Walker of Arcasia. The CSP and Chairman Malenyev might be the necessary evil to stop worse things from happening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Deivid Wisci: "“I say we should consider this offer very seriously.”"*)

### Węzeł `[411]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stand against Rumburg without strong allies. Soon, we will have to take a side in this global rivalry to avert a potential conflict with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Deivid Wisci: "“And I recently found out of a planned meeting between th..."*)

### Węzeł `[412]`
Mówca: **Deivid Wisci**
> "“Rumburg is bound to increase diplomatic pressure in the upcoming AN meeting. Backchannels are reporting rumours about Queen Beatrice Livingston meeting with military leaders in Thornbourg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Deivid Wisci: "“I am afraid it might not be possible to stand against Ru..."*)

### Węzeł `[413]`
Mówca: **Deivid Wisci**
> "“I say we should consider this offer very seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: "“Lucian. What do you think?”"*)
  - -> `[187]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[188]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[414]`
Mówca: **Deivid Wisci**
> "“I say we should consider this offer very seriously.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player: "“Lucian. What do you think?”"*)
  - -> `[386]` (*Player: "“Very well. Accept their offer.”"*)
  - -> `[387]` (*Player: "“I don't want to involve ourselves with superpowers. Decl..."*)

### Węzeł `[415]`
Mówca: **Deivid Wisci**
> "“And I recently found out of a planned meeting between the Queen and Chairman Malenyev of United Contana. The ATO and President Walker might be the necessary evil to stop worse things from happening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Deivid Wisci: "“I say we should consider this offer very seriously.”"*)

### Węzeł `[416]`
Mówca: **Deivid Wisci**
> "“I am afraid it might not be possible to stand against Rumburg without strong allies. Soon, we will have to take a side in this global rivalry to avert a potential conflict with Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Deivid Wisci: "“And I recently found out of a planned meeting between th..."*)

### Węzeł `[417]`
Mówca: **Deivid Wisci**
> "“Rumburg is bound to increase diplomatic pressure in the upcoming AN meeting. Backchannels are reporting rumours about Queen Beatrice Livingston meeting with military leaders in Thornbourg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Deivid Wisci: "“I am afraid it might not be possible to stand against Ru..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_..."*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Lespia_Alliance == true || (BaseGame.Valgslan..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Deivid Wisci: "“World tension is increasing rapidly, Mr. President, and ..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Lespia_Alliance == true || (BaseGame.Valgsland_Alliance == true && BaseGame.Turn09_Military_WeakAgainstRumburg == false)))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  (Variable["BaseGame.Valgsland_Alliance"] == true  and  Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Deivid Wisci: "“Rumburg is bound to increase diplomatic pressure in the ..."*)

### Węzeł `[421]`
Mówca: **Iosef Lancea**
> "“I assure you, we don't need any outside *help*. Definitely not from Malenyev.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Iosef Lancea: "“We will make do somehow.”"*)

### Węzeł `[422]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[183]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[181]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[423]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[346]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[349]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[424]`
Mówca: **Iosef Lancea**
> "“We will make do somehow.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Player: "“Let's see what he wants first. I will decide when I talk..."*)
  - -> `[365]` (*Player: "“I trust your judgement and our troops.”"*)
  - -> `[366]` (*Player: "“I want to take the least amount of risks for Sordland.”"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Iosef Lancea: "“With the current state our military is in, this is very ..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Iosef Lancea: "“Even though our military situation has improved, this is..."*)

### Węzeł `[428]`
Mówca: **Iosef Lancea**
> "“Even though our military situation has improved, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[272]` (*Player: "“That's right. Rumburg is still a very real threat.”"*)
  - -> `[271]` (*Player: "“We don't need them. Why do we have the Sordish army for?”"*)

### Węzeł `[429]`
Mówca: **Iosef Lancea**
> "“Even though our military situation has improved, this is very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player: "“This is not the worst threat Sordland has ever faced. We..."*)
  - -> `[268]` (*Player: "“You are making me nervous, Iosef.”"*)
  - -> `[270]` (*Player: "“Otherwise, we are doomed.”"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg == true"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Iosef Lancea: "“With the current state our military is in, this is very ..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn09_Military_WeakAgainstRumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Iosef Lancea: "“Even though our military situation has improved, this is..."*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Deivid Wisci: "“I will send our response immediately. Sordland stands al..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Deivid Wisci: "“I will send our response immediately.”"*)

### Węzeł `[436]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately. Sordland stands alone in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[437]`
Mówca: **Deivid Wisci**
> "“I will send our response immediately. Sordland stands alone in the world.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Deivid Wisci: "“I will send our response immediately. Sordland stands al..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Deivid Wisci: "“I will send our response immediately.”"*)

### Węzeł `[441]`
Mówca: **Deivid Wisci**
> "“We need to look at the future at this point even if we stand alone in it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Lucian Galade: "“Agreed. Was that all for today, Mr. Wisci?”"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && Ba..."*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && ..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Deivid Wisci: "“We need to look at the future at this point even if we s..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Agnolia_Alliance == false && BaseGame.Policy_Diplomacy_Valgsland_Alliance == false && BaseGame.Policy_Diplomacy_Lespia_Alliance == false && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Agnolia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Valgsland_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Lespia_Alliance"] == false  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Deivid Wisci: "“We need to look at the future at this point and let bygo..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn09_Military_WeakAgainstRumburg = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn09_Military_WeakAgainstRumburg"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I was sitting right across from Deivid in the White Room ..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_FreedomAct == true && BaseGame.Po..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = true; Bas..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecurityAct == true && (BaseGame.Po..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true ||..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn09_Military_WeakAgainstRumburg = true"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (BaseGame.Turn03_EnT_Military_Budget_Maintain == true && BaseGame.Turn06_SnO_Conscription_Removed == true && BaseGame.RumburgIncident_RumburgKnows == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  (Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true  and  Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true  and  Variable["BaseGame.RumburgIncident_RumburgKnows"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "I was sitting right across from Deivid in the White Room ..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_SomeHumanRights = true;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = true;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.RumburgIncident_RumburgKnows = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.RumburgIncident_RumburgKnows"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Prostitution_Illegal == true && BaseG..."*)
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Prostitution_Illegal == true && Bas..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Prostitution_Illegal"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true  and   Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Economy"] < 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Welfare_IncreasedDepression = true; Ba..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Prostitution_Illegal == true && BaseGame.Bill_Turn09_AlcoholTax_Signed == true &&  BaseGame.Bill_Turn08_TobaccoTax_Signed == true && BaseGame.Economy < 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Prostitution_Illegal"] == true  and  Variable["BaseGame.Bill_Turn09_AlcoholTax_Signed"] == true  and   Variable["BaseGame.Bill_Turn08_TobaccoTax_Signed"] == true  and  Variable["BaseGame.Economy"] < 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_CrimeWave = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_CrimeWave"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaStays == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays == true"*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaStays == true)"*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaStays == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_RumburgKnows = true"*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaStays == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaStays"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Decrease == true || (..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == true && (BaseGame.P..."*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_MinorityRights == true && (BaseGame..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == true
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and  Variable["BaseGame.Policy_Law_EducationUnification"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation = true; Base..."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_MinorityRights == true
&&
(BaseGame.Policy_Law_ReligiousHarmony == false && BaseGame.Policy_Law_EducationUnification == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == true
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and  Variable["BaseGame.Policy_Law_EducationUnification"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == false && (BaseGame...."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn09_HP_SordishPlaneShot"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays == true"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Welfare_IncreasedDepression = true;
BaseGameSupport.Report_Turn09_Valgen_SuicideRates = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Welfare_IncreasedDepression"] = true;
Variable["BaseGameSupport.Report_Turn09_Valgen_SuicideRates"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecurityAct == true && (BaseGame.Po..."*)
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecurityAct == true && (BaseGame...."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation = false;
BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_EmergencyDecree == true)"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_EmergencyDecree == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  || ..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation = true;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = true;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_OrganisedCrime = true;
BaseGame.Situation_Order_ReductionOfCrimeCommunities = false;
BaseGame.Situation_Order_OrganisedCrimeContained = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_OrganisedCrime"] = true;
Variable["BaseGame.Situation_Order_ReductionOfCrimeCommunities"] = false;
Variable["BaseGame.Situation_Order_OrganisedCrimeContained"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false |..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = false; BaseGame...."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  || ..."*)
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true  |..."*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = true; BaseGame.S..."*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == true 
|| (BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true ||BaseGame.Policy_Law_Ban_YoungSords == true))
&&
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == true 
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true))
 and 
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)"*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_CrimeWave = true;"*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_OrganisedCrime = true; BaseGame...."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_FreedomAct == true && BaseGame.Po..."*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_LittleSecurityPowers = false; Ba..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_FreedomAct == true &&
BaseGame.Policy_Law_MinorityRights == true &&
BaseGame.Policy_Order_SecurityAct == true &&
(BaseGame.Policy_Law_Ban_WPB == true || BaseGame.Policy_Law_Ban_RedYouth == true || BaseGame.Policy_Law_Ban_YoungSords == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_FreedomAct"] == true  and 
Variable["BaseGame.Policy_Law_MinorityRights"] == true  and 
Variable["BaseGame.Policy_Order_SecurityAct"] == true  and 
(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true  or  Variable["BaseGame.Policy_Law_Ban_YoungSords"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_SomeHumanRights = false;
BaseGame.Situation_Law_LimitedHumanRights = false;
BaseGame.Situation_Law_ExpandedHumanRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_SomeHumanRights"] = false;
Variable["BaseGame.Situation_Law_LimitedHumanRights"] = false;
Variable["BaseGame.Situation_Law_ExpandedHumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == false && (BaseGame...."*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_MinorityRights == false && (BaseGam..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == false
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == true  and  Variable["BaseGame.Policy_Law_EducationUnification"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation = false; Bas..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_MinorityRights == false
&&
(BaseGame.Policy_Law_ReligiousHarmony == true && BaseGame.Policy_Law_EducationUnification == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == false
 and 
(Variable["BaseGame.Policy_Law_ReligiousHarmony"] == true  and  Variable["BaseGame.Policy_Law_EducationUnification"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == true && BaseGame.Po..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == true && BaseGame.Po..."*)
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_MinorityRights == true && BaseGame...."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_MinorityRights"] == true  and  Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and 
Variable["BaseGame.Policy_Law_EducationUnification"] == false  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation = true; Base..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_MinorityRights == true && BaseGame.Policy_Law_ReligiousHarmony == false &&
BaseGame.Policy_Law_EducationUnification == false && BaseGame.Policy_Diplomacy_RelaxedImmigration == true && BaseGame.Policy_Diplomacy_Wehlen_JointOperation == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_MinorityRights"] == true  and  Variable["BaseGame.Policy_Law_ReligiousHarmony"] == false  and 
Variable["BaseGame.Policy_Law_EducationUnification"] == false  and  Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true  and  Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation = false; Bas..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_FreedomAct == true && BaseGame.Poli..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true"*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// continue`
- **Efekt skryptowy (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// end`
- **Efekt skryptowy (`userScript`):** `-- end;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = false;
BaseGame.Situation_Order_SomeSecurityPowers = true;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_LittleSecurityPowers = true;
BaseGame.Situation_Order_SomeSecurityPowers = false;
BaseGame.Situation_Order_WideRangingSecurityPowers = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_LittleSecurityPowers"] = true;
Variable["BaseGame.Situation_Order_SomeSecurityPowers"] = false;
Variable["BaseGame.Situation_Order_WideRangingSecurityPowers"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "// continue"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alli..."*)
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Al..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Iosef Lancea: "“With the courage of our troops and our allies, we can de..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Lespia_Alliance == true || BaseGame.Agnolia_Alliance == true || BaseGame.Valgsland_Alliance == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  Variable["BaseGame.Agnolia_Alliance"] == true  or  Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Iosef Lancea: "“If you are worried, don't worry about the war with Rumbu..."*)

### Węzeł `[515]`
Mówca: **Iosef Lancea**
> "“If you are worried, don't worry about the war with Rumburg. Our troops are brave and ready to die for their country. On top of it, we have our allies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.RumburgIncident_DeclareWar == true"*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation = false;
BaseGame.Situation_Law_BludishOppression = false;
BaseGame.Situation_Law_BludishProblem = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;
Variable["BaseGame.Situation_Law_BludishOppression"] = false;
Variable["BaseGame.Situation_Law_BludishProblem"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdateCountryRelationship("Sordland_Country_Rumburg", "Neutral");`
- **Efekt skryptowy (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Neutral");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He insisted on waiting for Iosef and Lucian so we did."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false || ..."*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false |..."*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_SomeHumanRights = false; BaseGame...."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn08_HarsherSecurity_Signed == false
|| (BaseGame.Policy_Law_Ban_WPB == false || BaseGame.Policy_Law_Ban_RedYouth == false ||BaseGame.Policy_Law_Ban_YoungSords == false))
&& 
(BaseGame.Bill_Turn09_LighterSecurity_Signed == true || BaseGame.Policy_Law_MinorityRights == true) && (BaseGame.Policy_Law_SpecialZoneOfBergia == false && BaseGame.Policy_Law_WomenLiberation == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn08_HarsherSecurity_Signed"] == false
 or  (Variable["BaseGame.Policy_Law_Ban_WPB"] == false  or  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == false  or Variable["BaseGame.Policy_Law_Ban_YoungSords"] == false))
 and  
(Variable["BaseGame.Bill_Turn09_LighterSecurity_Signed"] == true  or  Variable["BaseGame.Policy_Law_MinorityRights"] == true)  and  (Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  Variable["BaseGame.Policy_Law_WomenLiberation"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishReconciliation == true)"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "// end"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishReconciliation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_MinorityRights == true && (BaseGame.P..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ==..."*)
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks ..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false  and  Variable["BaseGame.Enable_RumburgIncident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn09_HP_SordishPlaneShot = true"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks == false && BaseGame.Enable_RumburgIncident == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn09_RumburgPeaceSummit_StartTalks"] == false  and  Variable["BaseGame.Enable_RumburgIncident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaStays == true"*)
