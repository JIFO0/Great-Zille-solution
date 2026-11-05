# Sordland/Prologue

- **ID konwersacji:** `277`
- **StoryPack:** `Sordland`
- **Tura:** `Prologue`
- **Lokalizacja pliku:** `Sordland/Prologue/277_Prologue.md`
- **Liczba węzłów dialogowych:** 297
- **Liczba wyborów gracza:** 137

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_Political_Socialist`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Bludish_Opinion`
- `BaseGame.Democratic`
- `BaseGame.Economy`
- `BaseGame.GovernmentBudget`
- `BaseGame.Malenyevist`
- `BaseGame.PersonalWealth`
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Prologue_EasyLife`
- `BaseGame.Prologue_Family_Important`
- `BaseGame.Prologue_HardLife`
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Prologue_MinisterOffer_Accepted`
- `BaseGame.Prologue_MinisterOffer_Rejected`
- `BaseGame.Prologue_NormalLife`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Prologue_Protest_Girl_Crushed`
- `BaseGame.Prologue_Speech_Democracy_Conservative`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Prologue_Studyplace_Deyr_History`
- `BaseGame.Prologue_Studyplace_Holsord_Law`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_1stCoup_Protested`
- `BaseGame.Prologue_University_Group_HumanRights`
- `BaseGame.Prologue_University_Group_PoliticalDebate`
- `BaseGame.Prologue_University_Group_StudentCouncil`
- `BaseGame.Prologue_University_Political_Active`
- `BaseGame.Prologue_University_Political_Nationalist`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Prologue_University_SupportWomensRights`
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[3]` | **"... a wealthy family in the city of Lachaven."** | `[6]` **Narrator**: "You opened your eyes to this wor..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] = ...`<br>`PrologueImage("pe_lachaven");` | `[7]` **Narrator**: "Your parents named you Anton. As..." |
| `[4]` | **"... a middle-income family in the city of Holsord."** | `[6]` **Narrator**: "You opened your eyes to this wor..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] =...`<br>`PrologueImage("pe_holsord");` | `[8]` **Narrator**: "Your parents named you Anton. As..." |
| `[5]` | **"... an impoverished family in the city of Deyr."** | `[6]` **Narrator**: "You opened your eyes to this wor..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] = true;`<br>`PrologueImage("pe_deyr");` | `[9]` **Narrator**: "Your parents named you Anton. As..." |
| `[6]` | **"1908\|Kingdom of Sordland"** | *Brak bezpośredniego kontekstu* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Player**: "... a wealthy family in the city..."<br>`[4]` **Player**: "... a middle-income family in th..."<br>*(oraz 1 innych odgałęzień)* |
| `[10]` | **"1923\|September 9th"** | `[79]` **Player**: "The years passed." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[11]` **Player**: "You did not fully understand."<br>`[12]` **Player**: "You were happy that you had the ..."<br>*(oraz 1 innych odgałęzień)* |
| `[11]` | **"You did not fully understand."** | `[10]` **Narrator**: "During a history class at school..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Narrator**: "Months after the Republic was pr..." |
| `[12]` | **"You were happy that you had the day off."** | `[10]` **Narrator**: "During a history class at school..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Narrator**: "Months after the Republic was pr..." |
| `[13]` | **"You were somewhat worried."** | `[10]` **Narrator**: "During a history class at school..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Narrator**: "Months after the Republic was pr..." |
| `[14]` | **"1926"** | `[291]` **Player**: "…envied those who escaped it all..."<br>`[292]` **Player**: "…saw both pain and perseverance,..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false` | *Brak zmian stanu* | `[15]` **Player**: "...Law at the Holsord State Univ..."<br>`[16]` **Player**: "...Economics at the Lachaven Bus..."<br>*(oraz 1 innych odgałęzień)* |
| `[15]` | **"...Law at the Holsord State University."** | `[14]` **Narrator**: "After graduating, you passed the..."<br>`[243]` **Narrator**: "After graduating, you passed the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] = true;` | `[19]` **Narrator**: "During the first year you attend..." |
| `[16]` | **"...Economics at the Lachaven Business School."** | `[14]` **Narrator**: "After graduating, you passed the..."<br>`[243]` **Narrator**: "After graduating, you passed the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics...` | `[18]` **Narrator**: "During the first year you attend..." |
| `[17]` | **"...History at the Deyr University of Culture."** | `[14]` **Narrator**: "After graduating, you passed the..."<br>`[243]` **Narrator**: "After graduating, you passed the..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] = t...` | `[20]` **Narrator**: "During the first year you attend..." |
| `[21]` | **"1927\|May 22nd"** | `[80]` **Player**: "Your only concern was passing th..."<br>`[150]` **Player**: "You questioned what you were bei..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_coup");` | `[22]` **Player**: "...protest with the students."<br>`[23]` **Player**: "...avoid any confrontation." |
| `[22]` | **"...protest with the students."** | `[21]` **Narrator**: "Soldiers entered the campus in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "One of the officers made a loud ..." |
| `[23]` | **"...avoid any confrontation."** | `[21]` **Narrator**: "Soldiers entered the campus in t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "You heard a loud announcement th..." |
| `[41]` | **"1927\|October 10th"** | `[129]` **Player**: "It was a gloomy year." | `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true` | `PrologueImage("pe_holsord");` | `[152]` **Player**: "...a human rights group."<br>`[151]` **Player**: "...a student council."<br>*(oraz 1 innych odgałęzień)* |
| `[42]` | **"1927\|October 10th"** | `[129]` **Player**: "It was a gloomy year." | `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true` | `PrologueImage("pe_lachaven");` | `[152]` **Player**: "...a human rights group."<br>`[151]` **Player**: "...a student council."<br>*(oraz 1 innych odgałęzień)* |
| `[43]` | **"1927\|October 10th"** | `[129]` **Player**: "It was a gloomy year." | `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true` | `PrologueImage("pe_deyr");` | `[152]` **Player**: "...a human rights group."<br>`[151]` **Player**: "...a student council."<br>*(oraz 1 innych odgałęzień)* |
| `[44]` | **"...a political debate group."** | `[41]` **Narrator**: "The arrested teachers were repla..."<br>`[42]` **Narrator**: "The majority of the students and..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Group_PoliticalDeb...` | `[55]` **Narrator**: "The dozens of debates helped you..." |
| `[47]` | **"You held your ground."** | `[45]` **Narrator**: "A student fell and was trampled ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Political_Active"]...`<br>`Variable["BaseGame.Prologue_University_1stCoup_Protested"...` | `[50]` **Narrator**: "The soldiers beat you relentlessly." |
| `[48]` | **"You tried to go out to see."** | `[46]` **Narrator**: "As you entered the room, you hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Narrator**: "But the soldiers locked the doors." |
| `[49]` | **"You ran off."** | `[45]` **Narrator**: "A student fell and was trampled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "Unlike the others, you were luck..." |
| `[52]` | **"You tried to bury yourself under the sheets."** | `[46]` **Narrator**: "As you entered the room, you hea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "But the screams echoed." |
| `[57]` | **"...join the Red Youth, the socialists."** | `[56]` **Narrator**: "The politically charged environm..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Political_Active"]...` | `[59]` **Narrator**: "The radio relayed that the commu..." |
| `[58]` | **"...join the Young Sords, the nationalists."** | `[56]` **Narrator**: "The politically charged environm..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Political_Active"]...` | `[59]` **Narrator**: "The radio relayed that the commu..." |
| `[59]` | **"1928\|June 2nd"** | `[57]` **Player**: "...join the Red Youth, the socia..."<br>`[58]` **Player**: "...join the Young Sords, the nat..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[131]` **Player**: "Sordland plunged into chaos." |
| `[65]` | **"...“United we stand, divided we fall!”"** | `[64]` **Narrator**: "Rikard's sudden attack caused ev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "You were marching against Rikard..." |
| `[66]` | **"...“Freedom, equality and solidarity!”"** | `[63]` **Narrator**: "Rikard's sudden attack caused mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "You were marching under the prot..." |
| `[68]` | **"You ran to save her."** | `[72]` **Narrator**: "There was a massive clash betwee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Narrator**: "But you couldn't reach her in ti..." |
| `[69]` | **"You warned her."** | `[72]` **Narrator**: "There was a massive clash betwee..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Narrator**: "But all your efforts were in vai..." |
| `[75]` | **"1929\|Republic of Sordland"** | `[134]` **Player**: "The chaos had to end." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_soll");` | `[158]` **Player**: "...you voted for the United Sord..."<br>`[76]` **Player**: "...you did not vote." |
| `[76]` | **"...you did not vote."** | `[75]` **Narrator**: "The charismatic Colonel, Tarquin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "USP won the election by a large ..." |
| `[77]` | **"1929\|June"** | `[76]` **Player**: "...you did not vote."<br>`[158]` **Player**: "...you voted for the United Sord..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Player**: "It was time to serve your nation..." |
| `[78]` | **"1930\|February\|Bergia Region"** | `[180]` **Player**: "It was time to serve your nation..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_outpost");` | `[82]` **Player**: "You could see your breath." |
| `[79]` | **"The years passed."** | `[7]` **Narrator**: "Your parents named you Anton. As..."<br>`[8]` **Narrator**: "Your parents named you Anton. As..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Narrator**: "During a history class at school..." |
| `[80]` | **"Your only concern was passing the exams."** | `[18]` **Narrator**: "During the first year you attend..."<br>`[19]` **Narrator**: "During the first year you attend..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "Soldiers entered the campus in t..." |
| `[81]` | **"You did exactly as they said."** | `[31]` **Narrator**: "You heard a loud announcement th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "As you entered the room, you hea..." |
| `[82]` | **"You could see your breath."** | `[78]` **Narrator**: "The devastating civil war from n..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "After several hours of marching ..." |
| `[84]` | **"...let them slip through."** | `[83]` **Narrator**: "After several hours of marching ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[185]` **Narrator**: "After the patrol, Major Lancea a..." |
| `[85]` | **"...escorted them back."** | `[83]` **Narrator**: "After several hours of marching ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Narrator**: "The refugees were in despair whe..." |
| `[93]` | **"...your duties ended and you went back to civilian life."** | `[86]` **Narrator**: "The refugees were in despair whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[94]` **Narrator**: "You and Monica decided to share ..." |
| `[94]` | **"1931\|July\|Holsord"** | `[93]` **Player**: "...your duties ended and you wen..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_wedding");` | `[160]` **Player**: "Working for the ruling party was..."<br>`[159]` **Player**: "The financial compensation was t..."<br>*(oraz 1 innych odgałęzień)* |
| `[98]` | **"It was the best opportunity to change the country for the better."** | `[94]` **Narrator**: "You and Monica decided to share ..."<br>`[197]` **Narrator**: "You and Monica decided to share ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "You became the legal assistant t..."<br>`[96]` **Narrator**: "You became the economics assista..."<br>*(oraz 1 innych odgałęzień)* |
| `[99]` | **"1933\|September"** | `[100]` **Player**: "You were climbing the ladder." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[101]` **Player**: "President Tarquin Soll was elect..." |
| `[100]` | **"You were climbing the ladder."** | `[95]` **Narrator**: "You became the legal assistant t..."<br>`[96]` **Narrator**: "You became the economics assista..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "Tarquin Soll gave amnesty to the..." |
| `[101]` | **"President Tarquin Soll was elected once more."** | `[99]` **Narrator**: "Tarquin Soll gave amnesty to the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "The ongoing legal battle between..."<br>`[217]` **Narrator**: "The new five-year plan and the s..."<br>*(oraz 1 innych odgałęzień)* |
| `[102]` | **"1945\|October\|Time of Change"** | `[199]` **Player**: "The cracks began to show." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[164]` **Player**: "...watched from the sidelines."<br>`[163]` **Player**: "...kept supporting the president."<br>*(oraz 1 innych odgałęzień)* |
| `[103]` | **"...joined the internal opposition."** | `[102]` **Narrator**: "President Soll barely secured a ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[165]` **Narrator**: "You gave your support to Ewald A..." |
| `[113]` | **"You accepted."** | `[110]` **Narrator**: "The president offered you the po..."<br>`[111]` **Narrator**: "The president offered you the po..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_MinisterOffer_Accepted"] = true;` | `[114]` **Narrator**: "The congress was nothing short o..." |
| `[114]` | **"1946\|August"** | `[167]` **Player**: "But he didn't approach you."<br>`[113]` **Player**: "You accepted."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_congress");` | `[117]` **Player**: "You voted for Tarquin Soll."<br>`[115]` **Player**: "You voted for Ewald Alphonso." |
| `[115]` | **"You voted for Ewald Alphonso."** | `[114]` **Narrator**: "The congress was nothing short o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Party_Congress_Soll"] = false;` | `[116]` **Narrator**: "The efforts bore fruit as the co..." |
| `[116]` | **"1946\|September 1st"** | `[115]` **Player**: "You voted for Ewald Alphonso." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[171]` **Player**: "...were happy that Soll was fina..."<br>`[170]` **Player**: "...were troubled by the departur..."<br>*(oraz 1 innych odgałęzień)* |
| `[117]` | **"You voted for Tarquin Soll."** | `[114]` **Narrator**: "The congress was nothing short o..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Party_Congress_Soll"] = true;` | `[169]` **Narrator**: "Unfortunately, Tarquin Soll lost..." |
| `[118]` | **"You rejected."** | `[110]` **Narrator**: "The president offered you the po..."<br>`[111]` **Narrator**: "The president offered you the po..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_MinisterOffer_Rejected"] = true;` | `[114]` **Narrator**: "The congress was nothing short o..." |
| `[121]` | **"...didn't care about who was in charge."** | `[116]` **Narrator**: "The efforts bore fruit as the co..."<br>`[169]` **Narrator**: "Unfortunately, Tarquin Soll lost..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "A month later, your daughter was..." |
| `[122]` | **"1949"** | `[138]` **Player**: "...did your best not to help him."<br>`[172]` **Player**: "...joined the party effort and c..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_flag");` | `[174]` **Player**: "...did your best in order to mak..."<br>`[173]` **Player**: "...tried all that was necessary ..."<br>*(oraz 1 innych odgałęzień)* |
| `[123]` | **"1951\|Summer\|A New Sordland"** | `[139]` **Player**: "...dedicated yourself to the par..."<br>`[173]` **Player**: "...tried all that was necessary ..."<br>*(oraz 1 innych węzłów)* | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | `AdvanceTimeline();` | `[175]` **Player**: "...thought that your party could..."<br>`[182]` **Player**: "...were worried about the econom..."<br>*(oraz 1 innych odgałęzień)* |
| `[124]` | **"1952\|October\|Rise of Rayne"** | `[127]` **Player**: "...worried that your reputation ..."<br>`[175]` **Player**: "...thought that your party could..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Player**: "...blamed Alphonso for the crisi..."<br>`[146]` **Player**: "...bribed and extorted Alphonso'..."<br>*(oraz 1 innych odgałęzień)* |
| `[125]` | **"...advised Alphonso to step down."** | `[124]` **Narrator**: "With Petr's help, your presence ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] =...` | `[126]` **Narrator**: "He listened to your advice.   Al..." |
| `[126]` | **"1953\|March"** | `[125]` **Player**: "...advised Alphonso to step down." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_speech");` | `[128]` **Player**: "It was your turn." |
| `[127]` | **"...worried that your reputation would be tarnished along with Alphonso."** | `[123]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[247]` **Narrator**: "The Presidency of Alphonso saw m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "With Petr's help, your presence ..." |
| `[128]` | **"It was your turn."** | `[126]` **Narrator**: "He listened to your advice.   Al..."<br>`[186]` **Narrator**: "Most of the inner circle abandon..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "After visiting every city and to..." |
| `[129]` | **"It was a gloomy year."** | `[50]` **Narrator**: "The soldiers beat you relentlessly."<br>`[51]` **Narrator**: "Unlike the others, you were luck..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Narrator**: "The arrested teachers were repla..."<br>`[42]` **Narrator**: "The majority of the students and..."<br>*(oraz 1 innych odgałęzień)* |
| `[130]` | **"...her diligence."** | `[55]` **Narrator**: "The dozens of debates helped you..."<br>`[176]` **Narrator**: "The council was focused on incre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Narrator**: "She mentioned to you that she wa..." |
| `[131]` | **"Sordland plunged into chaos."** | `[59]` **Narrator**: "The radio relayed that the commu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Rikard's sudden attack caused mo..."<br>`[64]` **Narrator**: "Rikard's sudden attack caused ev..." |
| `[132]` | **"You stayed."** | `[67]` **Narrator**: "You were marching under the prot..."<br>`[70]` **Narrator**: "You were marching against Rikard..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Narrator**: "There was a massive clash betwee..." |
| `[133]` | **"You never forgot her face."** | `[71]` **Narrator**: "But you couldn't reach her in ti..."<br>`[73]` **Narrator**: "But all your efforts were in vai..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] = true;` | `[74]` **Narrator**: "The clashes escalated into a ful..." |
| `[134]` | **"The chaos had to end."** | `[74]` **Narrator**: "The clashes escalated into a ful..."<br>`[179]` **Narrator**: "The clashes escalated into a ful..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Narrator**: "The charismatic Colonel, Tarquin..." |
| `[135]` | **"1946\|July"** | `[163]` **Player**: "...kept supporting the president." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[136]` **Player**: "You had a meeting with him." |
| `[136]` | **"You had a meeting with him."** | `[135]` **Narrator**: "The contender for party leadersh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "The president offered you the po..."<br>`[111]` **Narrator**: "The president offered you the po..."<br>*(oraz 1 innych odgałęzień)* |
| `[137]` | **"1946\|October 15th\|Uncertain Years"** | `[121]` **Player**: "...didn't care about who was in ..."<br>`[170]` **Player**: "...were troubled by the departur..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_baby");` | `[172]` **Player**: "...joined the party effort and c..."<br>`[138]` **Player**: "...did your best not to help him." |
| `[138]` | **"...did your best not to help him."** | `[137]` **Narrator**: "A month later, your daughter was..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[122]` **Narrator**: "During the general elections, th..." |
| `[139]` | **"...dedicated yourself to the party and its success."** | `[122]` **Narrator**: "During the general elections, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[123]` **Narrator**: "The Presidency of Alphonso saw m..." |
| `[140]` | **"1953\|October\|Election Campaign"** | `[128]` **Player**: "It was your turn." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[142]` **Player**: "...enact democratic reforms."<br>`[141]` **Player**: "...preserve national values." |
| `[141]` | **"...preserve national values."** | `[140]` **Narrator**: "After visiting every city and to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Speech_Democracy_Conservative...` | `[205]` **Narrator**: "“Great nation of Sordland! Due t..." |
| `[142]` | **"...enact democratic reforms."** | `[140]` **Narrator**: "After visiting every city and to..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] = ...` | `[143]` **Narrator**: "“The people are tired of empty p..." |
| `[146]` | **"...bribed and extorted Alphonso's inner circle."** | `[124]` **Narrator**: "With Petr's help, your presence ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] = t...` | `[186]` **Narrator**: "Most of the inner circle abandon..." |
| `[147]` | **"The broadcast ended."** | `[143]` **Narrator**: "“The people are tired of empty p..."<br>`[205]` **Narrator**: "“Great nation of Sordland! Due t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Narrator**: "On election day, millions went o..." |
| `[148]` | **"1953\|November 5th"** | `[147]` **Player**: "The broadcast ended." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_vote");` | `[183]` **Player**: "It was time to face the truth." |
| `[149]` | **"...blamed Alphonso for the crisis on television."** | `[124]` **Narrator**: "With Petr's help, your presence ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame....`<br>`Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] ...` | `[187]` **Narrator**: "The media backlash prompted Pres..." |
| `[150]` | **"You questioned what you were being taught."** | `[18]` **Narrator**: "During the first year you attend..."<br>`[19]` **Narrator**: "During the first year you attend..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "Soldiers entered the campus in t..." |
| `[151]` | **"...a student council."** | `[41]` **Narrator**: "The arrested teachers were repla..."<br>`[42]` **Narrator**: "The majority of the students and..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Group_StudentCounc...` | `[176]` **Narrator**: "The council was focused on incre..." |
| `[152]` | **"...a human rights group."** | `[41]` **Narrator**: "The arrested teachers were repla..."<br>`[42]` **Narrator**: "The majority of the students and..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Group_HumanRights"...` | `[177]` **Narrator**: "The group heavily protested agai..." |
| `[153]` | **"...“End the chaos! We want stability!”"** | `[64]` **Narrator**: "Rikard's sudden attack caused ev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "You were marching against Rikard..." |
| `[154]` | **"...“Workers of the world, unite!”"** | `[63]` **Narrator**: "Rikard's sudden attack caused mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "You were marching under the prot..." |
| `[155]` | **"...“Bring down the nationalists!”"** | `[63]` **Narrator**: "Rikard's sudden attack caused mo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Narrator**: "You were marching under the prot..." |
| `[156]` | **"...“One nation, one system, one people!”"** | `[64]` **Narrator**: "Rikard's sudden attack caused ev..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "You were marching against Rikard..." |
| `[157]` | **"You left."** | `[67]` **Narrator**: "You were marching under the prot..."<br>`[70]` **Narrator**: "You were marching against Rikard..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "The clashes escalated into a ful..." |
| `[158]` | **"...you voted for the United Sordland Party."** | `[75]` **Narrator**: "The charismatic Colonel, Tarquin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[77]` **Narrator**: "USP won the election by a large ..." |
| `[159]` | **"The financial compensation was too great to pass up."** | `[94]` **Narrator**: "You and Monica decided to share ..."<br>`[197]` **Narrator**: "You and Monica decided to share ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "You became the legal assistant t..."<br>`[96]` **Narrator**: "You became the economics assista..."<br>*(oraz 1 innych odgałęzień)* |
| `[160]` | **"Working for the ruling party was the easiest path to power."** | `[94]` **Narrator**: "You and Monica decided to share ..."<br>`[197]` **Narrator**: "You and Monica decided to share ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Narrator**: "You became the legal assistant t..."<br>`[96]` **Narrator**: "You became the economics assista..."<br>*(oraz 1 innych odgałęzień)* |
| `[161]` | **"You accepted with doubts."** | `[208]` **Narrator**: "The preparation of a comprehensi..."<br>`[217]` **Narrator**: "The new five-year plan and the s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Narrator**: "As the youngest MP, it was diffi..." |
| `[162]` | **"You accepted right away."** | `[208]` **Narrator**: "The preparation of a comprehensi..."<br>`[217]` **Narrator**: "The new five-year plan and the s..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[207]` **Narrator**: "As the youngest MP, it was diffi..." |
| `[163]` | **"...kept supporting the president."** | `[102]` **Narrator**: "President Soll barely secured a ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...` | `[135]` **Narrator**: "The contender for party leadersh..." |
| `[164]` | **"...watched from the sidelines."** | `[102]` **Narrator**: "President Soll barely secured a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[166]` **Narrator**: "The contender for party leadersh..." |
| `[165]` | **"1946\|July"** | `[103]` **Player**: "...joined the internal opposition." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_politicians");` | `[167]` **Player**: "But he didn't approach you." |
| `[166]` | **"1946\|July"** | `[164]` **Player**: "...watched from the sidelines." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[168]` **Player**: "He approached you too." |
| `[167]` | **"But he didn't approach you."** | `[165]` **Narrator**: "You gave your support to Ewald A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Narrator**: "The congress was nothing short o..." |
| `[168]` | **"He approached you too."** | `[166]` **Narrator**: "The contender for party leadersh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Narrator**: "The president offered you the po..."<br>`[111]` **Narrator**: "The president offered you the po..."<br>*(oraz 1 innych odgałęzień)* |
| `[169]` | **"1946\|September 1st"** | `[117]` **Player**: "You voted for Tarquin Soll." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[171]` **Player**: "...were happy that Soll was fina..."<br>`[170]` **Player**: "...were troubled by the departur..."<br>*(oraz 1 innych odgałęzień)* |
| `[170]` | **"...were troubled by the departure of Soll."** | `[116]` **Narrator**: "The efforts bore fruit as the co..."<br>`[169]` **Narrator**: "Unfortunately, Tarquin Soll lost..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "A month later, your daughter was..." |
| `[171]` | **"...were happy that Soll was finally leaving."** | `[116]` **Narrator**: "The efforts bore fruit as the co..."<br>`[169]` **Narrator**: "Unfortunately, Tarquin Soll lost..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "A month later, your daughter was..." |
| `[172]` | **"...joined the party effort and campaigned for him."** | `[137]` **Narrator**: "A month later, your daughter was..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"]...` | `[122]` **Narrator**: "During the general elections, th..." |
| `[173]` | **"...tried all that was necessary to climb up the ladder."** | `[122]` **Narrator**: "During the general elections, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[123]` **Narrator**: "The Presidency of Alphonso saw m..." |
| `[174]` | **"...did your best in order to make Sordland a better place."** | `[122]` **Narrator**: "During the general elections, th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[123]` **Narrator**: "The Presidency of Alphonso saw m..." |
| `[175]` | **"...thought that your party could not survive another crisis."** | `[123]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[247]` **Narrator**: "The Presidency of Alphonso saw m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "With Petr's help, your presence ..." |
| `[178]` | **"...her beauty."** | `[55]` **Narrator**: "The dozens of debates helped you..."<br>`[176]` **Narrator**: "The council was focused on incre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Narrator**: "She mentioned to you that she wa..." |
| `[180]` | **"It was time to serve your national duty."** | `[77]` **Narrator**: "USP won the election by a large ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "The devastating civil war from n..." |
| `[181]` | **"You agreed in principle."** | `[18]` **Narrator**: "During the first year you attend..."<br>`[19]` **Narrator**: "During the first year you attend..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "Soldiers entered the campus in t..." |
| `[182]` | **"...were worried about the economic recession."** | `[123]` **Narrator**: "The Presidency of Alphonso saw m..."<br>`[247]` **Narrator**: "The Presidency of Alphonso saw m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Narrator**: "With Petr's help, your presence ..." |
| `[183]` | **"It was time to face the truth."** | `[148]` **Narrator**: "On election day, millions went o..." | *Brak (Dostępna bezwarunkowo)* | `UnlockAchievement("Prologue_Finish");`<br>`PlayMusic("MainTheme");`<br>*(+2 skryptów)* | `[2]` **System**: "[KONIEC SCENY / WYJŚCIE]" |
| `[184]` | **"Suddenly the soldiers charged."** | `[30]` **Narrator**: "One of the officers made a loud ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Narrator**: "A student fell and was trampled ..." |
| `[186]` | **"1953\|March"** | `[146]` **Player**: "...bribed and extorted Alphonso'..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_speech");` | `[128]` **Player**: "It was your turn." |
| `[187]` | **"1953\|March"** | `[149]` **Player**: "...blamed Alphonso for the crisi..." | `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false` | `AdvanceTimeline(); PrologueImage("pe_speech");` | `[128]` **Player**: "It was your turn." |
| `[188]` | **"...her intelligence."** | `[55]` **Narrator**: "The dozens of debates helped you..."<br>`[176]` **Narrator**: "The council was focused on incre..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Narrator**: "She mentioned to you that she wa..." |
| `[196]` | **"...your duties ended and you went back to civilian life."** | `[185]` **Narrator**: "After the patrol, Major Lancea a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Narrator**: "You and Monica decided to share ..." |
| `[197]` | **"1931\|July\|Holsord"** | `[196]` **Player**: "...your duties ended and you wen..." | *Brak (Dostępna bezwarunkowo)* | `PrologueImage("pe_wedding");` | `[160]` **Player**: "Working for the ruling party was..."<br>`[159]` **Player**: "The financial compensation was t..."<br>*(oraz 1 innych odgałęzień)* |
| `[198]` | **"1941\|October"** | `[209]` **Player**: "...sacrificed work to spend time..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_innercircle");` | `[199]` **Player**: "The cracks began to show." |
| `[199]` | **"The cracks began to show."** | `[198]` **Narrator**: "During your absence, Petr Vecter..."<br>`[220]` **Narrator**: "Just like your father once did, ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Narrator**: "President Soll barely secured a ..." |
| `[200]` | **"...stay away from any political organization."** | `[56]` **Narrator**: "The politically charged environm..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_Political_Active"]...` | `[201]` **Narrator**: "The radio relayed that the commu..." |
| `[201]` | **"1928\|June 2nd"** | `[200]` **Player**: "...stay away from any political ..." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline();` | `[202]` **Player**: "Sordland plunged into chaos." |
| `[202]` | **"Sordland plunged into chaos."** | `[201]` **Narrator**: "The radio relayed that the commu..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[179]` **Narrator**: "The clashes escalated into a ful..." |
| `[207]` | **"1938\|June\|Rising Career"** | `[161]` **Player**: "You accepted with doubts."<br>`[162]` **Player**: "You accepted right away." | *Brak (Dostępna bezwarunkowo)* | `AdvanceTimeline(); PrologueImage("pe_baby");` | `[209]` **Player**: "...sacrificed work to spend time..."<br>`[213]` **Player**: "...sacrificed family time to imp..." |
| `[208]` | **"1934\|April 2nd"** | `[101]` **Player**: "President Tarquin Soll was elect..." | `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`<br>`(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false` | `PrologueImage("pe_meeting");` | `[162]` **Player**: "You accepted right away."<br>`[161]` **Player**: "You accepted with doubts." |
| `[209]` | **"...sacrificed work to spend time with your family."** | `[207]` **Narrator**: "As the youngest MP, it was diffi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_Family_Important"] = true;` | `[198]` **Narrator**: "During your absence, Petr Vecter..." |
| `[213]` | **"...sacrificed family time to improve your position in the party."** | `[207]` **Narrator**: "As the youngest MP, it was diffi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Narrator**: "Just like your father once did, ..."<br>`[226]` **Narrator**: "Along with Petr Vectern, you did..." |
| `[217]` | **"1934\|April 2nd"** | `[101]` **Player**: "President Tarquin Soll was elect..." | `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`<br>`(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false` | `PrologueImage("pe_meeting");` | `[162]` **Player**: "You accepted right away."<br>`[161]` **Player**: "You accepted with doubts." |
| `[218]` | **"1934\|April 2nd"** | `[101]` **Player**: "President Tarquin Soll was elect..." | `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true` | `PrologueImage("pe_meeting");` | `[162]` **Player**: "You accepted right away."<br>`[161]` **Player**: "You accepted with doubts." |
| `[220]` | **"1941\|October"** | `[213]` **Player**: "...sacrificed family time to imp..." | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true` | `AdvanceTimeline(); PrologueImage("pe_innercircle");` | `[199]` **Player**: "The cracks began to show." |
| `[226]` | **"1941\|October"** | `[213]` **Player**: "...sacrificed family time to imp..." | `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false` | `AdvanceTimeline(); PrologueImage("pe_innercircle");` | `[199]` **Player**: "The cracks began to show." |
| `[243]` | **"1926"** | `[291]` **Player**: "…envied those who escaped it all..."<br>`[292]` **Player**: "…saw both pain and perseverance,..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true` | *Brak zmian stanu* | `[15]` **Player**: "...Law at the Holsord State Univ..."<br>`[16]` **Player**: "...Economics at the Lachaven Bus..."<br>*(oraz 1 innych odgałęzień)* |
| `[247]` | **"1951\|Summer\|A New Sordland"** | `[139]` **Player**: "...dedicated yourself to the par..."<br>`[173]` **Player**: "...tried all that was necessary ..."<br>*(oraz 1 innych węzłów)* | `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true` | `AdvanceTimeline();` | `[175]` **Player**: "...thought that your party could..."<br>`[182]` **Player**: "...were worried about the econom..."<br>*(oraz 1 innych odgałęzień)* |
| `[286]` | **"...told her you wholeheartedly supported her cause."** | `[285]` **Narrator**: "She mentioned to you that she wa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_University_SupportWomensRight...` | `[56]` **Narrator**: "The politically charged environm..." |
| `[287]` | **"...weren't particularly interested in women's rights, but asked her to dinner none..."** | `[285]` **Narrator**: "She mentioned to you that she wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[56]` **Narrator**: "The politically charged environm..." |
| `[291]` | **"…envied those who escaped it all, and wished for an easier path. [Easier Resources]"** | `[290]` **Narrator**: "Months after the Republic was pr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_EasyLife"] = true; Variable["...` | `[243]` **Narrator**: "After graduating, you passed the..."<br>`[14]` **Narrator**: "After graduating, you passed the..." |
| `[292]` | **"…saw both pain and perseverance, and sought balance between the two."** | `[290]` **Narrator**: "Months after the Republic was pr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_NormalLife"] = true; ;` | `[243]` **Narrator**: "After graduating, you passed the..."<br>`[14]` **Narrator**: "After graduating, you passed the..." |
| `[293]` | **"…felt the weight they carried and chose to shoulder even more. [Harder Resources]"** | `[290]` **Narrator**: "Months after the Republic was pr..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Prologue_HardLife"] = true; Variable["...` | `[243]` **Narrator**: "After graduating, you passed the..."<br>`[14]` **Narrator**: "After graduating, you passed the..." |

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
  - -> `[283]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("In the Prologue", "", "");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... a wealthy family in the city of Lachaven."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich = true"*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... a middle-income family in the city of Holsord."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle = true"*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "... an impoverished family in the city of Deyr."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor = true"*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "1908|Kingdom of Sordland"]** — Mówca: **Narrator**
> "You opened your eyes to this world. 

You came from..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Player: "... a wealthy family in the city of Lachaven."*)
  - -> `[4]` (*Player: "... a middle-income family in the city of Holsord."*)
  - -> `[5]` (*Player: "... an impoverished family in the city of Deyr."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a successful businessman, you had the chance to grow up in a wealthy family.

Life was easy at first and you had the best education money could afford. 

However, things inside the Rayne family changed due to the absence of your father. This affected your mother and you negatively."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 3; BaseGame.Public_Opinion -= ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a diligent civil servant, you lived quite an ordinary childhood.

Life was not bad. You were lucky enough to attend a well-known public school.

But frequent fights broke out at the Rayne family home, which made you feel uneasy."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 2; BaseGame.Public_Opinion += 1;"*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Your parents named you Anton. As the only child of a farmer, you spent your childhood among wheat fields.

Life was not easy. You were too poor to afford a good education.

The Rayne family was caring regardless of the economically dire situation. Your parents always did their best to support you."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGame.PersonalWealth += 1; BaseGame.Public_Opinion += ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "1923|September 9th"]** — Mówca: **Narrator**
> "During a history class at school, the bell started to ring unexpectedly. You heard a loud commotion outside.

As everyone tried to figure out what was going on, the principal announced the historic revolution. 

The Kingdom was no more. The Republic of Sordland was born."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[79]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did not fully understand."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Months after the Republic was proclaimed, life around you..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were happy that you had the day off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Months after the Republic was proclaimed, life around you..."*)

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were somewhat worried."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[10]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Narrator: "Months after the Republic was proclaimed, life around you..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "1926"]** — Mówca: **Narrator**
> "After graduating, you passed the university exam with high marks.

You had the opportunity to choose between several studies. You chose..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[291]` (Player), `[292]` (Player), `[293]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "...Law at the Holsord State University."*)
  - -> `[16]` (*Player: "...Economics at the Lachaven Business School."*)
  - -> `[17]` (*Player: "...History at the Deyr University of Culture."*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...Law at the Holsord State University."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law = true"*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...Economics at the Lachaven Business School."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics = true"*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...History at the Deyr University of Culture."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Narrator), `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History = true"*)

### Węzeł `[18]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained why a market economy is the better option for Sordland.

He argued for a system where prices for goods and services are determined by the open market."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_university");"*)

### Węzeł `[19]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained how the Supreme Court is obstructing justice in Sordland. 

He stated that laws should be applied fairly, and that even the members of the Supreme Court, are subject to the same laws."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_university");"*)

### Węzeł `[20]`
Mówca: **Narrator**
> "During the first year you attended a lecture with Deivid Wisci. He was a well-known diplomat from the Foreign Ministry and the son of the President.

After observing the hall in silence, he explained why Realpolitik is important for a successful foreign policy.

He argued that a strategy based on practical and material factors would be much more successful in reaching Sordland's ambitions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_university");"*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "1927|May 22nd"]** — Mówca: **Narrator**
> "Soldiers entered the campus in the evening ahead of the first election.

Many were in shock as the uniformed men created a security cordon and started arresting the teachers. 

A group of students started gathering in protest. Along with your best friend Petr Vectern, you decided to..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Player), `[150]` (Player), `[181]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_coup");"*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...protest with the students."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "One of the officers made a loud announcement that echoed ..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...avoid any confrontation."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "You heard a loud announcement that echoed through the cam..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_lachaven");"*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_deyr");"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Narrator: "During the first year you attended a lecture with Deivid ..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "During the first year you attended a lecture with Deivid ..."*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Narrator: "During the first year you attended a lecture with Deivid ..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "One of the officers made a loud announcement that echoed through the campus.

“General Luderin declared martial law in order to restore the administration. Please stand back and disperse to your rooms.”

You joined the students that slowly marched towards the large group of soldiers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Player: "Suddenly the soldiers charged."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "You heard a loud announcement that echoed through the campus.

“General Luderin declared martial law in order to restore the administration. Please stand back and disperse to your rooms.”

You quickly made your way towards the dormitory, avoiding the scene."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: "You did exactly as they said."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Deyr_History == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Deyr_History == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "1927|October 10th"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Deyr_History == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "1927|October 10th"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "1927|October 10th"*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[41]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The arrested teachers were replaced by those that promoted conformism to the state.

Holsord turned a blind eye to the things that were happening.

You didn't want to stay idle and decided to join..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_holsord");"*)

### Węzeł `[42]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The majority of the students and teachers displayed their opposition.

Thus, Lachaven became a target for the military regime.

You didn't want to stay idle and decided to join..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_lachaven");"*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "1927|October 10th"]** — Mówca: **Narrator**
> "The coup split the students into two groups and caused frequent fights. 

Torture and imprisonment of any opposing voice became a daily routine in Deyr.

You didn't want to stay idle and decided to join..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Deyr_History"] == true`
- **Kontekst wejściowy (poprzednik):** `[129]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_deyr");"*)

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a political debate group."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[42]` (Narrator), `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_PoliticalDebate = true"*)

### Węzeł `[45]`
Mówca: **Narrator**
> "A student fell and was trampled as everybody started running away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Player: "You held your ground."*)
  - -> `[49]` (*Player: "You ran off."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "As you entered the room, you heard screams coming from the outside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player: "You tried to bury yourself under the sheets."*)
  - -> `[48]` (*Player: "You tried to go out to see."*)

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You held your ground."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active = true"*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to go out to see."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "But the soldiers locked the doors."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ran off."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "Unlike the others, you were lucky to escape."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The soldiers beat you relentlessly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "It was a gloomy year."*)

### Węzeł `[51]`
Mówca: **Narrator**
> "Unlike the others, you were lucky to escape."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "It was a gloomy year."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You tried to bury yourself under the sheets."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[46]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "But the screams echoed."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "But the screams echoed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "It was a gloomy year."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "But the soldiers locked the doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: "It was a gloomy year."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "The dozens of debates helped you hone your oratory skills while also helping you grow your network.

Even though the discussions between different groups often became heated, you all grew from sharing ideas.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "...her intelligence."*)
  - -> `[178]` (*Player: "...her beauty."*)
  - -> `[130]` (*Player: "...her diligence."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "The politically charged environment led you to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "...join the Red Youth, the socialists."*)
  - -> `[58]` (*Player: "...join the Young Sords, the nationalists."*)
  - -> `[200]` (*Player: "...stay away from any political organization."*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...join the Red Youth, the socialists."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active = true; Bas..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...join the Young Sords, the nationalists."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active = true; Bas..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "1928|June 2nd"]** — Mówca: **Narrator**
> "The radio relayed that the communist general Rikard surrounded Luderin and his troops, demanding their surrender.

They refused and heavy fighting broke out across the country. 

You just couldn't believe it. The army was fighting amongst themselves."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Player), `[58]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Rikard's sudden attack caused more instability in the cou..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Narrator: "Rikard's sudden attack caused even more bloodshed in the ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Rikard's sudden attack caused more instability in the country. 

But compared to nationalist Luderin, he was a real socialist.

This convinced you to participate in a support march. You were chanting..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_protest");"*)

### Węzeł `[64]`
Mówca: **Narrator**
> "Rikard's sudden attack caused even more bloodshed in the country. 

He seemed different compared to nationalist Luderin. In your opinion however, he was more of the same. 

So you participated in a protest march. You were chanting..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_protest");"*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“United we stand, divided we fall!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "You were marching against Rikard.  The students and soldi..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Freedom, equality and solidarity!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "You were marching under the protection of Rikard's soldie..."*)

### Węzeł `[67]`
Mówca: **Narrator**
> "You were marching under the protection of Rikard's soldiers.

The students supporting Luderin's coup gathered a few hundred meters in front of you. 

Many nationalists were among them. You knew something was going to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "You stayed."*)
  - -> `[157]` (*Player: "You left."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You ran to save her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "But you couldn't reach her in time..."*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You warned her."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "But all your efforts were in vain..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "You were marching against Rikard.

The students and soldiers against Luderin's coup gathered a few hundred meters away.

Many socialists were among them. You knew something was going to happen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Player: "You stayed."*)
  - -> `[157]` (*Player: "You left."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "But you couldn't reach her in time..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "You never forgot her face."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "There was a massive clash between the two sides. Soldiers began to beat the students.

Tanks started rolling forward. 

In this chaotic moment, you saw a young girl about to get run over by a tank."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_coup2");"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "But all your efforts were in vain..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "You never forgot her face."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "The clashes escalated into a full blown civil war. The horrors made you isolate yourself for a while.

Monica helped you cope and love grew between the two of you.

However, it was a difficult time for love."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "The chaos had to end."*)

### Węzeł `[75]`
**[WYBÓR GRACZA: "1929|Republic of Sordland"]** — Mówca: **Narrator**
> "The charismatic Colonel, Tarquin Soll, orchestrated a sudden attack on the capital where the Luderinist and Rikardist forces were battling each other. He defeated both, ending the war.

A new constitution was written, and the military government began efforts to restore stability. Many people saw the Colonel as a savior. 

He formed the United Sordland Party and ran as a presidential candidate. In the first-ever single-party elections..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[134]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_soll");"*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...you did not vote."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "1929|June"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "1929|June"]** — Mówca: **Narrator**
> "USP won the election by a large majority. The military government announced a four-year restoration period to transform to an entirely civilian government.

After graduation, you kept seeing Monica. You were both interested in marrying and starting a family.

However, a letter arrived from the military, calling you to fulfill your compulsory service."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Player), `[158]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player: "It was time to serve your national duty."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "1930|February|Bergia Region"]** — Mówca: **Narrator**
> "The devastating civil war from neighboring Wehlen quickly turned into a proxy war between regional and world powers.

The distinguished major, Iosef Lancea, ordered you to lead your squad on a border patrol mission.

It was a very cold winter night when you began marching out of Gumren Outpost."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[180]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_outpost");"*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The years passed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[7]` (Narrator), `[8]` (Narrator), `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "1923|September 9th"*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Your only concern was passing the exams."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator), `[19]` (Narrator), `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1927|May 22nd"*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You did exactly as they said."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "As you entered the room, you heard screams coming from th..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You could see your breath."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[78]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "After several hours of marching through the snowy hills, ..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "After several hours of marching through the snowy hills, distant noises were heard. 

Visibility was too low to confirm the source, so the squad crawled forward in formation and found a spot to observe.

A group of refugees had made it beyond the border fence. You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Player: "...escorted them back."*)
  - -> `[84]` (*Player: "...let them slip through."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...let them slip through."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "After the patrol, Major Lancea arrived with anger and imm..."*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...escorted them back."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "The refugees were in despair when they realized that you ..."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "The refugees were in despair when they realized that you were taking them back to the border.

Screams and protests ensued as they were restrained. You delivered them to the border guards.

After several months of military service..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Military_Order_Accomplished = true"*)

### Węzeł `[87]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[88]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "You became the legal assistant to one of the more experie..."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "You became the economics assistant to one of the more exp..."*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Narrator: "You became the foreign policy assistant to one of the mor..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...your duties ended and you went back to civilian life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Narrator: "1931|July|Holsord"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "1931|July|Holsord"]** — Mówca: **Narrator**
> "You and Monica decided to share your lives together. After receiving the blessing of her parents, a ceremony was held in Holsord.

During the same year, you were offered a high-paying job within the governing United Sordland Party. 

It was important to start your career on a good foot, so you accepted it."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_wedding");"*)

### Węzeł `[95]`
Mówca: **Narrator**
> "You became the legal assistant to one of the more experienced members of assembly.

You worked long and hard, going through hundreds of pages of legal documents late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "You became the economics assistant to one of the more experienced members of assembly.

You worked long and hard, investigating hundreds of pages of economic reports late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[97]`
Mówca: **Narrator**
> "You became the foreign policy assistant to one of the more experienced members of assembly.

You worked long and hard, reviewing dozens of foreign policy plans late into the night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_suitcase");"*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was the best opportunity to change the country for the better."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator), `[197]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "1933|September"]** — Mówca: **Narrator**
> "Tarquin Soll gave amnesty to the remaining factions of the civil war and chose de-escalation and appeasement. The institutions and symbols of the former kingdom were slowly replaced.

His government launched several new initiatives, such as a citizen-funded bills program to revitalize the economy, a social labor initiative to help rebuild and improve society, and a large dam project to solve the energy crisis.

The first multi-party elections in the history of Sordland were held."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You were climbing the ladder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Narrator), `[96]` (Narrator), `[97]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "1933|September"*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "President Tarquin Soll was elected once more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "1945|October|Time of Change"]** — Mówca: **Narrator**
> "President Soll barely secured a majority in the election against the opposition leader.

Over the next year, the Sordish people grew increasingly discontent with corruption and the worsening quality of life. Economic growth was slowing down.

Meanwhile, calls for a United Sordland Party congress became louder as a leadership struggle started to brew. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[199]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[103]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the internal opposition."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 1"*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "The president offered you the position of Minister of Jus..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[108]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "The president offered you the position of Minister of Eco..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Narrator: "The president offered you the position of Minister of For..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Justice and Law in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Economy, Commerce and Energy in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[112]`
Mówca: **Narrator**
> "The president offered you the position of Minister of Foreign Affairs and Trade in the next government if you backed him in the upcoming vote."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator), `[111]` (Narrator), `[112]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_MinisterOffer_Accepted = true"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "1946|August"]** — Mówca: **Narrator**
> "The congress was nothing short of impressive. The banners of the United Sordland Party were decorating every possible spot.

Thousands of influential political figures, lobbyists and benefactors gathered for this turning point. 

The voting for the party leadership began."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[167]` (Player), `[113]` (Player), `[118]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_congress");"*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You voted for Ewald Alphonso."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll = false"*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "1946|September 1st"]** — Mówca: **Narrator**
> "The efforts bore fruit as the contentious leadership vote was won by Ewald Alphonso. 

During the congress, Tarquin Soll announced he would retire from politics at the end of his term, and appointed Alphonso as Vice President.

You knew the structure he had established was to stay. The country had become increasingly authoritarian. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[115]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[117]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You voted for Tarquin Soll."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[114]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Congress_Soll = true"*)

### Węzeł `[118]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You rejected."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Narrator), `[111]` (Narrator), `[112]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_MinisterOffer_Rejected = true"*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "1946|September 1st"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Congress_Soll = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Narrator: "1946|September 1st"*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...didn't care about who was in charge."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "1946|October 15th|Uncertain Years"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "1949"]** — Mówca: **Narrator**
> "During the general elections, the main opposition leader was embroiled in a sex scandal with his secretary. He was replaced by the more popular figure Frens Ricter, but the damage had been done.

The new economic policies and the extensive privatization program proposed by Ewald Alphonso secured an election victory for the United Sordland Party.

Over the following years you..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[138]` (Player), `[172]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_flag");"*)

### Węzeł `[123]`
**[WYBÓR GRACZA: "1951|Summer|A New Sordland"]** — Mówca: **Narrator**
> "The Presidency of Alphonso saw many bold reforms in government and law and advancements in liberal democratic values.

However, due to infighting and disorganization, continental economic tensions, and fast-track privatization, it was followed by a severe economic recession.

The other parties announced their bids for the 1953 election, but the unfair election system hampered opposition efforts to campaign. You..."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[139]` (Player), `[173]` (Player), `[174]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "1952|October|Rise of Rayne"]** — Mówca: **Narrator**
> "With Petr's help, your presence in the USP grew. The two of you worked long nights together; he flipped opponents to your side. 

You became the face of a new wing of the party. Step by step and with adequate planning, your wing took over the leadership as President Alphonso lost control of the country.

The moment to make a move had come. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Player), `[175]` (Player), `[182]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "...blamed Alphonso for the crisis on television."*)
  - -> `[146]` (*Player: "...bribed and extorted Alphonso's inner circle."*)
  - -> `[125]` (*Player: "...advised Alphonso to step down."*)

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...advised Alphonso to step down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Diplomatic = true"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "He listened to your advice. 

Alphonso conceded the leadership struggle and the party eventually voted you in because of your indisputable influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_speech");"*)

### Węzeł `[127]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...worried that your reputation would be tarnished along with Alphonso."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator), `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "1952|October|Rise of Rayne"*)

### Węzeł `[128]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was your turn."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[126]` (Narrator), `[186]` (Narrator), `[187]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "1953|October|Election Campaign"*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was a gloomy year."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator), `[51]` (Narrator), `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Deyr_History == true"*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her diligence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator), `[176]` (Narrator), `[177]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "She mentioned to you that she was a volunteer for the Sor..."*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland plunged into chaos."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == true"*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You stayed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "There was a massive clash between the two sides. Soldiers..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You never forgot her face."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Narrator), `[73]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Protest_Girl_Crushed = true"*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The chaos had to end."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Narrator), `[179]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "1929|Republic of Sordland"*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "The contender for party leadership was Ewald Alphonso, a reformist and talented business magnate with a growing follower base within the party.

President Soll noticed your attempts to secure votes for him and approached you with a lucrative deal."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "You had a meeting with him."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You had a meeting with him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[135]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "1946|October 15th|Uncertain Years"]** — Mówca: **Narrator**
> "A month later, your daughter was born. Monica named her Deana. She motivated you during a tumultuous period in the party.

As the VP and the leader of the USP, Ewald Alphonso began dismantling the old organizations and structures established by the USP such as the State Educators Corps and the Sordish State Corporation Bills.

The general elections were approaching. The United Sordland party was under new leadership. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Player), `[170]` (Player), `[171]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_baby");"*)

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best not to help him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "1949"*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...dedicated yourself to the party and its success."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "1953|October|Election Campaign"]** — Mówca: **Narrator**
> "After visiting every city and town during the campaign, you made a speech on state television.

You promised to..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...preserve national values."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Conservative = true;  ..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...enact democratic reforms."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[140]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal = true;  BaseG..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "“The people are tired of empty promises. We need fundamental change in our institutions and government!

A solid and transparent democracy awaits us. Brothers and sisters, a new constitution and a new age is upon us!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: "The broadcast ended."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Conservative = true; 
BaseGame.Sollist += 1;
BaseGame.Public_Opinion += 1;
BaseGame.Bludish_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Speech_Democracy_Conservative"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "“Great nation of Sordland! Due to our incompetent leaders..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal = true; 
BaseGame.Democratic += 1;
BaseGame.Bludish_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] = true;
Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "“The people are tired of empty promises. We need fundamen..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...bribed and extorted Alphonso's inner circle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_Backstab = true"*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The broadcast ended."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[143]` (Narrator), `[205]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "1953|November 5th"*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "1953|November 5th"]** — Mówca: **Narrator**
> "On election day, millions went out to cast their votes."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[147]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_vote");"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...blamed Alphonso for the crisis on television."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[124]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You questioned what you were being taught."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator), `[19]` (Narrator), `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1927|May 22nd"*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a student council."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[42]` (Narrator), `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_StudentCouncil = true"*)

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...a human rights group."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[41]` (Narrator), `[42]` (Narrator), `[43]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Group_HumanRights = true"*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“End the chaos! We want stability!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "You were marching against Rikard.  The students and soldi..."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Workers of the world, unite!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "You were marching under the protection of Rikard's soldie..."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“Bring down the nationalists!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Narrator: "You were marching under the protection of Rikard's soldie..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...“One nation, one system, one people!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "You were marching against Rikard.  The students and soldi..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You left."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[67]` (Narrator), `[70]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The clashes escalated into a full blown civil war. The ho..."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...you voted for the United Sordland Party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "1929|June"*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The financial compensation was too great to pass up."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator), `[197]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Working for the ruling party was the easiest path to power."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Narrator), `[197]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted with doubts."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Narrator), `[217]` (Narrator), `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "1938|June|Rising Career"*)

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You accepted right away."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Narrator), `[217]` (Narrator), `[218]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Narrator: "1938|June|Rising Career"*)

### Węzeł `[163]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...kept supporting the president."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist += 1"*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...watched from the sidelines."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "1946|July"*)

### Węzeł `[165]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "You gave your support to Ewald Alphonso, a reformist and talented business magnate, who was the main contender for party leadership.

Meanwhile, in a desperate effort to secure votes before the congress, President Soll was meeting party members one by one."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_politicians");"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "1946|July"]** — Mówca: **Narrator**
> "The contender for party leadership was Ewald Alphonso, a reformist and talented business magnate with a growing follower base within the party.

Meanwhile, in a desperate effort to secure votes before the congress, President Soll was meeting party members one by one."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Player: "He approached you too."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "But he didn't approach you."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "1946|August"*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "He approached you too."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[166]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "1946|September 1st"]** — Mówca: **Narrator**
> "Unfortunately, Tarquin Soll lost the leadership vote to Ewald Alphonso by a small margin. 

During the congress, Soll announced he would retire from politics at the end of his term, and appointed Alphonso as Vice President.

The systems he had established were to stay much longer; his achievements wouldn't be forgotten. You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[117]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[170]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were troubled by the departure of Soll."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "1946|October 15th|Uncertain Years"*)

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were happy that Soll was finally leaving."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[116]` (Narrator), `[169]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "1946|October 15th|Uncertain Years"*)

### Węzeł `[172]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...joined the party effort and campaigned for him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso = true"*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...tried all that was necessary to climb up the ladder."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...did your best in order to make Sordland a better place."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...thought that your party could not survive another crisis."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator), `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "1952|October|Rise of Rayne"*)

### Węzeł `[176]`
Mówca: **Narrator**
> "The council was focused on increasing the student involvement in the campus along with partaking in the budget. 

Through active participation, you gained budget management and leadership skills.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "...her intelligence."*)
  - -> `[178]` (*Player: "...her beauty."*)
  - -> `[130]` (*Player: "...her diligence."*)

### Węzeł `[177]`
Mówca: **Narrator**
> "The group heavily protested against the deteriorating human rights situation in Sordland. 

You contributed in thorough discussions on how to protect and expand freedoms.

In one of the meetings, Petr Vectern introduced you to a classmate of his, Monica. You were immediately attracted to..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Player: "...her intelligence."*)
  - -> `[178]` (*Player: "...her beauty."*)
  - -> `[130]` (*Player: "...her diligence."*)

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her beauty."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator), `[176]` (Narrator), `[177]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "She mentioned to you that she was a volunteer for the Sor..."*)

### Węzeł `[179]`
Mówca: **Narrator**
> "The clashes escalated into a full blown civil war. The horrors made you isolate yourself for a while.

Monica helped you cope and love grew between the two of you.

However, it was a difficult time for love."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player: "The chaos had to end."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was time to serve your national duty."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "1930|February|Bergia Region"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "You agreed in principle."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[18]` (Narrator), `[19]` (Narrator), `[20]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "1927|May 22nd"*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...were worried about the economic recession."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator), `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "1952|October|Rise of Rayne"*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "It was time to face the truth."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "UnlockAchievement("Prologue_Finish");"*)

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Suddenly the soldiers charged."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "A student fell and was trampled as everybody started runn..."*)

### Węzeł `[185]`
Mówca: **Narrator**
> "After the patrol, Major Lancea arrived with anger and immediately relieved you of your command, calling you a disappointment.

One of your squad members had reported your actions.

After several months of scrubbing the floors as a punishment..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player: "...your duties ended and you went back to civilian life."*)

### Węzeł `[186]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "Most of the inner circle abandoned him, even Minister of Development Gus Manger. President Alphonso started to reshuffle his cabinet, but it was too late.

Alphonso was removed from power by a no-confidence vote. The party eventually voted you in because of your influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[146]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_speech");"*)

### Węzeł `[187]`
**[WYBÓR GRACZA: "1953|March"]** — Mówca: **Narrator**
> "The media backlash prompted President Alphonso to reshuffle his cabinet, but most of his inner circle, even Minister of Development Gus Manger, abandoned him.

Alphonso was removed from power by a no-confidence vote. The party eventually voted you in because of your influence.

Following this, you announced that you would be running for President in the general election with Petr as your running mate."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[149]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_speech");"*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...her intelligence."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[55]` (Narrator), `[176]` (Narrator), `[177]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "She mentioned to you that she was a volunteer for the Sor..."*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_PublicBlame = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "1953|March"*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Backstab = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "1953|March"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_Takeover_Diplomatic = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "1953|March"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_1stCoup_Protested = true"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_HumanRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Group_HumanRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Narrator: "The group heavily protested against the deteriorating hum..."*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_StudentCouncil = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Group_StudentCouncil"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "The council was focused on increasing the student involve..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Group_PoliticalDebate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Group_PoliticalDebate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "The dozens of debates helped you hone your oratory skills..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...your duties ended and you went back to civilian life."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[185]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Narrator: "1931|July|Holsord"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "1931|July|Holsord"]** — Mówca: **Narrator**
> "You and Monica decided to share your lives together. After receiving the blessing of her parents, a ceremony was held in Holsord.

During the same year, you worked hard to secure a high-paying job within the governing United Sordland Party. 

It was much more difficult to start your career on a good foot because of the "refugee incident", but you still managed."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[196]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_wedding");"*)

### Węzeł `[198]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "During your absence, Petr Vectern found trustworthy contacts and strengthened your position in the party.

At the same time, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[209]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_innercircle");"*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "The cracks began to show."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Narrator), `[220]` (Narrator), `[226]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Narrator: "1945|October|Time of Change"*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...stay away from any political organization."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Active = false"*)

### Węzeł `[201]`
**[WYBÓR GRACZA: "1928|June 2nd"]** — Mówca: **Narrator**
> "The radio relayed that the communist general Rikard surrounded Luderin and his troops, demanding their surrender.

They refused and heavy fighting broke out across the country. 

You just couldn't believe it. The army was fighting amongst themselves."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[200]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "Sordland plunged into chaos."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Narrator: "The clashes escalated into a full blown civil war. The ho..."*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "1928|June 2nd"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Military_Order_Accomplished = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Player: "...your duties ended and you went back to civilian life."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "“Great nation of Sordland! Due to our incompetent leadership, enemies both internal and external are influencing our glorious nation.

Today, more than ever, we need to unite under one flag and protect our values! Greci Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Player: "The broadcast ended."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 3;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 3;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "The years passed."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "1938|June|Rising Career"]** — Mówca: **Narrator**
> "As the youngest MP, it was difficult to connect with the influential inner circle. You needed allies, so you brought on Petr Vectern as your right hand man.

The birth of your son, Franc, provided a brief moment of joy and relief.

You..."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Player), `[162]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_baby");"*)

### Węzeł `[208]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The preparation of a comprehensive trade agreement with Agnolia was occupying most of your personal time.

But your significant contribution to the trade talks triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false` AND `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sacrificed work to spend time with your family."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Family_Important = true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Holsord_Law == true"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Holsord_Law == true)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Holsord_Law == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "1934|April 2nd"*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Holsord_Law == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...sacrificed family time to improve your position in the party."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[207]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == true"*)
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "1934|April 2nd"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Narrator: "1934|April 2nd"*)

### Węzeł `[217]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The new five-year plan and the subsequent financial work put you under a lot of pressure.

But your significant contribution to the economic strategy triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == true` AND `(Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[218]`
**[WYBÓR GRACZA: "1934|April 2nd"]** — Mówca: **Narrator**
> "The ongoing legal battle between the Justice Ministry and the Supreme Court put you under a lot of stress.

But your significant contribution to the legal case triggered an invitation to meet President Tarquin Soll himself, who offered you a key position.

You were to become the youngest Member of Assembly."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Studyplace_Holsord_Law"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "PrologueImage("pe_meeting");"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Family_Important = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Family_Important"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Narrator: "1941|October"*)

### Węzeł `[220]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "Just like your father once did, you prioritized work over family. Along with Petr Vectern, you accomplished great things for your party. 

At home, Monica and Franc felt your absence.

Meanwhile, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Kontekst wejściowy (poprzednik):** `[213]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_innercircle");"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_1stCoup_Protested = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_1stCoup_Protested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The soldiers beat you relentlessly."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Protest_Girl_Crushed = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Protest_Girl_Crushed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "The clashes escalated into a full blown civil war. The ho..."*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich == true"*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "1941|October"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Narrator: "1941|October"*)

### Węzeł `[226]`
**[WYBÓR GRACZA: "1941|October"]** — Mówca: **Narrator**
> "Along with Petr Vectern, you did great things to cement your position in the party. Meanwhile at home, Monica and Franc felt your absence.

At the same time, President Soll increased his authority over the years. His growing ego started to cause strife within the USP."
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[213]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline(); PrologueImage("pe_innercircle");"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active = true; BaseGame.Prologue_University_Political_Socialist = true; BaseGame.Malenyevist += 1; BaseGame.Sollist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;
Variable["BaseGame.Prologue_University_Political_Socialist"] = true;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "1928|June 2nd"*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Active = true; BaseGame.Prologue_University_Political_Nationalist = true; BaseGame.Sollist += 1; BaseGame.Malenyevist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_Political_Active"] = true;
Variable["BaseGame.Prologue_University_Political_Nationalist"] = true;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;
Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "1928|June 2nd"*)

### Węzeł `[229]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "1946|July"*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "1946|July"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 2;
BaseGame.Public_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "The years passed."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.PersonalWealth += 1;
BaseGame.Public_Opinion += 2;
BaseGame.Bludish_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "The years passed."*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_MinisterOffer_Accepted = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_MinisterOffer_Accepted"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "1946|August"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_MinisterOffer_Rejected = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_MinisterOffer_Rejected"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Narrator: "1946|August"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "1949"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion -= 1"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame = true"*)

### Węzeł `[239]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_Takeover_PublicBlame = true"*)

### Węzeł `[240]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[242]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[241]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "1926"*)

### Węzeł `[242]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "1926"*)

### Węzeł `[243]`
**[WYBÓR GRACZA: "1926"]** — Mówca: **Narrator**
> "After graduating, you passed the university exam with high marks.

Even though your family was poor, the public education system made it possible to go to university. You had the opportunity to choose between several studies.

You chose..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Kontekst wejściowy (poprzednik):** `[291]` (Player), `[292]` (Player), `[293]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "...Law at the Holsord State University."*)
  - -> `[16]` (*Player: "...Economics at the Lachaven Business School."*)
  - -> `[17]` (*Player: "...History at the Deyr University of Culture."*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Party_CampaignedForAlphonso == true"*)
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)"*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Party_CampaignedForAlphonso == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "1951|Summer|A New Sordland"*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Party_CampaignedForAlphonso == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "1951|Summer|A New Sordland"*)

### Węzeł `[247]`
**[WYBÓR GRACZA: "1951|Summer|A New Sordland"]** — Mówca: **Narrator**
> "The Presidency of Alphonso saw many bold reforms in government and law and advancements in liberal democratic values. He valued your support throughout.

However, due to infighting and disorganization, continental economic tensions, and fast-track privatization, it was followed by a severe economic recession.

The other parties announced their bids for the 1953 election, but the unfair election system hampered opposition efforts to campaign. You..."
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true`
- **Kontekst wejściowy (poprzednik):** `[139]` (Player), `[173]` (Player), `[174]` (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "AdvanceTimeline();"*)

### Węzeł `[248]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Player: "You did not fully understand."*)
  - -> `[12]` (*Player: "You were happy that you had the day off."*)
  - -> `[13]` (*Player: "You were somewhat worried."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_university");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_university");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player: "You agreed in principle."*)
  - -> `[150]` (*Player: "You questioned what you were being taught."*)
  - -> `[80]` (*Player: "Your only concern was passing the exams."*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_coup");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_coup");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player: "...protest with the students."*)
  - -> `[23]` (*Player: "...avoid any confrontation."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "...a human rights group."*)
  - -> `[151]` (*Player: "...a student council."*)
  - -> `[44]` (*Player: "...a political debate group."*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_lachaven");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_lachaven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "...a human rights group."*)
  - -> `[151]` (*Player: "...a student council."*)
  - -> `[44]` (*Player: "...a political debate group."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_deyr");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_deyr");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player: "...a human rights group."*)
  - -> `[151]` (*Player: "...a student council."*)
  - -> `[44]` (*Player: "...a political debate group."*)

### Węzeł `[254]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "Sordland plunged into chaos."*)

### Węzeł `[255]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Player: "Sordland plunged into chaos."*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_protest");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_protest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Player: "...“One nation, one system, one people!”"*)
  - -> `[153]` (*Player: "...“End the chaos! We want stability!”"*)
  - -> `[65]` (*Player: "...“United we stand, divided we fall!”"*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_protest");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_protest");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: "...“Freedom, equality and solidarity!”"*)
  - -> `[154]` (*Player: "...“Workers of the world, unite!”"*)
  - -> `[155]` (*Player: "...“Bring down the nationalists!”"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_coup2");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_coup2");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player: "You ran to save her."*)
  - -> `[69]` (*Player: "You warned her."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_soll");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_soll");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Player: "...you voted for the United Sordland Party."*)
  - -> `[76]` (*Player: "...you did not vote."*)

### Węzeł `[260]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_outpost");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_outpost");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "You could see your breath."*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_wedding");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_wedding");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Player: "Working for the ruling party was the easiest path to power."*)
  - -> `[159]` (*Player: "The financial compensation was too great to pass up."*)
  - -> `[98]` (*Player: "It was the best opportunity to change the country for the..."*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_suitcase");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_suitcase");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: "You were climbing the ladder."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "President Tarquin Soll was elected once more."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meeting");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Player: "You accepted right away."*)
  - -> `[161]` (*Player: "You accepted with doubts."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_baby");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_baby");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player: "...sacrificed work to spend time with your family."*)
  - -> `[213]` (*Player: "...sacrificed family time to improve your position in the..."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_innercircle");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_innercircle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: "The cracks began to show."*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player: "...watched from the sidelines."*)
  - -> `[163]` (*Player: "...kept supporting the president."*)
  - -> `[103]` (*Player: "...joined the internal opposition."*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_politicians");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_politicians");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Player: "But he didn't approach you."*)

### Węzeł `[269]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_meeting");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_meeting");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player: "You accepted."*)
  - -> `[118]` (*Player: "You rejected."*)

### Węzeł `[270]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_congress");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_congress");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "You voted for Tarquin Soll."*)
  - -> `[115]` (*Player: "You voted for Ewald Alphonso."*)

### Węzeł `[271]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Player: "...were happy that Soll was finally leaving."*)
  - -> `[170]` (*Player: "...were troubled by the departure of Soll."*)
  - -> `[121]` (*Player: "...didn't care about who was in charge."*)

### Węzeł `[272]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_baby");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_baby");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Player: "...joined the party effort and campaigned for him."*)
  - -> `[138]` (*Player: "...did your best not to help him."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_flag");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_flag");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Player: "...did your best in order to make Sordland a better place."*)
  - -> `[173]` (*Player: "...tried all that was necessary to climb up the ladder."*)
  - -> `[139]` (*Player: "...dedicated yourself to the party and its success."*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Player: "...thought that your party could not survive another crisis."*)
  - -> `[182]` (*Player: "...were worried about the economic recession."*)
  - -> `[127]` (*Player: "...worried that your reputation would be tarnished along ..."*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();
PrologueImage("pe_speech");`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();
PrologueImage("pe_speech");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Player: "It was your turn."*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AdvanceTimeline();`
- **Efekt skryptowy (`userScript`):** `AdvanceTimeline();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player: "...enact democratic reforms."*)
  - -> `[141]` (*Player: "...preserve national values."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_vote");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_vote");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player: "It was time to face the truth."*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_lachaven");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_lachaven");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Your parents named you Anton. As the only child of a succ..."*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_holsord");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "Your parents named you Anton. As the only child of a dili..."*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PrologueImage("pe_deyr");`
- **Efekt skryptowy (`userScript`):** `PrologueImage("pe_deyr");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Your parents named you Anton. As the only child of a farm..."*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("MainTheme");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("MainTheme");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Węzeł Logiki Narracyjnej: "DontPlayMapMusic();"*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `UnlockAchievement("Prologue_Finish");`
- **Efekt skryptowy (`userScript`):** `UnlockAchievement("Prologue_Finish");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "PlayMusic("MainTheme");"*)

### Węzeł `[283]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("In the Prologue", "", "");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("In the Prologue","","");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "1908|Kingdom of Sordland"*)

### Węzeł `[284]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DontPlayMapMusic();`
- **Efekt skryptowy (`userScript`):** `DontPlayMapMusic();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "DontPlayMapAmbience();"*)

### Węzeł `[285]`
Mówca: **Narrator**
> "She mentioned to you that she was a volunteer for the Sordish League of Women, an organization campaigning for women's rights.

You..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player: "...told her you wholeheartedly supported her cause."*)
  - -> `[287]` (*Player: "...weren't particularly interested in women's rights, but..."*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...told her you wholeheartedly supported her cause."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_SupportWomensRights = true"*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "...weren't particularly interested in women's rights, but asked her to dinner nonetheless."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The politically charged environment led you to..."*)

### Węzeł `[288]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_SupportWomensRights = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_University_SupportWomensRights"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "The politically charged environment led you to..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `DontPlayMapAmbience();`
- **Efekt skryptowy (`userScript`):** `DontPlayMapAmbience();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[290]`
Mówca: **Narrator**
> "Months after the Republic was proclaimed, life around you changed. You watched friends and family face uncertainty, economic hardship, scattered unrest and resistance from those tied to the old order. 

In their struggle, you..."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player: "…envied those who escaped it all, and wished for an easie..."*)
  - -> `[292]` (*Player: "…saw both pain and perseverance, and sought balance betwe..."*)
  - -> `[293]` (*Player: "…felt the weight they carried and chose to shoulder even ..."*)

### Węzeł `[291]`
**[WYBÓR GRACZA: "…envied those who escaped it all, and wished for an easier path. [Easier Resources]"]** — Mówca: **Player**
> "…envied those who escaped it all, and wished for an easier path."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_EasyLife = true;  BaseGame.Economy += 2..."*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "…saw both pain and perseverance, and sought balance between the two."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_NormalLife = true;"*)

### Węzeł `[293]`
**[WYBÓR GRACZA: "…felt the weight they carried and chose to shoulder even more. [Harder Resources]"]** — Mówca: **Player**
> "…felt the weight they carried and chose to shoulder even more."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[290]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_HardLife = true;  BaseGame.Economy -= 2..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_EasyLife = true; 
BaseGame.Economy += 2;
BaseGame.GovernmentBudget += 2;
BaseGame.PersonalWealth += 1;
BaseGame.Public_Opinion += 3;
BaseGame.Bludish_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_EasyLife"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] + 2;
Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] + 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] + 3;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_NormalLife = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_NormalLife"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_HardLife = true; 
BaseGame.Economy -= 2;
BaseGame.GovernmentBudget -= 2;
BaseGame.Public_Opinion -= 2;
BaseGame.Bludish_Opinion -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Prologue_HardLife"] = true;
Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;
Variable["BaseGame.GovernmentBudget"] = Variable["BaseGame.GovernmentBudget"] - 2;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 2;
Variable["BaseGame.Bludish_Opinion"] = Variable["BaseGame.Bludish_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
