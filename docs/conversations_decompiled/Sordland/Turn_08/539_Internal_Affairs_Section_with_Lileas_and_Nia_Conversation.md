# Sordland/Turn08/Internal Affairs Section with Lileas and Nia/Internal Affairs Section with Lileas and Nia Conversation

- **ID konwersacji:** `539`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/539_Internal_Affairs_Section_with_Lileas_and_Nia_Conversation.md`
- **Liczba węzłów dialogowych:** 594
- **Liczba wyborów gracza:** 82

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[44]** Lileas Graf

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.BFF_EliminationOperation_Botched`
- `BaseGame.BergiaSpecialZone_Proposal_Centralization`
- `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn07_LanguageBill_Signed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Decision_Turn04_RegionalInvestment_Bergia`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum`
- `BaseGame.Media_Censored`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Policy_Diplomacy_Wehlen_DefendBorder`
- `BaseGame.Policy_Diplomacy_Wehlen_JointOperation`
- `BaseGame.Policy_Law_AutonomousZoneOfBergia`
- `BaseGame.Policy_Law_EmergencyDecree`
- `BaseGame.Policy_Law_SpecialZoneOfBergia`
- `BaseGame.Policy_Order_CommunityPolice`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Situation_Law_BludishOppression`
- `BaseGame.SpecialZone_Autonomy_Bill_DoesntPass`
- `BaseGame.SpecialZone_Centralization_Bill_DoesntPass`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn08_SecondScandal_Detained_Livia`
- `BaseGame.Turn08_SecondScandal_LiviaFired`
- `BaseGame.Turn08_SecondScandal_LiviaTrialled`
- `BaseGame.Turn08_SecondScandal_RumburgBlamed`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia`
- `BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.Bludish_Opinion`
- `BaseGame.Economy`
- `BaseGame.LateGameCrisis`
- `BaseGame.Policy_Order_CounterTerrorismOperation`
- `BaseGame.Situation_Order_BFF_ThreatAlarming`
- `BaseGame.Situation_Order_BFF_ThreatContinues`
- `BaseGame.Situation_Order_BFF_ThreatEliminated`
- `BaseGame.Situation_Order_DisputeWithGovernor_Autonomy`
- `BaseGameSupport.CountryReport_Turn08_Rumburg_BFFMilitantsCaptured`
- `BaseGameSupport.CountryReport_Turn08_Rumburg_BludishHumanitarianCrisis`
- `BaseGameSupport.CountryReport_Turn08_Wehlen_BFFActivityStrengthened`
- `BaseGameSupport.CountryReport_Turn08_Wehlen_BFFMilitantsCaptured`
- `BaseGameSupport.CountryReport_Turn08_Wehlen_BFFRemnantsHung`
- `BaseGameSupport.News_Turn08_HP_BFFOperation_Damaged`
- `BaseGameSupport.News_Turn08_HP_BFFOperation_Fail`
- `BaseGameSupport.News_Turn08_HP_BFFOperation_Success`
- `BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsBoth`
- `BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsLanguageBill`
- `BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsReligiousHarmony`
- `BaseGameSupport.News_Turn08_HP_ZeharenIncident`
- `BaseGameSupport.News_Turn08_LT_BFFOperation_Success`
- `BaseGameSupport.News_Turn08_LT_ZeharenIncident`
- `BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsBoth`
- `BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsLanguageBill`
- `BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsReligiousHarmony`
- `BaseGameSupport.News_Turn08_R_ZeharenIncident`
- `BaseGameSupport.News_Turn08_ST_Deal_BFFOperation_Success`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[177] Sordland/Turn08/Other Cabinet Updates** (../Turn_08/177_Other_Cabinet_Updates.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""Yes, please do.""** | `[511]` **Lileas Graf**: ""Shall we begin?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Order_DisputeWithGovernor_Au...` | `[5]` **Nia Morgna**: ""Mr. President. I want to congra..."<br>`[13]` **Lileas Graf**: ""Mr. President. I want to congra..."<br>*(oraz 1 innych odgałęzień)* |
| `[36]` | **""Lileas, I appreciate your dedication and the effort you put into those plans. I u..."** | `[35]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She simply nodded." |
| `[37]` | **""Instead of expressing our disappointment, let's learn from this. We must improve ..."** | `[35]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She simply nodded." |
| `[38]` | **""I understand your disappointment but you have to learn to respect my decisions, M..."** | `[35]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She simply nodded." |
| `[39]` | **""I am disappointed too. There is nothing we can do about it now. Let's talk about ..."** | `[35]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Narrator**: "She simply nodded." |
| `[47]` | **""Lileas, I appreciate your dedication to the revocation of the Special Zone. But I..."** | `[46]` **Lileas Graf**: ""The lack of action taken in thi..."<br>`[495]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[48]` | **""You know as well as I do that there wasn't much that I could have done.""** | `[46]` **Lileas Graf**: ""The lack of action taken in thi..."<br>`[495]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[49]` | **""I understand your disappointment but you have to learn to respect my decisions, M..."** | `[46]` **Lileas Graf**: ""The lack of action taken in thi..."<br>`[495]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[50]` | **""I am disappointed about Governor Bron's attitude as well. But we must try to find..."** | `[46]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[139]` | **""Maybe giving them autonomy wasn't a good idea.""** | `[90]` **Nia Morgna**: ""If you ask me, this already mak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "Nia raised an eyebrow." |
| `[140]` | **""What are you trying to say, Ms. Morgna?""** | `[90]` **Nia Morgna**: ""If you ask me, this already mak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Nia Morgna**: ""Nothing, Mr. President. I am re..." |
| `[141]` | **""Thank you for the report.""** | `[90]` **Nia Morgna**: ""If you ask me, this already mak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Nia Morgna**: ""Of course."" |
| `[142]` | **""Great work as usual, Ms. Morgna.""** | `[95]` **Nia Morgna**: ""Governor Ersen and the represen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[143]` | **""That's good to know. Please send them my regards.""** | `[95]` **Nia Morgna**: ""Governor Ersen and the represen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[144]` | **""Thank you for the report.""** | `[95]` **Nia Morgna**: ""Governor Ersen and the represen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[145]` | **""Frankly, I'm disappointed in your lack of faith in the administration.""** | `[135]` **Narrator**: "She sighed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[309]` **Nia Morgna**: ""I am sorry, Mr. President. I am..." |
| `[146]` | **""What are you trying to say, Ms. Morgna?""** | `[135]` **Narrator**: "She sighed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Nia Morgna**: ""Nothing, Mr. President. I am re..." |
| `[147]` | **""I hear your concerns.""** | `[135]` **Narrator**: "She sighed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[310]` **Narrator**: "Nia nodded." |
| `[148]` | **""Thank you for the report.""** | `[135]` **Narrator**: "She sighed." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[149]` | **""I couldn't have done it without you. You know that.""** | `[137]` **Nia Morgna**: ""You must be applauded for your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Nia Morgna**: ""Thank you for your kind words, ..." |
| `[150]` | **""That means a lot. Thank you.""** | `[137]` **Nia Morgna**: ""You must be applauded for your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[151]` | **""We can still do a lot more.""** | `[137]` **Nia Morgna**: ""You must be applauded for your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Nia Morgna**: ""Of course."" |
| `[183]` | **""Maybe the operation wasn't such a good idea.""** | `[171]` **Lileas Graf**: ""He didn't stop there. He condem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." |
| `[184]` | **""This isn't good.""** | `[171]` **Lileas Graf**: ""He didn't stop there. He condem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." |
| `[185]` | **""Forget about the governor. Give me the results.""** | `[171]` **Lileas Graf**: ""He didn't stop there. He condem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." |
| `[186]` | **""So, it isn't a complete success? Tell me. What happened?""** | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Lileas Graf**: ""Indeed."" |
| `[187]` | **""Give me the whole picture.""** | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Lileas Graf**: ""Of course."" |
| `[188]` | **""That's great to hear, Ms. Graf.""** | `[159]` **Lileas Graf**: ""Despite not reaching all of our..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Lileas Graf**: ""Indeed."" |
| `[193]` | **""That's great to hear, Ms. Graf. Tell me about the details.""** | `[179]` **Lileas Graf**: ""And I must say... It's been a g..."<br>`[591]` **Lileas Graf**: ""And I must say... It paid off."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lileas Graf**: ""Of course."" |
| `[201]` | **""Are you telling me the BFF is not a threat anymore?""** | `[179]` **Lileas Graf**: ""And I must say... It's been a g..."<br>`[591]` **Lileas Graf**: ""And I must say... It paid off."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Lileas Graf**: ""It would require an extraordina..." |
| `[202]` | **""Don't leave me hanging. I want to hear about the whole picture.""** | `[179]` **Lileas Graf**: ""And I must say... It's been a g..."<br>`[591]` **Lileas Graf**: ""And I must say... It paid off."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Lileas Graf**: ""Of course."" |
| `[212]` | **""This is amazing news. With their whole leadership gone, the group won't be able t..."** | `[208]` **Lileas Graf**: ""Wehzek authorities captured Arg..."<br>`[210]` **Lileas Graf**: ""To my complete surprise, they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Lileas Graf**: ""Exactly. And peace will finally..." |
| `[213]` | **""I knew President Smolak could be trusted.""** | `[208]` **Lileas Graf**: ""Wehzek authorities captured Arg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Lileas Graf**: ""His country was incredibly help..." |
| `[214]` | **""Are both the Arge brothers in Antel Rock now?""** | `[208]` **Lileas Graf**: ""Wehzek authorities captured Arg..."<br>`[210]` **Lileas Graf**: ""To my complete surprise, they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[215]` **Lileas Graf**: ""Yes. Awlan was transferred to A..." |
| `[220]` | **""I knew President Smolak could be trusted, but Rumburg's cooperation seems fishy t..."** | `[210]` **Lileas Graf**: ""To my complete surprise, they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Lileas Graf**: ""Rumburg authorities stated that..." |
| `[221]` | **""Rumburg returned the leader of the BFF to us? What do you think of this?""** | `[210]` **Lileas Graf**: ""To my complete surprise, they c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Lileas Graf**: ""Rumburg authorities stated that..." |
| `[226]` | **""I'll be honest with you, Lileas. I didn't trust you at first, but you've proven m..."** | `[225]` **Lileas Graf**: ""Sordland is now Sordland again...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Narrator**: "She looked annoyed for a second ..." |
| `[227]` | **""Let's not get ahead of ourselves. This was just one minor blemish in our country'..."** | `[225]` **Lileas Graf**: ""Sordland is now Sordland again...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "She nodded." |
| `[228]` | **""Great work as always, Ms. Graf. Thank you.""** | `[225]` **Lileas Graf**: ""Sordland is now Sordland again...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Narrator**: "She nodded." |
| `[261]` | **""You should have done a better job at this, Lileas. We've been working on this for..."** | `[231]` **Lileas Graf**: ""But unfortunately, the remainin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Lileas Graf**: ""You are right, Mr. Rayne. I did..." |
| `[262]` | **""Do you think they can still pose a threat for us?""** | `[231]` **Lileas Graf**: ""But unfortunately, the remainin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Lileas Graf**: ""Potentially in the future."" |
| `[272]` | **""So, you're still coming to me with excuses?""** | `[191]` **Lileas Graf**: ""This led to the failure of the ..."<br>`[593]` **Lileas Graf**: ""With rushed decisions, delayed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Lileas Graf**: ""There isn't anything I could do..." |
| `[276]` | **""This is still great news. With most of their leadership gone, it would be incredi..."** | `[231]` **Lileas Graf**: ""But unfortunately, the remainin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Lileas Graf**: ""We should have done a lot more...." |
| `[277]` | **""We have to pressure Rumburg to transfer them to us.""** | `[231]` **Lileas Graf**: ""But unfortunately, the remainin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Lileas Graf**: ""You could try, Mr. Rayne, but d..." |
| `[281]` | **""What happened? Tell me.""** | `[191]` **Lileas Graf**: ""This led to the failure of the ..."<br>`[593]` **Lileas Graf**: ""With rushed decisions, delayed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Lileas Graf**: ""Of course."" |
| `[282]` | **""I thought I could trust you with this. You disappointed the entire administration..."** | `[191]` **Lileas Graf**: ""This led to the failure of the ..."<br>`[593]` **Lileas Graf**: ""With rushed decisions, delayed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[265]` **Lileas Graf**: ""There isn't anything I could do..." |
| `[283]` | **""That's worrying, indeed.""** | `[191]` **Lileas Graf**: ""This led to the failure of the ..."<br>`[593]` **Lileas Graf**: ""With rushed decisions, delayed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Lileas Graf**: ""It is."" |
| `[285]` | **""We have to pressure Rumburg to transfer them to us.""** | `[270]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Lileas Graf**: ""Are you joking? The head of the..." |
| `[286]` | **""You should have done a better job at this, Lileas. We've been working on this for..."** | `[270]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lileas Graf**: ""As I said, it was outside of my..." |
| `[287]` | **""It's alright. What's done is done and there's no point arguing about it anymore.""** | `[270]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "She nodded." |
| `[288]` | **""Goddammit, Lileas! How did all seven of them managed to flee the scene?""** | `[270]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[291]` **Lileas Graf**: ""As I said, it was outside of my..." |
| `[317]` | **""That is pure slander. I didn't do anything against the Bludish people.""** | `[316]` **Lileas Graf**: ""Nonsense.""<br>`[116]` **Nia Morgna**: ""You are fuelling the tensions, ..." | `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[324]` **Nia Morgna**: ""Fine. Mr. President. I will jus..." |
| `[321]` | **""You will have to learn to respect my decision.""** | `[316]` **Lileas Graf**: ""Nonsense.""<br>`[116]` **Nia Morgna**: ""You are fuelling the tensions, ..." | `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[324]` **Nia Morgna**: ""Fine. Mr. President. I will jus..." |
| `[322]` | **""Enough with this, Ms. Morgna. I will not allow you to work against me anymore.""** | `[316]` **Lileas Graf**: ""Nonsense.""<br>`[116]` **Nia Morgna**: ""You are fuelling the tensions, ..." | `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[324]` **Nia Morgna**: ""Fine. Mr. President. I will jus..." |
| `[323]` | **""What are your concerns?""** | `[116]` **Nia Morgna**: ""You are fuelling the tensions, ..." | `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[318]` **Nia Morgna**: ""Really, Mr. President?"" |
| `[375]` | **""So, you're still coming to me with excuses?""** | `[355]` **Lileas Graf**: ""Due to the interference of Gove..."<br>`[356]` **Lileas Graf**: ""Due to the interference of Gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Lileas Graf**: ""There isn't anything I could do..." |
| `[376]` | **""What happened? Tell me.""** | `[355]` **Lileas Graf**: ""Due to the interference of Gove..."<br>`[356]` **Lileas Graf**: ""Due to the interference of Gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Lileas Graf**: ""Of course."" |
| `[377]` | **""I thought I could trust you with this. You disappointed the entire administration..."** | `[355]` **Lileas Graf**: ""Due to the interference of Gove..."<br>`[356]` **Lileas Graf**: ""Due to the interference of Gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Lileas Graf**: ""There isn't anything I could do..." |
| `[378]` | **""That's worrying, indeed.""** | `[355]` **Lileas Graf**: ""Due to the interference of Gove..."<br>`[356]` **Lileas Graf**: ""Due to the interference of Gove..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[373]` **Lileas Graf**: ""It is."" |
| `[384]` | **""Ms. Graf. Please give me all the details. How many deaths are we talking about he..."** | `[383]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[391]` **Lileas Graf**: ""The death count from the town i..." |
| `[385]` | **""You should have done a better job, Lileas. We've been working on this for a long ..."** | `[383]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Lileas Graf**: ""As I said, it was outside of my..." |
| `[386]` | **""It's alright. What's done is done and there's no point arguing about it anymore.""** | `[383]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Narrator**: "She nodded." |
| `[387]` | **""Goddammit, Lileas! How did all seven of them managed to flee the scene?""** | `[383]` **Lileas Graf**: ""We suspect that all seven leade..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[388]` **Lileas Graf**: ""As I said, it was outside of my..." |
| `[415]` | **""You have to accept the responsibility for this incident, Ms. Graf. Don't look els..."** | `[409]` **Lileas Graf**: ""Not abolishing the Special Zone..."<br>`[419]` **Lileas Graf**: ""I'm afraid the autonomous zone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Lileas Graf**: ""I'm afraid that's not all, Mr. ..."<br>`[420]` **Lileas Graf**: ""In any case, I will do my best ..." |
| `[416]` | **""This is bad. Really bad.""** | `[409]` **Lileas Graf**: ""Not abolishing the Special Zone..."<br>`[419]` **Lileas Graf**: ""I'm afraid the autonomous zone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Lileas Graf**: ""I'm afraid that's not all, Mr. ..."<br>`[420]` **Lileas Graf**: ""In any case, I will do my best ..." |
| `[417]` | **""You're right, Ms. Graf. I should have listened to you.""** | `[409]` **Lileas Graf**: ""Not abolishing the Special Zone..."<br>`[419]` **Lileas Graf**: ""I'm afraid the autonomous zone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Lileas Graf**: ""I'm afraid that's not all, Mr. ..."<br>`[420]` **Lileas Graf**: ""In any case, I will do my best ..." |
| `[418]` | **""You are being overly dramatic, Ms. Graf.""** | `[419]` **Lileas Graf**: ""I'm afraid the autonomous zone ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Lileas Graf**: ""I'm afraid that's not all, Mr. ..."<br>`[420]` **Lileas Graf**: ""In any case, I will do my best ..." |
| `[437]` | **""Tell me about this bill.""** | `[436]` **Lileas Graf**: ""I've been following their work ..."<br>`[441]` **Lileas Graf**: ""You should be taking this more ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[442]` **Lileas Graf**: ""Firstly, it aims to grant the n..." |
| `[438]` | **""If it's Mr. Holstron's work, I'm sure I'll be vetoing it.""** | `[436]` **Lileas Graf**: ""I've been following their work ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Lileas Graf**: ""You should be taking this more ..." |
| `[439]` | **""I'll think about that when -- and if -- the Assembly approves it.""** | `[436]` **Lileas Graf**: ""I've been following their work ..."<br>`[441]` **Lileas Graf**: ""You should be taking this more ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Lileas Graf**: ""Fair enough..."" |
| `[444]` | **""I like the sound of it.""** | `[443]` **Lileas Graf**: ""It will also remove several leg..."<br>`[448]` **Lileas Graf**: ""It also adds a clause which all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Nia Morgna**: ""Are you serious?"" |
| `[445]` | **""I'm sorry. I don't think I'll be supporting this bill.""** | `[443]` **Lileas Graf**: ""It will also remove several leg..."<br>`[448]` **Lileas Graf**: ""It also adds a clause which all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Lileas Graf**: ""You are clearly not seeing the ..." |
| `[446]` | **""This sounds all too vague. What legal limits are you talking about here?""** | `[443]` **Lileas Graf**: ""It will also remove several leg..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Lileas Graf**: ""It removes the prerequisites of..." |
| `[449]` | **""This is insane, Lileas. I'm not going to turn Sordland into a police state.""** | `[448]` **Lileas Graf**: ""It also adds a clause which all..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Lileas Graf**: ""Hmm. An interesting comment, co..."<br>`[455]` **Lileas Graf**: ""You are clearly not seeing the ..." |
| `[485]` | **""Lileas, I appreciate your dedication and the effort you put into those plans. I u..."** | `[484]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "She simply nodded." |
| `[486]` | **""Frankly, I don't care about your disappointment, Lileas.""** | `[484]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "She simply nodded." |
| `[487]` | **""I understand your disappointment but you have to learn to respect my decisions, M..."** | `[484]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "She simply nodded." |
| `[488]` | **""I am disappointed too. There is nothing we can do about it now. Let's talk about ..."** | `[484]` **Lileas Graf**: ""Frankly, this was a huge disapp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Narrator**: "She simply nodded." |
| `[494]` | **""I am disappointed about Governor Krull's attitude as well. But we must try to fin..."** | `[495]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[496]` | **""I wish it was up to me, Lileas. But you know it isn't.""** | `[46]` **Lileas Graf**: ""The lack of action taken in thi..."<br>`[495]` **Lileas Graf**: ""The lack of action taken in thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "She simply nodded." |
| `[512]` | **""I hope you've got only good news for me.""** | `[511]` **Lileas Graf**: ""Shall we begin?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Order_DisputeWithGovernor_Au...` | `[5]` **Nia Morgna**: ""Mr. President. I want to congra..."<br>`[13]` **Lileas Graf**: ""Mr. President. I want to congra..."<br>*(oraz 1 innych odgałęzień)* |
| `[513]` | **""Tell me what's been going on in Bergia.""** | `[511]` **Lileas Graf**: ""Shall we begin?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Situation_Order_DisputeWithGovernor_Au...` | `[5]` **Nia Morgna**: ""Mr. President. I want to congra..."<br>`[13]` **Lileas Graf**: ""Mr. President. I want to congra..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[3]`
Mówca: **Narrator**
> "Internal affairs was first on the list of items. Lileas and Nia, along with their close staff, joined me around the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, please do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[511]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[5]`
Mówca: **Nia Morgna**
> ""Mr. President. I want to congratulate you again on your historic accomplishment for our Bludish community. Thank you for approving my plans for autonomy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Lileas grimaced at her remarks."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_DisputeWithGovernor_Autonomy = true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Lileas Graf: ""Mr. President. I want to congratulate you again on your ..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Lileas grimaced at her remarks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Nia Morgna: ""After holding a local election, Ishval Ersen was elected..."*)

### Węzeł `[13]`
Mówca: **Lileas Graf**
> ""Mr. President. I want to congratulate you again on your historic accomplishment for Bluds and Sordland. Thank you for approving my plans for the revocation of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Nia averted her gaze."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Nia averted her gaze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lileas Graf: ""The internal security structure of Bergia has already be..."*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true"*)
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true)"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SpecialZone_Autonomy_Bill_DoesntPass"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Nia Morgna: ""Mr. President. I wanted to thank you again for approving..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SpecialZone_Autonomy_Bill_DoesntPass == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SpecialZone_Autonomy_Bill_DoesntPass"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.SpecialZone_Centralization_Bill_DoesntPass == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SpecialZone_Centralization_Bill_DoesntPass == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.SpecialZone_Centralization_Bill_DoesntPass == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.SpecialZone_Centralization_Bill_DoesntPass == ..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.SpecialZone_Centralization_Bill_DoesntPass == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.SpecialZone_Centralization_Bill_DoesntPass"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lileas Graf: ""Mr. President. I wanted to thank you again for approving..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.SpecialZone_Centralization_Bill_DoesntPass == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.SpecialZone_Centralization_Bill_DoesntPass"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)

### Węzeł `[21]`
Mówca: **Nia Morgna**
> ""Mr. President. I wanted to thank you again for approving my plans for Autonomous Bergia. However, the Assembly denied us the possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Nia Morgna: ""The proposal only received about 90 votes.""*)

### Węzeł `[22]`
Mówca: **Nia Morgna**
> ""The proposal only received about 90 votes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lileas Graf: ""I'm sorry but what did you expect? The Grand National As..."*)

### Węzeł `[23]`
Mówca: **Lileas Graf**
> ""I'm sorry but what did you expect? The Grand National Assembly did the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[24]`
Mówca: **Lileas Graf**
> ""Mr. President. I wanted to thank you again for approving my plans for the centralization of Bergia. However, the Assembly denied us the possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lileas Graf: ""Of course, this isn't very unexpected, judging by your p..."*)

### Węzeł `[25]`
Mówca: **Lileas Graf**
> ""Of course, this isn't very unexpected, judging by your popularity among the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Re..."*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Re..."*)
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame...."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lileas Graf: ""You could have passed it by decree if you hadn't taken t..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[29]`
Mówca: **Lileas Graf**
> ""You could have passed it by decree if you hadn't taken that authority away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[30]`
Mówca: **Lileas Graf**
> ""You could have passed it by decree if you hadn't completely removed them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lileas Graf: ""You could have passed it by decree if you hadn't complet..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Lileas Graf: ""You could have passed it by decree but you made the Asse..."*)

### Węzeł `[34]`
Mówca: **Lileas Graf**
> ""You could have passed it by decree but you made the Assembly block it instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[35]`
Mówca: **Lileas Graf**
> ""Frankly, this was a huge disappointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Player: ""Instead of expressing our disappointment, let's learn fr..."*)
  - -> `[36]` (*Player: ""Lileas, I appreciate your dedication and the effort you ..."*)
  - -> `[38]` (*Player: ""I understand your disappointment but you have to learn t..."*)
  - -> `[39]` (*Player: ""I am disappointed too. There is nothing we can do about ..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lileas, I appreciate your dedication and the effort you put into those plans. I understand your frustration, but we must respect the democratic process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She simply nodded."*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Instead of expressing our disappointment, let's learn from this. We must improve our approach and build consensus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She simply nodded."*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your disappointment but you have to learn to respect my decisions, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She simply nodded."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am disappointed too. There is nothing we can do about it now. Let's talk about the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[35]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "She simply nodded."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "She simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[41]`
Mówca: **Nia Morgna**
> ""In any case, as long as Governor Bron retains his position, the central government can never properly decrease the tensions between our Sordish and Bludish communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[45]`
Mówca: **Lileas Graf**
> ""Mr. President. Governor Bron is still causing problems with my forces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: ""The lack of action taken in this arena is disappointing.""*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> ""The lack of action taken in this arena is disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Player: ""I wish it was up to me, Lileas. But you know it isn't.""*)
  - -> `[47]` (*Player: ""Lileas, I appreciate your dedication to the revocation o..."*)
  - -> `[48]` (*Player: ""You know as well as I do that there wasn't much that I c..."*)
  - -> `[49]` (*Player: ""I understand your disappointment but you have to learn t..."*)
  - -> `[50]` (*Player: ""I am disappointed about Governor Bron's attitude as well..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lileas, I appreciate your dedication to the revocation of the Special Zone. But I simply do not support it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lileas Graf), `[495]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know as well as I do that there wasn't much that I could have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lileas Graf), `[495]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your disappointment but you have to learn to respect my decisions, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lileas Graf), `[495]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am disappointed about Governor Bron's attitude as well. But we must try to find solutions instead of blaming each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "She simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""After holding a local election, Ishval Ersen was elected as the Governor of the Autonomous Zone of Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[53]`
Mówca: **Nia Morgna**
> ""This marks a new era for all Bergians. I've gotten reports of days-long post-election celebrations all across the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lileas Graf: ""And now they are building their own security force from ..."*)

### Węzeł `[54]`
Mówca: **Lileas Graf**
> ""And now they are building their own security force from scratch. My problem remains the same -- if not worse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Lileas Graf: ""If they do not cooperate like Bron's forces, I'm afraid ..."*)

### Węzeł `[55]`
Mówca: **Lileas Graf**
> ""If they do not cooperate like Bron's forces, I'm afraid the consequences will be more deadly this time around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[56]`
Mówca: **Lileas Graf**
> ""The internal security structure of Bergia has already been dismantled. Part of the local forces will be integrated into the Sordish Police Force.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lileas Graf: ""The governor position has been abolished. In the next el..."*)

### Węzeł `[57]`
Mówca: **Lileas Graf**
> ""The governor position has been abolished. In the next election, each town will elect its own mayor as in the rest of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: ""And now you, Ms. Graf, have complete control over the re..."*)

### Węzeł `[58]`
Mówca: **Nia Morgna**
> ""And now you, Ms. Graf, have complete control over the region's security...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: ""As I should, Ms. Morgna. I am the Minister of the Interi..."*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> ""As I should, Ms. Morgna. I am the Minister of the Interior, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[60]`
Mówca: **Nia Morgna**
> ""In any case, as long as Governor Krull retains his position, the central government can never properly decrease the tensions between our Sordish and Bludish communities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Nia Morgna: ""In any case, despite Governor Bron being a major obstacl..."*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Nia Morgna: ""In any case, as long as Governor Bron retains his positi..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Nia Morgna: ""In any case, despite Governor Krull being an obstacle fo..."*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Nia Morgna: ""In any case, as long as Governor Krull retains his posit..."*)

### Węzeł `[67]`
Mówca: **Nia Morgna**
> ""In any case, despite Governor Krull being an obstacle for Bludish rights, the new Constitution will open the way for real reforms from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[68]`
Mówca: **Nia Morgna**
> ""In any case, despite Governor Bron being a major obstacle for Bludish rights, the new Constitution will open the way for real reforms from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)

### Węzeł `[72]`
Mówca: **Nia Morgna**
> ""In any case, now that the governor is gone, and the Constitution expanded to include Bludish rights, the Bludish community is happy with the overall situation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""In any case, now that the governor is gone, this will hopefully prove to be a huge step for Bludish rights in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[76]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[75]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Nia Morgna: ""Governor Ersen, as his first act, has already blocked th..."*)

### Węzeł `[76]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Nia Morgna: ""Governor Ersen, as his first act, has already blocked th..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[80]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[82]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[81]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Nia Morgna: ""He did the same for the Unified Language Act.""*)

### Węzeł `[82]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsRelig..."*)

### Węzeł `[83]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[86]`
Mówca: **Nia Morgna**
> ""Governor Ersen, as his first act, has already blocked the Religious Harmony Act you signed from going into law in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[87]`
Mówca: **Nia Morgna**
> ""Governor Ersen, as his first act, has already blocked the Unified Language Act you signed from going into law in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsLangua..."*)

### Węzeł `[88]`
Mówca: **Nia Morgna**
> ""He did the same for the Unified Language Act.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsBoth =..."*)

### Węzeł `[89]`
Mówca: **Nia Morgna**
> ""Of course, the Unified Language Act is creating a lot of resentment within the Bludish communities, who want to choose their own language in education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Nia Morgna: ""This is certainly a point of contention.""*)

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""If you ask me, this already makes Bergia more democratic than the central government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player: ""What are you trying to say, Ms. Morgna?""*)
  - -> `[139]` (*Player: ""Maybe giving them autonomy wasn't a good idea.""*)
  - -> `[141]` (*Player: ""Thank you for the report.""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Nia Morgna: ""And the Unified Language Act is taking their right to ch..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Nia Morgna: ""This is certainly a point of contention.""*)

### Węzeł `[94]`
Mówca: **Nia Morgna**
> ""And the Unified Language Act is taking their right to choose their own language in education.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Nia Morgna: ""Therefore, I cannot say that everything is going great f..."*)

### Węzeł `[95]`
Mówca: **Nia Morgna**
> ""Governor Ersen and the representatives of the Bludish democratic movement have sent you their best wishes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player: ""That's good to know. Please send them my regards.""*)
  - -> `[142]` (*Player: ""Great work as usual, Ms. Morgna.""*)
  - -> `[144]` (*Player: ""Thank you for the report.""*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[97]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Nia Morgna: ""Of course, the Religious Harmony Act is creating a lot o..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)"*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Nia Morgna: ""Of course, the Unified Language Act is creating a lot of..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)

### Węzeł `[102]`
Mówca: **Nia Morgna**
> ""Therefore, I cannot say that everything is going great for Bludish rights in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sighed."*)

### Węzeł `[103]`
Mówca: **Nia Morgna**
> ""This is certainly a point of contention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sighed."*)

### Węzeł `[104]`
Mówca: **Nia Morgna**
> ""Of course, the Religious Harmony Act is creating a lot of resentment within the Golcondist communities, who are predominantly Bludish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""The Bludish community is incredibly furious about the si..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "!(((BaseGame.Bill_Turn07_LanguageBill_Signed == true && B..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  or  Variable["BaseGame.BFF_EliminationOperation"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Nia Morgna: ""In any case, even now that the governor is gone and the ..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(((Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  or  Variable["BaseGame.BFF_EliminationOperation"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Nia Morgna: ""In any case, now that the governor is gone, and the Cons..."*)

### Węzeł `[111]`
Mówca: **Nia Morgna**
> ""In any case, even now that the governor is gone and the Constitution has been expanded to include Bludish rights, the Bludish community is not entirely happy with the overall situation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""The Bludish community is incredibly furious about the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Nia Morgna: ""You are fuelling the tensions, Mr. President.""*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "((BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(((BaseGame.Bill_Turn07_LanguageBill_Signed == true && B..."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  or  Variable["BaseGame.BFF_EliminationOperation"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Nia Morgna: ""The Bludish community is angry about the current situati..."*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) || BaseGame.BFF_EliminationOperation == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false)`
- **Warunek bezpośredni (`conditionsString`):** `(((Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  or  Variable["BaseGame.BFF_EliminationOperation"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""In any case, now that the governor is gone, this will ho..."*)

### Węzeł `[116]`
Mówca: **Nia Morgna**
> ""You are fuelling the tensions, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "She stopped and looked pointedly at Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Nia Morgna: ""Why don't you explain the situation, Ms. Graf?""*)

### Węzeł `[118]`
Mówca: **Nia Morgna**
> ""Why don't you explain the situation, Ms. Graf?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "Lileas stood up and cleared her throat."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Nia Morgna: ""Though I'm not very hopeful anymore. Especially after, w..."*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseG..."*)

### Węzeł `[122]`
Mówca: **Nia Morgna**
> ""Though I'm not very hopeful anymore. Especially after, well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She stopped and looked pointedly at...."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She stopped and looked pointedly at..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "She stopped and looked pointedly at Lileas."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Nia Morgna: ""Especially after today's incident...""*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[127]`
Mówca: **Nia Morgna**
> ""Especially after today's incident...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She stopped and looked pointedly at...."*)

### Węzeł `[128]`
Mówca: **Nia Morgna**
> ""But I'm not hopeful, knowing that you have approved incredibly discriminatory bills by Kesaro Kibener already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Nia Morgna: ""Therefore, I cannot say that everything is going great f..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -15"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -15)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Nia Morgna: ""Especially considering the state's oppression against th..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Nia Morgna: ""Therefore, I cannot say that everything is going great f..."*)

### Węzeł `[132]`
Mówca: **Nia Morgna**
> ""But there is still a long way to go. The Bludish community will never forget what our government did in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Nia Morgna: ""Therefore, I cannot say that everything is going great f..."*)

### Węzeł `[133]`
Mówca: **Nia Morgna**
> ""Especially considering the state's war against the Bludish community...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [Nia Morgna: ""You are fuelling the tensions, Mr..."*)

### Węzeł `[134]`
Mówca: **Nia Morgna**
> ""Especially considering the state's oppression against the Bludish community...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [Nia Morgna: ""You are fuelling the tensions, Mr..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""What are you trying to say, Ms. Morgna?""*)
  - -> `[145]` (*Player: ""Frankly, I'm disappointed in your lack of faith in the a..."*)
  - -> `[147]` (*Player: ""I hear your concerns.""*)
  - -> `[148]` (*Player: ""Thank you for the report.""*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Nia Morgna: ""You are fuelling the tensions, Mr...."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Nia Morgna: ""You are fuelling the tensions, Mr. President.""*)

### Węzeł `[137]`
Mówca: **Nia Morgna**
> ""You must be applauded for your efforts on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: ""That means a lot. Thank you.""*)
  - -> `[149]` (*Player: ""I couldn't have done it without you. You know that.""*)
  - -> `[151]` (*Player: ""We can still do a lot more.""*)

### Węzeł `[138]`
Mówca: **Nia Morgna**
> ""Therefore, I cannot say that everything is going great for Bludish rights in this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sighed."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe giving them autonomy wasn't a good idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "Nia raised an eyebrow."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you trying to say, Ms. Morgna?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Nia Morgna: ""Nothing, Mr. President. I am reporting on the current si..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for the report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great work as usual, Ms. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's good to know. Please send them my regards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for the report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Frankly, I'm disappointed in your lack of faith in the administration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Nia Morgna: ""I am sorry, Mr. President. I am just reporting on the cu..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you trying to say, Ms. Morgna?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Nia Morgna: ""Nothing, Mr. President. I am reporting on the current si..."*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hear your concerns.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Nia nodded."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you for the report.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I couldn't have done it without you. You know that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Nia Morgna: ""Thank you for your kind words, Mr. President.""*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That means a lot. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We can still do a lot more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Nia Morgna: ""Of course.""*)

### Węzeł `[152]`
Mówca: **Nia Morgna**
> ""Nothing, Mr. President. I am reporting on the current situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "Nia raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[154]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[155]`
Mówca: **Nia Morgna**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lileas Graf: ""I've been personally leading the ground operations to le..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lileas Graf: ""Karl Greiser has been leading the operations on the grou..."*)

### Węzeł `[159]`
Mówca: **Lileas Graf**
> ""Despite not reaching all of our targets, the operation can still be called as a success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged = true; BaseGame.Situation_Order_BFF..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Destroyed"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player: ""That's great to hear, Ms. Graf. Tell me about the details.""*)
  - -> `[201]` (*Player: ""Are you telling me the BFF is not a threat anymore?""*)
  - -> `[202]` (*Player: ""Don't leave me hanging. I want to hear about the whole p..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged = true;
BaseGame.Situation_Order_BFF_ThreatContinues = true;
BaseGame.Situation_Order_BFF_ThreatAlarming = false;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Damaged"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Player: ""So, it isn't a complete success? Tell me. What happened?""*)
  - -> `[187]` (*Player: ""Give me the whole picture.""*)
  - -> `[188]` (*Player: ""That's great to hear, Ms. Graf.""*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Lileas Graf: ""Governor Bron has been leading the operations on the gro..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Lileas Graf: ""Governor Krull has been leading the operations on the gr..."*)

### Węzeł `[165]`
Mówca: **Lileas Graf**
> ""I have important updates about our operation against the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[166]`
Mówca: **Lileas Graf**
> ""Despite eliminating several leaders of the BFF, our operations were disrupted...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lileas Graf: ""...By none other than our new governor, Ishval Ersen. Th..."*)

### Węzeł `[167]`
Mówca: **Lileas Graf**
> ""...By none other than our new governor, Ishval Ersen. The autonomous zone wasn't a good idea. He is already interfering with internal security matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Lileas Graf: ""He didn't stop there. He condemned the operation, Mr. Pr..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Nia Morgna: ""You must be applauded for your efforts on this.""*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Nia Morgna: ""Governor Ersen and the representatives of the Bludish de..."*)

### Węzeł `[171]`
Mówca: **Lileas Graf**
> ""He didn't stop there. He condemned the operation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: ""This isn't good.""*)
  - -> `[183]` (*Player: ""Maybe the operation wasn't such a good idea.""*)
  - -> `[185]` (*Player: ""Forget about the governor. Give me the results.""*)

### Węzeł `[172]`
Mówca: **Lileas Graf**
> ""Governor Bron has been leading the operations on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)

### Węzeł `[173]`
Mówca: **Lileas Graf**
> ""Governor Krull has been leading the operations on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)

### Węzeł `[174]`
Mówca: **Lileas Graf**
> ""Karl Greiser has been leading the operations on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lileas Graf: ""Unfortunately, due to the lack of security resources, op..."*)

### Węzeł `[175]`
Mówca: **Lileas Graf**
> ""I've been personally leading the ground operations to leave nothing to chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Lileas Graf: ""And I must say... It's been a great success.""*)

### Węzeł `[176]`
Mówca: **Lileas Graf**
> ""Karl Greiser has been leading the operations on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || (Bas..."*)

### Węzeł `[177]`
Mówca: **Lileas Graf**
> ""Of course, I still had to directly intervene on critical moments to leave nothing to chance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Lileas Graf: ""And I must say... It paid off.""*)

### Węzeł `[178]`
Mówca: **Lileas Graf**
> ""As a matter of fact, both the Wehzek and Rumburgian authorities helped subdue Arge and the two captains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Lileas Graf: ""After the capture of the two captains in Wehlen, Arge hi..."*)

### Węzeł `[179]`
Mówca: **Lileas Graf**
> ""And I must say... It's been a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true; BaseGame.Situation_Order_B..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn08_Wehlen_BFFMilitantsC..."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn08_Rumburg_BFFMilitants..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Maybe the operation wasn't such a good idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lileas Graf: ""Despite not reaching all of our targets, the operation c..."*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This isn't good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lileas Graf: ""Despite not reaching all of our targets, the operation c..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Forget about the governor. Give me the results.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lileas Graf: ""Despite not reaching all of our targets, the operation c..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So, it isn't a complete success? Tell me. What happened?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lileas Graf: ""Indeed.""*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Give me the whole picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to hear, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lileas Graf: ""Indeed.""*)

### Węzeł `[189]`
Mówca: **Lileas Graf**
> ""Indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[190]`
Mówca: **Lileas Graf**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[191]`
Mówca: **Lileas Graf**
> ""This led to the failure of the operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: ""What happened? Tell me.""*)
  - -> `[282]` (*Player: ""I thought I could trust you with this. You disappointed ..."*)
  - -> `[283]` (*Player: ""That's worrying, indeed.""*)
  - -> `[272]` (*Player: ""So, you're still coming to me with excuses?""*)

### Węzeł `[192]`
Mówca: **Lileas Graf**
> ""There was an incident, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to hear, Ms. Graf. Tell me about the details.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lileas Graf), `[591]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Lileas Graf: ""Due to the interference of Governor Ersen, our operation..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Lileas Graf: ""Due to the interference of Governor Bron, our operation ..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Lileas Graf: ""Due to the interference of Governor Krull, our operation..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "Lileas stood up and cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Lileas Graf: ""There was an incident, Mr. President.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you telling me the BFF is not a threat anymore?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lileas Graf), `[591]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Lileas Graf: ""It would require an extraordinary effort for them to rec..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't leave me hanging. I want to hear about the whole picture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[179]` (Lileas Graf), `[591]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[203]`
Mówca: **Lileas Graf**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[204]`
Mówca: **Lileas Graf**
> ""It would require an extraordinary effort for them to recover from this, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[205]`
Mówca: **Lileas Graf**
> ""By the joint efforts of the Sordish Intelligence Directorate and Mr. Ejall's contacts, we managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lileas Graf: ""We surrounded and raided the location, eliminating four ..."*)

### Węzeł `[206]`
Mówca: **Lileas Graf**
> ""We surrounded and raided the location, eliminating four of the seven leaders of the terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lileas Graf: ""They were all declared KIA.""*)

### Węzeł `[207]`
Mówca: **Lileas Graf**
> ""Although the remaining three leaders -- including Awlan Arge -- escaped briefly, we eventually managed to capture them all thanks to our cooperation with foreign partners.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)

### Węzeł `[208]`
Mówca: **Lileas Graf**
> ""Wehzek authorities captured Arge and his two captains trying to flee to the mountains in northern Wehlen towards Rumburg, and quickly transferred them to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""This is amazing news. With their whole leadership gone, ..."*)
  - -> `[213]` (*Player: ""I knew President Smolak could be trusted.""*)
  - -> `[214]` (*Player: ""Are both the Arge brothers in Antel Rock now?""*)

### Węzeł `[209]`
Mówca: **Lileas Graf**
> ""After the capture of the two captains in Wehlen, Arge himself was arrested by Rumburgian border police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Lileas Graf: ""To my complete surprise, they cooperated with us in tran..."*)

### Węzeł `[210]`
Mówca: **Lileas Graf**
> ""To my complete surprise, they cooperated with us in transferring all three to Sordish soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Player: ""This is amazing news. With their whole leadership gone, ..."*)
  - -> `[214]` (*Player: ""Are both the Arge brothers in Antel Rock now?""*)
  - -> `[220]` (*Player: ""I knew President Smolak could be trusted, but Rumburg's ..."*)
  - -> `[221]` (*Player: ""Rumburg returned the leader of the BFF to us? What do yo..."*)

### Węzeł `[211]`
Mówca: **Lileas Graf**
> ""They were all declared KIA.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Lileas Graf: ""Although the remaining three leaders -- including Awlan ..."*)

### Węzeł `[212]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is amazing news. With their whole leadership gone, the group won't be able to recover.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lileas Graf), `[210]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Lileas Graf: ""Exactly. And peace will finally prevail over the region.""*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew President Smolak could be trusted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Lileas Graf: ""His country was incredibly helpful in our operation.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are both the Arge brothers in Antel Rock now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Lileas Graf), `[210]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Lileas Graf: ""Yes. Awlan was transferred to Antel Rock Prison today.""*)

### Węzeł `[215]`
Mówca: **Lileas Graf**
> ""Yes. Awlan was transferred to Antel Rock Prison today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lileas Graf: ""In any case, I am proud to say that we have ended an era..."*)

### Węzeł `[216]`
Mówca: **Lileas Graf**
> ""Exactly. And peace will finally prevail over the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Lileas Graf: ""Just as Tarquin Soll wished for.""*)

### Węzeł `[217]`
Mówca: **Lileas Graf**
> ""Just as Tarquin Soll wished for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lileas Graf: ""In any case, I am proud to say that we have ended an era..."*)

### Węzeł `[218]`
Mówca: **Lileas Graf**
> ""His country was incredibly helpful in our operation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Lileas Graf: ""Without their cooperation, we could have missed our oppo..."*)

### Węzeł `[219]`
Mówca: **Lileas Graf**
> ""Without their cooperation, we could have missed our opportunity to get the top instigator.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lileas Graf: ""In any case, I am proud to say that we have ended an era..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew President Smolak could be trusted, but Rumburg's cooperation seems fishy to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lileas Graf: ""Rumburg authorities stated that they wanted to show a si..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rumburg returned the leader of the BFF to us? What do you think of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[210]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Lileas Graf: ""Rumburg authorities stated that they wanted to show a si..."*)

### Węzeł `[222]`
Mówca: **Lileas Graf**
> ""Rumburg authorities stated that they wanted to show a sign of goodwill, after your efforts at de-escalating a possible conflict with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Lileas Graf: ""But I suspect this may be coupled with future demands. R..."*)

### Węzeł `[223]`
Mówca: **Lileas Graf**
> ""But I suspect this may be coupled with future demands. Rumburg is never to be trusted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Lileas Graf: ""In any case, I am proud to say that we have ended an era..."*)

### Węzeł `[224]`
Mówca: **Lileas Graf**
> ""In any case, I am proud to say that we have ended an era in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Lileas Graf: ""And you, Mr. Rayne, will be remembered as the president ..."*)

### Węzeł `[225]`
Mówca: **Lileas Graf**
> ""Sordland is now Sordland again. I thank you for your trust in my abilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""Let's not get ahead of ourselves. This was just one mino..."*)
  - -> `[226]` (*Player: ""I'll be honest with you, Lileas. I didn't trust you at f..."*)
  - -> `[228]` (*Player: ""Great work as always, Ms. Graf. Thank you.""*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest with you, Lileas. I didn't trust you at first, but you've proven me wrong. Good job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "She looked annoyed for a second but gave me a brief smile."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's not get ahead of ourselves. This was just one minor blemish in our country's history. May it not even be remembered.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "She nodded."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great work as always, Ms. Graf. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Narrator: "She nodded."*)

### Węzeł `[229]`
Mówca: **Lileas Graf**
> ""With a massive operation, we have surrounded and raided the location, eliminating four of the seven leaders of the terrorists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Lileas Graf: ""They were all declared KIA.""*)

### Węzeł `[230]`
Mówca: **Lileas Graf**
> ""They were all declared KIA.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Lileas Graf: ""But unfortunately, the remaining three leaders -- includ..."*)

### Węzeł `[231]`
Mówca: **Lileas Graf**
> ""But unfortunately, the remaining three leaders -- including Awlan Arge -- managed to escape. We believe they managed to enter Rumburg from the mountains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player: ""This is still great news. With most of their leadership ..."*)
  - -> `[277]` (*Player: ""We have to pressure Rumburg to transfer them to us.""*)
  - -> `[262]` (*Player: ""Do you think they can still pose a threat for us?""*)
  - -> `[261]` (*Player: ""You should have done a better job at this, Lileas. We've..."*)

### Węzeł `[232]`
Mówca: **Lileas Graf**
> ""And you, Mr. Rayne, will be remembered as the president who eliminated the BFF and their unending terror inside our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Lileas Graf: ""Sordland is now Sordland again. I thank you for your tru..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Nia Morgna: ""Especially considering the state's war against the Bludi..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -15"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == true && BaseG..."*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == true && Bas..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Nia Morgna: ""But I'm not hopeful, knowing that you have approved incr..."*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Nia Morgna: ""But there is still a long way to go. The Bludish communi..."*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Nia Morgna: ""You must be applauded for your efforts on this.""*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true"*)
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Nia Morgna: ""Of course, the Bludish community did not yet forget our ..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Nia Morgna: ""I hope we can achieve a true reconciliation between our ..."*)

### Węzeł `[245]`
Mówca: **Nia Morgna**
> ""Of course, the Bludish community did not yet forget our support to the Operation Bear Trap, and how Bludish refugees were treated...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Nia Morgna: ""These scars will not heal so easily.""*)

### Węzeł `[246]`
Mówca: **Nia Morgna**
> ""These scars will not heal so easily.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sighed."*)

### Węzeł `[247]`
Mówca: **Nia Morgna**
> ""The Bludish community is angry about the current situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[248]`
Mówca: **Nia Morgna**
> ""I hope we can achieve a true reconciliation between our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sighed."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Nia Morgna: ""Your president-approved operation against the BFF will d..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[252]`
Mówca: **Nia Morgna**
> ""Your president-approved operation against the BFF will destroy any gains we've made. The Bludish community is actually very concerned about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Lileas Graf: ""You said it yourself. It has already been approved by th..."*)

### Węzeł `[253]`
Mówca: **Lileas Graf**
> ""You said it yourself. It has already been approved by the president.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Nia Morgna: ""Under other circumstances, this would be cause for celeb..."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Nia Morgna: ""This marks a new era for all Bergians. I've gotten repor..."*)

### Węzeł `[260]`
Mówca: **Nia Morgna**
> ""Under other circumstances, this would be cause for celebration across the region. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 4"*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have done a better job at this, Lileas. We've been working on this for a long time now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Lileas Graf: ""You are right, Mr. Rayne. I did everything in my power b..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Do you think they can still pose a threat for us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Lileas Graf: ""Potentially in the future.""*)

### Węzeł `[263]`
Mówca: **Lileas Graf**
> ""We should have done a lot more. But it is correct. This is a massive success nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[264]`
Mówca: **Lileas Graf**
> ""You are right, Mr. Rayne. I did everything in my power but it wasn't me who led the operation on the ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "She sighed."*)

### Węzeł `[265]`
Mówca: **Lileas Graf**
> ""There isn't anything I could do about this, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Lileas Graf: ""I expected you to be more fair about this. You know I di..."*)

### Węzeł `[266]`
Mówca: **Lileas Graf**
> ""It is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[267]`
Mówca: **Lileas Graf**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[268]`
Mówca: **Lileas Graf**
> ""Our raid was delayed due to logistical issues, and our massive operation was thwarted when the leaders of the terrorists were signalled about our plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Lileas Graf: ""Regardless, the operation took place and several terrori..."*)

### Węzeł `[269]`
Mówca: **Lileas Graf**
> ""Regardless, the operation took place and several terrorists were killed in action. Unfortunately, none of the leaders were found on the location.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Lileas Graf: ""We suspect that all seven leaders of the BFF -- includin..."*)

### Węzeł `[270]`
Mówca: **Lileas Graf**
> ""We suspect that all seven leaders of the BFF -- including Awlan Arge -- managed to escape to Rumburg from the mountains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Player: ""Goddammit, Lileas! How did all seven of them managed to ..."*)
  - -> `[285]` (*Player: ""We have to pressure Rumburg to transfer them to us.""*)
  - -> `[287]` (*Player: ""It's alright. What's done is done and there's no point a..."*)
  - -> `[286]` (*Player: ""You should have done a better job at this, Lileas. We've..."*)

### Węzeł `[271]`
Mówca: **Lileas Graf**
> ""You could try, Mr. Rayne, but don't expect them to listen to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Lileas Graf: ""They are the ones funding the BFF all along.""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So, you're still coming to me with excuses?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lileas Graf), `[593]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lileas Graf: ""There isn't anything I could do about this, Mr. Rayne.""*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Nia Morgna: ""Well, you've certainly got your work cut out for you aft..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is still great news. With most of their leadership gone, it would be incredibly hard for them to get back up again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Lileas Graf: ""We should have done a lot more. But it is correct. This ..."*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have to pressure Rumburg to transfer them to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Lileas Graf: ""You could try, Mr. Rayne, but don't expect them to liste..."*)

### Węzeł `[278]`
Mówca: **Lileas Graf**
> ""They are the ones funding the BFF all along.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "She sighed."*)

### Węzeł `[279]`
Mówca: **Lileas Graf**
> ""Potentially in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Lileas Graf: ""As long as he maintains Rumburg's full support, they'll ..."*)

### Węzeł `[280]`
Mówca: **Lileas Graf**
> ""As long as he maintains Rumburg's full support, they'll be under their protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Narrator: "She sighed."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What happened? Tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lileas Graf), `[593]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought I could trust you with this. You disappointed the entire administration, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lileas Graf), `[593]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Lileas Graf: ""There isn't anything I could do about this, Mr. Rayne.""*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's worrying, indeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[191]` (Lileas Graf), `[593]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Lileas Graf: ""It is.""*)

### Węzeł `[284]`
Mówca: **Lileas Graf**
> ""I expected you to be more fair about this. You know I didn't even lead the ground operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We have to pressure Rumburg to transfer them to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Lileas Graf: ""Are you joking? The head of the snake itself?""*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have done a better job at this, Lileas. We've been working on this for a long time now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: ""As I said, it was outside of my control, Mr. President.""*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's alright. What's done is done and there's no point arguing about it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "She nodded."*)

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Goddammit, Lileas! How did all seven of them managed to flee the scene?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Lileas Graf: ""As I said, it was outside of my control, Mr. President.""*)

### Węzeł `[289]`
Mówca: **Lileas Graf**
> ""Are you joking? The head of the snake itself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Lileas Graf: ""Are you willing to believe the country that funds and pr..."*)

### Węzeł `[290]`
Mówca: **Lileas Graf**
> ""Are you willing to believe the country that funds and protects the BFF will hand them to us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "She sighed."*)

### Węzeł `[291]`
Mówca: **Lileas Graf**
> ""As I said, it was outside of my control, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "She sighed."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[293]`
Mówca: **Narrator**
> "She looked annoyed for a second but gave me a brief smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[294]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[295]`
Mówca: **Lileas Graf**
> ""I have important updates about the increasing tensions on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lileas Graf: ""We are getting reports of more and more demonstrations a..."*)

### Węzeł `[296]`
Mówca: **Lileas Graf**
> ""I also have an update about the increasing tensions on the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Lileas Graf: ""We are getting reports of more and more demonstrations a..."*)

### Węzeł `[297]`
Mówca: **Lileas Graf**
> ""I have some updates about the state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Lileas Graf: "...""*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opin..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lileas Graf: ""I also have an update about the ..."*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lileas Graf: ""We'll keep it brief. I think tha..."*)

### Węzeł `[301]`
Mówca: **Lileas Graf**
> ""I also have an update about the state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "Lileas Graf: "...""*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Lileas Graf: "..."`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Lileas stood up."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lileas Graf: ""I also have an update about the in..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: ""I also have an update about the increasing tensions on t..."*)

### Węzeł `[304]`
Mówca: **Lileas Graf**
> ""Anyway, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false &&  Base..."*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[306]`
Mówca: **Lileas Graf**
> ""Anyway, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[307]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Lileas Graf: ""Anyway, Mr. President...""*)

### Węzeł `[308]`
Mówca: **Lileas Graf**
> ""We are getting reports of more and more demonstrations against the government, with some having the potential to become violent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Lileas Graf: ""Karl and I are watching the situation closely.""*)

### Węzeł `[309]`
Mówca: **Nia Morgna**
> ""I am sorry, Mr. President. I am just reporting on the current situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Nia nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[312]`
Mówca: **Nia Morgna**
> ""Thank you for your kind words, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Lileas Graf: ""Nonsense.""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: ""Enough with this, Ms. Morgna. I will not allow you to wo..."*)
  - -> `[321]` (*Player: ""You will have to learn to respect my decision.""*)
  - -> `[317]` (*Player: ""That is pure slander. I didn't do anything against the B..."*)
  - -> `[323]` (*Player: ""What are your concerns?""*)

### Węzeł `[316]`
Mówca: **Lileas Graf**
> ""Nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: ""Enough with this, Ms. Morgna. I will not allow you to wo..."*)
  - -> `[321]` (*Player: ""You will have to learn to respect my decision.""*)
  - -> `[317]` (*Player: ""That is pure slander. I didn't do anything against the B..."*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That is pure slander. I didn't do anything against the Bludish people.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[316]` (Lileas Graf), `[116]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Nia Morgna: ""Fine. Mr. President. I will just be quiet from now on.""*)

### Węzeł `[318]`
Mówca: **Nia Morgna**
> ""Really, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Lileas Graf: ""I think we should just move on.""*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lileas Graf: ""I have important updates about our operation against the..."*)

### Węzeł `[320]`
Mówca: **Lileas Graf**
> ""I think we should just move on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You will have to learn to respect my decision.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[316]` (Lileas Graf), `[116]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Nia Morgna: ""Fine. Mr. President. I will just be quiet from now on.""*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough with this, Ms. Morgna. I will not allow you to work against me anymore.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[316]` (Lileas Graf), `[116]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Nia Morgna: ""Fine. Mr. President. I will just be quiet from now on.""*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are your concerns?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[116]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Nia Morgna: ""Really, Mr. President?""*)

### Węzeł `[324]`
Mówca: **Nia Morgna**
> ""Fine. Mr. President. I will just be quiet from now on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Lileas Graf: ""I think we should just move on.""*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Lileas stood up."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opini..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  ..."*)
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Lileas Graf: ""I've been personally leading the ground operations to le..."*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true   or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15) && BaseGame.Policy_Law_EmergencyDecree == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opini..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15) && BaseGame.Policy_Law_EmergencyDecree == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15)  and  Variable["BaseGame.Policy_Law_EmergencyDecree"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "Lileas stood up."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15) && BaseGame.Policy_Law_EmergencyDecree == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15)  and  Variable["BaseGame.Policy_Law_EmergencyDecree"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lileas Graf: ""We'll keep it brief. I think that will be all for our in..."*)

### Węzeł `[334]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Lileas Graf: ""I have important updates about the increasing tensions o..."*)

### Węzeł `[335]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_EmergencyDecree == true"*)
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_EmergencyDecree == true)"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_EmergencyDecree == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_EmergencyDecree"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "Lileas stood up."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_EmergencyDecree == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_EmergencyDecree"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Narrator: "Lileas stood up."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lileas Graf: ""I have some updates about the state of emergency.""*)

### Węzeł `[339]`
Mówca: **Narrator**
> "Lileas stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lileas Graf: ""We'll keep it brief. I think that will be all for our in..."*)

### Węzeł `[340]`
Mówca: **Lileas Graf**
> ""We'll keep it brief. I think that will be all for our internal affairs update.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)

### Węzeł `[341]`
Mówca: **Nia Morgna**
> ""See you later, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "They took their entourage and left the room."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "They took their entourage and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[343]`
Mówca: **Lileas Graf**
> ""Unfortunately, due to the lack of security resources, operations were delayed because of unforeseen circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Lileas Graf: ""This led to the failure of the operation.""*)

### Węzeł `[344]`
Mówca: **Narrator**
> "They gathered their documents."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Nia Morgna: ""See you later, Mr. President.""*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Lileas Graf: ""Karl Greiser has been leading the operations on the grou..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == false || Bas..."*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == false || Bas..."*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Decreased == false || B..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true  ..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Decreased == false || BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  or  Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lileas Graf: ""Karl Greiser has been leading the operations on the grou..."*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lileas Graf: ""We'll keep it brief. I think that..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lileas Graf: ""We'll keep it brief. I think that will be all for our in..."*)

### Węzeł `[355]`
Mówca: **Lileas Graf**
> ""Due to the interference of Governor Ersen, our operation against the BFF has failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""What happened? Tell me.""*)
  - -> `[377]` (*Player: ""I thought I could trust you with this. You disappointed ..."*)
  - -> `[378]` (*Player: ""That's worrying, indeed.""*)
  - -> `[375]` (*Player: ""So, you're still coming to me with excuses?""*)

### Węzeł `[356]`
Mówca: **Lileas Graf**
> ""Due to the interference of Governor Bron, our operation against the BFF has failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""What happened? Tell me.""*)
  - -> `[377]` (*Player: ""I thought I could trust you with this. You disappointed ..."*)
  - -> `[378]` (*Player: ""That's worrying, indeed.""*)
  - -> `[375]` (*Player: ""So, you're still coming to me with excuses?""*)

### Węzeł `[357]`
Mówca: **Lileas Graf**
> ""Due to the interference of Governor Krull, our operation against the BFF has failed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Player: ""What happened? Tell me.""*)
  - -> `[377]` (*Player: ""I thought I could trust you with this. You disappointed ..."*)
  - -> `[378]` (*Player: ""That's worrying, indeed.""*)
  - -> `[375]` (*Player: ""So, you're still coming to me with excuses?""*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Lileas Graf: ""By the joint efforts of the Sordish Intelligence Directo..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Lileas Graf: ""By the joint efforts of the Sordish Intelligence Directo..."*)

### Węzeł `[361]`
Mówca: **Lileas Graf**
> ""By the joint efforts of the Sordish Intelligence Directorate and the Sordish Police Force, we managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lileas Graf: ""We surrounded and raided the location, eliminating four ..."*)

### Węzeł `[362]`
Mówca: **Lileas Graf**
> ""By the joints efforts of the Sordish Intelligence Directorate and Mr. Ejall's contacts, we have managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: ""With a massive operation, we have surrounded and raided ..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Lileas Graf: ""By the joints efforts of the Sordish Intelligence Direct..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Lileas Graf: ""By the joints efforts of the Sordish Intelligence Direct..."*)

### Węzeł `[366]`
Mówca: **Lileas Graf**
> ""By the joints efforts of the Sordish Intelligence Directorate and the Sordish Police Force, we have managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Lileas Graf: ""With a massive operation, we have surrounded and raided ..."*)

### Węzeł `[367]`
Mówca: **Lileas Graf**
> ""By the joints efforts of the Sordish Intelligence Directorate and Mr. Ejall's contacts, we have managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lileas Graf: ""Our raid was delayed due to logistical issues, and our m..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true"*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)"*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Lileas Graf: ""By the joints efforts of the Sordish Intelligence Direct..."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Lileas Graf: ""By the joints efforts of the Sordish Intelligence Direct..."*)

### Węzeł `[371]`
Mówca: **Lileas Graf**
> ""By the joints efforts of the Sordish Intelligence Directorate and the Sordish Police Force, we have managed to locate the secret meeting spot of the BFF leaders close to our southern border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Lileas Graf: ""Our raid was delayed due to logistical issues, and our m..."*)

### Węzeł `[372]`
Mówca: **Lileas Graf**
> ""There isn't anything I could do about this, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Lileas Graf: ""I expected you to be more fair. You know I didn't even l..."*)

### Węzeł `[373]`
Mówca: **Lileas Graf**
> ""It is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lileas Graf: ""Our raid was delayed due to logistical issues, and our m..."*)

### Węzeł `[374]`
Mówca: **Lileas Graf**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lileas Graf: ""Our raid was delayed due to logistical issues, and our m..."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""So, you're still coming to me with excuses?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lileas Graf), `[356]` (Lileas Graf), `[357]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Lileas Graf: ""There isn't anything I could do about this, Mr. Rayne.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What happened? Tell me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lileas Graf), `[356]` (Lileas Graf), `[357]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Lileas Graf: ""Of course.""*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought I could trust you with this. You disappointed the entire administration, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lileas Graf), `[356]` (Lileas Graf), `[357]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Lileas Graf: ""There isn't anything I could do about this, Mr. Rayne.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's worrying, indeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[355]` (Lileas Graf), `[356]` (Lileas Graf), `[357]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Lileas Graf: ""It is.""*)

### Węzeł `[379]`
Mówca: **Lileas Graf**
> ""I expected you to be more fair. You know I didn't even lead the ground operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Lileas Graf: ""Our raid was delayed due to logistical issues, and our m..."*)

### Węzeł `[380]`
Mówca: **Lileas Graf**
> ""Our raid was delayed due to logistical issues, and our massive operation was thwarted when the leaders of the terrorists were signalled about our plan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Lileas Graf: ""They were prepared for the raid and a huge firefight bro..."*)

### Węzeł `[381]`
Mówca: **Lileas Graf**
> ""They were prepared for the raid and a huge firefight broke out in the border town Zeharen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Lileas Graf: ""Unfortunately, a lot of civilians lost their lives in th..."*)

### Węzeł `[382]`
Mówca: **Lileas Graf**
> ""Unfortunately, a lot of civilians lost their lives in the fracas, and the explosions triggered by the BFF militants damaged countless houses and public buildings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Lileas Graf: ""We suspect that all seven leaders of the BFF -- includin..."*)

### Węzeł `[383]`
Mówca: **Lileas Graf**
> ""We suspect that all seven leaders of the BFF -- including Awlan Arge -- managed to escape to Rumburg from the mountains.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player: ""Goddammit, Lileas! How did all seven of them managed to ..."*)
  - -> `[384]` (*Player: ""Ms. Graf. Please give me all the details. How many death..."*)
  - -> `[386]` (*Player: ""It's alright. What's done is done and there's no point a..."*)
  - -> `[385]` (*Player: ""You should have done a better job, Lileas. We've been wo..."*)

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Ms. Graf. Please give me all the details. How many deaths are we talking about here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Lileas Graf: ""The death count from the town is in the twenties but ris..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You should have done a better job, Lileas. We've been working on this for a long time now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lileas Graf: ""As I said, it was outside of my control, Mr. President.""*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's alright. What's done is done and there's no point arguing about it anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "She nodded."*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Goddammit, Lileas! How did all seven of them managed to flee the scene?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[383]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Lileas Graf: ""As I said, it was outside of my control, Mr. President.""*)

### Węzeł `[388]`
Mówca: **Lileas Graf**
> ""As I said, it was outside of my control, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Nia sighed."*)

### Węzeł `[389]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Nia sighed."*)

### Węzeł `[390]`
Mówca: **Narrator**
> "Nia sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Nia Morgna: ""Mr. President. The whole Bludish community is incredibly..."*)

### Węzeł `[391]`
Mówca: **Lileas Graf**
> ""The death count from the town is in the twenties but rising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Narrator: "Nia sighed."*)

### Węzeł `[392]`
Mówca: **Nia Morgna**
> ""Mr. President. The whole Bludish community is incredibly restless. They are already dubbing the incident 'Rayne's Izzam'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Lileas Graf: ""She is right. We suspect that the leaders escaped due to..."*)

### Węzeł `[393]`
Mówca: **Lileas Graf**
> ""She is right. We suspect that the leaders escaped due to Bludish civilians aiding them. This collaboration between them has definitely increased.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Lileas Graf: ""And this unfortunate event will likely increase their su..."*)

### Węzeł `[394]`
Mówca: **Lileas Graf**
> ""And this unfortunate event will likely increase their support further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == true)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Lileas Graf: ""What makes it worse is that Governor Ersen actively work..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Lileas Graf: ""What makes it worse is that Governor Bron has ignored ou..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Lileas Graf: ""What makes it worse is that Governor Krull has ignored o..."*)

### Węzeł `[401]`
Mówca: **Lileas Graf**
> ""What makes it worse is that Governor Ersen actively worked against our operation and is now openly condemning the government as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Lileas Graf: ""I'm afraid the autonomous zone has given the Bluds the i..."*)

### Węzeł `[402]`
Mówca: **Lileas Graf**
> ""What makes it worse is that Governor Bron has ignored our plans and followed through with his separate operation, which resulted in more violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lileas Graf: ""Not abolishing the Special Zone is proving to be a bad m..."*)

### Węzeł `[403]`
Mówca: **Lileas Graf**
> ""What makes it worse is that Governor Krull has ignored our plans and followed through with his separate operation. And now he is openly blaming the government for the incident.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Lileas Graf: ""Not abolishing the Special Zone is proving to be a bad m..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsBoth = true;
BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsBoth = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsBoth"] = true;
Variable["BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsBoth"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""If you ask me, this already makes Bergia more democratic..."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsReligiousHarmony = true;
BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsReligiousHarmony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsReligiousHarmony"] = true;
Variable["BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsReligiousHarmony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""If you ask me, this already makes Bergia more democratic..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsLanguageBill = true;
BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsLanguageBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_R_GovernorErsen_CancelsLanguageBill"] = true;
Variable["BaseGameSupport.News_Turn08_HP_GovernorErsen_CancelsLanguageBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""If you ask me, this already makes Bergia more democratic..."*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Internal affairs was first on the list of items. Lileas a..."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_DisputeWithGovernor_Autonomy = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_DisputeWithGovernor_Autonomy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Nia Morgna: ""Mr. President. I want to congratulate you again on your ..."*)

### Węzeł `[409]`
Mówca: **Lileas Graf**
> ""Not abolishing the Special Zone is proving to be a bad move. The governor and the regional forces are becoming increasingly independent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player: ""You have to accept the responsibility for this incident,..."*)
  - -> `[417]` (*Player: ""You're right, Ms. Graf. I should have listened to you.""*)
  - -> `[416]` (*Player: ""This is bad. Really bad.""*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opin..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Lileas Graf: ""I'm afraid that's not all, Mr. President.""*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinion <= -15 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -10  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Lileas Graf: ""In any case, I will do my best before the incident explo..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lileas Graf: ""I also have an update about the in..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Lileas Graf: ""I also have an update about the increasing tensions on t..."*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Lileas Graf: ""We'll keep it brief. I think that..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lileas Graf: ""We'll keep it brief. I think that will be all for our in..."*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You have to accept the responsibility for this incident, Ms. Graf. Don't look elsewhere for excuses.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lileas Graf), `[419]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is bad. Really bad.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lileas Graf), `[419]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right, Ms. Graf. I should have listened to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Lileas Graf), `[419]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are being overly dramatic, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[419]`
Mówca: **Lileas Graf**
> ""I'm afraid the autonomous zone has given the Bluds the incentive to push for further decentralization. If we allow this to go on, don't be surprised when they get support from foreign powers for their independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""You are being overly dramatic, Ms. Graf.""*)
  - -> `[415]` (*Player: ""You have to accept the responsibility for this incident,..."*)
  - -> `[417]` (*Player: ""You're right, Ms. Graf. I should have listened to you.""*)
  - -> `[416]` (*Player: ""This is bad. Really bad.""*)

### Węzeł `[420]`
Mówca: **Lileas Graf**
> ""In any case, I will do my best before the incident explodes out of proportion. We can't have the Bludish exploit the situation again by fabricating another Izzam.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "She took a look at her watch."*)

### Węzeł `[421]`
Mówca: **Narrator**
> "She took a look at her watch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lileas Graf: ""We'll keep it brief. I think tha..."*)

### Węzeł `[422]`
Mówca: **Lileas Graf**
> ""I'm afraid that's not all, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "Jump to: [Lileas Graf: ""I also have an update about the ..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion -= 4`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "She stopped and looked pointedly at Lileas."*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Lileas Graf: ""Rest assured, our police forces will not let the situati..."*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_DecreasedInteriorFunding == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_DecreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Lileas Graf: ""However, due to the lack of funds, I am deeply concerned..."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_DecreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "She placed a stack of papers in front of me."*)

### Węzeł `[430]`
Mówca: **Lileas Graf**
> ""Rest assured, our police forces will not let the situation get out of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "She placed a stack of papers in front of me."*)

### Węzeł `[431]`
Mówca: **Lileas Graf**
> ""Karl and I are watching the situation closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == true"*)

### Węzeł `[432]`
Mówca: **Lileas Graf**
> ""However, due to the lack of funds, I am deeply concerned about the possibility of the situation getting out of control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Lileas Graf: ""If that were to happen, our forces may not be prepared t..."*)

### Węzeł `[433]`
Mówca: **Lileas Graf**
> ""If that were to happen, our forces may not be prepared to counter the threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "She placed a stack of papers in front of me."*)

### Węzeł `[434]`
Mówca: **Narrator**
> "She placed a stack of papers in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Lileas Graf: ""The security committee of the Assembly is working on a d..."*)

### Węzeł `[435]`
Mówca: **Lileas Graf**
> ""The security committee of the Assembly is working on a draft law that would help strengthen our internal security in times of crisis. Such as now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Lileas Graf: ""I've been following their work and I truly believe they'..."*)

### Węzeł `[436]`
Mówca: **Lileas Graf**
> ""I've been following their work and I truly believe they've done an exemplary job with this. Mr. Holstron -- who has been working on this for quite some time -- has made some great arguments for the bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player: ""Tell me about this bill.""*)
  - -> `[438]` (*Player: ""If it's Mr. Holstron's work, I'm sure I'll be vetoing it.""*)
  - -> `[439]` (*Player: ""I'll think about that when -- and if -- the Assembly app..."*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me about this bill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lileas Graf), `[441]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lileas Graf: ""Firstly, it aims to grant the necessary authority to the..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If it's Mr. Holstron's work, I'm sure I'll be vetoing it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Lileas Graf: ""You should be taking this more seriously, Mr. President.""*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll think about that when -- and if -- the Assembly approves it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Lileas Graf), `[441]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Lileas Graf: ""Fair enough...""*)

### Węzeł `[440]`
Mówca: **Lileas Graf**
> ""Fair enough...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Lileas Graf: ""But at least allow me to give you a brief description of..."*)

### Węzeł `[441]`
Mówca: **Lileas Graf**
> ""You should be taking this more seriously, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Player: ""Tell me about this bill.""*)
  - -> `[439]` (*Player: ""I'll think about that when -- and if -- the Assembly app..."*)

### Węzeł `[442]`
Mówca: **Lileas Graf**
> ""Firstly, it aims to grant the necessary authority to the police forces on the ground to enable quick and decisive responses in situations where public security is at risk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Lileas Graf: ""It will also remove several legal limits that were presc..."*)

### Węzeł `[443]`
Mówca: **Lileas Graf**
> ""It will also remove several legal limits that were prescribed for the forces -- allowing them to function much more efficiently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I like the sound of it.""*)
  - -> `[445]` (*Player: ""I'm sorry. I don't think I'll be supporting this bill.""*)
  - -> `[446]` (*Player: ""This sounds all too vague. What legal limits are you tal..."*)

### Węzeł `[444]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I like the sound of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Lileas Graf), `[448]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Nia Morgna: ""Are you serious?""*)

### Węzeł `[445]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry. I don't think I'll be supporting this bill.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Lileas Graf), `[448]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Lileas Graf: ""You are clearly not seeing the threats.""*)

### Węzeł `[446]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This sounds all too vague. What legal limits are you talking about here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[443]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Lileas Graf: ""It removes the prerequisites of warrants and substantial..."*)

### Węzeł `[447]`
Mówca: **Lileas Graf**
> ""It removes the prerequisites of warrants and substantial evidence, allowing for suspicion-based arrests and confiscations if the forces believe the targets to be potential threats to public safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Lileas Graf: ""It also adds a clause which allows security forces to ex..."*)

### Węzeł `[448]`
Mówca: **Lileas Graf**
> ""It also adds a clause which allows security forces to exercise their authority beyond their legal limits *only if* it is deemed essential for maintaining state security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""I like the sound of it.""*)
  - -> `[445]` (*Player: ""I'm sorry. I don't think I'll be supporting this bill.""*)
  - -> `[449]` (*Player: ""This is insane, Lileas. I'm not going to turn Sordland i..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""This is insane, Lileas. I'm not going to turn Sordland into a police state.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[450]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Lileas Graf: ""Hmm. An interesting comment, coming from you.""*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Lileas Graf: ""You are clearly not seeing the threats.""*)

### Węzeł `[453]`
Mówca: **Lileas Graf**
> ""Hmm. An interesting comment, coming from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Lileas Graf: ""I suppose you'd rather such actions remained behind clos..."*)

### Węzeł `[454]`
Mówca: **Lileas Graf**
> ""I suppose you'd rather such actions remained behind close doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "Nia raised an eyebrow."*)

### Węzeł `[455]`
Mówca: **Lileas Graf**
> ""You are clearly not seeing the threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Nia Morgna: ""You are creating them yourself, Lileas.""*)

### Węzeł `[456]`
Mówca: **Nia Morgna**
> ""Are you serious?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Lileas Graf: ""You are clearly not seeing the threats.""*)

### Węzeł `[457]`
Mówca: **Lileas Graf**
> ""You are clearly not seeing the threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "Lileas sighed."*)

### Węzeł `[458]`
Mówca: **Narrator**
> "Nia raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Lileas Graf: ""In any case...""*)

### Węzeł `[459]`
Mówca: **Nia Morgna**
> ""You are creating them yourself, Lileas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Narrator: "Lileas sighed."*)

### Węzeł `[460]`
Mówca: **Narrator**
> "Lileas sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Lileas Graf: ""In any case...""*)

### Węzeł `[461]`
Mówca: **Lileas Graf**
> ""In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Lileas Graf: ""That's all from me about the security bill.""*)

### Węzeł `[462]`
Mówca: **Lileas Graf**
> ""That's all from me about the security bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "They both stood up."*)

### Węzeł `[463]`
Mówca: **Narrator**
> "They both stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Lileas Graf: ""We'll keep it brief. I think that will be all for our in..."*)

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Nia Morgna: ""Mr. President. Many of my colleagues in the ministry are..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_SemiAutonomy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "BaseGame.BergiaSpecialZone_Proposal_Centralization == true"*)
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BergiaSpecialZone_Proposal_Centralization == t..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BergiaSpecialZone_Proposal_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Lileas Graf: ""Mr. President. Many of my colleagues in the ministry are..."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BergiaSpecialZone_Proposal_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BergiaSpecialZone_Proposal_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[470]`
Mówca: **Nia Morgna**
> ""Mr. President. Many of my colleagues in the ministry are disappointed by the lack of action taken by the government about the Autonomous Zone project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Nia Morgna: ""They've worked day and night to make this a possibility.""*)

### Węzeł `[471]`
Mówca: **Nia Morgna**
> ""They've worked day and night to make this a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Lileas Graf: ""I'm sorry, but what did you expect? That project was doo..."*)

### Węzeł `[472]`
Mówca: **Lileas Graf**
> ""I'm sorry, but what did you expect? That project was doomed to fail.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[473]`
Mówca: **Lileas Graf**
> ""Mr. President. Many of my colleagues in the ministry are disappointed by the lack of action taken by the government about the abolishment of the Special Zone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Lileas Graf: ""We've worked day and night to make it a possibility.""*)

### Węzeł `[474]`
Mówca: **Lileas Graf**
> ""We've worked day and night to make it a possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Re..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Re..."*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame...."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Lileas Graf: ""You could have passed it by decree if you hadn't taken t..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Weaker == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Weaker"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)

### Węzeł `[478]`
Mówca: **Lileas Graf**
> ""You could have passed it by decree if you hadn't taken that authority away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[479]`
Mówca: **Lileas Graf**
> ""You could have passed it by decree if you hadn't completely removed those powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.R..."*)
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame..."*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Lileas Graf: ""You could have passed it by decree if you hadn't complet..."*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Law_Decrees_Removed == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Lileas Graf: ""But you decided not to sign the decree.""*)

### Węzeł `[483]`
Mówca: **Lileas Graf**
> ""But you decided not to sign the decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Lileas Graf: ""Frankly, this was a huge disappointment.""*)

### Węzeł `[484]`
Mówca: **Lileas Graf**
> ""Frankly, this was a huge disappointment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Player: ""Frankly, I don't care about your disappointment, Lileas.""*)
  - -> `[485]` (*Player: ""Lileas, I appreciate your dedication and the effort you ..."*)
  - -> `[487]` (*Player: ""I understand your disappointment but you have to learn t..."*)
  - -> `[488]` (*Player: ""I am disappointed too. There is nothing we can do about ..."*)

### Węzeł `[485]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lileas, I appreciate your dedication and the effort you put into those plans. I understand your frustration, but there was nothing I could do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She simply nodded."*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Frankly, I don't care about your disappointment, Lileas.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She simply nodded."*)

### Węzeł `[487]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I understand your disappointment but you have to learn to respect my decisions, Ms. Graf.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She simply nodded."*)

### Węzeł `[488]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am disappointed too. There is nothing we can do about it now. Let's talk about the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[484]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "She simply nodded."*)

### Węzeł `[489]`
Mówca: **Narrator**
> "She simply nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lileas Graf: ""Mr. President. Governor Bron is still causing problems w..."*)

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Lileas Graf: ""Mr. President. Governor Krull is still causing problems ..."*)

### Węzeł `[493]`
Mówca: **Lileas Graf**
> ""Mr. President. Governor Krull is still causing problems with my forces. He is no different than Mr. Bron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Lileas Graf: ""The lack of action taken in this arena is disappointing.""*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I am disappointed about Governor Krull's attitude as well. But we must try to find solutions instead of blaming each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[495]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[495]`
Mówca: **Lileas Graf**
> ""The lack of action taken in this arena is disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Player: ""I wish it was up to me, Lileas. But you know it isn't.""*)
  - -> `[47]` (*Player: ""Lileas, I appreciate your dedication to the revocation o..."*)
  - -> `[48]` (*Player: ""You know as well as I do that there wasn't much that I c..."*)
  - -> `[49]` (*Player: ""I understand your disappointment but you have to learn t..."*)
  - -> `[494]` (*Player: ""I am disappointed about Governor Krull's attitude as wel..."*)

### Węzeł `[496]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish it was up to me, Lileas. But you know it isn't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Lileas Graf), `[495]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "She simply nodded."*)

### Węzeł `[497]`
Mówca: **Narrator**
> "As she sat down, Lileas caught my eye and gave me a knowing nod. Karl and the SSP had done the job requested of them, presumably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Lileas Graf: ""Shall we begin?""*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true ||BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == ..."*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia =..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true ||BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "As she sat down, Lileas caught my eye and gave me a knowi..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia == true ||BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia == true || BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true || BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestLivia"] == true  or Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true  or  Variable["BaseGame.Turn08_SecondScandal_SecretState_ArrestPetr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)

### Węzeł `[501]`
Mówca: **Lileas Graf**
> ""No new secretary yet? I hope this means Ms. Suno's replacement is getting an extremely thorough background check.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Lileas Graf: ""Needless to say, such an egregious breach of security sh..."*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_Detained_Livia == true || B..."*)
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_Detained_Livia == true ||..."*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Narrator: "Lileas cast an eye around the room."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_Detained_Livia == true || BaseGame.Turn08_SecondScandal_LiviaTrialled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_Detained_Livia"] == true  or  Variable["BaseGame.Turn08_SecondScandal_LiviaTrialled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaFired == true"*)

### Węzeł `[505]`
Mówca: **Narrator**
> "Lileas cast an eye around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Lileas Graf: ""No new secretary yet? I hope this means Ms. Suno's repla..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaFired == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn08_SecondScandal_LiviaFired == true"*)
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn08_SecondScandal_LiviaFired == true)"*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn08_SecondScandal_LiviaFired == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Narrator: "Lileas cast an eye around the room."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn08_SecondScandal_LiviaFired == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_LiviaFired"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Lileas Graf: ""Shall we begin?""*)

### Węzeł `[509]`
Mówca: **Narrator**
> "Lileas cast an eye around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Lileas Graf: ""I still don't understand why you fired that secretary of..."*)

### Węzeł `[510]`
Mówca: **Lileas Graf**
> ""I still don't understand why you fired that secretary of yours. She seemed like a competent young lady.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Lileas Graf: ""Shall we begin?""*)

### Węzeł `[511]`
Mówca: **Lileas Graf**
> ""Shall we begin?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player: ""Yes, please do.""*)
  - -> `[512]` (*Player: ""I hope you've got only good news for me.""*)
  - -> `[513]` (*Player: ""Tell me what's been going on in Bergia.""*)

### Węzeł `[512]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I hope you've got only good news for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[511]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me what's been going on in Bergia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[511]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[514]`
Mówca: **Nia Morgna**
> ""Well, you've certainly got your work cut out for you after...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion -= 4"*)

### Węzeł `[515]`
Mówca: **Lileas Graf**
> ""Needless to say, such an egregious breach of security should be met with harsh consequences. But you know that already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Lileas Graf: ""Shall we begin?""*)

### Węzeł `[516]`
Mówca: **Lileas Graf**
> ""But at least allow me to give you a brief description of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Lileas Graf: ""Firstly, it aims to grant the necessary authority to the..."*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn08_Wehlen_BFFMilitantsCaptured = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn08_Wehlen_BFFMilitantsCaptured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Lileas Graf: ""Wehzek authorities captured Arge and his two captains tr..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn08_Rumburg_BFFMilitantsCaptured = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn08_Rumburg_BFFMilitantsCaptured"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lileas Graf: ""As a matter of fact, both the Wehzek and Rumburgian auth..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Au..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == false && Base..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false &..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true && (BaseGame.Policy_Order_IncreasedInteriorFunding == true || BaseGame.Policy_Order_CommunityPolice == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true && (BaseGame.Policy_Order_IncreasedInteriorFunding == true || BaseGame.Policy_Order_CommunityPolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  (Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true  or  Variable["BaseGame.Policy_Order_CommunityPolice"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated = true; Bas..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true && (BaseGame.Policy_Order_IncreasedInteriorFunding == true || BaseGame.Policy_Order_CommunityPolice == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true  and  (Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true  or  Variable["BaseGame.Policy_Order_CommunityPolice"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == false &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn07_LanguageBill_Signed == false && Base..."*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn07_LanguageBill_Signed == false && Ba..."*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn07_LanguageBill_Signed == false &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == false  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated = true; Bas..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn07_LanguageBill_Signed == false &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == false && BaseGame.Wehlen_JointOperation == false && BaseGame.Reform_BludishRights_Amendment_Proposal == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == false  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == false  and  Variable["BaseGame.Wehlen_JointOperation"] == false  and  Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation == true"*)
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation == true)"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_CounterTerrorismOperation = false"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_ZeharenIncident = true; Ba..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged == true"*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Damaged == true)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Damaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_BFFOperation_Damaged = tru..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Damaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Damaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed == true"*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed == true"*)
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Destroyed == true)"*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true  || BaseGame.Me..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_BFFOperation_Fail = true; ..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_ZeharenIncident = true;
BaseGameSupport.News_Turn08_LT_ZeharenIncident = true;
BaseGameSupport.News_Turn08_R_ZeharenIncident = true;
BaseGame.Situation_Order_BFF_ThreatAlarming = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;
BaseGameSupport.CountryReport_Turn08_Rumburg_BludishHumanitarianCrisis = true;
BaseGame.LateGameCrisis += 1;
BaseGame.Economy -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_ZeharenIncident"] = true;
Variable["BaseGameSupport.News_Turn08_LT_ZeharenIncident"] = true;
Variable["BaseGameSupport.News_Turn08_R_ZeharenIncident"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;
Variable["BaseGameSupport.CountryReport_Turn08_Rumburg_BludishHumanitarianCrisis"] = true;
Variable["BaseGame.LateGameCrisis"] = Variable["BaseGame.LateGameCrisis"] + 1;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_BFFOperation_Damaged = true; 
BaseGame.Situation_Order_BFF_ThreatContinues = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = false;
BaseGameSupport.CountryReport_Turn08_Wehlen_BFFActivityStrengthened = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_BFFOperation_Damaged"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;
Variable["BaseGameSupport.CountryReport_Turn08_Wehlen_BFFActivityStrengthened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_BFFOperation_Success = true;
BaseGameSupport.News_Turn08_LT_BFFOperation_Success = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatAlarming = false;
BaseGame.Situation_Order_BFF_ThreatContinues = false;
BaseGameSupport.CountryReport_Turn08_Wehlen_BFFRemnantsHung = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_BFFOperation_Success"] = true;
Variable["BaseGameSupport.News_Turn08_LT_BFFOperation_Success"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;
Variable["BaseGameSupport.CountryReport_Turn08_Wehlen_BFFRemnantsHung"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true  || BaseGame.Media_Censored == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true  || BaseGame.Me..."*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true  || BaseGame...."*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true  || BaseGame.Media_Censored == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true   or  Variable["BaseGame.Media_Censored"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_ST_Deal_BFFOperation_Success ..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true  || BaseGame.Media_Censored == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true   or  Variable["BaseGame.Media_Censored"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_BFFOperation_Success = tru..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_ST_Deal_BFFOperation_Success = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_ST_Deal_BFFOperation_Success"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn08_HP_BFFOperation_Success = tru..."*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn08_HP_BFFOperation_Fail = true;
BaseGame.Situation_Order_BFF_ThreatEliminated = false;
BaseGame.Situation_Order_BFF_ThreatAlarming = false;
BaseGame.Situation_Order_BFF_ThreatContinues = true;
BaseGameSupport.CountryReport_Turn08_Rumburg_BludishHumanitarianCrisis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn08_HP_BFFOperation_Fail"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = false;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = true;
Variable["BaseGameSupport.CountryReport_Turn08_Rumburg_BludishHumanitarianCrisis"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "They gathered their documents."*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_CounterTerrorismOperation = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Order_CounterTerrorismOperation"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated = true; Bas..."*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || B..."*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming = true; BaseG..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true || BaseGame.Bludish_Opinion <= -15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn07_LanguageBill_Signed == true && Base..."*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Bill_Turn07_LanguageBill_Signed == true && Base..."*)
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Bill_Turn07_LanguageBill_Signed == true && Ba..."*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming = true; BaseG..."*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Bill_Turn07_LanguageBill_Signed == true &&
BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true) && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone == false && BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == false)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Bill_Turn07_LanguageBill_Signed"] == true  and 
Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true)  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_AutonomousZone"] == false  and  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true && BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true && BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatEliminated = true; Bas..."*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true && BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true  and  Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Auto..."*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatEliminated = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatEliminated"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false && BaseGame.Situation_Law_BludishOppression == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false &..."*)
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == false..."*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false && BaseGame.Situation_Law_BludishOppression == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false  and  Variable["BaseGame.Situation_Law_BludishOppression"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_BFF_ThreatAlarming = true; BaseG..."*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == false && BaseGame.Situation_Law_BludishOppression == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false  and  Variable["BaseGame.Situation_Law_BludishOppression"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_BFF_ThreatAlarming = true;
BaseGame.Situation_Order_BFF_ThreatContinues = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_BFF_ThreatAlarming"] = true;
Variable["BaseGame.Situation_Order_BFF_ThreatContinues"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Game_MakeSordlandGreatAgain");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Game_MakeSordlandGreatAgain");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false && 
BaseGame.Policy_Law_AutonomousZoneOfBergia == false && BaseGame.Turn04_SnO_LE_Interior_Increased == true && BaseGame.BFF_Destroyed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_SpecialZoneOfBergia == false &&  Base..."*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_SpecialZoneOfBergia == false &&  Ba..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_SpecialZoneOfBergia == false && 
BaseGame.Policy_Law_AutonomousZoneOfBergia == false && BaseGame.Turn04_SnO_LE_Interior_Increased == true && BaseGame.BFF_Destroyed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  
Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  and  Variable["BaseGame.BFF_Destroyed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Game_MakeSordlandGreatAgain");"*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_SpecialZoneOfBergia == false && 
BaseGame.Policy_Law_AutonomousZoneOfBergia == false && BaseGame.Turn04_SnO_LE_Interior_Increased == true && BaseGame.BFF_Destroyed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_SpecialZoneOfBergia"] == false  and  
Variable["BaseGame.Policy_Law_AutonomousZoneOfBergia"] == false  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  and  Variable["BaseGame.BFF_Destroyed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -10 || BaseGame.Bludish_Opinio..."*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || (Bas..."*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || (B..."*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Lileas Graf: ""Despite eliminating several leaders of the BFF, our oper..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Lileas Graf: ""Despite eliminating several terrorists, our operations w..."*)

### Węzeł `[580]`
Mówca: **Lileas Graf**
> ""Despite eliminating several terrorists, our operations were disrupted...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Lileas Graf: ""I suspect our new governor had a hand in this. The auton..."*)

### Węzeł `[581]`
Mówca: **Lileas Graf**
> ""I suspect our new governor had a hand in this. The autonomous zone wasn't a good idea. He is already interfering with internal security matters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Lileas Graf: ""Unfortunately, due to the lack of security resources, op..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || Ba..."*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Decision_Turn04_RegionalInvestment_Bergia == true || (BaseGame.Turn04_SnO_LE_Interior_Decreased == false && BaseGame.YoungSords_Aids_Security == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Decision_Turn04_RegionalInvestment_Bergia"] == true  or  (Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false  and  Variable["BaseGame.YoungSords_Aids_Security"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Lileas Graf: ""Of course, he didn't allow the central government to do ..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true |..."*)
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lileas Graf: ""Of course, I still had to directly intervene on critical..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_Wehlen_JointOperation == true || BaseGame.Policy_Diplomacy_Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_Wehlen_JointOperation"] == true  or  Variable["BaseGame.Policy_Diplomacy_Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAs..."*)
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrant..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Lileas Graf: ""Of course, I still had to directly intervene on critical..."*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum == true && BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == false && BaseGame.Turn08_SecondScandal_RumburgBlamed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn07_RumburgWhistleblower_DontGrantAsylum"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == false  and  Variable["BaseGame.Turn08_SecondScandal_RumburgBlamed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lileas Graf: ""Despite not reaching all of our targets, the operation c..."*)

### Węzeł `[591]`
Mówca: **Lileas Graf**
> ""And I must say... It paid off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed = true; BaseGame.Situation_Order_B..."*)

### Węzeł `[592]`
Mówca: **Lileas Graf**
> ""Of course, he didn't allow the central government to do its job properly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Lileas Graf: ""With rushed decisions, delayed communications and the go..."*)

### Węzeł `[593]`
Mówca: **Lileas Graf**
> ""With rushed decisions, delayed communications and the governor's forces adopting an unnecessarily aggressive strategy at the last minute, the operation has unfortunately failed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: ""What happened? Tell me.""*)
  - -> `[282]` (*Player: ""I thought I could trust you with this. You disappointed ..."*)
  - -> `[283]` (*Player: ""That's worrying, indeed.""*)
  - -> `[272]` (*Player: ""So, you're still coming to me with excuses?""*)
