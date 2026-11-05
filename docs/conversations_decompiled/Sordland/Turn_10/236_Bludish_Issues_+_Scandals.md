# Sordland/Turn10/Bludish Issues + Scandals

- **ID konwersacji:** `236`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Sordland/Turn_10/236_Bludish_Issues_+_Scandals.md`
- **Liczba węzłów dialogowych:** 382
- **Liczba wyborów gracza:** 47

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[12]** Moderator
- **[15]** Mansoun Leke
- **[16]** Manoly Suheil
- **[22]** Denis Stahler
- **[32]** Frens Ricter
- **[44]** Lileas Graf
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Bill_Turn09_BludishCommission_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn03_Extraction_AddressProtestors`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Democratic`
- `BaseGame.Faction_NFP_Destroyed`
- `BaseGame.Faction_PFJP_Destroyed`
- `BaseGame.Killed_MarcelKoronti`
- `BaseGame.LeakedScandal_AlbinClavin_Bribe`
- `BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP`
- `BaseGame.LeakedScandal_FrensRicter_Bribe`
- `BaseGame.LeakedScandal_FrensRicter_TaurusBribe`
- `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal`
- `BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation`
- `BaseGame.LeakedScandal_PrivatizationShares_Both`
- `BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti`
- `BaseGame.LeakedScandal_PrivatizationShares_WalterTusk`
- `BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses`
- `BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp`
- `BaseGame.LeakedScandal_WalterTusk_UnderhallBribe`
- `BaseGame.LeakedScandals_Severity`
- `BaseGame.Malenyevist`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.NoUnrest_Mansoun_Deal_Failed`
- `BaseGame.Policy_Law_Threshold_15`
- `BaseGame.Policy_Law_Threshold_Default`
- `BaseGame.Reform_Alliance_PFJP`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.Situation_Law_BludishProblem`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Situation_Law_MediaCensored`
- `BaseGame.Turn03_A_Protestors_Calm`
- `BaseGame.Turn07_SecretState_Kill_OrsoHawker`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk`
- `BaseGame.Unrest_BFF_Deal_Failed`
- `BaseGame.Unrest_BFF_Deal_Signed`
- `BaseGame.Unrest_BFF_Happened`
- `BaseGameIsolated.Debate_Enable_FrensRicter`
- `BaseGameIsolated.Debate_Enable_KesaroKibener`
- `BaseGameIsolated.Debate_Enable_LileasGraf`
- `BaseGameIsolated.Debate_Enable_ManolySuheil`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameIsolated.Debate_Enable_RemusHolstron`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn10_A_NumberOfResignations`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Debate_DenisChallenge`
- `BaseGameIsolated.Debate_Enable_DenisStahler`
- `BaseGameIsolated.Debate_Enable_MansounLeke`
- `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted`
- `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[238] Sordland/Turn10/Election + closing statements** (../Turn_10/238_Election_+_closing_statements.md), Węzeł `[1]`
- Węzeł `[10]` -> **[237] Sordland/Turn10/Denis Challenge** (../Turn_10/237_Denis_Challenge.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **""I'm proud to say that under my administration, the Bludish community has been giv..."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5` | *Brak zmian stanu* | `[39]` **Narrator**: "Mansoun shook his head sadly."<br>`[61]` **Denis Stahler**: ""How dare you say that, Mr. Pres..." |
| `[9]` | **""The work I've done to further the Bludish cause was just the beginning. We still ..."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5` | *Brak zmian stanu* | `[25]` **Narrator**: "Mansoun smiled."<br>`[61]` **Denis Stahler**: ""How dare you say that, Mr. Pres..." |
| `[11]` | **""The events of the past four years have proven that peaceful coexistence between S..."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false` | *Brak zmian stanu* | `[62]` **Narrator**: "Mansoun struggled to stay calm."<br>`[61]` **Denis Stahler**: ""How dare you say that, Mr. Pres..." |
| `[12]` | **""Yes, we will all work together.""** | `[8]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>`[27]` **Manoly Suheil**: ""I will work with the WPB to ens..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Denis Stahler**: ""We all know how well you two wo..."<br>`[156]` **Moderator**: ""I believe it's time to move on ..."<br>*(oraz 2 innych odgałęzień)* |
| `[13]` | **""I'd like to yield the floor to Mr. Leke.""** | `[6]` **Moderator**: ""That brings me to my next quest..." | `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`<br>`Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5` | *Brak zmian stanu* | `[25]` **Narrator**: "Mansoun smiled."<br>`[61]` **Denis Stahler**: ""How dare you say that, Mr. Pres..." |
| `[14]` | **""I have shown nothing but kindness towards the Bluds, and they have reacted only w..."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false` | *Brak zmian stanu* | `[62]` **Narrator**: "Mansoun struggled to stay calm."<br>`[61]` **Denis Stahler**: ""How dare you say that, Mr. Pres..." |
| `[15]` | **"Signal to the moderator to skip this question."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true` | *Brak zmian stanu* | `[10]` **Moderator**: ""Ah. Um, right. Onto the next qu..." |
| `[19]` | **"Say nothing."** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Moderator**: ""You've gone over your speaking ..."<br>`[155]` **Moderator**: ""You've gone over your speaking ..."<br>*(oraz 1 innych odgałęzień)* |
| `[20]` | **""I have no problem with the Bludish community as long as they make an effort to in..."** | `[6]` **Moderator**: ""That brings me to my next quest..." | `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`<br>`(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false` | *Brak zmian stanu* | `[59]` **Narrator**: "Mansoun struggled to stay calm." |
| `[21]` | **""Thousands suffered under Soll. We cannot go back to that.""** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Lileas Graf**: ""No. I disagreed with certain of..." |
| `[22]` | **""You, ma'am, are no Tarquin Soll.""** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[144]` **Lileas Graf**: ""No. I disagreed with certain of..." |
| `[23]` | **""He's in prison, Lileas. For a reason.""** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`<br>`(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false` | *Brak zmian stanu* | `[143]` **Lileas Graf**: ""That's exactly what I mean. Suc..." |
| `[24]` | **""He's dead, Lileas. For a reason.""** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` | *Brak zmian stanu* | `[143]` **Lileas Graf**: ""That's exactly what I mean. Suc..." |
| `[40]` | **""Good luck getting the Assembly to agree on that.""** | `[8]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>`[26]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Denis Stahler**: ""Look at you lovebirds, pretendi..."<br>`[156]` **Moderator**: ""I believe it's time to move on ..."<br>*(oraz 2 innych odgałęzień)* |
| `[65]` | **""Negotiating with terrorists. A dangerous mistake.""** | `[26]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>`[37]` **Manoly Suheil**: ""I will work with the WPB to ens..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Denis Stahler**: ""Look at you lovebirds, pretendi..."<br>`[156]` **Moderator**: ""I believe it's time to move on ..."<br>*(oraz 2 innych odgałęzień)* |
| `[117]` | **"Say nothing."** | `[8]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>`[26]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Moderator**: ""I believe it's time to move on ..."<br>`[279]` **Lileas Graf**: ""Gentlemen. Ms. Suheil.""<br>*(oraz 1 innych odgałęzień)* |
| `[119]` | **""Your so-called democracy will result in the Bludish people losing the rights I ha..."** | `[8]` **Frens Ricter**: ""I will work with the WPB to ens..."<br>`[27]` **Manoly Suheil**: ""I will work with the WPB to ens..." | `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true` | *Brak zmian stanu* | `[115]` **Denis Stahler**: ""Look at you lovebirds, pretendi..."<br>`[156]` **Moderator**: ""I believe it's time to move on ..."<br>*(oraz 2 innych odgałęzień)* |
| `[142]` | **""What are you talking about? I've made Sordland more stable than ever.""** | `[49]` **Lileas Graf**: ""It isn't too late to go back to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Lileas Graf**: ""Your willingness to rebel again..." |
| `[164]` | **""Nothing but a smear campaign to prevent my re-election.""** | `[146]` **Moderator**: ""This seems a good enough a time..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Denis Stahler**: ""What does the esteemed head of ..."<br>`[190]` **Lileas Graf**: ""I wonder what your vice preside..." |
| `[165]` | **""Compared to the blatant corruption of my predecessors, I'd say I'm doing pretty w..."** | `[146]` **Moderator**: ""This seems a good enough a time..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Denis Stahler**: ""What does the esteemed head of ..."<br>`[190]` **Lileas Graf**: ""I wonder what your vice preside..." |
| `[166]` | **""The mistakes I made were those of a young and inexperienced president. They will ..."** | `[146]` **Moderator**: ""This seems a good enough a time..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Denis Stahler**: ""What does the esteemed head of ..."<br>`[190]` **Lileas Graf**: ""I wonder what your vice preside..." |
| `[167]` | **""I refuse to comment on said allegations at this time.""** | `[146]` **Moderator**: ""This seems a good enough a time..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Denis Stahler**: ""What does the esteemed head of ..."<br>`[190]` **Lileas Graf**: ""I wonder what your vice preside..." |
| `[200]` | **""I was pressured into those actions by individuals who have since resigned.""** | `[190]` **Lileas Graf**: ""I wonder what your vice preside..."<br>`[191]` **Lileas Graf**: ""I wonder what certain oligarchs..."<br>*(oraz 6 innych węzłów)* | `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0` | `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDeb...` | `[225]` **Moderator**: ""Ahem... it's time we moved on a..." |
| `[212]` | **""My press spokesperson has already issued a statement regarding the innocent misun..."** | `[190]` **Lileas Graf**: ""I wonder what your vice preside..."<br>`[199]` **Frens Ricter**: ""I wonder what your vice preside..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDeb...` | `[225]` **Moderator**: ""Ahem... it's time we moved on a..." |
| `[213]` | **""I will remember your lack of loyalty during my next term.""** | `[177]` **Frens Ricter**: ""My press spokesperson has alrea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[214]` | **""You liar! You practically begged me for that check.""** | `[177]` **Frens Ricter**: ""My press spokesperson has alrea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[215]` | **""This is politics. You know the saying: You've got to kill the cow to make the zab..."** | `[177]` **Frens Ricter**: ""My press spokesperson has alrea..."<br>`[190]` **Lileas Graf**: ""I wonder what your vice preside..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[216]` | **""Thank you, Frens.""** | `[173]` **Frens Ricter**: ""My press spokesperson has alrea..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDeb...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[217]` | **"Say nothing."** | `[173]` **Frens Ricter**: ""My press spokesperson has alrea..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDeb...` | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[218]` | **""Is this a debate or a witch hunt? Can we move on?""** | `[177]` **Frens Ricter**: ""My press spokesperson has alrea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[220]` | **""Is this a debate or a witch hunt? Can we move on?""** | `[190]` **Lileas Graf**: ""I wonder what your vice preside..."<br>`[191]` **Lileas Graf**: ""I wonder what certain oligarchs..."<br>*(oraz 7 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[222]` | **""Shut up, all of you! I am your President!""** | `[219]` **Narrator**: "The other candidates tittered." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDeba...` | `[225]` **Moderator**: ""Ahem... it's time we moved on a..." |
| `[223]` | **""MODERATOR! Next question!""** | `[219]` **Narrator**: "The other candidates tittered." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDeba...` | `[225]` **Moderator**: ""Ahem... it's time we moved on a..." |
| `[224]` | **"Say nothing."** | `[219]` **Narrator**: "The other candidates tittered." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDeba...` | `[225]` **Moderator**: ""Ahem... it's time we moved on a..." |
| `[226]` | **""Stop that high-and-mighty act. I know who you really are.""** | `[221]` **Lileas Graf**: ""I was a part of the administrat..."<br>`[227]` **Frens Ricter**: ""Rest assured the PFJP is commit..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Narrator**: "The other candidates tittered." |
| `[302]` | **""Denis, I have nothing but admiration for you and your ideology. Please do not tes..."** | `[329]` **Narrator**: "The studio went deathly silent." | `Variable["BaseGame.Malenyevist"] > 15` | *Brak zmian stanu* | `[298]` **Denis Stahler**: ""Admiration? You had me thrown i..."<br>`[347]` **Narrator**: "Denis gaped at me indignantly, t..." |
| `[307]` | **""The Red Youth was out of control. You should have done something.""** | `[298]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Denis Stahler**: ""They're more violent than they ..." |
| `[315]` | **""Don't make me do it again.""** | `[298]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Narrator**: "Denis sat, his face red. None of..." |
| `[317]` | **""I didn't give that order.""** | `[298]` **Denis Stahler**: ""Admiration? You had me thrown i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Denis Stahler**: ""Abdicating responsibility. A go..." |
| `[327]` | **""Leave this building. Now.""** | `[343]` **Denis Stahler**: ""I--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Denis Stahler**: ""Gladly."" |
| `[331]` | **""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely fo..."** | `[329]` **Narrator**: "The studio went deathly silent." | `Variable["BaseGame.Democratic"] < -10` | *Brak zmian stanu* | `[353]` **Narrator**: "Denis paled slightly." |
| `[332]` | **""Sit back down. Now.""** | `[343]` **Denis Stahler**: ""I--"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Narrator**: "Denis sat, his face red. None of..." |
| `[333]` | **""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""** | `[329]` **Narrator**: "The studio went deathly silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Denis Stahler**: ""Gladly."" |
| `[342]` | **""I have no idea what you're talking about.""** | `[329]` **Narrator**: "The studio went deathly silent." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Denis Stahler**: ""The hell you do."" |
| `[345]` | **""If I was censoring the media, would I permit you to make this kind of scene?""** | `[341]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Narrator**: "Denis gaped at me indignantly, t..." |
| `[346]` | **""Whatever you think you know about me, it's a lie.""** | `[341]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Denis Stahler**: ""I won't play this game a second..." |
| `[348]` | **""Guards, this man is a danger to me. Please escort him out of the building at once.""** | `[341]` **Denis Stahler**: ""The hell you do."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Denis Stahler**: ""I'll find my own way out."" |

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
  - -> `[6]` (*Moderator: ""That brings me to my next question. What about the statu..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true || B..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishReconciliation == true ||..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: ""I'm proud to say that under my administration, the Bludi..."*)
  - -> `[9]` (*Player: ""The work I've done to further the Bludish cause was just..."*)
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Bludish_Opinion >= 5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[14]` (*Player: ""I have shown nothing but kindness towards the Bluds, and..."*)
  - -> `[11]` (*Player: ""The events of the past four years have proven that peace..."*)

### Węzeł `[6]`
Mówca: **Moderator**
> ""That brings me to my next question. What about the status of Sordland's minorities? I'm speaking particularly about the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true || B..."*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I'm proud to say that under my administration, the Bludish community has been given a voice.""]** — Mówca: **Player**
> ""I'm proud to say that under my administration, the Bludish community has been given a voice.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[8]`
Mówca: **Frens Ricter**
> ""I will work with the WPB to ensure the Bludish people get the equal status they have been denied for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""Yes, we will all work together.""*)
  - -> `[40]` (*Player: ""Good luck getting the Assembly to agree on that.""*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true || ..."*)
  - -> `[117]` (*Player_Italic: "Say nothing."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""The work I've done to further the Bludish cause was just the beginning. We still have a long way to go.""]** — Mówca: **Player**
> ""The work I've done to further the Bludish cause was just the beginning. We still have a long way to go.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[10]`
Mówca: **Moderator**
> ""Ah. Um, right. Onto the next question--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: ""The events of the past four years have proven that peaceful coexistence between Sords and Bluds is a mere pipe dream.""]** — Mówca: **Player**
> ""The events of the past four years have proven that peaceful coexistence between Sords and Bluds is a mere pipe dream.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: ""Yes, we will all work together.""]** — Mówca: **Player**
> ""Yes, we will all work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Frens Ricter), `[27]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I'd like to yield the floor to Mr. Leke.""]** — Mówca: **Player**
> ""I'd like to yield the floor to Mr. Leke.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true` AND `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""I have shown nothing but kindness towards the Bluds, and they have reacted only with violence.""]** — Mówca: **Player**
> ""I have shown nothing but kindness towards the Bluds, and they have reacted only with violence.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Signal to the moderator to skip this question."]** — Mówca: **Player_Italic**
> "I signaled to the moderator to move on."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Moderator: ""Ah. Um, right. Onto the next question--""*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""I have no problem with the Bludish community as long as ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[19]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I have no problem with the Bludish community as long as they make an effort to integrate into Sordish society. Like Mr. Leke here.""]** — Mówca: **Player**
> ""I have no problem with the Bludish community as long as they make an effort to integrate into Sordish society. Like Mr. Leke here.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true` AND `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Bludish_Opinion"] >= 5) == false`
- **Kontekst wejściowy (poprzednik):** `[6]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Mansoun struggled to stay calm."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""Thousands suffered under Soll. We cannot go back to that.""]** — Mówca: **Player**
> ""Thousands suffered under Soll. We cannot go back to that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lileas Graf: ""No. I disagreed with certain of the Colonel's more bruta..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA: ""You, ma'am, are no Tarquin Soll.""]** — Mówca: **Player**
> ""You, ma'am, are no Tarquin Soll.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Lileas Graf: ""No. I disagreed with certain of the Colonel's more bruta..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: ""He's in prison, Lileas. For a reason.""]** — Mówca: **Player**
> ""He's in prison, Lileas. For a reason.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true` AND `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lileas Graf: ""That's exactly what I mean. Such a rash and vindictive d..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA: ""He's dead, Lileas. For a reason.""]** — Mówca: **Player**
> ""He's dead, Lileas. For a reason.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Lileas Graf: ""That's exactly what I mean. Such a rash and vindictive d..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "Mansoun smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true || B..."*)

### Węzeł `[26]`
Mówca: **Frens Ricter**
> ""I will work with the WPB to ensure the Bludish people get the representation he has denied them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Negotiating with terrorists. A dangerous mistake.""*)
  - -> `[40]` (*Player: ""Good luck getting the Assembly to agree on that.""*)
  - -> `[117]` (*Player_Italic: "Say nothing."*)

### Węzeł `[27]`
Mówca: **Manoly Suheil**
> ""I will work with the WPB to ensure the Bludish people get the equal status they have been denied for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Player: ""Yes, we will all work together.""*)
  - -> `[40]` (*Player: ""Good luck getting the Assembly to agree on that.""*)
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true || ..."*)
  - -> `[117]` (*Player_Italic: "Say nothing."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "Mansoun struggled to stay calm."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Denis Stahler: ""How dare you say that, Mr. President?""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player: ""He's in prison, Lileas. For a reason.""*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: ""You, ma'am, are no Tarquin Soll.""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: ""He's dead, Lileas. For a reason.""*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)

### Węzeł `[37]`
Mówca: **Manoly Suheil**
> ""I will work with the WPB to ensure the Bludish people get the representation he has denied them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: ""Negotiating with terrorists. A dangerous mistake.""*)
  - -> `[40]` (*Player: ""Good luck getting the Assembly to agree on that.""*)
  - -> `[117]` (*Player_Italic: "Say nothing."*)

### Węzeł `[38]`
Mówca: **Mansoun Leke**
> ""The BFF and the Bludish people are not one and the same.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Mansoun Leke: ""But a radical response was inevitable given the way the ..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "Mansoun shook his head sadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true || B..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Good luck getting the Assembly to agree on that.""]** — Mówca: **Player**
> ""Good luck getting the Assembly to agree on that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Frens Ricter), `[26]` (Frens Ricter), `[27]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishReconciliation == true || B..."*)
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishReconciliation == true ||..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Mansoun Leke: ""President Rayne was only able to grant the Bludish peopl..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishReconciliation == true || BaseGame.Unrest_BFF_Deal_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Mansoun Leke: ""President Rayne has proven himself a more tolerant leade..."*)

### Węzeł `[44]`
Mówca: **Frens Ricter**
> ""It is true that President Rayne has only stoked the fires of xenophobia in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Frens Ricter: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[45]`
Mówca: **Frens Ricter**
> ""As you can tell, xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Frens Ricter: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Italic: "Signal to the moderator to skip this question."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
Mówca: **Lileas Graf**
> ""It isn't too late to go back to the way things were. Under the USP, the glorious republic envisioned by Tarquin Soll can still become a reality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn09_SollTrial_Guilty_Death == true"*)
  - -> `[21]` (*Player: ""Thousands suffered under Soll. We cannot go back to that.""*)
  - -> `[142]` (*Player: ""What are you talking about? I've made Sordland more stab..."*)
  - -> `[19]` (*Player_Italic: "Say nothing."*)

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""We talk about safety when our country is facing conditions of insurgency?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "His eyes focused on him."*)

### Węzeł `[51]`
Mówca: **Remus Holstron**
> ""Safe? Safe?!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "His eyes were practically bulging."*)

### Węzeł `[52]`
Mówca: **Mansoun Leke**
> ""Mr. President, I won't allow you to bring me into this. Not after the way our last talk ended.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  B..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnr..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoU..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Mansoun Leke: ""Mr. President, I won't allow you to bring me into this. ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnrest_Mansoun_Deal_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Deal_Failed"] == true  or  Variable["BaseGame.NoUnrest_Mansoun_Deal_Failed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Mansoun Leke: ""Mr. President, I won't allow you to bring me into this. ..."*)

### Węzeł `[56]`
Mówca: **Manoly Suheil**
> ""As you can tell, xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Manoly Suheil: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[57]`
Mówca: **Mansoun Leke**
> ""Mr. President, I won't allow you to bring me into this. Not after the way you've treated my compatriots.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  B..."*)

### Węzeł `[58]`
Mówca: **Lileas Graf**
> ""To speak more generally, haven't we all had enough of upheaval? Of promises of radical change? Of having to check newspaper headlines daily to be sure our country is still intact?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lileas Graf: ""It isn't too late to go back to the way things were. Und..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Mansoun struggled to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Deal_Failed == true || BaseGame.NoUnr..."*)

### Węzeł `[60]`
Mówca: **Manoly Suheil**
> ""It is true that President Rayne has only stoked the fires of xenophobia in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Manoly Suheil: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[61]`
Mówca: **Denis Stahler**
> ""How dare you say that, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Denis Stahler: ""The absence of the WPB in this studio speaks louder than..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "Mansoun struggled to stay calm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Mansoun Leke: ""The BFF and the Bludish people are not one and the same.""*)

### Węzeł `[63]`
Mówca: **Denis Stahler**
> ""The absence of the WPB in this studio speaks louder than your lies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (B..."*)

### Węzeł `[64]`
Mówca: **Mansoun Leke**
> ""President Rayne was only able to grant the Bludish people a small modicum of justice by exercising his executive powers. This has not magically erased centuries of anti-Bludish sentiment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (B..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Negotiating with terrorists. A dangerous mistake.""]** — Mówca: **Player**
> ""Negotiating with terrorists. A dangerous mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[26]` (Frens Ricter), `[37]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)

### Węzeł `[66]`
Mówca: **Mansoun Leke**
> ""President Rayne has proven himself a more tolerant leader than his predecessors, but anti-Bludish sentiment remains deeply ingrained in our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (B..."*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> ""Surely there's a compromise between meeting the demands of violent militants and oppressing innocent civilians in a way that only incites further violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lileas Graf: ""To speak more generally, haven't we all had enough of up..."*)

### Węzeł `[68]`
Mówca: **Manoly Suheil**
> ""I'll spare you viewers another of the NFP's racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true || BaseG..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The moderator hurriedly flipped a few pages ahead in her notepad."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Moderator: ""This seems a good enough a time as any to bring up the a..."*)

### Węzeł `[70]`
Mówca: **Denis Stahler**
> ""As long as this man is in office, Bludish citizens in Sordland will never be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[71]`
Mówca: **Moderator**
> ""Unsubstantiated rumors have no place in this debate, Mr. Stahler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Denis Stahler: ""I cannot fucking believe this!""*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Kesaro Kibener: ""We talk about safety when our country is facing conditio..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Remus Holstron: ""Safe? Safe?!""*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn09_BludishCommission_Signed == true || ..."*)
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn09_BludishCommission_Signed == true |..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player: ""Your so-called democracy will result in the Bludish peop..."*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn09_BludishCommission_Signed == true || BaseGame.Unrest_BFF_Deal_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[81]`
Mówca: **Remus Holstron**
> ""It's the President's job to look after the safety of the Sordish people, and that's exactly what he has done. Although, of course, I believe more extreme actions must be taken--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""It's the President's job to look after the safety of the Sordish people, and that's exactly what he has done. Although, of course, I believe more safety measures could have been taken--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[83]`
Mówca: **Mansoun Leke**
> ""But a radical response was inevitable given the way the President continued the oppressive policies of his predecessors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  B..."*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Lileas' voice was syrupy-sweet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lileas Graf: ""Surely there's a compromise between meeting the demands ..."*)

### Węzeł `[85]`
Mówca: **Mansoun Leke**
> ""As long as this man remains in office, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Moderator: ""Unsubstantiated rumors have no place in this debate, Mr...."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The moderator hurriedly flipped a few pages ahead in her ..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true || BaseG..."*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true || Bas..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true  or  Variable["BaseGame.Situation_Law_BludishProblem"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Manoly Suheil: ""It is true that President Rayne has only stoked the fire..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true || BaseGame.Situation_Law_BludishProblem == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true  or  Variable["BaseGame.Situation_Law_BludishProblem"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Manoly Suheil: ""As you can tell, xenophobia is alive and well in Sordlan..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Frens Ricter: ""It is true that President Rayne has only stoked the fire..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Frens Ricter: ""As you can tell, xenophobia is alive and well in Sordlan..."*)

### Węzeł `[95]`
Mówca: **Lileas Graf**
> ""Gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Lileas' voice was syrupy-sweet."*)

### Węzeł `[96]`
Mówca: **Denis Stahler**
> ""Well? Nobody else is going to address the allegations of bribery and corruption between Rayne and Ricter here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[97]`
Mówca: **Mansoun Leke**
> ""Electing Sordland's first leader of Bludish descent would help to create a bridge of lasting peace between our communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[98]`
Mówca: **Remus Holstron**
> ""What about the governor's safety? What about the Soll Dam employees? The Bludish scum cannot be trusted to--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[99]`
Mówca: **Kesaro Kibener**
> ""What about the governor's safety? What about the Soll Dam employees? The Bludish people must recognize that this isn't right--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_KesaroKibener == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Kesaro Kibener: ""For someone who is against the different treatment of ra..."*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_KesaroKibener == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_KesaroKibener"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_RemusHolstron == true"*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Remus Holstron: ""No. No!""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil"*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil)"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "Manoly smoothly cut in."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Moderator: ""I believe it's time to move on to another subject.""*)

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""For someone who is against the different treatment of races you seem to put one race ahead of the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "His eyes focused on him."*)

### Węzeł `[113]`
Mówca: **Denis Stahler**
> ""We all know how well you two work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Denis Stahler: ""Well? Nobody else is going to address the allegations of..."*)

### Węzeł `[114]`
Mówca: **Remus Holstron**
> ""No. No!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "His eyes were practically bulging."*)

### Węzeł `[115]`
Mówca: **Denis Stahler**
> ""Look at you lovebirds, pretending to bicker.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Denis Stahler: ""Well? Nobody else is going to address the allegations of..."*)

### Węzeł `[116]`
Mówca: **Frens Ricter**
> ""I'll spare you viewers another of the NFP's racist tirades.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I sat back and said nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Frens Ricter), `[26]` (Frens Ricter), `[27]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[118]`
Mówca: **Narrator**
> "His eyes focused on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_P..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""Your so-called democracy will result in the Bludish people losing the rights I have won for them.""]** — Mówca: **Player**
> ""Your so-called democracy will result in the Bludish people losing the rights I have won for them.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Bill_Turn09_BludishCommission_Signed"] == true  or  Variable["BaseGame.Unrest_BFF_Deal_Signed"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Frens Ricter), `[27]` (Manoly Suheil)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "His eyes were practically bulging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_P..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "Manoly smoothly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Manoly Suheil: ""I'll spare you viewers another of the NFP's racist tirad..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "His eyes focused on him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Kesaro Kibener: ""Sordland must be led by capable people who understand an..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "His eyes were practically bulging."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Remus Holstron: ""Sordland must be led by a maroon-blooded Sord, as has be..."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_FrensRicter_Bribe == true || Ba..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Denis Stahler: ""We all know how well you two work together.""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "Frens smoothly cut in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Frens Ricter: ""I'll spare you viewers another of the NFP's racist tirad..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true || Base..."*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_FrensRicter_Bribe == true || Ba..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Denis Stahler: ""Look at you lovebirds, pretending to bicker.""*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_FrensRicter_Bribe == true || BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "Frens smoothly cut in."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil"*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_P..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Kesaro Kibener: ""What about the governor's safety? What about the Soll Da..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Kesaro Kibener: ""It's the President's job to look after the safety of the..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_P..."*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Remus Holstron: ""What about the governor's safety? What about the Soll Da..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_Happened == true && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_Happened"] == true  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Remus Holstron: ""It's the President's job to look after the safety of the..."*)

### Węzeł `[140]`
Mówca: **Kesaro Kibener**
> ""Sordland must be led by capable people who understand and can represent the majority of the population. This has been the case since our great country was founded. I find it very dangerous that merits are thrown out of the window in support of an agenda. A blinded thought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[141]`
Mówca: **Remus Holstron**
> ""Sordland must be led by a maroon-blooded Sord, as has been the case since our great country was founded. It's exactly this kind of dangerous talk that proves why the Bludish question must be solved once and for--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[142]`
**[WYBÓR GRACZA: ""What are you talking about? I've made Sordland more stable than ever.""]** — Mówca: **Player**
> ""What are you talking about? I've made Sordland more stable than ever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Lileas Graf: ""Your willingness to rebel against the wishes of your own..."*)

### Węzeł `[143]`
Mówca: **Lileas Graf**
> ""That's exactly what I mean. Such a rash and vindictive decision from an acting president. Is this what Sordland wants?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)

### Węzeł `[144]`
Mówca: **Lileas Graf**
> ""No. I disagreed with certain of the Colonel's more brutally oppressive policies. I shall bring Soll's core values into a more enlightened, morally correct administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)

### Węzeł `[145]`
Mówca: **Lileas Graf**
> ""Your willingness to rebel against the wishes of your own party means you cannot be trusted as a leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)

### Węzeł `[146]`
Mówca: **Moderator**
> ""This seems a good enough a time as any to bring up the allegations that President Rayne has abused his power while in office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: ""Nothing but a smear campaign to prevent my re-election.""*)
  - -> `[165]` (*Player: ""Compared to the blatant corruption of my predecessors, I..."*)
  - -> `[166]` (*Player: ""The mistakes I made were those of a young and inexperien..."*)
  - -> `[167]` (*Player: ""I refuse to comment on said allegations at this time.""*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Moderator: ""You've gone over your speaking time, Ms. Graf.""*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Moderator: ""This seems a good enough a time as any to bring up the a..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity >= 1)"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Moderator: ""You've gone over your speaking time, Ms. Graf.""*)

### Węzeł `[153]`
Mówca: **Moderator**
> ""You've gone over your speaking time, Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lileas neatly folded her arms and sat back in her chair."*)

### Węzeł `[154]`
Mówca: **Narrator**
> "Lileas neatly folded her arms and sat back in her chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[155]`
Mówca: **Moderator**
> ""You've gone over your speaking time, Ms. Graf.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "Lileas neatly folded her arms and sat back in her chair."*)

### Węzeł `[156]`
Mówca: **Moderator**
> ""I believe it's time to move on to another subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "She hurriedly flipped through her notes."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "She hurriedly flipped through her notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandals_Severity >= 1"*)
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandals_Severity >= 1)"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandals_Severity >= 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandals_Severity"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandals_Severity >= 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandals_Severity"] >= 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Moderator: ""This seems a good enough a time as any to bring up the a..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""Nothing but a smear campaign to prevent my re-election.""]** — Mówca: **Player**
> ""Nothing but a smear campaign to prevent my re-election.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseG..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""Compared to the blatant corruption of my predecessors, I'd say I'm doing pretty well for myself.""]** — Mówca: **Player**
> ""Compared to the blatant corruption of my predecessors, I'd say I'm doing pretty well for myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseG..."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""The mistakes I made were those of a young and inexperienced president. They will not be repeated again.""]** — Mówca: **Player**
> ""The mistakes I made were those of a young and inexperienced president. They will not be repeated again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseG..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: ""I refuse to comment on said allegations at this time.""]** — Mówca: **Player**
> ""I refuse to comment on said allegations at this time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Moderator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseG..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseG..."*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_FrensRicter_Bribe == true ||Bas..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Denis Stahler: ""What does the esteemed head of the PFJP have to say abou..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_FrensRicter_Bribe == true ||BaseGame.LeakedScandal_FrensRicter_TaurusBribe == true) && BaseGameIsolated.Debate_Enable_FrensRicter == true )`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_FrensRicter_Bribe"] == true  or Variable["BaseGame.LeakedScandal_FrensRicter_TaurusBribe"] == true)  and  Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[171]`
Mówca: **Denis Stahler**
> ""What does the esteemed head of the PFJP have to say about that, I wonder?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "Frens fixed Denis with an icy stare."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "Frens fixed Denis with an icy stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)

### Węzeł `[173]`
Mówca: **Frens Ricter**
> ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Rayne and myself. I will not rehash it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Player: ""Thank you, Frens.""*)
  - -> `[217]` (*Player_Italic: "Say nothing."*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Alliance_PFJP == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Alliance_PFJP == true )"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Alliance_PFJP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Alliance_PFJP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Frens Ricter: ""My press spokesperson has already issued a statement reg..."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Alliance_PFJP == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Alliance_PFJP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Frens Ricter: ""My press spokesperson has already issued a statement reg..."*)

### Węzeł `[177]`
Mówca: **Frens Ricter**
> ""My press spokesperson has already issued a statement regarding how Mr. Rayne threatened and intimidated me into accepting his offer. I will not rehash it here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: ""You liar! You practically begged me for that check.""*)
  - -> `[213]` (*Player: ""I will remember your lack of loyalty during my next term.""*)
  - -> `[218]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_LileasGraf == true)"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_LileasGraf == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_LileasGraf == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_LileasGraf"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Ba..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lileas Graf: ""I wonder what your vice president would have to say abou..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lileas Graf: ""I wonder what certain oligarchs would have to say about ..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Lileas Graf: ""I was a part of the administration. It was every bit as ..."*)

### Węzeł `[190]`
Mówca: **Lileas Graf**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[212]` (*Player: ""My press spokesperson has already issued a statement reg..."*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[191]`
Mówca: **Lileas Graf**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Ba..."*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Frens Ricter: ""I wonder what your vice president would have to say abou..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)

### Węzeł `[195]`
Mówca: **Frens Ricter**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Frens Ricter: ""I wonder what certain oligarchs would have to say about ..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Frens Ricter: ""Rest assured the PFJP is committed to purging corruption..."*)

### Węzeł `[199]`
Mówca: **Frens Ricter**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[212]` (*Player: ""My press spokesperson has already issued a statement reg..."*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[200]`
**[WYBÓR GRACZA: ""I was pressured into those actions by individuals who have since resigned.""]** — Mówca: **Player**
> ""I was pressured into those actions by individuals who have since resigned.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0`
- **Kontekst wejściowy (poprzednik):** `[190]` (Lileas Graf), `[191]` (Lileas Graf), `[195]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Scanda..."*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn10_A_NumberOfResignations > 0)"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn10_A_NumberOfResignations > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player: ""I was pressured into those actions by individuals who ha..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn10_A_NumberOfResignations > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_A_NumberOfResignations"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Base..."*)
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || Ba..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Denis Stahler: ""I wonder what your vice president would have to say abou..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.LeakedScandal_AlbinClavin_Bribe == true || BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP == true) && BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.LeakedScandal_AlbinClavin_Bribe"] == true  or  Variable["BaseGame.LeakedScandal_AlbinClavin_BribeSelectedVP"] == true)  and  Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ||..."*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true ..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Denis Stahler: ""I wonder what certain oligarchs would have to say about ..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.LeakedScandal_MarcelKoronti_MediaDeal == true || BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation == true || BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti == true || BaseGame.LeakedScandal_PrivatizationShares_Both == true || BaseGame.LeakedScandal_PrivatizationShares_WalterTusk == true || BaseGame.LeakedScandal_WalterTusk_UnderhallBribe == true || BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses == true || BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.LeakedScandal_MarcelKoronti_MediaDeal"] == true  or  Variable["BaseGame.LeakedScandal_MarcelKoronti_TipOffInvestigation"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_MarcelKoronti"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_Both"] == true  or  Variable["BaseGame.LeakedScandal_PrivatizationShares_WalterTusk"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_UnderhallBribe"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_BailOutBusinesses"] == true  or  Variable["BaseGame.LeakedScandal_WalterTusk_TaxCutLargeCorp"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Denis Stahler: ""Rest assured my party is committed to purging corruption..."*)

### Węzeł `[210]`
Mówca: **Denis Stahler**
> ""I wonder what your vice president would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[212]` (*Player: ""My press spokesperson has already issued a statement reg..."*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[211]`
Mówca: **Denis Stahler**
> ""I wonder what certain oligarchs would have to say about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Clavin and myself. I will not rehash it here.""]** — Mówca: **Player**
> ""My press spokesperson has already issued a statement regarding the innocent misunderstanding between Mr. Clavin and myself. I will not rehash it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Lileas Graf), `[199]` (Frens Ricter), `[210]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Scanda..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA: ""I will remember your lack of loyalty during my next term.""]** — Mówca: **Player**
> ""I will remember your lack of loyalty during my next term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""You liar! You practically begged me for that check.""]** — Mówca: **Player**
> ""You liar! You practically begged me for that check.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""This is politics. You know the saying: You've got to kill the cow to make the zabla.""]** — Mówca: **Player**
> ""This is politics. You know the saying: You've got to kill the cow to make the zabla.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Frens Ricter), `[190]` (Lileas Graf), `[191]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""Thank you, Frens.""]** — Mówca: **Player**
> ""Thank you, Frens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Scanda..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I kept my mouth shut."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[173]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_Scanda..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA: ""Is this a debate or a witch hunt? Can we move on?""]** — Mówca: **Player**
> ""Is this a debate or a witch hunt? Can we move on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[177]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "The other candidates tittered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""Shut up, all of you! I am your President!""*)
  - -> `[223]` (*Player: ""MODERATOR! Next question!""*)
  - -> `[224]` (*Player_Italic: "Say nothing."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Is this a debate or a witch hunt? Can we move on?""]** — Mówca: **Player**
> ""Is this a debate or a witch hunt? Can we move on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Lileas Graf), `[191]` (Lileas Graf), `[195]` (Frens Ricter)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[221]`
Mówca: **Lileas Graf**
> ""I was a part of the administration. It was every bit as bad as they say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[226]` (*Player: ""Stop that high-and-mighty act. I know who you really are.""*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Shut up, all of you! I am your President!""]** — Mówca: **Player**
> ""Shut up, all of you! I am your President!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""MODERATOR! Next question!""]** — Mówca: **Player**
> ""MODERATOR! Next question!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I ignored them."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)

### Węzeł `[225]`
Mówca: **Moderator**
> ""Ahem... it's time we moved on anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Stop that high-and-mighty act. I know who you really are.""]** — Mówca: **Player**
> ""Stop that high-and-mighty act. I know who you really are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Lileas Graf), `[227]` (Frens Ricter), `[228]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "The other candidates tittered."*)

### Węzeł `[227]`
Mówca: **Frens Ricter**
> ""Rest assured the PFJP is committed to purging corruption from the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[226]` (*Player: ""Stop that high-and-mighty act. I know who you really are.""*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[228]`
Mówca: **Denis Stahler**
> ""Rest assured my party is committed to purging corruption from the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player: ""This is politics. You know the saying: You've got to kil..."*)
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn10_A_NumberOfResignations > 0"*)
  - -> `[226]` (*Player: ""Stop that high-and-mighty act. I know who you really are.""*)
  - -> `[220]` (*Player: ""Is this a debate or a witch hunt? Can we move on?""*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (B..."*)
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && ..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Mansoun Leke: ""I'm sure you recall that one of his very first acts in o..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Mansoun Leke: ""Electing Sordland's first leader of Bludish descent woul..."*)

### Węzeł `[232]`
Mówca: **Mansoun Leke**
> ""I'm sure you recall that one of his very first acts in office was to effectively shut the country's only Bludish party off from campaign funding...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaCensored == true || BaseGam..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Moderator: ""The President had a perfectly good explanation for that.""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Moderator: ""Indeed I do.""*)

### Węzeł `[236]`
Mówca: **Moderator**
> ""Indeed I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Mansoun Leke: ""Electing Sordland's first leader of Bludish descent woul..."*)

### Węzeł `[237]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Mansoun raised an eyebrow."*)

### Węzeł `[238]`
Mówca: **Mansoun Leke**
> ""Uh... regardless, electing Sordland's first leader of Bludish descent would help to create a bridge of lasting peace between our communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Mansoun raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Mansoun Leke: ""Uh... regardless, electing Sordland's first leader of Bl..."*)

### Węzeł `[240]`
Mówca: **Moderator**
> ""Yes, I remember that well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mansoun Leke: ""As long as this man remains in office, no minority in So..."*)

### Węzeł `[241]`
Mówca: **Mansoun Leke**
> ""You've been attempting to undermine my people from the moment you took office. Beginning with that bill depriving our party of election funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == true || BaseGame.Media_Sordlan..."*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == true || BaseGame.Media_Sordl..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Moderator: ""The President had a perfectly good explanation for that.""*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == true || BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Moderator: ""Yes, I remember that well.""*)

### Węzeł `[245]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Mansoun raised an eyebrow."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  B..."*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && ..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and   Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Mansoun Leke: ""You've been attempting to undermine my people from the m..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true &&  BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and   Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Mansoun raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Mansoun Leke: ""Uh... regardless, as long as this man is in the Maroon P..."*)

### Węzeł `[250]`
Mówca: **Mansoun Leke**
> ""Uh... regardless, as long as this man is in the Maroon Palace, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Frens Ricter: ""It is true that President Rayne has only stoked the fire..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Manoly Suheil: ""It is true that President Rayne has only stoked the fire..."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[257]`
Mówca: **Moderator**
> ""Yes, I remember that well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Denis Stahler: ""As long as this man is in office, Bludish citizens in So..."*)

### Węzeł `[258]`
Mówca: **Denis Stahler**
> ""You've been attempting to undermine the Bludish people from the moment you took office. Beginning with that bill depriving their party -- and mine -- of election funding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (B..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && ..."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Denis Stahler: ""You've been attempting to undermine the Bludish people f..."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true && (BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true  and  (Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_MediaCensored == true || BaseGame...."*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_MediaCensored == true || BaseGam..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Moderator: ""The President had a perfectly good explanation for that.""*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_MediaCensored == true || BaseGame.Situation_Law_MediaBias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaCensored"] == true  or  Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Moderator: ""Yes, I remember that well.""*)

### Węzeł `[265]`
Mówca: **Denis Stahler**
> ""Uh... regardless, as long as this man is in the Maroon Palace, no minority in Sordland will be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Denis Stahler: ""As long as this man is in office, Bludish citizens in So..."*)

### Węzeł `[266]`
Mówca: **Moderator**
> ""The President had a perfectly good explanation for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Narrator: "Denis raised an eyebrow."*)

### Węzeł `[267]`
Mówca: **Narrator**
> "Denis raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Denis Stahler: ""Uh... regardless, as long as this man is in the Maroon P..."*)

### Węzeł `[268]`
Mówca: **Frens Ricter**
> ""It's true that xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Frens Ricter: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[269]`
Mówca: **Manoly Suheil**
> ""It's true that xenophobia is alive and well in Sordland. Despite the president's best efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Manoly Suheil: ""I will work with the WPB to ensure the Bludish people ge..."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_FrensRicter == true"*)
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_FrensRicter == true)"*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_FrensRicter == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Frens Ricter: ""It's true that xenophobia is alive and well in Sordland...."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_FrensRicter == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_FrensRicter"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Manoly Suheil: ""It's true that xenophobia is alive and well in Sordland...."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_LileasGraf == true"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true"*)
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)"*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Lileas Graf: ""Gentlemen. Ms. Suheil.""*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lileas Graf: ""Gentlemen.""*)

### Węzeł `[279]`
Mówca: **Lileas Graf**
> ""Gentlemen. Ms. Suheil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Lileas' voice was syrupy-sweet."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Moderator: ""Ahem... it's time we moved on anyway.""*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_HP_SordlandFirstDebate_ScandalConfronted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn10_R_SordlandFirstDebate_ScandalIgnored"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Moderator: ""Ahem... it's time we moved on anyway.""*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_Censored == false"*)
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_Censored == false)"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_Censored == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn10_R_SordlandFirstDebate_Scandal..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_Censored == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Moderator: ""Ahem... it's time we moved on anyway.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: ""I'd like to yield the floor to Mr. Leke.""*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "Mansoun smiled."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Denis Stahler: ""How dare you say that, Mr. President?""*)

### Węzeł `[292]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "Mansoun shook his head sadly."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Denis Stahler: ""How dare you say that, Mr. President?""*)

### Węzeł `[295]`
Mówca: **Mansoun Leke**
> ""Denis, calm down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Denis Stahler: ""No. The charade has gone on long enough. How can the bla..."*)

### Węzeł `[296]`
Mówca: **Denis Stahler**
> ""No. The charade has gone on long enough. How can the blatant censorship of the media go unremarked upon on this stage?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "Denis rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)

### Węzeł `[298]`
Mówca: **Denis Stahler**
> ""Admiration? You had me thrown in prison!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: ""I didn't give that order.""*)
  - -> `[315]` (*Player: ""Don't make me do it again.""*)
  - -> `[307]` (*Player: ""The Red Youth was out of control. You should have done s..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Mansoun Leke: ""Denis, calm down.""*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Denis Stahler: ""This charade has gone on long enough. Can't you others s..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""]** — Mówca: **Player**
> ""Denis, I have nothing but admiration for you and your ideology. Please do not test my goodwill.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Malenyevist"] > 15`
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[303]`
Mówca: **Denis Stahler**
> ""Unbelievable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[304]`
Mówca: **Denis Stahler**
> ""They're more violent than they used to be, I'll agree with you there. But your reaction crossed a line.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Denis Stahler: ""Let's just get this dog and pony show over with.""*)

### Węzeł `[305]`
Mówca: **Denis Stahler**
> ""This charade has gone on long enough. Can't you others see he has the media rigged against us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_DenisStahler = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[307]`
**[WYBÓR GRACZA: ""The Red Youth was out of control. You should have done something.""]** — Mówca: **Player**
> ""The Red Youth was out of control. You should have done something.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Denis Stahler: ""They're more violent than they used to be, I'll agree wi..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseGameIsolated.Debate_Enable_DenisStahler = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] = false;
Variable["BaseGameIsolated.Debate_Enable_DenisStahler"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Facti..."*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Fac..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Denis Stahler: ""Not to mention the disappearance of one of the most prom..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Faction_PFJP_Destroyed == true || BaseGame.Faction_NFP_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Faction_PFJP_Destroyed"] == true  or  Variable["BaseGame.Faction_NFP_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true || Ba..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_ManolySuheil == true || Ba..."*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_ManolySuheil == true || ..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Denis Stahler: ""Not to mention the disappearance of one of the most prom..."*)
  - -> `[319]` (*Denis Stahler: ""Not to mention the disappearance of one of the most prom..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_ManolySuheil == true || BaseGameIsolated.Debate_Enable_RemusHolstron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_ManolySuheil"] == true  or  Variable["BaseGameIsolated.Debate_Enable_RemusHolstron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Don't make me do it again.""]** — Mówca: **Player**
> ""Don't make me do it again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "He and Denis walked out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke = false; BaseG..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA: ""I didn't give that order.""]** — Mówca: **Player**
> ""I didn't give that order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Denis Stahler: ""Abdicating responsibility. A good look for a President.""*)

### Węzeł `[318]`
Mówca: **Narrator**
> "Denis loudly pushed his chair back and stormed out of the studio. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_DenisStahler = false"*)

### Węzeł `[319]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition leaders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[320]`
Mówca: **Denis Stahler**
> ""Not to mention the disappearance of one of the most prominent opposition parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)

### Węzeł `[321]`
Mówca: **Denis Stahler**
> ""Let's go, Mansoun.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true || BaseGame..."*)

### Węzeł `[322]`
Mówca: **Mansoun Leke**
> ""It doesn't have to be this way. Vote People's Front for real change in '57.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "He and Denis walked out of the studio. None of the other ..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || Ba..."*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || ..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Denis Stahler: ""To say nothing of the mysterious deaths of certain indiv..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn07_SecretState_Kill_OrsoHawker == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk == true || BaseGame.Killed_MarcelKoronti == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn07_SecretState_Kill_OrsoHawker"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn09_A_Investigation_Oligarchs_Kill_Tusk"] == true  or  Variable["BaseGame.Killed_MarcelKoronti"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "The studio went deathly silent."*)

### Węzeł `[326]`
Mówca: **Denis Stahler**
> ""To say nothing of the mysterious deaths of certain individuals in the President's orbit...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "The studio went deathly silent."*)

### Węzeł `[327]`
**[WYBÓR GRACZA: ""Leave this building. Now.""]** — Mówca: **Player**
> ""Leave this building. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Denis Stahler: ""Gladly.""*)

### Węzeł `[328]`
Mówca: **Mansoun Leke**
> ""Sorry, Denis, I can't risk it. You're on your own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Denis loudly pushed his chair back and stormed out of the..."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "The studio went deathly silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic < -10"*)
  - -> `[333]` (*Player: ""Mr. Stahler. Leave this stage and do not ever show your ..."*)
  - -> `[342]` (*Player: ""I have no idea what you're talking about.""*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)

### Węzeł `[330]`
Mówca: **Narrator**
> "Mansoun got up and looked into the camera."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Mansoun Leke: ""It doesn't have to be this way. Vote People's Front for ..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA: ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""]** — Mówca: **Player**
> ""Mr. Stahler. If I really am as powerful as you claim, wouldn't it be extremely foolish of you to speak against me?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Democratic"] < -10`
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Narrator: "Denis paled slightly."*)

### Węzeł `[332]`
**[WYBÓR GRACZA: ""Sit back down. Now.""]** — Mówca: **Player**
> ""Sit back down. Now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[333]`
**[WYBÓR GRACZA: ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""]** — Mówca: **Player**
> ""Mr. Stahler. Leave this stage and do not ever show your face in front of me again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Denis Stahler: ""Gladly.""*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Threshold_Default == true || BaseGame..."*)
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Threshold_Default == true || BaseGa..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Narrator: "Mansoun got up and looked into the camera."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Threshold_Default == true || BaseGame.Policy_Law_Threshold_15 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Threshold_Default"] == true  or  Variable["BaseGame.Policy_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Mansoun Leke: ""Sorry, Denis, I can't risk it. You're on your own.""*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Malenyevist > 15"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Malenyevist > 15)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Malenyevist > 15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Malenyevist"] > 15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player: ""Denis, I have nothing but admiration for you and your id..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Malenyevist > 15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Malenyevist"] > 15) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[340]`
Mówca: **Denis Stahler**
> ""I'll find my own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[341]`
Mówca: **Denis Stahler**
> ""The hell you do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Player: ""Guards, this man is a danger to me. Please escort him ou..."*)
  - -> `[346]` (*Player: ""Whatever you think you know about me, it's a lie.""*)
  - -> `[345]` (*Player: ""If I was censoring the media, would I permit you to make..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""I have no idea what you're talking about.""]** — Mówca: **Player**
> ""I have no idea what you're talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[329]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Denis Stahler: ""The hell you do.""*)

### Węzeł `[343]`
Mówca: **Denis Stahler**
> ""I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player: ""Sit back down. Now.""*)
  - -> `[327]` (*Player: ""Leave this building. Now.""*)

### Węzeł `[344]`
Mówca: **Denis Stahler**
> ""Abdicating responsibility. A good look for a President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[345]`
**[WYBÓR GRACZA: ""If I was censoring the media, would I permit you to make this kind of scene?""]** — Mówca: **Player**
> ""If I was censoring the media, would I permit you to make this kind of scene?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Denis gaped at me indignantly, then sat, his face red."*)

### Węzeł `[346]`
**[WYBÓR GRACZA: ""Whatever you think you know about me, it's a lie.""]** — Mówca: **Player**
> ""Whatever you think you know about me, it's a lie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Denis Stahler: ""I won't play this game a second longer.""*)

### Węzeł `[347]`
Mówca: **Narrator**
> "Denis gaped at me indignantly, then sat, his face red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Denis Stahler: ""Unbelievable.""*)

### Węzeł `[348]`
**[WYBÓR GRACZA: ""Guards, this man is a danger to me. Please escort him out of the building at once.""]** — Mówca: **Player**
> ""Guards, this man is a danger to me. Please escort him out of the building at once.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[341]` (Denis Stahler)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Denis Stahler: ""I'll find my own way out.""*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Denis Stahler: ""Admiration? You had me thrown in prison!""*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Denis gaped at me indignantly, then sat, his face red."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Denis sat, his face red. None of the other candidates spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_DenisChallenge = true"*)

### Węzeł `[353]`
Mówca: **Narrator**
> "Denis paled slightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Denis Stahler: ""I--""*)

### Węzeł `[354]`
Mówca: **Denis Stahler**
> ""I won't play this game a second longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Debate_Enable_MansounLeke == true)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_Enable_MansounLeke == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Denis Stahler: ""Let's go, Mansoun.""*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Debate_Enable_MansounLeke == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Debate_Enable_MansounLeke"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Denis loudly pushed his chair back and stormed out of the..."*)

### Węzeł `[358]`
Mówca: **Denis Stahler**
> ""Let's just get this dog and pony show over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Denis sat, his face red. None of the other candidates spoke."*)

### Węzeł `[359]`
Mówca: **Denis Stahler**
> ""Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[360]`
Mówca: **Denis Stahler**
> ""I cannot fucking believe this!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "Denis rose from his seat."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "The moderator took a moment to regain her composure."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Debate_DenisChallenge = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Debate_DenisChallenge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "The moderator took a moment to regain her composure."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic < -10"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Democratic < -10)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic < -10`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Democratic"] < -10`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player: ""Mr. Stahler. If I really am as powerful as you claim, wo..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Democratic < -10)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Democratic"] < -10) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true)"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Mansoun Leke: ""As long as this man remains in office, no minority in So..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Mansoun Leke: ""The great Bludish people wish to be safe.""*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_BludishOppression == true"*)
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_BludishOppression == true)"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Denis Stahler: ""As long as this man is in office, Bludish citizens in So..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Denis Stahler: ""Bludish citizens in Sordland should be safe.""*)

### Węzeł `[372]`
Mówca: **Denis Stahler**
> ""Bludish citizens in Sordland should be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[373]`
Mówca: **Mansoun Leke**
> ""The great Bludish people wish to be safe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_KesaroKibener == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn03_Extraction_AddressProtestors == ..."*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn03_Extraction_AddressProtestors =..."*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn03_Extraction_AddressProtestors == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn03_Extraction_AddressProtestors == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn03_Extraction_AddressProtestors"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[377]`
Mówca: **Denis Stahler**
> ""Since our confrontation in Narbel, I've known exactly what kind of man you are, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_A_Protestors_Calm == true"*)
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_A_Protestors_Calm == true)"*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_A_Protestors_Calm == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_A_Protestors_Calm"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Denis Stahler: ""When we met in Narbel, you presented yourself as a reaso..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_A_Protestors_Calm == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_A_Protestors_Calm"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Denis Stahler: ""Since our confrontation in Narbel, I've known exactly wh..."*)

### Węzeł `[381]`
Mówca: **Denis Stahler**
> ""When we met in Narbel, you presented yourself as a reasonable man. But it was all an act, wasn't it, President Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Debate_Enable_MansounLeke == true"*)
