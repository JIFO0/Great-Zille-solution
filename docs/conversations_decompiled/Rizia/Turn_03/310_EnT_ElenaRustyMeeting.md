# Rizia/Turn 3/EnT_ElenaRustyMeeting

- **ID konwersacji:** `310`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/310_EnT_ElenaRustyMeeting.md`
- **Liczba węzłów dialogowych:** 384
- **Liczba wyborów gracza:** 80

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[68]** Hugo Toras
- **[80]** Elena Werner
- **[89]** Russello Montoro
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.Economy_PromiseNoMiningRegs`
- `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed`
- `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project`
- `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized`
- `RiziaDLC.Prologue_JoinedMilitary`
- `RiziaDLC.Relations_Manus_ConstitutionalMonarchy`
- `RiziaDLC.Relations_Vina_DancedWithManus`
- `RiziaDLC.Rusty_LoanAmount`
- `RiziaDLC.Rusty_LoanOfferCount`
- `RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers`
- `RiziaDLCIsolated.Turn03_RustyConvo_ITZ`
- `RiziaDLCIsolated.Turn03_RustyConvo_Revenue`
- `RiziaDLCIsolated.Turn03_RustyConvo_Zille`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Economy_PromiseNoMiningRegs`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.PersonalValue_Religious`
- `RiziaDLC.PersonalValue_Tyrant`
- `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers`
- `RiziaDLCIsolated.Turn03_RustyConvo_ITZ`
- `RiziaDLCIsolated.Turn03_RustyConvo_Revenue`
- `RiziaDLCIsolated.Turn03_RustyConvo_Zille`
- `RiziaDLCSupport.Journal_Turn03_Rusty_PromiseNoRegs`
- `RiziaDLCSupport.News_Turn03_G_PalesGas`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **""Hideous. I hate new money.""** | `[9]` **Narrator**: "I looked in the direction she wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Hugo Toras**: ""I'd be surprised if Mr. Montoro..." |
| `[11]` | **""Seems practical. I never understood the appeal of water gardens anyway.""** | `[9]` **Narrator**: "I looked in the direction she wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Elena Werner**: ""They're attractive, to be sure...." |
| `[12]` | **""Why don't we have one of these at Palas Rezna?""** | `[9]` **Narrator**: "I looked in the direction she wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Hugo Toras**: ""Because we have taste."" |
| `[20]` | **""It's a pleasure, Rusty.""** | `[19]` **Russello Montoro**: ""Heck, I was never one for forma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Russello Montoro**: ""There you go! With your father,..." |
| `[21]` | **""Thank you, Mr. Montoro.""** | `[19]` **Russello Montoro**: ""Heck, I was never one for forma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Russello Montoro**: ""Rusty, please. Calling me 'Mr. ..." |
| `[22]` | **""You certainly have made it yours, haven't you?""** | `[19]` **Russello Montoro**: ""Heck, I was never one for forma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Russello Montoro**: ""Oh, the pool? I can't stand swi..." |
| `[36]` | **""A Malenyevist. A dangerous figure.""** | `[73]` **Russello Montoro**: ""Sure, RRG isn't a direct stakeh..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[40]` **Russello Montoro**: ""Right, Your Majesty. Banning pr..."<br>`[45]` **Russello Montoro**: ""That's right, Your Majesty."" |
| `[37]` | **""The first female Prime Minister of Morella. A pioneer.""** | `[73]` **Russello Montoro**: ""Sure, RRG isn't a direct stakeh..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[39]` **Russello Montoro**: ""A pioneering pain in both of ou..." |
| `[38]` | **""She's not a threat.""** | `[73]` **Russello Montoro**: ""Sure, RRG isn't a direct stakeh..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Russello Montoro**: ""She wouldn't be if she stuck to..." |
| `[48]` | **""Have you tried, let's see, improving those conditions?""** | `[47]` **Russello Montoro**: ""Supervisors at my mines have go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Russello Montoro**: ""I mean, we would if they brough..." |
| `[49]` | **""They should be grateful to be employed at all.""** | `[47]` **Russello Montoro**: ""Supervisors at my mines have go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Russello Montoro**: ""They were before. Someone's bee..." |
| `[50]` | **""The first step to unionizing?""** | `[47]` **Russello Montoro**: ""Supervisors at my mines have go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Russello Montoro**: ""Don't know if I'd go that far. ..." |
| `[57]` | **""That's barbaric.""** | `[56]` **Russello Montoro**: ""Accidents have been part of thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Russello Montoro**: ""That's reality. Not all of us h..." |
| `[58]` | **""What do you need all ten of them for, anyway?""** | `[56]` **Russello Montoro**: ""Accidents have been part of thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Russello Montoro**: ""As long as you've got enough to..." |
| `[59]` | **""Did you ever even work in the mines yourself, Rusty?""** | `[56]` **Russello Montoro**: ""Accidents have been part of thi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Narrator**: "Rusty slowly held up his left ha..." |
| `[67]` | **""How much revenue would RRG stand to lose?""** | `[299]` **Russello Montoro**: ""Will they make anyone safer? Do..." | `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false`<br>`(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false` | *Brak zmian stanu* | `[70]` **Russello Montoro**: ""Hard to say. Implementing the r..." |
| `[68]` | **""We still have the Meftiem International Trade Zone, don't we? The rules wouldn't ..."** | `[299]` **Russello Montoro**: ""Will they make anyone safer? Do..." | `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false`<br>`(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false` | *Brak zmian stanu* | `[72]` **Russello Montoro**: ""Well, that's the other thing."" |
| `[69]` | **""The company will rebound when we get Zille back.""** | `[299]` **Russello Montoro**: ""Will they make anyone safer? Do..." | `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false`<br>`(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false` | *Brak zmian stanu* | `[74]` **Russello Montoro**: ""We'll see about that, Your Maje..." |
| `[77]` | **""Aren't most RRG miners labor hands from foreign countries? Would the regulations ..."** | `[299]` **Russello Montoro**: ""Will they make anyone safer? Do..." | `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false`<br>`(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false` | *Brak zmian stanu* | `[85]` **Russello Montoro**: ""They most certainly would, now ..."<br>`[198]` **Russello Montoro**: ""They're fixing to have it that ..." |
| `[81]` | **""Actually, Malenyev is a staunch atheist.""** | `[80]` **Russello Montoro**: ""If she and Hegel get their way,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[89]` **Hugo Toras**: ""Another reason to keep his infl..." |
| `[82]` | **""That still leaves us and Lespia.""** | `[80]` **Russello Montoro**: ""If she and Hegel get their way,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Elena Werner**: ""It's hard to say if we can coun..." |
| `[83]` | **""She should have the right to determine how gold is mined in her own country.""** | `[80]` **Russello Montoro**: ""If she and Hegel get their way,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Hugo Toras**: ""It's Chancellor Hegel's influen..." |
| `[90]` | **""No matter what, our revenue from the region takes a hit.""** | `[80]` **Russello Montoro**: ""If she and Hegel get their way,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Hugo Toras**: ""And the CSP will claim another ..." |
| `[99]` | **""It has indeed been a mutually beneficial partnership. I intend to keep it that way.""** | `[31]` **Russello Montoro**: ""Now. As you know, Rizian Royal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Russello Montoro**: ""Glad we're on the same page."" |
| `[100]` | **""Was it 'cooperation' when you wrested away a third of the kingdom's stake?""** | `[31]` **Russello Montoro**: ""Now. As you know, Rizian Royal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Russello Montoro**: ""That deal was your father's ide..." |
| `[101]` | **""Don't overinflate your company's importance. We have other resources.""** | `[31]` **Russello Montoro**: ""Now. As you know, Rizian Royal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Russello Montoro**: ""But only one is in the name of ..." |
| `[104]` | **""What's the occasion?""** | `[29]` **Narrator**: "She shook Rusty's hand. He becko..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Russello Montoro**: ""Do you need an occasion to catc..." |
| `[105]` | **""I suppose you haven't invited us over here to marvel at your renovations.""** | `[29]` **Narrator**: "She shook Rusty's hand. He becko..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[107]` **Russello Montoro**: ""Neat, aren't they? But no."" |
| `[106]` | **""So how's business?""** | `[29]` **Narrator**: "She shook Rusty's hand. He becko..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Russello Montoro**: ""We'll get to that, Your Majesty..." |
| `[112]` | **""Please tell me what this meeting is about. We don't have all day.""** | `[110]` **Hugo Toras**: ""One dance does not a 'beau' mak..."<br>`[190]` **Hugo Toras**: ""We'll thank you not to speculat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Russello Montoro**: ""Well, all right."" |
| `[113]` | **""That's quite all right, Hugo. My daughter does happen to have her eye on a specia..."** | `[110]` **Hugo Toras**: ""One dance does not a 'beau' mak..."<br>`[190]` **Hugo Toras**: ""We'll thank you not to speculat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Russello Montoro**: ""Lucky man. Anyway, I'll cut to ..." |
| `[114]` | **""Agreed. My daughter is a private person and her love life is strictly off-limits.""** | `[110]` **Hugo Toras**: ""One dance does not a 'beau' mak..."<br>`[190]` **Hugo Toras**: ""We'll thank you not to speculat..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Russello Montoro**: ""Well, all right. I'll cut to th..." |
| `[146]` | **""An increased stake in RRG in exchange for refusing regulations? If I didn't know ..."** | `[154]` **Narrator**: "A valet escorted Elena out. Hugo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Russello Montoro**: ""Your Majesty. How crass do you ..." |
| `[147]` | **""If the company's in as much trouble as you mentioned, it's no wonder you're so ea..."** | `[154]` **Narrator**: "A valet escorted Elena out. Hugo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[150]` **Russello Montoro**: ""You misunderstand me, Your Maje..." |
| `[151]` | **""Let me make one thing clear, *Russello*. You are only running RRG by the grace of..."** | `[154]` **Narrator**: "A valet escorted Elena out. Hugo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[305]` **Narrator**: "He gave me a crooked smile." |
| `[161]` | **""What do you think of all this, Hugo?""** | `[154]` **Narrator**: "A valet escorted Elena out. Hugo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Hugo Toras**: ""I think our friend *Rusty* here..." |
| `[166]` | **""Yes, I think we're just about finished here.""** | `[165]` **Russello Montoro**: ""And here I was about to ask you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[175]` **Russello Montoro**: ""That we are. Enjoy the trip back.""<br>`[179]` **Russello Montoro**: ""Far from it, if you ask me. But..." |
| `[167]` | **""Don't worry. You'll be hearing from me.""** | `[165]` **Russello Montoro**: ""And here I was about to ask you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[180]` **Russello Montoro**: ""Not if you hear from me first, ..." |
| `[168]` | **""Please excuse my uncle's hastiness. Lunch would be lovely.""** | `[165]` **Russello Montoro**: ""And here I was about to ask you..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[173]` **Narrator**: "Rusty smirked in triumph." |
| `[169]` | **""Remind me. How did a man like him take over the most powerful corporation in Rizia?""** | `[9]` **Narrator**: "I looked in the direction she wa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Elena Werner**: ""He's got a knack for being in t..." |
| `[181]` | **""See you, Rusty.""** | `[175]` **Russello Montoro**: ""That we are. Enjoy the trip back.""<br>`[179]` **Russello Montoro**: ""Far from it, if you ask me. But..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "I could see him cheerfully wavin..." |
| `[182]` | **""Goodbye, Mr. Montoro.""** | `[175]` **Russello Montoro**: ""That we are. Enjoy the trip back.""<br>`[179]` **Russello Montoro**: ""Far from it, if you ask me. But..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "I could see him cheerfully wavin..." |
| `[183]` | **""Until next time.""** | `[175]` **Russello Montoro**: ""That we are. Enjoy the trip back.""<br>`[179]` **Russello Montoro**: ""Far from it, if you ask me. But..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Narrator**: "I could see him cheerfully wavin..." |
| `[205]` | **""Good morning, sir.""** | `[221]` **Narrator**: "As I passed the largest guard, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "He stared at me with a look of n..." |
| `[206]` | **""What's your rank? Where did you serve?""** | `[221]` **Narrator**: "As I passed the largest guard, I..." | `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true` | *Brak zmian stanu* | `[213]` **Narrator**: "He stared at me with a look of n..." |
| `[210]` | **""You will bow before your king, you insolent lowlife.""** | `[221]` **Narrator**: "As I passed the largest guard, I..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[212]` **Narrator**: "He didn't move a muscle. There w..." |
| `[211]` | **""Palantor... Are you Arcasian?""** | `[221]` **Narrator**: "As I passed the largest guard, I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[214]` **Narrator**: "He stared at me with a look of n..." |
| `[219]` | **""You say I'm welcome. Your guards send a different message.""** | `[19]` **Russello Montoro**: ""Heck, I was never one for forma..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[220]` **Russello Montoro**: ""I know what it seems like, but ..." |
| `[224]` | **""Let me say this straight away. Your wealth may excuse your lack of manners in som..."** | `[29]` **Narrator**: "She shook Rusty's hand. He becko..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Narrator**: "He looked stricken." |
| `[228]` | **""It was the Crown's to begin with. Queen Lyza never should have privatized it.""** | `[31]` **Russello Montoro**: ""Now. As you know, Rizian Royal ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Russello Montoro**: ""Your grandmother was a savvy da..." |
| `[230]` | **""That's troubling. Workers in this country should have a right to safety.""** | `[47]` **Russello Montoro**: ""Supervisors at my mines have go..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[231]` **Russello Montoro**: ""They already do, Your Majesty. ..." |
| `[239]` | **""I'm sure Ms. Werner can find her own way.""** | `[238]` **Narrator**: "He winked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[241]` **Hugo Toras**: ""She certainly can. I'll stay ri..." |
| `[240]` | **""Go on, Hugo. I'll be fine out here.""** | `[238]` **Narrator**: "He winked at me." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "Hugo looked at us both warily." |
| `[248]` | **""Is there something you've been keeping from me?""** | `[247]` **Narrator**: "I watched them go inside. When I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[250]` **Russello Montoro**: ""I could ask you the same questi..." |
| `[249]` | **""If the people want regulations, I'm not going to get in their way.""** | `[247]` **Narrator**: "I watched them go inside. When I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[259]` **Russello Montoro**: ""But there's something else the ..." |
| `[251]` | **""You're beginning to test my patience, Mr. Montoro.""** | `[247]` **Narrator**: "I watched them go inside. When I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[252]` **Russello Montoro**: ""Wait, Your Majesty. You're goin..." |
| `[254]` | **""How do you know about that?""** | `[253]` **Russello Montoro**: ""I heard you're thinking of brin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Russello Montoro**: ""So I was right."" |
| `[255]` | **""Yes, I'm planning changes. Changes that will keep people like you from hoarding w..."** | `[325]` **Russello Montoro**: ""If I'm wrong, go ahead and tell..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[262]` **Russello Montoro**: ""People like me have bankrolled ..." |
| `[257]` | **""I'm not going to dignify that with a response.""** | `[253]` **Russello Montoro**: ""I heard you're thinking of brin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[266]` **Russello Montoro**: ""You don't have to respond. Just..." |
| `[258]` | **""What exactly did you hear?""** | `[253]` **Russello Montoro**: ""I heard you're thinking of brin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[267]` **Russello Montoro**: ""All I know is, the word 'reform..." |
| `[263]` | **""I am not opposed to working together. But I want it to be on my terms.""** | `[247]` **Narrator**: "I watched them go inside. When I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[264]` **Russello Montoro**: ""This is just the beginning, You..." |
| `[268]` | **""If I did have such plans in store, what business would it be of yours?""** | `[253]` **Russello Montoro**: ""I heard you're thinking of brin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[269]` **Russello Montoro**: ""Aha! So I'm right?"" |
| `[270]` | **""Go to hell, Mr. Montoro.""** | `[325]` **Russello Montoro**: ""If I'm wrong, go ahead and tell..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["Riz...` | `[271]` **Narrator**: "He shrugged." |
| `[273]` | **""The rumors are exaggerated. Any reforms I put in place will be minor at the very ..."** | `[325]` **Russello Montoro**: ""If I'm wrong, go ahead and tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Russello Montoro**: ""Minor or not, you know as well ..." |
| `[281]` | **""He's right to be worried. With Manus Sazon in charge, the party could become a re..."** | `[280]` **Hugo Toras**: ""Since when are you worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[288]` **Russello Montoro**: ""Not if we steer them in the rig..." |
| `[282]` | **""His Grace is right. The RPP doesn't have the power to change anything.""** | `[280]` **Hugo Toras**: ""Since when are you worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[287]` **Russello Montoro**: ""Except the public's mind."" |
| `[283]` | **""The party wants to bring the workers' demands to the highest level of government...."** | `[280]` **Hugo Toras**: ""Since when are you worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[286]` **Russello Montoro**: ""Only in theory."" |
| `[284]` | **""The miners don't need the RPP to help them. I'm the King. I can better their situ..."** | `[280]` **Hugo Toras**: ""Since when are you worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[285]` **Russello Montoro**: ""You can. But should you?"" |
| `[300]` | **""I still don't understand what you're getting at.""** | `[325]` **Russello Montoro**: ""If I'm wrong, go ahead and tell..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[301]` **Russello Montoro**: ""If the rumors are true, Your Ma..." |
| `[320]` | **""I've heard enough. If I'd known you'd invited me here only to wheedle favors out ..."** | `[321]` **Russello Montoro**: ""Give me a hint, Your Majesty. I..."<br>`[337]` **Narrator**: "Hugo shuddered quietly."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[343]` **Russello Montoro**: ""Favors? I'm sorry if I gave you..." |
| `[323]` | **""We're indeed in this together. Keep supplying the kingdom with gold, and I will t..."** | `[321]` **Russello Montoro**: ""Give me a hint, Your Majesty. I..."<br>`[337]` **Narrator**: "Hugo shuddered quietly."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] = true; ...` | `[344]` **Russello Montoro**: ""Much appreciated, Your Majesty."" |
| `[324]` | **""The only side I'm on is that of ordinary, hard-working Rizians. I want what is be..."** | `[321]` **Russello Montoro**: ""Give me a hint, Your Majesty. I..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Narrator**: "He nodded, unperturbed." |
| `[327]` | **""I'd never utter such blasphemous words. But I'm not interested in discussing this..."** | `[325]` **Russello Montoro**: ""If I'm wrong, go ahead and tell..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["...` | `[329]` **Narrator**: "He shrugged." |
| `[339]` | **""I appreciate everything RRG has done for the Crown. But I owe it to the Rizian pe..."** | `[337]` **Narrator**: "Hugo shuddered quietly."<br>`[338]` **Russello Montoro**: ""And so do I. Especially when it..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Narrator**: "He nodded, unperturbed." |
| `[340]` | **""I'm not going to make any promises one way or the other.""** | `[321]` **Russello Montoro**: ""Give me a hint, Your Majesty. I..."<br>`[337]` **Narrator**: "Hugo shuddered quietly."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[341]` **Narrator**: "He nodded, unperturbed." |
| `[359]` | **""Yes, thank you for your offer. You'll get your repayment in due time.""** | `[350]` **Russello Montoro**: ""And I didn't hear you complaini..."<br>`[354]` **Russello Montoro**: ""Plus, y'know, you did accept a ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Russello Montoro**: ""It was nothing. I know you and ..." |
| `[360]` | **""It's a disgrace that my father allowed you to accumulate so much wealth. The King..."** | `[350]` **Russello Montoro**: ""And I didn't hear you complaini..."<br>`[354]` **Russello Montoro**: ""Plus, y'know, you did accept a ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Russello Montoro**: ""Hey, it's not like I didn't wor..." |
| `[361]` | **""Borrowing from RRG does not mean you and I are entering into any kind of *arrange..."** | `[350]` **Russello Montoro**: ""And I didn't hear you complaini..."<br>`[354]` **Russello Montoro**: ""Plus, y'know, you did accept a ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Russello Montoro**: ""You're a valuable shareholder i..." |
| `[365]` | **""It's impolite of you to bring that up here. We shall speak no more of it.""** | `[350]` **Russello Montoro**: ""And I didn't hear you complaini..."<br>`[354]` **Russello Montoro**: ""Plus, y'know, you did accept a ..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[366]` **Russello Montoro**: ""All right. My lips are sealed."" |
| `[370]` | **""You say cooperation, I say usury. Did you try to pull that 'loan' trick with my f..."** | `[31]` **Russello Montoro**: ""Now. As you know, Rizian Royal ..." | `Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0` | *Brak zmian stanu* | `[371]` **Russello Montoro**: ""Trick, Your Majesty? I was only..." |

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
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "SetRichPresence("Meeting the CEO of Royal Rizian Gold by ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "On the banks of the Zpana River in Bronaz stood Palas Verana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Almost as opulent as my own palace, it had once served as..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Almost as opulent as my own palace, it had once served as a summer residence for my ancestors, the Rubaz family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Today it was the home of Russello "Rusty" Montoro. The CE..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Today it was the home of Russello "Rusty" Montoro. The CEO of Rizian Royal Gold, and the wealthiest commoner in the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "I stepped out onto the deck of the Rizania as the yacht a..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "I stepped out onto the deck of the Rizania as the yacht approached the palace's private dock. Hugo and Elena were already there, gazing out at the grounds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Hugo Toras: ""I can't believe what I'm seeing. Palas Verana without it..."*)

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""I can't believe what I'm seeing. Palas Verana without its water garden is no palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Elena Werner: ""I think it's an improvement, myself. But what do you mak..."*)

### Węzeł `[8]`
Mówca: **Elena Werner**
> ""I think it's an improvement, myself. But what do you make of this, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "I looked in the direction she was indicating. The water g..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked in the direction she was indicating. The water garden, once a tranquil oasis filled with blossoming flowers and gently burbling fountains, had been replaced with a gigantic gold-tiled swimming pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player_Romus: ""Hideous. I hate new money.""*)
  - -> `[11]` (*Player_Romus: ""Seems practical. I never understood the appeal of water ..."*)
  - -> `[12]` (*Player_Romus: ""Why don't we have one of these at Palas Rezna?""*)
  - -> `[169]` (*Player_Romus: ""Remind me. How did a man like him take over the most pow..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hideous. I hate new money.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Hugo Toras: ""I'd be surprised if Mr. Montoro even used it.""*)

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seems practical. I never understood the appeal of water gardens anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Elena Werner: ""They're attractive, to be sure. But at the height of sum..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't we have one of these at Palas Rezna?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Hugo Toras: ""Because we have taste.""*)

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Because we have taste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Suddenly, a group of armed men exited the palace in singl..."*)

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""They're attractive, to be sure. But at the height of summer, looking at fountains you can't swim in is just torturous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Suddenly, a group of armed men exited the palace in singl..."*)

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""I'd be surprised if Mr. Montoro even used it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Suddenly, a group of armed men exited the palace in singl..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "The gold magnate's red hair was streaked with grey, but his eyes had a youthful mischief about them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]` (*Narrator: "He gestured towards a number of floral-patterned chairs t..."*)

### Węzeł `[17]`
Mówca: **Russello Montoro**
> ""On behalf of all of us at the esteemed Rizian Royal Gold corporation, I do hereby extend my cordial greetings to your royal delegation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "He trailed off with a grin."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "He trailed off with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Russello Montoro: ""Heck, I was never one for formalities. Welcome to my pal..."*)

### Węzeł `[19]`
Mówca: **Russello Montoro**
> ""Heck, I was never one for formalities. Welcome to my palace, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player_Romus: ""It's a pleasure, Rusty.""*)
  - -> `[21]` (*Player_Romus: ""Thank you, Mr. Montoro.""*)
  - -> `[22]` (*Player_Romus: ""You certainly have made it yours, haven't you?""*)
  - -> `[219]` (*Player_Romus: ""You say I'm welcome. Your guards send a different message.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a pleasure, Rusty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Russello Montoro: ""There you go! With your father, it was always 'Russello'..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Montoro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Russello Montoro: ""Rusty, please. Calling me 'Mr. Montoro' is like trying t..."*)

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You certainly have made it yours, haven't you?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Russello Montoro: ""Oh, the pool? I can't stand swimming myself. Get sunburn..."*)

### Węzeł `[23]`
Mówca: **Russello Montoro**
> ""Oh, the pool? I can't stand swimming myself. Get sunburned at the drop of a hat. The grandkids love it, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He turned to Hugo and Elena."*)

### Węzeł `[24]`
Mówca: **Narrator**
> "He turned to Hugo and Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Russello Montoro: ""Your Grace, Madam Treasurer. Haven't had a sit-down with..."*)

### Węzeł `[25]`
Mówca: **Russello Montoro**
> ""Your Grace, Madam Treasurer. Haven't had a sit-down with you two since the last gentleman wore the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Narrator: "My uncle gritted his teeth."*)

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""You must mean my honorable brother, His Majesty King Valero. May he rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Elena Werner: ""Now, Hugo. Rusty paid his respects at the funeral like e..."*)

### Węzeł `[27]`
Mówca: **Narrator**
> "My uncle gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Hugo Toras: ""You must mean my honorable brother, His Majesty King Val..."*)

### Węzeł `[28]`
Mówca: **Elena Werner**
> ""Now, Hugo. Rusty paid his respects at the funeral like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "She shook Rusty's hand. He beckoned for us to sit as his ..."*)

### Węzeł `[29]`
Mówca: **Narrator**
> "She shook Rusty's hand. He beckoned for us to sit as his valets brought over water and fresh fruit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Player_Romus: ""So how's business?""*)
  - -> `[105]` (*Player_Romus: ""I suppose you haven't invited us over here to marvel at ..."*)
  - -> `[104]` (*Player_Romus: ""What's the occasion?""*)
  - -> `[224]` (*Player_Romus: ""Let me say this straight away. Your wealth may excuse yo..."*)

### Węzeł `[30]`
Mówca: **Russello Montoro**
> ""Rusty, please. Calling me 'Mr. Montoro' is like trying to put an elevator in an outhouse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He turned to Hugo and Elena."*)

### Węzeł `[31]`
Mówca: **Russello Montoro**
> ""Now. As you know, Rizian Royal Gold boasts a long, proud history of cooperation with the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player_Romus: ""It has indeed been a mutually beneficial partnership. I ..."*)
  - -> `[100]` (*Player_Romus: ""Was it 'cooperation' when you wrested away a third of th..."*)
  - -> `[101]` (*Player_Romus: ""Don't overinflate your company's importance. We have oth..."*)
  - -> `[228]` (*Player_Romus: ""It was the Crown's to begin with. Queen Lyza never shoul..."*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanA..."*)

### Węzeł `[32]`
Mówca: **Russello Montoro**
> ""That deal was your father's idea, Your Majesty. All I was asking for was fair compensation for what my company lost. As any CEO would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Russello Montoro: ""My point being. As a trusted business associate, there's..."*)

### Węzeł `[33]`
Mówca: **Russello Montoro**
> ""My point being. As a trusted business associate, there's something I need to bring to your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Russello Montoro: ""Feast your eyes on this.""*)

### Węzeł `[34]`
Mówca: **Russello Montoro**
> ""Feast your eyes on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Narrator: "He picked up a piece of paper from the table next to him...."*)

### Węzeł `[35]`
Mówca: **Narrator**
> "He picked up a piece of paper from the table next to him. It was a flyer with a few sentences written in both Rizian and Wehzek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Russello Montoro: ""Supervisors at my mines have gotten word that the worker..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Malenyevist. A dangerous figure.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 1"*)

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The first female Prime Minister of Morella. A pioneer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's not a threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Russello Montoro: ""She wouldn't be if she stuck to governing Morella. You k..."*)

### Węzeł `[39]`
Mówca: **Russello Montoro**
> ""A pioneering pain in both of our behinds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Russello Montoro: ""Woman's never picked up a chisel in her life, and she su..."*)

### Węzeł `[40]`
Mówca: **Russello Montoro**
> ""Right, Your Majesty. Banning propaganda in Rizia won't stop what's happening on her side of the border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Russello Montoro: ""Woman's never picked up a chisel in her life, and she su..."*)

### Węzeł `[41]`
Mówca: **Russello Montoro**
> ""Woman's never picked up a chisel in her life, and she suddenly knows how to run the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Russello Montoro: ""She's started calling for regulation over there as well...."*)

### Węzeł `[42]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == t..."*)

### Węzeł `[43]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Russello Montoro: ""Right, Your Majesty. Banning propaganda in Rizia won't s..."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Russello Montoro: ""That's right, Your Majesty.""*)

### Węzeł `[45]`
Mówca: **Russello Montoro**
> ""That's right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Russello Montoro: ""Woman's never picked up a chisel in her life, and she su..."*)

### Węzeł `[46]`
Mówca: **Russello Montoro**
> ""She wouldn't be if she stuck to governing Morella. You know, like she was elected to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Russello Montoro: ""Woman's never picked up a chisel in her life, and she su..."*)

### Węzeł `[47]`
Mówca: **Russello Montoro**
> ""Supervisors at my mines have gotten word that the workers are holding after-hours meetings. On the subject of 'unsafe conditions'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""The first step to unionizing?""*)
  - -> `[49]` (*Player_Romus: ""They should be grateful to be employed at all.""*)
  - -> `[48]` (*Player_Romus: ""Have you tried, let's see, improving those conditions?""*)
  - -> `[230]` (*Player_Romus: ""That's troubling. Workers in this country should have a ..."*)

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you tried, let's see, improving those conditions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Russello Montoro: ""I mean, we would if they brought up the subject with us ..."*)

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They should be grateful to be employed at all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Russello Montoro: ""They were before. Someone's been putting ideas in their ..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The first step to unionizing?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Russello Montoro: ""Don't know if I'd go that far. But the more employees pu..."*)

### Węzeł `[51]`
Mówca: **Russello Montoro**
> ""Don't know if I'd go that far. But the more employees put their heads together, the more dangerous their ideas get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Elena struggled to keep a pleasant expression on her face."*)

### Węzeł `[52]`
Mówca: **Russello Montoro**
> ""They were before. Someone's been putting ideas in their heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Elena Werner: ""Have there been any accidents lately? Anything that migh..."*)

### Węzeł `[53]`
Mówca: **Russello Montoro**
> ""I mean, we would if they brought up the subject with us directly. But seems they'd rather conspire amongst themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Narrator: "Elena struggled to keep a pleasant expression on her face."*)

### Węzeł `[54]`
Mówca: **Elena Werner**
> ""Have there been any accidents lately? Anything that might have triggered this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "Rusty snorted."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "Rusty snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Russello Montoro: ""Accidents have been part of this job since the dawn of t..."*)

### Węzeł `[56]`
Mówca: **Russello Montoro**
> ""Accidents have been part of this job since the dawn of time. Used to say you weren't a real miner until you were missing a finger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player_Romus: ""That's barbaric.""*)
  - -> `[58]` (*Player_Romus: ""What do you need all ten of them for, anyway?""*)
  - -> `[59]` (*Player_Romus: ""Did you ever even work in the mines yourself, Rusty?""*)

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's barbaric.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Russello Montoro: ""That's reality. Not all of us have estates to live off, ..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you need all ten of them for, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Russello Montoro: ""As long as you've got enough to swing a pickaxe.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you ever even work in the mines yourself, Rusty?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "Rusty slowly held up his left hand. His little finger had..."*)

### Węzeł `[60]`
Mówca: **Russello Montoro**
> ""As long as you've got enough to swing a pickaxe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Hugo cleared his throat."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "Rusty slowly held up his left hand. His little finger had been lopped off at the second joint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Russello Montoro: ""First week on the job in Argno. Thought I'd save time by..."*)

### Węzeł `[62]`
Mówca: **Russello Montoro**
> ""That's reality. Not all of us have estates to live off, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Hugo cleared his throat."*)

### Węzeł `[63]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Hugo Toras: ""Do you have a request of His Majesty, Mr. Montoro? Or ha..."*)

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Do you have a request of His Majesty, Mr. Montoro? Or have you merely invited us here to complain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Russello Montoro: ""Not complain. Warn.""*)

### Węzeł `[65]`
Mówca: **Russello Montoro**
> ""Not complain. Warn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Russello Montoro: ""This is about more than just a few disgruntled miners. R..."*)

### Węzeł `[66]`
Mówca: **Russello Montoro**
> ""If I'm right, they're about to propose a big new batch of workplace regulations. Not just for RRG, but for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Russello Montoro: ""Will they make anyone safer? Doubtful. Will they be a de..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much revenue would RRG stand to lose?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false` AND `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[299]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Russello Montoro: ""Hard to say. Implementing the regulations themselves wou..."*)

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have the Meftiem International Trade Zone, don't we? The rules wouldn't apply there.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false` AND `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[299]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Russello Montoro: ""Well, that's the other thing.""*)

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The company will rebound when we get Zille back.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false` AND `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[299]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Russello Montoro: ""We'll see about that, Your Majesty.""*)

### Węzeł `[70]`
Mówca: **Russello Montoro**
> ""Hard to say. Implementing the regulations themselves would cost a pretty penny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Russello Montoro: ""And what do you think will happen if we pass those costs..."*)

### Węzeł `[71]`
Mówca: **Russello Montoro**
> ""And what do you think will happen if we pass those costs on to our trading partners? They'll hit the road faster than my first ex-wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Narrator: "Elena raised her eyebrows."*)

### Węzeł `[72]`
Mówca: **Russello Montoro**
> ""Well, that's the other thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Russello Montoro: ""Sure, RRG isn't a direct stakeholder in the Trade Zone. ..."*)

### Węzeł `[73]`
Mówca: **Russello Montoro**
> ""Sure, RRG isn't a direct stakeholder in the Trade Zone. But we're involved enough to be highly worried about Alma Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Player_Romus: ""A Malenyevist. A dangerous figure.""*)
  - -> `[37]` (*Player_Romus: ""The first female Prime Minister of Morella. A pioneer.""*)
  - -> `[38]` (*Player_Romus: ""She's not a threat.""*)

### Węzeł `[74]`
Mówca: **Russello Montoro**
> ""We'll see about that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Russello Montoro: ""25 years ago, that little nub of land was home to some o..."*)

### Węzeł `[75]`
Mówca: **Narrator**
> "Elena raised her eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Elena Werner: ""We have been seeing more global competition on the gold ..."*)

### Węzeł `[76]`
Mówca: **Elena Werner**
> ""We have been seeing more global competition on the gold market, unfortunately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Elena Werner: ""But for now, our product is of high enough quality that ..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aren't most RRG miners labor hands from foreign countries? Would the regulations even apply to them?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false` AND `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[299]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true"*)

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Morella doesn't have unilateral power over the International Trade Zone. Rizia, Lespia and Valgsland all have a say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Russello Montoro: ""And guess which one of those Ms. Saltana has been cozyin..."*)

### Węzeł `[79]`
Mówca: **Russello Montoro**
> ""And guess which one of those Ms. Saltana has been cozying up to on this subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Russello Montoro: ""If she and Hegel get their way, Rizia will either lose i..."*)

### Węzeł `[80]`
Mówca: **Russello Montoro**
> ""If she and Hegel get their way, Rizia will either lose its mining rights or our boys will have to pray to Malenyev before going to work every morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Player_Romus: ""No matter what, our revenue from the region takes a hit.""*)
  - -> `[83]` (*Player_Romus: ""She should have the right to determine how gold is mined..."*)
  - -> `[82]` (*Player_Romus: ""That still leaves us and Lespia.""*)
  - -> `[81]` (*Player_Romus: ""Actually, Malenyev is a staunch atheist.""*)

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Malenyev is a staunch atheist.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Hugo Toras: ""Another reason to keep his influence far from our borders.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That still leaves us and Lespia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Elena Werner: ""It's hard to say if we can count on Lespia's cooperation..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She should have the right to determine how gold is mined in her own country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Hugo Toras: ""It's Chancellor Hegel's influence that is concerning. Ma..."*)

### Węzeł `[84]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Gold Regs Hub`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false"*)
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Zille == false"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false"*)

### Węzeł `[85]`
Mówca: **Russello Montoro**
> ""They most certainly would, now that labor hands have the same protections as honest-to-goodness Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Russello Montoro: ""Honestly, Your Majesty, I just about ate my boot when yo..."*)

### Węzeł `[86]`
Mówca: **Russello Montoro**
> ""25 years ago, that little nub of land was home to some of the fattest gold veins my company's ever found. But Nur knows what shape it's in now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true &..."*)

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""It's Chancellor Hegel's influence that is concerning. Malenyevism has a way of spilling over borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Elena Werner: ""The political aspect isn't as concerning to me as the lo..."*)

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""It's hard to say if we can count on Lespia's cooperation. Of course they abhor Valgsland, but we don't have the friendliest history with them either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Elena Werner: ""We'll have to keep a close eye on this.""*)

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Another reason to keep his influence far from our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Elena Werner: ""The political aspect isn't as concerning to me as the lo..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what, our revenue from the region takes a hit.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Hugo Toras: ""And the CSP will claim another victory.""*)

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""And the CSP will claim another victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Elena Werner: ""The political aspect isn't as concerning to me as the lo..."*)

### Węzeł `[92]`
Mówca: **Elena Werner**
> ""The political aspect isn't as concerning to me as the loss of access to our most important mines. We have to keep a close eye on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_ITZ = true"*)

### Węzeł `[93]`
Mówca: **Russello Montoro**
> ""She's started calling for regulation over there as well. Or worse, nationalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Elena Werner: ""Morella doesn't have unilateral power over the Internati..."*)

### Węzeł `[94]`
Mówca: **Elena Werner**
> ""We'll have to keep a close eye on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_ITZ = true"*)

### Węzeł `[95]`
Mówca: **Russello Montoro**
> ""Honestly, Your Majesty, I just about ate my boot when you made that decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Russello Montoro: ""My fellow businessmen and I lost enough money granting a..."*)

### Węzeł `[96]`
Mówca: **Russello Montoro**
> ""My fellow businessmen and I lost enough money granting all kinds of benefits to folks who don't even understand how lucky they are to work here. Giving them more would damn near bankrupt us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Elena Werner: ""A little extreme, don't you think?""*)

### Węzeł `[97]`
Mówca: **Elena Werner**
> ""A little extreme, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Elena Werner: ""I agree we shouldn't impose more regulations than necess..."*)

### Węzeł `[98]`
Mówca: **Elena Werner**
> ""I agree we shouldn't impose more regulations than necessary, but investing in safer and healthier employees could lead to profit in the long term. Foreigners included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers = true"*)

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It has indeed been a mutually beneficial partnership. I intend to keep it that way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Russello Montoro: ""Glad we're on the same page.""*)

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was it 'cooperation' when you wrested away a third of the kingdom's stake?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Russello Montoro: ""That deal was your father's idea, Your Majesty. All I wa..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't overinflate your company's importance. We have other resources.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Russello Montoro: ""But only one is in the name of the national anthem.""*)

### Węzeł `[102]`
Mówca: **Russello Montoro**
> ""Glad we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Russello Montoro: ""My point being. As a trusted business associate, there's..."*)

### Węzeł `[103]`
Mówca: **Russello Montoro**
> ""But only one is in the name of the national anthem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Russello Montoro: ""My point being. As a trusted business associate, there's..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the occasion?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Russello Montoro: ""Do you need an occasion to catch up with an old friend?""*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose you haven't invited us over here to marvel at your renovations.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Russello Montoro: ""Neat, aren't they? But no.""*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So how's business?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Russello Montoro: ""We'll get to that, Your Majesty. Settle down, have a dri..."*)

### Węzeł `[107]`
Mówca: **Russello Montoro**
> ""Neat, aren't they? But no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Russello Montoro: ""I couldn't help noticing you've been crisscrossing the k..."*)

### Węzeł `[108]`
Mówca: **Russello Montoro**
> ""I couldn't help noticing you've been crisscrossing the kingdom lately. And no royal tour would be complete without a visit to my modest little hideaway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[109]`
Mówca: **Russello Montoro**
> ""A shame Her Highness couldn't make it. Too occupied with her latest beau?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Hugo Toras: ""One dance does not a 'beau' make. We'd appreciate it if ..."*)

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""One dance does not a 'beau' make. We'd appreciate it if you didn't speculate about Princess Vina's romantic prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""That's quite all right, Hugo. My daughter does happen to..."*)
  - -> `[114]` (*Player_Romus: ""Agreed. My daughter is a private person and her love lif..."*)
  - -> `[112]` (*Player_Romus: ""Please tell me what this meeting is about. We don't have..."*)

### Węzeł `[111]`
Mówca: **Russello Montoro**
> ""We'll get to that, Your Majesty. Settle down, have a drink first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me what this meeting is about. We don't have all day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras), `[190]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Russello Montoro: ""Well, all right.""*)

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite all right, Hugo. My daughter does happen to have her eye on a special someone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras), `[190]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Russello Montoro: ""Lucky man. Anyway, I'll cut to the chase.""*)

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. My daughter is a private person and her love life is strictly off-limits.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[110]` (Hugo Toras), `[190]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Russello Montoro: ""Well, all right. I'll cut to the chase, then.""*)

### Węzeł `[115]`
Mówca: **Russello Montoro**
> ""Lucky man. Anyway, I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He sat back and unbuttoned the top button of his shirt."*)

### Węzeł `[116]`
Mówca: **Russello Montoro**
> ""Well, all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He sat back and unbuttoned the top button of his shirt."*)

### Węzeł `[117]`
Mówca: **Narrator**
> "He sat back and unbuttoned the top button of his shirt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Russello Montoro: ""Now. As you know, Rizian Royal Gold boasts a long, proud..."*)

### Węzeł `[118]`
Mówca: **Elena Werner**
> ""But for now, our product is of high enough quality that Rumburg is willing to pay more for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Hugo Toras: ""Yes, but if the price rises further still? I'd rather no..."*)

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Yes, but if the price rises further still? I'd rather not admit it, but Mr. Montoro may have a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]` (*Russello Montoro: ""Don't get me wrong, Your Majesty -- my personal finances..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false"*)
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false)"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player_Romus: ""How much revenue would RRG stand to lose?""*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false"*)
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false)"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Player_Romus: ""We still have the Meftiem International Trade Zone, don'..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Zille == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Zille == false"*)
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_RustyConvo_Zille == false)"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Zille == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Player_Romus: ""The company will rebound when we get Zille back.""*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_RustyConvo_Zille == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false"*)
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false)"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Player_Romus: ""Aren't most RRG miners labor hands from foreign countrie..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "Rusty took a big bite out of a watermelon slice. He wiped..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Węzeł Logiki Narracyjnej: "Gold Regs Hub"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Revenue = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_ITZ = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_Zille = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]"*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)

### Węzeł `[143]`
Mówca: **Russello Montoro**
> ""Look, I won't press the issue any further. Just hope you'll do the right thing if this ever lands in your lap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Russello Montoro: ""Who knows? If all goes well, I might be persuaded to sel..."*)

### Węzeł `[144]`
Mówca: **Narrator**
> "Rusty took a big bite out of a watermelon slice. He wiped the juice off his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Russello Montoro: ""Look, I won't press the issue any further. Just hope you..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Elena pushed her chair back and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Elena Werner: ""I'm going to recuse myself from this part of the convers..."*)

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An increased stake in RRG in exchange for refusing regulations? If I didn't know better, I'd think you were trying to bribe the government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Russello Montoro: ""Your Majesty. How crass do you think I am?""*)

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the company's in as much trouble as you mentioned, it's no wonder you're so eager to sell us our stake back.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Russello Montoro: ""You misunderstand me, Your Majesty. We're not in trouble..."*)

### Węzeł `[148]`
Mówca: **Russello Montoro**
> ""Who knows? If all goes well, I might be persuaded to sell you back the share the honorable King Valero sold me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Elena pushed her chair back and stood up."*)

### Węzeł `[149]`
Mówca: **Russello Montoro**
> ""Your Majesty. How crass do you think I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)

### Węzeł `[150]`
Mówca: **Russello Montoro**
> ""You misunderstand me, Your Majesty. We're not in trouble. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me make one thing clear, *Russello*. You are only running RRG by the grace of Rizia's royal family. Everything you have, we can take away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]` (*Narrator: "He gave me a crooked smile."*)

### Węzeł `[152]`
Mówca: **Elena Werner**
> ""I'm going to recuse myself from this part of the conversation. Where's the ladies' room?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Russello Montoro: ""Just inside. If you've never sat on a solid gold toilet,..."*)

### Węzeł `[153]`
Mówca: **Russello Montoro**
> ""Just inside. If you've never sat on a solid gold toilet, you're in for a treat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true"*)

### Węzeł `[154]`
Mówca: **Narrator**
> "A valet escorted Elena out. Hugo, Rusty and I glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player_Romus: ""An increased stake in RRG in exchange for refusing regul..."*)
  - -> `[147]` (*Player_Romus: ""If the company's in as much trouble as you mentioned, it..."*)
  - -> `[151]` (*Player_Romus: ""Let me make one thing clear, *Russello*. You are only ru..."*)
  - -> `[161]` (*Player_Romus: ""What do you think of all this, Hugo?""*)

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""I think our friend *Rusty* here is perilously close to oversteppng his bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Narrator: "He let out a sigh."*)

### Węzeł `[156]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Hugo Toras: ""But cooperation with RRG served King Valero well in the ..."*)

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""But cooperation with RRG served King Valero well in the past. Even after selling part of the royal stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Hugo Toras: ""I take it as a positive sign that Mr. Montoro is open to..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Elena stepped back onto the terrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Elena Werner: ""That was... colder than I expected. I hope I haven't mis..."*)

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""That was... colder than I expected. I hope I haven't missed much?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Narrator: "Hugo practically sprang from his seat."*)

### Węzeł `[160]`
Mówca: **Narrator**
> "Hugo practically sprang from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Hugo Toras: ""It's been a delight, but we must be headed back to Porte..."*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think of all this, Hugo?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Hugo Toras: ""I think our friend *Rusty* here is perilously close to o..."*)

### Węzeł `[162]`
Mówca: **Russello Montoro**
> ""You're a smart man, Your Grace. You and I should go out for beers someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Narrator: "Hugo looked like he'd swallowed something unpleasant."*)

### Węzeł `[163]`
Mówca: **Narrator**
> "Hugo looked like he'd swallowed something unpleasant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Hugo Toras: ""Yes. 'Beers'. I would... enjoy that.""*)

### Węzeł `[164]`
Mówca: **Hugo Toras**
> ""It's been a delight, but we must be headed back to Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Russello Montoro: ""And here I was about to ask you to stay for lunch. So so..."*)

### Węzeł `[165]`
Mówca: **Russello Montoro**
> ""And here I was about to ask you to stay for lunch. So soon, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus: ""Yes, I think we're just about finished here.""*)
  - -> `[167]` (*Player_Romus: ""Don't worry. You'll be hearing from me.""*)
  - -> `[168]` (*Player_Romus: ""Please excuse my uncle's hastiness. Lunch would be lovely.""*)

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I think we're just about finished here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. You'll be hearing from me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Russello Montoro: ""Not if you hear from me first, eh?""*)

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please excuse my uncle's hastiness. Lunch would be lovely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Narrator: "Rusty smirked in triumph."*)

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me. How did a man like him take over the most powerful corporation in Rizia?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Elena Werner: ""He's got a knack for being in the right place at the rig..."*)

### Węzeł `[170]`
Mówca: **Elena Werner**
> ""He's got a knack for being in the right place at the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Hugo Toras: ""Legend has it he worked his way up from regional mine su..."*)

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Legend has it he worked his way up from regional mine supervisor in a series of backroom deals and boardroom betrayals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Narrator: "Suddenly, a group of armed men exited the palace in singl..."*)

### Węzeł `[172]`
Mówca: **Russello Montoro**
> ""This is about more than just a few disgruntled miners. Rumor has it the RPP's picking up the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Hugo Toras: ""Since when are you worried about the Rizian People's Par..."*)

### Węzeł `[173]`
Mówca: **Narrator**
> "Rusty smirked in triumph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Russello Montoro: ""Sorry, Your Grace. Got to pretend to be civil to me a wh..."*)

### Węzeł `[174]`
Mówca: **Russello Montoro**
> ""Sorry, Your Grace. Got to pretend to be civil to me a while longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Narrator: "Hugo and Elena sat back down as the valets began bringing..."*)

### Węzeł `[175]`
Mówca: **Russello Montoro**
> ""That we are. Enjoy the trip back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""See you, Rusty.""*)
  - -> `[182]` (*Player_Romus: ""Goodbye, Mr. Montoro.""*)
  - -> `[183]` (*Player_Romus: ""Until next time.""*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs == true"*)
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Economy_PromiseNoMiningRegs == true)"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Russello Montoro: ""That we are. Enjoy the trip back.""*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Economy_PromiseNoMiningRegs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Russello Montoro: ""Far from it, if you ask me. But enjoy the trip back.""*)

### Węzeł `[179]`
Mówca: **Russello Montoro**
> ""Far from it, if you ask me. But enjoy the trip back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""See you, Rusty.""*)
  - -> `[182]` (*Player_Romus: ""Goodbye, Mr. Montoro.""*)
  - -> `[183]` (*Player_Romus: ""Until next time.""*)

### Węzeł `[180]`
Mówca: **Russello Montoro**
> ""Not if you hear from me first, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Player_Romus: ""See you, Rusty.""*)
  - -> `[182]` (*Player_Romus: ""Goodbye, Mr. Montoro.""*)

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you, Rusty.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Russello Montoro), `[179]` (Russello Montoro), `[180]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "I could see him cheerfully waving from the veranda as Hug..."*)

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Montoro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Russello Montoro), `[179]` (Russello Montoro), `[180]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "I could see him cheerfully waving from the veranda as Hug..."*)

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[175]` (Russello Montoro), `[179]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Narrator: "I could see him cheerfully waving from the veranda as Hug..."*)

### Węzeł `[184]`
Mówca: **Narrator**
> "I could see him cheerfully waving from the veranda as Hugo, Elena and I stepped back on board the yacht."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[185]`
Mówca: **Narrator**
> "Hugo and Elena sat back down as the valets began bringing out our midday meal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[186]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_DancedWithManus == true)"*)

### Węzeł `[187]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_DancedWithManus == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Russello Montoro: ""A shame Her Highness couldn't make it. Too occupied with..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_DancedWithManus == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Russello Montoro: ""A shame Her Highness couldn't make it. Has she finally f..."*)

### Węzeł `[189]`
Mówca: **Russello Montoro**
> ""A shame Her Highness couldn't make it. Has she finally found a beau back home in the capital?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Hugo Toras: ""We'll thank you not to speculate about Princess Vina's r..."*)

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""We'll thank you not to speculate about Princess Vina's romantic prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Player_Romus: ""That's quite all right, Hugo. My daughter does happen to..."*)
  - -> `[114]` (*Player_Romus: ""Agreed. My daughter is a private person and her love lif..."*)
  - -> `[112]` (*Player_Romus: ""Please tell me what this meeting is about. We don't have..."*)

### Węzeł `[191]`
Mówca: **Russello Montoro**
> ""Well, all right. I'll cut to the chase, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Narrator: "He sat back and unbuttoned the top button of his shirt."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true"*)
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Russello Montoro: ""They most certainly would, now that labor hands have the..."*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Russello Montoro: ""They're fixing to have it that way, yes.""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)

### Węzeł `[197]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Russello Montoro: ""A pioneering pain in both of our behinds.""*)

### Węzeł `[198]`
Mówca: **Russello Montoro**
> ""They're fixing to have it that way, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Russello Montoro: ""The folks pushing for these restrictions -- I mean regul..."*)

### Węzeł `[199]`
Mówca: **Russello Montoro**
> ""The folks pushing for these restrictions -- I mean regulations -- are a mix of labor hands and honest-to-goodness Rizians. With some support from the Sazons to boot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Russello Montoro: ""I see what they're going for. I really do. But giving th..."*)

### Węzeł `[200]`
Mówca: **Russello Montoro**
> ""I see what they're going for. I really do. But giving them everything they want would set a dangerous example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Elena Werner: ""A little extreme, don't you think?""*)

### Węzeł `[201]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn03_G_PalesGas = true"*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn03_G_PalesGas = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_G_PalesGas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "On the banks of the Zpana River in Bronaz stood Palas Ver..."*)

### Węzeł `[203]`
Mówca: **Narrator**
> "Suddenly, a group of armed men exited the palace in single file. They positioned themself at equal intervals around the dock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "They followed us with their eyes as we disembarked and wa..."*)

### Węzeł `[204]`
Mówca: **Narrator**
> "They followed us with their eyes as we disembarked and walked towards the palace veranda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Narrator: "As I passed the largest guard, I noticed he was wearing a..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, sir.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He stared at me with a look of non-comprehension. There w..."*)

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's your rank? Where did you serve?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Kontekst wejściowy (poprzednik):** `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Narrator: "He stared at me with a look of non-comprehension. There w..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_JoinedMilitary == true)"*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_JoinedMilitary == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Player_Romus: ""What's your rank? Where did you serve?""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_JoinedMilitary == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will bow before your king, you insolent lowlife.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Palantor... Are you Arcasian?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[221]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Narrator: "He stared at me with a look of non-comprehension. There w..."*)

### Węzeł `[212]`
Mówca: **Narrator**
> "He didn't move a muscle. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Rusty rose from where he'd been sitting and rushed over t..."*)

### Węzeł `[213]`
Mówca: **Narrator**
> "He stared at me with a look of non-comprehension. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Rusty rose from where he'd been sitting and rushed over t..."*)

### Węzeł `[214]`
Mówca: **Narrator**
> "He stared at me with a look of non-comprehension. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "Rusty rose from where he'd been sitting and rushed over t..."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Narrator: "He didn't move a muscle. There was a rustle behind me as ..."*)

### Węzeł `[216]`
Mówca: **Narrator**
> "Rusty rose from where he'd been sitting and rushed over to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Russello Montoro: ""Antoine! That's no way to treat our royal visitors.""*)

### Węzeł `[217]`
Mówca: **Russello Montoro**
> ""Antoine! That's no way to treat our royal visitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Narrator: "The guard reluctantly bowed and stepped aside. Rusty ushe..."*)

### Węzeł `[218]`
Mówca: **Narrator**
> "The guard reluctantly bowed and stepped aside. Rusty ushered us past him, shaking his head as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Russello Montoro: ""I am so, so, sorry. You can take the guards out of Arcas..."*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You say I'm welcome. Your guards send a different message.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Russello Montoro: ""I know what it seems like, but they're looking out for y..."*)

### Węzeł `[220]`
Mówca: **Russello Montoro**
> ""I know what it seems like, but they're looking out for your safety as well as mine. Can't be too careful after what happened in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He turned to Hugo and Elena."*)

### Węzeł `[221]`
Mówca: **Narrator**
> "As I passed the largest guard, I noticed he was wearing a badge that read 'Palantor Security Solutions.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Player_Romus: ""Good morning, sir.""*)
  - -> `[211]` (*Player_Romus: ""Palantor... Are you Arcasian?""*)
  - -> `[210]` (*Player_Romus: ""You will bow before your king, you insolent lowlife.""*)
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_JoinedMilitary == true"*)

### Węzeł `[222]`
Mówca: **Hugo Toras**
> ""Yes. 'Beers'. I would... enjoy that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Russello Montoro: ""Give me a hint, Your Majesty. Is the Crown on our side?""*)

### Węzeł `[223]`
Mówca: **Russello Montoro**
> ""There you go! With your father, it was always 'Russello' this and 'Mr. Montoro' that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Narrator: "He turned to Hugo and Elena."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me say this straight away. Your wealth may excuse your lack of manners in some circles, but not with me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[29]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Narrator: "He looked stricken."*)

### Węzeł `[225]`
Mówca: **Narrator**
> "He looked stricken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]` (*Russello Montoro: ""I do beg your pardon. I never did have time for fancy et..."*)

### Węzeł `[226]`
Mówca: **Russello Montoro**
> ""I do beg your pardon. I never did have time for fancy etiquette classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)

### Węzeł `[227]`
Mówca: **Narrator**
> "Elena struggled to keep a pleasant expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Elena Werner: ""Have there been any accidents lately? Anything that migh..."*)

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the Crown's to begin with. Queen Lyza never should have privatized it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Russello Montoro: ""Your grandmother was a savvy dame. She saw an innovator ..."*)

### Węzeł `[229]`
Mówca: **Russello Montoro**
> ""Your grandmother was a savvy dame. She saw an innovator and reached out her hand, 'stead of her fist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Russello Montoro: ""My point being. As a trusted business associate, there's..."*)

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's troubling. Workers in this country should have a right to safety.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Russello Montoro: ""They already do, Your Majesty. Someone's been stirring u..."*)

### Węzeł `[231]`
Mówca: **Russello Montoro**
> ""They already do, Your Majesty. Someone's been stirring up trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Elena Werner: ""Have there been any accidents lately? Anything that migh..."*)

### Węzeł `[232]`
Mówca: **Russello Montoro**
> ""First week on the job in Argno. Thought I'd save time by fixing a blockage in one of the ore processors. Reached right in, and wouldn't you know? It started working again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Russello Montoro: ""But did I blame RRG for my own boneheaded stupidity? You..."*)

### Węzeł `[233]`
Mówca: **Russello Montoro**
> ""But did I blame RRG for my own boneheaded stupidity? Your Majesty, I did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "Hugo cleared his throat."*)

### Węzeł `[234]`
Mówca: **Russello Montoro**
> ""Duke Hugo, why don't you show her the way? Maybe have a gander at my latest art acquisitions while you're at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Narrator: "He winked at me."*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true"*)
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)"*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Russello Montoro: ""Duke Hugo, why don't you show her the way? Maybe have a ..."*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Elena Werner");"*)

### Węzeł `[238]`
Mówca: **Narrator**
> "He winked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Player_Romus: ""Go on, Hugo. I'll be fine out here.""*)
  - -> `[239]` (*Player_Romus: ""I'm sure Ms. Werner can find her own way.""*)

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure Ms. Werner can find her own way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Hugo Toras: ""She certainly can. I'll stay right here.""*)

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on, Hugo. I'll be fine out here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[238]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "Hugo looked at us both warily."*)

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""She certainly can. I'll stay right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Elena Werner");"*)

### Węzeł `[242]`
Mówca: **Narrator**
> "Hugo looked at us both warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Hugo Toras: ""Very well. Ms. Werner?""*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Elena Werner");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Elena Werner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Narrator: "A valet escorted Elena out. Hugo, Rusty and I glanced at ..."*)

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""Very well. Ms. Werner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]` (*Narrator: "Elena gave him a nod. The two of them headed towards the ..."*)

### Węzeł `[245]`
Mówca: **Narrator**
> "Elena gave him a nod. The two of them headed towards the palace doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Elena Werner"); RemoveConversant("Hugo ..."*)

### Węzeł `[246]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Elena Werner");
RemoveConversant("Hugo Toras");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Elena Werner");
RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Narrator: "I watched them go inside. When I turned my attention back..."*)

### Węzeł `[247]`
Mówca: **Narrator**
> "I watched them go inside. When I turned my attention back to Rusty, I saw him studying me intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Player_Romus: ""Is there something you've been keeping from me?""*)
  - -> `[251]` (*Player_Romus: ""You're beginning to test my patience, Mr. Montoro.""*)
  - -> `[249]` (*Player_Romus: ""If the people want regulations, I'm not going to get in ..."*)
  - -> `[263]` (*Player_Romus: ""I am not opposed to working together. But I want it to b..."*)

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you've been keeping from me?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Russello Montoro: ""I could ask you the same question.""*)

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the people want regulations, I'm not going to get in their way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Russello Montoro: ""But there's something else the people want more. Isn't t..."*)

### Węzeł `[250]`
Mówca: **Russello Montoro**
> ""I could ask you the same question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "He looked around to make sure all of our guards were out ..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're beginning to test my patience, Mr. Montoro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Russello Montoro: ""Wait, Your Majesty. You're going to want to hear this ne..."*)

### Węzeł `[252]`
Mówca: **Russello Montoro**
> ""Wait, Your Majesty. You're going to want to hear this next part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "He looked around to make sure all of our guards were out ..."*)

### Węzeł `[253]`
Mówca: **Russello Montoro**
> ""I heard you're thinking of bringing some pretty big changes to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Player_Romus: ""How do you know about that?""*)
  - -> `[258]` (*Player_Romus: ""What exactly did you hear?""*)
  - -> `[257]` (*Player_Romus: ""I'm not going to dignify that with a response.""*)
  - -> `[268]` (*Player_Romus: ""If I did have such plans in store, what business would i..."*)

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know about that?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Russello Montoro: ""So I was right.""*)

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm planning changes. Changes that will keep people like you from hoarding wealth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist += 1"*)

### Węzeł `[256]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Russello Montoro: ""People like me have bankrolled every major power shift s..."*)

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to dignify that with a response.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Russello Montoro: ""You don't have to respond. Just hear me out for a second.""*)

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly did you hear?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Russello Montoro: ""All I know is, the word 'reform' has come up in connecti..."*)

### Węzeł `[259]`
Mówca: **Russello Montoro**
> ""But there's something else the people want more. Isn't there, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "He looked around to make sure all of our guards were out ..."*)

### Węzeł `[260]`
Mówca: **Narrator**
> "He looked around to make sure all of our guards were out of earshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Russello Montoro: ""I heard you're thinking of bringing some pretty big chan..."*)

### Węzeł `[261]`
Mówca: **Russello Montoro**
> ""So I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Russello Montoro: ""All I know is, the word 'reform' has come up in connecti..."*)

### Węzeł `[262]`
Mówca: **Russello Montoro**
> ""People like me have bankrolled every major power shift since 1823. Arcasia, Qinal, Lespia... you name it, there's a fat wallet behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Russello Montoro: ""And if you really do want to pull the rug out from under..."*)

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to working together. But I want it to be on my terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[247]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Russello Montoro: ""This is just the beginning, Your Majesty.""*)

### Węzeł `[264]`
Mówca: **Russello Montoro**
> ""This is just the beginning, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Narrator: "He looked around to make sure all of our guards were out ..."*)

### Węzeł `[265]`
Mówca: **Russello Montoro**
> ""And if you really do want to pull the rug out from under the Rizian nobility, you're going to need the fattest wallet of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He triumphantly gestured at himself. On seeing Hugo strid..."*)

### Węzeł `[266]`
Mówca: **Russello Montoro**
> ""You don't have to respond. Just hear me out for a second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Russello Montoro: ""All I know is, the word 'reform' has come up in connecti..."*)

### Węzeł `[267]`
Mówca: **Russello Montoro**
> ""All I know is, the word 'reform' has come up in connection with your name once or twice. And I don't mean the branch of Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Russello Montoro: ""If I'm wrong, go ahead and tell me to go to hell. All yo..."*)

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I did have such plans in store, what business would it be of yours?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[253]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Russello Montoro: ""Aha! So I'm right?""*)

### Węzeł `[269]`
Mówca: **Russello Montoro**
> ""Aha! So I'm right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Russello Montoro: ""All I know is, the word 'reform' has come up in connecti..."*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go to hell, Mr. Montoro.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Tyrant += 1"*)

### Węzeł `[271]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]` (*Russello Montoro: ""As you command, Your Majesty.""*)

### Węzeł `[272]`
Mówca: **Russello Montoro**
> ""As you command, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Russello Montoro: ""Just letting you know that I'm on your side. Or I could ..."*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rumors are exaggerated. Any reforms I put in place will be minor at the very most.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Russello Montoro: ""Minor or not, you know as well as I do that the nobility..."*)

### Węzeł `[274]`
Mówca: **Russello Montoro**
> ""Minor or not, you know as well as I do that the nobility in this country doesn't take kindly to change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Russello Montoro: ""You're going to need someone in your corner. Someone wit..."*)

### Węzeł `[275]`
Mówca: **Narrator**
> "He triumphantly gestured at himself. On seeing Hugo striding back towards us, he adopted a more serious posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Hugo Toras: ""I wouldn't have taken you for an art connoisseur. Mr. Mo..."*)

### Węzeł `[276]`
Mówca: **Russello Montoro**
> ""You're going to need someone in your corner. Someone with resources to burn and no scruples about burning them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Narrator: "He triumphantly gestured at himself. On seeing Hugo strid..."*)

### Węzeł `[277]`
Mówca: **Russello Montoro**
> ""Just letting you know that I'm on your side. Or I could be, if you let me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "He cut himself off upon seeing Hugo striding back towards..."*)

### Węzeł `[278]`
Mówca: **Russello Montoro**
> ""I am so, so, sorry. You can take the guards out of Arcasia, but you can't... well, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "The gold magnate's red hair was streaked with grey, but h..."*)

### Węzeł `[279]`
Mówca: **Russello Montoro**
> ""Do you need an occasion to catch up with an old friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Russello Montoro: ""I couldn't help noticing you've been crisscrossing the k..."*)

### Węzeł `[280]`
Mówca: **Hugo Toras**
> ""Since when are you worried about the Rizian People's Party, Mr. Montoro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Player_Romus: ""He's right to be worried. With Manus Sazon in charge, th..."*)
  - -> `[282]` (*Player_Romus: ""His Grace is right. The RPP doesn't have the power to ch..."*)
  - -> `[283]` (*Player_Romus: ""The party wants to bring the workers' demands to the hig..."*)
  - -> `[284]` (*Player_Romus: ""The miners don't need the RPP to help them. I'm the King..."*)

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right to be worried. With Manus Sazon in charge, the party could become a real threat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Russello Montoro: ""Not if we steer them in the right direction.""*)

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His Grace is right. The RPP doesn't have the power to change anything.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]` (*Russello Montoro: ""Except the public's mind.""*)

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The party wants to bring the workers' demands to the highest level of government. Admirable.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Russello Montoro: ""Only in theory.""*)

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The miners don't need the RPP to help them. I'm the King. I can better their situation in an instant.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[280]` (Hugo Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Russello Montoro: ""You can. But should you?""*)

### Węzeł `[285]`
Mówca: **Russello Montoro**
> ""You can. But should you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Russello Montoro: ""If I'm right, they're about to propose a big new batch o..."*)

### Węzeł `[286]`
Mówca: **Russello Montoro**
> ""Only in theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Russello Montoro: ""If I'm right, they're about to propose a big new batch o..."*)

### Węzeł `[287]`
Mówca: **Russello Montoro**
> ""Except the public's mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Russello Montoro: ""If I'm right, they're about to propose a big new batch o..."*)

### Węzeł `[288]`
Mówca: **Russello Montoro**
> ""Not if we steer them in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Russello Montoro: ""If I'm right, they're about to propose a big new batch o..."*)

### Węzeł `[289]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true &..."*)
  - -> `[291]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true..."*)

### Węzeł `[290]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Russello Montoro: ""Better to focus on breaking new ground, if you ask me. T..."*)

### Węzeł `[291]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true &..."*)

### Węzeł `[292]`
Mówca: **Russello Montoro**
> ""Better to focus on breaking new ground, if you ask me. That mining survey of yours was a good start...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Russello Montoro: ""That said, the more unnecessary requirements we have to ..."*)

### Węzeł `[293]`
Mówca: **Russello Montoro**
> ""Qalus, on the other hand, is looking *very* promising. That survey of yours was a stroke of genius.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Russello Montoro: ""That said, the more unnecessary requirements we have to ..."*)

### Węzeł `[294]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true &..."*)
  - -> `[296]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true..."*)

### Węzeł `[295]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  
(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Russello Montoro: ""Qalus, on the other hand, is looking *very* promising. T..."*)

### Węzeł `[296]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  
(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == tru..."*)

### Węzeł `[297]`
Mówca: **Russello Montoro**
> ""Better to focus on breaking new ground, if you ask me. Rumor has it your relatives in Valenqiris might be sitting on some *extremely* valuable real estate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Russello Montoro: ""That said, the more unnecessary requirements we have to ..."*)

### Węzeł `[298]`
Mówca: **Russello Montoro**
> ""That said, the more unnecessary requirements we have to meet to extract that gold, the less of it you get to keep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Zille = true"*)

### Węzeł `[299]`
Mówca: **Russello Montoro**
> ""Will they make anyone safer? Doubtful. Will they be a death blow to our bottom line? One hundred percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true &..."*)

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't understand what you're getting at.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Russello Montoro: ""If the rumors are true, Your Majesty... I see huge poten..."*)

### Węzeł `[301]`
Mówca: **Russello Montoro**
> ""If the rumors are true, Your Majesty... I see huge potential for both of us to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Russello Montoro: ""Hell, do you know how much growth we're missing out on b..."*)

### Węzeł `[302]`
Mówca: **Russello Montoro**
> ""Hell, do you know how much growth we're missing out on because international investors don't want to mess with an absolute monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Russello Montoro: ""I'm on your side. Or I could be, if you let me.""*)

### Węzeł `[303]`
Mówca: **Russello Montoro**
> ""I'm on your side. Or I could be, if you let me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Narrator: "He cut himself off upon seeing Hugo striding back towards..."*)

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""I take it as a positive sign that Mr. Montoro is open to renegotiating that stake. And I agree that over-regulation of our industries would hamper businesses while emboldening workers to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Russello Montoro: ""You're a smart man, Your Grace. You and I should go out ..."*)

### Węzeł `[305]`
Mówca: **Narrator**
> "He gave me a crooked smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Russello Montoro: ""I know, Your Majesty. Every single day, I'm grateful for..."*)

### Węzeł `[306]`
Mówca: **Russello Montoro**
> ""I know, Your Majesty. Every single day, I'm grateful for the privilege I've been given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Russello Montoro: ""I would like nothing more than to pay it forward. Let RR..."*)

### Węzeł `[307]`
Mówca: **Russello Montoro**
> ""I would like nothing more than to pay it forward. Let RRG keep running the way we always have, and I swear I'll return the favor in triplicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "He spread his arms wide."*)

### Węzeł `[308]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)
  - -> `[310]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ..."*)

### Węzeł `[309]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Russello Montoro: ""My pal Gus Manger told me he saw potential in your reign..."*)

### Węzeł `[310]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Russello Montoro: ""We're in this together. What's good for Rizian Royal Gol..."*)

### Węzeł `[311]`
Mówca: **Russello Montoro**
> ""My pal Gus Manger told me he saw potential in your reign. I'm inclined to agree with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Russello Montoro: ""If you keep on making deals and let us run our business ..."*)

### Węzeł `[312]`
Mówca: **Russello Montoro**
> ""If you keep on making deals and let us run our business the way we always have... well, just imagine a gold swimming pool in every Rizian backyard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Narrator: "Hugo shuddered quietly."*)

### Węzeł `[313]`
Mówca: **Russello Montoro**
> ""We're in this together. What's good for Rizian Royal Gold is good for Rizian royals. And vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Russello Montoro: ""Just let us keep running things the way we always have, ..."*)

### Węzeł `[314]`
Mówca: **Russello Montoro**
> ""Just let us keep running things the way we always have, and we'll take care of the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "He spread his arms wide."*)

### Węzeł `[315]`
Mówca: **Hugo Toras**
> ""I wouldn't have taken you for an art connoisseur. Mr. Montoro. That Kolores fresco in your hallway is stunning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Russello Montoro: ""Yeah, well. My pal Gus Manger convinced me it was a good..."*)

### Węzeł `[316]`
Mówca: **Narrator**
> "He cut himself off upon seeing Hugo striding back towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]` (*Hugo Toras: ""I wouldn't have taken you for an art connoisseur. Mr. Mo..."*)

### Węzeł `[317]`
Mówca: **Russello Montoro**
> ""Yeah, well. My pal Gus Manger convinced me it was a good investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]` (*Narrator: "He cracked a smile."*)

### Węzeł `[318]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)

### Węzeł `[319]`
Mówca: **Narrator**
> "Hugo shuddered quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Russello Montoro: ""Give me a hint, Your Majesty. Is the Crown on our side?""*)

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. If I'd known you'd invited me here only to wheedle favors out of me, I would have saved myself the trip.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Russello Montoro), `[337]` (Narrator), `[338]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Russello Montoro: ""Favors? I'm sorry if I gave you the wrong impression. Th..."*)

### Węzeł `[321]`
Mówca: **Russello Montoro**
> ""Give me a hint, Your Majesty. Is the Crown on our side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Player_Romus: ""We're indeed in this together. Keep supplying the kingdo..."*)
  - -> `[320]` (*Player_Romus: ""I've heard enough. If I'd known you'd invited me here on..."*)
  - -> `[324]` (*Player_Romus: ""The only side I'm on is that of ordinary, hard-working R..."*)
  - -> `[340]` (*Player_Romus: ""I'm not going to make any promises one way or the other.""*)

### Węzeł `[322]`
Mówca: **Narrator**
> "He spread his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Russello Montoro: ""Give me a hint, Your Majesty. Is the Crown on our side?""*)

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're indeed in this together. Keep supplying the kingdom with gold, and I will take care of any obstacles in RRG's way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Russello Montoro), `[337]` (Narrator), `[338]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Economy_PromiseNoMiningRegs = true; RiziaDLCSupp..."*)

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only side I'm on is that of ordinary, hard-working Rizians. I want what is best for them, even if our gold reserves suffer.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "He nodded, unperturbed."*)

### Węzeł `[325]`
Mówca: **Russello Montoro**
> ""If I'm wrong, go ahead and tell me to go to hell. All you nobles do, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]` (*Player_Romus: ""The rumors are exaggerated. Any reforms I put in place w..."*)
  - -> `[255]` (*Player_Romus: ""Yes, I'm planning changes. Changes that will keep people..."*)
  - -> `[300]` (*Player_Romus: ""I still don't understand what you're getting at.""*)
  - -> `[270]` (*Player_Romus: ""Go to hell, Mr. Montoro.""*)
  - -> `[327]` (*Player_Romus: ""I'd never utter such blasphemous words. But I'm not inte..."*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Tyrant += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]` (*Narrator: "He shrugged."*)

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd never utter such blasphemous words. But I'm not interested in discussing this with you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[325]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Religious += 1"*)

### Węzeł `[328]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Religious += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Narrator: "He shrugged."*)

### Węzeł `[329]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Russello Montoro: ""Suit yourself, Your Majesty.""*)

### Węzeł `[330]`
Mówca: **Russello Montoro**
> ""Suit yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]` (*Russello Montoro: ""Just letting you know that I'm on your side. Or I could ..."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ||..."*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true ..."*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Russello Montoro: ""He told me he had very high hopes for your reign, by the..."*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Russello Montoro: ""He doesn't have any hard feelings about you turning down..."*)

### Węzeł `[334]`
Mówca: **Russello Montoro**
> ""He told me he had very high hopes for your reign, by the way. Hopes that I myself share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Russello Montoro: ""If you keep on making deals and let us run our business ..."*)

### Węzeł `[335]`
Mówca: **Russello Montoro**
> ""He doesn't have any hard feelings about you turning down his deals, by the way. But he hopes you'll keep the door open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Russello Montoro: ""And so do I. Especially when it comes to that thing we w..."*)

### Węzeł `[336]`
Mówca: **Russello Montoro**
> ""If you keep on making deals and let us run our business the way we always have... well, just imagine a gold swimming pool in every Rizian backyard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Narrator: "Hugo shuddered quietly."*)

### Węzeł `[337]`
Mówca: **Narrator**
> "Hugo shuddered quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Romus: ""I appreciate everything RRG has done for the Crown. But ..."*)
  - -> `[323]` (*Player_Romus: ""We're indeed in this together. Keep supplying the kingdo..."*)
  - -> `[320]` (*Player_Romus: ""I've heard enough. If I'd known you'd invited me here on..."*)
  - -> `[340]` (*Player_Romus: ""I'm not going to make any promises one way or the other.""*)

### Węzeł `[338]`
Mówca: **Russello Montoro**
> ""And so do I. Especially when it comes to that thing we were just discussing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Player_Romus: ""I appreciate everything RRG has done for the Crown. But ..."*)
  - -> `[323]` (*Player_Romus: ""We're indeed in this together. Keep supplying the kingdo..."*)
  - -> `[320]` (*Player_Romus: ""I've heard enough. If I'd known you'd invited me here on..."*)
  - -> `[340]` (*Player_Romus: ""I'm not going to make any promises one way or the other.""*)

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate everything RRG has done for the Crown. But I owe it to the Rizian people to take the concerns of the workers into consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[337]` (Narrator), `[338]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "He nodded, unperturbed."*)

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to make any promises one way or the other.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[321]` (Russello Montoro), `[337]` (Narrator), `[338]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]` (*Narrator: "He nodded, unperturbed."*)

### Węzeł `[341]`
Mówca: **Narrator**
> "He nodded, unperturbed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Russello Montoro: ""Fine and dandy, Your Majesty.""*)

### Węzeł `[342]`
Mówca: **Russello Montoro**
> ""Fine and dandy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount < 1"*)

### Węzeł `[343]`
Mówca: **Russello Montoro**
> ""Favors? I'm sorry if I gave you the wrong impression. This was only supposed to be a friendly chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount < 1"*)

### Węzeł `[344]`
Mówca: **Russello Montoro**
> ""Much appreciated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount < 1"*)

### Węzeł `[345]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Economy_PromiseNoMiningRegs = true; RiziaDLCSupport.Journal_Turn03_Rusty_PromiseNoRegs = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rusty_PromiseNoRegs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Russello Montoro: ""Much appreciated, Your Majesty.""*)

### Węzeł `[346]`
Mówca: **Narrator**
> "He gestured towards a number of floral-patterned chairs that had been set out on the terrace, overlooking the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Russello Montoro: ""On behalf of all of us at the esteemed Rizian Royal Gold..."*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)
  - -> `[349]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanAmount > 0)"*)

### Węzeł `[348]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Russello Montoro: ""And I didn't hear you complaining about my manners when ..."*)

### Węzeł `[349]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanAmount > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[350]`
Mówca: **Russello Montoro**
> ""And I didn't hear you complaining about my manners when you were accepting my money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Yes, thank you for your offer. You'll get your repayment..."*)
  - -> `[360]` (*Player_Romus: ""It's a disgrace that my father allowed you to accumulate..."*)
  - -> `[361]` (*Player_Romus: ""Borrowing from RRG does not mean you and I are entering ..."*)
  - -> `[365]` (*Player_Romus: ""It's impolite of you to bring that up here. We shall spe..."*)

### Węzeł `[351]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)
  - -> `[353]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanAmount > 0)"*)

### Węzeł `[352]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]` (*Russello Montoro: ""Plus, y'know, you did accept a big chunk of change from ..."*)

### Węzeł `[353]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanAmount > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[354]`
Mówca: **Russello Montoro**
> ""Plus, y'know, you did accept a big chunk of change from me lately. Thought you might want to come meet your benefactor in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Yes, thank you for your offer. You'll get your repayment..."*)
  - -> `[360]` (*Player_Romus: ""It's a disgrace that my father allowed you to accumulate..."*)
  - -> `[361]` (*Player_Romus: ""Borrowing from RRG does not mean you and I are entering ..."*)
  - -> `[365]` (*Player_Romus: ""It's impolite of you to bring that up here. We shall spe..."*)

### Węzeł `[355]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanAmount > 0"*)
  - -> `[357]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanAmount > 0)"*)

### Węzeł `[356]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanAmount > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]` (*Russello Montoro: ""By the way, no rush on paying back that loan I gave you.""*)

### Węzeł `[357]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanAmount > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[358]`
Mówca: **Russello Montoro**
> ""By the way, no rush on paying back that loan I gave you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]` (*Player_Romus: ""Yes, thank you for your offer. You'll get your repayment..."*)
  - -> `[360]` (*Player_Romus: ""It's a disgrace that my father allowed you to accumulate..."*)
  - -> `[361]` (*Player_Romus: ""Borrowing from RRG does not mean you and I are entering ..."*)
  - -> `[365]` (*Player_Romus: ""It's impolite of you to bring that up here. We shall spe..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thank you for your offer. You'll get your repayment in due time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Russello Montoro), `[354]` (Russello Montoro), `[358]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Russello Montoro: ""It was nothing. I know you and Ms. Werner will put the c..."*)

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that my father allowed you to accumulate so much wealth. The King of Rizia should not have to stoop to borrowing from a commoner.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Russello Montoro), `[354]` (Russello Montoro), `[358]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Russello Montoro: ""Hey, it's not like I didn't work for it. And besides, I ..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Borrowing from RRG does not mean you and I are entering into any kind of *arrangement*. You should know that upfront.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Russello Montoro), `[354]` (Russello Montoro), `[358]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Russello Montoro: ""You're a valuable shareholder in my business, Your Majes..."*)

### Węzeł `[362]`
Mówca: **Russello Montoro**
> ""You're a valuable shareholder in my business, Your Majesty. You want our arrangement to stop there, it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[363]`
Mówca: **Russello Montoro**
> ""It was nothing. I know you and Ms. Werner will put the cash to good use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[364]`
Mówca: **Russello Montoro**
> ""Hey, it's not like I didn't work for it. And besides, I know you and Ms. Werner will double that money in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's impolite of you to bring that up here. We shall speak no more of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[350]` (Russello Montoro), `[354]` (Russello Montoro), `[358]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Russello Montoro: ""All right. My lips are sealed.""*)

### Węzeł `[366]`
Mówca: **Russello Montoro**
> ""All right. My lips are sealed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_DancedWithManus == true"*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanA..."*)
  - -> `[369]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_Loa..."*)

### Węzeł `[368]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Player_Romus: ""You say cooperation, I say usury. Did you try to pull th..."*)

### Węzeł `[369]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You say cooperation, I say usury. Did you try to pull that 'loan' trick with my father?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0`
- **Kontekst wejściowy (poprzednik):** `[31]` (Russello Montoro)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Russello Montoro: ""Trick, Your Majesty? I was only trying to give us both a..."*)

### Węzeł `[371]`
Mówca: **Russello Montoro**
> ""Trick, Your Majesty? I was only trying to give us both a leg up. You've got to spend money to make money, as I'm sure you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Russello Montoro: ""My point being. As a trusted business associate, there's..."*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanOfferCount < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Rusty_LoanOfferCount < 1"*)
  - -> `[374]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Rusty_LoanOfferCount < 1)"*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Rusty_LoanOfferCount < 1`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanOfferCount"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Russello Montoro: ""And by the way. Should you ever find yourself low on Cro..."*)

### Węzeł `[374]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Rusty_LoanOfferCount < 1)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanOfferCount"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Russello Montoro: ""And don't forget. You ever find yourself low on Crown fu..."*)

### Węzeł `[375]`
Mówca: **Russello Montoro**
> ""And by the way. Should you ever find yourself low on Crown funds, don't hesitate to reach out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]` (*Russello Montoro: ""RRG aside, I've been fortunate enough to have made some ..."*)

### Węzeł `[376]`
Mówca: **Russello Montoro**
> ""RRG aside, I've been fortunate enough to have made some very profitable investments. Happy to share the wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Elena stepped back onto the terrace."*)

### Węzeł `[377]`
Mówca: **Russello Montoro**
> ""Don't get me wrong, Your Majesty -- my personal finances will be just fine. It's your revenue stream I'm looking out for here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "RiziaDLCIsolated.Turn03_RustyConvo_Revenue = true"*)

### Węzeł `[378]`
Mówca: **Russello Montoro**
> ""And don't forget. You ever find yourself low on Crown funds again, the bank of Rusty is still open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Elena stepped back onto the terrace."*)

### Węzeł `[379]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == tru..."*)
  - -> `[381]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == t..."*)

### Węzeł `[380]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Russello Montoro: ""Qalus, on the other hand, is looking *very* promising.""*)

### Węzeł `[381]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Russello Montoro: ""Better to focus on breaking new ground, if you ask me. R..."*)

### Węzeł `[382]`
Mówca: **Russello Montoro**
> ""Qalus, on the other hand, is looking *very* promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Russello Montoro: ""That said, the more unnecessary requirements we have to ..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `SetRichPresence("Meeting the CEO of Royal Rizian Gold by his gold-tiled pool", "Palas Verana", "Bronaz");`
- **Efekt skryptowy (`userScript`):** `SetRichPresence("Meeting the CEO of Royal Rizian Gold by his gold-tiled pool","Palas Verana","Bronaz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");"*)
