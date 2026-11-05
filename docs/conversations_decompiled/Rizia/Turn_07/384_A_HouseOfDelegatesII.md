# Rizia/Turn 7/A_HouseOfDelegatesII

- **ID konwersacji:** `384`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Rizia/Turn_07/384_A_HouseOfDelegatesII.md`
- **Liczba węzłów dialogowych:** 430
- **Liczba wyborów gracza:** 85

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[75]** Manus Sazon
- **[86]** Daria de Rava
- **[87]** Sal Ignacius
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Country_HouseToras`
- `RiziaDLC.Country_PublicOpinion`
- `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit`
- `RiziaDLC.Decision_Turn07_InviteSalToHOD`
- `RiziaDLC.HouseElections_RNCWinsSeats`
- `RiziaDLC.HouseElections_RPPWinsSeats`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Pales_War`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValues_FellOffWagon`
- `RiziaDLC.Policy_Law_StateReligion_Wruhecism`
- `RiziaDLC.Policy_RD_Economy_WarProfitsTax`
- `RiziaDLC.Reforms_DiscussedOnYacht`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_OutedToPlayer`
- `RiziaDLC.Relations_Pabel_Together`
- `RiziaDLC.Relations_VinaManus_Approve`
- `RiziaDLC.Trait_FunnyKing`
- `RiziaDLC.Trait_ReligiousKing`
- `RiziaDLC.Trait_SoberKing`
- `RiziaDLC.Trait_TyrantKing`
- `RiziaDLC.Vina_Hostage`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality`
- `RiziaDLC.Said_GlovuriusAxaRizia`
- `RiziaDLC.Said_Halaita`
- `RiziaDLCSupport.Journal_RD_WarProfitsTax`
- `RiziaDLCSupport.News_RD_RH_WarProfitsTax`
- `RiziaDLCSupport.News_RD_V_WarProfitsTax`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious`
- `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War`
- `RiziaDLCSupport.News_Turn07_RH_MateusDeath`
- `RiziaDLCSupport.News_Turn07_V_MateusDeath`

### Skoki między-konwersacyjne:
- Węzeł `[138]` -> **[385] Rizia/Turn 7/Pales War Update And Tax** (../Turn_07/385_Pales_War_Update_And_Tax.md), Węzeł `[1]`
- Węzeł `[141]` -> **[385] Rizia/Turn 7/Pales War Update And Tax** (../Turn_07/385_Pales_War_Update_And_Tax.md), Węzeł `[1]`
- Węzeł `[143]` -> **[386] Rizia/Turn 7/Zille Treaty Discussion** (../Turn_07/386_Zille_Treaty_Discussion.md), Węzeł `[1]`
- Węzeł `[144]` -> **[386] Rizia/Turn 7/Zille Treaty Discussion** (../Turn_07/386_Zille_Treaty_Discussion.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[26]` | **""And give my enemies in ATO more ammunition against me? Never.""** | `[20]` **Hugo Toras**: ""Are you sure it's a good idea t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Hugo Toras**: ""Your enemies already have forme..." |
| `[27]` | **""I can't blindly fight a war without knowing what's going on in my country.""** | `[20]` **Hugo Toras**: ""Are you sure it's a good idea t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Hugo Toras**: ""That's what the reports from yo..." |
| `[28]` | **""Failing to appease my citizens now will lead to mutiny down the line. You know th..."** | `[20]` **Hugo Toras**: ""Are you sure it's a good idea t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Hugo Toras**: ""We appease them by winning. Whi..." |
| `[33]` | **""No. It's not what Vina would have wanted.""** | `[20]` **Hugo Toras**: ""Are you sure it's a good idea t..." | `Variable["RiziaDLC.Vina_Hostage"] == true` | *Brak zmian stanu* | `[40]` **Narrator**: "His expression saddened." |
| `[34]` | **""Not as long as my daughter's lover is one of the speakers.""** | `[20]` **Hugo Toras**: ""Are you sure it's a good idea t..." | `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`<br>`(Variable["RiziaDLC.Vina_Hostage"] == true) == false` | *Brak zmian stanu* | `[38]` **Narrator**: "Hugo rubbed his forehead." |
| `[64]` | **""Yes. Phew. What a relief.""** | `[48]` **Hugo Toras**: ""I'm relieved that the RPP's his..."<br>`[60]` **Hugo Toras**: ""It's a relief that the RPP didn..." | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[67]` **Hugo Toras**: ""Unfortunate that our minority s..." |
| `[65]` | **""Perhaps Manus Sazon's charisma is wearing off.""** | `[48]` **Hugo Toras**: ""I'm relieved that the RPP's his..."<br>`[60]` **Hugo Toras**: ""It's a relief that the RPP didn..." | `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false` | *Brak zmian stanu* | `[66]` **Hugo Toras**: ""One can only hope."" |
| `[68]` | **""Even if that wasn't the case, I'm under no obligation to take the party's advice.""** | `[48]` **Hugo Toras**: ""I'm relieved that the RPP's his..."<br>`[60]` **Hugo Toras**: ""It's a relief that the RPP didn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Hugo Toras**: ""That's true. But we don't want ..." |
| `[70]` | **""I wouldn't mind hearing a little more from the opposition.""** | `[48]` **Hugo Toras**: ""I'm relieved that the RPP's his..."<br>`[60]` **Hugo Toras**: ""It's a relief that the RPP didn..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Hugo Toras**: ""As long as Manus Sazon is still..." |
| `[75]` | **""They will if they want to keep their heads.""** | `[29]` **Hugo Toras**: ""I hope they behave themselves i..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[81]` **Hugo Toras**: ""There's over 50 of them. Behead..." |
| `[76]` | **""Their movement is undeniable now. Perhaps we should start listening to them.""** | `[29]` **Hugo Toras**: ""I hope they behave themselves i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Hugo Toras**: ""Throw them a scrap or two. But ..." |
| `[82]` | **""Don't worry about it. The party and I have an understanding.""** | `[29]` **Hugo Toras**: ""I hope they behave themselves i..." | `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true` | *Brak zmian stanu* | `[83]` **Hugo Toras**: ""Actually, that does worry me."" |
| `[84]` | **""If they want to throw a tantrum, I'll let them. They still don't have any real po..."** | `[29]` **Hugo Toras**: ""I hope they behave themselves i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Hugo Toras**: ""Not yet."" |
| `[121]` | **""Halaita.""** | `[123]` **Narrator**: "He lowered his arms." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[125]` **Narrator**: "The Delegates murmured the word ..." |
| `[122]` | **""Thank you, Grand Wiseman.""** | `[123]` **Narrator**: "He lowered his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Narrator**: "The Delegates solemnly applauded..." |
| `[124]` | **""Wise words. May you all take them to heart.""** | `[123]` **Narrator**: "He lowered his arms." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Narrator**: "The Delegates murmured "Halaita"..." |
| `[159]` | **""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""** | `[158]` **Manus Sazon**: ""Unless, of course, His Majesty ..." | `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true` | *Brak zmian stanu* | `[169]` **Sal Ignacius**: ""It would be an honor, Your Maje..." |
| `[160]` | **""In fact, I do. House Speaker Sazon, esteemed delegates...""** | `[158]` **Manus Sazon**: ""Unless, of course, His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Narrator**: "The Delegates were all listening..." |
| `[161]` | **""No, I do not. This is your space, not mine.""** | `[158]` **Manus Sazon**: ""Unless, of course, His Majesty ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Narrator**: "Manus nodded gratefully." |
| `[164]` | **""I understand that the RPP now holds a delegate majority. However, that does not g..."** | `[163]` **Narrator**: "The Delegates were all listening..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[198]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 4 innych odgałęzień)* |
| `[168]` | **""I respect the criticism you have expressed today and will take it to heart.""** | `[163]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>`[198]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 2 innych odgałęzień)* |
| `[173]` | **""And the truths of His emissary, your sovereign king.""** | `[172]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Sal Ignacius**: ""Hrm. Yes."" |
| `[174]` | **""Halaita.""** | `[172]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[178]` **Narrator**: "Hugo and everyone else in the ro..." |
| `[175]` | **""And yet, let us not forget that some of those truths are more truthful than others.""** | `[172]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[177]` **Sal Ignacius**: ""Hrm. Yes."" |
| `[176]` | **""Your wisdom is inspiring, Grand Wiseman.""** | `[172]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Sal Ignacius**: ""It is not my wisdom, but that o..." |
| `[179]` | **""I thank you for bringing my attention to the plight of the less fortunate in my k..."** | `[163]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>`[198]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 2 innych odgałęzień)* |
| `[180]` | **""I tire of your constant negativity. The next time we convene in these chambers, I..."** | `[163]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[198]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 4 innych odgałęzień)* |
| `[181]` | **""Do not forget that you are here to serve me. Not the other way around.""** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[180]` **Player_Romus**: ""I tire of your constant negativ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[182]` | **""You can expect prompt action from the Crown regarding the matters you brought up ..."** | `[168]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[179]` **Player_Romus**: ""I thank you for bringing my att..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[183]` | **""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""** | `[168]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[179]` **Player_Romus**: ""I thank you for bringing my att..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[187]` | **""I will remind you that we are at war. And during a war, you stand behind your kin..."** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[180]` **Player_Romus**: ""I tire of your constant negativ..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[191]` | **""No matter what is going on around us, we cannot neglect our internal welfare.""** | `[168]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[179]` **Player_Romus**: ""I thank you for bringing my att..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[192]` | **""As members of one of the world's few remaining monarchist governments, I expect y..."** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[180]` **Player_Romus**: ""I tire of your constant negativ..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>`[199]` **Player_Romus**: ""Until next time, my comrades.""<br>*(oraz 3 innych odgałęzień)* |
| `[193]` | **""It is by my sword you live. I could have this assembly dissolved at any moment.""** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[180]` **Player_Romus**: ""I tire of your constant negativ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[197]` | **""I can serve my people a lot more easily when I am not surrounded by constant disa..."** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[180]` **Player_Romus**: ""I tire of your constant negativ..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[198]` | **""It is my hope that the majority and opposition can find common ground. Otherwise,..."** | `[164]` **Player_Romus**: ""I understand that the RPP now h..."<br>`[168]` **Player_Romus**: ""I respect the criticism you hav..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[213]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[209]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[199]` | **""Until next time, my comrades.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2` | *Brak zmian stanu* | `[216]` **Narrator**: "The Delegates looked puzzled. A ..." |
| `[206]` | **""Thank you, and God bless our troops.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[215]` **Narrator**: "Hugo and the Delegates quietly r..." |
| `[207]` | **""Thank you, and God bless you all.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[218]` **Narrator**: "The Delegates politely applauded." |
| `[208]` | **""I bid you farewell until next time.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false` | *Brak zmian stanu* | `[218]` **Narrator**: "The Delegates politely applauded." |
| `[209]` | **""Mr. Sazon, see you for dinner at ours next week.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Relations_VinaManus_Approve"]` | *Brak zmian stanu* | `[217]` **Narrator**: "Manus' face reddened. He nodded ..." |
| `[213]` | **""Thank you, and Glovurius axa Rizia.""** | `[181]` **Player_Romus**: ""Do not forget that you are here..."<br>`[182]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "Hugo and the Delegates repeated ..." |
| `[227]` | **""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""** | `[291]` **Daria de Rava**: ""Unless, of course, His Majesty ..." | `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true` | *Brak zmian stanu* | `[237]` **Sal Ignacius**: ""It would be an honor, Your Maje..." |
| `[228]` | **""In fact, I do. Madame Speaker, esteemed delegates...""** | `[291]` **Daria de Rava**: ""Unless, of course, His Majesty ..." | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` | *Brak zmian stanu* | `[231]` **Narrator**: "The Delegates were all listening..." |
| `[229]` | **""No, I do not. This is your space, not mine.""** | `[291]` **Daria de Rava**: ""Unless, of course, His Majesty ..." | `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false` | *Brak zmian stanu* | `[230]` **Narrator**: "Daria nodded graciously." |
| `[232]` | **""I understand that the RNC now holds a delegate majority. However, that does not g..."** | `[231]` **Narrator**: "The Delegates were all listening..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[284]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 4 innych odgałęzień)* |
| `[236]` | **""I respect the criticism you have expressed today and will take it to heart.""** | `[231]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>`[284]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 2 innych odgałęzień)* |
| `[241]` | **""And the truths of His emissary, your sovereign king.""** | `[240]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Sal Ignacius**: ""Hrm. Yes."" |
| `[242]` | **""Halaita.""** | `[240]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Sa...` | `[258]` **Narrator**: "Hugo and everyone else in the ro..." |
| `[246]` | **""Do not forget that you are here to serve me. Not the other way around.""** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[261]` **Player_Romus**: ""I tire of your constant negativ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[247]` | **""You can expect prompt action from the Crown regarding the matters you brought up ..."** | `[236]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[260]` **Player_Romus**: ""I thank you for bringing my att..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[248]` | **""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""** | `[236]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[260]` **Player_Romus**: ""I thank you for bringing my att..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[249]` | **""No matter what is going on around us, we cannot neglect our internal welfare.""** | `[236]` **Player_Romus**: ""I respect the criticism you hav..."<br>`[260]` **Player_Romus**: ""I thank you for bringing my att..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[250]` | **""As members of one of the world's few remaining monarchist governments, I expect y..."** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[261]` **Player_Romus**: ""I tire of your constant negativ..." | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>`[267]` **Player_Romus**: ""Until next time, my comrades.""<br>*(oraz 3 innych odgałęzień)* |
| `[254]` | **""It is by my sword you live. I could have this assembly dissolved at any moment.""** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[261]` **Player_Romus**: ""I tire of your constant negativ..." | `Variable["RiziaDLC.Trait_TyrantKing"] == true` | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[255]` | **""And yet, let us not forget that some of those truths are more truthful than others.""** | `[240]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Sal Ignacius**: ""Hrm. Yes."" |
| `[256]` | **""I will remind you that we are at war. And during a war, you stand behind your kin..."** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[261]` **Player_Romus**: ""I tire of your constant negativ..." | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[257]` | **""Your wisdom is inspiring, Grand Wiseman.""** | `[240]` **Sal Ignacius**: ""Remember, we are but one people..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[271]` **Sal Ignacius**: ""It is not my wisdom, but that o..." |
| `[260]` | **""I thank you for bringing my attention to the plight of the less fortunate in my k..."** | `[231]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>`[284]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 2 innych odgałęzień)* |
| `[261]` | **""I tire of your constant negativity. The next time we convene in these chambers, I..."** | `[231]` **Narrator**: "The Delegates were all listening..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[284]` **Player_Romus**: ""It is my hope that the majority..."<br>*(oraz 4 innych odgałęzień)* |
| `[266]` | **""Thank you, and God bless you all.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.Pales_War"] == true) == false` | *Brak zmian stanu* | `[287]` **Narrator**: "The Delegates politely applauded." |
| `[267]` | **""Until next time, my comrades.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2` | *Brak zmian stanu* | `[265]` **Narrator**: "The Delegates looked puzzled. A ..." |
| `[268]` | **""Thank you, and God bless our troops.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Pales_War"] == true` | *Brak zmian stanu* | `[272]` **Narrator**: "Hugo and the Delegates quietly r..." |
| `[269]` | **""I bid you farewell until next time.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false` | *Brak zmian stanu* | `[287]` **Narrator**: "The Delegates politely applauded." |
| `[270]` | **""Mr. Sazon, see you for dinner at ours next week.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 7 innych węzłów)* | `Variable["RiziaDLC.Relations_VinaManus_Approve"]` | *Brak zmian stanu* | `[286]` **Narrator**: "Manus' face reddened. He nodded ..." |
| `[276]` | **""I can serve my people a lot more easily when I am not surrounded by constant disa..."** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[261]` **Player_Romus**: ""I tire of your constant negativ..." | `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false` | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[283]` | **""Thank you, and Glovurius axa Rizia.""** | `[246]` **Player_Romus**: ""Do not forget that you are here..."<br>`[247]` **Player_Romus**: ""You can expect prompt action fr..."<br>*(oraz 6 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["R...` | `[285]` **Narrator**: "Hugo and the Delegates repeated ..." |
| `[284]` | **""It is my hope that the majority and opposition can find common ground. Otherwise,..."** | `[232]` **Player_Romus**: ""I understand that the RNC now h..."<br>`[236]` **Player_Romus**: ""I respect the criticism you hav..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Player_Romus**: ""Thank you, and Glovurius axa Ri..."<br>`[270]` **Player_Romus**: ""Mr. Sazon, see you for dinner a..."<br>*(oraz 4 innych odgałęzień)* |
| `[292]` | **""Well. Seems like Rizia is doing better than ever.""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false` | *Brak zmian stanu* | `[302]` **Hugo Toras**: ""To hear the Sazon boy tell it, ..."<br>`[313]` **Hugo Toras**: ""Apparently, yes."" |
| `[293]` | **""What a waste of time.""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`<br>`Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[321]` **Hugo Toras**: ""To put it mildly."" |
| `[294]` | **""We're screwed, aren't we?""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | `Variable["RiziaDLC.Country_PublicOpinion"] < 0` | *Brak zmian stanu* | `[303]` **Hugo Toras**: ""I would not put it so crassly."" |
| `[301]` | **""So everybody loves me. That's a relief.""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false` | *Brak zmian stanu* | `[304]` **Hugo Toras**: ""Be careful, Your Majesty. You c..." |
| `[305]` | **""House of Delegates? More like House of Irrelevance.""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true`<br>`Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[319]` **Narrator**: "Hugo suppressed a laugh." |
| `[309]` | **""I'd better get to work passing decrees.""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[317]` **Hugo Toras**: ""Be careful how much you capitul..."<br>`[318]` **Hugo Toras**: ""The RNC has some good proposals..." |
| `[322]` | **""Any thoughts on today's session, Your Grace?""** | `[223]` **Narrator**: "My uncle and I remained seated a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[323]` **Hugo Toras**: ""The Sazon boy is getting overco..."<br>`[341]` **Hugo Toras**: ""Baroness de Rava is handling th..." |
| `[349]` | **""I know. I just felt like a good laugh.""** | `[320]` **Hugo Toras**: ""I keep telling you, Your Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[354]` **Hugo Toras**: ""You have more pressing prioriti..." |
| `[350]` | **""I disagree. The Delegates need to be reminded whom they answer to.""** | `[320]` **Hugo Toras**: ""I keep telling you, Your Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Hugo Toras**: ""Ideally, my presence should ser..." |
| `[351]` | **""I was kidding. It's always useful to hear how the public is doing.""** | `[320]` **Hugo Toras**: ""I keep telling you, Your Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[353]` **Hugo Toras**: ""As long as you remember that wh..." |
| `[352]` | **""You're absolutely right. I should listen to you more often.""** | `[320]` **Hugo Toras**: ""I keep telling you, Your Majest..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Hugo Toras**: ""I am your Grand Vizier. Trust m..." |
| `[358]` | **""If you have something to say to me, you should say it here.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..."<br>`[428]` **Hugo Toras**: ""It's been a while since the two..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[365]` **Hugo Toras**: ""There are some matters that are..." |
| `[359]` | **""As long as no wine is involved, I'd love to.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..."<br>`[428]` **Hugo Toras**: ""It's been a while since the two..." | `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false) == false` | *Brak zmian stanu* | `[367]` **Narrator**: "Hugo rose and bowed." |
| `[363]` | **""As long as wine is involved, I'd love to.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..."<br>`[428]` **Hugo Toras**: ""It's been a while since the two..." | `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false` | *Brak zmian stanu* | `[367]` **Narrator**: "Hugo rose and bowed." |
| `[364]` | **""If the Derdians don't kill me? Sure thing.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..." | `Variable["RiziaDLC.Trait_FunnyKing"] == true` | *Brak zmian stanu* | `[367]` **Narrator**: "Hugo rose and bowed." |
| `[366]` | **""The honor would be all mine, Your Grace.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..."<br>`[428]` **Hugo Toras**: ""It's been a while since the two..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[367]` **Narrator**: "Hugo rose and bowed." |
| `[390]` | **""I can't promise you anything. Who knows if I'll make it back from Derdia alive.""** | `[357]` **Hugo Toras**: ""It's been a while since the two..." | `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` | *Brak zmian stanu* | `[367]` **Narrator**: "Hugo rose and bowed." |

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
  - -> `[424]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Facing parliament after the elections", ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War = true"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_ReligiousKing == true"*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_ReligiousKing == true)"*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_ReligiousKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_ReligiousKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religiou..."*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_ReligiousKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_ReligiousKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == false"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_War"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_Religious"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == false"*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Law_StateReligion_Wruhecism == false"*)
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == false)"*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Law_StateReligion_Wruhecism == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonRelig..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Law_StateReligion_Wruhecism == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Law_StateReligion_Wruhecism"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_G_DerdiaPreparations_NonReligious"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[15]`
Mówca: **Narrator**
> "Once more, I took my seat next to Hugo in the middle of the House of Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Węzeł Logiki Narracyjnej: "AddConversant("Hugo Toras");"*)

### Węzeł `[16]`
Mówca: **Narrator**
> "My uncle seemed to be in a grim mood today. He watched with agitation as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Hugo Toras: ""Are you sure it's a good idea to be here today, Your Maj..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true )"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "My uncle seemed to be in a grim mood today. He watched wi..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[20]`
Mówca: **Hugo Toras**
> ""Are you sure it's a good idea to be here today, Your Majesty? You have every right to shutter the House of Delegates while the war is ongoing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player_Romus: ""And give my enemies in ATO more ammunition against me? N..."*)
  - -> `[27]` (*Player_Romus: ""I can't blindly fight a war without knowing what's going..."*)
  - -> `[28]` (*Player_Romus: ""Failing to appease my citizens now will lead to mutiny d..."*)
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "My uncle watched with agitation as the representatives be..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)

### Węzeł `[24]`
Mówca: **Narrator**
> "My uncle watched with agitation as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Hugo Toras: ""Your first visit to the House of Delegates since the RPP..."*)

### Węzeł `[25]`
Mówca: **Hugo Toras**
> ""Your first visit to the House of Delegates since the RPP took over as majority party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Hugo Toras: ""I hope they behave themselves in front of their King.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And give my enemies in ATO more ammunition against me? Never.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Hugo Toras: ""Your enemies already have formed their opinions about mo..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't blindly fight a war without knowing what's going on in my country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Hugo Toras: ""That's what the reports from your Council are for.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Failing to appease my citizens now will lead to mutiny down the line. You know that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Hugo Toras: ""We appease them by winning. Which we actually might have..."*)

### Węzeł `[29]`
Mówca: **Hugo Toras**
> ""I hope they behave themselves in front of their King.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[76]` (*Player_Romus: ""Their movement is undeniable now. Perhaps we should star..."*)
  - -> `[77]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[84]` (*Player_Romus: ""If they want to throw a tantrum, I'll let them. They sti..."*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_Hostage == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_Hostage == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_Hostage == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""No. It's not what Vina would have wanted.""*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_Hostage == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. It's not what Vina would have wanted.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_Hostage"] == true`
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "His expression saddened."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not as long as my daughter's lover is one of the speakers.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true` AND `(Variable["RiziaDLC.Vina_Hostage"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[20]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Hugo rubbed his forehead."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Player_Romus: ""Not as long as my daughter's lover is one of the speakers.""*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
Mówca: **Narrator**
> "Hugo rubbed his forehead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Hugo Toras: ""Right. About that...""*)

### Węzeł `[39]`
Mówca: **Hugo Toras**
> ""Right. About that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "His expression saddened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Hugo Toras: ""I am truly sorry, Romus. But the hostage situation with ..."*)

### Węzeł `[41]`
Mówca: **Hugo Toras**
> ""I am truly sorry, Romus. But the hostage situation with Her Highness is all the more reason why...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[42]`
Mówca: **Narrator**
> "A gavel banged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "My uncle watched with a smile as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Hugo Toras: ""I think we'll find a lot more supporters of the Crown si..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RNCWinsSeats == true"*)
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RNCWinsSeats == true)"*)

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RNCWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "My uncle watched with a smile as the representatives bega..."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RNCWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RNCWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Narrator: "My uncle watched calmly as the representatives began fili..."*)

### Węzeł `[47]`
Mówca: **Hugo Toras**
> ""I think we'll find a lot more supporters of the Crown since the last time we were here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Hugo Toras: ""I'm relieved that the RPP's historic gains six years ago..."*)

### Węzeł `[48]`
Mówca: **Hugo Toras**
> ""I'm relieved that the RPP's historic gains six years ago were a mere anomaly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I wouldn't mind hearing a little more from the opposition.""*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[68]` (*Player_Romus: ""Even if that wasn't the case, I'm under no obligation to..."*)

### Węzeł `[49]`
Mówca: **Hugo Toras**
> ""We appease them by winning. Which we actually might have a chance at, if we focus and apply ourselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Of course, the Delegates' advice is invaluable in times ..."*)

### Węzeł `[50]`
Mówca: **Hugo Toras**
> ""That's what the reports from your Council are for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Of course, the Delegates' advice is invaluable in times ..."*)

### Węzeł `[51]`
Mówca: **Hugo Toras**
> ""Your enemies already have formed their opinions about monarchies. Keeping our symbolic parliament open is not going to change them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Hugo Toras: ""Of course, the Delegates' advice is invaluable in times ..."*)

### Węzeł `[52]`
Mówca: **Hugo Toras**
> ""Of course, the Delegates' advice is invaluable in times of peace. But I just think that...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Manus Sazon, positioned behind the House Speaker podium, carefully put the wooden mallet aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Manus Sazon: ""As the majority speaker of the House of Delegates, I her..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats"*)
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats)"*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");  // Adds the conversant wit..."*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");"*)

### Węzeł `[57]`
Mówca: **Narrator**
> "Daria de Rava, positioned behind the House Speaker podium, put the wooden mallet aside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Daria de Rava: ""I call this meeting of the House of Delegates to order.""*)

### Węzeł `[58]`
Mówca: **Narrator**
> "My uncle watched calmly as the representatives began filing into the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Hugo Toras: ""I don't see many fresh faces.""*)

### Węzeł `[59]`
Mówca: **Hugo Toras**
> ""I don't see many fresh faces.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Hugo Toras: ""It's a relief that the RPP didn't manage to make any gai..."*)

### Węzeł `[60]`
Mówca: **Hugo Toras**
> ""It's a relief that the RPP didn't manage to make any gains over last time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player_Romus: ""I wouldn't mind hearing a little more from the opposition.""*)
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[68]` (*Player_Romus: ""Even if that wasn't the case, I'm under no obligation to..."*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[63]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player_Romus: ""Yes. Phew. What a relief.""*)

### Węzeł `[63]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player_Romus: ""Perhaps Manus Sazon's charisma is wearing off.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes. Phew. What a relief.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[60]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Hugo Toras: ""Unfortunate that our minority speaker managed to retain ..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps Manus Sazon's charisma is wearing off.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[60]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Hugo Toras: ""One can only hope.""*)

### Węzeł `[66]`
Mówca: **Hugo Toras**
> ""One can only hope.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[67]`
Mówca: **Hugo Toras**
> ""Unfortunate that our minority speaker managed to retain his position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if that wasn't the case, I'm under no obligation to take the party's advice.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[60]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Hugo Toras: ""That's true. But we don't want them getting big ideas.""*)

### Węzeł `[69]`
Mówca: **Hugo Toras**
> ""That's true. But we don't want them getting big ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't mind hearing a little more from the opposition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Hugo Toras), `[60]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Hugo Toras: ""As long as Manus Sazon is still minority speaker, you wi..."*)

### Węzeł `[71]`
Mówca: **Hugo Toras**
> ""As long as Manus Sazon is still minority speaker, you will hear plenty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[72]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[74]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[73]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Player_Romus: ""They will if they want to keep their heads.""*)

### Węzeł `[74]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They will if they want to keep their heads.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Hugo Toras: ""There's over 50 of them. Beheading that many politicians..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their movement is undeniable now. Perhaps we should start listening to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Hugo Toras: ""Throw them a scrap or two. But we can't let them have th..."*)

### Węzeł `[77]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Reforms_DiscussedOnYacht == true"*)
  - -> `[79]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Reforms_DiscussedOnYacht == true)"*)

### Węzeł `[78]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Reforms_DiscussedOnYacht == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Don't worry about it. The party and I have an understand..."*)

### Węzeł `[79]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Reforms_DiscussedOnYacht == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Hugo Toras**
> ""Throw them a scrap or two. But we can't let them have the whole roast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[81]`
Mówca: **Hugo Toras**
> ""There's over 50 of them. Beheading that many politicians would be... well, I would rather not say 'satisfying', but...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry about it. The party and I have an understanding.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Reforms_DiscussedOnYacht"] == true`
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Hugo Toras: ""Actually, that does worry me.""*)

### Węzeł `[83]`
Mówca: **Hugo Toras**
> ""Actually, that does worry me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If they want to throw a tantrum, I'll let them. They still don't have any real power.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Hugo Toras: ""Not yet.""*)

### Węzeł `[85]`
Mówca: **Hugo Toras**
> ""Not yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Narrator: "A gavel banged."*)

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""As the majority speaker of the House of Delegates, I hereby call this session to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "He bowed in my direction."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "He bowed in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[88]`
Mówca: **Manus Sazon**
> ""Thank you for coming in the middle of this turbulent time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "Daria forced a smile from behind the opposition podium."*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Manus Sazon: ""Thank you for coming in the middle of this turbulent tim..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Manus Sazon: ""Thank you for coming, Your Majesty.""*)

### Węzeł `[92]`
Mówca: **Manus Sazon**
> ""Thank you for coming, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Narrator: "Daria forced a smile from behind the opposition podium."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[95]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Manus looked down at his podium with a slight frown."*)

### Węzeł `[95]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Narrator: "She nodded at Manus, who flipped open a binder."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Manus looked down at his podium with a slight frown."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Manus Sazon: ""At His Majesty's request, Grand Wiseman Ignacius will op..."*)

### Węzeł `[97]`
Mówca: **Manus Sazon**
> ""At His Majesty's request, Grand Wiseman Ignacius will open today's session with a short prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "All Delegates' eyes followed Sal as he rose from the back..."*)

### Węzeł `[98]`
Mówca: **Daria de Rava**
> ""I call this meeting of the House of Delegates to order.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "She bowed in my direction."*)

### Węzeł `[99]`
Mówca: **Narrator**
> "She bowed in my direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[100]`
Mówca: **Daria de Rava**
> ""Thank you for coming in the middle of this turbulent time, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "Manus nodded his assent from his usual place behind the o..."*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[103]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Daria de Rava: ""Thank you for coming in the middle of this turbulent tim..."*)

### Węzeł `[103]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Daria de Rava: ""Thank you for coming, Your Majesty.""*)

### Węzeł `[104]`
Mówca: **Daria de Rava**
> ""Thank you for coming, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Narrator: "Manus nodded his assent from his usual place behind the o..."*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[107]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Daria looked down at her notes with a smile."*)

### Węzeł `[107]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Narrator: "Daria flipped open a binder."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Daria looked down at her notes with a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Daria de Rava: ""At His Majesty's request, Grand Wiseman Ignacius will op..."*)

### Węzeł `[109]`
Mówca: **Daria de Rava**
> ""At His Majesty's request, Grand Wiseman Ignacius will open today's session with a short prayer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "All Delegates' eyes followed Sal as he rose from the back..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "All Delegates' eyes followed Sal as he rose from the back row of seats and slowly walked to the center of the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Węzeł Logiki Narracyjnej: "AddConversant("Sal Ignacius");"*)

### Węzeł `[111]`
Mówca: **Narrator**
> "Standing between Manus and Daria, he opened his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Sal Ignacius: ""Dearest brothers and sisters...""*)

### Węzeł `[112]`
Mówca: **Sal Ignacius**
> ""Dearest brothers and sisters...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Sal Ignacius: ""As we gather here today, we call upon the spirit of St. ..."*)

### Węzeł `[113]`
Mówca: **Sal Ignacius**
> ""As we gather here today, we call upon the spirit of St. Wruhec and the guidance of the divine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Sal Ignacius: ""May the great Nur bestow upon us the clarity of mind and..."*)

### Węzeł `[114]`
Mówca: **Sal Ignacius**
> ""May the great Nur bestow upon us the clarity of mind and purity of intent necessary to serve our people with honor and integrity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Sal Ignacius: ""We pray for the day when swords can be sheathed and harm..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Sal Ignacius: ""We pray for the courage to face our challenges, and the ..."*)

### Węzeł `[118]`
Mówca: **Sal Ignacius**
> ""We pray for the day when swords can be sheathed and harmony restored, when our troops return to their homes, and peace reigns once more in our lands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Sal Ignacius: ""God bless this assembly, and God bless our sovereign king.""*)

### Węzeł `[119]`
Mówca: **Sal Ignacius**
> ""We pray for the courage to face our challenges, and the wisdom to choose paths that lead to prosperity and peace for our kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Sal Ignacius: ""God bless this assembly, and God bless our sovereign king.""*)

### Węzeł `[120]`
Mówca: **Sal Ignacius**
> ""God bless this assembly, and God bless our sovereign king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He lowered his arms."*)

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "The Delegates solemnly applauded. Sal shuffled back to hi..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He lowered his arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player_Romus: ""Halaita.""*)
  - -> `[122]` (*Player_Romus: ""Thank you, Grand Wiseman.""*)
  - -> `[124]` (*Player_Romus: ""Wise words. May you all take them to heart.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words. May you all take them to heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[123]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "The Delegates murmured "Halaita" as Sal shuffled back to ..."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "The Delegates murmured the word as well. Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Adds the conversant..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "The Delegates solemnly applauded. Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Adds the conversant..."*)

### Węzeł `[127]`
Mówca: **Narrator**
> "The Delegates murmured "Halaita" as Sal shuffled back to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Sal Ignacius");  // Adds the conversant..."*)

### Węzeł `[128]`
Mówca: **Narrator**
> "Manus waited until the Grand Wiseman sat down before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Manus Sazon: ""Yes, thank you, Grand Wiseman. That was... enlightening.""*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Narrator: "Manus waited until the Grand Wiseman sat down before cont..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Daria waited until the Grand Wiseman sat down before cont..."*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Daria waited until the Grand Wiseman sat down before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Daria de Rava: ""Yes, thank you, Grand Wiseman. We will not forget the ro..."*)

### Węzeł `[133]`
Mówca: **Manus Sazon**
> ""Yes, thank you, Grand Wiseman. That was... enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "He flipped open a binder on his podium."*)

### Węzeł `[134]`
Mówca: **Daria de Rava**
> ""Yes, thank you, Grand Wiseman. We will not forget the role of God in these halls.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "She flipped open a binder on her podium."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "He flipped open a binder on his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[136]`
Mówca: **Narrator**
> "She flipped open a binder on her podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Manus Sazon: ""The first item on our agenda is an update on Zille.""*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Daria de Rava: ""The first item on our agenda is an update on Zille.""*)

### Węzeł `[143]`
Mówca: **Manus Sazon**
> ""The first item on our agenda is an update on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[144]`
Mówca: **Daria de Rava**
> ""The first item on our agenda is an update on Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Manus closed the binder and looked up."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Daria closed her binder and looked up."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Manus closed the binder and looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Manus Sazon: ""That concludes today's session.""*)

### Węzeł `[149]`
Mówca: **Manus Sazon**
> ""That concludes today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Manus Sazon: ""Unless, of course, His Majesty had any closing remarks.""*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Daria closed her binder and looked up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Daria de Rava: ""That concludes today's session.""*)

### Węzeł `[151]`
Mówca: **Daria de Rava**
> ""That concludes today's session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Daria de Rava: ""Unless, of course, His Majesty had any closing remarks.""*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player_Romus: ""No, I do not. This is your space, not mine.""*)
  - -> `[228]` (*Player_Romus: ""In fact, I do. Madame Speaker, esteemed delegates...""*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: ""I would like to ask Grand Wiseman Ignacius to conclude o..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[158]`
Mówca: **Manus Sazon**
> ""Unless, of course, His Majesty had any closing remarks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[161]` (*Player_Romus: ""No, I do not. This is your space, not mine.""*)
  - -> `[160]` (*Player_Romus: ""In fact, I do. House Speaker Sazon, esteemed delegates...""*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Kontekst wejściowy (poprzednik):** `[158]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Sal Ignacius: ""It would be an honor, Your Majesty.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In fact, I do. House Speaker Sazon, esteemed delegates...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "The Delegates were all listening closely to me."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I do not. This is your space, not mine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[158]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Narrator: "Manus nodded gratefully."*)

### Węzeł `[162]`
Mówca: **Narrator**
> "Manus nodded gratefully."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Manus Sazon: ""Then until next time, ladies and gentlemen.""*)

### Węzeł `[163]`
Mówca: **Narrator**
> "The Delegates were all listening closely to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[168]` (*Player_Romus: ""I respect the criticism you have expressed today and wil..."*)
  - -> `[179]` (*Player_Romus: ""I thank you for bringing my attention to the plight of t..."*)
  - -> `[180]` (*Player_Romus: ""I tire of your constant negativity. The next time we con..."*)

### Węzeł `[164]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that the RPP now holds a delegate majority. However, that does not give you free rein to speak critically of your King.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Do not forget that you are here to serve me. Not the oth..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[198]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Player_Romus: ""I understand that the RPP now holds a delegate majority...."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the criticism you have expressed today and will take it to heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""You can expect prompt action from the Crown regarding th..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[198]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)

### Węzeł `[169]`
Mówca: **Sal Ignacius**
> ""It would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "Once more, Sal walked over to stand between the two House..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "Once more, Sal walked over to stand between the two House speakers. This time, he took each one by the hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Sal Ignacius: ""My beloved Delegates, do not let your differences preven..."*)

### Węzeł `[171]`
Mówca: **Sal Ignacius**
> ""My beloved Delegates, do not let your differences prevent you from recognizing the Divine in each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Sal Ignacius: ""Remember, we are but one people, watching over this king..."*)

### Węzeł `[172]`
Mówca: **Sal Ignacius**
> ""Remember, we are but one people, watching over this kingdom by the great grace of our God, duty-bound to carry His truths into the mortal realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Player_Romus: ""And the truths of His emissary, your sovereign king.""*)
  - -> `[175]` (*Player_Romus: ""And yet, let us not forget that some of those truths are..."*)
  - -> `[176]` (*Player_Romus: ""Your wisdom is inspiring, Grand Wiseman.""*)
  - -> `[174]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[173]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the truths of His emissary, your sovereign king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Sal Ignacius: ""Hrm. Yes.""*)

### Węzeł `[174]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, let us not forget that some of those truths are more truthful than others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Sal Ignacius: ""Hrm. Yes.""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your wisdom is inspiring, Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[172]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Sal Ignacius: ""It is not my wisdom, but that of the heavens above.""*)

### Węzeł `[177]`
Mówca: **Sal Ignacius**
> ""Hrm. Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Hugo and everyone else in the room repeated the word after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank you for bringing my attention to the plight of the less fortunate in my kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Player_Romus: ""You can expect prompt action from the Crown regarding th..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[198]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of your constant negativity. The next time we convene in these chambers, I would like to hear only good news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[163]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Do not forget that you are here to serve me. Not the oth..."*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[198]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not forget that you are here to serve me. Not the other way around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[180]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can expect prompt action from the Crown regarding the matters you brought up today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[168]` (Player_Romus), `[179]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[168]` (Player_Romus), `[179]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Player_Romus: ""Even -- especially -- in the midst of war, we cannot neg..."*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""No matter what is going on around us, we cannot neglect ..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that we are at war. And during a war, you stand behind your king no matter what.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[180]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[190]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[189]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Player_Romus: ""I will remind you that we are at war. And during a war, ..."*)

### Węzeł `[190]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Player_Romus: ""As members of one of the world's few remaining monarchis..."*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what is going on around us, we cannot neglect our internal welfare.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[168]` (Player_Romus), `[179]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As members of one of the world's few remaining monarchist governments, I expect you to stand behind me no matter what.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[180]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is by my sword you live. I could have this assembly dissolved at any moment.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[180]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Player_Romus: ""It is by my sword you live. I could have this assembly d..."*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Player_Romus: ""I can serve my people a lot more easily when I am not su..."*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can serve my people a lot more easily when I am not surrounded by constant disagreement.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[180]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my hope that the majority and opposition can find common ground. Otherwise, we are all lost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[164]` (Player_Romus), `[168]` (Player_Romus), `[179]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[213]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, my comrades.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "The Delegates looked puzzled. A few applauded."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 2)"*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player_Romus: ""Until next time, my comrades.""*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Player_Romus: ""I bid you farewell until next time.""*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""Thank you, and God bless our troops.""*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Player_Romus: ""Thank you, and God bless you all.""*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless our troops.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Narrator: "Hugo and the Delegates quietly repeated the phrase."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless you all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The Delegates politely applauded."*)

### Węzeł `[208]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bid you farewell until next time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The Delegates politely applauded."*)

### Węzeł `[209]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, see you for dinner at ours next week.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Narrator: "Manus' face reddened. He nodded and left his podium."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve)"*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Player_Romus: ""Mr. Sazon, see you for dinner at ours next week.""*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and Glovurius axa Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[181]` (Player_Romus), `[182]` (Player_Romus), `[183]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "Hugo and the Delegates repeated the phrase."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "Hugo and the Delegates repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[215]`
Mówca: **Narrator**
> "Hugo and the Delegates quietly repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "The Delegates looked puzzled. A few applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[217]`
Mówca: **Narrator**
> "Manus' face reddened. He nodded and left his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "The Delegates politely applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""Then until next time, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Manus Sazon: ""Glovurius axa Rizia.""*)

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "I repeated the phrase along with Hugo and the other Deleg..."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "I repeated the phrase along with Hugo and the other Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[222]`
Mówca: **Sal Ignacius**
> ""It is not my wisdom, but that of the heavens above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[223]`
Mówca: **Narrator**
> "My uncle and I remained seated as the session adjourned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Player_Romus: ""Any thoughts on today's session, Your Grace?""*)
  - -> `[298]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)
  - -> `[309]` (*Player_Romus: ""I'd better get to work passing decrees.""*)
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_InviteSalToHOD == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player_Romus: ""I would like to ask Grand Wiseman Ignacius to conclude o..."*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_InviteSalToHOD == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I would like to ask Grand Wiseman Ignacius to conclude our session with a prayer.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true`
- **Kontekst wejściowy (poprzednik):** `[291]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Sal Ignacius: ""It would be an honor, Your Majesty.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In fact, I do. Madame Speaker, esteemed delegates...""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[291]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "The Delegates were all listening closely to me."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, I do not. This is your space, not mine.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn07_InviteSalToHOD"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[291]` (Daria de Rava)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Daria nodded graciously."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Daria nodded graciously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Daria de Rava: ""Then until next time, ladies and gentlemen.""*)

### Węzeł `[231]`
Mówca: **Narrator**
> "The Delegates were all listening closely to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[236]` (*Player_Romus: ""I respect the criticism you have expressed today and wil..."*)
  - -> `[260]` (*Player_Romus: ""I thank you for bringing my attention to the plight of t..."*)
  - -> `[261]` (*Player_Romus: ""I tire of your constant negativity. The next time we con..."*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand that the RNC now holds a delegate majority. However, that does not give you free rein to speak critically of your King.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""Do not forget that you are here to serve me. Not the oth..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[284]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Player_Romus: ""I understand that the RNC now holds a delegate majority...."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I respect the criticism you have expressed today and will take it to heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""You can expect prompt action from the Crown regarding th..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[284]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)

### Węzeł `[237]`
Mówca: **Sal Ignacius**
> ""It would be an honor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "Once more, Sal walked over to stand between the two House..."*)

### Węzeł `[238]`
Mówca: **Narrator**
> "Once more, Sal walked over to stand between the two House speakers. This time, he took each one by the hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Sal Ignacius: ""My beloved Delegates, do not let your differences preven..."*)

### Węzeł `[239]`
Mówca: **Sal Ignacius**
> ""My beloved Delegates, do not let your differences prevent you from recognizing the Divine in each other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Sal Ignacius: ""Remember, we are but one people, watching over this king..."*)

### Węzeł `[240]`
Mówca: **Sal Ignacius**
> ""Remember, we are but one people, watching over this kingdom by the great grace of our God, duty-bound to carry His truths into the mortal realm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Player_Romus: ""And the truths of His emissary, your sovereign king.""*)
  - -> `[255]` (*Player_Romus: ""And yet, let us not forget that some of those truths are..."*)
  - -> `[257]` (*Player_Romus: ""Your wisdom is inspiring, Grand Wiseman.""*)
  - -> `[242]` (*Player_Romus: ""Halaita.""*)

### Węzeł `[241]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And the truths of His emissary, your sovereign king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Sal Ignacius: ""Hrm. Yes.""*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Halaita.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_Halaita += 1"*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Player_Romus: ""I will remind you that we are at war. And during a war, ..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Player_Romus: ""As members of one of the world's few remaining monarchis..."*)

### Węzeł `[246]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not forget that you are here to serve me. Not the other way around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[261]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You can expect prompt action from the Crown regarding the matters you brought up today.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Player_Romus), `[260]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even -- especially -- in the midst of war, we cannot neglect our internal welfare.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[236]` (Player_Romus), `[260]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what is going on around us, we cannot neglect our internal welfare.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[236]` (Player_Romus), `[260]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As members of one of the world's few remaining monarchist governments, I expect you to stand behind me no matter what.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[261]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[253]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[252]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""Even -- especially -- in the midst of war, we cannot neg..."*)

### Węzeł `[253]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Player_Romus: ""No matter what is going on around us, we cannot neglect ..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is by my sword you live. I could have this assembly dissolved at any moment.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[261]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And yet, let us not forget that some of those truths are more truthful than others.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Sal Ignacius: ""Hrm. Yes.""*)

### Węzeł `[256]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will remind you that we are at war. And during a war, you stand behind your king no matter what.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[261]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Your wisdom is inspiring, Grand Wiseman.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[240]` (Sal Ignacius)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Sal Ignacius: ""It is not my wisdom, but that of the heavens above.""*)

### Węzeł `[258]`
Mówca: **Narrator**
> "Hugo and everyone else in the room repeated the word after me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[259]`
Mówca: **Sal Ignacius**
> ""Hrm. Yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I thank you for bringing my attention to the plight of the less fortunate in my kingdom.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus: ""You can expect prompt action from the Crown regarding th..."*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[284]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I tire of your constant negativity. The next time we convene in these chambers, I would like to hear only good news.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[231]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Player_Romus: ""Do not forget that you are here to serve me. Not the oth..."*)
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[284]` (*Player_Romus: ""It is my hope that the majority and opposition can find ..."*)
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_TyrantKing == true"*)
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_TyrantKing == true)"*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_TyrantKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_TyrantKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Romus: ""It is by my sword you live. I could have this assembly d..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_TyrantKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Player_Romus: ""I can serve my people a lot more easily when I am not su..."*)

### Węzeł `[265]`
Mówca: **Narrator**
> "The Delegates looked puzzled. A few applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless you all.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "The Delegates politely applauded."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time, my comrades.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Narrator: "The Delegates looked puzzled. A few applauded."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and God bless our troops.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Pales_War"] == true`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Hugo and the Delegates quietly repeated the phrase."*)

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bid you farewell until next time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Narrator: "The Delegates politely applauded."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon, see you for dinner at ours next week.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Narrator: "Manus' face reddened. He nodded and left his podium."*)

### Węzeł `[271]`
Mówca: **Sal Ignacius**
> ""It is not my wisdom, but that of the heavens above.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Hugo and the Delegates quietly repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[273]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Pales_War == true)"*)

### Węzeł `[274]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Pales_War == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Pales_War"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Player_Romus: ""Thank you, and God bless our troops.""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Pales_War == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Pales_War"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Player_Romus: ""Thank you, and God bless you all.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can serve my people a lot more easily when I am not surrounded by constant disagreement.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_TyrantKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[261]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[279]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Malenyevist > 2)"*)

### Węzeł `[278]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist > 2`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""Until next time, my comrades.""*)

### Węzeł `[279]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Malenyevist > 2)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Malenyevist"] > 2) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Player_Romus: ""I bid you farewell until next time.""*)

### Węzeł `[280]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[282]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_VinaManus_Approve)"*)

### Węzeł `[281]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_VinaManus_Approve`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_VinaManus_Approve"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""Mr. Sazon, see you for dinner at ours next week.""*)

### Węzeł `[282]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_VinaManus_Approve)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_VinaManus_Approve"]) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, and Glovurius axa Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[246]` (Player_Romus), `[247]` (Player_Romus), `[248]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Said_GlovuriusAxaRizia += 1"*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It is my hope that the majority and opposition can find common ground. Otherwise, we are all lost.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[232]` (Player_Romus), `[236]` (Player_Romus), `[260]` (Player_Romus)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_VinaManus_Approve"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist > 2"*)
  - -> `[273]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)
  - -> `[283]` (*Player_Romus: ""Thank you, and Glovurius axa Rizia.""*)

### Węzeł `[285]`
Mówca: **Narrator**
> "Hugo and the Delegates repeated the phrase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[286]`
Mówca: **Narrator**
> "Manus' face reddened. He nodded and left his podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[287]`
Mówca: **Narrator**
> "The Delegates politely applauded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[288]`
Mówca: **Daria de Rava**
> ""Glovurius axa Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Narrator: "I repeated the phrase along with Hugo and the other Deleg..."*)

### Węzeł `[289]`
Mówca: **Narrator**
> "I repeated the phrase along with Hugo and the other Delegates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[290]`
Mówca: **Daria de Rava**
> ""Then until next time, ladies and gentlemen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Daria de Rava: ""Glovurius axa Rizia.""*)

### Węzeł `[291]`
Mówca: **Daria de Rava**
> ""Unless, of course, His Majesty had any closing remarks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[292]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well. Seems like Rizia is doing better than ever.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[293]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What a waste of time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false` AND `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Hugo Toras: ""To put it mildly.""*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're screwed, aren't we?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Hugo Toras: ""I would not put it so crassly.""*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[297]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)

### Węzeł `[297]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[298]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)
  - -> `[300]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion < 0)"*)

### Węzeł `[299]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player_Romus: ""We're screwed, aren't we?""*)

### Węzeł `[300]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Player_Romus: ""Well. Seems like Rizia is doing better than ever.""*)
  - -> `[301]` (*Player_Romus: ""So everybody loves me. That's a relief.""*)

### Węzeł `[301]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So everybody loves me. That's a relief.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Hugo Toras: ""Be careful, Your Majesty. You cannot afford to fall into..."*)

### Węzeł `[302]`
Mówca: **Hugo Toras**
> ""To hear the Sazon boy tell it, yes. But do you trust him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[303]`
Mówca: **Hugo Toras**
> ""I would not put it so crassly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""Be careful, Your Majesty. You cannot afford to fall into complacency.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""House of Delegates? More like House of Irrelevance.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true` AND `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Hugo suppressed a laugh."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Player_Romus: ""House of Delegates? More like House of Irrelevance.""*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Player_Romus: ""What a waste of time.""*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd better get to work passing decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Hugo Toras: ""To hear the Sazon boy tell it, yes. But do you trust him?""*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Hugo Toras: ""Apparently, yes.""*)

### Węzeł `[313]`
Mówca: **Hugo Toras**
> ""Apparently, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Hugo Toras: ""Be careful how much you capitulate to the RPP. Their vic..."*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Hugo Toras: ""The RNC has some good proposals. But you needn't give Ba..."*)

### Węzeł `[317]`
Mówca: **Hugo Toras**
> ""Be careful how much you capitulate to the RPP. Their victory is already getting to Mr. Sazon's head.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[318]`
Mówca: **Hugo Toras**
> ""The RNC has some good proposals. But you needn't give Baroness de Rava everything she is asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Hugo suppressed a laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Hugo Toras: ""I keep telling you, Your Majesty. Your presence is not r..."*)

### Węzeł `[320]`
Mówca: **Hugo Toras**
> ""I keep telling you, Your Majesty. Your presence is not required at these sessions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Player_Romus: ""I know. I just felt like a good laugh.""*)
  - -> `[350]` (*Player_Romus: ""I disagree. The Delegates need to be reminded whom they ..."*)
  - -> `[351]` (*Player_Romus: ""I was kidding. It's always useful to hear how the public..."*)
  - -> `[352]` (*Player_Romus: ""You're absolutely right. I should listen to you more oft..."*)

### Węzeł `[321]`
Mówca: **Hugo Toras**
> ""To put it mildly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Hugo Toras: ""I keep telling you, Your Majesty. Your presence is not r..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Any thoughts on today's session, Your Grace?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[223]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[323]`
Mówca: **Hugo Toras**
> ""The Sazon boy is getting overconfident since his election win. I would be careful of how much you capitulate to his party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Narrator: "He kept his eyes on the Delegates as they left the hall."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Hugo Toras: ""The Sazon boy is getting overconfident since his electio..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Hugo Toras: ""Baroness de Rava is handling the House as capably as eve..."*)

### Węzeł `[327]`
Mówca: **Narrator**
> "He kept his eyes on the Delegates as they left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)

### Węzeł `[328]`
Mówca: **Hugo Toras**
> ""Having said that... the concerns he raised about the public's discontent were valid. We should find a way to mollify them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion < 0 )"*)

### Węzeł `[330]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion < 0 )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[334]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Hugo Toras: ""Having said that... the concerns he raised about the pub..."*)

### Węzeł `[334]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Hugo Toras: ""The concerns he raised about public discontent were over..."*)

### Węzeł `[335]`
Mówca: **Hugo Toras**
> ""The concerns he raised about public discontent were overblown, if you ask me. I would not worry about the state of the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Hugo Toras: ""And I don't trust his assessment of public opinion. The ..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Hugo Toras: ""Having said that, I do trust his assessment of the publi..."*)

### Węzeł `[339]`
Mówca: **Hugo Toras**
> ""And I don't trust his assessment of public opinion. The whispers I've been hearing tell a very different story.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[340]`
Mówca: **Hugo Toras**
> ""Having said that, I do trust his assessment of the public's opinion. It is consistent with what I've been hearing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[341]`
Mówca: **Hugo Toras**
> ""Baroness de Rava is handling the House as capably as ever. But a certain opposition speaker is getting a little too confident for comfort.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Narrator: "He kept his eyes on the Delegates as they left the hall."*)

### Węzeł `[342]`
Mówca: **Narrator**
> "He kept his eyes on the Delegates as they left the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion < 0"*)

### Węzeł `[343]`
Mówca: **Narrator**
> "He picked up his attache case and paused to look at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[344]`
Mówca: **Hugo Toras**
> ""Having said that... the concerns raised about the public's discontent were valid. We should find a way to mollify them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_HouseToras < 0"*)
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_HouseToras < 0)"*)

### Węzeł `[346]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_HouseToras < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_HouseToras"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Hugo Toras: ""Having said that... the concerns raised about the public..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_HouseToras < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_HouseToras"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Hugo Toras: ""The concerns that were raised about public discontent ar..."*)

### Węzeł `[348]`
Mówca: **Hugo Toras**
> ""The concerns that were raised about public discontent are overblown, if you ask me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I know. I just felt like a good laugh.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Hugo Toras: ""You have more pressing priorities than laughter, Your Ma..."*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I disagree. The Delegates need to be reminded whom they answer to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Hugo Toras: ""Ideally, my presence should serve as that reminder.""*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was kidding. It's always useful to hear how the public is doing.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Hugo Toras: ""As long as you remember that what you're hearing may not..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're absolutely right. I should listen to you more often.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[320]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Hugo Toras: ""I am your Grand Vizier. Trust me to fulfill my function.""*)

### Węzeł `[353]`
Mówca: **Hugo Toras**
> ""As long as you remember that what you're hearing may not reflect the truth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[354]`
Mówca: **Hugo Toras**
> ""You have more pressing priorities than laughter, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[355]`
Mówca: **Hugo Toras**
> ""Ideally, my presence should serve as that reminder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[356]`
Mówca: **Hugo Toras**
> ""I am your Grand Vizier. Trust me to fulfill my function.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He picked up his attache case and paused to look at me."*)

### Węzeł `[357]`
Mówca: **Hugo Toras**
> ""It's been a while since the two of us caught up. I hope you'll do me the honor of paying me a private visit once you're back from your trip to Derdia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""If you have something to say to me, you should say it he..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC...."*)
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[366]` (*Player_Romus: ""The honor would be all mine, Your Grace.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you have something to say to me, you should say it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras), `[428]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Hugo Toras: ""There are some matters that are best kept in the family.""*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as no wine is involved, I'd love to.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false) == false`
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras), `[428]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC...."*)
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDL..."*)

### Węzeł `[361]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Player_Romus: ""As long as wine is involved, I'd love to.""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC.Trait_SoberKing == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""As long as no wine is involved, I'd love to.""*)

### Węzeł `[363]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""As long as wine is involved, I'd love to.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValues_FellOffWagon"] == true  or  Variable["RiziaDLC.Trait_SoberKing"] == false`
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras), `[428]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[364]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the Derdians don't kill me? Sure thing.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[365]`
Mówca: **Hugo Toras**
> ""There are some matters that are best kept in the family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The honor would be all mine, Your Grace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras), `[428]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[367]`
Mówca: **Narrator**
> "Hugo rose and bowed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Hugo Toras: ""Until then, Your Majesty.""*)

### Węzeł `[368]`
Mówca: **Hugo Toras**
> ""Until then, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Hugo Toras");"*)

### Węzeł `[369]`
Mówca: **Narrator**
> "I stayed in my seat until the room was completely empty."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion > 0"*)

### Węzeł `[370]`
Mówca: **Narrator**
> "Was Manus right? Was my public happy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Narrator: "And if he was, where would I go from here?"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Country_PublicOpinion > 0"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Country_PublicOpinion > 0)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Country_PublicOpinion > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Country_PublicOpinion"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Country_PublicOpinion > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Country_PublicOpinion"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[376]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[375]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Narrator: "Was Manus right? Was my public happy with my reign?"*)

### Węzeł `[376]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Narrator: "Was Daria right? Was my public happy with my reign?"*)

### Węzeł `[377]`
Mówca: **Narrator**
> "And if he was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaD..."*)

### Węzeł `[378]`
Mówca: **Narrator**
> "Was Daria right? Was my public happy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Narrator: "And if she was, where would I go from here?"*)

### Węzeł `[379]`
Mówca: **Narrator**
> "And if she was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaD..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats == true"*)
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.HouseElections_RPPWinsSeats == true)"*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.HouseElections_RPPWinsSeats == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Narrator: "Was Manus right? Was my public unhappy with my reign?"*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.HouseElections_RPPWinsSeats == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.HouseElections_RPPWinsSeats"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Narrator: "Was Daria right? Was my public unhappy with my reign?"*)

### Węzeł `[383]`
Mówca: **Narrator**
> "Was Manus right? Was my public unhappy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Narrator: "And if he was, where would I go from here?"*)

### Węzeł `[384]`
Mówca: **Narrator**
> "And if he was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaD..."*)

### Węzeł `[385]`
Mówca: **Narrator**
> "Was Daria right? Was my public unhappy with my reign?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Narrator: "And if she was, where would I go from here?"*)

### Węzeł `[386]`
Mówca: **Narrator**
> "And if she was, where would I go from here?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaD..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Trait_FunnyKing == true"*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Trait_FunnyKing == true)"*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Trait_FunnyKing == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Trait_FunnyKing"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Player_Romus: ""If the Derdians don't kill me? Sure thing.""*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Trait_FunnyKing == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Player_Romus: ""I can't promise you anything. Who knows if I'll make it ..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can't promise you anything. Who knows if I'll make it back from Derdia alive.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Trait_FunnyKing"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[357]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Narrator: "Hugo rose and bowed."*)

### Węzeł `[391]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[392]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");

// Adds the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Manus Sazon, positioned behind the House Speaker podium, ..."*)

### Węzeł `[393]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "Daria de Rava, positioned behind the House Speaker podium..."*)

### Węzeł `[394]`
Mówca: **Narrator**
> "Daria forced a smile from behind the opposition podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]` (*Węzeł Logiki Narracyjnej: "AddConversant("Daria de Rava");  // Adds the conversant w..."*)

### Węzeł `[395]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Daria de Rava");

// Adds the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `AddConversant("Daria de Rava");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]` (*Daria de Rava: ""Yes. On behalf of both of our parties, your presence is ..."*)

### Węzeł `[396]`
Mówca: **Daria de Rava**
> ""Yes. On behalf of both of our parties, your presence is much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[397]`
Mówca: **Narrator**
> "She nodded at Manus, who flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[398]`
Mówca: **Narrator**
> "Manus nodded his assent from his usual place behind the opposition podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Węzeł Logiki Narracyjnej: "AddConversant("Manus Sazon");"*)

### Węzeł `[399]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_InviteSalToHOD == true"*)

### Węzeł `[400]`
Mówca: **Narrator**
> "Daria flipped open a binder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[401]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `AddConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `AddConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Narrator: "Standing between Manus and Daria, he opened his arms wide."*)

### Węzeł `[402]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Sal Ignacius");

// Adds the conversant with the character name in database`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Sal Ignacius");
-- Adds the conversant with the character name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.HouseElections_RPPWinsSeats"*)

### Węzeł `[403]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Sal Ignacius");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Daria de Rava");
RemoveConversant("Sal Ignacius");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Narrator: "My uncle and I remained seated as the session adjourned."*)

### Węzeł `[404]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Hugo Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "I stayed in my seat until the room was completely empty."*)

### Węzeł `[405]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[406]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn07_RH_MateusDeath = true; RiziaDLCSupport.News_Turn07_V_MateusDeath = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn07_RH_MateusDeath"] = true;
Variable["RiziaDLCSupport.News_Turn07_V_MateusDeath"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_WarProfitsTax == true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_WarProfitsTax == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_WarProfitsTax == true"*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_WarProfitsTax == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_RD_WarProfitsTax = true; RiziaDLC..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_WarProfitsTax == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_WarProfitsTax"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Re..."*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_RD_WarProfitsTax = true; RiziaDLCSupport.News_RD_RH_WarProfitsTax = true;
RiziaDLCSupport.News_RD_V_WarProfitsTax = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_RD_WarProfitsTax"] = true;
Variable["RiziaDLCSupport.News_RD_RH_WarProfitsTax"] = true;
Variable["RiziaDLCSupport.News_RD_V_WarProfitsTax"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Re..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_ImpasseLight","R_ImpasseLight_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "Once more, I took my seat next to Hugo in the middle of t..."*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Re..."*)
  - -> `[414]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC...."*)

### Węzeł `[413]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[414]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_Together == true || (RiziaDLC.Relations_Pabel_OutedToPlayer == true && RiziaDLC.Relations_Pabel > 0))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_Together"] == true  or  (Variable["RiziaDLC.Relations_Pabel_OutedToPlayer"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 0)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexual..."*)

### Węzeł `[415]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Enable_Policy_RD_Welfare_DecriminalizeHomosexuality"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "The Delegates murmured the word as well. Sal shuffled bac..."*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Hugo and everyone else in the room repeated the word afte..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_Halaita += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_Halaita"] = Variable["RiziaDLC.Said_Halaita"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Narrator: "Hugo and everyone else in the room repeated the word afte..."*)

### Węzeł `[419]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Daria ..."*)

### Węzeł `[420]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Said_GlovuriusAxaRizia += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Said_GlovuriusAxaRizia"] = Variable["RiziaDLC.Said_GlovuriusAxaRizia"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Narrator: "Hugo and the Delegates repeated the phrase."*)

### Węzeł `[421]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)
  - -> `[423]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)"*)

### Węzeł `[422]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Pales_War == true"*)

### Węzeł `[423]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[424]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Facing parliament after the elections", "House of Delegates", "Porte Drazon");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Facing parliament after the elections","House of Delegates","Porte Drazon");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)

### Węzeł `[425]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true"*)
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)"*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Hugo Toras: ""It's been a while since the two of us caught up. I hope ..."*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn07_DerdianDiplomaticVisit"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Hugo Toras: ""It's been a while since the two of us caught up. I hope ..."*)

### Węzeł `[428]`
Mówca: **Hugo Toras**
> ""It's been a while since the two of us caught up. I hope you'll do me the honor of paying me a private visit one of these days.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Player_Romus: ""If you have something to say to me, you should say it he..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValues_FellOffWagon == true || RiziaDLC...."*)
  - -> `[366]` (*Player_Romus: ""The honor would be all mine, Your Grace.""*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_ImpasseLight", "R_ImpasseLight_Loop");"*)
