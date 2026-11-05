# Sordland/Turn06/A_AutocratDemands

- **ID konwersacji:** `83`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/083_A_AutocratDemands.md`
- **Liczba węzłów dialogowych:** 372
- **Liczba wyborów gracza:** 78

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[36]** Heron Garaci
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Immigration_Relaxed`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Turn01_EnT_Economy_Market`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain`
- `BaseGame.Turn03_EnT_Military_Budget_Decrease`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn03_EnT_Military_Budget_Maintain`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs`
- `BaseGameIsolated.turn06_AutocratDemands_Conscription`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Diplomacy_RelaxedImmigration`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Military_CompulsoryMilitaryService`
- `BaseGame.Reform_Autocrat_Demanded_FullNationalization`
- `BaseGame.Reform_Autocrat_Demanded_TightenedImmigration`
- `BaseGame.Situation_Military_LackOfReservists`
- `BaseGame.Situation_Military_LargeReservistPool`
- `BaseGame.Situation_Order_IllegalImmigration`
- `BaseGame.Situation_Order_StreamlinedImmigration`
- `BaseGame.Turn05_FPnT_Immigration_Tight`
- `BaseGame.Turn06_SnO_Conscription_Removed`
- `BaseGameIsolated.Turn06_AutocratDemands_Immigration`
- `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs`
- `BaseGameIsolated.turn06_AutocratDemands_Conscription`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription`
- `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads`
- `BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise`
- `BaseGameSupport.Journal_Turn06_Conscription_Mandatory`
- `BaseGameSupport.Journal_Turn06_Conscription_Removed`
- `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore`
- `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten`
- `BaseGameSupport.News_Turn06_ST_VictoryDay`
- `BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency`
- `GameCondition.Turn06_A_AutocratDemands`
- `GameCondition.Turn06_A_Reform`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Send him in.""** | `[6]` **Livia Suno**: ""Sorry to interrupt, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Livia Suno**: ""Right away."" |
| `[11]` | **""I told you that I'm expecting an important call. No visitors.""** | `[6]` **Livia Suno**: ""Sorry to interrupt, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Livia Suno**: ""He told me that he's here to ta..." |
| `[12]` | **""I'm waiting for Orso Hawker, not Heron.""** | `[6]` **Livia Suno**: ""Sorry to interrupt, Mr. Preside..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Livia Suno**: ""He told me that he's here to ta..." |
| `[15]` | **""Send him in.""** | `[13]` **Livia Suno**: ""He told me that he's here to ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Livia Suno**: ""Right away."" |
| `[16]` | **""So Orso has sent his pawn.""** | `[13]` **Livia Suno**: ""He told me that he's here to ta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Livia Suno**: ""Um..."" |
| `[23]` | **""Busy? I'm a busy man too, Mr. Garaci.""** | `[22]` **Heron Garaci**: ""I'm sorry if I disappointed you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Heron Garaci**: ""Of course you are, Mr. President."" |
| `[24]` | **""You're right. I am disappointed.""** | `[22]` **Heron Garaci**: ""I'm sorry if I disappointed you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Heron Garaci**: ""Life is full of disappointments..." |
| `[25]` | **""Let's get to the point.""** | `[22]` **Heron Garaci**: ""I'm sorry if I disappointed you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Heron Garaci**: ""Of course."" |
| `[26]` | **""What is the Court plotting, Mr. Garaci?""** | `[22]` **Heron Garaci**: ""I'm sorry if I disappointed you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Heron Garaci**: ""We are not plotting anything, M..." |
| `[43]` | **""Then why did you accept the case?""** | `[42]` **Heron Garaci**: ""Although, of course, none of us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Heron Garaci**: ""It is the responsibility of the..." |
| `[44]` | **""What is the meaning of this?""** | `[42]` **Heron Garaci**: ""Although, of course, none of us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Heron Garaci**: ""There's nothing out of the ordi..." |
| `[45]` | **""We don't want that indeed...""** | `[42]` **Heron Garaci**: ""Although, of course, none of us..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Heron Garaci**: ""Yes. That's why we need to talk."" |
| `[52]` | **""The Court has promised not to act about this clause.""** | `[50]` **Heron Garaci**: ""But as you know, The Constituti..."<br>`[291]` **Heron Garaci**: ""But it isn't up to me. Unless....." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Heron Garaci**: ""That's true."" |
| `[53]` | **""Don't you dare stab me in the back.""** | `[50]` **Heron Garaci**: ""But as you know, The Constituti..."<br>`[291]` **Heron Garaci**: ""But it isn't up to me. Unless....." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Heron Garaci**: ""Of course not."" |
| `[54]` | **""You and Orso are also implicated in this. Don't forget that.""** | `[50]` **Heron Garaci**: ""But as you know, The Constituti..."<br>`[291]` **Heron Garaci**: ""But it isn't up to me. Unless....." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Heron Garaci**: ""We won't."" |
| `[55]` | **""Okay, I get it. You have demands.""** | `[50]` **Heron Garaci**: ""But as you know, The Constituti..."<br>`[291]` **Heron Garaci**: ""But it isn't up to me. Unless....." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Heron Garaci**: ""Well..."" |
| `[58]` | **""If you promised to help me, why did you accept the case?""** | `[57]` **Narrator**: "He smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Heron Garaci**: ""It is the responsibility of the..." |
| `[59]` | **""I hope you are really doing your best, Mr. Garaci.""** | `[57]` **Narrator**: "He smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Heron Garaci**: ""Of course we are, Mr. President..." |
| `[60]` | **""Is that a threat?""** | `[57]` **Narrator**: "He smiled." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Heron Garaci**: ""No. No. You are getting this al..." |
| `[65]` | **""The Court promised not to act on this clause.""** | `[51]` **Heron Garaci**: ""But as you know... the Constitu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Heron Garaci**: ""Yes, we did."" |
| `[66]` | **""Don't you dare stab me in the back.""** | `[51]` **Heron Garaci**: ""But as you know... the Constitu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Heron Garaci**: ""Of course not... As long as you..." |
| `[67]` | **""And?""** | `[51]` **Heron Garaci**: ""But as you know... the Constitu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Heron Garaci**: ""Well..."" |
| `[81]` | **""Tell me about them.""** | `[80]` **Heron Garaci**: ""We wish to see you address thes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Heron Garaci**: ""Of course."" |
| `[82]` | **""And what if I don't?""** | `[80]` **Heron Garaci**: ""We wish to see you address thes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Heron Garaci**: ""Then I cannot promise the Court..." |
| `[83]` | **""This is treachery!""** | `[80]` **Heron Garaci**: ""We wish to see you address thes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Heron Garaci**: ""It is not. It would only be tre..." |
| `[89]` | **""You're right. We'll definitely tighten immigration.""** | `[88]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Heron Garaci**: ""That's good to hear."" |
| `[90]` | **""I can't do that.""** | `[88]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Heron Garaci**: ""That's precisely why we are con..." |
| `[91]` | **"Stay silent."** | `[88]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Heron Garaci**: ""We hope to see you revert your ..." |
| `[104]` | **""What are you suggesting here?""** | `[103]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Heron Garaci**: ""We are already in an emergency,..." |
| `[105]` | **""There is no evidence of this.""** | `[103]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Heron Garaci**: ""What evidence do you need when ..." |
| `[106]` | **""I share the same concerns.""** | `[103]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Heron Garaci**: ""Then we are on the same page."" |
| `[110]` | **""I can't disagree with that.""** | `[294]` **Heron Garaci**: ""We can't let a handful of peopl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Heron Garaci**: ""We hope you follow through with..." |
| `[111]` | **""That is too extreme, Mr. Garaci.""** | `[294]` **Heron Garaci**: ""We can't let a handful of peopl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Heron Garaci**: ""And your Emergency Act was not?"" |
| `[112]` | **""We are already working on market economy reforms. Your little proposal doesn't al..."** | `[294]` **Heron Garaci**: ""We can't let a handful of peopl..." | `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[116]` **Heron Garaci**: ""Really?"" |
| `[125]` | **""What concerns?""** | `[124]` **Heron Garaci**: ""With that said, they might be p..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmi...` | `[155]` **Heron Garaci**: ""Mr. President, we are worried a..."<br>`[317]` **Heron Garaci**: ""We are concerned about Sordland..." |
| `[126]` | **""I'm on to your shenanigans, Mr. Garaci.""** | `[124]` **Heron Garaci**: ""With that said, they might be p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Heron Garaci**: ""There are no shenanigans, Mr. P..." |
| `[127]` | **""I thought the Old Guard controlled the Court.""** | `[124]` **Heron Garaci**: ""With that said, they might be p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Heron Garaci**: ""We do. And there are no problem..." |
| `[132]` | **""Okay, I get it. What do you want?""** | `[131]` **Heron Garaci**: ""But of course, some of us are h..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmi...` | `[155]` **Heron Garaci**: ""Mr. President, we are worried a..."<br>`[317]` **Heron Garaci**: ""We are concerned about Sordland..." |
| `[133]` | **""No. As we already agreed, you will fix this as soon as possible. I won't cave to ..."** | `[131]` **Heron Garaci**: ""But of course, some of us are h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Heron Garaci**: ""Whatever you say, Mr. President..." |
| `[136]` | **""You're right. We'll definitely tighten immigration.""** | `[135]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Heron Garaci**: ""That's relieving."" |
| `[139]` | **"Stay silent."** | `[135]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Heron Garaci**: ""We hope to see you revert your ..." |
| `[145]` | **""I can't do that.""** | `[135]` **Heron Garaci**: ""There have been countless cases..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Heron Garaci**: ""That's precisely why we are con..." |
| `[149]` | **""There is no evidence of this.""** | `[140]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Heron Garaci**: ""What evidence do you need when ..." |
| `[150]` | **""I share the same concerns.""** | `[140]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Heron Garaci**: ""Then we are on the same page."" |
| `[152]` | **""What are you suggesting here?""** | `[140]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Heron Garaci**: ""We are already in an emergency,..." |
| `[161]` | **""Is that a threat?""** | `[160]` **Heron Garaci**: ""Of course, there are some justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Heron Garaci**: ""You promised to manage this eme..."<br>`[166]` **Heron Garaci**: ""We are doing our best to keep t..." |
| `[162]` | **""You promised the Court would side with me.""** | `[160]` **Heron Garaci**: ""Of course, there are some justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Heron Garaci**: ""You promised to manage this eme..."<br>`[166]` **Heron Garaci**: ""We are doing our best to keep t..." |
| `[163]` | **""What is the meaning of this!?""** | `[160]` **Heron Garaci**: ""Of course, there are some justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Heron Garaci**: ""You promised to manage this eme..."<br>`[166]` **Heron Garaci**: ""We are doing our best to keep t..." |
| `[168]` | **""Impeach me?""** | `[167]` **Heron Garaci**: ""Of course, nobody would go as f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Heron Garaci**: ""As you know, the Constitution s..." |
| `[169]` | **""What are you suggesting?""** | `[167]` **Heron Garaci**: ""Of course, nobody would go as f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Heron Garaci**: ""As you know, the Constitution s..." |
| `[170]` | **""Don't you dare stab me in the back.""** | `[167]` **Heron Garaci**: ""Of course, nobody would go as f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Heron Garaci**: ""As you know, the Constitution s..." |
| `[173]` | **""Screw you, Mr. Garaci.""** | `[172]` **Heron Garaci**: ""I don't know what to say. After..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Heron Garaci**: ""Where are your manners, Mr. Pre..." |
| `[174]` | **""You have balls coming to me like that.""** | `[172]` **Heron Garaci**: ""I don't know what to say. After..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Heron Garaci**: ""Where are your manners, Mr. Pre..." |
| `[175]` | **""Listen to me. The Court will reject Ricter's case and I will forget about this co..."** | `[172]` **Heron Garaci**: ""I don't know what to say. After..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Heron Garaci**: ""That depends, Mr. President."" |
| `[176]` | **"Stay silent."** | `[172]` **Heron Garaci**: ""I don't know what to say. After..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Heron Garaci**: ""Listen..."" |
| `[182]` | **""You will regret this. Get out of my sight!""** | `[181]` **Heron Garaci**: ""Then we will see what happens."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Heron Garaci**: ""Whatever you say."" |
| `[183]` | **""What if I don't?""** | `[181]` **Heron Garaci**: ""Then we will see what happens."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Heron Garaci**: ""Then it might just be too hard ..." |
| `[184]` | **""Don't worry. We are on the same side. I will do as you say.""** | `[181]` **Heron Garaci**: ""Then we will see what happens."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Heron Garaci**: ""Good. The Old Guard will be wai..." |
| `[185]` | **""We are already working on market economy reforms. What you're saying doesn't alig..."** | `[181]` **Heron Garaci**: ""Then we will see what happens."" | `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true` | *Brak zmian stanu* | `[186]` **Heron Garaci**: ""Does being impeached align with..." |
| `[194]` | **"Don't shake his hand."** | `[198]` **Narrator**: "He extended his hand towards mine." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Narrator**: "He raised an eyebrow and then sm..." |
| `[195]` | **"Shake his hand."** | `[198]` **Narrator**: "He extended his hand towards mine." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Heron Garaci**: ""Goodbye, Mr. President. Thank y..." |
| `[202]` | **"Start working on a decree to tighten immigration."** | `[262]` **Narrator**: "I had promised the people of Sor..."<br>`[201]` **Narrator**: "I reflected on our conversation ..." | `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false` | `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"...`<br>`Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true;`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[206]` | **"Ignore their demand."** | `[262]` **Narrator**: "I had promised the people of Sor..."<br>`[201]` **Narrator**: "I reflected on our conversation ..." | `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false` | `Variable["BaseGameSupport.Journal_Turn06_ImmigrationDeman...` | `[337]` **Narrator**: "And then there was the conscript..."<br>`[341]` **Narrator**: "I didn't even want to think abou..."<br>*(oraz 1 innych odgałęzień)* |
| `[219]` | **""What are you suggesting here?""** | `[218]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[224]` **Heron Garaci**: ""We are already in an emergency,..."<br>`[284]` **Heron Garaci**: ""You must deal with them..."" |
| `[221]` | **""There is no evidence of this.""** | `[218]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Heron Garaci**: ""What evidence do you need when ..." |
| `[222]` | **""I share the same concerns.""** | `[218]` **Heron Garaci**: ""It is clear that they're trying..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Heron Garaci**: ""Then we are on the same page."" |
| `[234]` | **""You're right. We'll definitely tighten immigration.""** | `[241]` **Heron Garaci**: ""So. In addition to what I said ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Heron Garaci**: ""That's a relief."" |
| `[235]` | **"Stay silent."** | `[241]` **Heron Garaci**: ""So. In addition to what I said ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Heron Garaci**: ""I will not repeat myself. I thi..." |
| `[236]` | **""I can't do that.""** | `[241]` **Heron Garaci**: ""So. In addition to what I said ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Heron Garaci**: ""I will not repeat myself. I thi..." |
| `[274]` | **""Is that a threat?""** | `[273]` **Heron Garaci**: ""Of course, there are some Justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Heron Garaci**: ""You promised to eliminate the n..." |
| `[276]` | **""You promised the Court would side with me.""** | `[273]` **Heron Garaci**: ""Of course, there are some Justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Heron Garaci**: ""You promised to eliminate the n..." |
| `[277]` | **""What is the meaning of this!?""** | `[273]` **Heron Garaci**: ""Of course, there are some Justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Heron Garaci**: ""You promised to eliminate the n..." |
| `[279]` | **""Orso gave me the green light. It was your plan.""** | `[273]` **Heron Garaci**: ""Of course, there are some Justi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Heron Garaci**: ""You promised to eliminate the n..." |
| `[311]` | **""That would be too extreme, Mr. Garaci.""** | `[310]` **Heron Garaci**: ""Something must be done. Nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Heron Garaci**: ""Look. I'm not asking you to do ..." |
| `[312]` | **""I will think about it.""** | `[310]` **Heron Garaci**: ""Something must be done. Nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Heron Garaci**: ""Look. I'm not asking you to do ..." |
| `[314]` | **""That was my plan anyway.""** | `[310]` **Heron Garaci**: ""Something must be done. Nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Heron Garaci**: ""Look. I'm not asking you to do ..." |
| `[339]` | **"Start working on a decree to reinstate conscription."** | `[338]` **Narrator**: "If I reversed my policy, boys li..." | `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false` | `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = fa...`<br>`Variable["BaseGame.Policy_Military_CompulsoryMilitaryServ...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |
| `[340]` | **"Leave the law as it is."** | `[338]` **Narrator**: "If I reversed my policy, boys li..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = true;`<br>`Variable["BaseGame.Policy_Military_CompulsoryMilitaryServ...`<br>*(+3 skryptów)* | *Koniec sceny / Terminal* |

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
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Earlier in the day, I learned that Frens Ricter's complaint had been accepted by the Supreme Court for review."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "I had also been hearing countless reports about our polic..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Send him in.""]** — Mówca: **Player**
> ""Send him in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Livia Suno: ""Right away.""*)

### Węzeł `[5]`
Mówca: **Heron Garaci**
> ""I heard that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "Heron brushed past Livia and strode into the office. Livi..."*)

### Węzeł `[6]`
Mówca: **Livia Suno**
> ""Sorry to interrupt, Mr. President, but Justice Garaci is here to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Send him in.""*)
  - -> `[11]` (*Player: ""I told you that I'm expecting an important call. No visi..."*)
  - -> `[12]` (*Player: ""I'm waiting for Orso Hawker, not Heron.""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I called Chief Justice Hawker's office to demand an explanation, but he wasn't in. I sat by the phone, waiting for him to call back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I waited and waited."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "I had also been hearing countless reports about our police forces becoming reluctant to enforce the rules of the emergency."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I called Chief Justice Hawker's office to demand an expla..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I waited and waited."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "Suddenly, I heard a knock on the door."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "Suddenly, I heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Livia Suno: ""Sorry to interrupt, Mr. President, but Justice Garaci is..."*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""I told you that I'm expecting an important call. No visitors.""]** — Mówca: **Player**
> ""I told you that I'm expecting an important call. No visitors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Livia Suno: ""He told me that he's here to talk to you about the Emerg..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I'm waiting for Orso Hawker, not Heron.""]** — Mówca: **Player**
> ""I'm waiting for Orso Hawker, not Heron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Livia Suno: ""He told me that he's here to talk to you about the Emerg..."*)

### Węzeł `[13]`
Mówca: **Livia Suno**
> ""He told me that he's here to talk to you about the Emergency Act. He said he couldn't speak on the phone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: ""Send him in.""*)
  - -> `[16]` (*Player: ""So Orso has sent his pawn.""*)

### Węzeł `[14]`
Mówca: **Livia Suno**
> ""Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "She opened the door for Heron Garaci and closed the door ..."*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Send him in.""]** — Mówca: **Player**
> ""Send him in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Livia Suno: ""Right away.""*)

### Węzeł `[16]`
**[WYBÓR GRACZA: ""So Orso has sent his pawn.""]** — Mówca: **Player**
> ""So Orso has sent his pawn.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Livia Suno: ""Um...""*)

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""Um...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Heron Garaci: ""I heard that, Mr. President.""*)

### Węzeł `[18]`
Mówca: **Narrator**
> "She opened the door for Heron Garaci and closed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Heron Garaci: ""Hello, Mr. President. Sorry to have come unannounced, bu..."*)

### Węzeł `[19]`
Mówca: **Heron Garaci**
> ""Hello, Mr. President. Sorry to have come unannounced, but I'm sure you expected us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Heron Garaci: ""I'm sorry if I disappointed you, but the Chief Justice i..."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "Heron brushed past Livia and strode into the office. Livia gave me an apologetic half-smile, turned and closed the door behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Heron Garaci: ""It would be wise of you not to be so rude to your partne..."*)

### Węzeł `[21]`
Mówca: **Heron Garaci**
> ""It would be wise of you not to be so rude to your partners in the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Heron Garaci: ""I'm sorry if I disappointed you, but the Chief Justice i..."*)

### Węzeł `[22]`
Mówca: **Heron Garaci**
> ""I'm sorry if I disappointed you, but the Chief Justice is very busy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""Busy? I'm a busy man too, Mr. Garaci.""*)
  - -> `[24]` (*Player: ""You're right. I am disappointed.""*)
  - -> `[25]` (*Player: ""Let's get to the point.""*)
  - -> `[26]` (*Player: ""What is the Court plotting, Mr. Garaci?""*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""Busy? I'm a busy man too, Mr. Garaci.""]** — Mówca: **Player**
> ""Busy? I'm a busy man too, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Heron Garaci: ""Of course you are, Mr. President.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""You're right. I am disappointed.""]** — Mówca: **Player**
> ""You're right. I am disappointed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Heron Garaci: ""Life is full of disappointments, Mr. President.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA: ""Let's get to the point.""]** — Mówca: **Player**
> ""Let's get to the point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Heron Garaci: ""Of course.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""What is the Court plotting, Mr. Garaci?""]** — Mówca: **Player**
> ""What is the Court plotting, Mr. Garaci?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Heron Garaci: ""We are not plotting anything, Mr. President. Please calm..."*)

### Węzeł `[27]`
Mówca: **Heron Garaci**
> ""Of course you are, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Heron Garaci: ""You already know that Frens Ricter has filed a complaint..."*)

### Węzeł `[28]`
Mówca: **Heron Garaci**
> ""Life is full of disappointments, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Heron Garaci: ""You already know that Frens Ricter has filed a complaint..."*)

### Węzeł `[29]`
Mówca: **Heron Garaci**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Heron Garaci: ""You already know that Frens Ricter has filed a complaint..."*)

### Węzeł `[30]`
Mówca: **Heron Garaci**
> ""We are not plotting anything, Mr. President. Please calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Heron Garaci: ""You already know that Frens Ricter has filed a complaint..."*)

### Węzeł `[31]`
Mówca: **Heron Garaci**
> ""You already know that Frens Ricter has filed a complaint about your Emergency Act being unconstitutional. The judges couldn't ignore his arguments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == ..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""Mr. Ricter has made a very compelling case against the E..."*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)

### Węzeł `[35]`
Mówca: **Heron Garaci**
> ""Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Demanded_FullNationalization = true"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == tru..."*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Heron Garaci: ""But as we have promised, the Court is doing its best to ..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true && BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true  and  Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Heron Garaci: ""To be honest, Mr. Ricter has made a very compelling case..."*)

### Węzeł `[39]`
Mówca: **Heron Garaci**
> ""But as we have promised, the Court is doing its best to help you out...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Heron Garaci: ""...Even though the arguments filed by Ricter are notewor..."*)

### Węzeł `[40]`
Mówca: **Heron Garaci**
> ""To be honest, Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Demanded_FullNationalization = true"*)

### Węzeł `[41]`
Mówca: **Heron Garaci**
> ""...Even though the arguments filed by Ricter are noteworthy and do give us the right to deem your actions as unconstitutional.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "He smiled."*)

### Węzeł `[42]`
Mówca: **Heron Garaci**
> ""Although, of course, none of us want the act revoked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Then why did you accept the case?""*)
  - -> `[44]` (*Player: ""What is the meaning of this?""*)
  - -> `[45]` (*Player: ""We don't want that indeed...""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: ""Then why did you accept the case?""]** — Mówca: **Player**
> ""Then why did you accept the case?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Heron Garaci: ""It is the responsibility of the Supreme Court, Mr. Presi..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""What is the meaning of this?""]** — Mówca: **Player**
> ""What is the meaning of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Heron Garaci: ""There's nothing out of the ordinary, Mr. President. I'm ..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: ""We don't want that indeed...""]** — Mówca: **Player**
> ""We don't want that indeed...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Heron Garaci: ""Yes. That's why we need to talk.""*)

### Węzeł `[46]`
Mówca: **Heron Garaci**
> ""It is the responsibility of the Supreme Court, Mr. President. We can't simply ignore matters of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Heron Garaci: ""Our hands are tied. The decrees you've signed are seen a..."*)

### Węzeł `[47]`
Mówca: **Heron Garaci**
> ""There's nothing out of the ordinary, Mr. President. I'm here to ask for your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Heron Garaci: ""Our hands are tied. The decrees you've signed are seen a..."*)

### Węzeł `[48]`
Mówca: **Heron Garaci**
> ""Yes. That's why we need to talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Heron Garaci: ""Our hands are tied. The decrees you've signed are seen a..."*)

### Węzeł `[49]`
Mówca: **Heron Garaci**
> ""Our hands are tied. The decrees you've signed are seen as abuse of power... Although of course, that isn't how Chief Justice Hawker and myself see it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Heron Garaci: ""But as you know, The Constitution states, 'No State shal..."*)

### Węzeł `[50]`
Mówca: **Heron Garaci**
> ""But as you know, The Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' And this does not seem to be the case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""The Court has promised not to act about this clause.""*)
  - -> `[53]` (*Player: ""Don't you dare stab me in the back.""*)
  - -> `[54]` (*Player: ""You and Orso are also implicated in this. Don't forget t..."*)
  - -> `[55]` (*Player: ""Okay, I get it. You have demands.""*)

### Węzeł `[51]`
Mówca: **Heron Garaci**
> ""But as you know... the Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' This is fairly clear...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""And?""*)
  - -> `[65]` (*Player: ""The Court promised not to act on this clause.""*)
  - -> `[66]` (*Player: ""Don't you dare stab me in the back.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""The Court has promised not to act about this clause.""]** — Mówca: **Player**
> ""The Court has promised not to act about this clause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Heron Garaci), `[291]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Heron Garaci: ""That's true.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Heron Garaci), `[291]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Heron Garaci: ""Of course not.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""You and Orso are also implicated in this. Don't forget that.""]** — Mówca: **Player**
> ""You and Orso are also implicated in this. Don't forget that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Heron Garaci), `[291]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Heron Garaci: ""We won't.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Okay, I get it. You have demands.""]** — Mówca: **Player**
> ""Okay, I get it. You have demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Heron Garaci), `[291]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Heron Garaci: ""Well...""*)

### Węzeł `[56]`
Mówca: **Heron Garaci**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He sighed."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""If you promised to help me, why did you accept the case?""*)
  - -> `[59]` (*Player: ""I hope you are really doing your best, Mr. Garaci.""*)
  - -> `[60]` (*Player: ""Is that a threat?""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""If you promised to help me, why did you accept the case?""]** — Mówca: **Player**
> ""If you promised to help me, why did you accept the case?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Heron Garaci: ""It is the responsibility of the Supreme Court, Mr. Presi..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""I hope you are really doing your best, Mr. Garaci.""]** — Mówca: **Player**
> ""I hope you are really doing your best, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Heron Garaci: ""Of course we are, Mr. President. Rest assured, everythin..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Heron Garaci: ""No. No. You are getting this all wrong.""*)

### Węzeł `[61]`
Mówca: **Heron Garaci**
> ""No. No. You are getting this all wrong.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Heron Garaci: ""The Old Guard are happy with the Emergency Act. And Mr. ..."*)

### Węzeł `[62]`
Mówca: **Heron Garaci**
> ""Of course we are, Mr. President. Rest assured, everything's going to work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Heron Garaci: ""The Old Guard are happy with the Emergency Act. And Mr. ..."*)

### Węzeł `[63]`
Mówca: **Heron Garaci**
> ""It is the responsibility of the Supreme Court, Mr. President. We couldn't simply ignore matters of the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Heron Garaci: ""The Old Guard are happy with the Emergency Act. And Mr. ..."*)

### Węzeł `[64]`
Mówca: **Heron Garaci**
> ""The Old Guard are happy with the Emergency Act. And Mr. Hawker is currently working on a legal argument against Mr. Ricter's case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Heron Garaci: ""But as you know... the Constitution states, 'No State sh..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""The Court promised not to act on this clause.""]** — Mówca: **Player**
> ""The Court promised not to act on this clause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Heron Garaci: ""Yes, we did.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Heron Garaci: ""Of course not... As long as you keep your promises.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""And?""]** — Mówca: **Player**
> ""And?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Heron Garaci: ""Well...""*)

### Węzeł `[68]`
Mówca: **Heron Garaci**
> ""Yes, we did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Heron Garaci: ""Personally, I believe Sordland is in more than enough im..."*)

### Węzeł `[69]`
Mówca: **Heron Garaci**
> ""Of course not... As long as you keep your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Heron Garaci: ""Personally, I believe Sordland is in more than enough im..."*)

### Węzeł `[70]`
Mówca: **Heron Garaci**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Heron Garaci: ""Personally, I believe Sordland is in more than enough im..."*)

### Węzeł `[71]`
Mówca: **Heron Garaci**
> ""Personally, I believe Sordland is in more than enough imminent danger to justify the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Heron Garaci: ""But we must work within the boundaries defined by our Co..."*)

### Węzeł `[72]`
Mówca: **Heron Garaci**
> ""But we must work within the boundaries defined by our Constitution. I'm sure you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Heron Garaci: ""I'll be honest with you. There are a few justices who ar..."*)

### Węzeł `[73]`
Mówca: **Heron Garaci**
> ""I'll be honest with you. There are a few justices who are taking Mr. Ricter's side on this. They do believe you are acting unconstitutionally and must be held accountable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Heron Garaci: ""With that said, they might be persuaded to rule in your ..."*)

### Węzeł `[74]`
Mówca: **Heron Garaci**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He sighed."*)

### Węzeł `[75]`
Mówca: **Heron Garaci**
> ""We won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He sighed."*)

### Węzeł `[76]`
Mówca: **Heron Garaci**
> ""That's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "He sighed."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false && Bas..."*)

### Węzeł `[78]`
Mówca: **Heron Garaci**
> ""We are simply a little disappointed about the lack of proper budget for our police and military forces. This Emergency Act has taken a heavy toll on them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Heron Garaci: ""And we have a few other suggestions that may help you ma..."*)

### Węzeł `[79]`
Mówca: **Heron Garaci**
> ""And we have a few other suggestions that may help you manage this difficult period in the best way possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Heron Garaci: ""We wish to see you address these concerns before the jud..."*)

### Węzeł `[80]`
Mówca: **Heron Garaci**
> ""We wish to see you address these concerns before the judicial review is concluded.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""Tell me about them.""*)
  - -> `[82]` (*Player: ""And what if I don't?""*)
  - -> `[83]` (*Player: ""This is treachery!""*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""Tell me about them.""]** — Mówca: **Player**
> ""Tell me about them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Heron Garaci: ""Of course.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""And what if I don't?""]** — Mówca: **Player**
> ""And what if I don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Heron Garaci: ""Then I cannot promise the Court will find your actions c..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""This is treachery!""]** — Mówca: **Player**
> ""This is treachery!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Heron Garaci: ""It is not. It would only be treacherous if we overlook p..."*)

### Węzeł `[84]`
Mówca: **Heron Garaci**
> ""It is not. It would only be treacherous if we overlook problems that may end up damaging Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Heron Garaci: ""Mr. Hawker and I only want to make sure that you are on ..."*)

### Węzeł `[85]`
Mówca: **Heron Garaci**
> ""Then I cannot promise the Court will find your actions constitutionally justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Heron Garaci: ""Mr. Hawker and I only want to make sure that you are on ..."*)

### Węzeł `[86]`
Mówca: **Heron Garaci**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Heron Garaci: ""Mr. Hawker and I only want to make sure that you are on ..."*)

### Węzeł `[87]`
Mówca: **Heron Garaci**
> ""Mr. Hawker and I only want to make sure that you are on our side, Mr. President. Addressing these concerns of ours would be a great place to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[88]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player: ""You're right. We'll definitely tighten immigration.""*)
  - -> `[91]` (*Player_Italic: "Stay silent."*)
  - -> `[90]` (*Player: ""I can't do that.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Heron Garaci: ""That's good to hear.""*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Heron Garaci: ""That's precisely why we are concerned about your managem..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[92]`
Mówca: **Heron Garaci**
> ""That's precisely why we are concerned about your management of this sensitive period. Keeping the current policy would be a grave mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""That's good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[94]`
Mówca: **Heron Garaci**
> ""We hope to see you revert your earlier decision to relax immigration laws with a decree as soon as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Heron Garaci: ""Our biggest concern, however, regards the Oligarchs. Wal..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""Mr. Ricter has made a very compelling case against the E..."*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true ||BaseGame.Turn03_EnT_Military_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == tru..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = ..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Heron Garaci: ""For example, something has to be done about the Oligarch..."*)

### Węzeł `[101]`
Mówca: **Heron Garaci**
> ""Our biggest concern, however, regards the Oligarchs. Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Heron Garaci: ""They are in close cooperation with Arcasia and have ties..."*)

### Węzeł `[102]`
Mówca: **Heron Garaci**
> ""They are in close cooperation with Arcasia and have ties to almost every other country on this continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Heron Garaci: ""It is clear that they're trying to profit from the viole..."*)

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reason to believe they are supporting the militant organizations we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""What are you suggesting here?""*)
  - -> `[105]` (*Player: ""There is no evidence of this.""*)
  - -> `[106]` (*Player: ""I share the same concerns.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Heron Garaci: ""We are already in an emergency, Mr. President.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Heron Garaci: ""What evidence do you need when they are the only people ..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Heron Garaci: ""Then we are on the same page.""*)

### Węzeł `[107]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[108]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[109]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""I can't disagree with that.""]** — Mówca: **Player**
> ""I can't disagree with that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Heron Garaci: ""We hope you follow through with this plan at the next ec..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""That is too extreme, Mr. Garaci.""]** — Mówca: **Player**
> ""That is too extreme, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Heron Garaci: ""And your Emergency Act was not?""*)

### Węzeł `[112]`
**[WYBÓR GRACZA: ""We are already working on market economy reforms. Your little proposal doesn't align with my plans.""]** — Mówca: **Player**
> ""We are already working on market economy reforms. Your little proposal doesn't align with my plans.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[294]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Heron Garaci: ""Really?""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: ""We are already working on market economy reforms. Your l..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
Mówca: **Heron Garaci**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Heron Garaci: ""Mr. President... You don't seem to understand the whole ..."*)

### Węzeł `[117]`
Mówca: **Heron Garaci**
> ""We hope you follow through with this plan at the next economy meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Heron Garaci: ""In the meantime, the Court will be doing its best. As lo..."*)

### Węzeł `[118]`
Mówca: **Heron Garaci**
> ""And your Emergency Act was not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Heron Garaci: ""Mr. President... You don't seem to understand the whole ..."*)

### Węzeł `[119]`
Mówca: **Heron Garaci**
> ""Mr. President... You don't seem to understand the whole picture here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Heron Garaci: ""This is not only a matter of revoking the validity of yo..."*)

### Węzeł `[120]`
Mówca: **Heron Garaci**
> ""This is not only a matter of revoking the validity of your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Heron Garaci: ""As much as we're doing our best to help you out, the Cou..."*)

### Węzeł `[121]`
Mówca: **Heron Garaci**
> ""As much as we're doing our best to help you out, the Court could still decide to try you for deliberately going against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)

### Węzeł `[122]`
Mówca: **Heron Garaci**
> ""In the meantime, the Court will be doing its best. As long as you listen to our concerns, Chief Justice Hawker will be motivated to help you further...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Heron Garaci: ""I hope you understand.""*)

### Węzeł `[123]`
Mówca: **Heron Garaci**
> ""I hope you understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)

### Węzeł `[124]`
Mówca: **Heron Garaci**
> ""With that said, they might be persuaded to rule in your favor if certain other judicial concerns were addressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""What concerns?""*)
  - -> `[126]` (*Player: ""I'm on to your shenanigans, Mr. Garaci.""*)
  - -> `[127]` (*Player: ""I thought the Old Guard controlled the Court.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""I'm on to your shenanigans, Mr. Garaci.""]** — Mówca: **Player**
> ""I'm on to your shenanigans, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Heron Garaci: ""There are no shenanigans, Mr. President. Relax a little...."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""I thought the Old Guard controlled the Court.""]** — Mówca: **Player**
> ""I thought the Old Guard controlled the Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Heron Garaci: ""We do. And there are no problems from our side.""*)

### Węzeł `[128]`
Mówca: **Heron Garaci**
> ""We do. And there are no problems from our side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Heron Garaci: ""We are personally happy with the work you've been doing ..."*)

### Węzeł `[129]`
Mówca: **Heron Garaci**
> ""There are no shenanigans, Mr. President. Relax a little. I'm here to help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Heron Garaci: ""We are personally happy with the work you've been doing ..."*)

### Węzeł `[130]`
Mówca: **Heron Garaci**
> ""We are personally happy with the work you've been doing to keep Sordland safe. Especially your generous support of the police and military.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Heron Garaci: ""But of course, some of us are harder to please than othe..."*)

### Węzeł `[131]`
Mówca: **Heron Garaci**
> ""But of course, some of us are harder to please than others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: ""Okay, I get it. What do you want?""*)
  - -> `[133]` (*Player: ""No. As we already agreed, you will fix this as soon as p..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Okay, I get it. What do you want?""]** — Mówca: **Player**
> ""Okay, I get it. What do you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""No. As we already agreed, you will fix this as soon as possible. I won't cave to your demands.""]** — Mówca: **Player**
> ""No. As we already agreed, you will fix this as soon as possible. I won't cave to your demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Heron Garaci: ""Whatever you say, Mr. President. But I can't promise I'l..."*)

### Węzeł `[134]`
Mówca: **Heron Garaci**
> ""Whatever you say, Mr. President. But I can't promise I'll be able to convince those finicky holdouts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Heron Garaci: ""Anyway, I am not here to argue with you.""*)

### Węzeł `[135]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: ""You're right. We'll definitely tighten immigration.""*)
  - -> `[139]` (*Player_Italic: "Stay silent."*)
  - -> `[145]` (*Player: ""I can't do that.""*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Heron Garaci: ""That's relieving.""*)

### Węzeł `[137]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[138]`
Mówca: **Heron Garaci**
> ""Our biggest concern, however, regards the Oligarchs. Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Heron Garaci: ""They are in close cooperation with Arcasia and have ties..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[140]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reason to believe they are supporting the militant organizations we are fighting against.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: ""What are you suggesting here?""*)
  - -> `[149]` (*Player: ""There is no evidence of this.""*)
  - -> `[150]` (*Player: ""I share the same concerns.""*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = ..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Heron Garaci: ""Mr. President, we are worried about the Oligarchs. Marce..."*)

### Węzeł `[144]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Heron Garaci: ""That's precisely why we are concerned about your managem..."*)

### Węzeł `[146]`
Mówca: **Heron Garaci**
> ""That's precisely why we are concerned about your management of this sensitive period. Keeping the current policy would be a grave mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[147]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[148]`
Mówca: **Heron Garaci**
> ""That's relieving.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Heron Garaci: ""We hope to see you revert your earlier decision to relax..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Heron Garaci: ""What evidence do you need when they are the only people ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Heron Garaci: ""Then we are on the same page.""*)

### Węzeł `[151]`
Mówca: **Heron Garaci**
> ""We hope to see you revert your earlier decision to relax immigration laws with a decree as soon as possible. We are in an emergency, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Heron Garaci: ""Our biggest concern, however, regards the Oligarchs. Mar..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Heron Garaci: ""We are already in an emergency, Mr. President.""*)

### Węzeł `[153]`
Mówca: **Heron Garaci**
> ""They are in close cooperation with Arcasia and have ties to almost every other country on this continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Heron Garaci: ""It is clear that they're trying to profit from the viole..."*)

### Węzeł `[154]`
Mówca: **Heron Garaci**
> ""For example, something has to be done about the Oligarchs. Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Heron Garaci: ""They are in close cooperation with Arcasia and have ties..."*)

### Węzeł `[155]`
Mówca: **Heron Garaci**
> ""Mr. President, we are worried about the Oligarchs. Marcel Koronti and Walter Tusk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Heron Garaci: ""They are in close cooperation with Arcasia and have ties..."*)

### Węzeł `[156]`
Mówca: **Heron Garaci**
> ""In these difficult times when unity is so sorely needed, they pose a great threat to all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Heron Garaci: ""They already control much of our economy. They can't be ..."*)

### Węzeł `[157]`
Mówca: **Heron Garaci**
> ""Anyway, I am not here to argue with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Heron Garaci: ""I hope our alliance stands strong. As I said earlier, th..."*)

### Węzeł `[158]`
Mówca: **Heron Garaci**
> ""I hope our alliance stands strong. As I said earlier, there is nothing to worry about. The Court will reject Mr. Ricter's case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Heron Garaci: ""Barring any... extraordinary circumstances.""*)

### Węzeł `[159]`
Mówca: **Heron Garaci**
> ""Barring any... extraordinary circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""Well... For now, I must leave. I hope you'll think long ..."*)

### Węzeł `[160]`
Mówca: **Heron Garaci**
> ""Of course, there are some justices who believe you are to blame. Going against the Constitution is a serious offense, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""What is the meaning of this!?""*)
  - -> `[162]` (*Player: ""You promised the Court would side with me.""*)
  - -> `[161]` (*Player: ""Is that a threat?""*)

### Węzeł `[161]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)

### Węzeł `[162]`
**[WYBÓR GRACZA: ""You promised the Court would side with me.""]** — Mówca: **Player**
> ""You promised the Court would side with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""What is the meaning of this!?""]** — Mówca: **Player**
> ""What is the meaning of this!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)

### Węzeł `[164]`
Mówca: **Heron Garaci**
> ""You promised to manage this emergency period as best as you can. Yet our police and military forces took a heavy toll with their lack of proper budget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Heron Garaci: ""This is having very negative effects on Sordland, Mr. Pr..."*)

### Węzeł `[165]`
Mówca: **Heron Garaci**
> ""This is having very negative effects on Sordland, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Heron Garaci: ""We are doing our best to keep the Court in check, but it..."*)

### Węzeł `[166]`
Mówca: **Heron Garaci**
> ""We are doing our best to keep the Court in check, but it seems your decree has made you quite unpopular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Heron Garaci: ""Of course, nobody would go as far as to impeach you for ..."*)

### Węzeł `[167]`
Mówca: **Heron Garaci**
> ""Of course, nobody would go as far as to impeach you for crimes against the Constitution. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: ""Impeach me?""*)
  - -> `[169]` (*Player: ""What are you suggesting?""*)
  - -> `[170]` (*Player: ""Don't you dare stab me in the back.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA: ""Impeach me?""]** — Mówca: **Player**
> ""Impeach me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Heron Garaci: ""As you know, the Constitution states, 'No State shall mo..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""What are you suggesting?""]** — Mówca: **Player**
> ""What are you suggesting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Heron Garaci: ""As you know, the Constitution states, 'No State shall mo..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""Don't you dare stab me in the back.""]** — Mówca: **Player**
> ""Don't you dare stab me in the back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Heron Garaci: ""As you know, the Constitution states, 'No State shall mo..."*)

### Węzeł `[171]`
Mówca: **Heron Garaci**
> ""As you know, the Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay.' That does not seem to apply to our current situation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Heron Garaci: ""I don't know what to say. After all, it is up to the maj..."*)

### Węzeł `[172]`
Mówca: **Heron Garaci**
> ""I don't know what to say. After all, it is up to the majority in the Court if they decide to take action against your decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Italic: "Stay silent."*)
  - -> `[173]` (*Player: ""Screw you, Mr. Garaci.""*)
  - -> `[174]` (*Player: ""You have balls coming to me like that.""*)
  - -> `[175]` (*Player: ""Listen to me. The Court will reject Ricter's case and I ..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Screw you, Mr. Garaci.""]** — Mówca: **Player**
> ""Screw you, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Heron Garaci: ""Where are your manners, Mr. President?""*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""You have balls coming to me like that.""]** — Mówca: **Player**
> ""You have balls coming to me like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Heron Garaci: ""Where are your manners, Mr. President?""*)

### Węzeł `[175]`
**[WYBÓR GRACZA: ""Listen to me. The Court will reject Ricter's case and I will forget about this conversation. Okay?""]** — Mówca: **Player**
> ""Listen to me. The Court will reject Ricter's case and I will forget about this conversation. Okay?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Heron Garaci: ""That depends, Mr. President.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Heron Garaci: ""Listen...""*)

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""That depends, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Heron Garaci: ""Now you listen to me...""*)

### Węzeł `[178]`
Mówca: **Heron Garaci**
> ""Where are your manners, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Heron Garaci: ""Listen...""*)

### Węzeł `[179]`
Mówca: **Heron Garaci**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Heron Garaci: ""We are concerned about Walter Tusk and Marcel Koronti.""*)

### Węzeł `[180]`
Mówca: **Heron Garaci**
> ""You will implement a nationalization plan and seize the assets of the Oligarchs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Heron Garaci: ""Then we will see what happens.""*)

### Węzeł `[181]`
Mówca: **Heron Garaci**
> ""Then we will see what happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""You will regret this. Get out of my sight!""*)
  - -> `[183]` (*Player: ""What if I don't?""*)
  - -> `[184]` (*Player: ""Don't worry. We are on the same side. I will do as you s..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[182]`
**[WYBÓR GRACZA: ""You will regret this. Get out of my sight!""]** — Mówca: **Player**
> ""You will regret this. Get out of my sight!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Heron Garaci: ""Whatever you say.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA: ""What if I don't?""]** — Mówca: **Player**
> ""What if I don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Heron Garaci: ""Then it might just be too hard for us to ignore your cri..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: ""Don't worry. We are on the same side. I will do as you say.""]** — Mówca: **Player**
> ""Don't worry. We are on the same side. I will do as you say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Heron Garaci: ""Good. The Old Guard will be waiting.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""We are already working on market economy reforms. What you're saying doesn't align with my plans.""]** — Mówca: **Player**
> ""We are already working on market economy reforms. What you're saying doesn't align with my plans.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Kontekst wejściowy (poprzednik):** `[181]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Heron Garaci: ""Does being impeached align with your plans? Does spendin..."*)

### Węzeł `[186]`
Mówca: **Heron Garaci**
> ""Does being impeached align with your plans? Does spending the rest of your term in prison?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Heron Garaci: ""We hope you follow through on this in the next economy m..."*)

### Węzeł `[187]`
Mówca: **Heron Garaci**
> ""Then it might just be too hard for us to ignore your crimes against the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Heron Garaci: ""We hope you follow through on this in the next economy m..."*)

### Węzeł `[188]`
Mówca: **Heron Garaci**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Heron Garaci: ""I have to say... You are not so different from President..."*)

### Węzeł `[189]`
Mówca: **Heron Garaci**
> ""Good. The Old Guard will be waiting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Heron Garaci: ""We hope you follow through on this in the next economy m..."*)

### Węzeł `[190]`
Mówca: **Heron Garaci**
> ""I have to say... You are not so different from President Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "He stood up and went to the door."*)

### Węzeł `[191]`
Mówca: **Narrator**
> "He stood up and went to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Heron Garaci: ""Goodbye and good luck, Mr. President.""*)

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""Goodbye and good luck, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Narrator: "He went out and closed the door behind him."*)

### Węzeł `[193]`
Mówca: **Heron Garaci**
> ""Well... For now, I must leave. I hope you'll think long and hard about what we just talked about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "He extended his hand towards mine."*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "Don't shake his hand."]** — Mówca: **Player_Italic**
> "I did not shake his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "He raised an eyebrow and then smiled."*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "I shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Heron Garaci: ""Goodbye, Mr. President. Thank you for your time.""*)

### Węzeł `[196]`
Mówca: **Narrator**
> "He raised an eyebrow and then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Heron Garaci: ""Goodbye, Mr. President. Thank you for your time.""*)

### Węzeł `[197]`
Mówca: **Heron Garaci**
> ""Goodbye, Mr. President. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "He went out and closed the door behind him."*)

### Węzeł `[198]`
Mówca: **Narrator**
> "He extended his hand towards mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Italic: "Shake his hand."*)
  - -> `[194]` (*Player_Italic: "Don't shake his hand."*)

### Węzeł `[199]`
Mówca: **Narrator**
> "He went out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "I leaned back in my chair."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "He went out and closed the door behind him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "I reflected on our conversation for a moment. Would it be worth re-tightening the laws on immigration to keep the Old Guard happy?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "Start working on a decree to tighten immigration."]** — Mówca: **Player_Italic**
> "I decided to comply with Heron's suggestion and started to work on a decree to implement tighter immigration laws."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration = true; Ba..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "I reflected on our conversation for a moment. Would it be..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription == true"*)

### Węzeł `[206]`
**[WYBÓR GRACZA: "Ignore their demand."]** — Mówca: **Player_Italic**
> "I decided to ignore their demands on immigration."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[262]` (Narrator), `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore =..."*)

### Węzeł `[207]`
Mówca: **Narrator**
> "I leaned back in my chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Was my decision to work with the Old Guard right?"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration = true;
BaseGame.Policy_Diplomacy_RelaxedImmigration = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;
Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_FPnT_Immigration_Tight = true;"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Market == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Market == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Market"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""We are already working on market economy reforms. What y..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Market == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Market"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Heron Garaci: ""We also know that you've been *working* with them.""*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Heron Garaci: ""In these difficult times when unity is so sorely needed,..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_A_AutocratDemands = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_A_AutocratDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[216]`
Mówca: **Heron Garaci**
> ""We are concerned about Walter Tusk and Marcel Koronti.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Heron Garaci: ""The Oligarchs are in close cooperation with Arcasia and ..."*)

### Węzeł `[217]`
Mówca: **Heron Garaci**
> ""The Oligarchs are in close cooperation with Arcasia and have ties to almost every other country on the continent. And as we all know, they only care about money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Heron Garaci: ""It is clear that they're trying to profit from the viole..."*)

### Węzeł `[218]`
Mówca: **Heron Garaci**
> ""It is clear that they're trying to profit from the violence in Sordland and abroad. We have reasons to believe they are supporting the militant organizations inside our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""What are you suggesting here?""*)
  - -> `[221]` (*Player: ""There is no evidence of this.""*)
  - -> `[222]` (*Player: ""I share the same concerns.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""What are you suggesting here?""]** — Mówca: **Player**
> ""What are you suggesting here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[220]`
Mówca: **Heron Garaci**
> ""What evidence do you need when they are the only people who are not affected by these crises? They influence politics in Sordland for their own gains as well as those of foreign interests.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""There is no evidence of this.""]** — Mówca: **Player**
> ""There is no evidence of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Heron Garaci: ""What evidence do you need when they are the only people ..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""I share the same concerns.""]** — Mówca: **Player**
> ""I share the same concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Heron Garaci: ""Then we are on the same page.""*)

### Węzeł `[223]`
Mówca: **Heron Garaci**
> ""They pose a great threat to all of Sordland. The State must seize both of their corporations and bring an end to their supremacy very soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligar..."*)

### Węzeł `[224]`
Mówca: **Heron Garaci**
> ""We are already in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[225]`
Mówca: **Heron Garaci**
> ""Then we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[226]`
Mówca: **Heron Garaci**
> ""So here is the deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Heron Garaci: ""You will implement a nationalization plan and seize the ..."*)

### Węzeł `[227]`
Mówca: **Heron Garaci**
> ""Now you listen to me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Heron Garaci: ""We are concerned about Walter Tusk and Marcel Koronti.""*)

### Węzeł `[228]`
Mówca: **Heron Garaci**
> ""We hope you follow through on this in the next economy meeting. For your own good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)

### Węzeł `[229]`
Mówca: **Heron Garaci**
> ""I have one final request.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Heron Garaci: ""We are concerned about Sordland's current immigration la..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_RelaxedImmigration == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Heron Garaci: ""I have one final request.""*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_RelaxedImmigration == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_RelaxedImmigration"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""Well... For now, I must leave. I hope you'll think long ..."*)

### Węzeł `[233]`
Mówca: **Heron Garaci**
> ""We are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Heron Garaci: ""There have been countless cases of foreigners joining th..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: ""You're right. We'll definitely tighten immigration.""]** — Mówca: **Player**
> ""You're right. We'll definitely tighten immigration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Heron Garaci: ""That's a relief.""*)

### Węzeł `[235]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Heron Garaci: ""I will not repeat myself. I think you get the point. We ..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[241]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Heron Garaci: ""I will not repeat myself. I think you get the point. We ..."*)

### Węzeł `[237]`
Mówca: **Heron Garaci**
> ""I will not repeat myself. I think you get the point. We will not let Sordland deteriorate under bad leadership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_Immigration = true"*)

### Węzeł `[238]`
Mówca: **Heron Garaci**
> ""That's a relief.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_Immigration = true"*)

### Węzeł `[239]`
Mówca: **Heron Garaci**
> ""There have been countless cases of foreigners joining the fight against our state. We require better border security and a tighter immigration policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[240]`
Mówca: **Heron Garaci**
> ""We are in an emergency, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Heron Garaci: ""So. In addition to what I said before, you will make a d..."*)

### Węzeł `[241]`
Mówca: **Heron Garaci**
> ""So. In addition to what I said before, you will make a decree reverting your earlier decision to relax immigration laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player: ""You're right. We'll definitely tighten immigration.""*)
  - -> `[235]` (*Player_Italic: "Stay silent."*)
  - -> `[236]` (*Player: ""I can't do that.""*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Even if I was wrong, would I be able to get out of this if I wanted?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_Reform = true"*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Was my decision to work with the Old Guard right?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Even if I was wrong, would I be able to get out of this i..."*)

### Węzeł `[244]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Heron Garaci: ""Remember, Mr. President.""*)

### Węzeł `[245]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Heron Garaci: ""Those who sleep with dogs will rise with fleas.""*)

### Węzeł `[246]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Heron Garaci: ""In these difficult times when unity is so sorely needed,..."*)

### Węzeł `[247]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Heron Garaci: ""Remember, Mr. President.""*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Heron Garaci: ""We also know that you've been *working* with them.""*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Heron Garaci: ""In these difficult times when unity is so sorely needed,..."*)

### Węzeł `[251]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Heron Garaci: ""Those who sleep with dogs will rise with fleas.""*)

### Węzeł `[252]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Heron Garaci: ""In these difficult times when unity is so sorely needed,..."*)

### Węzeł `[253]`
Mówca: **Heron Garaci**
> ""We also know that you've been *working* with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Heron Garaci: ""Remember, Mr. President.""*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_Oligarchs_Content == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_Oligarchs_Content == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Heron Garaci: ""We also know that you've been *working* with them.""*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_Oligarchs_Content == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Heron Garaci: ""They pose a great threat to all of Sordland. The State m..."*)

### Węzeł `[257]`
Mówca: **Heron Garaci**
> ""Remember, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Heron Garaci: ""Those who sleep with dogs will rise with fleas.""*)

### Węzeł `[258]`
Mówca: **Heron Garaci**
> ""Those who sleep with dogs will rise with fleas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Heron Garaci: ""They pose a great threat to all of Sordland. The State m..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_Immigration_Relaxed == true"*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_Immigration_Relaxed == true)"*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_Immigration_Relaxed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_Immigration_Relaxed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Narrator: "I had promised the people of Sordland that I would open o..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_Immigration_Relaxed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_Immigration_Relaxed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Italic: "Start working on a decree to tighten immigration."*)
  - -> `[206]` (*Player_Italic: "Ignore their demand."*)

### Węzeł `[262]`
Mówca: **Narrator**
> "I had promised the people of Sordland that I would open our borders, and I had followed through. Turning back now would mean betraying all that work. On the other hand, so would losing the court case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player_Italic: "Start working on a decree to tighten immigration."*)
  - -> `[206]` (*Player_Italic: "Ignore their demand."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency = true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn06_ST_VictoryDay = true"*)

### Węzeł `[266]`
Mówca: **Narrator**
> "Earlier in the day, I learned that Frens Ricter's complaint had been accepted by the Supreme Court for review."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "I had stopped the state of emergency, but the reformists ..."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "I had stopped the state of emergency, but the reformists and the Old Guard were still coming after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Narrator: "I called Chief Justice Hawker's office to demand an expla..."*)

### Węzeł `[268]`
Mówca: **Narrator**
> "I called Chief Justice Hawker's office to demand an explanation, but he wasn't in. I sat by the phone, waiting for him to call back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I waited and waited."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Heron Garaci: ""To be honest, Mr. Ricter has made a very compelling case..."*)

### Węzeł `[272]`
Mówca: **Heron Garaci**
> ""To be honest, Mr. Ricter has made a very compelling case against the Emergency Act. It's going to be very hard for us to refute it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Demanded_FullNationalization = true"*)

### Węzeł `[273]`
Mówca: **Heron Garaci**
> ""Of course, there are some Justices who believe you were to blame from the beginning. Going against the Constitution was an impeachable offence, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player: ""What is the meaning of this!?""*)
  - -> `[276]` (*Player: ""You promised the Court would side with me.""*)
  - -> `[279]` (*Player: ""Orso gave me the green light. It was your plan.""*)
  - -> `[274]` (*Player: ""Is that a threat?""*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Is that a threat?""]** — Mówca: **Player**
> ""Is that a threat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Heron Garaci: ""You promised to eliminate the national security threats...."*)

### Węzeł `[275]`
Mówca: **Heron Garaci**
> ""This is having very negative effects on Sordland, Mr. President. You were supposed to use the state of emergency to its full advantage, not trigger more dissent by attacking militants and retreating before defeating them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Heron Garaci: ""As you know... The Constitution states, 'No State shall ..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: ""You promised the Court would side with me.""]** — Mówca: **Player**
> ""You promised the Court would side with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Heron Garaci: ""You promised to eliminate the national security threats...."*)

### Węzeł `[277]`
**[WYBÓR GRACZA: ""What is the meaning of this!?""]** — Mówca: **Player**
> ""What is the meaning of this!?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Heron Garaci: ""You promised to eliminate the national security threats...."*)

### Węzeł `[278]`
Mówca: **Heron Garaci**
> ""You promised to eliminate the national security threats. Yet you stopped the emergency before our security forces could successfully do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Heron Garaci: ""This is having very negative effects on Sordland, Mr. Pr..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""Orso gave me the green light. It was your plan.""]** — Mówca: **Player**
> ""Orso gave me the green light. It was your plan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Heron Garaci: ""You promised to eliminate the national security threats...."*)

### Węzeł `[280]`
Mówca: **Heron Garaci**
> ""As you know... The Constitution states, 'No State shall modify or suspend the rights of freedom defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not allow for delay'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Heron Garaci: ""Personally, I of course believe the emergency was fully ..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Heron Garaci: ""We are already in an emergency, Mr. President.""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Heron Garaci: ""You must deal with them...""*)

### Węzeł `[284]`
Mówca: **Heron Garaci**
> ""You must deal with them...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_Oligarchs_Content == true"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Heron Garaci: ""We are in an emergency, Mr. President.""*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Heron Garaci: ""So. In addition to what I said before, you will make a d..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_StreamlinedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_StreamlinedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten ..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_IllegalImmigration = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_IllegalImmigration"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_StreamlinedImmigration = true"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_FPnT_Immigration_Tight = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_FPnT_Immigration_Tight"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_IllegalImmigration = false"*)

### Węzeł `[291]`
Mówca: **Heron Garaci**
> ""But it isn't up to me. Unless... a majority of the court could somehow be convinced to take your side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: ""The Court has promised not to act about this clause.""*)
  - -> `[53]` (*Player: ""Don't you dare stab me in the back.""*)
  - -> `[54]` (*Player: ""You and Orso are also implicated in this. Don't forget t..."*)
  - -> `[55]` (*Player: ""Okay, I get it. You have demands.""*)

### Węzeł `[292]`
Mówca: **Heron Garaci**
> ""In these difficult times when unity is so sorely needed, they pose a great threat to all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Heron Garaci: ""We propose a nationalization plan to eliminate the power..."*)

### Węzeł `[293]`
Mówca: **Heron Garaci**
> ""We propose a nationalization plan to eliminate the power of the Oligarchs. The State must have control over their assets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Heron Garaci: ""Namely Walter Tusk's Bergia Steel and Marcel Koronti's H..."*)

### Węzeł `[294]`
Mówca: **Heron Garaci**
> ""We can't let a handful of people control the treasury, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I can't disagree with that.""*)
  - -> `[111]` (*Player: ""That is too extreme, Mr. Garaci.""*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Market == true"*)

### Węzeł `[295]`
Mówca: **Heron Garaci**
> ""Namely Walter Tusk's Bergia Steel and Marcel Koronti's Heart of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Heron Garaci: ""We can't let a handful of people control the treasury, c..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Demanded_FullNationalization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationa..."*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Demanded_FullNationalization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationa..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Heron Garaci: ""Although, of course, none of us want the act revoked.""*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Heron Garaci: ""Of course, there are some Justices who believe you were ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ImmigrationDemand_Tighten"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription == true"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_ImmigrationDemand_Ignore"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription == true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && Ba..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Heron Garaci: ""You played your cards wrong, Mr. President. Look at you...."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.Promise_Diplomacy_East == true && BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true  and  Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)

### Węzeł `[305]`
Mówca: **Heron Garaci**
> ""You played your cards wrong, Mr. President. Look at you. You have done virtually *everything* that is possible to oppose us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Heron Garaci: ""First you ban the Young Sords, then you make a deal with..."*)

### Węzeł `[306]`
Mówca: **Heron Garaci**
> ""First you ban the Young Sords, then you make a deal with the communists!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Heron Garaci: ""We knew you were leaning eastwards, but accepting financ..."*)

### Węzeł `[307]`
Mówca: **Heron Garaci**
> ""We knew you were leaning eastwards, but accepting financial aid from our enemies? Preposterous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Heron Garaci: ""Let me just say this.""*)

### Węzeł `[308]`
Mówca: **Heron Garaci**
> ""Let me just say this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Heron Garaci: ""Mr. Ricter has made a very compelling case against the E..."*)

### Węzeł `[309]`
Mówca: **Heron Garaci**
> ""They already control much of our economy. They can't be allowed to have that much power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Heron Garaci: ""Something must be done. Nationalizing their assets, for ..."*)

### Węzeł `[310]`
Mówca: **Heron Garaci**
> ""Something must be done. Nationalizing their assets, for example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Player: ""That would be too extreme, Mr. Garaci.""*)
  - -> `[312]` (*Player: ""I will think about it.""*)
  - -> `[314]` (*Player: ""That was my plan anyway.""*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""That would be too extreme, Mr. Garaci.""]** — Mówca: **Player**
> ""That would be too extreme, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Heron Garaci: ""Look. I'm not asking you to do anything. It's just a fri..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I will think about it.""]** — Mówca: **Player**
> ""I will think about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Heron Garaci: ""Look. I'm not asking you to do anything. It's just a fri..."*)

### Węzeł `[313]`
Mówca: **Heron Garaci**
> ""Look. I'm not asking you to do anything. It's just a friendly suggestion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Heron Garaci: ""I hope our alliance stands strong. As I said earlier, th..."*)

### Węzeł `[314]`
**[WYBÓR GRACZA: ""That was my plan anyway.""]** — Mówca: **Player**
> ""That was my plan anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Heron Garaci: ""Look. I'm not asking you to do anything. It's just a fri..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Heron Garaci: ""Firstly, we are concerned about Sordland's current immig..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Demanded_TightenedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Heron Garaci: ""We are concerned about Sordland's current immigration la..."*)

### Węzeł `[317]`
Mówca: **Heron Garaci**
> ""We are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Heron Garaci: ""There have been countless cases of foreigners joining th..."*)

### Węzeł `[318]`
Mówca: **Heron Garaci**
> ""Firstly, we are concerned about Sordland's current immigration laws. We fear too many troublemakers are crossing the border to lend support to militant organizations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Heron Garaci: ""There have been countless cases of foreigners joining th..."*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_SnO_Conscription_Removed == true)"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Heron Garaci: ""But that's not all we want.""*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_SnO_Conscription_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[322]`
Mówca: **Heron Garaci**
> ""You must reverse your ridiculous decision to end mandatory conscription. A large, strong military is the only way to ensure stability in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription = true"*)

### Węzeł `[323]`
Mówca: **Heron Garaci**
> ""But that's not all we want.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Heron Garaci: ""You must reverse your ridiculous decision to end mandato..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Heron Garaci: ""So here is the deal.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.turn06_AutocratDemands_Conscription = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_RelaxedImmigration == true"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_AutocratDemands_Immigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_Immigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""Well... For now, I must leave. I hope you'll think long ..."*)

### Węzeł `[327]`
Mówca: **Heron Garaci**
> ""Personally, I of course believe the emergency was fully justified. It would be a shame if the rest of the Court failed to agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Heron Garaci: ""But it isn't up to me. Unless... a majority of the court..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Demanded_FullNationalization = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Demanded_FullNationalization"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationa..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_AutocratDemand_FullNationalise"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Heron Garaci: ""Of course, there are some justices who believe you are t..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService = true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_LargeReservistPool = true; Ba..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_LargeReservistPool = true;
BaseGame.Situation_Military_LackOfReservists = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_LargeReservistPool"] = true;
Variable["BaseGame.Situation_Military_LackOfReservists"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Conscription_Removed = fal..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Conscription_Removed = false; BaseGameSupport.Journal_Turn06_Conscription_Mandatory = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Conscription_Removed"] = false;
Variable["BaseGameSupport.Journal_Turn06_Conscription_Mandatory"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SordishA..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.turn06_AutocratDemands_Conscription == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription == true"*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.turn06_AutocratDemands_Conscription ==..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.turn06_AutocratDemands_Conscription == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "And then there was the conscription issue..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.turn06_AutocratDemands_Conscription == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligar..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "And then there was the conscription issue..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "If I reversed my policy, boys like my own son would be fo..."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "If I reversed my policy, boys like my own son would be forced to join the army. Would I be able to live with that?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == false"*)
  - -> `[340]` (*Player_Italic: "Leave the law as it is."*)

### Węzeł `[339]`
**[WYBÓR GRACZA: "Start working on a decree to reinstate conscription."]** — Mówca: **Player_Italic**
> "I decided to comply with Heron's suggestion and bring conscription back."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false`
- **Kontekst wejściowy (poprzednik):** `[338]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed = false"*)

### Węzeł `[340]`
**[WYBÓR GRACZA: "Leave the law as it is."]** — Mówca: **Player_Italic**
> "I decided to ignore Heron's demands on conscription."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[338]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed = true"*)

### Węzeł `[341]`
Mówca: **Narrator**
> "I didn't even want to think about Heron's demands for the Oligarchs. Nationalizing Sordland's two largest private corporations would have huge repercussions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "I leaned back in my chair."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService = false;"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Military_LackOfReservists = true; Base..."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Military_LackOfReservists = true; BaseGame.Situation_Military_LargeReservistPool = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Military_LackOfReservists"] = true;
Variable["BaseGame.Situation_Military_LargeReservistPool"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn06_Conscription_Removed = tru..."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn06_Conscription_Removed = true; BaseGameSupport.Journal_Turn06_Conscription_Mandatory = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn06_Conscription_Removed"] = true;
Variable["BaseGameSupport.Journal_Turn06_Conscription_Mandatory"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Organisations_Governmental_SordishA..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn06_A_Reform = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn06_A_Reform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn06_A_AutocratDemands = true"*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligar..."*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn06_AutocratDemands_NationalizeOlig..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "I didn't even want to think about Heron's demands for the..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligarchs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "I leaned back in my chair."*)

### Węzeł `[350]`
Mówca: **Heron Garaci**
> ""There is more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Heron Garaci: ""You must reverse your ridiculous decision to end mandato..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn06_SnO_Conscription_Removed == true"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn06_SnO_Conscription_Removed == true)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn06_SnO_Conscription_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Heron Garaci: ""There is more.""*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn06_SnO_Conscription_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn06_SnO_Conscription_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""Well... For now, I must leave. I hope you'll think long ..."*)

### Węzeł `[354]`
Mówca: **Heron Garaci**
> ""You must reverse your ridiculous decision to end mandatory conscription. A large, strong military is the only way to ensure stability in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Heron Garaci: ""Do that and we will see about the rest.""*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.turn06_AutocratDemands_Conscription = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.turn06_AutocratDemands_Conscription"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Heron Garaci: ""Well... For now, I must leave. I hope you'll think long ..."*)

### Węzeł `[356]`
Mówca: **Heron Garaci**
> ""Do that and we will see about the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.turn06_AutocratDemands_Conscription = true"*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription = true;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads = false; BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligar..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces = true;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads = false;
BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces"] = true;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscription"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_IosefLeads"] = false;
Variable["BaseGameSupport.Codex_Organisations_Governmental_SordishArmedForces_NoConscriptionIosefLeads"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn06_AutocratDemands_NationalizeOligar..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false && Bas..."*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_IncreasedFunding == false && B..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Heron Garaci: ""We are simply a little disappointed about the lack of pr..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_IncreasedFunding == false && BaseGame.Policy_Order_IncreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Heron Garaci: ""We have a few other suggestions that may help you manage..."*)

### Węzeł `[362]`
Mówca: **Heron Garaci**
> ""We have a few other suggestions that may help you manage this difficult period in the best way possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Heron Garaci: ""We wish to see you address these concerns before the jud..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay_Emergency"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Earlier in the day, I learned that Frens Ricter's complai..."*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn06_ST_VictoryDay = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn06_ST_VictoryDay"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "Earlier in the day, I learned that Frens Ricter's complai..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tr..."*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == ..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Heron Garaci: ""You promised to manage this emergency period as best as ..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true) && (BaseGame.Turn03_EnT_Military_Budget_Decrease == true || BaseGame.Turn03_EnT_Military_Budget_Maintain == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true)  and  (Variable["BaseGame.Turn03_EnT_Military_Budget_Decrease"] == true  or  Variable["BaseGame.Turn03_EnT_Military_Budget_Maintain"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Heron Garaci: ""We are doing our best to keep the Court in check, but it..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_CompulsoryMilitaryService == false"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_CompulsoryMilitaryService == f..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_CompulsoryMilitaryService == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Italic: "Start working on a decree to reinstate conscription."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_CompulsoryMilitaryService == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_CompulsoryMilitaryService"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
