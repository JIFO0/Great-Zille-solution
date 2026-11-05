# Rizia/Turn 10/AxelVina_Unity

- **ID konwersacji:** `331`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 10`
- **Lokalizacja pliku:** `Rizia/Turn_10/331_AxelVina_Unity.md`
- **Liczba węzłów dialogowych:** 620
- **Liczba wyborów gracza:** 129

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[93]** Player_Romus_Italic *(Gracz)*
- **[94]** Axel Reinhart
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Rumburg_War`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon`
- `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras`
- `RiziaDLC.BirthdayGathering_ViolentAction`
- `RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike`
- `RiziaDLC.Birthday_WarnedAboutCoup`
- `RiziaDLC.Diplomacy_Pales_GRACEApplication`
- `RiziaDLC.Ending_Coup_Azaro`
- `RiziaDLC.Ending_Coup_Sazon`
- `RiziaDLC.Ending_Coup_Toras`
- `RiziaDLC.Ending_Revolution`
- `RiziaDLC.HouseAzaro_Conquered`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.HouseToras_Conquered`
- `RiziaDLC.Intermerkopum_Failed`
- `RiziaDLC.Lucita_Arrested`
- `RiziaDLC.Lucita_Executed`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.Pabel_RelationshipPublic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP`
- `RiziaDLC.Policy_Diplomacy_GRACEMember`
- `RiziaDLC.Policy_Diplomacy_Intermerkopum`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Monqiz_PartyPrince`
- `RiziaDLC.PromiseToAbdicate`
- `RiziaDLC.Promised_Succession_Son_RespectTradition`
- `RiziaDLC.Reform_Regions_Centralized`
- `RiziaDLC.Reform_Success`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Situation_Law_RoyalTraditions_Broken`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_ViolentProtests_Valenqiris`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vendonesam_Lose`
- `RiziaDLC.Vina_KeepsLastName`
- `RiziaDLC.ZilleReturn_Success`
- `RiziaDLCIsolated.AxelConcerned`
- `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Pales_Rizia_Unification`
- `RiziaDLC.PersonalValue_Drinking`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLCIsolated.AxelConcerned`
- `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink`
- `RiziaDLCSupport.Codex_Locations_Countries_Pales`
- `RiziaDLCSupport.Codex_Locations_Regions_PAD`
- `RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree`
- `RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree`
- `RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree`
- `RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree`
- `RiziaDLCSupport.Reports_Turn10_Pales_Peace`
- `RiziaDLCText.GRACECountries`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[21]` | **""Indeed, Axel. Well said.""** | `[19]` **Narrator**: "My eyes were on Vina as she was ..."<br>`[212]` **Narrator**: "My eyes were on Vina and Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Axel Reinhart**: ""To be honest, it's your daughte..." |
| `[22]` | **""Look at her, Axel. I feel like she's more at home here than in any palace or court.""** | `[19]` **Narrator**: "My eyes were on Vina as she was ..."<br>`[212]` **Narrator**: "My eyes were on Vina and Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[26]` **Axel Reinhart**: ""Perhaps so. She definitely has ..." |
| `[23]` | **""Tell me. Is the marriage faring well?""** | `[19]` **Narrator**: "My eyes were on Vina as she was ..."<br>`[212]` **Narrator**: "My eyes were on Vina and Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Axel Reinhart**: ""Tremendously, actually. We both..." |
| `[24]` | **""I'm glad everything is going great between the two of you. I hope it stays that w..."** | `[19]` **Narrator**: "My eyes were on Vina as she was ..."<br>`[212]` **Narrator**: "My eyes were on Vina and Lucita ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Axel Reinhart**: ""You need not worry. Really."" |
| `[30]` | **""I'm not surprised to hear that.""** | `[28]` **Axel Reinhart**: ""To be honest, I don't think I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Narrator**: "He looked over at Lucita. She ha..."<br>`[514]` **Axel Reinhart**: ""And what of your own... unconve..."<br>*(oraz 1 innych odgałęzień)* |
| `[31]` | **""Keep her close to you.""** | `[28]` **Axel Reinhart**: ""To be honest, I don't think I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Narrator**: "He looked over at Lucita. She ha..."<br>`[514]` **Axel Reinhart**: ""And what of your own... unconve..."<br>*(oraz 1 innych odgałęzień)* |
| `[32]` | **""Good to know, Axel.""** | `[28]` **Axel Reinhart**: ""To be honest, I don't think I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[498]` **Narrator**: "He looked over at Lucita. She ha..."<br>`[514]` **Axel Reinhart**: ""And what of your own... unconve..."<br>*(oraz 1 innych odgałęzień)* |
| `[57]` | **""An excellent choice. I'll have the same.""** | `[56]` **Narrator**: "He looked at me to see if I woul..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`<br>`Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["R...` | `[570]` **Narrator**: "The waiter penciled down the ord..." |
| `[58]` | **""I'll just have water. Thank you.""** | `[56]` **Narrator**: "He looked at me to see if I woul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Axel Reinhart**: ""Overdone it lately, have you? I..."<br>`[395]` **Axel Reinhart**: ""Oh, I see. This is some sort of..." |
| `[59]` | **""Thank you, but I'm not thirsty.""** | `[56]` **Narrator**: "He looked at me to see if I woul..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDr...` | `[570]` **Narrator**: "The waiter penciled down the ord..."<br>`[61]` **Narrator**: "The waiter nodded and brought us..."<br>*(oraz 1 innych odgałęzień)* |
| `[68]` | **""Of course they're fine with it. Because they have to be.""** | `[64]` **Axel Reinhart**: ""Tell me... Are your family and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Axel Reinhart**: ""I'm beginning to get the sense ..."<br>`[401]` **Axel Reinhart**: ""Hmm. I hope you're right."" |
| `[69]` | **""They were fine with the marriage, weren't they?""** | `[64]` **Axel Reinhart**: ""Tell me... Are your family and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Axel Reinhart**: ""I guess they were."" |
| `[70]` | **""Their opinions don't really matter. What matters is your union with Vina.""** | `[64]` **Axel Reinhart**: ""Tell me... Are your family and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Axel Reinhart**: ""I hope so."" |
| `[71]` | **""Heirs? Do you and Vina have something to tell me?""** | `[64]` **Axel Reinhart**: ""Tell me... Are your family and ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Axel Reinhart**: ""I'm speaking hypothetically, Yo..." |
| `[75]` | **""Do you think your brother will be a problem?""** | `[74]` **Axel Reinhart**: ""Let alone all these talks of 'r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "He let out a short laugh." |
| `[76]` | **""Are you saying they're trying to block your efforts?""** | `[74]` **Axel Reinhart**: ""Let alone all these talks of 'r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Axel Reinhart**: ""Oh, they tried. But most of the..." |
| `[77]` | **""I know how difficult it is to go against your own family, Axel. And you still did..."** | `[74]` **Axel Reinhart**: ""Let alone all these talks of 'r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Axel Reinhart**: ""Thank you. It is tough."" |
| `[78]` | **""Are you having second thoughts now?""** | `[74]` **Axel Reinhart**: ""Let alone all these talks of 'r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Axel Reinhart**: ""No, not at all."" |
| `[104]` | **""I'm not so fond of the new charter myself, but I had to do it for the Rizian peop..."** | `[103]` **Axel Reinhart**: ""That was a drastic change. Abol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Axel Reinhart**: ""I couldn't imagine how hard it ..." |
| `[105]` | **""Times are changing, Axel. The days of kings leading armies on the battlefields ar..."** | `[103]` **Axel Reinhart**: ""That was a drastic change. Abol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Axel Reinhart**: ""Absolutely."" |
| `[106]` | **""Thank you, Axel. I had to take a lot of risks for this charter.""** | `[103]` **Axel Reinhart**: ""That was a drastic change. Abol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Axel Reinhart**: ""I couldn't imagine how hard it ..." |
| `[107]` | **""It was. The question is, do you respect that system yourself?""** | `[103]` **Axel Reinhart**: ""That was a drastic change. Abol..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Axel Reinhart**: ""Yes, of course. Governing Rizia..." |
| `[110]` | **""I did what I had to do to keep Rizia running smoothly. The Delegates were only sl..."** | `[109]` **Axel Reinhart**: ""And how is the abolishment of y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Axel Reinhart**: ""Hmm. You know best about these ..." |
| `[111]` | **""I don't believe in their function, Axel. I'm just undoing the mistakes of my fath..."** | `[109]` **Axel Reinhart**: ""And how is the abolishment of y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[477]` **Axel Reinhart**: ""King Valero was a man of many m..." |
| `[112]` | **""Thank you, Axel. It was the right thing to do.""** | `[109]` **Axel Reinhart**: ""And how is the abolishment of y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Axel Reinhart**: ""If you say so, Your Majesty."" |
| `[113]` | **""I did indeed. The question is, do you have a problem with that?""** | `[109]` **Axel Reinhart**: ""And how is the abolishment of y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Axel Reinhart**: ""Oh, not at all."" |
| `[114]` | **""Cosmetic changes only, Your Grace. Nothing to be concerned about.""** | `[102]` **Axel Reinhart**: ""And how is this new religious r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Axel Reinhart**: ""I see."" |
| `[115]` | **""I believe in enforcing the Divine's laws, Axel. I'm doing this for God and Rizian..."** | `[102]` **Axel Reinhart**: ""And how is this new religious r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["Ri...` | `[121]` **Axel Reinhart**: ""I see."" |
| `[116]` | **""Rizia is only beginning its transformation. I fully expect Pales to become part o..."** | `[102]` **Axel Reinhart**: ""And how is this new religious r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Axel Reinhart**: ""Oh..."" |
| `[117]` | **""Do you have a problem with that?""** | `[102]` **Axel Reinhart**: ""And how is this new religious r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "He smiled nervously." |
| `[123]` | **""Halaita.""** | `[122]` **Axel Reinhart**: ""May the Divine bless you, Your ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...`<br>`--;` | `[86]` **Narrator**: "He took a large sip from his glass." |
| `[124]` | **""Tell me, Axel. Would you consider yourself a devout Wruhecist?""** | `[122]` **Axel Reinhart**: ""May the Divine bless you, Your ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "He took a few seconds to deliber..." |
| `[125]` | **""And you as well.""** | `[122]` **Axel Reinhart**: ""May the Divine bless you, Your ..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[86]` **Narrator**: "He took a large sip from his glass." |
| `[127]` | **""Don't worry, son. We'll have all our lives to have many more of these talks.""** | `[126]` **Axel Reinhart**: ""And how are you, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Axel Reinhart**: ""That we do."" |
| `[128]` | **""I'm fine, thank you. A lot going on, as you know.""** | `[126]` **Axel Reinhart**: ""And how are you, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Axel Reinhart**: ""I'm glad to hear that. Really."" |
| `[129]` | **""I don't like talking about my personal life, Axel.""** | `[126]` **Axel Reinhart**: ""And how are you, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Axel Reinhart**: ""You've got to talk about yourse..." |
| `[133]` | **""If I may be honest with you, the recent unrest has been quite taxing.""** | `[126]` **Axel Reinhart**: ""And how are you, Your Majesty? ..." | `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true` | *Brak zmian stanu* | `[141]` **Axel Reinhart**: ""I suspected that..."" |
| `[137]` | **""It would be a lie if I'd said everything is great. But you know how it is.""** | `[126]` **Axel Reinhart**: ""And how are you, Your Majesty? ..." | `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true` | *Brak zmian stanu* | `[138]` **Axel Reinhart**: ""Yes. I understand it well."" |
| `[157]` | **""I do not partake in the vice of alcohol consumption.""** | `[56]` **Narrator**: "He looked at me to see if I woul..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[158]` **Axel Reinhart**: ""Uhm. As you wish. Then just the..." |
| `[163]` | **""Derteans 25:17, reads, and I quote, 'The path of the righteous man is beset on al..."** | `[56]` **Narrator**: "He looked at me to see if I woul..." | `Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[164]` **Narrator**: "He listened to me in shock as I ..." |
| `[166]` | **""Is this going to be a sticking point, Your Grace? My plan is to purge our unified..."** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | `Variable["RiziaDLC.Theocracy_Full"] == true` | *Brak zmian stanu* | `[171]` **Narrator**: "He did not respond for a few sec..." |
| `[167]` | **""There are many passages warning against it. I choose to heed that warning.""** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[175]` **Axel Reinhart**: ""Well, I choose not to. I'm stic..." |
| `[168]` | **""Your interpretation is completely false and ungrounded. May God forgive your igno..."** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Narrator**: "He did not respond for a few sec..." |
| `[169]` | **""Don't worry. You can drink whatever you want.""** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Narrator**: "He looked relieved and gestured ..." |
| `[170]` | **""I mean it, Axel. If you are to be with my daughter, you have to stop drinking and..."** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Axel Reinhart**: ""Uhm..."" |
| `[187]` | **""Still, I'd rather try to have a good relationship with them.""** | `[186]` **Axel Reinhart**: ""But I think we're off to a very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Axel Reinhart**: ""Alvarez should be the one tryin..." |
| `[188]` | **""Sooner or later, they will all have to realize and respect the power of Intermerk..."** | `[186]` **Axel Reinhart**: ""But I think we're off to a very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Axel Reinhart**: ""I agree."" |
| `[193]` | **""What did you expect? We took their favorite toy away from them.""** | `[186]` **Axel Reinhart**: ""But I think we're off to a very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Narrator**: "He laughed." |
| `[194]` | **""Good. That means we are on the right track.""** | `[186]` **Axel Reinhart**: ""But I think we're off to a very..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Narrator**: "He laughed." |
| `[195]` | **""Still, I'd rather try to have a good relationship with them.""** | `[192]` **Axel Reinhart**: ""Lespia, for one, was immensely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Axel Reinhart**: ""We have make nice with Alvarez ..." |
| `[196]` | **""Don't tell me you're thinking about crawling back to Alvarez.""** | `[192]` **Axel Reinhart**: ""Lespia, for one, was immensely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Axel Reinhart**: ""No, no. That door has slammed s..." |
| `[197]` | **""What are you implying, Your Grace?""** | `[192]` **Axel Reinhart**: ""Lespia, for one, was immensely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Axel Reinhart**: ""Nothing, Your Majesty. Just mak..." |
| `[198]` | **""That means we were on the right track. We'll try again.""** | `[192]` **Axel Reinhart**: ""Lespia, for one, was immensely ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Axel Reinhart**: ""Well, I'm glad you're optimistic."" |
| `[223]` | **""Oh, please. Rumburg and Rizia were never truly allies. The only thing keeping us ..."** | `[222]` **Axel Reinhart**: ""Why would Rizia isolate itself ..."<br>`[412]` **Axel Reinhart**: ""Why would Rizia isolate itself ..." | `Variable["RiziaDLC.Prologue_LovedWife"] == false` | *Brak zmian stanu* | `[418]` **Narrator**: "Axel frowned." |
| `[224]` | **""Rumburg is nothing but trouble, Axel. Rizia cannot afford to have such a close as..."** | `[222]` **Axel Reinhart**: ""Why would Rizia isolate itself ..."<br>`[412]` **Axel Reinhart**: ""Why would Rizia isolate itself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[230]` **Axel Reinhart**: ""Isn't the Queen still your sist..." |
| `[225]` | **""It wasn't my choice. When Queen Beatrice got wind of our intention to form Interm..."** | `[222]` **Axel Reinhart**: ""Why would Rizia isolate itself ..."<br>`[412]` **Axel Reinhart**: ""Why would Rizia isolate itself ..." | `Variable["RiziaDLC.Intermerkopum_Failed"] == true` | *Brak zmian stanu* | `[233]` **Axel Reinhart**: ""I see. A very vindictive woman,..." |
| `[229]` | **""I see. Now that we can no longer get you into GRACE, you don't want to have anyth..."** | `[412]` **Axel Reinhart**: ""Why would Rizia isolate itself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Axel Reinhart**: ""Please, Your Majesty. I never s..." |
| `[235]` | **""Are you crazy? She's not my *sister*.""** | `[230]` **Axel Reinhart**: ""Isn't the Queen still your sist..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Axel Reinhart**: ""Fine. I get it. Excuse me."" |
| `[236]` | **""She is my sister-in-law, which means nothing at all.""** | `[230]` **Axel Reinhart**: ""Isn't the Queen still your sist..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Axel Reinhart**: ""I see."" |
| `[237]` | **""Well, yes. That's why I can afford to do this in the first place.""** | `[230]` **Axel Reinhart**: ""Isn't the Queen still your sist..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Axel Reinhart**: ""I see."" |
| `[258]` | **""You shouldn't trust everything you read in the newspapers.""** | `[255]` **Axel Reinhart**: ""Well... Not just here but the e..."<br>`[259]` **Axel Reinhart**: ""Rizian revolutionaries have bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Axel Reinhart**: ""Oh, you're playing that card now?"" |
| `[260]` | **""Yes. It's quite worrying, indeed.""** | `[255]` **Axel Reinhart**: ""Well... Not just here but the e..."<br>`[259]` **Axel Reinhart**: ""Rizian revolutionaries have bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Axel Reinhart**: ""I seriously am concerned about ..." |
| `[261]` | **""They can march wherever they want. The roads are not worn by walking.""** | `[255]` **Axel Reinhart**: ""Well... Not just here but the e..."<br>`[259]` **Axel Reinhart**: ""Rizian revolutionaries have bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Narrator**: "He laughed." |
| `[262]` | **""Why does it concern you?""** | `[255]` **Axel Reinhart**: ""Well... Not just here but the e..."<br>`[259]` **Axel Reinhart**: ""Rizian revolutionaries have bee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[263]` **Axel Reinhart**: ""You know perfectly well why."" |
| `[271]` | **""Why are you so concerned about this? There is no way Vina would be harmed here.""** | `[270]` **Axel Reinhart**: ""I want Vina to pause her regula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Axel Reinhart**: ""Either you are not being honest..." |
| `[272]` | **""It seems to me like you're looking for an excuse.""** | `[270]` **Axel Reinhart**: ""I want Vina to pause her regula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Axel Reinhart**: ""An excuse for what?"" |
| `[273]` | **""I don't understand, Axel. What unrest are you talking about? We are on a beach, a..."** | `[270]` **Axel Reinhart**: ""I want Vina to pause her regula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Axel Reinhart**: ""Either you are not being honest..." |
| `[274]` | **""I understand, Axel. But that is for Vina to decide, not you.""** | `[270]` **Axel Reinhart**: ""I want Vina to pause her regula..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Axel Reinhart**: ""Of course."" |
| `[277]` | **""I don't know.""** | `[276]` **Axel Reinhart**: ""An excuse for what?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Narrator**: "He smiled and took another sip f..." |
| `[278]` | **""To stop the reunification efforts.""** | `[276]` **Axel Reinhart**: ""An excuse for what?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Narrator**: "He did not respond." |
| `[279]` | **""To leave Rizia.""** | `[276]` **Axel Reinhart**: ""An excuse for what?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Axel Reinhart**: ""You got me."" |
| `[280]` | **""To spend more time with Vina.""** | `[276]` **Axel Reinhart**: ""An excuse for what?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Axel Reinhart**: ""You got me."" |
| `[281]` | **""To go back on your promises.""** | `[276]` **Axel Reinhart**: ""An excuse for what?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Axel Reinhart**: ""I don't recall making any promi..." |
| `[302]` | **""Of course. We can definitely make an exception for Pales.""** | `[301]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Axel Reinhart**: ""Good."" |
| `[303]` | **""Yes, Axel. If that's your demand for unification, consider it done.""** | `[301]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Axel Reinhart**: ""Good."" |
| `[304]` | **""You can trust Rizia to take care of Pales as its own, but we cannot grant you spe..."** | `[301]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["Ri...` | `[317]` **Narrator**: "He sighed and went quiet for a w..." |
| `[305]` | **""No, Axel. We are not playing that game. You married my daughter, and now you're g..."** | `[301]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["Ri...` | `[315]` **Axel Reinhart**: ""That was uncalled for."" |
| `[306]` | **""Don't worry. Pales is of such enormous value to all of us. I will make sure it ge..."** | `[293]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Axel Reinhart**: ""Good."" |
| `[307]` | **""No, Axel. We are not playing that game. You married my daughter already and now I..."** | `[293]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["Ri...` | `[314]` **Axel Reinhart**: ""We will see... We will see..."" |
| `[308]` | **""Of course. That goes without saying.""** | `[293]` **Axel Reinhart**: ""Tell me. Can I trust that Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Axel Reinhart**: ""Good."" |
| `[331]` | **""I understand. I hope we can regain your trust in the future.""** | `[328]` **Axel Reinhart**: ""I just don't think Pales is rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Axel Reinhart**: ""Thanks for your understanding, ..." |
| `[332]` | **""Don't make us wait any longer, Axel.""** | `[328]` **Axel Reinhart**: ""I just don't think Pales is rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Axel Reinhart**: ""We will see about that, Romus."" |
| `[333]` | **""Are you kidding me? After everything I've done?""** | `[328]` **Axel Reinhart**: ""I just don't think Pales is rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[482]` **Axel Reinhart**: ""We are still allies, Your Majes..." |
| `[334]` | **""You seem not to understand the situation, Axel. I only sanctioned this marriage s..."** | `[328]` **Axel Reinhart**: ""I just don't think Pales is rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Narrator**: "He raised an eyebrow." |
| `[346]` | **""To our unity!""** | `[327]` **Axel Reinhart**: ""To our unity!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Narrator**: "He motioned for an embrace and w..." |
| `[347]` | **""Glovurius axa Rizia axa Pales!""** | `[327]` **Axel Reinhart**: ""To our unity!"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[349]` **Narrator**: "He motioned for an embrace and w..." |
| `[348]` | **""To new beginnings, and to the enduring strength of the bonds forged not by politi..."** | `[327]` **Axel Reinhart**: ""To our unity!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Narrator**: "He motioned for an embrace and w..." |
| `[360]` | **""Speaking of preparations, shall we discuss our progress?""** | `[28]` **Axel Reinhart**: ""To be honest, I don't think I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Axel Reinhart**: ""Yes, I was getting to that."" |
| `[362]` | **""Marrying Lucita was the only way to keep House Azaro happy. You know they're stil..."** | `[216]` **Axel Reinhart**: ""And how is your own marriage go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Axel Reinhart**: ""They're getting what they wante..." |
| `[363]` | **""Our marriage is a mere footnote to yours. You and Vina are the future. Lucita and..."** | `[216]` **Axel Reinhart**: ""And how is your own marriage go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Axel Reinhart**: ""Are you sure about that?"" |
| `[364]` | **""I couldn't be happier, Your Grace.""** | `[216]` **Axel Reinhart**: ""And how is your own marriage go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Axel Reinhart**: ""A second chance at fatherhood, ..." |
| `[419]` | **""Our partnership with Rumburg served its purpose. But now it is time for Rizia and..."** | `[222]` **Axel Reinhart**: ""Why would Rizia isolate itself ..."<br>`[412]` **Axel Reinhart**: ""Why would Rizia isolate itself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Axel Reinhart**: ""We'll have a hard time doing th..." |
| `[427]` | **""Still, I'd rather try to have a good relationship with them.""** | `[424]` **Axel Reinhart**: ""I have to thank you once more f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Axel Reinhart**: ""Alvarez should be the one tryin..." |
| `[431]` | **""Sooner or later, they will all have to realize and respect the power of our band ..."** | `[424]` **Axel Reinhart**: ""I have to thank you once more f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Axel Reinhart**: ""I agree."" |
| `[433]` | **""What did you expect? We took their favorite toy away from them.""** | `[424]` **Axel Reinhart**: ""I have to thank you once more f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Narrator**: "He laughed." |
| `[434]` | **""Good. That means we are on the right track.""** | `[424]` **Axel Reinhart**: ""I have to thank you once more f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[432]` **Axel Reinhart**: ""What's bad for Lespia is good f..." |
| `[439]` | **""I'm sure it'll blow over. Nothing to worry about.""** | `[438]` **Axel Reinhart**: ""I confess I don't like the rumo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[454]` **Narrator**: "He looked unconvinced." |
| `[440]` | **""What impending conflict?""** | `[438]` **Axel Reinhart**: ""I confess I don't like the rumo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Narrator**: "He wrinkled his brow." |
| `[441]` | **""The members of GRACE must support each other, Duke Reinhart. If we don't come to ..."** | `[438]` **Axel Reinhart**: ""I confess I don't like the rumo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Axel Reinhart**: ""You would support Rumburg like ..."<br>`[452]` **Axel Reinhart**: ""I suppose you're right."" |
| `[442]` | **""Trust me, I will do everything I can to keep Rizia and Pales out of such a confli..."** | `[438]` **Axel Reinhart**: ""I confess I don't like the rumo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Axel Reinhart**: ""That's the answer I was hoping ..." |
| `[460]` | **""It was a necessary business arrangement. We would've lost control of the MITZ wit..."** | `[459]` **Axel Reinhart**: ""Caleqabiz, Your Majesty? You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Axel Reinhart**: ""I am sure you had your reasons...." |
| `[462]` | **""This is not the Valgos Empire of old, Duke Reinhart. Hegel and his republic are d..."** | `[459]` **Axel Reinhart**: ""Caleqabiz, Your Majesty? You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[465]` **Axel Reinhart**: ""You were there at the AN. You h..." |
| `[463]` | **""Do not disparage our Valgslandian comrades. We are all one people, fighting the g..."** | `[459]` **Axel Reinhart**: ""Caleqabiz, Your Majesty? You've..." | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0` | *Brak zmian stanu* | `[464]` **Axel Reinhart**: ""...Comrades?"" |
| `[466]` | **"'Your concerns are misplaced, Your Grace. Valgsland isn't planning anything.""** | `[459]` **Axel Reinhart**: ""Caleqabiz, Your Majesty? You've..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[467]` **Axel Reinhart**: ""Then why would they want a base..." |
| `[490]` | **""Look at all I've done for you. Isn't it enough to be part of a prospering alliance?""** | `[489]` **Axel Reinhart**: ""The least that I can expect is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[503]` **Axel Reinhart**: ""I do treasure our alliance. And..." |
| `[491]` | **""I will be honest with you. I already promised to House Azaro that if my second ch..."** | `[489]` **Axel Reinhart**: ""The least that I can expect is ..." | `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true` | *Brak zmian stanu* | `[492]` **Axel Reinhart**: ""I see..."" |
| `[493]` | **""The child could be a girl, in which case you have nothing to worry about. But if ..."** | `[489]` **Axel Reinhart**: ""The least that I can expect is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[504]` **Axel Reinhart**: ""You yourself have broken royal ..."<br>`[508]` **Axel Reinhart**: ""If Pales and Rizia are to forge..." |
| `[497]` | **""Birthrights don't mean much these days, Axel. Whether you're a prince or King Con..."** | `[489]` **Axel Reinhart**: ""The least that I can expect is ..." | `Variable["RiziaDLC.Reform_Success"] == true` | *Brak zmian stanu* | `[502]` **Axel Reinhart**: ""Hm. Yes, that's another thing I..." |
| `[499]` | **""You might as well come straight out with it. You're worried about losing your cla..."** | `[216]` **Axel Reinhart**: ""And how is your own marriage go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[500]` **Axel Reinhart**: ""The thought has crossed my mind."" |
| `[509]` | **""Vina is my eldest child. As far as I'm concerned, she is and will remain my heir.""** | `[489]` **Axel Reinhart**: ""The least that I can expect is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[510]` **Axel Reinhart**: ""Great. I hope Her Majesty isn't..." |
| `[517]` | **""Come, now. Even if I was with a woman, I would never jeopardize Vina's inheritance.""** | `[516]` **Axel Reinhart**: ""And, well, I admit I'm relieved..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[525]` **Narrator**: "He grinned." |
| `[518]` | **""Never say never. Like the metaphorical door between Pales and Rizia, this king sw..."** | `[516]` **Axel Reinhart**: ""And, well, I admit I'm relieved..." | `Variable["RiziaDLC.Prologue_LovedWife"] == true` | *Brak zmian stanu* | `[522]` **Axel Reinhart**: ""I, uh..."" |
| `[526]` | **""I'm too old to go through parenthood again, Axel. You two, on the other hand...""** | `[516]` **Axel Reinhart**: ""And, well, I admit I'm relieved..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Narrator**: "He grinned." |
| `[528]` | **""No. And as a matter of fact, should reunification go as planned, you and Vina wil..."** | `[516]` **Axel Reinhart**: ""And, well, I admit I'm relieved..." | `Variable["RiziaDLC.PromiseToAbdicate"] == true` | *Brak zmian stanu* | `[530]` **Narrator**: "He drew in a breath." |
| `[535]` | **""Thank you. It wasn't easy, but I couldn't go on living a lie.""** | `[516]` **Axel Reinhart**: ""And, well, I admit I'm relieved..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Axel Reinhart**: ""I hope your relatives will come..." |
| `[554]` | **""What are you talking about?""** | `[541]` **Axel Reinhart**: ""Especially after what happened ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Narrator**: "He smiled nervously." |
| `[555]` | **""There was an emergency, but it was handled swiftly by the Rizian Crown.""** | `[541]` **Axel Reinhart**: ""Especially after what happened ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Narrator**: "He smiled nervously." |
| `[556]` | **""Rizia is only beginning its transformation. I assure you there is nothing for Pal..."** | `[541]` **Axel Reinhart**: ""Especially after what happened ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Narrator**: "He smiled nervously." |
| `[557]` | **""Do you have a problem with that?""** | `[541]` **Axel Reinhart**: ""Especially after what happened ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[558]` **Narrator**: "He smiled nervously." |
| `[571]` | **""That's right, worm. Remember who owns these lands.""** | `[570]` **Narrator**: "The waiter penciled down the ord..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[579]` **Narrator**: "Axel raised an eyebrow, but didn..." |
| `[575]` | **""Why is everyone here so scared of me? They should be grateful I've purged the kin..."** | `[570]` **Narrator**: "The waiter penciled down the ord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Axel Reinhart**: ""Mm. You must admit it's been qu..." |
| `[576]` | **""It's taking the province some time to adjust to the Crown's direct rule. I assure..."** | `[570]` **Narrator**: "The waiter penciled down the ord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[577]` **Axel Reinhart**: ""Mm. Yes, seems like it's been q..." |
| `[580]` | **"Don't comment."** | `[570]` **Narrator**: "The waiter penciled down the ord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[590]` **Narrator**: "The waiter returned with our dri..."<br>`[591]` **Narrator**: "The waiter returned with Axel's ..." |
| `[594]` | **""Relax, Your Grace. As long as Pales behaves itself, you'll never befall such a fa..."** | `[593]` **Axel Reinhart**: ""The idea that the Crown can sim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[603]` **Axel Reinhart**: ""We will behave ourselves. You w..." |
| `[595]` | **""There was a plot to overthrow me. I did what I had to in order to protect Princes..."** | `[593]` **Axel Reinhart**: ""The idea that the Crown can sim..." | `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true` | *Brak zmian stanu* | `[611]` **Axel Reinhart**: ""If there truly was not other op..." |
| `[596]` | **""I promise you, this was strictly between me and the nobles in question. It won't ..."** | `[593]` **Axel Reinhart**: ""The idea that the Crown can sim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[602]` **Axel Reinhart**: ""All right. I suppose the inner ..." |
| `[600]` | **""I acted in pure self-defense. Had I not, I wouldn't be sitting here talking to yo..."** | `[593]` **Axel Reinhart**: ""The idea that the Crown can sim..." | `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false` | *Brak zmian stanu* | `[611]` **Axel Reinhart**: ""If there truly was not other op..." |
| `[601]` | **""Think about it, Axel. Thanks to me, House Azaro is no longer sitting at your door..."** | `[593]` **Axel Reinhart**: ""The idea that the Crown can sim..." | `Variable["RiziaDLC.HouseAzaro_Conquered"] == true` | *Brak zmian stanu* | `[610]` **Axel Reinhart**: ""I suppose I should be grateful ..." |
| `[619]` | **""Relax. I myself enjoy a drink or two from time to time. I'll join you.""** | `[165]` **Axel Reinhart**: ""There's no text in Nurity that ..." | `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false` | `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["R...` | `[570]` **Narrator**: "The waiter penciled down the ord..."<br>`[61]` **Narrator**: "The waiter nodded and brought us..."<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Polic..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Failed"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Axel Reinhart: ""We haven't had much of a chance to talk about Intermerko..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_Diplomacy_Intermerkopum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Failed"] == true  or  Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Since my daughter married him, the couple had been traveling constantly between Pales and Porte Drazon. The Palesian authorities were working hard with our government to realize our plans for unity."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_KeepsLastName == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Axel Reinhart: ""You know... My brother is quite mad about my decision to..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_KeepsLastName == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Axel Reinhart: ""Tell me... Are your family and the other royal houses re..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The grand Rizia-Pales reunion was right around the corner. Preparations were complete, our teams were cooperating and the marriage between Vina and Axel seemed to be going well. It wasn't a distant dream anymore."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The only thing that was left was Duke Reinhart's complete..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The only thing that was left was Duke Reinhart's complete approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Since my daughter married him, the couple had been travel..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "On one of their visits, we decided to take a break and visit my hometown in Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "We were on the picturesque beach of Monqiz, sitting in front of a cafe run by distant Toras relatives in a secluded corner of the sandy shores."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[14]`
Mówca: **Axel Reinhart**
> ""It's refreshing being here, away from the court's rigidity. Life's simpler rhythms have a charm of their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "We were on the picturesque beach of Monqiz, sitting in front of a cafe run by distant Toras relatives in a secluded corner that hadn't been invaded by Sordish tourists yet."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "We were on the picturesque beach of Monqiz, sitting in fr..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "We were on the picturesque beach of Monqiz, sitting in fr..."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "My eyes were on Vina as she was taking a stroll on the beach, talking to the locals she encountered. She seemed to be immensely popular here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Indeed, Axel. Well said.""*)
  - -> `[22]` (*Player_Romus: ""Look at her, Axel. I feel like she's more at home here t..."*)
  - -> `[23]` (*Player_Romus: ""Tell me. Is the marriage faring well?""*)
  - -> `[24]` (*Player_Romus: ""I'm glad everything is going great between the two of yo..."*)

### Węzeł `[20]`
Mówca: **Axel Reinhart**
> ""Tremendously, actually. We both think this was the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Axel Reinhart: ""Of course we're still working out the particulars of our..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed, Axel. Well said.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Axel Reinhart: ""To be honest, it's your daughter who's given me a fresh ..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at her, Axel. I feel like she's more at home here than in any palace or court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Axel Reinhart: ""Perhaps so. She definitely has a spirit too vast for the..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me. Is the marriage faring well?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Axel Reinhart: ""Tremendously, actually. We both think this was the right..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad everything is going great between the two of you. I hope it stays that way for your sake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[212]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Axel Reinhart: ""You need not worry. Really.""*)

### Węzeł `[25]`
Mówca: **Axel Reinhart**
> ""Of course we're still working out the particulars of our marriage arrangement. But we make a good team, Vina and I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Axel Reinhart: ""To be honest, I don't think I could manage the preparati..."*)

### Węzeł `[26]`
Mówca: **Axel Reinhart**
> ""Perhaps so. She definitely has a spirit too vast for the confines of stone walls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Axel Reinhart: ""Of course we're still working out the particulars of our..."*)

### Węzeł `[27]`
Mówca: **Axel Reinhart**
> ""You need not worry. Really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Axel Reinhart: ""Of course we're still working out the particulars of our..."*)

### Węzeł `[28]`
Mówca: **Axel Reinhart**
> ""To be honest, I don't think I could manage the preparations for our reunion without her help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Player_Romus: ""I'm not surprised to hear that.""*)
  - -> `[32]` (*Player_Romus: ""Good to know, Axel.""*)
  - -> `[31]` (*Player_Romus: ""Keep her close to you.""*)
  - -> `[360]` (*Player_Romus: ""Speaking of preparations, shall we discuss our progress?""*)

### Węzeł `[29]`
Mówca: **Axel Reinhart**
> ""To be honest, it's your daughter who's given me a fresh perspective on life these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Axel Reinhart: ""Of course we're still working out the particulars of our..."*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not surprised to hear that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep her close to you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Just then, the waiter of the cafe approached us to ask what we would like to drink. Axel turned to him and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Axel Reinhart: ""What is the recommendation of the house?""*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The waiter quickly brought over a bottle of Lespian wine,..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "The waiter quickly brought a bottle of Cantuavo as his re..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal =..."*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "The waiter quickly brought a bottle of Erlory Maroon whis..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "The waiter quickly brought a bottle of Erlory Maroon whiskey as a recommendation, and started talking about how smoky and delicious it was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Axel Reinhart: ""Oh, I don't want whiskey. If I wanted hard liquor, I'd g..."*)

### Węzeł `[41]`
Mówca: **Axel Reinhart**
> ""What is the recommendation of the house?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == ..."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The waiter quickly brought over a bottle of Lespian wine, 'Chateau de Falenco 1934', and started talking about its complex flavors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Axel Reinhart: ""Lespian wine in Rizia? What has the world come to?""*)

### Węzeł `[43]`
Mówca: **Narrator**
> "The waiter quickly brought a bottle of Cantuavo as his recommendation, and started talking about its exquisite taste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Axel Reinhart: ""Cantuavo? Oh, yes, please. Rizians know how to make thei..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon = true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1"*)

### Węzeł `[47]`
Mówca: **Axel Reinhart**
> ""Cantuavo? Oh, yes, please. Rizians know how to make their wine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He looked at me to see if I would have the same."*)

### Węzeł `[48]`
Mówca: **Axel Reinhart**
> ""Lespian wine in Rizia? What has the world come to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "The waiter quickly explained it was the main choice of th..."*)

### Węzeł `[49]`
Mówca: **Axel Reinhart**
> ""With all due respect, in all my years working with Lespia, I've had enough of that. I'd prefer something authentically Rizian. Cantuavo, perhaps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He looked at me to see if I would have the same."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "He laughed as he dismissed the bottle with a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Axel Reinhart: ""With all due respect, in all my years working with Lespi..."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "The waiter quickly explained it was the main choice of the wealthy Sordish tourists who visited the area."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Axel Reinhart: ""Oh, of course. Only a northerner with no culture would l..."*)

### Węzeł `[52]`
Mówca: **Axel Reinhart**
> ""Oh, of course. Only a northerner with no culture would look at Lespian products and think they're fancy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "He laughed as he dismissed the bottle with a wave of his ..."*)

### Węzeł `[53]`
Mówca: **Axel Reinhart**
> ""Oh, I don't want whiskey. If I wanted hard liquor, I'd go with something Valgish or Galmish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "He laughed as he dismissed the bottle with a wave of his ..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "He laughed as he dismissed the bottle with a wave of his hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Axel Reinhart: ""I'll have a Cantuavo, if you have any.""*)

### Węzeł `[55]`
Mówca: **Axel Reinhart**
> ""I'll have a Cantuavo, if you have any.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "He looked at me to see if I would have the same."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "He looked at me to see if I would have the same."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_Religiou..."*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[57]` (*Player_Romus: ""An excellent choice. I'll have the same.""*)
  - -> `[58]` (*Player_Romus: ""I'll just have water. Thank you.""*)
  - -> `[59]` (*Player_Romus: ""Thank you, but I'm not thirsty.""*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An excellent choice. I'll have the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll just have water. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, but I'm not thirsty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1"*)

### Węzeł `[61]`
Mówca: **Narrator**
> "The waiter nodded and brought us our drinks a few minutes later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""Cheers.""*)

### Węzeł `[62]`
Mówca: **Narrator**
> "The waiter nodded and brought Axel's drink a few minutes later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He raised his glass and then took a sip from it."*)

### Węzeł `[63]`
Mówca: **Axel Reinhart**
> ""Cheers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "We clinked our glasses and took a sip from our drinks."*)

### Węzeł `[64]`
Mówca: **Axel Reinhart**
> ""Tell me... Are your family and the other royal houses really fine with your heirs bearing the Reinhart name?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""Of course they're fine with it. Because they have to be.""*)
  - -> `[69]` (*Player_Romus: ""They were fine with the marriage, weren't they?""*)
  - -> `[70]` (*Player_Romus: ""Their opinions don't really matter. What matters is your..."*)
  - -> `[71]` (*Player_Romus: ""Heirs? Do you and Vina have something to tell me?""*)

### Węzeł `[65]`
Mówca: **Narrator**
> "We clinked our glasses and took a sip from our drinks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == true"*)

### Węzeł `[66]`
Mówca: **Narrator**
> "He raised his glass and then took a sip from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == true"*)

### Węzeł `[67]`
Mówca: **Axel Reinhart**
> ""You know... My brother is quite mad about my decision to go along with this marriage. He thinks I've betrayed House Reinhart by giving my name away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Axel Reinhart: ""Let alone all these talks of 'reunification'. It's makin..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course they're fine with it. Because they have to be.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.T..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They were fine with the marriage, weren't they?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Axel Reinhart: ""I guess they were.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their opinions don't really matter. What matters is your union with Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Axel Reinhart: ""I hope so.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Heirs? Do you and Vina have something to tell me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Axel Reinhart: ""I'm speaking hypothetically, Your Majesty. For now.""*)

### Węzeł `[72]`
Mówca: **Axel Reinhart**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Axel Reinhart: ""I'm just trying to wrap my head around the dynamics here..."*)

### Węzeł `[73]`
Mówca: **Axel Reinhart**
> ""I guess they were.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Axel Reinhart: ""I'm just trying to wrap my head around the dynamics here..."*)

### Węzeł `[74]`
Mówca: **Axel Reinhart**
> ""Let alone all these talks of 'reunification'. It's making my family quite hostile towards me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""Do you think your brother will be a problem?""*)
  - -> `[76]` (*Player_Romus: ""Are you saying they're trying to block your efforts?""*)
  - -> `[77]` (*Player_Romus: ""I know how difficult it is to go against your own family..."*)
  - -> `[78]` (*Player_Romus: ""Are you having second thoughts now?""*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think your brother will be a problem?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "He let out a short laugh."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you saying they're trying to block your efforts?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Axel Reinhart: ""Oh, they tried. But most of them don't even hold governm..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know how difficult it is to go against your own family, Axel. And you still did. I respect that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Axel Reinhart: ""Thank you. It is tough.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you having second thoughts now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Axel Reinhart: ""No, not at all.""*)

### Węzeł `[79]`
Mówca: **Narrator**
> "He let out a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Axel Reinhart: ""He had his chance to rule. If he hadn't taken the coward..."*)

### Węzeł `[80]`
Mówca: **Axel Reinhart**
> ""He had his chance to rule. If he hadn't taken the coward's way out, none of this would be happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Axel Reinhart: ""Njolma's not the boss of me. I won't let this affect our..."*)

### Węzeł `[81]`
Mówca: **Axel Reinhart**
> ""Njolma's not the boss of me. I won't let this affect our cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Ful..."*)

### Węzeł `[82]`
Mówca: **Axel Reinhart**
> ""Oh, they tried. But most of them don't even hold government positions anymore, the lazy bastards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Axel Reinhart: ""Njolma's not the boss of me. I won't let this affect our..."*)

### Węzeł `[83]`
Mówca: **Axel Reinhart**
> ""No, not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Axel Reinhart: ""I'm just stating the obvious.""*)

### Węzeł `[84]`
Mówca: **Axel Reinhart**
> ""I'm just stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Axel Reinhart: ""Njolma's not the boss of me. I won't let this affect our..."*)

### Węzeł `[85]`
Mówca: **Axel Reinhart**
> ""Thank you. It is tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Axel Reinhart: ""Njolma's not the boss of me. I won't let this affect our..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He took a large sip from his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Failed == true || RiziaDLC.Policy_..."*)

### Węzeł `[87]`
Mówca: **Axel Reinhart**
> ""Tell me, how have your reforms been working out for Rizia? I see that the new government is already preparing for its first elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Axel Reinhart: ""That was a drastic change. Abolishing the power of your ..."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Axel Reinhart: ""Tell me, how have your reforms been working out for Rizi..."*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Axel Reinhart: ""And how is this new religious rule of law faring for Riz..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[96]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Axel Reinhart: ""And how is the abolishment of your House of Delegates wo..."*)

### Węzeł `[96]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Axel Reinhart: ""And how are you, Your Majesty? It's been a while since w..."*)

### Węzeł `[97]`
Mówca: **Axel Reinhart**
> ""I am more concerned about the Rizian side of the equation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Ful..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_F..."*)

### Węzeł `[99]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Axel Reinhart: ""I am more concerned about the Rizian side of the equation.""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[101]`
Mówca: **Axel Reinhart**
> ""I'm just trying to wrap my head around the dynamics here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[102]`
Mówca: **Axel Reinhart**
> ""And how is this new religious rule of law faring for Rizia? It's a very different kingdom than when our negotiations began.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player_Romus: ""Cosmetic changes only, Your Grace. Nothing to be concern..."*)
  - -> `[115]` (*Player_Romus: ""I believe in enforcing the Divine's laws, Axel. I'm doin..."*)
  - -> `[116]` (*Player_Romus: ""Rizia is only beginning its transformation. I fully expe..."*)
  - -> `[117]` (*Player_Romus: ""Do you have a problem with that?""*)

### Węzeł `[103]`
Mówca: **Axel Reinhart**
> ""That was a drastic change. Abolishing the power of your council and empowering the parliament just like that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: ""I'm not so fond of the new charter myself, but I had to ..."*)
  - -> `[105]` (*Player_Romus: ""Times are changing, Axel. The days of kings leading armi..."*)
  - -> `[106]` (*Player_Romus: ""Thank you, Axel. I had to take a lot of risks for this c..."*)
  - -> `[107]` (*Player_Romus: ""It was. The question is, do you respect that system your..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not so fond of the new charter myself, but I had to do it for the Rizian people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Axel Reinhart: ""I couldn't imagine how hard it was.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Times are changing, Axel. The days of kings leading armies on the battlefields are long gone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Axel Reinhart: ""Absolutely.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Axel. I had to take a lot of risks for this charter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Axel Reinhart: ""I couldn't imagine how hard it was.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was. The question is, do you respect that system yourself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Axel Reinhart: ""Yes, of course. Governing Rizia is a much larger task th..."*)

### Węzeł `[108]`
Mówca: **Axel Reinhart**
> ""Yes, of course. Governing Rizia is a much larger task than of Pales. I can't even imagine having direct control over such a large swath of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[109]`
Mówca: **Axel Reinhart**
> ""And how is the abolishment of your House of Delegates working out? You've taken quite a risk with that decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""I did what I had to do to keep Rizia running smoothly. T..."*)
  - -> `[111]` (*Player_Romus: ""I don't believe in their function, Axel. I'm just undoin..."*)
  - -> `[112]` (*Player_Romus: ""Thank you, Axel. It was the right thing to do.""*)
  - -> `[113]` (*Player_Romus: ""I did indeed. The question is, do you have a problem wit..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did what I had to do to keep Rizia running smoothly. The Delegates were only slowing us down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Axel Reinhart: ""Hmm. You know best about these things.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't believe in their function, Axel. I'm just undoing the mistakes of my father.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Axel Reinhart: ""King Valero was a man of many mistakes, I'll grant you t..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Axel. It was the right thing to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Axel Reinhart: ""If you say so, Your Majesty.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did indeed. The question is, do you have a problem with that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Axel Reinhart: ""Oh, not at all.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cosmetic changes only, Your Grace. Nothing to be concerned about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe in enforcing the Divine's laws, Axel. I'm doing this for God and Rizian people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[116]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is only beginning its transformation. I fully expect Pales to become part of our holy dominion as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Axel Reinhart: ""Oh...""*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a problem with that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "He smiled nervously."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[119]`
Mówca: **Axel Reinhart**
> ""No problem at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Axel Reinhart: ""May the Divine bless you, Your Majesty...""*)

### Węzeł `[120]`
Mówca: **Axel Reinhart**
> ""Oh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[121]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Axel Reinhart: ""May the Divine bless you, Your Majesty...""*)

### Węzeł `[122]`
Mówca: **Axel Reinhart**
> ""May the Divine bless you, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player_Romus: ""Halaita.""*)
  - -> `[124]` (*Player_Romus: ""Tell me, Axel. Would you consider yourself a devout Wruh..."*)
  - -> `[125]` (*Player_Romus: ""And you as well.""*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me, Axel. Would you consider yourself a devout Wruhecist?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "He took a few seconds to deliberate over his answer. Fina..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And you as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[126]`
Mówca: **Axel Reinhart**
> ""And how are you, Your Majesty? It's been a while since we last had a personal talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Cou..."*)
  - -> `[127]` (*Player_Romus: ""Don't worry, son. We'll have all our lives to have many ..."*)
  - -> `[128]` (*Player_Romus: ""I'm fine, thank you. A lot going on, as you know.""*)
  - -> `[129]` (*Player_Romus: ""I don't like talking about my personal life, Axel.""*)
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry, son. We'll have all our lives to have many more of these talks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Axel Reinhart: ""That we do.""*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm fine, thank you. A lot going on, as you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Axel Reinhart: ""I'm glad to hear that. Really.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like talking about my personal life, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Axel Reinhart: ""You've got to talk about yourself at some point, or the ..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player_Romus: ""If I may be honest with you, the recent unrest has been ..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I may be honest with you, the recent unrest has been quite taxing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Axel Reinhart: ""I suspected that...""*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Cou..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_C..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""It would be a lie if I'd said everything is great. But y..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Revolution == true || RiziaDLC.Ending_Coup_Toras == true || RiziaDLC.Ending_Coup_Sazon == true || RiziaDLC.Ending_Coup_Azaro == true  )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be a lie if I'd said everything is great. But you know how it is.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Ending_Coup_Toras"] == true  or  Variable["RiziaDLC.Ending_Coup_Sazon"] == true  or  Variable["RiziaDLC.Ending_Coup_Azaro"] == true`
- **Kontekst wejściowy (poprzednik):** `[126]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Axel Reinhart: ""Yes. I understand it well.""*)

### Węzeł `[138]`
Mówca: **Axel Reinhart**
> ""Yes. I understand it well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[139]`
Mówca: **Axel Reinhart**
> ""That we do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[140]`
Mówca: **Axel Reinhart**
> ""I'm glad to hear that. Really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[141]`
Mówca: **Axel Reinhart**
> ""I suspected that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[142]`
Mówca: **Axel Reinhart**
> ""You've got to talk about yourself at some point, or the gossip columnists will do it for you. That's my take, at any rate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[143]`
Mówca: **Axel Reinhart**
> ""Hmm. You know best about these things.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Axel Reinhart: ""My wife sees it rather differently. Personally, though, ..."*)

### Węzeł `[144]`
Mówca: **Axel Reinhart**
> ""If you say so, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Axel Reinhart: ""My wife sees it rather differently. Personally, though, ..."*)

### Węzeł `[145]`
Mówca: **Axel Reinhart**
> ""Oh, not at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Axel Reinhart: ""My wife has her qualms, as I'm sure you're aware. Person..."*)

### Węzeł `[146]`
Mówca: **Axel Reinhart**
> ""I couldn't imagine how hard it was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[147]`
Mówca: **Axel Reinhart**
> ""Absolutely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Axel Reinhart: ""Besides, governing Rizia is a much larger task than ruli..."*)

### Węzeł `[148]`
Mówca: **Axel Reinhart**
> ""Besides, governing Rizia is a much larger task than ruling Pales. I can't even imagine having direct control over such a large swath of land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He took a large sip from his glass."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He took a large sip from his glass."*)

### Węzeł `[151]`
Mówca: **Axel Reinhart**
> ""Praise be to God, I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[152]`
Mówca: **Narrator**
> "He took a few seconds to deliberate over his answer. Finally, he smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Axel Reinhart: ""Praise be to God, I am.""*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He took a large sip from his glass."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player_Romus: ""I do not partake in the vice of alcohol consumption.""*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I do not partake in the vice of alcohol consumption.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Axel Reinhart: ""Uhm. As you wish. Then just the one glass of wine, please.""*)

### Węzeł `[158]`
Mówca: **Axel Reinhart**
> ""Uhm. As you wish. Then just the one glass of wine, please.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true"*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He took a large sip from his glass."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_Religiou..."*)
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_Religi..."*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player_Romus: ""Derteans 25:17, reads, and I quote, 'The path of the rig..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true ||RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Derteans 25:17, reads, and I quote, 'The path of the righteous man is beset on all sides by sinful temptations of intoxicants and debauchery. I warn you, that those who live like this will be refused to walk the path of Golconda.'""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true  or Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "He listened to me in shock as I recited the verse."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "He listened to me in shock as I recited the verse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Axel Reinhart: ""There's no text in Nurity that explicitly prohibits drin..."*)

### Węzeł `[165]`
Mówca: **Axel Reinhart**
> ""There's no text in Nurity that explicitly prohibits drinking alcohol, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""I mean it, Axel. If you are to be with my daughter, you ..."*)
  - -> `[168]` (*Player_Romus: ""Your interpretation is completely false and ungrounded. ..."*)
  - -> `[613]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[616]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[169]` (*Player_Romus: ""Don't worry. You can drink whatever you want.""*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this going to be a sticking point, Your Grace? My plan is to purge our unified kingdom of all sin, alcohol included.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He did not respond for a few seconds."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There are many passages warning against it. I choose to heed that warning.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Axel Reinhart: ""Well, I choose not to. I'm sticking with my order.""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your interpretation is completely false and ungrounded. May God forgive your ignorance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He did not respond for a few seconds."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. You can drink whatever you want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He looked relieved and gestured at the waiter."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean it, Axel. If you are to be with my daughter, you have to stop drinking and strive to follow the path of Enlightenment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Axel Reinhart: ""Uhm...""*)

### Węzeł `[171]`
Mówca: **Narrator**
> "He did not respond for a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Axel Reinhart: ""I understand. I'll just have a glass of water.""*)

### Węzeł `[172]`
Mówca: **Axel Reinhart**
> ""Uhm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: "He did not respond for a few seconds."*)

### Węzeł `[173]`
Mówca: **Axel Reinhart**
> ""I understand. I'll just have a glass of water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[174]`
Mówca: **Narrator**
> "He looked relieved and gestured at the waiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true"*)

### Węzeł `[175]`
Mówca: **Axel Reinhart**
> ""Well, I choose not to. I'm sticking with my order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "He then quickly gestured at the waiter."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "He then quickly gestured at the waiter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Axel Reinhart: ""No problem at all.""*)

### Węzeł `[182]`
Mówca: **Axel Reinhart**
> ""We haven't had much of a chance to talk about Intermerkopum yet, have we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Axel Reinhart: ""From what I'm hearing, few other countries expected such..."*)

### Węzeł `[183]`
Mówca: **Axel Reinhart**
> ""From what I'm hearing, few other countries expected such a bold move from Rizia, let alone Pales.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)

### Węzeł `[184]`
Mówca: **Axel Reinhart**
> ""May I ask you something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "He continued without waiting for my response."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == false"*)

### Węzeł `[186]`
Mówca: **Axel Reinhart**
> ""But I think we're off to a very promising start. Although the Lespians are furious, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player_Romus: ""Good. That means we are on the right track.""*)
  - -> `[193]` (*Player_Romus: ""What did you expect? We took their favorite toy away fro..."*)
  - -> `[188]` (*Player_Romus: ""Sooner or later, they will all have to realize and respe..."*)
  - -> `[187]` (*Player_Romus: ""Still, I'd rather try to have a good relationship with t..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Axel Reinhart: ""Alvarez should be the one trying to appease us now. Not ..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, they will all have to realize and respect the power of Intermerkopum.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Axel Reinhart: ""I agree.""*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Axel Reinhart: ""But I think we're off to a very promising start. Althoug..."*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Axel Reinhart: ""Lespia, for one, was immensely relieved when it didn't w..."*)

### Węzeł `[192]`
Mówca: **Axel Reinhart**
> ""Lespia, for one, was immensely relieved when it didn't work out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Player_Romus: ""That means we were on the right track. We'll try again.""*)
  - -> `[197]` (*Player_Romus: ""What are you implying, Your Grace?""*)
  - -> `[196]` (*Player_Romus: ""Don't tell me you're thinking about crawling back to Alv..."*)
  - -> `[195]` (*Player_Romus: ""Still, I'd rather try to have a good relationship with t..."*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you expect? We took their favorite toy away from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "He laughed."*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That means we are on the right track.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[186]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "He laughed."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Axel Reinhart: ""We have make nice with Alvarez now, don't we?""*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't tell me you're thinking about crawling back to Alvarez.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Axel Reinhart: ""No, no. That door has slammed shut.""*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you implying, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Axel Reinhart: ""Nothing, Your Majesty. Just making small talk.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That means we were on the right track. We'll try again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[192]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Axel Reinhart: ""Well, I'm glad you're optimistic.""*)

### Węzeł `[199]`
Mówca: **Axel Reinhart**
> ""Alvarez should be the one trying to appease us now. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[200]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Axel Reinhart: ""I agree.""*)

### Węzeł `[201]`
Mówca: **Axel Reinhart**
> ""We have make nice with Alvarez now, don't we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Narrator: "HIs face darkened."*)

### Węzeł `[202]`
Mówca: **Axel Reinhart**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)

### Węzeł `[204]`
Mówca: **Narrator**
> "He took another sip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true"*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "On one of their visits, we decided to take a break and vi..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "On one of their visits, we decided to take a break and vi..."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "On one of their visits, we decided to take a break and visit my hometown in Monqiz. Queen Consort Lucita joined us as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "AddConversant("Axel Reinhart");"*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "My eyes were on Vina and Lucita strolling along the beach..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "My eyes were on Vina as she was taking a stroll on the be..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "My eyes were on Vina and Lucita strolling along the beach. My wife stood behind my daughter as locals stopped and approached the Princess. She seemed to be immensely popular here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""Indeed, Axel. Well said.""*)
  - -> `[22]` (*Player_Romus: ""Look at her, Axel. I feel like she's more at home here t..."*)
  - -> `[23]` (*Player_Romus: ""Tell me. Is the marriage faring well?""*)
  - -> `[24]` (*Player_Romus: ""I'm glad everything is going great between the two of yo..."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arre..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Narrator: "He looked over at Lucita. She had met a young girl on the..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrested == false && RiziaDLC.Lucita_Executed == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true  and  Variable["RiziaDLC.Lucita_Arrested"] == false  and  Variable["RiziaDLC.Lucita_Executed"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)

### Węzeł `[216]`
Mówca: **Axel Reinhart**
> ""And how is your own marriage going, Your Majesty? Pregnancy suits the Queen Consort, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player_Romus: ""Marrying Lucita was the only way to keep House Azaro hap..."*)
  - -> `[364]` (*Player_Romus: ""I couldn't be happier, Your Grace.""*)
  - -> `[363]` (*Player_Romus: ""Our marriage is a mere footnote to yours. You and Vina a..."*)
  - -> `[499]` (*Player_Romus: ""You might as well come straight out with it. You're worr..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == false"*)
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == false )"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Axel Reinhart: ""May I ask you something?""*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC..."*)

### Węzeł `[220]`
Mówca: **Axel Reinhart**
> ""So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "He continued without waiting for my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GRACEApplication == true"*)

### Węzeł `[222]`
Mówca: **Axel Reinhart**
> ""Why would Rizia isolate itself from GRACE and Rumburg? It seems to me that you've lost your greatest support structure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Failed == true"*)
  - -> `[224]` (*Player_Romus: ""Rumburg is nothing but trouble, Axel. Rizia cannot affor..."*)
  - -> `[419]` (*Player_Romus: ""Our partnership with Rumburg served its purpose. But now..."*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, please. Rumburg and Rizia were never truly allies. The only thing keeping us together was a sham of an arranged marriage.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Axel Reinhart), `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "Axel frowned."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rumburg is nothing but trouble, Axel. Rizia cannot afford to have such a close association with that kingdom anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Axel Reinhart), `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Axel Reinhart: ""Isn't the Queen still your sister?""*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It wasn't my choice. When Queen Beatrice got wind of our intention to form Intermerkopum, she gave us the boot.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Intermerkopum_Failed"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Axel Reinhart), `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Axel Reinhart: ""I see. A very vindictive woman, your sister-in-law.""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Failed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Failed == true"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Intermerkopum_Failed == true)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Intermerkopum_Failed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Intermerkopum_Failed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Player_Romus: ""It wasn't my choice. When Queen Beatrice got wind of our..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Intermerkopum_Failed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Intermerkopum_Failed"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Now that we can no longer get you into GRACE, you don't want to have anything to do with Rizia anymore.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Axel Reinhart: ""Please, Your Majesty. I never said that.""*)

### Węzeł `[230]`
Mówca: **Axel Reinhart**
> ""Isn't the Queen still your sister?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player_Romus: ""Are you crazy? She's not my *sister*.""*)
  - -> `[236]` (*Player_Romus: ""She is my sister-in-law, which means nothing at all.""*)
  - -> `[237]` (*Player_Romus: ""Well, yes. That's why I can afford to do this in the fir..."*)

### Węzeł `[231]`
Mówca: **Axel Reinhart**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[232]`
Mówca: **Axel Reinhart**
> ""Like the marriage you just arranged for your daughter?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[233]`
Mówca: **Axel Reinhart**
> ""I see. A very vindictive woman, your sister-in-law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Axel Reinhart: ""But without the protection of GRACE or an alliance like ..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you crazy? She's not my *sister*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Axel Reinhart: ""Fine. I get it. Excuse me.""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She is my sister-in-law, which means nothing at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, yes. That's why I can afford to do this in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Axel Reinhart: ""I see.""*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == true"*)
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He took another sip."*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Intermerkopum == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == false"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == false && Rizia..."*)

### Węzeł `[242]`
Mówca: **Axel Reinhart**
> ""Fine. I get it. Excuse me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Intermerkopum == false && Rizia..."*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Intermerkopum == false && Riz..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == false  and  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Intermerkopum == false && RiziaDLC.Policy_Diplomacy_GRACEMember == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Intermerkopum"] == false  and  Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "He took another sip."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_..."*)
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Ending_Revolution == true || RiziaDLC.Situatio..."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Ending_Revolution"] == true  or  Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Toras", "R_Toras_Loop");"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == ..."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_ViolentProtests_Valenqiris"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Axel Reinhart: ""I'm surprised you never mentioned the true gravity of th..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_ViolentProtests_Valenqiris == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_ViolentProtests_Valenqiris"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Axel Reinhart: ""I'm surprised you've never mentioned the true gravity of..."*)

### Węzeł `[254]`
Mówca: **Axel Reinhart**
> ""I'm surprised you never mentioned the true gravity of the situation around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Axel Reinhart: ""Well... Not just here but the entire country. Revolution..."*)

### Węzeł `[255]`
Mówca: **Axel Reinhart**
> ""Well... Not just here but the entire country. Revolutionaries are getting quite massive and violent from what I've been reading.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""You shouldn't trust everything you read in the newspapers.""*)
  - -> `[260]` (*Player_Romus: ""Yes. It's quite worrying, indeed.""*)
  - -> `[261]` (*Player_Romus: ""They can march wherever they want. The roads are not wor..."*)
  - -> `[262]` (*Player_Romus: ""Why does it concern you?""*)

### Węzeł `[256]`
Mówca: **Axel Reinhart**
> ""I'm surprised you've never mentioned the true gravity of the situation here in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Axel Reinhart: ""Rizian revolutionaries have been getting quite massive, ..."*)

### Węzeł `[257]`
Mówca: **Axel Reinhart**
> ""Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You shouldn't trust everything you read in the newspapers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Axel Reinhart), `[259]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Axel Reinhart: ""Oh, you're playing that card now?""*)

### Węzeł `[259]`
Mówca: **Axel Reinhart**
> ""Rizian revolutionaries have been getting quite massive, haven't they? Violent, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""You shouldn't trust everything you read in the newspapers.""*)
  - -> `[260]` (*Player_Romus: ""Yes. It's quite worrying, indeed.""*)
  - -> `[261]` (*Player_Romus: ""They can march wherever they want. The roads are not wor..."*)
  - -> `[262]` (*Player_Romus: ""Why does it concern you?""*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. It's quite worrying, indeed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Axel Reinhart), `[259]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Axel Reinhart: ""I seriously am concerned about the chaos, though. I'll b..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They can march wherever they want. The roads are not worn by walking.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Axel Reinhart), `[259]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "He laughed."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why does it concern you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[255]` (Axel Reinhart), `[259]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Axel Reinhart: ""You know perfectly well why.""*)

### Węzeł `[263]`
Mówca: **Axel Reinhart**
> ""You know perfectly well why.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Axel Reinhart: ""I seriously am concerned about the chaos, though. I'll b..."*)

### Węzeł `[264]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Axel Reinhart: ""You're right about that one.""*)

### Węzeł `[265]`
Mówca: **Axel Reinhart**
> ""You're right about that one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Axel Reinhart: ""Just don't forget. The same roads may lead them to you.""*)

### Węzeł `[266]`
Mówca: **Axel Reinhart**
> ""Just don't forget. The same roads may lead them to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Axel Reinhart: ""I seriously am concerned about the chaos, though. I'll b..."*)

### Węzeł `[267]`
Mówca: **Axel Reinhart**
> ""I seriously am concerned about the chaos, though. I'll be honest with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Axel Reinhart: ""I want Vina to pause her regular travels back home until..."*)

### Węzeł `[268]`
Mówca: **Axel Reinhart**
> ""Oh, you're playing that card now?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He laughed."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Axel Reinhart: ""I seriously am concerned about the chaos, though. I'll b..."*)

### Węzeł `[270]`
Mówca: **Axel Reinhart**
> ""I want Vina to pause her regular travels back home until the danger is neutralized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""I understand, Axel. But that is for Vina to decide, not ..."*)
  - -> `[271]` (*Player_Romus: ""Why are you so concerned about this? There is no way Vin..."*)
  - -> `[273]` (*Player_Romus: ""I don't understand, Axel. What unrest are you talking ab..."*)
  - -> `[272]` (*Player_Romus: ""It seems to me like you're looking for an excuse.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are you so concerned about this? There is no way Vina would be harmed here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Axel Reinhart: ""Either you are not being honest with me, or you are not ..."*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems to me like you're looking for an excuse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Axel Reinhart: ""An excuse for what?""*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand, Axel. What unrest are you talking about? We are on a beach, and as you can see, everything is fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Axel Reinhart: ""Either you are not being honest with me, or you are not ..."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand, Axel. But that is for Vina to decide, not you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[270]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Axel Reinhart: ""Of course.""*)

### Węzeł `[275]`
Mówca: **Axel Reinhart**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[276]`
Mówca: **Axel Reinhart**
> ""An excuse for what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Player_Romus: ""I don't know.""*)
  - -> `[281]` (*Player_Romus: ""To go back on your promises.""*)
  - -> `[278]` (*Player_Romus: ""To stop the reunification efforts.""*)
  - -> `[280]` (*Player_Romus: ""To spend more time with Vina.""*)
  - -> `[279]` (*Player_Romus: ""To leave Rizia.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[278]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To stop the reunification efforts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "He did not respond."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To leave Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Axel Reinhart: ""You got me.""*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To spend more time with Vina.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Axel Reinhart: ""You got me.""*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To go back on your promises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[276]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Axel Reinhart: ""I don't recall making any promises.""*)

### Węzeł `[282]`
Mówca: **Axel Reinhart**
> ""I don't recall making any promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "He did not respond."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[284]`
Mówca: **Axel Reinhart**
> ""You got me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[285]`
Mówca: **Narrator**
> "He smiled and took another sip from his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 3"*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Toras", "R_Toras_Loop");"*)

### Węzeł `[287]`
Mówca: **Axel Reinhart**
> ""Either you are not being honest with me, or you are not aware of what's been happening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Axel Reinhart: ""I didn't mean to criticize or offend you at all. But as ..."*)

### Węzeł `[288]`
Mówca: **Axel Reinhart**
> ""I didn't mean to criticize or offend you at all. But as this concerns both my wife and my Grand Duchy, I hope you can get the situation under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "He smiled and took another sip from his glass."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.AxelConcerned < 3)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Axel Reinhart: ""I think it's time we strengthen our bonds and achieve th..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.AxelConcerned < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Axel Reinhart: ""Given some concerns of ours, as well as certain other ch..."*)

### Węzeł `[292]`
Mówca: **Axel Reinhart**
> ""Given some concerns of ours, as well as certain other changes that have occurred since my wedding to Princess Vina...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Axel Reinhart: ""I believe our countries should put the reunfication proc..."*)

### Węzeł `[293]`
Mówca: **Axel Reinhart**
> ""Tell me. Can I trust that Rizia will take care of Pales as its own and respect our unique culture?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""Of course. That goes without saying.""*)
  - -> `[306]` (*Player_Romus: ""Don't worry. Pales is of such enormous value to all of u..."*)
  - -> `[307]` (*Player_Romus: ""No, Axel. We are not playing that game. You married my d..."*)

### Węzeł `[294]`
Mówca: **Axel Reinhart**
> ""I think it's time we strengthen our bonds and achieve this long-awaited reunification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Axel Reinhart: ""I've had some concerns, but in principle, I want to proc..."*)

### Węzeł `[295]`
Mówca: **Axel Reinhart**
> ""I've had some concerns, but in principle, I want to proceed with turning Rizia and Pales into a single kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Regions_Centralized == true"*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Regions_Centralized == true)"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Regions_Centralized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Regions_Centralized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Axel Reinhart: ""One thing that bothers me, though, is the centralization..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Regions_Centralized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Regions_Centralized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Axel Reinhart: ""Tell me. Can I trust that Rizia will take care of Pales ..."*)

### Węzeł `[299]`
Mówca: **Axel Reinhart**
> ""One thing that bothers me, though, is the centralization of your regional system in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Axel Reinhart: ""If we were to be united, Palesian culture and traditions..."*)

### Węzeł `[300]`
Mówca: **Axel Reinhart**
> ""If we were to be united, Palesian culture and traditions must be respected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Axel Reinhart: ""Tell me. Can I trust that Rizia will take care of Pales ..."*)

### Węzeł `[301]`
Mówca: **Axel Reinhart**
> ""Tell me. Can I trust that Rizia will take care of Pales as its own while respecting us as a semi-autonomous region?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""Of course. We can definitely make an exception for Pales.""*)
  - -> `[303]` (*Player_Romus: ""Yes, Axel. If that's your demand for unification, consid..."*)
  - -> `[304]` (*Player_Romus: ""You can trust Rizia to take care of Pales as its own, bu..."*)
  - -> `[305]` (*Player_Romus: ""No, Axel. We are not playing that game. You married my d..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. We can definitely make an exception for Pales.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, Axel. If that's your demand for unification, consider it done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can trust Rizia to take care of Pales as its own, but we cannot grant you special privileges. Once you unify with us, you will be a region of Rizia like any other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Axel. We are not playing that game. You married my daughter, and now you're going to agree to unification.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[301]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 2"*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. Pales is of such enormous value to all of us. I will make sure it gets the attention it deserves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, Axel. We are not playing that game. You married my daughter already and now I need you to stop asking questions and agree to the unification.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. That goes without saying.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Axel Reinhart: ""Good.""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Axel Reinhart: ""We will see... We will see...""*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Axel Reinhart: ""That was uncalled for.""*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Narrator: "He sighed and went quiet for a while."*)

### Węzeł `[312]`
Mówca: **Axel Reinhart**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "He looked at me with a huge smile on his face."*)

### Węzeł `[313]`
Mówca: **Axel Reinhart**
> ""I'm not sure if that's going to be enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Axel Reinhart: ""In fact...""*)

### Węzeł `[314]`
Mówca: **Axel Reinhart**
> ""We will see... We will see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Realizing that I was being serious, he averted his eyes f..."*)

### Węzeł `[315]`
Mówca: **Axel Reinhart**
> ""That was uncalled for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "Realizing that I was being serious, he averted his eyes f..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "Realizing that I was being serious, he averted his eyes from me and sipped his drink again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)

### Węzeł `[317]`
Mówca: **Narrator**
> "He sighed and went quiet for a while."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.AxelConcerned < 3)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Axel Reinhart: ""You know what...""*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.AxelConcerned < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Axel Reinhart: ""Listen.""*)

### Węzeł `[321]`
Mówca: **Axel Reinhart**
> ""You know what...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Narrator: "He looked at me with a huge smile on his face."*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned < 3"*)
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.AxelConcerned < 3)"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned < 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.AxelConcerned"] < 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Axel Reinhart: ""You know what...""*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.AxelConcerned < 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.AxelConcerned"] < 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Axel Reinhart: ""I'm not sure if that's going to be enough.""*)

### Węzeł `[325]`
Mówca: **Narrator**
> "He looked at me with a huge smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Axel Reinhart: ""Let's do it.""*)

### Węzeł `[326]`
Mówca: **Axel Reinhart**
> ""Let's do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Axel Reinhart: ""Once I'm back in Pales, I'll approve all the reunificati..."*)

### Węzeł `[327]`
Mówca: **Axel Reinhart**
> ""To our unity!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_Rizia_Unification = true; RiziaDLCSupport...."*)

### Węzeł `[328]`
Mówca: **Axel Reinhart**
> ""I just don't think Pales is ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Player_Romus: ""I understand. I hope we can regain your trust in the fut..."*)
  - -> `[332]` (*Player_Romus: ""Don't make us wait any longer, Axel.""*)
  - -> `[333]` (*Player_Romus: ""Are you kidding me? After everything I've done?""*)
  - -> `[334]` (*Player_Romus: ""You seem not to understand the situation, Axel. I only s..."*)

### Węzeł `[329]`
Mówca: **Axel Reinhart**
> ""I believe our countries should put the reunfication process on hold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Axel Reinhart: ""You know I'm not against it in principle. But now might ..."*)

### Węzeł `[330]`
Mówca: **Axel Reinhart**
> ""You know I'm not against it in principle. But now might not be the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Axel Reinhart: ""I just don't think Pales is ready.""*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand. I hope we can regain your trust in the future.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Axel Reinhart: ""Thanks for your understanding, Romus.""*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't make us wait any longer, Axel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Axel Reinhart: ""We will see about that, Romus.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you kidding me? After everything I've done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Axel Reinhart: ""We are still allies, Your Majesty. I still value and tre..."*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You seem not to understand the situation, Axel. I only sanctioned this marriage so that Rizia could get Pales back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[328]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "He raised an eyebrow."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "He raised an eyebrow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Axel Reinhart: ""You know what, Romus?""*)

### Węzeł `[336]`
Mówca: **Axel Reinhart**
> ""You know what, Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""It's time the Princess and I were on our way back home.""*)

### Węzeł `[337]`
Mówca: **Axel Reinhart**
> ""It's time the Princess and I were on our way back home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Narrator: "He finished the rest of his glass in one go and stood up,..."*)

### Węzeł `[338]`
Mówca: **Narrator**
> "He finished the rest of his glass in one go and stood up, waving at Vina as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Axel Reinhart: ""Sweetheart! Didn't you say you knew the perfect spot to ..."*)

### Węzeł `[339]`
Mówca: **Axel Reinhart**
> ""We will see about that, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Axel Reinhart: ""But for now...""*)

### Węzeł `[340]`
Mówca: **Axel Reinhart**
> ""But for now...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""It's time the Princess and I were on our way back home.""*)

### Węzeł `[341]`
Mówca: **Axel Reinhart**
> ""Thanks for your understanding, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Axel Reinhart: ""Well...""*)

### Węzeł `[342]`
Mówca: **Axel Reinhart**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Axel Reinhart: ""It's time the Princess and I were on our way back home.""*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_Rizia_Unification = true;
RiziaDLCSupport.Reports_Turn10_Pales_Peace = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Pales_Rizia_Unification"] = true;
Variable["RiziaDLCSupport.Reports_Turn10_Pales_Peace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Player_Romus: ""To our unity!""*)
  - -> `[347]` (*Player_Romus: ""Glovurius axa Rizia axa Pales!""*)
  - -> `[348]` (*Player_Romus: ""To new beginnings, and to the enduring strength of the b..."*)

### Węzeł `[344]`
Mówca: **Axel Reinhart**
> ""Once I'm back in Pales, I'll approve all the reunification documents and swear my undying fealty to the Rizian kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "He raised his glass."*)

### Węzeł `[345]`
Mówca: **Narrator**
> "He raised his glass."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Axel Reinhart: ""To our unity!""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To our unity!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "He motioned for an embrace and we hugged."*)

### Węzeł `[347]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Glovurius axa Rizia axa Pales!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[348]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To new beginnings, and to the enduring strength of the bonds forged not by politics, but by hearts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "He motioned for an embrace and we hugged."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "He motioned for an embrace and we hugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Axel Reinhart: ""If you'll excuse me, I want to join Vina at the beach be..."*)

### Węzeł `[350]`
Mówca: **Narrator**
> "It was finally real. Pales was coming back home."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Codex_Locations_Countries_Pales = false; ..."*)

### Węzeł `[351]`
Mówca: **Axel Reinhart**
> ""If you'll excuse me, I want to join Vina at the beach before the sun sets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Narrator: "It was finally real. Pales was coming back home."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[353]`
Mówca: **Axel Reinhart**
> ""Sweetheart! Didn't you say you knew the perfect spot to watch the sunset? You simply must show me right this second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "He abruptly stood up and walked away towards the sandy be..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "He abruptly stood up and walked away towards the sandy beach."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("MapChange_Pales");"*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Axel Reinhart");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Axel Reinhart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The grand Rizia-Pales reunion was right around the corner..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Toras", "R_Toras_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Toras","R_Toras_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Axel Reinhart: ""Your Majesty.""*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EvaluateConditionalInstruction("MapChange_Pales");`
- **Efekt skryptowy (`userScript`):** `EvaluateConditionalInstruction("MapChange_Pales");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speaking of preparations, shall we discuss our progress?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Axel Reinhart: ""Yes, I was getting to that.""*)

### Węzeł `[361]`
Mówca: **Axel Reinhart**
> ""Yes, I was getting to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true && RiziaDLC.Lucita_Arrest..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Marrying Lucita was the only way to keep House Azaro happy. You know they're still disappointed we never invaded you a second time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Axel Reinhart: ""They're getting what they wanted, aren't they? Pales and..."*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our marriage is a mere footnote to yours. You and Vina are the future. Lucita and I are relics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Axel Reinhart: ""Are you sure about that?""*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't be happier, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Axel Reinhart: ""A second chance at fatherhood, at your age. It must feel..."*)

### Węzeł `[365]`
Mówca: **Axel Reinhart**
> ""They're getting what they wanted, aren't they? Pales and Rizia, together at last.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Axel Reinhart: ""Although I suppose if it went the way your wife's family..."*)

### Węzeł `[366]`
Mówca: **Axel Reinhart**
> ""Although I suppose if it went the way your wife's family envisioned, they'd be on my throne and I'd be facing the guillotine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "He laced his fingers behind his head."*)

### Węzeł `[367]`
Mówca: **Axel Reinhart**
> ""A second chance at fatherhood, at your age. It must feel like a gift from God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "He laced his fingers behind his head."*)

### Węzeł `[368]`
Mówca: **Axel Reinhart**
> ""I gave away the Reinhart name for this union, as you well know. And I am on the verge of giving up the Grand Duchy's hard-won independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Axel Reinhart: ""The least that I can expect is that this... development ..."*)

### Węzeł `[369]`
Mówca: **Axel Reinhart**
> ""Are you sure about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "He laced his fingers behind his head."*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_KeepsLastName == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_KeepsLastName == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_KeepsLastName"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Axel Reinhart: ""I gave away the Reinhart name for this union, as you wel..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_KeepsLastName == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_KeepsLastName"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Axel Reinhart: ""I'm giving away the Grand Duchy's hard-won independence ..."*)

### Węzeł `[373]`
Mówca: **Axel Reinhart**
> ""I'm giving away the Grand Duchy's hard-won independence for this union, as you well know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Axel Reinhart: ""The least that I can expect is that this... development ..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "The owner bowed deferentially several times in a row befo..."*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Axel, seated next to me, looked out at the Antacean wistf..."*)

### Węzeł `[377]`
Mówca: **Narrator**
> "Axel, seated next to me, looked out at the Antacean wistfully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Axel Reinhart: ""It's refreshing being here, away from the court's rigidi..."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "The owner bowed deferentially several times in a row before rushing to set our places."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "Axel, seated next to me, looked out at the Antacean wistf..."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.ZilleReturn_Success == true)"*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.ZilleReturn_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.ZilleReturn_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Rizia_GreatUnification");"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.ZilleReturn_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.ZilleReturn_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Riza_PeacefulUnification");"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Rizia_GreatUnification");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Rizia_GreatUnification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Riza_PeacefulUnification");"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Riza_PeacefulUnification");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Riza_PeacefulUnification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "EvaluateConditionalInstruction("MapChange_Pales");"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "He motioned for an embrace and we hugged."*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree = true;
RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree = true;
RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree = true;
RiziaDLCSupport.Codex_Locations_Regions_PAD = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.News_Turn09_G_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_Sordland_Decision_Unification_Agree"] = true;
Variable["RiziaDLCSupport.Codex_Locations_Regions_PAD"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.ZilleReturn_Success == true"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unif..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree..."*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.FactionReports_Turn10_GRACE_Decision_Unification_Agree"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vendonesam_Lose == true"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Monqiz_PartyPrince"*)
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Monqiz_PartyPrince)"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Monqiz_PartyPrince`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Axel Reinhart: ""Overdone it lately, have you? I know the feeling. I'll h..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Monqiz_PartyPrince)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Monqiz_PartyPrince"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Axel Reinhart: ""Oh, I see. This is some sort of test. Listen, Your Majes..."*)

### Węzeł `[394]`
Mówca: **Axel Reinhart**
> ""Overdone it lately, have you? I know the feeling. I'll have some water as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[395]`
Mówca: **Axel Reinhart**
> ""Oh, I see. This is some sort of test. Listen, Your Majesty, I enjoy a drink as much as the next man, but I assure you I'm no Patricio Alvarez. I'll have some water as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[396]`
Mówca: **Axel Reinhart**
> ""I'm speaking hypothetically, Your Majesty. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Axel Reinhart: ""I'm just trying to wrap my head around the dynamics here..."*)

### Węzeł `[397]`
Mówca: **Axel Reinhart**
> ""I'm beginning to get the sense that's how it works in your kingdom. Whatever King Romus says, goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.T..."*)
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Axel Reinhart: ""I'm beginning to get the sense that's how it works in yo..."*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true || RiziaDLC.Theocracy_Full == true || RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true  or  Variable["RiziaDLC.Theocracy_Full"] == true  or  Variable["RiziaDLC.BirthdayGathering_ViolentAction_DirectStrike"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Axel Reinhart: ""Hmm. I hope you're right.""*)

### Węzeł `[401]`
Mówca: **Axel Reinhart**
> ""Hmm. I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Axel Reinhart: ""I'm just trying to wrap my head around the dynamics here..."*)

### Węzeł `[402]`
Mówca: **Axel Reinhart**
> ""Well, I'm glad you're optimistic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[403]`
Mówca: **Axel Reinhart**
> ""No, no. That door has slammed shut.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[404]`
Mówca: **Axel Reinhart**
> ""Nobody will dare to toy with us now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[405]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Axel Reinhart: ""Nobody will dare to toy with us now.""*)

### Węzeł `[406]`
Mówca: **Narrator**
> "HIs face darkened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Axel Reinhart: ""Either that, or the other guys...""*)

### Węzeł `[407]`
Mówca: **Axel Reinhart**
> ""Either that, or the other guys...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[408]`
Mówca: **Axel Reinhart**
> ""Nothing, Your Majesty. Just making small talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GRACEApplication == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Pales_GRACEApplication == true"*)
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Diplomacy_Pales_GRACEApplication == true)"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Pales_GRACEApplication == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Axel Reinhart: ""Why would Rizia isolate itself from GRACE? Right on the ..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Diplomacy_Pales_GRACEApplication == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Axel Reinhart: ""Why would Rizia isolate itself from GRACE and Rumburg? I..."*)

### Węzeł `[412]`
Mówca: **Axel Reinhart**
> ""Why would Rizia isolate itself from GRACE? Right on the cusp of Pales becoming a member, no less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Intermerkopum_Failed == true"*)
  - -> `[224]` (*Player_Romus: ""Rumburg is nothing but trouble, Axel. Rizia cannot affor..."*)
  - -> `[229]` (*Player_Romus: ""I see. Now that we can no longer get you into GRACE, you..."*)
  - -> `[419]` (*Player_Romus: ""Our partnership with Rumburg served its purpose. But now..."*)
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)

### Węzeł `[413]`
Mówca: **Axel Reinhart**
> ""But without the protection of GRACE or an alliance like Intermerkopum, our reunified kingdom will have to go it alone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[414]`
Mówca: **Axel Reinhart**
> ""Please, Your Majesty. I never said that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == false"*)
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == false)"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Player_Romus: ""Oh, please. Rumburg and Rizia were never truly allies. T..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[418]`
Mówca: **Narrator**
> "Axel frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Axel Reinhart: ""Like the marriage you just arranged for your daughter?""*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our partnership with Rumburg served its purpose. But now it is time for Rizia and Pales to forge our own way forward.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Axel Reinhart), `[412]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Axel Reinhart: ""We'll have a hard time doing that without other allies, ..."*)

### Węzeł `[420]`
Mówca: **Axel Reinhart**
> ""We'll have a hard time doing that without other allies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC..."*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaD..."*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Axel Reinhart: ""I have to thank you once more for getting Pales into GRA..."*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_GRACEMember == true && RiziaDLC.Diplomacy_Pales_GRACEApplication == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_GRACEMember"] == true  and  Variable["RiziaDLC.Diplomacy_Pales_GRACEApplication"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[424]`
Mówca: **Axel Reinhart**
> ""I have to thank you once more for getting Pales into GRACE, Your Majesty. Although the Lespians are furious about it, as you can imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Player_Romus: ""Good. That means we are on the right track.""*)
  - -> `[433]` (*Player_Romus: ""What did you expect? We took their favorite toy away fro..."*)
  - -> `[431]` (*Player_Romus: ""Sooner or later, they will all have to realize and respe..."*)
  - -> `[427]` (*Player_Romus: ""Still, I'd rather try to have a good relationship with t..."*)

### Węzeł `[425]`
Mówca: **Axel Reinhart**
> ""Nobody will dare to toy with us now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[426]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Axel Reinhart: ""Nobody will dare to toy with us now.""*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, I'd rather try to have a good relationship with them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Axel Reinhart: ""Alvarez should be the one trying to appease us. Not the ..."*)

### Węzeł `[428]`
Mówca: **Axel Reinhart**
> ""Alvarez should be the one trying to appease us. Not the other way around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[429]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[430]`
Mówca: **Axel Reinhart**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sooner or later, they will all have to realize and respect the power of our band of monarchies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Axel Reinhart: ""I agree.""*)

### Węzeł `[432]`
Mówca: **Axel Reinhart**
> ""What's bad for Lespia is good for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Narrator: "He laughed."*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What did you expect? We took their favorite toy away from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "He laughed."*)

### Węzeł `[434]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That means we are on the right track.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[424]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Axel Reinhart: ""What's bad for Lespia is good for us.""*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "BaseGame.Rumburg_War == true"*)
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Rumburg_War == true)"*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Rumburg_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Rumburg_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Axel Reinhart: ""I confess I don't like the rumors I'm hearing about an i..."*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Rumburg_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Rumburg_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[438]`
Mówca: **Axel Reinhart**
> ""I confess I don't like the rumors I'm hearing about an impending conflict between Rumburg and Sordland. I trust Pales would never be dragged into such a conflagration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Player_Romus: ""I'm sure it'll blow over. Nothing to worry about.""*)
  - -> `[441]` (*Player_Romus: ""The members of GRACE must support each other, Duke Reinh..."*)
  - -> `[442]` (*Player_Romus: ""Trust me, I will do everything I can to keep Rizia and P..."*)
  - -> `[440]` (*Player_Romus: ""What impending conflict?""*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure it'll blow over. Nothing to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Narrator: "He looked unconvinced."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What impending conflict?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "He wrinkled his brow."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The members of GRACE must support each other, Duke Reinhart. If we don't come to Rumburg's aid in such a situation, they will never come to ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vendonesam_Lose == true"*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, I will do everything I can to keep Rizia and Pales out of such a conflict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[438]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Axel Reinhart: ""That's the answer I was hoping for.""*)

### Węzeł `[443]`
Mówca: **Narrator**
> "He wrinkled his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Axel Reinhart: ""Have your butler read you a newspaper sometime, Your Maj..."*)

### Węzeł `[444]`
Mówca: **Axel Reinhart**
> ""Have your butler read you a newspaper sometime, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[445]`
Mówca: **Axel Reinhart**
> ""That's the answer I was hoping for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[446]`
Mówca: **Axel Reinhart**
> ""You would support Rumburg like you supported Vendonesam?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Narrator: "He frowned."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vendonesam_Lose == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vendonesam_Lose == true"*)
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vendonesam_Lose == true)"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vendonesam_Lose == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vendonesam_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Axel Reinhart: ""You would support Rumburg like you supported Vendonesam?""*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vendonesam_Lose == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vendonesam_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Axel Reinhart: ""I suppose you're right.""*)

### Węzeł `[450]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Axel Reinhart: ""But I suppose you're right.""*)

### Węzeł `[451]`
Mówca: **Axel Reinhart**
> ""But I suppose you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[452]`
Mówca: **Axel Reinhart**
> ""I suppose you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[453]`
Mówca: **Axel Reinhart**
> ""I suppose you're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[454]`
Mówca: **Narrator**
> "He looked unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Axel Reinhart: ""I suppose you're right...""*)

### Węzeł `[455]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true"*)
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true)"*)

### Węzeł `[456]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Axel Reinhart: ""One thing I did not expect from Rizia was your sudden co..."*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Diplomacy_Caleqabiz_ValgslandCSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Axel Reinhart: ""So...""*)

### Węzeł `[458]`
Mówca: **Axel Reinhart**
> ""One thing I did not expect from Rizia was your sudden coziness with Valgsland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Axel Reinhart: ""Caleqabiz, Your Majesty? You've practically put the Valg..."*)

### Węzeł `[459]`
Mówca: **Axel Reinhart**
> ""Caleqabiz, Your Majesty? You've practically put the Valgs at Pales' doorstep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Player_Romus: ""It was a necessary business arrangement. We would've los..."*)
  - -> `[462]` (*Player_Romus: ""This is not the Valgos Empire of old, Duke Reinhart. Heg..."*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[466]` (*Player_Romus: "'Your concerns are misplaced, Your Grace. Valgsland isn't..."*)

### Węzeł `[460]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a necessary business arrangement. We would've lost control of the MITZ without it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Axel Reinhart: ""I am sure you had your reasons. But you've got to unders..."*)

### Węzeł `[461]`
Mówca: **Axel Reinhart**
> ""I am sure you had your reasons. But you've got to understand how this looks to my people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 2"*)

### Węzeł `[462]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is not the Valgos Empire of old, Duke Reinhart. Hegel and his republic are different.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Axel Reinhart: ""You were there at the AN. You heard what Hegel thinks of..."*)

### Węzeł `[463]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not disparage our Valgslandian comrades. We are all one people, fighting the good fight on behalf of the common man.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Axel Reinhart: ""...Comrades?""*)

### Węzeł `[464]`
Mówca: **Axel Reinhart**
> ""...Comrades?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 3"*)

### Węzeł `[465]`
Mówca: **Axel Reinhart**
> ""You were there at the AN. You heard what Hegel thinks of me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 2"*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'Your concerns are misplaced, Your Grace. Valgsland isn't planning anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[459]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Axel Reinhart: ""Then why would they want a base so far south? Something ..."*)

### Węzeł `[467]`
Mówca: **Axel Reinhart**
> ""Then why would they want a base so far south? Something here doesn't smell right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 2"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 0"*)
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 0)"*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Player_Romus: ""Do not disparage our Valgslandian comrades. We are all o..."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Axel Reinhart: ""But anyway...""*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Axel Reinhart: ""But anyway...""*)

### Węzeł `[473]`
Mówca: **Axel Reinhart**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Ending_Revolution == true || RiziaDLC.Situation_..."*)

### Węzeł `[474]`
Mówca: **Axel Reinhart**
> ""I had my doubts at first -- especially when Mr. Esquibel stopped leading the reunification talks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Axel Reinhart: ""But my dear wife convinced me that both of our countries..."*)

### Węzeł `[475]`
Mówca: **Axel Reinhart**
> ""But my dear wife convinced me that both of our countries would be better off in the long run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[476]`
Mówca: **Axel Reinhart**
> ""My wife sees it rather differently. Personally, though, I'm just happy you took her ex-paramour out of play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[477]`
Mówca: **Axel Reinhart**
> ""King Valero was a man of many mistakes, I'll grant you that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Axel Reinhart: ""I'm not sure the House of Delegates was one of them. But..."*)

### Węzeł `[478]`
Mówca: **Axel Reinhart**
> ""I'm not sure the House of Delegates was one of them. But I'll take your word for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[479]`
Mówca: **Axel Reinhart**
> ""My wife has her qualms, as I'm sure you're aware. Personally, though, I'm just happy you took her ex-paramour out of play.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[480]`
Mówca: **Axel Reinhart**
> ""In fact...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Axel Reinhart: ""Given some concerns of ours, as well as certain other ch..."*)

### Węzeł `[481]`
Mówca: **Axel Reinhart**
> ""Listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Axel Reinhart: ""Given some concerns of ours, as well as certain other ch..."*)

### Węzeł `[482]`
Mówca: **Axel Reinhart**
> ""We are still allies, Your Majesty. I still value and treasure our partnership.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Axel Reinhart: ""But for now...""*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Codex_Locations_Countries_Pales = false;
EnableCodexEntry("Locations_Regions_Pales_Unified");
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_UnifiedMarriedVina");
EnableCodexEntry("Locations_Cities_FortAles_Reunification");
EnableCodexEntry("Locations_Cities_Terador_Reunification");`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Codex_Locations_Countries_Pales"] = false;
EnableCodexEntry("Locations_Regions_Pales_Unified");
EnableCodexEntry("Characters_ForeignLeaders_AxelReinhart_UnifiedMarriedVina");
EnableCodexEntry("Locations_Cities_FortAles_Reunification");
EnableCodexEntry("Locations_Cities_Terador_Reunification");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Diplomacy_GRACEMember == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vendonesam_Lose == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vendonesam_Lose == true"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vendonesam_Lose == true)"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vendonesam_Lose == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vendonesam_Lose"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.GRACECountries = "the United Kingdom of Rizi..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vendonesam_Lose == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vendonesam_Lose"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "RiziaDLCText.GRACECountries = "the United Kingdom of Rizi..."*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.GRACECountries = "the United Kingdom of Rizia and Pales"`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.GRACECountries"] ="the United Kingdom of Rizia and Pales";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCText.GRACECountries = "the United Kingdom of Rizia and Pales, the Confederacy of Vendonesam"`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCText.GRACECountries"] ="the United Kingdom of Rizia and Pales, the Confederacy of Vendonesam";`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_Decision_Unification_Agree..."*)

### Węzeł `[489]`
Mówca: **Axel Reinhart**
> ""The least that I can expect is that this... development won't interfere with the Princess of Rizia's birthright.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Player_Romus: ""Look at all I've done for you. Isn't it enough to be par..."*)
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[493]` (*Player_Romus: ""The child could be a girl, in which case you have nothin..."*)
  - -> `[509]` (*Player_Romus: ""Vina is my eldest child. As far as I'm concerned, she is..."*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true"*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at all I've done for you. Isn't it enough to be part of a prospering alliance?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Axel Reinhart: ""I do treasure our alliance. And I worry an Azaro heir on..."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will be honest with you. I already promised to House Azaro that if my second child is a boy, he will succeed me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true`
- **Kontekst wejściowy (poprzednik):** `[489]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Axel Reinhart: ""I see...""*)

### Węzeł `[492]`
Mówca: **Axel Reinhart**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Axel Reinhart: ""This is all stll hypothetical for now. But I hope you'll..."*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The child could be a girl, in which case you have nothing to worry about. But if it is a boy, tradition dictates he will be my heir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_RoyalTraditions_Broken == true"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reform_Success == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reform_Success == true)"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reform_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Player_Romus: ""Birthrights don't mean much these days, Axel. Whether yo..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reform_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reform_Success"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[497]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Birthrights don't mean much these days, Axel. Whether you're a prince or King Consort, your status will remain the same.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reform_Success"] == true`
- **Kontekst wejściowy (poprzednik):** `[489]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Axel Reinhart: ""Hm. Yes, that's another thing I wanted to bring up with ..."*)

### Węzeł `[498]`
Mówca: **Narrator**
> "He looked over at Lucita. She had met a young girl on the beach and was gleefully instructing her how to hold a stick as if it were a sword."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Axel Reinhart: ""And how is your own marriage going, Your Majesty? Pregna..."*)

### Węzeł `[499]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You might as well come straight out with it. You're worried about losing your claim to the throne.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[216]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Axel Reinhart: ""The thought has crossed my mind.""*)

### Węzeł `[500]`
Mówca: **Axel Reinhart**
> ""The thought has crossed my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Narrator: "He laced his fingers behind his head."*)

### Węzeł `[501]`
Mówca: **Narrator**
> "He laced his fingers behind his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_KeepsLastName == true"*)

### Węzeł `[502]`
Mówca: **Axel Reinhart**
> ""Hm. Yes, that's another thing I wanted to bring up with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[503]`
Mówca: **Axel Reinhart**
> ""I do treasure our alliance. And I worry an Azaro heir on the throne will jeopardize it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[504]`
Mówca: **Axel Reinhart**
> ""You yourself have broken royal tradition on a number of occasions. Why should this one mean so much to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_RoyalTraditions_Broken == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Law_RoyalTraditions_Broken == true"*)
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Law_RoyalTraditions_Broken == true)"*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Law_RoyalTraditions_Broken == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Law_RoyalTraditions_Broken"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Axel Reinhart: ""You yourself have broken royal tradition on a number of ..."*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Law_RoyalTraditions_Broken == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Law_RoyalTraditions_Broken"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Axel Reinhart: ""If Pales and Rizia are to forge a new kingdom together, ..."*)

### Węzeł `[508]`
Mówca: **Axel Reinhart**
> ""If Pales and Rizia are to forge a new kingdom together, we must put old traditions aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[509]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina is my eldest child. As far as I'm concerned, she is and will remain my heir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[489]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Axel Reinhart: ""Great. I hope Her Majesty isn't too put out about that.""*)

### Węzeł `[510]`
Mówca: **Axel Reinhart**
> ""Great. I hope Her Majesty isn't too put out about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pabel_RelationshipPublic == true"*)
  - -> `[513]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pabel_RelationshipPublic == true)"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pabel_RelationshipPublic == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pabel_RelationshipPublic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Axel Reinhart: ""And what of your own... unconventional partnership, Your..."*)

### Węzeł `[513]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pabel_RelationshipPublic == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pabel_RelationshipPublic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[514]`
Mówca: **Axel Reinhart**
> ""And what of your own... unconventional partnership, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Axel Reinhart: ""It took real strength to come out and announce it like t..."*)

### Węzeł `[515]`
Mówca: **Axel Reinhart**
> ""It took real strength to come out and announce it like that. I've got to say I'm impressed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Axel Reinhart: ""And, well, I admit I'm relieved to know you won't be bea..."*)

### Węzeł `[516]`
Mówca: **Axel Reinhart**
> ""And, well, I admit I'm relieved to know you won't be bearing any more children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Player_Romus: ""Come, now. Even if I was with a woman, I would never jeo..."*)
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[535]` (*Player_Romus: ""Thank you. It wasn't easy, but I couldn't go on living a..."*)
  - -> `[526]` (*Player_Romus: ""I'm too old to go through parenthood again, Axel. You tw..."*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)

### Węzeł `[517]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Come, now. Even if I was with a woman, I would never jeopardize Vina's inheritance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Narrator: "He grinned."*)

### Węzeł `[518]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Never say never. Like the metaphorical door between Pales and Rizia, this king swings both ways.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Kontekst wejściowy (poprzednik):** `[516]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Axel Reinhart: ""I, uh...""*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Player_Romus: ""Never say never. Like the metaphorical door between Pale..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[522]`
Mówca: **Axel Reinhart**
> ""I, uh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Axel Reinhart: ""I'll keep that in mind.""*)

### Węzeł `[523]`
Mówca: **Axel Reinhart**
> ""I'll keep that in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[524]`
Mówca: **Axel Reinhart**
> ""It's awfully hard to say no to Her Highness, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[525]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Axel Reinhart: ""It's awfully hard to say no to Her Highness, isn't it?""*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm too old to go through parenthood again, Axel. You two, on the other hand...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Narrator: "He grinned."*)

### Węzeł `[527]`
Mówca: **Narrator**
> "He grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Axel Reinhart: ""The topic has come up, Your Majesty. But we're in no rush.""*)

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. And as a matter of fact, should reunification go as planned, you and Vina will inherit the Rizian throne *very* soon.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Kontekst wejściowy (poprzednik):** `[516]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Narrator: "He drew in a breath."*)

### Węzeł `[529]`
Mówca: **Axel Reinhart**
> ""Thank you for telling me that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[530]`
Mówca: **Narrator**
> "He drew in a breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Axel Reinhart: ""Thank you for telling me that.""*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PromiseToAbdicate == true"*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PromiseToAbdicate == true)"*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PromiseToAbdicate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PromiseToAbdicate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Player_Romus: ""No. And as a matter of fact, should reunification go as ..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PromiseToAbdicate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PromiseToAbdicate"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[534]`
Mówca: **Axel Reinhart**
> ""The topic has come up, Your Majesty. But we're in no rush.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[535]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. It wasn't easy, but I couldn't go on living a lie.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[516]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Axel Reinhart: ""I hope your relatives will come around in time. It's as ..."*)

### Węzeł `[536]`
Mówca: **Axel Reinhart**
> ""I hope your relatives will come around in time. It's as valid a lifestyle choice as any, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Just then, the waiter of the cafe approached us to ask wh..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Drinking += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Drinking"] = Variable["RiziaDLC.PersonalValue_Drinking"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true)"*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Axel Reinhart: ""Especially after what happened at your mother's birthday.""*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[541]`
Mówca: **Axel Reinhart**
> ""Especially after what happened at your mother's birthday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Player_Romus: ""What are you talking about?""*)
  - -> `[555]` (*Player_Romus: ""There was an emergency, but it was handled swiftly by th..."*)
  - -> `[556]` (*Player_Romus: ""Rizia is only beginning its transformation. I assure you..."*)
  - -> `[557]` (*Player_Romus: ""Do you have a problem with that?""*)

### Węzeł `[542]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_ViolentAction == true"*)
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_ViolentAction == true)"*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_ViolentAction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Axel Reinhart: ""However, the tactics you used to get these reforms passe..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_ViolentAction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_ViolentAction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Axel Reinhart: ""I had my doubts at first -- especially when Mr. Esquibel..."*)

### Węzeł `[545]`
Mówca: **Axel Reinhart**
> ""However, the tactics you used to get these reforms passed struck me as highly concerning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Axel Reinhart: ""I'm just being honest with you...""*)

### Węzeł `[546]`
Mówca: **Axel Reinhart**
> ""I'm just being honest with you...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == t..."*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Axel Reinhart: ""Still, striking all three provinces at once? Not even my..."*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true && RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true  and  Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == t..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 2"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseToras"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)

### Węzeł `[554]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you talking about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He smiled nervously."*)

### Węzeł `[555]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was an emergency, but it was handled swiftly by the Rizian Crown.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He smiled nervously."*)

### Węzeł `[556]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia is only beginning its transformation. I assure you there is nothing for Pales to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He smiled nervously."*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you have a problem with that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[541]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "He smiled nervously."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "He smiled nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Axel Reinhart: ""Ehm... Your Majesty, Rizia's provincial semi-autonomy wa..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 3`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 3;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 2`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.AxelConcerned += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.AxelConcerned"] = Variable["RiziaDLCIsolated.AxelConcerned"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He took a large sip from his glass."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Promised_Succession_Son_RespectTradition == true"*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Promised_Succession_Son_RespectTradition == true)"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Promised_Succession_Son_RespectTradition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Player_Romus: ""I will be honest with you. I already promised to House A..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Promised_Succession_Son_RespectTradition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Promised_Succession_Son_RespectTradition"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[566]`
Mówca: **Axel Reinhart**
> ""This is all stll hypothetical for now. But I hope you'll keep in mind that our alliance goes back further than yours and Her Majesty's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseToras_Conquered == true)"*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseToras_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseToras_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Narrator: "The waiter penciled down the order with shaking hands, th..."*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseToras_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseToras_Conquered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)

### Węzeł `[570]`
Mówca: **Narrator**
> "The waiter penciled down the order with shaking hands, then practically raced to the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[575]` (*Player_Romus: ""Why is everyone here so scared of me? They should be gra..."*)
  - -> `[576]` (*Player_Romus: ""It's taking the province some time to adjust to the Crow..."*)
  - -> `[580]` (*Player_Romus_Italic: "Don't comment."*)

### Węzeł `[571]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right, worm. Remember who owns these lands.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Narrator: "Axel raised an eyebrow, but didn't say anything."*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player_Romus: ""That's right, worm. Remember who owns these lands.""*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why is everyone here so scared of me? They should be grateful I've purged the kingdom of traitors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Axel Reinhart: ""Mm. You must admit it's been quite the shake-up.""*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's taking the province some time to adjust to the Crown's direct rule. I assure you, they'll be happier in the end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Axel Reinhart: ""Mm. Yes, seems like it's been quite the shake-up.""*)

### Węzeł `[577]`
Mówca: **Axel Reinhart**
> ""Mm. Yes, seems like it's been quite the shake-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)

### Węzeł `[578]`
Mówca: **Axel Reinhart**
> ""Mm. You must admit it's been quite the shake-up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)

### Węzeł `[579]`
Mówca: **Narrator**
> "Axel raised an eyebrow, but didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)

### Węzeł `[580]`
**[WYBÓR GRACZA: "Don't comment."]** — Mówca: **Player_Romus_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)

### Węzeł `[581]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[583]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseToras_Conquered == true"*)

### Węzeł `[584]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)
  - -> `[586]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == f..."*)

### Węzeł `[585]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "The waiter nodded and brought us our drinks a few minutes..."*)

### Węzeł `[586]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "The waiter nodded and brought Axel's drink a few minutes ..."*)

### Węzeł `[587]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false"*)
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == f..."*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Narrator: "The waiter returned with our drinks a few moments later."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn10_PalesReunification_NoDrink == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn10_PalesReunification_NoDrink"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Narrator: "The waiter returned with Axel's drink a few moments later."*)

### Węzeł `[590]`
Mówca: **Narrator**
> "The waiter returned with our drinks a few moments later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Axel Reinhart: ""Cheers.""*)

### Węzeł `[591]`
Mówca: **Narrator**
> "The waiter returned with Axel's drink a few moments later."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "He raised his glass and then took a sip from it."*)

### Węzeł `[592]`
Mówca: **Axel Reinhart**
> ""Ehm... Your Majesty, Rizia's provincial semi-autonomy was a large reason why I agreed to these reunification efforts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Axel Reinhart: ""The idea that the Crown can simply seize control of any ..."*)

### Węzeł `[593]`
Mówca: **Axel Reinhart**
> ""The idea that the Crown can simply seize control of any province at any time... you'll excuse me if it doesn't sit right with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Player_Romus: ""Relax, Your Grace. As long as Pales behaves itself, you'..."*)
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[596]` (*Player_Romus: ""I promise you, this was strictly between me and the nobl..."*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)

### Węzeł `[594]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax, Your Grace. As long as Pales behaves itself, you'll never befall such a fate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[593]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Axel Reinhart: ""We will behave ourselves. You won't have to worry about ..."*)

### Węzeł `[595]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There was a plot to overthrow me. I did what I had to in order to protect Princess Vina's inheritance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Kontekst wejściowy (poprzednik):** `[593]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Axel Reinhart: ""If there truly was not other option, then I cannot fault..."*)

### Węzeł `[596]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise you, this was strictly between me and the nobles in question. It won't go any further than that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[593]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Axel Reinhart: ""All right. I suppose the inner workings of Rizia are sti..."*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Birthday_WarnedAboutCoup == true"*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Birthday_WarnedAboutCoup == true)"*)

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Birthday_WarnedAboutCoup == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Player_Romus: ""There was a plot to overthrow me. I did what I had to in..."*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Birthday_WarnedAboutCoup == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Player_Romus: ""I acted in pure self-defense. Had I not, I wouldn't be s..."*)

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I acted in pure self-defense. Had I not, I wouldn't be sitting here talking to you right now.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Birthday_WarnedAboutCoup"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[593]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Axel Reinhart: ""If there truly was not other option, then I cannot fault..."*)

### Węzeł `[601]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think about it, Axel. Thanks to me, House Azaro is no longer sitting at your doorstep. They'll never threaten Pales again.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Kontekst wejściowy (poprzednik):** `[593]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Axel Reinhart: ""I suppose I should be grateful about that...""*)

### Węzeł `[602]`
Mówca: **Axel Reinhart**
> ""All right. I suppose the inner workings of Rizia are still confusing to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[603]`
Mówca: **Axel Reinhart**
> ""We will behave ourselves. You won't have to worry about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseAzaro_Conquered == true"*)
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseAzaro_Conquered == true)"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseAzaro_Conquered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseAzaro_Conquered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Player_Romus: ""Think about it, Axel. Thanks to me, House Azaro is no lo..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseAzaro_Conquered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseAzaro_Conquered"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true"*)
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == t..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 1"*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BirthdayGathering_Target_StrikeHouseSazon"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[610]`
Mówca: **Axel Reinhart**
> ""I suppose I should be grateful about that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseToras == true"*)

### Węzeł `[611]`
Mówca: **Axel Reinhart**
> ""If there truly was not other option, then I cannot fault you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BirthdayGathering_Target_StrikeHouseAzaro == tru..."*)

### Węzeł `[612]`
Mówca: **Axel Reinhart**
> ""Still, striking all three provinces at once? Not even my ancestor Otto would've tried to pull that off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.AxelConcerned += 3"*)

### Węzeł `[613]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[615]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[614]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""Is this going to be a sticking point, Your Grace? My pla..."*)

### Węzeł `[615]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[616]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[618]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true)"*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player_Romus: ""There are many passages warning against it. I choose to ..."*)

### Węzeł `[618]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Player_Romus: ""Relax. I myself enjoy a drink or two from time to time. ..."*)

### Węzeł `[619]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I myself enjoy a drink or two from time to time. I'll join you.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Axel Reinhart)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Drinking += 1"*)
