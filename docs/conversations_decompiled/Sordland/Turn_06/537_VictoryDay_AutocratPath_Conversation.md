# Sordland/Turn06/VictoryDay_AutocratPath/VictoryDay_AutocratPath Conversation

- **ID konwersacji:** `537`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 06`
- **Lokalizacja pliku:** `Sordland/Turn_06/537_VictoryDay_AutocratPath_Conversation.md`
- **Liczba węzłów dialogowych:** 610
- **Liczba wyborów gracza:** 119

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[50]** Kesaro Kibener
- **[60]** Remus Holstron

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_DecreasedInteriorFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Order_SecretStatePolice`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Situation_Economy_FinancialInvestment_UC`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn05_SnO_Investigate_Opposition`
- `BaseGame.Wehlen_DefendBorder`
- `BaseGame.Wehlen_JointOperation`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4`
- `BaseGameIsolated.VictoryDay_YoungSords_Willing`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Autocrat_YoungSords_NFP_Deal`
- `BaseGame.EconomyDirection_Scale`
- `BaseGame.Gasom_Bankrupt`
- `BaseGame.Gasom_Booming`
- `BaseGame.Gasom_Default`
- `BaseGame.Gasom_Downsized`
- `BaseGame.Gasom_Ownership_ForeignOwned`
- `BaseGame.Gasom_Ownership_PrivatelyOwned`
- `BaseGame.Gasom_Ownership_StatePrivateCooperation`
- `BaseGame.GovernmentBudget`
- `BaseGame.Policy_Diplomacy_TightenedImmigration`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_49Percent`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Default`
- `BaseGame.Policy_Economy_EnergyProtectionAct_Removed`
- `BaseGame.Policy_Law_Ban_YoungSords`
- `BaseGame.Policy_Military_IncreasedFunding`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Policy_Welfare_EducationReform`
- `BaseGame.Policy_Welfare_TraditionalEducation`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_Friendly`
- `BaseGame.Relations_Ewald_Neutral`
- `BaseGame.Relations_NFP_Promised_LanguageBill`
- `BaseGame.Stopped_Investigations_NFP`
- `BaseGame.Turn03_EnT_Military_Budget_Increase`
- `BaseGame.Turn04_PSnW_Education_Progressive`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands`
- `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3`
- `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4`
- `BaseGameIsolated.VictoryDay_YoungSords_Willing`
- `BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[90] Sordland/Turn06/A_VictoryDayBludishMeeting** (../Turn_06/090_A_VictoryDayBludishMeeting.md), Węzeł `[60]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[16]` | **""Honestly, I'm already regretting my decision to come here.""** | `[15]` **Petr Vectern**: ""Why is he even in the spotlight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Petr Vectern**: ""Well, it was Lucian's idea."" |
| `[17]` | **""To be fair, his party still does.""** | `[15]` **Petr Vectern**: ""Why is he even in the spotlight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Petr Vectern**: ""Yeah, that's true."" |
| `[18]` | **""He's a dangerously competent man, Petr. We should be cautious with him.""** | `[15]` **Petr Vectern**: ""Why is he even in the spotlight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Petr Vectern**: ""I agree."" |
| `[19]` | **""He can act however he wants, Petr. He is not a threat to us.""** | `[15]` **Petr Vectern**: ""Why is he even in the spotlight..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Petr Vectern**: ""I hope so."" |
| `[26]` | **""It is good to be here.""** | `[25]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "We shook hands." |
| `[28]` | **""Thank you, Mr. Kibener.""** | `[25]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Narrator**: "We shook hands." |
| `[29]` | **""It looks like you did a good job. Maybe you should think about running for local ..."** | `[25]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Kesaro Kibener**: ""Thanks for the kind words, but ..." |
| `[32]` | **"Shake his hand in silence."** | `[25]` **Kesaro Kibener**: ""As the former mayor of Jen, it ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Petr Vectern**: ""Thank you for organizing this, ..." |
| `[43]` | **""Of course, Mr. Kibener. I understand.""** | `[42]` **Kesaro Kibener**: ""It isn't everyday that one sees..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Kesaro Kibener**: ""Thank you. There are a few thin..." |
| `[44]` | **""Well, there's nothing better to do right now. Go ahead and make your comments if ..."** | `[42]` **Kesaro Kibener**: ""It isn't everyday that one sees..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Kesaro Kibener**: ""Thank you. There are a few thin..." |
| `[45]` | **""I'll be very honest. I don't want to hear your comments. Please keep them to your..."** | `[42]` **Kesaro Kibener**: ""It isn't everyday that one sees..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Kesaro Kibener**: ""Fine. No comments. But at least..." |
| `[46]` | **""Thank you, Mr. Kibener. I appreciate your supportive words.""** | `[297]` **Kesaro Kibener**: ""Your fight against Bludish sepa..."<br>`[299]` **Kesaro Kibener**: ""Albeit not enough by any means,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "He smiled." |
| `[47]` | **""I'm glad you approve. And frankly, I don't think you and I are so different from ..."** | `[297]` **Kesaro Kibener**: ""Your fight against Bludish sepa..."<br>`[299]` **Kesaro Kibener**: ""Albeit not enough by any means,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Kesaro Kibener**: ""I wouldn't dare to disagree wit..." |
| `[48]` | **""Thank you, Mr. Kibener, but I don't need either your sympathy or your support.""** | `[297]` **Kesaro Kibener**: ""Your fight against Bludish sepa..."<br>`[299]` **Kesaro Kibener**: ""Albeit not enough by any means,..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Kesaro Kibener**: ""Oh, come on, Mr. Rayne!"" |
| `[49]` | **""Are you serious? *Not enough*? It's an emergency, Mr. Kibener. What more can I do?""** | `[299]` **Kesaro Kibener**: ""Albeit not enough by any means,..."<br>`[300]` **Kesaro Kibener**: ""Albeit not enough by any means,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Kesaro Kibener**: ""I meant no offense, Mr. Preside..."<br>`[51]` **Kesaro Kibener**: ""I meant no offense, Mr. Preside..." |
| `[64]` | **""You'll be making a grave mistake if you keep supporting terrorists like the Young..."** | `[298]` **Kesaro Kibener**: ""You are making a grave mistake ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Kesaro Kibener**: ""Just because you label them a t..." |
| `[67]` | **""It was a necessary decision. That's all I can say.""** | `[298]` **Kesaro Kibener**: ""You are making a grave mistake ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Kesaro Kibener**: ""It was hardly a *necessary* dec..." |
| `[68]` | **""Mistakes were made, but the past is in the past.""** | `[298]` **Kesaro Kibener**: ""You are making a grave mistake ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Kesaro Kibener**: ""I'm glad you agree. But the wro..." |
| `[69]` | **""Am I supposed to be impressed with these theatrics?""** | `[298]` **Kesaro Kibener**: ""You are making a grave mistake ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Kesaro Kibener**: ""That's for you to decide."" |
| `[75]` | **""And what if I don't?""** | `[74]` **Kesaro Kibener**: ""I'll be clear. You can still ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Kesaro Kibener**: ""Let's not imagine that scenario..." |
| `[76]` | **""The Young Sords orchestrated an attack at the Maroon Palace and murdered a member..."** | `[74]` **Kesaro Kibener**: ""I'll be clear. You can still ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Kesaro Kibener**: ""Yes, yes. A justified purge. A ..." |
| `[77]` | **""Don't act like you have the upper hand, Mr. Kibener. You are the one who should m..."** | `[74]` **Kesaro Kibener**: ""I'll be clear. You can still ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Kesaro Kibener**: ""No need for premature assumptio..." |
| `[78]` | **""I'm listening.""** | `[74]` **Kesaro Kibener**: ""I'll be clear. You can still ma..."<br>`[82]` **Kesaro Kibener**: ""We know how it goes. Hire a men..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Kesaro Kibener**: ""I'll be straight with you. Your..." |
| `[83]` | **""Isn't it ironic that you're the one who's saying this?""** | `[82]` **Kesaro Kibener**: ""We know how it goes. Hire a men..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Kesaro Kibener**: ""Are you saying I'm a hypocrite?..." |
| `[84]` | **""You're the one putting undue blame on minorities. Particularly the Bludish commun..."** | `[82]` **Kesaro Kibener**: ""We know how it goes. Hire a men..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Kesaro Kibener**: ""Are you saying I'm a hypocrite?..." |
| `[85]` | **""I'm sorry but I don't agree with that. The establishment is more aligned with you..."** | `[82]` **Kesaro Kibener**: ""We know how it goes. Hire a men..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Kesaro Kibener**: ""Maybe it does seem that way fro..." |
| `[93]` | **""Mr. Vice President is right. Be careful with your choice of words, Mr. Kibener.""** | `[91]` **Petr Vectern**: ""You cannot speak that way to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Kesaro Kibener**: ""I wish people would focus more ..." |
| `[94]` | **""It's okay, Petr. I want to know where he'll go with this.""** | `[91]` **Petr Vectern**: ""You cannot speak that way to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Narrator**: "Petr nodded." |
| `[95]` | **"(Point at your armed security.) "I think you're forgetting that we're in an emerge..."** | `[91]` **Petr Vectern**: ""You cannot speak that way to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Narrator**: "I pointed at the heavily armed s..." |
| `[106]` | **""I'm not going to entertain you by taking part in your word games, Mr. Kibener.""** | `[105]` **Kesaro Kibener**: ""I just wanted to confirm whethe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Kesaro Kibener**: ""Suit yourself, Mr. Rayne. But h..." |
| `[107]` | **""You've heard wrong. There are no cracks between us.""** | `[105]` **Kesaro Kibener**: ""I just wanted to confirm whethe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Kesaro Kibener**: ""Yes... I'm sure there aren't."" |
| `[108]` | **""Why would you care if it is a political suicide for me?""** | `[105]` **Kesaro Kibener**: ""I just wanted to confirm whethe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Kesaro Kibener**: ""I'm an honest man, so don't get..." |
| `[109]` | **""The answer is: I am not. I am aware of the threat the Court poses but I won't be ..."** | `[105]` **Kesaro Kibener**: ""I just wanted to confirm whethe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Kesaro Kibener**: ""Is that supposed to be noble?"" |
| `[120]` | **""You seem very confident.""** | `[171]` **Kesaro Kibener**: ""I am sure that it will pass and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Narrator**: "He smiled." |
| `[123]` | **""Even if the Assembly supports it, I will surely be using my veto on it.""** | `[171]` **Kesaro Kibener**: ""I am sure that it will pass and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Kesaro Kibener**: ""If I were you, I wouldn't stand..." |
| `[124]` | **""I'll sign the bill if it reaches me.""** | `[171]` **Kesaro Kibener**: ""I am sure that it will pass and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Suddenly, a man with a large bui..." |
| `[125]` | **""I'll have to read it in detail to decide if I can support it.""** | `[171]` **Kesaro Kibener**: ""I am sure that it will pass and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "Suddenly, a man with a large bui..." |
| `[132]` | **""Really, Mr. Kibener? When it's a Bludish person, it's Bludish terror, but when it..."** | `[82]` **Kesaro Kibener**: ""We know how it goes. Hire a men..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Kesaro Kibener**: ""Don't put words in my mouth, Pr..." |
| `[140]` | **""An ally? Tell me more.""** | `[160]` **Kesaro Kibener**: ""I want you to reconsider your o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "Petr looked at me in surprise." |
| `[144]` | **""No. Please tell me about these *grander* forces. I want to hear it.""** | `[91]` **Petr Vectern**: ""You cannot speak that way to th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Kesaro Kibener**: ""What do you want me to say? You..." |
| `[148]` | **""Who?""** | `[147]` **Petr Vectern**: ""Oh. The Iron Wall himself?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Petr Vectern**: ""The Iron Wall. The man behind....." |
| `[154]` | **""It's interesting to see you speak on behalf of an outlawed terror organization, M..."** | `[160]` **Kesaro Kibener**: ""I want you to reconsider your o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Kesaro Kibener**: ""Well, are you telling me that y..." |
| `[155]` | **""If you really thought I'd be interested in such an offer, you're living in your d..."** | `[160]` **Kesaro Kibener**: ""I want you to reconsider your o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..." |
| `[156]` | **""It's too late for that, Mr. Kibener. The Young Sords have overstepped and organiz..."** | `[160]` **Kesaro Kibener**: ""I want you to reconsider your o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..." |
| `[161]` | **""What in the world is the *Iron Wall*?""** | `[147]` **Petr Vectern**: ""Oh. The Iron Wall himself?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Kesaro Kibener**: ""It's just an old nickname that ..." |
| `[164]` | **""It's great to see your party's wholehearted support. Thank you.""** | `[147]` **Petr Vectern**: ""Oh. The Iron Wall himself?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[167]` **Kesaro Kibener**: ""No need to thank us, Mr. Rayne."" |
| `[173]` | **""Happy Victory Day, Mr. Holstron.""** | `[163]` **Remus Holstron**: ""It's nice to finally meet you i..."<br>`[591]` **Remus Holstron**: ""Good to see you again after a l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Remus Holstron**: ""Likewise."" |
| `[174]` | **""I'd also be happy to meet with him, Mr. Kibener.""** | `[147]` **Petr Vectern**: ""Oh. The Iron Wall himself?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Kesaro Kibener**: ""He'll be happy to hear that."" |
| `[182]` | **""Likewise, Mr. Holstron.""** | `[163]` **Remus Holstron**: ""It's nice to finally meet you i..."<br>`[591]` **Remus Holstron**: ""Good to see you again after a l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "We shook hands." |
| `[186]` | **""I always wanted to meet the Iron Wall himself. Today's my lucky day.""** | `[163]` **Remus Holstron**: ""It's nice to finally meet you i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Remus Holstron**: ""Well. It's Victory Day."" |
| `[190]` | **""Is that an original Rippo?""** | `[185]` **Narrator**: "Kesaro leaned against the wall, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Kesaro Kibener**: ""You bet, Mr. President. It's on..." |
| `[191]` | **""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes t..."** | `[185]` **Narrator**: "Kesaro leaned against the wall, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Kesaro Kibener**: ""Apologies."" |
| `[192]` | **""How long are we going to be waiting here exactly?""** | `[185]` **Narrator**: "Kesaro leaned against the wall, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Kesaro Kibener**: ""What, are you bored already, Mr..." |
| `[232]` | **""Thanks for the compliment.""** | `[227]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[226]` **Kesaro Kibener**: ""That brings me to the Religious..." |
| `[238]` | **""The support President Smolak received from United Contana was a concern, but real..."** | `[227]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false` | *Brak zmian stanu* | `[245]` **Kesaro Kibener**: ""Their time will come too."" |
| `[239]` | **""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""** | `[227]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..."<br>`[237]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[228]` **Kesaro Kibener**: ""That's right. They don't even k..." |
| `[240]` | **""We can't intervene in other countries. It would destabilize the region.""** | `[237]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>`[243]` **Kesaro Kibener**: ""Rumburg is using them to weaken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Kesaro Kibener**: ""A Sordish president has to do w..." |
| `[242]` | **""Wehlen could be a valuable ally in the future, now that we have established a clo..."** | `[227]` **Kesaro Kibener**: ""Now, Rumburg will have a harder..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Kesaro Kibener**: ""I doubt it."" |
| `[244]` | **""Wehlen can take care of their own problems, and we will take care of ours.""** | `[237]` **Kesaro Kibener**: ""Rumburg is using them to weaken..."<br>`[243]` **Kesaro Kibener**: ""Rumburg is using them to weaken..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[236]` **Kesaro Kibener**: ""They are a weaker nation both i..." |
| `[259]` | **""The bill was practically a recruitment flyer for the BFF. The more of these we pa..."** | `[256]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Kesaro Kibener**: ""In this case, doing nothing is ..." |
| `[261]` | **""It was too restrictive on the Bludish people. I couldn't let it pass.""** | `[256]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Kesaro Kibener**: ""If anything, we are not restric..." |
| `[262]` | **""The Bludish problem must be solved. We can't have an independence movement inside..."** | `[252]` **Kesaro Kibener**: ""Thanks to your support, the BFF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Kesaro Kibener**: ""I'm glad you and I agree on thi..." |
| `[263]` | **""It was a well-written and strong bill. It would have been wrong to veto it.""** | `[252]` **Kesaro Kibener**: ""Thanks to your support, the BFF..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Kesaro Kibener**: ""Thank you. I led the effort. I ..." |
| `[265]` | **""We need to find a way where we can coexist without violence.""** | `[252]` **Kesaro Kibener**: ""Thanks to your support, the BFF..."<br>`[256]` **Kesaro Kibener**: ""But you decided to veto it. Why..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Kesaro Kibener**: ""In an ideal world, yes. But as ..." |
| `[269]` | **""Is your national pride so fragile that this will destroy it? I don't think so.""** | `[277]` **Kesaro Kibener**: ""The NFP believes you sold our n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Kesaro Kibener**: ""I fought for my country many ti..." |
| `[271]` | **""It was a necessary evil. Don't expect me to sit by while my people suffer.""** | `[277]` **Kesaro Kibener**: ""The NFP believes you sold our n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Kesaro Kibener**: ""You are naive."" |
| `[272]` | **""Kesaro. I am the President. I won't allow you to talk to me like this.""** | `[277]` **Kesaro Kibener**: ""The NFP believes you sold our n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Kesaro Kibener**: ""Of course. My apologies."" |
| `[275]` | **""I don't see anything wrong with accepting a helping hand.""** | `[277]` **Kesaro Kibener**: ""The NFP believes you sold our n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Kesaro Kibener**: ""You are naive."" |
| `[301]` | **""Would you have thought the same if it wasn't your boys who were being targeted?""** | `[292]` **Kesaro Kibener**: ""Luckily that time is behind us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Kesaro Kibener**: ""I wouldn't, no."" |
| `[302]` | **""It was a necessary decision to make. For the time.""** | `[292]` **Kesaro Kibener**: ""Luckily that time is behind us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Kesaro Kibener**: ""It was hardly a *necessary* dec..." |
| `[303]` | **""Mistakes were made but the past is in the past.""** | `[292]` **Kesaro Kibener**: ""Luckily that time is behind us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Kesaro Kibener**: ""It's true. And I respect you fo..." |
| `[305]` | **""Am I supposed to be impressed with the theatrics?""** | `[293]` **Kesaro Kibener**: ""Political uncertainty inside an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Kesaro Kibener**: ""Oh, come on, Mr. Rayne!"" |
| `[307]` | **""Am I supposed to be impressed with the theatrics?""** | `[292]` **Kesaro Kibener**: ""Luckily that time is behind us ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Kesaro Kibener**: ""Oh, come on, Mr. Rayne!"" |
| `[309]` | **""What are you insinuating, Mr. Kibener?""** | `[293]` **Kesaro Kibener**: ""Political uncertainty inside an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Kesaro Kibener**: ""Oh, it's nothing, Mr. Rayne!"" |
| `[310]` | **""Were you not supportive of the emergency?""** | `[293]` **Kesaro Kibener**: ""Political uncertainty inside an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[289]` **Kesaro Kibener**: ""Oh, I was."" |
| `[311]` | **""Mistakes were made but the past is in the past.""** | `[293]` **Kesaro Kibener**: ""Political uncertainty inside an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Kesaro Kibener**: ""Oh, you made more than one of t..." |
| `[316]` | **""Why don't you answer my question first?""** | `[317]` **Kesaro Kibener**: ""Well, are you telling me that y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Kesaro Kibener**: ""Don't you have the power to fab..." |
| `[321]` | **""I didn't say anything about trusting the Old Guard.""** | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..."<br>`[317]` **Kesaro Kibener**: ""Well, are you telling me that y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Kesaro Kibener**: ""The Old Guard will not let you ..." |
| `[322]` | **""I don't trust the Old Guard the same way I don't trust you.""** | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..."<br>`[320]` **Kesaro Kibener**: ""You answer me. Do you or don't ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Kesaro Kibener**: ""The Old Guard will not let you ..." |
| `[323]` | **""No. I won't budge.""** | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..."<br>`[317]` **Kesaro Kibener**: ""Well, are you telling me that y..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Kesaro Kibener**: ""The Old Guard will not let you ..." |
| `[324]` | **""You know what? Let's hear what you're exactly offering here.""** | `[315]` **Kesaro Kibener**: ""Does that mean you completely t..."<br>`[317]` **Kesaro Kibener**: ""Well, are you telling me that y..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "Petr looked at me in surprise." |
| `[330]` | **""Enough with your threats. If you're delaying the celebrations for this talk, I'll..."** | `[162]` **Kesaro Kibener**: ""You made an enemy of Sordland. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Kesaro Kibener**: ""I'm not delaying anything. If y..." |
| `[331]` | **""You are making an enemy of Sordland at this very moment, Mr. Kibener. I advise yo..."** | `[162]` **Kesaro Kibener**: ""You made an enemy of Sordland. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Kesaro Kibener**: ""I may back off but others may n..." |
| `[332]` | **""It's too late to complain, Mr. Kibener. The Young Sords have overstepped and orga..."** | `[162]` **Kesaro Kibener**: ""You made an enemy of Sordland. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Kesaro Kibener**: ""You are a traitor to the cause.""<br>`[342]` **Kesaro Kibener**: ""Nobody expected you to do so."" |
| `[333]` | **""It's interesting to see you speak on behalf of an outlawed terror organization, M..."** | `[162]` **Kesaro Kibener**: ""You made an enemy of Sordland. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Kesaro Kibener**: ""Don't you have the power to fab..." |
| `[344]` | **""You know what? I am willing to hear you out. I will consider a reversal on the ba..."** | `[343]` **Kesaro Kibener**: ""You know what I'm trying to say..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Narrator**: "Petr looked at me in surprise." |
| `[345]` | **""No, I'm definitely not.""** | `[343]` **Kesaro Kibener**: ""You know what I'm trying to say..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Kesaro Kibener**: ""It is a shame to see you make e..." |
| `[370]` | **""I don't care what the nationalists think.""** | `[369]` **Remus Holstron**: ""You will regret your decision."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Remus Holstron**: ""That's very brave of you."" |
| `[371]` | **""Are you threatening the President of Sordland?""** | `[369]` **Remus Holstron**: ""You will regret your decision."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Petr Vectern**: ""Enough of this, you three. Let'..." |
| `[372]` | **""No more threats! Both of you will face consequences for your actions today.""** | `[369]` **Remus Holstron**: ""You will regret your decision."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[378]` **Petr Vectern**: ""Enough of this, you three. Let'..." |
| `[373]` | **"Stay silent."** | `[163]` **Remus Holstron**: ""It's nice to finally meet you i..."<br>`[591]` **Remus Holstron**: ""Good to see you again after a l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Remus Holstron**: ""It is good to see you both in J..."<br>`[352]` **Remus Holstron**: ""I must say I am very supportive..."<br>*(oraz 1 innych odgałęzień)* |
| `[374]` | **""Look at the time. Is the event starting already?""** | `[369]` **Remus Holstron**: ""You will regret your decision."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Remus Holstron**: ""It is about to start..."" |
| `[385]` | **""On a second thought, I don't want to involve myself with the Young Sords. We are ..."** | `[384]` **Remus Holstron**: ""If you're willing to do that, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[389]` **Remus Holstron**: ""Go ahead, Mr. Rayne. Remain a p..." |
| `[386]` | **""On a second thought, I think I should report you both for supporting terrorism.""** | `[384]` **Remus Holstron**: ""If you're willing to do that, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[387]` **Remus Holstron**: ""Go ahead, Mr. Rayne. We have do..." |
| `[394]` | **""I'm willing to consider it but I need to know about these additional requests and..."** | `[384]` **Remus Holstron**: ""If you're willing to do that, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Remus Holstron**: ""In return for giving you full s..." |
| `[401]` | **""I thought you only wanted to unban the Young Sords. What are these requests?""** | `[384]` **Remus Holstron**: ""If you're willing to do that, a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[395]` **Remus Holstron**: ""In return for giving you full s..." |
| `[408]` | **""First, tell me what the Young Sords can offer me.""** | `[407]` **Remus Holstron**: ""What do you want to know about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[430]` **Remus Holstron**: ""The Young Sords can give you on..." |
| `[409]` | **""First, I want to hear your demands.""** | `[407]` **Remus Holstron**: ""What do you want to know about ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedTo...` | `[410]` **Remus Holstron**: ""First and foremost, you will re..."<br>`[525]` **Remus Holstron**: ""We are aware of the investigati..." |
| `[416]` | **""Very intriguing. I'm willing to discuss the possibilities.""** | `[400]` **Remus Holstron**: ""If you're willing to cooperate ..."<br>`[422]` **Petr Vectern**: ""As much as I hate to involve ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Remus Holstron**: ""Great."" |
| `[417]` | **""Let's talk about how we can help each other.""** | `[400]` **Remus Holstron**: ""If you're willing to cooperate ..."<br>`[422]` **Petr Vectern**: ""As much as I hate to involve ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Remus Holstron**: ""Great."" |
| `[418]` | **""I'm sorry, but I don't want to involve myself with the Young Sords.""** | `[400]` **Remus Holstron**: ""If you're willing to cooperate ..."<br>`[422]` **Petr Vectern**: ""As much as I hate to involve ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Kesaro Kibener**: ""The Old Guard will not let you ..." |
| `[419]` | **""Petr. What do you think?""** | `[400]` **Remus Holstron**: ""If you're willing to cooperate ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Narrator**: "Petr leaned in and whispered." |
| `[427]` | **""You know what? Having the Young Sords support me is not a bad idea. Let's talk.""** | `[426]` **Kesaro Kibener**: ""You know what I'm trying to say..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[396]` **Remus Holstron**: ""Great."" |
| `[428]` | **""No, I'm definitely not.""** | `[426]` **Kesaro Kibener**: ""You know what I'm trying to say..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Remus Holstron**: ""That's a shame."" |
| `[437]` | **""Quit beating around the bush, Mr. Holstron. You are offering me an extrajudicial ..."** | `[436]` **Remus Holstron**: ""You should already have an idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Remus Holstron**: ""Me? No."" |
| `[438]` | **""Can you give me more concrete examples?""** | `[436]` **Remus Holstron**: ""You should already have an idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[443]` **Narrator**: "He smiled." |
| `[439]` | **""But how do I know they won't turn against me one day?""** | `[436]` **Remus Holstron**: ""You should already have an idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[441]` **Remus Holstron**: ""You don't. Neither do I. Who tr..." |
| `[440]` | **""I like the idea already, Mr. Holstron.""** | `[436]` **Remus Holstron**: ""You should already have an idea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Remus Holstron**: ""Beautiful."" |
| `[451]` | **""How can the Young Sords help us enforce the emergency?""** | `[450]` **Kesaro Kibener**: ""Ask away and we'll try our best..."<br>`[456]` **Remus Holstron**: ""Ms. Graf's security forces are ..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true) == false` | *Brak zmian stanu* | `[455]` **Remus Holstron**: ""The enemies of the state are th..." |
| `[452]` | **""I know the Young Sords are well-connected with the NFP. How can they support me i..."** | `[450]` **Kesaro Kibener**: ""Ask away and we'll try our best..."<br>`[456]` **Remus Holstron**: ""Ms. Graf's security forces are ..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true) == false` | *Brak zmian stanu* | `[461]` **Kesaro Kibener**: ""An alliance with the Young Sord..." |
| `[453]` | **""What if there are problematic individuals who require... being handled?""** | `[450]` **Kesaro Kibener**: ""Ask away and we'll try our best..."<br>`[456]` **Remus Holstron**: ""Ms. Graf's security forces are ..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true) == false` | *Brak zmian stanu* | `[465]` **Kesaro Kibener**: ""I've heard rumors that you alre..."<br>`[469]` **Remus Holstron**: ""If your definition of 'problema..." |
| `[454]` | **""The Court is a problem. What can we do to protect the emergency and the administr..."** | `[450]` **Kesaro Kibener**: ""Ask away and we'll try our best..."<br>`[456]` **Remus Holstron**: ""Ms. Graf's security forces are ..."<br>*(oraz 4 innych węzłów)* | `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true) == false` | *Brak zmian stanu* | `[472]` **Kesaro Kibener**: ""The Court itself isn't the main..." |
| `[504]` | **""I think I get the idea.""** | `[450]` **Kesaro Kibener**: ""Ask away and we'll try our best..."<br>`[456]` **Remus Holstron**: ""Ms. Graf's security forces are ..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[519]` **Player**: ""I think you're asking too much...."<br>`[505]` **Remus Holstron**: ""Good. And we have important req..."<br>*(oraz 1 innych odgałęzień)* |
| `[513]` | **""Let's hear what the Young Sords can offer me in return now.""** | `[492]` **Remus Holstron**: ""If you can do that, you will ha..." | `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false` | *Brak zmian stanu* | `[430]` **Remus Holstron**: ""The Young Sords can give you on..." |
| `[519]` | **""I think you're asking too much. I don't think we can make a deal.""** | `[504]` **Player**: ""I think I get the idea.""<br>`[492]` **Remus Holstron**: ""If you can do that, you will ha..." | `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true`<br>`Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true` | *Brak zmian stanu* | `[543]` **Remus Holstron**: ""That's a shame. A big mistake."" |
| `[520]` | **""Fine. I agree to your demands. It's a deal." [-2 Government Budget]"** | `[504]` **Player**: ""I think I get the idea.""<br>`[492]` **Remus Holstron**: ""If you can do that, you will ha..." | `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)`<br>`Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true`<br>`Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true` | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] = true;...`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[521]` | **""You're asking too much. I don't even want to hear about your offer.""** | `[492]` **Remus Holstron**: ""If you can do that, you will ha..." | `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false` | *Brak zmian stanu* | `[543]` **Remus Holstron**: ""That's a shame. A big mistake."" |
| `[580]` | **""Fine. I agree to your demands. It's a deal." [-1 Government Budget]"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGam...`<br>`Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] = true;...`<br>*(+2 skryptów)* | *Koniec sceny / Terminal* |
| `[581]` | **""Fine. I agree to your demands. It's a deal.""** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] = true;...`<br>`Variable["BaseGame.Stopped_Investigations_NFP"] = true;`<br>*(+1 skryptów)* | *Koniec sceny / Terminal* |

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
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Kesaro Kibener: ""Why so grouchy?""*)

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Kesaro Kibener: ""Thank you for being here so early on this glorious day i..."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Kesaro Kibener: ""Thank you for being here so early on this glorious day, ..."*)

### Węzeł `[6]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here so early on this glorious day in spite of the emergency, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Kesaro Kibener: ""As the former mayor of Jen, it is an honor to welcome yo..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "We got out of the car and walked towards the entrance of ..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "We got out of the car and walked towards the entrance of ..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "We got out of the car and walked towards the entrance of the building, escorted by our guards. Besides our own security forces, I noticed a heavy police presence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The buildings around the plaza were decorated with a comi..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The buildings around the plaza were decorated with a comically large amount of Sordish flags. Everywhere I looked, I saw a sea of maroon, white and gold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "At the entrance, Kesaro Kibener, the head of the National..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "At the entrance, Kesaro Kibener, the head of the National Front Party, was waiting for us in his iconic brown suit, together with a group of local policemen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Petr Vectern: ""Huh. I thought we arrived way too early. Looks like our ..."*)

### Węzeł `[13]`
Mówca: **Petr Vectern**
> ""Huh. I thought we arrived way too early. Looks like our host -- the devil himself -- is already expecting us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Petr Vectern: ""Why is he even in the spotlight? He's acting like he sti..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "We got out of the car and walked towards the entrance of the building, escorted by our guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The buildings around the plaza were decorated with a comi..."*)

### Węzeł `[15]`
Mówca: **Petr Vectern**
> ""Why is he even in the spotlight? He's acting like he still governs the city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player: ""To be fair, his party still does.""*)
  - -> `[16]` (*Player: ""Honestly, I'm already regretting my decision to come here.""*)
  - -> `[18]` (*Player: ""He's a dangerously competent man, Petr. We should be cau..."*)
  - -> `[19]` (*Player: ""He can act however he wants, Petr. He is not a threat to..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Honestly, I'm already regretting my decision to come here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""Well, it was Lucian's idea.""*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""To be fair, his party still does.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Petr Vectern: ""Yeah, that's true.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's a dangerously competent man, Petr. We should be cautious with him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""I agree.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He can act however he wants, Petr. He is not a threat to us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Petr Vectern: ""I hope so.""*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""Well, it was Lucian's idea.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[22]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[23]`
Mówca: **Petr Vectern**
> ""Yeah, that's true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Seeing us arrive, Kesaro approached us with a smile."*)

### Węzeł `[24]`
Mówca: **Kesaro Kibener**
> ""Thank you for being here so early on this glorious day, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Kesaro Kibener: ""As the former mayor of Jen, it is an honor to welcome yo..."*)

### Węzeł `[25]`
Mówca: **Kesaro Kibener**
> ""As the former mayor of Jen, it is an honor to welcome you to our fine city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Player: ""Thank you, Mr. Kibener.""*)
  - -> `[29]` (*Player: ""It looks like you did a good job. Maybe you should think..."*)
  - -> `[26]` (*Player: ""It is good to be here.""*)
  - -> `[32]` (*Player_Italic: "Shake his hand in silence."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It is good to be here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "We shook hands."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""Thank you for organizing this, Mr. Kibener.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "We shook hands."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It looks like you did a good job. Maybe you should think about running for local office again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Kesaro Kibener: ""Thanks for the kind words, but I'll do an even better jo..."*)

### Węzeł `[30]`
Mówca: **Kesaro Kibener**
> ""Thanks for the kind words, but I'll do an even better job as president. Besides, as you can see, our current mayor doesn't need my help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "We shook hands."*)

### Węzeł `[31]`
Mówca: **Petr Vectern**
> ""Thank you for organizing this, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "Kesaro pointed at the center of the plaza where a stage h..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Shake his hand in silence."]** — Mówca: **Player_Italic**
> "I did not reply and simply shook his hand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Petr Vectern: ""Thank you for organizing this, Mr. Kibener.""*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Seeing us arrive, Kesaro approached us with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[34]`
Mówca: **Narrator**
> "Kesaro pointed at the center of the plaza where a stage had been erected. He gestured at the blazing sun above us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Kesaro Kibener: ""It'll still be a while before the stage is ready. Why do..."*)

### Węzeł `[35]`
Mówca: **Kesaro Kibener**
> ""It'll still be a while before the stage is ready. Why don't we find somewhere away from the sun?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Kesaro Kibener: ""Please. This way.""*)

### Węzeł `[36]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Kesaro Kibener: ""Let's brighten up a little. It's Victory Day today.""*)

### Węzeł `[37]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Kesaro Kibener: ""I just wanted to use this opportunity to make some comme..."*)

### Węzeł `[38]`
Mówca: **Kesaro Kibener**
> ""Mr. Vice President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Petr Vectern: ""Sure. I'll take one too.""*)

### Węzeł `[39]`
Mówca: **Petr Vectern**
> ""Sure. I'll take one too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "After passing one more cigarette to Petr, he lit them up."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "After passing one more cigarette to Petr, he lit them up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "I took a look at his lighter as he closed its lid. It was..."*)

### Węzeł `[41]`
Mówca: **Kesaro Kibener**
> ""I just wanted to use this opportunity to make some comments on the administration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Kesaro Kibener: ""It isn't everyday that one sees the president and the vi..."*)

### Węzeł `[42]`
Mówca: **Kesaro Kibener**
> ""It isn't everyday that one sees the president and the vice president together, let alone have a conversation with them. Surely you'd understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: ""Of course, Mr. Kibener. I understand.""*)
  - -> `[44]` (*Player: ""Well, there's nothing better to do right now. Go ahead a..."*)
  - -> `[45]` (*Player: ""I'll be very honest. I don't want to hear your comments...."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Of course, Mr. Kibener. I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Kesaro Kibener: ""Thank you. There are a few things that have been occupyi..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, there's nothing better to do right now. Go ahead and make your comments if you have to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Kesaro Kibener: ""Thank you. There are a few things that have been occupyi..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be very honest. I don't want to hear your comments. Please keep them to yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Kesaro Kibener: ""Fine. No comments. But at least hear this out.""*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener. I appreciate your supportive words.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Kesaro Kibener), `[299]` (Kesaro Kibener), `[300]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "He smiled."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad you approve. And frankly, I don't think you and I are so different from each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Kesaro Kibener), `[299]` (Kesaro Kibener), `[300]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Kesaro Kibener: ""I wouldn't dare to disagree with that.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Thank you, Mr. Kibener, but I don't need either your sympathy or your support.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Kesaro Kibener), `[299]` (Kesaro Kibener), `[300]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Kesaro Kibener: ""Oh, come on, Mr. Rayne!""*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you serious? *Not enough*? It's an emergency, Mr. Kibener. What more can I do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[299]` (Kesaro Kibener), `[300]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[50]`
Mówca: **Kesaro Kibener**
> ""I meant no offense, Mr. President. You've done wonders to neutralize the Red Youth. But the Bludish separatists are just as dangerous as the commies, if not more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Kesaro Kibener: ""If only something could be done against them as well...""*)

### Węzeł `[51]`
Mówca: **Kesaro Kibener**
> ""I meant no offense, Mr. President. You've done wonders to neutralize the separatists. But the Red Youth is as equally dangerous as the Bluds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Kesaro Kibener: ""If only something could be done against them as well...""*)

### Węzeł `[52]`
Mówca: **Kesaro Kibener**
> ""If only something could be done against them as well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "He smiled."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Kesaro Kibener: ""I meant no offense, Mr. President. You've done wonders t..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Kesaro Kibener: ""I meant no offense, Mr. President. You've done wonders t..."*)

### Węzeł `[56]`
Mówca: **Kesaro Kibener**
> ""I wouldn't dare to disagree with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "He smiled."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Kesaro Kibener: ""Let's brighten up a little. It's Victory Day today.""*)

### Węzeł `[58]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Kesaro Kibener: ""What would be a more fitting act on such a day of unity ..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Kesaro Kibener: ""Let's brighten up a little. It's Victory Day today.""*)

### Węzeł `[60]`
Mówca: **Kesaro Kibener**
> ""Why so grouchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "He laughed."*)

### Węzeł `[61]`
Mówca: **Kesaro Kibener**
> ""Oh, come on, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Kesaro Kibener: ""Why so grouchy?""*)

### Węzeł `[62]`
Mówca: **Kesaro Kibener**
> ""Let's brighten up a little. It's Victory Day today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Kesaro Kibener: ""What would be a more fitting act on such a day of unity ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Kesaro Kibener: ""Let's brighten up a little. It's Victory Day today.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You'll be making a grave mistake if you keep supporting terrorists like the Young Sords, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Kesaro Kibener: ""Just because you label them a terrorist organization doe..."*)

### Węzeł `[65]`
Mówca: **Kesaro Kibener**
> ""Just because you label them a terrorist organization doesn't make them one, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He sighed and looked at me with narrowed eyes."*)

### Węzeł `[66]`
Mówca: **Kesaro Kibener**
> ""That's for you to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He sighed and looked at me with narrowed eyes."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a necessary decision. That's all I can say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Kesaro Kibener: ""It was hardly a *necessary* decision, Mr. President. You..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made, but the past is in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Kesaro Kibener: ""I'm glad you agree. But the wrongs of the past can still..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with these theatrics?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[298]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Kesaro Kibener: ""That's for you to decide.""*)

### Węzeł `[70]`
Mówca: **Kesaro Kibener**
> ""It was hardly a *necessary* decision, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He sighed and looked at me with narrowed eyes."*)

### Węzeł `[71]`
Mówca: **Kesaro Kibener**
> ""I'm glad you agree. But the wrongs of the past can still be undone by others.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "He sighed and looked at me with narrowed eyes."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "He sighed and looked at me with narrowed eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)

### Węzeł `[73]`
Mówca: **Kesaro Kibener**
> ""I want to ask you to reconsider the targets of the emergency. It is still not too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Kesaro Kibener: ""I'll be clear. You can still make it up to us. And I thi..."*)

### Węzeł `[74]`
Mówca: **Kesaro Kibener**
> ""I'll be clear. You can still make it up to us. And I think you should take that opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player: ""Don't act like you have the upper hand, Mr. Kibener. You..."*)
  - -> `[75]` (*Player: ""And what if I don't?""*)
  - -> `[76]` (*Player: ""The Young Sords orchestrated an attack at the Maroon Pal..."*)
  - -> `[78]` (*Player: ""I'm listening.""*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And what if I don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Kesaro Kibener: ""Let's not imagine that scenario, Mr. President. Let me e..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Young Sords orchestrated an attack at the Maroon Palace and murdered a member of the Assembly in cold blood. There is nothing to reconsider here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Kesaro Kibener: ""Yes, yes. A justified purge. A classic campaign of anti-..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't act like you have the upper hand, Mr. Kibener. You are the one who should make it up to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Kesaro Kibener: ""No need for premature assumptions, Mr. President.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm listening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Kesaro Kibener), `[82]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Kesaro Kibener: ""I'll be straight with you. Your politics or intentions d..."*)

### Węzeł `[79]`
Mówca: **Kesaro Kibener**
> ""No need for premature assumptions, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Kesaro Kibener: ""I'll be straight with you. Your politics or intentions d..."*)

### Węzeł `[80]`
Mówca: **Kesaro Kibener**
> ""Let's not imagine that scenario, Mr. President. Let me explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Kesaro Kibener: ""I'll be straight with you. Your politics or intentions d..."*)

### Węzeł `[81]`
Mówca: **Kesaro Kibener**
> ""Yes, yes. A justified purge. A classic campaign of anti-Sordist propaganda from the establishment. I get it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Kesaro Kibener: ""We know how it goes. Hire a mentally damaged individual ..."*)

### Węzeł `[82]`
Mówca: **Kesaro Kibener**
> ""We know how it goes. Hire a mentally damaged individual to wreak societal havoc and blame a whole group of individuals for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: ""Isn't it ironic that you're the one who's saying this?""*)
  - -> `[84]` (*Player: ""You're the one putting undue blame on minorities. Partic..."*)
  - -> `[85]` (*Player: ""I'm sorry but I don't agree with that. The establishment..."*)
  - -> `[132]` (*Player: ""Really, Mr. Kibener? When it's a Bludish person, it's Bl..."*)
  - -> `[78]` (*Player: ""I'm listening.""*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't it ironic that you're the one who's saying this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Kesaro Kibener: ""Are you saying I'm a hypocrite? Perhaps I am.""*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're the one putting undue blame on minorities. Particularly the Bludish community.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Kesaro Kibener: ""Are you saying I'm a hypocrite? Perhaps I am.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry but I don't agree with that. The establishment is more aligned with your ideology than anything else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Kesaro Kibener: ""Maybe it does seem that way from your perspective. Doesn..."*)

### Węzeł `[86]`
Mówca: **Kesaro Kibener**
> ""Are you saying I'm a hypocrite? Perhaps I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Kesaro Kibener: ""Nonetheless, none of that matters if you cannot hold ont..."*)

### Węzeł `[87]`
Mówca: **Kesaro Kibener**
> ""Maybe it does seem that way from your perspective. Doesn't mean it's the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Kesaro Kibener: ""Nonetheless, none of that matters if you cannot hold ont..."*)

### Węzeł `[88]`
Mówca: **Kesaro Kibener**
> ""Nonetheless, none of that matters if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Kesaro Kibener: ""Your emergency act may have you feeling invincible, but ..."*)

### Węzeł `[89]`
Mówca: **Kesaro Kibener**
> ""Your emergency act may have you feeling invincible, but there are forces grander than you that are set on your destruction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Petr Vectern: ""You cannot speak that way to the president, Mr. Kibener...."*)

### Węzeł `[90]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you. Your politics or intentions don't matter if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Kesaro Kibener: ""Your emergency act may have you feeling invincible, but ..."*)

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""You cannot speak that way to the president, Mr. Kibener. I hope -- for your sake -- that wasn't a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Player: ""It's okay, Petr. I want to know where he'll go with this.""*)
  - -> `[93]` (*Player: ""Mr. Vice President is right. Be careful with your choice..."*)
  - -> `[95]` (*Player: "(Point at your armed security.) "I think you're forgettin..."*)
  - -> `[144]` (*Player: ""No. Please tell me about these *grander* forces. I want ..."*)

### Węzeł `[92]`
Mówca: **Kesaro Kibener**
> ""I'll be straight with you. Your politics or intentions don't matter if you cannot hold onto your newly attained powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Kesaro Kibener: ""Your emergency act may have you feeling invincible, but ..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Vice President is right. Be careful with your choice of words, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Kesaro Kibener: ""I wish people would focus more on actions than words. Bu..."*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, Petr. I want to know where he'll go with this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "Petr nodded."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "(Point at your armed security.) "I think you're forgetting that we're in an emergency. I advise you not to bite off any more than you can chew.""]** — Mówca: **Player**
> ""I think you're forgetting that we're in an emergency. I advise you not to bite off any more than you can chew.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "I pointed at the heavily armed security forces that follo..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "I pointed at the heavily armed security forces that followed us from a distance. Kesaro took a long look at them and turned to us, smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Kesaro Kibener: ""Now, that was an actual threat. Wouldn't you agree, Mr. ..."*)

### Węzeł `[97]`
Mówca: **Kesaro Kibener**
> ""Now, that was an actual threat. Wouldn't you agree, Mr. Vectern?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""Well... Feel free to file a lawsuit, Mr. Kibener.""*)

### Węzeł `[98]`
Mówca: **Narrator**
> "Petr nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""As I said... The president is far from safe during this ..."*)

### Węzeł `[99]`
Mówca: **Kesaro Kibener**
> ""I actually wanted you to meet someone. We both have much to discuss with you. He'll be here any second now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: ""And who might that be, Mr. Kibener?""*)

### Węzeł `[100]`
Mówca: **Kesaro Kibener**
> ""What would be a more fitting act on such a day of unity than the establishment of mutual respect and cooperation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Kesaro Kibener: ""I actually wanted you to meet someone. We both have much..."*)

### Węzeł `[101]`
Mówca: **Kesaro Kibener**
> ""I wish people would focus more on actions than words. But I will do my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""As I said... The president is far from safe during this ..."*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""Well... Feel free to file a lawsuit, Mr. Kibener.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "Kesaro laughed."*)

### Węzeł `[103]`
Mówca: **Narrator**
> "Kesaro laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""As I said... The president is far from safe during this ..."*)

### Węzeł `[104]`
Mówca: **Kesaro Kibener**
> ""As I said... The president is far from safe during this emergency. I am aware of the fissures forming between the administration and the Supreme Court. The Old Guard have you at their whim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Kesaro Kibener: ""I just wanted to confirm whether you are insistent on co..."*)

### Węzeł `[105]`
Mówca: **Kesaro Kibener**
> ""I just wanted to confirm whether you are insistent on committing your own political suicide or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""The answer is: I am not. I am aware of the threat the Co..."*)
  - -> `[107]` (*Player: ""You've heard wrong. There are no cracks between us.""*)
  - -> `[106]` (*Player: ""I'm not going to entertain you by taking part in your wo..."*)
  - -> `[108]` (*Player: ""Why would you care if it is a political suicide for me?""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm not going to entertain you by taking part in your word games, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Kesaro Kibener: ""Suit yourself, Mr. Rayne. But hear me out.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You've heard wrong. There are no cracks between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Kesaro Kibener: ""Yes... I'm sure there aren't.""*)

### Węzeł `[108]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why would you care if it is a political suicide for me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Kesaro Kibener: ""I'm an honest man, so don't get me wrong. If it was only..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The answer is: I am not. I am aware of the threat the Court poses but I won't be intimidated by it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[105]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Kesaro Kibener: ""Is that supposed to be noble?""*)

### Węzeł `[110]`
Mówca: **Kesaro Kibener**
> ""I'm an honest man, so don't get me wrong. If it was only about you or the USP, I wouldn't care at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Kesaro Kibener: ""But if the nationalist movement is getting the short end..."*)

### Węzeł `[111]`
Mówca: **Kesaro Kibener**
> ""But if the nationalist movement is getting the short end of the stick in this process, then we have a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)

### Węzeł `[112]`
Mówca: **Kesaro Kibener**
> ""Suit yourself, Mr. Rayne. But hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)

### Węzeł `[113]`
Mówca: **Kesaro Kibener**
> ""Yes... I'm sure there aren't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)

### Węzeł `[114]`
Mówca: **Kesaro Kibener**
> ""Is that supposed to be noble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Kesaro Kibener: ""Look. I never questioned your courage. Your logic, on th..."*)

### Węzeł `[115]`
Mówca: **Kesaro Kibener**
> ""Look. I never questioned your courage. Your logic, on the other hand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)

### Węzeł `[116]`
Mówca: **Kesaro Kibener**
> ""Our suggestion is to finally enforce the official language of our country as stated in the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Kesaro Kibener: ""We are working on the Unified Language Act. It is direct..."*)

### Węzeł `[117]`
Mówca: **Kesaro Kibener**
> ""We are working on the Unified Language Act. It is directly aimed at the breeding grounds of the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Kesaro Kibener: ""The police have infiltrated 32 BFF training grounds in r..."*)

### Węzeł `[118]`
Mówca: **Kesaro Kibener**
> ""The bill will give the state a way to control the radicalization in these schools that teach Bludish nationalist propaganda. Without taking any rights away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Petr Vectern: ""So you want the support of the USP?""*)

### Węzeł `[119]`
Mówca: **Kesaro Kibener**
> ""I believe we already have the support of all the patriots within the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Kesaro Kibener: ""I am sure that it will pass and arrive on your desk, Mr...."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You seem very confident.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "He smiled."*)

### Węzeł `[121]`
Mówca: **Kesaro Kibener**
> ""The police have infiltrated 32 BFF training grounds in remote towns around Bergia that posed as middle schools. Despite all the evidence, similar schools keep popping up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Kesaro Kibener: ""And so-called activists are constantly blocking Governor..."*)

### Węzeł `[122]`
Mówca: **Kesaro Kibener**
> ""And so-called activists are constantly blocking Governor Bron's attempts to stop these schools, claiming he is attacking their *right to language*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Kesaro Kibener: ""The bill will give the state a way to control the radica..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even if the Assembly supports it, I will surely be using my veto on it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Kesaro Kibener: ""If I were you, I wouldn't stand in the way of the majori..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll sign the bill if it reaches me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll have to read it in detail to decide if I can support it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Suddenly, a man with a large build in a brown suit approached us. When we turned to greet him, I realized he was Remus Holstron. The Deputy of the National Front Party."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Kesaro Kibener: ""Ah. There he is! Welcome, Mr. Holstron.""*)

### Węzeł `[127]`
Mówca: **Kesaro Kibener**
> ""That shouldn't come as a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[128]`
Mówca: **Kesaro Kibener**
> ""If I were you, I wouldn't stand in the way of the majority, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[129]`
Mówca: **Petr Vectern**
> ""So you want the support of the USP?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Kesaro Kibener: ""I believe we already have the support of all the patriot..."*)

### Węzeł `[130]`
Mówca: **Kesaro Kibener**
> ""Your emergency is directly aimed at the proud nationalists of this country, Mr. Rayne. People are finally waking up to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Kesaro Kibener: ""You had your own justification, of course. A classic cam..."*)

### Węzeł `[131]`
Mówca: **Kesaro Kibener**
> ""You had your own justification, of course. A classic campaign of anti-Sordist propaganda from the establishment. I get it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Kesaro Kibener: ""We know how it goes. Hire a mentally damaged individual ..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really, Mr. Kibener? When it's a Bludish person, it's Bludish terror, but when it's Sordish nationalists, it's a few mentally handicapped individuals?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[82]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Kesaro Kibener: ""Don't put words in my mouth, President Rayne.""*)

### Węzeł `[133]`
Mówca: **Kesaro Kibener**
> ""You made an enemy out of Sordish nationalists -- people who have the deepest love for this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Kesaro Kibener: ""The Young Sords aren't some kind of a 'fringe group of m..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && ..."*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false &..."*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Kesaro Kibener: ""Your emergency is directly aimed at the proud nationalis..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == false && BaseGame.Reform_EmergencyDecree_Banned_RY == false && BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == false  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Kesaro Kibener: ""I want to ask you to reconsider the targets of the emerg..."*)

### Węzeł `[137]`
Mówca: **Kesaro Kibener**
> ""Don't put words in my mouth, President Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Kesaro Kibener: ""Nonetheless, none of that matters if you cannot hold ont..."*)

### Węzeł `[138]`
Mówca: **Kesaro Kibener**
> ""You cannot win a fight against the core values of Sords and Sordland. I hope you are aware of that mistake now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)

### Węzeł `[139]`
Mówca: **Kesaro Kibener**
> ""The Young Sords aren't some kind of a 'fringe group of militants' as your administration claims. You know whom they represent and how many stand behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Kesaro Kibener: ""You cannot win a fight against the core values of Sords ..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""An ally? Tell me more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Petr looked at me in surprise."*)

### Węzeł `[141]`
Mówca: **Kesaro Kibener**
> ""What, are you bored already, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "He laughed."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Kesaro Kibener: ""Don't worry. It won't take too long.""*)

### Węzeł `[143]`
Mówca: **Kesaro Kibener**
> ""You are making an enemy out of Sordish nationalists -- people who have the deepest love for this nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Kesaro Kibener: ""The Young Sords aren't some kind of a 'fringe group of m..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. Please tell me about these *grander* forces. I want to hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Kesaro Kibener: ""What do you want me to say? You know your enemies better..."*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""And who might that be, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Kesaro Kibener: ""My deputy, Remus Holstron. He wanted to personally congr..."*)

### Węzeł `[146]`
Mówca: **Kesaro Kibener**
> ""My deputy, Remus Holstron. He wanted to personally congratulate you for your emergency policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Petr Vectern: ""Oh. The Iron Wall himself?""*)

### Węzeł `[147]`
Mówca: **Petr Vectern**
> ""Oh. The Iron Wall himself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Who?""*)
  - -> `[174]` (*Player: ""I'd also be happy to meet with him, Mr. Kibener.""*)
  - -> `[164]` (*Player: ""It's great to see your party's wholehearted support. Tha..."*)
  - -> `[161]` (*Player: ""What in the world is the *Iron Wall*?""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Who?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Petr Vectern: ""The Iron Wall. The man behind... well, many things. Let'..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && B..."*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true &&..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Kesaro Kibener: ""Especially after you isolated yourself and made everyone..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true && BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Kesaro Kibener: ""I want you to reconsider your orders about the Young Sor..."*)

### Węzeł `[152]`
Mówca: **Kesaro Kibener**
> ""Especially after you isolated yourself and made everyone your enemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Kesaro Kibener: ""I want you to reconsider your orders about the Young Sor..."*)

### Węzeł `[153]`
Mówca: **Kesaro Kibener**
> ""What do you want me to say? You know your enemies better than me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Kesaro Kibener: ""As I said... The president is far from safe during this ..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's interesting to see you speak on behalf of an outlawed terror organization, Mr. Kibener. To be clear, are you admitting your ties to the Young Sords?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Kesaro Kibener: ""Well, are you telling me that you completely trust the O..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If you really thought I'd be interested in such an offer, you're living in your dreams.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Kesaro Kibener: ""Does that mean you completely trust the Old Guard and wi..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too late for that, Mr. Kibener. The Young Sords have overstepped and organized a political assassination in the heart of the capital. I cannot simply reverse my decision after that fact.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Kesaro Kibener: ""Does that mean you completely trust the Old Guard and wi..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||Ba..."*)
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false &..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true ||BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true  or Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Kesaro Kibener: ""You made an enemy out of Sordish nationalists -- people ..."*)

### Węzeł `[160]`
Mówca: **Kesaro Kibener**
> ""I want you to reconsider your orders about the Young Sords. It's not too late to make amends. Besides, if there's an ally to be made, it is the nationalist youth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Player: ""It's interesting to see you speak on behalf of an outlaw..."*)
  - -> `[140]` (*Player: ""An ally? Tell me more.""*)
  - -> `[155]` (*Player: ""If you really thought I'd be interested in such an offer..."*)
  - -> `[156]` (*Player: ""It's too late for that, Mr. Kibener. The Young Sords hav..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What in the world is the *Iron Wall*?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Kesaro Kibener: ""It's just an old nickname that stuck around. Nobody real..."*)

### Węzeł `[162]`
Mówca: **Kesaro Kibener**
> ""You made an enemy of Sordland. I hope you are aware of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""Enough with your threats. If you're delaying the celebra..."*)
  - -> `[333]` (*Player: ""It's interesting to see you speak on behalf of an outlaw..."*)
  - -> `[331]` (*Player: ""You are making an enemy of Sordland at this very moment,..."*)
  - -> `[332]` (*Player: ""It's too late to complain, Mr. Kibener. The Young Sords ..."*)

### Węzeł `[163]`
Mówca: **Remus Holstron**
> ""It's nice to finally meet you in person, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""Likewise, Mr. Holstron.""*)
  - -> `[186]` (*Player: ""I always wanted to meet the Iron Wall himself. Today's m..."*)
  - -> `[173]` (*Player: ""Happy Victory Day, Mr. Holstron.""*)
  - -> `[373]` (*Player_Italic: "Stay silent."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's great to see your party's wholehearted support. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Kesaro Kibener: ""No need to thank us, Mr. Rayne.""*)

### Węzeł `[165]`
Mówca: **Petr Vectern**
> ""The Iron Wall. The man behind... well, many things. Let's just say he's a bit of a legend within the nationalist movement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Kesaro Kibener: ""It's just an old nickname that stuck around. Nobody real..."*)

### Węzeł `[166]`
Mówca: **Kesaro Kibener**
> ""He'll be happy to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Kesaro Kibener: ""While we wait, I wanted to quickly mention a few things ..."*)

### Węzeł `[167]`
Mówca: **Kesaro Kibener**
> ""No need to thank us, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Kesaro Kibener: ""While we wait, I wanted to quickly mention a few things ..."*)

### Węzeł `[168]`
Mówca: **Kesaro Kibener**
> ""It's just an old nickname that stuck around. Nobody really calls him that anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Kesaro Kibener: ""While we wait, I wanted to quickly mention a few things ..."*)

### Węzeł `[169]`
Mówca: **Kesaro Kibener**
> ""While we wait, I wanted to quickly mention a few things that were occupying my mind recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Jump to: [Jump_KesarosComments]"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Jump_KesarosComments]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump_KesarosComments"*)

### Węzeł `[171]`
Mówca: **Kesaro Kibener**
> ""I am sure that it will pass and arrive on your desk, Mr. President. All I'm asking is for you not to veto it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player: ""I'll sign the bill if it reaches me.""*)
  - -> `[125]` (*Player: ""I'll have to read it in detail to decide if I can suppor..."*)
  - -> `[120]` (*Player: ""You seem very confident.""*)
  - -> `[123]` (*Player: ""Even if the Assembly supports it, I will surely be using..."*)

### Węzeł `[172]`
Mówca: **Kesaro Kibener**
> ""Ah. There he is! Welcome, Mr. Holstron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Happy Victory Day, Mr. Holstron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Remus Holstron), `[591]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Remus Holstron: ""Likewise.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd also be happy to meet with him, Mr. Kibener.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Kesaro Kibener: ""He'll be happy to hear that.""*)

### Węzeł `[175]`
Mówca: **Kesaro Kibener**
> ""Thank you. There are a few things that have been occupying my mind recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "Jump to: [Jump_KesarosComments]"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump_KesarosComments`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Kesaro Kibener: ""The Bludish independence movement, for example... Not on..."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Jump_KesarosComments]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "Jump_KesarosComments"*)

### Węzeł `[178]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Kesaro Kibener: ""That shouldn't come as a surprise.""*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Kesaro Kibener: ""Look. I don't mean to corner you o..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Kesaro Kibener: ""Look. I don't mean to corner you on Victory Day like thi..."*)

### Węzeł `[180]`
Mówca: **Kesaro Kibener**
> ""Fine. No comments. But at least hear this out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "Jump to: [Kesaro Kibener: ""Look. I don't mean to corner ..."*)

### Węzeł `[181]`
Mówca: **Kesaro Kibener**
> ""The Young Sords aren't some kind of a 'fringe group of militants' as your administration claimed. You know whom they represent and how many are behind them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Kesaro Kibener: ""You made an enemy of Sordland. I hope you are aware of t..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Likewise, Mr. Holstron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Remus Holstron), `[591]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "We shook hands."*)

### Węzeł `[183]`
Mówca: **Kesaro Kibener**
> ""Please. This way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "We walked until we found a shady spot just outside the Je..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "We walked until we found a shady spot just outside the Jen Center of Culture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Kesaro leaned against the wall, pulled out a cigarette an..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Kesaro leaned against the wall, pulled out a cigarette and lit it up with his Rippo lighter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""Is that an original Rippo?""*)
  - -> `[191]` (*Player: ""Have you forgotten common courtesy, Mr. Kibener? Are we ..."*)
  - -> `[192]` (*Player: ""How long are we going to be waiting here exactly?""*)

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I always wanted to meet the Iron Wall himself. Today's my lucky day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Remus Holstron: ""Well. It's Victory Day.""*)

### Węzeł `[187]`
Mówca: **Remus Holstron**
> ""Well. It's Victory Day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "We shook hands."*)

### Węzeł `[188]`
Mówca: **Remus Holstron**
> ""Likewise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "We shook hands."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is that an original Rippo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Kesaro Kibener: ""You bet, Mr. President. It's one of the first.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have you forgotten common courtesy, Mr. Kibener? Are we not offering cigarettes to friends anymore?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Kesaro Kibener: ""Apologies.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How long are we going to be waiting here exactly?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Kesaro Kibener: ""What, are you bored already, Mr. Rayne?""*)

### Węzeł `[193]`
Mówca: **Kesaro Kibener**
> ""You bet, Mr. President. It's one of the first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He gave me the lighter. It was obviously high-quality, bu..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "He passed a cigarette to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Kesaro Kibener: ""Mr. Vice President?""*)

### Węzeł `[195]`
Mówca: **Kesaro Kibener**
> ""Apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "He passed a cigarette to me."*)

### Węzeł `[196]`
Mówca: **Kesaro Kibener**
> ""Our flags fly above the clouds, Mr. Rayne. And from up there, our fallen brothers, our national pride, the Sordish spirit... They're all watching over us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[197]`
Mówca: **Kesaro Kibener**
> ""And they surely watched in shame when the true patriots of this country were targeted with purely political reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Kesaro Kibener: ""Luckily that time is behind us now. Thankfully, you revo..."*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Kesaro Kibener: ""And they surely watched in shame when the true patriots ..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Kesaro Kibener: ""And they are surely concerned of the current circumstanc..."*)

### Węzeł `[201]`
Mówca: **Kesaro Kibener**
> ""The Bludish independence movement, for example... Not only do the separatists pose an existential risk to us, they also threaten our neighbors in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == false"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == false)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Kesaro Kibener: ""And they are surely applauding you for your determinatio..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Kesaro Kibener: ""And they are surely ashamed of what we Sords are living ..."*)

### Węzeł `[205]`
Mówca: **Kesaro Kibener**
> ""I may not be fond of President Smolak, but our joint operation with the Wehzeks was certainly successful in stamping out the BFF. I consider that a great success.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Kesaro Kibener: ""Now, Rumburg will have a harder time trying to influence..."*)

### Węzeł `[206]`
Mówca: **Kesaro Kibener**
> ""That's from a bullet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Kesaro Kibener: ""Believe it or not, this lighter is the reason I'm alive ..."*)

### Węzeł `[207]`
Mówca: **Kesaro Kibener**
> ""Don't worry. It won't take too long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "I took a look at his lighter as he closed its lid. It was..."*)

### Węzeł `[208]`
Mówca: **Kesaro Kibener**
> ""Believe it or not, this lighter is the reason I'm alive today. I should be thankful that the damn assassin was a Blud. No wonder he was incompetent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Kesaro Kibener: ""The lighter took the first shot. The second one grazed m..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "I took a look at his lighter as he closed its lid. It was a regular Rippo, but its shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Looking more closely, I could see a large circular dent i..."*)

### Węzeł `[210]`
Mówca: **Narrator**
> "Looking more closely, I could see a large circular dent in the chrome plating."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Kesaro Kibener: ""That's from a bullet.""*)

### Węzeł `[211]`
Mówca: **Narrator**
> "He pulled on his collar to reveal a scar on his neck."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Kesaro Kibener: ""Maybe I'll tell you the full story some other time. For ..."*)

### Węzeł `[212]`
Mówca: **Kesaro Kibener**
> ""Maybe I'll tell you the full story some other time. For now, I have some other things in mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "He took a drag from his cigarette and pointed at the gian..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "He took a drag from his cigarette and pointed at the giant flagpole in the plaza. I had to crane my neck to see the enormous Sordish flag flying from it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Kesaro Kibener: ""Our flags fly above the clouds, Mr. Rayne. And from up t..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "He gave me the lighter. It was obviously high-quality, but its shape appeared to be malformed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_KesaroLighter");"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_JointOperation == true"*)
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_JointOperation == true)"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_JointOperation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Kesaro Kibener: ""I may not be fond of President Smolak, but our joint ope..."*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_JointOperation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == false"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[221]`
Mówca: **Kesaro Kibener**
> ""And they are surely ashamed of what we Sords are living through today. Ashamed of how the true patriots of this country are being targeted for purely political reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Kesaro Kibener: ""You are making a grave mistake targeting the wrong peopl..."*)

### Węzeł `[222]`
Mówca: **Kesaro Kibener**
> ""The lighter took the first shot. The second one grazed me right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Narrator: "He pulled on his collar to reveal a scar on his neck."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && Ba..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Kesaro Kibener: ""Your fight against Bludish separatists and radical Malen..."*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)

### Węzeł `[226]`
Mówca: **Kesaro Kibener**
> ""That brings me to the Religious Harmony Bill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Kesaro Kibener: ""Our party and many members of parliament worked extremel..."*)

### Węzeł `[227]`
Mówca: **Kesaro Kibener**
> ""Now, Rumburg will have a harder time trying to influence us from within. Let's not forget their caches of KA-74s in our country. You've done the right thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player: ""Thanks for the compliment.""*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false"*)
  - -> `[242]` (*Player: ""Wehlen could be a valuable ally in the future, now that ..."*)
  - -> `[239]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)

### Węzeł `[228]`
Mówca: **Kesaro Kibener**
> ""That's right. They don't even know whom they are dealing with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[229]`
Mówca: **Kesaro Kibener**
> ""Closing the borders with Wehlen has helped, but the countryside of Nargis and Bergia continues to be plagued by the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[230]`
Mówca: **Kesaro Kibener**
> ""Wehlen continues to be plagued by the BFF. They use their secret bases in the mountains to launch infiltrations into Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)

### Węzeł `[231]`
Mówca: **Kesaro Kibener**
> ""I doubt it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA: ""Thanks for the compliment.""]** — Mówca: **Player**
> ""Thanks for the compliment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Wehlen_DefendBorder == true"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Wehlen_DefendBorder == true)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Wehlen_DefendBorder == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Wehlen_DefendBorder"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Kesaro Kibener: ""Closing the borders with Wehlen has helped, but the coun..."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Wehlen_DefendBorder == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Wehlen_DefendBorder"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Kesaro Kibener: ""Wehlen continues to be plagued by the BFF. They use thei..."*)

### Węzeł `[236]`
Mówca: **Kesaro Kibener**
> ""They are a weaker nation both in heart and might. They won't have the capacity to handle the Bludish threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[237]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us, and they might succeed if we do nothing to stop them. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)
  - -> `[240]` (*Player: ""We can't intervene in other countries. It would destabil..."*)
  - -> `[244]` (*Player: ""Wehlen can take care of their own problems, and we will ..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""]** — Mówca: **Player**
> ""The support President Smolak received from United Contana was a concern, but realpolitik was the victor.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Kontekst wejściowy (poprzednik):** `[227]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Kesaro Kibener: ""Their time will come too.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""]** — Mówca: **Player**
> ""Rumburg and the BFF will both meet a bad end if they dare to divide Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Kesaro Kibener), `[237]` (Kesaro Kibener), `[243]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Kesaro Kibener: ""That's right. They don't even know whom they are dealing..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA: ""We can't intervene in other countries. It would destabilize the region.""]** — Mówca: **Player**
> ""We can't intervene in other countries. It would destabilize the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Kesaro Kibener), `[243]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Kesaro Kibener: ""A Sordish president has to do whatever is necessary to p..."*)

### Węzeł `[241]`
Mówca: **Kesaro Kibener**
> ""A Sordish president has to do whatever is necessary to protect his people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA: ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""]** — Mówca: **Player**
> ""Wehlen could be a valuable ally in the future, now that we have established a closer relationship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[227]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Kesaro Kibener: ""I doubt it.""*)

### Węzeł `[243]`
Mówca: **Kesaro Kibener**
> ""Rumburg is using them to weaken us. Hopefully, our increased military funding will make sure their efforts won't bear fruit. But we need to stay vigilant. Let's not forget their caches of KA-74s in our country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: ""Rumburg and the BFF will both meet a bad end if they dar..."*)
  - -> `[240]` (*Player: ""We can't intervene in other countries. It would destabil..."*)
  - -> `[244]` (*Player: ""Wehlen can take care of their own problems, and we will ..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""Wehlen can take care of their own problems, and we will take care of ours.""]** — Mówca: **Player**
> ""Wehlen can take care of their own problems, and we will take care of ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[237]` (Kesaro Kibener), `[243]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Kesaro Kibener: ""They are a weaker nation both in heart and might. They w..."*)

### Węzeł `[245]`
Mówca: **Kesaro Kibener**
> ""Their time will come too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Kesaro Kibener: ""That brings me to the Religious Harmony Bill.""*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false"*)
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == f..."*)

### Węzeł `[247]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Player: ""The support President Smolak received from United Contan..."*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Military_Budget_Increase == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Military_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Kesaro Kibener: ""Rumburg is using them to weaken us. Hopefully, our incre..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Military_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Kesaro Kibener: ""Rumburg is using them to weaken us, and they might succe..."*)

### Węzeł `[252]`
Mówca: **Kesaro Kibener**
> ""Thanks to your support, the BFF and other extremist groups won't be able to use religion to organize and gain support among the common folk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player: ""The Bludish problem must be solved. We can't have an ind..."*)
  - -> `[263]` (*Player: ""It was a well-written and strong bill. It would have bee..."*)
  - -> `[265]` (*Player: ""We need to find a way where we can coexist without viole..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Kesaro Kibener: ""Thanks to your support, the BFF and other extremist grou..."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Kesaro Kibener: ""But you decided to veto it. Why are you ignoring the pro..."*)

### Węzeł `[256]`
Mówca: **Kesaro Kibener**
> ""But you decided to veto it. Why are you ignoring the problem? The Bludish are using Nurity as a tool in their quest for independence. This is a direct threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: ""We need to find a way where we can coexist without viole..."*)
  - -> `[261]` (*Player: ""It was too restrictive on the Bludish people. I couldn't..."*)
  - -> `[259]` (*Player: ""The bill was practically a recruitment flyer for the BFF..."*)

### Węzeł `[257]`
Mówca: **Kesaro Kibener**
> ""If anything, we are not restrictive enough. But I will not dive into this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[258]`
Mówca: **Kesaro Kibener**
> ""In this case, doing nothing is far worse. The BFF is actively using priests in majority-Bludish areas. But let's not get off track.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[259]`
**[WYBÓR GRACZA: ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""]** — Mówca: **Player**
> ""The bill was practically a recruitment flyer for the BFF. The more of these we pass, the more followers they get.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Kesaro Kibener: ""In this case, doing nothing is far worse. The BFF is act..."*)

### Węzeł `[260]`
Mówca: **Kesaro Kibener**
> ""Thank you. I led the effort. I was happy but not surprised to receive so much support from my fellow MPs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[261]`
**[WYBÓR GRACZA: ""It was too restrictive on the Bludish people. I couldn't let it pass.""]** — Mówca: **Player**
> ""It was too restrictive on the Bludish people. I couldn't let it pass.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Kesaro Kibener: ""If anything, we are not restrictive enough. But I will n..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA: ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""]** — Mówca: **Player**
> ""The Bludish problem must be solved. We can't have an independence movement inside Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Kesaro Kibener: ""I'm glad you and I agree on this issue.""*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""It was a well-written and strong bill. It would have been wrong to veto it.""]** — Mówca: **Player**
> ""It was a well-written and strong bill. It would have been wrong to veto it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Kesaro Kibener: ""Thank you. I led the effort. I was happy but not surpris..."*)

### Węzeł `[264]`
Mówca: **Kesaro Kibener**
> ""In an ideal world, yes. But as long as the BFF exists, that is not the world we live in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[265]`
**[WYBÓR GRACZA: ""We need to find a way where we can coexist without violence.""]** — Mówca: **Player**
> ""We need to find a way where we can coexist without violence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[252]` (Kesaro Kibener), `[256]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Kesaro Kibener: ""In an ideal world, yes. But as long as the BFF exists, t..."*)

### Węzeł `[266]`
Mówca: **Kesaro Kibener**
> ""I'm glad you and I agree on this issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)

### Węzeł `[267]`
Mówca: **Kesaro Kibener**
> ""Our party and many members of parliament worked extremely hard on the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true"*)

### Węzeł `[268]`
Mówca: **Kesaro Kibener**
> ""Look. I don't mean to corner you on Victory Day like this, but I have to mention an important bill in the making.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Kesaro Kibener: ""Our suggestion is to finally enforce the official langua..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA: ""Is your national pride so fragile that this will destroy it? I don't think so.""]** — Mówca: **Player**
> ""Is your national pride so fragile that this will destroy it? I don't think so.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Kesaro Kibener: ""I fought for my country many times, and I have the scars..."*)

### Węzeł `[270]`
Mówca: **Kesaro Kibener**
> ""You were fooled. They saw Sordland battling the recession and they pounced on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Kesaro Kibener: ""The NFP believes you sold our national pride for money.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA: ""It was a necessary evil. Don't expect me to sit by while my people suffer.""]** — Mówca: **Player**
> ""It was a necessary evil. Don't expect me to sit by while my people suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Kesaro Kibener: ""You are naive.""*)

### Węzeł `[272]`
**[WYBÓR GRACZA: ""Kesaro. I am the President. I won't allow you to talk to me like this.""]** — Mówca: **Player**
> ""Kesaro. I am the President. I won't allow you to talk to me like this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Kesaro Kibener: ""Of course. My apologies.""*)

### Węzeł `[273]`
Mówca: **Kesaro Kibener**
> ""Of course. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Kesaro Kibener: ""Look. I don't mean to corner you on Victory Day like thi..."*)

### Węzeł `[274]`
Mówca: **Kesaro Kibener**
> ""I fought for my country many times, and I have the scars to prove it. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Kesaro Kibener: ""I won't waste my breath further on this matter, since yo..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""I don't see anything wrong with accepting a helping hand.""]** — Mówca: **Player**
> ""I don't see anything wrong with accepting a helping hand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Kesaro Kibener: ""You are naive.""*)

### Węzeł `[276]`
Mówca: **Kesaro Kibener**
> ""You are naive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Kesaro Kibener: ""I won't waste my breath further on this matter, since yo..."*)

### Węzeł `[277]`
Mówca: **Kesaro Kibener**
> ""The NFP believes you sold our national pride for money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Player: ""It was a necessary evil. Don't expect me to sit by while..."*)
  - -> `[275]` (*Player: ""I don't see anything wrong with accepting a helping hand.""*)
  - -> `[269]` (*Player: ""Is your national pride so fragile that this will destroy..."*)
  - -> `[272]` (*Player: ""Kesaro. I am the President. I won't allow you to talk to..."*)

### Węzeł `[278]`
Mówca: **Kesaro Kibener**
> ""I won't waste my breath further on this matter, since you clearly don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Kesaro Kibener: ""Look. I don't mean to corner you on Victory Day like thi..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true"*)
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == t..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Kesaro Kibener: ""I also wanted to talk about the aid you received from Un..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Kesaro Kibener: ""Look. I don't mean to corner you on Victory Day like thi..."*)

### Węzeł `[282]`
Mówca: **Kesaro Kibener**
> ""I also wanted to talk about the aid you received from United Contana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Kesaro Kibener: ""Do you think that's just free money? Do you think they o..."*)

### Węzeł `[283]`
Mówca: **Kesaro Kibener**
> ""Do you think that's just free money? Do you think they offered it out of sheer goodwill?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Kesaro Kibener: ""You were fooled. They saw Sordland battling the recessio..."*)

### Węzeł `[284]`
Mówca: **Kesaro Kibener**
> ""Oh, it's nothing, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Kesaro Kibener: ""Why so grouchy?""*)

### Węzeł `[285]`
Mówca: **Kesaro Kibener**
> ""I think it didn't last long enough to make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He smiled."*)

### Węzeł `[286]`
Mówca: **Kesaro Kibener**
> ""Oh, you made more than one of those.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Kesaro Kibener: ""The emergency was the right call but it didn't last long..."*)

### Węzeł `[287]`
Mówca: **Kesaro Kibener**
> ""The emergency was the right call but it didn't last long enough to make a difference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He smiled."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Kesaro Kibener: ""Let's brighten up a little. It's Victory Day today.""*)

### Węzeł `[289]`
Mówca: **Kesaro Kibener**
> ""Oh, I was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Kesaro Kibener: ""I think it didn't last long enough to make a difference.""*)

### Węzeł `[290]`
Mówca: **Kesaro Kibener**
> ""And they are surely concerned of the current circumstances the Sords have to go live through. One day you have an emergency, the next day the rules are different again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Kesaro Kibener: ""Political uncertainty inside and exploitative pressures ..."*)

### Węzeł `[291]`
Mówca: **Kesaro Kibener**
> ""And they are surely applauding you for your determination in maintaining stability in this nation. Applauding how its true patriots are finally taking it back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true && Base..."*)

### Węzeł `[292]`
Mówca: **Kesaro Kibener**
> ""Luckily that time is behind us now. Thankfully, you revoked that emergency before it was too late.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Player: ""Would you have thought the same if it wasn't your boys w..."*)
  - -> `[302]` (*Player: ""It was a necessary decision to make. For the time.""*)
  - -> `[303]` (*Player: ""Mistakes were made but the past is in the past.""*)
  - -> `[307]` (*Player: ""Am I supposed to be impressed with the theatrics?""*)

### Węzeł `[293]`
Mówca: **Kesaro Kibener**
> ""Political uncertainty inside and exploitative pressures outside. It is an unusual time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""What are you insinuating, Mr. Kibener?""*)
  - -> `[310]` (*Player: ""Were you not supportive of the emergency?""*)
  - -> `[311]` (*Player: ""Mistakes were made but the past is in the past.""*)
  - -> `[305]` (*Player: ""Am I supposed to be impressed with the theatrics?""*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY == true"*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Kesaro Kibener: ""Albeit not enough by any means, your fight against the r..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Kesaro Kibener: ""Albeit not enough by any means, your fight against Bludi..."*)

### Węzeł `[297]`
Mówca: **Kesaro Kibener**
> ""Your fight against Bludish separatists and radical Malenyevists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Thank you, Mr. Kibener. I appreciate your supportive wor..."*)
  - -> `[47]` (*Player: ""I'm glad you approve. And frankly, I don't think you and..."*)
  - -> `[48]` (*Player: ""Thank you, Mr. Kibener, but I don't need either your sym..."*)

### Węzeł `[298]`
Mówca: **Kesaro Kibener**
> ""You are making a grave mistake targeting the wrong people, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""You'll be making a grave mistake if you keep supporting ..."*)
  - -> `[67]` (*Player: ""It was a necessary decision. That's all I can say.""*)
  - -> `[68]` (*Player: ""Mistakes were made, but the past is in the past.""*)
  - -> `[69]` (*Player: ""Am I supposed to be impressed with these theatrics?""*)

### Węzeł `[299]`
Mówca: **Kesaro Kibener**
> ""Albeit not enough by any means, your fight against the radical Malenyevists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Thank you, Mr. Kibener. I appreciate your supportive wor..."*)
  - -> `[47]` (*Player: ""I'm glad you approve. And frankly, I don't think you and..."*)
  - -> `[48]` (*Player: ""Thank you, Mr. Kibener, but I don't need either your sym..."*)
  - -> `[49]` (*Player: ""Are you serious? *Not enough*? It's an emergency, Mr. Ki..."*)

### Węzeł `[300]`
Mówca: **Kesaro Kibener**
> ""Albeit not enough by any means, your fight against Bludish separatists has been commendable, Mr. Rayne. I must thank you for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player: ""Thank you, Mr. Kibener. I appreciate your supportive wor..."*)
  - -> `[47]` (*Player: ""I'm glad you approve. And frankly, I don't think you and..."*)
  - -> `[48]` (*Player: ""Thank you, Mr. Kibener, but I don't need either your sym..."*)
  - -> `[49]` (*Player: ""Are you serious? *Not enough*? It's an emergency, Mr. Ki..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Would you have thought the same if it wasn't your boys who were being targeted?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Kesaro Kibener: ""I wouldn't, no.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It was a necessary decision to make. For the time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Kesaro Kibener: ""It was hardly a *necessary* decision, Mr. President. You..."*)

### Węzeł `[303]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made but the past is in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Kesaro Kibener: ""It's true. And I respect you for admitting that.""*)

### Węzeł `[304]`
Mówca: **Kesaro Kibener**
> ""I wouldn't, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Kesaro Kibener: ""What? You expected me to come up with a witty response c..."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with the theatrics?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Kesaro Kibener: ""Oh, come on, Mr. Rayne!""*)

### Węzeł `[306]`
Mówca: **Kesaro Kibener**
> ""Oh, come on, Mr. Rayne!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Kesaro Kibener: ""Why so grouchy?""*)

### Węzeł `[307]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Am I supposed to be impressed with the theatrics?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[292]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Kesaro Kibener: ""Oh, come on, Mr. Rayne!""*)

### Węzeł `[308]`
Mówca: **Kesaro Kibener**
> ""What? You expected me to come up with a witty response claiming I would?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He smiled."*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you insinuating, Mr. Kibener?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Kesaro Kibener: ""Oh, it's nothing, Mr. Rayne!""*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Were you not supportive of the emergency?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Kesaro Kibener: ""Oh, I was.""*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mistakes were made but the past is in the past.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[293]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Kesaro Kibener: ""Oh, you made more than one of those.""*)

### Węzeł `[312]`
Mówca: **Kesaro Kibener**
> ""It's true. And I respect you for admitting that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He smiled."*)

### Węzeł `[313]`
Mówca: **Kesaro Kibener**
> ""It was hardly a *necessary* decision, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He smiled."*)

### Węzeł `[314]`
Mówca: **Kesaro Kibener**
> ""Why so grouchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "He laughed."*)

### Węzeł `[315]`
Mówca: **Kesaro Kibener**
> ""Does that mean you completely trust the Old Guard and will not budge on your position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player: ""I didn't say anything about trusting the Old Guard.""*)
  - -> `[322]` (*Player: ""I don't trust the Old Guard the same way I don't trust y..."*)
  - -> `[323]` (*Player: ""No. I won't budge.""*)
  - -> `[324]` (*Player: ""You know what? Let's hear what you're exactly offering h..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why don't you answer my question first?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[317]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Kesaro Kibener: ""Don't you have the power to fabricate an answer to that ..."*)

### Węzeł `[317]`
Mówca: **Kesaro Kibener**
> ""Well, are you telling me that you completely trust the Old Guard and will not budge on your position?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player: ""Why don't you answer my question first?""*)
  - -> `[321]` (*Player: ""I didn't say anything about trusting the Old Guard.""*)
  - -> `[323]` (*Player: ""No. I won't budge.""*)
  - -> `[324]` (*Player: ""You know what? Let's hear what you're exactly offering h..."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "Petr looked at me in surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Willing = true"*)

### Węzeł `[319]`
Mówca: **Kesaro Kibener**
> ""Don't you have the power to fabricate an answer to that question yourself and do whatever you wish with it? I refuse to play that game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Kesaro Kibener: ""You answer me. Do you or don't you trust the Old Guard? ..."*)

### Węzeł `[320]`
Mówca: **Kesaro Kibener**
> ""You answer me. Do you or don't you trust the Old Guard? And is your position flexible?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player: ""I don't trust the Old Guard the same way I don't trust y..."*)
  - -> `[323]` (*Player: ""No. I won't budge.""*)
  - -> `[324]` (*Player: ""You know what? Let's hear what you're exactly offering h..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I didn't say anything about trusting the Old Guard.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Kesaro Kibener), `[317]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Kesaro Kibener: ""The Old Guard will not let you free from their hook. You..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't trust the Old Guard the same way I don't trust you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Kesaro Kibener), `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Kesaro Kibener: ""The Old Guard will not let you free from their hook. You..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. I won't budge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Kesaro Kibener), `[317]` (Kesaro Kibener), `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Kesaro Kibener: ""The Old Guard will not let you free from their hook. You..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Let's hear what you're exactly offering here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[315]` (Kesaro Kibener), `[317]` (Kesaro Kibener), `[320]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Petr looked at me in surprise."*)

### Węzeł `[325]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know they can strike back at you at any time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Kesaro Kibener: ""If the nationalists supported you, the emergency would h..."*)

### Węzeł `[326]`
Mówca: **Kesaro Kibener**
> ""If the nationalists supported you, the emergency would have been much more effective against its 'true' targets. And you wouldn't need to fear Hawker as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Petr Vectern: ""'Effective' in what way, exactly?""*)

### Węzeł `[327]`
Mówca: **Petr Vectern**
> ""'Effective' in what way, exactly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Kesaro Kibener: ""You know what I'm trying to say... But are you willing t..."*)

### Węzeł `[328]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know that they can strike back at you at any time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""It is a shame to see you make enemies of everybody. But ..."*)

### Węzeł `[329]`
Mówca: **Kesaro Kibener**
> ""It is a shame to see you make enemies of everybody. But if you're willing to continue on this path, I'll gladly watch your demise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enough with your threats. If you're delaying the celebrations for this talk, I'll take my leave.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Kesaro Kibener: ""I'm not delaying anything. If you're willing to abandon ..."*)

### Węzeł `[331]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You are making an enemy of Sordland at this very moment, Mr. Kibener. I advise you to back off before it's too late.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Kesaro Kibener: ""I may back off but others may not.""*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's too late to complain, Mr. Kibener. The Young Sords have overstepped and organized a political assassination in the heart of the capital. I cannot simply reverse my decision after that fact.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's interesting to see you speak on behalf of an outlawed terror organization, Mr. Kibener. To be clear, are you admitting your ties to the Young Sords?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Kesaro Kibener: ""Don't you have the power to fabricate an answer to that ..."*)

### Węzeł `[334]`
Mówca: **Kesaro Kibener**
> ""I'm not delaying anything. If you're willing to abandon Sordland's largest Victory Day celebrations, feel free to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Kesaro Kibener: ""That would only harm your reputation.""*)

### Węzeł `[335]`
Mówca: **Kesaro Kibener**
> ""That would only harm your reputation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[336]`
Mówca: **Kesaro Kibener**
> ""Don't you have the power to fabricate an answer to that question yourself and do whatever you wish with it? I refuse to play that game.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[337]`
Mówca: **Kesaro Kibener**
> ""I may back off but others may not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Kesaro Kibener: ""You are a traitor to the cause.""*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Kesaro Kibener: ""Nobody expected you to do so.""*)

### Węzeł `[341]`
Mówca: **Kesaro Kibener**
> ""You are a traitor to the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[342]`
Mówca: **Kesaro Kibener**
> ""Nobody expected you to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Kesaro Kibener: ""But know this. The Sordists wi-""*)

### Węzeł `[343]`
Mówca: **Kesaro Kibener**
> ""You know what I'm trying to say... But are you willing to have that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Player: ""You know what? I am willing to hear you out. I will cons..."*)
  - -> `[345]` (*Player: ""No, I'm definitely not.""*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? I am willing to hear you out. I will consider a reversal on the ban of the Young Sords -- if you can *convince* me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "Petr looked at me in surprise."*)

### Węzeł `[345]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I'm definitely not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Kesaro Kibener: ""It is a shame to see you make enemies of everybody. But ..."*)

### Węzeł `[346]`
Mówca: **Kesaro Kibener**
> ""But know this. The Sordists wi-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "Suddenly, a man with a large build..."]"*)

### Węzeł `[347]`
Mówca: **Kesaro Kibener**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)
  - -> `[350]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)"*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == false"*)

### Węzeł `[350]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Remus Holstron: ""It is good to see you both in Jen today. This means a lo..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "Suddenly, a man with a large build..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Suddenly, a man with a large build in a brown suit approa..."*)

### Węzeł `[352]`
Mówca: **Remus Holstron**
> ""I must say I am very supportive of the emergency, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Remus Holstron: ""The Sordists and the wider Sordish nationalist movement ..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == false"*)
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == false)"*)

### Węzeł `[354]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Remus Holstron: ""I must say I am very supportive of the emergency, Mr. Ra..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Remus Holstron: ""I must say you are very lucky to survive the journey to ..."*)

### Węzeł `[356]`
Mówca: **Remus Holstron**
> ""The Sordists and the wider Sordish nationalist movement hold the consensus view that the act was justified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "He looked me straight in the eye."*)

### Węzeł `[357]`
Mówca: **Remus Holstron**
> ""I must say you are very lucky to survive the journey to central Jen, Mr. Rayne. This city is the stronghold of the Sordists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Remus Holstron: ""The Sordists and the wider Sordish nationalist movement ..."*)

### Węzeł `[358]`
Mówca: **Remus Holstron**
> ""It is good to see you both in Jen today. This means a lot to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Remus Holstron: ""The event is about to begin. Why don't we slowly walk ov..."*)

### Węzeł `[359]`
Mówca: **Remus Holstron**
> ""The Sordists and the wider Sordish nationalist movement hold the consensus view that this emergency is targeting them as a whole.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Willing == true"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Willing = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Kesaro Kibener: ""Good.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Willing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Willing == true"*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_YoungSords_Willing == true)"*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Willing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Kesaro Kibener: ""I've already talked to Mr. President about a possible re..."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_YoungSords_Willing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Willing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Remus Holstron: ""You will regret your decision.""*)

### Węzeł `[364]`
Mówca: **Kesaro Kibener**
> ""I've already talked to Mr. President about a possible reversal of the wrongs that have been made.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Kesaro Kibener: ""He is willing to compromise for our support.""*)

### Węzeł `[365]`
Mówca: **Kesaro Kibener**
> ""He is willing to compromise for our support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Remus Holstron: ""That is great to hear.""*)

### Węzeł `[366]`
Mówca: **Remus Holstron**
> ""That is great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "He looked at me straight in the eye."*)

### Węzeł `[367]`
Mówca: **Remus Holstron**
> ""The event is about to begin. Why don't we slowly walk over to the plaza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Petr Vectern: ""About time. Let's go.""*)

### Węzeł `[368]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[369]`
Mówca: **Remus Holstron**
> ""You will regret your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Player: ""Are you threatening the President of Sordland?""*)
  - -> `[372]` (*Player: ""No more threats! Both of you will face consequences for ..."*)
  - -> `[370]` (*Player: ""I don't care what the nationalists think.""*)
  - -> `[374]` (*Player: ""Look at the time. Is the event starting already?""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't care what the nationalists think.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Remus Holstron: ""That's very brave of you.""*)

### Węzeł `[371]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you threatening the President of Sordland?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Petr Vectern: ""Enough of this, you three. Let's go to the damn plaza an..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No more threats! Both of you will face consequences for your actions today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Petr Vectern: ""Enough of this, you three. Let's go to the damn plaza an..."*)

### Węzeł `[373]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I did not respond."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Remus Holstron), `[591]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true"*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look at the time. Is the event starting already?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Remus Holstron: ""It is about to start...""*)

### Węzeł `[375]`
Mówca: **Remus Holstron**
> ""It is about to start...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Remus Holstron: ""Let me show you the way.""*)

### Węzeł `[376]`
Mówca: **Remus Holstron**
> ""Let me show you the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Petr Vectern: ""About damn time.""*)

### Węzeł `[377]`
Mówca: **Petr Vectern**
> ""About damn time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[378]`
Mówca: **Petr Vectern**
> ""Enough of this, you three. Let's go to the damn plaza and get this event over with already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Remus Holstron: ""Agreed. Our presence is expected.""*)

### Węzeł `[379]`
Mówca: **Remus Holstron**
> ""That's very brave of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Remus Holstron: ""Anyway, our presence is expected at the plaza. Shall we ..."*)

### Węzeł `[380]`
Mówca: **Remus Holstron**
> ""Agreed. Our presence is expected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[381]`
Mówca: **Narrator**
> "He looked at me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Remus Holstron: ""Mr. Rayne. The nationalists are willing to give you thei..."*)

### Węzeł `[382]`
Mówca: **Remus Holstron**
> ""Mr. Rayne. The nationalists are willing to give you their support if you are willing to protect them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Remus Holstron: ""And if you reverse the ban on the Young Sords, and give ..."*)

### Węzeł `[383]`
Mówca: **Remus Holstron**
> ""And if you reverse the ban on the Young Sords, and give your support to the group, you will be in a much stronger position enforcing your emergency powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Remus Holstron: ""If you're willing to do that, and help us with a few req..."*)

### Węzeł `[384]`
Mówca: **Remus Holstron**
> ""If you're willing to do that, and help us with a few requests, we can have this conversation in detail. I can answer any questions you have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""I'm willing to consider it but I need to know about thes..."*)
  - -> `[401]` (*Player: ""I thought you only wanted to unban the Young Sords. What..."*)
  - -> `[385]` (*Player: ""On a second thought, I don't want to involve myself with..."*)
  - -> `[386]` (*Player: ""On a second thought, I think I should report you both fo..."*)

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On a second thought, I don't want to involve myself with the Young Sords. We are not having this conversation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Remus Holstron: ""Go ahead, Mr. Rayne. Remain a puppet of the Sollists.""*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""On a second thought, I think I should report you both for supporting terrorism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Remus Holstron: ""Go ahead, Mr. Rayne. We have done nothing wrong and the ..."*)

### Węzeł `[387]`
Mówca: **Remus Holstron**
> ""Go ahead, Mr. Rayne. We have done nothing wrong and the police knows this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Remus Holstron: ""Good luck with your masters in the Old Guard.""*)

### Węzeł `[388]`
Mówca: **Kesaro Kibener**
> ""It's actually about to begin. Follow me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[389]`
Mówca: **Remus Holstron**
> ""Go ahead, Mr. Rayne. Remain a puppet of the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Remus Holstron: ""Good luck with your masters in the Old Guard.""*)

### Węzeł `[390]`
Mówca: **Remus Holstron**
> ""Good luck with your masters in the Old Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Petr Vectern: ""Enough!""*)

### Węzeł `[391]`
Mówca: **Petr Vectern**
> ""It's a celebration, remember? Let's go to the damn plaza and get this event over with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Kesaro Kibener: ""It's actually about to begin. Follow me.""*)

### Węzeł `[392]`
Mówca: **Petr Vectern**
> ""Enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "Everybody went silent."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "Everybody went silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Petr Vectern: ""It's a celebration, remember? Let's go to the damn plaza..."*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm willing to consider it but I need to know about these additional requests and exactly what you are offering.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Remus Holstron: ""In return for giving you full support, the nationalists ..."*)

### Węzeł `[395]`
Mówca: **Remus Holstron**
> ""In return for giving you full support, the nationalists would expect you to show them that you are a true patriot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Remus Holstron: ""What do you want to know about first?""*)

### Węzeł `[396]`
Mówca: **Remus Holstron**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Remus Holstron: ""The Young Sords can give you on-the-ground support that ..."*)

### Węzeł `[397]`
Mówca: **Narrator**
> "He looked me straight in the eye."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Remus Holstron: ""President Rayne. The nationalists are willing to give yo..."*)

### Węzeł `[398]`
Mówca: **Remus Holstron**
> ""President Rayne. The nationalists are willing to give you their support if you are willing to protect them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Remus Holstron: ""I'm referring particularly to the Young Sords. Many in t..."*)

### Węzeł `[399]`
Mówca: **Remus Holstron**
> ""I'm referring particularly to the Young Sords. Many in the organization feel the urge to support you directly in your efforts against our enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Remus Holstron: ""With the Young Sords on your side, you will be in a much..."*)

### Węzeł `[400]`
Mówca: **Remus Holstron**
> ""If you're willing to cooperate with the Young Sords, we can have this conversation in detail. I can answer any questions you have about a possible alliance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""I'm sorry, but I don't want to involve myself with the Y..."*)
  - -> `[419]` (*Player: ""Petr. What do you think?""*)
  - -> `[416]` (*Player: ""Very intriguing. I'm willing to discuss the possibilities.""*)
  - -> `[417]` (*Player: ""Let's talk about how we can help each other.""*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I thought you only wanted to unban the Young Sords. What are these requests?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[384]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Remus Holstron: ""In return for giving you full support, the nationalists ..."*)

### Węzeł `[402]`
Mówca: **Remus Holstron**
> ""However, revoking the ban alone won't be enough to erase the trauma you brought upon them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Remus Holstron: ""They'll need resources to be able to rebuild again. You'..."*)

### Węzeł `[403]`
Mówca: **Remus Holstron**
> ""And finally, we want you to sign the Unified Education Act when it reaches you. We already have the support of the Assembly and it would be a step in the right direction if you do not use your veto powers on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Remus Holstron: ""If you can do that, you will have the nationalist moveme..."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Remus Holstron: ""And you will order the complete halt of your education r..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)

### Węzeł `[407]`
Mówca: **Remus Holstron**
> ""What do you want to know about first?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "Questions_YSDeal"*)

### Węzeł `[408]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, tell me what the Young Sords can offer me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Remus Holstron: ""The Young Sords can give you on-the-ground support that ..."*)

### Węzeł `[409]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""First, I want to hear your demands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[407]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands = ..."*)

### Węzeł `[410]`
Mówca: **Remus Holstron**
> ""First and foremost, you will revoke the ban on the Young Sords and recognize them as a legal organization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Remus Holstron: ""However, revoking the ban alone won't be enough to erase..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)"*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Remus Holstron: ""You will write a decree to tighten immigration. Effectiv..."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[414]`
Mówca: **Remus Holstron**
> ""With the Young Sords on your side, you will be in a much stronger position to enforce your emergency powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Remus Holstron: ""And judging by the current relationship you have with th..."*)

### Węzeł `[415]`
Mówca: **Remus Holstron**
> ""And judging by the current relationship you have with the Supreme Court, it would be a good idea for you to have strong allies outside of their direct reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Remus Holstron: ""If you're willing to cooperate with the Young Sords, we ..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very intriguing. I'm willing to discuss the possibilities.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Remus Holstron), `[422]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Remus Holstron: ""Great.""*)

### Węzeł `[417]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's talk about how we can help each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Remus Holstron), `[422]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Remus Holstron: ""Great.""*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry, but I don't want to involve myself with the Young Sords.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Remus Holstron), `[422]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Kesaro Kibener: ""The Old Guard will not let you free from their hook. You..."*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. What do you think?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Narrator: "Petr leaned in and whispered."*)

### Węzeł `[420]`
Mówca: **Narrator**
> "Petr leaned in and whispered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Petr Vectern: ""You know I don't necessarily enjoy the emergency. But at..."*)

### Węzeł `[421]`
Mówca: **Petr Vectern**
> ""You know I don't necessarily enjoy the emergency. But at this point, why not hear the Iron Wall out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Petr Vectern: ""As much as I hate to involve ourselves with the Young So..."*)

### Węzeł `[422]`
Mówca: **Petr Vectern**
> ""As much as I hate to involve ourselves with the Young Sords, he has a point about the Court. You need strong allies against them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player: ""I'm sorry, but I don't want to involve myself with the Y..."*)
  - -> `[416]` (*Player: ""Very intriguing. I'm willing to discuss the possibilities.""*)
  - -> `[417]` (*Player: ""Let's talk about how we can help each other.""*)

### Węzeł `[423]`
Mówca: **Kesaro Kibener**
> ""The Old Guard will not let you free from their hook. You know they can strike back at you at any time. We can help each other out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Kesaro Kibener: ""If the nationalists supported you, the emergency would b..."*)

### Węzeł `[424]`
Mówca: **Kesaro Kibener**
> ""If the nationalists supported you, the emergency would be much more effective against its targets. And you wouldn't need to fear Hawker as much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Petr Vectern: ""'Effective' in what way exactly, Mr. Kibener?""*)

### Węzeł `[425]`
Mówca: **Petr Vectern**
> ""'Effective' in what way exactly, Mr. Kibener?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Kesaro Kibener: ""You know what I'm trying to say... But are you willing t..."*)

### Węzeł `[426]`
Mówca: **Kesaro Kibener**
> ""You know what I'm trying to say... But are you willing to have that conversation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Player: ""You know what? Having the Young Sords support me is not ..."*)
  - -> `[428]` (*Player: ""No, I'm definitely not.""*)

### Węzeł `[427]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Having the Young Sords support me is not a bad idea. Let's talk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Remus Holstron: ""Great.""*)

### Węzeł `[428]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, I'm definitely not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Kesaro Kibener)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Remus Holstron: ""That's a shame.""*)

### Węzeł `[429]`
Mówca: **Remus Holstron**
> ""That's a shame.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Kesaro Kibener: ""Well... I guess we can start walking towards the plaza. ..."*)

### Węzeł `[430]`
Mówca: **Remus Holstron**
> ""The Young Sords can give you on-the-ground support that the state institutions cannot provide. A helping hand to steer the country towards your cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer = true"*)

### Węzeł `[431]`
Mówca: **Kesaro Kibener**
> ""Well... I guess we can start walking towards the plaza. The event is about to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Petr Vectern: ""About time. Let's go.""*)

### Węzeł `[432]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Opposition == true)"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Remus Holstron: ""We are also aware of the investigations being conducted ..."*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[436]`
Mówca: **Remus Holstron**
> ""You should already have an idea of what they're capable of. With protection from the President himself, they will surely have the power to eliminate any obstacle that stands in your way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Player: ""But how do I know they won't turn against me one day?""*)
  - -> `[438]` (*Player: ""Can you give me more concrete examples?""*)
  - -> `[437]` (*Player: ""Quit beating around the bush, Mr. Holstron. You are offe..."*)
  - -> `[440]` (*Player: ""I like the idea already, Mr. Holstron.""*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Quit beating around the bush, Mr. Holstron. You are offering me an extrajudicial solution to political problems. Isn't that right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Remus Holstron: ""Me? No.""*)

### Węzeł `[438]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Can you give me more concrete examples?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Narrator: "He smiled."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But how do I know they won't turn against me one day?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Remus Holstron: ""You don't. Neither do I. Who truly knows what the future..."*)

### Węzeł `[440]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I like the idea already, Mr. Holstron.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[436]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Remus Holstron: ""Beautiful.""*)

### Węzeł `[441]`
Mówca: **Remus Holstron**
> ""You don't. Neither do I. Who truly knows what the future will bring?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Remus Holstron: ""Trust is mutual, Mr. Rayne. As long as both sides unders..."*)

### Węzeł `[442]`
Mówca: **Remus Holstron**
> ""Trust is mutual, Mr. Rayne. As long as both sides understand each other, there would be no reason to end a beneficial cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Kesaro Kibener: ""The support of a such a massive non-governmental organiz..."*)

### Węzeł `[443]`
Mówca: **Narrator**
> "He smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Remus Holstron: ""No, I cannot. But I can tell you whether what's on your ..."*)

### Węzeł `[444]`
Mówca: **Remus Holstron**
> ""No, I cannot. But I can tell you whether what's on your mind can be done or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Kesaro Kibener: ""Ask away and we'll try our best to answer.""*)

### Węzeł `[445]`
Mówca: **Remus Holstron**
> ""Me? No.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Remus Holstron: ""But I'm not responsible for anything the Young Sords mig..."*)

### Węzeł `[446]`
Mówca: **Remus Holstron**
> ""But I'm not responsible for anything the Young Sords might or might not want to offer you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Kesaro Kibener: ""The support of a such a massive non-governmental organiz..."*)

### Węzeł `[447]`
Mówca: **Remus Holstron**
> ""Beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Kesaro Kibener: ""The support of a such a massive non-governmental organiz..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Questions_YSDeal`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Player: ""First, tell me what the Young Sords can offer me.""*)
  - -> `[409]` (*Player: ""First, I want to hear your demands.""*)

### Węzeł `[449]`
Mówca: **Kesaro Kibener**
> ""The support of a such a massive non-governmental organization would surely be useful to you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Kesaro Kibener: ""Ask away and we'll try our best to answer.""*)

### Węzeł `[450]`
Mówca: **Kesaro Kibener**
> ""Ask away and we'll try our best to answer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "VictoryDay_AutocratOfferHub"*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""How can the Young Sords help us enforce the emergency?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[450]` (Kesaro Kibener), `[456]` (Remus Holstron), `[460]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Remus Holstron: ""The enemies of the state are the enemies of the Young So..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I know the Young Sords are well-connected with the NFP. How can they support me if they're aligned with our rivals?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[450]` (Kesaro Kibener), `[456]` (Remus Holstron), `[460]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Kesaro Kibener: ""An alliance with the Young Sords means an unofficial all..."*)

### Węzeł `[453]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What if there are problematic individuals who require... being handled?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[450]` (Kesaro Kibener), `[456]` (Remus Holstron), `[460]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The Court is a problem. What can we do to protect the emergency and the administration?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[450]` (Kesaro Kibener), `[456]` (Remus Holstron), `[460]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Kesaro Kibener: ""The Court itself isn't the main problem. It's certain in..."*)

### Węzeł `[455]`
Mówca: **Remus Holstron**
> ""The enemies of the state are the enemies of the Young Sords, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[456]`
Mówca: **Remus Holstron**
> ""Ms. Graf's security forces are doing a good job enforcing the rules on the ground, but they might still have some gaps that need filling in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 = true"*)

### Węzeł `[457]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Remus Holstron: ""Ms. Graf's security forces are doing a good job enforcin..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Remus Holstron: ""They can help the security forces on the ground where ne..."*)

### Węzeł `[460]`
Mówca: **Remus Holstron**
> ""They can help the security forces on the ground where necessary. I'm sure that would be very valuable, considering the current lack of funding for the police.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 = true"*)

### Węzeł `[461]`
Mówca: **Kesaro Kibener**
> ""An alliance with the Young Sords means an unofficial alliance with the nationalist movement, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Kesaro Kibener: ""As long as our policies stay aligned, we are no rivals. ..."*)

### Węzeł `[462]`
Mówca: **Kesaro Kibener**
> ""As long as our policies stay aligned, we are no rivals. Nationalists being in charge of this nation has only benefits for both of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Kesaro Kibener: ""Hell, maybe it's even about time for the USP to form an ..."*)

### Węzeł `[463]`
Mówca: **Kesaro Kibener**
> ""Hell, maybe it's even about time for the USP to form an official alliance with the NFP. We'd be stronger together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Remus Holstron: ""If it's the elections you're worried about, don't. If yo..."*)

### Węzeł `[464]`
Mówca: **Remus Holstron**
> ""If it's the elections you're worried about, don't. If you sustain the emergency until that point, let's just say we'd be happy to support your campaign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 = true"*)

### Węzeł `[465]`
Mówca: **Kesaro Kibener**
> ""I've heard rumors that you already have the means to handle that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Kesaro Kibener: ""But of course, even you probably don't have absolute con..."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_SecretStatePolice == true"*)
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_SecretStatePolice == true)"*)

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_SecretStatePolice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_SecretStatePolice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Kesaro Kibener: ""I've heard rumors that you already have the means to han..."*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_SecretStatePolice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_SecretStatePolice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Remus Holstron: ""If your definition of 'problematic' aligns with ours, I ..."*)

### Węzeł `[469]`
Mówca: **Remus Holstron**
> ""If your definition of 'problematic' aligns with ours, I don't think it would be difficult to arrange something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 = true"*)

### Węzeł `[470]`
Mówca: **Kesaro Kibener**
> ""But of course, even you probably don't have absolute control over those forces. If they prove to be unreliable, the nationalist youth would be happy to help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Remus Holstron: ""Exactly.""*)

### Węzeł `[471]`
Mówca: **Remus Holstron**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Remus Holstron: ""If your definition of 'problematic' aligns with ours, I ..."*)

### Węzeł `[472]`
Mówca: **Kesaro Kibener**
> ""The Court itself isn't the main problem. It's certain individuals who hold the power to impeach you whenever necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Remus Holstron: ""And their adulterated Sollist philosophy, of course... T..."*)

### Węzeł `[473]`
Mówca: **Remus Holstron**
> ""And their adulterated Sollist philosophy, of course... This illusion of *unity* they fabricated has long poisoned our nation. It is time the true Sords take the power back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Remus Holstron: ""I believe the Sordists are done cooperating with them. I..."*)

### Węzeł `[474]`
Mówca: **Remus Holstron**
> ""I believe the Sordists are done cooperating with them. If you prove to be the strong leader you're portraying yourself as, they'd be happy to plan a move against the Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 = true"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Remus Holstron: ""Finally, you will reinstate the Energy Protection Act as..."*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Remus Holstron: ""And finally, we want you to sign the Unified Education A..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget > 0)"*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false"*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false"*)
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == false)"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Remus Holstron: ""Finally, you will make use of the remaining government b..."*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[484]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false"*)
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_IncreasedFunding == false)"*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Remus Holstron: ""Finally, you will make use of the remaining government b..."*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_IncreasedFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false"*)

### Węzeł `[487]`
Mówca: **Remus Holstron**
> ""They'll need resources to be able to rebuild again. You'll need to arrange a 'transfer' of finances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)

### Węzeł `[488]`
Mówca: **Remus Holstron**
> ""We are also aware of the investigations being conducted on both opposition parties. You will immediately stop the investigations into the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[489]`
Mówca: **Remus Holstron**
> ""You will write a decree to tighten immigration. Effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[490]`
Mówca: **Remus Holstron**
> ""And you will order the complete halt of your education reforms. There is no possible way we can accept the removal of nationalist doctrines from our curriculums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)

### Węzeł `[491]`
Mówca: **Remus Holstron**
> ""Finally, you will reinstate the Energy Protection Act as it was enacted by Tarquin Soll. We have to reverse this exploitative scheme immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Remus Holstron: ""If you can do that, you will have the nationalist moveme..."*)

### Węzeł `[492]`
Mówca: **Remus Holstron**
> ""If you can do that, you will have the nationalist movement and the Young Sords behind you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true"*)

### Węzeł `[493]`
Mówca: **Remus Holstron**
> ""Finally, you will make use of the remaining government budget and transfer emergency funds to the Ministry of Interior to strengthen the emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Remus Holstron: ""If you can do that, you will have the nationalist moveme..."*)

### Węzeł `[494]`
Mówca: **Remus Holstron**
> ""Finally, you will make use of the remaining government budget and transfer emergency funds to the Sordish Armed Forces to strengthen our defense against Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Remus Holstron: ""If you can do that, you will have the nationalist moveme..."*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false &..."*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_TightenedImmigration == false..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  (Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Kesaro Kibener: ""You made an enemy out of Sordish nationalists -- people ..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_TightenedImmigration == false && BaseGame.Turn04_PSnW_Education_Progressive == true && (BaseGame.Situation_Economy_FinancialInvestment_UC == true || BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true || BaseGame.Policy_Order_DecreasedInteriorFunding == true) == true && BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  and  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true  and  (Variable["BaseGame.Situation_Economy_FinancialInvestment_UC"] == true  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true  or  Variable["BaseGame.Policy_Order_DecreasedInteriorFunding"] == true) == true  and  Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Vetoed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Kesaro Kibener: ""You are making an enemy out of Sordish nationalists -- p..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_KesaroLighter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Kesaro Kibener: ""Please. Keep it.""*)

### Węzeł `[499]`
Mówca: **Kesaro Kibener**
> ""Please. Keep it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: "Looking more closely, I could see a large circular dent i..."*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Remus Holstron: ""You should already have an idea of what they're capable ..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[502]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `VictoryDay_AutocratOfferHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true"*)
  - -> `[599]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true"*)
  - -> `[602]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true"*)
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true"*)
  - -> `[504]` (*Player: ""I think I get the idea.""*)

### Węzeł `[503]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [VictoryDay_AutocratOfferHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Węzeł Logiki Narracyjnej: "VictoryDay_AutocratOfferHub"*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think I get the idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[450]` (Kesaro Kibener), `[456]` (Remus Holstron), `[460]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands ==..."*)

### Węzeł `[505]`
Mówca: **Remus Holstron**
> ""Good. And we have important requests from you in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands = ..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Remus Holstron: ""Good. And we have important reques..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Remus Holstron: ""Good. And we have important requests from you in return.""*)

### Węzeł `[507]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands ==..."*)
  - -> `[509]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands ..."*)

### Węzeł `[508]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "OfferComplete"*)

### Węzeł `[509]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "Jump to: [Remus Holstron: ""Good. And we have important r..."*)

### Węzeł `[510]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true"*)
  - -> `[512]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer ==..."*)

### Węzeł `[511]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Węzeł Logiki Narracyjnej: "OfferComplete"*)

### Węzeł `[512]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Player: ""You're asking too much. I don't even want to hear about ..."*)
  - -> `[513]` (*Player: ""Let's hear what the Young Sords can offer me in return n..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Let's hear what the Young Sords can offer me in return now.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[492]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Węzeł Logiki Narracyjnej: "Jump to: [Remus Holstron: ""The Young Sords can give you ..."*)

### Węzeł `[514]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Remus Holstron: ""The Young Sords can give you on-th..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Remus Holstron: ""The Young Sords can give you on-the-ground support that ..."*)

### Węzeł `[515]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `OfferComplete`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)
  - -> `[519]` (*Player: ""I think you're asking too much. I don't think we can mak..."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[517]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGa..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_NFP_Promised_LanguageBill = true;"*)

### Węzeł `[519]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I think you're asking too much. I don't think we can make a deal.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true` AND `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true`
- **Kontekst wejściowy (poprzednik):** `[504]` (Player), `[492]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Remus Holstron: ""That's a shame. A big mistake.""*)

### Węzeł `[520]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal." [-2 Government Budget]"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)` AND `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToDemands"] == true` AND `Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true`
- **Kontekst wejściowy (poprzednik):** `[504]` (Player), `[492]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 2;"*)

### Węzeł `[521]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're asking too much. I don't even want to hear about your offer.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.VictoryDay_Autocrat_ListenedToOffer"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[492]` (Remus Holstron)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Remus Holstron: ""That's a shame. A big mistake.""*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Remus Holstron: ""First and foremost, you will revoke the ban on the Young..."*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)

### Węzeł `[525]`
Mówca: **Remus Holstron**
> ""We are aware of the investigations being conducted on both opposition parties. You will immediately stop the investigation into the NFP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Opposition == true)"*)

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Remus Holstron: ""We are aware of the investigations being conducted on bo..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Remus Holstron: ""You will write a decree to tighten immigration. Effectiv..."*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[532]`
Mówca: **Remus Holstron**
> ""You will write a decree to tighten immigration. Effective immediately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[535]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[534]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Remus Holstron: ""You will order the complete halt of your education refor..."*)

### Węzeł `[535]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true || Bas..."*)

### Węzeł `[536]`
Mówca: **Remus Holstron**
> ""You will order the complete halt of your education reforms. There is no possible way we can accept the removal of nationalist doctrines from our curriculums.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Remus Holstron: ""And finally, we want you to sign the Unified Education A..."*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true || Bas..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true || Bas..."*)
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Opposition == true || B..."*)

### Węzeł `[538]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true  or  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  or  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Remus Holstron: ""And finally, we want you to sign the Unified Education A..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Opposition == true || BaseGame.Policy_Diplomacy_TightenedImmigration == false || BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true  or  Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false  or  Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Remus Holstron: ""We just want you to sign the Unified Education Act when ..."*)

### Węzeł `[540]`
Mówca: **Remus Holstron**
> ""We just want you to sign the Unified Education Act when it reaches you. We already have the support of the Assembly and it would be a step in the right direction if you do not use your veto powers on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Remus Holstron: ""If you can do that, you will have the nationalist moveme..."*)

### Węzeł `[541]`
Mówca: **Kesaro Kibener**
> ""Agreed. But the event is about to begin. Why don't we head back over to the plaza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Petr Vectern: ""About time. Let's go.""*)

### Węzeł `[542]`
Mówca: **Petr Vectern**
> ""About time. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[543]`
Mówca: **Remus Holstron**
> ""That's a shame. A big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[541]` (*Kesaro Kibener: ""Agreed. But the event is about to begin. Why don't we he..."*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)
  - -> `[546]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_SnO_Investigate_Opposition == true)"*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_SnO_Investigate_Opposition == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Węzeł Logiki Narracyjnej: "BaseGame.Stopped_Investigations_NFP = true"*)

### Węzeł `[546]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_SnO_Investigate_Opposition == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_SnO_Investigate_Opposition"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[547]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)
  - -> `[549]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration = true"*)

### Węzeł `[549]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Diplomacy_TightenedImmigration == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[550]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_Education_Progressive == true)"*)

### Węzeł `[551]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_Education_Progressive == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Welfare_EducationReform = false; BaseGame..."*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_Education_Progressive == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Progressive"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[553]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Stopped_Investigations_NFP = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Stopped_Investigations_NFP"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Diplomacy_TightenedImmigration == false"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Diplomacy_TightenedImmigration = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Diplomacy_TightenedImmigration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_Education_Progressive == true"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Welfare_EducationReform = false;
BaseGame.Policy_Welfare_TraditionalEducation = true;
BaseGame.Turn04_PSnW_Education_Progressive = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Welfare_EducationReform"] = false;
Variable["BaseGame.Policy_Welfare_TraditionalEducation"] = true;
Variable["BaseGame.Turn04_PSnW_Education_Progressive"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[556]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS = false; BaseGame.Policy_Law_Ban_YoungSords = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] = false;
Variable["BaseGame.Policy_Law_Ban_YoungSords"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)

### Węzeł `[557]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)
  - -> `[559]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == ..."*)

### Węzeł `[558]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Węzeł Logiki Narracyjnej: "BaseGame.EconomyDirection_Scale -= 4; BaseGame.Policy_Eco..."*)

### Węzeł `[559]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_NFP_Promised_LanguageBill = true;"*)

### Węzeł `[560]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget > 0"*)
  - -> `[562]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.GovernmentBudget > 0)"*)

### Węzeł `[561]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.GovernmentBudget"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false"*)

### Węzeł `[562]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.GovernmentBudget > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.GovernmentBudget"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false"*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Order_IncreasedInteriorFunding == false)"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding = true; Ba..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Order_IncreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Economy_EnergyProtectionAct_Removed == true"*)

### Węzeł `[566]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding == false"*)
  - -> `[568]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Military_IncreasedFunding == false)"*)

### Węzeł `[567]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Military_IncreasedFunding = true; BaseGam..."*)

### Węzeł `[568]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Military_IncreasedFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Military_IncreasedFunding"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Order_IncreasedInteriorFunding == false"*)

### Węzeł `[569]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_NFP_Promised_LanguageBill = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_NFP_Promised_LanguageBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[570]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Autocrat_YoungSords_NFP_Deal = true;
BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Autocrat_YoungSords_NFP_Deal"] = true;
Variable["BaseGameSupport.Journal_Turn06_VictoryDay_MadeDealWithYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_SnO_Investigate_Opposition == true"*)

### Węzeł `[571]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.EconomyDirection_Scale -= 4;
BaseGame.Policy_Economy_EnergyProtectionAct_10Percent = true;
BaseGame.Policy_Economy_EnergyProtectionAct_49Percent = false;
BaseGame.Policy_Economy_EnergyProtectionAct_Default = false;
BaseGame.Policy_Economy_EnergyProtectionAct_Removed = false;
BaseGame.Relations_Ewald_Discontent = true;
BaseGame.Relations_Ewald_Neutral = false;
BaseGame.Relations_Ewald_Friendly = false;
BaseGame.Gasom_Bankrupt = true;
BaseGame.Gasom_Default = false;
BaseGame.Gasom_Downsized = false;
BaseGame.Gasom_Booming = false;
BaseGame.Gasom_Ownership_PrivatelyOwned = true;
BaseGame.Gasom_Ownership_ForeignOwned = false;
BaseGame.Gasom_Ownership_StatePrivateCooperation = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.EconomyDirection_Scale"] = Variable["BaseGame.EconomyDirection_Scale"] - 4;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] = true;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_49Percent"] = false;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Default"] = false;
Variable["BaseGame.Policy_Economy_EnergyProtectionAct_Removed"] = false;
Variable["BaseGame.Relations_Ewald_Discontent"] = true;
Variable["BaseGame.Relations_Ewald_Neutral"] = false;
Variable["BaseGame.Relations_Ewald_Friendly"] = false;
Variable["BaseGame.Gasom_Bankrupt"] = true;
Variable["BaseGame.Gasom_Default"] = false;
Variable["BaseGame.Gasom_Downsized"] = false;
Variable["BaseGame.Gasom_Booming"] = false;
Variable["BaseGame.Gasom_Ownership_PrivatelyOwned"] = true;
Variable["BaseGame.Gasom_Ownership_ForeignOwned"] = false;
Variable["BaseGame.Gasom_Ownership_StatePrivateCooperation"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[572]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Order_IncreasedInteriorFunding = true;
BaseGame.Turn04_SnO_LE_Interior_Increased = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] = true;
Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[573]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Military_IncreasedFunding = true;
BaseGame.Turn03_EnT_Military_Budget_Increase = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Military_IncreasedFunding"] = true;
Variable["BaseGame.Turn03_EnT_Military_Budget_Increase"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[582]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[574]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true && Base..."*)
  - -> `[576]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && Ba..."*)

### Węzeł `[575]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Player: ""Fine. I agree to your demands. It's a deal." [-2 Governm..."*)

### Węzeł `[576]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true && BaseGame.GovernmentBudget > 0 && (BaseGame.Policy_Military_IncreasedFunding == false || BaseGame.Policy_Order_IncreasedInteriorFunding == false))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true  and  Variable["BaseGame.GovernmentBudget"] > 0  and  (Variable["BaseGame.Policy_Military_IncreasedFunding"] == false  or  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)

### Węzeł `[577]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS == true"*)
  - -> `[579]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)"*)

### Węzeł `[578]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Player: ""Fine. I agree to your demands. It's a deal." [-1 Governm..."*)

### Węzeł `[579]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Player: ""Fine. I agree to your demands. It's a deal.""*)

### Węzeł `[580]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal." [-1 Government Budget]"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "BaseGame.GovernmentBudget -= 1;"*)

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine. I agree to your demands. It's a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal = true; BaseGameSup..."*)

### Węzeł `[582]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Kesaro Kibener: ""That's great to hear!""*)

### Węzeł `[583]`
Mówca: **Kesaro Kibener**
> ""That's great to hear!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Remus Holstron: ""It was a pleasure, Mr. Rayne.""*)

### Węzeł `[584]`
Mówca: **Remus Holstron**
> ""It was a pleasure, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Kesaro Kibener: ""Now why don't we head back towards the plaza? The event ..."*)

### Węzeł `[585]`
Mówca: **Kesaro Kibener**
> ""Now why don't we head back towards the plaza? The event is about to start.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Petr Vectern: ""Great. Let's go.""*)

### Węzeł `[586]`
Mówca: **Petr Vectern**
> ""Great. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[587]`
Mówca: **Remus Holstron**
> ""Anyway, our presence is expected at the plaza. Shall we make our way over?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Petr Vectern: ""About damn time.""*)

### Węzeł `[588]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Nationalist == true"*)
  - -> `[590]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Nationalist == t..."*)

### Węzeł `[589]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Nationalist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Nationalist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Remus Holstron: ""Good to see you again after a long time, Mr. President a..."*)

### Węzeł `[590]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Nationalist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Nationalist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Remus Holstron: ""It's nice to finally meet you in person, Mr. President a..."*)

### Węzeł `[591]`
Mówca: **Remus Holstron**
> ""Good to see you again after a long time, Mr. President and Mr. Vice President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player: ""Likewise, Mr. Holstron.""*)
  - -> `[173]` (*Player: ""Happy Victory Day, Mr. Holstron.""*)
  - -> `[373]` (*Player_Italic: "Stay silent."*)

### Węzeł `[592]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "Jump to: [VictoryDay_AutocratOfferHub]"*)

### Węzeł `[593]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "Jump to: [VictoryDay_AutocratOfferHub]"*)

### Węzeł `[594]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "Jump to: [VictoryDay_AutocratOfferHub]"*)

### Węzeł `[595]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Węzeł Logiki Narracyjnej: "Jump to: [VictoryDay_AutocratOfferHub]"*)

### Węzeł `[596]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true"*)
  - -> `[598]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == t..."*)

### Węzeł `[597]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[598]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option1"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Player: ""How can the Young Sords help us enforce the emergency?""*)

### Węzeł `[599]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true"*)
  - -> `[601]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == t..."*)

### Węzeł `[600]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[601]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Player: ""I know the Young Sords are well-connected with the NFP. ..."*)

### Węzeł `[602]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true"*)
  - -> `[604]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == t..."*)

### Węzeł `[603]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[604]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Player: ""What if there are problematic individuals who require......"*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true"*)
  - -> `[607]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == t..."*)

### Węzeł `[606]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[607]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.VictoryDay_YoungSords_Hub_Option4"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Player: ""The Court is a problem. What can we do to protect the em..."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal = true; BaseGameSup..."*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.GovernmentBudget -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Węzeł Logiki Narracyjnej: "BaseGame.Autocrat_YoungSords_NFP_Deal = true; BaseGameSup..."*)
