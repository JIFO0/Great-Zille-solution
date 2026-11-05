# Sordland/Turn02/A_AutocratBriefing

- **ID konwersacji:** `18`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/018_A_AutocratBriefing.md`
- **Liczba węzłów dialogowych:** 646
- **Liczba wyborów gracza:** 209

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[36]** Heron Garaci
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_SetUpMeeting`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_A`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_B`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_C`
- `BaseGameIsolated.Turn02_A_Confront_Whiskey`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Policy_Law_ReformCommittee`
- `BaseGame.Reform_Autocrat_Abandon`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Reform_Dictator_Path`
- `BaseGame.Reform_Reformist_Intention`
- `BaseGame.Reform_Reformist_Path`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_A`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_B`
- `BaseGameIsolated.Turn02_A_Autocrat_Hub_C`
- `BaseGameIsolated.Turn02_A_Confront_Whiskey`
- `BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal`
- `BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal`
- `BaseGameSupport.News_Turn02_E_REEPotential`
- `BaseGameSupport.News_Turn02_G_IyotakePlanMixed`
- `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan`
- `BaseGameSupport.News_Turn02_R_GasomJobsRisk`
- `BaseGameSupport.News_Turn02_R_OrsoSeenInPalace`
- `BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter`
- `BaseGameSupport.Report_Turn02_Morbel_NaturePreservation`
- `GameCondition.Turn02_A_AutocratBriefing`
- `GameCondition.Turn03_A_LateBriefing`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[14]` | **"Pour whiskey."** | `[19]` **Narrator**: "I was either going to cooperate ..."<br>`[20]` **Narrator**: "I waited for him, wondering what..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] = ...` | `[18]` **Narrator**: "It eased my mind a little." |
| `[17]` | **"Take a moment to relax."** | `[19]` **Narrator**: "I was either going to cooperate ..."<br>`[20]` **Narrator**: "I waited for him, wondering what..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "Thousands of shimmering lights i..." |
| `[31]` | **"“Good evening, Lucian.”"** | `[24]` **Lucian Galade**: "Good evening, sir." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Lucian Galade**: ""Soon, Mr. Hawker will be coming..."<br>`[30]` **Lucian Galade**: ""I'm sorry that I couldn't expla..." |
| `[32]` | **"“Good to see you.”"** | `[24]` **Lucian Galade**: "Good evening, sir." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Lucian Galade**: ""Good to see you too, sir."" |
| `[33]` | **"“Have a seat.”"** | `[24]` **Lucian Galade**: "Good evening, sir." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Narrator**: "He sat on a chair near my desk." |
| `[37]` | **"“They are here to threaten us to stop the reforms.”"** | `[36]` **Lucian Galade**: ""He will be coming shortly with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Lucian Galade**: ""We knew they would react at som..." |
| `[38]` | **"“I think he's here to test the waters.""** | `[36]` **Lucian Galade**: ""He will be coming shortly with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Lucian Galade**: ""I agree. They will probably try..." |
| `[39]` | **"“We may be able to cooperate with them.”"** | `[36]` **Lucian Galade**: ""He will be coming shortly with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Lucian Galade**: ""I advise against that, sir. I d..." |
| `[40]` | **"“Regardless of what they say, I will continue with the new Constitution.”"** | `[36]` **Lucian Galade**: ""He will be coming shortly with ..." | `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false` | *Brak zmian stanu* | `[45]` **Lucian Galade**: ""Of course. Let's stand our grou..." |
| `[41]` | **"“I knew they would come. We all want the same thing.”"** | `[36]` **Lucian Galade**: ""He will be coming shortly with ..." | `Variable["BaseGame.Reform_Autocrat_Intention"] == true` | *Brak zmian stanu* | `[46]` **Lucian Galade**: ""I'm sure they have heard about ..." |
| `[53]` | **"“There is nothing to talk about. Let's see what they have to say.""** | `[29]` **Lucian Galade**: ""Before they come, we should tal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Lucian Galade**: ""We should be careful when deali..." |
| `[54]` | **"“What are you suggesting?""** | `[29]` **Lucian Galade**: ""Before they come, we should tal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Lucian Galade**: ""We should be careful when deali..." |
| `[55]` | **"“I aim to get a deal out of this meeting.""** | `[29]` **Lucian Galade**: ""Before they come, we should tal..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Lucian Galade**: ""We should be careful when deali..." |
| `[60]` | **"“I don't trust him either.""** | `[58]` **Lucian Galade**: ""And... I know I told you this b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Lucian Galade**: ""Glad we're on the same page, sir."" |
| `[61]` | **"“Duly noted, Lucian. I'll see about that myself.""** | `[58]` **Lucian Galade**: ""And... I know I told you this b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: ""Of course, sir."" |
| `[62]` | **"“I've heard this enough, Lucian. I told you my intentions.""** | `[58]` **Lucian Galade**: ""And... I know I told you this b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Lucian Galade**: ""Of course, sir."" |
| `[74]` | **"Raise your drink."** | `[24]` **Lucian Galade**: "Good evening, sir." | `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true` | *Brak zmian stanu* | `[75]` **Narrator**: "He sat on a chair near my desk." |
| `[77]` | **"“Good to see you, gentlemen.""** | `[52]` **Heron Garaci**: ""Evening."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: ""Good to see you, indeed."" |
| `[78]` | **"“Welcome, Justice Garaci and Chief Justice Hawker.""** | `[52]` **Heron Garaci**: ""Evening."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Lucian Galade**: ""Good to see you, indeed."" |
| `[82]` | **"Nod."** | `[81]` **Orso Hawker**: "“May I?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "We all took our seats on two opp..." |
| `[83]` | **"“Please.""** | `[81]` **Orso Hawker**: "“May I?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "We all took our seats on two opp..." |
| `[84]` | **""Let's have a seat, gentlemen.""** | `[81]` **Orso Hawker**: "“May I?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Narrator**: "We all took our seats on two opp..." |
| `[91]` | **"“Forgive me, would you also like to have a drink?""** | `[92]` **Orso Hawker**: "“Celebrating something, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Orso Hawker**: ""No, thank you."" |
| `[95]` | **"“I was just trying to relax.""** | `[92]` **Orso Hawker**: "“Celebrating something, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Orso Hawker**: "“A man needs his drink, I unders..." |
| `[96]` | **""I don't think that's relevant to our meeting, Mr. Hawker.""** | `[92]` **Orso Hawker**: "“Celebrating something, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "He gave me a blank stare and rea..." |
| `[97]` | **""Can we get to the point, Mr. Hawker?""** | `[92]` **Orso Hawker**: "“Celebrating something, Mr. Pres..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Narrator**: "He gave me a blank stare and rea..." |
| `[105]` | **""Thank you, it's very busy but I'm doing good.""** | `[93]` **Heron Garaci**: ""How were your first couple of m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Heron Garaci**: ""It will only get busier. Yet, I..." |
| `[106]` | **""To be honest, it was a rough start.""** | `[93]` **Heron Garaci**: ""How were your first couple of m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Heron Garaci**: ""I couldn't imagine. Yet, I thin..." |
| `[107]` | **""I'm doing well. No need to worry, Mr. Garaci.""** | `[93]` **Heron Garaci**: ""How were your first couple of m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Heron Garaci**: ""That's great to hear, Mr. Presi..." |
| `[108]` | **""No need for pleasantries. Let's just get to the point.""** | `[93]` **Heron Garaci**: ""How were your first couple of m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Narrator**: "They both gave me blank stares. ..." |
| `[125]` | **""That's correct.""** | `[124]` **Orso Hawker**: ""We've heard that you're not giv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Orso Hawker**: ""That's relieving to hear."" |
| `[126]` | **""You must have heard wrong, Mr. Hawker.""** | `[124]` **Orso Hawker**: ""We've heard that you're not giv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Orso Hawker**: ""That is quite possible."" |
| `[127]` | **""Where did you hear that?""** | `[124]` **Orso Hawker**: ""We've heard that you're not giv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Orso Hawker**: ""The question is not where I hea..." |
| `[128]` | **""I don't.""** | `[122]` **Orso Hawker**: ""You probably know why we are he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Orso Hawker**: ""We know you are working on a ne..." |
| `[129]` | **""Please enlighten us, Mr. Hawker.""** | `[122]` **Orso Hawker**: ""You probably know why we are he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Orso Hawker**: ""We know you are working on a ne..." |
| `[130]` | **""You're here to bribe me.""** | `[122]` **Orso Hawker**: ""You probably know why we are he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Narrator**: "Heron Garaci laughed." |
| `[131]` | **""You're here to stop the new Constitution.""** | `[122]` **Orso Hawker**: ""You probably know why we are he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Orso Hawker**: ""We are only here to tell you th..." |
| `[132]` | **""I want to protect the current Constitution.""** | `[119]` **Orso Hawker**: "“So, let us hear it from you. Wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Orso Hawker**: ""Looks like we are on the same p..." |
| `[133]` | **""I want to protect our Constitution.""** | `[124]` **Orso Hawker**: ""We've heard that you're not giv..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Orso Hawker**: ""Looks like we are on the same p..." |
| `[134]` | **""I offer cooperation against the reformists.""** | `[119]` **Orso Hawker**: "“So, let us hear it from you. Wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Orso Hawker**: ""That's relieving to hear. Sordl..." |
| `[135]` | **""We need to stay united in times of possible conflict.""** | `[119]` **Orso Hawker**: "“So, let us hear it from you. Wh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Orso Hawker**: ""I agree. Sordland is in a dire ..." |
| `[145]` | **""I am weighing my options first.""** | `[143]` **Orso Hawker**: ""So, you are going to push to ch..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Orso Hawker**: ""That's quite understandable."" |
| `[146]` | **""No, I'd rather work with you, if that's a possibility.""** | `[143]` **Orso Hawker**: ""So, you are going to push to ch..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Orso Hawker**: ""Looks like we are on the same p..." |
| `[148]` | **""Yes, I don't support the reforms.""** | `[141]` **Orso Hawker**: ""The question is not where I hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Orso Hawker**: ""That's relieving to hear."" |
| `[149]` | **""It's neither true or false, I'm weighing my options first.""** | `[141]` **Orso Hawker**: ""The question is not where I hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Orso Hawker**: ""That's quite understandable."" |
| `[163]` | **""How so?""** | `[162]` **Heron Garaci**: ""Yes, Mr. President. Our nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[172]` **Heron Garaci**: ""Mr. President, if you are not a..." |
| `[164]` | **""I've read the security reports. I am suspecting something big too.""** | `[162]` **Heron Garaci**: ""Yes, Mr. President. Our nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Heron Garaci**: ""It's not only some *thing*, Mr...." |
| `[165]` | **""That's a bit far-fetched, isn't it?""** | `[162]` **Heron Garaci**: ""Yes, Mr. President. Our nationa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[192]` **Heron Garaci**: ""Mr. President, if you are not a..." |
| `[169]` | **""You haven't even seen the proposal yet, Mr. Hawker. Isn't it too soon to be again..."** | `[167]` **Orso Hawker**: ""Even if your proposal passes th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[174]` **Orso Hawker**: ""Do you think I live under a roc..." |
| `[170]` | **""So you came here to threaten us.""** | `[167]` **Orso Hawker**: ""Even if your proposal passes th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[176]` **Orso Hawker**: ""How was that a threat, Mr. Pres..." |
| `[171]` | **""Come on, Mr. Hawker. We can figure something out.""** | `[167]` **Orso Hawker**: ""Even if your proposal passes th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Orso Hawker**: ""We can."" |
| `[173]` | **""We'll get the Court too, even if you do not cooperate.""** | `[167]` **Orso Hawker**: ""Even if your proposal passes th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Orso Hawker**: ""Good luck with that."" |
| `[185]` | **""I believe I am fully informed about the situation, Mr. Garaci.""** | `[183]` **Heron Garaci**: ""Yet you, Mr. President, seem to..."<br>`[184]` **Heron Garaci**: ""Mr. President, you seem to be o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[204]` **Heron Garaci**: ""You think you are, Mr. Presiden..." |
| `[186]` | **""Oh? Please explain.""** | `[183]` **Heron Garaci**: ""Yet you, Mr. President, seem to..."<br>`[184]` **Heron Garaci**: ""Mr. President, you seem to be o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Heron Garaci**: ""We are protecting the Constitut..." |
| `[187]` | **""Let's hear it.""** | `[183]` **Heron Garaci**: ""Yet you, Mr. President, seem to..."<br>`[184]` **Heron Garaci**: ""Mr. President, you seem to be o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Heron Garaci**: ""We are protecting the Constitut..." |
| `[188]` | **""I don't care about your reasons.""** | `[183]` **Heron Garaci**: ""Yet you, Mr. President, seem to..."<br>`[184]` **Heron Garaci**: ""Mr. President, you seem to be o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Heron Garaci**: ""That's exactly what they want y..." |
| `[195]` | **""Please explain, Mr. Hawker.""** | `[194]` **Orso Hawker**: ""That is a good question. How? M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Orso Hawker**: ""I have incriminating evidence a..." |
| `[196]` | **""I trust my team, Mr. Hawker. You shouldn't concern yourself with these matters.""** | `[194]` **Orso Hawker**: ""That is a good question. How? M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Orso Hawker**: ""I did not want to offend you, M..." |
| `[197]` | **""Let the Chief Justice talk, Lucian.""** | `[194]` **Orso Hawker**: ""That is a good question. How? M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Orso Hawker**: ""I have incriminating evidence a..." |
| `[205]` | **""Who are 'they'?""** | `[203]` **Heron Garaci**: ""That's exactly what they want y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[206]` | **""I am merely stating my feelings.""** | `[203]` **Heron Garaci**: ""That's exactly what they want y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[207]` | **""What does that mean?""** | `[203]` **Heron Garaci**: ""That's exactly what they want y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[210]` | **""And what would that be?""** | `[204]` **Heron Garaci**: ""You think you are, Mr. Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[211]` | **""Go on.""** | `[204]` **Heron Garaci**: ""You think you are, Mr. Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[212]` | **""I am not interested in your games.""** | `[204]` **Heron Garaci**: ""You think you are, Mr. Presiden..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Narrator**: "Orso signalled Heron with his ha..." |
| `[214]` | **""I am very troubled by that. We need to be prepared against Rumburg.""** | `[213]` **Orso Hawker**: ""What do you think about the off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Orso Hawker**: ""Is the administration doing som..." |
| `[215]` | **""Blud separatists must be dealt with before they gain the support of the Bluds.""** | `[213]` **Orso Hawker**: ""What do you think about the off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Orso Hawker**: ""Is the administration doing som..." |
| `[216]` | **""The connection is not that strong, I don't think they are a real threat.""** | `[213]` **Orso Hawker**: ""What do you think about the off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Orso Hawker**: ""We all know what the Bludish Fr..." |
| `[219]` | **""I don't think the organization is strong enough to create problems.""** | `[218]` **Orso Hawker**: ""We all know what the Bludish Fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Orso Hawker**: ""Have you even talked with your ..." |
| `[220]` | **""We haven't found thousands of it. That is not enough to establish a direct connec..."** | `[218]` **Orso Hawker**: ""We all know what the Bludish Fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Orso Hawker**: ""Have you even talked with your ..." |
| `[221]` | **""My security team is working on that.""** | `[217]` **Orso Hawker**: ""Is the administration doing som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Orso Hawker**: ""Clearly.""<br>`[229]` **Orso Hawker**: ""That's not good enough, Mr. Pre..." |
| `[222]` | **""We are not rushing with our actions just yet.""** | `[217]` **Orso Hawker**: ""Is the administration doing som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Orso Hawker**: ""Clearly.""<br>`[229]` **Orso Hawker**: ""That's not good enough, Mr. Pre..." |
| `[223]` | **""Not as fast as I'd like to.""** | `[217]` **Orso Hawker**: ""Is the administration doing som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Orso Hawker**: ""Clearly.""<br>`[229]` **Orso Hawker**: ""That's not good enough, Mr. Pre..." |
| `[237]` | **""I agree, security will be improved.""** | `[230]` **Heron Garaci**: ""We hope that regardless of your..."<br>`[236]` **Orso Hawker**: ""We need an increase on our secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Heron Garaci**: ""That's great to hear."" |
| `[238]` | **""I am not sure about it.""** | `[230]` **Heron Garaci**: ""We hope that regardless of your..."<br>`[236]` **Orso Hawker**: ""We need an increase on our secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Orso Hawker**: ""Are you also aware that the arm..." |
| `[239]` | **""Is that a demand?""** | `[230]` **Heron Garaci**: ""We hope that regardless of your..."<br>`[236]` **Orso Hawker**: ""We need an increase on our secu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[240]` **Orso Hawker**: ""Sure, Mr. President. It is a de..." |
| `[243]` | **""Everybody knows that.""** | `[242]` **Orso Hawker**: ""Are you also aware that the arm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Orso Hawker**: ""You know what that means. Do yo..." |
| `[244]` | **""They claim otherwise.""** | `[242]` **Orso Hawker**: ""Are you also aware that the arm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Orso Hawker**: ""They may claim they have no tie..." |
| `[245]` | **""The Worker's Party is a democratic party unlike the militias. They are not the sa..."** | `[242]` **Orso Hawker**: ""Are you also aware that the arm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Orso Hawker**: ""They may claim they have no tie..." |
| `[246]` | **""I mean... They are all Bluds.""** | `[242]` **Orso Hawker**: ""Are you also aware that the arm..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Heron Garaci**: ""They are. And both organization..." |
| `[250]` | **""You know what that means. Do you remember the vote of the Workers'Party in the la..."** | `[243]` **Player**: ""Everybody knows that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Lucian Galade**: ""I see where this is going."" |
| `[254]` | **""You think that's Mr. Ricter's intention?""** | `[253]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Orso Hawker**: ""I suspect his intentions are gr..." |
| `[255]` | **""That's why we cannot allow it, Mr. Hawker.""** | `[253]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Orso Hawker**: ""Therefore, we need to work toge..." |
| `[256]` | **""That's too dramatic.""** | `[253]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Orso Hawker**: ""Say what you will, Mr. Presiden..." |
| `[263]` | **""What does that have to do with anything?""** | `[213]` **Orso Hawker**: ""What do you think about the off..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Orso Hawker**: ""Is the administration doing som..." |
| `[264]` | **""With all due respect, that does not really concern you.""** | `[217]` **Orso Hawker**: ""Is the administration doing som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Orso Hawker**: ""Clearly.""<br>`[229]` **Orso Hawker**: ""That's not good enough, Mr. Pre..." |
| `[274]` | **""Mr. Hawker, the Court has no jurisdiction over these matters.""** | `[272]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Orso Hawker**: ""Aren't we all part of this Stat..." |
| `[275]` | **""We are taking the necessary steps. No need to worry.""** | `[272]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Orso Hawker**: ""We hope that our police forces ..." |
| `[276]` | **""I did promise that but the circumstances have changed.""** | `[272]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Orso Hawker**: ""I am relieved to hear that."" |
| `[277]` | **""Tolerate!? You should be more careful with your words of choice.""** | `[272]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Orso Hawker**: ""Surely a decision to destroy So..." |
| `[278]` | **""Mr. Hawker, the Court has no jurisdiction over these matters.""** | `[273]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Orso Hawker**: ""Aren't we all part of this Stat..." |
| `[279]` | **""We are taking the necessary steps, no need to worry.""** | `[273]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Orso Hawker**: ""We hope that our police forces ..." |
| `[280]` | **""I will actually be increasing the security budget shortly.""** | `[273]` **Orso Hawker**: ""And sadly we don't see the admi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Orso Hawker**: ""I am relieved to hear that."" |
| `[289]` | **""I mean... They are all Bluds.""** | `[288]` **Orso Hawker**: ""But regardless of that, are you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Heron Garaci**: ""They are. And both organization..." |
| `[290]` | **""Everybody knows that.""** | `[288]` **Orso Hawker**: ""But regardless of that, are you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Orso Hawker**: ""You know what that means. Do yo..." |
| `[291]` | **""They claim otherwise.""** | `[288]` **Orso Hawker**: ""But regardless of that, are you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Orso Hawker**: ""They may claim they have no tie..." |
| `[292]` | **""The Worker's Party is a democratic party unlike the militias. They are not the sa..."** | `[288]` **Orso Hawker**: ""But regardless of that, are you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Orso Hawker**: ""They may claim they have no tie..." |
| `[296]` | **""You know what that means. Do you remember the vote of the Workers' Party in the l..."** | `[290]` **Player**: ""Everybody knows that."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[297]` **Lucian Galade**: ""What is this all about?"" |
| `[300]` | **""That's too dramatic.""** | `[299]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[303]` **Orso Hawker**: ""Say what you will, Mr. Presiden..." |
| `[301]` | **""I will not allow it to happen.""** | `[299]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[304]` **Orso Hawker**: ""Therefore, we need to work toge..." |
| `[302]` | **""You think that's Mr. Ricter's intention?""** | `[299]` **Orso Hawker**: ""And all of a sudden, the reform..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Orso Hawker**: ""I suspect his intentions are gr..." |
| `[308]` | **""You're saying the reformists are working for the foreign powers?""** | `[307]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Heron Garaci**: ""Haven't you been briefed by you..." |
| `[309]` | **""I apologise, gentlemen. But I am not a conspiracy theorist.""** | `[307]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[322]` **Heron Garaci**: ""This is not a conspiracy theory..." |
| `[310]` | **""There is no evidence about any of this.""** | `[307]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Heron Garaci**: ""Haven't you been briefed by you..." |
| `[311]` | **""And what is your suggestion?""** | `[307]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[324]` **Orso Hawker**: ""We should take the necessary me..." |
| `[312]` | **""I am not working with the reformists, Mr. Hawker.""** | `[299]` **Orso Hawker**: ""And all of a sudden, the reform..." | `Variable["BaseGame.Reform_Dictator_Intention"] == true` | *Brak zmian stanu* | `[316]` **Orso Hawker**: ""I am aware. Yet you're proceedi..." |
| `[317]` | **""I am. The new Constitution will not be weaker but stronger.""** | `[316]` **Orso Hawker**: ""I am aware. Yet you're proceedi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Orso Hawker**: ""You already have the power of t..." |
| `[318]` | **""We'll see about that.""** | `[316]` **Orso Hawker**: ""I am aware. Yet you're proceedi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Orso Hawker**: ""You already have the power of t..." |
| `[319]` | **""Yes. I need more powers to fix these problems.""** | `[316]` **Orso Hawker**: ""I am aware. Yet you're proceedi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Orso Hawker**: ""You already have the power of t..." |
| `[320]` | **""Unless you have something better to propose.""** | `[316]` **Orso Hawker**: ""I am aware. Yet you're proceedi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[321]` **Orso Hawker**: ""You already have the power of t..." |
| `[328]` | **""Let the Chief Justice talk, Lucian.""** | `[327]` **Lucian Galade**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[331]` **Lucian Galade**: ""Of course, sir."" |
| `[329]` | **""You're right. I don't think anything will come out of this meeting.""** | `[327]` **Lucian Galade**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[332]` **Orso Hawker**: ""So you don't want to hear about..." |
| `[330]` | **""Please explain, Mr. Hawker.""** | `[327]` **Lucian Galade**: ""With all due respect, Mr. Presi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[333]` **Orso Hawker**: ""The person in question is Mr. F..." |
| `[340]` | **""I need to know this. Please explain.""** | `[339]` **Heron Garaci**: ""Mr. Galade, we all know he has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[338]` **Orso Hawker**: ""He was spotted in a hotel in Ar..." |
| `[341]` | **""He was hiding his flights to Arcasia?""** | `[339]` **Heron Garaci**: ""Mr. Galade, we all know he has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Heron Garaci**: ""He was."" |
| `[342]` | **""Another conspiracy theory.""** | `[339]` **Heron Garaci**: ""Mr. Galade, we all know he has ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[359]` **Orso Hawker**: ""Believe what you will, Mr. Pres..." |
| `[347]` | **""How did you find out about this?""** | `[346]` **Orso Hawker**: ""He also attended another event ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Orso Hawker**: ""Many Sollists were already foll..." |
| `[348]` | **""If this is true, this is *big*.""** | `[346]` **Orso Hawker**: ""He also attended another event ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Orso Hawker**: ""I told you so, Mr. President."" |
| `[349]` | **""How can any of these be undocumented?""** | `[346]` **Orso Hawker**: ""He also attended another event ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[350]` **Orso Hawker**: ""We don't know. Even if he used ..." |
| `[362]` | **""There is no need, Mr. Hawker. This meeting is over.""** | `[332]` **Orso Hawker**: ""So you don't want to hear about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Orso Hawker**: ""I see."" |
| `[363]` | **""I want to hear it first.""** | `[332]` **Orso Hawker**: ""So you don't want to hear about..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Narrator**: "Lucian looked upset." |
| `[369]` | **""You're saying the reformists are working for the foreign powers?""** | `[368]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[373]` **Heron Garaci**: ""Haven't you been briefed by you..." |
| `[370]` | **""And what is your suggestion?""** | `[368]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Orso Hawker**: ""We should take the necessary me..." |
| `[371]` | **""I apologize gentlemen but I am not a conspiracy theorist.""** | `[368]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[374]` **Heron Garaci**: ""This is not a conspiracy theory..." |
| `[372]` | **""This doesn't look good.""** | `[368]` **Heron Garaci**: ""The Reformists' suggested chang..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[375]` **Heron Garaci**: ""No, it doesn't, Mr. President."" |
| `[378]` | **""Please explain, Mr. Hawker.""** | `[377]` **Orso Hawker**: ""...Which brings us to the infor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Orso Hawker**: ""The person in question is Mr. F..." |
| `[379]` | **""Finally.""** | `[377]` **Orso Hawker**: ""...Which brings us to the infor..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[380]` **Orso Hawker**: ""The person in question is Mr. F..." |
| `[388]` | **""Let's talk about how we can work together.""** | `[386]` **Orso Hawker**: ""There is not much to think or c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Orso Hawker**: ""Of course. We cannot wait for t..." |
| `[389]` | **""You want me to declare an emergency?""** | `[386]` **Orso Hawker**: ""There is not much to think or c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Orso Hawker**: ""Of course. We cannot wait for t..." |
| `[390]` | **""I am still too skeptical about these, Mr. Hawker. I will have to decline.""** | `[386]` **Orso Hawker**: ""There is not much to think or c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Orso Hawker**: ""It seems you are more influence..." |
| `[400]` | **""Could you leave us alone with Mr. Hawker, gentlemen?""** | `[399]` **Lucian Galade**: ""Sir, I advise against it.""<br>`[404]` **Narrator**: "Lucian looked at me to hear my r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Narrator**: "Lucian stood up as Orso gave him..." |
| `[405]` | **""I like your idea, Mr. Hawker but I'd rather plan it together.""** | `[399]` **Lucian Galade**: ""Sir, I advise against it.""<br>`[404]` **Narrator**: "Lucian looked at me to hear my r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[429]` **Orso Hawker**: ""Glad to hear that we're on the ..." |
| `[406]` | **""I'm sorry to say that we won't be cooperating, Mr. Hawker.""** | `[399]` **Lucian Galade**: ""Sir, I advise against it.""<br>`[404]` **Narrator**: "Lucian looked at me to hear my r..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Orso Hawker**: ""Even though you are aware of ou..." |
| `[407]` | **""Regardless of our situation, I'll be proceeding with the reforms.""** | `[399]` **Lucian Galade**: ""Sir, I advise against it.""<br>`[414]` **Heron Garaci**: ""And if you believe you can enac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Orso Hawker**: ""Even though you are aware of ou..." |
| `[411]` | **""I am not swayed by anyone, Mr. Hawker. This is my own decision.""** | `[410]` **Orso Hawker**: ""Why don't you explain your agen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Orso Hawker**: ""Say what you will. History will..." |
| `[412]` | **""You are the one trying to sway me into believing in conspiracies.""** | `[410]` **Orso Hawker**: ""Why don't you explain your agen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[413]` **Orso Hawker**: ""Say what you will. History will..." |
| `[415]` | **""Sorry to upset you, gentlemen.""** | `[414]` **Heron Garaci**: ""And if you believe you can enac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Orso Hawker**: ""Even though you are aware of ou..." |
| `[418]` | **""ENOUGH!""** | `[409]` **Heron Garaci**: ""You are making a big mistake, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Narrator**: "There was a long silence in the ..." |
| `[420]` | **""Let's hear your suggestions.""** | `[419]` **Orso Hawker**: ""Well, Mr. President. Do you wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Orso Hawker**: ""Of course. We cannot wait for t..." |
| `[421]` | **""No, Mr. Hawker. I think this meeting is over.""** | `[419]` **Orso Hawker**: ""Well, Mr. President. Do you wan..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[488]` **Orso Hawker**: ""I see."" |
| `[423]` | **""You are the ones who are making the mistake.""** | `[409]` **Heron Garaci**: ""You are making a big mistake, M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[426]` **Orso Hawker**: ""We will see, Mr. President. We ..." |
| `[424]` | **""Gentlemen, I think it's about time to end this meeting.""** | `[409]` **Heron Garaci**: ""You are making a big mistake, M..."<br>`[429]` **Orso Hawker**: ""Glad to hear that we're on the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Orso Hawker**: ""Well, thank you for having us, ..." |
| `[430]` | **""Fair enough. Will you leave us, gentlemen?""** | `[429]` **Orso Hawker**: ""Glad to hear that we're on the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Narrator**: "Lucian stood up as Orso gave him..." |
| `[431]` | **""Lucian?""** | `[429]` **Orso Hawker**: ""Glad to hear that we're on the ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[432]` **Lucian Galade**: ""You know exactly what I think. ..." |
| `[438]` | **""Tell me more about the legal details of an emergency act.""** | `[437]` **Orso Hawker**: ""You must eliminate these threat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Orso Hawker**: ""According to Article 58, if pub..." |
| `[439]` | **""How can we fight against these threats with an emergency act?""** | `[437]` **Orso Hawker**: ""You must eliminate these threat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[459]` **Orso Hawker**: ""You have the power to give more..." |
| `[442]` | **""Which parts of the Constitution can we modify or suspend?""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true) == false` | *Brak zmian stanu* | `[445]` **Orso Hawker**: ""That is kind of a grey area. Th..." |
| `[443]` | **""How can we effectively silence the opposition?""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false` | *Brak zmian stanu* | `[460]` **Orso Hawker**: ""We may need increased surveilla..." |
| `[444]` | **""Can't the Assembly simply revoke it?""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true) == false` | *Brak zmian stanu* | `[469]` **Orso Hawker**: ""According to the Constitution, ..." |
| `[446]` | **""I agree. Sordland is in a crisis.""** | `[437]` **Orso Hawker**: ""You must eliminate these threat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[447]` **Orso Hawker**: ""Yes, this is very serious."" |
| `[449]` | **""If we want to give the police more authority, we might need to modify the rights ..."** | `[448]` **Orso Hawker**: ""...no State shall, in the case ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[451]` **Orso Hawker**: ""That is correct. Current securi..." |
| `[450]` | **""Such imminent danger... That can definitely be argued to be the case.""** | `[448]` **Orso Hawker**: ""...no State shall, in the case ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[456]` **Orso Hawker**: ""Exactly."" |
| `[452]` | **""But we are not under invasion.""** | `[448]` **Orso Hawker**: ""...no State shall, in the case ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[455]` **Orso Hawker**: ""That is correct."" |
| `[461]` | **""What if the investigations cannot find anything incriminating?""** | `[460]` **Orso Hawker**: ""We may need increased surveilla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[466]` **Orso Hawker**: ""The information that I gave you..." |
| `[462]` | **""He needs to be eliminated.""** | `[460]` **Orso Hawker**: ""We may need increased surveilla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[468]` **Orso Hawker**: ""I agree. In an emergency, anyth..." |
| `[463]` | **""That might be going a bit too far.""** | `[460]` **Orso Hawker**: ""We may need increased surveilla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[464]` **Orso Hawker**: ""I disagree. You already know ab..." |
| `[481]` | **""Let's talk about the details of this emergency act.""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true` | *Brak zmian stanu* | `[482]` **Orso Hawker**: ""You must first justify the emer..." |
| `[483]` | **""Young Sords executed an attack near the Palace. They must pay for it.""** | `[502]` **Orso Hawker**: ""You can also justify an action ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Orso Hawker**: ""They are an enemy of the state...." |
| `[484]` | **""Red Youth must be targeted before they get too powerful to trigger a revolution.""** | `[502]` **Orso Hawker**: ""You can also justify an action ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Orso Hawker**: ""They are an enemy of the state...." |
| `[487]` | **""Gentlemen, let's get back to the topic.""** | `[410]` **Orso Hawker**: ""Why don't you explain your agen..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[419]` **Orso Hawker**: ""Well, Mr. President. Do you wan..." |
| `[489]` | **""I think this meeting is over.""** | `[414]` **Heron Garaci**: ""And if you believe you can enac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Orso Hawker**: ""Even though you are aware of ou..." |
| `[499]` | **""Okay. Where do we begin?""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true` | *Brak zmian stanu* | `[482]` **Orso Hawker**: ""You must first justify the emer..." |
| `[503]` | **""These Blud separatists have no place in Sordland. They will not be tolerated.""** | `[500]` **Orso Hawker**: ""There are obvious connections b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Orso Hawker**: ""Red Youth must also be our targ..." |
| `[504]` | **""They will be our targets.""** | `[500]` **Orso Hawker**: ""There are obvious connections b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Orso Hawker**: ""Red Youth must also be our targ..." |
| `[505]` | **""I don't want to create problems with our Bludish citizens.""** | `[500]` **Orso Hawker**: ""There are obvious connections b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[507]` **Orso Hawker**: ""But they are already creating p..." |
| `[506]` | **""There is not enough evidence to connect the separatists with the Worker's party.""** | `[500]` **Orso Hawker**: ""There are obvious connections b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Orso Hawker**: ""Come on, Mr. President. We all ..." |
| `[510]` | **""Both organizations must be declared as national threats.""** | `[502]` **Orso Hawker**: ""You can also justify an action ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[513]` **Orso Hawker**: ""They are both enemies of the st..." |
| `[511]` | **""I need to think about this.""** | `[502]` **Orso Hawker**: ""You can also justify an action ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[514]` **Orso Hawker**: ""I don't think there is much to ..." |
| `[516]` | **""Sorry to interrupt, Mr. Hawker, but I won't be going ahead with this.""** | `[441]` **Orso Hawker**: ""...the President of Sordland ma..."<br>`[465]` **Orso Hawker**: ""I suspect Frens Ricter is invol..."<br>*(oraz 3 innych węzłów)* | `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true` | *Brak zmian stanu* | `[517]` **Orso Hawker**: ""I thought you wanted to plan ou..." |
| `[518]` | **""I just wanted to hear your plan. And now I've heard it.""** | `[517]` **Orso Hawker**: ""I thought you wanted to plan ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[521]` **Orso Hawker**: ""What is the meaning of this?"" |
| `[519]` | **""I cannot do this, Mr. Hawker.""** | `[517]` **Orso Hawker**: ""I thought you wanted to plan ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[522]` **Orso Hawker**: ""You will instead push on with y..." |
| `[520]` | **""I thought I wanted to. Instead I will be proceeding with the reforms.""** | `[517]` **Orso Hawker**: ""I thought you wanted to plan ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[523]` **Orso Hawker**: ""Is this all a joke to you?"" |
| `[528]` | **"Nod."** | `[526]` **Orso Hawker**: ""We should give more authority t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Orso Hawker**: ""The police will also need permi..." |
| `[529]` | **""We should suspend the right to protest and disperse the crowds.""** | `[526]` **Orso Hawker**: ""We should give more authority t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Orso Hawker**: ""The police will also need permi..." |
| `[530]` | **""The police should stop and frisk based on suspicion.""** | `[526]` **Orso Hawker**: ""We should give more authority t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[527]` **Orso Hawker**: ""The police will also need permi..." |
| `[532]` | **""I agree.""** | `[531]` **Orso Hawker**: ""They will also need to be able ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Orso Hawker**: ""There are also the external thr..." |
| `[533]` | **"Nod."** | `[531]` **Orso Hawker**: ""They will also need to be able ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[536]` **Orso Hawker**: ""There are also the external thr..." |
| `[534]` | **""I think detention without trial is too much.""** | `[531]` **Orso Hawker**: ""They will also need to be able ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[535]` **Orso Hawker**: ""We are fighting against nationa..." |
| `[540]` | **""Rumburg is our biggest enemy, we must react.""** | `[539]` **Orso Hawker**: ""We must erase all of their infl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[543]` **Orso Hawker**: ""And of course, we need to prepa..." |
| `[541]` | **""We shouldn't escalate the situation with Rumburg too fast.""** | `[539]` **Orso Hawker**: ""We must erase all of their infl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[542]` **Orso Hawker**: ""They are the ones who are spitt..." |
| `[546]` | **""We can't go against the superpowers.""** | `[545]` **Orso Hawker**: ""And United Contana is funding S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[548]` **Orso Hawker**: ""I know it is a serious issue. B..." |
| `[547]` | **""We will not bow to them, Mr. Hawker.""** | `[545]` **Orso Hawker**: ""And United Contana is funding S..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[549]` **Orso Hawker**: ""I know we won't. They tried to ..." |
| `[550]` | **""I salute Colonel Soll for that.""** | `[549]` **Orso Hawker**: ""I know we won't. They tried to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[556]` **Orso Hawker**: ""May God preserve his soul."" |
| `[551]` | **""We will come out of this stronger again.""** | `[549]` **Orso Hawker**: ""I know we won't. They tried to ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[557]` **Orso Hawker**: ""I do hope so, Mr. President. It..." |
| `[552]` | **""I agree, but we cannot afford to sever all of our ties with them.""** | `[548]` **Orso Hawker**: ""I know it is a serious issue. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[555]` **Orso Hawker**: ""You should think about it furth..." |
| `[553]` | **""We might need one of their support against the other.""** | `[548]` **Orso Hawker**: ""I know it is a serious issue. B..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[554]` **Orso Hawker**: ""Getting their support means bec..." |
| `[561]` | **""I will stop the reforms shortly. [Proceed with the deal]""** | `[560]` **Orso Hawker**: ""I will be reaching out again af..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn02_Reform_AcceptedO...`<br>`Variable["BaseGame.Policy_Law_ReformCommittee"] = false; ...` | `[576]` **Orso Hawker**: ""That's great to hear."" |
| `[562]` | **""I cannot promise you that, Mr. Hawker. We do not have a deal. [Proceed with refor..."** | `[560]` **Orso Hawker**: ""I will be reaching out again af..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGameSupport.Journal_Turn02_Reform_RefusedOr...` | `[563]` **Orso Hawker**: ""Was this all a joke to you?"" |
| `[564]` | **""No, Mr. Hawker. I just wanted to learn about your intentions.""** | `[563]` **Orso Hawker**: ""Was this all a joke to you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Narrator**: "He looked at me with anger." |
| `[565]` | **""I'm sorry, Mr. Hawker. But I won't be doing this.""** | `[563]` **Orso Hawker**: ""Was this all a joke to you?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[567]` **Narrator**: "He looked at me with anger." |
| `[571]` | **""Goodbye, Mr. Hawker.""** | `[570]` **Narrator**: "He quickly got off the couch and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[574]` **Orso Hawker**: ""Have a good evening."" |
| `[572]` | **""Don't walk out on me, Mr. Hawker.""** | `[570]` **Narrator**: "He quickly got off the couch and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[573]` **Orso Hawker**: ""You already did that, Mr. Presi..." |
| `[581]` | **""Good evening, Mr. Hawker.""** | `[579]` **Orso Hawker**: ""Have a good evening, Mr. Rayne."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "He left the room." |
| `[582]` | **""Likewise.""** | `[579]` **Orso Hawker**: ""Have a good evening, Mr. Rayne."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[575]` **Narrator**: "He left the room." |
| `[590]` | **""Take care, gentlemen.""** | `[589]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Narrator**: "They both left the room." |
| `[591]` | **""I expect your support for the reforms. Don't make a mistake.""** | `[589]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[594]` **Narrator**: "Orso laughed sarcastically." |
| `[592]` | **""Goodbye Chief Justice.""** | `[589]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[595]` **Narrator**: "They both left the room." |
| `[602]` | **""Goodbye Chief Justice.""** | `[603]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[599]` **Narrator**: "They both left the room without ..." |
| `[605]` | **""Take care, gentlemen.""** | `[603]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[599]` **Narrator**: "They both left the room without ..." |
| `[607]` | **""I expect your support for the reforms. Don't make a mistake.""** | `[603]` **Orso Hawker**: ""Please excuse us, Mr. President..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[601]` **Narrator**: "Orso laughed sarcastically." |
| `[612]` | **""We need to take care of them.""** | `[611]` **Lucian Galade**: ""That was not good. They clearly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucian Galade**: ""Orso will be doing whatever it ..." |
| `[613]` | **""We have to make sure our reforms will pass the Court.""** | `[611]` **Lucian Galade**: ""That was not good. They clearly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucian Galade**: ""Orso will be doing whatever it ..." |
| `[614]` | **""How dare they talk to me like that?""** | `[611]` **Lucian Galade**: ""That was not good. They clearly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucian Galade**: ""Orso will be doing whatever it ..." |
| `[616]` | **""I'm not scared of them.""** | `[611]` **Lucian Galade**: ""That was not good. They clearly..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[615]` **Lucian Galade**: ""Orso will be doing whatever it ..." |
| `[621]` | **""There is no conspiracy but yours, Mr. Hawker.""** | `[522]` **Orso Hawker**: ""You will instead push on with y..."<br>`[524]` **Orso Hawker**: ""It seems you are also part of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Orso Hawker**: ""Good God..."" |
| `[622]` | **""I think we should end the meeting before we offend each other.""** | `[522]` **Orso Hawker**: ""You will instead push on with y..."<br>`[524]` **Orso Hawker**: ""It seems you are also part of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Orso Hawker**: ""Good God..."" |
| `[623]` | **""I need to push the reforms, Mr. Hawker, and I will.""** | `[522]` **Orso Hawker**: ""You will instead push on with y..."<br>`[524]` **Orso Hawker**: ""It seems you are also part of t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[624]` **Orso Hawker**: ""Good God..."" |
| `[644]` | **""Yes, thank you, Lucian. You can go.""** | `[433]` **Orso Hawker**: ""Then please do so, Mr. Galade."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Narrator**: "Lucian stood up as Orso gave him..." |
| `[645]` | **""Lucian isn't going anywhere. This meeting is over.""** | `[433]` **Orso Hawker**: ""Then please do so, Mr. Galade."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[416]` **Narrator**: "There was a long silence in the ..." |

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
  - -> `[6]` (*Narrator: "The administration had been working day and night on the ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: "“I knew they would come. We all want the same thing.”"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: "“Regardless of what they say, I will continue with the ne..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "The administration had been working day and night on the overwhelming amount of issues that were facing the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "The various government departments were sending me an ava..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "After I'd signed dozens of them, I closed my eyes to relax for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Another long day..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Another long day..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "On top of all that, I'd finally managed to set up a meeting with the Old Guards to talk about a path of no reforms and cooperation. It was in thirty minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "I was either going to cooperate with them, or would have ..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_SetUpMeeting == true)"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "On top of all that, I'd finally managed to set up a meeti..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_SetUpMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Even though I couldn't wait to leave the Palace for the d..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Even though I couldn't wait to leave the Palace for the day, Lucian had earlier told me that the Chief Justice wanted to speak to me. We were to meet in my office in thirty minutes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "I waited for him, wondering what he wanted to talk about."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "Pour whiskey."]** — Mówca: **Player_Italic**
> "I poured some whiskey for myself and took a sip."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Confront_Whiskey = true"*)

### Węzeł `[15]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Confront_Whiskey = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "It eased my mind a little."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Thousands of shimmering lights in the Holsord skyline were mesmerising."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Suddenly, I heard a knock on the door."*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "Take a moment to relax."]** — Mówca: **Player_Italic**
> "I stretched out my arms and looked out the window."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Narrator), `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Thousands of shimmering lights in the Holsord skyline wer..."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "It eased my mind a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Suddenly, I heard a knock on the door."*)

### Węzeł `[19]`
Mówca: **Narrator**
> "I was either going to cooperate with them, or would have no choice but to work with the reformists on the new Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Italic: "Pour whiskey."*)
  - -> `[17]` (*Player_Italic: "Take a moment to relax."*)

### Węzeł `[20]`
Mówca: **Narrator**
> "I waited for him, wondering what he wanted to talk about."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player_Italic: "Pour whiskey."*)
  - -> `[17]` (*Player_Italic: "Take a moment to relax."*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_SetUpMeeting == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""Soon, Mr. Hawker will be coming to the meeting with Mr. ..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_SetUpMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""I'm sorry that I couldn't explain the situation to you i..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> "Good evening, sir."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Player: "“Good evening, Lucian.”"*)
  - -> `[32]` (*Player: "“Good to see you.”"*)
  - -> `[33]` (*Player: "“Have a seat.”"*)
  - -> `[71]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Confront_Whiskey == true"*)

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""The Chief Justice insisted on seeing you this evening. I do not know what he has to say but it will probably be about the new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Lucian Galade: ""He will be coming shortly with Judge Garaci to the meeti..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Suddenly, I heard a knock on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "It was Lucian."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: "Good evening, sir."*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""Soon, Mr. Hawker will be coming to the meeting with Mr. Garaci.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""Before they come, we should talk about our strategy, sir.""*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Before they come, we should talk about our strategy, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: "“What are you suggesting?""*)
  - -> `[53]` (*Player: "“There is nothing to talk about. Let's see what they have..."*)
  - -> `[55]` (*Player: "“I aim to get a deal out of this meeting.""*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""I'm sorry that I couldn't explain the situation to you in detail earlier, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Lucian Galade: ""The Chief Justice insisted on seeing you this evening. I..."*)

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Good evening, Lucian.”"]** — Mówca: **Player**
> "“Good evening, Lucian.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Good to see you.”"]** — Mówca: **Player**
> "“Good to see you.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Lucian Galade: ""Good to see you too, sir.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Have a seat.”"]** — Mówca: **Player**
> "“Have a seat.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "He sat on a chair near my desk."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "He sat on a chair near my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""Good to see you too, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[36]`
Mówca: **Lucian Galade**
> ""He will be coming shortly with Judge Garaci to the meeting. We shouldn't take them lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“I think he's here to test the waters.""*)
  - -> `[37]` (*Player: "“They are here to threaten us to stop the reforms.”"*)
  - -> `[39]` (*Player: "“We may be able to cooperate with them.”"*)
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“They are here to threaten us to stop the reforms.”"]** — Mówca: **Player**
> "“They are here to threaten us to stop the reforms.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""We knew they would react at some point.""*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I think he's here to test the waters.""]** — Mówca: **Player**
> "“I think he's here to test the waters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: ""I agree. They will probably try to get you to their side.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: "“We may be able to cooperate with them.”"]** — Mówca: **Player**
> "“We may be able to cooperate with them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Lucian Galade: ""I advise against that, sir. I do not trust the Chief Jus..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: "“Regardless of what they say, I will continue with the new Constitution.”"]** — Mówca: **Player**
> "“Regardless of what they say, I will continue with the new Constitution.”"
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Lucian Galade: ""Of course. Let's stand our ground and not let them antag..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: "“I knew they would come. We all want the same thing.”"]** — Mówca: **Player**
> "“I knew they would come. We all want the same thing.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[36]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lucian Galade: ""I'm sure they have heard about your intentions regarding..."*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""I agree. They will probably try to get you to their side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""We knew they would react at some point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[44]`
Mówca: **Lucian Galade**
> ""I advise against that, sir. I do not trust the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[45]`
Mówca: **Lucian Galade**
> ""Of course. Let's stand our ground and not let them antagonize us, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[46]`
Mówca: **Lucian Galade**
> ""I'm sure they have heard about your intentions regarding the reforms. They must be coming here to make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> ""We should-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "There were three knocks at the door."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Livia opened the doors. Chief Justice Orso Hawker and Judge Heron Garaci entered the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Orso Hawker: ""Good evening, Mr. President. It's great to see you.""*)

### Węzeł `[49]`
Mówca: **Narrator**
> "There were three knocks at the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "Lucian checked his watch. He looked rather worried."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "Lucian checked his watch. He looked rather worried."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Livia opened the doors. Chief Justice Orso Hawker and Jud..."*)

### Węzeł `[51]`
Mówca: **Orso Hawker**
> ""Good evening, Mr. President. It's great to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Heron Garaci: ""Evening.""*)

### Węzeł `[52]`
Mówca: **Heron Garaci**
> ""Evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Player: "“Welcome, Justice Garaci and Chief Justice Hawker.""*)
  - -> `[77]` (*Player: "“Good to see you, gentlemen.""*)

### Węzeł `[53]`
**[WYBÓR GRACZA: "“There is nothing to talk about. Let's see what they have to say.""]** — Mówca: **Player**
> "“There is nothing to talk about. Let's see what they have to say.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""We should be careful when dealing with the Old Guard, sir.""*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "“What are you suggesting?""]** — Mówca: **Player**
> "“What are you suggesting?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: ""We should be careful when dealing with the Old Guard, sir.""*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“I aim to get a deal out of this meeting.""]** — Mówca: **Player**
> "“I aim to get a deal out of this meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lucian Galade: ""We should be careful when dealing with the Old Guard, sir.""*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> ""We should be careful when dealing with the Old Guard, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Lucian Galade: ""We should try not to antagonize them. In case we don't c..."*)

### Węzeł `[57]`
Mówca: **Lucian Galade**
> ""We should try not to antagonize them. In case we don't collaborate with them, we'll need their support in the Court's vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""And... I know I told you this before, sir. But I wouldn'..."*)

### Węzeł `[58]`
Mówca: **Lucian Galade**
> ""And... I know I told you this before, sir. But I wouldn't trust the Chief Justice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Player: "“I don't trust him either.""*)
  - -> `[61]` (*Player: "“Duly noted, Lucian. I'll see about that myself.""*)
  - -> `[62]` (*Player: "“I've heard this enough, Lucian. I told you my intentions.""*)

### Węzeł `[59]`
Mówca: **Lucian Galade**
> ""We should be careful when dealing with the Old Guard, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Lucian Galade: ""And... I know I told you this before, sir. But I wouldn'..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I don't trust him either.""]** — Mówca: **Player**
> "“I don't trust him either.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""Glad we're on the same page, sir.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: "“Duly noted, Lucian. I'll see about that myself.""]** — Mówca: **Player**
> "“Duly noted, Lucian. I'll see about that myself.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“I've heard this enough, Lucian. I told you my intentions.""]** — Mówca: **Player**
> "“I've heard this enough, Lucian. I told you my intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Glad we're on the same page, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: ""We should-""*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_SetUpMeeting == true)"*)

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Orso Hawker: "“You invited us here this evening to talk about a possibl..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_SetUpMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Orso Hawker: "“So...""*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[70]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Orso Hawker: ""You know why we are here.""*)

### Węzeł `[70]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Orso Hawker: ""You probably know why we are here.""*)

### Węzeł `[71]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Confront_Whiskey == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Confront_Whiskey == true"*)
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Confront_Whiskey == true)"*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Confront_Whiskey == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Italic: "Raise your drink."*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Confront_Whiskey == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
**[WYBÓR GRACZA: "Raise your drink."]** — Mówca: **Player_Italic**
> "I raised the glass of whiskey and gestured at Lucian."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true`
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "He sat on a chair near my desk."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "He sat on a chair near my desk."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lucian Galade: ""No thank you, sir. But good to see you enjoying yourself.""*)

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""No thank you, sir. But good to see you enjoying yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Good to see you, gentlemen.""]** — Mówca: **Player**
> "“Good to see you, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""Good to see you, indeed.""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“Welcome, Justice Garaci and Chief Justice Hawker.""]** — Mówca: **Player**
> "“Welcome, Justice Garaci and Chief Justice Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""Good to see you, indeed.""*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""Good to see you, indeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Orso gestured at the sofa in the office."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Orso gestured at the sofa in the office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Orso Hawker: "“May I?""*)

### Węzeł `[81]`
Mówca: **Orso Hawker**
> "“May I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Player: "“Please.""*)
  - -> `[82]` (*Player_Italic: "Nod."*)
  - -> `[84]` (*Player: ""Let's have a seat, gentlemen.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "We all took our seats on two opposite sofas and made ours..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Please.""]** — Mówca: **Player**
> "“Please.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "We all took our seats on two opposite sofas and made ours..."*)

### Węzeł `[84]`
**[WYBÓR GRACZA: ""Let's have a seat, gentlemen.""]** — Mówca: **Player**
> ""Let's have a seat, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "We all took our seats on two opposite sofas and made ours..."*)

### Węzeł `[85]`
Mówca: **Narrator**
> "He gave me a blank stare and readjusted himself on the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Orso Hawker: "“Hm...""*)

### Węzeł `[86]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Confront_Whiskey == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Confront_Whiskey == true"*)
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Confront_Whiskey == true)"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Confront_Whiskey == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Narrator: "Orso glanced at the glass of whiskey."*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Confront_Whiskey == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Confront_Whiskey"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Heron Garaci: ""How were your first couple of months, Mr. President? I h..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "We all took our seats on two opposite sofas and made ourselves comfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Confront_Whiskey == true"*)

### Węzeł `[90]`
Mówca: **Narrator**
> "Orso glanced at the glass of whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Orso Hawker: "“Celebrating something, Mr. President?""*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Forgive me, would you also like to have a drink?""]** — Mówca: **Player**
> "“Forgive me, would you also like to have a drink?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Orso Hawker: ""No, thank you.""*)

### Węzeł `[92]`
Mówca: **Orso Hawker**
> "“Celebrating something, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“Forgive me, would you also like to have a drink?""*)
  - -> `[95]` (*Player: "“I was just trying to relax.""*)
  - -> `[96]` (*Player: ""I don't think that's relevant to our meeting, Mr. Hawker.""*)
  - -> `[97]` (*Player: ""Can we get to the point, Mr. Hawker?""*)

### Węzeł `[93]`
Mówca: **Heron Garaci**
> ""How were your first couple of months, Mr. President? I hope you're faring well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: ""Thank you, it's very busy but I'm doing good.""*)
  - -> `[106]` (*Player: ""To be honest, it was a rough start.""*)
  - -> `[107]` (*Player: ""I'm doing well. No need to worry, Mr. Garaci.""*)
  - -> `[108]` (*Player: ""No need for pleasantries. Let's just get to the point.""*)

### Węzeł `[94]`
Mówca: **Orso Hawker**
> ""No, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Heron Garaci: ""Me neither, thank you.""*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I was just trying to relax.""]** — Mówca: **Player**
> "“I was just trying to relax.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Orso Hawker: "“A man needs his drink, I understand.""*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""I don't think that's relevant to our meeting, Mr. Hawker.""]** — Mówca: **Player**
> ""I don't think that's relevant to our meeting, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He gave me a blank stare and readjusted himself on the sofa."*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Can we get to the point, Mr. Hawker?""]** — Mówca: **Player**
> ""Can we get to the point, Mr. Hawker?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[92]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Narrator: "He gave me a blank stare and readjusted himself on the sofa."*)

### Węzeł `[98]`
Mówca: **Orso Hawker**
> "“I'd like to stay as conscious and focused as I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Heron Garaci: ""How were your first couple of months, Mr. President? I h..."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "He cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[100]`
Mówca: **Orso Hawker**
> "“A man needs his drink, I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Heron Garaci: ""How were your first couple of months, Mr. President? I h..."*)

### Węzeł `[101]`
Mówca: **Orso Hawker**
> "“Forgive me. Mr. *President.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "He cleared his throat."*)

### Węzeł `[102]`
Mówca: **Orso Hawker**
> "“Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Orso Hawker: "“Forgive me. Mr. *President.*""*)

### Węzeł `[103]`
Mówca: **Heron Garaci**
> ""Me neither, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Orso Hawker: "“I'd like to stay as conscious and focused as I can.""*)

### Węzeł `[104]`
Mówca: **Narrator**
> "The various government departments were sending me an avalanche of documents, all of which required my signature so they could start working on the new plans that had been decided on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "After I'd signed dozens of them, I closed my eyes to rela..."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Thank you, it's very busy but I'm doing good.""]** — Mówca: **Player**
> ""Thank you, it's very busy but I'm doing good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Heron Garaci: ""It will only get busier. Yet, I think you're doing a goo..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""To be honest, it was a rough start.""]** — Mówca: **Player**
> ""To be honest, it was a rough start.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Heron Garaci: ""I couldn't imagine. Yet, I think you're doing a good job..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I'm doing well. No need to worry, Mr. Garaci.""]** — Mówca: **Player**
> ""I'm doing well. No need to worry, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Heron Garaci: ""That's great to hear, Mr. President. We also think you'v..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""No need for pleasantries. Let's just get to the point.""]** — Mówca: **Player**
> ""No need for pleasantries. Let's just get to the point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "They both gave me blank stares. Orso readjusted himself o..."*)

### Węzeł `[109]`
Mówca: **Orso Hawker**
> "“Hm...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Orso Hawker: "“Forgive us. Mr. *President.*""*)

### Węzeł `[110]`
Mówca: **Orso Hawker**
> "“Forgive us. Mr. *President.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "He cleared his throat."*)

### Węzeł `[111]`
Mówca: **Narrator**
> "They both gave me blank stares. Orso readjusted himself on the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Orso Hawker: "“Hm...""*)

### Węzeł `[112]`
Mówca: **Heron Garaci**
> ""That's great to hear, Mr. President. We also think you've been doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Heron Garaci: ""Considering all that's happening around us. With the sho..."*)

### Węzeł `[113]`
Mówca: **Heron Garaci**
> ""I couldn't imagine. Yet, I think you're doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Heron Garaci: ""Considering all that's happening around us. With the sho..."*)

### Węzeł `[114]`
Mówca: **Heron Garaci**
> ""Considering all that's happening around us. With the shootings near the Palace and soldiers on our borders...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "He let out a deep sigh."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "He let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Heron Garaci: ""It is a troubling time.""*)

### Węzeł `[116]`
Mówca: **Heron Garaci**
> ""It is a troubling time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: ""We appreciate your concerns.""*)

### Węzeł `[117]`
Mówca: **Heron Garaci**
> ""It will only get busier. Yet, I think you're doing a good job so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Heron Garaci: ""Considering all that's happening around us. With the sho..."*)

### Węzeł `[118]`
Mówca: **Orso Hawker**
> "“You invited us here this evening to talk about a possible cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Orso Hawker: "“So, let us hear it from you. What do you have in mind, M..."*)

### Węzeł `[119]`
Mówca: **Orso Hawker**
> "“So, let us hear it from you. What do you have in mind, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: ""I offer cooperation against the reformists.""*)
  - -> `[132]` (*Player: ""I want to protect the current Constitution.""*)
  - -> `[135]` (*Player: ""We need to stay united in times of possible conflict.""*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""We appreciate your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting == true"*)

### Węzeł `[121]`
Mówca: **Orso Hawker**
> "“So...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[122]`
Mówca: **Orso Hawker**
> ""You probably know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: ""I don't.""*)
  - -> `[129]` (*Player: ""Please enlighten us, Mr. Hawker.""*)
  - -> `[130]` (*Player: ""You're here to bribe me.""*)
  - -> `[131]` (*Player: ""You're here to stop the new Constitution.""*)

### Węzeł `[123]`
Mówca: **Orso Hawker**
> ""You know why we are here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Orso Hawker: ""We've heard that you're not giving full support to the r..."*)

### Węzeł `[124]`
Mówca: **Orso Hawker**
> ""We've heard that you're not giving full support to the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Player: ""That's correct.""*)
  - -> `[126]` (*Player: ""You must have heard wrong, Mr. Hawker.""*)
  - -> `[127]` (*Player: ""Where did you hear that?""*)
  - -> `[133]` (*Player: ""I want to protect our Constitution.""*)

### Węzeł `[125]`
**[WYBÓR GRACZA: ""That's correct.""]** — Mówca: **Player**
> ""That's correct.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Orso Hawker: ""That's relieving to hear.""*)

### Węzeł `[126]`
**[WYBÓR GRACZA: ""You must have heard wrong, Mr. Hawker.""]** — Mówca: **Player**
> ""You must have heard wrong, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Orso Hawker: ""That is quite possible.""*)

### Węzeł `[127]`
**[WYBÓR GRACZA: ""Where did you hear that?""]** — Mówca: **Player**
> ""Where did you hear that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Orso Hawker: ""The question is not where I heard that, but if it's true..."*)

### Węzeł `[128]`
**[WYBÓR GRACZA: ""I don't.""]** — Mówca: **Player**
> ""I don't.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Orso Hawker: ""We know you are working on a new Constitution.""*)

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Please enlighten us, Mr. Hawker.""]** — Mówca: **Player**
> ""Please enlighten us, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Orso Hawker: ""We know you are working on a new Constitution.""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: ""You're here to bribe me.""]** — Mówca: **Player**
> ""You're here to bribe me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Heron Garaci laughed."*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""You're here to stop the new Constitution.""]** — Mówca: **Player**
> ""You're here to stop the new Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Orso Hawker: ""We are only here to tell you that the Supreme Court does..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I want to protect the current Constitution.""]** — Mówca: **Player**
> ""I want to protect the current Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Orso Hawker: ""Looks like we are on the same page.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""I want to protect our Constitution.""]** — Mówca: **Player**
> ""I want to protect our Constitution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Orso Hawker: ""Looks like we are on the same page.""*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""I offer cooperation against the reformists.""]** — Mówca: **Player**
> ""I offer cooperation against the reformists.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Orso Hawker: ""That's relieving to hear. Sordland has plunged into chao..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: ""We need to stay united in times of possible conflict.""]** — Mówca: **Player**
> ""We need to stay united in times of possible conflict.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[119]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Orso Hawker: ""I agree. Sordland is in a dire situation right now. We n..."*)

### Węzeł `[136]`
Mówca: **Orso Hawker**
> ""That's relieving to hear. Sordland has plunged into chaos because of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""We would be honored to work together.""*)

### Węzeł `[137]`
Mówca: **Orso Hawker**
> ""Looks like we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""We would be honored to work together.""*)

### Węzeł `[138]`
Mówca: **Orso Hawker**
> ""I agree. Sordland is in a dire situation right now. We need to stay focused on our real problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""We would be honored to work together.""*)

### Węzeł `[139]`
Mówca: **Orso Hawker**
> ""That's relieving to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""We would be honored to work together.""*)

### Węzeł `[140]`
Mówca: **Orso Hawker**
> ""Looks like we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Orso Hawker: ""We would be honored to work together.""*)

### Węzeł `[141]`
Mówca: **Orso Hawker**
> ""The question is not where I heard that, but if it's true or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player: ""Yes, I don't support the reforms.""*)
  - -> `[149]` (*Player: ""It's neither true or false, I'm weighing my options first.""*)

### Węzeł `[142]`
Mówca: **Orso Hawker**
> ""That is quite possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Orso Hawker: ""So, you are going to push to change the Constitution, af..."*)

### Węzeł `[143]`
Mówca: **Orso Hawker**
> ""So, you are going to push to change the Constitution, after all?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: ""No, I'd rather work with you, if that's a possibility.""*)
  - -> `[145]` (*Player: ""I am weighing my options first.""*)

### Węzeł `[144]`
Mówca: **Orso Hawker**
> ""We would be honored to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Orso Hawker: ""Having said that, there are some things you need to be a..."*)

### Węzeł `[145]`
**[WYBÓR GRACZA: ""I am weighing my options first.""]** — Mówca: **Player**
> ""I am weighing my options first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Orso Hawker: ""That's quite understandable.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: ""No, I'd rather work with you, if that's a possibility.""]** — Mówca: **Player**
> ""No, I'd rather work with you, if that's a possibility.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Orso Hawker: ""Looks like we are on the same page.""*)

### Węzeł `[147]`
Mówca: **Orso Hawker**
> ""That's quite understandable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Orso Hawker: ""In any case, it would have been an honor to work together.""*)

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Yes, I don't support the reforms.""]** — Mówca: **Player**
> ""Yes, I don't support the reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Orso Hawker: ""That's relieving to hear.""*)

### Węzeł `[149]`
**[WYBÓR GRACZA: ""It's neither true or false, I'm weighing my options first.""]** — Mówca: **Player**
> ""It's neither true or false, I'm weighing my options first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[141]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Orso Hawker: ""That's quite understandable.""*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Heron Garaci laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Heron Garaci: ""I wish.""*)

### Węzeł `[151]`
Mówca: **Orso Hawker**
> ""We are only here to tell you that the Supreme Court does not approve of the attempt to change the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: ""With all due respect, the Constitution needs to be updat..."*)

### Węzeł `[152]`
Mówca: **Orso Hawker**
> ""We know you are working on a new Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Orso Hawker: ""The Supreme Court does not approve of this.""*)

### Węzeł `[153]`
Mówca: **Orso Hawker**
> ""The Supreme Court does not approve of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lucian Galade: ""With all due respect, the Constitution needs to be updat..."*)

### Węzeł `[154]`
Mówca: **Lucian Galade**
> ""With all due respect, the Constitution needs to be updated, sir. I am sure you are well aware of the public demand and our circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)

### Węzeł `[155]`
Mówca: **Heron Garaci**
> ""I wish.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Orso Hawker: ""We are only here to tell you that the Supreme Court does..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Intention == true )"*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Orso Hawker: ""Is that so? I see that you are the one who is not aware ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Intention == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Orso Hawker: ""And the public demanded to give more powers to the Presi..."*)

### Węzeł `[159]`
Mówca: **Orso Hawker**
> ""Is that so? I see that you are the one who is not aware of our actual circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Orso Hawker: ""You want to make a weaker Constitution in the midst of p..."*)

### Węzeł `[160]`
Mówca: **Orso Hawker**
> ""And the public demanded to give more powers to the President? Spare me the lecture, I know you have *different* ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Orso Hawker: ""Even if your proposal passes the Assembly, I will make s..."*)

### Węzeł `[161]`
Mówca: **Orso Hawker**
> ""Having said that, there are some things you need to be aware of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Heron Garaci: ""Yes, Mr. President. Our national values and sovereignty ..."*)

### Węzeł `[162]`
Mówca: **Heron Garaci**
> ""Yes, Mr. President. Our national values and sovereignty are under attack. We must be vigilant and aggressive against these reformists. It's clear that their reforms are a conspiracy of foreign powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""How so?""*)
  - -> `[165]` (*Player: ""That's a bit far-fetched, isn't it?""*)
  - -> `[164]` (*Player: ""I've read the security reports. I am suspecting somethin..."*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""How so?""]** — Mówca: **Player**
> ""How so?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Heron Garaci: ""Mr. President, if you are not aware of these plots, you ..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""I've read the security reports. I am suspecting something big too.""]** — Mówca: **Player**
> ""I've read the security reports. I am suspecting something big too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Heron Garaci: ""It's not only some *thing*, Mr. President. The superpowe..."*)

### Węzeł `[165]`
**[WYBÓR GRACZA: ""That's a bit far-fetched, isn't it?""]** — Mówca: **Player**
> ""That's a bit far-fetched, isn't it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Heron Garaci: ""Mr. President, if you are not aware of these plots, you ..."*)

### Węzeł `[166]`
Mówca: **Orso Hawker**
> ""In any case, it would have been an honor to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Orso Hawker: ""Having said that, there are some things you need to be a..."*)

### Węzeł `[167]`
Mówca: **Orso Hawker**
> ""Even if your proposal passes the Assembly, I will make sure it will not pass the Supreme Court. That much is clear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Player: ""You haven't even seen the proposal yet, Mr. Hawker. Isn'..."*)
  - -> `[170]` (*Player: ""So you came here to threaten us.""*)
  - -> `[171]` (*Player: ""Come on, Mr. Hawker. We can figure something out.""*)
  - -> `[173]` (*Player: ""We'll get the Court too, even if you do not cooperate.""*)

### Węzeł `[168]`
Mówca: **Orso Hawker**
> ""You want to make a weaker Constitution in the midst of problems from both inside and outside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Orso Hawker: ""Even if your proposal passes the Assembly, I will make s..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: ""You haven't even seen the proposal yet, Mr. Hawker. Isn't it too soon to be against it?""]** — Mówca: **Player**
> ""You haven't even seen the proposal yet, Mr. Hawker. Isn't it too soon to be against it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Orso Hawker: ""Do you think I live under a rock, Mr. President?""*)

### Węzeł `[170]`
**[WYBÓR GRACZA: ""So you came here to threaten us.""]** — Mówca: **Player**
> ""So you came here to threaten us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Orso Hawker: ""How was that a threat, Mr. President? I merely stated my..."*)

### Węzeł `[171]`
**[WYBÓR GRACZA: ""Come on, Mr. Hawker. We can figure something out.""]** — Mówca: **Player**
> ""Come on, Mr. Hawker. We can figure something out.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Orso Hawker: ""We can.""*)

### Węzeł `[172]`
Mówca: **Heron Garaci**
> ""Mr. President, if you are not aware of these plots, you should really reconsider your team of advisers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Lucian frowned."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""We'll get the Court too, even if you do not cooperate.""]** — Mówca: **Player**
> ""We'll get the Court too, even if you do not cooperate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Orso Hawker: ""Good luck with that.""*)

### Węzeł `[174]`
Mówca: **Orso Hawker**
> ""Do you think I live under a rock, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Orso Hawker: ""I know what goes on.""*)

### Węzeł `[175]`
Mówca: **Orso Hawker**
> ""I know what goes on.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Heron Garaci: ""Yet you, Mr. President, seem to be only partially inform..."*)

### Węzeł `[176]`
Mówca: **Orso Hawker**
> ""How was that a threat, Mr. President? I merely stated my position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Heron Garaci: ""There is no threat here, Mr. President.""*)

### Węzeł `[177]`
Mówca: **Heron Garaci**
> ""There is no threat here, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Heron Garaci: ""Mr. President, you seem to be only partially informed ab..."*)

### Węzeł `[178]`
Mówca: **Orso Hawker**
> ""We can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Orso Hawker: ""If you decide to give us a listen.""*)

### Węzeł `[179]`
Mówca: **Orso Hawker**
> ""If you decide to give us a listen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Heron Garaci: ""Mr. President, you seem to be only partially informed ab..."*)

### Węzeł `[180]`
Mówca: **Orso Hawker**
> ""Good luck with that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Orso Hawker: ""Justices of the Supreme Court cannot be bought.""*)

### Węzeł `[181]`
Mówca: **Orso Hawker**
> ""Justices of the Supreme Court cannot be bought.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "Lucian gave a mocking look."*)

### Węzeł `[182]`
Mówca: **Lucian Galade**
> ""I am sure they cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Heron Garaci: ""Mr. President, you seem to be only partially informed ab..."*)

### Węzeł `[183]`
Mówca: **Heron Garaci**
> ""Yet you, Mr. President, seem to be only partially informed about the current situation. Please let us explain the reasons of our stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""I believe I am fully informed about the situation, Mr. G..."*)
  - -> `[186]` (*Player: ""Oh? Please explain.""*)
  - -> `[187]` (*Player: ""Let's hear it.""*)
  - -> `[188]` (*Player: ""I don't care about your reasons.""*)

### Węzeł `[184]`
Mówca: **Heron Garaci**
> ""Mr. President, you seem to be only partially informed about the current situation. Please let us explain the reasons of our stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""I believe I am fully informed about the situation, Mr. G..."*)
  - -> `[186]` (*Player: ""Oh? Please explain.""*)
  - -> `[187]` (*Player: ""Let's hear it.""*)
  - -> `[188]` (*Player: ""I don't care about your reasons.""*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""I believe I am fully informed about the situation, Mr. Garaci.""]** — Mówca: **Player**
> ""I believe I am fully informed about the situation, Mr. Garaci.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Heron Garaci), `[184]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Heron Garaci: ""You think you are, Mr. President. But the Chief Justice ..."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""Oh? Please explain.""]** — Mówca: **Player**
> ""Oh? Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Heron Garaci), `[184]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Heron Garaci: ""We are protecting the Constitution, because it works, Mr..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""Let's hear it.""]** — Mówca: **Player**
> ""Let's hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Heron Garaci), `[184]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Heron Garaci: ""We are protecting the Constitution, because it works, Mr..."*)

### Węzeł `[188]`
**[WYBÓR GRACZA: ""I don't care about your reasons.""]** — Mówca: **Player**
> ""I don't care about your reasons.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[183]` (Heron Garaci), `[184]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Heron Garaci: ""That's exactly what they want you to say.""*)

### Węzeł `[189]`
Mówca: **Lucian Galade**
> ""With all due respect, how could a Justice have better security intel than the President of Sordland?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Orso Hawker: ""That is a good question. How? Maybe you should first see..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "Lucian frowned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Orso Hawker: ""Please let me explain. We have important information you..."*)

### Węzeł `[191]`
Mówca: **Heron Garaci**
> ""It's not only some *thing*, Mr. President. The superpowers are playing chess in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Orso Hawker: ""Please let me explain. We have important information you..."*)

### Węzeł `[192]`
Mówca: **Heron Garaci**
> ""Mr. President, if you are not aware of these plots, you should really reconsider your team of advisers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "Lucian frowned."*)

### Węzeł `[193]`
Mówca: **Orso Hawker**
> ""Please let me explain. We have important information you may not have heard yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Lucian Galade: ""With all due respect, how could a Justice have better se..."*)

### Węzeł `[194]`
Mówca: **Orso Hawker**
> ""That is a good question. How? Maybe you should first see if your security team is worth trusting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player: ""Please explain, Mr. Hawker.""*)
  - -> `[196]` (*Player: ""I trust my team, Mr. Hawker. You shouldn't concern yours..."*)
  - -> `[197]` (*Player: ""Let the Chief Justice talk, Lucian.""*)

### Węzeł `[195]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Orso Hawker: ""I have incriminating evidence against a very prominent p..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA: ""I trust my team, Mr. Hawker. You shouldn't concern yourself with these matters.""]** — Mówca: **Player**
> ""I trust my team, Mr. Hawker. You shouldn't concern yourself with these matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Orso Hawker: ""I did not want to offend you, Mr. President. But I meant..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA: ""Let the Chief Justice talk, Lucian.""]** — Mówca: **Player**
> ""Let the Chief Justice talk, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[194]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Orso Hawker: ""I have incriminating evidence against a very prominent p..."*)

### Węzeł `[198]`
Mówca: **Orso Hawker**
> ""I did not want to offend you, Mr. President. But I meant it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Orso Hawker: ""I have incriminating evidence against a very prominent p..."*)

### Węzeł `[199]`
Mówca: **Orso Hawker**
> ""I have incriminating evidence against a very prominent political personality.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Orso Hawker: ""But before I give you that... I've had a couple of quest..."*)

### Węzeł `[200]`
Mówca: **Orso Hawker**
> ""But before I give you that... I've had a couple of questions on my mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Orso Hawker: ""What do you think about the offensive posturing of Rumbu..."*)

### Węzeł `[201]`
Mówca: **Heron Garaci**
> ""Sordland has more important problems and threats that we should face right now instead of nitpicking about some paragraphs of the Constitution. We have a potential war within our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[202]`
Mówca: **Heron Garaci**
> ""We are protecting the Constitution, because it works, Mr. President. It is efficient and it gives you the authority to lead the nation with swift decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Heron Garaci: ""Sordland has more important problems and threats that we..."*)

### Węzeł `[203]`
Mówca: **Heron Garaci**
> ""That's exactly what they want you to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player: ""Who are 'they'?""*)
  - -> `[206]` (*Player: ""I am merely stating my feelings.""*)
  - -> `[207]` (*Player: ""What does that mean?""*)

### Węzeł `[204]`
Mówca: **Heron Garaci**
> ""You think you are, Mr. President. But the Chief Justice has some intel on something that you would be very interested in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Player: ""And what would that be?""*)
  - -> `[211]` (*Player: ""Go on.""*)
  - -> `[212]` (*Player: ""I am not interested in your games.""*)

### Węzeł `[205]`
**[WYBÓR GRACZA: ""Who are 'they'?""]** — Mówca: **Player**
> ""Who are 'they'?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[206]`
**[WYBÓR GRACZA: ""I am merely stating my feelings.""]** — Mówca: **Player**
> ""I am merely stating my feelings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: ""What does that mean?""]** — Mówca: **Player**
> ""What does that mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[208]`
Mówca: **Orso Hawker**
> ""Mr. President. I know that you are a busy man, so I will make this quick.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Orso Hawker: ""We all know that Sordish security forces found stashes o..."*)

### Węzeł `[209]`
Mówca: **Narrator**
> "Orso signalled Heron with his hand to let him speak instead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Orso Hawker: ""Mr. President. I know that you are a busy man, so I will..."*)

### Węzeł `[210]`
**[WYBÓR GRACZA: ""And what would that be?""]** — Mówca: **Player**
> ""And what would that be?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[211]`
**[WYBÓR GRACZA: ""Go on.""]** — Mówca: **Player**
> ""Go on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[212]`
**[WYBÓR GRACZA: ""I am not interested in your games.""]** — Mówca: **Player**
> ""I am not interested in your games.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Narrator: "Orso signalled Heron with his hand to let him speak instead."*)

### Węzeł `[213]`
Mówca: **Orso Hawker**
> ""What do you think about the offensive posturing of Rumburg and their KA-74's being found in the hands of the Blud separatists?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Player: ""I am very troubled by that. We need to be prepared again..."*)
  - -> `[215]` (*Player: ""Blud separatists must be dealt with before they gain the..."*)
  - -> `[216]` (*Player: ""The connection is not that strong, I don't think they ar..."*)
  - -> `[263]` (*Player: ""What does that have to do with anything?""*)

### Węzeł `[214]`
**[WYBÓR GRACZA: ""I am very troubled by that. We need to be prepared against Rumburg.""]** — Mówca: **Player**
> ""I am very troubled by that. We need to be prepared against Rumburg.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Orso Hawker: ""Is the administration doing something about that?""*)

### Węzeł `[215]`
**[WYBÓR GRACZA: ""Blud separatists must be dealt with before they gain the support of the Bluds.""]** — Mówca: **Player**
> ""Blud separatists must be dealt with before they gain the support of the Bluds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Orso Hawker: ""Is the administration doing something about that?""*)

### Węzeł `[216]`
**[WYBÓR GRACZA: ""The connection is not that strong, I don't think they are a real threat.""]** — Mówca: **Player**
> ""The connection is not that strong, I don't think they are a real threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Orso Hawker: ""We all know what the Bludish Freedom Front stands for. H..."*)

### Węzeł `[217]`
Mówca: **Orso Hawker**
> ""Is the administration doing something about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Player: ""We are not rushing with our actions just yet.""*)
  - -> `[223]` (*Player: ""Not as fast as I'd like to.""*)
  - -> `[221]` (*Player: ""My security team is working on that.""*)
  - -> `[264]` (*Player: ""With all due respect, that does not really concern you.""*)

### Węzeł `[218]`
Mówca: **Orso Hawker**
> ""We all know what the Bludish Freedom Front stands for. How come stashes of Rumburgian KA rifles do not trouble you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player: ""I don't think the organization is strong enough to creat..."*)
  - -> `[220]` (*Player: ""We haven't found thousands of it. That is not enough to ..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA: ""I don't think the organization is strong enough to create problems.""]** — Mówca: **Player**
> ""I don't think the organization is strong enough to create problems.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Orso Hawker: ""Have you even talked with your own generals? Or Mr. Lanc..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA: ""We haven't found thousands of it. That is not enough to establish a direct connection.""]** — Mówca: **Player**
> ""We haven't found thousands of it. That is not enough to establish a direct connection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Orso Hawker: ""Have you even talked with your own generals? Or Mr. Lanc..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA: ""My security team is working on that.""]** — Mówca: **Player**
> ""My security team is working on that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[222]`
**[WYBÓR GRACZA: ""We are not rushing with our actions just yet.""]** — Mówca: **Player**
> ""We are not rushing with our actions just yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Not as fast as I'd like to.""]** — Mówca: **Player**
> ""Not as fast as I'd like to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == false)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Orso Hawker: ""Clearly.""*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Orso Hawker: ""That's not good enough, Mr. President.""*)

### Węzeł `[227]`
Mówca: **Orso Hawker**
> ""Clearly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Orso Hawker: ""And you said you will not focus on military during your ..."*)

### Węzeł `[228]`
Mówca: **Orso Hawker**
> ""And you said you will not focus on military during your term. How is that for a preparation? You will be the one to blame if you actually proceed with that campaign talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Heron Garaci: ""We hope that regardless of your promise, you increase th..."*)

### Węzeł `[229]`
Mówca: **Orso Hawker**
> ""That's not good enough, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Orso Hawker: ""We need an increase on our security budgets. This is an ..."*)

### Węzeł `[230]`
Mówca: **Heron Garaci**
> ""We hope that regardless of your promise, you increase the security measures and put every Sord's mind at a little more ease.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""I agree, security will be improved.""*)
  - -> `[238]` (*Player: ""I am not sure about it.""*)
  - -> `[239]` (*Player: ""Is that a demand?""*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == false)"*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Orso Hawker: ""And you said you will not focus on military during your ..."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Orso Hawker: ""We need an increase on our security budgets. This is an ..."*)

### Węzeł `[234]`
Mówca: **Orso Hawker**
> ""Have you even talked with your own generals? Or Mr. Lancea? I don't think they share your views, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[235]`
Mówca: **Orso Hawker**
> ""And you said you will not focus on military during your term. Are you aware what that could mean for Sordland? You will be the one to blame if you actually proceed with that campaign talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Heron Garaci: ""We hope that regardless of your promise, you increase th..."*)

### Węzeł `[236]`
Mówca: **Orso Hawker**
> ""We need an increase on our security budgets. This is an actual emergency. It affects all of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Player: ""I agree, security will be improved.""*)
  - -> `[238]` (*Player: ""I am not sure about it.""*)
  - -> `[239]` (*Player: ""Is that a demand?""*)

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I agree, security will be improved.""]** — Mówca: **Player**
> ""I agree, security will be improved.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Heron Garaci), `[236]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Heron Garaci: ""That's great to hear.""*)

### Węzeł `[238]`
**[WYBÓR GRACZA: ""I am not sure about it.""]** — Mówca: **Player**
> ""I am not sure about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Heron Garaci), `[236]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Orso Hawker: ""Are you also aware that the armed Bludish separatists ha..."*)

### Węzeł `[239]`
**[WYBÓR GRACZA: ""Is that a demand?""]** — Mówca: **Player**
> ""Is that a demand?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[230]` (Heron Garaci), `[236]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Orso Hawker: ""Sure, Mr. President. It is a demand. A just and logical ..."*)

### Węzeł `[240]`
Mówca: **Orso Hawker**
> ""Sure, Mr. President. It is a demand. A just and logical one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Orso Hawker: ""Are you also aware that the armed Bludish separatists ha..."*)

### Węzeł `[241]`
Mówca: **Heron Garaci**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Orso Hawker: ""Are you also aware that the armed Bludish separatists ha..."*)

### Węzeł `[242]`
Mówca: **Orso Hawker**
> ""Are you also aware that the armed Bludish separatists have direct connections with the Workers Party of Bludia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: ""Everybody knows that.""*)
  - -> `[244]` (*Player: ""They claim otherwise.""*)
  - -> `[245]` (*Player: ""The Worker's Party is a democratic party unlike the mili..."*)
  - -> `[246]` (*Player: ""I mean... They are all Bluds.""*)

### Węzeł `[243]`
**[WYBÓR GRACZA: ""Everybody knows that.""]** — Mówca: **Player**
> ""Everybody knows that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Orso Hawker: ""You know what that means. Do you remember the vote of th..."*)

### Węzeł `[244]`
**[WYBÓR GRACZA: ""They claim otherwise.""]** — Mówca: **Player**
> ""They claim otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Orso Hawker: ""They may claim they have no ties with the separatists, b..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA: ""The Worker's Party is a democratic party unlike the militias. They are not the same.""]** — Mówca: **Player**
> ""The Worker's Party is a democratic party unlike the militias. They are not the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Orso Hawker: ""They may claim they have no ties with the separatists, b..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: ""I mean... They are all Bluds.""]** — Mówca: **Player**
> ""I mean... They are all Bluds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Heron Garaci: ""They are. And both organizations want the same thing. To..."*)

### Węzeł `[247]`
Mówca: **Orso Hawker**
> ""They may claim they have no ties with the separatists, but most of their members used to be part of them before they formed the Workers Party of Bludia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Heron Garaci: ""How about the name, Mr. President? It is not the 'Worker..."*)

### Węzeł `[248]`
Mówca: **Heron Garaci**
> ""How about the name, Mr. President? It is not the 'Workers Party of Sordland', is it? As far as I am aware, there is no nation called Bludia around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucian Galade: ""I see where this is going.""*)

### Węzeł `[249]`
Mówca: **Heron Garaci**
> ""They are. And both organizations want the same thing. To gain independence from Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucian Galade: ""I see where this is going.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA: ""You know what that means. Do you remember the vote of the Workers'Party in the last election?""]** — Mówca: **Orso Hawker**
> ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Lucian Galade: ""I see where this is going.""*)

### Węzeł `[251]`
Mówca: **Lucian Galade**
> ""I see where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Orso Hawker: ""Today, the only reason they are not in the Assembly is b..."*)

### Węzeł `[252]`
Mówca: **Orso Hawker**
> ""Today, the only reason they are not in the Assembly is because of the electoral threshold. They have gotten quite big too. They are clearly getting outside help and their connections to the paramilitary Bludish force cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Orso Hawker: ""And all of a sudden, the reformists are trying to decrea..."*)

### Węzeł `[253]`
Mówca: **Orso Hawker**
> ""And all of a sudden, the reformists are trying to decrease the electoral threshold, so that the Bludish separatists can be legitimized in the Assembly to achieve their aims of independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player: ""You think that's Mr. Ricter's intention?""*)
  - -> `[255]` (*Player: ""That's why we cannot allow it, Mr. Hawker.""*)
  - -> `[256]` (*Player: ""That's too dramatic.""*)

### Węzeł `[254]`
**[WYBÓR GRACZA: ""You think that's Mr. Ricter's intention?""]** — Mówca: **Player**
> ""You think that's Mr. Ricter's intention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Orso Hawker: ""I suspect his intentions are grander.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA: ""That's why we cannot allow it, Mr. Hawker.""]** — Mówca: **Player**
> ""That's why we cannot allow it, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Orso Hawker: ""Therefore, we need to work together.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA: ""That's too dramatic.""]** — Mówca: **Player**
> ""That's too dramatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Orso Hawker: ""Say what you will, Mr. President. I am stating the obvio..."*)

### Węzeł `[257]`
Mówca: **Orso Hawker**
> ""Say what you will, Mr. President. I am stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Orso Hawker: ""I wish the only issues were the Bludish terrorists and R..."*)

### Węzeł `[258]`
Mówca: **Orso Hawker**
> ""I suspect his intentions are grander.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Orso Hawker: ""I wish the only issues were the Bludish terrorists and R..."*)

### Węzeł `[259]`
Mówca: **Orso Hawker**
> ""Therefore, we need to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Orso Hawker: ""I wish the only issues were the Bludish terrorists and R..."*)

### Węzeł `[260]`
Mówca: **Orso Hawker**
> ""I wish the only issues were the Bludish terrorists and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Orso Hawker: ""Now we have conflicts on the streets between the nationa..."*)

### Węzeł `[261]`
Mówca: **Orso Hawker**
> ""Now we have conflicts on the streets between the nationalists and the communists. And the communists are gathering really fast after the shooting of Circas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Orso Hawker: ""This could potentially lead to civil war, Mr. President...."*)

### Węzeł `[262]`
Mówca: **Orso Hawker**
> ""This could potentially lead to civil war, Mr. President. We know that United Contana supports the communists in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Heron Garaci: ""The Reformists' suggested changes would also bring the c..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA: ""What does that have to do with anything?""]** — Mówca: **Player**
> ""What does that have to do with anything?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[213]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Orso Hawker: ""Is the administration doing something about that?""*)

### Węzeł `[264]`
**[WYBÓR GRACZA: ""With all due respect, that does not really concern you.""]** — Mówca: **Player**
> ""With all due respect, that does not really concern you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[265]`
Mówca: **Narrator**
> "Lucian gave a mocking look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Lucian Galade: ""I am sure they cannot.""*)

### Węzeł `[266]`
Mówca: **Orso Hawker**
> ""We all know that Sordish security forces found stashes of Rumburgian weaponry in the hideouts of Bludish separatists. KA-74's are roaming inside Sordland at this moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Orso Hawker: ""As much as Rumburg poses a direct threat, now it's clear..."*)

### Węzeł `[267]`
Mówca: **Orso Hawker**
> ""As much as Rumburg poses a direct threat, now it's clear that they are also intervening in our country and weaponising our minorities against us. It's not unprecedented to think that the Bluds will start their terror again with their new toys.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Orso Hawker: ""Not to mention the fights that broke out between the lef..."*)

### Węzeł `[268]`
Mówca: **Orso Hawker**
> ""Not to mention the fights that broke out between the left and right wing after the shooting of Bernard Circas. Communists are rising with the support of United Contana. The chaos is imminent for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == false"*)
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == false)"*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Orso Hawker: ""And sadly we don't see the administration taking the nec..."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Orso Hawker: ""And sadly we don't see the administration taking the nec..."*)

### Węzeł `[272]`
Mówca: **Orso Hawker**
> ""And sadly we don't see the administration taking the necessary precautions. You said you will not focus on military during your term. Under current circumstances that cannot be tolerated at any cost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: ""Mr. Hawker, the Court has no jurisdiction over these mat..."*)
  - -> `[275]` (*Player: ""We are taking the necessary steps. No need to worry.""*)
  - -> `[276]` (*Player: ""I did promise that but the circumstances have changed.""*)
  - -> `[277]` (*Player: ""Tolerate!? You should be more careful with your words of..."*)

### Węzeł `[273]`
Mówca: **Orso Hawker**
> ""And sadly we don't see the administration taking the necessary precautions yet. We clearly need more funding for our security forces for the days to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Player: ""Mr. Hawker, the Court has no jurisdiction over these mat..."*)
  - -> `[279]` (*Player: ""We are taking the necessary steps, no need to worry.""*)
  - -> `[280]` (*Player: ""I will actually be increasing the security budget shortly.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA: ""Mr. Hawker, the Court has no jurisdiction over these matters.""]** — Mówca: **Player**
> ""Mr. Hawker, the Court has no jurisdiction over these matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Orso Hawker: ""Aren't we all part of this State, Mr. President? We are ..."*)

### Węzeł `[275]`
**[WYBÓR GRACZA: ""We are taking the necessary steps. No need to worry.""]** — Mówca: **Player**
> ""We are taking the necessary steps. No need to worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Orso Hawker: ""We hope that our police forces and our military is adequ..."*)

### Węzeł `[276]`
**[WYBÓR GRACZA: ""I did promise that but the circumstances have changed.""]** — Mówca: **Player**
> ""I did promise that but the circumstances have changed.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Orso Hawker: ""I am relieved to hear that.""*)

### Węzeł `[277]`
**[WYBÓR GRACZA: ""Tolerate!? You should be more careful with your words of choice.""]** — Mówca: **Player**
> ""Tolerate!? You should be more careful with your words of choice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[272]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Orso Hawker: ""Surely a decision to destroy Sordland cannot be tolerate..."*)

### Węzeł `[278]`
**[WYBÓR GRACZA: ""Mr. Hawker, the Court has no jurisdiction over these matters.""]** — Mówca: **Player**
> ""Mr. Hawker, the Court has no jurisdiction over these matters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Orso Hawker: ""Aren't we all part of this State, Mr. President? We are ..."*)

### Węzeł `[279]`
**[WYBÓR GRACZA: ""We are taking the necessary steps, no need to worry.""]** — Mówca: **Player**
> ""We are taking the necessary steps. No need to worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Orso Hawker: ""We hope that our police forces and our military is adequ..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA: ""I will actually be increasing the security budget shortly.""]** — Mówca: **Player**
> ""I will actually be increasing the security budget shortly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Orso Hawker: ""I am relieved to hear that.""*)

### Węzeł `[281]`
Mówca: **Orso Hawker**
> ""Aren't we all part of this State, Mr. President? We are all responsible if Sordland fails to overcome these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[282]`
Mówca: **Orso Hawker**
> ""We hope that our police forces and our military is adequately funded during these times of conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[283]`
Mówca: **Orso Hawker**
> ""I am relieved to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[284]`
Mówca: **Orso Hawker**
> ""Surely a decision to destroy Sordland cannot be tolerated whether it comes from you or President Soll. Why can't you admit that we are making sense here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[285]`
Mówca: **Orso Hawker**
> ""Aren't we all part of this State, Mr. President? We are all responsible if Sordland fails to overcome these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[286]`
Mówca: **Orso Hawker**
> ""We hope that our police forces and our military is adequately funded during these times of conflict.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[287]`
Mówca: **Orso Hawker**
> ""I am relieved to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Orso Hawker: ""But regardless of that, are you also aware that the arme..."*)

### Węzeł `[288]`
Mówca: **Orso Hawker**
> ""But regardless of that, are you also aware that the armed Bludish separatists have direct connections with the Worker's Party of Bludia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Player: ""Everybody knows that.""*)
  - -> `[291]` (*Player: ""They claim otherwise.""*)
  - -> `[292]` (*Player: ""The Worker's Party is a democratic party unlike the mili..."*)
  - -> `[289]` (*Player: ""I mean... They are all Bluds.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA: ""I mean... They are all Bluds.""]** — Mówca: **Player**
> ""I mean... They are all Bluds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Heron Garaci: ""They are. And both organizations want the same thing. To..."*)

### Węzeł `[290]`
**[WYBÓR GRACZA: ""Everybody knows that.""]** — Mówca: **Player**
> ""Everybody knows that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Orso Hawker: ""You know what that means. Do you remember the vote of th..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA: ""They claim otherwise.""]** — Mówca: **Player**
> ""They claim otherwise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Orso Hawker: ""They may claim they have no ties with the separatists, b..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA: ""The Worker's Party is a democratic party unlike the militias. They are not the same.""]** — Mówca: **Player**
> ""The Worker's Party is a democratic party unlike the militias. They are not the same.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Orso Hawker: ""They may claim they have no ties with the separatists, b..."*)

### Węzeł `[293]`
Mówca: **Orso Hawker**
> ""They may claim they have no ties with the separatists, but most of their members used to be part of them before they formed the Workers' Party of Bludia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Heron Garaci: ""How about the name, Mr. President? It is not the 'Worker..."*)

### Węzeł `[294]`
Mówca: **Heron Garaci**
> ""They are. And both organizations want the same thing. To gain independence from Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucian Galade: ""What is this all about?""*)

### Węzeł `[295]`
Mówca: **Heron Garaci**
> ""How about the name, Mr. President? It is not the 'Workers' Party of Sordland', is it? As far as I am aware, there is no nation called Bludia around here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucian Galade: ""What is this all about?""*)

### Węzeł `[296]`
**[WYBÓR GRACZA: ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""]** — Mówca: **Orso Hawker**
> ""You know what that means. Do you remember the vote of the Workers' Party in the last election?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Lucian Galade: ""What is this all about?""*)

### Węzeł `[297]`
Mówca: **Lucian Galade**
> ""What is this all about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Orso Hawker: ""The only reason they are not in the Assembly is because ..."*)

### Węzeł `[298]`
Mówca: **Orso Hawker**
> ""The only reason they are not in the Assembly is because of the electoral threshold. They have gotten quite big. They are clearly getting outside help and their connections to the paramilitary Bludish force cannot be denied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Orso Hawker: ""And all of a sudden, the reformists are trying to decrea..."*)

### Węzeł `[299]`
Mówca: **Orso Hawker**
> ""And all of a sudden, the reformists are trying to decrease the electoral threshold, so that the Bludish separatists can be legitimized in the Assembly to achieve their aims of independence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Player: ""You think that's Mr. Ricter's intention?""*)
  - -> `[301]` (*Player: ""I will not allow it to happen.""*)
  - -> `[300]` (*Player: ""That's too dramatic.""*)
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)

### Węzeł `[300]`
**[WYBÓR GRACZA: ""That's too dramatic.""]** — Mówca: **Player**
> ""That's too dramatic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[299]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Orso Hawker: ""Say what you will, Mr. President. I am stating the obvio..."*)

### Węzeł `[301]`
**[WYBÓR GRACZA: ""I will not allow it to happen.""]** — Mówca: **Player**
> ""I will not allow it to happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[299]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Orso Hawker: ""Therefore, we need to work together.""*)

### Węzeł `[302]`
**[WYBÓR GRACZA: ""You think that's Mr. Ricter's intention?""]** — Mówca: **Player**
> ""You think that's Mr. Ricter's intention?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[299]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Orso Hawker: ""I suspect his intentions are grander.""*)

### Węzeł `[303]`
Mówca: **Orso Hawker**
> ""Say what you will, Mr. President. I am stating the obvious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Orso Hawker: ""But I wish the only issues were the Bludish terrorists a..."*)

### Węzeł `[304]`
Mówca: **Orso Hawker**
> ""Therefore, we need to work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Orso Hawker: ""But I wish the only issues were the Bludish terrorists a..."*)

### Węzeł `[305]`
Mówca: **Orso Hawker**
> ""But I wish the only issues were the Bludish terrorists and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Heron Garaci: ""The Reformists' suggested changes would also bring the c..."*)

### Węzeł `[306]`
Mówca: **Orso Hawker**
> ""I suspect his intentions are grander.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Orso Hawker: ""But I wish the only issues were the Bludish terrorists a..."*)

### Węzeł `[307]`
Mówca: **Heron Garaci**
> ""The Reformists' suggested changes would also bring the communists -- who are backed by United Contana -- into the Assembly. Do you see the pattern yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Player: ""I apologise, gentlemen. But I am not a conspiracy theori..."*)
  - -> `[308]` (*Player: ""You're saying the reformists are working for the foreign..."*)
  - -> `[310]` (*Player: ""There is no evidence about any of this.""*)
  - -> `[311]` (*Player: ""And what is your suggestion?""*)

### Węzeł `[308]`
**[WYBÓR GRACZA: ""You're saying the reformists are working for the foreign powers?""]** — Mówca: **Player**
> ""You're saying the reformists are working for the foreign powers?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Heron Garaci: ""Haven't you been briefed by your security team? Maybe yo..."*)

### Węzeł `[309]`
**[WYBÓR GRACZA: ""I apologise, gentlemen. But I am not a conspiracy theorist.""]** — Mówca: **Player**
> ""I apologise, gentlemen. But I am not a conspiracy theorist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Heron Garaci: ""This is not a conspiracy theory. Haven't you been briefe..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA: ""There is no evidence about any of this.""]** — Mówca: **Player**
> ""There is no evidence about any of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Heron Garaci: ""Haven't you been briefed by your security team? Maybe yo..."*)

### Węzeł `[311]`
**[WYBÓR GRACZA: ""And what is your suggestion?""]** — Mówca: **Player**
> ""And what is your suggestion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA: ""I am not working with the reformists, Mr. Hawker.""]** — Mówca: **Player**
> ""I am not working with the reformists, Mr. Hawker.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Kontekst wejściowy (poprzednik):** `[299]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Orso Hawker: ""I am aware. Yet you're proceeding with your own version ..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Intention == true )"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Player: ""I am not working with the reformists, Mr. Hawker.""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Intention == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[316]`
Mówca: **Orso Hawker**
> ""I am aware. Yet you're proceeding with your own version of changes to the Constitution, aren't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Player: ""I am. The new Constitution will not be weaker but strong..."*)
  - -> `[318]` (*Player: ""We'll see about that.""*)
  - -> `[319]` (*Player: ""Yes. I need more powers to fix these problems.""*)
  - -> `[320]` (*Player: ""Unless you have something better to propose.""*)

### Węzeł `[317]`
**[WYBÓR GRACZA: ""I am. The new Constitution will not be weaker but stronger.""]** — Mówca: **Player**
> ""I am. The new Constitution will not be weaker but stronger.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Orso Hawker: ""You already have the power of the decrees, Mr. President..."*)

### Węzeł `[318]`
**[WYBÓR GRACZA: ""We'll see about that.""]** — Mówca: **Player**
> ""We'll see about that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Orso Hawker: ""You already have the power of the decrees, Mr. President..."*)

### Węzeł `[319]`
**[WYBÓR GRACZA: ""Yes. I need more powers to fix these problems.""]** — Mówca: **Player**
> ""Yes. I need more powers to fix these problems of Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Orso Hawker: ""You already have the power of the decrees, Mr. President..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA: ""Unless you have something better to propose.""]** — Mówca: **Player**
> ""Unless you have something better to propose.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[316]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Orso Hawker: ""You already have the power of the decrees, Mr. President..."*)

### Węzeł `[321]`
Mówca: **Orso Hawker**
> ""You already have the power of the decrees, Mr. President. As long as we work together, we can allow you to enact major changes with the presidential decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Orso Hawker: ""But I wish the only issues were the Bludish terrorists a..."*)

### Węzeł `[322]`
Mówca: **Heron Garaci**
> ""This is not a conspiracy theory. Haven't you been briefed by your security team? Maybe you should suspect them as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[323]`
Mówca: **Heron Garaci**
> ""Haven't you been briefed by your security team? Maybe you should suspect them as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[324]`
Mówca: **Orso Hawker**
> ""We should take the necessary measures against communist and Bludish plots as well as increasing our military budget against a possible conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Heron Garaci: ""And of course not fall into the traps of the reformists ..."*)

### Węzeł `[325]`
Mówca: **Heron Garaci**
> ""And of course not fall into the traps of the reformists by listening to their demands. They are clearly plotting to weaken the President and our whole administration in order to exploit the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Orso Hawker: ""...Which brings us to some very important information th..."*)

### Węzeł `[326]`
Mówca: **Orso Hawker**
> ""...Which brings us to some very important information that we have. It's definitely something you need to hear, and it can change absolutely everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Lucian Galade: ""With all due respect, Mr. President, I think this is get..."*)

### Węzeł `[327]`
Mówca: **Lucian Galade**
> ""With all due respect, Mr. President, I think this is getting slightly ridiculous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player: ""Please explain, Mr. Hawker.""*)
  - -> `[328]` (*Player: ""Let the Chief Justice talk, Lucian.""*)
  - -> `[329]` (*Player: ""You're right. I don't think anything will come out of th..."*)

### Węzeł `[328]`
**[WYBÓR GRACZA: ""Let the Chief Justice talk, Lucian.""]** — Mówca: **Player**
> ""Let the Chief Justice talk, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Lucian Galade: ""Of course, sir.""*)

### Węzeł `[329]`
**[WYBÓR GRACZA: ""You're right. I don't think anything will come out of this meeting.""]** — Mówca: **Player**
> ""You're right. I don't think anything will come out of this meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Orso Hawker: ""So you don't want to hear about the information that I h..."*)

### Węzeł `[330]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[327]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Orso Hawker: ""The person in question is Mr. Frens Ricter, himself. The..."*)

### Węzeł `[331]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Orso Hawker: ""The person in question is Mr. Frens Ricter, himself. The..."*)

### Węzeł `[332]`
Mówca: **Orso Hawker**
> ""So you don't want to hear about the information that I have?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Player: ""There is no need, Mr. Hawker. This meeting is over.""*)
  - -> `[363]` (*Player: ""I want to hear it first.""*)

### Węzeł `[333]`
Mówca: **Orso Hawker**
> ""The person in question is Mr. Frens Ricter, himself. The *leader* of the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Orso Hawker: ""We have enough information to infer that he has ties wit..."*)

### Węzeł `[334]`
Mówca: **Orso Hawker**
> ""We have enough information to infer that he has ties with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Orso Hawker: ""Arcasia is aggressively growing their influence around t..."*)

### Węzeł `[335]`
Mówca: **Orso Hawker**
> ""Arcasia is aggressively growing their influence around the world and now we have Mr. Ricter coming up with these ridiculous demands for a new Constitution amidst a chaotic period in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Orso Hawker: ""All the pieces seem to fit perfectly. That is why the Su..."*)

### Węzeł `[336]`
Mówca: **Lucian Galade**
> ""How would you know that Mr. Ricter has ties to Arcasia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Heron Garaci: ""Mr. Galade, we all know he has been in Arcasia many time..."*)

### Węzeł `[337]`
Mówca: **Orso Hawker**
> ""All the pieces seem to fit perfectly. That is why the Supreme Court will be doing what it takes to stop these reforms and preserve the Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Lucian Galade: ""How would you know that Mr. Ricter has ties to Arcasia?""*)

### Węzeł `[338]`
Mówca: **Orso Hawker**
> ""He was spotted in a hotel in Arcasia last year, where they held the 'Conference on Economic Development in Volatile Regions'. Right around that time, he started to influence the masses into believing that our Constitution is the reason for everything bad.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Orso Hawker: ""His trip was not documented, nor was he an official gues..."*)

### Węzeł `[339]`
Mówca: **Heron Garaci**
> ""Mr. Galade, we all know he has been in Arcasia many times, because it's been documented. But what would you think if I told you he has been making hidden flights to the country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Player: ""I need to know this. Please explain.""*)
  - -> `[341]` (*Player: ""He was hiding his flights to Arcasia?""*)
  - -> `[342]` (*Player: ""Another conspiracy theory.""*)

### Węzeł `[340]`
**[WYBÓR GRACZA: ""I need to know this. Please explain.""]** — Mówca: **Player**
> ""I need to know this. Please explain.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Orso Hawker: ""He was spotted in a hotel in Arcasia last year, where th..."*)

### Węzeł `[341]`
**[WYBÓR GRACZA: ""He was hiding his flights to Arcasia?""]** — Mówca: **Player**
> ""He was hiding his flights to Arcasia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Heron Garaci: ""He was.""*)

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Another conspiracy theory.""]** — Mówca: **Player**
> ""Another conspiracy theory.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[339]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Orso Hawker: ""Believe what you will, Mr. President. But at least hear ..."*)

### Węzeł `[343]`
Mówca: **Heron Garaci**
> ""He was.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Orso Hawker: ""He was spotted in a hotel in Arcasia last year, where th..."*)

### Węzeł `[344]`
Mówca: **Orso Hawker**
> ""His trip was not documented, nor was he an official guest of the conference. We believe that he had a meeting with President Walker behind closed doors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Orso Hawker: ""I also have more photos of him that were taken in Arcasi..."*)

### Węzeł `[345]`
Mówca: **Orso Hawker**
> ""I also have more photos of him that were taken in Arcasia in different cities. One is from a couple months back. Again, none of it is documented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Orso Hawker: ""He also attended another event in Lespia last week. The ..."*)

### Węzeł `[346]`
Mówca: **Orso Hawker**
> ""He also attended another event in Lespia last week. The Arcasian Minister of Foreign Affairs was there too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Player: ""How did you find out about this?""*)
  - -> `[348]` (*Player: ""If this is true, this is *big*.""*)
  - -> `[349]` (*Player: ""How can any of these be undocumented?""*)

### Węzeł `[347]`
**[WYBÓR GRACZA: ""How did you find out about this?""]** — Mówca: **Player**
> ""How did you find out about this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Orso Hawker: ""Many Sollists were already following his leads for quite..."*)

### Węzeł `[348]`
**[WYBÓR GRACZA: ""If this is true, this is *big*.""]** — Mówca: **Player**
> ""If this is true, this is *big*.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Orso Hawker: ""I told you so, Mr. President.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA: ""How can any of these be undocumented?""]** — Mówca: **Player**
> ""How can any of these be undocumented?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[346]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Orso Hawker: ""We don't know. Even if he used a private plane, we would..."*)

### Węzeł `[350]`
Mówca: **Orso Hawker**
> ""We don't know. Even if he used a private plane, we would be able to get the information of his flights. That means he has people helping them from inside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Orso Hawker: ""Many Sollists were already following his leads for quite..."*)

### Węzeł `[351]`
Mówca: **Orso Hawker**
> ""Many Sollists were already following his leads for quite some time, Mr. President. I cannot give away their identities, but I can give you the evidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Narrator: "He handed me a small file."*)

### Węzeł `[352]`
Mówca: **Narrator**
> "He handed me a small file."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Narrator: "It contained official documents from the Sordish Border G..."*)

### Węzeł `[353]`
Mówca: **Orso Hawker**
> ""I told you so, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Orso Hawker: ""Many Sollists were already following his leads for quite..."*)

### Węzeł `[354]`
Mówca: **Narrator**
> "It contained official documents from the Sordish Border Guard with highlighted dates that showed no trace of Frens Ricter's name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Narrator: "There were clear photos of him that were taken in the con..."*)

### Węzeł `[355]`
Mówca: **Narrator**
> "There were clear photos of him that were taken in the conference in Arcasia, as well as remarks by Lespian and Arcasian citizens who claim to have seen him with Arcasian businessmen around the same dates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Narrator: "There was also an official transcript of one of his speec..."*)

### Węzeł `[356]`
Mówca: **Narrator**
> "There was also an official transcript of one of his speeches where he claimed to be in Benfi on the dates of the conference in Arcasia, where he was spotted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Narrator: "Lucian skimmed through the documents with skepticism whic..."*)

### Węzeł `[357]`
Mówca: **Lucian Galade**
> ""These seem to be real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Orso Hawker: ""Of course they are real, Mr. Galade.""*)

### Węzeł `[358]`
Mówca: **Orso Hawker**
> ""Of course they are real, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Orso Hawker: ""These seem to suggest that Arcasia is behind the reformi..."*)

### Węzeł `[359]`
Mówca: **Orso Hawker**
> ""Believe what you will, Mr. President. But at least hear me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Orso Hawker: ""He was spotted in a hotel in Arcasia last year, where th..."*)

### Węzeł `[360]`
Mówca: **Orso Hawker**
> ""Now you understand the reasons for our current stance. And also our suspicions about your advisers, who clearly have not given you this vital information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "Lucian gave him a sharp look."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "Lucian gave him a sharp look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Lucian Galade: ""We appreciate the information, Mr. Hawker, but I advise ..."*)

### Węzeł `[362]`
**[WYBÓR GRACZA: ""There is no need, Mr. Hawker. This meeting is over.""]** — Mówca: **Player**
> ""There is no need, Mr. Hawker. This meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Orso Hawker: ""I see.""*)

### Węzeł `[363]`
**[WYBÓR GRACZA: ""I want to hear it first.""]** — Mówca: **Player**
> ""I want to hear it first.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[332]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Narrator: "Lucian looked upset."*)

### Węzeł `[364]`
Mówca: **Narrator**
> "Lucian looked upset."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Orso Hawker: ""The person in question is Mr. Frens Ricter, himself. The..."*)

### Węzeł `[365]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[586]` (*Heron Garaci: ""Suit yourself, Mr. President. Play into the hands of Sor..."*)

### Węzeł `[366]`
Mówca: **Narrator**
> "Lucian skimmed through the documents with skepticism which slowly turned into surprise."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Lucian Galade: ""These seem to be real.""*)

### Węzeł `[367]`
Mówca: **Orso Hawker**
> ""We should take the necessary measures against communist and Bludish plots as well as increasing our military budget against a possible conflict with Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Heron Garaci: ""And of course not fall into the traps of the reformists ..."*)

### Węzeł `[368]`
Mówca: **Heron Garaci**
> ""The Reformists' suggested changes would also bring the communists -- who are backed by United Contana -- into the Assembly. Do you see the pattern yet?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Player: ""This doesn't look good.""*)
  - -> `[371]` (*Player: ""I apologize gentlemen but I am not a conspiracy theorist.""*)
  - -> `[369]` (*Player: ""You're saying the reformists are working for the foreign..."*)
  - -> `[370]` (*Player: ""And what is your suggestion?""*)

### Węzeł `[369]`
**[WYBÓR GRACZA: ""You're saying the reformists are working for the foreign powers?""]** — Mówca: **Player**
> ""You're saying the reformists are working for the foreign powers?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Heron Garaci: ""Haven't you been briefed by your security team? Maybe yo..."*)

### Węzeł `[370]`
**[WYBÓR GRACZA: ""And what is your suggestion?""]** — Mówca: **Player**
> ""And what is your suggestion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[371]`
**[WYBÓR GRACZA: ""I apologize gentlemen but I am not a conspiracy theorist.""]** — Mówca: **Player**
> ""I apologize gentlemen but I am not a conspiracy theorist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Heron Garaci: ""This is not a conspiracy theory. Haven't you been briefe..."*)

### Węzeł `[372]`
**[WYBÓR GRACZA: ""This doesn't look good.""]** — Mówca: **Player**
> ""This doesn't look good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Heron Garaci: ""No, it doesn't, Mr. President.""*)

### Węzeł `[373]`
Mówca: **Heron Garaci**
> ""Haven't you been briefed by your security team? Maybe you should start suspecting them too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[374]`
Mówca: **Heron Garaci**
> ""This is not a conspiracy theory. Haven't you been briefed by your security team? Maybe you should start suspecting them too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[375]`
Mówca: **Heron Garaci**
> ""No, it doesn't, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Orso Hawker: ""We should take the necessary measures against communist ..."*)

### Węzeł `[376]`
Mówca: **Heron Garaci**
> ""And of course not fall into the traps of the reformists by listening to their demands. They are clearly plotting to weaken the President and our whole administration in order to exploit the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Orso Hawker: ""...Which brings us to the information that I have about ..."*)

### Węzeł `[377]`
Mówca: **Orso Hawker**
> ""...Which brings us to the information that I have about this important figure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Player: ""Please explain, Mr. Hawker.""*)
  - -> `[379]` (*Player: ""Finally.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA: ""Please explain, Mr. Hawker.""]** — Mówca: **Player**
> ""Please explain, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Orso Hawker: ""The person in question is Mr. Frens Ricter, himself.""*)

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Finally.""]** — Mówca: **Player**
> ""Finally.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[377]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Orso Hawker: ""The person in question is Mr. Frens Ricter, himself.""*)

### Węzeł `[380]`
Mówca: **Orso Hawker**
> ""The person in question is Mr. Frens Ricter, himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Orso Hawker: ""We have enough information to infer that he has ties wit..."*)

### Węzeł `[381]`
Mówca: **Orso Hawker**
> ""We have enough information to infer that he has ties with Arcasia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Orso Hawker: ""Arcasia is aggressively growing their influence around t..."*)

### Węzeł `[382]`
Mówca: **Orso Hawker**
> ""All the pieces seem to fit perfectly. That is why the Supreme Court will be doing what it takes to stop these reforms and preserve the Constitution together with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Orso Hawker: ""...At least that's what we hope for.""*)

### Węzeł `[383]`
Mówca: **Orso Hawker**
> ""Arcasia is aggressively growing their influence around the world and now we have Mr. Ricter coming up with these ridiculous demands for a new Constitution amidst a chaotic period in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Orso Hawker: ""All the pieces seem to fit perfectly. That is why the Su..."*)

### Węzeł `[384]`
Mówca: **Lucian Galade**
> ""How would you know that Mr. Ricter has ties to Arcasia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Heron Garaci: ""Mr. Galade, we all know he has been in Arcasia many time..."*)

### Węzeł `[385]`
Mówca: **Orso Hawker**
> ""...At least that's what we hope for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Lucian Galade: ""How would you know that Mr. Ricter has ties to Arcasia?""*)

### Węzeł `[386]`
Mówca: **Orso Hawker**
> ""There is not much to think or check... This is clearly an emergency. In such cases, the Constitution gives the President the right to use his emergency powers. If we work together, you can be sure that the Supreme Court will not block your declaration of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Player: ""Let's talk about how we can work together.""*)
  - -> `[389]` (*Player: ""You want me to declare an emergency?""*)
  - -> `[390]` (*Player: ""I am still too skeptical about these, Mr. Hawker. I will..."*)

### Węzeł `[387]`
Mówca: **Lucian Galade**
> ""We appreciate the information, Mr. Hawker, but I advise against jumping to conclusions right away. We still need to check the information.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Orso Hawker: ""There is not much to think or check... This is clearly a..."*)

### Węzeł `[388]`
**[WYBÓR GRACZA: ""Let's talk about how we can work together.""]** — Mówca: **Player**
> ""Let's talk about how we can work together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Orso Hawker: ""Of course. We cannot wait for the processes of the Assem..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA: ""You want me to declare an emergency?""]** — Mówca: **Player**
> ""You want me to declare an emergency?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Orso Hawker: ""Of course. We cannot wait for the processes of the Assem..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA: ""I am still too skeptical about these, Mr. Hawker. I will have to decline.""]** — Mówca: **Player**
> ""I am still too skeptical about these, Mr. Hawker. I will have to decline.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[386]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Orso Hawker: ""It seems you are more influenced by Mr. Galade than you ..."*)

### Węzeł `[391]`
Mówca: **Lucian Galade**
> ""What is that supposed to mean, Mr. Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Orso Hawker: ""Why don't you explain your agenda yourself, Lucian? You ..."*)

### Węzeł `[392]`
Mówca: **Orso Hawker**
> ""It seems you are more influenced by Mr. Galade than you think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Lucian Galade: ""What is that supposed to mean, Mr. Hawker?""*)

### Węzeł `[393]`
Mówca: **Orso Hawker**
> ""Of course. We cannot wait for the processes of the Assembly to take care of these issues. You must exercise your presidential powers for a fast and effective solution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Orso Hawker: ""Which means you might need to suspend parts of the Const..."*)

### Węzeł `[394]`
Mówca: **Orso Hawker**
> ""Which means you might need to suspend parts of the Constitution to give more authority to our security forces to deal with these issues. We must officially investigate Mr. Ricter as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Orso Hawker: ""You can devise a strong security decree if you can base ..."*)

### Węzeł `[395]`
Mówca: **Orso Hawker**
> ""You can devise a strong security decree if you can base it on the Articles 57 and 58, which gives the president the right to suspend parts of the Constitution to deal with national security threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Orso Hawker: ""You can directly bypass the Assembly in such a situation..."*)

### Węzeł `[396]`
Mówca: **Orso Hawker**
> ""You can directly bypass the Assembly in such a situation. The only thing you need is the Supreme Court to allow the emergency to be declared. And you have our word on that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Lucian Galade: ""Sir, I think that is going a bit too far. We shouldn't e..."*)

### Węzeł `[397]`
Mówca: **Lucian Galade**
> ""Sir, I think that is going a bit too far. We shouldn't escalate things so fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Orso Hawker: ""Mr. President, why don't we talk in private, just the tw..."*)

### Węzeł `[398]`
Mówca: **Orso Hawker**
> ""We can devise a plan together. I know how we can use the Constitution to our advantage. It would be more effective if Mr. Galade and Mr. Garaci leave the room before we discuss it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[399]`
Mówca: **Lucian Galade**
> ""Sir, I advise against it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player: ""Could you leave us alone with Mr. Hawker, gentlemen?""*)
  - -> `[405]` (*Player: ""I like your idea, Mr. Hawker but I'd rather plan it toge..."*)
  - -> `[406]` (*Player: ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""*)
  - -> `[407]` (*Player: ""Regardless of our situation, I'll be proceeding with the..."*)

### Węzeł `[400]`
**[WYBÓR GRACZA: ""Could you leave us alone with Mr. Hawker, gentlemen?""]** — Mówca: **Player**
> ""Could you leave us alone with Mr. Hawker, gentlemen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Lucian Galade), `[404]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Lucian stood up as Orso gave him a smile. Heron paid his ..."*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Narrator: "Lucian looked at me to hear my response."*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Lucian Galade: ""Sir, I advise against it.""*)

### Węzeł `[404]`
Mówca: **Narrator**
> "Lucian looked at me to hear my response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Player: ""Could you leave us alone with Mr. Hawker, gentlemen?""*)
  - -> `[405]` (*Player: ""I like your idea, Mr. Hawker but I'd rather plan it toge..."*)
  - -> `[406]` (*Player: ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""*)

### Węzeł `[405]`
**[WYBÓR GRACZA: ""I like your idea, Mr. Hawker but I'd rather plan it together.""]** — Mówca: **Player**
> ""I like your idea, Mr. Hawker, but I'd rather plan it together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Lucian Galade), `[404]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Orso Hawker: ""Glad to hear that we're on the same page, Mr. President...."*)

### Węzeł `[406]`
**[WYBÓR GRACZA: ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""]** — Mówca: **Player**
> ""I'm sorry to say that we won't be cooperating, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Lucian Galade), `[404]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Orso Hawker: ""Even though you are aware of our national security threa..."*)

### Węzeł `[407]`
**[WYBÓR GRACZA: ""Regardless of our situation, I'll be proceeding with the reforms.""]** — Mówca: **Player**
> ""Regardless of our situation, I'll be proceeding with the reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[399]` (Lucian Galade), `[414]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Orso Hawker: ""Even though you are aware of our national security threa..."*)

### Węzeł `[408]`
Mówca: **Orso Hawker**
> ""Even though you are aware of our national security threats...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Heron Garaci: ""You are making a big mistake, Mr. President. We will not..."*)

### Węzeł `[409]`
Mówca: **Heron Garaci**
> ""You are making a big mistake, Mr. President. We will not allow you to succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player: ""You are the ones who are making the mistake.""*)
  - -> `[418]` (*Player: ""ENOUGH!""*)
  - -> `[424]` (*Player: ""Gentlemen, I think it's about time to end this meeting.""*)

### Węzeł `[410]`
Mówca: **Orso Hawker**
> ""Why don't you explain your agenda yourself, Lucian? You are swaying the President to ignore the national security threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player: ""I am not swayed by anyone, Mr. Hawker. This is my own de..."*)
  - -> `[412]` (*Player: ""You are the one trying to sway me into believing in cons..."*)
  - -> `[487]` (*Player: ""Gentlemen, let's get back to the topic.""*)

### Węzeł `[411]`
**[WYBÓR GRACZA: ""I am not swayed by anyone, Mr. Hawker. This is my own decision.""]** — Mówca: **Player**
> ""I am not swayed by anyone, Mr. Hawker. This is my own decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Orso Hawker: ""Say what you will. History will prove us right, once aga..."*)

### Węzeł `[412]`
**[WYBÓR GRACZA: ""You are the one trying to sway me into believing in conspiracies.""]** — Mówca: **Player**
> ""You are the one trying to sway me into believing in conspiracies.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Orso Hawker: ""Say what you will. History will prove us right, once aga..."*)

### Węzeł `[413]`
Mówca: **Orso Hawker**
> ""Say what you will. History will prove us right, once again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Heron Garaci: ""And if you believe you can enact these reforms, you are ..."*)

### Węzeł `[414]`
Mówca: **Heron Garaci**
> ""And if you believe you can enact these reforms, you are living in a land of dreams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Player: ""Regardless of our situation, I'll be proceeding with the..."*)
  - -> `[415]` (*Player: ""Sorry to upset you, gentlemen.""*)
  - -> `[489]` (*Player: ""I think this meeting is over.""*)

### Węzeł `[415]`
**[WYBÓR GRACZA: ""Sorry to upset you, gentlemen.""]** — Mówca: **Player**
> ""Sorry to upset you, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[414]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Orso Hawker: ""Even though you are aware of our national security threa..."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "There was a long silence in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Orso Hawker: ""It seems the President is done with us, Heron. Let's tak..."*)

### Węzeł `[417]`
Mówca: **Orso Hawker**
> ""It seems the President is done with us, Heron. Let's take our leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Narrator: "They stood up."*)

### Węzeł `[418]`
**[WYBÓR GRACZA: ""ENOUGH!""]** — Mówca: **Player**
> ""ENOUGH!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "There was a long silence in the room."*)

### Węzeł `[419]`
Mówca: **Orso Hawker**
> ""Well, Mr. President. Do you want to talk about how we can fight against these reformists and the others? Or did you made up your mind?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player: ""Let's hear your suggestions.""*)
  - -> `[421]` (*Player: ""No, Mr. Hawker. I think this meeting is over.""*)

### Węzeł `[420]`
**[WYBÓR GRACZA: ""Let's hear your suggestions.""]** — Mówca: **Player**
> ""Let's hear your suggestions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Orso Hawker: ""Of course. We cannot wait for the processes of the Assem..."*)

### Węzeł `[421]`
**[WYBÓR GRACZA: ""No, Mr. Hawker. I think this meeting is over.""]** — Mówca: **Player**
> ""No, Mr. Hawker. I think this meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Orso Hawker: ""I see.""*)

### Węzeł `[422]`
Mówca: **Orso Hawker**
> ""Mr. President, why don't we talk in private, just the two of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Orso Hawker: ""We can devise a plan together. I know how we can use the..."*)

### Węzeł `[423]`
**[WYBÓR GRACZA: ""You are the ones who are making the mistake.""]** — Mówca: **Player**
> ""You are the ones who are making the mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Orso Hawker: ""We will see, Mr. President. We will see...""*)

### Węzeł `[424]`
**[WYBÓR GRACZA: ""Gentlemen, I think it's about time to end this meeting.""]** — Mówca: **Player**
> ""Gentlemen, I think it's about time to end this meeting.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[409]` (Heron Garaci), `[429]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Orso Hawker: ""Well, thank you for having us, Mr. President.""*)

### Węzeł `[425]`
Mówca: **Orso Hawker**
> ""Well, thank you for having us, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Orso Hawker: ""Have a good evening.""*)

### Węzeł `[426]`
Mówca: **Orso Hawker**
> ""We will see, Mr. President. We will see...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Orso Hawker: ""Have a good evening.""*)

### Węzeł `[427]`
Mówca: **Orso Hawker**
> ""Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "They both left the room without saying anything else."*)

### Węzeł `[428]`
Mówca: **Narrator**
> "They stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Orso Hawker: ""Well, thank you for having us, Mr. President.""*)

### Węzeł `[429]`
Mówca: **Orso Hawker**
> ""Glad to hear that we're on the same page, Mr. President. But I will have to insist on the private talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Player: ""Fair enough. Will you leave us, gentlemen?""*)
  - -> `[431]` (*Player: ""Lucian?""*)
  - -> `[424]` (*Player: ""Gentlemen, I think it's about time to end this meeting.""*)

### Węzeł `[430]`
**[WYBÓR GRACZA: ""Fair enough. Will you leave us, gentlemen?""]** — Mówca: **Player**
> ""Fair enough. Will you leave us, gentlemen?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[429]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Lucian stood up as Orso gave him a smile. Heron paid his ..."*)

### Węzeł `[431]`
**[WYBÓR GRACZA: ""Lucian?""]** — Mówca: **Player**
> ""Lucian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[429]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]` (*Lucian Galade: ""You know exactly what I think. But if you both insist up..."*)

### Węzeł `[432]`
Mówca: **Lucian Galade**
> ""You know exactly what I think. But if you both insist upon it, I will leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Orso Hawker: ""Then please do so, Mr. Galade.""*)

### Węzeł `[433]`
Mówca: **Orso Hawker**
> ""Then please do so, Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[644]` (*Player: ""Yes, thank you, Lucian. You can go.""*)
  - -> `[645]` (*Player: ""Lucian isn't going anywhere. This meeting is over.""*)

### Węzeł `[434]`
Mówca: **Narrator**
> "Lucian stood up as Orso gave him a smile. Heron paid his respects and left with Lucian, leaving me and Orso alone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Orso Hawker: ""So, Mr. President...""*)

### Węzeł `[435]`
Mówca: **Orso Hawker**
> ""So, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Orso Hawker: ""If you stop the reform committee meetings immediately an..."*)

### Węzeł `[436]`
Mówca: **Orso Hawker**
> ""If you stop the reform committee meetings immediately and focus on the real threats, I will guarantee you, we will manage the reformists together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Orso Hawker: ""You must eliminate these threats both internal and exter..."*)

### Węzeł `[437]`
Mówca: **Orso Hawker**
> ""You must eliminate these threats both internal and external. An emergency act can help you do that. We cannot trust anyone in the administration either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Player: ""I agree. Sordland is in a crisis.""*)
  - -> `[438]` (*Player: ""Tell me more about the legal details of an emergency act.""*)
  - -> `[439]` (*Player: ""How can we fight against these threats with an emergency..."*)

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Tell me more about the legal details of an emergency act.""]** — Mówca: **Player**
> ""Tell me more about the legal details of an emergency act.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Orso Hawker: ""According to Article 58, if public security and order ar..."*)

### Węzeł `[439]`
**[WYBÓR GRACZA: ""How can we fight against these threats with an emergency act?""]** — Mówca: **Player**
> ""How can we fight against these threats with an emergency decree?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Orso Hawker: ""You have the power to give more authority to the police ..."*)

### Węzeł `[440]`
Mówca: **Orso Hawker**
> ""According to Article 58, if public security and order are seriously disturbed or endangered within the Republic of Sordland...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Orso Hawker: ""...the President of Sordland may modify and suspend part..."*)

### Węzeł `[441]`
Mówca: **Orso Hawker**
> ""...the President of Sordland may modify and suspend parts of Constitution, subject to confirmation by the Supreme Court, to determine the validity of the declaration of a state of emergency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "AutocratHub01"*)

### Węzeł `[442]`
**[WYBÓR GRACZA: ""Which parts of the Constitution can we modify or suspend?""]** — Mówca: **Player**
> ""Which parts of the Constitution can we modify or suspend?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Orso Hawker: ""That is kind of a grey area. The Constitution states tha..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA: ""How can we effectively silence the opposition?""]** — Mówca: **Player**
> ""How can we effectively silence the opposition?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Orso Hawker: ""We may need increased surveillance on our political riva..."*)

### Węzeł `[444]`
**[WYBÓR GRACZA: ""Can't the Assembly simply revoke it?""]** — Mówca: **Player**
> ""Can't the Assembly simply revoke it?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]` (*Orso Hawker: ""According to the Constitution, only the President and th..."*)

### Węzeł `[445]`
Mówca: **Orso Hawker**
> ""That is kind of a grey area. The Constitution states that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Orso Hawker: ""...no State shall, in the case of National Emergency, mo..."*)

### Węzeł `[446]`
**[WYBÓR GRACZA: ""I agree. Sordland is in a crisis.""]** — Mówca: **Player**
> ""I agree. Sordland is in a crisis.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[437]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Orso Hawker: ""Yes, this is very serious.""*)

### Węzeł `[447]`
Mówca: **Orso Hawker**
> ""Yes, this is very serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Orso Hawker: ""According to Article 58, if public security and order ar..."*)

### Węzeł `[448]`
Mówca: **Orso Hawker**
> ""...no State shall, in the case of National Emergency, modify or suspend the rights of freedom, defined in Article 100 of the Constitution, unless actually invaded, or in such imminent danger as will not admit of delay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player: ""If we want to give the police more authority, we might n..."*)
  - -> `[452]` (*Player: ""But we are not under invasion.""*)
  - -> `[450]` (*Player: ""Such imminent danger... That can definitely be argued to..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA: ""If we want to give the police more authority, we might need to modify the rights of freedom too.""]** — Mówca: **Player**
> ""If we want to give the police more authority, we might need to modify the rights of freedom too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]` (*Orso Hawker: ""That is correct. Current security laws are limited becau..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA: ""Such imminent danger... That can definitely be argued to be the case.""]** — Mówca: **Player**
> ""Such imminent danger... That can definitely be argued to be the case.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]` (*Orso Hawker: ""Exactly.""*)

### Węzeł `[451]`
Mówca: **Orso Hawker**
> ""That is correct. Current security laws are limited because of the personal freedoms defined in Article 100. We may need to suspend some of the privacy laws which definitely conflicts with the Constitution...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Orso Hawker: ""However, the section where it states that 'actually inva..."*)

### Węzeł `[452]`
**[WYBÓR GRACZA: ""But we are not under invasion.""]** — Mówca: **Player**
> ""But we are not under invasion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[448]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Orso Hawker: ""That is correct.""*)

### Węzeł `[453]`
Mówca: **Orso Hawker**
> ""However, the section where it states that 'actually invaded, or in such imminent danger as will not admit of delay' can be up to interpretation. We are definitely under such imminent danger because of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Orso Hawker: ""Not to mention United Contana's support for a communist ..."*)

### Węzeł `[454]`
Mówca: **Orso Hawker**
> ""Not to mention United Contana's support for a communist coup in Sordland as well as Frens Ricter's involvement with Arcasia, which is definitely connected to all of these problems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Orso Hawker: ""And of course, that is up to the Supreme Court to decide..."*)

### Węzeł `[455]`
Mówca: **Orso Hawker**
> ""That is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Orso Hawker: ""However, the section where it states that 'actually inva..."*)

### Węzeł `[456]`
Mówca: **Orso Hawker**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Orso Hawker: ""It can definitely be argued that we are under such immin..."*)

### Węzeł `[457]`
Mówca: **Orso Hawker**
> ""It can definitely be argued that we are under such imminent danger because of Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]` (*Orso Hawker: ""Not to mention United Contana's support for a communist ..."*)

### Węzeł `[458]`
Mówca: **Orso Hawker**
> ""And of course, that is up to the Supreme Court to decide. So that is not a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_A = true"*)

### Węzeł `[459]`
Mówca: **Orso Hawker**
> ""You have the power to give more authority to the police with their search warrants, suspicion- based arrests, detention without trials... as well as banning the threatening nations' citizens from entering Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Orso Hawker: ""According to Article 58, if public security and order ar..."*)

### Węzeł `[460]`
Mówca: **Orso Hawker**
> ""We may need increased surveillance on our political rivals to find out about their connections and plots. Bringing unlimited detention would allow you to arrest people as necessary, such as Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Player: ""What if the investigations cannot find anything incrimin..."*)
  - -> `[462]` (*Player: ""He needs to be eliminated.""*)
  - -> `[463]` (*Player: ""That might be going a bit too far.""*)

### Węzeł `[461]`
**[WYBÓR GRACZA: ""What if the investigations cannot find anything incriminating?""]** — Mówca: **Player**
> ""What if the investigations cannot find anything incriminating?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Orso Hawker: ""The information that I gave you can be enough, depending..."*)

### Węzeł `[462]`
**[WYBÓR GRACZA: ""He needs to be eliminated.""]** — Mówca: **Player**
> ""He needs to be eliminated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[468]` (*Orso Hawker: ""I agree. In an emergency, anything is possible, Mr. Pres..."*)

### Węzeł `[463]`
**[WYBÓR GRACZA: ""That might be going a bit too far.""]** — Mówca: **Player**
> ""That might be going a bit too far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Orso Hawker: ""I disagree. You already know about the coup plots and fo..."*)

### Węzeł `[464]`
Mówca: **Orso Hawker**
> ""I disagree. You already know about the coup plots and foreign backed terrorists in Sordland. And a lot of these issues overlap with the reformist agenda of creating a weaker Constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Orso Hawker: ""I suspect Frens Ricter is involved with many of these or..."*)

### Węzeł `[465]`
Mówca: **Orso Hawker**
> ""I suspect Frens Ricter is involved with many of these organisations. He may even be working together with Rumburg. And they really do pose an existential threat to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_B = true"*)

### Węzeł `[466]`
Mówca: **Orso Hawker**
> ""The information that I gave you can be enough, depending on what parts of the Constitution you'll modify. In an emergency, anything is possible, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Orso Hawker: ""The Supreme Court will support your decisions.""*)

### Węzeł `[467]`
Mówca: **Orso Hawker**
> ""The Supreme Court will support your decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_B = true"*)

### Węzeł `[468]`
Mówca: **Orso Hawker**
> ""I agree. In an emergency, anything is possible, Mr. President...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Orso Hawker: ""The Supreme Court will support your decisions.""*)

### Węzeł `[469]`
Mówca: **Orso Hawker**
> ""According to the Constitution, only the President and the Grand National Assembly can revoke the emergency after it is declared. That is correct.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Orso Hawker: ""However, as long as your party is in line, they will nev..."*)

### Węzeł `[470]`
Mówca: **Orso Hawker**
> ""However, as long as your party is in line, they will never have a majority to revoke it immediately. So, no. They cannot *simply* revoke it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_C = true"*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AutocratHub01`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true"*)
  - -> `[493]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true"*)
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true"*)
  - -> `[478]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsola..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Węzeł Logiki Narracyjnej: "Jump to: [AutocratHub01]"*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_B = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "Jump to: [AutocratHub01]"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_C = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Węzeł Logiki Narracyjnej: "Jump to: [AutocratHub01]"*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AutocratHub01]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "AutocratHub01"*)

### Węzeł `[476]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AutocratHub01]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "AutocratHub01"*)

### Węzeł `[477]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [AutocratHub01]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "AutocratHub01"*)

### Węzeł `[478]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsola..."*)
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIso..."*)

### Węzeł `[479]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Player: ""Okay. Where do we begin?""*)
  - -> `[481]` (*Player: ""Let's talk about the details of this emergency act.""*)
  - -> `[516]` (*Player: ""Sorry to interrupt, Mr. Hawker, but I won't be going ahe..."*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Autocrat_Hub_A && BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[481]`
**[WYBÓR GRACZA: ""Let's talk about the details of this emergency act.""]** — Mówca: **Player**
> ""Let's talk about the details of this emergency act.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Orso Hawker: ""You must first justify the emergency act. We need to hav..."*)

### Węzeł `[482]`
Mówca: **Orso Hawker**
> ""You must first justify the emergency act. We need to have at least one target that we can blame the conflicts on. They will be declared as a national security threat, and this would allow us to prosecute their members or people connected to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]` (*Orso Hawker: ""There are obvious connections between the Bludish separa..."*)

### Węzeł `[483]`
**[WYBÓR GRACZA: ""Young Sords executed an attack near the Palace. They must pay for it.""]** — Mówca: **Player**
> ""Young Sords executed an attack near the Palace. They must pay for it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Orso Hawker: ""They are an enemy of the state. The state must react.""*)

### Węzeł `[484]`
**[WYBÓR GRACZA: ""Red Youth must be targeted before they get too powerful to trigger a revolution.""]** — Mówca: **Player**
> ""Red Youth must be targeted before they get too powerful to trigger a revolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Orso Hawker: ""They are an enemy of the state. The state must react.""*)

### Węzeł `[485]`
Mówca: **Orso Hawker**
> ""These seem to suggest that Arcasia is behind the reformists. Their demands will only benefit Arcasia. They want us to have a weaker administration while we face all these threats.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]` (*Orso Hawker: ""This is clearly a plot against Sordland. I bet Rumburg i..."*)

### Węzeł `[486]`
Mówca: **Orso Hawker**
> ""This is clearly a plot against Sordland. I bet Rumburg is part of their plan too. It cannot be a coincidence that they are weaponizing our minorities against us around the same time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Orso Hawker: ""Now you understand the reasons for our current stance. A..."*)

### Węzeł `[487]`
**[WYBÓR GRACZA: ""Gentlemen, let's get back to the topic.""]** — Mówca: **Player**
> ""Gentlemen, let's get back to the topic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[410]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Orso Hawker: ""Well, Mr. President. Do you want to talk about how we ca..."*)

### Węzeł `[488]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[598]` (*Heron Garaci: ""Suit yourself, Mr. President. Play into the hands of Sor..."*)

### Węzeł `[489]`
**[WYBÓR GRACZA: ""I think this meeting is over.""]** — Mówca: **Player**
> ""I think this meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[414]` (Heron Garaci)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Orso Hawker: ""Even though you are aware of our national security threa..."*)

### Węzeł `[490]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[491]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true"*)
  - -> `[492]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true)"*)

### Węzeł `[491]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[492]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Autocrat_Hub_A == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Player: ""Which parts of the Constitution can we modify or suspend?""*)

### Węzeł `[493]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[494]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true"*)
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)"*)

### Węzeł `[494]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Autocrat_Hub_B == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Player: ""How can we effectively silence the opposition?""*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true"*)
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "!(BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true)"*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGameIsolated.Turn02_A_Autocrat_Hub_C == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_C"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Player: ""Can't the Assembly simply revoke it?""*)

### Węzeł `[499]`
**[WYBÓR GRACZA: ""Okay. Where do we begin?""]** — Mówca: **Player**
> ""Okay. Where do we begin?""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Orso Hawker: ""You must first justify the emergency act. We need to hav..."*)

### Węzeł `[500]`
Mówca: **Orso Hawker**
> ""There are obvious connections between the Bludish separatists and Rumburg. And the separatists have clear connections to the Worker's Party of Bludia. They should be declared a national security threat and the party should be banned.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Player: ""These Blud separatists have no place in Sordland. They w..."*)
  - -> `[504]` (*Player: ""They will be our targets.""*)
  - -> `[505]` (*Player: ""I don't want to create problems with our Bludish citizens.""*)
  - -> `[506]` (*Player: ""There is not enough evidence to connect the separatists ..."*)

### Węzeł `[501]`
Mówca: **Orso Hawker**
> ""Red Youth must also be our target. They are plotting a communist revolution in Sordland with clear funding from United Contana. And now they took to the streets after the death of Bernard Circas. There are already clashes and protests on the streets which must be dealt with before it gets out of hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Orso Hawker: ""You can also justify an action against the Young Sords. ..."*)

### Węzeł `[502]`
Mówca: **Orso Hawker**
> ""You can also justify an action against the Young Sords. After all, they started all this mess with the commies, *and* they killed a man right near the Maroon Palace. That can be considered a declaration of war against the state itself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]` (*Player: ""Red Youth must be targeted before they get too powerful ..."*)
  - -> `[483]` (*Player: ""Young Sords executed an attack near the Palace. They mus..."*)
  - -> `[510]` (*Player: ""Both organizations must be declared as national threats.""*)
  - -> `[511]` (*Player: ""I need to think about this.""*)

### Węzeł `[503]`
**[WYBÓR GRACZA: ""These Blud separatists have no place in Sordland. They will not be tolerated.""]** — Mówca: **Player**
> ""These Blud separatists have no place in Sordland. They will not be tolerated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Orso Hawker: ""Red Youth must also be our target. They are plotting a c..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA: ""They will be our targets.""]** — Mówca: **Player**
> ""They will be our targets.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Orso Hawker: ""Red Youth must also be our target. They are plotting a c..."*)

### Węzeł `[505]`
**[WYBÓR GRACZA: ""I don't want to create problems with our Bludish citizens.""]** — Mówca: **Player**
> ""I don't want to create problems with our Bludish citizens.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]` (*Orso Hawker: ""But they are already creating problems for us. Most Blud..."*)

### Węzeł `[506]`
**[WYBÓR GRACZA: ""There is not enough evidence to connect the separatists with the Worker's party.""]** — Mówca: **Player**
> ""There is not enough evidence to connect the separatists with the Worker's party.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[500]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Orso Hawker: ""Come on, Mr. President. We all know what they stand for...."*)

### Węzeł `[507]`
Mówca: **Orso Hawker**
> ""But they are already creating problems for us. Most Bluds in Bergia are either ballsy enough to show their support for the separatists or they vote for the Worker's Party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Orso Hawker: ""But let's not forget about the socialists.""*)

### Węzeł `[508]`
Mówca: **Orso Hawker**
> ""But let's not forget about the socialists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Orso Hawker: ""Red Youth must also be our target. They are plotting a c..."*)

### Węzeł `[509]`
Mówca: **Orso Hawker**
> ""Come on, Mr. President. We all know what they stand for. Bluds will be Bluds. They all want to establish their own country in Bergia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Orso Hawker: ""But let's not forget about the socialists.""*)

### Węzeł `[510]`
**[WYBÓR GRACZA: ""Both organizations must be declared as national threats.""]** — Mówca: **Player**
> ""Both organizations must be declared as national threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Orso Hawker: ""They are both enemies of the state.""*)

### Węzeł `[511]`
**[WYBÓR GRACZA: ""I need to think about this.""]** — Mówca: **Player**
> ""I need to think about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[502]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Orso Hawker: ""I don't think there is much to think.""*)

### Węzeł `[512]`
Mówca: **Orso Hawker**
> ""They are an enemy of the state. The state must react.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Orso Hawker: ""But let's talk about how we can deal with them.""*)

### Węzeł `[513]`
Mówca: **Orso Hawker**
> ""They are both enemies of the state.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Orso Hawker: ""But let's talk about how we can deal with them.""*)

### Węzeł `[514]`
Mówca: **Orso Hawker**
> ""I don't think there is much to think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Orso Hawker: ""But let's talk about how we can deal with them.""*)

### Węzeł `[515]`
Mówca: **Orso Hawker**
> ""But let's talk about how we can deal with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Orso Hawker: ""We should eliminate the threats on our streets first. Th..."*)

### Węzeł `[516]`
**[WYBÓR GRACZA: ""Sorry to interrupt, Mr. Hawker, but I won't be going ahead with this.""]** — Mówca: **Player**
> ""Sorry to interrupt, Mr. Hawker, but I won't be going ahead with this.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_A"]  and  Variable["BaseGameIsolated.Turn02_A_Autocrat_Hub_B"] == true`
- **Kontekst wejściowy (poprzednik):** `[441]` (Orso Hawker), `[465]` (Orso Hawker), `[467]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Orso Hawker: ""I thought you wanted to plan our move.""*)

### Węzeł `[517]`
Mówca: **Orso Hawker**
> ""I thought you wanted to plan our move.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Player: ""I just wanted to hear your plan. And now I've heard it.""*)
  - -> `[519]` (*Player: ""I cannot do this, Mr. Hawker.""*)
  - -> `[520]` (*Player: ""I thought I wanted to. Instead I will be proceeding with..."*)

### Węzeł `[518]`
**[WYBÓR GRACZA: ""I just wanted to hear your plan. And now I've heard it.""]** — Mówca: **Player**
> ""I just wanted to hear your plan. And now I've heard it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]` (*Orso Hawker: ""What is the meaning of this?""*)

### Węzeł `[519]`
**[WYBÓR GRACZA: ""I cannot do this, Mr. Hawker.""]** — Mówca: **Player**
> ""I cannot do this, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Orso Hawker: ""You will instead push on with your reforms then? It seem..."*)

### Węzeł `[520]`
**[WYBÓR GRACZA: ""I thought I wanted to. Instead I will be proceeding with the reforms.""]** — Mówca: **Player**
> ""I thought I wanted to. Instead I will be proceeding with the reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[517]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[523]` (*Orso Hawker: ""Is this all a joke to you?""*)

### Węzeł `[521]`
Mówca: **Orso Hawker**
> ""What is the meaning of this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Orso Hawker: ""You will instead push on with your reforms then? It seem..."*)

### Węzeł `[522]`
Mówca: **Orso Hawker**
> ""You will instead push on with your reforms then? It seems you are also part of the conspiracy, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Player: ""There is no conspiracy but yours, Mr. Hawker.""*)
  - -> `[622]` (*Player: ""I think we should end the meeting before we offend each ..."*)
  - -> `[623]` (*Player: ""I need to push the reforms, Mr. Hawker, and I will.""*)

### Węzeł `[523]`
Mówca: **Orso Hawker**
> ""Is this all a joke to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Orso Hawker: ""It seems you are also part of the conspiracy, after all.""*)

### Węzeł `[524]`
Mówca: **Orso Hawker**
> ""It seems you are also part of the conspiracy, after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[621]` (*Player: ""There is no conspiracy but yours, Mr. Hawker.""*)
  - -> `[622]` (*Player: ""I think we should end the meeting before we offend each ..."*)
  - -> `[623]` (*Player: ""I need to push the reforms, Mr. Hawker, and I will.""*)

### Węzeł `[525]`
Mówca: **Orso Hawker**
> ""We should eliminate the threats on our streets first. The police should have the authority to disperse crowds as necessary. We also have to keep the streets clean from the socialist thugs and Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]` (*Orso Hawker: ""We should give more authority to the police regarding th..."*)

### Węzeł `[526]`
Mówca: **Orso Hawker**
> ""We should give more authority to the police regarding their use of force. They should be able to stop and frisk as necessary, especially in Bludish neighbourhoods.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Player_Italic: "Nod."*)
  - -> `[529]` (*Player: ""We should suspend the right to protest and disperse the ..."*)
  - -> `[530]` (*Player: ""The police should stop and frisk based on suspicion.""*)

### Węzeł `[527]`
Mówca: **Orso Hawker**
> ""The police will also need permissions for increased surveillance against these organizations. They should be able to search properties without warrants, and wiretapping should be permissible beyond its current limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Orso Hawker: ""They will also need to be able to act swiftly. If a pers..."*)

### Węzeł `[528]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Orso Hawker: ""The police will also need permissions for increased surv..."*)

### Węzeł `[529]`
**[WYBÓR GRACZA: ""We should suspend the right to protest and disperse the crowds.""]** — Mówca: **Player**
> ""We should suspend the right to protest and disperse the crowds.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Orso Hawker: ""The police will also need permissions for increased surv..."*)

### Węzeł `[530]`
**[WYBÓR GRACZA: ""The police should stop and frisk based on suspicion.""]** — Mówca: **Player**
> ""The police should stop and frisk based on suspicion.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[526]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Orso Hawker: ""The police will also need permissions for increased surv..."*)

### Węzeł `[531]`
Mówca: **Orso Hawker**
> ""They will also need to be able to act swiftly. If a person is suspected of crimes against the national security of Sordland, the police should be able to detain them without trial. We cannot allow them proper trials anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]` (*Player_Italic: "Nod."*)
  - -> `[532]` (*Player: ""I agree.""*)
  - -> `[534]` (*Player: ""I think detention without trial is too much.""*)

### Węzeł `[532]`
**[WYBÓR GRACZA: ""I agree.""]** — Mówca: **Player**
> ""I agree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Orso Hawker: ""There are also the external threats we must face.""*)

### Węzeł `[533]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[536]` (*Orso Hawker: ""There are also the external threats we must face.""*)

### Węzeł `[534]`
**[WYBÓR GRACZA: ""I think detention without trial is too much.""]** — Mówca: **Player**
> ""I think detention without trial is too much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[531]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Orso Hawker: ""We are fighting against national security threats here. ..."*)

### Węzeł `[535]`
Mówca: **Orso Hawker**
> ""We are fighting against national security threats here. These are terrorists. We need extreme measures in extreme situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Orso Hawker: ""And there are also the external threats we must face.""*)

### Węzeł `[536]`
Mówca: **Orso Hawker**
> ""There are also the external threats we must face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Orso Hawker: ""Rumburg has acted hostile in the past and now they are a..."*)

### Węzeł `[537]`
Mówca: **Orso Hawker**
> ""And there are also the external threats we must face.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Orso Hawker: ""Rumburg has acted hostile in the past and now they are a..."*)

### Węzeł `[538]`
Mówca: **Orso Hawker**
> ""Rumburg has acted hostile in the past and now they are arming the Bluds. We must cut all ties with them. They need to be embargoed, their citizens must barred from entering Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Orso Hawker: ""We must erase all of their influence in Sordland, weaken..."*)

### Węzeł `[539]`
Mówca: **Orso Hawker**
> ""We must erase all of their influence in Sordland, weaken their trade and give them a message.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Player: ""Rumburg is our biggest enemy, we must react.""*)
  - -> `[541]` (*Player: ""We shouldn't escalate the situation with Rumburg too fast.""*)

### Węzeł `[540]`
**[WYBÓR GRACZA: ""Rumburg is our biggest enemy, we must react.""]** — Mówca: **Player**
> ""Rumburg is our biggest enemy, we must react.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[539]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Orso Hawker: ""And of course, we need to prepare our army in any case. ..."*)

### Węzeł `[541]`
**[WYBÓR GRACZA: ""We shouldn't escalate the situation with Rumburg too fast.""]** — Mówca: **Player**
> ""We shouldn't escalate the situation with Rumburg too fast.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[539]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Orso Hawker: ""They are the ones who are spitting on us! They already e..."*)

### Węzeł `[542]`
Mówca: **Orso Hawker**
> ""They are the ones who are spitting on us! They already escalated the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Orso Hawker: ""And of course, we need to prepare our army in any case. ..."*)

### Węzeł `[543]`
Mówca: **Orso Hawker**
> ""And of course, we need to prepare our army in any case. They have a very powerful military, and they seem to have plans on our soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Orso Hawker: ""Then there are the superpowers. Both are influencing our..."*)

### Węzeł `[544]`
Mówca: **Orso Hawker**
> ""Then there are the superpowers. Both are influencing our nation to be in their spheres. It seems Arcasia already bought Mr. Ricter and possibly is behind all of this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]` (*Orso Hawker: ""And United Contana is funding Sordish communists against..."*)

### Węzeł `[545]`
Mówca: **Orso Hawker**
> ""And United Contana is funding Sordish communists against our state. But we cannot bow down to the superpowers. Sordland must stand tall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player: ""We can't go against the superpowers.""*)
  - -> `[547]` (*Player: ""We will not bow to them, Mr. Hawker.""*)

### Węzeł `[546]`
**[WYBÓR GRACZA: ""We can't go against the superpowers.""]** — Mówca: **Player**
> ""We can't go against the superpowers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Orso Hawker: ""I know it is a serious issue. But their actions against ..."*)

### Węzeł `[547]`
**[WYBÓR GRACZA: ""We will not bow to them, Mr. Hawker.""]** — Mówca: **Player**
> ""We will not bow to them, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[545]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Orso Hawker: ""I know we won't. They tried to divide Sordland before, b..."*)

### Węzeł `[548]`
Mówca: **Orso Hawker**
> ""I know it is a serious issue. But their actions against our country is obvious. We simply cannot allow them to manipulate us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Player: ""I agree, but we cannot afford to sever all of our ties w..."*)
  - -> `[553]` (*Player: ""We might need one of their support against the other.""*)

### Węzeł `[549]`
Mówca: **Orso Hawker**
> ""I know we won't. They tried to divide Sordland before, but we came out stronger after the Civil War.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]` (*Player: ""We will come out of this stronger again.""*)
  - -> `[550]` (*Player: ""I salute Colonel Soll for that.""*)

### Węzeł `[550]`
**[WYBÓR GRACZA: ""I salute Colonel Soll for that.""]** — Mówca: **Player**
> ""I salute Colonel Soll for that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Orso Hawker: ""May God preserve his soul.""*)

### Węzeł `[551]`
**[WYBÓR GRACZA: ""We will come out of this stronger again.""]** — Mówca: **Player**
> ""We will come out of this stronger again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[549]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Orso Hawker: ""I do hope so, Mr. President. It will all be up to you.""*)

### Węzeł `[552]`
**[WYBÓR GRACZA: ""I agree, but we cannot afford to sever all of our ties with them.""]** — Mówca: **Player**
> ""I agree, but we cannot afford to sever all of our ties with them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Orso Hawker: ""You should think about it further.""*)

### Węzeł `[553]`
**[WYBÓR GRACZA: ""We might need one of their support against the other.""]** — Mówca: **Player**
> ""We might need one of their support against the other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[548]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Orso Hawker: ""Getting their support means becoming their pawns, Mr. Pr..."*)

### Węzeł `[554]`
Mówca: **Orso Hawker**
> ""Getting their support means becoming their pawns, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "Orso looked at the clock in the office, and then outside ..."*)

### Węzeł `[555]`
Mówca: **Orso Hawker**
> ""You should think about it further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "Orso looked at the clock in the office, and then outside ..."*)

### Węzeł `[556]`
Mówca: **Orso Hawker**
> ""May God preserve his soul.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "Orso looked at the clock in the office, and then outside ..."*)

### Węzeł `[557]`
Mówca: **Orso Hawker**
> ""I do hope so, Mr. President. It will all be up to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]` (*Narrator: "Orso looked at the clock in the office, and then outside ..."*)

### Węzeł `[558]`
Mówca: **Narrator**
> "Orso looked at the clock in the office, and then outside the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Orso Hawker: ""Mr. President, I have taken too much of your time already.""*)

### Węzeł `[559]`
Mówca: **Orso Hawker**
> ""Mr. President, I have taken too much of your time already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Orso Hawker: ""I will be reaching out again after you dissolve the refo..."*)

### Węzeł `[560]`
Mówca: **Orso Hawker**
> ""I will be reaching out again after you dissolve the reform committee and end the pursuits for reform.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Player: ""I will stop the reforms shortly. [Proceed with the deal]""*)
  - -> `[562]` (*Player: ""I cannot promise you that, Mr. Hawker. We do not have a ..."*)

### Węzeł `[561]`
**[WYBÓR GRACZA: ""I will stop the reforms shortly. [Proceed with the deal]""]** — Mówca: **Player**
> ""I will stop the reforms shortly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[639]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal = ..."*)

### Węzeł `[562]`
**[WYBÓR GRACZA: ""I cannot promise you that, Mr. Hawker. We do not have a deal. [Proceed with reforms]""]** — Mówca: **Player**
> ""I cannot promise you that, Mr. Hawker. We do not have a deal.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[560]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[640]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal = true"*)

### Węzeł `[563]`
Mówca: **Orso Hawker**
> ""Was this all a joke to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Player: ""No, Mr. Hawker. I just wanted to learn about your intent..."*)
  - -> `[565]` (*Player: ""I'm sorry, Mr. Hawker. But I won't be doing this.""*)

### Węzeł `[564]`
**[WYBÓR GRACZA: ""No, Mr. Hawker. I just wanted to learn about your intentions.""]** — Mówca: **Player**
> ""No, Mr. Hawker. I just wanted to learn about your intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Narrator: "He looked at me with anger."*)

### Węzeł `[565]`
**[WYBÓR GRACZA: ""I'm sorry, Mr. Hawker. But I won't be doing this.""]** — Mówca: **Player**
> ""I'm sorry, Mr. Hawker. But I won't be doing this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[563]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Narrator: "He looked at me with anger."*)

### Węzeł `[566]`
Mówca: **Orso Hawker**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Orso Hawker: ""Good luck with your reforms, Mr. President.""*)

### Węzeł `[567]`
Mówca: **Narrator**
> "He looked at me with anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Orso Hawker: ""I see.""*)

### Węzeł `[568]`
Mówca: **Orso Hawker**
> ""Good luck with your reforms, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[569]` (*Orso Hawker: ""You made a big mistake.""*)

### Węzeł `[569]`
Mówca: **Orso Hawker**
> ""You made a big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[570]` (*Narrator: "He quickly got off the couch and moved towards the door."*)

### Węzeł `[570]`
Mówca: **Narrator**
> "He quickly got off the couch and moved towards the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[571]` (*Player: ""Goodbye, Mr. Hawker.""*)
  - -> `[572]` (*Player: ""Don't walk out on me, Mr. Hawker.""*)

### Węzeł `[571]`
**[WYBÓR GRACZA: ""Goodbye, Mr. Hawker.""]** — Mówca: **Player**
> ""Goodbye, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Orso Hawker: ""Have a good evening.""*)

### Węzeł `[572]`
**[WYBÓR GRACZA: ""Don't walk out on me, Mr. Hawker.""]** — Mówca: **Player**
> ""Don't walk out on me, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[570]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[573]` (*Orso Hawker: ""You already did that, Mr. President.""*)

### Węzeł `[573]`
Mówca: **Orso Hawker**
> ""You already did that, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[574]` (*Orso Hawker: ""Have a good evening.""*)

### Węzeł `[574]`
Mówca: **Orso Hawker**
> ""Have a good evening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[583]` (*Narrator: "He left the room."*)

### Węzeł `[575]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[584]` (*Narrator: "After he left, I called in Lucian and explained to him ab..."*)

### Węzeł `[576]`
Mówca: **Orso Hawker**
> ""That's great to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[577]` (*Narrator: "He slowly got up from the sofa."*)

### Węzeł `[577]`
Mówca: **Narrator**
> "He slowly got up from the sofa."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[578]` (*Orso Hawker: ""It was great talking to you. And I am looking forward to..."*)

### Węzeł `[578]`
Mówca: **Orso Hawker**
> ""It was great talking to you. And I am looking forward to our cooperation, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[580]` (*Narrator: "We shook hands on our deal. This also meant that I made a..."*)

### Węzeł `[579]`
Mówca: **Orso Hawker**
> ""Have a good evening, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[581]` (*Player: ""Good evening, Mr. Hawker.""*)
  - -> `[582]` (*Player: ""Likewise.""*)

### Węzeł `[580]`
Mówca: **Narrator**
> "We shook hands on our deal. This also meant that I made an unholy alliance with the Old Guards."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[579]` (*Orso Hawker: ""Have a good evening, Mr. Rayne.""*)

### Węzeł `[581]`
**[WYBÓR GRACZA: ""Good evening, Mr. Hawker.""]** — Mówca: **Player**
> ""Good evening, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "He left the room."*)

### Węzeł `[582]`
**[WYBÓR GRACZA: ""Likewise.""]** — Mówca: **Player**
> ""Likewise.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[579]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[575]` (*Narrator: "He left the room."*)

### Węzeł `[583]`
Mówca: **Narrator**
> "He left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[584]`
Mówca: **Narrator**
> "After he left, I called in Lucian and explained to him about my decision to stop the reforms and called Petr to dissolve the committee on the next day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[585]` (*Narrator: "This was a point of no return."*)

### Węzeł `[585]`
Mówca: **Narrator**
> "This was a point of no return."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[626]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path = true"*)

### Węzeł `[586]`
Mówca: **Heron Garaci**
> ""Suit yourself, Mr. President. Play into the hands of Sordland's enemies. There will be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[587]` (*Orso Hawker: ""Mr. President clearly doesn't want to talk to us. Let's ..."*)

### Węzeł `[587]`
Mówca: **Orso Hawker**
> ""Mr. President clearly doesn't want to talk to us. Let's just give him some room before he disrespects the judiciary further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[596]` (*Heron Garaci: ""You are right.""*)

### Węzeł `[588]`
Mówca: **Narrator**
> "Orso and Heron both stood up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[589]` (*Orso Hawker: ""Please excuse us, Mr. President. Sorry to have taken up ..."*)

### Węzeł `[589]`
Mówca: **Orso Hawker**
> ""Please excuse us, Mr. President. Sorry to have taken up your valuable time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[590]` (*Player: ""Take care, gentlemen.""*)
  - -> `[591]` (*Player: ""I expect your support for the reforms. Don't make a mist..."*)
  - -> `[592]` (*Player: ""Goodbye Chief Justice.""*)

### Węzeł `[590]`
**[WYBÓR GRACZA: ""Take care, gentlemen.""]** — Mówca: **Player**
> ""Take care, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "They both left the room."*)

### Węzeł `[591]`
**[WYBÓR GRACZA: ""I expect your support for the reforms. Don't make a mistake.""]** — Mówca: **Player**
> ""I expect your support for the reforms. Don't make a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[594]` (*Narrator: "Orso laughed sarcastically."*)

### Węzeł `[592]`
**[WYBÓR GRACZA: ""Goodbye Chief Justice.""]** — Mówca: **Player**
> ""Goodbye Chief Justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[589]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "They both left the room."*)

### Węzeł `[593]`
Mówca: **Orso Hawker**
> ""But of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[595]` (*Narrator: "They both left the room."*)

### Węzeł `[594]`
Mówca: **Narrator**
> "Orso laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[593]` (*Orso Hawker: ""But of course.""*)

### Węzeł `[595]`
Mówca: **Narrator**
> "They both left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[609]` (*Węzeł Logiki Narracyjnej: "Jump to: [EarlyExit]"*)

### Węzeł `[596]`
Mówca: **Heron Garaci**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[588]` (*Narrator: "Orso and Heron both stood up from their seats."*)

### Węzeł `[597]`
Mówca: **Narrator**
> "Orso and Heron both stood up from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[603]` (*Orso Hawker: ""Please excuse us, Mr. President. Sorry to have taken you..."*)

### Węzeł `[598]`
Mówca: **Heron Garaci**
> ""Suit yourself, Mr. President. Play into the hands of Sordland's enemies. There will be-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[600]` (*Orso Hawker: ""Mr. President clearly doesn't want to talk to us. Let's ..."*)

### Węzeł `[599]`
Mówca: **Narrator**
> "They both left the room without saying anything else."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[610]` (*Węzeł Logiki Narracyjnej: "Jump to: [EarlyExit]"*)

### Węzeł `[600]`
Mówca: **Orso Hawker**
> ""Mr. President clearly doesn't want to talk to us. Let's just give him some room before he disrespects the judiciary further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[606]` (*Heron Garaci: ""You are right.""*)

### Węzeł `[601]`
Mówca: **Narrator**
> "Orso laughed sarcastically."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[604]` (*Orso Hawker: ""But of course.""*)

### Węzeł `[602]`
**[WYBÓR GRACZA: ""Goodbye Chief Justice.""]** — Mówca: **Player**
> ""Goodbye Chief Justice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[603]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "They both left the room without saying anything else."*)

### Węzeł `[603]`
Mówca: **Orso Hawker**
> ""Please excuse us, Mr. President. Sorry to have taken your valuable time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[605]` (*Player: ""Take care, gentlemen.""*)
  - -> `[607]` (*Player: ""I expect your support for the reforms. Don't make a mist..."*)
  - -> `[602]` (*Player: ""Goodbye Chief Justice.""*)

### Węzeł `[604]`
Mówca: **Orso Hawker**
> ""But of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "They both left the room without saying anything else."*)

### Węzeł `[605]`
**[WYBÓR GRACZA: ""Take care, gentlemen.""]** — Mówca: **Player**
> ""Take care, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[603]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[599]` (*Narrator: "They both left the room without saying anything else."*)

### Węzeł `[606]`
Mówca: **Heron Garaci**
> ""You are right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[597]` (*Narrator: "Orso and Heron both stood up from their seats."*)

### Węzeł `[607]`
**[WYBÓR GRACZA: ""I expect your support for the reforms. Don't make a mistake.""]** — Mówca: **Player**
> ""I expect your support for the reforms. Don't make a mistake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[603]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[601]` (*Narrator: "Orso laughed sarcastically."*)

### Węzeł `[608]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `EarlyExit`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[611]` (*Lucian Galade: ""That was not good. They clearly tried to threaten you.""*)

### Węzeł `[609]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EarlyExit]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "EarlyExit"*)

### Węzeł `[610]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [EarlyExit]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[608]` (*Węzeł Logiki Narracyjnej: "EarlyExit"*)

### Węzeł `[611]`
Mówca: **Lucian Galade**
> ""That was not good. They clearly tried to threaten you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[612]` (*Player: ""We need to take care of them.""*)
  - -> `[613]` (*Player: ""We have to make sure our reforms will pass the Court.""*)
  - -> `[614]` (*Player: ""How dare they talk to me like that?""*)
  - -> `[616]` (*Player: ""I'm not scared of them.""*)

### Węzeł `[612]`
**[WYBÓR GRACZA: ""We need to take care of them.""]** — Mówca: **Player**
> ""We need to take care of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Lucian Galade: ""Orso will be doing whatever it takes to damage you.""*)

### Węzeł `[613]`
**[WYBÓR GRACZA: ""We have to make sure our reforms will pass the Court.""]** — Mówca: **Player**
> ""We have to make sure our reforms will pass the Court.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Lucian Galade: ""Orso will be doing whatever it takes to damage you.""*)

### Węzeł `[614]`
**[WYBÓR GRACZA: ""How dare they talk to me like that?""]** — Mówca: **Player**
> ""How dare they talk to me like that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Lucian Galade: ""Orso will be doing whatever it takes to damage you.""*)

### Węzeł `[615]`
Mówca: **Lucian Galade**
> ""Orso will be doing whatever it takes to damage you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[617]` (*Lucian Galade: ""We need to be careful. There are still many Old Guard sy..."*)

### Węzeł `[616]`
**[WYBÓR GRACZA: ""I'm not scared of them.""]** — Mówca: **Player**
> ""I'm not scared of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[611]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[615]` (*Lucian Galade: ""Orso will be doing whatever it takes to damage you.""*)

### Węzeł `[617]`
Mówca: **Lucian Galade**
> ""We need to be careful. There are still many Old Guard sympathizers in our party. We can't let them divide our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[618]` (*Lucian Galade: ""And he will definitely try.""*)

### Węzeł `[618]`
Mówca: **Lucian Galade**
> ""And he will definitely try.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[619]` (*Narrator: "After a short evaluation of the situation on our hands, L..."*)

### Węzeł `[619]`
Mówca: **Narrator**
> "After a short evaluation of the situation on our hands, Lucian left me in the presidential office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[620]` (*Narrator: "It was obvious that the Old Guards would be my main rival..."*)

### Węzeł `[620]`
Mówca: **Narrator**
> "It was obvious that the Old Guards would be my main rivals in the near future."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[628]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[621]`
**[WYBÓR GRACZA: ""There is no conspiracy but yours, Mr. Hawker.""]** — Mówca: **Player**
> ""There is no conspiracy but yours, Mr. Hawker.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Orso Hawker), `[524]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Orso Hawker: ""Good God...""*)

### Węzeł `[622]`
**[WYBÓR GRACZA: ""I think we should end the meeting before we offend each other.""]** — Mówca: **Player**
> ""I think we should end the meeting before we offend each other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Orso Hawker), `[524]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Orso Hawker: ""Good God...""*)

### Węzeł `[623]`
**[WYBÓR GRACZA: ""I need to push the reforms, Mr. Hawker, and I will.""]** — Mówca: **Player**
> ""I need to push the reforms, Mr. Hawker, and I will.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[522]` (Orso Hawker), `[524]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[624]` (*Orso Hawker: ""Good God...""*)

### Węzeł `[624]`
Mówca: **Orso Hawker**
> ""Good God...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[625]` (*Orso Hawker: ""I hope Sordland's future is not bleak.""*)

### Węzeł `[625]`
Mówca: **Orso Hawker**
> ""I hope Sordland's future is not bleak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[568]` (*Orso Hawker: ""Good luck with your reforms, Mr. President.""*)

### Węzeł `[626]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[627]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_A_AutocratBriefing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_A_AutocratBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[638]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_OrsoSeenInPalace = true"*)

### Węzeł `[628]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[629]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[630]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[629]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[631]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Abandon = true"*)

### Węzeł `[630]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[632]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)

### Węzeł `[631]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Abandon = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_Abandon"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_AutocratBriefing = true"*)

### Węzeł `[632]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[633]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Intention == true"*)
  - -> `[634]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Reformist_Intention == true)"*)

### Węzeł `[633]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Reformist_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[635]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Reformist_Path = true"*)

### Węzeł `[634]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Reformist_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Reformist_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[636]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Path = true"*)

### Węzeł `[635]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Reformist_Path = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Reformist_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[636]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Path = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Dictator_Path"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[637]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_LateBriefing = true"*)

### Węzeł `[637]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_LateBriefing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_LateBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[627]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_AutocratBriefing = true"*)

### Węzeł `[638]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_OrsoSeenInPalace = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_OrsoSeenInPalace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[643]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true; ..."*)

### Węzeł `[639]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_Reform_AcceptedOrsoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[641]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_ReformCommittee = false; BaseGame.Ref..."*)

### Węzeł `[640]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Journal_Turn02_Reform_RefusedOrsoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[563]` (*Orso Hawker: ""Was this all a joke to you?""*)

### Węzeł `[641]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_ReformCommittee = false; BaseGame.Reform_Reformist_Intention = false; BaseGame.Reform_Dictator_Intention = false; BaseGame.Reform_Autocrat_Intention = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Policy_Law_ReformCommittee"] = false;
Variable["BaseGame.Reform_Reformist_Intention"] = false;
Variable["BaseGame.Reform_Dictator_Intention"] = false;
Variable["BaseGame.Reform_Autocrat_Intention"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[576]` (*Orso Hawker: ""That's great to hear.""*)

### Węzeł `[642]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[643]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true;
BaseGameSupport.News_Turn02_G_IyotakePlanMixed = true;
BaseGameSupport.News_Turn02_E_REEPotential = true;
BaseGameSupport.News_Turn02_R_GasomJobsRisk = true;
BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter = true;
BaseGameSupport.Report_Turn02_Morbel_NaturePreservation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_MangerRevealsPlan"] = true;
Variable["BaseGameSupport.News_Turn02_G_IyotakePlanMixed"] = true;
Variable["BaseGameSupport.News_Turn02_E_REEPotential"] = true;
Variable["BaseGameSupport.News_Turn02_R_GasomJobsRisk"] = true;
Variable["BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter"] = true;
Variable["BaseGameSupport.Report_Turn02_Morbel_NaturePreservation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[642]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[644]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, thank you, Lucian. You can go.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Narrator: "Lucian stood up as Orso gave him a smile. Heron paid his ..."*)

### Węzeł `[645]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Lucian isn't going anywhere. This meeting is over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[433]` (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "There was a long silence in the room."*)
