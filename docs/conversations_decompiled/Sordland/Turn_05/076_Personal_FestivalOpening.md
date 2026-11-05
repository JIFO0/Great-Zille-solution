# Sordland/Turn05/Personal_FestivalOpening

- **ID konwersacji:** `76`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/076_Personal_FestivalOpening.md`
- **Liczba węzłów dialogowych:** 423
- **Liczba wyborów gracza:** 81

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[37]** Curtan Leste

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGame.Turn04_SnO_LE_Balanced_Decreased`
- `BaseGame.Turn04_SnO_LE_Balanced_Increased`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Democratic`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Sollist`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`
- `BaseGame.Turn05_Personal_Festival_LesteLeft`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked`
- `BaseGameSupport.News_Turn05_HP_GruniReturnsNormal`
- `BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators`
- `BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill`
- `BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased`
- `BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced`
- `BaseGameSupport.Report_Turn05_Estord_Unrest`
- `BaseGameSupport.Report_Turn05_Holsord_EducationNegative`
- `BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative`
- `BaseGameSupport.Report_Turn05_Lachaven_NoUnrest`
- `BaseGameSupport.Report_Turn05_Uziren_Refugees`
- `GameCondition.Turn05_A_DamageControl`
- `GameCondition.Turn05_Personal_BenfiFestival`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“Don't worry. You're going to be fine.""** | `[5]` **Narrator**: "She nervously eyed the waiting c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[15]` **Narrator**: "She gave me a smile, looking som..." |
| `[11]` | **"“Do not mess this up.”"** | `[5]` **Narrator**: "She nervously eyed the waiting c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[14]` **Narrator**: "Monica swallowed hard. Her eyes ..." |
| `[12]` | **"Hold her hand."** | `[5]` **Narrator**: "She nervously eyed the waiting c..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[13]` **Narrator**: "She smiled and turned her head t..." |
| `[18]` | **"“Are you still angry about my decision?”"** | `[9]` **Narrator**: "Since I'd refused to let her mak..."<br>`[407]` **Narrator**: "Since Gloria had convinced me to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Narrator**: "She didn't reply at all. She cle..." |
| `[19]` | **"Say nothing."** | `[9]` **Narrator**: "Since I'd refused to let her mak..."<br>`[407]` **Narrator**: "Since Gloria had convinced me to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[4]` **Narrator**: "As soon as Serge opened the door..." |
| `[20]` | **""Will you ever forgive me? I told you my reasons.""** | `[9]` **Narrator**: "Since I'd refused to let her mak..."<br>`[407]` **Narrator**: "Since Gloria had convinced me to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Monica**: ""Whatever you say.""<br>`[21]` **Monica**: "“I know, and I understand. It's ..." |
| `[33]` | **"“Good luck.”"** | `[32]` **Monica**: "“A platform where Sordland's wom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[37]` **Narrator**: "The two of us proceeded to the p..." |
| `[34]` | **"“I hope this is not a mistake.”"** | `[32]` **Monica**: "“A platform where Sordland's wom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[35]` **Monica**: "“We will see.”" |
| `[70]` | **"“Monica, that's enough.”"** | `[77]` **Monica**: "“And it isn't *your* place to de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Monica**: "“What do you mean, enough? I've ..." |
| `[71]` | **"Do nothing."** | `[77]` **Monica**: "“And it isn't *your* place to de..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "I looked at the podium to see Cu..." |
| `[79]` | **"“Break a leg!”"** | `[32]` **Monica**: "“A platform where Sordland's wom..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[37]` **Narrator**: "The two of us proceeded to the p..." |
| `[80]` | **"Nod."** | `[61]` **Narrator**: "He paused for a moment to let th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Curtan Leste**: "“This is a night for the people ..." |
| `[81]` | **"Look away."** | `[61]` **Narrator**: "He paused for a moment to let th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Curtan Leste**: "“This is a night for the people ..." |
| `[84]` | **"“Ssshh. Quiet.”"** | `[83]` **Monica**: "“What in the hell is he talking ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "Monica turned back to watching t..." |
| `[85]` | **"“I don't know. Just let it be.”"** | `[83]` **Monica**: "“What in the hell is he talking ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "Monica turned back to watching t..." |
| `[86]` | **"Pretend not to hear her."** | `[83]` **Monica**: "“What in the hell is he talking ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Narrator**: "Monica turned back to watching t..." |
| `[89]` | **"“Ssshh. Monica. Please sit down.”"** | `[67]` **Monica**: "“Mr. Leste, it is not young wome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[92]` **Monica**: "“No, I will not sit down this ti..." |
| `[90]` | **"“Monica, sit down. You're making a fool of yourself.”"** | `[67]` **Monica**: "“Mr. Leste, it is not young wome..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[92]` **Monica**: "“No, I will not sit down this ti..." |
| `[91]` | **"Watch the events unfold."** | `[67]` **Monica**: "“Mr. Leste, it is not young wome..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Monica turned to face the audien..." |
| `[95]` | **"“Are you threatening me, Curtan?”"** | `[94]` **Curtan Leste**: "“Mr. President, I am afraid you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Curtan Leste**: "“No, I am merely telling what wi..." |
| `[96]` | **"“What kind of consequences?”"** | `[94]` **Curtan Leste**: "“Mr. President, I am afraid you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Curtan Leste**: ""Your little stunt has lost you ..." |
| `[97]` | **"Ignore him."** | `[94]` **Curtan Leste**: "“Mr. President, I am afraid you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Curtan Leste**: ""Your little stunt has lost you ..." |
| `[102]` | **"“Mr. Leste. Please sit down.”"** | `[51]` **Curtan Leste**: "“I will not let this woman besmi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Curtan Leste**: "“No, Anton. I can no longer sit ..." |
| `[103]` | **"“Curtan, get back in your goddamn seat!""** | `[51]` **Curtan Leste**: "“I will not let this woman besmi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Curtan Leste**: "“No, Anton. I can no longer sit ..." |
| `[104]` | **"Watch the events unfold."** | `[51]` **Curtan Leste**: "“I will not let this woman besmi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Narrator**: "Curtan turned towards the audien..." |
| `[115]` | **"“Enough, Mr. Leste! Let her speak!""** | `[114]` **Narrator**: "The mayor was still standing def..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[117]` **Narrator**: "The room immediately quieted dow..." |
| `[116]` | **"“Mr. Leste. Please calm down, take your seat, and let her finish. Now.”"** | `[114]` **Narrator**: "The mayor was still standing def..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[141]` **Curtan Leste**: "“I will not stand idly by as our..." |
| `[118]` | **"“Mr. Leste. Do I have to teach you basic manners? Have you forgotten what you lear..."** | `[114]` **Narrator**: "The mayor was still standing def..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[180]` **Narrator**: "The crowd erupted in laughter. C..." |
| `[119]` | **"“Thank you for the speech, Monica. You've done... enough.""** | `[114]` **Narrator**: "The mayor was still standing def..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[181]` **Narrator**: "Monica gaped at me, looking as i..." |
| `[120]` | **"“Monica, please continue your speech.”"** | `[117]` **Narrator**: "The room immediately quieted dow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Curtan Leste**: "“I will not stand idly by as our..." |
| `[121]` | **"“Curtan, if you don't sit down now and let her speak, I swear I will...”"** | `[117]` **Narrator**: "The room immediately quieted dow..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Curtan Leste**: "“You swear you will...what, Mr. ..." |
| `[123]` | **"“...make you pay.”"** | `[122]` **Curtan Leste**: "“You swear you will...what, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[143]` **Curtan Leste**: "“Do you realize what you are doi..." |
| `[124]` | **"“...have you removed.”"** | `[122]` **Curtan Leste**: "“You swear you will...what, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Curtan Leste**: "“Is this what you do to people w..." |
| `[125]` | **"Stare into his eyes menacingly."** | `[122]` **Curtan Leste**: "“You swear you will...what, Mr. ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "He did not even flinch." |
| `[130]` | **"Order the guards to escort him out."** | `[126]` **Curtan Leste**: "“Is this what you do to people w..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Personal_Festival_Force"] = tru...` | `[132]` **Narrator**: "My security guards immediately s..." |
| `[133]` | **"“It's what I do to upstarts who fail to show restraint.""** | `[126]` **Curtan Leste**: "“Is this what you do to people w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Curtan Leste**: "“Is that a threat?”" |
| `[134]` | **"“Yes, it is.”"** | `[128]` **Curtan Leste**: "“Is that a threat?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Curtan Leste**: "“Then you have just made an enemy.”" |
| `[135]` | **"Do not reply."** | `[128]` **Curtan Leste**: "“Is that a threat?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Curtan Leste**: "“Then you have just made an enemy.”" |
| `[136]` | **"“No. It is a request.”"** | `[128]` **Curtan Leste**: "“Is that a threat?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Curtan Leste**: "“Then I respectfully decline. I ..." |
| `[152]` | **""Is rudeness a Sordish value now? Is impropriety?""** | `[126]` **Curtan Leste**: "“Is this what you do to people w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." |
| `[165]` | **"“Curtan, let's talk about this.”"** | `[139]` **Curtan Leste**: "“Especially by our very own pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Curtan Leste**: "“It's too late, Mr. President. G..." |
| `[167]` | **"“Is rudeness a Sordish value now? Is impropriety?”"** | `[139]` **Curtan Leste**: "“Especially by our very own pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." |
| `[173]` | **""Is rudeness a Sordish value now? Is impropriety?""** | `[142]` **Curtan Leste**: "“Especially by our very own pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." |
| `[174]` | **"“That's the last straw, Curtan -- get out of my sights immediately!""** | `[142]` **Curtan Leste**: "“Especially by our very own pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Curtan Leste**: ""Mr. President, this is a free c..." |
| `[178]` | **"“Please do not make me repeat myself.”"** | `[142]` **Curtan Leste**: "“Especially by our very own pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[280]` **Curtan Leste**: "“Or what? You'll have me kicked ..." |
| `[184]` | **"“Wait. Don't go. I'm sorry.”"** | `[182]` **Narrator**: "I started walking back to my sea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "She looked back at me, her face ..." |
| `[185]` | **"Grab her arm to stop her."** | `[182]` **Narrator**: "I started walking back to my sea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "She looked back at me, her face ..." |
| `[186]` | **"“You knew this was going to happen.”"** | `[182]` **Narrator**: "I started walking back to my sea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "She looked back at me, her face ..." |
| `[187]` | **"Do nothing."** | `[182]` **Narrator**: "I started walking back to my sea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[190]` **Narrator**: "She looked back at me, her face ..." |
| `[194]` | **"“Not now, Curtan.”"** | `[193]` **Curtan Leste**: "“Thank you for having my back, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Curtan Leste**: "“Yes, I understand.”" |
| `[195]` | **"“Much appreciated.""** | `[193]` **Curtan Leste**: "“Thank you for having my back, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Curtan Leste**: "“I am glad we are on the same pa..." |
| `[197]` | **"“The greater good doesn't seem that great right now.”"** | `[193]` **Curtan Leste**: "“Thank you for having my back, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Curtan Leste**: "“It never does. Regardless, this..." |
| `[198]` | **"“Don't make me regret this.”"** | `[193]` **Curtan Leste**: "“Thank you for having my back, s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Curtan Leste**: "“I will not.”" |
| `[222]` | **"“You know what, Curtan? My wife is absolutely right.”"** | `[74]` **Curtan Leste**: "“Mr. President, could you please..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[229]` **Narrator**: "Monica looked at me, surprise re..." |
| `[223]` | **"“I'm so sorry about this, Mr. Leste. Please finish your speech.”"** | `[74]` **Curtan Leste**: "“Mr. President, could you please..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[237]` **Curtan Leste**: "“Thank you, Mr. President.”" |
| `[224]` | **"“Monica, get back in your goddamn seat!""** | `[74]` **Curtan Leste**: "“Mr. President, could you please..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[228]` **Monica**: "“I--”" |
| `[225]` | **"“Monica, we've been over this. Now is not the time. Sit down, please.”"** | `[74]` **Curtan Leste**: "“Mr. President, could you please..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...`<br>`Variable["BaseGame.Relations_Monica_SupportedAtFestival"]...` | `[228]` **Monica**: "“I--”" |
| `[231]` | **"“But we will take up her concerns at a later time. Please finish your speech.”"** | `[233]` **Narrator**: "I turned to Curtan." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Curtan Leste**: "“Thank you, Mr. President.”" |
| `[232]` | **"“Your task was to give an opening speech, not a moral lecture.”"** | `[233]` **Narrator**: "I turned to Curtan." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[238]` **Curtan Leste**: "“I will finish my speech if you'..." |
| `[234]` | **"“Now, please, get your speech over with already.”"** | `[233]` **Narrator**: "I turned to Curtan." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Curtan Leste**: "“I will, Mr. President. If you'l..." |
| `[239]` | **"“Go on.”"** | `[238]` **Curtan Leste**: "“I will finish my speech if you'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Curtan Leste**: "“How very generous of you.”" |
| `[240]` | **"“That's up to the people of Benfi, isn't it?""** | `[238]` **Curtan Leste**: "“I will finish my speech if you'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Narrator**: "I turned around to look at the c..." |
| `[265]` | **"“He's a bit extreme, but he is right. We owe everything to God.”"** | `[264]` **Narrator**: "I leaned over to Monica." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Monica**: "“He's a fanatic. Right or not, t..."<br>`[340]` **Narrator**: "Monica said nothing, her gaze fi..." |
| `[266]` | **"“He sounds more like a priest than a politician.”"** | `[264]` **Narrator**: "I leaned over to Monica." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Monica**: "“I do not like it when the two c..."<br>`[340]` **Narrator**: "Monica said nothing, her gaze fi..." |
| `[281]` | **"“That is exactly what I am doing. Guards!""** | `[280]` **Curtan Leste**: "“Or what? You'll have me kicked ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Personal_Festival_Force"] = tru...` | `[132]` **Narrator**: "My security guards immediately s..." |
| `[282]` | **"“You will stay and watch the speech. Without interrupting it.”"** | `[280]` **Curtan Leste**: "“Or what? You'll have me kicked ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Narrator**: "Curtan's response was nearly dro..." |
| `[285]` | **"Order the guards to kick him out."** | `[279]` **Narrator**: "The two of us glared angrily at ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Personal_Festival_Force"] = tru...` | `[132]` **Narrator**: "My security guards immediately s..." |
| `[286]` | **"“Then you will stay and watch the speech. Without interrupting it.”"** | `[279]` **Narrator**: "The two of us glared angrily at ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Narrator**: "He tried to reply, but he was dr..." |
| `[336]` | **"“I praise God he's only allowed to speak for another two minutes.”"** | `[264]` **Narrator**: "I leaned over to Monica." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Narrator**: "Monica stifled a short laugh."<br>`[340]` **Narrator**: "Monica said nothing, her gaze fi..." |
| `[349]` | **""Mr. Leste, I believe you had a speech prepared?""** | `[181]` **Narrator**: "Monica gaped at me, looking as i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[352]` **Narrator**: "Smiling triumphantly, Curtan str..." |
| `[350]` | **""I declare this festival officially open!""** | `[181]` **Narrator**: "Monica gaped at me, looking as i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Narrator**: "After some confusion, the band b..." |
| `[355]` | **""You feel it's right to berate a woman? The president's wife, at that?""** | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Curtan Leste**: ""Her ideas are dangerous, Anton...." |
| `[356]` | **""And I feel it's right to have you thrown out. Guards!""** | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Personal_Festival_Force"] = tru...` | `[132]` **Narrator**: "My security guards immediately s..." |
| `[357]` | **""Sordland does not need your protection.""** | `[354]` **Curtan Leste**: ""I'm only doing what I feel is r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[358]` **Curtan Leste**: ""Her ideas are dangerous, Anton...." |
| `[360]` | **""Your ideas, on the other hand, will lead us back to the Dark Ages.""** | `[358]` **Curtan Leste**: ""Her ideas are dangerous, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Curtan Leste**: ""Without our traditions, we are ..." |
| `[361]` | **""Maybe they will, maybe they won't. The only thing for certain is that you won't g..."** | `[358]` **Curtan Leste**: ""Her ideas are dangerous, Anton...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "The crowd was booing Curtan loud..." |
| `[362]` | **""I'll show you a dark path. Guards!""** | `[358]` **Curtan Leste**: ""Her ideas are dangerous, Anton...." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Turn05_Personal_Festival_Force"] = tru...` | `[132]` **Narrator**: "My security guards immediately s..." |
| `[366]` | **""And without change, we are fossils. Now please, sit down.""** | `[365]` **Curtan Leste**: ""Without our traditions, we are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "The crowd was booing Curtan loud..." |
| `[367]` | **""My administration has not lost sight of tradition. You'll have to trust me, Curtan.""** | `[365]` **Curtan Leste**: ""Without our traditions, we are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Narrator**: "The crowd was booing Curtan loud..." |
| `[368]` | **""How about you get lost yourself?""** | `[365]` **Curtan Leste**: ""Without our traditions, we are ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[372]` **Narrator**: "Curtan scowled at me." |
| `[411]` | **""I told you about what Gloria said. The change you want is coming.""** | `[9]` **Narrator**: "Since I'd refused to let her mak..." | `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true` | *Brak zmian stanu* | `[412]` **Monica**: ""When, Anton? In all her time in..." |

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
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators =..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our motorcade slowly made its way towards the magnificent Benfi High Arts Center. Night was falling, and the festival was about to begin. I flipped through the brochure that had been given to us at the hotel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "As soon as Serge opened the door, we were enveloped by the roar of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The next few minutes were a blur of handshakes, photos an..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "She nervously eyed the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“Don't worry. You're going to be fine.""*)
  - -> `[11]` (*Player: "“Do not mess this up.”"*)
  - -> `[12]` (*Player_Italic: "Hold her hand."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "She nervously eyed the waiting crowd."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Since I'd refused to let her make the opening speech, her attitude toward me had changed. She now only spoke to me if I asked her a question, or if it was something important concerning the children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Italic: "Say nothing."*)
  - -> `[18]` (*Player: "“Are you still angry about my decision?”"*)
  - -> `[20]` (*Player: ""Will you ever forgive me? I told you my reasons.""*)
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Don't worry. You're going to be fine.""]** — Mówca: **Player**
> "“Don't worry. You're going to be fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Do not mess this up.”"]** — Mówca: **Player**
> "“Do not mess this up.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1;"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Hold her hand."]** — Mówca: **Player_Italic**
> "I took her hand in mine and gave it a firm squeeze."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "She smiled and turned her head to look out the window once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "Monica swallowed hard. Her eyes grew wider."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Monica: "“I will do my best.”"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "She gave me a smile, looking somewhat comforted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Monica: "“Thanks, Anton. I appreciate it.”"*)

### Węzeł `[16]`
Mówca: **Monica**
> "“Thanks, Anton. I appreciate it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[17]`
Mówca: **Monica**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Are you still angry about my decision?”"]** — Mówca: **Player**
> "“Are you still angry about my decision?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[407]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Narrator: "She didn't reply at all. She clearly did not want to purs..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and waited for Serge to open the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[407]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Will you ever forgive me? I told you my reasons.""]** — Mówca: **Player**
> ""Will you ever forgive me? I told you my reasons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator), `[407]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)

### Węzeł `[21]`
Mówca: **Monica**
> "“I know, and I understand. It's just going to take me some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "She clearly did not want to pursue this topic any further."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "She clearly did not want to pursue this topic any further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "As soon as Serge opened the door, we were enveloped by the roar of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "The next few minutes were a blur of handshakes, photos an..."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "The Benfi Festival was one of the biggest events of the year. It originally marked the start of the annual religious pilgrimage, a weeks-long journey still undertaken by devout Nurists. But today it was better known as a cultural celebration that drew thousands of revelers to the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "There were film screenings, concerts, theater and dance p..."*)

### Węzeł `[25]`
Mówca: **Narrator**
> "As the car slowed, a coterie of reporters and security guards rushed to meet us. I turned my attention to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[26]`
Mówca: **Narrator**
> "We followed the guards through the cavernous white halls until we came to a set of arched doors leading to the auditorium. We waited outside as security did a quick sweep of the area, then headed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Monica: "“So, this is it. I will finally stand on the same platfor..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Narrator: "I had been asked to make a quick set of remarks introduci..."*)

### Węzeł `[30]`
Mówca: **Monica**
> "“I'm going to find my seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Narrator: "Monica brushed past me, took her seat in the front row an..."*)

### Węzeł `[31]`
Mówca: **Monica**
> "“So, this is it. I will finally stand on the same platform as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Monica: "“A platform where Sordland's women will have their voices..."*)

### Węzeł `[32]`
Mówca: **Monica**
> "“A platform where Sordland's women will have their voices heard and acknowledged for the first time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“Break a leg!”"*)
  - -> `[33]` (*Player: "“Good luck.”"*)
  - -> `[34]` (*Player: "“I hope this is not a mistake.”"*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I hope this is not a mistake.”"]** — Mówca: **Player**
> "“I hope this is not a mistake.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1;"*)

### Węzeł `[35]`
Mówca: **Monica**
> "“We will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The two of us proceeded to the podium. I spoke first, del..."*)

### Węzeł `[36]`
Mówca: **Narrator**
> "Monica brushed past me, took her seat in the front row and crossed her arms. I walked alone to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "I spoke for just a minute, reading a paragraph my speechw..."*)

### Węzeł `[37]`
Mówca: **Narrator**
> "The two of us proceeded to the podium. I spoke first, delivering a short paragraph about the importance of Benfi and the festival to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "I then introduced Monica. Thunderous applause echoed arou..."*)

### Węzeł `[38]`
Mówca: **Narrator**
> "I then introduced Monica. Thunderous applause echoed around the auditorium as she stepped to the microphone. I exited the stage and found my seat.... right next to Curtan Leste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Monica: "“Ladies and gentlemen, as the First Lady of Sordland, I w..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "I concluded by inviting Curtan Leste, the Mayor of Anrica, to the podium. I stepped down and joined Monica in the front row. Her arms were still folded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Curtan Leste: "“Welcome to the first day of the Benfi Festival.”"*)

### Węzeł `[40]`
Mówca: **Narrator**
> "I spoke for just a minute, reading a paragraph my speechwriter had churned out about the importance of the festival and Benfi to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I concluded by inviting Curtan Leste, the Mayor of Anrica..."*)

### Węzeł `[41]`
Mówca: **Monica**
> "“Ladies and gentlemen, as the First Lady of Sordland, I welcome all of you to the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "The crowd erupted again, clapping and cheering."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "The crowd erupted again, clapping and cheering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Narrator: "Curtan Leste leaned over and hissed into my ear."*)

### Węzeł `[43]`
Mówca: **Monica**
> "“This festival holds a very important place in all of our hearts. It is a celebration of art, music, theater -- but above all, it is a celebration of the people of Benfi, of their free and open-minded spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“As we all unite for the festivities, we must not forget ..."*)

### Węzeł `[44]`
Mówca: **Monica**
> "“As we all unite for the festivities, we must not forget the values that have inspired them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: "“Today marks the beginning of the Week of the Spirit. A t..."*)

### Węzeł `[45]`
Mówca: **Monica**
> "“Today marks the beginning of the Week of the Spirit. A time for vitality, growth, and new beginnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "The crowd was hanging on to her every word, but the mayor..."*)

### Węzeł `[46]`
Mówca: **Monica**
> "“I stand on this podium today to speak about change. About a new beginning for our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: "“Sordland calls itself a free country. Yet half of its ci..."*)

### Węzeł `[47]`
Mówca: **Monica**
> ""To truly move forward, we must make a break from old traditions and strive towards equality for all. Equal rights, equal pay, equal access to education--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Curtan Leste: ""Enough!""*)

### Węzeł `[48]`
Mówca: **Narrator**
> "The crowd was hanging on to her every word, but the mayor of Anrica and his entourage didn't seem as impressed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Monica: "“I stand on this podium today to speak about change. Abou..."*)

### Węzeł `[49]`
Mówca: **Monica**
> "“Sordland calls itself a free country. Yet half of its citizens are still barred from enjoying the same freedoms that the other half takes for granted. I refer to myself and my fellow women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "A rumble went through the crowd. Scattered applause mixed..."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "A rumble went through the crowd. Scattered applause mixed with murmurs of discontent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Monica: ""To truly move forward, we must make a break from old tra..."*)

### Węzeł `[51]`
Mówca: **Curtan Leste**
> "“I will not let this woman besmirch the traditions upon which our great country was built.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Player: "“Mr. Leste. Please sit down.”"*)
  - -> `[103]` (*Player: "“Curtan, get back in your goddamn seat!""*)
  - -> `[104]` (*Player_Italic: "Watch the events unfold."*)

### Węzeł `[52]`
Mówca: **Curtan Leste**
> "“You are not a politician. You are not a speaker. You are merely a woman who's lucky enough to be married to the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Curtan Leste: "“Your place is not at at this podium. It is at home, tend..."*)

### Węzeł `[53]`
Mówca: **Curtan Leste**
> "“Your place is not at at this podium. It is at home, tending to your husband and children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Booing");"*)

### Węzeł `[54]`
Mówca: **Curtan Leste**
> "“Mrs. Rayne, what right do you possibly have to pass judgement on our values as Sordish citizens?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Curtan Leste: "“You are not a politician. You are not a speaker. You are..."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "The crowd was growing rowdier. Some booed and jeered at Curtan's words, others whooped in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Monica: "“I--”"*)

### Węzeł `[56]`
Mówca: **Monica**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Monica froze completely. The audience grew louder."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Monica froze completely. The audience grew louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Narrator: "I had to do something. I walked up to the stage and stood..."*)

### Węzeł `[58]`
Mówca: **Curtan Leste**
> "“Welcome to the first day of the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "He paused for a moment to let the crowd cheer, and his ey..."*)

### Węzeł `[59]`
Mówca: **Curtan Leste**
> "“This is a night for the people of Benfi -- indeed, for the people of Sordland -- to put aside their differences and come together in celebration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Curtan Leste: "“Yet as we unite for the festivities, we must remember th..."*)

### Węzeł `[60]`
Mówca: **Curtan Leste**
> "“Yet as we unite for the festivities, we must remember the real reason we are gathered here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Narrator: "The crowd fell silent. The people were giving their full ..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "He paused for a moment to let the crowd cheer, and his eyes briefly met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Player_Italic: "Nod."*)
  - -> `[81]` (*Player_Italic: "Look away."*)

### Węzeł `[62]`
Mówca: **Curtan Leste**
> "“This festival was founded around the principles of our cherished religion, Nurity. Yet over the years, it has been severed from its sacred roots and become something else. Something more perverse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Curtan Leste: "“An excuse for public drunkenness and grotesque displays ..."*)

### Węzeł `[63]`
Mówca: **Curtan Leste**
> "“An excuse for public drunkenness and grotesque displays of the flesh. An occasion for young women to parade their bodies and engage in lascivious behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Narrator: "As he went on, I could see Monica become increasingly agi..."*)

### Węzeł `[64]`
Mówca: **Narrator**
> "The crowd was becoming restless. Many of the younger attendees were murmuring in disagreement, while a few of the older ones were nodding vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Curtan Leste: "“As I said, perversion hidden under the guise of art is n..."*)

### Węzeł `[65]`
Mówca: **Narrator**
> "The crowd fell silent. The people were giving their full attention to what he had to say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Curtan Leste: "“This festival was founded around the principles of our c..."*)

### Węzeł `[66]`
Mówca: **Curtan Leste**
> "“Perversion hidden under the guise of art is not befitting the beautiful city of --”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("Murmuring");"*)

### Węzeł `[67]`
Mówca: **Monica**
> "“Mr. Leste, it is not young women who are a disgrace to this fine festival, but you. You and your backwards, puritanical attitudes, which have been holding this country back for far too long--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player: "“Monica, sit down. You're making a fool of yourself.”"*)
  - -> `[89]` (*Player: "“Ssshh. Monica. Please sit down.”"*)
  - -> `[91]` (*Player_Italic: "Watch the events unfold."*)

### Węzeł `[68]`
Mówca: **Monica**
> "“Women of Sordland, we must not let people like Mr. Leste use religion as a justification to demean and oppress us. Our time has come!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "Shocked gasps ran through the crowd. A few people rose an..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "Shocked gasps ran through the crowd. A few people rose and applauded. Curtan Leste waited to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Curtan Leste: "“I think Mrs. Rayne is forgetting her place.”"*)

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Monica, that's enough.”"]** — Mówca: **Player**
> "“Monica, that's enough.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Monica: "“What do you mean, enough? I've barely even started.""*)

### Węzeł `[71]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I kept watching in silence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "I looked at the podium to see Curtan Leste's piercing gaz..."*)

### Węzeł `[72]`
Mówca: **Monica**
> "“What do you mean, enough? I've barely even started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "I looked at the podium to see Curtan Leste's piercing gaz..."*)

### Węzeł `[73]`
Mówca: **Narrator**
> "I looked at the podium to see Curtan Leste's piercing gaze on me. There would surely be a price to pay for this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Curtan Leste: "“Mr. President, could you please control your wife before..."*)

### Węzeł `[74]`
Mówca: **Curtan Leste**
> "“Mr. President, could you please control your wife before she embarrasses herself any further?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Player: "“Monica, get back in your goddamn seat!""*)
  - -> `[225]` (*Player: "“Monica, we've been over this. Now is not the time. Sit d..."*)
  - -> `[223]` (*Player: "“I'm so sorry about this, Mr. Leste. Please finish your s..."*)
  - -> `[222]` (*Player: "“You know what, Curtan? My wife is absolutely right.”"*)

### Węzeł `[75]`
Mówca: **Curtan Leste**
> "“I think Mrs. Rayne is forgetting her place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Monica: ""What do you think my place is, Mr. Leste? The kitchen? T..."*)

### Węzeł `[76]`
Mówca: **Monica**
> ""What do you think my place is, Mr. Leste? The kitchen? This festival is not about your retrograde traditions. We are living in modern times now. It's 1954.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Monica: "“And it isn't *your* place to decide how the people of Be..."*)

### Węzeł `[77]`
Mówca: **Monica**
> "“And it isn't *your* place to decide how the people of Benfi -- especially the women -- should be celebrating their own festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: "“Monica, that's enough.”"*)
  - -> `[71]` (*Player_Italic: "Do nothing."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "The next few minutes were a blur of handshakes, photos and reporters' questions. The onlookers cheered as we walked the red carpet to the newly built arts center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "We followed the guards through the cavernous white halls ..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Break a leg!”"]** — Mówca: **Player**
> "“Break a leg!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[80]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Curtan Leste: "“This is a night for the people of Benfi -- indeed, for t..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "Look away."]** — Mówca: **Player_Italic**
> "I looked away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Curtan Leste: "“This is a night for the people of Benfi -- indeed, for t..."*)

### Węzeł `[82]`
Mówca: **Narrator**
> "As he went on, I could see Monica become increasingly agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Monica: "“What in the hell is he talking about? Lascivious behavio..."*)

### Węzeł `[83]`
Mówca: **Monica**
> "“What in the hell is he talking about? Lascivious behavior? What century does he think we live in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Player: "“Ssshh. Quiet.”"*)
  - -> `[85]` (*Player: "“I don't know. Just let it be.”"*)
  - -> `[86]` (*Player_Italic: "Pretend not to hear her."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Ssshh. Quiet.”"]** — Mówca: **Player**
> "“Ssshh. Quiet.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Monica turned back to watching the speech, a frown on her..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA: "“I don't know. Just let it be.”"]** — Mówca: **Player**
> "“I don't know. Just let it be.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Monica turned back to watching the speech, a frown on her..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: "Pretend not to hear her."]** — Mówca: **Player_Italic**
> "I pretended not to hear her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "Monica turned back to watching the speech, a frown on her..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "Monica turned back to watching the speech, a frown on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Curtan Leste: "“Perversion hidden under the guise of art is not befittin..."*)

### Węzeł `[88]`
Mówca: **Curtan Leste**
> "“As I said, perversion hidden under the guise of art is not be--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Monica: "“Enough!”"*)

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Ssshh. Monica. Please sit down.”"]** — Mówca: **Player**
> "“Ssshh. Monica. Please sit down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Monica: "“No, I will not sit down this time.”"*)

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Monica, sit down. You're making a fool of yourself.”"]** — Mówca: **Player**
> "“Monica, sit down. You're making a fool of yourself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "Watch the events unfold."]** — Mówca: **Player_Italic**
> "I stayed in my seat and watched the events unfold."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Monica turned to face the audience, speaking loud enough ..."*)

### Węzeł `[92]`
Mówca: **Monica**
> "“No, I will not sit down this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Monica turned to face the audience, speaking loud enough ..."*)

### Węzeł `[93]`
Mówca: **Narrator**
> "Curtan Leste leaned over and hissed into my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Curtan Leste: "“Mr. President, I am afraid you have made a great mistake..."*)

### Węzeł `[94]`
Mówca: **Curtan Leste**
> "“Mr. President, I am afraid you have made a great mistake. There will be consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“Are you threatening me, Curtan?”"*)
  - -> `[96]` (*Player: "“What kind of consequences?”"*)
  - -> `[97]` (*Player_Italic: "Ignore him."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Are you threatening me, Curtan?”"]** — Mówca: **Player**
> "“Are you threatening me, Curtan?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Curtan Leste: "“No, I am merely telling what will happen. Your little st..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: "“What kind of consequences?”"]** — Mówca: **Player**
> "“What kind of consequences?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Curtan Leste: ""Your little stunt has lost you my support in the Assembly.”"*)

### Węzeł `[97]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Italic**
> "I did not pay any attention to Curtan and simply pretended to not hear him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Curtan Leste: ""Your little stunt has lost you my support in the Assembly.”"*)

### Węzeł `[98]`
Mówca: **Curtan Leste**
> "“No, I am merely telling what will happen. Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I kept my eyes on the stage. When the applause subsided, ..."*)

### Węzeł `[99]`
Mówca: **Curtan Leste**
> ""Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I kept my eyes on the stage. When the applause subsided, ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I kept my eyes on the stage. When the applause subsided, Monica resumed her speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Monica: "“This festival holds a very important place in all of our..."*)

### Węzeł `[101]`
Mówca: **Curtan Leste**
> ""Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I kept my eyes on the stage. When the applause subsided, ..."*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Mr. Leste. Please sit down.”"]** — Mówca: **Player**
> "“Mr. Leste. Please sit down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Curtan Leste: "“No, Anton. I can no longer sit idly by. We are past that..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Curtan, get back in your goddamn seat!""]** — Mówca: **Player**
> "“Curtan, get back in your goddamn seat!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Curtan Leste: "“No, Anton. I can no longer sit idly by. We are past that..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "Watch the events unfold."]** — Mówca: **Player_Italic**
> "I sat down and watched the events unfold."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Curtan turned towards the audience, speaking loudly enoug..."*)

### Węzeł `[105]`
Mówca: **Curtan Leste**
> "“No, Anton. I can no longer sit idly by. We are past that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Curtan turned towards the audience, speaking loudly enoug..."*)

### Węzeł `[106]`
Mówca: **Narrator**
> "The entire hall fell silent. The mayor of Anrica rose and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Curtan Leste: "“I will not let this woman besmirch the traditions upon w..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Curtan turned towards the audience, speaking loudly enough to be heard without a microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Curtan Leste: "“Mrs. Rayne, what right do you possibly have to pass judg..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Monica turned to face the audience, speaking loud enough to be heard without a microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Monica: "“Women of Sordland, we must not let people like Mr. Leste..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "On the front page, there was the face of Curtan Leste, mayor of Anrica. He was a Benfi native who had a longstanding relationship with the city's current mayor, and had been personally invited to make tonight's opening speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The Benfi Festival was one of the biggest events of the y..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_P_Monica_Benfi_Speech == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_P_Monica_Benfi_Speech == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Monica's face was featured on the front page. But the sch..."*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_P_Monica_Benfi_Speech == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "On the front page, there was the face of Curtan Leste, ma..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Monica's face was featured on the front page. But the schedule on the inside still said that Curtan Leste, mayor of Anrica, would be making the opening remarks. My last-minute announcement that my wife would be replacing Curtan must have caused some confusion at the print shop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "The Benfi Festival was one of the biggest events of the y..."*)

### Węzeł `[114]`
Mówca: **Narrator**
> "The mayor was still standing defiantly in the front row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“Enough, Mr. Leste! Let her speak!""*)
  - -> `[116]` (*Player: "“Mr. Leste. Please calm down, take your seat, and let her..."*)
  - -> `[118]` (*Player: "“Mr. Leste. Do I have to teach you basic manners? Have yo..."*)
  - -> `[119]` (*Player: "“Thank you for the speech, Monica. You've done... enough.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Enough, Mr. Leste! Let her speak!""]** — Mówca: **Player**
> "“Enough, Mr. Leste! Let her speak!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Mr. Leste. Please calm down, take your seat, and let her finish. Now.”"]** — Mówca: **Player**
> "“Mr. Leste. Please calm down, take your seat, and let her finish. Now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[117]`
Mówca: **Narrator**
> "The room immediately quieted down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“Curtan, if you don't sit down now and let her speak, I s..."*)
  - -> `[120]` (*Player: "“Monica, please continue your speech.”"*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Mr. Leste. Do I have to teach you basic manners? Have you forgotten what you learned in kindergarten?""]** — Mówca: **Player**
> "“Mr. Leste. Do I have to teach you basic manners? Have you forgotten what you learned in kindergarten?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Thank you for the speech, Monica. You've done... enough.""]** — Mówca: **Player**
> "“Thank you for the speech, Monica. You've done... enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 4"*)

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Monica, please continue your speech.”"]** — Mówca: **Player**
> "“Monica, please continue your speech.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Curtan Leste: "“I will not stand idly by as our Sordish values are being..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Curtan, if you don't sit down now and let her speak, I swear I will...”"]** — Mówca: **Player**
> "“Curtan, if you don't sit down, I swear I will...”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Curtan Leste: "“You swear you will...what, Mr. President?”"*)

### Węzeł `[122]`
Mówca: **Curtan Leste**
> "“You swear you will...what, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Player: "“...make you pay.”"*)
  - -> `[124]` (*Player: "“...have you removed.”"*)
  - -> `[125]` (*Player_Italic: "Stare into his eyes menacingly."*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "“...make you pay.”"]** — Mówca: **Player**
> "“...make you pay.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Curtan Leste: "“Do you realize what you are doing right now?”"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“...have you removed.”"]** — Mówca: **Player**
> "“...have you removed.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Curtan Leste: "“Is this what you do to people who protect Sordish values..."*)

### Węzeł `[125]`
**[WYBÓR GRACZA: "Stare into his eyes menacingly."]** — Mówca: **Player_Italic**
> "I stared into his eyes menacingly."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "He did not even flinch."*)

### Węzeł `[126]`
Mówca: **Curtan Leste**
> "“Is this what you do to people who protect Sordish values? To those with different opinions? Have them removed?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“It's what I do to upstarts who fail to show restraint.""*)
  - -> `[130]` (*Player_Italic: "Order the guards to escort him out."*)
  - -> `[152]` (*Player: ""Is rudeness a Sordish value now? Is impropriety?""*)

### Węzeł `[127]`
Mówca: **Narrator**
> "He did not even flinch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Curtan Leste: "“I will not stand idly by as our Sordish values are being..."*)

### Węzeł `[128]`
Mówca: **Curtan Leste**
> "“Is that a threat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“No. It is a request.”"*)
  - -> `[134]` (*Player: "“Yes, it is.”"*)
  - -> `[135]` (*Player_Italic: "Do not reply."*)

### Węzeł `[129]`
Mówca: **Curtan Leste**
> "“How dare you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Curtan Leste: "“To a mayor of Sordland. To a member of your own party...”"*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "Order the guards to escort him out."]** — Mówca: **Player_Italic**
> "I ordered the guards to escort Curtan and his entourage out of the hall."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Kicked Out]"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force = true;
BaseGame.Turn05_Personal_Festival_LesteKicked = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] = true;
Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "My security guards immediately surrounded Curtan and his ..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "My security guards immediately surrounded Curtan and his entourage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Curtan Leste: "“How dare you!”"*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“It's what I do to upstarts who fail to show restraint.""]** — Mówca: **Player**
> "“It's what I do to upstarts who fail to show restraint.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Curtan Leste: "“Is that a threat?”"*)

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Yes, it is.”"]** — Mówca: **Player**
> "“Yes, it is.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Curtan Leste: "“Then you have just made an enemy.”"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply to his question."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Curtan Leste: "“Then you have just made an enemy.”"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“No. It is a request.”"]** — Mówca: **Player**
> "“No. It is a request.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Curtan Leste: "“Then I respectfully decline. I will not stand idly by as..."*)

### Węzeł `[137]`
Mówca: **Curtan Leste**
> "“Then you have just made an enemy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[138]`
Mówca: **Curtan Leste**
> "“Then I respectfully decline. I will not stand idly by as our Sordish values are being tested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Curtan Leste: "“Especially by our very own president and his harlot of a..."*)

### Węzeł `[139]`
Mówca: **Curtan Leste**
> "“Especially by our very own president and his harlot of a wife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player: "“Curtan, let's talk about this.”"*)
  - -> `[167]` (*Player: "“Is rudeness a Sordish value now? Is impropriety?”"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "Curtan grabbed his coat and made his way to the exit. The men who had been sitting with him got up and followed him out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteLeft = true"*)

### Węzeł `[141]`
Mówca: **Curtan Leste**
> "“I will not stand idly by as our Sordish values are being tested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Curtan Leste: "“Especially by our very own president and his harlot of a..."*)

### Węzeł `[142]`
Mówca: **Curtan Leste**
> "“Especially by our very own president and his harlot of a wife!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player: ""Is rudeness a Sordish value now? Is impropriety?""*)
  - -> `[174]` (*Player: "“That's the last straw, Curtan -- get out of my sights im..."*)
  - -> `[178]` (*Player: "“Please do not make me repeat myself.”"*)

### Węzeł `[143]`
Mówca: **Curtan Leste**
> "“Do you realize what you are doing right now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Curtan Leste: "“You are threatening a member of the Assembly. A member o..."*)

### Węzeł `[144]`
Mówca: **Curtan Leste**
> "“You are threatening a member of the Assembly. A member of your own party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Curtan Leste: "“What a damn shame.”"*)

### Węzeł `[145]`
Mówca: **Curtan Leste**
> "“What a damn shame.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Curtan Leste: "“Congratulations, Mr. President. You have just made a new..."*)

### Węzeł `[146]`
Mówca: **Curtan Leste**
> "“Congratulations, Mr. President. You have just made a new enemy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[147]`
Mówca: **Curtan Leste**
> "“To a mayor of Sordland. To a member of your own party...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Narrator: "As he was being dragged out of the venue, his voice echoe..."*)

### Węzeł `[148]`
Mówca: **Curtan Leste**
> "“You'll pay for this, Anton! I swear on my name.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Curtan Leste: "“Do you hear me?! You will pay! I--""*)

### Węzeł `[149]`
Mówca: **Narrator**
> "As he was being dragged out of the venue, his voice echoed in the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Curtan Leste: "“You'll pay for this, Anton! I swear on my name.”"*)

### Węzeł `[150]`
Mówca: **Curtan Leste**
> "“Do you hear me?! You will pay! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "The door closed behind them. The crowd began to whisper."*)

### Węzeł `[151]`
Mówca: **Narrator**
> "The door closed behind them. The crowd began to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Having regained her composure, Monica stepped back behind..."*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Is rudeness a Sordish value now? Is impropriety?""]** — Mówca: **Player**
> ""Is rudeness a Sordish value now? Is impropriety?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leste Persuasion]"*)

### Węzeł `[153]`
Mówca: **Narrator**
> "The crowd was booing Curtan loudly now. He looked around the room and let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Curtan Leste: "“My apologies, Mr. President. Mrs. First Lady. I crossed ..."*)

### Węzeł `[154]`
Mówca: **Curtan Leste**
> "“My apologies, Mr. President. Mrs. First Lady. I crossed a line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Monica had regained her composure by now. She took her pl..."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Monica had regained her composure by now. She took her place at the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Monica: "“My heartfelt apologies to you as well, Mr. Leste. I assu..."*)

### Węzeł `[156]`
Mówca: **Monica**
> "“My heartfelt apologies to you as well, Mr. Leste. I assure you, my intention was not to offend anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Monica: "“Especially a senior member of the Assembly such as yours..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Curtan smiled faintly. Monica turned to the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Monica: "“I hope one day we shall all be able to set aside our dif..."*)

### Węzeł `[158]`
Mówca: **Monica**
> "“I hope one day we shall all be able to set aside our differences as we have done today...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Monica: "“And walk towards a happier, brighter future for all of S..."*)

### Węzeł `[159]`
Mówca: **Monica**
> "“And walk towards a happier, brighter future for all of Sordland's citizens, male and female alike. We must all remember: the future cannot exist without the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Monica: "“And I believe we're witnessing the meeting of our glorio..."*)

### Węzeł `[160]`
Mówca: **Monica**
> "“And I believe we're witnessing the meeting of our glorious past and our bright future right here in Benfi today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Monica: "“Ladies and gentlemen, I am proud to officially open the ..."*)

### Węzeł `[161]`
Mówca: **Monica**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "“Vectern sis da!“. Everyone in the hall, including Curtan..."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "“Vectern sis da!“. Everyone in the hall, including Curtan, finished the decades-old saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "The crowd erupted in cheers. Even Curtan started clapping."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "The crowd erupted in cheers. Even Curtan started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Narrator: "People started chanting Monica's name, and the band broke..."*)

### Węzeł `[164]`
Mówca: **Narrator**
> "People started chanting Monica's name, and the band broke into the official festival anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The opening event was finally finished."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "“Curtan, let's talk about this.”"]** — Mówca: **Player**
> "“Curtan, let's talk about this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Curtan Leste: "“It's too late, Mr. President. Goodbye.”"*)

### Węzeł `[166]`
Mówca: **Curtan Leste**
> "“It's too late, Mr. President. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "“Is rudeness a Sordish value now? Is impropriety?”"]** — Mówca: **Player**
> "“Is rudeness a Sordish value now? Is impropriety?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leste Persuasion]"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Speech Reconciliation`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "The crowd was booing Curtan loudly now. He looked around ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Monica Speech Curtan Leaves`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "Curtan grabbed his coat and made his way to the exit. The..."*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Is rudeness a Sordish value now? Is impropriety?""]** — Mówca: **Player**
> ""Is rudeness a Sordish value now? Is impropriety?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "Jump to: [Leste Persuasion]"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: "“That's the last straw, Curtan -- get out of my sights immediately!""]** — Mówca: **Player**
> "“That's the last straw, Curtan -- get out of my sights immediately!"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Curtan Leste: ""Mr. President, this is a free country. I refuse to leave.""*)

### Węzeł `[175]`
Mówca: **Curtan Leste**
> ""Mr. President, this is a free country. I refuse to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Narrator: "The two of us glared angrily at each other."*)

### Węzeł `[176]`
Mówca: **Monica**
> "“Especially a senior member of the Assembly such as yourself, who has pledged his life to the betterment of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Curtan smiled faintly. Monica turned to the audience."*)

### Węzeł `[177]`
Mówca: **Monica**
> "“Ladies and gentlemen, I am proud to officially open the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: "“A Morgna wes core!”"*)

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Please do not make me repeat myself.”"]** — Mówca: **Player**
> "“Please do not make me repeat myself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[142]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Curtan Leste: "“Or what? You'll have me kicked out?”"*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[180]`
Mówca: **Narrator**
> "The crowd erupted in laughter. Curtan's face turned red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Curtan Leste: "“I will not stand idly by as our Sordish values are being..."*)

### Węzeł `[181]`
Mówca: **Narrator**
> "Monica gaped at me, looking as if she'd been slapped in the face. I leaned over to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player: ""Mr. Leste, I believe you had a speech prepared?""*)
  - -> `[350]` (*Player: ""I declare this festival officially open!""*)

### Węzeł `[182]`
Mówca: **Narrator**
> "I started walking back to my seat. Monica brushed past me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "“Wait. Don't go. I'm sorry.”"*)
  - -> `[186]` (*Player: "“You knew this was going to happen.”"*)
  - -> `[185]` (*Player_Italic: "Grab her arm to stop her."*)
  - -> `[187]` (*Player_Italic: "Do nothing."*)

### Węzeł `[183]`
Mówca: **Narrator**
> "I had to do something. I walked up to the stage and stood beside my wife at the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "The mayor was still standing defiantly in the front row."*)

### Węzeł `[184]`
**[WYBÓR GRACZA: "“Wait. Don't go. I'm sorry.”"]** — Mówca: **Player**
> "“Wait. Don't go. I'm sorry.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She looked back at me, her face streaked with tears."*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "Grab her arm to stop her."]** — Mówca: **Player_Italic**
> "I grabbed her arm and she stopped."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She looked back at me, her face streaked with tears."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "“You knew this was going to happen.”"]** — Mówca: **Player**
> "“You knew this was going to happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She looked back at me, her face streaked with tears."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing to stop her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She looked back at me, her face streaked with tears."*)

### Węzeł `[188]`
Mówca: **Monica**
> "“I-- I have to go to the washroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "She stormed down the aisle and out the auditorium door."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "She stormed down the aisle and out the auditorium door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Narrator: "I wanted to follow her out. But out of presidential court..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "She looked back at me, her face streaked with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Monica: "“I-- I have to go to the washroom.”"*)

### Węzeł `[191]`
Mówca: **Narrator**
> "I wanted to follow her out. But out of presidential courtesy, I stayed in my seat until the opening ceremony concluded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Narrator: "I was about to leave when I felt a hand on my right shoul..."*)

### Węzeł `[192]`
Mówca: **Narrator**
> "I was about to leave when I felt a hand on my right shoulder. It was Curtan with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Curtan Leste: "“Sometimes sacrifices need to be made for the greater good.”"*)

### Węzeł `[193]`
Mówca: **Curtan Leste**
> "“Thank you for having my back, sir. Rest assured that I will have yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: "“Not now, Curtan.”"*)
  - -> `[195]` (*Player: "“Much appreciated.""*)
  - -> `[197]` (*Player: "“The greater good doesn't seem that great right now.”"*)
  - -> `[198]` (*Player: "“Don't make me regret this.”"*)

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Not now, Curtan.”"]** — Mówca: **Player**
> "“Not now, Curtan.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Curtan Leste: "“Yes, I understand.”"*)

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Much appreciated.""]** — Mówca: **Player**
> ""Much appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Curtan Leste: "“I am glad we are on the same page.”"*)

### Węzeł `[196]`
Mówca: **Curtan Leste**
> "“Sometimes sacrifices need to be made for the greater good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Curtan Leste: "“Thank you for having my back, sir. Rest assured that I w..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“The greater good doesn't seem that great right now.”"]** — Mówca: **Player**
> "“The greater good doesn't seem that great right now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Curtan Leste: "“It never does. Regardless, this was necessary.”"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Don't make me regret this.”"]** — Mówca: **Player**
> "“Don't make me regret this.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Curtan Leste: "“I will not.”"*)

### Węzeł `[199]`
Mówca: **Curtan Leste**
> "“Yes, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "We walked out of the auditorium together."*)

### Węzeł `[200]`
Mówca: **Curtan Leste**
> "“I am glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "We walked out of the auditorium together."*)

### Węzeł `[201]`
Mówca: **Curtan Leste**
> "“It never does. Regardless, this was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "We walked out of the auditorium together."*)

### Węzeł `[202]`
Mówca: **Curtan Leste**
> "“I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "We walked out of the auditorium together."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "We walked out of the auditorium together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "As Serge drove me back to the hotel, I hoped that the con..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Narrator: "The crowd erupted in laughter. Curtan's face turned red."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Narrator: "Monica gaped at me, looking as if she'd been slapped in t..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Curtan Leste: "“I will not stand idly by as our Sordish values are being..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "The room immediately quieted down again."*)

### Węzeł `[208]`
Mówca: **Narrator**
> "Having regained her composure, Monica stepped back behind the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Monica: "“Ladies and gentlemen, this incident only serves to demon..."*)

### Węzeł `[209]`
Mówca: **Monica**
> "“Ladies and gentlemen, this incident only serves to demonstrate how visibly divided our country is today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Monica: "“My intention was not to offend or harm anyone. It is unf..."*)

### Węzeł `[210]`
Mówca: **Monica**
> "“My intention was not to offend or harm anyone. It is unfortunate that even the mention of modern ideals still does not resonate with many in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Monica: "“I hope we can set aside our differences one day...”"*)

### Węzeł `[211]`
Mówca: **Monica**
> "“I hope we can set aside our differences one day...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Monica: "“And walk towards a happier, brighter future for all of S..."*)

### Węzeł `[212]`
Mówca: **Monica**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "“Vectern sis da!“ Most of the audience finished the decad..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "“Vectern sis da!“ Most of the audience finished the decades-old saying, but nervous whispers still emanated from around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "The opening event was finally finished."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "As Serge drove me back to the hotel, I hoped that the consequences of my actions today would not be too harsh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "I hoped that I could reconcile with Monica."*)

### Węzeł `[215]`
Mówca: **Narrator**
> "I hoped that I could reconcile with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "But I knew she might never forgive me."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "But I knew she might never forgive me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_BenfiFestival = true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_Personal_BenfiFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_Personal_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[218]`
Mówca: **Narrator**
> "The opening event was finally finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Narrator: "But I knew Curtan would never forget what happened today."*)

### Węzeł `[219]`
Mówca: **Narrator**
> "But I knew Curtan would never forget what happened today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_BenfiFestival = true"*)

### Węzeł `[220]`
Mówca: **Narrator**
> "The opening event was finally finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "But my troubles with Curtan were not."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "But my troubles with Curtan were not."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Narrator: "I let Monica and my entourage know we'd be flying straigh..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA: "“You know what, Curtan? My wife is absolutely right.”"]** — Mówca: **Player**
> "“You know what, Curtan? My wife is absolutely right.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I'm so sorry about this, Mr. Leste. Please finish your speech.”"]** — Mówca: **Player**
> "“I'm so sorry about this, Mr. Leste. Please finish your speech.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2"*)

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Monica, get back in your goddamn seat!""]** — Mówca: **Player**
> "“Monica, get back in your goddamn seat!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 2"*)

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Monica, we've been over this. Now is not the time. Sit down, please.”"]** — Mówca: **Player**
> "“Monica, we've been over this. Now is not the time. Sit down, please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Monica: "“I--”"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Monica looked at me, surprise registering on her face."*)

### Węzeł `[228]`
Mówca: **Monica**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "The crowd was in uproar. I had to lean over to catch Moni..."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "Monica looked at me, surprise registering on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Monica: "“Thank you, Anton.”"*)

### Węzeł `[230]`
Mówca: **Monica**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Narrator: "I turned to Curtan."*)

### Węzeł `[231]`
**[WYBÓR GRACZA: "“But we will take up her concerns at a later time. Please finish your speech.”"]** — Mówca: **Player**
> "“But we will take up her concerns at a later time. Please finish your speech.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Curtan Leste: "“Thank you, Mr. President.”"*)

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Your task was to give an opening speech, not a moral lecture.”"]** — Mówca: **Player**
> "“Your task was to give an opening speech, not a moral lecture.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Curtan Leste: "“I will finish my speech if you'll allow it, Mr. President.""*)

### Węzeł `[233]`
Mówca: **Narrator**
> "I turned to Curtan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Player: "“But we will take up her concerns at a later time. Please..."*)
  - -> `[234]` (*Player: "“Now, please, get your speech over with already.”"*)
  - -> `[232]` (*Player: "“Your task was to give an opening speech, not a moral lec..."*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Now, please, get your speech over with already.”"]** — Mówca: **Player**
> "“Now, please, get your speech over with already.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Curtan Leste: "“I will, Mr. President. If you'll allow it.”"*)

### Węzeł `[235]`
Mówca: **Curtan Leste**
> "“I will, Mr. President. If you'll allow it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Narrator: "He looked at me threateningly before continuing."*)

### Węzeł `[236]`
Mówca: **Narrator**
> "He looked at me threateningly before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Speech]"*)

### Węzeł `[237]`
Mówca: **Curtan Leste**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Speech]"*)

### Węzeł `[238]`
Mówca: **Curtan Leste**
> "“I will finish my speech if you'll allow it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Player: "“Go on.”"*)
  - -> `[240]` (*Player: "“That's up to the people of Benfi, isn't it?""*)

### Węzeł `[239]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Curtan Leste: "“How very generous of you.”"*)

### Węzeł `[240]`
**[WYBÓR GRACZA: "“That's up to the people of Benfi, isn't it?""]** — Mówca: **Player**
> "“That's up to the people of Benfi, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "I turned around to look at the crowd. The people immediat..."*)

### Węzeł `[241]`
Mówca: **Narrator**
> "I turned around to look at the crowd. The people immediately started booing Curtan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "He ignored them and continued with his speech."*)

### Węzeł `[242]`
Mówca: **Curtan Leste**
> "“How very generous of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Speech]"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Curtan Speech`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Curtan Leste: "“Benfi has always been a beacon of culture, tradition and..."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Curtan Speech"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Curtan Speech"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Curtan Speech"*)

### Węzeł `[247]`
Mówca: **Narrator**
> "He ignored them and continued with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Speech]"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Curtan Speech"*)

### Węzeł `[249]`
Mówca: **Curtan Leste**
> "“Benfi has always been a beacon of culture, tradition and religion. Many battles have been fought over this precious city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Curtan Leste: "“Army after army has tried to claim it for their own, but..."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "The crowd was in uproar. I had to lean over to catch Monica's next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Monica: "“I'm *so* sorry, Anton. Next time, I'll stay in the kitch..."*)

### Węzeł `[251]`
Mówca: **Monica**
> "“I'm *so* sorry, Anton. Next time, I'll stay in the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "She sat back down, seething. Curtan's voice filled the hall."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Curtan Leste: "“Thank you, Mr. President.”"*)

### Węzeł `[253]`
Mówca: **Narrator**
> "She sat back down, seething. Curtan's voice filled the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Speech]"*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Speech]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "Curtan Speech"*)

### Węzeł `[255]`
Mówca: **Curtan Leste**
> "“Army after army has tried to claim it for their own, but we fought back and won each time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Curtan Leste: "“We stand here thanks to the strong men who were able to ..."*)

### Węzeł `[256]`
Mówca: **Curtan Leste**
> "“We stand here thanks to the strong men who were able to protect their families, their lands, their way of living.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Curtan Leste: "“Every day, I praise God that we have succeeded so far.”"*)

### Węzeł `[257]`
Mówca: **Curtan Leste**
> "“Every day, I praise God that we have succeeded so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Scattered applause broke out from some of the older membe..."*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Scattered applause broke out from some of the older members of the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Narrator: "I leaned over to Monica."*)

### Węzeł `[259]`
Mówca: **Curtan Leste**
> "“Yet the traditions that form the very fabric of our society are being tested. Even as I speak!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He looked pointedly at Monica."*)

### Węzeł `[260]`
Mówca: **Curtan Leste**
> "“We must stay true to our values so that Sordland can prevail. So that Benfi can prevail!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Curtan Leste: "“With these at the forefront, I am convinced that Sordlan..."*)

### Węzeł `[261]`
Mówca: **Curtan Leste**
> "“With these at the forefront, I am convinced that Sordland will continue to be the greatest nation in the world!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Curtan Leste: "“I invite every single one of you to celebrate our roots ..."*)

### Węzeł `[262]`
Mówca: **Curtan Leste**
> "“I invite every single one of you to celebrate our roots and our traditions at this holy Benfi Festival!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Curtan Leste: "“I hereby declare the festival open! Praise God! Praise S..."*)

### Węzeł `[263]`
Mówca: **Curtan Leste**
> "“I hereby declare the festival open! Praise God! Praise Sordland! Praise Benfi!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Curtan Leste: "“A Morgna wes core!”"*)

### Węzeł `[264]`
Mówca: **Narrator**
> "I leaned over to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player: "“He's a bit extreme, but he is right. We owe everything t..."*)
  - -> `[266]` (*Player: "“He sounds more like a priest than a politician.”"*)
  - -> `[336]` (*Player: "“I praise God he's only allowed to speak for another two ..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA: "“He's a bit extreme, but he is right. We owe everything to God.”"]** — Mówca: **Player**
> "“He's a bit extreme, but he is right. We owe everything to God.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[266]`
**[WYBÓR GRACZA: "“He sounds more like a priest than a politician.”"]** — Mówca: **Player**
> "“He sounds more like a priest than a politician.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[267]`
Mówca: **Monica**
> "“I do not like it when the two collide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Curtan Leste: "“Yet the traditions that form the very fabric of our soci..."*)

### Węzeł `[268]`
Mówca: **Monica**
> "“He's a fanatic. Right or not, that's never any good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Curtan Leste: "“Yet the traditions that form the very fabric of our soci..."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He looked pointedly at Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Curtan Leste: "“We must stay true to our values so that Sordland can pre..."*)

### Węzeł `[270]`
Mówca: **Narrator**
> "“Vectern sis da!“. Most of the people in the hall finished the decades-old saying, including me. Monica's lips moved, but she didn't say the words out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "He exited the stage as the band struck up the official fe..."*)

### Węzeł `[271]`
Mówca: **Curtan Leste**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Narrator: "“Vectern sis da!“. Most of the people in the hall finishe..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "He exited the stage as the band struck up the official festival anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Narrator: "I spent the rest of the evening alternately watching the ..."*)

### Węzeł `[273]`
Mówca: **Narrator**
> "I spent the rest of the evening alternately watching the festivities and conversing with local politicians. By the time we got back to the hotel, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "But thanks to the festivities still raging outside -- and..."*)

### Węzeł `[274]`
Mówca: **Narrator**
> "But thanks to the festivities still raging outside -- and the sound of Monica tossing and turning beside me -- I couldn't sleep at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_BenfiFestival = true"*)

### Węzeł `[275]`
Mówca: **Narrator**
> "There were film screenings, concerts, theater and dance performances, art exhibitions, and celebrity-studded nightly galas. The opening ceremonies were broadcast on TV and watched by millions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "As the car slowed, a coterie of reporters and security gu..."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Curtan Kicked Out`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force = true; BaseGame...."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Kicked Out]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Curtan Kicked Out"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Kicked Out]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Curtan Kicked Out"*)

### Węzeł `[279]`
Mówca: **Narrator**
> "The two of us glared angrily at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Player_Italic: "Order the guards to kick him out."*)
  - -> `[286]` (*Player: "“Then you will stay and watch the speech. Without interru..."*)

### Węzeł `[280]`
Mówca: **Curtan Leste**
> "“Or what? You'll have me kicked out?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player: "“That is exactly what I am doing. Guards!""*)
  - -> `[282]` (*Player: "“You will stay and watch the speech. Without interrupting..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA: "“That is exactly what I am doing. Guards!""]** — Mówca: **Player**
> "“That is exactly what I am doing. Guards!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Kicked Out]"*)

### Węzeł `[282]`
**[WYBÓR GRACZA: "“You will stay and watch the speech. Without interrupting it.”"]** — Mówca: **Player**
> "“You will stay and watch the speech. Without interrupting it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Curtan's response was nearly drowned out by the booing cr..."*)

### Węzeł `[283]`
Mówca: **Curtan Leste**
> "“I will not stay where I am not wanted. Clearly that's the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Curtan's response was nearly drowned out by the booing crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Curtan Leste: "“I will not stay where I am not wanted. Clearly that's th..."*)

### Węzeł `[285]`
**[WYBÓR GRACZA: "Order the guards to kick him out."]** — Mówca: **Player_Italic**
> "I ordered my guards to kick Curtan out."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Kicked Out]"*)

### Węzeł `[286]`
**[WYBÓR GRACZA: "“Then you will stay and watch the speech. Without interrupting it.”"]** — Mówca: **Player**
> "“Then you will stay and watch the speech. Without interrupting it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "He tried to reply, but he was drowned out by the boos of ..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Kicked Out]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Curtan Kicked Out"*)

### Węzeł `[288]`
Mówca: **Narrator**
> "He tried to reply, but he was drowned out by the boos of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "He looked around the room and let out a deep sigh."*)

### Węzeł `[289]`
Mówca: **Curtan Leste**
> "“I will not stay where I am not wanted. Clearly that's the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Curtan Leste: ""Goodye, Mr. President.”"*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[291]`
Mówca: **Curtan Leste**
> ""Goodye, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[292]`
Mówca: **Narrator**
> "He looked around the room and let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Curtan Leste: "“I will not stay where I am not wanted. Clearly that's th..."*)

### Węzeł `[293]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion <= 0"*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_Opinion <= 0)"*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Monica: ""Whatever you say.""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Monica: "“I know, and I understand. It's just going to take me som..."*)

### Węzeł `[296]`
Mówca: **Monica**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "She clearly did not want to pursue this topic any further."*)

### Węzeł `[297]`
Mówca: **Narrator**
> "She didn't reply at all. She clearly did not want to pursue this topic any further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Monica: "“No, I will not sit down this time.”"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = false"*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = false"*)

### Węzeł `[301]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = true"*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 4`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = false"*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force == false"*)
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_Force == false)"*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_Force == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_A_DamageControl = true"*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_Force == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_Refugees = true;"*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn05_A_DamageControl = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn05_A_DamageControl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Uziren_Refugees = true;"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true &&..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill = true"*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force == false"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_Force == false"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Uziren_Refugees = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_Refugees"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "EnableNews("G_WehlenDeploysForces")"*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)"*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Education_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_EducationNegative =..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Education_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative ..."*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_EducationNegative = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_EducationNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && B..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "BaseGame.Country_Unrest > 0"*)
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Country_Unrest > 0)"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Country_Unrest > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Estord_Unrest = true"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Country_Unrest > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Lachaven_NoUnrest = true; B..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Estord_Unrest = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Lachaven_NoUnrest = true;
BaseGameSupport.News_Turn05_HP_GruniReturnsNormal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_NoUnrest"] = true;
Variable["BaseGameSupport.News_Turn05_HP_GruniReturnsNormal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Valgen", "City_Widesprea..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteLeft = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "Having regained her composure, Monica stepped back behind..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = false"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = true"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = true"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival = true"*)

### Węzeł `[333]`
Mówca: **Narrator**
> "I had been asked to make a quick set of remarks introducing Curtan Leste. I beckoned Monica to join me on the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Monica: "“I'm going to find my seat.""*)

### Węzeł `[334]`
Mówca: **Monica**
> "“Enough!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "The hall fell silent. Monica rose and continued."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "The hall fell silent. Monica rose and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Monica: "“Mr. Leste, it is not young women who are a disgrace to t..."*)

### Węzeł `[336]`
**[WYBÓR GRACZA: "“I praise God he's only allowed to speak for another two minutes.”"]** — Mówca: **Player**
> "“I praise God he's only allowed to speak for another two minutes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[264]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Monica: "“He's a fanatic. Right or not, that's never any good.”"*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "Monica said nothing, her gaze fixed forward."*)

### Węzeł `[340]`
Mówca: **Narrator**
> "Monica said nothing, her gaze fixed forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Curtan Leste: "“Yet the traditions that form the very fabric of our soci..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[343]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Monica: "“I do not like it when the two collide.”"*)

### Węzeł `[343]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "Monica said nothing, her gaze fixed forward."*)

### Węzeł `[344]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Narrator: "Monica stifled a short laugh."*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Narrator: "Monica said nothing, her gaze fixed forward."*)

### Węzeł `[347]`
Mówca: **Narrator**
> "Monica stifled a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Curtan Leste: "“Yet the traditions that form the very fabric of our soci..."*)

### Węzeł `[348]`
Mówca: **Curtan Leste**
> ""Enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Narrator: "The entire hall fell silent. The mayor of Anrica rose and..."*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""Mr. Leste, I believe you had a speech prepared?""]** — Mówca: **Player**
> ""Mr. Leste, I believe you had a speech prepared?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "Smiling triumphantly, Curtan strode to the podium."*)

### Węzeł `[350]`
**[WYBÓR GRACZA: ""I declare this festival officially open!""]** — Mówca: **Player**
> ""I declare this festival officially open!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "After some confusion, the band broke into the official fe..."*)

### Węzeł `[351]`
Mówca: **Narrator**
> "After some confusion, the band broke into the official festival anthem. The crowd cheered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "I started walking back to my seat. Monica brushed past me."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "Smiling triumphantly, Curtan strode to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "I started walking back to my seat. Monica brushed past me."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Leste Persuasion`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Curtan Leste: ""I'm only doing what I feel is right to protect my country.""*)

### Węzeł `[354]`
Mówca: **Curtan Leste**
> ""I'm only doing what I feel is right to protect my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Player: ""And I feel it's right to have you thrown out. Guards!""*)
  - -> `[355]` (*Player: ""You feel it's right to berate a woman? The president's w..."*)
  - -> `[357]` (*Player: ""Sordland does not need your protection.""*)

### Węzeł `[355]`
**[WYBÓR GRACZA: ""You feel it's right to berate a woman? The president's wife, at that?""]** — Mówca: **Player**
> ""You feel it's right to berate a woman? The president's wife, at that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Curtan Leste: ""Her ideas are dangerous, Anton. They'll lead us down a d..."*)

### Węzeł `[356]`
**[WYBÓR GRACZA: ""And I feel it's right to have you thrown out. Guards!""]** — Mówca: **Player**
> ""And I feel it's right to have you thrown out. Guards!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Kicked Out]"*)

### Węzeł `[357]`
**[WYBÓR GRACZA: ""Sordland does not need your protection.""]** — Mówca: **Player**
> ""Sordland does not need your protection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[354]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Curtan Leste: ""Her ideas are dangerous, Anton. They'll lead us down a d..."*)

### Węzeł `[358]`
Mówca: **Curtan Leste**
> ""Her ideas are dangerous, Anton. They'll lead us down a dark path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Player: ""Your ideas, on the other hand, will lead us back to the ..."*)
  - -> `[361]` (*Player: ""Maybe they will, maybe they won't. The only thing for ce..."*)
  - -> `[362]` (*Player: ""I'll show you a dark path. Guards!""*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Kicked Out]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Curtan Kicked Out"*)

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Your ideas, on the other hand, will lead us back to the Dark Ages.""]** — Mówca: **Player**
> ""Your ideas, on the other hand, will lead us back to the Dark Ages.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Curtan Leste: ""Without our traditions, we are lost.""*)

### Węzeł `[361]`
**[WYBÓR GRACZA: ""Maybe they will, maybe they won't. The only thing for certain is that you won't garner sympathy by making a scene.""]** — Mówca: **Player**
> ""Maybe they will, maybe they won't. The only thing for certain is that you won't garner sympathy by making a scene.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Reconciliation]"*)

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I'll show you a dark path. Guards!""]** — Mówca: **Player**
> ""I'll show you a dark path. Guards!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[358]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "Jump to: [Curtan Kicked Out]"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Reconciliation]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "Monica Speech Reconciliation"*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Curtan Kicked Out]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "Curtan Kicked Out"*)

### Węzeł `[365]`
Mówca: **Curtan Leste**
> ""Without our traditions, we are lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player: ""And without change, we are fossils. Now please, sit down.""*)
  - -> `[367]` (*Player: ""My administration has not lost sight of tradition. You'l..."*)
  - -> `[368]` (*Player: ""How about you get lost yourself?""*)

### Węzeł `[366]`
**[WYBÓR GRACZA: ""And without change, we are fossils. Now please, sit down.""]** — Mówca: **Player**
> ""And without change, we are fossils. Now please, sit down.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Reconciliation]"*)

### Węzeł `[367]`
**[WYBÓR GRACZA: ""My administration has not lost sight of tradition. You'll have to trust me, Curtan.""]** — Mówca: **Player**
> ""My administration has not lost sight of tradition. You'll have to trust me, Curtan.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Reconciliation]"*)

### Węzeł `[368]`
**[WYBÓR GRACZA: ""How about you get lost yourself?""]** — Mówca: **Player**
> ""How about you get lost yourself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Narrator: "Curtan scowled at me."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Reconciliation]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "Monica Speech Reconciliation"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Reconciliation]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "Monica Speech Reconciliation"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Monica Speech Curtan Leaves]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "Monica Speech Curtan Leaves"*)

### Węzeł `[372]`
Mówca: **Narrator**
> "Curtan scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Curtan Leste: ""Very well. I will not stay where I am clearly not wanted.""*)

### Węzeł `[373]`
Mówca: **Curtan Leste**
> ""Very well. I will not stay where I am clearly not wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "Jump to: [Monica Speech Curtan Leaves]"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Leste Persuasion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "Leste Persuasion"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Leste Persuasion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "Leste Persuasion"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Leste Persuasion]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "Leste Persuasion"*)

### Węzeł `[377]`
Mówca: **Monica**
> "“And walk towards a happier, brighter future for all of Sordland's citizens, male and female alike. We must all remember: the future cannot exist without the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Monica: "“And I believe we're witnessing the meeting of our glorio..."*)

### Węzeł `[378]`
Mówca: **Monica**
> "“And I believe we're witnessing the meeting of our glorious past and our bright future right here in Benfi today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Monica: "“Ladies and gentlemen, I am proud to officially open the ..."*)

### Węzeł `[379]`
Mówca: **Monica**
> "“Ladies and gentlemen, I am proud to officially open the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Monica: "“A Morgna wes core!”"*)

### Węzeł `[380]`
Mówca: **Narrator**
> "I let Monica and my entourage know we'd be flying straight back to Holsord. I was in for yet another sleepless night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn05_Personal_BenfiFestival = true"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_Personal_Festival_LesteKicked == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic -= 1; BaseGame.Sollist -= 1;"*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_Personal_Festival_LesteKicked == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic -= 1;
BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "// Filler to organize nodes"*)

### Węzeł `[385]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_SupportedAtFestival == true"*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Monica_SupportedAtFestival == true)"*)

### Węzeł `[386]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_SupportedAtFestival == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "BaseGame.Democratic += 1; BaseGame.Sollist -= 1;"*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Monica_SupportedAtFestival == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 1;"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Democratic += 1;
BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "// Filler to organize nodes"*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Węzeł Logiki Narracyjnej: "// Filler to organize nodes"*)

### Węzeł `[390]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `// Filler to organize nodes`
- **Efekt skryptowy (`userScript`):** `-- Filler to organize nodes;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "She gave me a smile, looking somewhat comforted."*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "She smiled and turned her head to look out the window onc..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "Monica swallowed hard. Her eyes grew wider."*)

### Węzeł `[394]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Narrator: "The two of us proceeded to the podium. I spoke first, del..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Monica: "“We will see.”"*)

### Węzeł `[396]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true || Base..."*)
  - -> `[398]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || Ba..."*)

### Węzeł `[397]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced ..."*)

### Węzeł `[398]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true || Base..."*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[400]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true || Base..."*)
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true || Ba..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn05_Estord_GangViolenceIncrease..."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)"*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Narrator: "Since Gloria had convinced me to cancel her opening speec..."*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Since I'd refused to let her make the opening speech, her..."*)

### Węzeł `[407]`
Mówca: **Narrator**
> "Since Gloria had convinced me to cancel her opening speech, things between us had been strained. She'd barely said a word to me all day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Italic: "Say nothing."*)
  - -> `[18]` (*Player: "“Are you still angry about my decision?”"*)
  - -> `[20]` (*Player: ""Will you ever forgive me? I told you my reasons.""*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true"*)
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)"*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player: ""I told you about what Gloria said. The change you want i..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[411]`
**[WYBÓR GRACZA: ""I told you about what Gloria said. The change you want is coming.""]** — Mówca: **Player**
> ""I told you about what Gloria said. The change you want is coming.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Monica: ""When, Anton? In all her time in Assembly, has she propos..."*)

### Węzeł `[412]`
Mówca: **Monica**
> ""When, Anton? In all her time in Assembly, has she proposed even one women's rights law?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Monica: ""If you ask me, she's gotten a bit too comfortable being ..."*)

### Węzeł `[413]`
Mówca: **Monica**
> ""If you ask me, she's gotten a bit too comfortable being one of the only women in the men's club.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Monica: ""Let me have a word with her after all this. I'll show he..."*)

### Węzeł `[414]`
Mówca: **Monica**
> ""Let me have a word with her after all this. I'll show her who's shrill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "As soon as Serge opened the door, we were enveloped by th..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Borin", "City_Widespread..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Borin", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Borin","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RemoveTokenStatus("Sordland_City_Benfi", "City_Widespread..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");`
- **Efekt skryptowy (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_Education_Budget_Decrease == true"*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Our motorcade slowly made its way towards the magnificent..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Booing");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Booing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "The crowd was growing rowdier. Some booed and jeered at C..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("Murmuring");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("Murmuring");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "The crowd was becoming restless. Many of the younger atte..."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EnableNews("G_WehlenDeploysForces")`
- **Efekt skryptowy (`userScript`):** `EnableNews("G_WehlenDeploysForces");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_Personal_Festival_LesteKicked == true"*)
