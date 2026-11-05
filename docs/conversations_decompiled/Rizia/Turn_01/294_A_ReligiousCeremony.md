# Rizia/Turn 1/A_ReligiousCeremony

- **ID konwersacji:** `294`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Rizia/Turn_01/294_A_ReligiousCeremony.md`
- **Liczba węzłów dialogowych:** 1006
- **Liczba wyborów gracza:** 292

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[81]** Titus Gordion
- **[87]** Sal Ignacius
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_DistantAsDad`
- `RiziaDLC.Prologue_FalloutWithDad`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Resources_Budget`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating`
- `RiziaDLCIsolated.SanctuaryQHub_Budget`
- `RiziaDLCIsolated.SanctuaryQHub_Dastnurists`
- `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues`
- `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers`
- `RiziaDLCIsolated.Turn01_EyesOpen`
- `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved`
- `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Country_DastnuristOpinion`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_BrokeTradition`
- `RiziaDLC.PersonalValue_FunnyKing`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Relations_Titus`
- `RiziaDLC.Resources_Authority`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn01_Religion_DivusZaitu`
- `RiziaDLC.Turn01_ReligiousBrief_YourBest`
- `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating`
- `RiziaDLCIsolated.SanctuaryQHub_Budget`
- `RiziaDLCIsolated.SanctuaryQHub_Dastnurists`
- `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues`
- `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body00`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom`
- `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers`
- `RiziaDLCIsolated.Turn01_EyesOpen`
- `RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway`
- `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved`
- `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita`
- `RiziaDLCSupport.Journal_Turn01_Ceremony_Participated`
- `RiziaDLCSupport.Journal_Turn01_Ceremony_Refused`
- `RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony`
- `RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""Good. I’ve been looking forward to this for quite some time.""** | `[7]` **Titus Gordion**: ""We shall be arriving shortly, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I was here for the Consecration ..." |
| `[9]` | **""Let’s get this over with.""** | `[7]` **Titus Gordion**: ""We shall be arriving shortly, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I was here for the Consecration ..." |
| `[10]` | **""This should be interesting.""** | `[7]` **Titus Gordion**: ""We shall be arriving shortly, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I was here for the Consecration ..." |
| `[17]` | **""Grand Wiseman Ignacius... looking as stoic as ever.""** | `[310]` **Narrator**: "Security guards held back a crow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Titus Gordion**: ""Indeed. He is a great man."" |
| `[18]` | **""Look at the old geezer. Hard to believe he's still breathing.""** | `[310]` **Narrator**: "Security guards held back a crow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[312]` **Titus Gordion**: ""I think he's an inspiration."" |
| `[19]` | **""Here we go.""** | `[310]` **Narrator**: "Security guards held back a crow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[313]` **Titus Gordion**: ""Good luck, sir."" |
| `[24]` | **""It is I who is honored to be here.""** | `[23]` **Sal Ignacius**: ""I look forward to serving you j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Sal Ignacius**: ""You are too kind."" |
| `[25]` | **""I shall honor this day with the dignity and respect this sacred tradition deserves.""** | `[23]` **Sal Ignacius**: ""I look forward to serving you j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Sal Ignacius**: "“It fills my heart with joy to h..." |
| `[26]` | **""I could think of better ways to spend my day. But when duty calls, one must oblige.""** | `[23]` **Sal Ignacius**: ""I look forward to serving you j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Sal Ignacius**: ""Well, in any case, I'm glad you..." |
| `[29]` | **"“Thank you, Grand Wiseman. I aspire to fulfill God's will here on earth, just as y..."** | `[28]` **Sal Ignacius**: ""I shall do my best to provide y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Sal Ignacius**: ""I have no doubt."" |
| `[30]` | **"“Time is short, Grand Wiseman. Let us skip the pleasantries.""** | `[28]` **Sal Ignacius**: ""I shall do my best to provide y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Sal Ignacius**: ""As you wish."" |
| `[31]` | **""And I am privileged to receive your guidance.”"** | `[28]` **Sal Ignacius**: ""I shall do my best to provide y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Sal Ignacius**: ""I'm merely a humble servant, Yo..." |
| `[32]` | **""Your best? Only the weak whine about doing their best.""** | `[28]` **Sal Ignacius**: ""I shall do my best to provide y..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_ReligiousBrief_YourBest"] = true;` | `[240]` **Sal Ignacius**: ""Don't let my physical frailty f..." |
| `[38]` | **"Stand your ground."** | `[801]` **Narrator**: "Amidst the commotion, one manage..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway"] ...` | `[40]` **Narrator**: "Titus, without missing a beat, c..." |
| `[39]` | **"Hurry towards the archsanctuary."** | `[801]` **Narrator**: "Amidst the commotion, one manage..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[502]` **Narrator**: "Partway up the stairs, I heard T..." |
| `[41]` | **""What's so blasphemous about Golcondism?""** | `[668]` **Sal Ignacius**: ""But the more Derdians came to R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[671]` **Sal Ignacius**: ""The Golcondists have a martial ..." |
| `[42]` | **"“And so you banned them. Rightly so, I might add.""** | `[668]` **Sal Ignacius**: ""But the more Derdians came to R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[670]` **Sal Ignacius**: ""I did so with a heavy heart. Bu..." |
| `[43]` | **"“Could we not have built Golcondist sanctuaries to pacify them?”"** | `[668]` **Sal Ignacius**: ""But the more Derdians came to R..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[669]` **Sal Ignacius**: ""They aim to trace the footsteps..." |
| `[48]` | **"“Lead the way.”"** | `[47]` **Sal Ignacius**: "“Shall we proceed?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "We continued towards the archsan..." |
| `[49]` | **"“Yes. The sooner we get this over with, the better.”"** | `[47]` **Sal Ignacius**: "“Shall we proceed?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "We continued towards the archsan..." |
| `[50]` | **"“How could I say no?""** | `[47]` **Sal Ignacius**: "“Shall we proceed?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "We continued towards the archsan..." |
| `[51]` | **""Just point me in the right direction.""** | `[47]` **Sal Ignacius**: "“Shall we proceed?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[431]` **Narrator**: "We continued towards the archsan..." |
| `[56]` | **"“This place never fails to impress.”"** | `[54]` **Narrator**: "I was surrounded by ornate wall ..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[341]` **Sal Ignacius**: ""Indeed it does. I've been here ..." |
| `[57]` | **"“I remember the archsanctuary being a lot bigger.”"** | `[54]` **Narrator**: "I was surrounded by ornate wall ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[340]` **Sal Ignacius**: ""That's because you used to be a..." |
| `[58]` | **"“One could get lost in a place like this.”"** | `[54]` **Narrator**: "I was surrounded by ornate wall ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[339]` **Sal Ignacius**: ""I have. More than once."" |
| `[59]` | **"“All spectacle. No sustenance.”"** | `[54]` **Narrator**: "I was surrounded by ornate wall ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[60]` **Sal Ignacius**: ""Some might say that spiritual s..." |
| `[62]` | **"“I’m not here for a history lesson. Let’s get down to business.”"** | `[61]` **Sal Ignacius**: ""Caelus the Devout. Singlehanded..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Sal Ignacius**: ""If you insist."" |
| `[63]` | **""As a great admirer of his, I've always aspired to lead a life of devotion and vir..."** | `[61]` **Sal Ignacius**: ""Caelus the Devout. Singlehanded..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[66]` **Sal Ignacius**: ""It warms my heart to hear it."" |
| `[65]` | **"“Yes, yes. I know all about him. But he’s not the reason why I’m here.”"** | `[61]` **Sal Ignacius**: ""Caelus the Devout. Singlehanded..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Sal Ignacius**: ""Without him, we Rizians would b..." |
| `[69]` | **""As long as you are Grand Wiseman, I'm sure those values will persevere.""** | `[717]` **Sal Ignacius**: ""I would never counsel this coun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[718]` **Sal Ignacius**: ""That's very kind, Your Majesty."" |
| `[70]` | **""The Dastnurists are particularly concerning. Their religion disregards the centur..."** | `[717]` **Sal Ignacius**: ""I would never counsel this coun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Sal Ignacius**: ""Indeed, Your Majesty."" |
| `[71]` | **""The Golcondists pose a particularly large threat, using Wruhecism as a cover for ..."** | `[717]` **Sal Ignacius**: ""I would never counsel this coun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Sal Ignacius**: ""That is of course worrying, You..." |
| `[72]` | **""I wouldn't call it 'diluted.' Supporting a plurality of religions will only enric..."** | `[717]` **Sal Ignacius**: ""I would never counsel this coun..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Sal Ignacius**: ""But we must not lose sight of o..." |
| `[75]` | **"“Why is it the government's responsibility to fund sanctuaries? Couldn't Rizia's r..."** | `[886]` **Sal Ignacius**: ""Afraid of angering one religiou..."<br>`[888]` **Sal Ignacius**: ""Focusing on the restoration of ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false` | `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenue...` | `[726]` **Sal Ignacius**: ""The Crown has funded and nurtur..." |
| `[76]` | **""Why didn't he just fund both projects?""** | `[886]` **Sal Ignacius**: ""Afraid of angering one religiou..."<br>`[888]` **Sal Ignacius**: ""Focusing on the restoration of ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false` | `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;` | `[348]` **Sal Ignacius**: ""I agree, Your Majesty, but King..." |
| `[77]` | **""We will begin the restoration of Plavo at once." [-2 Budget]"** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | *Brak zmian stanu* | `[411]` **Narrator**: "The Grand Wiseman clapped his ha..." |
| `[78]` | **""Both projects are equally important in my eyes. I will speak to Elena about fundi..."** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | `Variable["RiziaDLC.Resources_Budget"] >= 4` | *Brak zmian stanu* | `[83]` **Narrator**: "The holy man let out a small gasp." |
| `[79]` | **""Serving the Dastnurist community should take priority at this time. I will grant ..."** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | *Brak zmian stanu* | `[81]` **Narrator**: "The Grand Wiseman nodded solemnly." |
| `[91]` | **"“I had no idea this was down here.”"** | `[307]` **Sal Ignacius**: ""Welcome to the catacombs."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Sal Ignacius**: ""Most don’t."" |
| `[98]` | **"“Is that who I think it is?""** | `[97]` **Narrator**: "They were arranged around a marb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Sal Ignacius**: ""Indeed, Your Majesty. This is t..." |
| `[104]` | **"“I am ready.”"** | `[103]` **Sal Ignacius**: "“Let us begin. Please remove you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Following the Grand Wiseman's in..." |
| `[105]` | **""Whatever you say.""** | `[103]` **Sal Ignacius**: "“Let us begin. Please remove you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Following the Grand Wiseman's in..." |
| `[106]` | **"“Actually... I'm beginning to have second thoughts.""** | `[103]` **Sal Ignacius**: "“Let us begin. Please remove you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Sal Ignacius**: ""'Second thoughts?' But you have..." |
| `[112]` | **"“Miracle? Did I hear you correctly?”"** | `[111]` **Sal Ignacius**: ""But what most don’t know is tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Sal Ignacius**: "“Yes. The miracle of foresight."" |
| `[113]` | **"“I’ve never heard of disciples performing miracles before.”"** | `[111]` **Sal Ignacius**: ""But what most don’t know is tha..." | `(Variable["RiziaDLC.Prologue_Religious"] == true) == false` | *Brak zmian stanu* | `[116]` **Sal Ignacius**: "“Yes. The miracle of foresight."" |
| `[114]` | **"“I have gone along with you thus far. But are you really saying something supernat..."** | `[111]` **Sal Ignacius**: ""But what most don’t know is tha..." | `(Variable["RiziaDLC.Prologue_Religious"] == true) == false` | *Brak zmian stanu* | `[116]` **Sal Ignacius**: "“Yes. The miracle of foresight."" |
| `[115]` | **"“Even as a religious man, I have trouble believing in miracles.""** | `[111]` **Sal Ignacius**: ""But what most don’t know is tha..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[852]` **Sal Ignacius**: "“I refer to the miracle of fores..." |
| `[118]` | **""What can I expect to see?""** | `[119]` **Narrator**: "He poured the wine into the chal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Sal Ignacius**: ""You will see nothing. Only the ..." |
| `[127]` | **"Close your eyes."** | `[162]` **Narrator**: "He closed his eyes and began tak..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "We stood there in silence for wh..." |
| `[128]` | **"Leave eyes open."** | `[162]` **Narrator**: "He closed his eyes and began tak..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] = true;` | `[124]` **Narrator**: "We stood there in silence for wh..." |
| `[129]` | **"Look around you."** | `[162]` **Narrator**: "He closed his eyes and began tak..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] = true;` | `[124]` **Narrator**: "We stood there in silence for wh..." |
| `[130]` | **"Take his hands."** | `[123]` **Narrator**: "Setting it back down on the tray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Sal Ignacius**: ""Listen closely to my words. For..." |
| `[131]` | **"Step back."** | `[123]` **Narrator**: "Setting it back down on the tray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Player_Romus**: ""What are you doing?""<br>`[568]` **Player_Romus**: ""Kindly keep your distance.""<br>*(oraz 1 innych odgałęzień)* |
| `[132]` | **"Retract your hands."** | `[123]` **Narrator**: "Setting it back down on the tray..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Player_Romus**: ""What are you doing?""<br>`[565]` **Player_Romus**: ""Why do you need my hands?""<br>*(oraz 2 innych odgałęzień)* |
| `[134]` | **""Very well, then.""** | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[563]` **Narrator**: "Wary as I was, I relented and di..." |
| `[135]` | **""Nobody told me there would be prophecies. I cannot govern with the burden of futu..."** | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[818]` **Sal Ignacius**: ""Interrupting the ritual will ha..." |
| `[136]` | **""And *I* must insist you remember who you're speaking to!""** | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "My outburst left the wiseman spe..." |
| `[141]` | **""That's none of your concern. We're leaving.""** | `[140]` **Titus Gordion**: ""Your Majesty, is everything alr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[146]` **Narrator**: "Before long, my motorcade was ba..."<br>`[147]` **Narrator**: "By the time I'd made it back to ..." |
| `[142]` | **""Yes. We just have to go.""** | `[140]` **Titus Gordion**: ""Your Majesty, is everything alr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Before long, my motorcade was ba..." |
| `[143]` | **"Ignore him."** | `[140]` **Titus Gordion**: ""Your Majesty, is everything alr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[146]` **Narrator**: "Before long, my motorcade was ba..."<br>`[147]` **Narrator**: "By the time I'd made it back to ..." |
| `[144]` | **""Get out of my way, Captain. Do you want to be demoted to private?""** | `[140]` **Titus Gordion**: ""Your Majesty, is everything alr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[146]` **Narrator**: "Before long, my motorcade was ba..."<br>`[147]` **Narrator**: "By the time I'd made it back to ..." |
| `[153]` | **""I should be the one asking you.""** | `[152]` **Sal Ignacius**: ""Are you alright, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Sal Ignacius**: ""Oh, I may have some years on me..." |
| `[154]` | **""That's none of your concern.""** | `[152]` **Sal Ignacius**: ""Are you alright, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Sal Ignacius**: ""Very well, then."" |
| `[155]` | **""As best as one can be, given the situation.""** | `[152]` **Sal Ignacius**: ""Are you alright, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Sal Ignacius**: ""I hope I'm not overstepping my ..." |
| `[156]` | **""I'm fine. Thank you.""** | `[152]` **Sal Ignacius**: ""Are you alright, Your Majesty?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Sal Ignacius**: ""Can't say the same for myself. ..." |
| `[161]` | **""I'll be the judge of that.""** | `[240]` **Sal Ignacius**: ""Don't let my physical frailty f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[337]` **Sal Ignacius**: ""As the Lord's representative on..." |
| `[164]` | **""I know this may seem highly unorthodox, but this whole secret ceremony just doesn..."** | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Narrator**: "Sal looked apoplectic." |
| `[165]` | **""I must break with the archaic customs of my predecessors if I am to be the ruler ..."** | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Narrator**: "Sal looked apoplectic." |
| `[170]` | **""What does this diatribe have anything to do with my taking part in the ceremony?""** | `[168]` **Sal Ignacius**: ""It represents stability and ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Sal Ignacius**: ""Everything."" |
| `[171]` | **""I'm well aware of what the crown represents. Please get to the point.""** | `[168]` **Sal Ignacius**: ""It represents stability and ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Sal Ignacius**: ""My point is that you not only e..." |
| `[172]` | **""Yes, and I am grateful for the responsibility bestowed upon me.""** | `[168]` **Sal Ignacius**: ""It represents stability and ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Sal Ignacius**: ""And I, for one, am grateful for..." |
| `[173]` | **"Stay silent and listen."** | `[168]` **Sal Ignacius**: ""It represents stability and ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Sal Ignacius**: ""What I'm trying to say is..."" |
| `[179]` | **""By that logic, a challenge to your King is a challenge to the Almighty.""** | `[178]` **Sal Ignacius**: ""For to reject the sacrament is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "The wiscerer went silent. Though..." |
| `[180]` | **""You're right. Please forgive me. The crown's weight is heavy, and only with God's..."** | `[178]` **Sal Ignacius**: ""For to reject the sacrament is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[646]` **Sal Ignacius**: ""Splendid! Then let us proceed."" |
| `[181]` | **""Religion's place in society is without question. But as for its role in governmen..."** | `[178]` **Sal Ignacius**: ""For to reject the sacrament is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Sal Ignacius**: ""Wruhecism and the Rizian monarc..." |
| `[182]` | **""Are you finished?""** | `[178]` **Sal Ignacius**: ""For to reject the sacrament is ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "The wiscerer went silent. Though..." |
| `[185]` | **""I'm glad you brought this to my attention, but I'd rather not make an immediate d..."** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | *Brak zmian stanu* | `[405]` **Narrator**: "The Grand Wiseman nodded solemnly." |
| `[189]` | **""You make a valid point. I'm still not fully sold on religion's role in government..."** | `[188]` **Sal Ignacius**: ""This kingdom has been blessed f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..." |
| `[190]` | **""Religion and state should be separate. End of story.""** | `[188]` **Sal Ignacius**: ""This kingdom has been blessed f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[823]` **Player_Romus**: ""Now if you'll excuse me, I'll s..."<br>`[822]` **Player_Romus**: ""I hope I've made myself clear.""<br>*(oraz 2 innych odgałęzień)* |
| `[191]` | **""I believe my position on this issue is unlikely to change. But I see no obstacle ..."** | `[188]` **Sal Ignacius**: ""This kingdom has been blessed f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[349]` **Sal Ignacius**: ""So you'll go through with the c..." |
| `[199]` | **""If that's what it takes to get your blessing, then yes.""** | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..."<br>`[349]` **Sal Ignacius**: ""So you'll go through with the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Sal Ignacius**: ""Then please, let us proceed."" |
| `[200]` | **""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo a..."** | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..."<br>`[349]` **Sal Ignacius**: ""So you'll go through with the c..." | `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true` | *Brak zmian stanu* | `[202]` **Sal Ignacius**: ""The importance of the ceremony ..." |
| `[201]` | **""No, but since I did agree to reallocate funds toward the Dastnurist Grand Sanctua..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[856]` **Sal Ignacius**: ""You prioritized it over Plavo's..." |
| `[209]` | **""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo, ..."** | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..."<br>`[349]` **Sal Ignacius**: ""So you'll go through with the c..." | `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`<br>`(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false` | *Brak zmian stanu* | `[202]` **Sal Ignacius**: ""The importance of the ceremony ..." |
| `[213]` | **""I see no reason why not.""** | `[214]` **Sal Ignacius**: ""As long as similar... *arrangem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Sal Ignacius**: ""Excellent. I look forward to a ..." |
| `[215]` | **""No promises, but my door is always open to further discussions.""** | `[214]` **Sal Ignacius**: ""As long as similar... *arrangem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Sal Ignacius**: ""Very good, Your Majesty."" |
| `[216]` | **""This was a one-time agreement. Be grateful you got any concessions at all.""** | `[214]` **Sal Ignacius**: ""As long as similar... *arrangem..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Sal Ignacius**: ""Very well then. I will, of cour..." |
| `[227]` | **""You may.""** | `[226]` **Sal Ignacius**: ""If I may give you a piece of ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Sal Ignacius**: ""The throne you have inherited b..." |
| `[228]` | **""You may not. Good day.""** | `[226]` **Sal Ignacius**: ""If I may give you a piece of ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[229]` | **""Fine. But hurry it up. I haven't got all day.""** | `[226]` **Sal Ignacius**: ""If I may give you a piece of ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Sal Ignacius**: ""The throne you have inherited b..." |
| `[230]` | **""Go ahead.""** | `[226]` **Sal Ignacius**: ""If I may give you a piece of ad..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Sal Ignacius**: ""The throne you have inherited b..." |
| `[233]` | **""Is that a threat?""** | `[232]` **Sal Ignacius**: ""It would be a shame if any unne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Sal Ignacius**: ""Heavens no! I'm simply saying....." |
| `[234]` | **""And if I may give *you* a piece of advice... the door swings both ways.""** | `[232]` **Sal Ignacius**: ""It would be a shame if any unne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[235]` | **""You forget your place, Grand Wiseman. The onus lies not on the king to seek favor..."** | `[232]` **Sal Ignacius**: ""It would be a shame if any unne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[236]` | **""Duly noted. I will take my leave. Good day.""** | `[232]` **Sal Ignacius**: ""It would be a shame if any unne..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[238]` | **""Alright. Let's proceed.""** | `[310]` **Narrator**: "Security guards held back a crow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[314]` **Titus Gordion**: ""Right away, sir."" |
| `[241]` | **""Good. That's what I like to hear.""** | `[240]` **Sal Ignacius**: ""Don't let my physical frailty f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Sal Ignacius**: "“The six stars of St. Wruhec sti..." |
| `[242]` | **""As he does with me.""** | `[240]` **Sal Ignacius**: ""Don't let my physical frailty f..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Sal Ignacius**: ""It pleases me to hear it."" |
| `[245]` | **""No. No, I don't.""** | `[244]` **Sal Ignacius**: ""What?! But my king, you must.""<br>`[353]` **Sal Ignacius**: ""'Second thoughts?' But you have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." |
| `[246]` | **""My most sincere apologies.""** | `[244]` **Sal Ignacius**: ""What?! But my king, you must.""<br>`[353]` **Sal Ignacius**: ""'Second thoughts?' But you have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." |
| `[247]` | **""I mean no offense.""** | `[244]` **Sal Ignacius**: ""What?! But my king, you must.""<br>`[353]` **Sal Ignacius**: ""'Second thoughts?' But you have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." |
| `[248]` | **""I'm not going to repeat myself.""** | `[244]` **Sal Ignacius**: ""What?! But my king, you must.""<br>`[353]` **Sal Ignacius**: ""'Second thoughts?' But you have..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." |
| `[249]` | **""I'm sorry, but I can't. This is too much.""** | `[103]` **Sal Ignacius**: "“Let us begin. Please remove you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[244]` **Sal Ignacius**: ""What?! But my king, you must."" |
| `[251]` | **""Whose crown?""** | `[163]` **Sal Ignacius**: ""I see a crown. It's ascending i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Sal Ignacius**: ""Please don't interrupt, Your Ma..." |
| `[252]` | **""What does that mean?""** | `[163]` **Sal Ignacius**: ""I see a crown. It's ascending i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Sal Ignacius**: ""Please don't interrupt, Your Ma..." |
| `[253]` | **""Is that all?""** | `[163]` **Sal Ignacius**: ""I see a crown. It's ascending i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Sal Ignacius**: ""Please don't interrupt, Your Ma..." |
| `[257]` | **""I don't understand.""** | `[256]` **Sal Ignacius**: ""Whether or not it can be mended..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." |
| `[258]` | **""As in it can be fixed?""** | `[256]` **Sal Ignacius**: ""Whether or not it can be mended..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." |
| `[259]` | **""What do you mean it's uncertain?""** | `[256]` **Sal Ignacius**: ""Whether or not it can be mended..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." |
| `[262]` | **""What else do you see?""** | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "His grip tightened." |
| `[263]` | **""Is that all?""** | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "His grip tightened." |
| `[264]` | **""Go on.""** | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "His grip tightened." |
| `[265]` | **""Okay, I'm listening...""** | `[260]` **Sal Ignacius**: ""The visions are possible outcom..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "His grip tightened." |
| `[267]` | **""War with whom?""** | `[266]` **Sal Ignacius**: ""I now see soldiers... Many sold..."<br>`[270]` **Sal Ignacius**: ""I can not tell.""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false` | *Brak zmian stanu* | `[358]` **Sal Ignacius**: ""A most vicious foe. More than t..." |
| `[268]` | **""Whose soldiers? Are they ours?""** | `[266]` **Sal Ignacius**: ""I now see soldiers... Many sold..."<br>`[270]` **Sal Ignacius**: ""I can not tell.""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false` | *Brak zmian stanu* | `[359]` **Sal Ignacius**: ""One of the armies, yes. Their u..." |
| `[269]` | **""And the victor?""** | `[266]` **Sal Ignacius**: ""I now see soldiers... Many sold..."<br>`[270]` **Sal Ignacius**: ""I can not tell.""<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false` | *Brak zmian stanu* | `[270]` **Sal Ignacius**: ""I can not tell."" |
| `[274]` | **""A metaphor for betrayal?""** | `[273]` **Sal Ignacius**: ""Before me now is a heart... it'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Sal Ignacius**: ""Possibly."" |
| `[275]` | **""The death of a lover, perhaps?""** | `[273]` **Sal Ignacius**: ""Before me now is a heart... it'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Sal Ignacius**: ""Perhaps..."" |
| `[276]` | **""This is starting to sound like utter nonsense.""** | `[273]` **Sal Ignacius**: ""Before me now is a heart... it'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Sal Ignacius**: ""I can assure you, Your Grace, m..." |
| `[279]` | **""It's obvious that the birds represent Wehzek Dastnurists coming to our lands.""** | `[278]` **Sal Ignacius**: ""Above them are birds... tens of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Narrator**: "He paused, deep in thought, then..."<br>`[812]` **Narrator**: "He paused, deep in thought, then..." |
| `[280]` | **""The birds clearly represent Golcondists coming to our lands.""** | `[278]` **Sal Ignacius**: ""Above them are birds... tens of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Narrator**: "He paused, deep in thought, then..."<br>`[812]` **Narrator**: "He paused, deep in thought, then..." |
| `[281]` | **""It sounds to me like they represent literal birds.""** | `[278]` **Sal Ignacius**: ""Above them are birds... tens of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Narrator**: "He paused, deep in thought, then..."<br>`[812]` **Narrator**: "He paused, deep in thought, then..." |
| `[285]` | **""Rizia's royal houses. Toras, Sazon and Azaro.""** | `[284]` **Sal Ignacius**: ""...or all three will surely die."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[403]` **Sal Ignacius**: ""If true, it could mean dark clo..." |
| `[286]` | **""As it stands, Rizian lands are ruled under three different flags... Wehlen, The G..."** | `[284]` **Sal Ignacius**: ""...or all three will surely die."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Sal Ignacius**: ""It very well could."" |
| `[287]` | **""Alright. I've heard enough of this bullshit. Let me go.""** | `[284]` **Sal Ignacius**: ""...or all three will surely die."" | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");` | `[288]` **Narrator**: "I felt Sal loosen his hold of me..." |
| `[295]` | **""I think I understand.""** | `[294]` **Sal Ignacius**: ""The visions have stopped. Thus,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[300]` **Sal Ignacius**: ""Good. For it's now up to you to..." |
| `[296]` | **""Wait... I have so many questions I want to ask.""** | `[294]` **Sal Ignacius**: ""The visions have stopped. Thus,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[299]` **Sal Ignacius**: ""I don't have the answer you're ..." |
| `[297]` | **""I'm still unsure what happened.""** | `[294]` **Sal Ignacius**: ""The visions have stopped. Thus,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Sal Ignacius**: ""Give it time. Their meaning wil..." |
| `[302]` | **""I don't buy it.""** | `[294]` **Sal Ignacius**: ""The visions have stopped. Thus,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Sal Ignacius**: ""It's not uncommon to have feeli..." |
| `[317]` | **""And with you as well.""** | `[316]` **Narrator**: ""Divus zaitu" was Wruhecist for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Narrator**: "Titus quickly exited the vehicle..." |
| `[318]` | **""Please keep your religion to yourself.""** | `[316]` **Narrator**: ""Divus zaitu" was Wruhecist for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[319]` **Titus Gordion**: ""Of course. My most sincere apol..." |
| `[320]` | **""A religious man, are you? Interesting...""** | `[316]` **Narrator**: ""Divus zaitu" was Wruhecist for ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Narrator**: "Titus quickly exited the vehicle..." |
| `[324]` | **""I didn't ask for your opinion.""** | `[311]` **Titus Gordion**: ""Indeed. He is a great man.""<br>`[312]` **Titus Gordion**: ""I think he's an inspiration."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[329]` **Titus Gordion**: ""Forgive me. I meant no offense."" |
| `[325]` | **""Personal commentary isn't a part of your job description.""** | `[311]` **Titus Gordion**: ""Indeed. He is a great man.""<br>`[312]` **Titus Gordion**: ""I think he's an inspiration."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[326]` **Titus Gordion**: ""You're right. I was out of line..." |
| `[327]` | **""I'm pleased to know that our opinions align.""** | `[311]` **Titus Gordion**: ""Indeed. He is a great man."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Narrator**: "Titus quickly exited the vehicle..." |
| `[328]` | **""I couldn't agree more. As long as his loyalty remains steadfast.""** | `[311]` **Titus Gordion**: ""Indeed. He is a great man."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Narrator**: "Titus quickly exited the vehicle..." |
| `[330]` | **""Excuse my bluntness. I apologize if I offended you.""** | `[312]` **Titus Gordion**: ""I think he's an inspiration."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Titus Gordion**: ""No offense taken."" |
| `[342]` | **""Don't remind me.""** | `[340]` **Sal Ignacius**: ""That's because you used to be a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Sal Ignacius**: "“It’s only fitting that such a m..." |
| `[344]` | **""How time flies.""** | `[340]` **Sal Ignacius**: ""That's because you used to be a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Sal Ignacius**: "“It’s only fitting that such a m..." |
| `[350]` | **""Yes, though I still have reservations.""** | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..."<br>`[349]` **Sal Ignacius**: ""So you'll go through with the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Sal Ignacius**: ""Then please, let us proceed."" |
| `[351]` | **""Yes, I will.""** | `[198]` **Sal Ignacius**: ""Does this mean you'll go throug..."<br>`[349]` **Sal Ignacius**: ""So you'll go through with the c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Sal Ignacius**: ""Then please, let us proceed."" |
| `[354]` | **""I know where we are.""** | `[97]` **Narrator**: "They were arranged around a marb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[357]` **Sal Ignacius**: ""Indeed, Your Majesty. This is t..." |
| `[355]` | **""It is the holiest of honors to be allowed here.""** | `[97]` **Narrator**: "They were arranged around a marb..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[357]` **Sal Ignacius**: ""Indeed, Your Majesty. This is t..." |
| `[395]` | **""'Union.' As in marriage?""** | `[399]` **Sal Ignacius**: ""They are surrounded by people b..."<br>`[396]` **Sal Ignacius**: ""It's a forbidden love or one of..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false` | *Brak zmian stanu* | `[377]` **Sal Ignacius**: ""Or arrangement."" |
| `[397]` | **""Am I one of them?""** | `[399]` **Sal Ignacius**: ""They are surrounded by people b..."<br>`[396]` **Sal Ignacius**: ""It's a forbidden love or one of..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false` | *Brak zmian stanu* | `[376]` **Sal Ignacius**: ""One of them is of your blood."" |
| `[398]` | **""What kind of love?""** | `[399]` **Sal Ignacius**: ""They are surrounded by people b..."<br>`[396]` **Sal Ignacius**: ""It's a forbidden love or one of..."<br>*(oraz 2 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false` | *Brak zmian stanu* | `[396]` **Sal Ignacius**: ""It's a forbidden love or one of..." |
| `[414]` | **""Well done, Captain. Take him away.""** | `[413]` **Titus Gordion**: ""We'll take it from here, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Titus Gordion**: ""With pleasure."" |
| `[415]` | **""It seems I misjudged you after all, Captain Gordion. You have my thanks.""** | `[413]` **Titus Gordion**: ""We'll take it from here, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Titus Gordion**: ""It is my honor. My men will dea..." |
| `[416]` | **""Oh, now you'll 'take it from here?' He should have never broken through your men ..."** | `[413]` **Titus Gordion**: ""We'll take it from here, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[417]` **Titus Gordion**: ""Please accept my apology. It wo..." |
| `[419]` | **""What? Did you expect me to handle it myself?""** | `[413]` **Titus Gordion**: ""We'll take it from here, Your M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Titus Gordion**: ""No. Of course not. I'll have th..." |
| `[422]` | **""Was that man who I think he was?""** | `[46]` **Sal Ignacius**: ""I humbly apologize for the inte..."<br>`[432]` **Sal Ignacius**: ""I hope that man is duly punishe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..." |
| `[423]` | **""Can't say I cared for that little stunt, but I do wonder what the man wanted.""** | `[46]` **Sal Ignacius**: ""I humbly apologize for the inte..."<br>`[432]` **Sal Ignacius**: ""I hope that man is duly punishe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..." |
| `[424]` | **""I'll see to it that the protester is locked away for quite some time.""** | `[46]` **Sal Ignacius**: ""I humbly apologize for the inte..."<br>`[432]` **Sal Ignacius**: ""I hope that man is duly punishe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[839]` **Sal Ignacius**: ""Rightly so. Nobody should attac..." |
| `[425]` | **""Quite the daredevil, that man. I'm inclined to know his motivation.""** | `[46]` **Sal Ignacius**: ""I humbly apologize for the inte..."<br>`[432]` **Sal Ignacius**: ""I hope that man is duly punishe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[428]` **Sal Ignacius**: ""He was a Derdian Golcondist. I'..." |
| `[449]` | **""Fascinating. I'd love to hear more about them.""** | `[93]` **Sal Ignacius**: ""As for the tomb's tenants, they..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Sal Ignacius**: ""We shouldn't delay the ceremony..." |
| `[450]` | **""No time to bother with corpses. We've got a ceremony to perform.""** | `[93]` **Sal Ignacius**: ""As for the tomb's tenants, they..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Sal Ignacius**: ""This way, Your Majesty."" |
| `[455]` | **"First tomb."** | `[453]` **Sal Ignacius**: ""But very well. Who would you li..."<br>`[924]` **Sal Ignacius**: ""As long as they remember that i..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false` | *Brak zmian stanu* | `[483]` **Sal Ignacius**: ""That would be the tomb of Taler..." |
| `[456]` | **"Second tomb."** | `[453]` **Sal Ignacius**: ""But very well. Who would you li..."<br>`[924]` **Sal Ignacius**: ""As long as they remember that i..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false` | *Brak zmian stanu* | `[493]` **Sal Ignacius**: ""That would be Aurelia Itxaro. I..." |
| `[457]` | **"Third tomb."** | `[453]` **Sal Ignacius**: ""But very well. Who would you li..."<br>`[924]` **Sal Ignacius**: ""As long as they remember that i..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false` | *Brak zmian stanu* | `[644]` **Narrator**: "Decorated in gold, I would have ..." |
| `[490]` | **""Yes, I'm quite familiar with his reputation.""** | `[485]` **Sal Ignacius**: ""After the war, he established C..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body0...` | `[489]` **Narrator**: "His mentioning of Camp Domus flo..." |
| `[491]` | **""Even though he fought against House Toras, I still hold him in the highest respect.""** | `[485]` **Sal Ignacius**: ""After the war, he established C..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body0...` | `[489]` **Narrator**: "His mentioning of Camp Domus flo..." |
| `[492]` | **""He may be revered by some, but I never much cared for him.""** | `[485]` **Sal Ignacius**: ""After the war, he established C..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body0...` | `[489]` **Narrator**: "His mentioning of Camp Domus flo..." |
| `[503]` | **""Is that where you keep the torch-er chamber?""** | `[638]` **Narrator**: "We eventually reached an imposin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[623]` **Sal Ignacius**: ""Most amusing. If it's torture y..." |
| `[509]` | **"Conduct their applause."** | `[534]` **Narrator**: "I turned back toward the crowd. ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[511]` **Narrator**: "Eager to follow along, they got ..." |
| `[510]` | **"Ignore them."** | `[534]` **Narrator**: "I turned back toward the crowd. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Narrator**: "The onlookers' enthusiasm dimini..." |
| `[513]` | **"Wave."** | `[534]` **Narrator**: "I turned back toward the crowd. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[514]` **Narrator**: "The shouts of admiration resonat..." |
| `[515]` | **"Recite a Wruhecist proverb."** | `[534]` **Narrator**: "I turned back toward the crowd. ..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[516]` **Narrator**: "The old Wruhecist proverb transl..." |
| `[525]` | **""Have them removed immediately.""** | `[524]` **Titus Gordion**: ""These people look like they cou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[532]` **Titus Gordion**: ""Yes, sir."" |
| `[526]` | **""You really had to ask? Get those traitors the hell out of my sight.""** | `[524]` **Titus Gordion**: ""These people look like they cou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC...` | `[531]` **Titus Gordion**: ""Of course. Right away."" |
| `[527]` | **""No, they have the right to protest, even if I disagree with their cause.""** | `[524]` **Titus Gordion**: ""These people look like they cou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[535]` **Titus Gordion**: ""Understood."" |
| `[528]` | **""Let them protest, Captain, seeing as how this issue holds significant importance ..."** | `[524]` **Titus Gordion**: ""These people look like they cou..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemo...` | `[530]` **Titus Gordion**: ""Yes, Your Majesty."" |
| `[541]` | **""How morbidly disturbing.""** | `[307]` **Sal Ignacius**: ""Welcome to the catacombs."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[619]` **Sal Ignacius**: ""Our departed friends won't be c..." |
| `[542]` | **""Impressive, to say the least.""** | `[307]` **Sal Ignacius**: ""Welcome to the catacombs."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[618]` **Sal Ignacius**: ""Indeed it is."" |
| `[543]` | **""I'm tempted to knock to see if anyone's home.""** | `[307]` **Sal Ignacius**: ""Welcome to the catacombs."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[616]` **Sal Ignacius**: ""If you insist. However, if you ..." |
| `[546]` | **""Fine. The sooner we get this over with the better.""** | `[137]` **Sal Ignacius**: ""I must insist that you take my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "Despite my apprehension, I took ..." |
| `[547]` | **""You're right. Please continue.""** | `[137]` **Sal Ignacius**: ""I must insist that you take my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[545]` **Narrator**: "Despite my apprehension, I took ..." |
| `[548]` | **""Then I sincerely hope you can find it in your heart to forgive me.""** | `[137]` **Sal Ignacius**: ""I must insist that you take my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[551]` **Sal Ignacius**: ""It's not forgiveness from you t..." |
| `[549]` | **""Then I'll be sure to keep that in mind if ever you should come groveling on your ..."** | `[137]` **Sal Ignacius**: ""I must insist that you take my ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[550]` **Narrator**: "The wiscerer went silent. Though..." |
| `[557]` | **""Oh, yeah? And what's that?""** | `[556]` **Sal Ignacius**: ""You only just inherited the thr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[562]` **Sal Ignacius**: ""What I wanted to say was... bur..." |
| `[558]` | **""Fine. But keep it brief.""** | `[556]` **Sal Ignacius**: ""You only just inherited the thr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Sal Ignacius**: ""Of course."" |
| `[559]` | **""*Unsolicited* advice. But do go on. I want to hear what you have to say.""** | `[556]` **Sal Ignacius**: ""You only just inherited the thr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[819]` **Narrator**: "There was a flash of irritation ..." |
| `[560]` | **""Request denied. Good day, Grand Wiseman. I'll see myself out.""** | `[556]` **Sal Ignacius**: ""You only just inherited the thr..." | *Brak (Dostępna bezwarunkowo)* | `RemoveConversant("Sal Ignacius");` | `[138]` **Narrator**: "I quickly put on my clothes and ..." |
| `[565]` | **""Why do you need my hands?""** | `[132]` **Player_Romus_Italic**: "I pulled my hands away from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." |
| `[566]` | **""What's this about?""** | `[132]` **Player_Romus_Italic**: "I pulled my hands away from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." |
| `[567]` | **""What are you doing?""** | `[131]` **Player_Romus_Italic**: "I took a step back."<br>`[132]` **Player_Romus_Italic**: "I pulled my hands away from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." |
| `[568]` | **""Kindly keep your distance.""** | `[131]` **Player_Romus_Italic**: "I took a step back."<br>`[132]` **Player_Romus_Italic**: "I pulled my hands away from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." |
| `[569]` | **""What's going on?""** | `[131]` **Player_Romus_Italic**: "I took a step back." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." |
| `[570]` | **""No, I haven't changed my mind about that. However... perhaps we can overlook my a..."** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[571]` **Sal Ignacius**: ""That's asking a lot. The import..." |
| `[572]` | **""What if I made it worth your while?""** | `[571]` **Sal Ignacius**: ""That's asking a lot. The import..."<br>`[856]` **Sal Ignacius**: ""You prioritized it over Plavo's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[608]` **Sal Ignacius**: ""Go on..."" |
| `[573]` | **""What if I told you there would be consequences for defying the king's wishes?""** | `[571]` **Sal Ignacius**: ""That's asking a lot. The import..."<br>`[856]` **Sal Ignacius**: ""You prioritized it over Plavo's..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Sal Ignacius**: ""Then I would tell you that repe..." |
| `[575]` | **""Well, Your Holiness, it seems we've reached an impasse. I'll see myself out.""** | `[574]` **Sal Ignacius**: ""Then I would tell you that repe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[579]` **Sal Ignacius**: ""Divus zaitu."" |
| `[576]` | **""A man with convictions... It's a rarity these days. I respect that. Until next ti..."** | `[574]` **Sal Ignacius**: ""Then I would tell you that repe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[580]` **Sal Ignacius**: ""Next time, Your Majesty."" |
| `[577]` | **""Well then... now that we better understand each other, perhaps we can one day cha..."** | `[574]` **Sal Ignacius**: ""Then I would tell you that repe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[578]` **Sal Ignacius**: ""Perhaps."" |
| `[581]` | **""Divus zaitu.""** | `[579]` **Sal Ignacius**: ""Divus zaitu."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...` | `[606]` **Narrator**: "I wished Sal goodbye and left th..." |
| `[582]` | **""Whatever you say.""** | `[579]` **Sal Ignacius**: ""Divus zaitu."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...` | `[222]` **Narrator**: "I bid Wiseman Ignacius farewell ..." |
| `[583]` | **""Thanks.""** | `[579]` **Sal Ignacius**: ""Divus zaitu."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...` | `[222]` **Narrator**: "I bid Wiseman Ignacius farewell ..." |
| `[584]` | **""You're right. Forget what I said. 'Til next time.""** | `[571]` **Sal Ignacius**: ""That's asking a lot. The import..."<br>`[856]` **Sal Ignacius**: ""You prioritized it over Plavo's..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...` | `[606]` **Narrator**: "I wished Sal goodbye and left th..." |
| `[585]` | **""Can't say the same about you.""** | `[579]` **Sal Ignacius**: ""Divus zaitu."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...` | `[222]` **Narrator**: "I bid Wiseman Ignacius farewell ..." |
| `[588]` | **""Good. I expect nothing less.""** | `[587]` **Sal Ignacius**: ""While I have my reservations ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Sal Ignacius**: ""I look forward to speaking more..." |
| `[589]` | **""Meaning?""** | `[587]` **Sal Ignacius**: ""While I have my reservations ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Sal Ignacius**: ""That I may be old, but I know w..." |
| `[590]` | **""I look forward to future discussions. Maybe then I can nurture your curiosity eve..."** | `[587]` **Sal Ignacius**: ""While I have my reservations ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[592]` **Sal Ignacius**: ""We shall see."" |
| `[591]` | **""Then I look forward to speaking to you about future... arrangements.""** | `[587]` **Sal Ignacius**: ""While I have my reservations ab..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[593]` **Sal Ignacius**: ""As I with you."" |
| `[598]` | **""Good to hear. I underestimated you, Your Holiness.""** | `[594]` **Sal Ignacius**: ""That I may be old, but I know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[601]` **Sal Ignacius**: ""Most do."" |
| `[599]` | **""I don't want to be around someone who is so easily swayed. Forget it.""** | `[594]` **Sal Ignacius**: ""That I may be old, but I know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[607]` **Sal Ignacius**: ""Well, I'm sorry to hear that. H..." |
| `[600]` | **""Very good. I look forward to future *arrangements* between us.""** | `[594]` **Sal Ignacius**: ""That I may be old, but I know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[602]` **Sal Ignacius**: ""As do I."" |
| `[603]` | **""As long as the wind continues to blow in the right direction.""** | `[594]` **Sal Ignacius**: ""That I may be old, but I know w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[604]` **Sal Ignacius**: ""Yes, of course. Though predicti..." |
| `[609]` | **""As in, any *kindness* bestowed upon me will be reciprocated.""** | `[608]` **Sal Ignacius**: ""Go on..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[586]` **Sal Ignacius**: ""Make no mistake... In matters o..." |
| `[610]` | **""Meaning, I won't feel the need to seek *alternatives* to convince you to be more ..."** | `[608]` **Sal Ignacius**: ""Go on..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[614]` **Sal Ignacius**: ""Do what you must. But I stand o..." |
| `[611]` | **""As in, you keep your position as Grand Wiseman and aren't replaced by someone mor..."** | `[608]` **Sal Ignacius**: ""Go on..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Sal Ignacius**: ""Now, now... let's not be hasty...." |
| `[612]` | **""That if you do me this one small favor, another small favor will be returned to y..."** | `[608]` **Sal Ignacius**: ""Go on..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[613]` **Sal Ignacius**: ""I see..."" |
| `[624]` | **""What's down there?""** | `[638]` **Narrator**: "We eventually reached an imposin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[628]` **Sal Ignacius**: ""Come and see for yourself."" |
| `[625]` | **""I'm going to catch the plague, I know it.""** | `[638]` **Narrator**: "We eventually reached an imposin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[627]` **Sal Ignacius**: ""The path ahead leads us to one ..." |
| `[626]` | **""How medieval.""** | `[638]` **Narrator**: "We eventually reached an imposin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[629]` **Sal Ignacius**: ""Believe me, this is only the be..." |
| `[635]` | **""I'll look into funding these projects as soon as the Treasury allows it.""** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false` | *Brak zmian stanu* | `[636]` **Narrator**: "The Grand Wiseman clasped his ha..." |
| `[639]` | **""Who's in the coffin?""** | `[97]` **Narrator**: "They were arranged around a marb..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Sal Ignacius**: "“Why, Caelus the Devout, of cour..." |
| `[645]` | **""I'm ready to move on.""** | `[453]` **Sal Ignacius**: ""But very well. Who would you li..."<br>`[924]` **Sal Ignacius**: ""As long as they remember that i..."<br>*(oraz 4 innych węzłów)* | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true` | `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body0...` | `[470]` **Sal Ignacius**: ""Very well."" |
| `[647]` | **""What would a Derdian Golcondist be doing here?""** | `[426]` **Sal Ignacius**: ""I believe he was a Derdian Golc..."<br>`[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Sal Ignacius**: ""Plavo is one of the holiest pla..." |
| `[650]` | **""I have my own ways of honoring God, and this is not one of them.""** | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Narrator**: "Sal looked apoplectic." |
| `[651]` | **""Well, there's a first time for everything.""** | `[727]` **Sal Ignacius**: ""No Rizian king or queen has eve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[728]` **Narrator**: "Sal looked apoplectic." |
| `[662]` | **""Demanding entrance to our sacred Wruhecist space... I hope he gets what's coming ..."** | `[426]` **Sal Ignacius**: ""I believe he was a Derdian Golc..."<br>`[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..."<br>*(oraz 1 innych węzłów)* | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[667]` **Sal Ignacius**: ""Do not be too harsh towards our..." |
| `[663]` | **""I didn't know Derdia's fundamentalism had gotten this out of control.""** | `[426]` **Sal Ignacius**: ""I believe he was a Derdian Golc..."<br>`[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[666]` **Sal Ignacius**: ""Alas, our Derdian brothers have..." |
| `[664]` | **""I'm not surprised at his actions. When you deprive a man of religious freedom, th..."** | `[426]` **Sal Ignacius**: ""I believe he was a Derdian Golc..."<br>`[427]` **Sal Ignacius**: ""Judging by his wardrobe, he app..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[665]` **Sal Ignacius**: ""It is not 'freedom' that motiva..." |
| `[682]` | **""I have to say, the disheveled look gives the place character.""** | `[681]` **Narrator**: "Sal gestured over our heads to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[686]` **Sal Ignacius**: ""Many congregates don't share yo..." |
| `[683]` | **""It looks to have seen better days.""** | `[681]` **Narrator**: "Sal gestured over our heads to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[685]` **Sal Ignacius**: ""That's putting it mildly."" |
| `[684]` | **""It's a shame what happened to such a magnificent building.""** | `[681]` **Narrator**: "Sal gestured over our heads to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[687]` **Sal Ignacius**: ""I couldn't agree more."" |
| `[688]` | **""Religious fanaticism will do that.""** | `[681]` **Narrator**: "Sal gestured over our heads to t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[689]` **Sal Ignacius**: ""The collapse was entirely preve..." |
| `[694]` | **"“As it should be. I know I’d be lost without Wruhecism to show me the way.”"** | `[693]` **Sal Ignacius**: ""All under the umbrella of our s..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[705]` **Sal Ignacius**: ""As would I, Your Majesty."" |
| `[696]` | **""Should religion really be playing such a large role in modern society?""** | `[693]` **Sal Ignacius**: ""All under the umbrella of our s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[704]` **Sal Ignacius**: ""Our modern world is fractured, ..." |
| `[698]` | **""You could have fooled me. I look around and I see heretics and blasphemers everyw..."** | `[693]` **Sal Ignacius**: ""All under the umbrella of our s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[706]` **Sal Ignacius**: ""Indeed, our religious unity has..." |
| `[703]` | **""You are forgetting religion's most important role of all. That of pacifying the p..."** | `[693]` **Sal Ignacius**: ""All under the umbrella of our s..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[709]` **Sal Ignacius**: ""It is true that sharing a singl..." |
| `[722]` | **""I'll be honest with you. I don't particularly care.""** | `[717]` **Sal Ignacius**: ""I would never counsel this coun..." | `(Variable["RiziaDLC.Prologue_Religious"] == true) == false` | *Brak zmian stanu* | `[723]` **Sal Ignacius**: ""Many in this country do, Your M..." |
| `[737]` | **""Oh. Um... I don't drink.""** | `[119]` **Narrator**: "He poured the wine into the chal..." | `Variable["RiziaDLC.Trait_SoberKing"] == true` | *Brak zmian stanu* | `[738]` **Sal Ignacius**: ""Only the most pious and reveren..." |
| `[739]` | **""About time! I need a drink.""** | `[119]` **Narrator**: "He poured the wine into the chal..." | `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false` | *Brak zmian stanu* | `[738]` **Sal Ignacius**: ""Only the most pious and reveren..." |
| `[745]` | **""'Golcondism Is Not Blasphemy?' How dare they challenge our religious laws?'""** | `[744]` **Sal Ignacius**: ""You made the right decision in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[751]` **Sal Ignacius**: ""The Golcondists have been irate..." |
| `[746]` | **""'Who do you think they were?""** | `[744]` **Sal Ignacius**: ""You made the right decision in ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[747]` **Sal Ignacius**: ""Definitely Golcondists. Derdian..." |
| `[748]` | **""The guards went too easy on them. They should have locked up the whole lot.""** | `[744]` **Sal Ignacius**: ""You made the right decision in ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["...` | `[752]` **Sal Ignacius**: ""Be not too harsh on our Derdian..." |
| `[750]` | **""Those poor lost souls. Is there any hope for them?""** | `[744]` **Sal Ignacius**: ""You made the right decision in ..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[756]` **Sal Ignacius**: ""Only if they give up their twis..." |
| `[758]` | **""Those beasts. Praise the Lord it won't happen again.""** | `[757]` **Sal Ignacius**: ""A large group of Golcondists ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[765]` **Sal Ignacius**: ""Halaita. If it is said, so it i..." |
| `[759]` | **""Are you sure the locals didn't start it? The inhabitants of Cardesse-Montaklar ar..."** | `[757]` **Sal Ignacius**: ""A large group of Golcondists ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[764]` **Sal Ignacius**: ""I assure you, the warrior cultu..." |
| `[760]` | **""That's the only reason for our blasphemy law?""** | `[757]` **Sal Ignacius**: ""A large group of Golcondists ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[762]` **Sal Ignacius**: ""It was the feather that tipped ..." |
| `[761]` | **""And why has it not been fixed since then?""** | `[757]` **Sal Ignacius**: ""A large group of Golcondists ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[763]` **Sal Ignacius**: ""We will get to that."" |
| `[766]` | **""But I'm not thirsty.""** | `[119]` **Narrator**: "He poured the wine into the chal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[738]` **Sal Ignacius**: ""Only the most pious and reveren..." |
| `[772]` | **""This ceremony has exceeded the limits of reason. I cannot participate in good con..."** | `[133]` **Sal Ignacius**: ""To consummate the Consecration ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[818]` **Sal Ignacius**: ""Interrupting the ritual will ha..." |
| `[780]` | **""It is a heavy burden, Grand Wiseman. But I accept it.""** | `[778]` **Sal Ignacius**: ""It is your responsibility to ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[788]` **Sal Ignacius**: ""Halaita."" |
| `[781]` | **""I am an instrument of nobody. Not God, and definitely not you.""** | `[778]` **Sal Ignacius**: ""It is your responsibility to ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[786]` **Narrator**: "He frowned." |
| `[782]` | **""I pray that He and you will guide me to do what is best for our country.""** | `[778]` **Sal Ignacius**: ""It is your responsibility to ca..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[788]` **Sal Ignacius**: ""Halaita."" |
| `[783]` | **""I must confess that I'm not entirely convinced about what transpired here today. ..."** | `[778]` **Sal Ignacius**: ""It is your responsibility to ca..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[786]` **Narrator**: "He frowned." |
| `[814]` | **""It clearly speaks of Zille's return.""** | `[813]` **Sal Ignacius**: ""Once separated from its flock b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Sal Ignacius**: ""And on a nearby mountain overlo..." |
| `[815]` | **""Bringing the faithful back into the fold, perhaps?""** | `[813]` **Sal Ignacius**: ""Once separated from its flock b..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[282]` **Sal Ignacius**: ""And on a nearby mountain overlo..." |
| `[816]` | **"Sigh in frustration."** | `[813]` **Sal Ignacius**: ""Once separated from its flock b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Sal Ignacius**: ""And on a nearby mountain overlo..." |
| `[821]` | **""Unless you're aiming for a medieval revival of the Dark Ages...""** | `[190]` **Player_Romus**: ""Religion and state should be se..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...` | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[822]` | **""I hope I've made myself clear.""** | `[190]` **Player_Romus**: ""Religion and state should be se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[823]` | **""Now if you'll excuse me, I'll see myself out.""** | `[190]` **Player_Romus**: ""Religion and state should be se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[841]` | **"“He got all this just for *teaching*? My own final resting place had better be eve..."** | `[61]` **Sal Ignacius**: ""Caelus the Devout. Singlehanded..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[842]` **Sal Ignacius**: ""To use one's wisdom to enlighte..." |
| `[850]` | **"“The holy books do tell of mystical events occurring on this site, but they are un..."** | `[111]` **Sal Ignacius**: ""But what most don’t know is tha..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[851]` **Sal Ignacius**: "“I shall enlighten you. This is ..." |
| `[854]` | **""Having said that... can't you overlook my abstention? I don't want news getting o..."** | `[190]` **Player_Romus**: ""Religion and state should be se..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[855]` **Sal Ignacius**: ""Are you asking a holy man to li..." |
| `[873]` | **""I shall wield this with pride, so all who see me will be reminded that I walk in ..."** | `[876]` **Player_Romus_Italic**: "I took the scepter from him." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...`<br>`Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...`<br>*(+1 skryptów)* | `[564]` **Narrator**: "I put on my clothes, and made my..." |
| `[874]` | **""A reminder that while we espouse the six tenets of Wruhecism now, it was St. Dast..."** | `[876]` **Player_Romus_Italic**: "I took the scepter from him." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Country_DastnuristOpinion"] = Variable...`<br>`Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...`<br>*(+1 skryptów)* | `[564]` **Narrator**: "I put on my clothes, and made my..." |
| `[875]` | **""I am deeply humbled and profoundly grateful for this extraordinary honor.""** | `[876]` **Player_Romus_Italic**: "I took the scepter from him." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...`<br>`RemoveConversant("Sal Ignacius");` | `[564]` **Narrator**: "I put on my clothes, and made my..." |
| `[876]` | **"Take the scepter."** | `[872]` **Sal Ignacius**: ""And now, I give it to you."" | *Brak (Dostępna bezwarunkowo)* | `EnableCollectionItem("CollectionItem_DastScepter");` | `[875]` **Player_Romus**: ""I am deeply humbled and profoun..."<br>`[874]` **Player_Romus**: ""A reminder that while we espous..."<br>*(oraz 2 innych odgałęzień)* |
| `[877]` | **"Don't take the scepter."** | `[872]` **Sal Ignacius**: ""And now, I give it to you."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[878]` **Player_Romus**: ""I'm honored, but I believe it w..."<br>`[931]` **Player_Romus**: ""This represents Dast's eleven p..."<br>*(oraz 2 innych odgałęzień)* |
| `[878]` | **""I'm honored, but I believe it would be better suited under your esteemed care and..."** | `[877]` **Player_Romus_Italic**: "I didn't take the scepter from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[881]` **Sal Ignacius**: ""As you wish."" |
| `[879]` | **""Thanks, but I have enough scepters. You keep it.""** | `[877]` **Player_Romus_Italic**: "I didn't take the scepter from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[881]` **Sal Ignacius**: ""As you wish."" |
| `[880]` | **""I appreciate the gesture, but I'm not worthy of such a gift.""** | `[877]` **Player_Romus_Italic**: "I didn't take the scepter from him." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[881]` **Sal Ignacius**: ""As you wish."" |
| `[892]` | **""You brought me here to make a funding decision, under the guise of a ritual? The ..."** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[893]` **Narrator**: "The holy man withdrew, looking h..." |
| `[896]` | **""We are in a holy place, Grand Wiseman. I refuse to sully it with deliberations ov..."** | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[897]` **Narrator**: "The holy man drew in his breath." |
| `[900]` | **""Don't worry, Plavo will get its funding. But next time, come straight out and ask..."** | `[895]` **Sal Ignacius**: ""But now that you have seen the ..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | *Brak zmian stanu* | `[904]` **Narrator**: "Sal bowed in gratitude." |
| `[906]` | **""Quite the contrary. Plavo can wait. I'll allocate funds for that Dastnurist Grand..."** | `[895]` **Sal Ignacius**: ""But now that you have seen the ..." | `Variable["RiziaDLC.Resources_Budget"] >= 2` | *Brak zmian stanu* | `[907]` **Narrator**: "Sal nodded, clearly disappointed." |
| `[908]` | **""I understand when I'm being manipulated. Don't bother me with these requests again.""** | `[895]` **Sal Ignacius**: ""But now that you have seen the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[909]` **Narrator**: "He nodded hurriedly." |
| `[911]` | **""I prefer it this way. It reminds one that God is as capable of destruction as He ..."** | `[895]` **Sal Ignacius**: ""But now that you have seen the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[912]` **Sal Ignacius**: ""Y-yes, it is beautiful in its o..." |
| `[918]` | **""Luckily for you, the well-being of Rizia's religious communities is important to ..."** | `[895]` **Sal Ignacius**: ""But now that you have seen the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[919]` **Narrator**: "Sal bowed in gratitude." |
| `[921]` | **""A commoner, buried among the Montaklar nobility? What an insult.""** | `[494]` **Sal Ignacius**: ""While he isn't of royal lineage..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[926]` **Sal Ignacius**: ""With the love of God in his hea..." |
| `[922]` | **""A pioneer to whom we all owe a debt of gratitude. Rizia could use more innovators..."** | `[494]` **Sal Ignacius**: ""While he isn't of royal lineage..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[924]` **Sal Ignacius**: ""As long as they remember that i..." |
| `[923]` | **""It's his fault Rizia became so reliant on resources. Perhaps we would have been b..."** | `[494]` **Sal Ignacius**: ""While he isn't of royal lineage..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[925]` **Sal Ignacius**: ""The Lord put that gold in the g..." |
| `[928]` | **""A big stick. How useful.""** | `[876]` **Player_Romus_Italic**: "I took the scepter from him." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["...`<br>`Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyPart...`<br>*(+1 skryptów)* | `[564]` **Narrator**: "I put on my clothes, and made my..." |
| `[931]` | **""This represents Dast's eleven pillars, not Wruhec's six core tenets. Dastnurists ..."** | `[877]` **Player_Romus_Italic**: "I didn't take the scepter from him." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[933]` **Sal Ignacius**: ""I see the scepter as a reminder..." |
| `[939]` | **"“Why was he so afraid of angering Dastnurists? They make up only a small part of t..."** | `[886]` **Sal Ignacius**: ""Afraid of angering one religiou..."<br>`[888]` **Sal Ignacius**: ""Focusing on the restoration of ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false` | `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] = ...` | `[887]` **Sal Ignacius**: ""This may be true, but Wehlen an..." |
| `[954]` | **""So that more people may bask in God's glory.""** | `[953]` **Sal Ignacius**: ""With the entire religious commu..."<br>`[962]` **Sal Ignacius**: ""A pity. With enough funds, you ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[958]` **Sal Ignacius**: ""Precisely."" |
| `[955]` | **""I get what you're saying. If we keep our people busy with religion, we won't have..."** | `[953]` **Sal Ignacius**: ""With the entire religious commu..."<br>`[962]` **Sal Ignacius**: ""A pity. With enough funds, you ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[959]` **Sal Ignacius**: ""Spreading the great word of Nur..." |
| `[956]` | **""The Crown's money should be spent on improving our citizens' welfare, regardless ..."** | `[953]` **Sal Ignacius**: ""With the entire religious commu..."<br>`[962]` **Sal Ignacius**: ""A pity. With enough funds, you ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[961]` **Sal Ignacius**: ""Do not neglect the importance o..." |
| `[963]` | **""I aim to transform Rizia into a strong, modern nation. I'm not going to waste tim..."** | `[953]` **Sal Ignacius**: ""With the entire religious commu..."<br>`[962]` **Sal Ignacius**: ""A pity. With enough funds, you ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[964]` **Sal Ignacius**: ""The majority of our citizens ho..." |
| `[973]` | **""Here's what I think.""** | `[886]` **Sal Ignacius**: ""Afraid of angering one religiou..."<br>`[888]` **Sal Ignacius**: ""Focusing on the restoration of ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true` | *Brak zmian stanu* | `[657]` **Narrator**: "Sal closed his eyes and tilted h..." |
| `[980]` | **""My mind is made up. Goodbye.""** | `[168]` **Sal Ignacius**: ""It represents stability and ste..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Narrator**: "Sal gasped in astonishment as I ..." |
| `[982]` | **"Remain silent and continue listening."** | `[266]` **Sal Ignacius**: ""I now see soldiers... Many sold..."<br>`[270]` **Sal Ignacius**: ""I can not tell.""<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Narrator**: "I continued to listen closely to..." |
| `[983]` | **"Listen without interruption."** | `[399]` **Sal Ignacius**: ""They are surrounded by people b..."<br>`[396]` **Sal Ignacius**: ""It's a forbidden love or one of..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[273]` **Sal Ignacius**: ""Before me now is a heart... it'..." |
| `[984]` | **"Offer no reply."** | `[273]` **Sal Ignacius**: ""Before me now is a heart... it'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Sal Ignacius**: ""Now, I behold an endless sea of..." |
| `[985]` | **"Don't speak."** | `[278]` **Sal Ignacius**: ""Above them are birds... tens of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[811]` **Narrator**: "He paused, deep in thought, then..."<br>`[812]` **Narrator**: "He paused, deep in thought, then..." |
| `[986]` | **"Hold your tongue."** | `[813]` **Sal Ignacius**: ""Once separated from its flock b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Sal Ignacius**: ""And on a nearby mountain overlo..." |
| `[987]` | **"Offer no response."** | `[284]` **Sal Ignacius**: ""...or all three will surely die."" | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");` | `[288]` **Narrator**: "I felt Sal loosen his hold of me..." |
| `[988]` | **""Such a grand expenditure would certainly drain the Crown of its resources.""** | `[886]` **Sal Ignacius**: ""Afraid of angering one religiou..."<br>`[888]` **Sal Ignacius**: ""Focusing on the restoration of ..."<br>*(oraz 5 innych węzłów)* | `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false` | `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;` | `[990]` **Sal Ignacius**: ""Indeed... I am afraid both of t..." |
| `[1001]` | **"Nod."** | `[163]` **Sal Ignacius**: ""I see a crown. It's ascending i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Sal Ignacius**: ""And on the crown is a fracture ..." |
| `[1002]` | **"Gesture for him to keep going."** | `[256]` **Sal Ignacius**: ""Whether or not it can be mended..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "His grip tightened." |

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
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Breather", "R_Breather_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "My motorcade traveled for over an hour before the Archsanctuary of Plavo appeared on the horizon. Its golden dome radiated under the sunrise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "It was a view I’d seen countless times, but it never failed to inspire awe."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "It was a view that inspired awe in many a Rizian, especially the most devout followers of St. Wruhec."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Titus, who was sitting next to the driver, turned back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Titus Gordion: ""We shall be arriving shortly, Your Majesty.""*)

### Węzeł `[7]`
Mówca: **Titus Gordion**
> ""We shall be arriving shortly, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player_Romus: ""Good. I’ve been looking forward to this for quite some t..."*)
  - -> `[9]` (*Player_Romus: ""Let’s get this over with.""*)
  - -> `[10]` (*Player_Romus: ""This should be interesting.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I’ve been looking forward to this for quite some time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I was here for the Consecration of the King, the centurie..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let’s get this over with.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I was here for the Consecration of the King, the centurie..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This should be interesting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I was here for the Consecration of the King, the centurie..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I was here for the Consecration of the King, the centuries-old ecclesiastical ceremony symbolizing a monarch's appointment as God’s highest representative on earth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "Better known as the “divine right of kings.”"*)

### Węzeł `[12]`
Mówca: **Narrator**
> "Better known as the “divine right of kings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Unlike my coronation, this was a private event shrouded i..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Unlike my coronation, this was a private event shrouded in secrecy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[796]` (*Narrator: "Only a select few, such as Grand Wiseman and religious co..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Not even my father, despite my asking, would disclose what occurred. He'd simply say, “What took place was between me and God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "But aside from the pomp and circumstance of the Consecration of the King, this meeting was my chance to catch up on Rizia's current state of religious affairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Before long, my car pulled up in front of the towering co..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Before long, my car pulled up in front of the towering colonnades situated on either side of the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Narrator: "Security guards held back a crowd of onlookers gathered a..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grand Wiseman Ignacius... looking as stoic as ever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Titus Gordion: ""Indeed. He is a great man.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Look at the old geezer. Hard to believe he's still breathing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Titus Gordion: ""I think he's an inspiration.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here we go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Titus Gordion: ""Good luck, sir.""*)

### Węzeł `[20]`
Mówca: **Narrator**
> "While most shouted my praises, there was a small group of demonstrators protesting against the ceremony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[658]` (*Narrator: "One was waving a sign that read, "Golcondism Is Not Blasp..."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "A welcoming smile spread across the Grand Wiseman's face as he came down the stairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Sal Ignacius: ""Welcome, Your Majesty. We are greatly honored to have yo..."*)

### Węzeł `[22]`
Mówca: **Sal Ignacius**
> ""Welcome, Your Majesty. We are greatly honored to have you here for this momentous occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Sal Ignacius: ""I look forward to serving you just as I served your fath..."*)

### Węzeł `[23]`
Mówca: **Sal Ignacius**
> ""I look forward to serving you just as I served your father.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player_Romus: ""It is I who is honored to be here.""*)
  - -> `[25]` (*Player_Romus: ""I shall honor this day with the dignity and respect this..."*)
  - -> `[26]` (*Player_Romus: ""I could think of better ways to spend my day. But when d..."*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is I who is honored to be here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Sal Ignacius: ""You are too kind.""*)

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shall honor this day with the dignity and respect this sacred tradition deserves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Sal Ignacius: "“It fills my heart with joy to hear it.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I could think of better ways to spend my day. But when duty calls, one must oblige.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Sal Ignacius: ""Well, in any case, I'm glad you're here.""*)

### Węzeł `[27]`
Mówca: **Sal Ignacius**
> "“It fills my heart with joy to hear it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Sal Ignacius: ""I shall do my best to provide you with both personal and..."*)

### Węzeł `[28]`
Mówca: **Sal Ignacius**
> ""I shall do my best to provide you with both personal and state guidance on religion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: "“Thank you, Grand Wiseman. I aspire to fulfill God's will..."*)
  - -> `[31]` (*Player_Romus: ""And I am privileged to receive your guidance.”"*)
  - -> `[30]` (*Player_Romus: "“Time is short, Grand Wiseman. Let us skip the pleasantri..."*)
  - -> `[32]` (*Player_Romus: ""Your best? Only the weak whine about doing their best.""*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Thank you, Grand Wiseman. I aspire to fulfill God's will here on earth, just as you have done.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Sal Ignacius: ""I have no doubt.""*)

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Time is short, Grand Wiseman. Let us skip the pleasantries.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Sal Ignacius: ""As you wish.""*)

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I am privileged to receive your guidance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Sal Ignacius: ""I'm merely a humble servant, Your Grace. I do as God com..."*)

### Węzeł `[32]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your best? Only the weak whine about doing their best.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[979]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousBrief_YourBest = true;"*)

### Węzeł `[33]`
Mówca: **Sal Ignacius**
> ""I'm merely a humble servant, Your Grace. I do as God commands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Sal Ignacius: ""After today, it shall be you who speaks for the Divine.""*)

### Węzeł `[34]`
Mówca: **Sal Ignacius**
> "“The six stars of St. Wruhec still shine upon our nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Sal Ignacius: "“Come, let us step inside. We have much to discuss.”"*)

### Węzeł `[35]`
Mówca: **Sal Ignacius**
> "“Come, let us step inside. We have much to discuss.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false"*)

### Węzeł `[36]`
Mówca: **Narrator**
> "We began heading toward the entrance. However, I didn't get very far before my attention was drawn to a commotion from behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "As I turned to look, a throng of people surged against my..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "As I turned to look, a throng of people surged against my security guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[801]` (*Narrator: "Amidst the commotion, one managed to slip from their gras..."*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "Stand your ground."]** — Mówca: **Player_Romus_Italic**
> "I didn't want to be seen as a coward, so I stood my ground as the man approached."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[801]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = false; Riz..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "Hurry towards the archsanctuary."]** — Mówca: **Player_Romus_Italic**
> "I hurried towards the archsanctuary before he could reach me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[801]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Narrator: "Partway up the stairs, I heard Titus and his men apprehen..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Titus, without missing a beat, caught the man by the arm and threw him to the ground. Other guards approached as Titus held him down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "The surprise visitor was shouting something, but I couldn..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's so blasphemous about Golcondism?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[671]` (*Sal Ignacius: ""The Golcondists have a martial culture, Your Majesty. Th..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“And so you banned them. Rightly so, I might add.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[670]` (*Sal Ignacius: ""I did so with a heavy heart. But our sanctuaries are a p..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Could we not have built Golcondist sanctuaries to pacify them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[668]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[669]` (*Sal Ignacius: ""They aim to trace the footsteps of Wruhec's disciples th..."*)

### Węzeł `[44]`
Mówca: **Narrator**
> "With a nod from Captain Gordion, two of his guardsmen lifted the man to his feet and escorted him away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "Sal and I continued towards the archsanctuary's entrance."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "Sal and I continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Sal Ignacius: ""I humbly apologize for the interruption, Your Majesty.""*)

### Węzeł `[46]`
Mówca: **Sal Ignacius**
> ""I humbly apologize for the interruption, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "IntruderTakenAway"*)

### Węzeł `[47]`
Mówca: **Sal Ignacius**
> "“Shall we proceed?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player_Romus: "“Lead the way.”"*)
  - -> `[49]` (*Player_Romus: "“Yes. The sooner we get this over with, the better.”"*)
  - -> `[50]` (*Player_Romus: "“How could I say no?""*)
  - -> `[51]` (*Player_Romus: ""Just point me in the right direction.""*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Lead the way.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "We continued towards the archsanctuary's entrance."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Yes. The sooner we get this over with, the better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "We continued towards the archsanctuary's entrance."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“How could I say no?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "We continued towards the archsanctuary's entrance."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just point me in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Narrator: "We continued towards the archsanctuary's entrance."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "I accompanied Sal into the archsanctuary. Titus and one of his men stood guard at the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Our footsteps echoed throughout the massive empty chamber as we made our way down the main aisle that separated the hall in two."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "I was surrounded by ornate wall murals of religious scene..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "I was surrounded by ornate wall murals of religious scene depictions, leaving no surface bare. Nearby statues seemed to watch me as I passed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[678]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[58]` (*Player_Romus: "“One could get lost in a place like this.”"*)
  - -> `[59]` (*Player_Romus: "“All spectacle. No sustenance.”"*)
  - -> `[57]` (*Player_Romus: "“I remember the archsanctuary being a lot bigger.”"*)

### Węzeł `[55]`
Mówca: **Sal Ignacius**
> "“It’s only fitting that such a monument be built atop the final resting place of Rizia's most revered disciple.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Sal Ignacius: ""Caelus the Devout. Singlehandedly credited for spreading..."*)

### Węzeł `[56]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“This place never fails to impress.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Sal Ignacius: ""Indeed it does. I've been here more times than I can rem..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I remember the archsanctuary being a lot bigger.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Sal Ignacius: ""That's because you used to be a lot smaller. Memories of..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“One could get lost in a place like this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Sal Ignacius: ""I have. More than once.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“All spectacle. No sustenance.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 1;"*)

### Węzeł `[60]`
Mówca: **Sal Ignacius**
> ""Some might say that spiritual sustenance comes from within.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Sal Ignacius: ""However, there are those who need a little spectacle to ..."*)

### Węzeł `[61]`
Mówca: **Sal Ignacius**
> ""Caelus the Devout. Singlehandedly credited for spreading the teachings of St. Wruhec throughout our part of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[841]` (*Player_Romus: "“He got all this just for *teaching*? My own final restin..."*)
  - -> `[62]` (*Player_Romus: "“I’m not here for a history lesson. Let’s get down to bus..."*)
  - -> `[63]` (*Player_Romus: ""As a great admirer of his, I've always aspired to lead a..."*)
  - -> `[65]` (*Player_Romus: "“Yes, yes. I know all about him. But he’s not the reason ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’m not here for a history lesson. Let’s get down to business.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Sal Ignacius: ""If you insist.""*)

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As a great admirer of his, I've always aspired to lead a life of devotion and virtue, much like his own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[978]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[64]`
Mówca: **Sal Ignacius**
> ""If you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We stopped when we'd reached the chancel where the altar ..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Yes, yes. I know all about him. But he’s not the reason why I’m here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Sal Ignacius: ""Without him, we Rizians would be no more enlightened tha..."*)

### Węzeł `[66]`
Mówca: **Sal Ignacius**
> ""It warms my heart to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We stopped when we'd reached the chancel where the altar ..."*)

### Węzeł `[67]`
Mówca: **Sal Ignacius**
> ""Without him, we Rizians would be no more enlightened than Dastnurists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We stopped when we'd reached the chancel where the altar ..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "We stopped when we'd reached the chancel where the altar stood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[681]` (*Narrator: "Sal gestured over our heads to the second-floor gallery o..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as you are Grand Wiseman, I'm sure those values will persevere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[717]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[718]` (*Sal Ignacius: ""That's very kind, Your Majesty.""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Dastnurists are particularly concerning. Their religion disregards the centuries of progress since Descension Day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[717]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Sal Ignacius: ""Indeed, Your Majesty.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Golcondists pose a particularly large threat, using Wruhecism as a cover for blasphemy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[717]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Sal Ignacius: ""That is of course worrying, Your Majesty.""*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't call it 'diluted.' Supporting a plurality of religions will only enrich Rizian culture.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[717]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Sal Ignacius: ""But we must not lose sight of our one true faith.""*)

### Węzeł `[73]`
Mówca: **Sal Ignacius**
> ""But we must not lose sight of our one true faith.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "He stopped pacing and looked around the hall."*)

### Węzeł `[74]`
Mówca: **Sal Ignacius**
> ""However, he was also deluged with requests from the Dastnurist community. In particular, the Grandsanctuary of Sallabes has long been too small to serve worshippers' needs and is urgently in need of expansion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[886]` (*Sal Ignacius: ""Afraid of angering one religious group by prioritizing t..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Why is it the government's responsibility to fund sanctuaries? Couldn't Rizia's religious congregations pay for their own repairs and expansions?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false`
- **Kontekst wejściowy (poprzednik):** `[886]` (Sal Ignacius), `[888]` (Sal Ignacius), `[958]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[952]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues = true"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't he just fund both projects?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false`
- **Kontekst wejściowy (poprzednik):** `[886]` (Sal Ignacius), `[888]` (Sal Ignacius), `[958]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[966]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Budget = true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We will begin the restoration of Plavo at once." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""We will begin the restoration of Plavo at once.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Narrator: "The Grand Wiseman clapped his hands together."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Both projects are equally important in my eyes. I will speak to Elena about funding both the Plavo restoration and the Sallabes Grandsanctuary expansion.” [-4 Budget]"]** — Mówca: **Player_Romus**
> ""Both projects are equally important in my eyes. I will speak to Elena about funding both the Plavo restoration and the Sallabes Grandsanctuary expansion.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "The holy man let out a small gasp."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Serving the Dastnurist community should take priority at this time. I will grant the Archpriest of Sallabes' request." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Serving the Dastnurist community should take priority at this time. I will grant the Archpriest of Sallabes' request.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "The Grand Wiseman nodded solemnly."*)

### Węzeł `[80]`
Mówca: **Sal Ignacius**
> "“I see the wisdom in your decision. May God’s shining light forever guide you even through the darkest times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary")..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "The Grand Wiseman nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Sal Ignacius: "“I see the wisdom in your decision. May God’s shining lig..."*)

### Węzeł `[82]`
Mówca: **Sal Ignacius**
> ""Nur be praised!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary")..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "The holy man let out a small gasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Sal Ignacius: ""Nur be praised!""*)

### Węzeł `[84]`
Mówca: **Narrator**
> "Sal spread his arms wide open."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Sal Ignacius: "“With great honor, I shall lead you as you step across th..."*)

### Węzeł `[85]`
Mówca: **Sal Ignacius**
> "“With great honor, I shall lead you as you step across the threshold and unite with the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He motioned toward a stone archway leading out of the cha..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He motioned toward a stone archway leading out of the chamber."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Węzeł Logiki Narracyjnej: "IFollowedtheWiscerer"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "I followed the Grand Wiseman down a long corridor."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Narrator: "We eventually reached an imposing iron door. Behind it wa..."*)

### Węzeł `[88]`
Mówca: **Sal Ignacius**
> ""This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "I continued after him as we went down the stairs, which s..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "I continued after him as we went down the stairs, which seemed to go on forever."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Before long, we'd reached the bottom, where I was greeted..."*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Before long, we'd reached the bottom, where I was greeted by a wall of human bones that were carefully stacked from top to bottom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Narrator: "In an adjacent room, there were several tombs, each adorn..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I had no idea this was down here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Sal Ignacius: ""Most don’t.""*)

### Węzeł `[92]`
Mówca: **Sal Ignacius**
> ""Most don’t.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""As for the tomb's tenants, they're mostly wealthy noblem..."*)

### Węzeł `[93]`
Mówca: **Sal Ignacius**
> ""As for the tomb's tenants, they're mostly wealthy noblemen and their families alongside other well-to-do individuals throughout the centuries.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""Fascinating. I'd love to hear more about them.""*)
  - -> `[450]` (*Player_Romus: ""No time to bother with corpses. We've got a ceremony to ..."*)

### Węzeł `[94]`
Mówca: **Sal Ignacius**
> ""This way, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "DownTunnelHub"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "As we made our way down the tunnel, the ceiling began to close in around us, and feelings of claustrophobia began to sink in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Just when it seemed like the tunnel would never end, we e..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Just when it seemed like the tunnel would never end, we emerged into a vast cavern, also illuminated by torchlight. Several wiscerers, lesser in rank than Sal, were waiting for us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Narrator: "At the heart of the room stood a circle of six columns, e..."*)

### Węzeł `[97]`
Mówca: **Narrator**
> "They were arranged around a marble sarcophagus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Player_Romus: ""I know where we are.""*)
  - -> `[98]` (*Player_Romus: "“Is that who I think it is?""*)
  - -> `[639]` (*Player_Romus: ""Who's in the coffin?""*)
  - -> `[729]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Is that who I think it is?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Sal Ignacius: ""Indeed, Your Majesty. This is the tomb of Caelus the Dev..."*)

### Węzeł `[99]`
Mówca: **Sal Ignacius**
> ""Rare are those who have set foot here. Count yourself among the blessed few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "Caelus the Devout's effigy became more apparent as I appr..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "Caelus the Devout's effigy became more apparent as I approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Narrator: "Sal placed his torch into a nearby sconce as one of the o..."*)

### Węzeł `[101]`
Mówca: **Narrator**
> "Sal placed his torch into a nearby sconce as one of the other wisemen, carrying a silver tray, approached us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "On it was a golden chalice, a clay jug filled with oil, a..."*)

### Węzeł `[102]`
Mówca: **Narrator**
> "On it was a golden chalice, a clay jug filled with oil, a sponge, and what appeared to be a bottle of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Sal Ignacius: "“Let us begin. Please remove your clothes and stand on th..."*)

### Węzeł `[103]`
Mówca: **Sal Ignacius**
> "“Let us begin. Please remove your clothes and stand on the royal seal.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player_Romus: "“I am ready.”"*)
  - -> `[105]` (*Player_Romus: ""Whatever you say.""*)
  - -> `[106]` (*Player_Romus: "“Actually... I'm beginning to have second thoughts.""*)
  - -> `[249]` (*Player_Romus: ""I'm sorry, but I can't. This is too much.""*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I am ready.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "Ceremony"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "Ceremony"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Actually... I'm beginning to have second thoughts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Sal Ignacius: ""'Second thoughts?' But you have to go through with it!""*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Following the Grand Wiseman's instructions, I joined him in reciting verses from the sacred scripture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[732]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "When my garments were completely removed, Sal proceeded to anoint me, dipping a sponge into the fragrant oil and gently applying it all over my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[802]` (*Narrator: "After my flesh was fully coated, he set aside the jug and..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "He then poured the wine into the chalice until it reached the brim."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Sal Ignacius: "“It is well known that this is the final resting place of..."*)

### Węzeł `[110]`
Mówca: **Sal Ignacius**
> "“It is well known that this is the final resting place of Caelus the Devout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Sal Ignacius: ""But what most don’t know is that this is where he perfor..."*)

### Węzeł `[111]`
Mówca: **Sal Ignacius**
> ""But what most don’t know is that this is where he performed his first miracle.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player_Romus: "“Miracle? Did I hear you correctly?”"*)
  - -> `[847]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Miracle? Did I hear you correctly?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Sal Ignacius: "“Yes. The miracle of foresight.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I’ve never heard of disciples performing miracles before.”"
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Sal Ignacius: "“Yes. The miracle of foresight.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“I have gone along with you thus far. But are you really saying something supernatural happened here?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[111]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Sal Ignacius: "“Yes. The miracle of foresight.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Even as a religious man, I have trouble believing in miracles.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[111]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[852]` (*Sal Ignacius: "“I refer to the miracle of foresight.""*)

### Węzeł `[116]`
Mówca: **Sal Ignacius**
> "“Yes. The miracle of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Sal Ignacius: ""For upon filling his stomach with the sacred wine -- the..."*)

### Węzeł `[117]`
Mówca: **Sal Ignacius**
> ""For upon filling his stomach with the sacred wine -- the very wine before you now -- he was given the ability to prophesy the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "He poured the wine into the chalice and held it high."*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What can I expect to see?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Sal Ignacius: ""You will see nothing. Only the most pious and reverent m..."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "He poured the wine into the chalice and held it high."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[766]` (*Player_Romus: ""But I'm not thirsty.""*)
  - -> `[118]` (*Player_Romus: ""What can I expect to see?""*)

### Węzeł `[120]`
Mówca: **Sal Ignacius**
> ""You will see nothing. Only the most pious and reverent men may drink from the sacred chalice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)

### Węzeł `[121]`
Mówca: **Sal Ignacius**
> ""You see, once this wine is consumed, Caelus the Devout's gift of foresight shall, for a time, be bestowed upon the person who ingests it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[853]` (*Sal Ignacius: ""I have spent the past weeks cloistered here, fasting and..."*)

### Węzeł `[122]`
Mówca: **Narrator**
> "He held up the chalice, once more, and drank until the wine was gone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "Setting it back down on the tray, he then stepped toward ..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "Setting it back down on the tray, he then stepped toward me and held out his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player_Romus_Italic: "Take his hands."*)
  - -> `[132]` (*Player_Romus_Italic: "Retract your hands."*)
  - -> `[131]` (*Player_Romus_Italic: "Step back."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "We stood there in silence for what felt like an eternity. I wasn't sure what to expect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Stress", "R_Stress_Loop");"*)

### Węzeł `[125]`
Mówca: **Narrator**
> "But then suddenly, his body began to tremble and his hands took a firm grip in mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "I couldn't let go even if I wanted."*)

### Węzeł `[126]`
Mówca: **Sal Ignacius**
> ""Listen closely to my words. For the gift of sight comes in flashes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "He closed his eyes and began taking in long deep breaths."*)

### Węzeł `[127]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Romus_Italic**
> "I closed my eyes as well."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "We stood there in silence for what felt like an eternity...."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: "Leave eyes open."]** — Mówca: **Player_Romus_Italic**
> "I kept my eyes open, waiting to see what would happen next."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen = true;"*)

### Węzeł `[129]`
**[WYBÓR GRACZA: "Look around you."]** — Mówca: **Player_Romus_Italic**
> "Scanning the room, I watched as the other priests looked on, waiting to see what would happen next."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[807]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen = true;"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Take his hands."]** — Mówca: **Player_Romus_Italic**
> "I placed my hands in his."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Sal Ignacius: ""Listen closely to my words. For the gift of sight comes ..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "Step back."]** — Mówca: **Player_Romus_Italic**
> "I took a step back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""What are you doing?""*)
  - -> `[568]` (*Player_Romus: ""Kindly keep your distance.""*)
  - -> `[569]` (*Player_Romus: ""What's going on?""*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "Retract your hands."]** — Mówca: **Player_Romus_Italic**
> "I pulled my hands away from him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""What are you doing?""*)
  - -> `[565]` (*Player_Romus: ""Why do you need my hands?""*)
  - -> `[566]` (*Player_Romus: ""What's this about?""*)
  - -> `[568]` (*Player_Romus: ""Kindly keep your distance.""*)

### Węzeł `[133]`
Mówca: **Sal Ignacius**
> ""To consummate the Consecration of the King I must insist that you take my hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""Very well, then.""*)
  - -> `[135]` (*Player_Romus: ""Nobody told me there would be prophecies. I cannot gover..."*)
  - -> `[772]` (*Player_Romus: ""This ceremony has exceeded the limits of reason. I canno..."*)
  - -> `[136]` (*Player_Romus: ""And *I* must insist you remember who you're speaking to!""*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well, then.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Narrator: "Wary as I was, I relented and did as he requested."*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody told me there would be prophecies. I cannot govern with the burden of future events looming over me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Sal Ignacius: ""Interrupting the ritual will have long-lasting consequen..."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And *I* must insist you remember who you're speaking to!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "My outburst left the wiseman speechless. Seemingly shocke..."*)

### Węzeł `[137]`
Mówca: **Sal Ignacius**
> ""I must insist that you take my hand, or else I cannot bestow my consent on the ceremony's completion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Player_Romus: ""You're right. Please continue.""*)
  - -> `[546]` (*Player_Romus: ""Fine. The sooner we get this over with the better.""*)
  - -> `[548]` (*Player_Romus: ""Then I sincerely hope you can find it in your heart to f..."*)
  - -> `[549]` (*Player_Romus: ""Then I'll be sure to keep that in mind if ever you shoul..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "I quickly put on my clothes and made my way back through the catacombs until I'd reached the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "Titus and another guardsman were at my side the moment they saw me re-emerge."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "IsEverythingAlright"*)

### Węzeł `[140]`
Mówca: **Titus Gordion**
> ""Your Majesty, is everything alright?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Player_Romus: ""That's none of your concern. We're leaving.""*)
  - -> `[142]` (*Player_Romus: ""Yes. We just have to go.""*)
  - -> `[143]` (*Player_Romus_Italic: "Ignore him."*)
  - -> `[144]` (*Player_Romus: ""Get out of my way, Captain. Do you want to be demoted to..."*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern. We're leaving.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. We just have to go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Before long, my motorcade was back on the road."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Romus_Italic**
> "I barreled past him without saying a word."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Get out of my way, Captain. Do you want to be demoted to private?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[145]`
Mówca: **Narrator**
> "I thought about the Grand Wiseman's last words to me as the Archsanctuary of Plavo faded from view."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Before long, my motorcade was back on the road."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[147]`
Mówca: **Narrator**
> "By the time I'd made it back to the car, the captain was so far behind, I ended up opening the door myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "I barely noticed when the motorcade pulled out of the cit..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "I barely noticed when the motorcade pulled out of the city and back onto the highway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "I thought about the Grand Wiseman's last words to me as t..."*)

### Węzeł `[149]`
Mówca: **Narrator**
> "I couldn't let go even if I wanted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Sal Ignacius: ""I see a crown. It's ascending into the sky... rising hig..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "My outburst left the wiseman speechless. Seemingly shocked, he bowed his head and backed away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[773]` (*Sal Ignacius: ""This not a promising start to your reign.""*)

### Węzeł `[151]`
Mówca: **Narrator**
> "At his advanced age, he wasn't exactly spry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Sal Ignacius: ""Are you alright, Your Majesty?""*)

### Węzeł `[152]`
Mówca: **Sal Ignacius**
> ""Are you alright, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Player_Romus: ""I should be the one asking you.""*)
  - -> `[156]` (*Player_Romus: ""I'm fine. Thank you.""*)
  - -> `[154]` (*Player_Romus: ""That's none of your concern.""*)
  - -> `[155]` (*Player_Romus: ""As best as one can be, given the situation.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I should be the one asking you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Sal Ignacius: ""Oh, I may have some years on me, but I'm not dead yet.""*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's none of your concern.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Sal Ignacius: ""Very well, then.""*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As best as one can be, given the situation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Sal Ignacius: ""I hope I'm not overstepping my bounds. But it was a situ..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm fine. Thank you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[152]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Sal Ignacius: ""Can't say the same for myself. These old bones don't mov..."*)

### Węzeł `[157]`
Mówca: **Sal Ignacius**
> ""Very well, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: "“Shall we proceed?”"*)

### Węzeł `[158]`
Mówca: **Sal Ignacius**
> ""I hope I'm not overstepping my bounds. But it was a situation that, unfortunately, should never have happened in the first place--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Sal Ignacius: ""With all due respect to the Golden Guard.""*)

### Węzeł `[159]`
Mówca: **Sal Ignacius**
> ""Can't say the same for myself. These old bones don't move as quickly as they used to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: "“Shall we proceed?”"*)

### Węzeł `[160]`
Mówca: **Sal Ignacius**
> ""Oh, I may have some years on me, but I'm not dead yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: "“Shall we proceed?”"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be the judge of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Sal Ignacius: ""As the Lord's representative on earth, I expect nothing ..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "He closed his eyes and began taking in long deep breaths."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Player_Romus_Italic: "Close your eyes."*)
  - -> `[128]` (*Player_Romus_Italic: "Leave eyes open."*)
  - -> `[129]` (*Player_Romus_Italic: "Look around you."*)

### Węzeł `[163]`
Mówca: **Sal Ignacius**
> ""I see a crown. It's ascending into the sky... rising high above the surrounding countryside--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player_Romus: ""Whose crown?""*)
  - -> `[252]` (*Player_Romus: ""What does that mean?""*)
  - -> `[253]` (*Player_Romus: ""Is that all?""*)
  - -> `[1001]` (*Player_Romus_Italic: "Nod."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know this may seem highly unorthodox, but this whole secret ceremony just doesn't sit well with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Narrator: "Sal looked apoplectic."*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must break with the archaic customs of my predecessors if I am to be the ruler Rizia needs right now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Narrator: "Sal looked apoplectic."*)

### Węzeł `[166]`
Mówca: **Sal Ignacius**
> ""A sovereign leader of this great nation you’re duty-bound to uphold this sacred tradition, just as all the monarchs who came before you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Sal Ignacius: ""The crown you wear isn't just a decorative headdress, bu..."*)

### Węzeł `[167]`
Mówca: **Sal Ignacius**
> ""The crown you wear isn't just a decorative headdress, but a symbol of national identity -- of unity and pride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Sal Ignacius: ""It represents stability and steadfast continuity even th..."*)

### Węzeł `[168]`
Mówca: **Sal Ignacius**
> ""It represents stability and steadfast continuity even through the darkest of times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Player_Romus: ""What does this diatribe have anything to do with my taki..."*)
  - -> `[172]` (*Player_Romus: ""Yes, and I am grateful for the responsibility bestowed u..."*)
  - -> `[171]` (*Player_Romus: ""I'm well aware of what the crown represents. Please get ..."*)
  - -> `[980]` (*Player_Romus: ""My mind is made up. Goodbye.""*)
  - -> `[173]` (*Player_Romus_Italic: "Stay silent and listen."*)

### Węzeł `[169]`
Mówca: **Sal Ignacius**
> ""My point is that you not only embody a kingdom on earth, but the kingdom above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Sal Ignacius: ""For to reject the sacrament is to reject God himself.""*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does this diatribe have anything to do with my taking part in the ceremony?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Sal Ignacius: ""Everything.""*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm well aware of what the crown represents. Please get to the point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Sal Ignacius: ""My point is that you not only embody a kingdom on earth,..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I am grateful for the responsibility bestowed upon me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Sal Ignacius: ""And I, for one, am grateful for having you as our king. ..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: "Stay silent and listen."]** — Mówca: **Player_Romus_Italic**
> "I refrained from speaking to hear him out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Sal Ignacius: ""What I'm trying to say is...""*)

### Węzeł `[174]`
Mówca: **Sal Ignacius**
> ""Everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Sal Ignacius: ""You not only embody a kingdom on earth, but the kingdom ..."*)

### Węzeł `[175]`
Mówca: **Sal Ignacius**
> ""You not only embody a kingdom on earth, but the kingdom above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Sal Ignacius: ""For to reject the sacrament is to reject God himself.""*)

### Węzeł `[176]`
Mówca: **Sal Ignacius**
> ""What I'm trying to say is...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Sal Ignacius: ""You not only embody a kingdom on earth, but the kingdom ..."*)

### Węzeł `[177]`
Mówca: **Sal Ignacius**
> ""And I, for one, am grateful for having you as our king. As are the millions of subjects under your rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Sal Ignacius: ""You not only embody a kingdom on earth, but the kingdom ..."*)

### Węzeł `[178]`
Mówca: **Sal Ignacius**
> ""For to reject the sacrament is to reject God himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player_Romus: ""You're right. Please forgive me. The crown's weight is h..."*)
  - -> `[179]` (*Player_Romus: ""By that logic, a challenge to your King is a challenge t..."*)
  - -> `[182]` (*Player_Romus: ""Are you finished?""*)
  - -> `[181]` (*Player_Romus: ""Religion's place in society is without question. But as ..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""By that logic, a challenge to your King is a challenge to the Almighty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "The wiscerer went silent. Though he outwardly remained ca..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please forgive me. The crown's weight is heavy, and only with God's guidance can I fulfill my duties.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[646]` (*Sal Ignacius: ""Splendid! Then let us proceed.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion's place in society is without question. But as for its role in government... I have reservations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Sal Ignacius: ""Wruhecism and the Rizian monarchy are one and the same. ..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you finished?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "The wiscerer went silent. Though he outwardly remained ca..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ceremony]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "Ceremony"*)

### Węzeł `[184]`
Mówca: **Narrator**
> "The wiscerer went silent. Though he outwardly remained calm, the disdain in his eyes told a different story."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Sal Ignacius: ""If I may give you a piece of advice...""*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm glad you brought this to my attention, but I'd rather not make an immediate decision. I'll think it over once I'm back at the Palace.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "The Grand Wiseman nodded solemnly."*)

### Węzeł `[186]`
Mówca: **Sal Ignacius**
> ""With all due respect to the Golden Guard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Sal Ignacius: "“Shall we proceed?”"*)

### Węzeł `[187]`
Mówca: **Sal Ignacius**
> ""Wruhecism and the Rizian monarchy are one and the same. It has been that way since the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Sal Ignacius: ""This kingdom has been blessed for a reason. Any change t..."*)

### Węzeł `[188]`
Mówca: **Sal Ignacius**
> ""This kingdom has been blessed for a reason. Any change to the status quo will surely jeopardize our prosperity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player_Romus: ""Religion and state should be separate. End of story.""*)
  - -> `[191]` (*Player_Romus: ""I believe my position on this issue is unlikely to chang..."*)
  - -> `[189]` (*Player_Romus: ""You make a valid point. I'm still not fully sold on reli..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You make a valid point. I'm still not fully sold on religion's role in government, however, I know better than to upset that delicate balance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Sal Ignacius: ""Does this mean you'll go through with the consecration?""*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religion and state should be separate. End of story.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[823]` (*Player_Romus: ""Now if you'll excuse me, I'll see myself out.""*)
  - -> `[822]` (*Player_Romus: ""I hope I've made myself clear.""*)
  - -> `[821]` (*Player_Romus: ""Unless you're aiming for a medieval revival of the Dark ..."*)
  - -> `[854]` (*Player_Romus: ""Having said that... can't you overlook my abstention? I ..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I believe my position on this issue is unlikely to change. But I see no obstacle to finding common ground if the opportunity arises.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Sal Ignacius: ""So you'll go through with the ceremony?""*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [IsEverythingAlright]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "IsEverythingAlright"*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Sal gasped in astonishment as I made an about-face and headed back towards the catacombs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[790]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "I could still smell the "holy oil" permeating off of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "I thought about the Grand Wiseman's last words to me as t..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I could still smell the "holy oil" permeating off of me."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "I thought about the Grand Wiseman's last words to me as t..."*)

### Węzeł `[198]`
Mówca: **Sal Ignacius**
> ""Does this mean you'll go through with the consecration?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""Yes, I will.""*)
  - -> `[199]` (*Player_Romus: ""If that's what it takes to get your blessing, then yes.""*)
  - -> `[350]` (*Player_Romus: ""Yes, though I still have reservations.""*)
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "Abstension_hub"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that's what it takes to get your blessing, then yes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Sal Ignacius), `[349]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Sal Ignacius: ""Then please, let us proceed.""*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo as well as the Dastnurist Grand Sanctuary, perhaps we can overlook my abstention?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Kontekst wejściowy (poprzednik):** `[198]` (Sal Ignacius), `[349]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Sal Ignacius: ""The importance of the ceremony cannot be overstated.""*)

### Węzeł `[201]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Dastnurist Grand Sanctuary, perhaps we can overlook my abstention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[856]` (*Sal Ignacius: ""You prioritized it over Plavo's restoration, despite my ..."*)

### Węzeł `[202]`
Mówca: **Sal Ignacius**
> ""The importance of the ceremony cannot be overstated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[825]` (*Sal Ignacius: ""But in light of your generous support, I see no reason w..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Proje..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""No, but since I did agree to reallocate funds toward the..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true && RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Proj..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Player_Romus: ""No, but since I did agree to reallocate funds toward the..."*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Player_Romus: ""No, I haven't changed my mind about that. However... per..."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, but since I did agree to reallocate funds toward the Archsanctuary of Plavo, perhaps we can overlook my abstention?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true` AND `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true  and  Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[198]` (Sal Ignacius), `[349]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Sal Ignacius: ""The importance of the ceremony cannot be overstated.""*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Proje..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""No, but since I did agree to reallocate funds toward the..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see no reason why not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Sal Ignacius: ""Excellent. I look forward to a prosperous relationship i..."*)

### Węzeł `[214]`
Mówca: **Sal Ignacius**
> ""As long as similar... *arrangements* can be made in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Player_Romus: ""No promises, but my door is always open to further discu..."*)
  - -> `[213]` (*Player_Romus: ""I see no reason why not.""*)
  - -> `[216]` (*Player_Romus: ""This was a one-time agreement. Be grateful you got any c..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No promises, but my door is always open to further discussions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Sal Ignacius: ""Very good, Your Majesty.""*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This was a one-time agreement. Be grateful you got any concessions at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Sal Ignacius: ""Very well then. I will, of course, remain hopeful that y..."*)

### Węzeł `[217]`
Mówca: **Sal Ignacius**
> ""Excellent. I look forward to a prosperous relationship in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "I wished Wiseman Ignacius goodbye and left the premises. Captain Gordion and his men followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[219]`
Mówca: **Narrator**
> "As my motorcade traveled down the highway, and the Archsacturary of Plavo faded from view, I reflected on all I had accomplished today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "And hoped my future relationship with the wiscerer would ..."*)

### Węzeł `[220]`
Mówca: **Narrator**
> "And hoped my future relationship with the wiscerer would remain amicable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[221]`
Mówca: **Sal Ignacius**
> ""Very well then. I will, of course, remain hopeful that you'll have a change of heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[222]`
Mówca: **Narrator**
> "I bid Wiseman Ignacius farewell and departed the premises, with Captain Gordion and his men following closely behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[223]`
Mówca: **Narrator**
> "As my motorcade journeyed down the highway, the Archsacturary of Plavo slowly disappearing from sight, I reflected on all I had achieved today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Narrator: "The wiscerer knew his place now. I just hoped he wouldn't..."*)

### Węzeł `[224]`
Mówca: **Narrator**
> "The wiscerer knew his place now. I just hoped he wouldn't need friendly *reminders* in the future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[225]`
Mówca: **Sal Ignacius**
> ""Then please, let us proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[846]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ceremony]"*)

### Węzeł `[226]`
Mówca: **Sal Ignacius**
> ""If I may give you a piece of advice...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""You may.""*)
  - -> `[228]` (*Player_Romus: ""You may not. Good day.""*)
  - -> `[229]` (*Player_Romus: ""Fine. But hurry it up. I haven't got all day.""*)
  - -> `[230]` (*Player_Romus: ""Go ahead.""*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Sal Ignacius: ""The throne you have inherited bestows great advantages, ..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You may not. Good day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But hurry it up. I haven't got all day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Sal Ignacius: ""The throne you have inherited bestows great advantages, ..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go ahead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[226]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Sal Ignacius: ""The throne you have inherited bestows great advantages, ..."*)

### Węzeł `[231]`
Mówca: **Sal Ignacius**
> ""The throne you have inherited bestows great advantages, yet it also brings forth numerous adversities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[820]` (*Sal Ignacius: ""More often than not, friends and foes are indistinguisha..."*)

### Węzeł `[232]`
Mówca: **Sal Ignacius**
> ""It would be a shame if any unnecessary strains or hostilities were added to your troubles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Player_Romus: ""Is that a threat?""*)
  - -> `[234]` (*Player_Romus: ""And if I may give *you* a piece of advice... the door sw..."*)
  - -> `[235]` (*Player_Romus: ""You forget your place, Grand Wiseman. The onus lies not ..."*)
  - -> `[236]` (*Player_Romus: ""Duly noted. I will take my leave. Good day.""*)

### Węzeł `[233]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that a threat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Sal Ignacius: ""Heavens no! I'm simply saying... tread carefully.""*)

### Węzeł `[234]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I may give *you* a piece of advice... the door swings both ways.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You forget your place, Grand Wiseman. The onus lies not on the king to seek favor with others, but rather, it is others who should seek favor with the king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Duly noted. I will take my leave. Good day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""Heavens no! I'm simply saying... tread carefully.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. Let's proceed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[310]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Titus Gordion: ""Right away, sir.""*)

### Węzeł `[239]`
Mówca: **Sal Ignacius**
> ""Well, in any case, I'm glad you're here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Sal Ignacius: ""I shall do my best to provide you with both personal and..."*)

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""Don't let my physical frailty fool you, Your Majesty. For the grace of God gives me unimaginable strength.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""I'll be the judge of that.""*)
  - -> `[242]` (*Player_Romus: ""As he does with me.""*)
  - -> `[241]` (*Player_Romus: ""Good. That's what I like to hear.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. That's what I like to hear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As he does with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Sal Ignacius: ""It pleases me to hear it.""*)

### Węzeł `[243]`
Mówca: **Titus Gordion**
> ""With pleasure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus += 1;"*)

### Węzeł `[244]`
Mówca: **Sal Ignacius**
> ""What?! But my king, you must.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""No. No, I don't.""*)
  - -> `[246]` (*Player_Romus: ""My most sincere apologies.""*)
  - -> `[247]` (*Player_Romus: ""I mean no offense.""*)
  - -> `[248]` (*Player_Romus: ""I'm not going to repeat myself.""*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. No, I don't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Sal Ignacius), `[353]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "Jump to: [Refuse Ceremony]"*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My most sincere apologies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Sal Ignacius), `[353]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "Jump to: [Refuse Ceremony]"*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I mean no offense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Sal Ignacius), `[353]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "Jump to: [Refuse Ceremony]"*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to repeat myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[244]` (Sal Ignacius), `[353]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[741]` (*Węzeł Logiki Narracyjnej: "Jump to: [Refuse Ceremony]"*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry, but I can't. This is too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Sal Ignacius: ""What?! But my king, you must.""*)

### Węzeł `[250]`
Mówca: **Sal Ignacius**
> ""And on the crown is a fracture on the golden band...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Sal Ignacius: ""The higher it journeys upward, the larger the crack gets.""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whose crown?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Sal Ignacius: ""Please don't interrupt, Your Majesty.""*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What does that mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Sal Ignacius: ""Please don't interrupt, Your Majesty.""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Sal Ignacius: ""Please don't interrupt, Your Majesty.""*)

### Węzeł `[254]`
Mówca: **Sal Ignacius**
> ""Please don't interrupt, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Sal Ignacius: ""And on the crown is a fracture on the golden band...""*)

### Węzeł `[255]`
Mówca: **Sal Ignacius**
> ""The higher it journeys upward, the larger the crack gets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Sal Ignacius: ""Whether or not it can be mended is uncertain.""*)

### Węzeł `[256]`
Mówca: **Sal Ignacius**
> ""Whether or not it can be mended is uncertain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Player_Romus: ""As in it can be fixed?""*)
  - -> `[257]` (*Player_Romus: ""I don't understand.""*)
  - -> `[259]` (*Player_Romus: ""What do you mean it's uncertain?""*)
  - -> `[1002]` (*Player_Romus_Italic: "Gesture for him to keep going."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Sal Ignacius: ""The visions are possible outcomes of what could come to ..."*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in it can be fixed?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Sal Ignacius: ""The visions are possible outcomes of what could come to ..."*)

### Węzeł `[259]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean it's uncertain?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Sal Ignacius: ""The visions are possible outcomes of what could come to ..."*)

### Węzeł `[260]`
Mówca: **Sal Ignacius**
> ""The visions are possible outcomes of what could come to pass. They aren't set in stone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Player_Romus: ""What else do you see?""*)
  - -> `[263]` (*Player_Romus: ""Is that all?""*)
  - -> `[264]` (*Player_Romus: ""Go on.""*)
  - -> `[265]` (*Player_Romus: ""Okay, I'm listening...""*)

### Węzeł `[261]`
Mówca: **Narrator**
> "His grip tightened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Sal Ignacius: ""I now see soldiers... Many soldiers... War... And death...."*)

### Węzeł `[262]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What else do you see?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His grip tightened."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that all?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His grip tightened."*)

### Węzeł `[264]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His grip tightened."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Okay, I'm listening...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His grip tightened."*)

### Węzeł `[266]`
Mówca: **Sal Ignacius**
> ""I now see soldiers... Many soldiers... War... And death. So much death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "VisionHub1"*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""War with whom?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Sal Ignacius), `[270]` (Sal Ignacius), `[359]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Sal Ignacius: ""A most vicious foe. More than that, I cannot say.""*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whose soldiers? Are they ours?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Sal Ignacius), `[270]` (Sal Ignacius), `[359]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Sal Ignacius: ""One of the armies, yes. Their uniforms carry the royal s..."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the victor?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false`
- **Kontekst wejściowy (poprzednik):** `[266]` (Sal Ignacius), `[270]` (Sal Ignacius), `[359]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Sal Ignacius: ""I can not tell.""*)

### Węzeł `[270]`
Mówca: **Sal Ignacius**
> ""I can not tell.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor = ..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "I continued to listen closely to his words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Sal Ignacius: ""I now see two individuals... They are embraced in each o..."*)

### Węzeł `[272]`
Mówca: **Sal Ignacius**
> ""I now see two individuals... They are embraced in each other's arms... Lovers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Sal Ignacius: ""They are surrounded by people both for and against their..."*)

### Węzeł `[273]`
Mówca: **Sal Ignacius**
> ""Before me now is a heart... it's being stabbed by a sword.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Player_Romus: ""The death of a lover, perhaps?""*)
  - -> `[274]` (*Player_Romus: ""A metaphor for betrayal?""*)
  - -> `[276]` (*Player_Romus: ""This is starting to sound like utter nonsense.""*)
  - -> `[984]` (*Player_Romus_Italic: "Offer no reply."*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A metaphor for betrayal?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Sal Ignacius: ""Possibly.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The death of a lover, perhaps?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Sal Ignacius: ""Perhaps...""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is starting to sound like utter nonsense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Sal Ignacius: ""I can assure you, Your Grace, my visions are anything *b..."*)

### Węzeł `[277]`
Mówca: **Sal Ignacius**
> ""Now, I behold an endless sea of people stretching as far as the eye can see... They are marching toward the royal palace... in joy or anger... I can not say for sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Sal Ignacius: ""Above them are birds... tens of thousands of them so thi..."*)

### Węzeł `[278]`
Mówca: **Sal Ignacius**
> ""Above them are birds... tens of thousands of them so thick they blacken the sky... They are migrating from distant lands and making their nest in ours...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""The birds clearly represent Golcondists coming to our la..."*)
  - -> `[279]` (*Player_Romus: ""It's obvious that the birds represent Wehzek Dastnurists..."*)
  - -> `[281]` (*Player_Romus: ""It sounds to me like they represent literal birds.""*)
  - -> `[985]` (*Player_Romus_Italic: "Don't speak."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's obvious that the birds represent Wehzek Dastnurists coming to our lands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The birds clearly represent Golcondists coming to our lands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It sounds to me like they represent literal birds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)

### Węzeł `[282]`
Mówca: **Sal Ignacius**
> ""And on a nearby mountain overlooking the city sits a beast... a beast with three heads. Each head is fighting with the other...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Sal Ignacius: ""They must be brought under control, either through tamin..."*)

### Węzeł `[283]`
Mówca: **Sal Ignacius**
> ""They must be brought under control, either through taming or severing one or more heads...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Sal Ignacius: ""...or all three will surely die.""*)

### Węzeł `[284]`
Mówca: **Sal Ignacius**
> ""...or all three will surely die.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Romus: ""Rizia's royal houses. Toras, Sazon and Azaro.""*)
  - -> `[286]` (*Player_Romus: ""As it stands, Rizian lands are ruled under three differe..."*)
  - -> `[287]` (*Player_Romus: ""Alright. I've heard enough of this bullshit. Let me go.""*)
  - -> `[987]` (*Player_Romus_Italic: "Offer no response."*)

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Rizia's royal houses. Toras, Sazon and Azaro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Sal Ignacius: ""If true, it could mean dark clouds on the horizon are fa..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As it stands, Rizian lands are ruled under three different flags... Wehlen, The Grand Duchy of Pales, and our own... That could be the meaning...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Sal Ignacius: ""It very well could.""*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Alright. I've heard enough of this bullshit. Let me go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "I felt Sal loosen his hold of me, letting go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_EyesOpen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_EyesOpen == true)"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_EyesOpen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "I opened my eyes and looked at him curiously until he fin..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_EyesOpen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "I looked at him curiously until he finally spoke."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "I opened my eyes and looked at him curiously until he finally spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Sal Ignacius: ""The visions have stopped. Thus, concluding the ceremony.""*)

### Węzeł `[293]`
Mówca: **Narrator**
> "I looked at him curiously until he finally spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Sal Ignacius: ""The visions have stopped. Thus, concluding the ceremony.""*)

### Węzeł `[294]`
Mówca: **Sal Ignacius**
> ""The visions have stopped. Thus, concluding the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Player_Romus: ""I think I understand.""*)
  - -> `[296]` (*Player_Romus: ""Wait... I have so many questions I want to ask.""*)
  - -> `[297]` (*Player_Romus: ""I'm still unsure what happened.""*)
  - -> `[302]` (*Player_Romus: ""I don't buy it.""*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Sal Ignacius: ""Good. For it's now up to you to decipher their meaning.""*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait... I have so many questions I want to ask.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Sal Ignacius: ""I don't have the answer you're looking for. It's now up ..."*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still unsure what happened.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Sal Ignacius: ""Give it time. Their meaning will come to you soon enough..."*)

### Węzeł `[298]`
Mówca: **Narrator**
> "A part of me questioned whether or not what I'd experienced was real."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[803]` (*Narrator: "If it was, did I accept the responsibility that came with..."*)

### Węzeł `[299]`
Mówca: **Sal Ignacius**
> ""I don't have the answer you're looking for. It's now up to you to decipher their meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Sal Ignacius: ""That's the gift and the curse that comes with the divine..."*)

### Węzeł `[300]`
Mówca: **Sal Ignacius**
> ""Good. For it's now up to you to decipher their meaning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Sal Ignacius: ""That's the gift and the curse that comes with the divine..."*)

### Węzeł `[301]`
Mówca: **Sal Ignacius**
> ""Give it time. Their meaning will come to you soon enough. It's up to you to decipher them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[804]` (*Sal Ignacius: ""That's the gift and the curse that comes with the divine..."*)

### Węzeł `[302]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't buy it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[294]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Sal Ignacius: ""It's not uncommon to have feelings of doubt. It's now up..."*)

### Węzeł `[303]`
Mówca: **Sal Ignacius**
> ""It's not uncommon to have feelings of doubt. It's now up to you to decipher the meaning of said visions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "After a long moment, during which he seemed to still be r..."*)

### Węzeł `[304]`
Mówca: **Narrator**
> "After a long moment, during which he seemed to still be recovering, he spoke again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[774]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious < 0"*)

### Węzeł `[305]`
Mówca: **Narrator**
> "Before long, I was back on the road again -- back to reality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Narrator: "As the Archsanctuary of Plavo faded from view, and my min..."*)

### Węzeł `[306]`
Mówca: **Narrator**
> "As the Archsanctuary of Plavo faded from view, and my mind began to settle, I thought more about the visions, and what they meant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Narrator: "And if they were real, what my next steps should be."*)

### Węzeł `[307]`
Mówca: **Sal Ignacius**
> ""Welcome to the catacombs.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: "“I had no idea this was down here.”"*)
  - -> `[541]` (*Player_Romus: ""How morbidly disturbing.""*)
  - -> `[542]` (*Player_Romus: ""Impressive, to say the least.""*)
  - -> `[543]` (*Player_Romus: ""I'm tempted to knock to see if anyone's home.""*)

### Węzeł `[308]`
Mówca: **Narrator**
> "At the heart of the room stood a circle of six columns, each bearing a single star delicately carved upon them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "They were arranged around a marble sarcophagus."*)

### Węzeł `[309]`
Mówca: **Narrator**
> "And if they were real, what my next steps should be."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn01_Ceremony_Participated = tr..."*)

### Węzeł `[310]`
Mówca: **Narrator**
> "Security guards held back a crowd of onlookers gathered along either side of the stairway leading up to the archsanctuary, where the Grand Wiseman stood."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[311]`
Mówca: **Titus Gordion**
> ""Indeed. He is a great man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Player_Romus: ""I couldn't agree more. As long as his loyalty remains st..."*)
  - -> `[327]` (*Player_Romus: ""I'm pleased to know that our opinions align.""*)
  - -> `[324]` (*Player_Romus: ""I didn't ask for your opinion.""*)
  - -> `[325]` (*Player_Romus: ""Personal commentary isn't a part of your job description.""*)

### Węzeł `[312]`
Mówca: **Titus Gordion**
> ""I think he's an inspiration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Player_Romus: ""I didn't ask for your opinion.""*)
  - -> `[325]` (*Player_Romus: ""Personal commentary isn't a part of your job description.""*)
  - -> `[330]` (*Player_Romus: ""Excuse my bluntness. I apologize if I offended you.""*)

### Węzeł `[313]`
Mówca: **Titus Gordion**
> ""Good luck, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Titus Gordion: ""Divus zaitu!""*)

### Węzeł `[314]`
Mówca: **Titus Gordion**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[315]`
Mówca: **Titus Gordion**
> ""Divus zaitu!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[865]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Religion_DivusZaitu = true;"*)

### Węzeł `[316]`
Mówca: **Narrator**
> ""Divus zaitu" was Wruhecist for "May God be with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Player_Romus: ""Please keep your religion to yourself.""*)
  - -> `[317]` (*Player_Romus: ""And with you as well.""*)
  - -> `[320]` (*Player_Romus: ""A religious man, are you? Interesting...""*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And with you as well.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[318]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please keep your religion to yourself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Titus Gordion: ""Of course. My most sincere apologies, Your Majesty.""*)

### Węzeł `[319]`
Mówca: **Titus Gordion**
> ""Of course. My most sincere apologies, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A religious man, are you? Interesting...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true )"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "It was a view I’d seen countless times, but it never fail..."*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "It was a view that inspired awe in many a Rizian, especia..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't ask for your opinion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Titus Gordion), `[312]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Titus Gordion: ""Forgive me. I meant no offense.""*)

### Węzeł `[325]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Personal commentary isn't a part of your job description.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Titus Gordion), `[312]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Titus Gordion: ""You're right. I was out of line. My apologies.""*)

### Węzeł `[326]`
Mówca: **Titus Gordion**
> ""You're right. I was out of line. My apologies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm pleased to know that our opinions align.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[328]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I couldn't agree more. As long as his loyalty remains steadfast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[311]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[329]`
Mówca: **Titus Gordion**
> ""Forgive me. I meant no offense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Excuse my bluntness. I apologize if I offended you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[312]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Titus Gordion: ""No offense taken.""*)

### Węzeł `[331]`
Mówca: **Titus Gordion**
> ""No offense taken.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Narrator: "Titus quickly exited the vehicle and opened my side door."*)

### Węzeł `[332]`
Mówca: **Sal Ignacius**
> ""You are too kind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Sal Ignacius: ""I shall do my best to provide you with both personal and..."*)

### Węzeł `[333]`
Mówca: **Sal Ignacius**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Sal Ignacius: ""Nevertheless...""*)

### Węzeł `[334]`
Mówca: **Sal Ignacius**
> ""Nevertheless...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[335]`
Mówca: **Sal Ignacius**
> ""I have no doubt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[834]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[336]`
Mówca: **Sal Ignacius**
> ""After today, it shall be you who speaks for the Divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[337]`
Mówca: **Sal Ignacius**
> ""As the Lord's representative on earth, I expect nothing less.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[338]`
Mówca: **Sal Ignacius**
> ""It pleases me to hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[339]`
Mówca: **Sal Ignacius**
> ""I have. More than once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[340]`
Mówca: **Sal Ignacius**
> ""That's because you used to be a lot smaller. Memories of you first learning to walk are as vivid in my mind as if they were yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Player_Romus: ""Don't remind me.""*)
  - -> `[344]` (*Player_Romus: ""How time flies.""*)
  - -> `[674]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)

### Węzeł `[341]`
Mówca: **Sal Ignacius**
> ""Indeed it does. I've been here more times than I can remember and still get choked up sometimes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[342]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't remind me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "I suddenly recalled how overjoyed I was to see Vina take her first steps."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[344]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How time flies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[340]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[345]`
Mówca: **Sal Ignacius**
> ""However, there are those who need a little spectacle to ignite that internal spark. This magnificent sanctuary serves that purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[346]`
Mówca: **Sal Ignacius**
> ""That is of course worrying, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "He stopped pacing and looked around the hall."*)

### Węzeł `[347]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "He stopped pacing and looked around the hall."*)

### Węzeł `[348]`
Mówca: **Sal Ignacius**
> ""I agree, Your Majesty, but King Valero was hesitant to let go of such a large sum at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[940]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)

### Węzeł `[349]`
Mówca: **Sal Ignacius**
> ""So you'll go through with the ceremony?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player_Romus: ""Yes, I will.""*)
  - -> `[199]` (*Player_Romus: ""If that's what it takes to get your blessing, then yes.""*)
  - -> `[350]` (*Player_Romus: ""Yes, though I still have reservations.""*)
  - -> `[653]` (*Węzeł Logiki Narracyjnej: "Abstension_hub"*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, though I still have reservations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Sal Ignacius), `[349]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Sal Ignacius: ""Then please, let us proceed.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Sal Ignacius), `[349]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Sal Ignacius: ""Then please, let us proceed.""*)

### Węzeł `[352]`
Mówca: **Sal Ignacius**
> ""Very good, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[353]`
Mówca: **Sal Ignacius**
> ""'Second thoughts?' But you have to go through with it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Player_Romus: ""No. No, I don't.""*)
  - -> `[246]` (*Player_Romus: ""My most sincere apologies.""*)
  - -> `[247]` (*Player_Romus: ""I mean no offense.""*)
  - -> `[248]` (*Player_Romus: ""I'm not going to repeat myself.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know where we are.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Sal Ignacius: ""Indeed, Your Majesty. This is the tomb of Caelus the Dev..."*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is the holiest of honors to be allowed here.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Sal Ignacius: ""Indeed, Your Majesty. This is the tomb of Caelus the Dev..."*)

### Węzeł `[356]`
Mówca: **Sal Ignacius**
> "“Why, Caelus the Devout, of course. The reason for this Archsanctuary's very existence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Sal Ignacius: ""Rare are those who have set foot here. Count yourself am..."*)

### Węzeł `[357]`
Mówca: **Sal Ignacius**
> ""Indeed, Your Majesty. This is the tomb of Caelus the Devout.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Sal Ignacius: ""Rare are those who have set foot here. Count yourself am..."*)

### Węzeł `[358]`
Mówca: **Sal Ignacius**
> ""A most vicious foe. More than that, I cannot say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom = t..."*)

### Węzeł `[359]`
Mówca: **Sal Ignacius**
> ""One of the armies, yes. Their uniforms carry the royal seal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers =..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `VisionHub1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ==..."*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ==..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == ..."*)
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers =..."*)
  - -> `[982]` (*Player_Romus_Italic: "Remain silent and continue listening."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ==..."*)
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ..."*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "I continued to listen closely to his words."*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ==..."*)
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor ..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""And the victor?""*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == ..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom =..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""War with whom?""*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers =..."*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers..."*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Whose soldiers? Are they ours?""*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Rel_Who_Is_The_Victor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub1]"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WhoseSoldiers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub1]"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_WarWithWhom"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[981]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub1]"*)

### Węzeł `[376]`
Mówca: **Sal Ignacius**
> ""One of them is of your blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe = true;"*)

### Węzeł `[377]`
Mówca: **Sal Ignacius**
> ""Or arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarria..."*)

### Węzeł `[378]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `VisionHub2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == t..."*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == f..."*)
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false"*)
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarria..."*)
  - -> `[983]` (*Player_Romus_Italic: "Listen without interruption."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == t..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn ==..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""Before me now is a heart... it's being stabbed by a sword.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == true ||
RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == true  or 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == f..."*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn ==..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Player_Romus: ""What kind of love?""*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Player_Romus: ""Am I one of them?""*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarria..."*)
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarr..."*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Player_Romus: ""'Union.' As in marriage?""*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub2]"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub2]"*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "Jump to: [VisionHub2]"*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [VisionHub2]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "VisionHub2"*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Union.' As in marriage?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_UnionIsItMarriage"] == false`
- **Kontekst wejściowy (poprzednik):** `[399]` (Sal Ignacius), `[396]` (Sal Ignacius), `[377]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Sal Ignacius: ""Or arrangement.""*)

### Węzeł `[396]`
Mówca: **Sal Ignacius**
> ""It's a forbidden love or one of disapproval.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn = true;"*)

### Węzeł `[397]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Am I one of them?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_IsItMe"] == false`
- **Kontekst wejściowy (poprzednik):** `[399]` (Sal Ignacius), `[396]` (Sal Ignacius), `[377]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Sal Ignacius: ""One of them is of your blood.""*)

### Węzeł `[398]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What kind of love?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_LoversGoOn"] == false`
- **Kontekst wejściowy (poprzednik):** `[399]` (Sal Ignacius), `[396]` (Sal Ignacius), `[377]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Sal Ignacius: ""It's a forbidden love or one of disapproval.""*)

### Węzeł `[399]`
Mówca: **Sal Ignacius**
> ""They are surrounded by people both for and against their union.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Węzeł Logiki Narracyjnej: "VisionHub2"*)

### Węzeł `[400]`
Mówca: **Sal Ignacius**
> ""Perhaps...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Sal Ignacius: ""Now, I behold an endless sea of people stretching as far..."*)

### Węzeł `[401]`
Mówca: **Sal Ignacius**
> ""Possibly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Sal Ignacius: ""Now, I behold an endless sea of people stretching as far..."*)

### Węzeł `[402]`
Mówca: **Sal Ignacius**
> ""I can assure you, Your Grace, my visions are anything *but* nonsense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Sal Ignacius: ""Now, I behold an endless sea of people stretching as far..."*)

### Węzeł `[403]`
Mówca: **Sal Ignacius**
> ""If true, it could mean dark clouds on the horizon are fast approaching.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[404]`
Mówca: **Sal Ignacius**
> ""It very well could.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[405]`
Mówca: **Narrator**
> "The Grand Wiseman nodded solemnly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Sal Ignacius: ""Please do, Your Majesty. The spiritual health of our kin..."*)

### Węzeł `[406]`
Mówca: **Sal Ignacius**
> ""Please do, Your Majesty. The spiritual health of our kingdom is at stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Sal Ignacius: ""For now, let us proceed with your consecration.""*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Sal spread his arms wide open."*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
EnactDecree("Religion_RestorationPlavoArchsanctuary");
RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project = true;
RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project = true;
RiziaDLC.Resources_Authority += 4;`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
EnactDecree("Religion_RestorationPlavoArchsanctuary");
Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] = true;
Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Sal Ignacius: ""This is a most auspicious start to today's ceremony. And..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project = true;
RiziaDLC.Resources_Authority += 2;`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Religion_ExpansionOfSallabesGrandSanctuary");
Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Sal Ignacius: ""This is a most auspicious start to today's ceremony. And..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnactDecree("Religion_RestorationPlavoArchsanctuary");
RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project = true;
RiziaDLC.Resources_Authority += 2;`
- **Efekt skryptowy (`userScript`):** `EnactDecree("Religion_RestorationPlavoArchsanctuary");
Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] = true;
Variable["RiziaDLC.Resources_Authority"] = Variable["RiziaDLC.Resources_Authority"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[915]` (*Sal Ignacius: ""This is a most auspicious start to today's ceremony. And..."*)

### Węzeł `[411]`
Mówca: **Narrator**
> "The Grand Wiseman clapped his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Sal Ignacius: ""Excellent, Your Majesty! I look forward to seeing these ..."*)

### Węzeł `[412]`
Mówca: **Sal Ignacius**
> ""Excellent, Your Majesty! I look forward to seeing these pews lined with worshippers once more!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Religion_RestorationPlavoArchsanctuary"); Ri..."*)

### Węzeł `[413]`
Mówca: **Titus Gordion**
> ""We'll take it from here, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Player_Romus: ""It seems I misjudged you after all, Captain Gordion. You..."*)
  - -> `[414]` (*Player_Romus: ""Well done, Captain. Take him away.""*)
  - -> `[419]` (*Player_Romus: ""What? Did you expect me to handle it myself?""*)
  - -> `[416]` (*Player_Romus: ""Oh, now you'll 'take it from here?' He should have never..."*)

### Węzeł `[414]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well done, Captain. Take him away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Titus Gordion: ""With pleasure.""*)

### Węzeł `[415]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It seems I misjudged you after all, Captain Gordion. You have my thanks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Titus Gordion: ""It is my honor. My men will deal with this rogue accordi..."*)

### Węzeł `[416]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, now you'll 'take it from here?' He should have never broken through your men in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Titus Gordion: ""Please accept my apology. It won't happen again.""*)

### Węzeł `[417]`
Mówca: **Titus Gordion**
> ""Please accept my apology. It won't happen again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[418]`
Mówca: **Narrator**
> "The surprise visitor was shouting something, but I couldn't understand what he was saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Titus Gordion: ""We'll take it from here, Your Majesty.""*)

### Węzeł `[419]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What? Did you expect me to handle it myself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[413]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Titus Gordion: ""No. Of course not. I'll have this taken care of right aw..."*)

### Węzeł `[420]`
Mówca: **Titus Gordion**
> ""No. Of course not. I'll have this taken care of right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;"*)

### Węzeł `[421]`
Mówca: **Titus Gordion**
> ""It is my honor. My men will deal with this rogue accordingly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus += 1;"*)

### Węzeł `[422]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was that man who I think he was?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Sal Ignacius), `[432]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Sal Ignacius: ""Judging by his wardrobe, he appeared to be a Derdian Gol..."*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say I cared for that little stunt, but I do wonder what the man wanted.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Sal Ignacius), `[432]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Sal Ignacius: ""Judging by his wardrobe, he appeared to be a Derdian Gol..."*)

### Węzeł `[424]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see to it that the protester is locked away for quite some time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Sal Ignacius), `[432]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[839]` (*Sal Ignacius: ""Rightly so. Nobody should attack the King of Rizia, espe..."*)

### Węzeł `[425]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Quite the daredevil, that man. I'm inclined to know his motivation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Sal Ignacius), `[432]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Sal Ignacius: ""He was a Derdian Golcondist. I'd say his motivation was ..."*)

### Węzeł `[426]`
Mówca: **Sal Ignacius**
> ""I believe he was a Derdian Golcondist. He was wearing their traditional garb.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[663]` (*Player_Romus: ""I didn't know Derdia's fundamentalism had gotten this ou..."*)
  - -> `[664]` (*Player_Romus: ""I'm not surprised at his actions. When you deprive a man..."*)
  - -> `[647]` (*Player_Romus: ""What would a Derdian Golcondist be doing here?""*)

### Węzeł `[427]`
Mówca: **Sal Ignacius**
> ""Judging by his wardrobe, he appeared to be a Derdian Golcondist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[663]` (*Player_Romus: ""I didn't know Derdia's fundamentalism had gotten this ou..."*)
  - -> `[664]` (*Player_Romus: ""I'm not surprised at his actions. When you deprive a man..."*)
  - -> `[647]` (*Player_Romus: ""What would a Derdian Golcondist be doing here?""*)

### Węzeł `[428]`
Mówca: **Sal Ignacius**
> ""He was a Derdian Golcondist. I'd say his motivation was clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[659]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[663]` (*Player_Romus: ""I didn't know Derdia's fundamentalism had gotten this ou..."*)
  - -> `[664]` (*Player_Romus: ""I'm not surprised at his actions. When you deprive a man..."*)
  - -> `[647]` (*Player_Romus: ""What would a Derdian Golcondist be doing here?""*)

### Węzeł `[429]`
Mówca: **Sal Ignacius**
> ""Plavo is one of the holiest places in all of Wruhecism. A belief that the Golcondists *claim* to hold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[430]`
Mówca: **Sal Ignacius**
> ""There was a time when Golcondists prayed here in such small numbers that their presence was tolerated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[668]` (*Sal Ignacius: ""But the more Derdians came to Rizia, the more they overw..."*)

### Węzeł `[431]`
Mówca: **Narrator**
> "We continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Sal Ignacius: ""I hope that man is duly punished for his actions. We wou..."*)

### Węzeł `[432]`
Mówca: **Sal Ignacius**
> ""I hope that man is duly punished for his actions. We wouldn't want others following his example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Węzeł Logiki Narracyjnej: "IntruderTakenAway"*)

### Węzeł `[433]`
Mówca: **Sal Ignacius**
> ""Apart from the Golcondists, we have seen a rising Dastnurist minority due to the growing numbers of migrants from Wehlen and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[648]` (*Narrator: "Dastnurity was the other main branch of the Nurist religi..."*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_SoberKing == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_SoberKing == true )"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_SoberKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[737]` (*Player_Romus: ""Oh. Um... I don't drink.""*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_SoberKing == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[739]` (*Player_Romus: ""About time! I need a drink.""*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Titus, who was sitting next to the driver, turned back to..."*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Player_Romus: ""Grand Wiseman Ignacius... looking as stoic as ever.""*)
  - -> `[18]` (*Player_Romus: ""Look at the old geezer. Hard to believe he's still breat..."*)
  - -> `[238]` (*Player_Romus: ""Alright. Let's proceed.""*)
  - -> `[19]` (*Player_Romus: ""Here we go.""*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "At his advanced age, he wasn't exactly spry."*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "As my motorcade traveled down the highway, and the Archsa..."*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "As my motorcade journeyed down the highway, the Archsactu..."*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "I quickly put on my clothes and made my way back through ..."*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Titus and another guardsman were at my side the moment th..."*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Narrator: "I put on my clothes, and made my way back through the cat..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Before long, my motorcade was back on the road."*)
  - -> `[147]` (*Narrator: "By the time I'd made it back to the car, the captain was ..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Titus Gordion");"*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "With a nod from Captain Gordion, two of his guardsmen lif..."*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Narrator: "With a nod from Captain Gordion, two of his guardsmen lif..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fascinating. I'd love to hear more about them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Sal Ignacius: ""We shouldn't delay the ceremony much longer.""*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No time to bother with corpses. We've got a ceremony to perform.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[451]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = true; RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = true;
Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[452]`
Mówca: **Sal Ignacius**
> ""We shouldn't delay the ceremony much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Sal Ignacius: ""But very well. Who would you like to know about?""*)

### Węzeł `[453]`
Mówca: **Sal Ignacius**
> ""But very well. Who would you like to know about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "DeadBodyHub"*)

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DeadBodyHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false"*)
  - -> `[464]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false"*)
  - -> `[467]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false"*)
  - -> `[458]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true ..."*)

### Węzeł `[455]`
**[WYBÓR GRACZA: "First tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the first tomb."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false`
- **Kontekst wejściowy (poprzednik):** `[453]` (Sal Ignacius), `[924]` (Sal Ignacius), `[925]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Sal Ignacius: ""That would be the tomb of Talerius Azaro. Not only was h..."*)

### Węzeł `[456]`
**[WYBÓR GRACZA: "Second tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the second tomb."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false`
- **Kontekst wejściowy (poprzednik):** `[453]` (Sal Ignacius), `[924]` (Sal Ignacius), `[925]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]` (*Sal Ignacius: ""That would be Aurelia Itxaro. If you remember your histo..."*)

### Węzeł `[457]`
**[WYBÓR GRACZA: "Third tomb."]** — Mówca: **Player_Romus_Italic**
> "I gestured to the third tomb."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false`
- **Kontekst wejściowy (poprzednik):** `[453]` (Sal Ignacius), `[924]` (Sal Ignacius), `[925]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Narrator: "Decorated in gold, I would have considered it the most sp..."*)

### Węzeł `[458]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true ..."*)
  - -> `[460]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == tru..."*)

### Węzeł `[459]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[645]` (*Player_Romus: ""I'm ready to move on.""*)

### Węzeł `[460]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == true &&
RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[461]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false"*)
  - -> `[463]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false)"*)

### Węzeł `[462]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus_Italic: "First tomb."*)

### Węzeł `[463]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[464]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false"*)
  - -> `[466]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false)"*)

### Węzeł `[465]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Player_Romus_Italic: "Second tomb."*)

### Węzeł `[466]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[467]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false"*)
  - -> `[469]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false)"*)

### Węzeł `[468]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus_Italic: "Third tomb."*)

### Węzeł `[469]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[470]`
Mówca: **Sal Ignacius**
> ""Very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "Jump to: [DeadBodyHub]"*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "Jump to: [DeadBodyHub]"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "Jump to: [DeadBodyHub]"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Briefing_Religion_Body00 = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body00"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Sal Ignacius: ""Very well.""*)

### Węzeł `[475]`
Mówca: **Narrator**
> "In an adjacent room, there were several tombs, each adorned with intricate decorations."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Sal Ignacius: ""Welcome to the catacombs.""*)

### Węzeł `[476]`
Mówca: **Sal Ignacius**
> ""Here lies Bredus Azaro, the first Duke of Montaklar. All members of the Royal House of Azaro are descended from him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Sal Ignacius: ""The damage to his tomb was another casualty of the Golco..."*)

### Węzeł `[477]`
Mówca: **Sal Ignacius**
> ""The damage to his tomb was another casualty of the Golcondist pilgrims when a piece of the above ceiling came crashing down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Proje..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Sal Ignacius: ""Thanks to the funds that will now be put toward repairs,..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 = true;"*)

### Węzeł `[481]`
Mówca: **Sal Ignacius**
> ""Thanks to the funds that will now be put toward repairs, poor Bredus can finally be re-laid to rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body03 = true;"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [DeadBodyHub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "DeadBodyHub"*)

### Węzeł `[483]`
Mówca: **Sal Ignacius**
> ""That would be the tomb of Talerius Azaro. Not only was he the Earl of Havas, he was the most revered general during the War of Rizian Succession.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Sal Ignacius: ""Even though House Azaro ultimately lost the war, the gen..."*)

### Węzeł `[484]`
Mówca: **Sal Ignacius**
> ""Even though House Azaro ultimately lost the war, the general never lost a single battle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Sal Ignacius: ""After the war, he established Camp Domus -- Rizia's larg..."*)

### Węzeł `[485]`
Mówca: **Sal Ignacius**
> ""After the war, he established Camp Domus -- Rizia's largest military base to this day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Player_Romus: ""He may be revered by some, but I never much cared for him.""*)
  - -> `[491]` (*Player_Romus: ""Even though he fought against House Toras, I still hold ..."*)
  - -> `[490]` (*Player_Romus: ""Yes, I'm quite familiar with his reputation.""*)

### Węzeł `[486]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[488]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[487]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Narrator: "His mentioning of Camp Domus flooded my mind with fond me..."*)

### Węzeł `[488]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 = true;"*)

### Węzeł `[489]`
Mówca: **Narrator**
> "His mentioning of Camp Domus flooded my mind with fond memories of my time there as a young recruit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body01 = true;"*)

### Węzeł `[490]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm quite familiar with his reputation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even though he fought against House Toras, I still hold him in the highest respect.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He may be revered by some, but I never much cared for him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[485]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[493]`
Mówca: **Sal Ignacius**
> ""That would be Aurelia Itxaro. If you remember your history, he was the famed industrialist of the 19th Century whose revolutionary mining equipment led to the Second Rizian Gold Rush.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Sal Ignacius: ""He single-handedly brought incomprehensible wealth to th..."*)

### Węzeł `[494]`
Mówca: **Sal Ignacius**
> ""While he isn't of royal lineage, his legacy earned him a place amongst them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[921]` (*Player_Romus: ""A commoner, buried among the Montaklar nobility? What an..."*)
  - -> `[922]` (*Player_Romus: ""A pioneer to whom we all owe a debt of gratitude. Rizia ..."*)
  - -> `[923]` (*Player_Romus: ""It's his fault Rizia became so reliant on resources. Per..."*)

### Węzeł `[495]`
Mówca: **Sal Ignacius**
> ""He single-handedly brought incomprehensible wealth to this kingdom overnight, granting us enduring power and influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Sal Ignacius: ""While he isn't of royal lineage, his legacy earned him a..."*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "Jump to: [IsEverythingAlright]"*)

### Węzeł `[497]`
Mówca: **Narrator**
> "He paused with his hand on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Sal Ignacius: ""There was a time when Golcondists prayed here in such sm..."*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = false; RiziaDLCSupport.Journal_Turn01_Ceremony_Refused = true;
RiziaDLC.PersonalValue_BrokeTradition += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = false;
Variable["RiziaDLCSupport.Journal_Turn01_Ceremony_Refused"] = true;
Variable["RiziaDLC.PersonalValue_BrokeTradition"] = Variable["RiziaDLC.PersonalValue_BrokeTradition"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn01_Ceremony_Participated = true; RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn01_Ceremony_Participated"] = true;
Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCe..."*)

### Węzeł `[501]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCeremony"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions = fals..."*)

### Węzeł `[502]`
Mówca: **Narrator**
> "Partway up the stairs, I heard Titus and his men apprehending the assailant. Sal hobbled up behind me, panting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = true;"*)

### Węzeł `[503]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is that where you keep the torch-er chamber?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[638]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[623]` (*Sal Ignacius: ""Most amusing. If it's torture you want, the soprano sect..."*)

### Węzeł `[504]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_FalloutWithDad == true"*)
  - -> `[506]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_FalloutWithDad == true)"*)

### Węzeł `[505]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_FalloutWithDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_FalloutWithDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Narrator: "Given his ambivalence towards me, his reply should have c..."*)

### Węzeł `[506]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_FalloutWithDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_FalloutWithDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Narrator: "Though I wished he'd given more insight on what to expect..."*)

### Węzeł `[507]`
Mówca: **Narrator**
> "Given his ambivalence towards me, his reply should have come as no surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "But aside from the pomp and circumstance of the Consecrat..."*)

### Węzeł `[508]`
Mówca: **Narrator**
> "Though I wished he'd given more insight on what to expect, I respected Father's vow of secrecy and didn't press the issue further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "But aside from the pomp and circumstance of the Consecrat..."*)

### Węzeł `[509]`
**[WYBÓR GRACZA: "Conduct their applause."]** — Mówca: **Player_Romus_Italic**
> "I encouraged them to cheer even louder by raising my hand in the air like the conductor of the Rizian Royal Symphony."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[534]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[510]`
**[WYBÓR GRACZA: "Ignore them."]** — Mówca: **Player_Romus_Italic**
> "I ignored them and kept my head down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[534]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Narrator: "The onlookers' enthusiasm diminished as I dismissively ma..."*)

### Węzeł `[511]`
Mówca: **Narrator**
> "Eager to follow along, they got louder the higher my hand raised, and quieter when I brought it down low."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[798]` (*Narrator: "I performed variations of this toward different sections ..."*)

### Węzeł `[512]`
Mówca: **Narrator**
> "The onlookers' enthusiasm diminished as I dismissively made my way past. They clearly had expected a show."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "A welcoming smile spread across the Grand Wiseman's face ..."*)

### Węzeł `[513]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Romus_Italic**
> "I gave them a royal wave."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[534]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Narrator: "The shouts of admiration resonated even louder from my su..."*)

### Węzeł `[514]`
Mówca: **Narrator**
> "The shouts of admiration resonated even louder from my subjects."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "A welcoming smile spread across the Grand Wiseman's face ..."*)

### Węzeł `[515]`
**[WYBÓR GRACZA: "Recite a Wruhecist proverb."]** — Mówca: **Player_Romus_Italic**
> ""Laeteum cordeplenum quivoson Desiranto!""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[534]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Narrator: "The old Wruhecist proverb translated to "Let joy fill the..."*)

### Węzeł `[516]`
Mówca: **Narrator**
> "The old Wruhecist proverb translated to "Let joy fill the hearts of those who seek the Lord.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Narrator: "In unison, the crowd shouted, "Lusel Dominatun Deunon; se..."*)

### Węzeł `[517]`
Mówca: **Narrator**
> "In unison, the crowd shouted, "Lusel Dominatun Deunon; senkusant pactum denborarik!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[799]` (*Narrator: "It was the traditional reply meaning, "He is the Lord our..."*)

### Węzeł `[518]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IntruderTakenAway`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player_Romus: ""Can't say I cared for that little stunt, but I do wonder..."*)
  - -> `[422]` (*Player_Romus: ""Was that man who I think he was?""*)
  - -> `[424]` (*Player_Romus: ""I'll see to it that the protester is locked away for qui..."*)
  - -> `[425]` (*Player_Romus: ""Quite the daredevil, that man. I'm inclined to know his ..."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IsEverythingAlright`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Titus Gordion: ""Your Majesty, is everything alright?""*)

### Węzeł `[520]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `IFollowedtheWiscerer`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1003]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Descending into sacred catacombs with th..."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DownTunnelHub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "As we made our way down the tunnel, the ceiling began to ..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Sal Ignacius: ""Some might say that spiritual sustenance comes from with..."*)

### Węzeł `[523]`
Mówca: **Narrator**
> "Titus quickly exited the vehicle and opened my side door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[797]` (*Narrator: "As I stepped out and onto the pavement, I was immediately..."*)

### Węzeł `[524]`
Mówca: **Titus Gordion**
> ""These people look like they could give you trouble. Shall I have them removed?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Player_Romus: ""Have them removed immediately.""*)
  - -> `[526]` (*Player_Romus: ""You really had to ask? Get those traitors the hell out o..."*)
  - -> `[527]` (*Player_Romus: ""No, they have the right to protest, even if I disagree w..."*)
  - -> `[528]` (*Player_Romus: ""Let them protest, Captain, seeing as how this issue hold..."*)

### Węzeł `[525]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have them removed immediately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1; RiziaDLCIsolated.T..."*)

### Węzeł `[526]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You really had to ask? Get those traitors the hell out of my sight.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Titus -= 1;  RiziaDLCIsolated.Turn01_R..."*)

### Węzeł `[527]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, they have the right to protest, even if I disagree with their cause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic += 1; RiziaDLCIsolated.T..."*)

### Węzeł `[528]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let them protest, Captain, seeing as how this issue holds significant importance to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[524]` (Titus Gordion)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = false;"*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic += 1; RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Titus Gordion: ""Understood.""*)

### Węzeł `[530]`
Mówca: **Titus Gordion**
> ""Yes, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Narrator: "He cast an intimidating glare at the protesters as we pas..."*)

### Węzeł `[531]`
Mówca: **Titus Gordion**
> ""Of course. Right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Narrator: "The captain barked at several nearby guards to remove the..."*)

### Węzeł `[532]`
Mówca: **Titus Gordion**
> ""Yes, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Narrator: "Captain Gordion quietly spoke to several nearby guards wh..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Titus -= 1; 
RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = true; 
RiziaDLC.LeaningValue_Democratic -= 1;
RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Titus"] = Variable["RiziaDLC.Relations_Titus"] - 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Titus Gordion: ""Of course. Right away.""*)

### Węzeł `[534]`
Mówca: **Narrator**
> "I turned back toward the crowd. They were still applauding me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Player_Romus_Italic: "Conduct their applause."*)
  - -> `[513]` (*Player_Romus_Italic: "Wave."*)
  - -> `[836]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[510]` (*Player_Romus_Italic: "Ignore them."*)

### Węzeł `[535]`
Mówca: **Titus Gordion**
> ""Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Narrator: "He cast an intimidating glare at the protesters as we pas..."*)

### Węzeł `[536]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1; RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;
Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Titus Gordion: ""Yes, sir.""*)

### Węzeł `[537]`
Mówca: **Narrator**
> "He cast an intimidating glare at the protesters as we passed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "I turned back toward the crowd. They were still applaudin..."*)

### Węzeł `[538]`
Mówca: **Narrator**
> "He cast an intimidating glare at the protesters as we passed them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "I turned back toward the crowd. They were still applaudin..."*)

### Węzeł `[539]`
Mówca: **Narrator**
> "Captain Gordion quietly spoke to several nearby guards who began herding the protesters away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "I turned back toward the crowd. They were still applaudin..."*)

### Węzeł `[540]`
Mówca: **Narrator**
> "The captain barked at several nearby guards to remove the protesters, and they began clearing them out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Narrator: "I turned back toward the crowd. They were still applaudin..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How morbidly disturbing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Sal Ignacius: ""Our departed friends won't be coming back to life anytim..."*)

### Węzeł `[542]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Impressive, to say the least.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Sal Ignacius: ""Indeed it is.""*)

### Węzeł `[543]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm tempted to knock to see if anyone's home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Narrator: "Eager to follow along, they got louder the higher my hand..."*)

### Węzeł `[545]`
Mówca: **Narrator**
> "Despite my apprehension, I took his hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Sal Ignacius: ""Listen closely to my words. For the gift of sight comes ..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. The sooner we get this over with the better.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "Despite my apprehension, I took his hands."*)

### Węzeł `[547]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Please continue.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Narrator: "Despite my apprehension, I took his hands."*)

### Węzeł `[548]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I sincerely hope you can find it in your heart to forgive me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Sal Ignacius: ""It's not forgiveness from you that you should be seeking..."*)

### Węzeł `[549]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I'll be sure to keep that in mind if ever you should come groveling on your knees asking for *my* consent.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Narrator: "The wiscerer went silent. Though he outwardly remained ca..."*)

### Węzeł `[550]`
Mówca: **Narrator**
> "The wiscerer went silent. Though he outwardly remained calm, the sliver of vexation in his eyes was undeniable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Sal Ignacius: ""You only just inherited the throne -- an appointment tha..."*)

### Węzeł `[551]`
Mówca: **Sal Ignacius**
> ""It's not forgiveness from you that you should be seeking, but forgiveness from God.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Sal Ignacius: ""I must stay here until the visions run their course. Ple..."*)

### Węzeł `[552]`
Mówca: **Sal Ignacius**
> ""I must stay here until the visions run their course. Please find your own way out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "He closed his eyes and began trembling. I ignored him, pu..."*)

### Węzeł `[553]`
Mówca: **Narrator**
> "He closed his eyes and began trembling. I ignored him, put on my clothes, and made my way back through the catacombs until I'd reach the surface."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[554]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[555]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "Titus and another guardsman were at my side the moment th..."*)

### Węzeł `[556]`
Mówca: **Sal Ignacius**
> ""You only just inherited the throne -- an appointment that comes with the greatest of responsibilities -- so allow me to offer you some advice...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Player_Romus: ""Request denied. Good day, Grand Wiseman. I'll see myself..."*)
  - -> `[557]` (*Player_Romus: ""Oh, yeah? And what's that?""*)
  - -> `[558]` (*Player_Romus: ""Fine. But keep it brief.""*)
  - -> `[559]` (*Player_Romus: ""*Unsolicited* advice. But do go on. I want to hear what ..."*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh, yeah? And what's that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Sal Ignacius: ""What I wanted to say was... burn too many bridges -- esp..."*)

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine. But keep it brief.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Sal Ignacius: ""Of course.""*)

### Węzeł `[559]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""*Unsolicited* advice. But do go on. I want to hear what you have to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[819]` (*Narrator: "There was a flash of irritation in his eyes."*)

### Węzeł `[560]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Request denied. Good day, Grand Wiseman. I'll see myself out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[561]`
Mówca: **Sal Ignacius**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Sal Ignacius: ""What I wanted to say was... burn too many bridges -- esp..."*)

### Węzeł `[562]`
Mówca: **Sal Ignacius**
> ""What I wanted to say was... burn too many bridges -- especially this early into your reign -- and you may find yourself marooned on a deserted shore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Sal Ignacius: ""I must stay here until the visions run their course. Ple..."*)

### Węzeł `[563]`
Mówca: **Narrator**
> "Wary as I was, I relented and did as he requested."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Sal Ignacius: ""Listen closely to my words. For the gift of sight comes ..."*)

### Węzeł `[564]`
Mówca: **Narrator**
> "I put on my clothes, and made my way back through the catacombs until I'd reached the surface -- the events of today, forever burned in my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Narrator: "A part of me questioned whether or not what I'd experienc..."*)

### Węzeł `[565]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why do you need my hands?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""To consummate the Consecration of the King I must insist..."*)

### Węzeł `[566]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's this about?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[132]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""To consummate the Consecration of the King I must insist..."*)

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you doing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Player_Romus_Italic), `[132]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""To consummate the Consecration of the King I must insist..."*)

### Węzeł `[568]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Kindly keep your distance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Player_Romus_Italic), `[132]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""To consummate the Consecration of the King I must insist..."*)

### Węzeł `[569]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's going on?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[131]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Sal Ignacius: ""To consummate the Consecration of the King I must insist..."*)

### Węzeł `[570]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I haven't changed my mind about that. However... perhaps we can overlook my abstention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Sal Ignacius: ""That's asking a lot. The importance of the ceremony cann..."*)

### Węzeł `[571]`
Mówca: **Sal Ignacius**
> ""That's asking a lot. The importance of the ceremony cannot be overstated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Player_Romus: ""What if I made it worth your while?""*)
  - -> `[584]` (*Player_Romus: ""You're right. Forget what I said. 'Til next time.""*)
  - -> `[573]` (*Player_Romus: ""What if I told you there would be consequences for defyi..."*)

### Węzeł `[572]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I made it worth your while?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[571]` (Sal Ignacius), `[856]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Sal Ignacius: ""Go on...""*)

### Węzeł `[573]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What if I told you there would be consequences for defying the king's wishes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[571]` (Sal Ignacius), `[856]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Sal Ignacius: ""Then I would tell you that repercussions are of no conce..."*)

### Węzeł `[574]`
Mówca: **Sal Ignacius**
> ""Then I would tell you that repercussions are of no concern to me. I stand on the side of God. Can you say the same?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Player_Romus: ""A man with convictions... It's a rarity these days. I re..."*)
  - -> `[577]` (*Player_Romus: ""Well then... now that we better understand each other, p..."*)
  - -> `[575]` (*Player_Romus: ""Well, Your Holiness, it seems we've reached an impasse. ..."*)

### Węzeł `[575]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, Your Holiness, it seems we've reached an impasse. I'll see myself out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Sal Ignacius: ""Divus zaitu.""*)

### Węzeł `[576]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A man with convictions... It's a rarity these days. I respect that. Until next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Sal Ignacius: ""Next time, Your Majesty.""*)

### Węzeł `[577]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well then... now that we better understand each other, perhaps we can one day channel that newfound knowledge toward seeing eye to eye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[574]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Sal Ignacius: ""Perhaps.""*)

### Węzeł `[578]`
Mówca: **Sal Ignacius**
> ""Perhaps.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[579]`
Mówca: **Sal Ignacius**
> ""Divus zaitu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Player_Romus: ""Divus zaitu.""*)
  - -> `[582]` (*Player_Romus: ""Whatever you say.""*)
  - -> `[585]` (*Player_Romus: ""Can't say the same about you.""*)
  - -> `[583]` (*Player_Romus: ""Thanks.""*)

### Węzeł `[580]`
Mówca: **Sal Ignacius**
> ""Next time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[794]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[581]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Divus zaitu.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[582]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whatever you say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[583]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[584]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right. Forget what I said. 'Til next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[571]` (Sal Ignacius), `[856]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[585]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Can't say the same about you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[586]`
Mówca: **Sal Ignacius**
> ""Make no mistake... In matters of upholding principles, my steadfastness knows no bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[826]` (*Sal Ignacius: ""However, keeping an open mind through curiosity and skep..."*)

### Węzeł `[587]`
Mówca: **Sal Ignacius**
> ""While I have my reservations about what you're suggesting... My curiosity far outweighs my skepticism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[591]` (*Player_Romus: ""Then I look forward to speaking to you about future... a..."*)
  - -> `[590]` (*Player_Romus: ""I look forward to future discussions. Maybe then I can n..."*)
  - -> `[588]` (*Player_Romus: ""Good. I expect nothing less.""*)
  - -> `[589]` (*Player_Romus: ""Meaning?""*)

### Węzeł `[588]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good. I expect nothing less.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Sal Ignacius: ""I look forward to speaking more about this with you at a..."*)

### Węzeł `[589]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meaning?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Sal Ignacius: ""That I may be old, but I know which way to move when the..."*)

### Węzeł `[590]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I look forward to future discussions. Maybe then I can nurture your curiosity even further.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[592]` (*Sal Ignacius: ""We shall see.""*)

### Węzeł `[591]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Then I look forward to speaking to you about future... arrangements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[587]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Sal Ignacius: ""As I with you.""*)

### Węzeł `[592]`
Mówca: **Sal Ignacius**
> ""We shall see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[593]`
Mówca: **Sal Ignacius**
> ""As I with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[594]`
Mówca: **Sal Ignacius**
> ""That I may be old, but I know which way to move when the wind blows.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Player_Romus: ""Good to hear. I underestimated you, Your Holiness.""*)
  - -> `[599]` (*Player_Romus: ""I don't want to be around someone who is so easily swaye..."*)
  - -> `[600]` (*Player_Romus: ""Very good. I look forward to future *arrangements* betwe..."*)
  - -> `[603]` (*Player_Romus: ""As long as the wind continues to blow in the right direc..."*)

### Węzeł `[595]`
Mówca: **Sal Ignacius**
> ""I look forward to speaking more about this with you at a later date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[596]`
Mówca: **Narrator**
> "The tense interaction with the grand wiseman and the friction that came with it wasn't beneficial for anyone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[652]` (*Narrator: "But whether or not our little row could be rectified, I w..."*)

### Węzeł `[597]`
Mówca: **Narrator**
> "As my motorcade journeyed down the highway and the Archsacturary of Plavo gradually disappeared from sight, I reflected on all I had achieved today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Narrator: "The tense interaction with the grand wiseman and the fric..."*)

### Węzeł `[598]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to hear. I underestimated you, Your Holiness.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[594]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Sal Ignacius: ""Most do.""*)

### Węzeł `[599]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't want to be around someone who is so easily swayed. Forget it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[594]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[607]` (*Sal Ignacius: ""Well, I'm sorry to hear that. However, in the future, I ..."*)

### Węzeł `[600]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very good. I look forward to future *arrangements* between us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[594]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[602]` (*Sal Ignacius: ""As do I.""*)

### Węzeł `[601]`
Mówca: **Sal Ignacius**
> ""Most do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[602]`
Mówca: **Sal Ignacius**
> ""As do I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[860]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[603]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as the wind continues to blow in the right direction.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[594]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Sal Ignacius: ""Yes, of course. Though predicting the weather can be a t..."*)

### Węzeł `[604]`
Mówca: **Sal Ignacius**
> ""Yes, of course. Though predicting the weather can be a tricky thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[605]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "As my motorcade journeyed down the highway and the Archsa..."*)

### Węzeł `[606]`
Mówca: **Narrator**
> "I wished Sal goodbye and left the premises. Captain Gordion and his men followed behind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");"*)

### Węzeł `[607]`
Mówca: **Sal Ignacius**
> ""Well, I'm sorry to hear that. However, in the future, I suggest not being so quick to slam the door shut when opportunities present themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[793]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[608]`
Mówca: **Sal Ignacius**
> ""Go on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player_Romus: ""That if you do me this one small favor, another small fa..."*)
  - -> `[611]` (*Player_Romus: ""As in, you keep your position as Grand Wiseman and aren'..."*)
  - -> `[610]` (*Player_Romus: ""Meaning, I won't feel the need to seek *alternatives* to..."*)
  - -> `[609]` (*Player_Romus: ""As in, any *kindness* bestowed upon me will be reciproca..."*)

### Węzeł `[609]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in, any *kindness* bestowed upon me will be reciprocated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[608]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Sal Ignacius: ""Make no mistake... In matters of upholding principles, m..."*)

### Węzeł `[610]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Meaning, I won't feel the need to seek *alternatives* to convince you to be more compliable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[608]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[614]` (*Sal Ignacius: ""Do what you must. But I stand on the side of riotousness.""*)

### Węzeł `[611]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As in, you keep your position as Grand Wiseman and aren't replaced by someone more... agreeable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[608]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Sal Ignacius: ""Now, now... let's not be hasty. You wouldn't want to do ..."*)

### Węzeł `[612]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That if you do me this one small favor, another small favor will be returned to you should the time come.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[608]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[613]` (*Sal Ignacius: ""I see...""*)

### Węzeł `[613]`
Mówca: **Sal Ignacius**
> ""I see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Sal Ignacius: ""Make no mistake... In matters of upholding principles, m..."*)

### Węzeł `[614]`
Mówca: **Sal Ignacius**
> ""Do what you must. But I stand on the side of riotousness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[828]` (*Sal Ignacius: ""The only convincing you need isn't from me but from God...."*)

### Węzeł `[615]`
Mówca: **Sal Ignacius**
> ""Now, now... let's not be hasty. You wouldn't want to do anything that might disrupt the balance between us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Sal Ignacius: ""Make no mistake... In matters of upholding principles, m..."*)

### Węzeł `[616]`
Mówca: **Sal Ignacius**
> ""If you insist. However, if you get a knock back, I'd suggest we vacate this place as soon as humanly possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""As for the tomb's tenants, they're mostly wealthy noblem..."*)

### Węzeł `[617]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[616]` (*Sal Ignacius: ""If you insist. However, if you get a knock back, I'd sug..."*)

### Węzeł `[618]`
Mówca: **Sal Ignacius**
> ""Indeed it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""As for the tomb's tenants, they're mostly wealthy noblem..."*)

### Węzeł `[619]`
Mówca: **Sal Ignacius**
> ""Our departed friends won't be coming back to life anytime soon, in case you were worried.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Sal Ignacius: ""As for the tomb's tenants, they're mostly wealthy noblem..."*)

### Węzeł `[620]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false"*)
  - -> `[622]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == f..."*)

### Węzeł `[621]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "We began heading toward the entrance. However, I didn't g..."*)

### Węzeł `[622]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[743]` (*Narrator: "We continued towards the archsanctuary's entrance."*)

### Węzeł `[623]`
Mówca: **Sal Ignacius**
> ""Most amusing. If it's torture you want, the soprano section of the Wruhecist Tabernacle Choir will do the trick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[624]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's down there?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[638]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Sal Ignacius: ""Come and see for yourself.""*)

### Węzeł `[625]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm going to catch the plague, I know it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[638]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Sal Ignacius: ""The path ahead leads us to one of the holiest sites in W..."*)

### Węzeł `[626]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How medieval.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[638]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Sal Ignacius: ""Believe me, this is only the beginning.""*)

### Węzeł `[627]`
Mówca: **Sal Ignacius**
> ""The path ahead leads us to one of the holiest sites in Wruhecism. Believe me, it has undergone thorough purification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[628]`
Mówca: **Sal Ignacius**
> ""Come and see for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[629]`
Mówca: **Sal Ignacius**
> ""Believe me, this is only the beginning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Sal Ignacius: ""This way, Your Majesty.""*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway = false; RiziaDLC.Country_PublicOpinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Rel_Briefing_RunAway"] = false;
Variable["RiziaDLC.Country_PublicOpinion"] = Variable["RiziaDLC.Country_PublicOpinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Titus, without missing a beat, caught the man by the arm ..."*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player_Romus: ""I'm glad you brought this to my attention, but I'd rathe..."*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Player_Romus: ""I'll look into funding these projects as soon as the Tre..."*)

### Węzeł `[635]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll look into funding these projects as soon as the Treasury allows it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Narrator: "The Grand Wiseman clasped his hands together."*)

### Węzeł `[636]`
Mówca: **Narrator**
> "The Grand Wiseman clasped his hands together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[827]` (*Sal Ignacius: ""That would be much appreciated, Your Majesty.""*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Our footsteps echoed throughout the massive empty chamber..."*)

### Węzeł `[638]`
Mówca: **Narrator**
> "We eventually reached an imposing iron door. Behind it was a descending spiral staircase illuminated by torches mounted on the walls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Player_Romus: ""How medieval.""*)
  - -> `[624]` (*Player_Romus: ""What's down there?""*)
  - -> `[625]` (*Player_Romus: ""I'm going to catch the plague, I know it.""*)
  - -> `[503]` (*Player_Romus: ""Is that where you keep the torch-er chamber?""*)

### Węzeł `[639]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's in the coffin?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Sal Ignacius: "“Why, Caelus the Devout, of course. The reason for this A..."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved = false;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_Religion_ProtestersRemoved"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Titus Gordion: ""Yes, Your Majesty.""*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Breather", "R_Breather_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Breather","R_Breather_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "My motorcade traveled for over an hour before the Archsan..."*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Stress", "R_Stress_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Stress","R_Stress_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "But then suddenly, his body began to tremble and his hand..."*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "I felt Sal loosen his hold of me, letting go."*)

### Węzeł `[644]`
Mówca: **Narrator**
> "Decorated in gold, I would have considered it the most splendid of all if not for the hole in the lid, through which I could catch a glimpse of the skeletal remains within."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Sal Ignacius: ""Here lies Bredus Azaro, the first Duke of Montaklar. All..."*)

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm ready to move on.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body01"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body02"] == true  and 
Variable["RiziaDLCIsolated.Turn01_Briefing_Religion_Body03"] == true`
- **Kontekst wejściowy (poprzednik):** `[453]` (Sal Ignacius), `[924]` (Sal Ignacius), `[925]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body00 = true;"*)

### Węzeł `[646]`
Mówca: **Sal Ignacius**
> ""Splendid! Then let us proceed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "Jump to: [Ceremony]"*)

### Węzeł `[647]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would a Derdian Golcondist be doing here?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Sal Ignacius), `[427]` (Sal Ignacius), `[428]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Sal Ignacius: ""Plavo is one of the holiest places in all of Wruhecism. ..."*)

### Węzeł `[648]`
Mówca: **Narrator**
> "Dastnurity was the other main branch of the Nurist religion, observed in most countries to our north. Its followers relied on the writings of St. Dast as the only pure scripture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[711]` (*Narrator: "Lena had been a follower, but converted to Wruhecism on j..."*)

### Węzeł `[649]`
Mówca: **Sal Ignacius**
> ""Come. It is time you saw what they did to this very building. ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "I accompanied Sal into the archsanctuary. Titus and one o..."*)

### Węzeł `[650]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have my own ways of honoring God, and this is not one of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Narrator: "Sal looked apoplectic."*)

### Węzeł `[651]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well, there's a first time for everything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[727]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[728]` (*Narrator: "Sal looked apoplectic."*)

### Węzeł `[652]`
Mówca: **Narrator**
> "But whether or not our little row could be rectified, I would prepare for any eventuality."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[861]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)

### Węzeł `[653]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Abstension_hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)

### Węzeł `[654]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[655]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[656]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[655]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: ""We will begin the restoration of Plavo at once." [-2 Bud..."*)
  - -> `[79]` (*Player_Romus: ""Serving the Dastnurist community should take priority at..."*)

### Węzeł `[656]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[657]`
Mówca: **Narrator**
> "Sal closed his eyes and tilted his head up slightly, awaiting my next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[654]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[889]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[892]` (*Player_Romus: ""You brought me here to make a funding decision, under th..."*)
  - -> `[896]` (*Player_Romus: ""We are in a holy place, Grand Wiseman. I refuse to sully..."*)
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[658]`
Mówca: **Narrator**
> "One was waving a sign that read, "Golcondism Is Not Blasphemy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Titus Gordion: ""These people look like they could give you trouble. Shal..."*)

### Węzeł `[659]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[660]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[661]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[660]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[662]` (*Player_Romus: ""Demanding entrance to our sacred Wruhecist space... I ho..."*)

### Węzeł `[661]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[662]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Demanding entrance to our sacred Wruhecist space... I hope he gets what's coming to him.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[426]` (Sal Ignacius), `[427]` (Sal Ignacius), `[428]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[667]` (*Sal Ignacius: ""Do not be too harsh towards our Derdian brothers. They k..."*)

### Węzeł `[663]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I didn't know Derdia's fundamentalism had gotten this out of control.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Sal Ignacius), `[427]` (Sal Ignacius), `[428]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[666]` (*Sal Ignacius: ""Alas, our Derdian brothers have strayed far from God's p..."*)

### Węzeł `[664]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not surprised at his actions. When you deprive a man of religious freedom, this is the consequence.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[426]` (Sal Ignacius), `[427]` (Sal Ignacius), `[428]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[665]` (*Sal Ignacius: ""It is not 'freedom' that motivates these men, but blood ..."*)

### Węzeł `[665]`
Mówca: **Sal Ignacius**
> ""It is not 'freedom' that motivates these men, but blood lust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[666]`
Mówca: **Sal Ignacius**
> ""Alas, our Derdian brothers have strayed far from God's path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[667]`
Mówca: **Sal Ignacius**
> ""Do not be too harsh towards our Derdian brothers. They know not what they do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[668]`
Mówca: **Sal Ignacius**
> ""But the more Derdians came to Rizia, the more they overwhelmed the sacred sanctuaries of Plavo, Benievon, and Jales with their blasphemous version of worship.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""What's so blasphemous about Golcondism?""*)
  - -> `[42]` (*Player_Romus: "“And so you banned them. Rightly so, I might add.""*)
  - -> `[43]` (*Player_Romus: "“Could we not have built Golcondist sanctuaries to pacify..."*)

### Węzeł `[669]`
Mówca: **Sal Ignacius**
> ""They aim to trace the footsteps of Wruhec's disciples through what is now Merkopa. Which necessitates visiting their final resting places.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[673]` (*Sal Ignacius: ""But our sanctuaries are places of peace. They are not fo..."*)

### Węzeł `[670]`
Mówca: **Sal Ignacius**
> ""I did so with a heavy heart. But our sanctuaries are a place of peace. They are not for those who exalt violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Narrator: "He made a face."*)

### Węzeł `[671]`
Mówca: **Sal Ignacius**
> ""The Golcondists have a martial culture, Your Majesty. They seek purification through violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Narrator: "He made a face."*)

### Węzeł `[672]`
Mówca: **Sal Ignacius**
> ""Among other perversions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[649]` (*Sal Ignacius: ""Come. It is time you saw what they did to this very buil..."*)

### Węzeł `[673]`
Mówca: **Sal Ignacius**
> ""But our sanctuaries are places of peace. They are not for those who exalt violence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[840]` (*Narrator: "He made a face."*)

### Węzeł `[674]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[675]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_DistantAsDad == true"*)
  - -> `[676]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_DistantAsDad == true)"*)

### Węzeł `[675]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_DistantAsDad == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_DistantAsDad"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[677]` (*Narrator: "I tried to remember Vina taking her first steps, but coul..."*)

### Węzeł `[676]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_DistantAsDad == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_DistantAsDad"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "I suddenly recalled how overjoyed I was to see Vina take ..."*)

### Węzeł `[677]`
Mówca: **Narrator**
> "I tried to remember Vina taking her first steps, but could not. I must have been absent at the time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Sal Ignacius: "“It’s only fitting that such a monument be built atop the..."*)

### Węzeł `[678]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[679]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[680]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[679]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Player_Romus: "“This place never fails to impress.”"*)

### Węzeł `[680]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[681]`
Mówca: **Narrator**
> "Sal gestured over our heads to the second-floor gallery overlooking the hall. Part of it had collapsed, and the rest had been roped off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[683]` (*Player_Romus: ""It looks to have seen better days.""*)
  - -> `[682]` (*Player_Romus: ""I have to say, the disheveled look gives the place chara..."*)
  - -> `[684]` (*Player_Romus: ""It's a shame what happened to such a magnificent building.""*)
  - -> `[688]` (*Player_Romus: ""Religious fanaticism will do that.""*)

### Węzeł `[682]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I have to say, the disheveled look gives the place character.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[686]` (*Sal Ignacius: ""Many congregates don't share your opinion.""*)

### Węzeł `[683]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It looks to have seen better days.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[685]` (*Sal Ignacius: ""That's putting it mildly.""*)

### Węzeł `[684]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a shame what happened to such a magnificent building.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[687]` (*Sal Ignacius: ""I couldn't agree more.""*)

### Węzeł `[685]`
Mówca: **Sal Ignacius**
> ""That's putting it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Sal Ignacius: ""A large group of Golcondists came here on one of their h..."*)

### Węzeł `[686]`
Mówca: **Sal Ignacius**
> ""Many congregates don't share your opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Sal Ignacius: ""A large group of Golcondists came here on one of their h..."*)

### Węzeł `[687]`
Mówca: **Sal Ignacius**
> ""I couldn't agree more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Sal Ignacius: ""A large group of Golcondists came here on one of their h..."*)

### Węzeł `[688]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Religious fanaticism will do that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[681]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[689]` (*Sal Ignacius: ""The collapse was entirely preventable.""*)

### Węzeł `[689]`
Mówca: **Sal Ignacius**
> ""The collapse was entirely preventable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[757]` (*Sal Ignacius: ""A large group of Golcondists came here on one of their h..."*)

### Węzeł `[690]`
Mówca: **Narrator**
> "Sal began to pace around the altar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[691]` (*Sal Ignacius: ""Rizia's religious climate is at a crossroads, Your Majes..."*)

### Węzeł `[691]`
Mówca: **Sal Ignacius**
> ""Rizia's religious climate is at a crossroads, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[692]` (*Sal Ignacius: ""From aiding the impoverished to expanding educational op..."*)

### Węzeł `[692]`
Mówca: **Sal Ignacius**
> ""From aiding the impoverished to expanding educational opportunities, our faith-based institutions are a cornerstone of everyday life, strengthening the bonds that hold our society together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[693]` (*Sal Ignacius: ""All under the umbrella of our state religion, Wruhecism.""*)

### Węzeł `[693]`
Mówca: **Sal Ignacius**
> ""All under the umbrella of our state religion, Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[699]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[696]` (*Player_Romus: ""Should religion really be playing such a large role in m..."*)
  - -> `[698]` (*Player_Romus: ""You could have fooled me. I look around and I see hereti..."*)
  - -> `[703]` (*Player_Romus: ""You are forgetting religion's most important role of all..."*)

### Węzeł `[694]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“As it should be. I know I’d be lost without Wruhecism to show me the way.”"
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[693]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[695]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1;"*)

### Węzeł `[695]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[705]` (*Sal Ignacius: ""As would I, Your Majesty.""*)

### Węzeł `[696]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Should religion really be playing such a large role in modern society?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[693]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[697]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 1;"*)

### Węzeł `[697]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[704]` (*Sal Ignacius: ""Our modern world is fractured, Your Majesty. Morality is..."*)

### Węzeł `[698]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You could have fooled me. I look around and I see heretics and blasphemers everywhere.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[693]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[702]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1;"*)

### Węzeł `[699]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[700]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[701]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[700]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[694]` (*Player_Romus: "“As it should be. I know I’d be lost without Wruhecism to..."*)

### Węzeł `[701]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[702]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[706]` (*Sal Ignacius: ""Indeed, our religious unity has begun to splinter in rec..."*)

### Węzeł `[703]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You are forgetting religion's most important role of all. That of pacifying the populace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[693]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[845]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1;"*)

### Węzeł `[704]`
Mówca: **Sal Ignacius**
> ""Our modern world is fractured, Your Majesty. Morality is faltering. We need God more than ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[708]` (*Sal Ignacius: ""Surely you have noticed our religious unity beginning to..."*)

### Węzeł `[705]`
Mówca: **Sal Ignacius**
> ""As would I, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[707]` (*Sal Ignacius: ""But our religious unity has begun to splinter in recent ..."*)

### Węzeł `[706]`
Mówca: **Sal Ignacius**
> ""Indeed, our religious unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Sal Ignacius: ""Apart from the Golcondists, we have seen a rising Dastnu..."*)

### Węzeł `[707]`
Mówca: **Sal Ignacius**
> ""But our religious unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Sal Ignacius: ""Apart from the Golcondists, we have seen a rising Dastnu..."*)

### Węzeł `[708]`
Mówca: **Sal Ignacius**
> ""Surely you have noticed our religious unity beginning to splinter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Sal Ignacius: ""Apart from the Golcondists, we have seen a rising Dastnu..."*)

### Węzeł `[709]`
Mówca: **Sal Ignacius**
> ""It is true that sharing a single belief system fosters unity among our people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[710]` (*Sal Ignacius: ""But sadly, that unity has begun to splinter in recent ye..."*)

### Węzeł `[710]`
Mówca: **Sal Ignacius**
> ""But sadly, that unity has begun to splinter in recent years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Sal Ignacius: ""Apart from the Golcondists, we have seen a rising Dastnu..."*)

### Węzeł `[711]`
Mówca: **Narrator**
> "Lena had been a follower, but converted to Wruhecism on joining the Rizian royal family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[712]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[712]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[713]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[714]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[713]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[715]` (*Narrator: "A sacrifice, but one she gladly made in order to be with me."*)

### Węzeł `[714]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[716]` (*Narrator: "Her resentment over the sacrifice was palpable throughout..."*)

### Węzeł `[715]`
Mówca: **Narrator**
> "A sacrifice, but one she gladly made in order to be with me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Sal Ignacius: ""I would never counsel this country to turn away people i..."*)

### Węzeł `[716]`
Mówca: **Narrator**
> "Her resentment over the sacrifice was palpable throughout our marriage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[717]` (*Sal Ignacius: ""I would never counsel this country to turn away people i..."*)

### Węzeł `[717]`
Mówca: **Sal Ignacius**
> ""I would never counsel this country to turn away people in need, Your Majesty. But I do worry that our Wruhecist values are in danger of becoming diluted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""The Dastnurists are particularly concerning. Their relig..."*)
  - -> `[71]` (*Player_Romus: ""The Golcondists pose a particularly large threat, using ..."*)
  - -> `[69]` (*Player_Romus: ""As long as you are Grand Wiseman, I'm sure those values ..."*)
  - -> `[72]` (*Player_Romus: ""I wouldn't call it 'diluted.' Supporting a plurality of ..."*)
  - -> `[719]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[718]`
Mówca: **Sal Ignacius**
> ""That's very kind, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "He stopped pacing and looked around the hall."*)

### Węzeł `[719]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[720]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[721]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[720]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[721]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[722]` (*Player_Romus: ""I'll be honest with you. I don't particularly care.""*)

### Węzeł `[722]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be honest with you. I don't particularly care.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[717]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[723]` (*Sal Ignacius: ""Many in this country do, Your Majesty. Ask your uncle.""*)

### Węzeł `[723]`
Mówca: **Sal Ignacius**
> ""Many in this country do, Your Majesty. Ask your uncle.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[724]` (*Narrator: "He stopped pacing and looked around the hall."*)

### Węzeł `[724]`
Mówca: **Narrator**
> "He stopped pacing and looked around the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[884]` (*Sal Ignacius: ""Sanctuaries such as this one are at the core of our reli..."*)

### Węzeł `[725]`
Mówca: **Narrator**
> "He pointed once more to the balcony."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[800]` (*Sal Ignacius: ""I know he wished to return this sacred Wruhecist site to..."*)

### Węzeł `[726]`
Mówca: **Sal Ignacius**
> ""The Crown has funded and nurtured religious institutions since our kingdom's very founding. And for good reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[937]` (*Sal Ignacius: ""The more robust our many religious communities are, the ..."*)

### Węzeł `[727]`
Mówca: **Sal Ignacius**
> ""No Rizian king or queen has ever rejected the holy consecration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[651]` (*Player_Romus: ""Well, there's a first time for everything.""*)
  - -> `[650]` (*Player_Romus: ""I have my own ways of honoring God, and this is not one ..."*)
  - -> `[164]` (*Player_Romus: ""I know this may seem highly unorthodox, but this whole s..."*)
  - -> `[165]` (*Player_Romus: ""I must break with the archaic customs of my predecessors..."*)

### Węzeł `[728]`
Mówca: **Narrator**
> "Sal looked apoplectic."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Sal Ignacius: ""A sovereign leader of this great nation you’re duty-boun..."*)

### Węzeł `[729]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[730]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[731]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[730]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Player_Romus: ""It is the holiest of honors to be allowed here.""*)

### Węzeł `[731]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[732]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[733]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[734]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[733]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[735]` (*Narrator: "Having memorized them years ago, I recited them in unison."*)

### Węzeł `[734]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[736]` (*Narrator: "He slowly fed the words to me, and I repeated them back."*)

### Węzeł `[735]`
Mówca: **Narrator**
> "Having memorized them years ago, I recited them in unison."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "When my garments were completely removed, Sal proceeded t..."*)

### Węzeł `[736]`
Mówca: **Narrator**
> "He slowly fed the words to me, and I repeated them back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "When my garments were completely removed, Sal proceeded t..."*)

### Węzeł `[737]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Oh. Um... I don't drink.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_SoberKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Sal Ignacius: ""Only the most pious and reverent of men may drink from t..."*)

### Węzeł `[738]`
Mówca: **Sal Ignacius**
> ""Only the most pious and reverent of men may drink from the sacred chalice, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[767]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)

### Węzeł `[739]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""About time! I need a drink.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_SoberKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Sal Ignacius: ""Only the most pious and reverent of men may drink from t..."*)

### Węzeł `[740]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Refuse Ceremony`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[727]` (*Sal Ignacius: ""No Rizian king or queen has ever rejected the holy conse..."*)

### Węzeł `[741]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Refuse Ceremony]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[740]` (*Węzeł Logiki Narracyjnej: "Refuse Ceremony"*)

### Węzeł `[742]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Ceremony`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Following the Grand Wiseman's instructions, I joined him ..."*)

### Węzeł `[743]`
Mówca: **Narrator**
> "We continued towards the archsanctuary's entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[744]` (*Sal Ignacius: ""You made the right decision in removing the protesters, ..."*)

### Węzeł `[744]`
Mówca: **Sal Ignacius**
> ""You made the right decision in removing the protesters, Your Majesty. We would not have wanted them disrupting our ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[745]` (*Player_Romus: ""'Golcondism Is Not Blasphemy?' How dare they challenge o..."*)
  - -> `[746]` (*Player_Romus: ""'Who do you think they were?""*)
  - -> `[748]` (*Player_Romus: ""The guards went too easy on them. They should have locke..."*)
  - -> `[753]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[745]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Golcondism Is Not Blasphemy?' How dare they challenge our religious laws?'""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[744]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[751]` (*Sal Ignacius: ""The Golcondists have been irate ever since we began deny..."*)

### Węzeł `[746]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'Who do you think they were?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[744]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[747]` (*Sal Ignacius: ""Definitely Golcondists. Derdian ones, judging by their g..."*)

### Węzeł `[747]`
Mówca: **Sal Ignacius**
> ""Definitely Golcondists. Derdian ones, judging by their garb.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[748]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The guards went too easy on them. They should have locked up the whole lot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[744]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[749]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic -= 1"*)

### Węzeł `[749]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[752]` (*Sal Ignacius: ""Be not too harsh on our Derdian Golcondist brethren. The..."*)

### Węzeł `[750]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those poor lost souls. Is there any hope for them?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[744]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[756]` (*Sal Ignacius: ""Only if they give up their twisted form of Wruhecism and..."*)

### Węzeł `[751]`
Mówca: **Sal Ignacius**
> ""The Golcondists have been irate ever since we began denying them entrance to 'their' holy sites.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[752]`
Mówca: **Sal Ignacius**
> ""Be not too harsh on our Derdian Golcondist brethren. They may yet find their way back to the path of righteousness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[753]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[754]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[755]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[754]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[750]` (*Player_Romus: ""Those poor lost souls. Is there any hope for them?""*)

### Węzeł `[755]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[756]`
Mówca: **Sal Ignacius**
> ""Only if they give up their twisted form of Wruhecism and return to the correct path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Narrator: "He paused with his hand on the door."*)

### Węzeł `[757]`
Mówca: **Sal Ignacius**
> ""A large group of Golcondists came here on one of their holy pilgrimages from Derdia several years ago. An argument with the local Wruhecist worshippers led to an... altercation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[758]` (*Player_Romus: ""Those beasts. Praise the Lord it won't happen again.""*)
  - -> `[759]` (*Player_Romus: ""Are you sure the locals didn't start it? The inhabitants..."*)
  - -> `[760]` (*Player_Romus: ""That's the only reason for our blasphemy law?""*)
  - -> `[761]` (*Player_Romus: ""And why has it not been fixed since then?""*)

### Węzeł `[758]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Those beasts. Praise the Lord it won't happen again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[765]` (*Sal Ignacius: ""Halaita. If it is said, so it is, so it will be.""*)

### Węzeł `[759]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you sure the locals didn't start it? The inhabitants of Cardesse-Montaklar are not exactly conflict-averse.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[764]` (*Sal Ignacius: ""I assure you, the warrior culture of the Derdians makes ..."*)

### Węzeł `[760]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the only reason for our blasphemy law?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[762]` (*Sal Ignacius: ""It was the feather that tipped the scale, so to speak.""*)

### Węzeł `[761]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And why has it not been fixed since then?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[757]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[763]` (*Sal Ignacius: ""We will get to that.""*)

### Węzeł `[762]`
Mówca: **Sal Ignacius**
> ""It was the feather that tipped the scale, so to speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "Sal began to pace around the altar."*)

### Węzeł `[763]`
Mówca: **Sal Ignacius**
> ""We will get to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "Sal began to pace around the altar."*)

### Węzeł `[764]`
Mówca: **Sal Ignacius**
> ""I assure you, the warrior culture of the Derdians makes the Azaros look meek.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "Sal began to pace around the altar."*)

### Węzeł `[765]`
Mówca: **Sal Ignacius**
> ""Halaita. If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[829]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita = true;"*)

### Węzeł `[766]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I'm not thirsty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[738]` (*Sal Ignacius: ""Only the most pious and reverent of men may drink from t..."*)

### Węzeł `[767]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[768]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious > 0"*)
  - -> `[769]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious > 0)"*)

### Węzeł `[768]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[770]` (*Sal Ignacius: ""That will not be you. At least not today.""*)

### Węzeł `[769]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[771]` (*Sal Ignacius: ""That will not be you. Not today, and possibly not ever.""*)

### Węzeł `[770]`
Mówca: **Sal Ignacius**
> ""That will not be you. At least not today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Sal Ignacius: ""You see, once this wine is consumed, Caelus the Devout's..."*)

### Węzeł `[771]`
Mówca: **Sal Ignacius**
> ""That will not be you. Not today, and possibly not ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Sal Ignacius: ""You see, once this wine is consumed, Caelus the Devout's..."*)

### Węzeł `[772]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This ceremony has exceeded the limits of reason. I cannot participate in good conscience.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[133]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[818]` (*Sal Ignacius: ""Interrupting the ritual will have long-lasting consequen..."*)

### Węzeł `[773]`
Mówca: **Sal Ignacius**
> ""This not a promising start to your reign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Sal Ignacius: ""I must stay here until the visions run their course. Ple..."*)

### Węzeł `[774]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[775]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious < 0"*)
  - -> `[776]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious < 0)"*)

### Węzeł `[775]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[777]` (*Sal Ignacius: ""I sense skepticism in you, Your Majesty. But please know..."*)

### Węzeł `[776]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[779]` (*Sal Ignacius: ""Surely you now feel it, Your Majesty. The will of the Di..."*)

### Węzeł `[777]`
Mówca: **Sal Ignacius**
> ""I sense skepticism in you, Your Majesty. But please know that as the King of Rizia, the will of the Divine now courses through your veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Sal Ignacius: ""It is your responsibility to carry out what He has ordai..."*)

### Węzeł `[778]`
Mówca: **Sal Ignacius**
> ""It is your responsibility to carry out what He has ordained. And it is mine to aid you in your holy duty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[780]` (*Player_Romus: ""It is a heavy burden, Grand Wiseman. But I accept it.""*)
  - -> `[781]` (*Player_Romus: ""I am an instrument of nobody. Not God, and definitely no..."*)
  - -> `[782]` (*Player_Romus: ""I pray that He and you will guide me to do what is best ..."*)
  - -> `[783]` (*Player_Romus: ""I must confess that I'm not entirely convinced about wha..."*)

### Węzeł `[779]`
Mówca: **Sal Ignacius**
> ""Surely you now feel it, Your Majesty. The will of the Divine coursing through your veins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[778]` (*Sal Ignacius: ""It is your responsibility to carry out what He has ordai..."*)

### Węzeł `[780]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is a heavy burden, Grand Wiseman. But I accept it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[778]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 2;"*)

### Węzeł `[781]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am an instrument of nobody. Not God, and definitely not you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[778]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[784]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 2;"*)

### Węzeł `[782]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I pray that He and you will guide me to do what is best for our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[778]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[785]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 2;"*)

### Węzeł `[783]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I must confess that I'm not entirely convinced about what transpired here today. But if it helps appease the masses, count me in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[778]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Narrator: "He frowned."*)

### Węzeł `[784]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[786]` (*Narrator: "He frowned."*)

### Węzeł `[785]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 2;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[788]` (*Sal Ignacius: ""Halaita.""*)

### Węzeł `[786]`
Mówca: **Narrator**
> "He frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[787]` (*Sal Ignacius: ""You will see the light one day. I am confident of it.""*)

### Węzeł `[787]`
Mówca: **Sal Ignacius**
> ""You will see the light one day. I am confident of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "Leaving Hub"*)

### Węzeł `[788]`
Mówca: **Sal Ignacius**
> ""Halaita.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[975]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious >= 3"*)

### Węzeł `[789]`
Mówca: **Narrator**
> "I nodded in agreement at the ancient Wruhecist term. It was short for "Decensi halaita veretan": "If it is said, so it is, so it will be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Narrator: "One of the Grand Wiseman priests handed him a wooden case."*)

### Węzeł `[790]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "AddConversant("Titus Gordion");"*)

### Węzeł `[791]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "I wished Wiseman Ignacius goodbye and left the premises. ..."*)

### Węzeł `[792]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Narrator: "I wished Sal goodbye and left the premises. Captain Gordi..."*)

### Węzeł `[793]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Narrator: "I bid Wiseman Ignacius farewell and departed the premises..."*)

### Węzeł `[794]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated = false`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "I wished Wiseman Ignacius goodbye and left the premises. ..."*)

### Węzeł `[795]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "I followed the Grand Wiseman down a long corridor."*)

### Węzeł `[796]`
Mówca: **Narrator**
> "Only a select few, such as Grand Wiseman and religious councilor Sal Ignacius, were privy to what the ceremony entailed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Not even my father, despite my asking, would disclose wha..."*)

### Węzeł `[797]`
Mówca: **Narrator**
> "As I stepped out and onto the pavement, I was immediately greeted by the roar of a crowd that had come to witness my arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "While most shouted my praises, there was a small group of..."*)

### Węzeł `[798]`
Mówca: **Narrator**
> "I performed variations of this toward different sections of the crowd, much to their amusement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "A welcoming smile spread across the Grand Wiseman's face ..."*)

### Węzeł `[799]`
Mówca: **Narrator**
> "It was the traditional reply meaning, "He is the Lord our God; his covenant is everlasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[835]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[800]`
Mówca: **Sal Ignacius**
> ""I know he wished to return this sacred Wruhecist site to its former grandeur. He agreed with me that state funds should be allocated for the project.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Sal Ignacius: ""However, he was also deluged with requests from the Dast..."*)

### Węzeł `[801]`
Mówca: **Narrator**
> "Amidst the commotion, one managed to slip from their grasp and dashed towards me with frightening speed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus_Italic: "Hurry towards the archsanctuary."*)
  - -> `[38]` (*Player_Romus_Italic: "Stand your ground."*)

### Węzeł `[802]`
Mówca: **Narrator**
> "After my flesh was fully coated, he set aside the jug and sponge, reaching for the chalice and bottle of wine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "He then poured the wine into the chalice until it reached..."*)

### Węzeł `[803]`
Mówca: **Narrator**
> "If it was, did I accept the responsibility that came with my consecration?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[805]` (*Narrator: "Did I really speak for the Divine?"*)

### Węzeł `[804]`
Mówca: **Sal Ignacius**
> ""That's the gift and the curse that comes with the divine right of the king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Narrator: "After a long moment, during which he seemed to still be r..."*)

### Węzeł `[805]`
Mówca: **Narrator**
> "Did I really speak for the Divine?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "Before long, I was back on the road again -- back to real..."*)

### Węzeł `[806]`
Mówca: **Sal Ignacius**
> ""A lamb... I see a charming little lamb...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[813]` (*Sal Ignacius: ""Once separated from its flock by a great wolf, it now re..."*)

### Węzeł `[807]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_EyesOpen = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "We stood there in silence for what felt like an eternity...."*)

### Węzeł `[808]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_EyesOpen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[809]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)
  - -> `[810]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_EyesOpen == true)"*)

### Węzeł `[809]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_EyesOpen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[811]` (*Narrator: "He paused, deep in thought, then let out a small laugh, s..."*)

### Węzeł `[810]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_EyesOpen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_EyesOpen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[812]` (*Narrator: "He paused, deep in thought, then let out a small laugh."*)

### Węzeł `[811]`
Mówca: **Narrator**
> "He paused, deep in thought, then let out a small laugh, smiling to himself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Sal Ignacius: ""A lamb... I see a charming little lamb...""*)

### Węzeł `[812]`
Mówca: **Narrator**
> "He paused, deep in thought, then let out a small laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[806]` (*Sal Ignacius: ""A lamb... I see a charming little lamb...""*)

### Węzeł `[813]`
Mówca: **Sal Ignacius**
> ""Once separated from its flock by a great wolf, it now reunites with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[815]` (*Player_Romus: ""Bringing the faithful back into the fold, perhaps?""*)
  - -> `[814]` (*Player_Romus: ""It clearly speaks of Zille's return.""*)
  - -> `[816]` (*Player_Romus_Italic: "Sigh in frustration."*)
  - -> `[986]` (*Player_Romus_Italic: "Hold your tongue."*)

### Węzeł `[814]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It clearly speaks of Zille's return.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[813]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Sal Ignacius: ""And on a nearby mountain overlooking the city sits a bea..."*)

### Węzeł `[815]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bringing the faithful back into the fold, perhaps?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[813]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[817]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1;"*)

### Węzeł `[816]`
**[WYBÓR GRACZA: "Sigh in frustration."]** — Mówca: **Player_Romus_Italic**
> "I sighed in frustration as I grew increasingly tired of this charade."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[813]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Sal Ignacius: ""And on a nearby mountain overlooking the city sits a bea..."*)

### Węzeł `[817]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Sal Ignacius: ""And on a nearby mountain overlooking the city sits a bea..."*)

### Węzeł `[818]`
Mówca: **Sal Ignacius**
> ""Interrupting the ritual will have long-lasting consequences.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Sal Ignacius: ""I must insist that you take my hand, or else I cannot be..."*)

### Węzeł `[819]`
Mówca: **Narrator**
> "There was a flash of irritation in his eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Sal Ignacius: ""What I wanted to say was... burn too many bridges -- esp..."*)

### Węzeł `[820]`
Mówca: **Sal Ignacius**
> ""More often than not, friends and foes are indistinguishable from one another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Sal Ignacius: ""It would be a shame if any unnecessary strains or hostil..."*)

### Węzeł `[821]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Unless you're aiming for a medieval revival of the Dark Ages...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[824]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1;"*)

### Węzeł `[822]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope I've made myself clear.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[823]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Now if you'll excuse me, I'll see myself out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[824]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[825]`
Mówca: **Sal Ignacius**
> ""But in light of your generous support, I see no reason why the public has to no any differently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Sal Ignacius: ""As long as similar... *arrangements* can be made in the ..."*)

### Węzeł `[826]`
Mówca: **Sal Ignacius**
> ""However, keeping an open mind through curiosity and skepticism lies at the heart of Wruhecism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Sal Ignacius: ""While I have my reservations about what you're suggestin..."*)

### Węzeł `[827]`
Mówca: **Sal Ignacius**
> ""That would be much appreciated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Sal Ignacius: ""For now, let us proceed with your consecration.""*)

### Węzeł `[828]`
Mówca: **Sal Ignacius**
> ""The only convincing you need isn't from me but from God. And He isn't so easily swayed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[792]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[829]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[690]` (*Narrator: "Sal began to pace around the altar."*)

### Węzeł `[830]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[831]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true"*)
  - -> `[832]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true)"*)

### Węzeł `[831]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[833]` (*Narrator: "I nodded in agreement at the ancient Wruhecist term."*)

### Węzeł `[832]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[789]` (*Narrator: "I nodded in agreement at the ancient Wruhecist term. It w..."*)

### Węzeł `[833]`
Mówca: **Narrator**
> "I nodded in agreement at the ancient Wruhecist term."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[866]` (*Narrator: "One of the Grand Wiseman priests handed him a wooden case."*)

### Węzeł `[834]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Sal Ignacius: "“The six stars of St. Wruhec still shine upon our nation.""*)

### Węzeł `[835]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "A welcoming smile spread across the Grand Wiseman's face ..."*)

### Węzeł `[836]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[837]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[838]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[837]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Player_Romus_Italic: "Recite a Wruhecist proverb."*)

### Węzeł `[838]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[839]`
Mówca: **Sal Ignacius**
> ""Rightly so. Nobody should attack the King of Rizia, especially not for upholding our religious laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Sal Ignacius: ""I believe he was a Derdian Golcondist. He was wearing th..."*)

### Węzeł `[840]`
Mówca: **Narrator**
> "He made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[672]` (*Sal Ignacius: ""Among other perversions.""*)

### Węzeł `[841]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“He got all this just for *teaching*? My own final resting place had better be even grander.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[843]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 1;"*)

### Węzeł `[842]`
Mówca: **Sal Ignacius**
> ""To use one's wisdom to enlighten others is to do the Lord's work.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[844]` (*Sal Ignacius: ""I would like to think I am honoring Caelus the Devout's ..."*)

### Węzeł `[843]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[842]` (*Sal Ignacius: ""To use one's wisdom to enlighten others is to do the Lor..."*)

### Węzeł `[844]`
Mówca: **Sal Ignacius**
> ""I would like to think I am honoring Caelus the Devout's legacy by passing my own limited knowledge to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "We stopped when we'd reached the chancel where the altar ..."*)

### Węzeł `[845]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[709]` (*Sal Ignacius: ""It is true that sharing a single belief system fosters u..."*)

### Węzeł `[846]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Ceremony]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[742]` (*Węzeł Logiki Narracyjnej: "Ceremony"*)

### Węzeł `[847]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[848]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[849]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[848]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[850]` (*Player_Romus: "“The holy books do tell of mystical events occurring on t..."*)
  - -> `[115]` (*Player_Romus: "“Even as a religious man, I have trouble believing in mir..."*)

### Węzeł `[849]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: "“I’ve never heard of disciples performing miracles before.”"*)
  - -> `[114]` (*Player_Romus: "“I have gone along with you thus far. But are you really ..."*)

### Węzeł `[850]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“The holy books do tell of mystical events occurring on this site, but they are unclear as to their nature.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[111]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[851]` (*Sal Ignacius: "“I shall enlighten you. This is where Caelus received the..."*)

### Węzeł `[851]`
Mówca: **Sal Ignacius**
> "“I shall enlighten you. This is where Caelus received the gift of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Sal Ignacius: ""For upon filling his stomach with the sacred wine -- the..."*)

### Węzeł `[852]`
Mówca: **Sal Ignacius**
> "“I refer to the miracle of foresight.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Sal Ignacius: ""For upon filling his stomach with the sacred wine -- the..."*)

### Węzeł `[853]`
Mówca: **Sal Ignacius**
> ""I have spent the past weeks cloistered here, fasting and praying, in order to transform myself into a vessel for the visions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "He held up the chalice, once more, and drank until the wi..."*)

### Węzeł `[854]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Having said that... can't you overlook my abstention? I don't want news getting out that I refused this rite.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[190]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[855]` (*Sal Ignacius: ""Are you asking a holy man to lie, Your Majesty?""*)

### Węzeł `[855]`
Mówca: **Sal Ignacius**
> ""Are you asking a holy man to lie, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[857]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)

### Węzeł `[856]`
Mówca: **Sal Ignacius**
> ""You prioritized it over Plavo's restoration, despite my advice. And you wish to be rewarded for it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[572]` (*Player_Romus: ""What if I made it worth your while?""*)
  - -> `[584]` (*Player_Romus: ""You're right. Forget what I said. 'Til next time.""*)
  - -> `[573]` (*Player_Romus: ""What if I told you there would be consequences for defyi..."*)

### Węzeł `[857]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[858]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project..."*)
  - -> `[859]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Proje..."*)

### Węzeł `[858]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Sal Ignacius: ""The importance of the ceremony cannot be overstated.""*)

### Węzeł `[859]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_PlavoSanctuaryRestoration_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Sal Ignacius: ""That's asking a lot. The importance of the ceremony cann..."*)

### Węzeł `[860]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[791]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[861]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[862]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating ..."*)
  - -> `[863]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipatin..."*)

### Węzeł `[862]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[864]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCe..."*)

### Węzeł `[863]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_ReligiousCeremony_LiedAboutParticipating"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn01_RH_Religion_NoParticipatedCer..."*)

### Węzeł `[864]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn01_RH_Religion_YesParticipatedCeremony"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[865]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Religion_DivusZaitu = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_Religion_DivusZaitu"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: ""Divus zaitu" was Wruhecist for "May God be with you.""*)

### Węzeł `[866]`
Mówca: **Narrator**
> "One of the Grand Wiseman priests handed him a wooden case."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[867]` (*Sal Ignacius: ""In honor of this momentous day, I would like to bestow u..."*)

### Węzeł `[867]`
Mówca: **Sal Ignacius**
> ""In honor of this momentous day, I would like to bestow upon you one of the most sacred Nurist relics in Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[868]` (*Narrator: "He opened the case to reveal an intricately decorated sce..."*)

### Węzeł `[868]`
Mówca: **Narrator**
> "He opened the case to reveal an intricately decorated scepter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[869]` (*Sal Ignacius: ""St. Dast's Scepter.""*)

### Węzeł `[869]`
Mówca: **Sal Ignacius**
> ""St. Dast's Scepter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[870]` (*Sal Ignacius: ""It was said that before the time of St. Wruhec, master a..."*)

### Węzeł `[870]`
Mówca: **Sal Ignacius**
> ""It was said that before the time of St. Wruhec, master artisan Dorian Etxeberria had a vivid dream in which St. Dast appeared, urging him to create the scepter to encapsulate the Pillars of Nurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[871]` (*Sal Ignacius: ""Driven by this divine vision, Dorian meticulously design..."*)

### Węzeł `[871]`
Mówca: **Sal Ignacius**
> ""Driven by this divine vision, Dorian meticulously designed and forged the scepter, believing it to be his sacred duty to honor the saint's legacy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[872]` (*Sal Ignacius: ""And now, I give it to you.""*)

### Węzeł `[872]`
Mówca: **Sal Ignacius**
> ""And now, I give it to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[876]` (*Player_Romus_Italic: "Take the scepter."*)
  - -> `[877]` (*Player_Romus_Italic: "Don't take the scepter."*)

### Węzeł `[873]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I shall wield this with pride, so all who see me will be reminded that I walk in Nur's holy light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[930]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[874]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A reminder that while we espouse the six tenets of Wruhecism now, it was St. Dast who created the original foundations of our faith.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[935]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_DastnuristOpinion += 1;"*)

### Węzeł `[875]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am deeply humbled and profoundly grateful for this extraordinary honor.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[876]`
**[WYBÓR GRACZA: "Take the scepter."]** — Mówca: **Player_Romus_Italic**
> "I took the scepter from him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[872]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[927]` (*Węzeł Logiki Narracyjnej: "EnableCollectionItem("CollectionItem_DastScepter");"*)

### Węzeł `[877]`
**[WYBÓR GRACZA: "Don't take the scepter."]** — Mówca: **Player_Romus_Italic**
> "I didn't take the scepter from him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[872]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[878]` (*Player_Romus: ""I'm honored, but I believe it would be better suited und..."*)
  - -> `[931]` (*Player_Romus: ""This represents Dast's eleven pillars, not Wruhec's six ..."*)
  - -> `[879]` (*Player_Romus: ""Thanks, but I have enough scepters. You keep it.""*)
  - -> `[880]` (*Player_Romus: ""I appreciate the gesture, but I'm not worthy of such a g..."*)

### Węzeł `[878]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm honored, but I believe it would be better suited under your esteemed care and guardianship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[877]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Sal Ignacius: ""As you wish.""*)

### Węzeł `[879]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks, but I have enough scepters. You keep it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[877]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Sal Ignacius: ""As you wish.""*)

### Węzeł `[880]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the gesture, but I'm not worthy of such a gift.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[877]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[881]` (*Sal Ignacius: ""As you wish.""*)

### Węzeł `[881]`
Mówca: **Sal Ignacius**
> ""As you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[882]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Leaving Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyParticipated =..."*)

### Węzeł `[883]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Leaving Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "Leaving Hub"*)

### Węzeł `[884]`
Mówca: **Sal Ignacius**
> ""Sanctuaries such as this one are at the core of our religious communities. Without a place to congregate, the faithful are left wandering without guidance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[885]` (*Sal Ignacius: ""And I am sorry to say your father -- Nur bless his soul ..."*)

### Węzeł `[885]`
Mówca: **Sal Ignacius**
> ""And I am sorry to say your father -- Nur bless his soul -- left us with quite a bit of work to do with regard to their upkeep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[725]` (*Narrator: "He pointed once more to the balcony."*)

### Węzeł `[886]`
Mówca: **Sal Ignacius**
> ""Afraid of angering one religious group by prioritizing the needs of the other, he funded neither.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]` (*Węzeł Logiki Narracyjnej: "Sanctuary Q Hub"*)

### Węzeł `[887]`
Mówca: **Sal Ignacius**
> ""This may be true, but Wehlen and Rumburg are both watching our treatment of Dastnurists closely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[888]` (*Sal Ignacius: ""Focusing on the restoration of Plavo will strengthen our..."*)

### Węzeł `[888]`
Mówca: **Sal Ignacius**
> ""Focusing on the restoration of Plavo will strengthen our domestic Wruhecist community, but ignoring the plight of Dastnurists may damage our international standing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)

### Węzeł `[889]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[890]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[891]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[890]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player_Romus: ""Both projects are equally important in my eyes. I will s..."*)

### Węzeł `[891]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[892]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You brought me here to make a funding decision, under the guise of a ritual? The greed of the Sanctuary truly knows no bounds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[893]` (*Narrator: "The holy man withdrew, looking hurt."*)

### Węzeł `[893]`
Mówca: **Narrator**
> "The holy man withdrew, looking hurt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[894]` (*Sal Ignacius: ""My intention was not to pressure you, only to inform you..."*)

### Węzeł `[894]`
Mówca: **Sal Ignacius**
> ""My intention was not to pressure you, only to inform you of the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[895]` (*Sal Ignacius: ""But now that you have seen the state Plavo is in, I am s..."*)

### Węzeł `[895]`
Mówca: **Sal Ignacius**
> ""But now that you have seen the state Plavo is in, I am sure you understand how urgently it must be restored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[901]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[918]` (*Player_Romus: ""Luckily for you, the well-being of Rizia's religious com..."*)
  - -> `[908]` (*Player_Romus: ""I understand when I'm being manipulated. Don't bother me..."*)
  - -> `[911]` (*Player_Romus: ""I prefer it this way. It reminds one that God is as capa..."*)

### Węzeł `[896]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We are in a holy place, Grand Wiseman. I refuse to sully it with deliberations over finances.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[657]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[897]` (*Narrator: "The holy man drew in his breath."*)

### Węzeł `[897]`
Mówca: **Narrator**
> "The holy man drew in his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[898]` (*Sal Ignacius: ""You are absolutely right, Your Majesty. Now is not the t..."*)

### Węzeł `[898]`
Mówca: **Sal Ignacius**
> ""You are absolutely right, Your Majesty. Now is not the time to speak of such vulgar things as money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[899]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[899]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[916]` (*Sal Ignacius: ""Let us proceed with your consecration at once.""*)

### Węzeł `[900]`
**[WYBÓR GRACZA: ""Don't worry, Plavo will get its funding. But next time, come straight out and ask me." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Don't worry, Plavo will get its funding. But next time, come straight out and ask me.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[895]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[904]` (*Narrator: "Sal bowed in gratitude."*)

### Węzeł `[901]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[902]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[903]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[902]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[900]` (*Player_Romus: ""Don't worry, Plavo will get its funding. But next time, ..."*)
  - -> `[906]` (*Player_Romus: ""Quite the contrary. Plavo can wait. I'll allocate funds ..."*)

### Węzeł `[903]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[904]`
Mówca: **Narrator**
> "Sal bowed in gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[905]` (*Sal Ignacius: ""Of course, Your Majesty. Thank you.""*)

### Węzeł `[905]`
Mówca: **Sal Ignacius**
> ""Of course, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "EnactDecree("Religion_RestorationPlavoArchsanctuary"); Ri..."*)

### Węzeł `[906]`
**[WYBÓR GRACZA: ""Quite the contrary. Plavo can wait. I'll allocate funds for that Dastnurist Grandsanctuary you mentioned." [-2 Budget]"]** — Mówca: **Player_Romus**
> ""Quite the contrary. Plavo can wait. I'll allocate funds for that Dastnurist Grandsanctuary you mentioned.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Kontekst wejściowy (poprzednik):** `[895]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[907]` (*Narrator: "Sal nodded, clearly disappointed."*)

### Węzeł `[907]`
Mówca: **Narrator**
> "Sal nodded, clearly disappointed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Sal Ignacius: "“I see the wisdom in your decision. May God’s shining lig..."*)

### Węzeł `[908]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand when I'm being manipulated. Don't bother me with these requests again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[895]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[909]` (*Narrator: "He nodded hurriedly."*)

### Węzeł `[909]`
Mówca: **Narrator**
> "He nodded hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[910]` (*Sal Ignacius: ""I won't, Your Majesty. I am sorry.""*)

### Węzeł `[910]`
Mówca: **Sal Ignacius**
> ""I won't, Your Majesty. I am sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[914]` (*Sal Ignacius: "“If you'll allow me, we shall proceed with the Consecrati..."*)

### Węzeł `[911]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I prefer it this way. It reminds one that God is as capable of destruction as He is of creation.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[895]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[912]` (*Sal Ignacius: ""Y-yes, it is beautiful in its own way...""*)

### Węzeł `[912]`
Mówca: **Sal Ignacius**
> ""Y-yes, it is beautiful in its own way...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[913]` (*Sal Ignacius: ""At any rate, I will trouble you with this no further. It..."*)

### Węzeł `[913]`
Mówca: **Sal Ignacius**
> ""At any rate, I will trouble you with this no further. It is almost time for the ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Sal spread his arms wide open."*)

### Węzeł `[914]`
Mówca: **Sal Ignacius**
> "“If you'll allow me, we shall proceed with the Consecration of the King ceremony.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 1;"*)

### Węzeł `[915]`
Mówca: **Sal Ignacius**
> ""This is a most auspicious start to today's ceremony. And God willing, it is only the beginning of Rizia's religious renaissance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Sal spread his arms wide open."*)

### Węzeł `[916]`
Mówca: **Sal Ignacius**
> ""Let us proceed with your consecration at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Sal spread his arms wide open."*)

### Węzeł `[917]`
Mówca: **Sal Ignacius**
> ""For now, let us proceed with your consecration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Narrator: "Sal spread his arms wide open."*)

### Węzeł `[918]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Luckily for you, the well-being of Rizia's religious communities is important to me. I will consider your requests.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[895]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[919]` (*Narrator: "Sal bowed in gratitude."*)

### Węzeł `[919]`
Mówca: **Narrator**
> "Sal bowed in gratitude."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[920]` (*Sal Ignacius: ""Most kind of you, Your Majesty. Thank you.""*)

### Węzeł `[920]`
Mówca: **Sal Ignacius**
> ""Most kind of you, Your Majesty. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[917]` (*Sal Ignacius: ""For now, let us proceed with your consecration.""*)

### Węzeł `[921]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A commoner, buried among the Montaklar nobility? What an insult.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[926]` (*Sal Ignacius: ""With the love of God in his heart, any man can achieve g..."*)

### Węzeł `[922]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A pioneer to whom we all owe a debt of gratitude. Rizia could use more innovators like him.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[924]` (*Sal Ignacius: ""As long as they remember that it is by the Lord's grace,..."*)

### Węzeł `[923]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's his fault Rizia became so reliant on resources. Perhaps we would have been better off leaving that gold in the ground.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[494]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[925]` (*Sal Ignacius: ""The Lord put that gold in the ground to enrich our natio..."*)

### Węzeł `[924]`
Mówca: **Sal Ignacius**
> ""As long as they remember that it is by the Lord's grace, not man's, that Rizia is blessed with such abundant resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 = true;"*)

### Węzeł `[925]`
Mówca: **Sal Ignacius**
> ""The Lord put that gold in the ground to enrich our nation, Your Majesty. So that we may better exalt His good name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 = true;"*)

### Węzeł `[926]`
Mówca: **Sal Ignacius**
> ""With the love of God in his heart, any man can achieve greatness. No matter how lowborn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_Briefing_Religion_Body02 = true;"*)

### Węzeł `[927]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableCollectionItem("CollectionItem_DastScepter");`
- **Efekt skryptowy (`userScript`):** `EnableCollectionItem("CollectionItem_DastScepter");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[875]` (*Player_Romus: ""I am deeply humbled and profoundly grateful for this ext..."*)
  - -> `[874]` (*Player_Romus: ""A reminder that while we espouse the six tenets of Wruhe..."*)
  - -> `[873]` (*Player_Romus: ""I shall wield this with pride, so all who see me will be..."*)
  - -> `[928]` (*Player_Romus: ""A big stick. How useful.""*)

### Węzeł `[928]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A big stick. How useful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[876]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[929]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_FunnyKing += 1"*)

### Węzeł `[929]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_FunnyKing += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_FunnyKing"] = Variable["RiziaDLC.PersonalValue_FunnyKing"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[930]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[931]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This represents Dast's eleven pillars, not Wruhec's six core tenets. Dastnurists will see it as an endorsement of their faith.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[877]` (Player_Romus_Italic)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[932]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[932]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[933]` (*Sal Ignacius: ""I see the scepter as a reminder of our shared Nurist ori..."*)

### Węzeł `[933]`
Mówca: **Sal Ignacius**
> ""I see the scepter as a reminder of our shared Nurist origins. Our Wruhec refined the teachings of St. Dast. He did not contradict them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[934]` (*Sal Ignacius: ""But as you wish.""*)

### Węzeł `[934]`
Mówca: **Sal Ignacius**
> ""But as you wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[935]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_DastnuristOpinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Country_DastnuristOpinion"] = Variable["RiziaDLC.Country_DastnuristOpinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[883]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leaving Hub]"*)

### Węzeł `[936]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Sanctuary Q Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[967]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Budget == false"*)
  - -> `[949]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false"*)
  - -> `[945]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false"*)
  - -> `[970]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || Riz..."*)

### Węzeł `[937]`
Mówca: **Sal Ignacius**
> ""The more robust our many religious communities are, the greater the tithings we can collect for the monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[938]` (*Sal Ignacius: ""To put it in earthly terms... keep Rizia's faithful happ..."*)

### Węzeł `[938]`
Mówca: **Sal Ignacius**
> ""To put it in earthly terms... keep Rizia's faithful happy, and new sanctuaries will pay for themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1004]` (*Sal Ignacius: ""But neglect them, and unrest could follow. Four decades ..."*)

### Węzeł `[939]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "“Why was he so afraid of angering Dastnurists? They make up only a small part of the population, after all.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false`
- **Kontekst wejściowy (poprzednik):** `[886]` (Sal Ignacius), `[888]` (Sal Ignacius), `[958]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[948]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Dastnurists = true"*)

### Węzeł `[940]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[941]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[942]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[941]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[944]` (*Sal Ignacius: ""Considering the state of our treasury, I don't know what..."*)

### Węzeł `[942]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[943]` (*Sal Ignacius: ""Rightfully so, considering the state of our treasury.""*)

### Węzeł `[943]`
Mówca: **Sal Ignacius**
> ""Rightfully so, considering the state of our treasury.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[962]` (*Sal Ignacius: ""A pity. With enough funds, you and I could build new san..."*)

### Węzeł `[944]`
Mówca: **Sal Ignacius**
> ""Considering the state of our treasury, I don't know what he was worried about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[953]` (*Sal Ignacius: ""With the entire religious community's attention on today..."*)

### Węzeł `[945]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[946]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false"*)
  - -> `[947]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false)"*)

### Węzeł `[946]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[939]` (*Player_Romus: "“Why was he so afraid of angering Dastnurists? They make ..."*)

### Węzeł `[947]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[948]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Dastnurists = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[887]` (*Sal Ignacius: ""This may be true, but Wehlen and Rumburg are both watchi..."*)

### Węzeł `[949]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[950]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false"*)
  - -> `[951]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false)"*)

### Węzeł `[950]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: "“Why is it the government's responsibility to fund sanctu..."*)

### Węzeł `[951]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[952]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[726]` (*Sal Ignacius: ""The Crown has funded and nurtured religious institutions..."*)

### Węzeł `[953]`
Mówca: **Sal Ignacius**
> ""With the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order. And from there, we can construct new sanctuaries all over the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]` (*Player_Romus: ""So that more people may bask in God's glory.""*)
  - -> `[955]` (*Player_Romus: ""I get what you're saying. If we keep our people busy wit..."*)
  - -> `[956]` (*Player_Romus: ""The Crown's money should be spent on improving our citiz..."*)
  - -> `[963]` (*Player_Romus: ""I aim to transform Rizia into a strong, modern nation. I..."*)

### Węzeł `[954]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So that more people may bask in God's glory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[953]` (Sal Ignacius), `[962]` (Sal Ignacius), `[999]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[957]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[955]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I get what you're saying. If we keep our people busy with religion, we won't have to worry about them turning against us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[953]` (Sal Ignacius), `[962]` (Sal Ignacius), `[999]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[959]` (*Sal Ignacius: ""Spreading the great word of Nur is my goal, Your Majesty..."*)

### Węzeł `[956]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Crown's money should be spent on improving our citizens' welfare, regardless of their religion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[953]` (Sal Ignacius), `[962]` (Sal Ignacius), `[999]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[961]` (*Sal Ignacius: ""Do not neglect the importance of spiritual welfare, Your..."*)

### Węzeł `[957]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[958]` (*Sal Ignacius: ""Precisely.""*)

### Węzeł `[958]`
Mówca: **Sal Ignacius**
> ""Precisely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)

### Węzeł `[959]`
Mówca: **Sal Ignacius**
> ""Spreading the great word of Nur is my goal, Your Majesty. Not pacification.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[960]` (*Sal Ignacius: ""But you are right that our citizens are less likely to s..."*)

### Węzeł `[960]`
Mówca: **Sal Ignacius**
> ""But you are right that our citizens are less likely to stir up turmoil when their spiritual needs are met.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)

### Węzeł `[961]`
Mówca: **Sal Ignacius**
> ""Do not neglect the importance of spiritual welfare, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)

### Węzeł `[962]`
Mówca: **Sal Ignacius**
> ""A pity. With enough funds, you and I could build new sanctuaries all across the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]` (*Player_Romus: ""So that more people may bask in God's glory.""*)
  - -> `[955]` (*Player_Romus: ""I get what you're saying. If we keep our people busy wit..."*)
  - -> `[956]` (*Player_Romus: ""The Crown's money should be spent on improving our citiz..."*)
  - -> `[963]` (*Player_Romus: ""I aim to transform Rizia into a strong, modern nation. I..."*)

### Węzeł `[963]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I aim to transform Rizia into a strong, modern nation. I'm not going to waste time catering to the whims of its fanatics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[953]` (Sal Ignacius), `[962]` (Sal Ignacius), `[999]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[965]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious -= 1"*)

### Węzeł `[964]`
Mówca: **Sal Ignacius**
> ""The majority of our citizens hold Nurist beliefs, Your Majesty. You won't get far by calling them 'fanatics'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)

### Węzeł `[965]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[964]` (*Sal Ignacius: ""The majority of our citizens hold Nurist beliefs, Your M..."*)

### Węzeł `[966]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Budget = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Sal Ignacius: ""I agree, Your Majesty, but King Valero was hesitant to l..."*)

### Węzeł `[967]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Budget == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[968]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Budget == false"*)
  - -> `[969]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SanctuaryQHub_Budget == false)"*)

### Węzeł `[968]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Budget == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""Why didn't he just fund both projects?""*)
  - -> `[988]` (*Player_Romus: ""Such a grand expenditure would certainly drain the Crown..."*)

### Węzeł `[969]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SanctuaryQHub_Budget == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[970]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[971]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || Riz..."*)
  - -> `[972]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || R..."*)

### Węzeł `[971]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[973]` (*Player_Romus: ""Here's what I think.""*)

### Węzeł `[972]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.SanctuaryQHub_Dastnurists == true || RiziaDLCIsolated.SanctuaryQHub_Budget == true || RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[973]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Here's what I think.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Dastnurists"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == true  or  Variable["RiziaDLCIsolated.SanctuaryQHub_ReligiousRevenues"] == true`
- **Kontekst wejściowy (poprzednik):** `[886]` (Sal Ignacius), `[888]` (Sal Ignacius), `[958]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[657]` (*Narrator: "Sal closed his eyes and tilted his head up slightly, awai..."*)

### Węzeł `[974]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Sanctuary Q Hub]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[936]` (*Węzeł Logiki Narracyjnej: "Sanctuary Q Hub"*)

### Węzeł `[975]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[976]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious >= 3"*)
  - -> `[977]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Religious >= 3)"*)

### Węzeł `[976]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious >= 3`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Religious"] >= 3`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[830]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_ReligiousCeremony_Halaita == true"*)

### Węzeł `[977]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Religious >= 3)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Religious"] >= 3) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[882]` (*Węzeł Logiki Narracyjnej: "Leaving Hub"*)

### Węzeł `[978]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Sal Ignacius: ""It warms my heart to hear it.""*)

### Węzeł `[979]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_ReligiousBrief_YourBest = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn01_ReligiousBrief_YourBest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""Don't let my physical frailty fool you, Your Majesty. Fo..."*)

### Węzeł `[980]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mind is made up. Goodbye.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Sal gasped in astonishment as I made an about-face and he..."*)

### Węzeł `[981]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [VisionHub1]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "VisionHub1"*)

### Węzeł `[982]`
**[WYBÓR GRACZA: "Remain silent and continue listening."]** — Mówca: **Player_Romus_Italic**
> "I remained silent and continued listening."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[266]` (Sal Ignacius), `[270]` (Sal Ignacius), `[359]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "I continued to listen closely to his words."*)

### Węzeł `[983]`
**[WYBÓR GRACZA: "Listen without interruption."]** — Mówca: **Player_Romus_Italic**
> "I listened without interrupting."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Sal Ignacius), `[396]` (Sal Ignacius), `[377]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Sal Ignacius: ""Before me now is a heart... it's being stabbed by a sword.""*)

### Węzeł `[984]`
**[WYBÓR GRACZA: "Offer no reply."]** — Mówca: **Player_Romus_Italic**
> "I offered no reply."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Sal Ignacius: ""Now, I behold an endless sea of people stretching as far..."*)

### Węzeł `[985]`
**[WYBÓR GRACZA: "Don't speak."]** — Mówca: **Player_Romus_Italic**
> "I didn’t speak -- just listened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[278]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[808]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn01_EyesOpen == true"*)

### Węzeł `[986]`
**[WYBÓR GRACZA: "Hold your tongue."]** — Mówca: **Player_Romus_Italic**
> "I held my tongue and listened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[813]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Sal Ignacius: ""And on a nearby mountain overlooking the city sits a bea..."*)

### Węzeł `[987]`
**[WYBÓR GRACZA: "Offer no response."]** — Mówca: **Player_Romus_Italic**
> "I offered no response, just listened."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[284]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[988]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Such a grand expenditure would certainly drain the Crown of its resources.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] == false`
- **Kontekst wejściowy (poprzednik):** `[886]` (Sal Ignacius), `[888]` (Sal Ignacius), `[958]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[989]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.SanctuaryQHub_Budget = true"*)

### Węzeł `[989]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.SanctuaryQHub_Budget = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.SanctuaryQHub_Budget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[990]` (*Sal Ignacius: ""Indeed... I am afraid both of these projects will be qui..."*)

### Węzeł `[990]`
Mówca: **Sal Ignacius**
> ""Indeed... I am afraid both of these projects will be quite costly endeavors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[991]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)

### Węzeł `[991]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[992]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 4"*)
  - -> `[993]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 4)"*)

### Węzeł `[992]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 4`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 4`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[995]` (*Sal Ignacius: ""But we do have the funds in place, Your Majesty. And wit..."*)

### Węzeł `[993]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 4)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 4) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[996]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)

### Węzeł `[994]`
Mówca: **Sal Ignacius**
> ""But we have enough funds to get started on the Plavo restoration already. And with the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]` (*Sal Ignacius: ""From there, you and I can build new sanctuaries all acro..."*)

### Węzeł `[995]`
Mówca: **Sal Ignacius**
> ""But we do have the funds in place, Your Majesty. And with the entire religious community's attention on today's ceremony, there will never be a more opportune time to sign the order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]` (*Sal Ignacius: ""From there, you and I can build new sanctuaries all acro..."*)

### Węzeł `[996]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[997]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Resources_Budget >= 2"*)
  - -> `[998]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Resources_Budget >= 2)"*)

### Węzeł `[997]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Resources_Budget >= 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Resources_Budget"] >= 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[994]` (*Sal Ignacius: ""But we have enough funds to get started on the Plavo res..."*)

### Węzeł `[998]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Resources_Budget >= 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Resources_Budget"] >= 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1000]` (*Sal Ignacius: ""But I urge you not to neglect either of them. Even if th..."*)

### Węzeł `[999]`
Mówca: **Sal Ignacius**
> ""From there, you and I can build new sanctuaries all across the land...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[954]` (*Player_Romus: ""So that more people may bask in God's glory.""*)
  - -> `[955]` (*Player_Romus: ""I get what you're saying. If we keep our people busy wit..."*)
  - -> `[956]` (*Player_Romus: ""The Crown's money should be spent on improving our citiz..."*)
  - -> `[963]` (*Player_Romus: ""I aim to transform Rizia into a strong, modern nation. I..."*)

### Węzeł `[1000]`
Mówca: **Sal Ignacius**
> ""But I urge you not to neglect either of them. Even if they cannot be funded right away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[999]` (*Sal Ignacius: ""From there, you and I can build new sanctuaries all acro..."*)

### Węzeł `[1001]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Romus_Italic**
> "I nodded. With increased urgency in his voice, Sal continued."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Sal Ignacius: ""And on the crown is a fracture on the golden band...""*)

### Węzeł `[1002]`
**[WYBÓR GRACZA: "Gesture for him to keep going."]** — Mówca: **Player_Romus_Italic**
> "I gestured for him to keep going."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "His grip tightened."*)

### Węzeł `[1003]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Descending into sacred catacombs with the Grand Wiseman", "Plavo Archsanctuary", "Plavo");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Descending into sacred catacombs with the Grand Wiseman","Plavo Archsanctuary","Plavo");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[795]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[1004]`
Mówca: **Sal Ignacius**
> ""But neglect them, and unrest could follow. Four decades ago, reforms stirred discontent that began in sanctuaries and spilled into the streets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1005]` (*Sal Ignacius: ""When the faithful grow uneasy, their tithes shrink, leav..."*)

### Węzeł `[1005]`
Mówca: **Sal Ignacius**
> ""When the faithful grow uneasy, their tithes shrink, leaving the Crown to fill the gap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[974]` (*Węzeł Logiki Narracyjnej: "Jump to: [Sanctuary Q Hub]"*)
