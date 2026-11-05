# Rizia/Turn 2/P_VinaAtMonqiz

- **ID konwersacji:** `300`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/300_P_VinaAtMonqiz.md`
- **Liczba węzłów dialogowych:** 568
- **Liczba wyborów gracza:** 155

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[79]** Vina Toras
- **[81]** Titus Gordion
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban`
- `RiziaDLC.Focus_Government_Absolutism`
- `RiziaDLC.Focus_Government_Reform`
- `RiziaDLC.Hugo_KnowsIntention`
- `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative`
- `RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws`
- `RiziaDLC.Prologue_HadAffairs`
- `RiziaDLC.Prologue_InBoatAccident`
- `RiziaDLC.Prologue_LovedWife`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Prologue_Religious`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_TookBookAway`
- `RiziaDLC.Situation_Economy_Sordland_ResortDeal`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage`
- `RiziaDLC.Security_ValeroPoisoningTalk_Happened`
- `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy`
- `RiziaDLC.Turn02_Intention_NoMonarchy`
- `RiziaDLC.Vina_PromisedQueen`
- `RiziaDLC.Vina_WarnedPossibleDisinheritance`
- `RiziaDLCSupport.Journal_Turn02_Pabel_Listened`
- `RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist`
- `RiziaDLCSupport.News_Turn02_G_SaveTheRiver`
- `RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis`
- `RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep`

### Skoki między-konwersacyjne:
- Węzeł `[179]` -> **[301] Rizia/Turn 2/Pabel Valero Poisoning Talk** (../Turn_02/301_Pabel_Valero_Poisoning_Talk.md), Węzeł `[1]`
- Węzeł `[349]` -> **[301] Rizia/Turn 2/Pabel Valero Poisoning Talk** (../Turn_02/301_Pabel_Valero_Poisoning_Talk.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **""Vina! Slow down!""** | `[4]` **Narrator**: "A trail was carved into the clif..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[7]` **Narrator**: "She glanced back at me for just ..." |
| `[6]` | **"Go faster yourself."** | `[4]` **Narrator**: "A trail was carved into the clif..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Narrator**: "Vina glanced back at me with a g..." |
| `[12]` | **""Faster! Remember what I taught you!""** | `[4]` **Narrator**: "A trail was carved into the clif..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Narrator**: "She glanced back at me with a gr..." |
| `[15]` | **""I wanted to. It's been ages since we had time together.""** | `[14]` **Vina Toras**: ""You really didn't have to come ..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[17]` **Vina Toras**: ""We could be spending time at Pa..." |
| `[16]` | **""I'm grateful for the break. It's too hectic in Porte Drazon.""** | `[14]` **Vina Toras**: ""You really didn't have to come ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Vina Toras**: ""I like the place. But I can't l..."<br>`[208]` **Vina Toras**: ""Hectic for you, maybe. I'm bore..." |
| `[21]` | **""I wanted to. Council meetings don't exactly count as quality time together.""** | `[14]` **Vina Toras**: ""You really didn't have to come ..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[22]` **Vina Toras**: ""Deciding the fate of the countr..." |
| `[33]` | **""I'd still declare you next in line. Rizia needs a queen like you, and the rules w..."** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..."<br>`[547]` **Vina Toras**: ""Nothing, Father. Can we go back..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[48]` **Narrator**: "She smiled." |
| `[34]` | **""He'd become my successor, of course. Those are the rules. But you'll still be a d..."** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..."<br>`[547]` **Vina Toras**: ""Nothing, Father. Can we go back..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[47]` **Narrator**: "She folded her arms." |
| `[38]` | **""You know what'll help blot out those memories? A big Sordish resort, right on thi..."** | `[242]` **Narrator**: "It was just an ocean. A big, imp..."<br>`[285]` **Vina Toras**: ""I'm sorry, Father. I didn't rea..." | `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[263]` **Narrator**: "She let out a sound that was hal..." |
| `[39]` | **""It'll get easier over time. It did for me.""** | `[242]` **Narrator**: "It was just an ocean. A big, imp..."<br>`[288]` **Narrator**: "My daughter didn't join me, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[261]` **Narrator**: "She cast a sidelong glance at me." |
| `[40]` | **""Grief isn't a straight line, my daughter. It ebbs and flows like the tide.""** | `[242]` **Narrator**: "It was just an ocean. A big, imp..."<br>`[285]` **Vina Toras**: ""I'm sorry, Father. I didn't rea..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Vina Toras**: ""It's always high tide for me. A..." |
| `[43]` | **""What makes you think our family will still hold power by the time I die?""** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..." | `(Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[351]` **Narrator**: "Vina's eyes grew wide." |
| `[52]` | **""I've got to do some glad-handing here anyway, before the Sordish invasion begins.""** | `[14]` **Vina Toras**: ""You really didn't have to come ..." | `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[28]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..."<br>`[29]` **Vina Toras**: ""Ah. I knew there was another re..." |
| `[53]` | **""I just wanted to relish the sight of this beautiful, Sord-free beach.""** | `[14]` **Vina Toras**: ""You really didn't have to come ..." | `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false` | *Brak zmian stanu* | `[54]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..."<br>`[58]` **Vina Toras**: ""Don't you think that's a little..." |
| `[59]` | **""You don't have anything to worry about. My childbearing days are over.""** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..."<br>`[547]` **Vina Toras**: ""Nothing, Father. Can we go back..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[45]` **Vina Toras**: ""But you're a man. As long as yo..." |
| `[75]` | **""What?""** | `[74]` **Vina Toras**: ""Father? One more thing."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Vina Toras**: ""It's just..."" |
| `[76]` | **""I'm not hungry right now. I'll eat my sandwich when we get back to the palace.""** | `[74]` **Vina Toras**: ""Father? One more thing."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Vina Toras**: ""No, not that."" |
| `[82]` | **""Why? Do you have any candidates in mind?""** | `[81]` **Vina Toras**: ""How important is it to you, rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Vina Toras**: ""No, but do *you*? Are you going..." |
| `[83]` | **""Don't listen to that hypocrite. Grandma followed her heart, and so should you.""** | `[81]` **Vina Toras**: ""How important is it to you, rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Vina Toras**: ""So you won't try to marry me of..." |
| `[85]` | **""I don't care whom you marry. As long as he's of noble birth, of course.""** | `[81]` **Vina Toras**: ""How important is it to you, rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Vina Toras**: ""So you're not planning to marry..." |
| `[86]` | **""You're a princess, Vina. Your marriage status matters not only to me, but to the ..."** | `[81]` **Vina Toras**: ""How important is it to you, rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Vina Toras**: ""Does that mean you're planning ..." |
| `[89]` | **""I'm still considering all the options.""** | `[84]` **Vina Toras**: ""No, but do *you*? Are you going..."<br>`[87]` **Vina Toras**: ""Does that mean you're planning ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "She fixed me with a stare." |
| `[90]` | **""My arranged marriage was the best thing that ever happened to me.""** | `[84]` **Vina Toras**: ""No, but do *you*? Are you going..."<br>`[87]` **Vina Toras**: ""Does that mean you're planning ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "She fixed me with a stare." |
| `[91]` | **""Absolutely not. Arranged marriage is a barbaric tradition.""** | `[84]` **Vina Toras**: ""No, but do *you*? Are you going..."<br>`[87]` **Vina Toras**: ""Does that mean you're planning ..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Vina Toras**: ""It worked out for you and Mother.""<br>`[99]` **Vina Toras**: ""You and Mother were living proo..." |
| `[97]` | **""I might suggest a potential husband or two. But I'll never drag you to the altar.""** | `[88]` **Vina Toras**: ""So you're not planning to marry..."<br>`[108]` **Vina Toras**: ""So you won't try to marry me of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "She looked relieved." |
| `[98]` | **""And what if I am?""** | `[87]` **Vina Toras**: ""Does that mean you're planning ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Narrator**: "She fixed me with a stare." |
| `[105]` | **""You want to be queen? This is part of it. A single wedding can accomplish more th..."** | `[95]` **Vina Toras**: ""I wasn't blind and deaf growing..."<br>`[96]` **Vina Toras**: ""You and Mother were lucky to fa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[116]` **Narrator**: "She mulled over my words for a m..." |
| `[106]` | **""Relax. I might suggest a potential husband or two, but I'll never drag you to the..."** | `[95]` **Vina Toras**: ""I wasn't blind and deaf growing..."<br>`[96]` **Vina Toras**: ""You and Mother were lucky to fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Narrator**: "She looked relieved." |
| `[107]` | **""Whether or not I loved her, I did what I was ordered to do. As you will when the ..."** | `[95]` **Vina Toras**: ""I wasn't blind and deaf growing..."<br>`[96]` **Vina Toras**: ""You and Mother were lucky to fa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[190]` **Narrator**: "She seemed to shrink a little." |
| `[110]` | **""Think of it as yet another one of your royal obligations. You can always take a l..."** | `[95]` **Vina Toras**: ""I wasn't blind and deaf growing..."<br>`[96]` **Vina Toras**: ""You and Mother were lucky to fa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Narrator**: "She regarded me coolly for a mom..."<br>`[116]` **Narrator**: "She mulled over my words for a m..." |
| `[111]` | **""I trust you to make the right decision. For yourself, and for Rizia.""** | `[88]` **Vina Toras**: ""So you're not planning to marry..."<br>`[108]` **Vina Toras**: ""So you won't try to marry me of..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "She smiled."<br>`[126]` **Narrator**: "Her expression was hard to read." |
| `[124]` | **""We were an exception.""** | `[103]` **Vina Toras**: ""It worked out for you and Mother."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "She nodded." |
| `[132]` | **""We both loved you. And we both swore you'd never go through the same hell we did.""** | `[99]` **Vina Toras**: ""You and Mother were living proo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[189]` **Narrator**: "She smiled." |
| `[133]` | **""I don't know what you're talking about.""** | `[99]` **Vina Toras**: ""You and Mother were living proo..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Narrator**: "She regarded me coolly for a sec..." |
| `[134]` | **""All because I didn't have the courage to speak to my father as an equal. You're b..."** | `[99]` **Vina Toras**: ""You and Mother were living proo..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[189]` **Narrator**: "She smiled." |
| `[135]` | **""We made the best of the situation we'd been forced into.""** | `[103]` **Vina Toras**: ""It worked out for you and Mother."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[137]` **Narrator**: "She nodded." |
| `[136]` | **""I still wish I'd had a choice. The least I can do is grant you one.""** | `[103]` **Vina Toras**: ""It worked out for you and Mother."" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[189]` **Narrator**: "She smiled." |
| `[148]` | **""She's too fast for her old man.""** | `[343]` **Pabel Adria**: ""Where is the princess?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[151]` **Pabel Adria**: ""I remember a certain Romus Tora..."<br>`[152]` **Pabel Adria**: ""I heard you used to be quite th..." |
| `[149]` | **""She's visiting with a friend, but she wanted to thank you for lunch.""** | `[343]` **Pabel Adria**: ""Where is the princess?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[153]` **Pabel Adria**: ""Monqiz lobster. It's never so s..." |
| `[150]` | **""In another castle. I let her go out, against my better judgement.""** | `[343]` **Pabel Adria**: ""Where is the princess?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[157]` **Pabel Adria**: ""She's more than old enough to g..."<br>`[158]` **Pabel Adria**: ""Any daughter of King Romus is b..." |
| `[159]` | **""You read my mind, Pabel.""** | `[344]` **Pabel Adria**: ""There's a warm bath waiting for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[162]` **Pabel Adria**: ""All part of the job."" |
| `[160]` | **""I'm not sore at all. But a bath sounds good.""** | `[344]` **Pabel Adria**: ""There's a warm bath waiting for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[163]` **Pabel Adria**: ""Let me know if you need anythin..." |
| `[161]` | **""Only if it's got bubbles.""** | `[344]` **Pabel Adria**: ""There's a warm bath waiting for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Pabel Adria**: ""Is there any other kind of bath?"" |
| `[166]` | **"Scrub your right arm."** | `[165]` **Narrator**: "I made my way to Palas Monqiz's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A tap came at the door, so soft ..." |
| `[167]` | **"Scrub your left arm."** | `[165]` **Narrator**: "I made my way to Palas Monqiz's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A tap came at the door, so soft ..." |
| `[168]` | **"Scrub your right leg."** | `[165]` **Narrator**: "I made my way to Palas Monqiz's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A tap came at the door, so soft ..." |
| `[169]` | **"Scrub your left leg."** | `[165]` **Narrator**: "I made my way to Palas Monqiz's ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[170]` **Narrator**: "A tap came at the door, so soft ..." |
| `[176]` | **""Not now. Go away.""** | `[171]` **Pabel Adria**: ""Your Majesty?""<br>`[175]` **Pabel Adria**: ""Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[178]` **Pabel Adria**: ""I'll just be a second. I forgot..." |
| `[177]` | **""Yes?""** | `[171]` **Pabel Adria**: ""Your Majesty?""<br>`[175]` **Pabel Adria**: ""Romus?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[345]` **Pabel Adria**: ""May I come in? I forgot to leav..." |
| `[179]` | **""All right. Come in.""** | `[178]` **Pabel Adria**: ""I'll just be a second. I forgot..."<br>`[345]` **Pabel Adria**: ""May I come in? I forgot to leav..." | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop"); ;` | `[3]` **Narrator**: "It was low tide. The waves of th..." |
| `[180]` | **""Don't you have anything better to do? Stop bothering me.""** | `[178]` **Pabel Adria**: ""I'll just be a second. I forgot..."<br>`[345]` **Pabel Adria**: ""May I come in? I forgot to leav..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[181]` **Pabel Adria**: ""Very well. Have a nice bath, Yo..."<br>`[186]` **Pabel Adria**: ""Very well. Have a nice bath."" |
| `[195]` | **""We already discussed this. What have you been doing instead?""** | `[17]` **Vina Toras**: ""We could be spending time at Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[199]` **Vina Toras**: ""The usual. Ballgoing. Public ap..." |
| `[196]` | **""I don't know how much we're deciding. Sometimes I feel like it's out of any of ou..."** | `[22]` **Vina Toras**: ""Deciding the fate of the countr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[415]` **Vina Toras**: ""You just accepted that Sordish ..."<br>`[419]` **Vina Toras**: ""You just turned down the Sords'..." |
| `[197]` | **""My mother was right about a few things. It's not healthy to spend too long in tho..."** | `[22]` **Vina Toras**: ""Deciding the fate of the countr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[198]` | **""Keep up that enthusiasm. It will serve you well when you're older.""** | `[22]` **Vina Toras**: ""Deciding the fate of the countr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[200]` | **""Not our beach, though, right?""** | `[58]` **Vina Toras**: ""Don't you think that's a little..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[201]` **Vina Toras**: ""Why should we be an exception?"" |
| `[202]` | **""A Marcel Koronti resort on these shores would attract the worst kind of elitist. ..."** | `[58]` **Vina Toras**: ""Don't you think that's a little..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[203]` **Vina Toras**: ""You're probably right. I've rea..." |
| `[204]` | **""Everyone in *Rizia*. The Sords have their own beaches.""** | `[58]` **Vina Toras**: ""Don't you think that's a little..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[402]` **Vina Toras**: ""They don't belong to everyone i..." |
| `[205]` | **""Trust me, it's nowhere near as exciting as you imagine.""** | `[17]` **Vina Toras**: ""We could be spending time at Pa..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[206]` **Vina Toras**: ""I'm sure it's more exciting tha..." |
| `[207]` | **""None of your backtalk. Let's just treasure what time we have.""** | `[17]` **Vina Toras**: ""We could be spending time at Pa..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[448]` **Vina Toras**: ""Sure, Father. I will."" |
| `[213]` | **""What would you have done?""** | `[28]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Narrator**: "She considered it seriously." |
| `[214]` | **""They made me drink whiskey. It went to my head.""** | `[28]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[222]` **Vina Toras**: ""No need to make excuses, Father..." |
| `[215]` | **""Are you questioning my decision?""** | `[28]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[221]` **Vina Toras**: ""Not at all, Father. I'm sure yo..." |
| `[218]` | **""It was the right diplomatic move. I'm sure of it.""** | `[28]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[223]` **Vina Toras**: ""I'll miss the unobstructed view..." |
| `[219]` | **""And what would you have done?""** | `[54]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[216]` **Narrator**: "She considered it seriously." |
| `[224]` | **""I may have made the wrong diplomatic move, but it felt right in my heart.""** | `[54]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[225]` **Vina Toras**: ""No need to make excuses, Father..." |
| `[226]` | **""They thought they could buy me with their greasy Sordish ren. I showed them.""** | `[54]` **Vina Toras**: ""A Sordish resort in Monqiz! I c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[227]` **Vina Toras**: ""I'm sure you did, Father."" |
| `[233]` | **"Let yourself remember."** | `[228]` **Narrator**: "I looked out at the sea again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[235]` **Narrator**: "The sickening sound the boat had..."<br>`[241]` **Narrator**: "The sickening sound the boat had..."<br>*(oraz 2 innych odgałęzień)* |
| `[234]` | **"Try not to think about it."** | `[228]` **Narrator**: "I looked out at the sea again." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[229]` **Narrator**: "But they were too strong."<br>`[242]` **Narrator**: "It was just an ocean. A big, imp..." |
| `[240]` | **"Don't resist."** | `[239]` **Narrator**: "Tears formed at the corners of m..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[284]` **Narrator**: "Vina appeared at a loss for word..." |
| `[247]` | **"Don't cry."** | `[239]` **Narrator**: "Tears formed at the corners of m..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "It was just an ocean. A big, imp..." |
| `[255]` | **"Cry."** | `[254]` **Narrator**: "Worst of all: the secret relief ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[284]` **Narrator**: "Vina appeared at a loss for word..." |
| `[256]` | **"Keep your cool."** | `[254]` **Narrator**: "Worst of all: the secret relief ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[242]` **Narrator**: "It was just an ocean. A big, imp..." |
| `[260]` | **"Pray."** | `[239]` **Narrator**: "Tears formed at the corners of m..."<br>`[254]` **Narrator**: "Worst of all: the secret relief ..." | `Variable["RiziaDLC.Prologue_Religious"] == true` | *Brak zmian stanu* | `[288]` **Narrator**: "My daughter didn't join me, but ..." |
| `[267]` | **""We've got to move forward. Lena wouldn't have wanted us to stay in mourning for s..."** | `[242]` **Narrator**: "It was just an ocean. A big, imp..."<br>`[285]` **Vina Toras**: ""I'm sorry, Father. I didn't rea..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[292]` **Vina Toras**: ""Maybe not. But I can't help it."" |
| `[270]` | **""Don't be naive. I've had dates. Just nobody worth telling you about.""** | `[269]` **Vina Toras**: ""Eight years and not so much as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[279]` **Vina Toras**: ""Oh."" |
| `[271]` | **""What's with the sudden interest in my love life?""** | `[269]` **Vina Toras**: ""Eight years and not so much as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[282]` **Vina Toras**: ""Well..."" |
| `[272]` | **""It feels useless to try. I'll never love anyone else as much as I loved your moth..."** | `[269]` **Vina Toras**: ""Eight years and not so much as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[274]` **Narrator**: "Vina looked unconvinced."<br>`[278]` **Narrator**: "Vina gave me a small smile." |
| `[273]` | **""Looking after you has been my number-one priority.""** | `[269]` **Vina Toras**: ""Eight years and not so much as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[281]` **Vina Toras**: ""You can't use that as an excuse..." |
| `[287]` | **""She's in a better place now, Vina. As you and I will be one day.""** | `[288]` **Narrator**: "My daughter didn't join me, but ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[295]` **Vina Toras**: ""But what happens until then? We..." |
| `[289]` | **""I miss her so much.""** | `[285]` **Vina Toras**: ""I'm sorry, Father. I didn't rea..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[290]` **Vina Toras**: ""Me too. But it's got to get eas..." |
| `[305]` | **""Fine, you can bring Lizzie back to Porte Drazon. But you'll have to get rid of on..."** | `[74]` **Vina Toras**: ""Father? One more thing."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[306]` **Vina Toras**: ""Oh, that'd be grand! But I want..." |
| `[308]` | **""But I thought we'd be spending the whole visit together.""** | `[307]` **Vina Toras**: ""Sorry to run, but one of the co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[316]` **Vina Toras**: ""I've spent enough time with you..."<br>`[317]` **Vina Toras**: ""Don't worry. I'll be back befor..." |
| `[309]` | **""Have fun. I'm glad we were able to talk.""** | `[307]` **Vina Toras**: ""Sorry to run, but one of the co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[328]` **Vina Toras**: ""Yes, it was *very* enlightening.""<br>`[327]` **Vina Toras**: ""So am I."" |
| `[310]` | **""Titus! Send one of your men to keep an eye on her?""** | `[307]` **Vina Toras**: ""Sorry to run, but one of the co..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[311]` **Narrator**: "My guard appeared from behind a ..." |
| `[321]` | **""Try and gauge her reaction to the Sordish resort idea, will you?""** | `[307]` **Vina Toras**: ""Sorry to run, but one of the co..." | `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[330]` **Vina Toras**: ""No need. I already know her fam..."<br>`[334]` **Vina Toras**: ""I already know her family hates..." |
| `[346]` | **""It's not important. I'll dry off without one.""** | `[178]` **Pabel Adria**: ""I'll just be a second. I forgot..."<br>`[345]` **Pabel Adria**: ""May I come in? I forgot to leav..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[348]` **Pabel Adria**: ""It's... a very special towel?"" |
| `[349]` | **""I see. Fine, bring it in.""** | `[348]` **Pabel Adria**: ""It's... a very special towel?"" | *Brak (Dostępna bezwarunkowo)* | `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop"); ;` | `[3]` **Narrator**: "It was low tide. The waves of th..." |
| `[350]` | **""I told you not to come in, Pabel.""** | `[348]` **Pabel Adria**: ""It's... a very special towel?"" | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC...` | `[181]` **Pabel Adria**: ""Very well. Have a nice bath, Yo..."<br>`[186]` **Pabel Adria**: ""Very well. Have a nice bath."" |
| `[353]` | **""It's time for the people of Rizia to hold the real power, Vina.""** | `[352]` **Vina Toras**: ""You mean..."" | `Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[356]` **Vina Toras**: ""But... what would become of us?"" |
| `[354]` | **""The monarchy must die if Rizia is to enter the modern era. At least in its curren..."** | `[352]` **Vina Toras**: ""You mean..."" | `Variable["RiziaDLC.Focus_Government_Reform"] == true` | *Brak zmian stanu* | `[356]` **Vina Toras**: ""But... what would become of us?"" |
| `[355]` | **""We stopped one uprising. I fear the next won't be so easy to suppress.""** | `[352]` **Vina Toras**: ""You mean..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[401]` **Vina Toras**: ""The next? That's pessimistic, F..." |
| `[357]` | **""We would stay on, but only in a symbolic role. The human embodiment of Rizian gra..."** | `[356]` **Vina Toras**: ""But... what would become of us?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[363]` **Vina Toras**: ""I understand. But I always thou..." |
| `[358]` | **""We could do anything we wanted! All the riches, none of the responsibility. Isn't..."** | `[356]` **Vina Toras**: ""But... what would become of us?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[364]` **Vina Toras**: ""Maybe for you. I always thought..." |
| `[359]` | **""We'd live as normal citizens. We don't deserve to be treated as superior simply b..."** | `[356]` **Vina Toras**: ""But... what would become of us?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[360]` **Vina Toras**: ""You really think that?"" |
| `[361]` | **""We would still perform some important duties. But a democratically elected leader..."** | `[356]` **Vina Toras**: ""But... what would become of us?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[362]` **Vina Toras**: ""I understand. I think."" |
| `[370]` | **""Mr. Chavatangakwunua, eh?""** | `[369]` **Vina Toras**: ""You know, this book I'm reading..." | `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`<br>`(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false` | *Brak zmian stanu* | `[380]` **Vina Toras**: ""Well... um, yes. He makes a lot..." |
| `[374]` | **""How are you still reading that? I took it away.""** | `[369]` **Vina Toras**: ""You know, this book I'm reading..." | `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true` | *Brak zmian stanu* | `[381]` **Narrator**: "Vina folded her arms defiantly." |
| `[375]` | **""You're still reading that? Even after I banned Malenyevist propaganda?""** | `[369]` **Vina Toras**: ""You know, this book I'm reading..." | `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`<br>`(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false` | *Brak zmian stanu* | `[381]` **Narrator**: "Vina folded her arms defiantly." |
| `[376]` | **""That's cruel to those of us who are only trying to keep our country afloat.""** | `[369]` **Vina Toras**: ""You know, this book I'm reading..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[379]` **Vina Toras**: ""Maybe we're dead weight. We hav..." |
| `[377]` | **""Maybe it's time to sink that ship.""** | `[369]` **Vina Toras**: ""You know, this book I'm reading..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] = true;` | `[378]` **Vina Toras**: ""Maybe it is."" |
| `[386]` | **""She was right. We're not ready to sink to the bottom of the ocean just yet.""** | `[368]` **Vina Toras**: ""You know, Queen Lyza likened th..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarch...` | `[397]` **Vina Toras**: ""I hope not. Our people still ne..." |
| `[387]` | **""Wise words. But the Rizian people should steer their own ship.""** | `[368]` **Vina Toras**: ""You know, Queen Lyza likened th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[398]` **Vina Toras**: ""How can they, without a noble h..." |
| `[388]` | **""I am warning you, Vina. Stop filling your head with this nonsense.""** | `[385]` **Vina Toras**: ""You can't stop me from informin..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[488]` **Vina Toras**: ""But... you're the one talking a..." |
| `[389]` | **""I don't know, His concept of vanguardism doesn't sound too far off from monarchy ..."** | `[380]` **Vina Toras**: ""Well... um, yes. He makes a lot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[393]` **Vina Toras**: ""That's why Hegel branched off w..." |
| `[390]` | **""Keep on reading. Sounds like there's a lot of useful information in there.""** | `[380]` **Vina Toras**: ""Well... um, yes. He makes a lot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[394]` **Vina Toras**: ""To be honest, a lot of it is ou..." |
| `[391]` | **""I like his analogy. I'm less convinced about his preferred system of government.""** | `[380]` **Vina Toras**: ""Well... um, yes. He makes a lot..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[392]` **Vina Toras**: ""Yes, I've also started to read ..." |
| `[395]` | **""It may be a steady ship, but it sails on the currents of privilege and tradition,..."** | `[368]` **Vina Toras**: ""You know, Queen Lyza likened th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[399]` **Vina Toras**: ""That doesn't need to be the cas..." |
| `[396]` | **""We do not need a steady ship. We need to recognize the changing seas and adapt to..."** | `[368]` **Vina Toras**: ""You know, Queen Lyza likened th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[400]` **Vina Toras**: ""Change can be threatening to ma..." |
| `[403]` | **""What have you been doing these days, anyway?""** | `[208]` **Vina Toras**: ""Hectic for you, maybe. I'm bore..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Vina Toras**: ""The usual. Ballgoing. Public ap..." |
| `[410]` | **""Do you think it was the right decision to let them build their resort?""** | `[406]` **Vina Toras**: ""It's beautiful here, isn't it? ..." | `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[421]` **Narrator**: "Vina thought for a moment." |
| `[411]` | **""They did indeed. But I showed them who's in charge.""** | `[406]` **Vina Toras**: ""It's beautiful here, isn't it? ..." | `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false` | *Brak zmian stanu* | `[425]` **Vina Toras**: ""A Sordish resort on our shores!..." |
| `[412]` | **""Do you think I should have given it to them?""** | `[406]` **Vina Toras**: ""It's beautiful here, isn't it? ..." | `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false` | *Brak zmian stanu* | `[426]` **Narrator**: "Vina thought for a moment." |
| `[413]` | **""That's your own fault. Why don't you find something to do?""** | `[208]` **Vina Toras**: ""Hectic for you, maybe. I'm bore..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[414]` **Vina Toras**: ""You mean between the ballgoing,..." |
| `[420]` | **""It's so beautiful it deserves to be shared.""** | `[406]` **Vina Toras**: ""It's beautiful here, isn't it? ..." | `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true` | *Brak zmian stanu* | `[424]` **Vina Toras**: ""It's what Queen Lyza would have..." |
| `[429]` | **""Don't even get me started on what your Aunt Bea calls them.""** | `[423]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[428]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[431]` | **""Yeah. That was a cheap shot.""** | `[423]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[428]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[432]` | **""She had an ear for a good pun.""** | `[423]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[428]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[433]` | **""Since who died?""** | `[31]` **Vina Toras**: ""Eight years since she died. Whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[434]` **Vina Toras**: ""Mother, obviously."" |
| `[435]` | **""I honestly don't think about it that often.""** | `[31]` **Vina Toras**: ""Eight years since she died. Whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[436]` **Vina Toras**: ""Lucky you."" |
| `[437]` | **""You almost died too that day, you know.""** | `[31]` **Vina Toras**: ""Eight years since she died. Whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[438]` **Vina Toras**: ""Sometimes I wish I had."" |
| `[439]` | **""Tell me about it. It hurts every time we come back here.""** | `[31]` **Vina Toras**: ""Eight years since she died. Whe..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[440]` **Vina Toras**: ""But we keep doing it anyway."" |
| `[441]` | **""Really? I'll remember that the next time I'm in Derdia.""** | `[212]` **Vina Toras**: ""By the way, did you know it's c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[445]` **Vina Toras**: ""Remember to tell them to treat ..." |
| `[442]` | **""What's a Duel of Generosity?""** | `[212]` **Vina Toras**: ""By the way, did you know it's c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[444]` **Vina Toras**: ""Some sort of welcome ceremony. ..." |
| `[443]` | **""See? Those classes aren't entirely useless.""** | `[212]` **Vina Toras**: ""By the way, did you know it's c..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[446]` **Vina Toras**: ""They are. Have you heard about ..." |
| `[449]` | **""What are you up to nowadays, Vina?""** | `[201]` **Vina Toras**: ""Why should we be an exception?""<br>`[203]` **Vina Toras**: ""You're probably right. I've rea..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[404]` **Vina Toras**: ""The usual. Ballgoing. Public ap..." |
| `[450]` | **""I was only following your late mother's wishes. Remember how she used to call the..."** | `[201]` **Vina Toras**: ""Why should we be an exception?""<br>`[203]` **Vina Toras**: ""You're probably right. I've rea..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[453]` **Vina Toras**: ""It's true. She would have been ..." |
| `[451]` | **""For now, let's just enjoy having this time and this beach to ourselves.""** | `[203]` **Vina Toras**: ""You're probably right. I've rea..."<br>`[402]` **Vina Toras**: ""They don't belong to everyone i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[452]` **Vina Toras**: ""Sure, Father. I don't mean to c..." |
| `[454]` | **""Do you agree with it? Should I have turned them down instead?""** | `[415]` **Vina Toras**: ""You just accepted that Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[458]` **Narrator**: "Vina thought for a moment." |
| `[455]` | **""That's right. I showed them who's in charge.""** | `[419]` **Vina Toras**: ""You just turned down the Sords'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[462]` **Vina Toras**: ""A Sordish resort on our shores!..." |
| `[456]` | **""Do you think I should have let them build it?""** | `[419]` **Vina Toras**: ""You just turned down the Sords'..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[463]` **Narrator**: "Vina thought for a moment." |
| `[457]` | **""Yes, and I'm proud of it. A beach as beautiful as this deserves to be shared.""** | `[415]` **Vina Toras**: ""You just accepted that Sordish ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[461]` **Vina Toras**: ""It's what Queen Lyza would have..." |
| `[466]` | **""Don't even get me started on what your Aunt Bea calls them.""** | `[460]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[465]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[468]` | **""Yeah. That was a cheap shot.""** | `[460]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[465]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[469]` | **""She had an ear for a good pun.""** | `[460]` **Vina Toras**: ""Mother would be rolling in her ..."<br>`[465]` **Vina Toras**: ""Mother would've rolled in her g..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "She picked up a lobster salad sa..." |
| `[478]` | **""Is it really revolution if we're still on the throne?""** | `[477]` **Vina Toras**: ""But in my opinion, if the peopl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[511]` **Vina Toras**: ""Why not? A good monarch adapts ..." |
| `[479]` | **""We Torases are not revolutionaries. We are keepers of tradition.""** | `[477]` **Vina Toras**: ""But in my opinion, if the peopl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[512]` **Vina Toras**: ""Why can't we be both?"" |
| `[484]` | **""All right. Keep reading it if that's what you really want.""** | `[385]` **Vina Toras**: ""You can't stop me from informin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[489]` **Vina Toras**: ""It is. And I will."" |
| `[486]` | **""I'm concerned for your safety. If you're going to harbor these sentiments, then b..."** | `[385]` **Vina Toras**: ""You can't stop me from informin..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[487]` **Vina Toras**: ""I will. You're the one who brou..." |
| `[491]` | **""The people who want revolution also want to see me dead.""** | `[477]` **Vina Toras**: ""But in my opinion, if the peopl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[513]` **Vina Toras**: ""Not if you're willing to change..." |
| `[492]` | **""No. But we can die trying.""** | `[476]` **Vina Toras**: ""But I agree that if the people ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[508]` **Vina Toras**: ""That doesn't sound very appeali..." |
| `[493]` | **""If that is truly what they want, I will not get in their way.""** | `[476]` **Vina Toras**: ""But I agree that if the people ..."<br>`[542]` **Vina Toras**: ""That's what you're worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[509]` **Vina Toras**: ""Neither will I."" |
| `[494]` | **""Don't tell me you're still reading Comrade Chavatangakwunua.""** | `[476]` **Vina Toras**: ""But I agree that if the people ..."<br>`[542]` **Vina Toras**: ""That's what you're worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[501]` **Vina Toras**: ""No thanks to you. I'm a grown w..."<br>`[502]` **Vina Toras**: ""Would you have me executed if I..."<br>*(oraz 1 innych odgałęzień)* |
| `[504]` | **""I am warning you, Vina. Stop filling your head with this nonsense.""** | `[501]` **Vina Toras**: ""No thanks to you. I'm a grown w..."<br>`[502]` **Vina Toras**: ""Would you have me executed if I..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable...` | `[517]` **Vina Toras**: ""But..."" |
| `[505]` | **""No need to get defensive. Keep reading it if that's what you really want.""** | `[501]` **Vina Toras**: ""No thanks to you. I'm a grown w..."<br>`[502]` **Vina Toras**: ""Would you have me executed if I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[515]` **Vina Toras**: ""It is, and I will."" |
| `[506]` | **""I'm concerned for your safety. If you're going to harbor these sentiments, then b..."** | `[501]` **Vina Toras**: ""No thanks to you. I'm a grown w..."<br>`[502]` **Vina Toras**: ""Would you have me executed if I..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[514]` **Vina Toras**: ""I will, I will. You're the one ..." |
| `[507]` | **""Give me a summary when you have the chance. I'm dying of curiosity.""** | `[503]` **Vina Toras**: ""Well... um, yes. He makes a lot..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[520]` **Vina Toras**: ""Sure thing, Father."" |
| `[534]` | **""It doesn't matter. You heard what I said to Hugo. It's time for House Toras to st..."** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..." | `Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[535]` **Vina Toras**: ""So you really mean it. You want..." |
| `[536]` | **""The future is unpredictable. Any one of the other royal houses could seize power ..."** | `[352]` **Vina Toras**: ""You mean..."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[538]` **Vina Toras**: ""Not if you neutralize the threa..."<br>`[549]` **Vina Toras**: ""It can't be that hard to keep t..."<br>*(oraz 1 innych odgałęzień)* |
| `[546]` | **""Just what are you implying, Vina?""** | `[542]` **Vina Toras**: ""That's what you're worried abou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[547]` **Vina Toras**: ""Nothing, Father. Can we go back..." |
| `[551]` | **""I don't know, Vina. If the situation ever arises, it will be a hard decision.""** | `[303]` **Vina Toras**: ""What if you had a son? Who woul..."<br>`[547]` **Vina Toras**: ""Nothing, Father. Can we go back..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC....` | `[553]` **Narrator**: "She folded her arms." |
| `[557]` | **""If you want agency, you can always take yourself out of the line of succession. I..."** | `[556]` **Vina Toras**: ""Sorry, Father. I do understand ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[559]` **Narrator**: "She made a face." |
| `[558]` | **""This is all completely hypothetical. Just assume that you're my successor and pre..."** | `[556]` **Vina Toras**: ""Sorry, Father. I do understand ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[561]` **Vina Toras**: ""Yes. That's what I've been doing."" |
| `[562]` | **""You're a future Duchess and a member of the Royal Council. That's already more po..."** | `[556]` **Vina Toras**: ""Sorry, Father. I do understand ..." | `Variable["RiziaDLC.Vina_OnCouncil"] == true` | *Brak zmian stanu* | `[566]` **Vina Toras**: ""You're right, of course. But yo..." |
| `[567]` | **""You're a future Duchess and a member of House Toras. That's already more power th..."** | `[556]` **Vina Toras**: ""Sorry, Father. I do understand ..." | `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false` | *Brak zmian stanu* | `[566]` **Vina Toras**: ""You're right, of course. But yo..." |

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
  - -> `[521]` (*Węzeł Logiki Narracyjnej: "PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");"*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was low tide. The waves of the Antacean Sea lapped at the sands below the cliffs of Monqiz."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "A trail was carved into the cliffside, just wide enough f..."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "A trail was carved into the cliffside, just wide enough for a single horse. Vina picked up speed as she guided her mare, Lizzie, around a sharp curve."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player_Romus: ""Vina! Slow down!""*)
  - -> `[6]` (*Player_Romus_Italic: "Go faster yourself."*)
  - -> `[12]` (*Player_Romus: ""Faster! Remember what I taught you!""*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina! Slow down!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "She glanced back at me for just long enough to roll her e..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "Go faster yourself."]** — Mówca: **Player_Romus_Italic**
> "I urged my own horse on. She balked at the steep drop, slowing us down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "Vina glanced back at me with a grin."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "She glanced back at me for just long enough to roll her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Vina Toras: ""Meet you at the beach!""*)

### Węzeł `[8]`
Mówca: **Vina Toras**
> ""Meet you at the beach!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "I watched her fly down the trail."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "Vina glanced back at me with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Vina Toras: ""Meet you at the beach!""*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I watched her fly down the trail."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "She'd thrown herself into horseback riding after Lena die..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "At the bottom of the trail was a sheltered cove where Pabel had laid out a picnic lunch. I dismounted and sat down next to Vina."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Vina Toras: ""You really didn't have to come back to Monqiz with me, F..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Faster! Remember what I taught you!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "She glanced back at me with a grin and gave the horse a s..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "She glanced back at me with a grin and gave the horse a swift kick in the side with her spurred boot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Vina Toras: ""Meet you at the beach!""*)

### Węzeł `[14]`
Mówca: **Vina Toras**
> ""You really didn't have to come back to Monqiz with me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[16]` (*Player_Romus: ""I'm grateful for the break. It's too hectic in Porte Dra..."*)
  - -> `[49]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to. It's been ages since we had time together.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Vina Toras: ""We could be spending time at Palas Rezna. If you'd let m..."*)

### Węzeł `[16]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm grateful for the break. It's too hectic in Porte Drazon.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[17]`
Mówca: **Vina Toras**
> ""We could be spending time at Palas Rezna. If you'd let me on the council, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Player_Romus: ""We already discussed this. What have you been doing inst..."*)
  - -> `[205]` (*Player_Romus: ""Trust me, it's nowhere near as exciting as you imagine.""*)
  - -> `[207]` (*Player_Romus: ""None of your backtalk. Let's just treasure what time we ..."*)

### Węzeł `[18]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[20]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[19]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player_Romus: ""I wanted to. Council meetings don't exactly count as qua..."*)

### Węzeł `[20]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player_Romus: ""I wanted to. It's been ages since we had time together.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wanted to. Council meetings don't exactly count as quality time together.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[22]`
Mówca: **Vina Toras**
> ""Deciding the fate of the country together? That screams quality time to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Player_Romus: ""I don't know how much we're deciding. Sometimes I feel l..."*)
  - -> `[197]` (*Player_Romus: ""My mother was right about a few things. It's not healthy..."*)
  - -> `[198]` (*Player_Romus: ""Keep up that enthusiasm. It will serve you well when you..."*)

### Węzeł `[23]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Vina Toras: ""Deciding the fate of the country together? That screams ..."*)

### Węzeł `[24]`
Mówca: **Vina Toras**
> ""I like the place. But I can't let Lizzie think I've forgotten about her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]` (*Narrator: "She reached up and gave her horse a pat on the nose."*)

### Węzeł `[25]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)
  - -> `[27]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 0)"*)

### Węzeł `[26]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Vina Toras: ""A Sordish resort in Monqiz! I can't believe you agreed t..."*)

### Węzeł `[27]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Vina Toras: ""Ah. I knew there was another reason.""*)

### Węzeł `[28]`
Mówca: **Vina Toras**
> ""A Sordish resort in Monqiz! I can't believe you agreed to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Player_Romus: ""What would you have done?""*)
  - -> `[214]` (*Player_Romus: ""They made me drink whiskey. It went to my head.""*)
  - -> `[215]` (*Player_Romus: ""Are you questioning my decision?""*)
  - -> `[218]` (*Player_Romus: ""It was the right diplomatic move. I'm sure of it.""*)

### Węzeł `[29]`
Mówca: **Vina Toras**
> ""Ah. I knew there was another reason.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Narrator: "My daughter fell silent."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "She picked up a lobster salad sandwich from the picnic basket and nibbled at it. A solemn silence descended as we stared out at the waves."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Vina Toras: ""Eight years since she died. When I'm here, it might as w..."*)

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""Eight years since she died. When I'm here, it might as well have been yesterday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]` (*Player_Romus: ""Since who died?""*)
  - -> `[435]` (*Player_Romus: ""I honestly don't think about it that often.""*)
  - -> `[437]` (*Player_Romus: ""You almost died too that day, you know.""*)
  - -> `[439]` (*Player_Romus: ""Tell me about it. It hurts every time we come back here.""*)

### Węzeł `[32]`
Mówca: **Vina Toras**
> ""I can't even dip my toe in the water, or it'll all come rushing back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]` (*Narrator: "I looked out at the sea again."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd still declare you next in line. Rizia needs a queen like you, and the rules were meant to be broken.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras), `[547]` (Vina Toras), `[550]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1; RiziaDLC.Vina_PromisedQueen..."*)

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He'd become my successor, of course. Those are the rules. But you'll still be a duchess.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras), `[547]` (Vina Toras), `[550]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1; RiziaDLC.Vina_WarnedPossibl..."*)

### Węzeł `[35]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[37]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[36]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player_Romus: ""You know what'll help blot out those memories? A big Sor..."*)

### Węzeł `[37]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know what'll help blot out those memories? A big Sordish resort, right on this spot.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[285]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Narrator: "She let out a sound that was half-laugh, half-sniffle."*)

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It'll get easier over time. It did for me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]` (*Narrator: "She cast a sidelong glance at me."*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Grief isn't a straight line, my daughter. It ebbs and flows like the tide.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[285]` (Vina Toras), `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Vina Toras: ""It's always high tide for me. And I'm not sure I even wa..."*)

### Węzeł `[41]`
Mówca: **Vina Toras**
> ""It's always high tide for me. And I'm not sure I even want to come up for air.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]` (*Narrator: "She wiped her eyes."*)

### Węzeł `[42]`
Mówca: **Vina Toras**
> ""But you must be feeling the same way about Mother. Otherwise, you would've remarried by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[43]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What makes you think our family will still hold power by the time I die?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]` (*Narrator: "Vina's eyes grew wide."*)

### Węzeł `[44]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1; RiziaDLC.Vina_PromisedQueen = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;
Variable["RiziaDLC.Vina_PromisedQueen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Narrator: "She smiled."*)

### Węzeł `[45]`
Mówca: **Vina Toras**
> ""But you're a man. As long as your wife's young enough, you could have another child at any age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "She sighed."*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1;
RiziaDLC.Vina_WarnedPossibleDisinheritance = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;
Variable["RiziaDLC.Vina_WarnedPossibleDisinheritance"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "She folded her arms."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "She folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[48]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[49]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[51]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[50]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Romus: ""I've got to do some glad-handing here anyway, before the..."*)

### Węzeł `[51]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player_Romus: ""I just wanted to relish the sight of this beautiful, Sor..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've got to do some glad-handing here anyway, before the Sordish invasion begins.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[14]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)

### Węzeł `[53]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I just wanted to relish the sight of this beautiful, Sord-free beach.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[14]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[54]`
Mówca: **Vina Toras**
> ""A Sordish resort in Monqiz! I can't believe they thought you'd go for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Player_Romus: ""And what would you have done?""*)
  - -> `[224]` (*Player_Romus: ""I may have made the wrong diplomatic move, but it felt r..."*)
  - -> `[226]` (*Player_Romus: ""They thought they could buy me with their greasy Sordish..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Vina Toras: ""A Sordish resort in Monqiz! I can't believe they thought..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Vina Toras: ""Don't you think that's a little elitist? Beaches should ..."*)

### Węzeł `[58]`
Mówca: **Vina Toras**
> ""Don't you think that's a little elitist? Beaches should belong to everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Player_Romus: ""Not our beach, though, right?""*)
  - -> `[202]` (*Player_Romus: ""A Marcel Koronti resort on these shores would attract th..."*)
  - -> `[204]` (*Player_Romus: ""Everyone in *Rizia*. The Sords have their own beaches.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't have anything to worry about. My childbearing days are over.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras), `[547]` (Vina Toras), `[550]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Vina Toras: ""But you're a man. As long as your wife's young enough, y..."*)

### Węzeł `[60]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[62]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[61]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Vina Toras: ""Like Queen Lyza said. The eldest sibling should inherit ..."*)

### Węzeł `[62]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Vina Toras: ""Then let's see how many rules I can break once I'm queen.""*)

### Węzeł `[63]`
Mówca: **Narrator**
> "She sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Vina Toras: ""Never mind.""*)

### Węzeł `[64]`
Mówca: **Vina Toras**
> ""Never mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[65]`
Mówca: **Vina Toras**
> ""Like Queen Lyza said. The eldest sibling should inherit the throne, no matter their sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]` (*Vina Toras: ""Thank you, Father. It means a lot to know all my prepara..."*)

### Węzeł `[66]`
Mówca: **Narrator**
> "The tide was beginning to lap at the edge of our blanket. We stood up and pulled it away from the water."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Vina Toras: ""Father? One more thing.""*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[69]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[68]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Vina Toras: ""But... Queen Lyza always said the eldest child should in..."*)

### Węzeł `[69]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Vina Toras: ""The rules are the rules, I get it. No use being queen if..."*)

### Węzeł `[70]`
Mówca: **Vina Toras**
> ""But... Queen Lyza always said the eldest child should inherit the throne. No matter their sex.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Vina Toras: ""Never mind. Who knows if it will even happen.""*)

### Węzeł `[71]`
Mówca: **Vina Toras**
> ""Then let's see how many rules I can break once I'm queen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[72]`
Mówca: **Vina Toras**
> ""The rules are the rules, I get it. No use being queen if the people don't want me, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "She uncrossed her arms again with a look of contrition."*)

### Węzeł `[73]`
Mówca: **Vina Toras**
> ""Never mind. Who knows if it will even happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "She uncrossed her arms again with a look of contrition."*)

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""Father? One more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player_Romus: ""I'm not hungry right now. I'll eat my sandwich when we g..."*)
  - -> `[75]` (*Player_Romus: ""What?""*)
  - -> `[305]` (*Player_Romus: ""Fine, you can bring Lizzie back to Porte Drazon. But you..."*)

### Węzeł `[75]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Vina Toras: ""It's just...""*)

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not hungry right now. I'll eat my sandwich when we get back to the palace.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Vina Toras: ""No, not that.""*)

### Węzeł `[77]`
Mówca: **Narrator**
> "She hopped astride Lizzie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]` (*Vina Toras: ""Sorry to run, but one of the countesses from my school d..."*)

### Węzeł `[78]`
Mówca: **Vina Toras**
> ""It's just...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""Grandmother is always on about how I need to find the ri..."*)

### Węzeł `[79]`
Mówca: **Vina Toras**
> ""No, not that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""Grandmother is always on about how I need to find the ri..."*)

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""Grandmother is always on about how I need to find the right husband.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Vina Toras: ""How important is it to you, really? Whom I marry?""*)

### Węzeł `[81]`
Mówca: **Vina Toras**
> ""How important is it to you, really? Whom I marry?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player_Romus: ""Why? Do you have any candidates in mind?""*)
  - -> `[86]` (*Player_Romus: ""You're a princess, Vina. Your marriage status matters no..."*)
  - -> `[85]` (*Player_Romus: ""I don't care whom you marry. As long as he's of noble bi..."*)
  - -> `[83]` (*Player_Romus: ""Don't listen to that hypocrite. Grandma followed her hea..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Do you have any candidates in mind?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Vina Toras: ""No, but do *you*? Are you going to marry me off, like yo..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't listen to that hypocrite. Grandma followed her heart, and so should you.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Vina Toras: ""So you won't try to marry me off. Like your father did t..."*)

### Węzeł `[84]`
Mówca: **Vina Toras**
> ""No, but do *you*? Are you going to marry me off, like your father did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""I'm still considering all the options.""*)
  - -> `[90]` (*Player_Romus: ""My arranged marriage was the best thing that ever happen..."*)
  - -> `[91]` (*Player_Romus: ""Absolutely not. Arranged marriage is a barbaric tradition.""*)

### Węzeł `[85]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't care whom you marry. As long as he's of noble birth, of course.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Vina Toras: ""So you're not planning to marry me off. Like your father..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a princess, Vina. Your marriage status matters not only to me, but to the whole country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[81]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Vina Toras: ""Does that mean you're planning to marry me off? Like you..."*)

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""Does that mean you're planning to marry me off? Like your father did to you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Player_Romus: ""I'm still considering all the options.""*)
  - -> `[98]` (*Player_Romus: ""And what if I am?""*)
  - -> `[90]` (*Player_Romus: ""My arranged marriage was the best thing that ever happen..."*)
  - -> `[91]` (*Player_Romus: ""Absolutely not. Arranged marriage is a barbaric tradition.""*)

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""So you're not planning to marry me off. Like your father did to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""Absolutely not. Arranged marriage is a barbaric tradition.""*)
  - -> `[111]` (*Player_Romus: ""I trust you to make the right decision. For yourself, an..."*)
  - -> `[97]` (*Player_Romus: ""I might suggest a potential husband or two. But I'll nev..."*)

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm still considering all the options.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Vina Toras), `[87]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "She fixed me with a stare."*)

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My arranged marriage was the best thing that ever happened to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Vina Toras), `[87]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "She fixed me with a stare."*)

### Węzeł `[91]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. Arranged marriage is a barbaric tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[84]` (Vina Toras), `[87]` (Vina Toras), `[88]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[92]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[94]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[93]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Vina Toras: ""You and Mother were lucky to fall in love. Most such mar..."*)

### Węzeł `[94]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Vina Toras: ""I wasn't blind and deaf growing up. I don't want to end ..."*)

### Węzeł `[95]`
Mówca: **Vina Toras**
> ""I wasn't blind and deaf growing up. I don't want to end up like you and Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""Think of it as yet another one of your royal obligations..."*)
  - -> `[105]` (*Player_Romus: ""You want to be queen? This is part of it. A single weddi..."*)
  - -> `[107]` (*Player_Romus: ""Whether or not I loved her, I did what I was ordered to ..."*)
  - -> `[106]` (*Player_Romus: ""Relax. I might suggest a potential husband or two, but I..."*)

### Węzeł `[96]`
Mówca: **Vina Toras**
> ""You and Mother were lucky to fall in love. Most such marriages are miserable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player_Romus: ""Think of it as yet another one of your royal obligations..."*)
  - -> `[105]` (*Player_Romus: ""You want to be queen? This is part of it. A single weddi..."*)
  - -> `[107]` (*Player_Romus: ""Whether or not I loved her, I did what I was ordered to ..."*)
  - -> `[106]` (*Player_Romus: ""Relax. I might suggest a potential husband or two, but I..."*)

### Węzeł `[97]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might suggest a potential husband or two. But I'll never drag you to the altar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Vina Toras), `[108]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She looked relieved."*)

### Węzeł `[98]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what if I am?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Narrator: "She fixed me with a stare."*)

### Węzeł `[99]`
Mówca: **Vina Toras**
> ""You and Mother were living proof of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Player_Romus: ""All because I didn't have the courage to speak to my fat..."*)
  - -> `[132]` (*Player_Romus: ""We both loved you. And we both swore you'd never go thro..."*)
  - -> `[133]` (*Player_Romus: ""I don't know what you're talking about.""*)

### Węzeł `[100]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[102]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[101]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Vina Toras: ""It worked out for you and Mother.""*)

### Węzeł `[102]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Vina Toras: ""You and Mother were living proof of that.""*)

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""It worked out for you and Mother.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Player_Romus: ""We were an exception.""*)
  - -> `[135]` (*Player_Romus: ""We made the best of the situation we'd been forced into.""*)
  - -> `[136]` (*Player_Romus: ""I still wish I'd had a choice. The least I can do is gra..."*)

### Węzeł `[104]`
Mówca: **Narrator**
> "She fixed me with a stare."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You want to be queen? This is part of it. A single wedding can accomplish more than a hundred political conferences.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Vina Toras), `[96]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Relax. I might suggest a potential husband or two, but I'll never drag you to the altar.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Vina Toras), `[96]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Narrator: "She looked relieved."*)

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Whether or not I loved her, I did what I was ordered to do. As you will when the day comes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Vina Toras), `[96]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[108]`
Mówca: **Vina Toras**
> ""So you won't try to marry me off. Like your father did to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player_Romus: ""Absolutely not. Arranged marriage is a barbaric tradition.""*)
  - -> `[111]` (*Player_Romus: ""I trust you to make the right decision. For yourself, an..."*)
  - -> `[97]` (*Player_Romus: ""I might suggest a potential husband or two. But I'll nev..."*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "She mulled over my words for a moment."*)

### Węzeł `[110]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Think of it as yet another one of your royal obligations. You can always take a lover on the side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[95]` (Vina Toras), `[96]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)

### Węzeł `[111]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I trust you to make the right decision. For yourself, and for Rizia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Vina Toras), `[108]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_HadAffairs == true"*)
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_HadAffairs == true)"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_HadAffairs == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_HadAffairs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Narrator: "She regarded me coolly for a moment."*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_HadAffairs == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_HadAffairs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "She mulled over my words for a moment."*)

### Węzeł `[115]`
Mówca: **Narrator**
> "She regarded me coolly for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""I appreciate your honesty. I do know we royals must make..."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "She mulled over my words for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Vina Toras: ""I appreciate your honesty. I do know we royals must make..."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Narrator: "She seemed to shrink a little."*)

### Węzeł `[118]`
Mówca: **Narrator**
> "She looked relieved."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)

### Węzeł `[119]`
Mówca: **Vina Toras**
> ""I'm interested in hearing these suggestions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[120]`
Mówca: **Vina Toras**
> ""That's the least I could ask of you. But good to know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 0)"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Vina Toras: ""I'm interested in hearing these suggestions.""*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Vina Toras: ""That's the least I could ask of you. But good to know.""*)

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We were an exception.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "She nodded."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Vina Toras: ""Let's hope that my heart and Rizia's needs align.""*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Her expression was hard to read."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Vina Toras: ""Let's hope that my heart and Rizia's needs align.""*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina > 0"*)
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina > 0)"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "She smiled."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Her expression was hard to read."*)

### Węzeł `[130]`
Mówca: **Vina Toras**
> ""Let's hope that my heart and Rizia's needs align.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""I appreciate your honesty. I do know we royals must make compromises in our personal lives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She hopped astride Lizzie."*)

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We both loved you. And we both swore you'd never go through the same hell we did.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[133]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know what you're talking about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Narrator: "She regarded me coolly for a second."*)

### Węzeł `[134]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All because I didn't have the courage to speak to my father as an equal. You're braver than I was.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[99]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We made the best of the situation we'd been forced into.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Narrator: "She nodded."*)

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still wish I'd had a choice. The least I can do is grant you one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[137]`
Mówca: **Narrator**
> "She nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Vina Toras: ""I hope someday I can have what you two had. Arranged or ..."*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "She smiled."*)

### Węzeł `[139]`
Mówca: **Vina Toras**
> ""That means a lot, Father. And it's a decision I won't take lightly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[140]`
Mówca: **Narrator**
> "She regarded me coolly for a second."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Vina Toras: ""I wasn't deaf or blind as a child, you know. I'm happy I..."*)

### Węzeł `[141]`
Mówca: **Vina Toras**
> ""I wasn't deaf or blind as a child, you know. I'm happy I won't have to subject my own to the same fate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""I hope someday I can have what you two had. Arranged or otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true"*)

### Węzeł `[143]`
Mówca: **Narrator**
> "I staggered through the doorway of Palas Monqiz, exhausted. Pabel swiftly took my coat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Pabel Adria: ""I remember a certain Romus Toras being quite the rider h..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Pabel Adria: ""I heard you used to be quite the rider yourself.""*)

### Węzeł `[147]`
Mówca: **Pabel Adria**
> ""Welcome back, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Pabel Adria: ""Where is the princess?""*)

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's too fast for her old man.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's visiting with a friend, but she wanted to thank you for lunch.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Pabel Adria: ""Monqiz lobster. It's never so sweet as when it's fresh o..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""In another castle. I let her go out, against my better judgement.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[343]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)

### Węzeł `[151]`
Mówca: **Pabel Adria**
> ""I remember a certain Romus Toras being quite the rider himself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Pabel Adria: ""There's a warm bath waiting for you upstairs, in case yo..."*)

### Węzeł `[152]`
Mówca: **Pabel Adria**
> ""I heard you used to be quite the rider yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Pabel Adria: ""There's a warm bath waiting for you upstairs, in case yo..."*)

### Węzeł `[153]`
Mówca: **Pabel Adria**
> ""Monqiz lobster. It's never so sweet as when it's fresh out of the water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Pabel Adria: ""There's a warm bath waiting for you upstairs, in case yo..."*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Relations_PabelFriend == true"*)
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Relations_PabelFriend == true)"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Relations_PabelFriend == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Pabel Adria: ""She's more than old enough to go out alone. You can't pr..."*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Relations_PabelFriend == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Pabel Adria: ""Any daughter of King Romus is bound to have a strong will.""*)

### Węzeł `[157]`
Mówca: **Pabel Adria**
> ""She's more than old enough to go out alone. You can't protect her from everything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Pabel Adria: ""There's a warm bath waiting for you upstairs, in case yo..."*)

### Węzeł `[158]`
Mówca: **Pabel Adria**
> ""Any daughter of King Romus is bound to have a strong will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]` (*Pabel Adria: ""There's a warm bath waiting for you upstairs, in case yo..."*)

### Węzeł `[159]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You read my mind, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Pabel Adria: ""All part of the job.""*)

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not sore at all. But a bath sounds good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Pabel Adria: ""Let me know if you need anything else.""*)

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Only if it's got bubbles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[344]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Pabel Adria: ""Is there any other kind of bath?""*)

### Węzeł `[162]`
Mówca: **Pabel Adria**
> ""All part of the job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I made my way to Palas Monqiz's master bathroom, where an..."*)

### Węzeł `[163]`
Mówca: **Pabel Adria**
> ""Let me know if you need anything else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I made my way to Palas Monqiz's master bathroom, where an..."*)

### Węzeł `[164]`
Mówca: **Pabel Adria**
> ""Is there any other kind of bath?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Narrator: "I made my way to Palas Monqiz's master bathroom, where an..."*)

### Węzeł `[165]`
Mówca: **Narrator**
> "I made my way to Palas Monqiz's master bathroom, where an enormous clawfoot tub was filled to the brim with soapy, eucalyptus-scented water. I undressed and got in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player_Romus_Italic: "Scrub your right arm."*)
  - -> `[167]` (*Player_Romus_Italic: "Scrub your left arm."*)
  - -> `[168]` (*Player_Romus_Italic: "Scrub your right leg."*)
  - -> `[169]` (*Player_Romus_Italic: "Scrub your left leg."*)

### Węzeł `[166]`
**[WYBÓR GRACZA: "Scrub your right arm."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my right arm. The temperature was perfect."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A tap came at the door, so soft I thought I was imagining..."*)

### Węzeł `[167]`
**[WYBÓR GRACZA: "Scrub your left arm."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my left arm. The temperature was perfect."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A tap came at the door, so soft I thought I was imagining..."*)

### Węzeł `[168]`
**[WYBÓR GRACZA: "Scrub your right leg."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my right leg. The temperature was perfect."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A tap came at the door, so soft I thought I was imagining..."*)

### Węzeł `[169]`
**[WYBÓR GRACZA: "Scrub your left leg."]** — Mówca: **Player_Romus_Italic**
> "I scrubbed my left leg. The temperature was perfect."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[165]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "A tap came at the door, so soft I thought I was imagining..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "A tap came at the door, so soft I thought I was imagining it at first."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[171]`
Mówca: **Pabel Adria**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""Not now. Go away.""*)
  - -> `[177]` (*Player_Romus: ""Yes?""*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Pabel Adria: ""Your Majesty?""*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Pabel Adria: ""Romus?""*)

### Węzeł `[175]`
Mówca: **Pabel Adria**
> ""Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Player_Romus: ""Not now. Go away.""*)
  - -> `[177]` (*Player_Romus: ""Yes?""*)

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not now. Go away.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria), `[175]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Pabel Adria: ""I'll just be a second. I forgot to leave you a towel.""*)

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[171]` (Pabel Adria), `[175]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]` (*Pabel Adria: ""May I come in? I forgot to leave you a towel.""*)

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""I'll just be a second. I forgot to leave you a towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player_Romus: ""Don't you have anything better to do? Stop bothering me.""*)
  - -> `[179]` (*Player_Romus: ""All right. Come in.""*)
  - -> `[346]` (*Player_Romus: ""It's not important. I'll dry off without one.""*)

### Węzeł `[179]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Come in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[345]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you have anything better to do? Stop bothering me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[345]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[181]`
Mówca: **Pabel Adria**
> ""Very well. Have a nice bath, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I heard his footsteps receding in the hallway."*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)

### Węzeł `[183]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[185]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[184]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Pabel Adria: ""Very well. Have a nice bath, Your Majesty.""*)

### Węzeł `[185]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Pabel Adria: ""Very well. Have a nice bath.""*)

### Węzeł `[186]`
Mówca: **Pabel Adria**
> ""Very well. Have a nice bath.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Narrator: "I heard his footsteps receding in the hallway."*)

### Węzeł `[187]`
Mówca: **Narrator**
> "After a thorough soak, I dressed and headed to my study. I still had some work to go over before the trip back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep = ..."*)

### Węzeł `[188]`
Mówca: **Narrator**
> "I heard his footsteps receding in the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[189]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Vina Toras: ""That means a lot, Father. And it's a decision I won't ta..."*)

### Węzeł `[190]`
Mówca: **Narrator**
> "She seemed to shrink a little."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Vina Toras: ""Whatever you say, Father. I should be going now.""*)

### Węzeł `[191]`
Mówca: **Vina Toras**
> ""Whatever you say, Father. I should be going now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She hopped astride Lizzie."*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina_PromisedNoArrangedMarriage"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She hopped astride Lizzie."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "She'd thrown herself into horseback riding after Lena died. We kept a few horses in Porte Drazon as well, but Lizzie was her favorite."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "I followed her at a leisurely pace, taking time to gaze b..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "I followed her at a leisurely pace, taking time to gaze back up the hill at Palas Monqiz. With Hubertus Toras governing the province from his own estate, I was free to visit my old home and its private beach anytime I liked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "At the bottom of the trail was a sheltered cove where Pab..."*)

### Węzeł `[195]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We already discussed this. What have you been doing instead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Vina Toras: ""The usual. Ballgoing. Public appearances. Grandmother en..."*)

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know how much we're deciding. Sometimes I feel like it's out of any of our hands.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[197]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""My mother was right about a few things. It's not healthy to spend too long in those chambers.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[198]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep up that enthusiasm. It will serve you well when you're older.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[22]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[199]`
Mówca: **Vina Toras**
> ""The usual. Ballgoing. Public appearances. Grandmother enrolled me in an advanced etiquette class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Vina Toras: ""By the way, did you know it's considered polite to inten..."*)

### Węzeł `[200]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not our beach, though, right?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Vina Toras: ""Why should we be an exception?""*)

### Węzeł `[201]`
Mówca: **Vina Toras**
> ""Why should we be an exception?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""What are you up to nowadays, Vina?""*)
  - -> `[450]` (*Player_Romus: ""I was only following your late mother's wishes. Remember..."*)

### Węzeł `[202]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Marcel Koronti resort on these shores would attract the worst kind of elitist. Trust me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Vina Toras: ""You're probably right. I've read about him and his horri..."*)

### Węzeł `[203]`
Mówca: **Vina Toras**
> ""You're probably right. I've read about him and his horrible father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""What are you up to nowadays, Vina?""*)
  - -> `[450]` (*Player_Romus: ""I was only following your late mother's wishes. Remember..."*)
  - -> `[451]` (*Player_Romus: ""For now, let's just enjoy having this time and this beac..."*)

### Węzeł `[204]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Everyone in *Rizia*. The Sords have their own beaches.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[58]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]` (*Vina Toras: ""They don't belong to everyone in Rizia, though, do they?..."*)

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Trust me, it's nowhere near as exciting as you imagine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Vina Toras: ""I'm sure it's more exciting than the etiquette class Gra..."*)

### Węzeł `[206]`
Mówca: **Vina Toras**
> ""I'm sure it's more exciting than the etiquette class Grandmother made me start taking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Vina Toras: ""By the way, did you know it's considered polite to inten..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""None of your backtalk. Let's just treasure what time we have.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1"*)

### Węzeł `[208]`
Mówca: **Vina Toras**
> ""Hectic for you, maybe. I'm bored to tears.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]` (*Player_Romus: ""What have you been doing these days, anyway?""*)
  - -> `[413]` (*Player_Romus: ""That's your own fault. Why don't you find something to do?""*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Vina Toras: ""I like the place. But I can't let Lizzie think I've forg..."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Vina Toras: ""Hectic for you, maybe. I'm bored to tears.""*)

### Węzeł `[212]`
Mówca: **Vina Toras**
> ""By the way, did you know it's considered polite to intentionally lose a Derdian Duel of Generosity?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]` (*Player_Romus: ""Really? I'll remember that the next time I'm in Derdia.""*)
  - -> `[442]` (*Player_Romus: ""What's a Duel of Generosity?""*)
  - -> `[443]` (*Player_Romus: ""See? Those classes aren't entirely useless.""*)
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[213]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What would you have done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "She considered it seriously."*)

### Węzeł `[214]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They made me drink whiskey. It went to my head.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Vina Toras: ""No need to make excuses, Father. A King stands by his de..."*)

### Węzeł `[215]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are you questioning my decision?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Vina Toras: ""Not at all, Father. I'm sure you had your reasons.""*)

### Węzeł `[216]`
Mówca: **Narrator**
> "She considered it seriously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Vina Toras: ""Honestly... I probably would have let them have it. Lyza..."*)

### Węzeł `[217]`
Mówca: **Vina Toras**
> ""Honestly... I probably would have let them have it. Lyza knew how valuable it was to be close to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[218]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the right diplomatic move. I'm sure of it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[28]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Vina Toras: ""I'll miss the unobstructed views, though.""*)

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And what would you have done?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Narrator: "She considered it seriously."*)

### Węzeł `[220]`
Mówca: **Narrator**
> "My daughter fell silent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[221]`
Mówca: **Vina Toras**
> ""Not at all, Father. I'm sure you had your reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[222]`
Mówca: **Vina Toras**
> ""No need to make excuses, Father. A King stands by his decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[223]`
Mówca: **Vina Toras**
> ""I'll miss the unobstructed views, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I may have made the wrong diplomatic move, but it felt right in my heart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]` (*Vina Toras: ""No need to make excuses, Father. A King stands by his de..."*)

### Węzeł `[225]`
Mówca: **Vina Toras**
> ""No need to make excuses, Father. A King stands by his decisions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[226]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They thought they could buy me with their greasy Sordish ren. I showed them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[54]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Vina Toras: ""I'm sure you did, Father.""*)

### Węzeł `[227]`
Mówca: **Vina Toras**
> ""I'm sure you did, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[228]`
Mówca: **Narrator**
> "I looked out at the sea again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Player_Romus_Italic: "Try not to think about it."*)
  - -> `[233]` (*Player_Romus_Italic: "Let yourself remember."*)

### Węzeł `[229]`
Mówca: **Narrator**
> "But they were too strong."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "The sickening sound the boat had made as its girders spli..."*)

### Węzeł `[230]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prol..."*)
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Pr..."*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true  and  Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "But they were too strong."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true  and  Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "It was just an ocean. A big, impartial ocean."*)

### Węzeł `[233]`
**[WYBÓR GRACZA: "Let yourself remember."]** — Mówca: **Player_Romus_Italic**
> "The memories rushed over me."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)

### Węzeł `[234]`
**[WYBÓR GRACZA: "Try not to think about it."]** — Mówca: **Player_Romus_Italic**
> "I consciously tried to repress my memories."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[228]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true && RiziaDLC.Prol..."*)

### Węzeł `[235]`
Mówca: **Narrator**
> "The sickening sound the boat had made as its girders splintered. Calling out for my wife, over and over, until my voice finally gave out. The beep of the hospital machines as I told Vina to say goodbye to her mother one last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Narrator: "Was there anything I could have done to save her? In anot..."*)

### Węzeł `[236]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_InBoatAccident == true"*)
  - -> `[238]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_InBoatAccident == true )"*)

### Węzeł `[237]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_InBoatAccident == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_InBoatAccident"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[238]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_InBoatAccident == true )`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_InBoatAccident"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[239]`
Mówca: **Narrator**
> "Tears formed at the corners of my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Player_Romus_Italic: "Don't cry."*)
  - -> `[240]` (*Player_Romus_Italic: "Don't resist."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[240]`
**[WYBÓR GRACZA: "Don't resist."]** — Mówca: **Player_Romus_Italic**
> "I started sobbing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[241]`
Mówca: **Narrator**
> "The sickening sound the boat had made as its girders splintered. Vina calling out for her mother, over and over, until her voice finally gave out. My daughter's eyes as I told her she would never see Lena again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Worst of all: the secret relief I felt when the hospital ..."*)

### Węzeł `[242]`
Mówca: **Narrator**
> "It was just an ocean. A big, impartial ocean."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[39]` (*Player_Romus: ""It'll get easier over time. It did for me.""*)
  - -> `[40]` (*Player_Romus: ""Grief isn't a straight line, my daughter. It ebbs and fl..."*)
  - -> `[267]` (*Player_Romus: ""We've got to move forward. Lena wouldn't have wanted us ..."*)

### Węzeł `[243]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[245]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[244]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Narrator: "The break in the coast guard's voice as he told me the ne..."*)

### Węzeł `[245]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]` (*Narrator: "The break in the coast guard's voice as he told me the ne..."*)

### Węzeł `[246]`
Mówca: **Narrator**
> "The break in the coast guard's voice as he told me the news. The hospital staff muttering meaningless reassurances. The beep of the ventilator as my wife slipped in and out of consciousness."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]` (*Narrator: "If I had been on that boat, would things have gone differ..."*)

### Węzeł `[247]`
**[WYBÓR GRACZA: "Don't cry."]** — Mówca: **Player_Romus_Italic**
> "I took a second to regain my composure."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[239]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "It was just an ocean. A big, impartial ocean."*)

### Węzeł `[248]`
Mówca: **Narrator**
> "Was there anything I could have done to save her? In another timeline, were there three of us sitting on this beach instead of two?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Tears formed at the corners of my eyes."*)

### Węzeł `[249]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[251]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[250]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]` (*Narrator: "The sickening sound the boat had made as its girders spli..."*)

### Węzeł `[251]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Narrator: "The sickening sound the boat had made as its girders spli..."*)

### Węzeł `[252]`
Mówca: **Narrator**
> "The break in the coast guard's voice as he told me the news. The hospital staff muttering meaningless reassurances. My daughter's eyes as I told her she would never see her mother again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Narrator: "Worst of all: the secret relief I felt when the hospital ..."*)

### Węzeł `[253]`
Mówca: **Narrator**
> "If I had been on that boat, would things have gone differently? In another timeline, were there three of us sitting on this beach instead of two?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Narrator: "Tears formed at the corners of my eyes."*)

### Węzeł `[254]`
Mówca: **Narrator**
> "Worst of all: the secret relief I felt when the hospital ventilator beeped for the last time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Player_Romus_Italic: "Cry."*)
  - -> `[256]` (*Player_Romus_Italic: "Keep your cool."*)
  - -> `[257]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)

### Węzeł `[255]`
**[WYBÓR GRACZA: "Cry."]** — Mówca: **Player_Romus_Italic**
> "A man in my position would be crying. I forced out a few tears."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[256]`
**[WYBÓR GRACZA: "Keep your cool."]** — Mówca: **Player_Romus_Italic**
> "I kept staring out at the water, my eyes dry."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Narrator: "It was just an ocean. A big, impartial ocean."*)

### Węzeł `[257]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_Religious == true"*)
  - -> `[259]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_Religious == true)"*)

### Węzeł `[258]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_Religious == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Player_Romus_Italic: "Pray."*)

### Węzeł `[259]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_Religious == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Religious"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[260]`
**[WYBÓR GRACZA: "Pray."]** — Mówca: **Player_Romus_Italic**
> "I muttered a prayer."
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Prologue_Religious"] == true`
- **Kontekst wejściowy (poprzednik):** `[239]` (Narrator), `[254]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]` (*Narrator: "My daughter didn't join me, but maintained a respectful s..."*)

### Węzeł `[261]`
Mówca: **Narrator**
> "She cast a sidelong glance at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Vina Toras: ""Did it?""*)

### Węzeł `[262]`
Mówca: **Vina Toras**
> ""Did it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Vina Toras: ""Then why haven't you remarried? You must know it's unusu..."*)

### Węzeł `[263]`
Mówca: **Narrator**
> "She let out a sound that was half-laugh, half-sniffle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Vina Toras: ""If you're so keen to forget her, why haven't you remarri..."*)

### Węzeł `[264]`
Mówca: **Vina Toras**
> ""Then why haven't you remarried? You must know it's unusual for a king to stay a widower for so long.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[265]`
Mówca: **Vina Toras**
> ""If you're so keen to forget her, why haven't you remarried?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[266]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Vina Toras: ""But you must be feeling the same way about Mother. Other..."*)

### Węzeł `[267]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We've got to move forward. Lena wouldn't have wanted us to stay in mourning for so long.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Narrator), `[285]` (Vina Toras), `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]` (*Vina Toras: ""Maybe not. But I can't help it.""*)

### Węzeł `[268]`
Mówca: **Vina Toras**
> ""Are you... are you thinking of moving forward, Father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[269]`
Mówca: **Vina Toras**
> ""Eight years and not so much as a date.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]` (*Player_Romus: ""Don't be naive. I've had dates. Just nobody worth tellin..."*)
  - -> `[272]` (*Player_Romus: ""It feels useless to try. I'll never love anyone else as ..."*)
  - -> `[273]` (*Player_Romus: ""Looking after you has been my number-one priority.""*)
  - -> `[271]` (*Player_Romus: ""What's with the sudden interest in my love life?""*)

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't be naive. I've had dates. Just nobody worth telling you about.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]` (*Vina Toras: ""Oh.""*)

### Węzeł `[271]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's with the sudden interest in my love life?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]` (*Vina Toras: ""Well...""*)

### Węzeł `[272]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It feels useless to try. I'll never love anyone else as much as I loved your mother.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Looking after you has been my number-one priority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[269]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]` (*Vina Toras: ""You can't use that as an excuse for much longer.""*)

### Węzeł `[274]`
Mówca: **Narrator**
> "Vina looked unconvinced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Vina Toras: ""But... if you *were* to meet someone...""*)

### Węzeł `[275]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Prologue_LovedWife == true"*)
  - -> `[277]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Prologue_LovedWife == true)"*)

### Węzeł `[276]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Prologue_LovedWife == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Prologue_LovedWife"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]` (*Narrator: "Vina looked unconvinced."*)

### Węzeł `[277]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Prologue_LovedWife == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Prologue_LovedWife"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]` (*Narrator: "Vina gave me a small smile."*)

### Węzeł `[278]`
Mówca: **Narrator**
> "Vina gave me a small smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]` (*Vina Toras: ""But... if you *were* to meet someone...""*)

### Węzeł `[279]`
Mówca: **Vina Toras**
> ""Oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]` (*Narrator: "Her face went through a few different expressions as she ..."*)

### Węzeł `[280]`
Mówca: **Narrator**
> "Her face went through a few different expressions as she quietly processed this information."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]` (*Vina Toras: ""But then... if you *were* to meet someone...""*)

### Węzeł `[281]`
Mówca: **Vina Toras**
> ""You can't use that as an excuse for much longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]` (*Narrator: "She nervously picked up a handful of sand and let it run ..."*)

### Węzeł `[282]`
Mówca: **Vina Toras**
> ""Well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]` (*Narrator: "She nervously picked up a handful of sand and let it run ..."*)

### Węzeł `[283]`
Mówca: **Narrator**
> "She nervously picked up a handful of sand and let it run through her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]` (*Vina Toras: ""Say you *were* to meet someone...""*)

### Węzeł `[284]`
Mówca: **Narrator**
> "Vina appeared at a loss for words. She tentatively put a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]` (*Vina Toras: ""I'm sorry, Father. I didn't realize it was still so fres..."*)

### Węzeł `[285]`
Mówca: **Vina Toras**
> ""I'm sorry, Father. I didn't realize it was still so fresh for you as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[40]` (*Player_Romus: ""Grief isn't a straight line, my daughter. It ebbs and fl..."*)
  - -> `[267]` (*Player_Romus: ""We've got to move forward. Lena wouldn't have wanted us ..."*)
  - -> `[289]` (*Player_Romus: ""I miss her so much.""*)

### Węzeł `[286]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]` (*Narrator: "Vina appeared at a loss for words. She tentatively put a ..."*)

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's in a better place now, Vina. As you and I will be one day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[288]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]` (*Vina Toras: ""But what happens until then? We're just supposed to keep..."*)

### Węzeł `[288]`
Mówca: **Narrator**
> "My daughter didn't join me, but maintained a respectful silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player_Romus: ""It'll get easier over time. It did for me.""*)
  - -> `[40]` (*Player_Romus: ""Grief isn't a straight line, my daughter. It ebbs and fl..."*)
  - -> `[267]` (*Player_Romus: ""We've got to move forward. Lena wouldn't have wanted us ..."*)
  - -> `[287]` (*Player_Romus: ""She's in a better place now, Vina. As you and I will be ..."*)

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I miss her so much.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[285]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]` (*Vina Toras: ""Me too. But it's got to get easier sometime, right?""*)

### Węzeł `[290]`
Mówca: **Vina Toras**
> ""Me too. But it's got to get easier sometime, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]` (*Narrator: "She wiped her eyes."*)

### Węzeł `[291]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]` (*Vina Toras: ""And you can't stay a widower forever.""*)

### Węzeł `[292]`
Mówca: **Vina Toras**
> ""Maybe not. But I can't help it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]` (*Narrator: "She wiped her eyes."*)

### Węzeł `[293]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Vina Toras: ""Are you... are you thinking of moving forward, Father?""*)

### Węzeł `[294]`
Mówca: **Vina Toras**
> ""And you can't stay a widower forever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[295]`
Mówca: **Vina Toras**
> ""But what happens until then? We're just supposed to keep going like nothing happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]` (*Narrator: "She wiped her eyes."*)

### Węzeł `[296]`
Mówca: **Narrator**
> "She wiped her eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]` (*Vina Toras: ""I mean, look at you, Father.""*)

### Węzeł `[297]`
Mówca: **Vina Toras**
> ""I mean, look at you, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]` (*Vina Toras: ""Eight years and not so much as a date.""*)

### Węzeł `[298]`
Mówca: **Vina Toras**
> ""But then... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Vina Toras: ""What if you had a son? Who would be your successor when ..."*)

### Węzeł `[299]`
Mówca: **Vina Toras**
> ""But... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Vina Toras: ""What if you had a son? Who would be your successor when ..."*)

### Węzeł `[300]`
Mówca: **Vina Toras**
> ""Say you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Vina Toras: ""What if you had a son? Who would be your successor when ..."*)

### Węzeł `[301]`
Mówca: **Narrator**
> "She nervously picked up a handful of sand and let it run through her fingers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]` (*Vina Toras: ""So... if you *were* to meet someone...""*)

### Węzeł `[302]`
Mówca: **Vina Toras**
> ""So... if you *were* to meet someone...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]` (*Vina Toras: ""What if you had a son? Who would be your successor when ..."*)

### Węzeł `[303]`
Mówca: **Vina Toras**
> ""What if you had a son? Who would be your successor when you died?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo..."*)
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "Vina Succession Answers"*)

### Węzeł `[304]`
Mówca: **Vina Toras**
> ""Thank you, Father. It means a lot to know all my preparation won't be for nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[305]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Fine, you can bring Lizzie back to Porte Drazon. But you'll have to get rid of one of your other horses to make room in the stables.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[74]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]` (*Vina Toras: ""Oh, that'd be grand! But I wanted to ask something else.""*)

### Węzeł `[306]`
Mówca: **Vina Toras**
> ""Oh, that'd be grand! But I wanted to ask something else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Vina Toras: ""Grandmother is always on about how I need to find the ri..."*)

### Węzeł `[307]`
Mówca: **Vina Toras**
> ""Sorry to run, but one of the countesses from my school days has invited me for tea. She's just a few estates down the beach from here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]` (*Player_Romus: ""But I thought we'd be spending the whole visit together.""*)
  - -> `[309]` (*Player_Romus: ""Have fun. I'm glad we were able to talk.""*)
  - -> `[318]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[310]` (*Player_Romus: ""Titus! Send one of your men to keep an eye on her?""*)

### Węzeł `[308]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""But I thought we'd be spending the whole visit together.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[309]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have fun. I'm glad we were able to talk.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[310]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Titus! Send one of your men to keep an eye on her?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[307]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]` (*Narrator: "My guard appeared from behind a rock."*)

### Węzeł `[311]`
Mówca: **Narrator**
> "My guard appeared from behind a rock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]` (*Titus Gordion: ""Sure thing, Your Majesty.""*)

### Węzeł `[312]`
Mówca: **Titus Gordion**
> ""Sure thing, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]` (*Vina Toras: ""I won't get into trouble. But I understand the need for ..."*)

### Węzeł `[313]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[315]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[314]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]` (*Vina Toras: ""I've spent enough time with you, I think.""*)

### Węzeł `[315]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]` (*Vina Toras: ""Don't worry. I'll be back before supper.""*)

### Węzeł `[316]`
Mówca: **Vina Toras**
> ""I've spent enough time with you, I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]` (*Narrator: "She rode away before I could think of a comeback."*)

### Węzeł `[317]`
Mówca: **Vina Toras**
> ""Don't worry. I'll be back before supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[318]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[320]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[319]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]` (*Player_Romus: ""Try and gauge her reaction to the Sordish resort idea, w..."*)

### Węzeł `[320]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[321]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Try and gauge her reaction to the Sordish resort idea, will you?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[307]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)

### Węzeł `[322]`
Mówca: **Narrator**
> "She rode away before I could think of a comeback."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Titus G..."*)

### Węzeł `[323]`
Mówca: **Narrator**
> "She rode away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Vina Toras"); RemoveConversant("Titus G..."*)

### Węzeł `[324]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[326]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[325]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]` (*Vina Toras: ""Yes, it was *very* enlightening.""*)

### Węzeł `[326]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]` (*Vina Toras: ""So am I.""*)

### Węzeł `[327]`
Mówca: **Vina Toras**
> ""So am I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[328]`
Mówca: **Vina Toras**
> ""Yes, it was *very* enlightening.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[329]`
Mówca: **Vina Toras**
> ""I won't get into trouble. But I understand the need for protocol.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[330]`
Mówca: **Vina Toras**
> ""No need. I already know her family hates it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[331]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina < 0"*)
  - -> `[333]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina < 0)"*)

### Węzeł `[332]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina < 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]` (*Vina Toras: ""No need. I already know her family hates it.""*)

### Węzeł `[333]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina < 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]` (*Vina Toras: ""I already know her family hates it. But I'll try to sway..."*)

### Węzeł `[334]`
Mówca: **Vina Toras**
> ""I already know her family hates it. But I'll try to sway them for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]` (*Narrator: "She rode away."*)

### Węzeł `[335]`
Mówca: **Narrator**
> "The trip back up to the palace felt a lot longer than the way down. It was dusk by the time I'd returned my horse to the stables."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "I staggered through the doorway of Palas Monqiz, exhauste..."*)

### Węzeł `[336]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Vina Toras");
RemoveConversant("Titus Gordion");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Vina Toras");
RemoveConversant("Titus Gordion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]` (*Narrator: "The trip back up to the palace felt a lot longer than the..."*)

### Węzeł `[337]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RemoveConversant("Pabel Adria");`
- **Efekt skryptowy (`userScript`):** `RemoveConversant("Pabel Adria");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Narrator: "After a thorough soak, I dressed and headed to my study. ..."*)

### Węzeł `[338]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_Zille_FriendshipDayPrep"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == ..."*)

### Węzeł `[339]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel_YourMajesty == true"*)
  - -> `[341]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Pabel_YourMajesty == true)"*)

### Węzeł `[340]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Pabel_YourMajesty == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Pabel Adria: ""Welcome back, Your Majesty.""*)

### Węzeł `[341]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Pabel_YourMajesty == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]` (*Pabel Adria: ""Back so soon? I hope I packed enough food for you.""*)

### Węzeł `[342]`
Mówca: **Pabel Adria**
> ""Back so soon? I hope I packed enough food for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]` (*Pabel Adria: ""Where is the princess?""*)

### Węzeł `[343]`
Mówca: **Pabel Adria**
> ""Where is the princess?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Player_Romus: ""She's too fast for her old man.""*)
  - -> `[149]` (*Player_Romus: ""She's visiting with a friend, but she wanted to thank yo..."*)
  - -> `[150]` (*Player_Romus: ""In another castle. I let her go out, against my better j..."*)

### Węzeł `[344]`
Mówca: **Pabel Adria**
> ""There's a warm bath waiting for you upstairs, in case you're sore from the ride.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Player_Romus: ""You read my mind, Pabel.""*)
  - -> `[160]` (*Player_Romus: ""I'm not sore at all. But a bath sounds good.""*)
  - -> `[161]` (*Player_Romus: ""Only if it's got bubbles.""*)

### Węzeł `[345]`
Mówca: **Pabel Adria**
> ""May I come in? I forgot to leave you a towel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Player_Romus: ""Don't you have anything better to do? Stop bothering me.""*)
  - -> `[179]` (*Player_Romus: ""All right. Come in.""*)
  - -> `[346]` (*Player_Romus: ""It's not important. I'll dry off without one.""*)

### Węzeł `[346]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not important. I'll dry off without one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Pabel Adria), `[345]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]` (*Pabel Adria: ""It's... a very special towel?""*)

### Węzeł `[347]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[348]`
Mówca: **Pabel Adria**
> ""It's... a very special towel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]` (*Player_Romus: ""I told you not to come in, Pabel.""*)
  - -> `[349]` (*Player_Romus: ""I see. Fine, bring it in.""*)

### Węzeł `[349]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Fine, bring it in.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[350]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I told you not to come in, Pabel.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[348]` (Pabel Adria)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Pabel -= 1"*)

### Węzeł `[351]`
Mówca: **Narrator**
> "Vina's eyes grew wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]` (*Vina Toras: ""You mean...""*)

### Węzeł `[352]`
Mówca: **Vina Toras**
> ""You mean...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[524]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[536]` (*Player_Romus: ""The future is unpredictable. Any one of the other royal ..."*)
  - -> `[355]` (*Player_Romus: ""We stopped one uprising. I fear the next won't be so eas..."*)

### Węzeł `[353]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's time for the people of Rizia to hold the real power, Vina.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[352]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Vina Toras: ""But... what would become of us?""*)

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The monarchy must die if Rizia is to enter the modern era. At least in its current form.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Kontekst wejściowy (poprzednik):** `[352]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Vina Toras: ""But... what would become of us?""*)

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We stopped one uprising. I fear the next won't be so easy to suppress.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]` (*Vina Toras: ""The next? That's pessimistic, Father.""*)

### Węzeł `[356]`
Mówca: **Vina Toras**
> ""But... what would become of us?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]` (*Player_Romus: ""We would still perform some important duties. But a demo..."*)
  - -> `[357]` (*Player_Romus: ""We would stay on, but only in a symbolic role. The human..."*)
  - -> `[358]` (*Player_Romus: ""We could do anything we wanted! All the riches, none of ..."*)
  - -> `[359]` (*Player_Romus: ""We'd live as normal citizens. We don't deserve to be tre..."*)

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would stay on, but only in a symbolic role. The human embodiment of Rizian grace and dignity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]` (*Vina Toras: ""I understand. But I always thought I'd be more than that.""*)

### Węzeł `[358]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We could do anything we wanted! All the riches, none of the responsibility. Isn't that the dream?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]` (*Vina Toras: ""Maybe for you. I always thought my life would be more th..."*)

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We'd live as normal citizens. We don't deserve to be treated as superior simply by virtue of our birth.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]` (*Vina Toras: ""You really think that?""*)

### Węzeł `[360]`
Mówca: **Vina Toras**
> ""You really think that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_NoMonarchy = true; RiziaDLCSupp..."*)

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We would still perform some important duties. But a democratically elected leader should do the real work of governing the country.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[356]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]` (*Vina Toras: ""I understand. I think.""*)

### Węzeł `[362]`
Mówca: **Vina Toras**
> ""I understand. I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true; ..."*)

### Węzeł `[363]`
Mówca: **Vina Toras**
> ""I understand. But I always thought I'd be more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true; ..."*)

### Węzeł `[364]`
Mówca: **Vina Toras**
> ""Maybe for you. I always thought my life would be more than that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_NoMonarchy = true; RiziaDLCSupp..."*)

### Węzeł `[365]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[367]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[366]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]` (*Vina Toras: ""You know, Queen Lyza likened the monarchy to a steady sh..."*)

### Węzeł `[367]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]` (*Vina Toras: ""You know, this book I'm reading likened monarchy to a le..."*)

### Węzeł `[368]`
Mówca: **Vina Toras**
> ""You know, Queen Lyza likened the monarchy to a steady ship on a stormy ocean. We provide stability and comfort, even during the most unpredictable of times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[387]` (*Player_Romus: ""Wise words. But the Rizian people should steer their own..."*)
  - -> `[386]` (*Player_Romus: ""She was right. We're not ready to sink to the bottom of ..."*)
  - -> `[395]` (*Player_Romus: ""It may be a steady ship, but it sails on the currents of..."*)
  - -> `[396]` (*Player_Romus: ""We do not need a steady ship. We need to recognize the c..."*)

### Węzeł `[369]`
Mówca: **Vina Toras**
> ""You know, this book I'm reading likened monarchy to a leaky old galleon -- weighed down by the anchor of tradition, steered only by inertia and the whims of a privileged few.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)
  - -> `[376]` (*Player_Romus: ""That's cruel to those of us who are only trying to keep ..."*)
  - -> `[377]` (*Player_Romus: ""Maybe it's time to sink that ship.""*)

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mr. Chavatangakwunua, eh?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false` AND `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[369]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]` (*Vina Toras: ""Well... um, yes. He makes a lot of good points.""*)

### Węzeł `[371]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)
  - -> `[373]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_TookBookAway == true)"*)

### Węzeł `[372]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]` (*Player_Romus: ""How are you still reading that? I took it away.""*)

### Węzeł `[373]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_TookBookAway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)

### Węzeł `[374]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How are you still reading that? I took it away.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Kontekst wejściowy (poprzednik):** `[369]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "Vina folded her arms defiantly."*)

### Węzeł `[375]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're still reading that? Even after I banned Malenyevist propaganda?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true` AND `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[369]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]` (*Narrator: "Vina folded her arms defiantly."*)

### Węzeł `[376]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's cruel to those of us who are only trying to keep our country afloat.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]` (*Vina Toras: ""Maybe we're dead weight. We have to sink so the rest of ..."*)

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Maybe it's time to sink that ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[369]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[482]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_NoMonarchy = true"*)

### Węzeł `[378]`
Mówca: **Vina Toras**
> ""Maybe it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[379]`
Mówca: **Vina Toras**
> ""Maybe we're dead weight. We have to sink so the rest of the country can swim.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[380]`
Mówca: **Vina Toras**
> ""Well... um, yes. He makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]` (*Player_Romus: ""I don't know, His concept of vanguardism doesn't sound t..."*)
  - -> `[390]` (*Player_Romus: ""Keep on reading. Sounds like there's a lot of useful inf..."*)
  - -> `[391]` (*Player_Romus: ""I like his analogy. I'm less convinced about his preferr..."*)

### Węzeł `[381]`
Mówca: **Narrator**
> "Vina folded her arms defiantly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]` (*Vina Toras: ""You can't stop me from informing myself, Father. And he ..."*)

### Węzeł `[382]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)
  - -> `[384]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == t..."*)

### Węzeł `[383]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]` (*Player_Romus: ""You're still reading that? Even after I banned Malenyevi..."*)

### Węzeł `[384]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]` (*Player_Romus: ""Mr. Chavatangakwunua, eh?""*)

### Węzeł `[385]`
Mówca: **Vina Toras**
> ""You can't stop me from informing myself, Father. And he makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]` (*Player_Romus: ""I am warning you, Vina. Stop filling your head with this..."*)
  - -> `[484]` (*Player_Romus: ""All right. Keep reading it if that's what you really want.""*)
  - -> `[486]` (*Player_Romus: ""I'm concerned for your safety. If you're going to harbor..."*)

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She was right. We're not ready to sink to the bottom of the ocean just yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true"*)

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words. But the Rizian people should steer their own ship.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]` (*Vina Toras: ""How can they, without a noble hand to guide them?""*)

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am warning you, Vina. Stop filling your head with this nonsense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[485]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relatio..."*)

### Węzeł `[389]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know, His concept of vanguardism doesn't sound too far off from monarchy to me.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]` (*Vina Toras: ""That's why Hegel branched off with Valgslandian Socialis..."*)

### Węzeł `[390]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Keep on reading. Sounds like there's a lot of useful information in there.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]` (*Vina Toras: ""To be honest, a lot of it is outdated. I've also been re..."*)

### Węzeł `[391]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I like his analogy. I'm less convinced about his preferred system of government.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[380]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]` (*Vina Toras: ""Yes, I've also started to read about Valgslandian Social..."*)

### Węzeł `[392]`
Mówca: **Vina Toras**
> ""Yes, I've also started to read about Valgslandian Socialism. It makes even more sense to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[393]`
Mówca: **Vina Toras**
> ""That's why Hegel branched off with Valgslandian Socialism. I've been reading about that as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[394]`
Mówca: **Vina Toras**
> ""To be honest, a lot of it is outdated. I've also been reading some newer texts about Valgslandian Socialism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It may be a steady ship, but it sails on the currents of privilege and tradition, not the winds of change and progress.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]` (*Vina Toras: ""That doesn't need to be the case. Monarchs have embraced..."*)

### Węzeł `[396]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We do not need a steady ship. We need to recognize the changing seas and adapt to them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[368]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]` (*Vina Toras: ""Change can be threatening to many people. Our presence o..."*)

### Węzeł `[397]`
Mówca: **Vina Toras**
> ""I hope not. Our people still need us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[398]`
Mówca: **Vina Toras**
> ""How can they, without a noble hand to guide them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[399]`
Mówca: **Vina Toras**
> ""That doesn't need to be the case. Monarchs have embraced change and progress in the past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[400]`
Mówca: **Vina Toras**
> ""Change can be threatening to many people. Our presence on the throne is a symbol of continuity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[401]`
Mówca: **Vina Toras**
> ""The next? That's pessimistic, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[473]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[402]`
Mówca: **Vina Toras**
> ""They don't belong to everyone in Rizia, though, do they? So much of this coast is private property...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]` (*Player_Romus: ""What are you up to nowadays, Vina?""*)
  - -> `[450]` (*Player_Romus: ""I was only following your late mother's wishes. Remember..."*)
  - -> `[451]` (*Player_Romus: ""For now, let's just enjoy having this time and this beac..."*)

### Węzeł `[403]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What have you been doing these days, anyway?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Vina Toras: ""The usual. Ballgoing. Public appearances. Grandmother en..."*)

### Węzeł `[404]`
Mówca: **Vina Toras**
> ""The usual. Ballgoing. Public appearances. Grandmother enrolled me in an advanced etiquette class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Vina Toras: ""By the way, did you know it's considered polite to inten..."*)

### Węzeł `[405]`
Mówca: **Narrator**
> "She reached up and gave her horse a pat on the nose."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]` (*Vina Toras: ""It's beautiful here, isn't it? I can see why the Sords h..."*)

### Węzeł `[406]`
Mówca: **Vina Toras**
> ""It's beautiful here, isn't it? I can see why the Sords had their eye on it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)

### Węzeł `[407]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[408]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[409]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[408]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]` (*Player_Romus: ""It's so beautiful it deserves to be shared.""*)
  - -> `[410]` (*Player_Romus: ""Do you think it was the right decision to let them build..."*)

### Węzeł `[409]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]` (*Player_Romus: ""They did indeed. But I showed them who's in charge.""*)
  - -> `[412]` (*Player_Romus: ""Do you think I should have given it to them?""*)

### Węzeł `[410]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think it was the right decision to let them build their resort?""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[406]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]` (*Narrator: "Vina thought for a moment."*)

### Węzeł `[411]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They did indeed. But I showed them who's in charge.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[406]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]` (*Vina Toras: ""A Sordish resort on our shores! Imagine.""*)

### Węzeł `[412]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think I should have given it to them?""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[406]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[426]` (*Narrator: "Vina thought for a moment."*)

### Węzeł `[413]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's your own fault. Why don't you find something to do?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[208]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]` (*Vina Toras: ""You mean between the ballgoing, the public appearances a..."*)

### Węzeł `[414]`
Mówca: **Vina Toras**
> ""You mean between the ballgoing, the public appearances and the advanced etiquette classes Grandmother's making me go to?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Vina Toras: ""By the way, did you know it's considered polite to inten..."*)

### Węzeł `[415]`
Mówca: **Vina Toras**
> ""You just accepted that Sordish resort deal, didn't you? That was entirely your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]` (*Player_Romus: ""Yes, and I'm proud of it. A beach as beautiful as this d..."*)
  - -> `[454]` (*Player_Romus: ""Do you agree with it? Should I have turned them down ins..."*)

### Węzeł `[416]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Situation_Economy_Sordland_ResortDeal == true"*)
  - -> `[418]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)"*)

### Węzeł `[417]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Situation_Economy_Sordland_ResortDeal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]` (*Vina Toras: ""You just accepted that Sordish resort deal, didn't you? ..."*)

### Węzeł `[418]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]` (*Vina Toras: ""You just turned down the Sords' offer to build a resort ..."*)

### Węzeł `[419]`
Mówca: **Vina Toras**
> ""You just turned down the Sords' offer to build a resort here, didn't you? That was entirely your decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]` (*Player_Romus: ""That's right. I showed them who's in charge.""*)
  - -> `[456]` (*Player_Romus: ""Do you think I should have let them build it?""*)

### Węzeł `[420]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's so beautiful it deserves to be shared.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true`
- **Kontekst wejściowy (poprzednik):** `[406]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]` (*Vina Toras: ""It's what Queen Lyza would have done.""*)

### Węzeł `[421]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]` (*Vina Toras: ""Sure. I mean, Queen Lyza recognized the importance of be..."*)

### Węzeł `[422]`
Mówca: **Vina Toras**
> ""Sure. I mean, Queen Lyza recognized the importance of being connected with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Vina Toras: ""Mother would be rolling in her grave at the news, though..."*)

### Węzeł `[423]`
Mówca: **Vina Toras**
> ""Mother would be rolling in her grave at the news, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[431]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[432]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[424]`
Mówca: **Vina Toras**
> ""It's what Queen Lyza would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]` (*Vina Toras: ""Mother would be rolling in her grave at the news, though..."*)

### Węzeł `[425]`
Mówca: **Vina Toras**
> ""A Sordish resort on our shores! Imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]` (*Vina Toras: ""Mother would've rolled in her grave. Remember how she al..."*)

### Węzeł `[426]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]` (*Vina Toras: ""Maybe. If only to honor the history of trade between our..."*)

### Węzeł `[427]`
Mówca: **Vina Toras**
> ""Maybe. If only to honor the history of trade between our countries under Queen Lyza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]` (*Vina Toras: ""Mother would've rolled in her grave, though. Remember ho..."*)

### Węzeł `[428]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[431]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[432]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[429]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't even get me started on what your Aunt Bea calls them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Vina Toras), `[428]` (Vina Toras), `[430]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[430]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[431]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[432]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[431]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yeah. That was a cheap shot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Vina Toras), `[428]` (Vina Toras), `[430]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[432]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had an ear for a good pun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[423]` (Vina Toras), `[428]` (Vina Toras), `[430]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[433]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Since who died?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]` (*Vina Toras: ""Mother, obviously.""*)

### Węzeł `[434]`
Mówca: **Vina Toras**
> ""Mother, obviously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Vina Toras: ""I can't even dip my toe in the water, or it'll all come ..."*)

### Węzeł `[435]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I honestly don't think about it that often.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]` (*Vina Toras: ""Lucky you.""*)

### Węzeł `[436]`
Mówca: **Vina Toras**
> ""Lucky you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Vina Toras: ""I can't even dip my toe in the water, or it'll all come ..."*)

### Węzeł `[437]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You almost died too that day, you know.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[438]` (*Vina Toras: ""Sometimes I wish I had.""*)

### Węzeł `[438]`
Mówca: **Vina Toras**
> ""Sometimes I wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Vina Toras: ""I can't even dip my toe in the water, or it'll all come ..."*)

### Węzeł `[439]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Tell me about it. It hurts every time we come back here.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]` (*Vina Toras: ""But we keep doing it anyway.""*)

### Węzeł `[440]`
Mówca: **Vina Toras**
> ""But we keep doing it anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Vina Toras: ""I can't even dip my toe in the water, or it'll all come ..."*)

### Węzeł `[441]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Really? I'll remember that the next time I'm in Derdia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]` (*Vina Toras: ""Remember to tell them to treat women like people, too.""*)

### Węzeł `[442]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's a Duel of Generosity?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]` (*Vina Toras: ""Some sort of welcome ceremony. But Rizia hasn't had a di..."*)

### Węzeł `[443]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See? Those classes aren't entirely useless.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[212]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[446]` (*Vina Toras: ""They are. Have you heard about how abysmal women's right..."*)

### Węzeł `[444]`
Mówca: **Vina Toras**
> ""Some sort of welcome ceremony. But Rizia hasn't had a diplomatic visit to Derdia in decades, so the exact procedure is unknown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[445]`
Mówca: **Vina Toras**
> ""Remember to tell them to treat women like people, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[446]`
Mówca: **Vina Toras**
> ""They are. Have you heard about how abysmal women's rights are in Derdia? I'm never setting foot there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[447]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]` (*Vina Toras: ""Sure, Father. I will.""*)

### Węzeł `[448]`
Mówca: **Vina Toras**
> ""Sure, Father. I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[449]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What are you up to nowadays, Vina?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Vina Toras), `[203]` (Vina Toras), `[402]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]` (*Vina Toras: ""The usual. Ballgoing. Public appearances. Grandmother en..."*)

### Węzeł `[450]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was only following your late mother's wishes. Remember how she used to call them 'Sordid' instead of 'Sordish'?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[201]` (Vina Toras), `[203]` (Vina Toras), `[402]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[453]` (*Vina Toras: ""It's true. She would have been rolling in her grave if y..."*)

### Węzeł `[451]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""For now, let's just enjoy having this time and this beach to ourselves.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[203]` (Vina Toras), `[402]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]` (*Vina Toras: ""Sure, Father. I don't mean to complain.""*)

### Węzeł `[452]`
Mówca: **Vina Toras**
> ""Sure, Father. I don't mean to complain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[453]`
Mówca: **Vina Toras**
> ""It's true. She would have been rolling in her grave if you'd said yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[454]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you agree with it? Should I have turned them down instead?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[415]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]` (*Narrator: "Vina thought for a moment."*)

### Węzeł `[455]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's right. I showed them who's in charge.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]` (*Vina Toras: ""A Sordish resort on our shores! Imagine.""*)

### Węzeł `[456]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you think I should have let them build it?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[419]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]` (*Narrator: "Vina thought for a moment."*)

### Węzeł `[457]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, and I'm proud of it. A beach as beautiful as this deserves to be shared.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[415]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]` (*Vina Toras: ""It's what Queen Lyza would have done.""*)

### Węzeł `[458]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]` (*Vina Toras: ""I don't think so. I mean, Queen Lyza recognized the impo..."*)

### Węzeł `[459]`
Mówca: **Vina Toras**
> ""I don't think so. I mean, Queen Lyza recognized the importance of being connected with Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Vina Toras: ""Mother would be rolling in her grave at the news, though..."*)

### Węzeł `[460]`
Mówca: **Vina Toras**
> ""Mother would be rolling in her grave at the news, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[468]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[469]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[461]`
Mówca: **Vina Toras**
> ""It's what Queen Lyza would have done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]` (*Vina Toras: ""Mother would be rolling in her grave at the news, though..."*)

### Węzeł `[462]`
Mówca: **Vina Toras**
> ""A Sordish resort on our shores! Imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]` (*Vina Toras: ""Mother would've rolled in her grave. Remember how she al..."*)

### Węzeł `[463]`
Mówca: **Narrator**
> "Vina thought for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]` (*Vina Toras: ""Maybe. If only to honor the history of trade between our..."*)

### Węzeł `[464]`
Mówca: **Vina Toras**
> ""Maybe. If only to honor the history of trade between our countries under Queen Lyza.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]` (*Vina Toras: ""Mother would've rolled in her grave, though. Remember ho..."*)

### Węzeł `[465]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave, though. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[468]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[469]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[466]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't even get me started on what your Aunt Bea calls them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Vina Toras), `[465]` (Vina Toras), `[467]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[467]`
Mówca: **Vina Toras**
> ""Mother would've rolled in her grave. Remember how she always used to call them 'sordid' instead of 'Sordish'?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]` (*Player_Romus: ""Don't even get me started on what your Aunt Bea calls th..."*)
  - -> `[468]` (*Player_Romus: ""Yeah. That was a cheap shot.""*)
  - -> `[469]` (*Player_Romus: ""She had an ear for a good pun.""*)

### Węzeł `[468]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yeah. That was a cheap shot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Vina Toras), `[465]` (Vina Toras), `[467]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[469]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She had an ear for a good pun.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[460]` (Vina Toras), `[465]` (Vina Toras), `[467]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]` (*Węzeł Logiki Narracyjnej: "Jump to: [Narrator: "She picked up a lobster salad sandw...."*)

### Węzeł `[470]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She picked up a lobster salad sandw..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[471]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She picked up a lobster salad sandw..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[472]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Narrator: "She picked up a lobster salad sandw..."]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "She picked up a lobster salad sandwich from the picnic ba..."*)

### Węzeł `[473]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[475]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[474]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]` (*Vina Toras: ""But in my opinion, if the people want revolution, we sho..."*)

### Węzeł `[475]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]` (*Vina Toras: ""But I agree that if the people of this country want revo..."*)

### Węzeł `[476]`
Mówca: **Vina Toras**
> ""But I agree that if the people of this country want revolution, we will not be able to stop them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]` (*Player_Romus: ""No. But we can die trying.""*)
  - -> `[493]` (*Player_Romus: ""If that is truly what they want, I will not get in their..."*)
  - -> `[494]` (*Player_Romus: ""Don't tell me you're still reading Comrade Chavatangakwu..."*)

### Węzeł `[477]`
Mówca: **Vina Toras**
> ""But in my opinion, if the people want revolution, we should be the ones who bring it to them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]` (*Player_Romus: ""Is it really revolution if we're still on the throne?""*)
  - -> `[479]` (*Player_Romus: ""We Torases are not revolutionaries. We are keepers of tr..."*)
  - -> `[491]` (*Player_Romus: ""The people who want revolution also want to see me dead.""*)

### Węzeł `[478]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is it really revolution if we're still on the throne?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[511]` (*Vina Toras: ""Why not? A good monarch adapts to the times.""*)

### Węzeł `[479]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We Torases are not revolutionaries. We are keepers of tradition.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]` (*Vina Toras: ""Why can't we be both?""*)

### Węzeł `[480]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true; RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[481]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_NoMonarchy = true; RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Vina_AntiMonarchist"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[482]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_NoMonarchy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_NoMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]` (*Vina Toras: ""Maybe it is.""*)

### Węzeł `[483]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Turn02_Intention_ConstitutionalMonarchy = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Turn02_Intention_ConstitutionalMonarchy"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]` (*Vina Toras: ""I hope not. Our people still need us.""*)

### Węzeł `[484]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Keep reading it if that's what you really want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]` (*Vina Toras: ""It is. And I will.""*)

### Węzeł `[485]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[488]` (*Vina Toras: ""But... you're the one talking about getting rid of the m..."*)

### Węzeł `[486]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm concerned for your safety. If you're going to harbor these sentiments, then by God be quiet about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[385]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]` (*Vina Toras: ""I will. You're the one who brought up the subject.""*)

### Węzeł `[487]`
Mówca: **Vina Toras**
> ""I will. You're the one who brought up the subject.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[488]`
Mówca: **Vina Toras**
> ""But... you're the one talking about getting rid of the monarchy. Would you turn us into Lespia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]` (*Vina Toras: ""Never mind. You know best, Your Majesty.""*)

### Węzeł `[489]`
Mówca: **Vina Toras**
> ""It is. And I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[490]`
Mówca: **Vina Toras**
> ""Never mind. You know best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[491]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The people who want revolution also want to see me dead.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[477]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[513]` (*Vina Toras: ""Not if you're willing to change with them.""*)

### Węzeł `[492]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. But we can die trying.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]` (*Vina Toras: ""That doesn't sound very appealing.""*)

### Węzeł `[493]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If that is truly what they want, I will not get in their way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Vina Toras), `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]` (*Vina Toras: ""Neither will I.""*)

### Węzeł `[494]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't tell me you're still reading Comrade Chavatangakwunua.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[476]` (Vina Toras), `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)

### Węzeł `[495]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[496]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina_TookBookAway == true"*)
  - -> `[497]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Relations_Vina_TookBookAway == true)"*)

### Węzeł `[496]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina_TookBookAway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[501]` (*Vina Toras: ""No thanks to you. I'm a grown woman and I will read what..."*)

### Węzeł `[497]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Relations_Vina_TookBookAway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_TookBookAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)

### Węzeł `[498]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true"*)
  - -> `[500]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == t..."*)

### Węzeł `[499]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[502]` (*Vina Toras: ""Would you have me executed if I said yes?""*)

### Węzeł `[500]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]` (*Vina Toras: ""Well... um, yes. He makes a lot of good points.""*)

### Węzeł `[501]`
Mówca: **Vina Toras**
> ""No thanks to you. I'm a grown woman and I will read what I like.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""I am warning you, Vina. Stop filling your head with this..."*)
  - -> `[505]` (*Player_Romus: ""No need to get defensive. Keep reading it if that's what..."*)
  - -> `[506]` (*Player_Romus: ""I'm concerned for your safety. If you're going to harbor..."*)

### Węzeł `[502]`
Mówca: **Vina Toras**
> ""Would you have me executed if I said yes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[504]` (*Player_Romus: ""I am warning you, Vina. Stop filling your head with this..."*)
  - -> `[505]` (*Player_Romus: ""No need to get defensive. Keep reading it if that's what..."*)
  - -> `[506]` (*Player_Romus: ""I'm concerned for your safety. If you're going to harbor..."*)

### Węzeł `[503]`
Mówca: **Vina Toras**
> ""Well... um, yes. He makes a lot of good points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]` (*Player_Romus: ""No need to get defensive. Keep reading it if that's what..."*)
  - -> `[506]` (*Player_Romus: ""I'm concerned for your safety. If you're going to harbor..."*)
  - -> `[507]` (*Player_Romus: ""Give me a summary when you have the chance. I'm dying of..."*)

### Węzeł `[504]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am warning you, Vina. Stop filling your head with this nonsense.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[501]` (Vina Toras), `[502]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relatio..."*)

### Węzeł `[505]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need to get defensive. Keep reading it if that's what you really want.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[501]` (Vina Toras), `[502]` (Vina Toras), `[503]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]` (*Vina Toras: ""It is, and I will.""*)

### Węzeł `[506]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm concerned for your safety. If you're going to harbor these sentiments, then by God be quiet about it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[501]` (Vina Toras), `[502]` (Vina Toras), `[503]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]` (*Vina Toras: ""I will, I will. You're the one who brought up the topic.""*)

### Węzeł `[507]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give me a summary when you have the chance. I'm dying of curiosity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[503]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina += 1"*)

### Węzeł `[508]`
Mówca: **Vina Toras**
> ""That doesn't sound very appealing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Vina Toras: ""I don't know what it was like in the '20s. But it does f..."*)

### Węzeł `[509]`
Mówca: **Vina Toras**
> ""Neither will I.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]` (*Vina Toras: ""I don't know what it was like in the '20s. But it does f..."*)

### Węzeł `[510]`
Mówca: **Vina Toras**
> ""I don't know what it was like in the '20s. But it does feel like some sort of change is brewing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[511]`
Mówca: **Vina Toras**
> ""Why not? A good monarch adapts to the times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[512]`
Mówca: **Vina Toras**
> ""Why can't we be both?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[513]`
Mówca: **Vina Toras**
> ""Not if you're willing to change with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[514]`
Mówca: **Vina Toras**
> ""I will, I will. You're the one who brought up the topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[515]`
Mówca: **Vina Toras**
> ""It is, and I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[516]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Malenyevist -= 1; RiziaDLC.Relations_Vina -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]` (*Vina Toras: ""But...""*)

### Węzeł `[517]`
Mówca: **Vina Toras**
> ""But...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]` (*Vina Toras: ""Never mind. You know best, Your Majesty.""*)

### Węzeł `[518]`
Mówca: **Vina Toras**
> ""Never mind. You know best, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[519]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina += 1`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]` (*Vina Toras: ""Sure thing, Father.""*)

### Węzeł `[520]`
Mówca: **Vina Toras**
> ""Sure thing, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[521]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");`
- **Efekt skryptowy (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "It was low tide. The waves of the Antacean Sea lapped at ..."*)

### Węzeł `[522]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.News_Turn02_G_SaveTheRiver = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.News_Turn02_G_SaveTheRiver"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[523]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Security_ValeroPoisoningTalk_Happened = true;
RiziaDLCSupport.Journal_Turn02_Pabel_Listened = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_Happened"] = true;
Variable["RiziaDLCSupport.Journal_Turn02_Pabel_Listened"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]` (*Węzeł Logiki Narracyjnej: "RemoveConversant("Pabel Adria");"*)

### Węzeł `[524]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[525]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true"*)
  - -> `[526]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true)"*)

### Węzeł `[525]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]` (*Player_Romus: ""It's time for the people of Rizia to hold the real power..."*)
  - -> `[354]` (*Player_Romus: ""The monarchy must die if Rizia is to enter the modern er..."*)

### Węzeł `[526]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[527]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == ..."*)
  - -> `[529]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative =..."*)

### Węzeł `[528]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == false  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis ..."*)

### Węzeł `[529]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative == false && RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_AffordableHousingInitative"] == false  and  Variable["RiziaDLC.Policy_RD_Welfare_TenantProtectionLaws"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SaveTheRiver = true"*)

### Węzeł `[530]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLCSupport.Reports_Turn02_PorteDrazon_HousingCrisis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]` (*Węzeł Logiki Narracyjnej: "RiziaDLCSupport.News_Turn02_G_SaveTheRiver = true"*)

### Węzeł `[531]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo..."*)
  - -> `[533]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hu..."*)

### Węzeł `[532]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]` (*Player_Romus: ""It doesn't matter. You heard what I said to Hugo. It's t..."*)

### Węzeł `[533]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Focus_Government_Reform == true && RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Romus: ""What makes you think our family will still hold power by..."*)

### Węzeł `[534]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It doesn't matter. You heard what I said to Hugo. It's time for House Toras to step aside and let the people rule.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Focus_Government_Reform"] == true  and  Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]` (*Vina Toras: ""So you really mean it. You want to reform the kingdom.""*)

### Węzeł `[535]`
Mówca: **Vina Toras**
> ""So you really mean it. You want to reform the kingdom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]` (*Vina Toras: ""But... what would become of us?""*)

### Węzeł `[536]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The future is unpredictable. Any one of the other royal houses could seize power at any moment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[352]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnC..."*)

### Węzeł `[537]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Vina Succession Answers`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Player_Romus: ""I'd still declare you next in line. Rizia needs a queen ..."*)
  - -> `[34]` (*Player_Romus: ""He'd become my successor, of course. Those are the rules..."*)
  - -> `[551]` (*Player_Romus: ""I don't know, Vina. If the situation ever arises, it wil..."*)
  - -> `[59]` (*Player_Romus: ""You don't have anything to worry about. My childbearing ..."*)

### Węzeł `[538]`
Mówca: **Vina Toras**
> ""Not if you neutralize the threat. Like you were talking about with Uncle Hugo.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Vina Toras: ""You didn't answer my question. What would happen if you ..."*)

### Węzeł `[539]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnC..."*)
  - -> `[541]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_O..."*)

### Węzeł `[540]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Focus_Government_Absolutism"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]` (*Vina Toras: ""Not if you neutralize the threat. Like you were talking ..."*)

### Węzeł `[541]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Hugo_KnowsIntention == true && RiziaDLC.Vina_OnCouncil == true && RiziaDLC.Focus_Government_Absolutism == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Hugo_KnowsIntention"] == true  and  Variable["RiziaDLC.Vina_OnCouncil"] == true  and  Variable["RiziaDLC.Focus_Government_Absolutism"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[543]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[542]`
Mówca: **Vina Toras**
> ""That's what you're worried about? Not the people of Rizia seizing power themselves?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]` (*Player_Romus: ""Just what are you implying, Vina?""*)
  - -> `[493]` (*Player_Romus: ""If that is truly what they want, I will not get in their..."*)
  - -> `[494]` (*Player_Romus: ""Don't tell me you're still reading Comrade Chavatangakwu..."*)

### Węzeł `[543]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[545]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[544]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]` (*Vina Toras: ""It can't be that hard to keep the provinces happy. Can it?""*)

### Węzeł `[545]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]` (*Vina Toras: ""That's what you're worried about? Not the people of Rizi..."*)

### Węzeł `[546]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Just what are you implying, Vina?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[542]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[547]` (*Vina Toras: ""Nothing, Father. Can we go back to my original question?..."*)

### Węzeł `[547]`
Mówca: **Vina Toras**
> ""Nothing, Father. Can we go back to my original question? What would happen if you had a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "Jump to: [Vina Succession Answers]"*)

### Węzeł `[548]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `Jump to: [Vina Succession Answers]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]` (*Węzeł Logiki Narracyjnej: "Vina Succession Answers"*)

### Węzeł `[549]`
Mówca: **Vina Toras**
> ""It can't be that hard to keep the provinces happy. Can it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]` (*Vina Toras: ""You didn't answer my question. What would happen if you ..."*)

### Węzeł `[550]`
Mówca: **Vina Toras**
> ""You didn't answer my question. What would happen if you had a son?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]` (*Węzeł Logiki Narracyjnej: "Jump to: [Vina Succession Answers]"*)

### Węzeł `[551]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know, Vina. If the situation ever arises, it will be a hard decision.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[303]` (Vina Toras), `[547]` (Vina Toras), `[550]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[552]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Relations_Vina -= 1;"*)

### Węzeł `[552]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Relations_Vina -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]` (*Narrator: "She folded her arms."*)

### Węzeł `[553]`
Mówca: **Narrator**
> "She folded her arms."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[554]` (*Vina Toras: ""Thanks. It's lovely to know all my preparations may or m..."*)

### Węzeł `[554]`
Mówca: **Vina Toras**
> ""Thanks. It's lovely to know all my preparations may or may not be in vain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]` (*Narrator: "She uncrossed her arms again with a look of contrition."*)

### Węzeł `[555]`
Mówca: **Narrator**
> "She uncrossed her arms again with a look of contrition."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]` (*Vina Toras: ""Sorry, Father. I do understand the importance of royal t..."*)

### Węzeł `[556]`
Mówca: **Vina Toras**
> ""Sorry, Father. I do understand the importance of royal tradition. But it's frustrating not to have any power over my lot in life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]` (*Player_Romus: ""If you want agency, you can always take yourself out of ..."*)
  - -> `[558]` (*Player_Romus: ""This is all completely hypothetical. Just assume that yo..."*)
  - -> `[563]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)

### Węzeł `[557]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you want agency, you can always take yourself out of the line of succession. If I don't have a son, the crown will go to Hugo when I die. Or more likely, your cousin Ricardus.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]` (*Narrator: "She made a face."*)

### Węzeł `[558]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is all completely hypothetical. Just assume that you're my successor and prepare yourself accordingly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[556]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[561]` (*Vina Toras: ""Yes. That's what I've been doing.""*)

### Węzeł `[559]`
Mówca: **Narrator**
> "She made a face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]` (*Vina Toras: ""I'm not ready to give up all hope of becoming queen, tha..."*)

### Węzeł `[560]`
Mówca: **Vina Toras**
> ""I'm not ready to give up all hope of becoming queen, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[561]`
Mówca: **Vina Toras**
> ""Yes. That's what I've been doing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[562]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a future Duchess and a member of the Royal Council. That's already more power than most Rizians will ever have.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Kontekst wejściowy (poprzednik):** `[556]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Vina Toras: ""You're right, of course. But you knew you'd be king ever..."*)

### Węzeł `[563]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[564]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Vina_OnCouncil == true"*)
  - -> `[565]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.Vina_OnCouncil == true)"*)

### Węzeł `[564]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Vina_OnCouncil == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[562]` (*Player_Romus: ""You're a future Duchess and a member of the Royal Counci..."*)

### Węzeł `[565]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.Vina_OnCouncil == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[567]` (*Player_Romus: ""You're a future Duchess and a member of House Toras. Tha..."*)

### Węzeł `[566]`
Mówca: **Vina Toras**
> ""You're right, of course. But you knew you'd be king ever since you were a child. It's different for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Narrator: "The tide was beginning to lap at the edge of our blanket...."*)

### Węzeł `[567]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're a future Duchess and a member of House Toras. That's already more power than most Rizians will ever have.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Kontekst wejściowy (poprzednik):** `[556]` (Vina Toras)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[566]` (*Vina Toras: ""You're right, of course. But you knew you'd be king ever..."*)
