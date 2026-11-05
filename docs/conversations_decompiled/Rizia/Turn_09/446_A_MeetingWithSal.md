# Rizia/Turn 9/A_MeetingWithSal

- **ID konwersacji:** `446`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Rizia/Turn_09/446_A_MeetingWithSal.md`
- **Liczba węzłów dialogowych:** 441
- **Liczba wyborów gracza:** 86

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[85]** Sevrio Castellanus
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Adarfo_AssassinationOrdered`
- `RiziaDLC.Council_GrandVizier_Hugo`
- `RiziaDLC.Council_Security_Lucita`
- `RiziaDLC.Council_Security_Titus`
- `RiziaDLC.HouseOfDelegates_Abolished`
- `RiziaDLC.Lucita_Married`
- `RiziaDLC.PipelineNatDes_DeployWG`
- `RiziaDLC.Policy_Order_GoldenGuard_Expanded`
- `RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths`
- `RiziaDLC.Policy_RD_Law_EstablishReligiousCourts`
- `RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith`
- `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation`
- `RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed`
- `RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs`
- `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied`
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Situation_Order_WruhecistCommunity_Happy`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony`
- `RiziaDLC.WruhecistSanctuariesConstructed`
- `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Situation_Order_Unrest_NationalDestabilization`
- `RiziaDLC.Theocracy_Full`
- `RiziaDLC.Theocracy_None`
- `RiziaDLC.Theocracy_Partial`
- `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy`
- `RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier`
- `RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier`
- `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony`
- `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms`
- `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice`
- `RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest`
- `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier`
- `RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed`
- `RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony`
- `RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony`
- `RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[15]` | **"Throw nearby chalice."** | `[14]` **Narrator**: "My hands clenched into fists." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowCh...`<br>`AddConversant("Sal Ignacius");` | `[25]` **Narrator**: "It was then that I noticed Sal s..." |
| `[16]` | **"Take a deep breath."** | `[14]` **Narrator**: "My hands clenched into fists." | *Brak (Dostępna bezwarunkowo)* | `AddConversant("Sal Ignacius");` | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." |
| `[17]` | **""Oh, shut up, will you?!""** | `[14]` **Narrator**: "My hands clenched into fists." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Narrator**: "My voice echoed through the gran..." |
| `[22]` | **""Forgive me, Grand Wiseman. I didn't hear you come in.""** | `[21]` **Narrator**: "I turned and faced the Grand Wis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Sal Ignacius**: ""Not a problem Your Majesty."" |
| `[23]` | **""For God's sake, don't sneak up on me like that!""** | `[21]` **Narrator**: "I turned and faced the Grand Wis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Sal Ignacius**: ""My apologies. I didn't mean to ..." |
| `[24]` | **""I wasn't referring to you, Grand Wiseman, but rather to the shouts of protests sp..."** | `[21]` **Narrator**: "I turned and faced the Grand Wis..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Sal Ignacius**: ""Ah, I see. In any case..."" |
| `[28]` | **""May God forgive me for that outburst.""** | `[27]` **Sal Ignacius**: ""I believe you dropped something."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Player_Romus_Italic**: "I took back the chalice and set ..."<br>`[32]` **Player_Romus_Italic**: "I didn't take the chalice back." |
| `[29]` | **""Ever heard of knocking?""** | `[27]` **Sal Ignacius**: ""I believe you dropped something."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Sal Ignacius**: ""Forgive me, Your Majesty. I tho..." |
| `[32]` | **"Don't take chalice."** | `[28]` **Player_Romus**: ""May God forgive me for that out..."<br>`[30]` **Sal Ignacius**: ""Forgive me, Your Majesty. I tho..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "Sal waited a moment before setti..." |
| `[34]` | **"Take chalice."** | `[28]` **Player_Romus**: ""May God forgive me for that out..."<br>`[30]` **Sal Ignacius**: ""Forgive me, Your Majesty. I tho..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Sal Ignacius**: ""I came to inform you that the c..." |
| `[37]` | **""Well, you found me.""** | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Sal Ignacius**: ""I hope I'm not interrupting. Ne..." |
| `[38]` | **""Is there something you need?""** | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[64]` **Sal Ignacius**: ""Not necessarily, Your Majesty."" |
| `[39]` | **""Congratulations. You win the prize.""** | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[65]` **Sal Ignacius**: ""Lucky me."" |
| `[50]` | **""Sorry, I lost my temper. I've got a lot on my mind.""** | `[27]` **Sal Ignacius**: ""I believe you dropped something."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Sal Ignacius**: ""No need to apologize, Your Maje..." |
| `[60]` | **""Forgive me. I didn't hear you come in.""** | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Sal Ignacius**: ""No need to apologize, Your Maje..." |
| `[61]` | **""And what do I owe the pleasure, Grand Wiseman?""** | `[36]` **Sal Ignacius**: ""There you are, Your Majesty. I ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Sal Ignacius**: ""I came to inform you that the c..." |
| `[71]` | **""You must have noticed the unrest in our kingdom. I fear Rizia is on the verge of ..."** | `[31]` **Sal Ignacius**: ""If you don't mind my asking, wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Sal Ignacius**: ""Ah, yes. It saddens me to see o..." |
| `[72]` | **""I'm troubled by the seemingly endless stream of issues plaguing our nation.""** | `[31]` **Sal Ignacius**: ""If you don't mind my asking, wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Sal Ignacius**: ""As am I, Your Majesty. It sadde..." |
| `[73]` | **""That's none of your business.""** | `[31]` **Sal Ignacius**: ""If you don't mind my asking, wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Sal Ignacius**: ""Very well. I won't press the is..." |
| `[80]` | **""I wish I shared your optimism. Just thinking about it makes my head explode.""** | `[79]` **Sal Ignacius**: ""Uncertainty breeds turmoil, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Sal Ignacius**: ""It's normal to feel overwhelmed..." |
| `[81]` | **""Every day, I hope for a peaceful resolution. However, I'm concerned that we may n..."** | `[79]` **Sal Ignacius**: ""Uncertainty breeds turmoil, but..." | `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false` | *Brak zmian stanu* | `[91]` **Sal Ignacius**: ""I share your hope for peace, bu..." |
| `[82]` | **""These agitators mistake tolerance for weakness. It's a misunderstanding I intend ..."** | `[79]` **Sal Ignacius**: ""Uncertainty breeds turmoil, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Sal Ignacius**: ""Indeed, Your Majesty. Maintaini..." |
| `[83]` | **""Every day, I offer prayers for a peaceful resolution. Yet, I cannot help but fear..."** | `[79]` **Sal Ignacius**: ""Uncertainty breeds turmoil, but..." | `Variable["RiziaDLC.Trait_ReligiousKing"] == true` | *Brak zmian stanu* | `[91]` **Sal Ignacius**: ""I share your hope for peace, bu..." |
| `[87]` | **""It just feels like we've exhausted all available resources -- that nothing I do e..."** | `[79]` **Sal Ignacius**: ""Uncertainty breeds turmoil, but..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Sal Ignacius**: ""Your Majesty, while it may seem..." |
| `[96]` | **""Remind me, how long does their training last?""** | `[335]` **Narrator**: "Next to me, Sevrio serenely surv..."<br>`[116]` **Sevrio Castellanus**: ""This experience makes them offi..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false` | *Brak zmian stanu* | `[114]` **Sevrio Castellanus**: ""Physical fitness and defense tr..." |
| `[97]` | **""Why are a select few wearing different uniforms?""** | `[335]` **Narrator**: "Next to me, Sevrio serenely surv..."<br>`[116]` **Sevrio Castellanus**: ""This experience makes them offi..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false` | *Brak zmian stanu* | `[113]` **Sevrio Castellanus**: ""Those are the elite cadets, You..." |
| `[98]` | **""Good to know. We can speak more about them some other time.""** | `[335]` **Narrator**: "Next to me, Sevrio serenely surv..."<br>`[116]` **Sevrio Castellanus**: ""This experience makes them offi..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true` | *Brak zmian stanu* | `[121]` **Sevrio Castellanus**: ""It would be my pleasure."" |
| `[99]` | **""How many are there?""** | `[335]` **Narrator**: "Next to me, Sevrio serenely surv..."<br>`[116]` **Sevrio Castellanus**: ""This experience makes them offi..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false` | *Brak zmian stanu* | `[112]` **Sevrio Castellanus**: ""There are over 2,500, Your Maje..." |
| `[131]` | **""Wruhec's Guardians have proven their dedication and capability, and are a force t..."** | `[130]` **Sevrio Castellanus**: ""Perhaps it's time for us to set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Sevrio Castellanus**: ""Yes, I believe so as well."" |
| `[136]` | **""Ensure that Wruhec's Guardians are given everything they need." [-1 Budget]"** | `[135]` **Sevrio Castellanus**: ""Disregard of divine laws is pun..."<br>`[238]` **Sevrio Castellanus**: ""Wruhec's Guardians can serve as..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Sevrio Castellanus**: ""Yes, Your Majesty. I will see t..." |
| `[137]` | **""Are you certain that deploying them to quell unrest is the right course of action?""** | `[130]` **Sevrio Castellanus**: ""Perhaps it's time for us to set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Sevrio Castellanus**: ""Your Majesty, legally speaking,..." |
| `[140]` | **""But using them for such purposes... I worry about public backlash.""** | `[139]` **Sevrio Castellanus**: ""As the appointed representative..."<br>`[145]` **Sevrio Castellanus**: ""As the earthly representative o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Sevrio Castellanus**: ""I understand your hesitation, b..." |
| `[142]` | **""We must do what is necessary to restore peace and order. See to it that Wruhec's ..."** | `[135]` **Sevrio Castellanus**: ""Disregard of divine laws is pun..."<br>`[238]` **Sevrio Castellanus**: ""Wruhec's Guardians can serve as..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Sevrio Castellanus**: ""Of course, Your Majesty. I'll e..." |
| `[143]` | **""The sword of justice. Are you advocating for violence?""** | `[130]` **Sevrio Castellanus**: ""Perhaps it's time for us to set..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Sevrio Castellanus**: ""I am advocating for the restora..." |
| `[146]` | **""Yes, but using them for such purposes... It feels like a drastic measure.""** | `[139]` **Sevrio Castellanus**: ""As the appointed representative..."<br>`[145]` **Sevrio Castellanus**: ""As the earthly representative o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Sevrio Castellanus**: ""I understand your hesitation, Y..." |
| `[148]` | **""I appreciate your perspective, Sevrio. But I'm not inclined to deploy Wruhec's Gu..."** | `[135]` **Sevrio Castellanus**: ""Disregard of divine laws is pun..."<br>`[238]` **Sevrio Castellanus**: ""Wruhec's Guardians can serve as..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Sevrio Castellanus**: ""Understood, Your Majesty. I wil..." |
| `[152]` | **""And I get that. But just because we *can* deploy them doesn't mean that we should.""** | `[139]` **Sevrio Castellanus**: ""As the appointed representative..."<br>`[145]` **Sevrio Castellanus**: ""As the earthly representative o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Sevrio Castellanus**: ""I understand your hesitation, Y..." |
| `[153]` | **""No. Deploying Wruhec's Guardians in such a manner will only worsen the problem. W..."** | `[135]` **Sevrio Castellanus**: ""Disregard of divine laws is pun..."<br>`[238]` **Sevrio Castellanus**: ""Wruhec's Guardians can serve as..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Sevrio Castellanus**: ""I fear the time for peace is ra..." |
| `[158]` | **""I don't understand. What is it that you are asking of me?""** | `[356]` **Sal Ignacius**: ""It is time, Your Majesty. Time ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[188]` **Sal Ignacius**: ""Nothing less and nothing more t..." |
| `[159]` | **""I'm on board with implementing theocratic reforms. What would you have me do?""** | `[356]` **Sal Ignacius**: ""It is time, Your Majesty. Time ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Sal Ignacius**: ""God be praised! I knew you envi..." |
| `[160]` | **""It's all the same to me. Expressing religious devotion publicly is one thing. But..."** | `[366]` **Sal Ignacius**: ""You should know better than tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Sal Ignacius**: ""It seems our goals are not as i..." |
| `[169]` | **""It would be my honor. I accept.""** | `[168]` **Sal Ignacius**: ""Unless you'd like to do it your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Narrator**: "As I made my way towards the mas..." |
| `[170]` | **""You go ahead. I wouldn't want to deprive you of your sacred duty.""** | `[168]` **Sal Ignacius**: ""Unless you'd like to do it your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "Sal made his way into the congre..." |
| `[171]` | **""No thanks. But I appreciate the offer.""** | `[168]` **Sal Ignacius**: ""Unless you'd like to do it your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Narrator**: "Sal made his way into the congre..." |
| `[172]` | **""Of course! Just give me clear instructions on what needs to be done.""** | `[168]` **Sal Ignacius**: ""Unless you'd like to do it your..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Narrator**: "As I made my way towards the mas..." |
| `[210]` | **"Say nothing and observe them."** | `[335]` **Narrator**: "Next to me, Sevrio serenely surv..."<br>`[116]` **Sevrio Castellanus**: ""This experience makes them offi..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "Once the cadets had finished tak..." |
| `[224]` | **""I cannot commit to any of this. You are asking for far too much. Sorry, Sal.""** | `[223]` **Sal Ignacius**: ""What do you say, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Sal Ignacius**: ""It seems our goals are not as i..." |
| `[225]` | **""We can meet in the middle. Petition for Grand Vizier when the current Royal Counc..."** | `[223]` **Sal Ignacius**: ""What do you say, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_Partial"] = true; Variable["...` | `[230]` **Sal Ignacius**: ""Excellent! You have no idea how..." |
| `[226]` | **""We shall. Rizia will be a holy Wruhecist kingdom, governed by messengers of God.""** | `[223]` **Sal Ignacius**: ""What do you say, Your Majesty? ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Theocracy_Full"] = true; Variable["Riz...`<br>`UpdatePlayerCountryGovernment("Theocratic Monarchy");` | `[233]` **Sal Ignacius**: ""Bless you, Your Majesty! This d..." |
| `[245]` | **""At least the two of us still have the Lord on our side.""** | `[326]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>`[330]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false` | *Brak zmian stanu* | `[249]` **Sal Ignacius**: ""The Lord and His holy messengers."" |
| `[246]` | **""I didn't realize you were paying that much attention to earthly goings-on.""** | `[326]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>`[330]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false` | *Brak zmian stanu* | `[250]` **Sal Ignacius**: ""I listen to our people, Your Ma..." |
| `[247]` | **""I trust your spiritual advice, Grand Wiseman. But when it comes to placating the ..."** | `[326]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>`[330]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>*(oraz 3 innych węzłów)* | `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`<br>`(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false` | *Brak zmian stanu* | `[248]` **Sal Ignacius**: ""As is your right. Just remember..." |
| `[251]` | **""Those who go against the Crown will bear the full brunt of my vengeance. End of s..."** | `[326]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>`[330]` **Sal Ignacius**: ""It breaks my heart that Dastnur..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[255]` **Sal Ignacius**: ""Yes, Your Majesty."" |
| `[256]` | **""I have my doubts about replacing my uncle.""** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true` | *Brak zmian stanu* | `[267]` **Sal Ignacius**: ""It's only natural to have doubt..." |
| `[260]` | **""Now that you mention it, the position has been vacant for some time.""** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false` | *Brak zmian stanu* | `[265]` **Sal Ignacius**: ""Indeed. This was predestined."" |
| `[261]` | **""I need a new Grand Vizier after my uncle's resignation. But I can't simply appoin..."** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false` | *Brak zmian stanu* | `[264]` **Sal Ignacius**: ""You still don't understand, my ..." |
| `[262]` | **""Hugo is a religious man himself. What if I were to keep him on?""** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true` | *Brak zmian stanu* | `[266]` **Sal Ignacius**: ""You may keep him as an advisor,..." |
| `[263]` | **""I am not opposed to the idea. Your advice has never steered me wrong thus far.""** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[270]` **Sal Ignacius**: ""I have only carried the word of..." |
| `[268]` | **""I'm still not convinced this entire scheme isn't a power grab on your part.""** | `[220]` **Sal Ignacius**: ""During Alignment of the Six Sta..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Sal Ignacius**: ""If I could suggest someone else..." |
| `[274]` | **""You are asking me to break centuries of Rizian royal tradition.""** | `[273]` **Sal Ignacius**: ""All of your guardsmen must shed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Sal Ignacius**: ""Decades, at most. Don't forget ..." |
| `[276]` | **""And if they don't want to?""** | `[273]` **Sal Ignacius**: ""All of your guardsmen must shed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Narrator**: "He gestured down at the cadets." |
| `[283]` | **""Yes, that makes sense. I shall be protected by a holy army.""** | `[273]` **Sal Ignacius**: ""All of your guardsmen must shed..." | `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true` | *Brak zmian stanu* | `[280]` **Sal Ignacius**: ""Just imagine the members of the..." |
| `[284]` | **""Of course he will. This is what you and he wanted from the beginning, isn't it?""** | `[273]` **Sal Ignacius**: ""All of your guardsmen must shed..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Sal Ignacius**: ""We would never discuss such top..." |
| `[292]` | **""I can't imagine a priest would know more about war and security than Duchess Azaro.""** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | `Variable["RiziaDLC.Council_Security_Lucita"] == true` | *Brak zmian stanu* | `[296]` **Narrator**: "He spoke in a mysterious tone."<br>`[298]` **Sal Ignacius**: ""The lady Azaro knows nothing of..." |
| `[302]` | **""Titus is religious. I should keep him on as security councilor.""** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | `Variable["RiziaDLC.Council_Security_Titus"] == true`<br>`(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false` | *Brak zmian stanu* | `[303]` **Sal Ignacius**: ""He is needed as Captain of the ..." |
| `[304]` | **""The military wouldn't stand for it if I removed General Taddeus from the council.""** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`<br>`(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false` | *Brak zmian stanu* | `[305]` **Sal Ignacius**: ""Perhaps General Azaro will enjo..." |
| `[306]` | **""I can't kick Elena and Laurento off the Royal Council. They've been there since I..."** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[307]` **Sal Ignacius**: ""Both Ms. Werner and Mr. Esquibe..." |
| `[308]` | **""I can't imagine the House of Delegates would be happy with that change.""** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false` | *Brak zmian stanu* | `[312]` **Sal Ignacius**: ""The Delegates' opinion is of no..." |
| `[313]` | **""Where will I find councilors with religious as well as state expertise? We can't ..."** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Sal Ignacius**: ""Don't you worry about that. The..." |
| `[315]` | **""At last. Sanctuary and state, working together as a single all-powerful apparatus.""** | `[222]` **Sal Ignacius**: ""Just as your Grand Vizier must ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Sal Ignacius**: ""As the ancient scripture foreto..." |
| `[357]` | **""I am ready, Grand Wiseman. Show me the way.""** | `[356]` **Sal Ignacius**: ""It is time, Your Majesty. Time ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Sal Ignacius**: ""With pleasure."" |
| `[362]` | **""Are you trying to turn me on? Because it's working.""** | `[356]` **Sal Ignacius**: ""It is time, Your Majesty. Time ..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[363]` **Sal Ignacius**: ""Earthly desire has no place in ..." |
| `[364]` | **""No, no... this is all too much. You're trying to turn Rizia into Derdia.""** | `[356]` **Sal Ignacius**: ""It is time, Your Majesty. Time ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Narrator**: "The tone of his voice changed ab..." |
| `[367]` | **""Tell me precisely what you have in mind.""** | `[366]` **Sal Ignacius**: ""You should know better than tha..." | *Brak (Dostępna bezwarunkowo)* | `--;` | `[219]` **Narrator**: "He gazed fondly at the cadets be..." |
| `[373]` | **""God has big plans for you. Are you ready?""** | `[369]` **Narrator**: "After the last cadet had sipped ..." | `Variable["RiziaDLC.Theocracy_Full"] == true` | *Brak zmian stanu* | `[378]` **Sevrio Castellanus**: ""Ready as I can be, Your Majesty."" |
| `[374]` | **""In the name of St. Wruhec, I do bestow upon thee this holiest of blessings.""** | `[369]` **Narrator**: "After the last cadet had sipped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Sevrio Castellanus**: ""Thank you, Your Majesty."" |
| `[375]` | **""Thirsty, are we?""** | `[369]` **Narrator**: "After the last cadet had sipped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Narrator**: "He didn't laugh." |
| `[376]` | **""I hope you're proud of these graduates. May they serve the kingdom well.""** | `[369]` **Narrator**: "After the last cadet had sipped ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[377]` **Sevrio Castellanus**: ""They will."" |
| `[401]` | **""You've handled yourselves admirably during these trying times, Sevrio. I expected..."** | `[400]` **Sevrio Castellanus**: ""To restore peace is to uphold t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Sevrio Castellanus**: ""Your confidence in us strengthe..." |
| `[402]` | **""Your devotion is commendable, but there is still much to be done. I trust the Wru..."** | `[400]` **Sevrio Castellanus**: ""To restore peace is to uphold t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Sevrio Castellanus**: ""We stand ready for whatever lie..." |
| `[403]` | **""With righteousness on our side, there is no doubt that we will prevail.""** | `[400]` **Sevrio Castellanus**: ""To restore peace is to uphold t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Sevrio Castellanus**: ""Faith and steel will carry us t..." |
| `[404]` | **""Sacred or not, peace is won through strength and vigilance.""** | `[400]` **Sevrio Castellanus**: ""To restore peace is to uphold t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[405]` **Sevrio Castellanus**: ""My men remain sharp and unwaver..." |
| `[418]` | **""Our goal? This was always your goal, Sal, not mine. I only founded the Guardians ..."** | `[417]` **Sal Ignacius**: ""Your Majesty... with the format..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[419]` **Sal Ignacius**: ""Hrm. That explains your cavalie..." |
| `[420]` | **""Someday Rizia will rise to bask in God's glory.""** | `[417]` **Sal Ignacius**: ""Your Majesty... with the format..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Sal Ignacius**: ""Someday. When it has a king who..." |
| `[422]` | **""What do you mean? Am I not the king from the prophesies?""** | `[417]` **Sal Ignacius**: ""Your Majesty... with the format..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[423]` **Sal Ignacius**: ""I once thought you might be. Bu..." |
| `[425]` | **""I would love nothing more than to spend the rest of my reign promoting the tenets..."** | `[417]` **Sal Ignacius**: ""Your Majesty... with the format..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Sal Ignacius**: ""I understand. I only entreat yo..." |

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
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Attending the graduation of their religi..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "As I stood in the Benievon Archsanctuary, I marveled at the Lake of Reflection. Its waters flowed through naturally formed channels, weaving through the sanctuary's heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The Archsanctuary had been constructed around these canal..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "As I stood in the Benievon Archsanctuary, I marveled at the Lake of Reflection. Its waters flowed through naturally formed channels, weaving through the sanctuary's heart."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Narrator: "The Archsanctuary had been built around these canals, emb..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "As I stood in the Benievon Archsanctuary, I marveled at t..."*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "As I stood in the Benievon Archsanctuary, I marveled at t..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The Archsanctuary had been constructed around these canals, incorporating their presence in its design."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, hoping for clarity amidst the echoes of protests resounding incessantly within my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Even in this oasis of calm, I could find no respite from ..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Even in this oasis of calm, I could find no respite from the turmoil that plagued my realm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "With a furrowed brow, I attempted to silence the internal clamor, but the tumult of voices only grew louder -- perhaps a trial of faith in itself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "My hands clenched into fists."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "My hands clenched into fists."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Player_Romus_Italic: "Take a deep breath."*)
  - -> `[15]` (*Player_Romus_Italic: "Throw nearby chalice."*)
  - -> `[17]` (*Player_Romus: ""Oh, shut up, will you?!""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "Throw nearby chalice."]** — Mówca: **Player_Romus_Italic**
> "In a moment of unchecked anger, I seized a nearby chalice and hurled it across the Archsanctuary."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice = true;"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "Take a deep breath."]** — Mówca: **Player_Romus_Italic**
> "I closed my eyes and took a deep breath to calm my rising frustration."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, shut up, will you?!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "My voice echoed through the grand hall, though it was onl..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "My voice echoed through the grand hall, though it was only meant for the empty air."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[19]`
Mówca: **Sal Ignacius**
> ""I didn't say anything, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "I turned and faced the Grand Wiseman, who I hadn't heard ..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Sal Ignacius: ""I didn't say anything, Your Majesty.""*)

### Węzeł `[21]`
Mówca: **Narrator**
> "I turned and faced the Grand Wiseman, who I hadn't heard enter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""I wasn't referring to you, Grand Wiseman, but rather to ..."*)
  - -> `[22]` (*Player_Romus: ""Forgive me, Grand Wiseman. I didn't hear you come in.""*)
  - -> `[23]` (*Player_Romus: ""For God's sake, don't sneak up on me like that!""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Grand Wiseman. I didn't hear you come in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Sal Ignacius: ""Not a problem Your Majesty.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For God's sake, don't sneak up on me like that!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Sal Ignacius: ""My apologies. I didn't mean to startle you.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wasn't referring to you, Grand Wiseman, but rather to the shouts of protests spreading across the kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Sal Ignacius: ""Ah, I see. In any case...""*)

### Węzeł `[25]`
Mówca: **Narrator**
> "It was then that I noticed Sal standing nearby. With a gentle grace, he retrieved the fallen chalice and approached, holding it out to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Sal Ignacius: ""I believe you dropped something.""*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "It was then that I noticed Sal standing nearby. With a ge..."*)

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> ""I believe you dropped something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Ever heard of knocking?""*)
  - -> `[28]` (*Player_Romus: ""May God forgive me for that outburst.""*)
  - -> `[50]` (*Player_Romus: ""Sorry, I lost my temper. I've got a lot on my mind.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""May God forgive me for that outburst.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus_Italic: "Take chalice."*)
  - -> `[32]` (*Player_Romus_Italic: "Don't take chalice."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ever heard of knocking?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Sal Ignacius: ""Forgive me, Your Majesty. I thought you heard me come in.""*)

### Węzeł `[30]`
Mówca: **Sal Ignacius**
> ""Forgive me, Your Majesty. I thought you heard me come in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus_Italic: "Take chalice."*)
  - -> `[32]` (*Player_Romus_Italic: "Don't take chalice."*)

### Węzeł `[31]`
Mówca: **Sal Ignacius**
> ""If you don't mind my asking, what seems to be the trouble?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player_Romus: ""I'm troubled by the seemingly endless stream of issues p..."*)
  - -> `[71]` (*Player_Romus: ""You must have noticed the unrest in our kingdom. I fear ..."*)
  - -> `[73]` (*Player_Romus: ""That's none of your business.""*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "Don't take chalice."]** — Mówca: **Player_Romus_Italic**
> "I didn't take the chalice back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Player_Romus), `[30]` (Sal Ignacius), `[51]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "Sal waited a moment before setting the chalice down on a ..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "Sal waited a moment before setting the chalice down on a nearby altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "Take chalice."]** — Mówca: **Player_Romus_Italic**
> "I took back the chalice and set it on the altar where I got it from."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Player_Romus), `[30]` (Sal Ignacius), `[51]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Sal Ignacius: ""There you are, Your Majesty. I was looking for you.""*)

### Węzeł `[36]`
Mówca: **Sal Ignacius**
> ""There you are, Your Majesty. I was looking for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[37]` (*Player_Romus: ""Well, you found me.""*)
  - -> `[60]` (*Player_Romus: ""Forgive me. I didn't hear you come in.""*)
  - -> `[61]` (*Player_Romus: ""And what do I owe the pleasure, Grand Wiseman?""*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, you found me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Sal Ignacius: ""I hope I'm not interrupting. Nevertheless...""*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you need?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Sal Ignacius: ""Not necessarily, Your Majesty.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Congratulations. You win the prize.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[36]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Sal Ignacius: ""Lucky me.""*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""Congratulations. You win the prize.""*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""Is there something you need?""*)

### Węzeł `[43]`
Mówca: **Sal Ignacius**
> ""I came to inform you that the ceremony is set to begin within the hour, so we'll need to start letting people into the Archsanctuary soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He was referring to the graduation of the latest batch of..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "He was referring to the graduation of the latest batch of Wruhec's Guardians cadets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "My newly established religious security force was headqua..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Despite the Board of Trustees' initial resistance, they eventually committed to incorporating the Guardians' doctrine into the school's standard curriculum."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Thus, the ceremony provided a convenient excuse for my visit to Benievon amidst the unrest in Porte Drazon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnr..."*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Thus, the ceremony provided a convenient excuse for my vi..."*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "I had been invited here to witness the results."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, I lost my temper. I've got a lot on my mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Sal Ignacius: ""No need to apologize, Your Majesty. I can only imagine t..."*)

### Węzeł `[51]`
Mówca: **Sal Ignacius**
> ""No need to apologize, Your Majesty. I can only imagine the pressure you're under.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus_Italic: "Take chalice."*)
  - -> `[32]` (*Player_Romus_Italic: "Don't take chalice."*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "With a furrowed brow, I attempted to silence the internal..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "With a furrowed brow, I attempted to silence the internal..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "With a furrowed brow, I attempted to silence the internal clamor, but the tumult of voices only grew louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "My hands clenched into fists."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "As I knelt at the water's edge, my gaze fixed upon the mi..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "As I knelt at the water's edge, my gaze fixed upon the mi..."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface. Its serenity stood in quiet defiance to the echoes of protests resounding incessantly within my mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Even in this oasis of calm, I could find no respite from ..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me. I didn't hear you come in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Sal Ignacius: ""No need to apologize, Your Majesty.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what do I owe the pleasure, Grand Wiseman?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[62]`
Mówca: **Sal Ignacius**
> ""No need to apologize, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[63]`
Mówca: **Sal Ignacius**
> ""I hope I'm not interrupting. Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""Not necessarily, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Sal Ignacius: ""I just wanted to inform you that the ceremony is set to ..."*)

### Węzeł `[65]`
Mówca: **Sal Ignacius**
> ""Lucky me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[66]`
Mówca: **Sal Ignacius**
> ""I just wanted to inform you that the ceremony is set to begin within the hour, so we'll need to start letting people into the Archsanctuary soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "He was referring to the graduation of the latest batch of..."*)

### Węzeł `[67]`
Mówca: **Sal Ignacius**
> ""Ah, I see. In any case...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[68]`
Mówca: **Sal Ignacius**
> ""Not a problem Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[69]`
Mówca: **Sal Ignacius**
> ""My apologies. I didn't mean to startle you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Sal Ignacius: ""I came to inform you that the ceremony is set to begin w..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "My newly established religious security force was headquartered at the nearby Benievon Academy, a prestigious institution renowned for catering to the noble and elite class of Rizia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Despite the Board of Trustees' initial resistance, they e..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You must have noticed the unrest in our kingdom. I fear Rizia is on the verge of an uprising once more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Sal Ignacius: ""Ah, yes. It saddens me to see our people losing faith in..."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm troubled by the seemingly endless stream of issues plaguing our nation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Sal Ignacius: ""As am I, Your Majesty. It saddens me that our people are..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your business.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Sal Ignacius: ""Very well. I won't press the issue.""*)

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""Very well. I won't press the issue.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion = t..."*)

### Węzeł `[75]`
Mówca: **Sal Ignacius**
> ""Ah, yes. It saddens me to see our people losing faith in their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AssassinationOrdered == true"*)

### Węzeł `[76]`
Mówca: **Sal Ignacius**
> ""As am I, Your Majesty. It saddens me that our people are losing faith in their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AssassinationOrdered == true"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "The sound of the Archsantuary doors opening drew our attention to the front entrance, where people began trickling inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Sal and I stepped away from the main aisle, allowing the ..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Sal and I stepped away from the main aisle, allowing the flow of individuals to pass without obstruction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[79]`
Mówca: **Sal Ignacius**
> ""Uncertainty breeds turmoil, but faith endures. No matter how restless the times, I believe God will guide us through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[80]` (*Player_Romus: ""I wish I shared your optimism. Just thinking about it ma..."*)
  - -> `[82]` (*Player_Romus: ""These agitators mistake tolerance for weakness. It's a m..."*)
  - -> `[87]` (*Player_Romus: ""It just feels like we've exhausted all available resourc..."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish I shared your optimism. Just thinking about it makes my head explode.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Sal Ignacius: ""It's normal to feel overwhelmed, but remember, you're ne..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every day, I hope for a peaceful resolution. However, I'm concerned that we may need to consider more assertive measures.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[79]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Sal Ignacius: ""I share your hope for peace, but I also understand your ..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""These agitators mistake tolerance for weakness. It's a misunderstanding I intend to rectify.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Sal Ignacius: ""Indeed, Your Majesty. Maintaining order and authority is..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Every day, I offer prayers for a peaceful resolution. Yet, I cannot help but fear that more assertive measures may become necessary.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[79]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Sal Ignacius: ""I share your hope for peace, but I also understand your ..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[85]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player_Romus: ""Every day, I offer prayers for a peaceful resolution. Ye..."*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""Every day, I hope for a peaceful resolution. However, I'..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It just feels like we've exhausted all available resources -- that nothing I do ever satisfies them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""Your Majesty, while it may seem that way, we mustn't los..."*)

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""Your Majesty, while it may seem that way, we mustn't lose hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Sal Ignacius: ""Even in the darkest hours, there's always a glimmer of h..."*)

### Węzeł `[89]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty. Maintaining order and authority is essential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Our attention was drawn to the majestic tones of an organ..."*)

### Węzeł `[90]`
Mówca: **Sal Ignacius**
> ""It's normal to feel overwhelmed, but remember, you're never alone. God is always with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""And for what it's worth, you have me, too.""*)

### Węzeł `[91]`
Mówca: **Sal Ignacius**
> ""I share your hope for peace, but I also understand your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Sal Ignacius: ""It's wise to remain vigilant and consider all options. E..."*)

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Even in the darkest hours, there's always a glimmer of hope that the odds, no matter how daunting they may seem, will be overcome.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Our attention was drawn to the majestic tones of an organ..."*)

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""And for what it's worth, you have me, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Our attention was drawn to the majestic tones of an organ..."*)

### Węzeł `[94]`
Mówca: **Narrator**
> "Our attention was drawn to the majestic tones of an organ that resonated throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "Captains Sevrio Castellanus and Titus Gordion walked in, ..."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Cadet_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == ..."*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms ==..."*)
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining ==..."*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == ..."*)
  - -> `[210]` (*Player_Romus_Italic: "Say nothing and observe them."*)

### Węzeł `[96]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me, how long does their training last?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false`
- **Kontekst wejściowy (poprzednik):** `[335]` (Narrator), `[116]` (Sevrio Castellanus), `[209]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Sevrio Castellanus: ""Physical fitness and defense training lasts for 10 weeks..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why are a select few wearing different uniforms?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false`
- **Kontekst wejściowy (poprzednik):** `[335]` (Narrator), `[116]` (Sevrio Castellanus), `[209]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Sevrio Castellanus: ""Those are the elite cadets, Your Majesty, known as 'The ..."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to know. We can speak more about them some other time.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true`
- **Kontekst wejściowy (poprzednik):** `[335]` (Narrator), `[116]` (Sevrio Castellanus), `[209]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Sevrio Castellanus: ""It would be my pleasure.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How many are there?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false`
- **Kontekst wejściowy (poprzednik):** `[335]` (Narrator), `[116]` (Sevrio Castellanus), `[209]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Sevrio Castellanus: ""There are over 2,500, Your Majesty -- a mere fraction of..."*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining ==..."*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining ..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Player_Romus: ""Remind me, how long does their training last?""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms ==..."*)
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms ..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Player_Romus: ""Why are a select few wearing different uniforms?""*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == ..."*)
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany =..."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""How many are there?""*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == ..."*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany =..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player_Romus: ""Good to know. We can speak more about them some other ti..."*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining == true || RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] == true  or  Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[112]`
Mówca: **Sevrio Castellanus**
> ""There are over 2,500, Your Majesty -- a mere fraction of the cadets enrolled across Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Sevrio Castellanus: ""This represents the third graduating class of the Beniev..."*)

### Węzeł `[113]`
Mówca: **Sevrio Castellanus**
> ""Those are the elite cadets, Your Majesty, known as 'The Devout.' They are the most dedicated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Sevrio Castellanus: ""Each one has endured a rigorous spiritual experience of ..."*)

### Węzeł `[114]`
Mówca: **Sevrio Castellanus**
> ""Physical fitness and defense training lasts for 10 weeks, followed by an additional 6 weeks of spiritual training, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining = ..."*)

### Węzeł `[115]`
Mówca: **Sevrio Castellanus**
> ""Each one has endured a rigorous spiritual experience of seven days and nights, staring into the Lake of Reflection without food or water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Sevrio Castellanus: ""This experience makes them officers and leaders among th..."*)

### Węzeł `[116]`
Mówca: **Sevrio Castellanus**
> ""This experience makes them officers and leaders among their peers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms = ..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsUniforms"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansD..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansD..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsTraining"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansD..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Cadet_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Cadet_Hub"*)

### Węzeł `[121]`
Mówca: **Sevrio Castellanus**
> ""It would be my pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Once the cadets had finished taking their respective seat..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "Once the cadets had finished taking their respective seats, the Wiseman of Benievon stepped into the pulpit and began his commencement address."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)

### Węzeł `[123]`
Mówca: **Sevrio Castellanus**
> ""If I may speak freely... given the civil upheaval we're seeing, I feel there is a solution that's not being used to its full potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "He gestured subtly to the cadets in front of us."*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLC.PipelineNatDes_DeployWG"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Narrator: "Sevrio leaned in and spoke in a hushed tone."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLC.PipelineNatDes_DeployWG == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLC.PipelineNatDes_DeployWG"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true;"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "He gestured subtly to the cadets in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Sevrio Castellanus: ""Wruhec's Guardians. As you know, we've been tasked with ..."*)

### Węzeł `[128]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians. As you know, we've been tasked with faith-based humanitarian work--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Sevrio Castellanus: ""Repairing protester-damaged infrastructure, providing ai..."*)

### Węzeł `[129]`
Mówca: **Sevrio Castellanus**
> ""But we could be doing more. Much more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Sevrio Castellanus: ""Perhaps it's time for us to set aside the plowshares and..."*)

### Węzeł `[130]`
Mówca: **Sevrio Castellanus**
> ""Perhaps it's time for us to set aside the plowshares and to wield the sword of justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Player_Romus: ""The sword of justice. Are you advocating for violence?""*)
  - -> `[137]` (*Player_Romus: ""Are you certain that deploying them to quell unrest is t..."*)
  - -> `[131]` (*Player_Romus: ""Wruhec's Guardians have proven their dedication and capa..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wruhec's Guardians have proven their dedication and capability, and are a force to be reckoned with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Sevrio Castellanus: ""Yes, I believe so as well.""*)

### Węzeł `[132]`
Mówca: **Sevrio Castellanus**
> ""Yes, I believe so as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sevrio Castellanus: ""Legally speaking, you have the authority to deploy Wruhe..."*)

### Węzeł `[133]`
Mówca: **Sevrio Castellanus**
> ""Legally speaking, you have the authority to deploy Wruhec's Guardians to maintain order and uphold God's divine law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Sevrio Castellanus: ""As you are God's representative on earth, earthly laws a..."*)

### Węzeł `[134]`
Mówca: **Sevrio Castellanus**
> ""As you are God's representative on earth, earthly laws are no different from godly laws, and vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Sevrio Castellanus: ""Disregard of divine laws is punishable on earth as it is..."*)

### Węzeł `[135]`
Mówca: **Sevrio Castellanus**
> ""Disregard of divine laws is punishable on earth as it is in the eyes of the Almighty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: ""Ensure that Wruhec's Guardians are given everything they need." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""Ensure that Wruhec's Guardians are given everything they need.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Sevrio Castellanus), `[238]` (Sevrio Castellanus), `[239]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Sevrio Castellanus: ""Yes, Your Majesty. I will see to it that the Wruhec's Gu..."*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you certain that deploying them to quell unrest is the right course of action?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Sevrio Castellanus: ""Your Majesty, legally speaking, Captain Gordion and I ha..."*)

### Węzeł `[138]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, legally speaking, Captain Gordion and I have the authority to deploy Wruhec's Guardians to maintain order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Sevrio Castellanus: ""As the appointed representative of God on earth, you hav..."*)

### Węzeł `[139]`
Mówca: **Sevrio Castellanus**
> ""As the appointed representative of God on earth, you have the power to enforce divine laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""And I get that. But just because we *can* deploy them do..."*)
  - -> `[146]` (*Player_Romus: ""Yes, but using them for such purposes... It feels like a..."*)
  - -> `[140]` (*Player_Romus: ""But using them for such purposes... I worry about public..."*)

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But using them for such purposes... I worry about public backlash.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Sevrio Castellanus), `[145]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Sevrio Castellanus: ""I understand your hesitation, but in times of crisis, we..."*)

### Węzeł `[141]`
Mówca: **Sevrio Castellanus**
> ""I understand your hesitation, but in times of crisis, we must be prepared to take necessary measures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Sevrio Castellanus: ""Wruhec's Guardians can serve as a strong deterrent again..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We must do what is necessary to restore peace and order. See to it that Wruhec's Guardians are prepared for their new duties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Sevrio Castellanus), `[238]` (Sevrio Castellanus), `[239]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Sevrio Castellanus: ""Of course, Your Majesty. I'll ensure the Wruhec's Guardi..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The sword of justice. Are you advocating for violence?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[130]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Sevrio Castellanus: ""I am advocating for the restoration of order, so that ou..."*)

### Węzeł `[144]`
Mówca: **Sevrio Castellanus**
> ""I am advocating for the restoration of order, so that our kingdom may continue on the path that has been ordained for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Sevrio Castellanus: ""As the earthly representative of God, you have the legal..."*)

### Węzeł `[145]`
Mówca: **Sevrio Castellanus**
> ""As the earthly representative of God, you have the legal means to authorize the Guardians to use as much force as necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""And I get that. But just because we *can* deploy them do..."*)
  - -> `[146]` (*Player_Romus: ""Yes, but using them for such purposes... It feels like a..."*)
  - -> `[140]` (*Player_Romus: ""But using them for such purposes... I worry about public..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, but using them for such purposes... It feels like a drastic measure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Sevrio Castellanus), `[145]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Sevrio Castellanus: ""I understand your hesitation, Your Majesty. But the situ..."*)

### Węzeł `[147]`
Mówca: **Sevrio Castellanus**
> ""I understand your hesitation, Your Majesty. But the situation seems dire to me, and we must consider all available options.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Sevrio Castellanus: ""We can help maintain stability and prevent further escal..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate your perspective, Sevrio. But I'm not inclined to deploy Wruhec's Guardians in this manner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Sevrio Castellanus), `[238]` (Sevrio Castellanus), `[239]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Sevrio Castellanus: ""Understood, Your Majesty. I will ensure that our cadets ..."*)

### Węzeł `[149]`
Mówca: **Sevrio Castellanus**
> ""Understood, Your Majesty. I will ensure that our cadets persist in their current endeavors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = false;"*)

### Węzeł `[150]`
Mówca: **Sevrio Castellanus**
> ""Of course, Your Majesty. I'll ensure the Wruhec's Guardians are prepared to fulfill their new responsibilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = true; R..."*)

### Węzeł `[151]`
Mówca: **Sevrio Castellanus**
> ""Yes, Your Majesty. I will see to it that the Wruhec's Guardians are fully prepared to uphold justice and restore order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = true; R..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I get that. But just because we *can* deploy them doesn't mean that we should.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Sevrio Castellanus), `[145]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Sevrio Castellanus: ""I understand your hesitation, Your Majesty. But the situ..."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Deploying Wruhec's Guardians in such a manner will only worsen the problem. We need peaceful solutions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Sevrio Castellanus), `[238]` (Sevrio Castellanus), `[239]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Sevrio Castellanus: ""I fear the time for peace is rapidly coming to an end.""*)

### Węzeł `[154]`
Mówca: **Sevrio Castellanus**
> ""I fear the time for peace is rapidly coming to an end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = false;"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = true; RiziaDLC.Theocracy_Partial = true;
RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians = true;
RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] = true;
Variable["RiziaDLC.Theocracy_Partial"] = true;
Variable["RiziaDLCSupport.News_Turn09_RH_GuardiansDeployed"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DeployWruhecsGuardians"] = true;
Variable["RiziaDLCSupport.Reports_Turn09_PorteDrazon_GuardiansDeployed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "With another blast from the organ, the Wiseman finished h..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_ReligionMeeting_GuardiansDeploy"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "With another blast from the organ, the Wiseman finished h..."*)

### Węzeł `[157]`
Mówca: **Sal Ignacius**
> ""Your Majesty... with the formation of the Guardians, we came one step closer to bringing God's will to Rizia. But now I must humbly beg you to take a leap of faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "He lowered his voice to an intense whisper."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand. What is it that you are asking of me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Sal Ignacius: ""Nothing less and nothing more than the complete integrat..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm on board with implementing theocratic reforms. What would you have me do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Sal Ignacius: ""God be praised! I knew you envisioned this kingdom's fut..."*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's all the same to me. Expressing religious devotion publicly is one thing. But I won't put Wruhecism front and center in government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Sal Ignacius: ""It seems our goals are not as in aligned as I thought. I..."*)

### Węzeł `[161]`
Mówca: **Sal Ignacius**
> ""God be praised! I knew you envisioned this kingdom's future as I do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[162]`
Mówca: **Narrator**
> "As if ordained from heaven, the organ, once again, came to life. Everyone stood and began singing a hymn, their voices reverberating throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Sal Ignacius: ""Please excuse me, Your Majesty. I must now attend to my ..."*)

### Węzeł `[163]`
Mówca: **Sal Ignacius**
> ""Please excuse me, Your Majesty. I must now attend to my duties at the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Sal Ignacius: ""I'm to distribute the holy water to the new recruits, th..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "Sal made his way into the congregation, and I observed the procession. Each cadet approached Sal, who reverently collected the holy water from the sacred pool into a chalice from which to drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCere..."*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == false)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Sal made his way into the congregation, and I observed th..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Sal Ignacius: ""Unless you'd like to do it yourself, given your divine a..."*)

### Węzeł `[168]`
Mówca: **Sal Ignacius**
> ""Unless you'd like to do it yourself, given your divine appointment as Rizia's spiritual leader.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player_Romus: ""It would be my honor. I accept.""*)
  - -> `[170]` (*Player_Romus: ""You go ahead. I wouldn't want to deprive you of your sac..."*)
  - -> `[171]` (*Player_Romus: ""No thanks. But I appreciate the offer.""*)
  - -> `[172]` (*Player_Romus: ""Of course! Just give me clear instructions on what needs..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be my honor. I accept.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "As I made my way towards the mass of recruits, Sal briefe..."*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You go ahead. I wouldn't want to deprive you of your sacred duty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Sal made his way into the congregation, and I observed th..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No thanks. But I appreciate the offer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "Sal made his way into the congregation, and I observed th..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course! Just give me clear instructions on what needs to be done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "As I made my way towards the mass of recruits, Sal briefe..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Each cadet took their turn to partake in this sacred ritual, a symbol of their commitment and dedication to their faith and kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Narrator: "After the last cadet had sipped the water, Sevrio quietly..."*)

### Węzeł `[174]`
Mówca: **Narrator**
> "He drank, bathed in the kaleidoscopic light from the stained-glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "The sanctuary choir broke into a jubilant-sounding hymnal..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "As I made my way towards the mass of recruits, Sal briefed me on what to do before I joined him in distributing the holy water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony = true;"*)

### Węzeł `[177]`
Mówca: **Narrator**
> "As each individual approached one by one, they did so with reverence, bowing as they neared."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Meanwhile, I carefully scooped up the holy water from the..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true"*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice ==..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "The one I recently threw across the room. Nevertheless..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Every cadet approached to partake in this sacred ritual, ..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "The one I recently threw across the room. Nevertheless..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "Every cadet approached to partake in this sacred ritual, ..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "Every cadet approached to partake in this sacred ritual, symbolizing their commitment and dedication to both their faith and their kingdom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "After the last cadet had sipped the water, Sevrio quietly..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice ==..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "The one I recently threw across the room. Nevertheless..."*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Each cadet took their turn to partake in this sacred ritu..."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "The one I recently threw across the room. Nevertheless..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Each cadet took their turn to partake in this sacred ritu..."*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[188]`
Mówca: **Sal Ignacius**
> ""Nothing less and nothing more than the complete integration of Wruhecism into the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[189]`
Mówca: **Sal Ignacius**
> ""It seems our goals are not as in aligned as I thought. If that's the case, I have nothing more to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NoTheocracy_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "NoTheocracy_Hub"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `NoTheocracy_Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_None = true;"*)

### Węzeł `[192]`
Mówca: **Narrator**
> "The Grand Wiseman bowed politely before leaving my side as I continued to watch the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "One motivational speech and several songs later, I observ..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "One motivational speech and several songs later, I observed the procession."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Each cadet approached Sal, who reverently collected the h..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_None = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_None"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "The Grand Wiseman bowed politely before leaving my side a..."*)

### Węzeł `[195]`
Mówca: **Narrator**
> "The Archsanctuary had been built around these canals, embracing their presence in its design."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[196]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, hoping to find spiritual clarity as legend said it would provide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "It was then I saw another familiar face in the water's re..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Narrator: "As I knelt at the water's edge, my gaze fixed upon the mi..."*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "As I knelt at the water's edge, my gaze fixed upon the mi..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "As I knelt at the water's edge, my gaze fixed upon the mirrored surface, and I observed an old man I hardly recognized."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "It was then I saw another familiar face in the water's re..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "It was then I saw another familiar face in the water's reflection. Grand Wiseman Sal Ignacius."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[202]`
Mówca: **Narrator**
> "I had been invited here to witness the results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Sal Ignacius: ""Uncertainty breeds turmoil, but faith endures. No matter..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_Unrest_NationalDestabilization == true && RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] == true  and  Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: "Before long, the majestic tones of an organ resonated thr..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> "Before long, the majestic tones of an organ resonated throughout the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "Captains Sevrio Castellanus and Titus Gordion walked in, ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.ReligionMeeting_SkipUnrestDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[208]`
Mówca: **Sevrio Castellanus**
> ""This represents the third graduating class of the Benievon Academy, the most prestigious among them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Sevrio Castellanus: ""If my memory serves me correctly, your uncle is an alumn..."*)

### Węzeł `[209]`
Mówca: **Sevrio Castellanus**
> ""If my memory serves me correctly, your uncle is an alumnus of the Academy. The old version of it, I mean.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_CadetsHowMany = t..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: "Say nothing and observe them."]** — Mówca: **Player_Romus_Italic**
> "I stayed silent as the cadets kept filing in."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[335]` (Narrator), `[116]` (Sevrio Castellanus), `[209]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "Once the cadets had finished taking their respective seat..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true"*)
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true )"*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCere..."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony =..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "As each individual approached one by one, they did so wit..."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_RH_SalMeet_ObservedCeremony"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn09_SalMeet_RH_ParticipatedInCeremony"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "He gazed fondly at the cadets before us."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "He gazed fondly at the cadets before us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Sal Ignacius: ""During Alignment of the Six Stars, I mentioned my willin..."*)

### Węzeł `[220]`
Mówca: **Sal Ignacius**
> ""During Alignment of the Six Stars, I mentioned my willingness to advise you in a closer capacity. Are you ready to place a Grand Wiseman into the role of Grand Vizier?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Player_Romus: ""I am not opposed to the idea. Your advice has never stee..."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[268]` (*Player_Romus: ""I'm still not convinced this entire scheme isn't a power..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "He gazed reverently at Titus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Sal Ignacius: ""In my eyes, it has never been fitting for the King of Ri..."*)

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""Just as your Grand Vizier must be a man of God, so must all your advisors be versed in Wruhecist principles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[306]` (*Player_Romus: ""I can't kick Elena and Laurento off the Royal Council. T..."*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[313]` (*Player_Romus: ""Where will I find councilors with religious as well as s..."*)
  - -> `[315]` (*Player_Romus: ""At last. Sanctuary and state, working together as a sing..."*)

### Węzeł `[223]`
Mówca: **Sal Ignacius**
> ""What do you say, Your Majesty? Shall we walk this path together, as in the stories of old?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""We shall. Rizia will be a holy Wruhecist kingdom, govern..."*)
  - -> `[225]` (*Player_Romus: ""We can meet in the middle. Petition for Grand Vizier whe..."*)
  - -> `[224]` (*Player_Romus: ""I cannot commit to any of this. You are asking for far t..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I cannot commit to any of this. You are asking for far too much. Sorry, Sal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Sal Ignacius: ""It seems our goals are not as in aligned as I thought. I..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We can meet in the middle. Petition for Grand Vizier when the current Royal Council term ends, and I give you my word I will consider you for the position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Partial = true; RiziaDLC.Turn09_Religi..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We shall. Rizia will be a holy Wruhecist kingdom, governed by messengers of God.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full = true; RiziaDLC.Turn09_ReligionM..."*)

### Węzeł `[227]`
Mówca: **Sal Ignacius**
> ""It seems our goals are not as in aligned as I thought. If that's the case, and there's no changing your mind otherwise, I will speak of this no more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [NoTheocracy_Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "NoTheocracy_Hub"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Partial = true; RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_Partial"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_PromisedGrandVizier"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_PromiseSalGrandVizier"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Sal Ignacius: ""Excellent! You have no idea how much this means for me, ..."*)

### Węzeł `[230]`
Mówca: **Sal Ignacius**
> ""Excellent! You have no idea how much this means for me, and for Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Sal Ignacius: ""When that time comes, I know you will choose wisely.""*)

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""I shall begin the preparations for our transformation immediately. Rizia is blessed to have you as our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "As if ordained from heaven, the organ, once again, came t..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full = true; RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards = true; 
RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier = true; RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier = true; RiziaDLC.Situation_Order_Unrest_NationalDestabilization = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Theocracy_Full"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_ReplaceGoldenGuards"] = true;
Variable["RiziaDLC.Turn09_ReligionMeeting_Sal_AppointGrandVizier"] = true;
Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_AppointSalGrandVizier"] = true;
Variable["RiziaDLC.Situation_Order_Unrest_NationalDestabilization"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "UpdatePlayerCountryGovernment("Theocratic Monarchy");"*)

### Węzeł `[233]`
Mówca: **Sal Ignacius**
> ""Bless you, Your Majesty! This decision heralds a new era for our kingdom, one where divine guidance illuminates our path forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Sal Ignacius: ""I shall begin the preparations for our transformation im..."*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn09_ReligionMeeting_DiscussUnrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Sal Ignacius: ""If you don't mind my asking, what seems to be the trouble?""*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_ReligionMeeting_WruhecsGuardiansDiscussion"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "Jump to: [Cadet_Hub]"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UpdatePlayerCountryGovernment("Theocratic Monarchy");`
- **Efekt skryptowy (`userScript`):** `UpdatePlayerCountryGovernment("Theocratic Monarchy");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Sal Ignacius: ""Bless you, Your Majesty! This decision heralds a new era..."*)

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""It's wise to remain vigilant and consider all options. Even the less peaceful ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "Our attention was drawn to the majestic tones of an organ..."*)

### Węzeł `[238]`
Mówca: **Sevrio Castellanus**
> ""Wruhec's Guardians can serve as a strong deterrent against further violence and unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[239]`
Mówca: **Sevrio Castellanus**
> ""We can help maintain stability and prevent further escalation of violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""As Grand Vizier, I can provide invaluable guidance on both state and soul, guaranteeing the prosperity of our realm in worldly matters and in matters of the spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Sal Ignacius: ""Next. there is the matter of your so-called Golden Guard.""*)

### Węzeł `[241]`
Mówca: **Sal Ignacius**
> ""I'm to distribute the holy water to the new recruits, the final step to becoming a Wruhec's Guardian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == false"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Each cadet approached Sal, who reverently collected the holy water from the sacred pool into a chalice from which to drink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true"*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Meanwhile, I carefully scooped up the holy water from the sacred pool into a chalice."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn09_ReligionMeeting_ThrowChalice == true"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[245]` (*Player_Romus: ""At least the two of us still have the Lord on our side.""*)
  - -> `[246]` (*Player_Romus: ""I didn't realize you were paying that much attention to ..."*)
  - -> `[247]` (*Player_Romus: ""I trust your spiritual advice, Grand Wiseman. But when i..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At least the two of us still have the Lord on our side.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[326]` (Sal Ignacius), `[330]` (Sal Ignacius), `[334]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Sal Ignacius: ""The Lord and His holy messengers.""*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't realize you were paying that much attention to earthly goings-on.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[326]` (Sal Ignacius), `[330]` (Sal Ignacius), `[334]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Sal Ignacius: ""I listen to our people, Your Majesty. When they have gri..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust your spiritual advice, Grand Wiseman. But when it comes to placating the populace, I'd rather consult with my council.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false` AND `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[326]` (Sal Ignacius), `[330]` (Sal Ignacius), `[334]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Sal Ignacius: ""As is your right. Just remember that heaven and earth ar..."*)

### Węzeł `[248]`
Mówca: **Sal Ignacius**
> ""As is your right. Just remember that heaven and earth are more closely linked than they appear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[249]`
Mówca: **Sal Ignacius**
> ""The Lord and His holy messengers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[250]`
Mówca: **Sal Ignacius**
> ""I listen to our people, Your Majesty. When they have grievances, it is the Sanctuary whom they turn to first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those who go against the Crown will bear the full brunt of my vengeance. End of story.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[326]` (Sal Ignacius), `[330]` (Sal Ignacius), `[334]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Sal Ignacius: ""Yes, Your Majesty.""*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Those who go against the Crown will bear the full brunt ..."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "The sound of the Archsantuary doors opening drew our atte..."*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my doubts about replacing my uncle.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Sal Ignacius: ""It's only natural to have doubts. But listen to what you..."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_GrandVizier_Hugo == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_GrandVizier_Hugo == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_GrandVizier_Hugo == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""Hugo is a religious man himself. What if I were to keep ..."*)
  - -> `[256]` (*Player_Romus: ""I have my doubts about replacing my uncle.""*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_GrandVizier_Hugo == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: ""Now that you mention it, the position has been vacant fo..."*)
  - -> `[261]` (*Player_Romus: ""I need a new Grand Vizier after my uncle's resignation. ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now that you mention it, the position has been vacant for some time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Sal Ignacius: ""Indeed. This was predestined.""*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I need a new Grand Vizier after my uncle's resignation. But I can't simply appoint you without considering other candidates. There are rules that have to be followed.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Sal Ignacius: ""You still don't understand, my king. The only rules that..."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hugo is a religious man himself. What if I were to keep him on?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_GrandVizier_Hugo"] == true`
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Sal Ignacius: ""You may keep him as an advisor, of course. But for our h..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to the idea. Your advice has never steered me wrong thus far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Sal Ignacius: ""I have only carried the word of God to your ears, Your M..."*)

### Węzeł `[264]`
Mówca: **Sal Ignacius**
> ""You still don't understand, my king. The only rules that matter are God's.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[265]`
Mówca: **Sal Ignacius**
> ""Indeed. This was predestined.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[266]`
Mówca: **Sal Ignacius**
> ""You may keep him as an advisor, of course. But for our holy kingdom to succeed, the Grand Vizier position must be filled by a holy servant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[267]`
Mówca: **Sal Ignacius**
> ""It's only natural to have doubts. But listen to what your heart tells you. What the visions have prophesized.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still not convinced this entire scheme isn't a power grab on your part.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[220]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Sal Ignacius: ""If I could suggest someone else, I would. But I have spe..."*)

### Węzeł `[269]`
Mówca: **Sal Ignacius**
> ""If I could suggest someone else, I would. But I have spent my life as a conduit between the Crown and the heavens. I can think of no one else more qualified.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[270]`
Mówca: **Sal Ignacius**
> ""I have only carried the word of God to your ears, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""As Grand Vizier, I can provide invaluable guidance on bo..."*)

### Węzeł `[271]`
Mówca: **Sal Ignacius**
> ""Next. there is the matter of your so-called Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "He gazed reverently at Titus."*)

### Węzeł `[272]`
Mówca: **Sal Ignacius**
> ""In my eyes, it has never been fitting for the King of Rizia to surround himself with such an obvious symbol of material wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""All of your guardsmen must shed their golden trappings a..."*)

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""All of your guardsmen must shed their golden trappings and become Wruhec's Guardians. I know Captain Gordion will agree with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player_Romus: ""You are asking me to break centuries of Rizian royal tra..."*)
  - -> `[284]` (*Player_Romus: ""Of course he will. This is what you and he wanted from t..."*)
  - -> `[276]` (*Player_Romus: ""And if they don't want to?""*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are asking me to break centuries of Rizian royal tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Sal Ignacius: ""Decades, at most. Don't forget that your grandmother did..."*)

### Węzeł `[275]`
Mówca: **Sal Ignacius**
> ""Decades, at most. Don't forget that your grandmother did away with the Golden Guard entirely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if they don't want to?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Narrator: "He gestured down at the cadets."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Order_GoldenGuard_Expanded == true"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Order_GoldenGuard_Expanded == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Player_Romus: ""Yes, that makes sense. I shall be protected by a holy ar..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Order_GoldenGuard_Expanded == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[280]`
Mówca: **Sal Ignacius**
> ""Just imagine the members of the expanded Golden Guard working as one with Sevrio and our cadets here. It will be beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[281]`
Mówca: **Narrator**
> "He gestured down at the cadets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Sal Ignacius: ""I am sure replacements can be arranged.""*)

### Węzeł `[282]`
Mówca: **Sal Ignacius**
> ""I am sure replacements can be arranged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, that makes sense. I shall be protected by a holy army.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Order_GoldenGuard_Expanded"] == true`
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Sal Ignacius: ""Just imagine the members of the expanded Golden Guard wo..."*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course he will. This is what you and he wanted from the beginning, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Sal Ignacius: ""We would never discuss such topics behind your back.""*)

### Węzeł `[285]`
Mówca: **Sal Ignacius**
> ""We would never discuss such topics behind your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Sal Ignacius: ""But Captain Gordion's reverence for the Divine is obviou..."*)

### Węzeł `[286]`
Mówca: **Sal Ignacius**
> ""But Captain Gordion's reverence for the Divine is obvious. With the Golden Guard fully subsumed into Wruhec's Guardians, his leadership will be one of our most powerful tools.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)

### Węzeł `[287]`
Mówca: **Narrator**
> "He lowered his voice even further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Sal Ignacius: ""Finally, Your Majesty... we will need to restructure the..."*)

### Węzeł `[288]`
Mówca: **Sal Ignacius**
> ""Finally, Your Majesty... we will need to restructure the Royal Council under the guidance of the clergy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Sal Ignacius: ""Just as your Grand Vizier must be a man of God, so must ..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Lucita == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Lucita == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Lucita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""I can't imagine a priest would know more about war and s..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Lucita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't imagine a priest would know more about war and security than Duchess Azaro.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Lucita"] == true`
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Lucita_Married == true"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Lucita_Married == true)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Lucita_Married == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Lucita_Married"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "He spoke in a mysterious tone."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Lucita_Married == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Lucita_Married"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Sal Ignacius: ""The lady Azaro knows nothing of God, Your Majesty. I hav..."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "He spoke in a mysterious tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Sal Ignacius: ""The lady Azaro has a different role to play, Your Majest..."*)

### Węzeł `[297]`
Mówca: **Sal Ignacius**
> ""The lady Azaro has a different role to play, Your Majesty. A far more important one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[298]`
Mówca: **Sal Ignacius**
> ""The lady Azaro knows nothing of God, Your Majesty. I have seen it in her eyes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Council_Security_Titus == true"*)
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Council_Security_Titus == true)"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Council_Security_Titus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Council_Security_Titus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player_Romus: ""Titus is religious. I should keep him on as security cou..."*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Council_Security_Titus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Player_Romus: ""The military wouldn't stand for it if I removed General ..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus is religious. I should keep him on as security councilor.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Council_Security_Titus"] == true` AND `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Sal Ignacius: ""He is needed as Captain of the Wruhec's Guardians, Your ..."*)

### Węzeł `[303]`
Mówca: **Sal Ignacius**
> ""He is needed as Captain of the Wruhec's Guardians, Your Majesty. The Council will be a distraction from that role.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[304]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The military wouldn't stand for it if I removed General Taddeus from the council.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Council_Security_Titus"] == true) == false` AND `(Variable["RiziaDLC.Council_Security_Lucita"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Sal Ignacius: ""Perhaps General Azaro will enjoy the chance to lead the ..."*)

### Węzeł `[305]`
Mówca: **Sal Ignacius**
> ""Perhaps General Azaro will enjoy the chance to lead the military from his home province, without his council role to distract him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[306]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't kick Elena and Laurento off the Royal Council. They've been there since I was a child.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Sal Ignacius: ""Both Ms. Werner and Mr. Esquibel have led honorable live..."*)

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Both Ms. Werner and Mr. Esquibel have led honorable lives in service to the crown. They have earned a happy retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't imagine the House of Delegates would be happy with that change.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Sal Ignacius: ""The Delegates' opinion is of no consequence. It never was.""*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == false"*)
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == false)"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""I can't imagine the House of Delegates would be happy wi..."*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[312]`
Mówca: **Sal Ignacius**
> ""The Delegates' opinion is of no consequence. It never was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[313]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where will I find councilors with religious as well as state expertise? We can't reach Golconda if we tank the economy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Sal Ignacius: ""Don't you worry about that. The Lord will guide us forwa..."*)

### Węzeł `[314]`
Mówca: **Sal Ignacius**
> ""Don't you worry about that. The Lord will guide us forward.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[315]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""At last. Sanctuary and state, working together as a single all-powerful apparatus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[222]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Sal Ignacius: ""As the ancient scripture foretold.""*)

### Węzeł `[316]`
Mówca: **Sal Ignacius**
> ""As the ancient scripture foretold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Sal Ignacius: ""What do you say, Your Majesty? Shall we walk this path t..."*)

### Węzeł `[317]`
Mówca: **Sal Ignacius**
> ""When that time comes, I know you will choose wisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "As if ordained from heaven, the organ, once again, came t..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AssassinationOrdered == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Adarfo_AssassinationOrdered == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Adarfo_AssassinationOrdered == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Adarfo_AssassinationOrdered == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Sal Ignacius: ""Their late leader has become a false saint. They're usin..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Adarfo_AssassinationOrdered == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Adarfo_AssassinationOrdered"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Sal Ignacius: ""Their leader is a false idol. His followers blindly wors..."*)

### Węzeł `[321]`
Mówca: **Sal Ignacius**
> ""Their late leader has become a false saint. They're using his martyrdom as an excuse to wreak havoc.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[322]`
Mówca: **Sal Ignacius**
> ""Their leader is a false idol. His followers blindly worship him, though he is leading them nowhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied..."*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfi..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_DastnuristCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)

### Węzeł `[326]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Dastnurists and Golcondists are marching with the revolutionaries. They have abandoned their Nurist values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Sal Ignacius: ""It breaks my heart that Dastnurists and Golcondists are ..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Sal Ignacius: ""It breaks my heart that Dastnurists are marching with th..."*)

### Węzeł `[330]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Dastnurists are marching with the revolutionaries. They have abandoned their Nurist values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfi..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Sal Ignacius: ""It breaks my heart that Golcondists are marching with th..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_GolcondistCommunity_Dissatisfied"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[334]`
Mówca: **Sal Ignacius**
> ""It breaks my heart that Golcondists are marching with the revolutionaries. Proof at last that they were never true Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[335]`
Mówca: **Narrator**
> "Next to me, Sevrio serenely surveyed his army."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "Cadet_Hub"*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""No. Deploying Wruhec's Guardians in such a manner will o..."*)
  - -> `[142]` (*Player_Romus: ""We must do what is necessary to restore peace and order...."*)
  - -> `[148]` (*Player_Romus: ""I appreciate your perspective, Sevrio. But I'm not incli..."*)
  - -> `[136]` (*Player_Romus: ""Ensure that Wruhec's Guardians are given everything they..."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "He lowered his voice to an intense whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Sal Ignacius: ""A long time ago, I had a vision of Rizia's future. I bel..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheo..."*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTh..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Sal Ignacius: ""The university you sanctioned has created a new generati..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheology_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.WruhecistSanctuariesConstructed > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.WruhecistSanctuariesConstructed > 2"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.WruhecistSanctuariesConstructed > 2)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.WruhecistSanctuariesConstructed > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.WruhecistSanctuariesConstructed"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Sal Ignacius: ""With the sanctuaries you've built, the doctrine of Wruhe..."*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.WruhecistSanctuariesConstructed > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.WruhecistSanctuariesConstructed"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true"*)

### Węzeł `[344]`
Mówca: **Sal Ignacius**
> ""With the sanctuaries you've built, the doctrine of Wruhecism has reached into every corner of our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true"*)

### Węzeł `[345]`
Mówca: **Sal Ignacius**
> ""The university you sanctioned has created a new generation of learned men and women who will go forth and spread His will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)

### Węzeł `[346]`
Mówca: **Sal Ignacius**
> ""A long time ago, I had a vision of Rizia's future. I believe it is finally about to come to life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || Ri..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ==..."*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation ..."*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Sal Ignacius: ""Our precious children are now being blessed with the wis..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_EnforcedWruhecistEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true"*)

### Węzeł `[350]`
Mówca: **Sal Ignacius**
> ""Our precious children are now being blessed with the wisdom of St. Wruhec before they even learn the alphabet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true"*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == ..."*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Sal Ignacius: ""With your government's encouragement, Wruhecist religiou..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Religion_TaxCutsForReligiousOrgs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "A shiver ran through him."*)

### Węzeł `[354]`
Mówca: **Sal Ignacius**
> ""With your government's encouragement, Wruhecist religious organizations are growing and flourishing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "A shiver ran through him."*)

### Węzeł `[355]`
Mówca: **Narrator**
> "A shiver ran through him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Sal Ignacius: ""It is time, Your Majesty. Time for the old structures to..."*)

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> ""It is time, Your Majesty. Time for the old structures to crumble, and for the great golden pillar of Golconda to rise from the ruins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player_Romus: ""I don't understand. What is it that you are asking of me?""*)
  - -> `[357]` (*Player_Romus: ""I am ready, Grand Wiseman. Show me the way.""*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[159]` (*Player_Romus: ""I'm on board with implementing theocratic reforms. What ..."*)
  - -> `[364]` (*Player_Romus: ""No, no... this is all too much. You're trying to turn Ri..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am ready, Grand Wiseman. Show me the way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Sal Ignacius: ""With pleasure.""*)

### Węzeł `[358]`
Mówca: **Sal Ignacius**
> ""With pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player_Romus: ""Are you trying to turn me on? Because it's working.""*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[362]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to turn me on? Because it's working.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[356]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Sal Ignacius: ""Earthly desire has no place in this. I am speaking of th..."*)

### Węzeł `[363]`
Mówca: **Sal Ignacius**
> ""Earthly desire has no place in this. I am speaking of the full integration of Wruhecism into the Rizian government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, no... this is all too much. You're trying to turn Rizia into Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Narrator: "The tone of his voice changed abruptly."*)

### Węzeł `[365]`
Mówca: **Narrator**
> "The tone of his voice changed abruptly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Sal Ignacius: ""You should know better than that, Your Majesty. Derdia's..."*)

### Węzeł `[366]`
Mówca: **Sal Ignacius**
> ""You should know better than that, Your Majesty. Derdia's theocracy relies on keeping followers in the dark. Ours will shine God's light upon all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Player_Romus: ""Tell me precisely what you have in mind.""*)
  - -> `[160]` (*Player_Romus: ""It's all the same to me. Expressing religious devotion p..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me precisely what you have in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[368]`
Mówca: **Narrator**
> "After the last cadet had sipped the water, Sevrio quietly approached Sal as well. The wiscerer whispered a benediction and gently raised the chalice to my guardsman's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: "He drank, bathed in the kaleidoscopic light from the stai..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "After the last cadet had sipped the water, Sevrio quietly approached me as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[376]` (*Player_Romus: ""I hope you're proud of these graduates. May they serve t..."*)
  - -> `[374]` (*Player_Romus: ""In the name of St. Wruhec, I do bestow upon thee this ho..."*)
  - -> `[375]` (*Player_Romus: ""Thirsty, are we?""*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Player_Romus: ""God has big plans for you. Are you ready?""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[373]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""God has big plans for you. Are you ready?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Sevrio Castellanus: ""Ready as I can be, Your Majesty.""*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In the name of St. Wruhec, I do bestow upon thee this holiest of blessings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Sevrio Castellanus: ""Thank you, Your Majesty.""*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thirsty, are we?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "He didn't laugh."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope you're proud of these graduates. May they serve the kingdom well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Sevrio Castellanus: ""They will.""*)

### Węzeł `[377]`
Mówca: **Sevrio Castellanus**
> ""They will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "I raised the chalice to my guardsman's lips."*)

### Węzeł `[378]`
Mówca: **Sevrio Castellanus**
> ""Ready as I can be, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "I raised the chalice to my guardsman's lips."*)

### Węzeł `[379]`
Mówca: **Sevrio Castellanus**
> ""Thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "I raised the chalice to my guardsman's lips."*)

### Węzeł `[380]`
Mówca: **Narrator**
> "He didn't laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "I raised the chalice to my guardsman's lips."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "I raised the chalice to my guardsman's lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Narrator: "He drank, bathed in the kaleidoscopic light from the sanc..."*)

### Węzeł `[382]`
Mówca: **Narrator**
> "He drank, bathed in the kaleidoscopic light from the sanctuary's stained-glass windows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "The sanctuary choir broke into a jubilant-sounding hymnal..."*)

### Węzeł `[383]`
Mówca: **Narrator**
> "Captains Sevrio Castellanus and Titus Gordion walked in, their heads held high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sevrio Castellanus"); AddConversant("Titus..."*)

### Węzeł `[384]`
Mówca: **Narrator**
> "They took their places on either side of Sal and myself as a continuous line of Wruhec's Guardian cadets began marching down the aisle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "Next to me, Sevrio serenely surveyed his army."*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sevrio Castellanus");
AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sevrio Castellanus");
AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "They took their places on either side of Sal and myself a..."*)

### Węzeł `[386]`
Mówca: **Narrator**
> "With another blast from the organ, the Wiseman finished his address. Sevrio stepped forward and began affixing star-shaped pins to each individual cadet's collar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Narrator: "As the ceremony continued, Sal turned to me once more."*)

### Węzeł `[387]`
Mówca: **Narrator**
> "Sevrio leaned in and spoke in a hushed tone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Sevrio Castellanus: ""If I may speak freely... given the civil upheaval we're ..."*)

### Węzeł `[388]`
Mówca: **Narrator**
> "As the ceremony continued, Sal turned to me once more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true"*)

### Węzeł `[389]`
Mówca: **Narrator**
> "I had never felt so alive, so full of purpose. The time had come."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Theocracy_Full == true)"*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Theocracy_Full == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Theocracy_Full"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Narrator: "I had never felt so alive, so full of purpose. The time h..."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Theocracy_Full == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Theocracy_Full"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Narrator: "I felt full of pride -- in the Guardians, and in myself f..."*)

### Węzeł `[393]`
Mówca: **Narrator**
> "I felt full of pride -- in the Guardians, and in myself for sending them out into the world."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn09_SalMeet_ParticipatedInCeremony == true"*)

### Węzeł `[394]`
Mówca: **Narrator**
> "Sevrio leaned closer, lowering his voice to a whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Sevrio Castellanus: ""Your Majesty, if I may speak freely -- I wanted to say h..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PipelineNatDes_DeployWG == true;"*)
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PipelineNatDes_DeployWG == true;)"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PipelineNatDes_DeployWG == true;`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "Sevrio leaned closer, lowering his voice to a whisper."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PipelineNatDes_DeployWG == true;)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PipelineNatDes_DeployWG"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[398]`
Mówca: **Sevrio Castellanus**
> ""Your Majesty, if I may speak freely -- I wanted to say how honored I am by the trust you've placed in the Wruhec’s Guardians to quell the civil unrest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Sevrio Castellanus: ""My men are steadfast in their duty, not just to the real..."*)

### Węzeł `[399]`
Mówca: **Sevrio Castellanus**
> ""My men are steadfast in their duty, not just to the realm, but to the divine order itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Sevrio Castellanus: ""To restore peace is to uphold the will of God.""*)

### Węzeł `[400]`
Mówca: **Sevrio Castellanus**
> ""To restore peace is to uphold the will of God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Player_Romus: ""You've handled yourselves admirably during these trying ..."*)
  - -> `[403]` (*Player_Romus: ""With righteousness on our side, there is no doubt that w..."*)
  - -> `[402]` (*Player_Romus: ""Your devotion is commendable, but there is still much to..."*)
  - -> `[404]` (*Player_Romus: ""Sacred or not, peace is won through strength and vigilan..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You've handled yourselves admirably during these trying times, Sevrio. I expected nothing less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Sevrio Castellanus: ""Your confidence in us strengthens our resolve.""*)

### Węzeł `[402]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your devotion is commendable, but there is still much to be done. I trust the Wruhec's Guardians will see this through to the very end.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Sevrio Castellanus: ""We stand ready for whatever lies ahead.""*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""With righteousness on our side, there is no doubt that we will prevail.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Sevrio Castellanus: ""Faith and steel will carry us to victory.""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sacred or not, peace is won through strength and vigilance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[400]` (Sevrio Castellanus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Sevrio Castellanus: ""My men remain sharp and unwavering in their duty -- we w..."*)

### Węzeł `[405]`
Mówca: **Sevrio Castellanus**
> ""My men remain sharp and unwavering in their duty -- we will not fail the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[406]`
Mówca: **Sevrio Castellanus**
> ""We stand ready for whatever lies ahead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[407]`
Mówca: **Sevrio Castellanus**
> ""Faith and steel will carry us to victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[408]`
Mówca: **Sevrio Castellanus**
> ""Your confidence in us strengthens our resolve.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "With another blast from the organ, the Wiseman finished h..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || Ri..."*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || ..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith"] == true  or  Variable["RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Sal Ignacius: ""Your prohibition of heretic faiths has cleared the way f..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith == true || RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_WruhecismAsSoleFaith"] == true  or  Variable["RiziaDLC.Policy_RD_Law_BanOnNonNurityFaiths"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.WruhecistSanctuariesConstructed > 2"*)

### Węzeł `[413]`
Mówca: **Sal Ignacius**
> ""Your prohibition of heretic faiths has cleared the way for ours to flower.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.WruhecistSanctuariesConstructed > 2"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true"*)
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true)"*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Happy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Sal Ignacius: ""Your Majesty... with the formation of the Guardians, we ..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Order_WruhecistCommunity_Happy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Order_WruhecistCommunity_Happy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Sal Ignacius: ""Your Majesty... with the formation of the Guardians, we ..."*)

### Węzeł `[417]`
Mówca: **Sal Ignacius**
> ""Your Majesty... with the formation of the Guardians, we came one step closer to bringing God's will to Rizia. But I am afraid our goal of establishing a holy kingdom is still far out of reach.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Player_Romus: ""Our goal? This was always your goal, Sal, not mine. I on..."*)
  - -> `[420]` (*Player_Romus: ""Someday Rizia will rise to bask in God's glory.""*)
  - -> `[422]` (*Player_Romus: ""What do you mean? Am I not the king from the prophesies?""*)
  - -> `[425]` (*Player_Romus: ""I would love nothing more than to spend the rest of my r..."*)

### Węzeł `[418]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Our goal? This was always your goal, Sal, not mine. I only founded the Guardians to keep the peace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Sal Ignacius: ""Hrm. That explains your cavalier treatment of the Wruhec..."*)

### Węzeł `[419]`
Mówca: **Sal Ignacius**
> ""Hrm. That explains your cavalier treatment of the Wruhecist community since then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Someday Rizia will rise to bask in God's glory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Sal Ignacius: ""Someday. When it has a king who prioritizes the Wruhecis..."*)

### Węzeł `[421]`
Mówca: **Sal Ignacius**
> ""Someday. When it has a king who prioritizes the Wruhecist congregation's needs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean? Am I not the king from the prophesies?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Sal Ignacius: ""I once thought you might be. But then, I thought the sam..."*)

### Węzeł `[423]`
Mówca: **Sal Ignacius**
> ""I once thought you might be. But then, I thought the same of your father...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Sal Ignacius: ""I'm not a young man, Your Majesty. Prophecies are as har..."*)

### Węzeł `[424]`
Mówca: **Sal Ignacius**
> ""I'm not a young man, Your Majesty. Prophecies are as hard for me to read as newsprint.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would love nothing more than to spend the rest of my reign promoting the tenets of Wruhecism. But alas, it's just not realistic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[417]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Sal Ignacius: ""I understand. I only entreat you not to take your faithf..."*)

### Węzeł `[426]`
Mówca: **Sal Ignacius**
> ""I understand. I only entreat you not to take your faithful followers for granted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "Jump to: [NoTheocracy_Hub]"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseOfDelegates_Abolished == true"*)
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseOfDelegates_Abolished == true)"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseOfDelegates_Abolished == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "He lowered his voice even further."*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseOfDelegates_Abolished == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseOfDelegates_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Sal Ignacius: ""As for the House of Delegates... I see no reason to alte..."*)

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""As for the House of Delegates... I see no reason to alter its function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Sal Ignacius: ""Having a direct conduit to the people will be useful. So..."*)

### Węzeł `[431]`
Mówca: **Sal Ignacius**
> ""Having a direct conduit to the people will be useful. So long as we ensure the representatives are faithful Wruhecists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Narrator: "He lowered his voice even further."*)

### Węzeł `[432]`
Mówca: **Sal Ignacius**
> ""But as for the Royal Council... it will need to be restructured under the guidance of the clergy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Sal Ignacius: ""Just as your Grand Vizier must be a man of God, so must ..."*)

### Węzeł `[433]`
Mówca: **Narrator**
> "He lowered his voice even further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Sal Ignacius: ""But as for the Royal Council... it will need to be restr..."*)

### Węzeł `[434]`
Mówca: **Narrator**
> "The sanctuary choir broke into a jubilant-sounding hymnal, praising all who carry out the sacred duties of Nur."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Theocracy_Full == true"*)

### Węzeł `[435]`
Mówca: **Sevrio Castellanus**
> ""Repairing protester-damaged infrastructure, providing aid to displaced families, to name a few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Sevrio Castellanus: ""But we could be doing more. Much more.""*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true"*)
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true)"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Law_EstablishReligiousCourts"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Sal Ignacius: ""Thanks to the establishment of religious courts, divine ..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Law_EstablishReligiousCourts == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Law_EstablishReligiousCourts"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheo..."*)

### Węzeł `[439]`
Mówca: **Sal Ignacius**
> ""Thanks to the establishment of religious courts, divine judgment now walks beside the law of the land.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Religion_SouthMerkopanUniversityOfTheo..."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Attending the graduation of their religious militia", "Benievon Archsanctuary", "Kingdom of Rizia");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Attending the graduation of their religious militia","Benievon Archsanctuary","Kingdom of Rizia");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Order_Unrest_NationalDestabilization =..."*)
