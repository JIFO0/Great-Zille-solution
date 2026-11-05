# Rizia/Turn 3/A_VisitToSallabes

- **ID konwersacji:** `308`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/308_A_VisitToSallabes.md`
- **Liczba węzłów dialogowych:** 375
- **Liczba wyborów gracza:** 89

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[72]** Leona Sazon
- **[75]** Manus Sazon
- **[79]** Vina Toras
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.BrunoDog_Adopted`
- `RiziaDLC.Coronation_Speech_AntiMonarchy`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed`
- `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project`
- `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative`
- `RiziaDLC.Policy_RD_Welfare_FreePress`
- `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_Manus_IgnoreFirstMeeting`
- `RiziaDLC.Relations_Manus_ThreatenFirstMeeting`
- `RiziaDLC.Relations_Rico_ShotDog`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Manus_OverthrowMonarchy`
- `RiziaDLC.Relations_Manus_WorkWithRPP`
- `RiziaDLC.Relations_Sazon_ManusTalkSoured`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform`
- `RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty`
- `RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus`
- `RiziaDLCSupport.News_Turn03_RH_ManusSpeech`
- `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative`
- `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive`
- `RiziaDLCSupport.Reports_Turn03_Pales_Assessment`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[9]` | **""I promise I won't try to shoot any of the birds.""** | `[8]` **Narrator**: "My daughter impatiently tapped h..." | `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true` | *Brak zmian stanu* | `[13]` **Narrator**: "She laughed bleakly." |
| `[10]` | **""Don't worry. It'll start soon.""** | `[8]` **Narrator**: "My daughter impatiently tapped h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[128]` **Vina Toras**: ""And after that, another state f..."<br>`[129]` **Vina Toras**: ""The program announced a special..." |
| `[11]` | **""Sit still. Can't you see everyone's watching?""** | `[8]` **Narrator**: "My daughter impatiently tapped h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[39]` **Vina Toras**: ""Yes, I can see everyone watchin..."<br>`[43]` **Vina Toras**: ""Sorry. Just excited to see the ..." |
| `[12]` | **""Are you corresponding with Rico these days?""** | `[8]` **Narrator**: "My daughter impatiently tapped h..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Vina Toras**: ""What? No, I was about ready to ..."<br>`[313]` **Vina Toras**: ""A little bit. He wanted to know..."<br>*(oraz 1 innych odgałęzień)* |
| `[21]` | **""Is he talking about himself?""** | `[20]` **Manus Sazon**: ""An inner voice that tells him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Vina Toras**: ""Shh."" |
| `[22]` | **""I wish he'd get to the point.""** | `[20]` **Manus Sazon**: ""An inner voice that tells him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Vina Toras**: ""Shh."" |
| `[23]` | **""This is so maudlin. Why is the crowd eating it up?""** | `[20]` **Manus Sazon**: ""An inner voice that tells him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Vina Toras**: ""Shh."" |
| `[24]` | **""Huh. The kid has charisma.""** | `[20]` **Manus Sazon**: ""An inner voice that tells him, ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Vina Toras**: ""Shh."" |
| `[46]` | **""Keep your head down, Vina. Too much trust will get you a face full of shit.""** | `[45]` **Narrator**: "The audience gasped as the sky o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Vina Toras**: ""Don't be so crass, Father."" |
| `[49]` | **""Have you ever seen anything so beautiful?""** | `[45]` **Narrator**: "The audience gasped as the sky o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Vina Toras**: ""It's breathtaking."" |
| `[51]` | **""Timing the speech perfectly with the migration? What a cheap trick.""** | `[45]` **Narrator**: "The audience gasped as the sky o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Vina Toras**: ""I don't see anything cheap abou..." |
| `[54]` | **""A simple message. But you can't deny the truth in it.""** | `[45]` **Narrator**: "The audience gasped as the sky o..." | `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false` | *Brak zmian stanu* | `[55]` **Vina Toras**: ""I thought it was beautiful."" |
| `[58]` | **""Mr. Sazon. A pleasure to see you again.""** | `[57]` **Narrator**: "It was nearly an hour before I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Manus smiled and shook my hand." |
| `[59]` | **""That was some speech today. I see why your constituents love you.""** | `[57]` **Narrator**: "It was nearly an hour before I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Narrator**: "Manus smiled and bowed his head." |
| `[60]` | **""Not in the mood to dance, Mr. Sazon?""** | `[57]` **Narrator**: "It was nearly an hour before I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Narrator**: "Manus smiled uncomfortably." |
| `[73]` | **""That seat is reserved for my daughter.""** | `[57]` **Narrator**: "It was nearly an hour before I w..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Narrator**: "Manus gestured across the room. ..." |
| `[79]` | **""Why? What exactly is it that you want?""** | `[72]` **Manus Sazon**: ""Actually, I've been hoping to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[76]` **Narrator**: "He took a measured sip from the ..." |
| `[80]` | **""You assumed wrong. I don't intend to give up a single one of my powers as king.""** | `[204]` **Manus Sazon**: ""I heard your coronation speech...."<br>`[208]` **Manus Sazon**: ""I don't want to make assumption..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[334]` **Narrator**: "He flinched." |
| `[81]` | **""So you are telling me you have absolutely no intention of doing away with the mon..."** | `[204]` **Manus Sazon**: ""I heard your coronation speech...."<br>`[208]` **Manus Sazon**: ""I don't want to make assumption..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Narrator**: "Manus shook his head hurriedly." |
| `[82]` | **""I'm sure you're aware that removing any of the nobility's privileges would invite..."** | `[204]` **Manus Sazon**: ""I heard your coronation speech...."<br>`[208]` **Manus Sazon**: ""I don't want to make assumption..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Manus Sazon**: ""That's why any reforms we imple..." |
| `[109]` | **""They are, and I wish I had time to act on them. But there are international crise..."** | `[204]` **Manus Sazon**: ""I heard your coronation speech...."<br>`[208]` **Manus Sazon**: ""I don't want to make assumption..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[110]` **Manus Sazon**: ""The kind of reforms I'm suggest..." |
| `[119]` | **""Hmm. I thought it would be smaller.""** | `[118]` **Vina Toras**: ""It looks Dastnurist. I wonder i..."<br>`[121]` **Narrator**: "I remembered my orders to fund t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "A fanfare sounded from the pit o..." |
| `[120]` | **""It's a big, expensive building for heretics.""** | `[121]` **Narrator**: "I remembered my orders to fund t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "A fanfare sounded from the pit o..." |
| `[122]` | **""That ought to keep the Wehzeks out of trouble for a while.""** | `[118]` **Vina Toras**: ""It looks Dastnurist. I wonder i..."<br>`[121]` **Narrator**: "I remembered my orders to fund t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "A fanfare sounded from the pit o..." |
| `[123]` | **""Sal was right. Everyone deserves a space to worship God in their own way.""** | `[118]` **Vina Toras**: ""It looks Dastnurist. I wonder i..."<br>`[121]` **Narrator**: "I remembered my orders to fund t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "A fanfare sounded from the pit o..." |
| `[124]` | **""I hope it has good security.""** | `[118]` **Vina Toras**: ""It looks Dastnurist. I wonder i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[361]` **Narrator**: "A fanfare sounded from the pit o..." |
| `[137]` | **""I'm sorry I haven't visited the House of Delegates yet. It's been a busy time.""** | `[72]` **Manus Sazon**: ""Actually, I've been hoping to s..." | `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false` | *Brak zmian stanu* | `[138]` **Manus Sazon**: ""I understand, Your Majesty. The..." |
| `[139]` | **""To be perfectly honest... I've been avoiding you. Too much bad blood.""** | `[72]` **Manus Sazon**: ""Actually, I've been hoping to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Manus Sazon**: ""I understand. But isn't that pr..." |
| `[142]` | **""Do not address my daughter with such impudence, Mr. Sazon.""** | `[86]` **Manus Sazon**: ""That's very noble of you. But t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Narrator**: "Vina rolled her eyes." |
| `[143]` | **""He's right. We've got to tackle this problem at the root, not by granting special..."** | `[86]` **Manus Sazon**: ""That's very noble of you. But t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Vina ignored my remark." |
| `[144]` | **""How drunk are you, Vina? You can't go around making promises to random cater-wait..."** | `[86]` **Manus Sazon**: ""That's very noble of you. But t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Vina ignored my remark." |
| `[145]` | **""Forgive me, Mr. Sazon, but the Princess and I have really got to be going.""** | `[86]` **Manus Sazon**: ""That's very noble of you. But t..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[146]` **Narrator**: "Vina ignored my remark." |
| `[152]` | **""Over my dead body.""** | `[100]` **Narrator**: "She took a step closer towards M..." | `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true` | *Brak zmian stanu* | `[157]` **Narrator**: "Vina fixed me with an indignant ..." |
| `[153]` | **""You don't need my permission. Have fun out there.""** | `[100]` **Narrator**: "She took a step closer towards M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Vina beamed. Manus took her hand..." |
| `[154]` | **""One dance. Then we go home.""** | `[100]` **Narrator**: "She took a step closer towards M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Vina beamed. Manus took her hand..." |
| `[155]` | **""Sorry, but no. People will gossip.""** | `[100]` **Narrator**: "She took a step closer towards M..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Narrator**: "Vina fixed me with an indignant ..." |
| `[160]` | **""Fine, you win. *One* dance.""** | `[159]` **Vina Toras**: ""We're guests here, Father. It'l..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Narrator**: "Vina beamed. Manus took her hand..." |
| `[161]` | **""I've engaged with our host enough. We're going. Now.""** | `[159]` **Vina Toras**: ""We're guests here, Father. It'l..." | `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true` | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[167]` **Narrator**: "Vina let out an exasperated sigh." |
| `[165]` | **""There will be other chances. Let's go.""** | `[159]` **Vina Toras**: ""We're guests here, Father. It'l..." | `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false` | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[167]` **Narrator**: "Vina let out an exasperated sigh." |
| `[166]` | **""No dancing. That's a royal order.""** | `[159]` **Vina Toras**: ""We're guests here, Father. It'l..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[167]` **Narrator**: "Vina let out an exasperated sigh." |
| `[181]` | **""Stop trying to ambush me, Mr. Sazon. Whatever you want, I'm not interested.""** | `[72]` **Manus Sazon**: ""Actually, I've been hoping to s..." | `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true` | *Brak zmian stanu* | `[188]` **Manus Sazon**: ""Please, Your Majesty. Just give..." |
| `[185]` | **""So why didn't you request an audience with me?""** | `[72]` **Manus Sazon**: ""Actually, I've been hoping to s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[186]` **Narrator**: "He gave me a look that was equal..." |
| `[190]` | **""Who's speaking to me right now? The heir of House Sazon or the speaker of the Riz..."** | `[77]` **Manus Sazon**: ""But I still think we have a cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[195]` **Manus Sazon**: ""The two cannot be separated."" |
| `[191]` | **""All right, I'll indulge you. Tell me what you have in mind.""** | `[77]` **Manus Sazon**: ""But I still think we have a cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Manus Sazon**: ""Well, Your Majesty..."" |
| `[192]` | **""You have some nerve even approaching me after what your father did.""** | `[77]` **Manus Sazon**: ""But I still think we have a cha..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[193]` **Manus Sazon**: ""I don't expect you to forgive L..." |
| `[199]` | **""You mentioned a transition. But a transition to what?""** | `[198]` **Manus Sazon**: ""The rest of the RPP and I are i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Narrator**: "Manus traced the rim of his wine..." |
| `[200]` | **""The kind of change you're talking about doesn't happen peacefully. Look at how ma..."** | `[198]` **Manus Sazon**: ""The rest of the RPP and I are i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Manus Sazon**: ""It didn't have to be that way. ..." |
| `[213]` | **""Why? The people of Rizia have everything they want. And if they want more, I'll g..."** | `[233]` **Manus Sazon**: ""I know I am taking a risk by su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Manus Sazon**: ""They want to be heard, Your Maj..." |
| `[214]` | **""Are you trying to threaten me?""** | `[233]` **Manus Sazon**: ""I know I am taking a risk by su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Manus Sazon**: ""Certainly not, Your Majesty. Pr..." |
| `[217]` | **""And House Sazon? What do your relatives think of your crusade against their kind?""** | `[198]` **Manus Sazon**: ""The rest of the RPP and I are i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[218]` **Narrator**: "Manus traced the rim of his wine..." |
| `[224]` | **""A second uprising will not happen during my reign.""** | `[233]` **Manus Sazon**: ""I know I am taking a risk by su..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[234]` **Manus Sazon**: ""I do not doubt the strength of ..." |
| `[226]` | **""How exactly would you back me?""** | `[111]` **Manus Sazon**: ""Just know that should you choos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[249]` **Manus Sazon**: ""We will get the public on your ..." |
| `[227]` | **""'For now'. Is that supposed to be a threat?""** | `[215]` **Manus Sazon**: ""There are factions within Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[245]` **Manus Sazon**: ""No, Your Majesty. The opposite."" |
| `[228]` | **""It's not your job to keep them in check. It's mine.""** | `[215]` **Manus Sazon**: ""There are factions within Rizia..." | `Variable["RiziaDLC.LeaningValue_Democratic"] < 0` | *Brak zmian stanu* | `[246]` **Manus Sazon**: ""Yes, of course. But, Your Majes..." |
| `[229]` | **""That's the right idea. Without an outlet for their demands, they could become dan..."** | `[215]` **Manus Sazon**: ""There are factions within Rizia..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[351]` **Manus Sazon**: ""I agree."" |
| `[230]` | **""Hypothetically, if I, the King of Rizia, asked you to assist me in the complete d..."** | `[215]` **Manus Sazon**: ""There are factions within Rizia..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] = ...` | `[348]` **Manus Sazon**: ""I..."" |
| `[231]` | **""And if I don't?""** | `[111]` **Manus Sazon**: ""Just know that should you choos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[237]` **Manus Sazon**: ""We will not go against you."" |
| `[232]` | **""I am more interested in knowing that House Sazon won't rise against me again.""** | `[111]` **Manus Sazon**: ""Just know that should you choos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Manus Sazon**: ""My house has learned its lesson..." |
| `[238]` | **""I don't like what you're implying. I would advise you to choose your next words v..."** | `[236]` **Manus Sazon**: ""But the longer our people are s..."<br>`[241]` **Manus Sazon**: ""My house has learned its lesson..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Manus Sazon**: ""Well, I..."" |
| `[239]` | **""What in the hell do you mean by that? I have only ever had my people's needs at h..."** | `[225]` **Manus Sazon**: ""The commoners are tired of a ru..."<br>`[235]` **Manus Sazon**: ""But the commoners are tired of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Manus Sazon**: ""Of course. But will your succes..." |
| `[240]` | **""I am looking forward to working more closely with your party to better serve our ..."** | `[235]` **Manus Sazon**: ""But the commoners are tired of ..."<br>`[236]` **Manus Sazon**: ""But the longer our people are s..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Narrator**: "A tentative smile appeared on Ma..." |
| `[242]` | **""I agree with the idea of reforming Rizia and empowering our legislative body. It ..."** | `[235]` **Manus Sazon**: ""But the commoners are tired of ..."<br>`[236]` **Manus Sazon**: ""But the longer our people are s..."<br>*(oraz 4 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[243]` **Narrator**: "Manus' eyes lit up. He smiled co..." |
| `[247]` | **""I appreciate the risk you took in coming to me. It can't have been easy.""** | `[111]` **Manus Sazon**: ""Just know that should you choos..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Manus Sazon**: ""Thank you for hearing me out."" |
| `[250]` | **""We should end this conversation before I'm obliged to have you arrested for treas..."** | `[225]` **Manus Sazon**: ""The commoners are tired of a ru..."<br>`[235]` **Manus Sazon**: ""But the commoners are tired of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Manus Sazon**: ""I see."" |
| `[257]` | **""There is no right venue. You shouldn't have bothered me in the first place.""** | `[253]` **Manus Sazon**: ""I obviously chose the wrong ven..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[276]` **Manus Sazon**: ""Right, yes. Forgive me..."" |
| `[258]` | **""No, please go on. What were you going to tell me?""** | `[253]` **Manus Sazon**: ""I obviously chose the wrong ven..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[275]` **Manus Sazon**: ""Nothing..."" |
| `[260]` | **""My house was chosen by God to rule, Mr. Sazon. Are you saying God made a mistake?""** | `[259]` **Manus Sazon**: ""Of course. But will your succes..."<br>`[285]` **Manus Sazon**: ""I promise you, this is not abou..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[251]` **Manus Sazon**: ""Well, I..."" |
| `[265]` | **""Gladly.""** | `[256]` **Manus Sazon**: ""Please forget I brought this up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[278]` **Manus Sazon**: ""Thank you. I won't trouble you ..." |
| `[266]` | **""I will not forget.""** | `[256]` **Manus Sazon**: ""Please forget I brought this up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[277]` **Manus Sazon**: ""I-- okay. Understood."" |
| `[267]` | **""It's nothing personal. But consider this topic off-limits.""** | `[253]` **Manus Sazon**: ""I obviously chose the wrong ven..."<br>`[256]` **Manus Sazon**: ""Please forget I brought this up..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[268]` **Manus Sazon**: ""No, absolutely. I understand."" |
| `[279]` | **""Don't try to disguise your power grab as altruism, Mr. Sazon. I can see right thr..."** | `[259]` **Manus Sazon**: ""Of course. But will your succes..."<br>`[285]` **Manus Sazon**: ""I promise you, this is not abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[294]` **Manus Sazon**: ""It's not..."" |
| `[280]` | **""I see your point.""** | `[259]` **Manus Sazon**: ""Of course. But will your succes..."<br>`[285]` **Manus Sazon**: ""I promise you, this is not abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Manus Sazon**: ""I would never presume to tell t..." |
| `[281]` | **""What are you implying about my daughter, Mr. Sazon? You believe she's unfit to ru..."** | `[259]` **Manus Sazon**: ""Of course. But will your succes..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[251]` **Manus Sazon**: ""Well, I..."" |
| `[284]` | **""And I suppose your solution to that would be to make yourself Prime Minister?""** | `[225]` **Manus Sazon**: ""The commoners are tired of a ru..."<br>`[235]` **Manus Sazon**: ""But the commoners are tired of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Manus Sazon**: ""I promise you, this is not abou..." |
| `[286]` | **""I agree that my government could be doing more for the non-noble classes.""** | `[225]` **Manus Sazon**: ""The commoners are tired of a ru..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Manus Sazon**: ""I would never presume to tell t..." |
| `[289]` | **""I'll be there.""** | `[283]` **Manus Sazon**: ""Come to the House of Delegates...."<br>`[288]` **Manus Sazon**: ""It would be an honor to see you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "With a smile, he stood up and pu..." |
| `[290]` | **""I'll see what I can do.""** | `[283]` **Manus Sazon**: ""Come to the House of Delegates...."<br>`[288]` **Manus Sazon**: ""It would be an honor to see you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "With a smile, he stood up and pu..." |
| `[291]` | **""Don't get too excited. I'm not promising anything yet.""** | `[283]` **Manus Sazon**: ""Come to the House of Delegates...."<br>`[288]` **Manus Sazon**: ""It would be an honor to see you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Narrator**: "With a smile, he stood up and pu..." |
| `[295]` | **""I understand what you're saying. But now is not the right time to start changing ..."** | `[236]` **Manus Sazon**: ""But the longer our people are s..."<br>`[241]` **Manus Sazon**: ""My house has learned its lesson..."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[296]` **Narrator**: "A disappointed look spread acros..." |
| `[298]` | **""Don't push me, boy. I've given you enough of my time this evening.""** | `[297]` **Manus Sazon**: ""If not now, then when, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Manus Sazon**: ""I see."" |
| `[299]` | **""If and when the Zille crisis is solved, we may be able to revisit the topic.""** | `[297]` **Manus Sazon**: ""If not now, then when, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Narrator**: "He nodded." |
| `[300]` | **""I don't know. I'm sure you understand it's a lot to think about.""** | `[297]` **Manus Sazon**: ""If not now, then when, Your Maj..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Narrator**: "He nodded." |
| `[330]` | **""A giant flock of birds, migrating from a distant land... where have I seen that b..."** | `[45]` **Narrator**: "The audience gasped as the sky o..." | `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true` | *Brak zmian stanu* | `[331]` **Vina Toras**: ""I don't know, Father. It's a be..." |
| `[333]` | **""Indeed. Like you, I sense a sea change coming to Rizia.""** | `[204]` **Manus Sazon**: ""I heard your coronation speech...."<br>`[208]` **Manus Sazon**: ""I don't want to make assumption..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[335]` **Manus Sazon**: ""Listen..."" |
| `[352]` | **""The people have a voice. That's what the House of Delegates is for.""** | `[198]` **Manus Sazon**: ""The rest of the RPP and I are i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[202]` **Manus Sazon**: ""Quite right, Your Majesty. With..." |
| `[366]` | **""Hmm. Perhaps the Sazon matriarch has been punished for long enough.""** | `[365]` **Leona Sazon**: ""It has been 25 years since my b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[371]` **Narrator**: "Vina nodded. She craned her neck..." |
| `[367]` | **""Ha. Nice try, Leona.""** | `[365]` **Leona Sazon**: ""It has been 25 years since my b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Vina ignored me. She craned her ..." |
| `[368]` | **""The only way Angelica is returning to Rizia is in a coffin.""** | `[365]` **Leona Sazon**: ""It has been 25 years since my b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Vina ignored me. She craned her ..." |
| `[370]` | **""I'm bored already. When do we eat?""** | `[365]` **Leona Sazon**: ""It has been 25 years since my b..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[369]` **Narrator**: "Vina ignored me. She craned her ..." |

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
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Meeting the traitor’s son at the Scarlet..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Every spring, the seaside town of Sallabes celebrated the Scarlet Kingbird Festival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "The vibrantly colored songbirds spent their winters in Xi..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "The vibrantly colored songbirds spent their winters in Xina, near the southern part of what used to be the Mousser Empire. Every spring, like clockwork, they flew back over the Gulf of Moridia to settle in Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Their return was celebrated with music, dancing and lavis..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Their return was celebrated with music, dancing and lavish banquets, opened by a speech from the reigning Count or Countess of Sallabes. It was traditional for the King of Rizia and his family to attend."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "The sun hung low in the sky over the Arena Sallabes, a hu..."*)

### Węzeł `[6]`
Mówca: **Manus Sazon**
> ""Greetings, Sallabeans!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Narrator: "He waited for the applause to subside, then held up a han..."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "The sun hung low in the sky over the Arena Sallabes, a hundred-year-old open-air venue perched directly on the beach. Vina and I sat waiting in the royal box as cameras flashed in our direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "My daughter impatiently tapped her fingers on the arm of ..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "My daughter impatiently tapped her fingers on the arm of her chair. We hadn't spoken much since Iza."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Rico_ShotDog == true"*)
  - -> `[10]` (*Player_Romus: ""Don't worry. It'll start soon.""*)
  - -> `[11]` (*Player_Romus: ""Sit still. Can't you see everyone's watching?""*)
  - -> `[12]` (*Player_Romus: ""Are you corresponding with Rico these days?""*)

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I promise I won't try to shoot any of the birds.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true`
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "She laughed bleakly."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. It'll start soon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sit still. Can't you see everyone's watching?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you corresponding with Rico these days?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Rico_ShotDog == true"*)

### Węzeł `[13]`
Mówca: **Narrator**
> "She laughed bleakly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[14]`
Mówca: **Narrator**
> "The audience roared as Manus Sazon got onstage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Leona Sazon"); AddConversant("Manus Saz..."*)

### Węzeł `[15]`
Mówca: **Narrator**
> "He waited for the applause to subside, then held up a hand for the audience to listen. The entire arena fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Manus Sazon: ""The story of the scarlet kingbird is a story about trust.""*)

### Węzeł `[16]`
Mówca: **Manus Sazon**
> ""The story of the scarlet kingbird is a story about trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Manus Sazon: ""Every year, this tiny feathered creature travels thousan..."*)

### Węzeł `[17]`
Mówca: **Manus Sazon**
> ""He doesn't know what perils await him on the way to his destination, nor what sort of welcome will await him there. Yet he flies on, because something deep within his soul compels him to do so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Manus Sazon: ""An inner voice that tells him, 'This is your home.'""*)

### Węzeł `[18]`
Mówca: **Manus Sazon**
> ""Every year, this tiny feathered creature travels thousands of kilometers to reach our shores.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Manus Sazon: ""He doesn't know what perils await him on the way to his ..."*)

### Węzeł `[19]`
Mówca: **Manus Sazon**
> ""And what of those who wait for him? They have no idea where he's been, or how he knows to navigate to this exact same spot each time. Still they gather here, scanning the skies for the first sign of his return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");"*)

### Węzeł `[20]`
Mówca: **Manus Sazon**
> ""An inner voice that tells him, 'This is your home.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Player_Romus: ""I wish he'd get to the point.""*)
  - -> `[23]` (*Player_Romus: ""This is so maudlin. Why is the crowd eating it up?""*)
  - -> `[21]` (*Player_Romus: ""Is he talking about himself?""*)
  - -> `[24]` (*Player_Romus: ""Huh. The kid has charisma.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is he talking about himself?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Vina Toras: ""Shh.""*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wish he'd get to the point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Vina Toras: ""Shh.""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is so maudlin. Why is the crowd eating it up?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Vina Toras: ""Shh.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Huh. The kid has charisma.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Vina Toras: ""Shh.""*)

### Węzeł `[25]`
Mówca: **Vina Toras**
> ""Shh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Narrator: "Vina glared at me, then turned her full attention back to..."*)

### Węzeł `[26]`
Mówca: **Narrator**
> "Vina glared at me, then turned her full attention back to the man on stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Manus Sazon: ""And what of those who wait for him? They have no idea wh..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "As if on cue, a solitary bird came flying towards us from over the horizon. Its plumage was bright red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Narrator: "A tear rolled down Manus' cheek."*)

### Węzeł `[28]`
Mówca: **Narrator**
> "A tear rolled down Manus' cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Manus Sazon: ""Trust. It's the only way any of this works. Even when we..."*)

### Węzeł `[29]`
Mówca: **Manus Sazon**
> ""Trust. It's the only way any of this works. Even when we've been given no reason. Even when our faith is tested, over and over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "A second bird followed, then a third."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "A second bird followed, then a third."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Manus Sazon: ""It's only when we place our trust in one another that we..."*)

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""A little bit. He says Bruno's running almost as fast on three legs as he did on four.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[32]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Rico_ShotDog == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Rico_ShotDog == true"*)
  - -> `[34]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Rico_ShotDog == true)"*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Rico_ShotDog == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)

### Węzeł `[34]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Rico_ShotDog == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Rico_ShotDog"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Vina Toras: ""What? No, I was about ready to murder him after the Iza ..."*)

### Węzeł `[35]`
Mówca: **Vina Toras**
> ""What? No, I was about ready to murder him after the Iza trip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Rico_ShotDog == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Rico_ShotDog == true"*)
  - -> `[38]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Rico_ShotDog == true)"*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Rico_ShotDog == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Rico_ShotDog"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Player_Romus: ""I promise I won't try to shoot any of the birds.""*)

### Węzeł `[38]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Rico_ShotDog == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Rico_ShotDog"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[39]`
Mówca: **Vina Toras**
> ""Yes, I can see everyone watching me. Same as yesterday, and tomorrow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[40]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[41]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Vina Toras: ""Yes, I can see everyone watching me. Same as yesterday, ..."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Vina Toras: ""Sorry. Just excited to see the birds.""*)

### Węzeł `[43]`
Mówca: **Vina Toras**
> ""Sorry. Just excited to see the birds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[44]`
Mówca: **Manus Sazon**
> ""It's only when we place our trust in one another that we are able to find our way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Narrator: "The audience gasped as the sky over our heads filled with..."*)

### Węzeł `[45]`
Mówca: **Narrator**
> "The audience gasped as the sky over our heads filled with hundreds and hundreds of kingbirds, their crimson feathers magnificently lit by the setting sun."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Player_Romus: ""Keep your head down, Vina. Too much trust will get you a..."*)
  - -> `[49]` (*Player_Romus: ""Have you ever seen anything so beautiful?""*)
  - -> `[51]` (*Player_Romus: ""Timing the speech perfectly with the migration? What a c..."*)
  - -> `[327]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep your head down, Vina. Too much trust will get you a face full of shit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Vina Toras: ""Don't be so crass, Father.""*)

### Węzeł `[47]`
Mówca: **Vina Toras**
> ""Don't be so crass, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina sniffled. She had tears in her eyes as well."*)

### Węzeł `[48]`
Mówca: **Narrator**
> "Vina sniffled. She had tears in her eyes as well."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Manus Sazon"); RemoveConversant("Vina T..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you ever seen anything so beautiful?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Vina Toras: ""It's breathtaking.""*)

### Węzeł `[50]`
Mówca: **Vina Toras**
> ""It's breathtaking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina sniffled. She had tears in her eyes as well."*)

### Węzeł `[51]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Timing the speech perfectly with the migration? What a cheap trick.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Vina Toras: ""I don't see anything cheap about it.""*)

### Węzeł `[52]`
Mówca: **Vina Toras**
> ""I don't see anything cheap about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina sniffled. She had tears in her eyes as well."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "Once the sun had set and the birds had gone to roost, we made our way to the VIP reception in the neighboring pavilion."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "A big band was playing jazz music as Vina and I entered. ..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A simple message. But you can't deny the truth in it.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Vina Toras: ""I thought it was beautiful.""*)

### Węzeł `[55]`
Mówca: **Vina Toras**
> ""I thought it was beautiful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina sniffled. She had tears in her eyes as well."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "A big band was playing jazz music as Vina and I entered. We immediately found ourselves surrounded by local officials, celebrities and members of the press."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "It was nearly an hour before I was able to sit down. Almo..."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "It was nearly an hour before I was able to sit down. Almost as soon as I parked myself in a chair, I noticed Manus Sazon making his way over to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""Mr. Sazon. A pleasure to see you again.""*)
  - -> `[59]` (*Player_Romus: ""That was some speech today. I see why your constituents ..."*)
  - -> `[73]` (*Player_Romus: ""That seat is reserved for my daughter.""*)
  - -> `[60]` (*Player_Romus: ""Not in the mood to dance, Mr. Sazon?""*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Sazon. A pleasure to see you again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Manus smiled and shook my hand."*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That was some speech today. I see why your constituents love you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Manus smiled and bowed his head."*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not in the mood to dance, Mr. Sazon?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Narrator: "Manus smiled uncomfortably."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Manus smiled and shook my hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || Ri..."*)

### Węzeł `[62]`
Mówca: **Manus Sazon**
> ""A relief to hear, Your Majesty. I wasn't sure what to think after our last meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""Actually, I've been hoping to speak with you for a long ..."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Manus smiled and bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Manus Sazon: ""The birds did most of the heavy lifting. But thank you, ..."*)

### Węzeł `[64]`
Mówca: **Manus Sazon**
> ""The birds did most of the heavy lifting. But thank you, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""Actually, I've been hoping to speak with you for a long ..."*)

### Węzeł `[65]`
Mówca: **Vina Toras**
> ""Rico wrote me that Bruno is back on his feet. Well, three of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "She pointed to a cluster of buildings a little further down the coastline. In the middle of it rose a spire covered in scaffolding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Narrator: "I remembered my orders to fund the construction of an exp..."*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Proj..."*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[112]` (*Vina Toras: ""Oh, what's that over there?""*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[70]`
Mówca: **Narrator**
> "Manus smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Manus Sazon: ""I'm better off on the debate floor than the dance floor,..."*)

### Węzeł `[71]`
Mówca: **Manus Sazon**
> ""I'm better off on the debate floor than the dance floor, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""Actually, I've been hoping to speak with you for a long ..."*)

### Węzeł `[72]`
Mówca: **Manus Sazon**
> ""Actually, I've been hoping to speak with you for a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player_Romus: ""Why? What exactly is it that you want?""*)
  - -> `[139]` (*Player_Romus: ""To be perfectly honest... I've been avoiding you. Too mu..."*)
  - -> `[185]` (*Player_Romus: ""So why didn't you request an audience with me?""*)
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || Ri..."*)

### Węzeł `[73]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That seat is reserved for my daughter.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Narrator: "Manus gestured across the room. Vina was standing by the ..."*)

### Węzeł `[74]`
Mówca: **Narrator**
> "Manus gestured across the room. Vina was standing by the bar, having an animated conversation with the Derdian bartender."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Manus Sazon: ""With your permission, Your Majesty, I'd like to keep it ..."*)

### Węzeł `[75]`
Mówca: **Manus Sazon**
> ""With your permission, Your Majesty, I'd like to keep it warm for a moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""Actually, I've been hoping to speak with you for a long ..."*)

### Węzeł `[76]`
Mówca: **Narrator**
> "He took a measured sip from the wine glass he was holding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Manus Sazon: ""I know what you and your family think of me. And I know ..."*)

### Węzeł `[77]`
Mówca: **Manus Sazon**
> ""But I still think we have a chance to accomplish great things for this country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Player_Romus: ""All right, I'll indulge you. Tell me what you have in mi..."*)
  - -> `[190]` (*Player_Romus: ""Who's speaking to me right now? The heir of House Sazon ..."*)
  - -> `[192]` (*Player_Romus: ""You have some nerve even approaching me after what your ..."*)

### Węzeł `[78]`
Mówca: **Manus Sazon**
> ""As I said, I am not my father. Another revolution would damage the country and endanger what's left of my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Manus Sazon: ""There are factions within Rizia that have other, more ra..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? What exactly is it that you want?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Narrator: "He took a measured sip from the wine glass he was holding."*)

### Węzeł `[80]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You assumed wrong. I don't intend to give up a single one of my powers as king.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Manus Sazon), `[208]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Narrator: "He flinched."*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So you are telling me you have absolutely no intention of doing away with the monarchy?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Manus Sazon), `[208]` (Manus Sazon), `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Manus shook his head hurriedly."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure you're aware that removing any of the nobility's privileges would invite the wrath of all three royal houses. Yours included.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Manus Sazon), `[208]` (Manus Sazon), `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Manus Sazon: ""That's why any reforms we implemented would have to proc..."*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Manus shook his head hurriedly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Manus Sazon: ""As I said, I am not my father. Another revolution would ..."*)

### Węzeł `[84]`
Mówca: **Manus Sazon**
> ""I apologize for the misunderstanding.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[85]`
Mówca: **Vina Toras**
> ""I was just speaking to the bartender. He's still trying to get the rest of his family out of Derdia. I told him I'd see what I could do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Narrator: "Manus smiled warmly."*)

### Węzeł `[86]`
Mówca: **Manus Sazon**
> ""That's very noble of you. But there are thousands like him, and not all of them are lucky enough to catch the Princess of Rizia at a benevolent moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Player_Romus: ""Do not address my daughter with such impudence, Mr. Sazon.""*)
  - -> `[143]` (*Player_Romus: ""He's right. We've got to tackle this problem at the root..."*)
  - -> `[144]` (*Player_Romus: ""How drunk are you, Vina? You can't go around making prom..."*)
  - -> `[145]` (*Player_Romus: ""Forgive me, Mr. Sazon, but the Princess and I have reall..."*)

### Węzeł `[87]`
Mówca: **Narrator**
> "She turned to Manus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""Your speech was beautiful, Mr. Sazon. Actually, it reminded me of an essay of Queen Lyza's from 1883--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Manus Sazon: ""'On Social Contracts.' Yes, that was one inspiration.""*)

### Węzeł `[89]`
Mówca: **Vina Toras**
> ""What were the others?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "The band began playing "Sweetheart of Ventrie City," an u..."*)

### Węzeł `[90]`
Mówca: **Manus Sazon**
> ""'On Social Contracts.' Yes, that was one inspiration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Vina Toras: ""What were the others?""*)

### Węzeł `[91]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""Your speech was beautiful, Mr. Sazon. Actually, it remin..."*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Vina Toras: ""Your speech was beautiful, Mr. Sazon. Actually, it remin..."*)

### Węzeł `[94]`
Mówca: **Vina Toras**
> ""Your speech was beautiful, Mr. Sazon. Actually, it reminded me of something from a book I read recently.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Manus Sazon: ""Really? I'd love to hear more about it.""*)

### Węzeł `[95]`
Mówca: **Manus Sazon**
> ""Really? I'd love to hear more about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "The band began playing "Sweetheart of Ventrie City", an u..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "The band began playing "Sweetheart of Ventrie City", an upbeat tune that had recently reached us from Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Vina Toras: ""You know what? I'll tell you after this dance.""*)

### Węzeł `[97]`
Mówca: **Vina Toras**
> ""You know what? I'll tell you after this dance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She took a step closer towards Manus and extended a hand ..."*)

### Węzeł `[98]`
Mówca: **Narrator**
> "The band began playing "Sweetheart of Ventrie City," an upbeat tune that had recently reached us from Arcasia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Vina Toras: ""You know what? Tell me after this dance.""*)

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You know what? Tell me after this dance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "She took a step closer towards Manus and extended a hand ..."*)

### Węzeł `[100]`
Mówca: **Narrator**
> "She took a step closer towards Manus and extended a hand to him. He looked at me questioningly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[155]` (*Player_Romus: ""Sorry, but no. People will gossip.""*)
  - -> `[153]` (*Player_Romus: ""You don't need my permission. Have fun out there.""*)
  - -> `[154]` (*Player_Romus: ""One dance. Then we go home.""*)

### Węzeł `[101]`
Mówca: **Vina Toras**
> ""Wait, this is faster than the dances I've been learning. Do you know the steps?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Manus Sazon: ""As a matter of fact, I do. I'll walk you through it.""*)

### Węzeł `[102]`
Mówca: **Manus Sazon**
> ""As a matter of fact, I do. I'll walk you through it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)

### Węzeł `[103]`
Mówca: **Narrator**
> "If he did, Vina didn't notice. Cameras flashed as the two of them started dancing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "I wondered if the photographers were capturing the look i..."*)

### Węzeł `[104]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[106]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[105]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "It was the same one her mother had given me during our fi..."*)

### Węzeł `[106]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "In all the years I'd been with Lena, my wife had never lo..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "It was the same one her mother had given me during our first dance together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "In all the years I'd been with Lena, my wife had never looked at me that way."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[109]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They are, and I wish I had time to act on them. But there are international crises that require my full attention.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Manus Sazon), `[208]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Manus Sazon: ""The kind of reforms I'm suggesting can keep Rizia stable..."*)

### Węzeł `[110]`
Mówca: **Manus Sazon**
> ""The kind of reforms I'm suggesting can keep Rizia stable through such crises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[111]`
Mówca: **Manus Sazon**
> ""Just know that should you choose to guide Rizia in a more democratic direction, my party is prepared to back you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Player_Romus: ""How exactly would you back me?""*)
  - -> `[232]` (*Player_Romus: ""I am more interested in knowing that House Sazon won't r..."*)
  - -> `[231]` (*Player_Romus: ""And if I don't?""*)
  - -> `[247]` (*Player_Romus: ""I appreciate the risk you took in coming to me. It can't..."*)

### Węzeł `[112]`
Mówca: **Vina Toras**
> ""Oh, what's that over there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "She pointed to a cluster of buildings a little further do..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Vina Toras: ""Look over there, by the way.""*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[116]`
Mówca: **Narrator**
> "She pointed to a cluster of buildings a little further down the coastline. In the middle of it rose a spire covered in scaffolding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Vina Toras: ""It looks Dastnurist. I wonder if that's the sanctuary th..."*)

### Węzeł `[117]`
Mówca: **Vina Toras**
> ""Look over there, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "She pointed to a cluster of buildings a little further do..."*)

### Węzeł `[118]`
Mówca: **Vina Toras**
> ""It looks Dastnurist. I wonder if that's the sanctuary the Grand Wiseman was asking for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""I hope it has good security.""*)
  - -> `[119]` (*Player_Romus: ""Hmm. I thought it would be smaller.""*)
  - -> `[122]` (*Player_Romus: ""That ought to keep the Wehzeks out of trouble for a while.""*)
  - -> `[123]` (*Player_Romus: ""Sal was right. Everyone deserves a space to worship God ..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. I thought it would be smaller.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Vina Toras), `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a big, expensive building for heretics.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[121]`
Mówca: **Narrator**
> "I remembered my orders to fund the construction of an expanded Dastnurist Grandsanctuary in Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Player_Romus: ""Hmm. I thought it would be smaller.""*)
  - -> `[122]` (*Player_Romus: ""That ought to keep the Wehzeks out of trouble for a while.""*)
  - -> `[120]` (*Player_Romus: ""It's a big, expensive building for heretics.""*)
  - -> `[123]` (*Player_Romus: ""Sal was right. Everyone deserves a space to worship God ..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That ought to keep the Wehzeks out of trouble for a while.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Vina Toras), `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sal was right. Everyone deserves a space to worship God in their own way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Vina Toras), `[121]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I hope it has good security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[118]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Narrator: "A fanfare sounded from the pit orchestra, and a dark-hair..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Vina Toras: ""And after that, another state function, and another...""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Vina Toras: ""The program announced a special guest. I wonder who it'l..."*)

### Węzeł `[128]`
Mówca: **Vina Toras**
> ""And after that, another state function, and another...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[129]`
Mówca: **Vina Toras**
> ""The program announced a special guest. I wonder who it'll be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "He led Vina out onto the dance floor. I could swear he ha..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "He led Vina out onto the dance floor. Cameras flashed as ..."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "He led Vina out onto the dance floor. I could swear he had the faintest hint of a smirk on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Narrator: "If he did, Vina didn't notice. Cameras flashed as the two..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "He led Vina out onto the dance floor. Cameras flashed as the two of them started dancing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "I wondered if the photographers were capturing the look i..."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "I wondered if the photographers were capturing the look in my daughter's eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus = true; RiziaDLCS..."*)

### Węzeł `[136]`
Mówca: **Narrator**
> "This was no longer the nervous young man I'd met in Porte Drazon. He radiated confidence as he stepped up to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Manus Sazon: ""Greetings, Sallabeans!""*)

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry I haven't visited the House of Delegates yet. It's been a busy time.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[72]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Manus Sazon: ""I understand, Your Majesty. The Zille incident rattled u..."*)

### Węzeł `[138]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. The Zille incident rattled us all. My family included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Manus Sazon: ""But I still think we have a chance to accomplish great t..."*)

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""To be perfectly honest... I've been avoiding you. Too much bad blood.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Manus Sazon: ""I understand. But isn't that precisely *why* we should t..."*)

### Węzeł `[140]`
Mówca: **Manus Sazon**
> ""I understand. But isn't that precisely *why* we should talk?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Manus Sazon: ""I know what you and your family think of me. And I know ..."*)

### Węzeł `[141]`
Mówca: **Narrator**
> "Manus smiled warmly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Manus Sazon: ""That's very noble of you. But there are thousands like h..."*)

### Węzeł `[142]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do not address my daughter with such impudence, Mr. Sazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Narrator: "Vina rolled her eyes."*)

### Węzeł `[143]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right. We've got to tackle this problem at the root, not by granting special favors.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Vina ignored my remark."*)

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How drunk are you, Vina? You can't go around making promises to random cater-waiters.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Vina ignored my remark."*)

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forgive me, Mr. Sazon, but the Princess and I have really got to be going.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[86]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Narrator: "Vina ignored my remark."*)

### Węzeł `[146]`
Mówca: **Narrator**
> "Vina ignored my remark."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[147]`
Mówca: **Narrator**
> "Vina rolled her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Vina Toras: ""He was speaking to me as an equal, Father. I welcome his..."*)

### Węzeł `[148]`
Mówca: **Vina Toras**
> ""He was speaking to me as an equal, Father. I welcome his opinions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "She turned to Manus."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Player_Romus: ""Over my dead body.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Over my dead body.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Vina fixed me with an indignant stare."*)

### Węzeł `[153]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need my permission. Have fun out there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Vina beamed. Manus took her hand and rose from his seat."*)

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""One dance. Then we go home.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Vina beamed. Manus took her hand and rose from his seat."*)

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry, but no. People will gossip.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "Vina fixed me with an indignant stare."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "Vina beamed. Manus took her hand and rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Vina Toras: ""Wait, this is faster than the dances I've been learning...."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "Vina fixed me with an indignant stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Vina Toras: ""We're guests here, Father. It'll look bad if we leave wi..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Narrator: "Vina let out an exasperated sigh."*)

### Węzeł `[159]`
Mówca: **Vina Toras**
> ""We're guests here, Father. It'll look bad if we leave without engaging with our hosts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[166]` (*Player_Romus: ""No dancing. That's a royal order.""*)
  - -> `[160]` (*Player_Romus: ""Fine, you win. *One* dance.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, you win. *One* dance.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "Vina beamed. Manus took her hand and rose from his seat."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've engaged with our host enough. We're going. Now.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Player_Romus: ""I've engaged with our host enough. We're going. Now.""*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Player_Romus: ""There will be other chances. Let's go.""*)

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There will be other chances. Let's go.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No dancing. That's a royal order.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[159]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[167]`
Mówca: **Narrator**
> "Vina let out an exasperated sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Vina Toras: ""I do apologize, Mr. Sazon. It's been lovely to spend tim..."*)

### Węzeł `[168]`
Mówca: **Vina Toras**
> ""I do apologize, Mr. Sazon. It's been lovely to spend time in your family's province.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Manus Sazon: ""The pleasure has been all mine.""*)

### Węzeł `[169]`
Mówca: **Manus Sazon**
> ""The pleasure has been all mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "He took Vina's hand and pressed it to his lips."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "He took Vina's hand and pressed it to his lips."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Manus Sazon: ""Until next time, Your Highness. Your Majesty.""*)

### Węzeł `[171]`
Mówca: **Manus Sazon**
> ""Until next time, Your Highness. Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "I saw her sneak a look back at him as we left the ballroom."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "I saw her sneak a look back at him as we left the ballroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Narrator: "It was a look I knew well. I'd seen it in her mother's ey..."*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "In all the years I'd been with Lena, my wife had never lo..."*)

### Węzeł `[176]`
Mówca: **Narrator**
> "It was a look I knew well. I'd seen it in her mother's eyes the day we first met."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus = true;
RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] = true;
Variable["RiziaDLCSupport.News_Turn03_RH_Gossip_VinaManus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || Ri..."*)
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Manus Sazon: ""A relief to hear, Your Majesty. I wasn't sure what to th..."*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Manus Sazon: ""Actually, I've been hoping to speak with you for a long ..."*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stop trying to ambush me, Mr. Sazon. Whatever you want, I'm not interested.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true`
- **Kontekst wejściowy (poprzednik):** `[72]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Manus Sazon: ""Please, Your Majesty. Just give me five minutes.""*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || Ri..."*)
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || ..."*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""Stop trying to ambush me, Mr. Sazon. Whatever you want, ..."*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_IgnoreFirstMeeting == true || RiziaDLC.Relations_Manus_ThreatenFirstMeeting == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_IgnoreFirstMeeting"] == true  or  Variable["RiziaDLC.Relations_Manus_ThreatenFirstMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player_Romus: ""I'm sorry I haven't visited the House of Delegates yet. ..."*)

### Węzeł `[185]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So why didn't you request an audience with me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Narrator: "He gave me a look that was equal parts hurt and puzzled."*)

### Węzeł `[186]`
Mówca: **Narrator**
> "He gave me a look that was equal parts hurt and puzzled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Manus Sazon: ""I did, through your Grand Vizier. The message must have ..."*)

### Węzeł `[187]`
Mówca: **Manus Sazon**
> ""I did, through your Grand Vizier. The message must have gotten lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Manus Sazon: ""But since we're both here right now, Your Majesty...""*)

### Węzeł `[188]`
Mówca: **Manus Sazon**
> ""Please, Your Majesty. Just give me five minutes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Manus Sazon: ""I know what you and your family think of me. And I know ..."*)

### Węzeł `[189]`
Mówca: **Manus Sazon**
> ""But since we're both here right now, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Manus Sazon: ""I know what you and your family think of me. And I know ..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who's speaking to me right now? The heir of House Sazon or the speaker of the Rizian People's Party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Manus Sazon: ""The two cannot be separated.""*)

### Węzeł `[191]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right, I'll indulge you. Tell me what you have in mind.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Manus Sazon: ""Well, Your Majesty...""*)

### Węzeł `[192]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You have some nerve even approaching me after what your father did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[77]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Manus Sazon: ""I don't expect you to forgive Lucas Sazon. I haven't for..."*)

### Węzeł `[193]`
Mówca: **Manus Sazon**
> ""I don't expect you to forgive Lucas Sazon. I haven't forgiven him myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Manus Sazon: ""I used to hate him for robbing me of my birthright. Now,..."*)

### Węzeł `[194]`
Mówca: **Manus Sazon**
> ""I used to hate him for robbing me of my birthright. Now, I realize his real crime was robbing Rizia of the peaceful transition it deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Manus Sazon: ""The rest of the RPP and I are in agreement. Our kingdom ..."*)

### Węzeł `[195]`
Mówca: **Manus Sazon**
> ""The two cannot be separated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Manus Sazon: ""I joined the House of Delegates because of Lucas Sazon. ..."*)

### Węzeł `[196]`
Mówca: **Manus Sazon**
> ""I joined the House of Delegates because of Lucas Sazon. Because my father's rash act of violence robbed Rizia of the peaceful transition it deserved.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Manus Sazon: ""The rest of the RPP and I are in agreement. Our kingdom ..."*)

### Węzeł `[197]`
Mówca: **Manus Sazon**
> ""Well, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Manus Sazon: ""I joined the House of Delegates because of Lucas Sazon. ..."*)

### Węzeł `[198]`
Mówca: **Manus Sazon**
> ""The rest of the RPP and I are in agreement. Our kingdom thirsts for reform. We can grant our people a voice without spilling a drop of blood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""The kind of change you're talking about doesn't happen p..."*)
  - -> `[352]` (*Player_Romus: ""The people have a voice. That's what the House of Delega..."*)
  - -> `[199]` (*Player_Romus: ""You mentioned a transition. But a transition to what?""*)
  - -> `[217]` (*Player_Romus: ""And House Sazon? What do your relatives think of your cr..."*)

### Węzeł `[199]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You mentioned a transition. But a transition to what?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Manus traced the rim of his wine glass with his finger."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The kind of change you're talking about doesn't happen peacefully. Look at how many corpses the Century of Revolutions left in its wake.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Manus Sazon: ""It didn't have to be that way. If the kings and queens o..."*)

### Węzeł `[201]`
Mówca: **Manus Sazon**
> ""It didn't have to be that way. If the kings and queens of your father's generation had been willing to compromise, they might have kept their crowns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Manus Sazon: ""I envision a Rizia where the concerns of commoners and n..."*)

### Węzeł `[202]`
Mówca: **Manus Sazon**
> ""Quite right, Your Majesty. With just a few changes, it can fulfill its intended purpose.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Manus Sazon: ""I envision a Rizia where the concerns of commoners and n..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Manus traced the rim of his wine glass with his finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Manus Sazon: ""A true constitutional monarchy, Your Majesty.""*)

### Węzeł `[204]`
Mówca: **Manus Sazon**
> ""I heard your coronation speech. I believe your aims are the same as mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""So you are telling me you have absolutely no intention o..."*)
  - -> `[333]` (*Player_Romus: ""Indeed. Like you, I sense a sea change coming to Rizia.""*)
  - -> `[109]` (*Player_Romus: ""They are, and I wish I had time to act on them. But ther..."*)
  - -> `[82]` (*Player_Romus: ""I'm sure you're aware that removing any of the nobility'..."*)
  - -> `[80]` (*Player_Romus: ""You assumed wrong. I don't intend to give up a single on..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Coronation_Speech_AntiMonarchy == true )"*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Coronation_Speech_AntiMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Manus Sazon: ""I heard your coronation speech. I believe your aims are ..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Coronation_Speech_AntiMonarchy == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Coronation_Speech_AntiMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_I..."*)

### Węzeł `[208]`
Mówca: **Manus Sazon**
> ""I don't want to make assumptions... But could it be that your aims are the same as mine?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""So you are telling me you have absolutely no intention o..."*)
  - -> `[333]` (*Player_Romus: ""Indeed. Like you, I sense a sea change coming to Rizia.""*)
  - -> `[109]` (*Player_Romus: ""They are, and I wish I had time to act on them. But ther..."*)
  - -> `[82]` (*Player_Romus: ""I'm sure you're aware that removing any of the nobility'..."*)
  - -> `[80]` (*Player_Romus: ""You assumed wrong. I don't intend to give up a single on..."*)

### Węzeł `[209]`
Mówca: **Manus Sazon**
> ""I envision a Rizia where the concerns of commoners and nobles are given equal weight. Where an elected parliament makes the laws, but the royals retain their status and influence.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Coronation_Speech_AntiMonarchy == true"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_I..."*)
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] > 0  or  Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Manus Sazon: ""I don't want to make assumptions... But could it be that..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic > 0 || RiziaDLC.Turn02_Intention_ConstitutionalMonarchy == true || RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] > 0  or  Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] == true  or  Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Manus Sazon: ""I know I am taking a risk by suggesting this to you. But..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? The people of Rizia have everything they want. And if they want more, I'll give them more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Manus Sazon: ""They want to be heard, Your Majesty. Not placated.""*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you trying to threaten me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Manus Sazon: ""Certainly not, Your Majesty. Preserving the status of th..."*)

### Węzeł `[215]`
Mówca: **Manus Sazon**
> ""There are factions within Rizia that have other, more radical ideas. The RPP and I are keeping them in check. For now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[227]` (*Player_Romus: ""'For now'. Is that supposed to be a threat?""*)
  - -> `[230]` (*Player_Romus: ""Hypothetically, if I, the King of Rizia, asked you to as..."*)
  - -> `[229]` (*Player_Romus: ""That's the right idea. Without an outlet for their deman..."*)

### Węzeł `[216]`
Mówca: **Manus Sazon**
> ""I know what you and your family think of me. And I know that my position in government is symbolic at best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Manus Sazon: ""But I still think we have a chance to accomplish great t..."*)

### Węzeł `[217]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And House Sazon? What do your relatives think of your crusade against their kind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "Manus traced the rim of his wine glass with his finger."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "Manus traced the rim of his wine glass with his finger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Manus Sazon: ""My crusade is not against the nobility, Your Majesty. It..."*)

### Węzeł `[219]`
Mówca: **Manus Sazon**
> ""My crusade is not against the nobility, Your Majesty. It's on behalf of all Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Manus Sazon: ""I envision a Rizia where the concerns of commoners and n..."*)

### Węzeł `[220]`
Mówca: **Manus Sazon**
> ""That's why any reforms we implemented would have to proceed very gradually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[221]`
Mówca: **Manus Sazon**
> ""I would never presume to tell the King how the country should be run.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Manus Sazon: ""Just know that should you choose to guide Rizia in a mor..."*)

### Węzeł `[222]`
Mówca: **Manus Sazon**
> ""Certainly not, Your Majesty. Preserving the status of the Rizian nobility is as much in my family's interest as it is yours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Manus Sazon: ""But the commoners are tired of a ruling class that place..."*)

### Węzeł `[223]`
Mówca: **Manus Sazon**
> ""They want to be heard, Your Majesty. Not placated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Manus Sazon: ""The commoners are tired of a ruling class that places it..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A second uprising will not happen during my reign.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[233]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Manus Sazon: ""I do not doubt the strength of your regime, Your Majesty.""*)

### Węzeł `[225]`
Mówca: **Manus Sazon**
> ""The commoners are tired of a ruling class that places its own desires above their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Player_Romus: ""I agree that my government could be doing more for the n..."*)
  - -> `[284]` (*Player_Romus: ""And I suppose your solution to that would be to make you..."*)
  - -> `[239]` (*Player_Romus: ""What in the hell do you mean by that? I have only ever h..."*)
  - -> `[250]` (*Player_Romus: ""We should end this conversation before I'm obliged to ha..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How exactly would you back me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Manus Sazon: ""We will get the public on your side. When the time comes..."*)

### Węzeł `[227]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""'For now'. Is that supposed to be a threat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Manus Sazon: ""No, Your Majesty. The opposite.""*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not your job to keep them in check. It's mine.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Kontekst wejściowy (poprzednik):** `[215]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Manus Sazon: ""Yes, of course. But, Your Majesty...""*)

### Węzeł `[229]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's the right idea. Without an outlet for their demands, they could become dangerous.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Manus Sazon: ""I agree.""*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hypothetically, if I, the King of Rizia, asked you to assist me in the complete dismantling of the monarchy, would you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[215]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_OverthrowMonarchy = true; RiziaD..."*)

### Węzeł `[231]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if I don't?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Manus Sazon: ""We will not go against you.""*)

### Węzeł `[232]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am more interested in knowing that House Sazon won't rise against me again.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Manus Sazon: ""My house has learned its lesson, Your Majesty. As long a..."*)

### Węzeł `[233]`
Mówca: **Manus Sazon**
> ""I know I am taking a risk by suggesting this to you. But I believe that unless significant changes are made, we may face another uprising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player_Romus: ""So you are telling me you have absolutely no intention o..."*)
  - -> `[82]` (*Player_Romus: ""I'm sure you're aware that removing any of the nobility'..."*)
  - -> `[214]` (*Player_Romus: ""Are you trying to threaten me?""*)
  - -> `[213]` (*Player_Romus: ""Why? The people of Rizia have everything they want. And ..."*)
  - -> `[224]` (*Player_Romus: ""A second uprising will not happen during my reign.""*)

### Węzeł `[234]`
Mówca: **Manus Sazon**
> ""I do not doubt the strength of your regime, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Manus Sazon: ""But the commoners are tired of a ruling class that place..."*)

### Węzeł `[235]`
Mówca: **Manus Sazon**
> ""But the commoners are tired of a ruling class that places its own desires above their own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[284]` (*Player_Romus: ""And I suppose your solution to that would be to make you..."*)
  - -> `[239]` (*Player_Romus: ""What in the hell do you mean by that? I have only ever h..."*)
  - -> `[250]` (*Player_Romus: ""We should end this conversation before I'm obliged to ha..."*)

### Węzeł `[236]`
Mówca: **Manus Sazon**
> ""But the longer our people are silenced, the louder they will be when they finally speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[295]` (*Player_Romus: ""I understand what you're saying. But now is not the righ..."*)
  - -> `[238]` (*Player_Romus: ""I don't like what you're implying. I would advise you to..."*)

### Węzeł `[237]`
Mówca: **Manus Sazon**
> ""We will not go against you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Manus Sazon: ""But the longer our people are silenced, the louder they ..."*)

### Węzeł `[238]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't like what you're implying. I would advise you to choose your next words very carefully.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Manus Sazon), `[241]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Manus Sazon: ""Well, I...""*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What in the hell do you mean by that? I have only ever had my people's needs at heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Manus Sazon), `[235]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Manus Sazon: ""Of course. But will your successor? Or your successor's ..."*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am looking forward to working more closely with your party to better serve our people. But changing the entire system of government? We probably won't go that far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Manus Sazon), `[236]` (Manus Sazon), `[241]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Narrator: "A tentative smile appeared on Manus' face."*)

### Węzeł `[241]`
Mówca: **Manus Sazon**
> ""My house has learned its lesson, Your Majesty. As long as you treat its members with dignity, they will be among your most loyal supporters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[295]` (*Player_Romus: ""I understand what you're saying. But now is not the righ..."*)
  - -> `[238]` (*Player_Romus: ""I don't like what you're implying. I would advise you to..."*)

### Węzeł `[242]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree with the idea of reforming Rizia and empowering our legislative body. It is my wish that we work together to make it a reality.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[235]` (Manus Sazon), `[236]` (Manus Sazon), `[241]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Narrator: "Manus' eyes lit up. He smiled confidently."*)

### Węzeł `[243]`
Mówca: **Narrator**
> "Manus' eyes lit up. He smiled confidently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Manus Sazon: ""We can discuss this back in the capital, Your Majesty.""*)

### Węzeł `[244]`
Mówca: **Manus Sazon**
> ""We can discuss this back in the capital, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy = true; R..."*)

### Węzeł `[245]`
Mówca: **Manus Sazon**
> ""No, Your Majesty. The opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Manus Sazon: ""The undercurrents to which I refer are like a river. The..."*)

### Węzeł `[246]`
Mówca: **Manus Sazon**
> ""Yes, of course. But, Your Majesty...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Manus Sazon: ""The undercurrents to which I refer are like a river. The..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate the risk you took in coming to me. It can't have been easy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[111]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Manus Sazon: ""Thank you for hearing me out.""*)

### Węzeł `[248]`
Mówca: **Manus Sazon**
> ""Thank you for hearing me out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[295]` (*Player_Romus: ""I understand what you're saying. But now is not the righ..."*)

### Węzeł `[249]`
Mówca: **Manus Sazon**
> ""We will get the public on your side. When the time comes, they will embrace reform without hesitation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC...."*)

### Węzeł `[250]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We should end this conversation before I'm obliged to have you arrested for treason.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Manus Sazon), `[235]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Manus Sazon: ""I see.""*)

### Węzeł `[251]`
Mówca: **Manus Sazon**
> ""Well, I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "He took a handkerchief out of his pocket and dabbed his b..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "He took a handkerchief out of his pocket and dabbed his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Manus Sazon: ""I obviously chose the wrong venue for this conversation.""*)

### Węzeł `[253]`
Mówca: **Manus Sazon**
> ""I obviously chose the wrong venue for this conversation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Player_Romus: ""It's nothing personal. But consider this topic off-limits.""*)
  - -> `[258]` (*Player_Romus: ""No, please go on. What were you going to tell me?""*)
  - -> `[257]` (*Player_Romus: ""There is no right venue. You shouldn't have bothered me ..."*)

### Węzeł `[254]`
Mówca: **Manus Sazon**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Narrator: "He took a handkerchief out of his pocket and dabbed his b..."*)

### Węzeł `[255]`
Mówca: **Narrator**
> "He took a handkerchief out of his pocket and dabbed his brow."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Manus Sazon: ""Please forget I brought this up with you, then..""*)

### Węzeł `[256]`
Mówca: **Manus Sazon**
> ""Please forget I brought this up with you, then..""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Player_Romus: ""Gladly.""*)
  - -> `[266]` (*Player_Romus: ""I will not forget.""*)
  - -> `[267]` (*Player_Romus: ""It's nothing personal. But consider this topic off-limits.""*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There is no right venue. You shouldn't have bothered me in the first place.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Manus Sazon: ""Right, yes. Forgive me...""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No, please go on. What were you going to tell me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Manus Sazon: ""Nothing...""*)

### Węzeł `[259]`
Mówca: **Manus Sazon**
> ""Of course. But will your successor? Or your successor's successor? We've seen how risky it is to let the fate of the country rest on a single ruler.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""I see your point.""*)
  - -> `[279]` (*Player_Romus: ""Don't try to disguise your power grab as altruism, Mr. S..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[281]` (*Player_Romus: ""What are you implying about my daughter, Mr. Sazon? You ..."*)

### Węzeł `[260]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My house was chosen by God to rule, Mr. Sazon. Are you saying God made a mistake?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[259]` (Manus Sazon), `[285]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Manus Sazon: ""Well, I...""*)

### Węzeł `[261]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[262]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus: ""My house was chosen by God to rule, Mr. Sazon. Are you s..."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured = true;
RiziaDLC.Relations_Vina -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He turned around to head to the bar and came face to face..."*)

### Węzeł `[265]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Gladly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Manus Sazon: ""Thank you. I won't trouble you again.""*)

### Węzeł `[266]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will not forget.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[256]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Manus Sazon: ""I-- okay. Understood.""*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's nothing personal. But consider this topic off-limits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Manus Sazon), `[256]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Manus Sazon: ""No, absolutely. I understand.""*)

### Węzeł `[268]`
Mówca: **Manus Sazon**
> ""No, absolutely. I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He stood up and pushed back his chair."*)

### Węzeł `[269]`
Mówca: **Narrator**
> "He stood up and pushed back his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Manus Sazon: ""If you'll excuse me, Your Majesty, I'm going to refresh ..."*)

### Węzeł `[270]`
Mówca: **Manus Sazon**
> ""If you'll excuse me, Your Majesty, I'm going to refresh my drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured = true; RiziaDLC..."*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He turned around to head to the bar and came face to face with Vina, who was returning to our table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Narrator: "Her face was slightly flushed."*)

### Węzeł `[272]`
Mówca: **Narrator**
> "Her face was slightly flushed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Vina Toras: ""Oh, excuse me, Mr. Sazon.""*)

### Węzeł `[273]`
Mówca: **Vina Toras**
> ""Oh, excuse me, Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Manus Sazon: ""Nothing to excuse, Your Highness. I hope you're enjoying..."*)

### Węzeł `[274]`
Mówca: **Manus Sazon**
> ""Nothing to excuse, Your Highness. I hope you're enjoying your time in Sallabes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Vina Toras: ""I was just speaking to the bartender. He's still trying ..."*)

### Węzeł `[275]`
Mówca: **Manus Sazon**
> ""Nothing...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He stood up and pushed back his chair."*)

### Węzeł `[276]`
Mówca: **Manus Sazon**
> ""Right, yes. Forgive me...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He stood up and pushed back his chair."*)

### Węzeł `[277]`
Mówca: **Manus Sazon**
> ""I-- okay. Understood.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He stood up and pushed back his chair."*)

### Węzeł `[278]`
Mówca: **Manus Sazon**
> ""Thank you. I won't trouble you again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Narrator: "He stood up and pushed back his chair."*)

### Węzeł `[279]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't try to disguise your power grab as altruism, Mr. Sazon. I can see right through you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Manus Sazon), `[285]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Manus Sazon: ""It's not...""*)

### Węzeł `[280]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see your point.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Manus Sazon), `[285]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you implying about my daughter, Mr. Sazon? You believe she's unfit to rule?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[259]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Manus Sazon: ""Well, I...""*)

### Węzeł `[282]`
Mówca: **Narrator**
> "A tentative smile appeared on Manus' face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Manus Sazon: ""I understand, Your Majesty. Of course my party would be ..."*)

### Węzeł `[283]`
Mówca: **Manus Sazon**
> ""Come to the House of Delegates. You should have an idea how the current system works before we begin talking about how to fix it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""Don't get too excited. I'm not promising anything yet.""*)
  - -> `[289]` (*Player_Romus: ""I'll be there.""*)
  - -> `[290]` (*Player_Romus: ""I'll see what I can do.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And I suppose your solution to that would be to make yourself Prime Minister?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Manus Sazon), `[235]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Manus Sazon: ""I promise you, this is not about what I want. It's about..."*)

### Węzeł `[285]`
Mówca: **Manus Sazon**
> ""I promise you, this is not about what I want. It's about securing the stability of the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Player_Romus: ""I see your point.""*)
  - -> `[279]` (*Player_Romus: ""Don't try to disguise your power grab as altruism, Mr. S..."*)
  - -> `[261]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[286]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I agree that my government could be doing more for the non-noble classes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[225]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[287]`
Mówca: **Manus Sazon**
> ""I understand, Your Majesty. Of course my party would be thrilled to have your ear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty = true..."*)

### Węzeł `[288]`
Mówca: **Manus Sazon**
> ""It would be an honor to see you at the next House of Delegates session.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Player_Romus: ""Don't get too excited. I'm not promising anything yet.""*)
  - -> `[289]` (*Player_Romus: ""I'll be there.""*)
  - -> `[290]` (*Player_Romus: ""I'll see what I can do.""*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll be there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Manus Sazon), `[288]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "With a smile, he stood up and pushed back his chair."*)

### Węzeł `[290]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll see what I can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Manus Sazon), `[288]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "With a smile, he stood up and pushed back his chair."*)

### Węzeł `[291]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't get too excited. I'm not promising anything yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[283]` (Manus Sazon), `[288]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Narrator: "With a smile, he stood up and pushed back his chair."*)

### Węzeł `[292]`
Mówca: **Narrator**
> "With a smile, he stood up and pushed back his chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Manus Sazon: ""I've taken up enough of your time. If you'll excuse me, ..."*)

### Węzeł `[293]`
Mówca: **Manus Sazon**
> ""I've taken up enough of your time. If you'll excuse me, I'll freshen up my drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He turned around to head to the bar and came face to face..."*)

### Węzeł `[294]`
Mówca: **Manus Sazon**
> ""It's not...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Narrator: "A look of frustration spread across his face."*)

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I understand what you're saying. But now is not the right time to start changing the status quo.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[236]` (Manus Sazon), `[241]` (Manus Sazon), `[248]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "A disappointed look spread across his face."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "A disappointed look spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Manus Sazon: ""If not now, then when, Your Majesty?""*)

### Węzeł `[297]`
Mówca: **Manus Sazon**
> ""If not now, then when, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Player_Romus: ""I don't know. I'm sure you understand it's a lot to thin..."*)
  - -> `[299]` (*Player_Romus: ""If and when the Zille crisis is solved, we may be able t..."*)
  - -> `[298]` (*Player_Romus: ""Don't push me, boy. I've given you enough of my time thi..."*)

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't push me, boy. I've given you enough of my time this evening.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Manus Sazon: ""I see.""*)

### Węzeł `[299]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If and when the Zille crisis is solved, we may be able to revisit the topic.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "He nodded."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. I'm sure you understand it's a lot to think about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[297]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "He nodded."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "He nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Manus Sazon: ""Of course. Forgive me if I overstepped.""*)

### Węzeł `[302]`
Mówca: **Narrator**
> "A look of frustration spread across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "He took a handkerchief out of his pocket and dabbed his b..."*)

### Węzeł `[303]`
Mówca: **Manus Sazon**
> ""Of course. Forgive me if I overstepped.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Manus Sazon: ""It would be an honor to see you at the next House of Del..."*)

### Węzeł `[304]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy = true; RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;
RiziaDLC.LeaningValue_Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Manus Sazon: ""Come to the House of Delegates. You should have an idea ..."*)

### Węzeł `[305]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty = true; 
RiziaDLC.Relations_Manus_WorkWithRPP = true;
RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Journal_Turn03_Manus_WorkWithParty"] = true;
Variable["RiziaDLC.Relations_Manus_WorkWithRPP"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Manus Sazon: ""It would be an honor to see you at the next House of Del..."*)

### Węzeł `[306]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[307]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Vina Toras: ""At least Bruno is adjusting well to life with us. The ch..."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Vina Toras: ""Rico wrote me that Bruno is back on his feet. Well, thre..."*)

### Węzeł `[309]`
Mówca: **Vina Toras**
> ""At least Bruno is adjusting well to life with us. The chefs have him spoiled rotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.BrunoDog_Adopted == true"*)
  - -> `[312]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.BrunoDog_Adopted == true)"*)

### Węzeł `[311]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.BrunoDog_Adopted == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.BrunoDog_Adopted"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Vina Toras: ""A little bit. He wanted to know how Bruno was doing at t..."*)

### Węzeł `[312]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.BrunoDog_Adopted == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.BrunoDog_Adopted"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Vina Toras: ""A little bit. He says Bruno's running almost as fast on ..."*)

### Węzeł `[313]`
Mówca: **Vina Toras**
> ""A little bit. He wanted to know how Bruno was doing at the palace. I told him the chefs have him spoiled rotten.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_Welfare_SallabesSanctuaryExpansion_Projec..."*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Manus Sazon");
RemoveConversant("Vina Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "Once the sun had set and the birds had gone to roost, we ..."*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)
  - -> `[317]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)"*)

### Węzeł `[316]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Sazon_ManusTalkSoured == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative = true"*)

### Węzeł `[317]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Sazon_ManusTalkSoured == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Sazon_ManusTalkSoured"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive = true"*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Negative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_ManusSpeech = true"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_V_ManusMeeting_Positive"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_ManusSpeech = true"*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true"*)
  - -> `[322]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true)"*)

### Węzeł `[321]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Sazon_ManusTalkSoured == true"*)

### Węzeł `[322]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_RH_ManusSpeech = true"*)

### Węzeł `[323]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_RH_ManusSpeech = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_RH_ManusSpeech"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn03_Pales_Assessment = true"*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Alliances","R_Alliances_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "Every spring, the seaside town of Sallabes celebrated the..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn03_Pales_Assessment = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn03_Pales_Assessment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[327]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true"*)
  - -> `[329]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == t..."*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Player_Romus: ""A giant flock of birds, migrating from a distant land......"*)

### Węzeł `[329]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""A simple message. But you can't deny the truth in it.""*)

### Węzeł `[330]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A giant flock of birds, migrating from a distant land... where have I seen that before?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Turn01_Briefing_Religious_CeremonyVisions"] == true`
- **Kontekst wejściowy (poprzednik):** `[45]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Vina Toras: ""I don't know, Father. It's a beautiful sight, though.""*)

### Węzeł `[331]`
Mówca: **Vina Toras**
> ""I don't know, Father. It's a beautiful sight, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "Vina sniffled. She had tears in her eyes as well."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "As if on cue, a solitary bird came flying towards us from..."*)

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Indeed. Like you, I sense a sea change coming to Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[204]` (Manus Sazon), `[208]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Manus Sazon: ""Listen...""*)

### Węzeł `[334]`
Mówca: **Narrator**
> "He flinched."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Manus Sazon: ""I apologize for the misunderstanding.""*)

### Węzeł `[335]`
Mówca: **Manus Sazon**
> ""Listen...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.LeaningValue_Democratic < 0"*)
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.LeaningValue_Democratic < 0)"*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.LeaningValue_Democratic < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.LeaningValue_Democratic"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Player_Romus: ""It's not your job to keep them in check. It's mine.""*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.LeaningValue_Democratic < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.LeaningValue_Democratic"] < 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[339]`
Mówca: **Manus Sazon**
> ""The undercurrents to which I refer are like a river. They cannot be stopped, only channeled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project ..."*)
  - -> `[342]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Projec..."*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Narrator: "He allowed himself a smile."*)

### Węzeł `[342]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project == true || RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Project"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_ZpanaHydroelectricDam_Completed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Narrator: "He smiled uncomfortably."*)

### Węzeł `[343]`
Mówca: **Narrator**
> "He allowed himself a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Manus Sazon: ""With the new hydroelectric project you've approved for m..."*)

### Węzeł `[344]`
Mówca: **Manus Sazon**
> ""With the new hydroelectric project you've approved for my province, I believe you know something about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Manus Sazon: ""But as I was saying...""*)

### Węzeł `[345]`
Mówca: **Narrator**
> "He smiled uncomfortably."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Manus Sazon: ""Which reminds me, I heard the royal government is consid..."*)

### Węzeł `[346]`
Mówca: **Manus Sazon**
> ""Which reminds me, I heard the royal government is considering a new hydroelectric project in this province. My relatives would be exceedingly grateful if it were to be implemented.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Manus Sazon: ""But as I was saying...""*)

### Węzeł `[347]`
Mówca: **Manus Sazon**
> ""But as I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[348]`
Mówca: **Manus Sazon**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]` (*Narrator: "He laughed nervously."*)

### Węzeł `[349]`
Mówca: **Narrator**
> "He laughed nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Manus Sazon: ""I'm not convinced that's what the people of Rizia want a..."*)

### Węzeł `[350]`
Mówca: **Manus Sazon**
> ""I'm not convinced that's what the people of Rizia want at this particular moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Manus Sazon: ""As I was saying...""*)

### Węzeł `[351]`
Mówca: **Manus Sazon**
> ""I agree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[352]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people have a voice. That's what the House of Delegates is for.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[198]` (Manus Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Manus Sazon: ""Quite right, Your Majesty. With just a few changes, it c..."*)

### Węzeł `[353]`
Mówca: **Manus Sazon**
> ""A true constitutional monarchy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Manus Sazon: ""I envision a Rizia where the concerns of commoners and n..."*)

### Węzeł `[354]`
Mówca: **Manus Sazon**
> ""As I was saying...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Manus Sazon: ""I would never presume to tell the King how the country s..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_OverthrowMonarchy = true; RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform = true;
RiziaDLC.PersonalValue_Malenyevist += 1;
RiziaDLC.LeaningValue_Democratic += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Manus_OverthrowMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Manus_TalkedAboutReform"] = true;
Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;
Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Manus Sazon: ""I...""*)

### Węzeł `[356]`
Mówca: **Manus Sazon**
> ""You've implemented some of our proposals already. I'm glad you're open to working with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[295]` (*Player_Romus: ""I understand what you're saying. But now is not the righ..."*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC...."*)
  - -> `[359]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDL..."*)

### Węzeł `[358]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Manus Sazon: ""You've implemented some of our proposals already. I'm gl..."*)

### Węzeł `[359]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_FreePress == true || RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == true || RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_FreePress"] == true  or  Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_GovernmentStimulusForPeople"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Manus Sazon: ""It would help if you implemented some of the decrees we'..."*)

### Węzeł `[360]`
Mówca: **Manus Sazon**
> ""It would help if you implemented some of the decrees we've proposed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Player_Romus: ""I agree with the idea of reforming Rizia and empowering ..."*)
  - -> `[240]` (*Player_Romus: ""I am looking forward to working more closely with your p..."*)
  - -> `[295]` (*Player_Romus: ""I understand what you're saying. But now is not the righ..."*)

### Węzeł `[361]`
Mówca: **Narrator**
> "A fanfare sounded from the pit orchestra, and a dark-haired woman stepped on stage. I recognized her as Leona Sazon, Countess of Sallabes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Leona Sazon: ""Ladies and gentlemen!""*)

### Węzeł `[362]`
Mówca: **Leona Sazon**
> ""Ladies and gentlemen!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Leona Sazon: ""It is my great pleasure to welcome His Majesty King Romu..."*)

### Węzeł `[363]`
Mówca: **Leona Sazon**
> ""It is my great pleasure to welcome His Majesty King Romus and Her Highness Princess Vina to our humble city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Leona Sazon: ""We have another special guest here today as well.""*)

### Węzeł `[364]`
Mówca: **Leona Sazon**
> ""We have another special guest here today as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Leona Sazon: ""It has been 25 years since my beloved cousin Angelica wa..."*)

### Węzeł `[365]`
Mówca: **Leona Sazon**
> ""It has been 25 years since my beloved cousin Angelica was sent into exile. Like all Sazons, I hold out hope that someday, the King in his infinite generosity will bring her back to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Player_Romus: ""Hmm. Perhaps the Sazon matriarch has been punished for l..."*)
  - -> `[367]` (*Player_Romus: ""Ha. Nice try, Leona.""*)
  - -> `[368]` (*Player_Romus: ""The only way Angelica is returning to Rizia is in a coff..."*)
  - -> `[370]` (*Player_Romus: ""I'm bored already. When do we eat?""*)

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hmm. Perhaps the Sazon matriarch has been punished for long enough.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Narrator: "Vina nodded. She craned her neck to get a better view of ..."*)

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Ha. Nice try, Leona.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Vina ignored me. She craned her neck to get a better view..."*)

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only way Angelica is returning to Rizia is in a coffin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Vina ignored me. She craned her neck to get a better view..."*)

### Węzeł `[369]`
Mówca: **Narrator**
> "Vina ignored me. She craned her neck to get a better view of the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Leona Sazon: ""Today, we are graced with the presence of her child Manu..."*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm bored already. When do we eat?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[365]` (Leona Sazon)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Narrator: "Vina ignored me. She craned her neck to get a better view..."*)

### Węzeł `[371]`
Mówca: **Narrator**
> "Vina nodded. She craned her neck to get a better view of the stage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Leona Sazon: ""Today, we are graced with the presence of her child Manu..."*)

### Węzeł `[372]`
Mówca: **Leona Sazon**
> ""Today, we are graced with the presence of her child Manus. Heir of House Sazon, leader of the Rizian People's Party and prodigal son of Brenas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "The audience roared as Manus Sazon got onstage."*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Leona Sazon");
AddConversant("Manus Sazon");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Leona Sazon");
AddConversant("Manus Sazon");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Narrator: "This was no longer the nervous young man I'd met in Porte..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Meeting the traitor’s son at the Scarlet Kingbird Festival", "Sallabes", "Province of Brenas");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Meeting the traitor’s son at the Scarlet Kingbird Festival","Sallabes","Province of Brenas");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Alliances", "R_Alliances_Loop");"*)
