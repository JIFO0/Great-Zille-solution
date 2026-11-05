# Sordland/Turn08/A_UnrestMeeting

- **ID konwersacji:** `150`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/150_A_UnrestMeeting.md`
- **Liczba węzłów dialogowych:** 734
- **Liczba wyborów gracza:** 96

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[44]** Lileas Graf
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_CapitalistRayne`
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Archetype_SollistRayne`
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.BergiaSteel_Nationalization`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.BlackTuesdayHappened`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn04_RiotGear_Buy`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_AschrafSupport_DontGo`
- `BaseGame.Decision_Turn08_AschrafSupport_Go`
- `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity`
- `BaseGame.Economy`
- `BaseGame.HeartOfSordland_Nationalization`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NedamMiningGroup_Privatization`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.SordishStateCorporation_Privatization`
- `BaseGame.SuperpowerTradeWarHappened`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn04_SnO_LE_Justice_Decreased`
- `BaseGame.Turn07_Detained_MarcelKoronti`
- `BaseGame.Turn07_SecretState_Detained_FrensRicter`
- `BaseGame.Turn07_SecretState_Detained_KesaroKibener`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGame.Wehlen_JointOperation`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.Economy_Bergia`
- `BaseGame.LateGameCrisis`
- `BaseGame.Public_Opinion`
- `BaseGame.Security_Unrest_Diplomatic`
- `BaseGame.Security_Unrest_Military`
- `BaseGame.Security_Unrest_Police`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatContinues`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Situation_Order_BludishUprising`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGame.Sollist`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGame.Unrest_Peaceful_Happened`
- `BaseGame.Unrest_Violent_Happened`
- `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic`
- `BaseGameSupport.Journal_Turn08_Unrest_Military`
- `BaseGameSupport.Journal_Turn08_Unrest_Police`
- `GameCondition.Turn08_A_UnrestMeeting`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“A problem? Like what?”"** | `[8]` **Lileas Graf**: "“We have a problem.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lileas Graf**: "“This just came in. Here, take a..." |
| `[9]` | **"“Explain. Now.”"** | `[8]` **Lileas Graf**: "“We have a problem.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lileas Graf**: "“This just came in. Here, take a..." |
| `[10]` | **"“Go on.”"** | `[8]` **Lileas Graf**: "“We have a problem.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Lileas Graf**: "“This just came in. Here, take a..." |
| `[33]` | **"Take a look at the report."** | `[34]` **Lileas Graf**: "“This just came in. Here, take a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Narrator**: "The report was titled 'Violent P..."<br>`[32]` **Narrator**: "The report was titled 'BFF Attac..." |
| `[69]` | **"“Change doesn't come easy. There is always a cost.”"** | `[40]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lileas Graf**: "“Yes, but we must do everything ..." |
| `[70]` | **"“We need to look at *now*. We will need to handle these protests.”"** | `[40]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lileas Graf**: "“Agreed.”" |
| `[71]` | **"“Enough. We can't let the tensions rise to those levels again.”"** | `[40]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lileas Graf**: "“We are on it.”" |
| `[76]` | **"“Change doesn't come easy. There is always a cost.”"** | `[44]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Lileas Graf**: "“Yes, and it's our duty to keep ..." |
| `[77]` | **"“We will need to handle these protests.”"** | `[44]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lileas Graf**: "“Agreed.”" |
| `[79]` | **"“I didn't ask you for your opinion.”"** | `[44]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lileas Graf**: "“No, you didn't. Yet here we are.”" |
| `[81]` | **"“What do you want me to do? Detain all of them?”"** | `[52]` **Lileas Graf**: "“We need to put an end to this. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Lileas Graf**: "“Detaining some people would cer..." |
| `[82]` | **"“We must be careful not to suppress their freedom of speech.""** | `[52]` **Lileas Graf**: "“We need to put an end to this. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lileas Graf**: "“How can you call this freedom o..." |
| `[83]` | **"“I agree. They are committing borderline treason.”"** | `[52]` **Lileas Graf**: "“We need to put an end to this. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“We need to handle them immediat..." |
| `[88]` | **"“I agree. They are committing borderline treason.”"** | `[55]` **Lileas Graf**: "“These people have the gall to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Lileas Graf**: "“We need to handle them immediat..." |
| `[90]` | **"“We must be careful not to suppress their freedom of speech.""** | `[55]` **Lileas Graf**: "“These people have the gall to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Lileas Graf**: "“How can you call this freedom o..." |
| `[93]` | **"“What do you want me to do? Detain all of them?”"** | `[55]` **Lileas Graf**: "“These people have the gall to p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Lileas Graf**: "“Detaining *some* of them is cer..." |
| `[97]` | **"“Change doesn't come easy. There is always a cost.”"** | `[63]` **Lileas Graf**: "“Sordland hasn't seen this kind ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lileas Graf**: "“Yes, and it's our duty to keep ..." |
| `[98]` | **"“We need to look at *now*. We will need to handle these protests.”"** | `[63]` **Lileas Graf**: "“Sordland hasn't seen this kind ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Lileas Graf**: "“Agreed.”" |
| `[99]` | **"“Enough. We can't let the tensions rise to those levels again.”"** | `[63]` **Lileas Graf**: "“Sordland hasn't seen this kind ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Lileas Graf**: "“We are on it.”" |
| `[110]` | **"“We will need to handle these protests.”"** | `[68]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Lileas Graf**: "“Agreed.”" |
| `[111]` | **"“Change doesn't come easy. There is always a cost.”"** | `[68]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Lileas Graf**: "“Yes, and it's our duty to keep ..." |
| `[112]` | **"“I didn't ask you for your opinion.”"** | `[68]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Lileas Graf**: "“No, you didn't. Yet here we are.”" |
| `[115]` | **"Salute him back."** | `[114]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[116]` | **"“Status report!”"** | `[114]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[117]` | **"“What is going on?”"** | `[114]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[121]` | **"Salute him back."** | `[120]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[122]` | **"“Status report!”"** | `[120]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[123]` | **"“What is going on?”"** | `[120]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[127]` | **"Salute him back."** | `[126]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[128]` | **"“Status report!”"** | `[126]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[129]` | **"“What is going on?”"** | `[126]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[133]` | **"Salute him back."** | `[132]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[134]` | **"“Status report!”"** | `[132]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[135]` | **"“What is going on?”"** | `[132]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[139]` | **"Salute him back."** | `[138]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[140]` | **"“Status report!”"** | `[138]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[141]` | **"“What is going on?”"** | `[138]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[145]` | **"Salute him back."** | `[144]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[146]` | **"“Status report!”"** | `[144]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[147]` | **"“What is going on?”"** | `[144]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[150]` | **"“Search and destroy. Eliminate the enemies of the state.”"** | `[149]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Police"] = true; Varia...`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] ...` | `[699]` **Karl Greiser**: "“As you command.”"<br>`[193]` **Karl Greiser**: "“As you command.”" |
| `[151]` | **"“I will involve the military. This has gotten out of hand.”"** | `[149]` **Karl Greiser**: "“Your orders, Mr. President?”" | `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)` | *Brak zmian stanu* | `[703]` **Lileas Graf**: "“What? You cannot use the Sordis..."<br>`[549]` **Lileas Graf**: "“What? You cannot use the Sordis..." |
| `[152]` | **"“Infiltrate the dam quietly and take them out. No need to cause a ruckus.”"** | `[149]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Police"] = true; Varia...`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] ...` | `[699]` **Karl Greiser**: "“As you command.”"<br>`[193]` **Karl Greiser**: "“As you command.”" |
| `[157]` | **"“This is ridiculous. How could we let this happen?”"** | `[154]` **Lileas Graf**: "“Thankfully, no casualties have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Lileas Graf**: "“The dam was not necessarily gua..." |
| `[158]` | **"“If news of this ever gets out, we will be the laughing stock of the entire world.”"** | `[154]` **Lileas Graf**: "“Thankfully, no casualties have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lileas Graf**: "“Yes. We need to solve this as q..." |
| `[159]` | **"“What are their demands?”"** | `[154]` **Lileas Graf**: "“Thankfully, no casualties have ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Lileas Graf**: "“We should be receiving a commun..." |
| `[169]` | **"“Status report!”"** | `[172]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[174]` | **"“What is going on?”"** | `[172]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[175]` | **"Salute him back."** | `[172]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[176]` | **"Read the demands."** | `[168]` **Narrator**: "He handed me the file he was hol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Narrator**: "'President Rayne. In the name of..."<br>`[715]` **Narrator**: "'President Rayne. In the name of..." |
| `[191]` | **"“No. We need to approach this diplomatically. We will do what they say and send de..."** | `[190]` **Lileas Graf**: "“Mr. President, the BFF is a thr..."<br>`[727]` **Lileas Graf**: ""We have to destroy them."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[194]` **Lileas Graf**: "“What? We can't negotiate with t..." |
| `[192]` | **"“We will not negotiate with terrorists.”"** | `[190]` **Lileas Graf**: "“Mr. President, the BFF is a thr..."<br>`[727]` **Lileas Graf**: ""We have to destroy them."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Karl Greiser**: "“Your orders, Mr. President?”" |
| `[197]` | **"“Now that I think of it, you are right. It might cause more issues down the road.”"** | `[196]` **Karl Greiser**: "“Please think of the message it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Karl Greiser**: "“Your orders, Mr. President?”" |
| `[198]` | **"“I gave you an order.”"** | `[196]` **Karl Greiser**: "“Please think of the message it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Karl Greiser**: "“As you command, Mr. President.”" |
| `[202]` | **"“And where are those forefathers now? Let me guess. They are dead.”"** | `[201]` **Lileas Graf**: "“Our forefathers will be rolling..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Lileas Graf**: "“Such disrespect!”" |
| `[203]` | **"“Times change, Lileas. This is for the good of the nation.”"** | `[201]` **Lileas Graf**: "“Our forefathers will be rolling..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Lileas Graf**: "“We will see about that.”" |
| `[204]` | **"“Don't you dare question my orders, Lileas.”"** | `[201]` **Lileas Graf**: "“Our forefathers will be rolling..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[205]` **Lileas Graf**: "“We will see about that.”" |
| `[214]` | **"“Thank you both.”"** | `[213]` **Lileas Graf**: "“That's all I had for today.”" | *Brak (Dostępna bezwarunkowo)* | `-- Continue;`<br>`Variable["BaseGame.Situation_Law_BludishOppression"] = tr...` | `[208]` **Lileas Graf**: "“Come on Karl. We are leaving.”" |
| `[215]` | **"“Do not let anything like this happen again. If you do, heads will roll.”"** | `[213]` **Lileas Graf**: "“That's all I had for today.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Lileas Graf**: "“Understood.”" |
| `[216]` | **"“Keep me posted on the updates.”"** | `[213]` **Lileas Graf**: "“That's all I had for today.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lileas Graf**: "“I shall, Mr. President.”" |
| `[348]` | **"“They dare defy me? Traitors!”"** | `[262]` **Karl Greiser**: "“The main rhetoric they all shar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Lileas Graf**: "“We need to approach this in a c..." |
| `[349]` | **"“If my citizens are unhappy, then we should at least hear what they have to say.”"** | `[262]` **Karl Greiser**: "“The main rhetoric they all shar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Lileas Graf**: "“I would refrain from giving the..." |
| `[350]` | **"“Nonsense. If a president resigned whenever someone protested against him, there w..."** | `[262]` **Karl Greiser**: "“The main rhetoric they all shar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Lileas Graf**: "“Well said.”" |
| `[351]` | **"“There is freedom of speech in this country. They can say whatever they want.”"** | `[262]` **Karl Greiser**: "“The main rhetoric they all shar..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[651]` **Lileas Graf**: "“People have died, Mr. Rayne. Fr..."<br>`[355]` **Lileas Graf**: "“I'm afraid soon they might star..." |
| `[465]` | **"“I won't risk civil war. Do whatever it takes to stop the protests. Use force if n..."** | `[444]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[678]` **Karl Greiser**: "“As you command, Mr. President.”"<br>`[674]` **Karl Greiser**: "“As you command, Mr. President.”" |
| `[466]` | **"“Catch the ringleaders and sabotage their plans.”"** | `[444]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[679]` **Karl Greiser**: "“Yes, sir.”"<br>`[673]` **Karl Greiser**: "“Yes, sir.”" |
| `[467]` | **"“I can't fight against my own people. Set up a meeting with their spokesperson, I'..."** | `[444]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[470]` **Karl Greiser**: "“As you command, Mr. President.”" |
| `[468]` | **"“They are peaceful. You said it yourself. I will speak with them and listen to the..."** | `[445]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[475]` **Karl Greiser**: "“As you command, Mr. President. ..." |
| `[481]` | **"“Good luck.”"** | `[480]` **Lileas Graf**: "“If you will excuse us, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[485]` **Lileas Graf**: "“I believe you will need more lu..." |
| `[482]` | **"“Dismissed.”"** | `[480]` **Lileas Graf**: "“If you will excuse us, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[478]` **Lileas Graf**: "“Come on, Karl. We are leaving.”" |
| `[483]` | **"“I expect results.”"** | `[480]` **Lileas Graf**: "“If you will excuse us, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[484]` **Lileas Graf**: "“Of course.”" |
| `[492]` | **"“What is going on?”"** | `[494]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[495]` | **"Salute him back."** | `[494]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[496]` | **"“Status report!”"** | `[494]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[497]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[501]` | **"“We will need to handle these protests.”"** | `[505]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[510]` **Lileas Graf**: "“Agreed.”" |
| `[509]` | **"“Enough. We can't let the tensions rise to those levels again.”"** | `[505]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Lileas Graf**: "“We are on it.”" |
| `[511]` | **"“Change doesn't come easy. There is always a cost.”"** | `[505]` **Lileas Graf**: "“Sordland hasn't seen this much ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Lileas Graf**: "“Yes, and it's our duty to keep ..." |
| `[524]` | **"“We will need to handle these protests.”"** | `[517]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Lileas Graf**: "“Agreed.”" |
| `[525]` | **"“Change doesn't come easy. There is always a cost.”"** | `[517]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[520]` **Lileas Graf**: "“Yes, and we have a duty to keep..." |
| `[526]` | **"“I didn't ask you for your opinion.”"** | `[517]` **Lileas Graf**: "“I can't say this is unexpected.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Lileas Graf**: "“No, you didn't. Yet here we are.”" |
| `[527]` | **"Salute him back."** | `[529]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[533]` | **"“Status report!”"** | `[529]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[534]` | **"“What is going on?”"** | `[529]` **Narrator**: "He saluted me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[518]` **Karl Greiser**: "“Mr. President. I'm so sorry for..." |
| `[550]` | **"“We are in a state of emergency, Lileas. I will use my powers to give them authori..."** | `[549]` **Lileas Graf**: "“What? You cannot use the Sordis..."<br>`[703]` **Lileas Graf**: "“What? You cannot use the Sordis..." | `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true` | *Brak zmian stanu* | `[556]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[554]` | **"“I will sign a presidential decree, giving them authorization to act inside our bo..."** | `[549]` **Lileas Graf**: "“What? You cannot use the Sordis..."<br>`[703]` **Lileas Graf**: "“What? You cannot use the Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[555]` | **"“Watch me.""** | `[549]` **Lileas Graf**: "“What? You cannot use the Sordis..."<br>`[703]` **Lileas Graf**: "“What? You cannot use the Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[557]` | **""Don't you dare question my decision.""** | `[556]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Military"] = true; Var...`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"...`<br>*(+1 skryptów)* | `[208]` **Lileas Graf**: "“Come on Karl. We are leaving.”" |
| `[558]` | **""I will call Iosef immediately.""** | `[556]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Military"] = true; Var...`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"...`<br>*(+1 skryptów)* | `[208]` **Lileas Graf**: "“Come on Karl. We are leaving.”" |
| `[560]` | **"“I will involve the military. This has gotten out of hand.”"** | `[444]` **Karl Greiser**: "“Your orders, Mr. President?”" | `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)` | *Brak zmian stanu* | `[561]` **Lileas Graf**: "“What? You cannot use the Sordis..." |
| `[567]` | **"“I will sign a presidential decree, giving them authorization to act inside our bo..."** | `[561]` **Lileas Graf**: "“What? You cannot use the Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[566]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[568]` | **"“We are in a state of emergency, Lileas. I will use my powers to give them authori..."** | `[561]` **Lileas Graf**: "“What? You cannot use the Sordis..." | `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true` | *Brak zmian stanu* | `[566]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[572]` | **""Don't you dare question my decision.""** | `[566]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Military"] = true; ;`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"...` | `[575]` **Lileas Graf**: "“Fine. Come on Karl. We are leav..." |
| `[573]` | **""I will call Iosef immediately.""** | `[566]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Security_Unrest_Military"] = true; ;`<br>`Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"...` | `[575]` **Lileas Graf**: "“Fine. Come on Karl. We are leav..." |
| `[574]` | **"“Watch me.""** | `[561]` **Lileas Graf**: "“What? You cannot use the Sordis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[566]` **Karl Greiser**: "“Sir, you cannot simply authoriz..." |
| `[582]` | **"“Catch the ringleaders and sabotage their plans.”"** | `[445]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Karl Greiser**: "“Yes, sir.”"<br>`[583]` **Karl Greiser**: "“Yes, sir.”" |
| `[585]` | **"“I won't risk civil war. Do whatever it takes to stop the protests. Use force if n..."** | `[445]` **Karl Greiser**: "“Your orders, Mr. President?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Karl Greiser**: "“As you command, Mr. President.”"<br>`[588]` **Karl Greiser**: "“As you command, Mr. President.”" |

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
  - -> `[3]` (*Narrator: "Lileas entered my office and took a seat."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Lileas entered my office and took a seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "She was frowning intensely. She didn't talk at first, jus..."*)

### Węzeł `[4]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Lileas Graf: "“We have a problem.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“A problem? Like what?”"]** — Mówca: **Player**
> "“A problem? Like what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lileas Graf: "“This just came in. Here, take a look.”"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "She was frowning intensely. She didn't talk at first, just fixed me with a steady gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "When she did speak up, it was in strained tones."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "When she did speak up, it was in strained tones."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[8]`
Mówca: **Lileas Graf**
> "“We have a problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player: "“Explain. Now.”"*)
  - -> `[5]` (*Player: "“A problem? Like what?”"*)
  - -> `[10]` (*Player: "“Go on.”"*)

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Explain. Now.”"]** — Mówca: **Player**
> "“Explain. Now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lileas Graf: "“This just came in. Here, take a look.”"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lileas Graf: "“This just came in. Here, take a look.”"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -12)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == false ||..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -12)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true)"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[32]`
Mówca: **Narrator**
> "The report was titled 'BFF Attack on Soll Dam'. I looked up immediately after reading the title."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened = true; BaseGame.Economy -= ..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "Take a look at the report."]** — Mówca: **Player_Italic**
> "I took the document from her hands and started reading it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[34]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[34]`
Mówca: **Lileas Graf**
> "“This just came in. Here, take a look.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Italic: "Take a look at the report."*)

### Węzeł `[35]`
Mówca: **Lileas Graf**
> "“Yes. You read that right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Lileas Graf: "“The Bludish Freedom Front has taken over Soll Dam.”"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened = true; BaseGame.Economy..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened = true; BaseGame.Econom..."*)

### Węzeł `[38]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Lileas Graf: "“What is unexpected, however, is the sheer size of the pr..."*)

### Węzeł `[39]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. A few people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lileas Graf: "“Sordland hasn't seen this much civil unrest since the de..."*)

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this much civil unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Player: "“Enough. We can't let the tensions rise to those levels a..."*)
  - -> `[70]` (*Player: "“We need to look at *now*. We will need to handle these p..."*)
  - -> `[69]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened = true; BaseGame.Economy..."*)

### Węzeł `[42]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[43]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[44]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“I didn't ask you for your opinion.”"*)
  - -> `[77]` (*Player: "“We will need to handle these protests.”"*)
  - -> `[76]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[45]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“Anti-communism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“I don't know who is behind this, but protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“They seem to be anti-Sollist in nature.”"*)

### Węzeł `[49]`
Mówca: **Lileas Graf**
> "“These people have the gall to protest against the very foundations our country is based on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lileas Graf: "“As if that is not enough, they are turning violent! A fe..."*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“They seem to be anti-Sollist in nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lileas Graf: "“These people have the gall to protest against the very f..."*)

### Węzeł `[51]`
Mówca: **Lileas Graf**
> "“As if that is not enough, they are turning violent! A few people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lileas Graf: "“We need to put an end to this. We can't let them sully t..."*)

### Węzeł `[52]`
Mówca: **Lileas Graf**
> "“We need to put an end to this. We can't let them sully the name of Soll further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“I agree. They are committing borderline treason.”"*)
  - -> `[82]` (*Player: "“We must be careful not to suppress their freedom of spee..."*)
  - -> `[81]` (*Player: "“What do you want me to do? Detain all of them?”"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened = true; BaseGame.Econom..."*)

### Węzeł `[54]`
Mówca: **Lileas Graf**
> "“I don't know who is behind this, but protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[55]`
Mówca: **Lileas Graf**
> "“These people have the gall to protest against the very foundations our country is based on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Player: "“I agree. They are committing borderline treason.”"*)
  - -> `[90]` (*Player: "“We must be careful not to suppress their freedom of spee..."*)
  - -> `[93]` (*Player: "“What do you want me to do? Detain all of them?”"*)

### Węzeł `[56]`
Mówca: **Lileas Graf**
> "“They seem to be anti-Sollist in nature.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lileas Graf: "“These people have the gall to protest against the very f..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "The report was titled 'Violent Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened = true; BaseGame.Economy..."*)

### Węzeł `[58]`
Mówca: **Lileas Graf**
> "“Anti-capitalism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> "“Anti-capitalism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[60]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lileas Graf: "“What is unexpected, however, is the sheer size of the pr..."*)

### Węzeł `[62]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[63]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this kind of unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "“Enough. We can't let the tensions rise to those levels a..."*)
  - -> `[98]` (*Player: "“We need to look at *now*. We will need to handle these p..."*)
  - -> `[97]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened = true; BaseGame.Econom..."*)

### Węzeł `[65]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[66]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. Several people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lileas Graf: "“Sordland hasn't seen this kind of unrest since the death..."*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“I didn't ask you for your opinion.”"*)
  - -> `[110]` (*Player: "“We will need to handle these protests.”"*)
  - -> `[111]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lileas Graf: "“Yes, but we must do everything in our power to keep that..."*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“We need to look at *now*. We will need to handle these protests.”"]** — Mówca: **Player**
> "“We need to look at *now*. We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lileas Graf: "“We are on it.”"*)

### Węzeł `[72]`
Mówca: **Lileas Graf**
> "“Yes, but we must do everything in our power to keep that cost low.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[74]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“Yes, and it's our duty to keep that cost as low as possi..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[78]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lileas Graf: "“No, you didn't. Yet here we are.”"*)

### Węzeł `[80]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“What do you want me to do? Detain all of them?”"]** — Mówca: **Player**
> "“What do you want me to do? Detain all of them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lileas Graf: "“Detaining some people would certainly be a start.”"*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“We must be careful not to suppress their freedom of speech.""]** — Mówca: **Player**
> "“We must be careful not to suppress their freedom of speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lileas Graf: "“How can you call this freedom of speech? They are spitti..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“I agree. They are committing borderline treason.”"]** — Mówca: **Player**
> "“I agree. They are committing borderline treason.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“We need to handle them immediately.”"*)

### Węzeł `[84]`
Mówca: **Lileas Graf**
> "“Detaining some people would certainly be a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“How can you call this freedom of speech? They are spitting on the name of the founder of our country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lileas Graf: "“If they don't like it, they can go somewhere else.”"*)

### Węzeł `[86]`
Mówca: **Lileas Graf**
> "“If they don't like it, they can go somewhere else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“We need to handle them immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[88]`
**[WYBÓR GRACZA: "“I agree. They are committing borderline treason.”"]** — Mówca: **Player**
> "“I agree. They are committing borderline treason.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“We need to handle them immediately.”"*)

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“We need to handle them immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“We must be careful not to suppress their freedom of speech.""]** — Mówca: **Player**
> "“We must be careful not to suppress their freedom of speech.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lileas Graf: "“How can you call this freedom of speech? They are spitti..."*)

### Węzeł `[91]`
Mówca: **Lileas Graf**
> "“Detaining *some* of them is certainly a start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[92]`
Mówca: **Lileas Graf**
> "“How can you call this freedom of speech? They are spitting on the name of the founder of our country!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lileas Graf: "“If they don't like it, they can go somewhere else.”"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“What do you want me to do? Detain all of them?”"]** — Mówca: **Player**
> "“What do you want me to do? Detain all of them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lileas Graf: "“Detaining *some* of them is certainly a start.”"*)

### Węzeł `[94]`
Mówca: **Lileas Graf**
> "“If they don't like it, they can go somewhere else.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[95]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[96]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lileas Graf: "“Yes, and it's our duty to keep that cost as low as possi..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA: "“We need to look at *now*. We will need to handle these protests.”"]** — Mówca: **Player**
> "“We need to look at *now*. We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lileas Graf: "“We are on it.”"*)

### Węzeł `[100]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[101]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[647]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[102]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[653]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[104]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[105]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[106]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[107]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[108]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[656]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[109]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lileas Graf: "“Yes, and it's our duty to keep that cost as low as possi..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lileas Graf: "“No, you didn't. Yet here we are.”"*)

### Węzeł `[113]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "He saluted me."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“What is going on?”"*)
  - -> `[116]` (*Player: "“Status report!”"*)
  - -> `[115]` (*Player_Italic: "Salute him back."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[118]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[119]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "He saluted me."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“What is going on?”"*)
  - -> `[122]` (*Player: "“Status report!”"*)
  - -> `[121]` (*Player_Italic: "Salute him back."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[120]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[124]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[125]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "He saluted me."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "“What is going on?”"*)
  - -> `[128]` (*Player: "“Status report!”"*)
  - -> `[127]` (*Player_Italic: "Salute him back."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[130]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[131]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "He saluted me."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Player: "“What is going on?”"*)
  - -> `[134]` (*Player: "“Status report!”"*)
  - -> `[133]` (*Player_Italic: "Salute him back."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[136]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[137]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "He saluted me."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player: "“What is going on?”"*)
  - -> `[140]` (*Player: "“Status report!”"*)
  - -> `[139]` (*Player_Italic: "Salute him back."*)

### Węzeł `[139]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[142]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[143]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "He saluted me."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: "“What is going on?”"*)
  - -> `[146]` (*Player: "“Status report!”"*)
  - -> `[145]` (*Player_Italic: "Salute him back."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[144]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[148]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[149]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“Search and destroy. Eliminate the enemies of the state.”"*)
  - -> `[152]` (*Player: "“Infiltrate the dam quietly and take them out. No need to..."*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“Search and destroy. Eliminate the enemies of the state.”"]** — Mówca: **Player**
> "“Search and destroy. Eliminate the enemies of the state.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true; BaseGame.Bludish_..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "“I will involve the military. This has gotten out of hand.”"]** — Mówca: **Player**
> "“I will involve the military. This has gotten out of hand.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Kontekst wejściowy (poprzednik):** `[149]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA: "“Infiltrate the dam quietly and take them out. No need to cause a ruckus.”"]** — Mówca: **Player**
> "“Infiltrate the dam quietly and take them out. No need to cause a ruckus.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[149]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true; BaseGame.Bludish_..."*)

### Węzeł `[153]`
Mówca: **Lileas Graf**
> "“The Bludish Freedom Front has taken over Soll Dam.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lileas Graf: "“That dam currently provides 90% of electricity to Bergia..."*)

### Węzeł `[154]`
Mówca: **Lileas Graf**
> "“Thankfully, no casualties have been reported yet. We know that they have taken the staff as hostages.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: "“This is ridiculous. How could we let this happen?”"*)
  - -> `[158]` (*Player: "“If news of this ever gets out, we will be the laughing s..."*)
  - -> `[159]` (*Player: "“What are their demands?”"*)

### Węzeł `[155]`
Mówca: **Lileas Graf**
> "“That dam currently provides 90% of electricity to Bergia and its neighbouring regions. If they destroy the power station...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Lileas Graf: "“...I don't even want to think about the outcome.”"*)

### Węzeł `[156]`
Mówca: **Lileas Graf**
> "“...I don't even want to think about the outcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lileas Graf: "“Thankfully, no casualties have been reported yet. We kno..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“This is ridiculous. How could we let this happen?”"]** — Mówca: **Player**
> "“This is ridiculous. How could we let this happen?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lileas Graf: "“The dam was not necessarily guarded well. No one thought..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA: "“If news of this ever gets out, we will be the laughing stock of the entire world.”"]** — Mówca: **Player**
> "“If news of this ever gets out, we will be the laughing stock of the entire world.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lileas Graf: "“Yes. We need to solve this as quickly and quietly as pos..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "“What are their demands?”"]** — Mówca: **Player**
> "“What are their demands?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Lileas Graf: "“We should be receiving a communication from them soon.”"*)

### Węzeł `[160]`
Mówca: **Lileas Graf**
> "“Yes. We need to solve this as quickly and quietly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[161]`
Mówca: **Lileas Graf**
> "“The dam was not necessarily guarded well. No one thought they would be able to hit a power center.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[162]`
Mówca: **Lileas Graf**
> "“We should be receiving a communication from them soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Lileas Graf: "“Mr. President.”"*)

### Węzeł `[163]`
Mówca: **Lileas Graf**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[164]`
Mówca: **Lileas Graf**
> "“I'm afraid that's not all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[165]`
Mówca: **Lileas Graf**
> "“They are holding him hostage as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[166]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[168]`
Mówca: **Narrator**
> "He handed me the file he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Italic: "Read the demands."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[170]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "He saluted me."*)

### Węzeł `[171]`
Mówca: **Karl Greiser**
> "“We have just received the demands from the terrorists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Narrator: "He handed me the file he was holding."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "“What is going on?”"*)
  - -> `[169]` (*Player: "“Status report!”"*)
  - -> `[175]` (*Player_Italic: "Salute him back."*)

### Węzeł `[173]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[175]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[176]`
**[WYBÓR GRACZA: "Read the demands."]** — Mówca: **Player_Italic**
> "I started reading the file."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "'President Rayne. In the name of peace, we have taken hold of the Soll Dam and the Governor of Bergia is our hostage.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "'The free people of Bludia have suffered enough under the..."*)

### Węzeł `[178]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lileas Graf: "“Do you have any updates?”"*)

### Węzeł `[179]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Karl Greiser: "“We have just received the demands from the terrorists.”"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "'If our demands are not met, we will cut off electricity to the entirety of the Bergia and Nargis regions along with the governor's head.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "'Take this as your final warning.'"*)

### Węzeł `[181]`
Mówca: **Narrator**
> "'Yollak Bluderat!'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I handed the document to Lileas and she read it carefully."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "'The free people of Bludia have suffered enough under the tyranny of Sordland. Our villages were destroyed, our men and women assaulted, our children killed by our very own government in the name of this dam.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "'We, the BFF, are with the people. We, the BFF, always de..."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "'We, the BFF, are with the people. We, the BFF, always defend the downtrodden. We, the BFF, fight for freedom.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "'We, the BFF, are not like the Sordish government. We kno..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "'We, the BFF, are not like the Sordish government. We know compassion and we believe in a chance of reconciliation between our people.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "'That's why we are demanding a delegation from the Sordis..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "'That's why we are demanding a delegation from the Sordish government to negotiate the price of our freedom. We are ready to sit at the table as equals.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "'Make no mistake. We also know that true freedom comes at..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "'Make no mistake. We also know that true freedom comes at a cost. We will not hesitate to sacrifice as many lives as it takes to achieve our goals.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "'Take this as your final warning.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "'Yollak Bluderat!'"*)

### Węzeł `[188]`
Mówca: **Narrator**
> "I handed the document to Lileas and she read it carefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lileas Graf: "“As I thought.”"*)

### Węzeł `[189]`
Mówca: **Lileas Graf**
> "“As I thought.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[190]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. They must be completely eradicated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“We will not negotiate with terrorists.”"*)
  - -> `[191]` (*Player: "“No. We need to approach this diplomatically. We will do ..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA: "“No. We need to approach this diplomatically. We will do what they say and send delegates.”"]** — Mówca: **Player**
> "“No. We need to approach this diplomatically. We will do what they say and send delegates.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Lileas Graf), `[727]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Lileas Graf: "“What? We can't negotiate with terrorists!”"*)

### Węzeł `[192]`
**[WYBÓR GRACZA: "“We will not negotiate with terrorists.”"]** — Mówca: **Player**
> "“We will not negotiate with terrorists.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Lileas Graf), `[727]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Karl Greiser: "“Your orders, Mr. President?”"*)

### Węzeł `[193]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lileas Graf: "“It's good to see that we are taking immediate action.”"*)

### Węzeł `[194]`
Mówca: **Lileas Graf**
> "“What? We can't negotiate with terrorists!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Karl Greiser: "“I agree with Ms. Graf, Mr. President.”"*)

### Węzeł `[195]`
Mówca: **Karl Greiser**
> "“I agree with Ms. Graf, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Karl Greiser: "“Please think of the message it would send to other crimi..."*)

### Węzeł `[196]`
Mówca: **Karl Greiser**
> "“Please think of the message it would send to other criminal elements in the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player: "“Now that I think of it, you are right. It might cause mo..."*)
  - -> `[198]` (*Player: "“I gave you an order.”"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Now that I think of it, you are right. It might cause more issues down the road.”"]** — Mówca: **Player**
> "“Now that I think of it, you are right. It might cause more issues down the road.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Karl Greiser: "“Your orders, Mr. President?”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[199]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Lileas Graf: "“This is ridiculous!”"*)

### Węzeł `[200]`
Mówca: **Lileas Graf**
> "“This is ridiculous!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Lileas Graf: "“Our forefathers will be rolling in their graves!”"*)

### Węzeł `[201]`
Mówca: **Lileas Graf**
> "“Our forefathers will be rolling in their graves!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: "“And where are those forefathers now? Let me guess. They ..."*)
  - -> `[203]` (*Player: "“Times change, Lileas. This is for the good of the nation.”"*)
  - -> `[204]` (*Player: "“Don't you dare question my orders, Lileas.”"*)

### Węzeł `[202]`
**[WYBÓR GRACZA: "“And where are those forefathers now? Let me guess. They are dead.”"]** — Mówca: **Player**
> "“And where are those forefathers now? Let me guess. They are dead.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lileas Graf: "“Such disrespect!”"*)

### Węzeł `[203]`
**[WYBÓR GRACZA: "“Times change, Lileas. This is for the good of the nation.”"]** — Mówca: **Player**
> "“Times change, Lileas. This is for the good of the nation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lileas Graf: "“We will see about that.”"*)

### Węzeł `[204]`
**[WYBÓR GRACZA: "“Don't you dare question my orders, Lileas.”"]** — Mówca: **Player**
> "“Don't you dare question my orders, Lileas.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lileas Graf: "“We will see about that.”"*)

### Węzeł `[205]`
Mówca: **Lileas Graf**
> "“We will see about that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lileas Graf: "“I am done with this meeting.”"*)

### Węzeł `[206]`
Mówca: **Lileas Graf**
> "“Such disrespect!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lileas Graf: "“I am done with this meeting.”"*)

### Węzeł `[207]`
Mówca: **Lileas Graf**
> "“I am done with this meeting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Diplomatic = true;"*)

### Węzeł `[208]`
Mówca: **Lileas Graf**
> "“Come on Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[661]` (*Narrator: "Lileas hurriedly left the room. Karl bowed to me."*)

### Węzeł `[209]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "He followed after her."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_UnrestMeeting = true"*)

### Węzeł `[211]`
Mówca: **Lileas Graf**
> "“It's good to see that we are taking immediate action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Lileas Graf: "“Thank you, Mr. President.”"*)

### Węzeł `[212]`
Mówca: **Lileas Graf**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Lileas Graf: "“That's all I had for today.”"*)

### Węzeł `[213]`
Mówca: **Lileas Graf**
> "“That's all I had for today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: "“Thank you both.”"*)
  - -> `[215]` (*Player: "“Do not let anything like this happen again. If you do, h..."*)
  - -> `[216]` (*Player: "“Keep me posted on the updates.”"*)

### Węzeł `[214]`
**[WYBÓR GRACZA: "“Thank you both.”"]** — Mówca: **Player**
> "“Thank you both.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Do not let anything like this happen again. If you do, heads will roll.”"]** — Mówca: **Player**
> "“Do not let anything like this happen again. If you do, heads will roll.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lileas Graf: "“Understood.”"*)

### Węzeł `[216]`
**[WYBÓR GRACZA: "“Keep me posted on the updates.”"]** — Mówca: **Player**
> "“Keep me posted on the updates.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lileas Graf: "“I shall, Mr. President.”"*)

### Węzeł `[217]`
Mówca: **Lileas Graf**
> "“Understood.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[218]`
Mówca: **Lileas Graf**
> "“I shall, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[219]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Lileas Graf: "“Do you have any updates?”"*)

### Węzeł `[220]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Karl Greiser: "“As you know, protests have been organised in major citie..."*)

### Węzeł `[221]`
Mówca: **Karl Greiser**
> "“As you know, protests have been organised in major cities like Holsord, Lachaven, Deyr and many more.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[222]`
Mówca: **Karl Greiser**
> "“So called *protesters* organised an attack with KA-74s. 26 policemen died. On the civilian side, there were 13 casualties. Many more were injured, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Karl Greiser: "“The situation is extremely dire, Mr. President.”"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Karl Greiser: "“Thankfully, the demonstrations have been successfully su..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true"*)

### Węzeł `[226]`
Mówca: **Karl Greiser**
> "“Two people fell off from a truck and that seems to be about it. However, there is potential for these protests to turn violent.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[227]`
Mówca: **Lileas Graf**
> "“Do you have any updates?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Karl Greiser: "“As you know, protests have been popping up around Sordis..."*)

### Węzeł `[228]`
Mówca: **Karl Greiser**
> "“As you know, protests have been popping up around Sordish cities. They seem to be peaceful. For now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Karl Greiser: "“Two people fell off from a truck and that seems to be ab..."*)

### Węzeł `[229]`
Mówca: **Lileas Graf**
> "“Karl. I already informed the president of the situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Lileas Graf: "“Do you have any updates?”"*)

### Węzeł `[230]`
Mówca: **Karl Greiser**
> "“Thankfully, the demonstrations have been successfully suppressed for the time being.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == t..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Karl Greiser: "“Unfortunately we are having a hard time suppressing the ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Maintain"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Karl Greiser: "“Unfortunately my men on the ground are being overwhelmed..."*)

### Węzeł `[234]`
Mówca: **Karl Greiser**
> "“Unfortunately we are having a hard time suppressing the unrest.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)

### Węzeł `[235]`
Mówca: **Karl Greiser**
> "“Unfortunately my men on the ground are being overwhelmed by the protesters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RiotGear_Buy)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Karl Greiser: "“The President's wise decision to procure additional riot..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RiotGear_Buy)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Karl Greiser: "“Although I do believe we would have had an easier time d..."*)

### Węzeł `[239]`
Mówca: **Karl Greiser**
> "“The President's wise decision to procure additional riot gear has immensely helped.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Karl Greiser: "“Two protesters were killed in retaliation to throwing a ..."*)

### Węzeł `[240]`
Mówca: **Karl Greiser**
> "“Although I do believe we would have had an easier time dealing with them if we had additional riot gear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Karl Greiser: "“Two civilians and two policemen were killed due to a fir..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RiotGear_Buy)"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Karl Greiser: "“The President's decision to procure additional riot gear..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RiotGear_Buy)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Karl Greiser: "“This is partly due to the lack of riot gear.”"*)

### Węzeł `[244]`
Mówca: **Karl Greiser**
> "“The President's decision to procure additional riot gear has helped us, but our units are still outnumbered.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Karl Greiser: "“4 policemen and 2 protestors have been killed during the..."*)

### Węzeł `[245]`
Mówca: **Karl Greiser**
> "“This is partly due to the lack of riot gear.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Karl Greiser: "“Eight policemen and two protesters have been killed duri..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn04_RiotGear_Buy"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn04_RiotGear_Buy)"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn04_RiotGear_Buy`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Karl Greiser: "“The President's wise decision to procure additional riot..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn04_RiotGear_Buy)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_RiotGear_Buy"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Karl Greiser: "“We are not well-equipped enough to tip the balance.”"*)

### Węzeł `[249]`
Mówca: **Karl Greiser**
> "“The President's wise decision to procure additional riot gear has immensely helped. But we have been unable to prevent casualties.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Karl Greiser: "“So called *protesters* organised an attack with KA-74s. ..."*)

### Węzeł `[250]`
Mówca: **Karl Greiser**
> "“We are not well-equipped enough to tip the balance.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Karl Greiser: "“So called *protesters* organised an attack with KA-74s. ..."*)

### Węzeł `[251]`
Mówca: **Karl Greiser**
> "“Two protesters were killed in retaliation to throwing a firebomb on our units. Aside from that, no injuries.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Karl Greiser: "“The situation is completely under our control.”"*)

### Węzeł `[252]`
Mówca: **Karl Greiser**
> "“Two civilians and two policemen were killed due to a firebomb thrown by the protesters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Karl Greiser: "“Aside from that small incident, the situation is mostly ..."*)

### Węzeł `[253]`
Mówca: **Karl Greiser**
> "“4 policemen and 2 protestors have been killed during the clashes. One of the said *protesters* seem to have had a KA-74.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Karl Greiser: "“The situation is escalating.”"*)

### Węzeł `[254]`
Mówca: **Karl Greiser**
> "“Eight policemen and two protesters have been killed during the clashes. One of the said *protesters* seem to have had a KA-74.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Karl Greiser: "“The situation is escalating quickly.”"*)

### Węzeł `[255]`
Mówca: **Karl Greiser**
> "“So called *protesters* organised an attack with KA-74s. 13 policemen and nine civilians have died. Many were injured.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Karl Greiser: "“The situation is dire.”"*)

### Węzeł `[256]`
Mówca: **Karl Greiser**
> "“The situation is completely under our control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[257]`
Mówca: **Karl Greiser**
> "“Aside from that small incident, the situation is mostly under our control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[258]`
Mówca: **Karl Greiser**
> "“The situation is escalating.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[259]`
Mówca: **Karl Greiser**
> "“The situation is escalating quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[260]`
Mówca: **Karl Greiser**
> "“The situation is dire.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[261]`
Mówca: **Karl Greiser**
> "“The situation is extremely dire, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[262]`
Mówca: **Karl Greiser**
> "“The main rhetoric they all share is that they are demanding the President's resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: "“They dare defy me? Traitors!”"*)
  - -> `[349]` (*Player: "“If my citizens are unhappy, then we should at least hear..."*)
  - -> `[350]` (*Player: "“Nonsense. If a president resigned whenever someone prote..."*)
  - -> `[351]` (*Player: "“There is freedom of speech in this country. They can say..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 5"*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Economy <= 5)"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy <= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Economy"] <= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Economy <= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Economy"] <= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSo..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "BaseGame.BlackTuesdayHappened == true"*)
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BlackTuesdayHappened == true)"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BlackTuesdayHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BlackTuesdayHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Karl Greiser: "“The majority of the protests are about the Sordish marke..."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BlackTuesdayHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BlackTuesdayHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.SuperpowerTradeWarHappened == true"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SuperpowerTradeWarHappened == true)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SuperpowerTradeWarHappened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SuperpowerTradeWarHappened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Karl Greiser: "“The majority of the protests are about the global trade ..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SuperpowerTradeWarHappened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SuperpowerTradeWarHappened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Karl Greiser: "“The majority of the protests are about the state of the ..."*)

### Węzeł `[272]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the Sordish markets crashing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSo..."*)

### Węzeł `[273]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the global trade war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSo..."*)

### Węzeł `[274]`
Mówca: **Karl Greiser**
> "“The majority of the protests are about the state of the economy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSo..."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "He pulled out a document from the folder he was carrying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy <= 5"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSo..."*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOf..."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"] == 6`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Karl Greiser: "“There are some that are protesting against the state tak..."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization + BaseGame.HeartOfSordland_Nationalization == 6)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] + Variable["BaseGame.HeartOfSordland_Nationalization"] == 6) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 && Ba..."*)

### Węzeł `[279]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the state taking over Sordland's largest corporations.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3 && Ba..."*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 3 && ..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Karl Greiser: "“There are some that are protesting against the full priv..."*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 3 && BaseGame.NedamMiningGroup_Privatization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3  and  Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization == 3"*)

### Węzeł `[283]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of the Sordish State Corporation and Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.NedamMiningGroup_Privatization == 3"*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.NedamMiningGroup_Privatization == 3)"*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.NedamMiningGroup_Privatization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.NedamMiningGroup_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Karl Greiser: "“There are some that are protesting against the full priv..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.NedamMiningGroup_Privatization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.NedamMiningGroup_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3"*)

### Węzeł `[287]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of Nedam Mining Group.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.Hea..."*)
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.H..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 3  and  Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Karl Greiser: "“There are some that are protesting against the full nati..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.HeartOfSordland_Nationalization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 3  and  Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3"*)

### Węzeł `[291]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Bergia Steel and Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.HeartOfSordland_Nationalization == 3"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.HeartOfSordland_Nationalization == 3)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.HeartOfSordland_Nationalization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.HeartOfSordland_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Karl Greiser: "“There are some that are protesting against the full nati..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.HeartOfSordland_Nationalization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.HeartOfSordland_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 3"*)

### Węzeł `[295]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Heart of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Decreased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Justice_Decreased == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Justice_Decreased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Justice_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Karl Greiser: "“Judges and various other civil servants are protesting a..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Justice_Decreased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Justice_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[299]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full nationalization of Bergia Steel.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 3"*)
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSteel_Nationalization == 3)"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSteel_Nationalization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSteel_Nationalization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Karl Greiser: "“There are some that are protesting against the full nati..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSteel_Nationalization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSteel_Nationalization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[303]`
Mówca: **Karl Greiser**
> "“There are some that are protesting against the full privatization of the Sordish State Corporation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Justice_Decreased == true"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "BaseGame.SordishStateCorporation_Privatization == 3"*)
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SordishStateCorporation_Privatization == 3)"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SordishStateCorporation_Privatization == 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SordishStateCorporation_Privatization"] == 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Karl Greiser: "“There are some that are protesting against the full priv..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SordishStateCorporation_Privatization == 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SordishStateCorporation_Privatization"] == 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSteel_Nationalization == 3 && BaseGame.Hea..."*)

### Węzeł `[307]`
Mówca: **Karl Greiser**
> "“Judges and various other civil servants are protesting against backlogs in court matters.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Karl Greiser: "“Teachers are protesting against the decreased education ..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[311]`
Mówca: **Karl Greiser**
> "“Teachers are protesting against the decreased education budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Karl Greiser: "“Doctors are protesting against the decreased healthcare ..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true"*)

### Węzeł `[315]`
Mówca: **Karl Greiser**
> "“Doctors are protesting against the decreased healthcare budget.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_FrensRicter == true"*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true)"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Karl Greiser: "“The arrest of Frens Ricter has been a large factor in th..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == true"*)

### Węzeł `[319]`
Mówca: **Karl Greiser**
> "“The arrest of Frens Ricter has been a large factor in the protests. Members of PFJP and the reformist-leaning populace are at the forefront.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Detained_KesaroKibener == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == t..."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Detained_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Karl Greiser: "“The arrest of Kesaro Kibener angered many right-leaning ..."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Detained_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Detained_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true"*)

### Węzeł `[323]`
Mówca: **Karl Greiser**
> "“The arrest of Kesaro Kibener angered many right-leaning citizens.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true"*)

### Węzeł `[324]`
Mówca: **Karl Greiser**
> "“The arrest of Marcel Koronti has caused an uproar as he was a very public figure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_Detained_MarcelKoronti == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_Detained_MarcelKoronti == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_Detained_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Karl Greiser: "“The arrest of Marcel Koronti has caused an uproar as he ..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_Detained_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_Detained_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Karl Greiser: "“The Language Unification Bill led to protests, particula..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_DontGo == true"*)

### Węzeł `[331]`
Mówca: **Karl Greiser**
> "“The Language Unification Bill led to protests, particularly in the Bergia region.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_DontGo == true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_DontGo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_DontGo == true"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_DontGo == true)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_DontGo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_DontGo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Karl Greiser: "“Thanks to the media, we are under fire for not showing s..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_DontGo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_DontGo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ==..."*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity ..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Karl Greiser: "“Thanks to the media, we are under fire for the dead prot..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_GoWithSecurity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_Go == true"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_Go == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_AschrafSupport_Go == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_AschrafSupport_Go == true)"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_AschrafSupport_Go == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Karl Greiser: "“Thanks to the media, we are under fire for showing suppo..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_AschrafSupport_Go == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_AschrafSupport_Go"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[341]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for not showing support for the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[342]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for the dead protester at the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[343]`
Mówca: **Karl Greiser**
> "“Thanks to the media, we are under fire for showing support at the Aschraf Anniversary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Karl Greiser: "“Protesters are also demonstrating against the joint oper..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Karl Greiser: "“In addition, there are many provocateurs that are not ti..."*)

### Węzeł `[347]`
Mówca: **Karl Greiser**
> "“Protesters are also demonstrating against the joint operation with Wehlen against the Bludish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Karl Greiser: "“In addition, there are many provocateurs that are not ti..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA: "“They dare defy me? Traitors!”"]** — Mówca: **Player**
> "“They dare defy me? Traitors!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Lileas Graf: "“We need to approach this in a calm, controlled manner. O..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA: "“If my citizens are unhappy, then we should at least hear what they have to say.”"]** — Mówca: **Player**
> "“If my citizens are unhappy, then we should at least hear what they have to say.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Lileas Graf: "“I would refrain from giving them too much agency.”"*)

### Węzeł `[350]`
**[WYBÓR GRACZA: "“Nonsense. If a president resigned whenever someone protested against him, there would be no presidents.”"]** — Mówca: **Player**
> "“Nonsense. If a president resigned whenever someone protested against him, there would be no presidents.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Lileas Graf: "“Well said.”"*)

### Węzeł `[351]`
**[WYBÓR GRACZA: "“There is freedom of speech in this country. They can say whatever they want.”"]** — Mówca: **Player**
> "“There is freedom of speech in this country. They can say whatever they want.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[262]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[352]`
Mówca: **Lileas Graf**
> "“We need to approach this in a calm, controlled manner. Otherwise the pot might boil over.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: "“What does the protester profile look like?”"*)

### Węzeł `[353]`
Mówca: **Lileas Graf**
> "“I would refrain from giving them too much agency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: "“What does the protester profile look like?”"*)

### Węzeł `[354]`
Mówca: **Lileas Graf**
> "“Well said.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: "“What does the protester profile look like?”"*)

### Węzeł `[355]`
Mówca: **Lileas Graf**
> "“I'm afraid soon they might start doing more than just saying things.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: "“What does the protester profile look like?”"*)

### Węzeł `[356]`
Mówca: **Lileas Graf**
> "“What does the protester profile look like?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Karl Greiser: "“We have investigated the various groups involved in the ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Lileas Graf: "“Protests against your emergency are erupting all over So..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Lileas Graf: "“Anti-communism protests have been erupting all over Sord..."*)

### Węzeł `[360]`
Mówca: **Lileas Graf**
> "“Protests against your emergency are erupting all over Sordland. Many anti-communists are among the instigators.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Lileas Graf: "“Yes. Despite the emergency.”"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[364]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Lileas Graf: "“Protests against your emergency have been erupting all o..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: "“I don't know who is behind this, but protests have been ..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Lileas Graf: "“Yes. Despite the emergency.”"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“They seem to be anti-Sollist in nature.”"*)

### Węzeł `[371]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: "“They seem to be anti-Sollist in nature.”"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Lileas Graf: "“Protests against your emergency are erupting all over So..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lileas Graf: "“Anti-capitalism protests have been erupting all over Sor..."*)

### Węzeł `[375]`
Mówca: **Lileas Graf**
> "“Protests against your emergency are erupting all over Sordland. Many anti-capitalists are among the instigators.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[377]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Lileas Graf: "“Yes. Despite the emergency.”"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[379]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[380]`
Mówca: **Karl Greiser**
> "“We have investigated the various groups involved in the protests and compiled a list of their complaints. I will go through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He pulled out a document from the folder he was carrying."*)

### Węzeł `[381]`
Mówca: **Karl Greiser**
> "“In addition, there are many provocateurs that are not tied to any specific organization or cause.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Karl Greiser: "“Regardless, these protests are happening during an emerg..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[385]`
Mówca: **Karl Greiser**
> "“Regardless, these protests are happening during an emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Lileas Graf: "“That's indeed cause for concern.”"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Karl Greiser: "“These protests happening during an emergency means they ..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[389]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[390]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[391]`
Mówca: **Karl Greiser**
> "“These protests happening during an emergency means they are aiming to destabilise the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Lileas Graf: "“That's indeed cause for concern.”"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Karl Greiser: "“We currently have 467 protesters in custody.”"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Karl Greiser: "“We currently have 27 protesters in custody.”"*)

### Węzeł `[395]`
Mówca: **Karl Greiser**
> "“We currently have 467 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[396]`
Mówca: **Karl Greiser**
> "“We currently have 27 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[397]`
Mówca: **Karl Greiser**
> "“We currently have 1376 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[398]`
Mówca: **Karl Greiser**
> "“We currently have 137 protesters in custody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Karl Greiser: "“We currently have 1376 protesters in custody.”"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Karl Greiser: "“We currently have 137 protesters in custody.”"*)

### Węzeł `[402]`
Mówca: **Karl Greiser**
> "“Related to the protests, we have detained 642 people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Karl Greiser: "“Staging these protests during a state of emergency... it..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[406]`
Mówca: **Lileas Graf**
> "“That's indeed cause for concern.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)

### Węzeł `[407]`
Mówca: **Karl Greiser**
> "“Staging these protests during a state of emergency... it's almost as if they are trying to trigger a civil war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Lileas Graf: "“That's indeed cause for concern.”"*)

### Węzeł `[408]`
Mówca: **Karl Greiser**
> "“Related to the protests, we have detained 2364 people.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == ..."*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial =..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Karl Greiser: "“Related to the protests, we have detained 2364 people.”"*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_DetentionWithoutTrial"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Karl Greiser: "“Related to the protests, we have detained 642 people.”"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true)"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)

### Węzeł `[421]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found NFP and Young Sords members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[422]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found PFJP, Red Youth and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 2)"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Karl Greiser: "“Among the detainees, we have found NFP, USP, Young Sords..."*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Karl Greiser: "“Among the detainees, we have found NFP and Young Sords m..."*)

### Węzeł `[426]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found NFP, USP, Young Sords and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 2)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Karl Greiser: "“Among the detainees, we have found PFJP, Red Youth and B..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Karl Greiser: "“Among the detainees, we have found PFJP and Red Youth me..."*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion < 2"*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion < 2)"*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion < 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] < 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Karl Greiser: "“Among the detainees, we have found Red Youth members and..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion < 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] < 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Karl Greiser: "“Among the detainees, we have found Red Youth members.”"*)

### Węzeł `[433]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found PFJP and Red Youth members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[434]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found Red Youth members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[435]`
Mówca: **Karl Greiser**
> "“Among the detainees, we have found Red Youth members and BFF members.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)

### Węzeł `[436]`
Mówca: **Lileas Graf**
> "“We need to take action, Mr. President. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Lileas Graf: "“If the protests get even more violent than they already ..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lileas Graf: "“We need to take action, Mr. President. Immediately.”"*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lileas Graf: "“We need to take action, Mr. President. Immediately.”"*)

### Węzeł `[440]`
Mówca: **Lileas Graf**
> "“If the protests get even more violent than they already are...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lileas Graf: "“We are risking a civil war.”"*)

### Węzeł `[441]`
Mówca: **Lileas Graf**
> "“We are risking a civil war.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Karl Greiser: "“Your orders, Mr. President?”"*)

### Węzeł `[442]`
Mówca: **Lileas Graf**
> "“We need to take action, Mr. President. Immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Lileas Graf: "“The protesters may be peaceful now, but any spark of vio..."*)

### Węzeł `[443]`
Mówca: **Lileas Graf**
> "“The protesters may be peaceful now, but any spark of violence might snowball into something I don't even want to think about.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Karl Greiser: "“Your orders, Mr. President?”"*)

### Węzeł `[444]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame..."*)
  - -> `[467]` (*Player: "“I can't fight against my own people. Set up a meeting wi..."*)
  - -> `[465]` (*Player: "“I won't risk civil war. Do whatever it takes to stop the..."*)
  - -> `[466]` (*Player: "“Catch the ringleaders and sabotage their plans.”"*)

### Węzeł `[445]`
Mówca: **Karl Greiser**
> "“Your orders, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Player: "“They are peaceful. You said it yourself. I will speak wi..."*)
  - -> `[585]` (*Player: "“I won't risk civil war. Do whatever it takes to stop the..."*)
  - -> `[582]` (*Player: "“Catch the ringleaders and sabotage their plans.”"*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[449]`
Mówca: **Karl Greiser**
> "“I would like to remind you that some of these groups are banned by decree.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || Ba..."*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true || Base..."*)
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || Ba..."*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true || BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Karl Greiser: "“I would like to remind you that some of these groups are..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Karl Greiser: "“The main rhetoric they all share is that they are demand..."*)

### Węzeł `[465]`
**[WYBÓR GRACZA: "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"]** — Mówca: **Player**
> "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[466]`
**[WYBÓR GRACZA: "“Catch the ringleaders and sabotage their plans.”"]** — Mówca: **Player**
> "“Catch the ringleaders and sabotage their plans.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[467]`
**[WYBÓR GRACZA: "“I can't fight against my own people. Set up a meeting with their spokesperson, I'll listen to their demands.”"]** — Mówca: **Player**
> "“I can't fight against my own people. Set up a meeting with their spokesperson, I'll listen to their demands.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[444]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[468]`
**[WYBÓR GRACZA: "“They are peaceful. You said it yourself. I will speak with them and listen to their demands.”"]** — Mówca: **Player**
> "“They are peaceful. You said it yourself. I will speak with them and listen to their demands.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Karl Greiser: "“As you command, Mr. President. We will try to reach out ..."*)

### Węzeł `[469]`
Mówca: **Karl Greiser**
> "“I will keep you updated on the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Lileas Graf: "“Keep me in the loop as well. We need to end this farce o..."*)

### Węzeł `[470]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Lileas Graf: "“I can't say I condone this. The people must respect the ..."*)

### Węzeł `[471]`
Mówca: **Lileas Graf**
> "“I can't say I condone this. The people must respect the laws of this land. What you are doing right now is giving in to anarchists.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Diplomatic = true;"*)

### Węzeł `[472]`
Mówca: **Lileas Graf**
> "“Good call. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true;"*)

### Węzeł `[473]`
Mówca: **Lileas Graf**
> "“Keep me in the loop as well. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Karl Greiser: "“Of course, Ms. Graf.”"*)

### Węzeł `[474]`
Mówca: **Karl Greiser**
> "“Of course, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true;"*)

### Węzeł `[475]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President. We will try to reach out to their spokesperson.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Lileas Graf: "“I think you are playing with fire, Mr. President.”"*)

### Węzeł `[476]`
Mówca: **Lileas Graf**
> "“I think you are playing with fire, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Lileas Graf: "“Let's hope you don't burn yourself.”"*)

### Węzeł `[477]`
Mówca: **Lileas Graf**
> "“Let's hope you don't burn yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Diplomatic = true;"*)

### Węzeł `[478]`
Mówca: **Lileas Graf**
> "“Come on, Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Narrator: "Lileas hurriedly left the room. Karl bowed to me."*)

### Węzeł `[479]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Narrator: "He followed after her."*)

### Węzeł `[480]`
Mówca: **Lileas Graf**
> "“If you will excuse us, Mr. President, we have work to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Player: "“Good luck.”"*)
  - -> `[482]` (*Player: "“Dismissed.”"*)
  - -> `[483]` (*Player: "“I expect results.”"*)

### Węzeł `[481]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[480]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Lileas Graf: "“I believe you will need more luck than we do.”"*)

### Węzeł `[482]`
**[WYBÓR GRACZA: "“Dismissed.”"]** — Mówca: **Player**
> "“Dismissed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[480]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lileas Graf: "“Come on, Karl. We are leaving.”"*)

### Węzeł `[483]`
**[WYBÓR GRACZA: "“I expect results.”"]** — Mówca: **Player**
> "“I expect results.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[480]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lileas Graf: "“Of course.”"*)

### Węzeł `[484]`
Mówca: **Lileas Graf**
> "“Of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lileas Graf: "“Come on, Karl. We are leaving.”"*)

### Węzeł `[485]`
Mówca: **Lileas Graf**
> "“I believe you will need more luck than we do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lileas Graf: "“Come on, Karl. We are leaving.”"*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn08_A_UnrestMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn08_A_UnrestMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[489]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[489]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[490]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened = true; BaseGame.Economy..."*)

### Węzeł `[491]`
Mówca: **Lileas Graf**
> "“Protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[492]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[493]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Narrator: "He saluted me."*)

### Węzeł `[494]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Player: "“What is going on?”"*)
  - -> `[496]` (*Player: "“Status report!”"*)
  - -> `[495]` (*Player_Italic: "Salute him back."*)

### Węzeł `[495]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[496]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[497]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Lileas Graf: "“Protests against your emergency have been erupting all o..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Lileas Graf: "“Protests have been erupting all over Sordland.”"*)

### Węzeł `[501]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[502]`
Mówca: **Lileas Graf**
> "“What is unexpected, however, is the sheer size of the protests and the level of violence. Several people have been killed already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Lileas Graf: "“Sordland hasn't seen this much unrest since the death of..."*)

### Węzeł `[503]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Lileas Graf: "“What is unexpected, however, is the sheer size of the pr..."*)

### Węzeł `[504]`
Mówca: **Lileas Graf**
> "“We are on it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[505]`
Mówca: **Lileas Graf**
> "“Sordland hasn't seen this much unrest since the death of Bernard Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Player: "“Enough. We can't let the tensions rise to those levels a..."*)
  - -> `[501]` (*Player: "“We will need to handle these protests.”"*)
  - -> `[511]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[506]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[507]`
Mówca: **Lileas Graf**
> "“Yes, and it's our duty to keep that cost as low as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[508]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[509]`
**[WYBÓR GRACZA: "“Enough. We can't let the tensions rise to those levels again.”"]** — Mówca: **Player**
> "“Enough. We can't let the tensions rise to those levels again.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Lileas Graf: "“We are on it.”"*)

### Węzeł `[510]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[511]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[505]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Lileas Graf: "“Yes, and it's our duty to keep that cost as low as possi..."*)

### Węzeł `[512]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[513]`
Mówca: **Lileas Graf**
> "“Protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[514]`
Mówca: **Narrator**
> "The report was titled 'Protests in Major Cities'. I looked up immediately after reading the title. Lileas gave a grim nod of confirmation."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened = true; BaseGame.Econom..."*)

### Węzeł `[515]`
Mówca: **Lileas Graf**
> "“They are asking for your resignation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Lileas Graf: "“I can't say this is unexpected.”"*)

### Węzeł `[516]`
Mówca: **Lileas Graf**
> "“They are protesting you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Lileas Graf: "“They are asking for your resignation.”"*)

### Węzeł `[517]`
Mówca: **Lileas Graf**
> "“I can't say this is unexpected.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Player: "“I didn't ask you for your opinion.”"*)
  - -> `[524]` (*Player: "“We will need to handle these protests.”"*)
  - -> `[525]` (*Player: "“Change doesn't come easy. There is always a cost.”"*)

### Węzeł `[518]`
Mówca: **Karl Greiser**
> "“Mr. President. I'm so sorry for being late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: "“Karl. I already informed the president of the situation.”"*)

### Węzeł `[519]`
Mówca: **Lileas Graf**
> "“Yes. Despite the emergency.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[520]`
Mówca: **Lileas Graf**
> "“Yes, and we have a duty to keep that cost as low as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[521]`
Mówca: **Lileas Graf**
> "“Agreed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[522]`
Mówca: **Lileas Graf**
> "“Karl Greiser is on his way here right now. He will tell us what he knows so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "Just then, there was a loud knock on the door. Karl came ..."*)

### Węzeł `[523]`
Mówca: **Lileas Graf**
> "“No, you didn't. Yet here we are.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[524]`
**[WYBÓR GRACZA: "“We will need to handle these protests.”"]** — Mówca: **Player**
> "“We will need to handle these protests.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Lileas Graf: "“Agreed.”"*)

### Węzeł `[525]`
**[WYBÓR GRACZA: "“Change doesn't come easy. There is always a cost.”"]** — Mówca: **Player**
> "“Change doesn't come easy. There is always a cost.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Lileas Graf: "“Yes, and we have a duty to keep that cost as low as poss..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA: "“I didn't ask you for your opinion.”"]** — Mówca: **Player**
> "“I didn't ask you for your opinion.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Lileas Graf: "“No, you didn't. Yet here we are.”"*)

### Węzeł `[527]`
**[WYBÓR GRACZA: "Salute him back."]** — Mówca: **Player_Italic**
> "I saluted him back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[528]`
Mówca: **Lileas Graf**
> "“Ah, there he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Narrator: "He saluted me."*)

### Węzeł `[529]`
Mówca: **Narrator**
> "He saluted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player: "“What is going on?”"*)
  - -> `[533]` (*Player: "“Status report!”"*)
  - -> `[527]` (*Player_Italic: "Salute him back."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Lileas Graf: "“Yes. Despite the emergency.”"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[533]`
**[WYBÓR GRACZA: "“Status report!”"]** — Mówca: **Player**
> "“Status report!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[534]`
**[WYBÓR GRACZA: "“What is going on?”"]** — Mówca: **Player**
> "“What is going on?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[529]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Karl Greiser: "“Mr. President. I'm so sorry for being late.”"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened = true;
BaseGame.Economy -= 2;
BaseGame.Economy_Bergia = 0;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_BludishUprising = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.Economy_Bergia"] = 0;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_BludishUprising"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: "“Yes. You read that right.”"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“Anti-communism protests have been erupting all over Sord..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lileas Graf: "“I don't know who is behind this, but protests have been ..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: "“Anti-capitalism protests have been erupting all over Sor..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened = true;
BaseGame.Economy -= 1;
BaseGame.Situation_Order_Nationwide_Protests = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Revolt = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Lileas Graf: "“Protests have been erupting all over Sordland.”"*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Protests = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Protests = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened = true;
BaseGame.Economy -= 2;
BaseGame.LateGameCrisis += 1;
BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Protests = false;
BaseGame.Situation_Order_Nationwide_Quelled = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_Violent_Happened"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Diplomatic = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Police = true;
BaseGame.Bludish_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Police = true"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame..."*)
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGa..."*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: "“I will involve the military. This has gotten out of hand.”"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[549]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[554]` (*Player: "“I will sign a presidential decree, giving them authoriza..."*)
  - -> `[555]` (*Player: "“Watch me.""*)

### Węzeł `[550]`
**[WYBÓR GRACZA: "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""]** — Mówca: **Player**
> "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[549]` (Lileas Graf), `[703]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Player: "“We are in a state of emergency, Lileas. I will use my po..."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[554]`
**[WYBÓR GRACZA: "“I will sign a presidential decree, giving them authorization to act inside our borders.""]** — Mówca: **Player**
> "“I will sign a presidential decree, giving them authorization to act inside our borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Lileas Graf), `[703]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[555]`
**[WYBÓR GRACZA: "“Watch me.""]** — Mówca: **Player**
> "“Watch me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Lileas Graf), `[703]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[556]`
Mówca: **Karl Greiser**
> "“Sir, you cannot simply authorize the army to work within our borders. This is under the jurisdiction of the police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Player: ""Don't you dare question my decision.""*)
  - -> `[558]` (*Player: ""I will call Iosef immediately.""*)

### Węzeł `[557]`
**[WYBÓR GRACZA: ""Don't you dare question my decision.""]** — Mówca: **Player**
> ""Don't you dare question my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military = true; BaseGame.Bludis..."*)

### Węzeł `[558]`
**[WYBÓR GRACZA: ""I will call Iosef immediately.""]** — Mówca: **Player**
> ""I will call Iosef immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military = true; BaseGame.Bludis..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military = true;
BaseGame.Bludish_Opinion -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Military"] = true;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 5;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Military = true"*)

### Węzeł `[560]`
**[WYBÓR GRACZA: "“I will involve the military. This has gotten out of hand.”"]** — Mówca: **Player**
> "“I will involve the military. This has gotten out of hand.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Kontekst wejściowy (poprzednik):** `[444]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Lileas Graf: "“What? You cannot use the Sordish Armed Forces inside our..."*)

### Węzeł `[561]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[567]` (*Player: "“I will sign a presidential decree, giving them authoriza..."*)
  - -> `[574]` (*Player: "“Watch me.""*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame..."*)
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGa..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player: "“I will involve the military. This has gotten out of hand.”"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Reform_Court_Success == true) || (BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true)  or  (Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true)) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Military"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Military = true"*)

### Węzeł `[566]`
Mówca: **Karl Greiser**
> "“Sir, you cannot simply authorize the army to work within our borders. This is under the jurisdiction of the police force.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Player: ""Don't you dare question my decision.""*)
  - -> `[573]` (*Player: ""I will call Iosef immediately.""*)

### Węzeł `[567]`
**[WYBÓR GRACZA: "“I will sign a presidential decree, giving them authorization to act inside our borders.""]** — Mówca: **Player**
> "“I will sign a presidential decree, giving them authorization to act inside our borders.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[561]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[568]`
**[WYBÓR GRACZA: "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""]** — Mówca: **Player**
> "“We are in a state of emergency, Lileas. I will use my powers to give them authorization.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[561]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Player: "“We are in a state of emergency, Lileas. I will use my po..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[572]`
**[WYBÓR GRACZA: ""Don't you dare question my decision.""]** — Mówca: **Player**
> ""Don't you dare question my decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[566]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military = true;"*)

### Węzeł `[573]`
**[WYBÓR GRACZA: ""I will call Iosef immediately.""]** — Mówca: **Player**
> ""I will call Iosef immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[566]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military = true;"*)

### Węzeł `[574]`
**[WYBÓR GRACZA: "“Watch me.""]** — Mówca: **Player**
> "“Watch me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[561]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Karl Greiser: "“Sir, you cannot simply authorize the army to work within..."*)

### Węzeł `[575]`
Mówca: **Lileas Graf**
> "“Fine. Come on Karl. We are leaving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Narrator: "Lileas left the room in a huff. Karl bowed to me."*)

### Węzeł `[576]`
Mówca: **Karl Greiser**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Narrator: "He followed after her."*)

### Węzeł `[577]`
Mówca: **Narrator**
> "Lileas left the room in a huff. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[578]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Police = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Police = true"*)

### Węzeł `[580]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Diplomatic = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true"*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Diplomatic = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true"*)

### Węzeł `[582]`
**[WYBÓR GRACZA: "“Catch the ringleaders and sabotage their plans.”"]** — Mówca: **Player**
> "“Catch the ringleaders and sabotage their plans.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[583]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Karl Greiser: "“I will keep you updated on the results.”"*)

### Węzeł `[584]`
Mówca: **Karl Greiser**
> "“I will keep you updated on the results.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Lileas Graf: "“Keep me in the loop as well. We need to end this farce o..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA: "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"]** — Mówca: **Player**
> "“I won't risk civil war. Do whatever it takes to stop the protests. Use force if necessary.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[445]` (Karl Greiser)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[586]`
Mówca: **Lileas Graf**
> "“Good call. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true"*)

### Węzeł `[587]`
Mówca: **Karl Greiser**
> "“Of course, Ms. Graf.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police = true"*)

### Węzeł `[588]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Lileas Graf: "“Good call. We need to end this farce once and for all.”"*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Police = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Security_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn08_Unrest_Police = true"*)

### Węzeł `[590]`
Mówca: **Lileas Graf**
> "“Keep me in the loop as well. We need to end this farce once and for all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Karl Greiser: "“Of course, Ms. Graf.”"*)

### Węzeł `[591]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Police = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[696]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Military = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lileas Graf: "“Come on Karl. We are leaving.”"*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lileas Graf: "“If you will excuse us, Mr. President, we have work to do.”"*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lileas Graf: "“If you will excuse us, Mr. President, we have work to do.”"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Police = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lileas Graf: "“If you will excuse us, Mr. President, we have work to do.”"*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Police = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Police"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Lileas Graf: "“If you will excuse us, Mr. President, we have work to do.”"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn08_Unrest_Military = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn08_Unrest_Military"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Lileas Graf: "“Fine. Come on Karl. We are leaving.”"*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Military == true)"*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police == true"*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Police == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Police == true"*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Security_Unrest_Police == true)"*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Security_Unrest_Police == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Security_Unrest_Police"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Security_Unrest_Police == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Security_Unrest_Police"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion += 2;"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 4"*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 6;"*)

### Węzeł `[611]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true"*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true)"*)

### Węzeł `[612]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 2;"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 4`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[619]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 6;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 6;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[688]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true"*)

### Węzeł `[623]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 5;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[624]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 1;
BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[625]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn08_A_UnrestMeeting = true"*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 2;
BaseGame.Sollist -= 5;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 5;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Continue`
- **Efekt skryptowy (`userScript`):** `-- Continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression = true; BaseGame..."*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression = true;
BaseGame.Situation_Law_BludishProblem = false;
BaseGame.Situation_Law_BludishReconciliation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Law_BludishOppression"] = true;
Variable["BaseGame.Situation_Law_BludishProblem"] = false;
Variable["BaseGame.Situation_Law_BludishReconciliation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lileas Graf: "“Come on Karl. We are leaving.”"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true"*)
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == false ||..."*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_SollistRayne == true"*)
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_SollistRayne == true)"*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_SollistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_SollistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_SollistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_SollistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_CapitalistRayne == true"*)
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_CapitalistRayne == true)"*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_CapitalistRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_CapitalistRayne"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The report was titled 'Violent Protests in Major Cities'...."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_CapitalistRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_CapitalistRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Narrator: "The report was titled 'Protests in Major Cities'. I looke..."*)

### Węzeł `[644]`
Mówca: **Lileas Graf**
> "“Anti-communism protests have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[645]`
Mówca: **Lileas Graf**
> "“Protests against your emergency have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“They seem to be anti-Sollist in nature.”"*)

### Węzeł `[646]`
Mówca: **Lileas Graf**
> "“Protests against your emergency have been erupting all over Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Lileas Graf: "“They are protesting you, Mr. President.”"*)

### Węzeł `[647]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[648]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)
  - -> `[650]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true)"*)

### Węzeł `[649]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Lileas Graf: "“People have died, Mr. Rayne. Freedom of speech no longer..."*)

### Węzeł `[650]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lileas Graf: "“I'm afraid soon they might start doing more than just sa..."*)

### Węzeł `[651]`
Mówca: **Lileas Graf**
> "“People have died, Mr. Rayne. Freedom of speech no longer applies.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: "“What does the protester profile look like?”"*)

### Węzeł `[652]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[653]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[654]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[655]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[656]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[657]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[658]`
Mówca: **Narrator**
> "Just then, there was a loud knock on the door. Karl came in without waiting for an answer. He was clearly out of breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Lileas Graf: "“Ah, there he is.”"*)

### Węzeł `[659]`
Mówca: **Narrator**
> "He followed after her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "BaseGame.Security_Unrest_Military == true"*)

### Węzeł `[660]`
Mówca: **Narrator**
> "Lileas hurriedly left the room. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[661]`
Mówca: **Narrator**
> "Lileas hurriedly left the room. Karl bowed to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Karl Greiser: "“Mr. President.”"*)

### Węzeł `[662]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[663]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[664]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[663]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[664]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[665]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Lileas Graf: "“Good call. We need to end this farce once and for all.”"*)

### Węzeł `[666]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Karl Greiser: "“I will keep you updated on the results.”"*)

### Węzeł `[667]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[669]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[668]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Karl Greiser: "“Yes, sir.”"*)

### Węzeł `[669]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Karl Greiser: "“Yes, sir.”"*)

### Węzeł `[670]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[672]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[671]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[672]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[674]` (*Karl Greiser: "“As you command, Mr. President.”"*)

### Węzeł `[673]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Karl Greiser: "“I will keep you updated on the results.”"*)

### Węzeł `[674]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Lileas Graf: "“Good call. We need to end this farce once and for all.”"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[677]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Karl Greiser: "“Yes, sir.”"*)

### Węzeł `[677]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Karl Greiser: "“Yes, sir.”"*)

### Węzeł `[678]`
Mówca: **Karl Greiser**
> "“As you command, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Lileas Graf: "“Good call. We need to end this farce once and for all.”"*)

### Węzeł `[679]`
Mówca: **Karl Greiser**
> "“Yes, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Karl Greiser: "“I will keep you updated on the results.”"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)
  - -> `[682]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true)"*)

### Węzeł `[681]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 1; BaseGame.Sollist += 1;"*)

### Węzeł `[682]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true"*)

### Węzeł `[683]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[684]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Peaceful_Happened == true"*)
  - -> `[685]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Peaceful_Happened == true)"*)

### Węzeł `[684]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Peaceful_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Peaceful_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 5; BaseGame.Sollist += 1;"*)

### Węzeł `[685]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Peaceful_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Peaceful_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1;"*)

### Węzeł `[686]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 5;
BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 5;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[687]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[688]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_Violent_Happened == true"*)
  - -> `[690]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_Violent_Happened == true)"*)

### Węzeł `[689]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_Violent_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_Violent_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 5; BaseGame.Sollist += 2;"*)

### Węzeł `[690]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_Violent_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_Violent_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 3; BaseGame.Sollist += 2;"*)

### Węzeł `[691]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 3;
BaseGame.Sollist += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 3;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[692]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true"*)
  - -> `[694]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true)"*)

### Węzeł `[693]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 2; BaseGame.Sollist -= 5;"*)

### Węzeł `[694]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 2; BaseGame.Sollist -= 1;"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 2;
BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 2;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[696]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[698]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[698]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Karl Greiser: "“As you command.”"*)

### Węzeł `[699]`
Mówca: **Karl Greiser**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lileas Graf: "“It's good to see that we are taking immediate action.”"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[703]` (*Lileas Graf: "“What? You cannot use the Sordish Armed Forces inside our..."*)

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Lileas Graf: "“What? You cannot use the Sordish Armed Forces inside our..."*)

### Węzeł `[703]`
Mówca: **Lileas Graf**
> "“What? You cannot use the Sordish Armed Forces inside our borders. That is against the constitution.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[554]` (*Player: "“I will sign a presidential decree, giving them authoriza..."*)
  - -> `[555]` (*Player: "“Watch me.""*)

### Węzeł `[704]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[706]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[705]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Lileas Graf: "“With a simultaneous attack, the Bludish terrorists have ..."*)

### Węzeł `[706]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Lileas Graf: "“With a simultaneous attack, the Bludish terrorists have ..."*)

### Węzeł `[707]`
Mówca: **Lileas Graf**
> "“With a simultaneous attack, the Bludish terrorists have raided the governor's office in Deyr and kidnapped Governor Bron.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lileas Graf: "“They are holding him hostage as well.”"*)

### Węzeł `[708]`
Mówca: **Lileas Graf**
> "“With a simultaneous attack, the Bludish terrorists have raided the governor's office in Deyr and kidnapped Governor Krull.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lileas Graf: "“They are holding him hostage as well.”"*)

### Węzeł `[709]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[711]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[710]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lileas Graf: "“I'm afraid that's not all.”"*)

### Węzeł `[711]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lileas Graf: "“Karl Greiser is on his way here right now. He will tell ..."*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "'President Rayne. In the name of peace, we have taken hol..."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "'President Rayne. In the name of peace, we have taken hol..."*)

### Węzeł `[715]`
Mówca: **Narrator**
> "'President Rayne. In the name of peace, we have taken hold of the Soll Dam.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "'The free people of Bludia have suffered enough under the..."*)

### Węzeł `[716]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_..."*)
  - -> `[718]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergi..."*)

### Węzeł `[717]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "'If our demands are not met, we will cut off electricity ..."*)

### Węzeł `[718]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[719]` (*Narrator: "'If our demands are not met, we will cut off electricity ..."*)

### Węzeł `[719]`
Mówca: **Narrator**
> "'If our demands are not met, we will cut off electricity to the entirety of the Bergia and Nargis regions.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "'Take this as your final warning.'"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[722]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Lileas Graf: "“Mr. President, the BFF is a threat against our nation. O..."*)

### Węzeł `[722]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[723]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[725]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[724]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Lileas Graf: "“Mr. President, the BFF is a threat against our nation. W..."*)

### Węzeł `[725]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lileas Graf: "“Mr. President, the BFF is a threat against our nation. T..."*)

### Węzeł `[726]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. We had the chance to eradicate their leadership but not taking that chance resulted in this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Lileas Graf: ""We have to destroy them.""*)

### Węzeł `[727]`
Mówca: **Lileas Graf**
> ""We have to destroy them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player: "“We will not negotiate with terrorists.”"*)
  - -> `[191]` (*Player: "“No. We need to approach this diplomatically. We will do ..."*)

### Węzeł `[728]`
Mówca: **Lileas Graf**
> "“Mr. President, the BFF is a threat against our nation. Our failure in eliminating their leadership must have emboldened them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Lileas Graf: ""We have to destroy them.""*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Węzeł Logiki Narracyjnej: "// Continue"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated == false ||..."*)
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Order_BFF_ThreatEliminated == false ..."*)

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == false  or  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "The report was titled 'BFF Attack on Soll Dam'. I looked ..."*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Order_BFF_ThreatEliminated == false || BaseGame.Policy_Law_SpecialZoneOfBergia == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] == false  or  Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
