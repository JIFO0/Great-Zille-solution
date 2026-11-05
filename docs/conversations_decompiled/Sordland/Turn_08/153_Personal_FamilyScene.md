# Sordland/Turn08/Personal_FamilyScene

- **ID konwersacji:** `153`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 08`
- **Lokalizacja pliku:** `Sordland/Turn_08/153_Personal_FamilyScene.md`
- **Liczba węzłów dialogowych:** 455
- **Liczba wyborów gracza:** 119

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Archetype_ComradeRayne`
- `BaseGame.Arrest_FetihEjall`
- `BaseGame.BFF_Damaged`
- `BaseGame.BFF_Destroyed`
- `BaseGame.BFF_EliminationOperation`
- `BaseGame.BFF_EliminationOperation_Botched`
- `BaseGame.BFF_Threatens_President`
- `BaseGame.Bergia_Governor_Bron`
- `BaseGame.Bergia_Governor_Ersen`
- `BaseGame.Bergia_Governor_Krull`
- `BaseGame.Bludish_Opinion`
- `BaseGame.ChiefJustice_OvidGrecer`
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn08_VPSelection_Albin`
- `BaseGame.Petr_isVP`
- `BaseGame.Policy_Law_Ban_RedYouth`
- `BaseGame.Policy_Law_Ban_WPB`
- `BaseGame.Policy_Order_IncreasedInteriorFunding`
- `BaseGame.Public_Opinion`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_BludishRights_Amendment_Proposal`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation`
- `BaseGame.Reform_Reform_Court_Success`
- `BaseGame.Reform_Turn08_Decree_WomensRights`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Petr_ShareBlameForLeak`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Situation_Law_ExcellentWomenRights`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Unrest_WillHappen`
- `BaseGame.WomensRightCommission`
- `BaseGame.YoungSords_Aids_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.BFF_Threatens_President`
- `BaseGame.Unrest_BFF_WillHappen`
- `BaseGame.Unrest_WillHappen`
- `BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY`
- `BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[41]` | **""What are you reading?""** | `[15]` **Narrator**: "I entered the grand study and le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[44]` **Monica**: ""Oh. I didn't realize you were h..." |
| `[42]` | **""I must say, you seem to have quite the fondness for these dusty tomes.""** | `[15]` **Narrator**: "I entered the grand study and le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Monica**: ""Oh. I didn't realize you were h..." |
| `[43]` | **"Sit in the armchair next to hers."** | `[15]` **Narrator**: "I entered the grand study and le..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Monica**: ""Oh. I didn't realize you were h..." |
| `[67]` | **""Are you becoming a Malenyevist, my dear?""** | `[63]` **Monica**: ""It's about the women's struggle..." | `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false` | *Brak zmian stanu* | `[82]` **Monica**: ""This isn't about that."" |
| `[68]` | **""From the presidential library, really? I'm surprised they keep any books about th..."** | `[63]` **Monica**: ""It's about the women's struggle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Monica**: ""To be honest, I was surprised t..." |
| `[69]` | **""Seems like Valgish propaganda to me. I'd take its contents with a grain of salt.""** | `[63]` **Monica**: ""It's about the women's struggle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Monica**: ""I mean... That may be true. But..." |
| `[70]` | **""That actually sounds like a great read.""** | `[63]` **Monica**: ""It's about the women's struggle..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Monica**: ""It is. Especially the part abou..." |
| `[71]` | **""But what is it? Can't you at least tell me?""** | `[48]` **Narrator**: "Her voice was cold as she spoke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Narrator**: "She let out a deep sigh." |
| `[72]` | **""What's wrong?""** | `[48]` **Narrator**: "Her voice was cold as she spoke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Monica**: ""Really, Anton?"" |
| `[73]` | **""Whatever.""** | `[48]` **Narrator**: "Her voice was cold as she spoke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "We both sat by the fireplace in ..." |
| `[74]` | **"Stay silent."** | `[48]` **Narrator**: "Her voice was cold as she spoke." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "We both sat by the fireplace in ..." |
| `[92]` | **""Petr who? My new vice president is doing a much better job.""** | `[88]` **Monica**: ""Especially after everything tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Monica**: ""Is that really how you feel, An..." |
| `[93]` | **""I don't want to talk about him. I hope you understand.""** | `[88]` **Monica**: ""Especially after everything tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Monica**: ""I do understand..."" |
| `[94]` | **""I'll be honest. The palace does feel a lot more uncomfortable and intimidating wi..."** | `[88]` **Monica**: ""Especially after everything tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Monica**: ""I understand. But honestly, may..." |
| `[95]` | **""I wish it had all gone differently.""** | `[88]` **Monica**: ""Especially after everything tha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[421]` **Monica**: ""I understand. But honestly, may..." |
| `[104]` | **""I won't believe that until I see it with my own eyes.""** | `[103]` **Monica**: ""Apparently, he's been coming ho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Monica**: ""That was exactly my response to..." |
| `[105]` | **""Really? That's good to know. He did promise me he'd work harder.""** | `[103]` **Monica**: ""Apparently, he's been coming ho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[420]` **Monica**: ""Seems like he's following throu..." |
| `[106]` | **""I'm glad he's actually doing his part for once. It's been a madhouse at the palac..."** | `[103]` **Monica**: ""Apparently, he's been coming ho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Monica**: ""I see."" |
| `[109]` | **""He wasn't forgiven. By me or anyone else.""** | `[101]` **Monica**: ""And I don't think he should be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Monica**: ""I know."" |
| `[110]` | **""I won't defend what he did, but he's still my friend. And he's facing the consequ..."** | `[101]` **Monica**: ""And I don't think he should be ..." | `Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true` | *Brak zmian stanu* | `[117]` **Monica**: ""I know. I'm sorry."" |
| `[114]` | **""I knew Petr had his problems, Monica. But he was -- is -- my closest friend. I do..."** | `[101]` **Monica**: ""And I don't think he should be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Monica**: ""I know. I'm sorry."" |
| `[115]` | **""You're right. I should have listened to you back in the day.""** | `[101]` **Monica**: ""And I don't think he should be ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Monica**: ""Isn't that always the moral of ..." |
| `[129]` | **""That actually sounds marvelous, Monica. Let's make the arrangements.""** | `[127]` **Monica**: ""We can have a weekend retreat a..."<br>`[128]` **Monica**: ""We can have a weekend retreat o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Monica**: ""Great!"" |
| `[130]` | **""It's a nice idea, but I'll have to check my schedule. I *am* very busy, you know.""** | `[127]` **Monica**: ""We can have a weekend retreat a..."<br>`[128]` **Monica**: ""We can have a weekend retreat o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Monica**: ""Okay..."" |
| `[131]` | **""Just the two of us?""** | `[127]` **Monica**: ""We can have a weekend retreat a..."<br>`[128]` **Monica**: ""We can have a weekend retreat o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Monica**: ""Well... Franc's not around anym..." |
| `[149]` | **""What have you got there, darling?""** | `[148]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Deana unfolded the paper and sta..." |
| `[150]` | **""What is it?""** | `[148]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Deana unfolded the paper and sta..." |
| `[151]` | **"Wait for her to continue."** | `[148]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[152]` **Narrator**: "Deana unfolded the paper and sta..." |
| `[157]` | **""It's alright, my love. Just give it here.""** | `[155]` **Deana**: ""We advise all of you to tread c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "She reluctantly approached us wi..." |
| `[158]` | **""Deana! Give me that paper right now!""** | `[155]` **Deana**: ""We advise all of you to tread c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Narrator**: "She reluctantly approached us wi..." |
| `[159]` | **"Let her continue."** | `[155]` **Deana**: ""We advise all of you to tread c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Deana**: ""The safety you have enjoyed so ..." |
| `[167]` | **""I don't know, sweetie. It's just a bunch of words that don't make sense. It must ..."** | `[160]` **Deana**: ""Papa. Why does it say that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "I took the letter from her grasp..." |
| `[168]` | **""They are all lies, Deana.""** | `[160]` **Deana**: ""Papa. Why does it say that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "I took the letter from her grasp..." |
| `[169]` | **""It's okay, darling. This is nothing for you to worry about.""** | `[160]` **Deana**: ""Papa. Why does it say that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "I took the letter from her grasp..." |
| `[177]` | **""I'm sure it's nothing to worry about.""** | `[175]` **Monica**: ""What are we going to do, Anton?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Monica**: ""Are you insane? This letter is ..." |
| `[179]` | **""Deana, this letter is from some misguided individuals. We won't let them get thei..."** | `[160]` **Deana**: ""Papa. Why does it say that you ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "I took the letter from her grasp..." |
| `[180]` | **""I'll check in with the presidential guard. This should never even have reached us..."** | `[175]` **Monica**: ""What are we going to do, Anton?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Monica**: ""We can't be too cautious. The l..." |
| `[181]` | **""I won't let fear dictate our actions, Monica. If there's truly a threat, we will ..."** | `[175]` **Monica**: ""What are we going to do, Anton?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[183]` **Monica**: ""Are you insane? This letter is ..." |
| `[182]` | **""Don't worry, Monica. I'll inform the authorities and take every necessary precaut..."** | `[175]` **Monica**: ""What are we going to do, Anton?..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Monica**: ""We can't be too cautious. The l..." |
| `[188]` | **""Well done, Deana. You've shown incredible courage. Thank you for bringing this to..."** | `[187]` **Deana**: ""I found it in the living room w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Deana**: ""Papa, what's going on?"" |
| `[189]` | **""It's okay, sweetheart. But next time, please talk to me or your mother before tou..."** | `[187]` **Deana**: ""I found it in the living room w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Deana**: ""Papa, what's going on?"" |
| `[190]` | **"Console her."** | `[187]` **Deana**: ""I found it in the living room w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Deana**: ""Papa, what's going on?"" |
| `[194]` | **""Deana, we've received a letter from some people called the BFF. They want to do b..."** | `[193]` **Narrator**: "She spoke innocently, but I coul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[212]` **Deana**: ""But daddy, we're good people. A..." |
| `[211]` | **""No, darling. I haven't done anything wrong. The people who wrote this do not beli..."** | `[193]` **Narrator**: "She spoke innocently, but I coul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[217]` **Deana**: ""But that's not fair, Papa. Our ..." |
| `[213]` | **""Sometimes, people fear what they don't understand. But we won't let that fear def..."** | `[212]` **Deana**: ""But daddy, we're good people. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[215]` | **""Yes, darling. Some people think I've done bad things and now they are trying to s..."** | `[193]` **Narrator**: "She spoke innocently, but I coul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Deana**: ""But you wouldn't really do anyt..." |
| `[216]` | **""Some matters are best left for the grown-ups.""** | `[193]` **Narrator**: "She spoke innocently, but I coul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[219]` **Deana**: ""But I want to understand, Papa...." |
| `[220]` | **""Yes, my girl. Our country is meant to protect its people, but sometimes there are..."** | `[217]` **Deana**: ""But that's not fair, Papa. Our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[221]` | **""Oh, Deana. I strive to be the best I can be, but sometimes people have different ..."** | `[218]` **Deana**: ""But you wouldn't really do anyt..."<br>`[233]` **Deana**: ""Have you really done something ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[222]` | **""Even your papa can make mistakes sometimes, Deana. What's important is to remembe..."** | `[218]` **Deana**: ""But you wouldn't really do anyt..."<br>`[233]` **Deana**: ""Have you really done something ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[223]` | **""You're right. You're growing into such a remarkable young woman. Tell me. What do..."** | `[219]` **Deana**: ""But I want to understand, Papa...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[233]` **Deana**: ""Have you really done something ..." |
| `[224]` | **""There are complex issues and disagreements in our country, and sometimes it's bes..."** | `[219]` **Deana**: ""But I want to understand, Papa...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Narrator**: "Deana looked at me with a hint o..." |
| `[225]` | **""Some people have evil in their hearts, Deana. They don't care whether you're doin..."** | `[218]` **Deana**: ""But you wouldn't really do anyt..."<br>`[233]` **Deana**: ""Have you really done something ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[226]` | **""You're right. Our country protects all of us, Deana. But some people have evil in..."** | `[217]` **Deana**: ""But that's not fair, Papa. Our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[227]` | **""Trust me, Deana. It's best if you stay out of this.""** | `[219]` **Deana**: ""But I want to understand, Papa...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Narrator**: "Deana's lower lip trembled. I sa..." |
| `[228]` | **""Sometimes our country doesn't function the way it's supposed to, Deana. And when ..."** | `[217]` **Deana**: ""But that's not fair, Papa. Our ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[229]` | **""Oh, Deana. I strive to be the best I can be, but sometimes people have different ..."** | `[212]` **Deana**: ""But daddy, we're good people. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[230]` | **""Some people have evil in their hearts, Deana. They don't care whether you're doin..."** | `[212]` **Deana**: ""But daddy, we're good people. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |
| `[235]` | **""No, Deana. We will not let them win. We will take every precaution to keep our fa..."** | `[214]` **Deana**: ""So what are we going to do? We ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deana**: ""Okay..."" |
| `[236]` | **""There's nothing to win, Deana. Don't worry, nothing bad will happen as long as I'..."** | `[214]` **Deana**: ""So what are we going to do? We ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deana**: ""Okay..."" |
| `[237]` | **""Never, my dear. We will not surrender to fear or threats.""** | `[214]` **Deana**: ""So what are we going to do? We ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deana**: ""Okay..."" |
| `[238]` | **""They're not bad people, just people with bad ideas. I will show them the right th..."** | `[214]` **Deana**: ""So what are we going to do? We ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[239]` **Deana**: ""Okay..."" |
| `[244]` | **""That's my girl! I can't wait to hear about it.""** | `[243]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "Deana unfolded the paper and gav..." |
| `[245]` | **""Very well. Bring it here and let's assess your progress together.""** | `[243]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "Deana unfolded the paper and gav..." |
| `[246]` | **"Wait for her to continue."** | `[243]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Narrator**: "Deana unfolded the paper and gav..." |
| `[249]` | **""Oh no, not the dreaded report!""** | `[243]` **Narrator**: "Monica and I immediately turned ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Narrator**: "Deana chuckled and gave the pape..." |
| `[251]` | **""That's incredible, Deana! You've worked hard and it shows.""** | `[254]` **Narrator**: "I heard a mix of pride and disap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "Deana smiled." |
| `[252]` | **""*Almost* doesn't count, honey. Sounds like you've got to try harder.""** | `[254]` **Narrator**: "I heard a mix of pride and disap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[258]` **Deana**: ""I know..."" |
| `[253]` | **""Congratulations, my girl! But you know I'd love you even if you got bad grades, r..."** | `[254]` **Narrator**: "I heard a mix of pride and disap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[257]` **Narrator**: "Deana smiled." |
| `[255]` | **""Oh my. We've got a genius in the house! Watch out, world, Holsord's number-two st..."** | `[254]` **Narrator**: "I heard a mix of pride and disap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[256]` **Narrator**: "Deana chuckled." |
| `[267]` | **""That's great to hear! I wish your brother had your brains.""** | `[254]` **Narrator**: "I heard a mix of pride and disap..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Deana**: ""Mama says Franc's smart in a di..." |
| `[274]` | **""Wait. Did you just say Clavin?""** | `[273]` **Deana**: ""I told you about him, Mommy. Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Deana**: ""Yes. That's his last name."" |
| `[275]` | **""Your mother's right, Deana. Forget about it. You've already done great.""** | `[273]` **Deana**: ""I told you about him, Mommy. Ma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Deana**: ""Okay."" |
| `[276]` | **""Oh, really? Maybe I should have a talk with your school.""** | `[273]` **Deana**: ""I told you about him, Mommy. Ma..."<br>`[277]` **Deana**: ""Yes. That's his last name."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Deana**: ""What do you mean by talk, Papa?"" |
| `[280]` | **""Actually, I may know his father...""** | `[277]` **Deana**: ""Yes. That's his last name.""<br>`[284]` **Deana**: ""Do you know him?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[293]` **Deana**: ""Really?"" |
| `[281]` | **""Interesting...""** | `[277]` **Deana**: ""Yes. That's his last name."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[284]` **Deana**: ""Do you know him?"" |
| `[282]` | **""Anyway, it doesn't matter, Deana. You've already done great. Don't mind that kid.""** | `[277]` **Deana**: ""Yes. That's his last name.""<br>`[284]` **Deana**: ""Do you know him?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[283]` **Deana**: ""Okay."" |
| `[294]` | **""He did what?""** | `[279]` **Deana**: ""Please don't come to the school..."<br>`[295]` **Deana**: ""His father came to the school a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Deana**: ""I already told you!"" |
| `[296]` | **""Are you serious, sweetie?""** | `[279]` **Deana**: ""Please don't come to the school..."<br>`[295]` **Deana**: ""His father came to the school a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[346]` **Deana**: ""Why wouldn't I be?"" |
| `[297]` | **""He did, did he? Looks like I have a *lot* of talking to do.""** | `[279]` **Deana**: ""Please don't come to the school..."<br>`[295]` **Deana**: ""His father came to the school a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Deana**: ""Okay..."" |
| `[298]` | **""Some people just have bad manners, darling. You shouldn't pay attention to them.""** | `[279]` **Deana**: ""Please don't come to the school..."<br>`[295]` **Deana**: ""His father came to the school a..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[347]` **Deana**: ""Okay..."" |
| `[310]` | **""Don't worry, Monica. The anniversary won't even take place. All mass gatherings a..."** | `[309]` **Monica**: ""With everything going on in Ber..." | `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true` | *Brak zmian stanu* | `[319]` **Monica**: ""That's good to know."" |
| `[311]` | **""No, Monica. I cannot allow fear to dictate my actions. I cannot let the Bludish p..."** | `[309]` **Monica**: ""With everything going on in Ber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Monica**: ""You cannot simply decide that b..." |
| `[312]` | **""That's exactly what they want us to do, Monica. We cannot give in to their threat..."** | `[309]` **Monica**: ""With everything going on in Ber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Monica**: ""You cannot simply decide that b..." |
| `[316]` | **""Don't worry, Monica. I will not attend the anniversary. I will not take any risks.""** | `[309]` **Monica**: ""With everything going on in Ber..." | `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false` | *Brak zmian stanu* | `[319]` **Monica**: ""That's good to know."" |
| `[317]` | **""If I don't show support for the victims of Izzam now, I fear things may turn out ..."** | `[309]` **Monica**: ""With everything going on in Ber..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[318]` **Monica**: ""You cannot simply decide that b..." |
| `[320]` | **""Look. You have to trust me. If there is a threat, I will handle it.""** | `[318]` **Monica**: ""You cannot simply decide that b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Monica**: ""I don't really believe that aft..." |
| `[321]` | **""You're underestimating our forces and the power of the state. Nobody will let a b..."** | `[318]` **Monica**: ""You cannot simply decide that b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Monica**: ""I don't really believe that aft..." |
| `[322]` | **""Please, Monica. You have to understand me. This political mess can only be solved..."** | `[318]` **Monica**: ""You cannot simply decide that b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[325]` **Monica**: ""I don't really believe that aft..." |
| `[323]` | **""You know what? Maybe you're right.""** | `[318]` **Monica**: ""You cannot simply decide that b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[330]` **Monica**: ""Despite everything you've done,..."<br>`[324]` **Monica**: ""Please, Anton. Listen to me thi..." |
| `[332]` | **""No. They were never to be completely trusted. We must be careful.""** | `[326]` **Monica**: ""Do you think we can trust the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Monica**: ""You have to do something about ..." |
| `[333]` | **""No, Monica. I have great reservations about them after this letter. Don't worry, ..."** | `[326]` **Monica**: ""Do you think we can trust the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Monica**: ""You have to do something about ..." |
| `[334]` | **""We shouldn't jump to conclusions immediately. They are tasked with protecting our..."** | `[326]` **Monica**: ""Do you think we can trust the p..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[336]` **Monica**: ""Well, I don't trust them, Anton!"" |
| `[337]` | **""Don't worry. We'll weather this together. I will take the necessary measures.""** | `[335]` **Monica**: ""You have to do something about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Narrator**: "She did not respond. I knew what..." |
| `[338]` | **""Just let me do my job for once, Monica. I know what to do. You shouldn't keep wor..."** | `[335]` **Monica**: ""You have to do something about ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[344]` **Narrator**: "She did not respond. I knew what..." |
| `[339]` | **""I will. Don't worry.""** | `[335]` **Monica**: ""You have to do something about ..." | `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0` | *Brak zmian stanu* | `[344]` **Narrator**: "She did not respond. I knew what..." |
| `[343]` | **""I will, honey. I will.""** | `[335]` **Monica**: ""You have to do something about ..." | `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false` | *Brak zmian stanu* | `[344]` **Narrator**: "She did not respond. I knew what..." |
| `[351]` | **""There's no need for concern. People are just voicing their criticism.""** | `[350]` **Monica**: ""I'm worried that things may get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Monica**: ""I guess you're right."" |
| `[352]` | **""I'm aware. It concerns me as well. But I'll take all the necessary steps, don't y..."** | `[350]` **Monica**: ""I'm worried that things may get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[422]` **Monica**: ""I'm sure you can handle it."" |
| `[353]` | **""Well, there's nothing I can do about that. Can I?""** | `[350]` **Monica**: ""I'm worried that things may get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[355]` **Monica**: ""I guess you're right."" |
| `[354]` | **""They're just a bunch of traitors who are being supported by foreign powers. The m..."** | `[350]` **Monica**: ""I'm worried that things may get..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[356]` **Monica**: ""Listen to yourself. I think you..." |
| `[374]` | **""What is that supposed to mean?""** | `[365]` **Monica**: ""How do you keep finding men lik..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Monica**: ""Uh. Forget I asked."" |
| `[375]` | **""Come on, Monica. How would I know about any of this?""** | `[365]` **Monica**: ""How do you keep finding men lik..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[425]` **Monica**: ""I suppose you wouldn't."" |
| `[376]` | **""Just another male Sordish politician, Monica. You know how it is.""** | `[365]` **Monica**: ""How do you keep finding men lik..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Monica**: ""Oh, I know."" |
| `[377]` | **""Yes... He is the new Vice President.""** | `[365]` **Monica**: ""How do you keep finding men lik..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Monica**: ""Great."" |
| `[378]` | **""What does that supposed to mean?""** | `[366]` **Monica**: ""Why is your party still filled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[384]` **Monica**: ""Uh. Forget I asked."" |
| `[379]` | **""Come on, Monica. You know I can't control everything our members do.""** | `[366]` **Monica**: ""Why is your party still filled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[385]` **Monica**: ""Maybe you should have some cont..." |
| `[380]` | **""Just another male Sordish politician, Monica. You know how it is.""** | `[366]` **Monica**: ""Why is your party still filled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[382]` **Monica**: ""Oh, I know."" |
| `[381]` | **""Yes... That's him, all right.""** | `[366]` **Monica**: ""Why is your party still filled ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[383]` **Monica**: ""Great."" |
| `[394]` | **""Alright. See you at dinner, Monica.""** | `[390]` **Monica**: ""I think I'll continue my the bo..."<br>`[398]` **Monica**: ""Yes. I just want to read my book.""<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Narrator**: "I grabbed Deana's hand and walke..." |
| `[395]` | **""Is there something wrong?""** | `[390]` **Monica**: ""I think I'll continue my the bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Monica**: ""No! I just want to read, Anton."" |
| `[396]` | **""Now?""** | `[390]` **Monica**: ""I think I'll continue my the bo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[397]` **Monica**: ""What do you mean, *now*?"" |
| `[400]` | **""You can read it another time.""** | `[398]` **Monica**: ""Yes. I just want to read my book.""<br>`[399]` **Monica**: ""No! I just want to read, Anton."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[450]` **Monica**: ""Anton, please. Can you leave me..." |
| `[401]` | **""Fine.""** | `[398]` **Monica**: ""Yes. I just want to read my book.""<br>`[399]` **Monica**: ""No! I just want to read, Anton."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Narrator**: "I grabbed Deana's hand and walke..." |
| `[403]` | **""Great. I am starving.""** | `[393]` **Deana**: ""Yes!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[408]` **Monica**: ""Me too. Let's eat!"" |
| `[404]` | **""Rizian?""** | `[393]` **Deana**: ""Yes!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[407]` **Monica**: ""Yes. It's similar to Lespian fo..." |
| `[405]` | **""What? He couldn't come up with something Sordish?""** | `[393]` **Deana**: ""Yes!"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[406]` **Monica**: ""Oh, come on, Anton. It won't ki..." |
| `[423]` | **""It's 'retribution', sweetheart.""** | `[155]` **Deana**: ""We advise all of you to tread c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[424]` **Deana**: ""Yes. Retribution. Sorry."" |
| `[451]` | **""Even your papa can make mistakes sometimes, Deana. What's important is to remembe..."** | `[212]` **Deana**: ""But daddy, we're good people. A..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Deana**: ""So what are we going to do? We ..." |

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
  - -> `[454]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Spending some personal time with their o..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Ce..."*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = false"*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Policy_Order_IncreasedInteriorFunding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Policy_Order_IncreasedInteriorFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opin..."*)
  - -> `[8]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Op..."*)

### Węzeł `[7]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true))`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bludish_Opinion"] <= -12  or  (Variable["BaseGame.Bludish_Opinion"] <= -10  and  (Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = true"*)

### Węzeł `[8]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opinion <= -10 && (BaseGame.Bergia_Governor_Bron == true || BaseGame.Bergia_Governor_Krull == true)))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bludish_Opinion"] <= -12  or  (Variable["BaseGame.Bludish_Opinion"] <= -10  and  (Variable["BaseGame.Bergia_Governor_Bron"] == true  or  Variable["BaseGame.Bergia_Governor_Krull"] == true))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0"*)

### Węzeł `[9]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)
  - -> `[11]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == tr..."*)

### Węzeł `[10]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)

### Węzeł `[11]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bludish_Opinion <= -12 || (BaseGame.Bludish_Opin..."*)

### Węzeł `[12]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == tru..."*)
  - -> `[14]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == t..."*)

### Węzeł `[13]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF..."*)

### Węzeł `[14]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == true || BaseGame.Bludish_Opinion <= -15)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == true  or  Variable["BaseGame.Bludish_Opinion"] <= -15) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "I entered the grand study and let the warm glow of the room envelop me. Monica was sitting by the fireplace with a very old-looking book in her hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player: ""What are you reading?""*)
  - -> `[42]` (*Player: ""I must say, you seem to have quite the fondness for thes..."*)
  - -> `[43]` (*Player_Italic: "Sit in the armchair next to hers."*)

### Węzeł `[16]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[17]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen = false`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_BludishRights_Amendment_Proposal == tru..."*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Refo..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_BludishRights_Amendment_Proposal == true && BaseGame.Reform_Reform_Court_Success == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_BludishRights_Amendment_Proposal"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[21]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Ersen == true"*)
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Ersen == true)"*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Ersen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Ersen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Ersen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Ersen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_BludishRights_Amendment_Proposal == true ..."*)

### Węzeł `[24]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Refo..."*)
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Re..."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.ChiefJustice_OvidGrecer"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = false"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.ChiefJustice_OvidGrecer == true || BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.ChiefJustice_OvidGrecer"] == true  or  Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_F..."*)
  - -> `[29]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest..."*)

### Węzeł `[28]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  (Variable["BaseGame.Arrest_FetihEjall"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == false)  or  (Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.Situation_Law_BludishReconciliation"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President = true"*)

### Węzeł `[29]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_FetihEjall == true && BaseGame.Reform_Reform_Court_Success == false) || (BaseGame.BFF_EliminationOperation == true && BaseGame.BFF_Destroyed == false && BaseGame.Situation_Law_BludishReconciliation == false)
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true  or  (Variable["BaseGame.Arrest_FetihEjall"] == true  and  Variable["BaseGame.Reform_Reform_Court_Success"] == false)  or  (Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.Situation_Law_BludishReconciliation"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[30]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_BFF_WillHappen == true)"*)

### Węzeł `[31]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President = true"*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_BFF_WillHappen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_BFF_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true || (BaseGame.Arrest_F..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.BFF_Threatens_President"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "//"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Węzeł Logiki Narracyjnej: "PlayMusic("Mountains");"*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `//`
- **Efekt skryptowy (`userScript`):** `--;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged =..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= 0)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_WillHappen = true"*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[39]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_WillHappen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "As I stepped through the front door of our stately residence, a sense of tranquillity washed over me. The house was quiet -- almost too quiet, without Franc blasting his music from upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "I entered the grand study and let the warm glow of the ro..."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What are you reading?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: ""Oh. I didn't realize you were home.""*)

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I must say, you seem to have quite the fondness for these dusty tomes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: ""Oh. I didn't realize you were home.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Sit in the armchair next to hers."]** — Mówca: **Player_Italic**
> "I took a seat in the armchair next to hers."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[15]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Monica: ""Oh. I didn't realize you were home.""*)

### Węzeł `[44]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[45]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[46]`
Mówca: **Monica**
> ""Oh. I didn't realize you were home.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[47]`
Mówca: **Monica**
> ""I took some books from the presidential library. This one in particular caught my eye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "She showed me the book she was holding. I didn't recogniz..."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Her voice was cold as she spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Player_Italic: "Stay silent."*)
  - -> `[71]` (*Player: ""But what is it? Can't you at least tell me?""*)
  - -> `[72]` (*Player: ""What's wrong?""*)
  - -> `[73]` (*Player: ""Whatever.""*)

### Węzeł `[49]`
Mówca: **Monica**
> ""The book's nothing. You wouldn't like it anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Her voice was cold as she spoke."*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[52]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Monica: ""The book's nothing. You wouldn't like it anyway.""*)

### Węzeł `[52]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Monica: ""I took some books from the presidential library. This on..."*)

### Węzeł `[53]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[54]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Monica: ""This isn't just any dusty tome, Anton. But you wouldn't ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Monica: ""But yes, between these dusty covers lie worlds of knowle..."*)

### Węzeł `[56]`
Mówca: **Monica**
> ""This isn't just any dusty tome, Anton. But you wouldn't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Her voice was cold as she spoke."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[59]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Her voice was cold as she spoke."*)

### Węzeł `[59]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Monica: ""Is everything really going well at work?""*)

### Węzeł `[60]`
Mówca: **Monica**
> ""Is everything really going well at work?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_isVP == true"*)

### Węzeł `[61]`
Mówca: **Monica**
> ""But yes, between these dusty covers lie worlds of knowledge waiting to be explored.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Monica: ""I took some books from the presidential library. This on..."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "She showed me the book she was holding. I didn't recognize the author, but the name definitely sounded Valgish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Monica: ""It's about the women's struggle in post-revolution Valgs..."*)

### Węzeł `[63]`
Mówca: **Monica**
> ""It's about the women's struggle in post-revolution Valgsland and its breakaway states.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Player: ""That actually sounds like a great read.""*)
  - -> `[64]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[68]` (*Player: ""From the presidential library, really? I'm surprised the..."*)
  - -> `[69]` (*Player: ""Seems like Valgish propaganda to me. I'd take its conten..."*)

### Węzeł `[64]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Węzeł Logiki Narracyjnej: "BaseGame.Archetype_ComradeRayne == true"*)
  - -> `[66]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Archetype_ComradeRayne == true)"*)

### Węzeł `[65]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Archetype_ComradeRayne == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Archetype_ComradeRayne"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[66]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Archetype_ComradeRayne == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""Are you becoming a Malenyevist, my dear?""*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you becoming a Malenyevist, my dear?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Archetype_ComradeRayne"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[63]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Monica: ""This isn't about that.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""From the presidential library, really? I'm surprised they keep any books about the Valgish revolution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Monica: ""To be honest, I was surprised too.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Seems like Valgish propaganda to me. I'd take its contents with a grain of salt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Monica: ""I mean... That may be true. But...""*)

### Węzeł `[70]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually sounds like a great read.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[63]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Monica: ""It is. Especially the part about Galmland and the empire..."*)

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""But what is it? Can't you at least tell me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Narrator: "She let out a deep sigh."*)

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's wrong?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Monica: ""Really, Anton?""*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Whatever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "We both sat by the fireplace in stony silence."*)

### Węzeł `[74]`
**[WYBÓR GRACZA: "Stay silent."]** — Mówca: **Player_Italic**
> "I decided to stay silent."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[48]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "We both sat by the fireplace in stony silence."*)

### Węzeł `[75]`
Mówca: **Monica**
> ""Really, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "I could see the anger in her eyes."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "We both sat by the fireplace in stony silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Just then, we heard the patter of small feet approaching ..."*)

### Węzeł `[77]`
Mówca: **Narrator**
> "I could see the anger in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: ""I don't want to talk right now. Let me read in peace.""*)

### Węzeł `[78]`
Mówca: **Monica**
> ""I don't want to talk right now. Let me read in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "We both sat by the fireplace in stony silence."*)

### Węzeł `[79]`
Mówca: **Narrator**
> "She let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Monica: ""I don't want to talk right now. Let me read in peace.""*)

### Węzeł `[80]`
Mówca: **Monica**
> ""It is. Especially the part about Galmland and the empire's former Rikan colonies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Monica: ""I had no idea the women there managed to organize so wel..."*)

### Węzeł `[81]`
Mówca: **Monica**
> ""I had no idea the women there managed to organize so well and so early. It's very inspiring actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Monica: ""But anyway...""*)

### Węzeł `[82]`
Mówca: **Monica**
> ""This isn't about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Monica: ""We shouldn't let our political opinions get in the way o..."*)

### Węzeł `[83]`
Mówca: **Monica**
> ""We shouldn't let our political opinions get in the way of learning about what the revolutionaries did right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Monica: ""But anyway...""*)

### Węzeł `[84]`
Mówca: **Monica**
> ""To be honest, I was surprised too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Monica: ""I was told it was Tarquin Soll who collected most of the..."*)

### Węzeł `[85]`
Mówca: **Monica**
> ""I was told it was Tarquin Soll who collected most of them. Quite unexpected, really.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Monica: ""But anyway...""*)

### Węzeł `[86]`
Mówca: **Monica**
> ""I mean... That may be true. But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Monica: ""This isn't about that.""*)

### Węzeł `[87]`
Mówca: **Monica**
> ""But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Monica: ""Is everything really going well at work?""*)

### Węzeł `[88]`
Mówca: **Monica**
> ""Especially after everything that happened with Petr...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Petr who? My new vice president is doing a much better j..."*)
  - -> `[93]` (*Player: ""I don't want to talk about him. I hope you understand.""*)
  - -> `[94]` (*Player: ""I'll be honest. The palace does feel a lot more uncomfor..."*)
  - -> `[95]` (*Player: ""I wish it had all gone differently.""*)

### Węzeł `[89]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_isVP == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Węzeł Logiki Narracyjnej: "BaseGame.Petr_isVP == true"*)
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Petr_isVP == true)"*)

### Węzeł `[90]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Petr_isVP == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Petr_isVP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Monica: ""Evelyn said Petr's finally stopped drinking -- or most l..."*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Petr_isVP == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Petr_isVP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Monica: ""Especially after everything that happened with Petr...""*)

### Węzeł `[92]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr who? My new vice president is doing a much better job.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Monica: ""Is that really how you feel, Anton? He was your closest ..."*)

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't want to talk about him. I hope you understand.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Monica: ""I do understand...""*)

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be honest. The palace does feel a lot more uncomfortable and intimidating without him around.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Monica: ""I understand. But honestly, maybe it was all for the bes..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I wish it had all gone differently.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Monica: ""I understand. But honestly, maybe it was all for the bes..."*)

### Węzeł `[96]`
Mówca: **Monica**
> ""I do understand...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "She sighed."*)

### Węzeł `[97]`
Mówca: **Monica**
> ""Is that really how you feel, Anton? He was your closest friend since forever...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Monica: ""...But honestly, you're probably right.""*)

### Węzeł `[98]`
Mówca: **Monica**
> ""Thanks to you, I was just about the only woman at university he didn't go after. But I saw the way he was. And how he continued to be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Monica: ""The truth is... That man has always been a bad influence..."*)

### Węzeł `[99]`
Mówca: **Monica**
> ""The truth is... That man has always been a bad influence on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Monica: ""And I don't think he should be forgiven after what he did.""*)

### Węzeł `[100]`
Mówca: **Monica**
> ""...But honestly, you're probably right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Monica: ""Thanks to you, I was just about the only woman at univer..."*)

### Węzeł `[101]`
Mówca: **Monica**
> ""And I don't think he should be forgiven after what he did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Player: ""He wasn't forgiven. By me or anyone else.""*)
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Petr_ShareBlameForLeak == true"*)
  - -> `[114]` (*Player: ""I knew Petr had his problems, Monica. But he was -- is -..."*)
  - -> `[115]` (*Player: ""You're right. I should have listened to you back in the ..."*)

### Węzeł `[102]`
Mówca: **Monica**
> ""Evelyn said Petr's finally stopped drinking -- or most likely, stopped drinking so very much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Monica: ""Apparently, he's been coming home a lot more often, and ..."*)

### Węzeł `[103]`
Mówca: **Monica**
> ""Apparently, he's been coming home a lot more often, and spends most nights in his study, working on documents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Player: ""I won't believe that until I see it with my own eyes.""*)
  - -> `[105]` (*Player: ""Really? That's good to know. He did promise me he'd work..."*)
  - -> `[106]` (*Player: ""I'm glad he's actually doing his part for once. It's bee..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't believe that until I see it with my own eyes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Monica: ""That was exactly my response to Evelyn.""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Really? That's good to know. He did promise me he'd work harder.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Monica: ""Seems like he's following through.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad he's actually doing his part for once. It's been a madhouse at the palace lately.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Monica: ""I see.""*)

### Węzeł `[107]`
Mówca: **Monica**
> ""That was exactly my response to Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "She sighed."*)

### Węzeł `[108]`
Mówca: **Monica**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "She sighed."*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He wasn't forgiven. By me or anyone else.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Monica: ""I know.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't defend what he did, but he's still my friend. And he's facing the consequences of his actions.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true`
- **Kontekst wejściowy (poprzednik):** `[101]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Monica: ""I know. I'm sorry.""*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Petr_ShareBlameForLeak == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Petr_ShareBlameForLeak == true"*)
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Petr_ShareBlameForLeak == true)"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Petr_ShareBlameForLeak == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""I won't defend what he did, but he's still my friend. An..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Petr_ShareBlameForLeak == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Petr_ShareBlameForLeak"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I knew Petr had his problems, Monica. But he was -- is -- my closest friend. I don't want to badmouth him behind his back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Monica: ""I know. I'm sorry.""*)

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. I should have listened to you back in the day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[101]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Monica: ""Isn't that always the moral of these stories?""*)

### Węzeł `[116]`
Mówca: **Monica**
> ""I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "She sighed."*)

### Węzeł `[117]`
Mówca: **Monica**
> ""I know. I'm sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "She sighed."*)

### Węzeł `[118]`
Mówca: **Monica**
> ""Isn't that always the moral of these stories?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Narrator: "She sighed."*)

### Węzeł `[119]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Monica: ""I don't know, Anton. All of this seems to have put you u..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Monica: ""I don't know, Anton. Both of you seem to be under a mass..."*)

### Węzeł `[121]`
Mówca: **Monica**
> ""I don't know, Anton. Both of you seem to be under a massive amount of stress lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_WillHappen == true"*)

### Węzeł `[122]`
Mówca: **Monica**
> ""I don't know, Anton. All of this seems to have put you under a massive amount of stress.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_WillHappen == true"*)

### Węzeł `[123]`
Mówca: **Monica**
> ""Maybe we can make some time for a little getaway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn05_P_Vineyard == true"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn05_P_Vineyard == true)"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn05_P_Vineyard == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn05_P_Vineyard"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: ""We can have a weekend retreat at the vineyard in Erlory...."*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn05_P_Vineyard == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn05_P_Vineyard"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Monica: ""We can have a weekend retreat out in the countryside. Wh..."*)

### Węzeł `[127]`
Mówca: **Monica**
> ""We can have a weekend retreat at the vineyard in Erlory. What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""That actually sounds marvelous, Monica. Let's make the a..."*)
  - -> `[130]` (*Player: ""It's a nice idea, but I'll have to check my schedule. I ..."*)
  - -> `[131]` (*Player: ""Just the two of us?""*)

### Węzeł `[128]`
Mówca: **Monica**
> ""We can have a weekend retreat out in the countryside. What do you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Player: ""That actually sounds marvelous, Monica. Let's make the a..."*)
  - -> `[130]` (*Player: ""It's a nice idea, but I'll have to check my schedule. I ..."*)
  - -> `[131]` (*Player: ""Just the two of us?""*)

### Węzeł `[129]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That actually sounds marvelous, Monica. Let's make the arrangements.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Monica), `[128]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Monica: ""Great!""*)

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's a nice idea, but I'll have to check my schedule. I *am* very busy, you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Monica), `[128]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Monica: ""Okay...""*)

### Węzeł `[131]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just the two of us?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[127]` (Monica), `[128]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Monica: ""Well... Franc's not around anymore, and I'm sure Deana w..."*)

### Węzeł `[132]`
Mówca: **Monica**
> ""Well... Franc's not around anymore, and I'm sure Deana would love a sleepover at one of her friends'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Monica: ""So why not?""*)

### Węzeł `[133]`
Mówca: **Monica**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Just then, we heard the patter of small feet approaching ..."*)

### Węzeł `[134]`
Mówca: **Monica**
> ""Great!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "She grinned."*)

### Węzeł `[135]`
Mówca: **Monica**
> ""So why not?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "She grinned."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "She grinned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Just then, we heard the patter of small feet approaching ..."*)

### Węzeł `[137]`
Mówca: **Narrator**
> "Just then, we heard the patter of small feet approaching the study."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)

### Węzeł `[138]`
Mówca: **Narrator**
> "Deana appeared by the door with a piece of folded paper clutched in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Deana: ""Mama, Papa, look what I found!""*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Threatens_President == true)"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "Deana appeared by the door with a piece of folded paper c..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Threatens_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Deana appeared by the door with a piece of folded paper c..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_WillHappen == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_WillHappen == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Unrest_WillHappen == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_WillHappen == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Unrest_WillHappen"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Monica: ""I've also seen that more and more protests have been pop..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Unrest_WillHappen == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Unrest_WillHappen"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[145]`
Mówca: **Deana**
> ""Mama, Papa, look what I found!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Narrator: "Monica and I immediately turned our attention to her, our..."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Deana appeared by the door with a piece of folded paper clutched in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Deana: ""Mama, Papa, my school report came in!""*)

### Węzeł `[147]`
Mówca: **Deana**
> ""Mama, Papa, my school report came in!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Monica and I immediately turned our attention to her, our..."*)

### Węzeł `[148]`
Mówca: **Narrator**
> "Monica and I immediately turned our attention to her, our curiosity piqued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: ""What have you got there, darling?""*)
  - -> `[150]` (*Player: ""What is it?""*)
  - -> `[151]` (*Player_Italic: "Wait for her to continue."*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What have you got there, darling?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Deana unfolded the paper and started to read it aloud."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Deana unfolded the paper and started to read it aloud."*)

### Węzeł `[151]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[148]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Narrator: "Deana unfolded the paper and started to read it aloud."*)

### Węzeł `[152]`
Mówca: **Narrator**
> "Deana unfolded the paper and started to read it aloud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Deana: ""We hope this letter finds you in good spirits, surrounde..."*)

### Węzeł `[153]`
Mówca: **Deana**
> ""We hope this letter finds you in good spirits, surrounded by the warmth of your loved ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deana: ""Oh, how we long for a world where justice prevails, wher..."*)

### Węzeł `[154]`
Mówca: **Deana**
> ""Oh, how we long for a world where justice prevails, where the corrupt are exposed, and the righteous triumph.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged == true"*)

### Węzeł `[155]`
Mówca: **Deana**
> ""We advise all of you to tread carefully, for it was Anton Rayne who grew the darkness over this land and suffocated our people. For what the President did, he and his family shall face re-- Retrbrution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Player: ""It's 'retribution', sweetheart.""*)
  - -> `[157]` (*Player: ""It's alright, my love. Just give it here.""*)
  - -> `[158]` (*Player: ""Deana! Give me that paper right now!""*)
  - -> `[159]` (*Player_Italic: "Let her continue."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Her voice started quivering as she continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Deana: ""We advise all of you to tread carefully, for it was Anto..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's alright, my love. Just give it here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "She reluctantly approached us with the letter."*)

### Węzeł `[158]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana! Give me that paper right now!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "She reluctantly approached us with the letter."*)

### Węzeł `[159]`
**[WYBÓR GRACZA: "Let her continue."]** — Mówca: **Player_Italic**
> "I did not intervene and let her continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Deana: ""The safety you have enjoyed so far is nothing but an ill..."*)

### Węzeł `[160]`
Mówca: **Deana**
> ""Papa. Why does it say that you suffocated people?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: ""Deana, this letter is from some misguided individuals. W..."*)
  - -> `[167]` (*Player: ""I don't know, sweetie. It's just a bunch of words that d..."*)
  - -> `[168]` (*Player: ""They are all lies, Deana.""*)
  - -> `[169]` (*Player: ""It's okay, darling. This is nothing for you to worry abo..."*)

### Węzeł `[161]`
Mówca: **Narrator**
> "She reluctantly approached us with the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Deana: ""Papa. Why does it say that you suffocated people?""*)

### Węzeł `[162]`
Mówca: **Deana**
> ""The safety you have enjoyed so far is nothing but an illusion. Think twice before stepping into our ancestral lands. Danger lurks around every corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Deana: ""Don't forget. The powerful are vulnerable and the oppres..."*)

### Węzeł `[163]`
Mówca: **Deana**
> ""Don't forget. The powerful are vulnerable and the oppressed have nothing to los-""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Monica: ""Anton!""*)

### Węzeł `[164]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "Monica quickly stood up and snatched the letter from her ..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "Monica quickly stood up and snatched the letter from her grasp."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Monica: ""It's okay, darling. This is all just a bad joke.""*)

### Węzeł `[166]`
Mówca: **Monica**
> ""It's okay, darling. This is all just a bad joke.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "She gave me the letter and I immediately started reading ..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I don't know, sweetie. It's just a bunch of words that don't make sense. It must be a joke.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I took the letter from her grasp and started reading it."*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They are all lies, Deana.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I took the letter from her grasp and started reading it."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, darling. This is nothing for you to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I took the letter from her grasp and started reading it."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "I took the letter from her grasp and started reading it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Narrator: ""...The safety you have enjoyed so far is nothing but an ..."*)

### Węzeł `[171]`
Mówca: **Narrator**
> ""...The safety you have enjoyed so far is nothing but an illusion. Think twice before you step into our ancestral lands. Danger lurks around every corner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: ""Don't forget. The powerful are vulnerable and the oppres..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> ""Don't forget. The powerful are vulnerable and the oppressed have nothing to lose...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[173]`
Mówca: **Narrator**
> ""Consider our words, for they hold weight beyond your existence. Your decisions shape the destinies of millions, and their consequences will reverberate through the nation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Narrator: ""With sincerest concern, the Bludish Freedom Front.""*)

### Węzeł `[174]`
Mówca: **Narrator**
> ""With sincerest concern, the Bludish Freedom Front.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Monica: ""What are we going to do, Anton? This is serious.""*)

### Węzeł `[175]`
Mówca: **Monica**
> ""What are we going to do, Anton? This is serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Player: ""I'm sure it's nothing to worry about.""*)
  - -> `[180]` (*Player: ""I'll check in with the presidential guard. This should n..."*)
  - -> `[181]` (*Player: ""I won't let fear dictate our actions, Monica. If there's..."*)
  - -> `[182]` (*Player: ""Don't worry, Monica. I'll inform the authorities and tak..."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "She gave me the letter and I immediately started reading the rest of it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sure it's nothing to worry about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Monica: ""Are you insane? This letter is directed at our entire fa..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "Deana, sensing the tension, tiptoed closer to us, her eyes wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Monica: ""Deana, honey, where did you find this?""*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana, this letter is from some misguided individuals. We won't let them get their way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[160]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "I took the letter from her grasp and started reading it."*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll check in with the presidential guard. This should never even have reached us in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Monica: ""We can't be too cautious. The letter is directed at our ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I won't let fear dictate our actions, Monica. If there's truly a threat, we will face it head-on.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Monica: ""Are you insane? This letter is directed at our entire fa..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. I'll inform the authorities and take every necessary precaution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Monica: ""We can't be too cautious. The letter is directed at our ..."*)

### Węzeł `[183]`
Mówca: **Monica**
> ""Are you insane? This letter is directed at our entire family. And we know what its authors are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Deana, sensing the tension, tiptoed closer to us, her eye..."*)

### Węzeł `[184]`
Mówca: **Monica**
> ""We can't be too cautious. The letter is directed at our entire family. And we know what its authors are capable of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "Deana, sensing the tension, tiptoed closer to us, her eye..."*)

### Węzeł `[185]`
Mówca: **Monica**
> ""Deana, honey, where did you find this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "She hesitated for a moment before speaking."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "She hesitated for a moment before speaking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Deana: ""I found it in the living room window. It was stuck betwe..."*)

### Węzeł `[187]`
Mówca: **Deana**
> ""I found it in the living room window. It was stuck between the frames.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Player: ""It's okay, sweetheart. But next time, please talk to me ..."*)
  - -> `[188]` (*Player: ""Well done, Deana. You've shown incredible courage. Thank..."*)
  - -> `[190]` (*Player_Italic: "Console her."*)

### Węzeł `[188]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well done, Deana. You've shown incredible courage. Thank you for bringing this to our attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deana: ""Papa, what's going on?""*)

### Węzeł `[189]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's okay, sweetheart. But next time, please talk to me or your mother before touching things like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deana: ""Papa, what's going on?""*)

### Węzeł `[190]`
**[WYBÓR GRACZA: "Console her."]** — Mówca: **Player_Italic**
> "I knelt down and gathered Deana into my arms."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[187]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Deana: ""Papa, what's going on?""*)

### Węzeł `[191]`
Mówca: **Deana**
> ""Papa, what's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Deana: ""Are they threatening us for something you did?""*)

### Węzeł `[192]`
Mówca: **Deana**
> ""Are they threatening us for something you did?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "She spoke innocently, but I could sense a new guardedness..."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "She spoke innocently, but I could sense a new guardedness in her voice. I took a deep breath and tried to find the right words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Player: ""Deana, we've received a letter from some people called t..."*)
  - -> `[211]` (*Player: ""No, darling. I haven't done anything wrong. The people w..."*)
  - -> `[215]` (*Player: ""Yes, darling. Some people think I've done bad things and..."*)
  - -> `[216]` (*Player: ""Some matters are best left for the grown-ups.""*)

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Deana, we've received a letter from some people called the BFF. They want to do bad things to us because they don't agree with what we stand for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Deana: ""But daddy, we're good people. And I know you always try ..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Bron == true"*)
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Bron == true)"*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Bron == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Bron"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Narrator: ""Everyone who has been complicit in this injustice will h..."*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Bron == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Bron"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)

### Węzeł `[198]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)
  - -> `[200]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Policy_Law_Ban_WPB == true)"*)

### Węzeł `[199]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Policy_Law_Ban_WPB == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Policy_Law_Ban_WPB"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: ""When you eliminated our people's right to represent them..."*)

### Węzeł `[200]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Policy_Law_Ban_WPB == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Policy_Law_Ban_WPB"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[201]`
Mówca: **Narrator**
> ""When you eliminated our people's right to represent themselves, you gave us no choice but to take matters into our own hands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Arrest_FetihEjall == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Arrest_FetihEjall == true )"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Arrest_FetihEjall == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Arrest_FetihEjall"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: ""With the arrest of Mr. Ejall, we have finally come to te..."*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Arrest_FetihEjall == true
)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Arrest_FetihEjall"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: ""Consider our words, for they hold weight beyond your exi..."*)

### Węzeł `[205]`
Mówca: **Narrator**
> ""With the arrest of Mr. Ejall, we have finally come to terms with reality. The peaceful movement has failed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: ""Consider our words, for they hold weight beyond your exi..."*)

### Węzeł `[206]`
Mówca: **Narrator**
> ""Everyone who has been complicit in this injustice will have to answer for it. We will also visit Governor Bron.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bergia_Governor_Krull == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bergia_Governor_Krull == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bergia_Governor_Krull == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bergia_Governor_Krull"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Narrator: ""Everyone who has been complicit in this injustice will h..."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bergia_Governor_Krull == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bergia_Governor_Krull"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)

### Węzeł `[210]`
Mówca: **Narrator**
> ""Everyone who has been complicit in this injustice will have to answer for it. We will also visit Governor Krull.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Węzeł Logiki Narracyjnej: "BaseGame.Policy_Law_Ban_WPB == true"*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, darling. I haven't done anything wrong. The people who wrote this do not believe in the authority of our country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Deana: ""But that's not fair, Papa. Our country is supposed to pr..."*)

### Węzeł `[212]`
Mówca: **Deana**
> ""But daddy, we're good people. And I know you always try to do what's best for everyone. Why would they want to hurt us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Player: ""Oh, Deana. I strive to be the best I can be, but sometim..."*)
  - -> `[213]` (*Player: ""Sometimes, people fear what they don't understand. But w..."*)
  - -> `[230]` (*Player: ""Some people have evil in their hearts, Deana. They don't..."*)
  - -> `[451]` (*Player: ""Even your papa can make mistakes sometimes, Deana. What'..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes, people fear what they don't understand. But we won't let that fear define us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[214]`
Mówca: **Deana**
> ""So what are we going to do? We can't let the bad people win, can we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Player: ""No, Deana. We will not let them win. We will take every ..."*)
  - -> `[236]` (*Player: ""There's nothing to win, Deana. Don't worry, nothing bad ..."*)
  - -> `[237]` (*Player: ""Never, my dear. We will not surrender to fear or threats.""*)
  - -> `[238]` (*Player: ""They're not bad people, just people with bad ideas. I wi..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, darling. Some people think I've done bad things and now they are trying to send me a message.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Deana: ""But you wouldn't really do anything bad, would you? I kn..."*)

### Węzeł `[216]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some matters are best left for the grown-ups.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[193]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Deana: ""But I want to understand, Papa. This seems important. I'..."*)

### Węzeł `[217]`
Mówca: **Deana**
> ""But that's not fair, Papa. Our country is supposed to protect all of us, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player: ""Sometimes our country doesn't function the way it's supp..."*)
  - -> `[220]` (*Player: ""Yes, my girl. Our country is meant to protect its people..."*)
  - -> `[226]` (*Player: ""You're right. Our country protects all of us, Deana. But..."*)

### Węzeł `[218]`
Mówca: **Deana**
> ""But you wouldn't really do anything bad, would you? I know you always try to do what's best for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""Oh, Deana. I strive to be the best I can be, but sometim..."*)
  - -> `[222]` (*Player: ""Even your papa can make mistakes sometimes, Deana. What'..."*)
  - -> `[225]` (*Player: ""Some people have evil in their hearts, Deana. They don't..."*)

### Węzeł `[219]`
Mówca: **Deana**
> ""But I want to understand, Papa. This seems important. I'm not a little kid anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Player: ""Trust me, Deana. It's best if you stay out of this.""*)
  - -> `[223]` (*Player: ""You're right. You're growing into such a remarkable youn..."*)
  - -> `[224]` (*Player: ""There are complex issues and disagreements in our countr..."*)

### Węzeł `[220]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, my girl. Our country is meant to protect its people, but sometimes there are those who challenge its ideals.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[221]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Deana. I strive to be the best I can be, but sometimes people have different opinions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deana), `[233]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[222]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even your papa can make mistakes sometimes, Deana. What's important is to remember that we can learn and grow from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deana), `[233]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[223]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. You're growing into such a remarkable young woman. Tell me. What do you want to know?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Deana: ""Have you really done something to hurt these people? I k..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There are complex issues and disagreements in our country, and sometimes it's best for adults to handle them. But please know that I will always protect you and our family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Narrator: "Deana looked at me with a hint of disappointment in her e..."*)

### Węzeł `[225]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people have evil in their hearts, Deana. They don't care whether you're doing the right thing or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[218]` (Deana), `[233]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're right. Our country protects all of us, Deana. But some people have evil in their hearts and want to reject that protection.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Trust me, Deana. It's best if you stay out of this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[219]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Narrator: "Deana's lower lip trembled. I saw a hint of disappointmen..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Sometimes our country doesn't function the way it's supposed to, Deana. And when it doesn't, it leads to problems with different groups of people.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[217]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, Deana. I strive to be the best I can be, but sometimes people have different opinions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people have evil in their hearts, Deana. They don't care whether you're doing the right thing or not.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[231]`
Mówca: **Narrator**
> "Deana's lower lip trembled. I saw a hint of disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Deana: ""Okay...""*)

### Węzeł `[232]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Monica tugged on my arm."*)

### Węzeł `[233]`
Mówca: **Deana**
> ""Have you really done something to hurt these people? I know you always try to do what's best for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Player: ""Oh, Deana. I strive to be the best I can be, but sometim..."*)
  - -> `[222]` (*Player: ""Even your papa can make mistakes sometimes, Deana. What'..."*)
  - -> `[225]` (*Player: ""Some people have evil in their hearts, Deana. They don't..."*)

### Węzeł `[234]`
Mówca: **Narrator**
> "Deana looked at me with a hint of disappointment in her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Deana: ""Okay...""*)

### Węzeł `[235]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Deana. We will not let them win. We will take every precaution to keep our family safe.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deana: ""Okay...""*)

### Węzeł `[236]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's nothing to win, Deana. Don't worry, nothing bad will happen as long as I'm here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deana: ""Okay...""*)

### Węzeł `[237]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Never, my dear. We will not surrender to fear or threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deana: ""Okay...""*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're not bad people, just people with bad ideas. I will show them the right thing to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[214]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Deana: ""Okay...""*)

### Węzeł `[239]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Narrator: "Monica tugged on my arm."*)

### Węzeł `[240]`
Mówca: **Narrator**
> "Monica tugged on my arm."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Monica: ""Anton.""*)

### Węzeł `[241]`
Mówca: **Monica**
> ""Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Monica: ""We have to talk about this. You and me. Alone.""*)

### Węzeł `[242]`
Mówca: **Monica**
> ""We have to talk about this. You and me. Alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Narrator: "She gestured towards the kitchen."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Monica and I immediately turned our attention to her, our curiosity piqued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Player: ""That's my girl! I can't wait to hear about it.""*)
  - -> `[245]` (*Player: ""Very well. Bring it here and let's assess your progress ..."*)
  - -> `[249]` (*Player: ""Oh no, not the dreaded report!""*)
  - -> `[246]` (*Player_Italic: "Wait for her to continue."*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's my girl! I can't wait to hear about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Deana unfolded the paper and gave it to me."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Very well. Bring it here and let's assess your progress together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Deana unfolded the paper and gave it to me."*)

### Węzeł `[246]`
**[WYBÓR GRACZA: "Wait for her to continue."]** — Mówca: **Player_Italic**
> "I waited for her to continue."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "Deana unfolded the paper and gave it to me."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "Deana unfolded the paper and gave it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""I was so close to the top of the class...""*)

### Węzeł `[248]`
Mówca: **Deana**
> ""I was so close to the top of the class...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "I heard a mix of pride and disappointment in her voice.""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh no, not the dreaded report!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[243]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Narrator: "Deana chuckled and gave the paper to me."*)

### Węzeł `[250]`
Mówca: **Narrator**
> "Deana chuckled and gave the paper to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Deana: ""I was so close to the top of the class...""*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's incredible, Deana! You've worked hard and it shows.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Deana smiled."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""*Almost* doesn't count, honey. Sounds like you've got to try harder.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Deana: ""I know...""*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Congratulations, my girl! But you know I'd love you even if you got bad grades, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Narrator: "Deana smiled."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "I heard a mix of pride and disappointment in her voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""That's incredible, Deana! You've worked hard and it shows.""*)
  - -> `[252]` (*Player: ""*Almost* doesn't count, honey. Sounds like you've got to..."*)
  - -> `[253]` (*Player: ""Congratulations, my girl! But you know I'd love you even..."*)
  - -> `[267]` (*Player: ""That's great to hear! I wish your brother had your brains.""*)
  - -> `[255]` (*Player: ""Oh my. We've got a genius in the house! Watch out, world..."*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh my. We've got a genius in the house! Watch out, world, Holsord's number-two student is on the loose!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Narrator: "Deana chuckled."*)

### Węzeł `[256]`
Mówca: **Narrator**
> "Deana chuckled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""You did great, darling!""*)

### Węzeł `[257]`
Mówca: **Narrator**
> "Deana smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""You did great, darling!""*)

### Węzeł `[258]`
Mówca: **Deana**
> ""I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Monica: ""Anton!""*)

### Węzeł `[259]`
Mówca: **Monica**
> ""Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "Monica quickly stood up and snatched the paper from my ha..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "Monica quickly stood up and snatched the paper from my hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""You did great, darling!""*)

### Węzeł `[261]`
Mówca: **Monica**
> ""You did great, darling!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[262]`
Mówca: **Monica**
> ""We're so proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She knelt down and gathered Deana into her arms."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Monica: ""I'm so proud of you.""*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Monica: ""We're so proud of you.""*)

### Węzeł `[266]`
Mówca: **Monica**
> ""I'm so proud of you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "She knelt down and gathered Deana into her arms."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's great to hear! I wish your brother had your brains.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Deana: ""Mama says Franc's smart in a different way.""*)

### Węzeł `[268]`
Mówca: **Deana**
> ""Mama says Franc's smart in a different way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Monica: ""You did great, darling!""*)

### Węzeł `[269]`
Mówca: **Narrator**
> "She knelt down and gathered Deana into her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Deana: ""I know! But I still feel kinda bad...""*)

### Węzeł `[270]`
Mówca: **Deana**
> ""I know! But I still feel kinda bad...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)

### Węzeł `[271]`
Mówca: **Deana**
> ""And then there's that stupid blonde boy Markus. He never even studies, but the teachers always give him higher grades than everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Monica: ""Don't call him stupid, baby. Who is this Markus?""*)

### Węzeł `[272]`
Mówca: **Monica**
> ""Don't call him stupid, baby. Who is this Markus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Deana: ""I told you about him, Mommy. Markus Clavin. The one who ..."*)

### Węzeł `[273]`
Mówca: **Deana**
> ""I told you about him, Mommy. Markus Clavin. The one who can't even do basic math, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Player: ""Wait. Did you just say Clavin?""*)
  - -> `[275]` (*Player: ""Your mother's right, Deana. Forget about it. You've alre..."*)
  - -> `[276]` (*Player: ""Oh, really? Maybe I should have a talk with your school.""*)

### Węzeł `[274]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Wait. Did you just say Clavin?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Deana: ""Yes. That's his last name.""*)

### Węzeł `[275]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Your mother's right, Deana. Forget about it. You've already done great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Deana: ""Okay.""*)

### Węzeł `[276]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Oh, really? Maybe I should have a talk with your school.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[273]` (Deana), `[277]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Deana: ""What do you mean by talk, Papa?""*)

### Węzeł `[277]`
Mówca: **Deana**
> ""Yes. That's his last name.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: ""Actually, I may know his father...""*)
  - -> `[281]` (*Player: ""Interesting...""*)
  - -> `[282]` (*Player: ""Anyway, it doesn't matter, Deana. You've already done gr..."*)
  - -> `[276]` (*Player: ""Oh, really? Maybe I should have a talk with your school.""*)

### Węzeł `[278]`
Mówca: **Deana**
> ""What do you mean by talk, Papa?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Deana: ""Please don't come to the school and shout at the teacher..."*)

### Węzeł `[279]`
Mówca: **Deana**
> ""Please don't come to the school and shout at the teachers like Markus' father did.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""He did what?""*)
  - -> `[296]` (*Player: ""Are you serious, sweetie?""*)
  - -> `[297]` (*Player: ""He did, did he? Looks like I have a *lot* of talking to ..."*)
  - -> `[298]` (*Player: ""Some people just have bad manners, darling. You shouldn'..."*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Actually, I may know his father...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Deana), `[284]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Deana: ""Really?""*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Interesting...""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Deana: ""Do you know him?""*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Anyway, it doesn't matter, Deana. You've already done great. Don't mind that kid.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[277]` (Deana), `[284]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Deana: ""Okay.""*)

### Węzeł `[283]`
Mówca: **Deana**
> ""Okay.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[284]`
Mówca: **Deana**
> ""Do you know him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player: ""Actually, I may know his father...""*)
  - -> `[282]` (*Player: ""Anyway, it doesn't matter, Deana. You've already done gr..."*)

### Węzeł `[285]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Law_ExcellentWomenRights == true ||Bas..."*)
  - -> `[287]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Law_ExcellentWomenRights == true ||B..."*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Deana: ""I'm sure I would've been at the top if the boys at schoo..."*)

### Węzeł `[287]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Law_ExcellentWomenRights == true ||BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Law_ExcellentWomenRights"] == true  or Variable["BaseGame.Reform_PresiPower_Default_GenderEqualityInEducation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Deana: ""I'm sure I would've been at the top if I'd done better i..."*)

### Węzeł `[288]`
Mówca: **Deana**
> ""Ever since they started letting the girls take science classes, they've been distracting us during exams.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Deana: ""And the teachers don't even care!""*)

### Węzeł `[289]`
Mówca: **Deana**
> ""...But those classes are so boring!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Deana: ""And then there's that stupid blonde boy Markus. He never..."*)

### Węzeł `[290]`
Mówca: **Deana**
> ""And the teachers don't even care!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Deana: ""And then there's that stupid blonde boy Markus. He never..."*)

### Węzeł `[291]`
Mówca: **Deana**
> ""I'm sure I would've been at the top if the boys at school weren't so annoying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Deana: ""Ever since they started letting the girls take science c..."*)

### Węzeł `[292]`
Mówca: **Deana**
> ""I'm sure I would've been at the top if I'd done better in handicrafts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Deana: ""...But those classes are so boring!""*)

### Węzeł `[293]`
Mówca: **Deana**
> ""Really?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Deana: ""His father came to the school a couple of times and shou..."*)

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He did what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Deana), `[295]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Deana: ""I already told you!""*)

### Węzeł `[295]`
Mówca: **Deana**
> ""His father came to the school a couple of times and shouted at the teachers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Player: ""He did what?""*)
  - -> `[296]` (*Player: ""Are you serious, sweetie?""*)
  - -> `[297]` (*Player: ""He did, did he? Looks like I have a *lot* of talking to ..."*)
  - -> `[298]` (*Player: ""Some people just have bad manners, darling. You shouldn'..."*)

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you serious, sweetie?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Deana), `[295]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Deana: ""Why wouldn't I be?""*)

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He did, did he? Looks like I have a *lot* of talking to do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Deana), `[295]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Deana: ""Okay...""*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Some people just have bad manners, darling. You shouldn't pay attention to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[279]` (Deana), `[295]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Deana: ""Okay...""*)

### Węzeł `[299]`
Mówca: **Narrator**
> "She gestured towards the kitchen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Monica: ""We'll be back in a bit, sweetie.""*)

### Węzeł `[300]`
Mówca: **Monica**
> ""We'll be back in a bit, sweetie.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "We entered the kitchen and Monica closed the door behind us."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "We entered the kitchen and Monica closed the door behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)

### Węzeł `[302]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == tr..."*)

### Węzeł `[303]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Monica: ""Anton. I have a bad feeling about this. Isn't the Aschra..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Monica: ""Anton. I know the Aschraf Anniversary will take place in..."*)

### Węzeł `[305]`
Mówca: **Monica**
> ""Anton. I know the Aschraf Anniversary will take place in a few days. I don't want you to attend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Monica: ""You know it's the largest-ever commemoration of the Izza..."*)

### Węzeł `[306]`
Mówca: **Monica**
> ""You know it's the largest-ever commemoration of the Izzam Incident. And it will be swarming with Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Monica: ""With everything going on in Bergia, and the timing of th..."*)

### Węzeł `[307]`
Mówca: **Monica**
> ""Anton. I have a bad feeling about this. Isn't the Aschraf Anniversary in a few days?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Monica: ""I feel like something might happen on that day. It's the..."*)

### Węzeł `[308]`
Mówca: **Monica**
> ""I feel like something might happen on that day. It's the commemoration of the Izzam Incident after all. And it'll be swarming with Bludish separatists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Monica: ""With everything going on in Bergia, and the timing of th..."*)

### Węzeł `[309]`
Mówca: **Monica**
> ""With everything going on in Bergia, and the timing of the letter... This cannot be a coincidence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)
  - -> `[311]` (*Player: ""No, Monica. I cannot allow fear to dictate my actions. I..."*)
  - -> `[312]` (*Player: ""That's exactly what they want us to do, Monica. We canno..."*)
  - -> `[317]` (*Player: ""If I don't show support for the victims of Izzam now, I ..."*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. The anniversary won't even take place. All mass gatherings are banned for the remainder of the emergency.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Kontekst wejściowy (poprzednik):** `[309]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Monica: ""That's good to know.""*)

### Węzeł `[311]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Monica. I cannot allow fear to dictate my actions. I cannot let the Bludish people down. You have to trust me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Monica: ""You cannot simply decide that by yourself. This is about..."*)

### Węzeł `[312]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's exactly what they want us to do, Monica. We cannot give in to their threats. Don't worry. I will take the necessary security precautions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Monica: ""You cannot simply decide that by yourself. This is about..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == tr..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Player: ""Don't worry, Monica. The anniversary won't even take pla..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true &&
BaseGame.Decision_Turn05_AutocratEmergency_Extend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Player: ""Don't worry, Monica. I will not attend the anniversary. ..."*)

### Węzeł `[316]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry, Monica. I will not attend the anniversary. I will not take any risks.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and 
Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[309]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Monica: ""That's good to know.""*)

### Węzeł `[317]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""If I don't show support for the victims of Izzam now, I fear things may turn out even uglier. We can't let that happen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[309]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Monica: ""You cannot simply decide that by yourself. This is about..."*)

### Węzeł `[318]`
Mówca: **Monica**
> ""You cannot simply decide that by yourself. This is about all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Player: ""Look. You have to trust me. If there is a threat, I will..."*)
  - -> `[321]` (*Player: ""You're underestimating our forces and the power of the s..."*)
  - -> `[322]` (*Player: ""Please, Monica. You have to understand me. This politica..."*)
  - -> `[323]` (*Player: ""You know what? Maybe you're right.""*)

### Węzeł `[319]`
Mówca: **Monica**
> ""That's good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Look. You have to trust me. If there is a threat, I will handle it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""I don't really believe that after all the chaos I've see..."*)

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You're underestimating our forces and the power of the state. Nobody will let a bunch of misguided militants threaten us.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""I don't really believe that after all the chaos I've see..."*)

### Węzeł `[322]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please, Monica. You have to understand me. This political mess can only be solved through diplomacy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Monica: ""I don't really believe that after all the chaos I've see..."*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Maybe you're right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[318]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[324]`
Mówca: **Monica**
> ""Please, Anton. Listen to me this time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "She sighed."*)

### Węzeł `[325]`
Mówca: **Monica**
> ""I don't really believe that after all the chaos I've seen in this country, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Narrator: "She sighed."*)

### Węzeł `[326]`
Mówca: **Monica**
> ""Do you think we can trust the presidential guard after this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Player: ""No. They were never to be completely trusted. We must be..."*)
  - -> `[333]` (*Player: ""No, Monica. I have great reservations about them after t..."*)
  - -> `[334]` (*Player: ""We shouldn't jump to conclusions immediately. They are t..."*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Monica: ""Despite everything you've done, you are still the father..."*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Monica: ""Please, Anton. Listen to me this time.""*)

### Węzeł `[330]`
Mówca: **Monica**
> ""Despite everything you've done, you are still the father of our children. And I don't want you to get hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Monica: ""Please, Anton. Listen to me this time.""*)

### Węzeł `[331]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Monica: ""Do you think we can trust the presidential guard after t..."*)

### Węzeł `[332]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. They were never to be completely trusted. We must be careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Monica: ""You have to do something about our security.""*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No, Monica. I have great reservations about them after this letter. Don't worry, I will try to get to the root of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Monica: ""You have to do something about our security.""*)

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We shouldn't jump to conclusions immediately. They are tasked with protecting our family.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[326]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Monica: ""Well, I don't trust them, Anton!""*)

### Węzeł `[335]`
Mówca: **Monica**
> ""You have to do something about our security.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Player: ""Don't worry. We'll weather this together. I will take th..."*)
  - -> `[338]` (*Player: ""Just let me do my job for once, Monica. I know what to d..."*)
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[336]`
Mówca: **Monica**
> ""Well, I don't trust them, Anton!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Monica: ""You have to do something about our security.""*)

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Don't worry. We'll weather this together. I will take the necessary measures.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[335]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "She did not respond. I knew what I said hadn't made her f..."*)

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just let me do my job for once, Monica. I know what to do. You shouldn't keep worrying.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[335]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "She did not respond. I knew what I said hadn't made her f..."*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will. Don't worry.""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Kontekst wejściowy (poprzednik):** `[335]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "She did not respond. I knew what I said hadn't made her f..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player: ""I will. Don't worry.""*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Player: ""I will, honey. I will.""*)

### Węzeł `[343]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will, honey. I will.""
- **Wymagania odblokowania (kod gry):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Kontekst wejściowy (poprzednik):** `[335]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Narrator: "She did not respond. I knew what I said hadn't made her f..."*)

### Węzeł `[344]`
Mówca: **Narrator**
> "She did not respond. I knew what I said hadn't made her feel any better."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[345]`
Mówca: **Deana**
> ""I already told you!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[346]`
Mówca: **Deana**
> ""Why wouldn't I be?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[347]`
Mówca: **Deana**
> ""Okay...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)

### Węzeł `[348]`
Mówca: **Monica**
> ""Isn't that your new VP, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Monica: ""How do you keep finding men like this?""*)

### Węzeł `[349]`
Mówca: **Monica**
> ""I've also seen that more and more protests have been popping up around the country lately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Monica: ""I'm worried that things may get out of hand.""*)

### Węzeł `[350]`
Mówca: **Monica**
> ""I'm worried that things may get out of hand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Player: ""There's no need for concern. People are just voicing the..."*)
  - -> `[352]` (*Player: ""I'm aware. It concerns me as well. But I'll take all the..."*)
  - -> `[353]` (*Player: ""Well, there's nothing I can do about that. Can I?""*)
  - -> `[354]` (*Player: ""They're just a bunch of traitors who are being supported..."*)

### Węzeł `[351]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""There's no need for concern. People are just voicing their criticism.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Monica: ""I guess you're right.""*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm aware. It concerns me as well. But I'll take all the necessary steps, don't you worry.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Monica: ""I'm sure you can handle it.""*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Well, there's nothing I can do about that. Can I?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Monica: ""I guess you're right.""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""They're just a bunch of traitors who are being supported by foreign powers. The moment they truly pose a threat, they will be taken care of.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Monica: ""Listen to yourself. I think you need a break, Anton.""*)

### Węzeł `[355]`
Mówca: **Monica**
> ""I guess you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Monica: ""But I think you need a break, Anton.""*)

### Węzeł `[356]`
Mówca: **Monica**
> ""Listen to yourself. I think you need a break, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[357]`
Mówca: **Monica**
> ""But I think you need a break, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[360]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "Just then, we heard the patter of small feet approaching ..."*)

### Węzeł `[360]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Monica: ""Maybe we can make some time for a little getaway.""*)

### Węzeł `[361]`
Mówca: **Monica**
> ""Isn't that the one who challenged you for USP candidacy, Anton?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Monica: ""Why is your party still filled with men like this?""*)

### Węzeł `[362]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn08_VPSelection_Albin == true"*)
  - -> `[364]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn08_VPSelection_Albin == true)"*)

### Węzeł `[363]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn08_VPSelection_Albin == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Monica: ""Isn't that your new VP, Anton?""*)

### Węzeł `[364]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn08_VPSelection_Albin == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn08_VPSelection_Albin"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Monica: ""Isn't that the one who challenged you for USP candidacy,..."*)

### Węzeł `[365]`
Mówca: **Monica**
> ""How do you keep finding men like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Player: ""Yes... He is the new Vice President.""*)
  - -> `[374]` (*Player: ""What is that supposed to mean?""*)
  - -> `[375]` (*Player: ""Come on, Monica. How would I know about any of this?""*)
  - -> `[376]` (*Player: ""Just another male Sordish politician, Monica. You know h..."*)

### Węzeł `[366]`
Mówca: **Monica**
> ""Why is your party still filled with men like this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Player: ""Yes... That's him, all right.""*)
  - -> `[378]` (*Player: ""What does that supposed to mean?""*)
  - -> `[379]` (*Player: ""Come on, Monica. You know I can't control everything our..."*)
  - -> `[380]` (*Player: ""Just another male Sordish politician, Monica. You know h..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged =..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.BFF_Damaged"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn05_AutocratEmergency_Extend == true..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Destroyed == false && BaseGame.BFF_Damaged == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Destroyed"] == false  and  Variable["BaseGame.BFF_Damaged"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true"*)

### Węzeł `[370]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Damaged == true"*)
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Damaged == true)"*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Damaged == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Damaged"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Deana: ""You may think that you destroyed us. But the will of the..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Damaged == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Damaged"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Her voice started quivering as she continued."*)

### Węzeł `[373]`
Mówca: **Deana**
> ""You may think that you destroyed us. But the will of the people will live on forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Her voice started quivering as she continued."*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What is that supposed to mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Monica: ""Uh. Forget I asked.""*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come on, Monica. How would I know about any of this?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Monica: ""I suppose you wouldn't.""*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just another male Sordish politician, Monica. You know how it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Monica: ""Oh, I know.""*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes... He is the new Vice President.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Monica: ""Great.""*)

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What does that supposed to mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]` (*Monica: ""Uh. Forget I asked.""*)

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Come on, Monica. You know I can't control everything our members do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Monica: ""Maybe you should have some control. These type of men wi..."*)

### Węzeł `[380]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just another male Sordish politician, Monica. You know how it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Monica: ""Oh, I know.""*)

### Węzeł `[381]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes... That's him, all right.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[366]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Monica: ""Great.""*)

### Węzeł `[382]`
Mówca: **Monica**
> ""Oh, I know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[383]`
Mówca: **Monica**
> ""Great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[384]`
Mówca: **Monica**
> ""Uh. Forget I asked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[385]`
Mówca: **Monica**
> ""Maybe you should have some control. These type of men will only destroy the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[386]`
Mówca: **Monica**
> ""Anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)

### Węzeł `[387]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[389]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[388]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]` (*Monica: ""I think I'll continue my the book, Anton.""*)

### Węzeł `[389]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]` (*Monica: ""Are you hungry?""*)

### Węzeł `[390]`
Mówca: **Monica**
> ""I think I'll continue my the book, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""Alright. See you at dinner, Monica.""*)
  - -> `[395]` (*Player: ""Is there something wrong?""*)
  - -> `[396]` (*Player: ""Now?""*)

### Węzeł `[391]`
Mówca: **Monica**
> ""Are you hungry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Monica: ""I didn't cook today, but the chef prepared a wonderful R..."*)

### Węzeł `[392]`
Mówca: **Monica**
> ""I didn't cook today, but the chef prepared a wonderful Rizian meal for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Deana: ""Yes!""*)

### Węzeł `[393]`
Mówca: **Deana**
> ""Yes!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player: ""Great. I am starving.""*)
  - -> `[404]` (*Player: ""Rizian?""*)
  - -> `[405]` (*Player: ""What? He couldn't come up with something Sordish?""*)

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Alright. See you at dinner, Monica.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Monica), `[398]` (Monica), `[399]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "I grabbed Deana's hand and walked out the room."*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Is there something wrong?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Monica: ""No! I just want to read, Anton.""*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Now?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[390]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Monica: ""What do you mean, *now*?""*)

### Węzeł `[397]`
Mówca: **Monica**
> ""What do you mean, *now*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Monica: ""Yes. I just want to read my book.""*)

### Węzeł `[398]`
Mówca: **Monica**
> ""Yes. I just want to read my book.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""Alright. See you at dinner, Monica.""*)
  - -> `[400]` (*Player: ""You can read it another time.""*)
  - -> `[401]` (*Player: ""Fine.""*)

### Węzeł `[399]`
Mówca: **Monica**
> ""No! I just want to read, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Player: ""Alright. See you at dinner, Monica.""*)
  - -> `[400]` (*Player: ""You can read it another time.""*)
  - -> `[401]` (*Player: ""Fine.""*)

### Węzeł `[400]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You can read it another time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Monica), `[399]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[450]` (*Monica: ""Anton, please. Can you leave me alone so I can read in p..."*)

### Węzeł `[401]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[398]` (Monica), `[399]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "I grabbed Deana's hand and walked out the room."*)

### Węzeł `[402]`
Mówca: **Narrator**
> "I grabbed Deana's hand and walked out the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Great. I am starving.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Monica: ""Me too. Let's eat!""*)

### Węzeł `[404]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Rizian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Monica: ""Yes. It's similar to Lespian food, but better. There's a..."*)

### Węzeł `[405]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What? He couldn't come up with something Sordish?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[393]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Monica: ""Oh, come on, Anton. It won't kill you to try something n..."*)

### Węzeł `[406]`
Mówca: **Monica**
> ""Oh, come on, Anton. It won't kill you to try something new.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "She grabbed Deana's hand and we walked to the kitchen tog..."*)

### Węzeł `[407]`
Mówca: **Monica**
> ""Yes. It's similar to Lespian food, but better. There's a lobster dish called 'Toras Flambé!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "She grabbed Deana's hand and we walked to the kitchen tog..."*)

### Węzeł `[408]`
Mówca: **Monica**
> ""Me too. Let's eat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]` (*Narrator: "She grabbed Deana's hand and we walked to the kitchen tog..."*)

### Węzeł `[409]`
Mówca: **Narrator**
> "She grabbed Deana's hand and we walked to the kitchen together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[410]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Węzeł Logiki Narracyjnej: "(BaseGame.Reform_Turn08_Decree_WomensRights == false && B..."*)
  - -> `[412]` (*Węzeł Logiki Narracyjnej: "!((BaseGame.Reform_Turn08_Decree_WomensRights == false &&..."*)

### Węzeł `[411]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `(BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]` (*Monica: ""I hope so...""*)

### Węzeł `[412]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!((BaseGame.Reform_Turn08_Decree_WomensRights == false && BaseGame.WomensRightCommission == false) || BaseGame.Relations_Monica_Divorce == true || BaseGame.Relations_Monica_Opinion < 0)`
- **Warunek bezpośredni (`conditionsString`):** `((Variable["BaseGame.Reform_Turn08_Decree_WomensRights"] == false  and  Variable["BaseGame.WomensRightCommission"] == false)  or  Variable["BaseGame.Relations_Monica_Divorce"] == true  or  Variable["BaseGame.Relations_Monica_Opinion"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Narrator: "Before I could say anything else, she embraced me tightly."*)

### Węzeł `[413]`
Mówca: **Monica**
> ""I hope so...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Monica: ""I'll go check on Deana.""*)

### Węzeł `[414]`
Mówca: **Narrator**
> "Before I could say anything else, she embraced me tightly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Monica: ""We'll get through this together. We have to.""*)

### Węzeł `[415]`
Mówca: **Monica**
> ""We'll get through this together. We have to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "How real was the threat to my family? Did I really have t..."*)

### Węzeł `[416]`
Mówca: **Narrator**
> "Before I could say anything else, she left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]` (*Narrator: "How real was the threat to my family? Did I really have t..."*)

### Węzeł `[417]`
Mówca: **Monica**
> ""I'll go check on Deana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Narrator: "Before I could say anything else, she left the room."*)

### Węzeł `[418]`
Mówca: **Narrator**
> "How real was the threat to my family? Did I really have the power to guarantee their safety?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Narrator: "I felt a chill running down my spine."*)

### Węzeł `[419]`
Mówca: **Narrator**
> "I felt a chill running down my spine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Węzeł Logiki Narracyjnej: "PlayCustomMapMusic("Map_Music_Tense");  // Plays a custom..."*)

### Węzeł `[420]`
Mówca: **Monica**
> ""Seems like he's following through.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "She sighed."*)

### Węzeł `[421]`
Mówca: **Monica**
> ""I understand. But honestly, maybe it was all for the best in the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Monica: ""Thanks to you, I was just about the only woman at univer..."*)

### Węzeł `[422]`
Mówca: **Monica**
> ""I'm sure you can handle it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Monica: ""But I think you need a break, Anton.""*)

### Węzeł `[423]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's 'retribution', sweetheart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Deana: ""Yes. Retribution. Sorry.""*)

### Węzeł `[424]`
Mówca: **Deana**
> ""Yes. Retribution. Sorry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Deana: ""The safety you have enjoyed so far is nothing but an ill..."*)

### Węzeł `[425]`
Mówca: **Monica**
> ""I suppose you wouldn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]` (*Monica: ""Anyway...""*)

### Węzeł `[426]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_EliminationOperation_Botched == true"*)
  - -> `[428]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_EliminationOperation_Botched == true)"*)

### Węzeł `[427]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_EliminationOperation_Botched == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_EliminationOperation_Botched"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = true"*)

### Węzeł `[428]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_EliminationOperation_Botched == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_EliminationOperation_Botched"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = false"*)

### Węzeł `[429]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Unrest_BFF_WillHappen = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Unrest_BFF_WillHappen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen == true"*)

### Węzeł `[430]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[431]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true && BaseGame.Pol..."*)
  - -> `[432]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.YoungSords_Aids_Security == true && BaseGame.P..."*)

### Węzeł `[431]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchR..."*)

### Węzeł `[432]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.YoungSords_Aids_Security == true && BaseGame.Policy_Law_Ban_RedYouth == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.Policy_Law_Ban_RedYouth"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)

### Węzeł `[433]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Borin_YoungSords_HelpCatchRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)

### Węzeł `[434]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]` (*Węzeł Logiki Narracyjnej: "BaseGame.BFF_Threatens_President == true"*)
  - -> `[436]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.BFF_Threatens_President == true)"*)

### Węzeł `[435]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.BFF_Threatens_President == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.BFF_Threatens_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[437]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn08_Holsord_BFFThreat_President..."*)

### Węzeł `[436]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.BFF_Threatens_President == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.BFF_Threatens_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[437]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn08_Holsord_BFFThreat_PresidentSecurityIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[438]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayCustomMapMusic("Map_Music_Tense");

// Plays a custom map music after conversation is done. This works only once for one conversation`
- **Efekt skryptowy (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");
-- Plays a custom map music after conversation is done. This works only once for one conversation;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true && BaseGame.Pol..."*)

### Węzeł `[439]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true"*)
  - -> `[441]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.YoungSords_Aids_Security == true)"*)

### Węzeł `[440]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)

### Węzeł `[441]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.YoungSords_Aids_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= 0"*)

### Węzeł `[442]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]` (*Węzeł Logiki Narracyjnej: "BaseGame.Public_Opinion <= -5"*)
  - -> `[444]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Public_Opinion <= -5)"*)

### Węzeł `[443]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Public_Opinion <= -5`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Public_Opinion"] <= -5`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_WillHappen = true"*)

### Węzeł `[444]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Public_Opinion <= -5)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Public_Opinion"] <= -5) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[445]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Węzeł Logiki Narracyjnej: "BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF..."*)
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.YoungSords_Aids_Security == true && BaseGame.B..."*)

### Węzeł `[446]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Cent..."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.YoungSords_Aids_Security == true && BaseGame.BFF_EliminationOperation == true && BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.YoungSords_Aids_Security"] == true  and  Variable["BaseGame.BFF_EliminationOperation"] == true  and  Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Decrease"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Węzeł Logiki Narracyjnej: "BaseGame.Unrest_BFF_WillHappen = true"*)

### Węzeł `[448]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayMusic("Mountains");`
- **Efekt skryptowy (`userScript`):** `PlayMusic("Mountains");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "As I stepped through the front door of our stately reside..."*)

### Węzeł `[449]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[450]`
Mówca: **Monica**
> ""Anton, please. Can you leave me alone so I can read in peace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Narrator: "I grabbed Deana's hand and walked out the room."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Even your papa can make mistakes sometimes, Deana. What's important is to remember that we can learn and grow from them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Deana: ""So what are we going to do? We can't let the bad people ..."*)

### Węzeł `[452]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[453]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[454]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Spending some personal time with their own family", "Residence of the President", "Holsord");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Spending some personal time with their own family","Residence of the President","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "//"*)
