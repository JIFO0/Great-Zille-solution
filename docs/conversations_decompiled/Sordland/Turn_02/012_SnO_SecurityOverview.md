# Sordland/Turn02/SnO_SecurityOverview

- **ID konwersacji:** `12`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/012_SnO_SecurityOverview.md`
- **Liczba węzłów dialogowych:** 269
- **Liczba wyborów gracza:** 71

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[42]** Valken Kruger
- **[44]** Lileas Graf
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn01_InfrastructureProject_Invest`
- `BaseGame.Prologue_Studyplace_Lachaven_Economics`
- `BaseGame.Prologue_University_Political_Socialist`
- `BaseGame.Promise_TermFocus_Military`
- `BaseGame.Promise_TermFocus_Security`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Economy`
- `BaseGame.Intention_RevokeBergiaSpecialZone`
- `BaseGame.Situation_Diplomacy_DiplomaticPressure`
- `BaseGame.Situation_Order_Nationwide_Protests`
- `BaseGame.Situation_Order_Nationwide_Quelled`
- `BaseGame.Situation_Order_Nationwide_Revolt`
- `BaseGameSupport.FactionReport_Turn02_ATO_ArcasiaICBM`
- `BaseGameSupport.News_Turn02_E_UnderhallNo1`
- `BaseGameSupport.News_Turn02_G_RumburgClosesConsulate`
- `BaseGameSupport.News_Turn02_LT_GangViolence`
- `BaseGameSupport.News_Turn02_R_1927NeverAgain`
- `BaseGameSupport.News_Turn02_R_EconomicCrisis`
- `BaseGameSupport.News_Turn02_ST_InfrastructureRumours`
- `BaseGameSupport.Report_Turn02_Erzaren_RiseInGolcondism`
- `BaseGameSupport.Report_Turn02_Vesord_UCConsulate`
- `GameCondition.Turn02_SnO_SecurityOverview`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“General Kruger.”"** | `[8]` **Narrator**: "He was in his 70s, yet he had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Valken Kruger**: "“Mr. President. It is an honor.”" |
| `[12]` | **"Salute him."** | `[8]` **Narrator**: "He was in his 70s, yet he had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Narrator**: "He smiled at the gesture and bow..." |
| `[14]` | **""Let's begin.""** | `[6]` **Iosef Lancea**: ""Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Iosef Lancea**: ""I brought General Kruger with m..." |
| `[19]` | **"“Let them come, we will give them hell.”"** | `[17]` **Valken Kruger**: "“The entire situation was analys..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Valken Kruger**: "“I share your enthusiasm. We dra..." |
| `[21]` | **"“I have complete trust in the General Staff.”"** | `[17]` **Valken Kruger**: "“The entire situation was analys..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[18]` **Valken Kruger**: "“We will not let you down, Mr. P..." |
| `[23]` | **"“The threat is exaggerated.”"** | `[17]` **Valken Kruger**: "“The entire situation was analys..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Valken Kruger**: "“With all due respect, I think y..." |
| `[25]` | **"”This concerns me very much.“"** | `[24]` **Iosef Lancea**: "“Rumburg has been acting increas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Iosef Lancea**: "“We are observing these areas ac..." |
| `[26]` | **"”What is your current strategy?“"** | `[24]` **Iosef Lancea**: "“Rumburg has been acting increas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[32]` **Iosef Lancea**: "“Patrolling close to the borders..." |
| `[27]` | **"”I trust the capabilities of our armed forces to handle any threats.“"** | `[24]` **Iosef Lancea**: "“Rumburg has been acting increas..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Iosef Lancea**: "“I can assure you of our capabil..." |
| `[29]` | **"”Please, General.“"** | `[30]` **Valken Kruger**: "”Mr. President, if I may?“" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Valken Kruger**: "“The picture is becoming clearer..." |
| `[36]` | **"”Go on.“"** | `[30]` **Valken Kruger**: "”Mr. President, if I may?“" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Valken Kruger**: "“The picture is becoming clearer..." |
| `[37]` | **"“Let's move on.”"** | `[56]` **Lucian Galade**: "“Thank you for the updates, Mrs...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Nia Morgna**: "“Have a good day.”" |
| `[38]` | **"“Which two crime families?”"** | `[50]` **Lileas Graf**: "“It is the gang violence that is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Lileas Graf**: "“One is known as the Koranelli a..." |
| `[43]` | **"“They make a lot of noise but have little substance. A barking dog doesn't bite.”"** | `[42]` **Lileas Graf**: "“Our highest internal threat com..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Lileas Graf**: "“It may seem that way from the o..." |
| `[44]` | **"“Are they supported by our Bludish citizens?”"** | `[42]` **Lileas Graf**: "“Our highest internal threat com..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lileas Graf**: "“To some extent. Luckily they co..." |
| `[45]` | **"“Are they cooperating with any Bludish political organizations?”"** | `[42]` **Lileas Graf**: "“Our highest internal threat com..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Lileas Graf**: "“Many suspected links exist betw..." |
| `[51]` | **"“Why can't we just arrest them?”"** | `[50]` **Lileas Graf**: "“It is the gang violence that is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[54]` **Lileas Graf**: "“The primary reason is deception..." |
| `[52]` | **"“I don't think mere gangs can pose a threat to us.”"** | `[50]` **Lileas Graf**: "“It is the gang violence that is..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[40]` **Lileas Graf**: "“These ill-behaved thugs make ou..." |
| `[55]` | **"“They are playing with fire. I want them gone. For good.”"** | `[40]` **Lileas Graf**: "“These ill-behaved thugs make ou..."<br>`[53]` **Lileas Graf**: "“One is known as the Koranelli a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucian Galade**: "“While I agree it would make Sor..." |
| `[57]` | **"“Thank you for the overview.”"** | `[56]` **Lucian Galade**: "“Thank you for the updates, Mrs...." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[58]` **Nia Morgna**: "“Have a good day.”" |
| `[62]` | **"“Please enlighten us. The more we know, the better.”"** | `[60]` **Lileas Graf**: "“I have received news this morni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lileas Graf**: "“After further investigation and..." |
| `[63]` | **"“Great news. I am eager to hear about the details.”"** | `[60]` **Lileas Graf**: "“I have received news this morni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Lileas Graf**: "“After further investigation and..." |
| `[65]` | **"“Political violence needs to stop.”"** | `[71]` **Lileas Graf**: "“Since he often spoke against th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Lileas Graf**: "“Yes. We've kept it at bay for s..." |
| `[66]` | **"“He had it coming then.”"** | `[71]` **Lileas Graf**: "“Since he often spoke against th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[116]` **Narrator**: "Lileas Graf cleared her throat." |
| `[69]` | **"“Our country always had issues, this is a part of our job.”"** | `[93]` **Lileas Graf**: "“As we all know, the enemies of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Nia Morgna**: "“If we give up essential freedom..." |
| `[72]` | **"“The Red Youth are clearly to blame since they triggered it.”"** | `[71]` **Lileas Graf**: "“Since he often spoke against th..." | `Variable["BaseGame.Prologue_University_Political_Socialist"] == false` | *Brak zmian stanu* | `[75]` **Lileas Graf**: "“They struck first, yes. It was ..." |
| `[78]` | **"“I also don't want to jump to conclusions immediately. We shouldn't create a crisi..."** | `[90]` **Nia Morgna**: "“I went over the report in detai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Lileas Graf**: "“Nearly three decades ago, they ..." |
| `[79]` | **"“I trust Ms. Graf's judgement. United Contana is clearly trying to expand its infl..."** | `[90]` **Nia Morgna**: "“I went over the report in detai..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Lileas Graf**: "“Mr. Rayne, we have done our due..." |
| `[82]` | **"“What does this mean?”"** | `[76]` **Lileas Graf**: "“The investigation revealed a ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Lileas Graf**: "“That the communist superpower i..." |
| `[83]` | **"“Are you sure?”"** | `[76]` **Lileas Graf**: "“The investigation revealed a ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[87]` **Lileas Graf**: "“Yes, we have found the cash tra..." |
| `[84]` | **"“This is proof that they are meddling in our affairs.”"** | `[76]` **Lileas Graf**: "“The investigation revealed a ve..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[88]` **Lileas Graf**: "“Exactly.”" |
| `[94]` | **"“As the government we have all the power to deal with any threat.”"** | `[93]` **Lileas Graf**: "“As we all know, the enemies of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Nia Morgna**: "“If we give up essential freedom..." |
| `[95]` | **"“We need to remain vigilant.”"** | `[93]` **Lileas Graf**: "“As we all know, the enemies of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[96]` **Nia Morgna**: "“If we give up essential freedom..." |
| `[100]` | **"“It was expected that Rumburg would undermine us, but this is too far.”"** | `[98]` **Lucian Galade**: "“This is worrying. Very worrying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Lileas Graf**: "“I agree, the prospect of arming..." |
| `[101]` | **"“We need to keep level-headed with Rumburg. They are looking for reasons to take a..."** | `[98]` **Lucian Galade**: "“This is worrying. Very worrying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[103]` **Lileas Graf**: "“They will play dirty while we p..." |
| `[104]` | **"“We can't let anyone meddle with our internal stability.”"** | `[98]` **Lucian Galade**: "“This is worrying. Very worrying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lileas Graf**: "“Our security services are doing..." |
| `[110]` | **"“Let's begin.”"** | `[109]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Everyone in the room sat down ex..." |
| `[111]` | **"“Please take your seats.”"** | `[109]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Everyone in the room sat down ex..." |
| `[112]` | **"Nod at Lucian."** | `[109]` **Lucian Galade**: "“Sir.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Narrator**: "Everyone in the room sat down ex..." |
| `[117]` | **"“Can we make any direct correlations between the BFF and Rumburg?”"** | `[98]` **Lucian Galade**: "“This is worrying. Very worrying.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[211]` **Lileas Graf**: "“Not yet but we have suspects th..." |
| `[118]` | **"“They are insignificant. Not worth our attention.”"** | `[40]` **Lileas Graf**: "“These ill-behaved thugs make ou..."<br>`[53]` **Lileas Graf**: "“One is known as the Koranelli a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Lucian Galade**: "“I would be careful with underes..." |
| `[131]` | **"“I am a man of my word, Iosef.”"** | `[128]` **Iosef Lancea**: "“Do not forget that during the e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[133]` **Iosef Lancea**: "“Of course you are and that is w..." |
| `[132]` | **"“As you said times change, Iosef. We will see.”"** | `[128]` **Iosef Lancea**: "“Do not forget that during the e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Narrator**: "Iosef's face instantly soured." |
| `[135]` | **"“As you said times change, Iosef. We will see.”"** | `[129]` **Iosef Lancea**: "“During the election you said no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[138]` **Narrator**: "A smile brought a glimmer of hop..." |
| `[136]` | **"“Maybe you are right. Defense of our nation is more important.”"** | `[129]` **Iosef Lancea**: "“During the election you said no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Iosef Lancea**: "“I knew you would understand, Mr..." |
| `[137]` | **"“I am a man of my word, Iosef.”"** | `[129]` **Iosef Lancea**: "“During the election you said no..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Iosef Lancea**: "“That is a valuable trait, Mr. P..." |
| `[144]` | **"Shake his hand."** | `[8]` **Narrator**: "He was in his 70s, yet he had a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "Iosef tapped his foot impatientl..." |
| `[147]` | **"“True but I am not fully convinced that would be the right choice.”"** | `[154]` **Lileas Graf**: "“You promised to increase Sordla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[159]` **Lileas Graf**: "“If threats from separatists and..." |
| `[148]` | **"“These threats seem more direct than a few bribes.”"** | `[162]` **Nia Morgna**: "“I wish you would stop using the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[164]` **Lileas Graf**: "“They are, and they need all the..." |
| `[149]` | **"“We will stick to that promise, especially in light of all this information.”"** | `[154]` **Lileas Graf**: "“You promised to increase Sordla..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Lileas Graf**: "“We will rid our country from se..." |
| `[156]` | **"“You will do your job whatever happens. Don't come to me with excuses.”"** | `[155]` **Lileas Graf**: "“If the law enforcement budget i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[161]` **Lileas Graf**: "“My job is to keep you fully inf..." |
| `[157]` | **"“In light of this information, I might increase the law enforcement budget.”"** | `[155]` **Lileas Graf**: "“If the law enforcement budget i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[160]` **Lileas Graf**: "“We will rid our country from se..." |
| `[163]` | **"“Valid points. Corruption is the root of all evil, after all.”"** | `[162]` **Nia Morgna**: "“I wish you would stop using the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[165]` **Lileas Graf**: "“We can look into corruption onc..." |
| `[170]` | **"“Lileas, I trust that you can handle them.”"** | `[40]` **Lileas Graf**: "“These ill-behaved thugs make ou..."<br>`[53]` **Lileas Graf**: "“One is known as the Koranelli a..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[169]` **Lileas Graf**: "“I am doing my best, sir."" |
| `[172]` | **"“Your Ministry must tackle the issue with persistence Ms. Morgna.”"** | `[162]` **Nia Morgna**: "“I wish you would stop using the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[171]` **Nia Morgna**: "“We are, but it needs all the at..." |
| `[179]` | **"“Rumburg wouldn't attack any nation allied with any superpower.”"** | `[178]` **Lucian Galade**: "“We should find regional allies ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[187]` **Iosef Lancea**: "“One shudders at the sacrifices ..." |
| `[180]` | **"“Sordland must stand on its own two feet and be able to defend itself.”"** | `[178]` **Lucian Galade**: "“We should find regional allies ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[181]` **Iosef Lancea**: "“Of the same mind, sir.”" |
| `[185]` | **"“These options should be considered.”"** | `[178]` **Lucian Galade**: "“We should find regional allies ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Iosef Lancea**: "“They could be considered, but w..." |
| `[189]` | **"“Your service is appreciated, gentlemen.”"** | `[188]` **Valken Kruger**: "“Understood. Raising military re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[196]` **Iosef Lancea**: "“Thank you, Mr. President. You s..." |
| `[190]` | **""Iosef, welcome.""** | `[6]` **Iosef Lancea**: ""Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[191]` **Iosef Lancea**: ""I brought General Kruger with m..." |
| `[197]` | **"“Go and show them the might of the Sordish Armed Forces.”"** | `[188]` **Valken Kruger**: "“Understood. Raising military re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[198]` **Iosef Lancea**: "“We will. You can be sure of that.”" |
| `[199]` | **"“Make sure they know we are observant and ready.”"** | `[188]` **Valken Kruger**: "“Understood. Raising military re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[200]` **Valken Kruger**: "“'Always watching, always ready'..." |
| `[207]` | **"“Radical? Sordland just lost a great writer. For what?”"** | `[71]` **Lileas Graf**: "“Since he often spoke against th..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Lileas Graf**: "“It is unfortunate, but it was l..." |
| `[208]` | **"“Remain calm. Make sure not to escalate things further. Nobody wants a war.”"** | `[188]` **Valken Kruger**: "“Understood. Raising military re..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[209]` **Iosef Lancea**: "“We will exercise utmost caution..." |
| `[243]` | **""The discrimination Bergia suffers is maddening. We should find a way to revoke th..."** | `[260]` **Lileas Graf**: ""Even though our forces have the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[246]` **Nia Morgna**: ""I will do my best, Mr. President."" |
| `[244]` | **""I'd rather not disturb the status quo while we're facing all these threats.""** | `[260]` **Lileas Graf**: ""Even though our forces have the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[247]` **Lucian Galade**: ""I agree. We shouldn't rush anyt..." |
| `[245]` | **""Governor Bron and his special powers deserve credit for the current peace in the ..."** | `[260]` **Lileas Graf**: ""Even though our forces have the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[248]` **Lucian Galade**: ""The fact that he is an importan..." |
| `[251]` | **""Tell me more about the Special Zone.""** | `[242]` **Nia Morgna**: ""For now, yes. But with enough j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Nia Morgna**: ""As you know, Bergia was given a..." |
| `[252]` | **""No. I'd like to hear more.""** | `[242]` **Nia Morgna**: ""For now, yes. But with enough j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Nia Morgna**: ""As you know, Bergia was given a..." |
| `[253]` | **""Bergia has always been the region of chaos and trouble. We must be careful.""** | `[242]` **Nia Morgna**: ""For now, yes. But with enough j..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[254]` **Nia Morgna**: ""As you know, Bergia was given a..." |
| `[261]` | **""We must reverse this situation. It is absurd that the Ministry of Interior doesn'..."** | `[260]` **Lileas Graf**: ""Even though our forces have the..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[262]` **Lileas Graf**: ""I agree. I have some ideas abou..." |

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
  - -> `[266]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Erzaren_RiseInGolcondism = ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "The two ministers left the room. We took a short break before continuing to the second part."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Upon invitation, Iosef Lancea along with three high-ranki..."*)

### Węzeł `[4]`
Mówca: **Lucian Galade**
> "“Gentlemen, thanks for coming to this significant gathering. Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Narrator: "Iosef and Valken took their seats at the table while the ..."*)

### Węzeł `[5]`
Mówca: **Narrator**
> "Iosef made his way towards the table while the others stood by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Iosef Lancea: ""Mr. President.""*)

### Węzeł `[6]`
Mówca: **Iosef Lancea**
> ""Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Player: ""Let's begin.""*)
  - -> `[190]` (*Player: ""Iosef, welcome.""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Upon invitation, Iosef Lancea along with three high-ranking officials from the Ministry of Defense, walked into the room. One of the men was none other than General Kruger, the Chief of the Armed Forces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "Iosef made his way towards the table while the others sto..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "He was in his 70s, yet he had a bulky body that was a result of his commando training. Not only was he the second-most-decorated officer in Sordland, he was also the longest serving."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“General Kruger.”"*)
  - -> `[144]` (*Player_Italic: "Shake his hand."*)
  - -> `[12]` (*Player_Italic: "Salute him."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "General Kruger stepped forward and saluted. He had a strong jaw with sharp cheekbones. His tall stature, uniform and medals, combined with his deep and intense stare, made him look threatening."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "He was in his 70s, yet he had a bulky body that was a res..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“General Kruger.”"]** — Mówca: **Player**
> "“General Kruger.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Valken Kruger: "“Mr. President. It is an honor.”"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Iosef tapped his foot impatiently. He seemed uneasy with the presence of another high-ranking officer in the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Lucian Galade: "“Gentlemen, thanks for coming to this significant gatheri..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Salute him."]** — Mówca: **Player_Italic**
> "I saluted him."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Narrator: "He smiled at the gesture and bowed his head in respect."*)

### Węzeł `[13]`
Mówca: **Valken Kruger**
> "“Mr. President. It is an honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Iosef tapped his foot impatiently. He seemed uneasy with ..."*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Let's begin.""]** — Mówca: **Player**
> ""Let's begin.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Iosef Lancea: ""I brought General Kruger with me due to the escalation o..."*)

### Węzeł `[15]`
Mówca: **Iosef Lancea**
> "“Mr. President. The situation at the western and northern borders towards Rumburg is very tense. We are observing deployments of divisions closer to our border.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]` (*Węzeł Logiki Narracyjnej: "LookAt("Sordland_Country_Rumburg");"*)

### Węzeł `[16]`
Mówca: **Valken Kruger**
> "“The picture is becoming clearer. The latest information from the Interior about the weapons caches and now there is an active military build-up close to our borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Valken Kruger: "“The entire situation was analysed by our General Staff a..."*)

### Węzeł `[17]`
Mówca: **Valken Kruger**
> "“The entire situation was analysed by our General Staff and our prediction is a future territorial incursion by Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Player: "“I have complete trust in the General Staff.”"*)
  - -> `[23]` (*Player: "“The threat is exaggerated.”"*)
  - -> `[19]` (*Player: "“Let them come, we will give them hell.”"*)

### Węzeł `[18]`
Mówca: **Valken Kruger**
> "“We will not let you down, Mr. President. The General Staff is composed of the smartest military individuals.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Valken Kruger: "“I require an increase in the military budget to enlist m..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“Let them come, we will give them hell.”"]** — Mówca: **Player**
> "“Let them come, we will give them hell.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Valken Kruger: "“I share your enthusiasm. We draw our strength from the b..."*)

### Węzeł `[20]`
Mówca: **Valken Kruger**
> "“With all due respect, I think you are underestimating what we could face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Valken Kruger: "“I require an increase in the military budget to enlist m..."*)

### Węzeł `[21]`
**[WYBÓR GRACZA: "“I have complete trust in the General Staff.”"]** — Mówca: **Player**
> "“I have complete trust in the General Staff.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Valken Kruger: "“We will not let you down, Mr. President. The General Sta..."*)

### Węzeł `[22]`
Mówca: **Valken Kruger**
> "“I share your enthusiasm. We draw our strength from the brave sons and daughters of Sordland but we wouldn't be able to stand against them right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Valken Kruger: "“I require an increase in the military budget to enlist m..."*)

### Węzeł `[23]`
**[WYBÓR GRACZA: "“The threat is exaggerated.”"]** — Mówca: **Player**
> "“I think the threat is exaggerated.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[17]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Valken Kruger: "“With all due respect, I think you are underestimating wh..."*)

### Węzeł `[24]`
Mówca: **Iosef Lancea**
> "“Rumburg has been acting increasingly expansionist in the past decades and also interfered in Agnolia, but now they have turned their sights on us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player: "”I trust the capabilities of our armed forces to handle a..."*)
  - -> `[25]` (*Player: "”This concerns me very much.“"*)
  - -> `[26]` (*Player: "”What is your current strategy?“"*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "”This concerns me very much.“"]** — Mówca: **Player**
> "”This concerns me very much.“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Iosef Lancea: "“We are observing these areas actively. Our contingency p..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "”What is your current strategy?“"]** — Mówca: **Player**
> "”What is your current strategy?“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Iosef Lancea: "“Patrolling close to the borders with our border force an..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "”I trust the capabilities of our armed forces to handle any threats.“"]** — Mówca: **Player**
> "”I trust the capabilities of our armed forces to handle any threats.“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Iosef Lancea: "“I can assure you of our capabilities, but we don't have ..."*)

### Węzeł `[28]`
Mówca: **Iosef Lancea**
> "“I can assure you of our capabilities, but we don't have unlimited resources.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“It seems like they want to increase the pressure both ex..."*)

### Węzeł `[29]`
**[WYBÓR GRACZA: "”Please, General.“"]** — Mówca: **Player**
> "”Please, General.“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Valken Kruger: "“The picture is becoming clearer. The latest information ..."*)

### Węzeł `[30]`
Mówca: **Valken Kruger**
> "”Mr. President, if I may?“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player: "”Please, General.“"*)
  - -> `[36]` (*Player: "”Go on.“"*)

### Węzeł `[31]`
Mówca: **Iosef Lancea**
> "“We are observing these areas actively. Our contingency plans are ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“It seems like they want to increase the pressure both ex..."*)

### Węzeł `[32]`
Mówca: **Iosef Lancea**
> "“Patrolling close to the borders with our border force and keeping army reserve divisions near.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Lucian Galade: "“It seems like they want to increase the pressure both ex..."*)

### Węzeł `[33]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_SnO_SecurityOverview = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_SnO_SecurityOverview"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[34]`
Mówca: **Valken Kruger**
> "“I require an increase in the military budget to enlist more soldiers. Only then, we can stand strong against our enemies. The enlarged armed forces will hold them at bay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Iosef Lancea: "“Valken is right. We do need an increase in the military ..."*)

### Węzeł `[35]`
Mówca: **Iosef Lancea**
> "“Valken is right. We do need an increase in the military budget. Although we don't see eye to eye on exactly how to spend the budget, that much we agree on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Lucian Galade: "“I have my concerns about Rumburg too. We need strong all..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: "”Go on.“"]** — Mówca: **Player**
> "”Go on.“"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[30]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Valken Kruger: "“The picture is becoming clearer. The latest information ..."*)

### Węzeł `[37]`
**[WYBÓR GRACZA: "“Let's move on.”"]** — Mówca: **Player**
> "“Let's move on.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: "“Have a good day.”"*)

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Which two crime families?”"]** — Mówca: **Player**
> "“Which two crime families?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lileas Graf: "“One is known as the Koranelli and the other as the Skinn..."*)

### Węzeł `[39]`
Mówca: **Narrator**
> "I opened the door. Lucian, Nia and Lileas rose from their seats."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Lucian Galade: "“Sir.”"*)

### Węzeł `[40]`
Mówca: **Lileas Graf**
> "“These ill-behaved thugs make our administration look weak. They're also disrupting the peace in those cities, meaning other issues like emigration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "“They are playing with fire. I want them gone. For good.”"*)
  - -> `[170]` (*Player: "“Lileas, I trust that you can handle them.”"*)
  - -> `[118]` (*Player: "“They are insignificant. Not worth our attention.”"*)

### Węzeł `[41]`
Mówca: **Narrator**
> "Today's security briefing was arranged in two parts, starting with internal matters and moving on to external matters after a short break."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "The Minister of Interior, Lileas Graf and the Minister of..."*)

### Węzeł `[42]`
Mówca: **Lileas Graf**
> "“Our highest internal threat comes from the estimated 20000-strong Bludish Freedom Front led by the imprisoned Dewlen Arge. They are a banned political organization, now a militant force that is trying to incite racial violence.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player: "“They make a lot of noise but have little substance. A ba..."*)
  - -> `[44]` (*Player: "“Are they supported by our Bludish citizens?”"*)
  - -> `[45]` (*Player: "“Are they cooperating with any Bludish political organiza..."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "“They make a lot of noise but have little substance. A barking dog doesn't bite.”"]** — Mówca: **Player**
> "“They make a lot of noise but have little substance. A barking dog doesn't bite.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Lileas Graf: "“It may seem that way from the outside, but police intell..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Are they supported by our Bludish citizens?”"]** — Mówca: **Player**
> "“Are they supported by our Bludish citizens?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lileas Graf: "“To some extent. Luckily they couldn't attract a wide aud..."*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "“Are they cooperating with any Bludish political organizations?”"]** — Mówca: **Player**
> "“Are they cooperating with any Bludish political organizations?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Lileas Graf: "“Many suspected links exist between the Bludish Freedom F..."*)

### Węzeł `[46]`
Mówca: **Lileas Graf**
> "“It may seem that way from the outside, but police intelligence shows a real potential for them to become dangerous.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Lileas pointed to page three in the report."*)

### Węzeł `[47]`
Mówca: **Lileas Graf**
> "“To some extent. Luckily they couldn't attract a wide audience of Bluds. But they could potentially attract thousands if anti-Bludish sentiment spreads in Sordland again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Lileas pointed to page three in the report."*)

### Węzeł `[48]`
Mówca: **Lileas Graf**
> "“We expect that more have been smuggled in. A group of Bluds were caught with these guns at a checkpoint not far away.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]` (*Lileas Graf: ""The governor of Bergia, Phelix Bron, is already taking t..."*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> "“This is grave news, but we must be careful not to stoke the fires of anti-Bludish sentiment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]` (*Nia Morgna: ""Unfortunately, Governor Bron is directly causing the ten..."*)

### Węzeł `[50]`
Mówca: **Lileas Graf**
> "“It is the gang violence that is threatening the Nargis and Agnland regions. Two prominent organized crime families are at war, and the potential for bloodshed is real.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Player: "“Which two crime families?”"*)
  - -> `[51]` (*Player: "“Why can't we just arrest them?”"*)
  - -> `[52]` (*Player: "“I don't think mere gangs can pose a threat to us.”"*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Why can't we just arrest them?”"]** — Mówca: **Player**
> "“Why can't we just arrest them?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Lileas Graf: "“The primary reason is deception and corruption. They inf..."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "“I don't think mere gangs can pose a threat to us.”"]** — Mówca: **Player**
> "“I don't think mere gangs can pose a threat to us.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Lileas Graf: "“These ill-behaved thugs make our administration look wea..."*)

### Węzeł `[53]`
Mówca: **Lileas Graf**
> "“One is known as the Koranelli and the other as the Skinner Cartel. They used to be allies until a recent disagreement. Both are active in the cities of Narbel and Estord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "“They are playing with fire. I want them gone. For good.”"*)
  - -> `[170]` (*Player: "“Lileas, I trust that you can handle them.”"*)
  - -> `[118]` (*Player: "“They are insignificant. Not worth our attention.”"*)

### Węzeł `[54]`
Mówca: **Lileas Graf**
> "“The primary reason is deception and corruption. They infiltrated several government offices and the police. That's how they can evade us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Player: "“They are playing with fire. I want them gone. For good.”"*)
  - -> `[170]` (*Player: "“Lileas, I trust that you can handle them.”"*)
  - -> `[118]` (*Player: "“They are insignificant. Not worth our attention.”"*)

### Węzeł `[55]`
**[WYBÓR GRACZA: "“They are playing with fire. I want them gone. For good.”"]** — Mówca: **Player**
> "“They are playing with fire. I want them gone. For good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf), `[53]` (Lileas Graf), `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: "“While I agree it would make Sordland a better place, it ..."*)

### Węzeł `[56]`
Mówca: **Lucian Galade**
> "“Thank you for the updates, Mrs. Graf, Mrs. Morgna.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Player: "“Thank you for the overview.”"*)
  - -> `[37]` (*Player: "“Let's move on.”"*)

### Węzeł `[57]`
**[WYBÓR GRACZA: "“Thank you for the overview.”"]** — Mówca: **Player**
> "“Thank you for the overview.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[56]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Nia Morgna: "“Have a good day.”"*)

### Węzeł `[58]`
Mówca: **Nia Morgna**
> "“Have a good day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Lileas Graf: "“Until next time.”"*)

### Węzeł `[59]`
Mówca: **Lileas Graf**
> "“Until next time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Narrator: "The two ministers left the room. We took a short break be..."*)

### Węzeł `[60]`
Mówca: **Lileas Graf**
> "“I have received news this morning that the investigation into the murder of Bernard Circas has concluded.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Player: "“Great news. I am eager to hear about the details.”"*)
  - -> `[62]` (*Player: "“Please enlighten us. The more we know, the better.”"*)

### Węzeł `[61]`
Mówca: **Lileas Graf**
> "“After further investigation and testimonies, we have confirmed the motive and also the events leading up to the shooting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lileas Graf: "“A few days prior, members of the Red Youth initiated a v..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Please enlighten us. The more we know, the better.”"]** — Mówca: **Player**
> "“Please enlighten us. The more we know, the better.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“After further investigation and testimonies, we have con..."*)

### Węzeł `[63]`
**[WYBÓR GRACZA: "“Great news. I am eager to hear about the details.”"]** — Mówca: **Player**
> "“Great news. I am eager to hear about the details.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[60]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Lileas Graf: "“After further investigation and testimonies, we have con..."*)

### Węzeł `[64]`
Mówca: **Nia Morgna**
> "“The reports around the country indicate that tensions are rising as we feared.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Order_Nationwide_Revolt = true; BaseGa..."*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Political violence needs to stop.”"]** — Mówca: **Player**
> "“Political violence needs to stop now.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Lileas Graf: "“Yes. We've kept it at bay for so long, but it seems that..."*)

### Węzeł `[66]`
**[WYBÓR GRACZA: "“He had it coming then.”"]** — Mówca: **Player**
> "“He had it coming then.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Narrator: "Lileas Graf cleared her throat."*)

### Węzeł `[67]`
Mówca: **Lileas Graf**
> "“Mr. Rayne, we have done our due diligence, and the funding; operatives and strategy all point to a coup plot.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She took a sip from her glass of water and continued."*)

### Węzeł `[68]`
Mówca: **Lileas Graf**
> "“Nearly three decades ago, they funded General Rikard and tried to establish a communist dictatorship in our country. If it was not for Colonel Soll, we would have seen the real crisis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]` (*Narrator: "She took a sip from her glass of water and continued."*)

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Our country always had issues, this is a part of our job.”"]** — Mówca: **Player**
> "“Our country always had issues, this is a part of our job.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Nia Morgna: "“If we give up essential freedoms to purchase temporary s..."*)

### Węzeł `[70]`
Mówca: **Lileas Graf**
> "“A few days prior, members of the Red Youth initiated a violent attack on a Young Sords local leader in Jen. We believe the Young Sords then called for revenge, leading to the death of Mr. Circas.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Lileas Graf: "“Since he often spoke against the Young Sords and nationa..."*)

### Węzeł `[71]`
Mówca: **Lileas Graf**
> "“Since he often spoke against the Young Sords and nationalist sentiments in the Assembly, he was a big target. Not to mention his radical communist views.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Player: "“Political violence needs to stop.”"*)
  - -> `[66]` (*Player: "“He had it coming then.”"*)
  - -> `[207]` (*Player: "“Radical? Sordland just lost a great writer. For what?”"*)
  - -> `[226]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == false"*)

### Węzeł `[72]`
**[WYBÓR GRACZA: "“The Red Youth are clearly to blame since they triggered it.”"]** — Mówca: **Player**
> "“The Red Youth are clearly to blame since they triggered it.”"
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == false`
- **Kontekst wejściowy (poprzednik):** `[71]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Lileas Graf: "“They struck first, yes. It was obvious that there would ..."*)

### Węzeł `[73]`
Mówca: **Lileas Graf**
> "“Yes. We've kept it at bay for so long, but it seems that there are now new triggers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lileas handed over the report and pointed at a highlighte..."*)

### Węzeł `[74]`
Mówca: **Lileas Graf**
> "“It is unfortunate, but it was likely that an incident would happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lileas handed over the report and pointed at a highlighte..."*)

### Węzeł `[75]`
Mówca: **Lileas Graf**
> "“They struck first, yes. It was obvious that there would be a retaliation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Narrator: "Lileas handed over the report and pointed at a highlighte..."*)

### Węzeł `[76]`
Mówca: **Lileas Graf**
> "“The investigation revealed a very troubling fact. The funding sources of the Red Youth have a clear link to United Contana.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: "“What does this mean?”"*)
  - -> `[83]` (*Player: "“Are you sure?”"*)
  - -> `[84]` (*Player: "“This is proof that they are meddling in our affairs.”"*)

### Węzeł `[77]`
Mówca: **Narrator**
> "She took a sip from her glass of water and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lileas Graf: "“Our police chief Karl Greiser has linked the funding cha..."*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“I also don't want to jump to conclusions immediately. We shouldn't create a crisis with them.”"]** — Mówca: **Player**
> "“I also don't want to jump to conclusions. We shouldn't create a crisis with them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Lileas Graf: "“Nearly three decades ago, they funded General Rikard and..."*)

### Węzeł `[79]`
**[WYBÓR GRACZA: "“I trust Ms. Graf's judgement. United Contana is clearly trying to expand its influence.”"]** — Mówca: **Player**
> "“I trust Ms. Graf's judgement. United Contana is clearly trying to expand its influence.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[90]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Lileas Graf: "“Mr. Rayne, we have done our due diligence, and the fundi..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> "“This is debatable. But yes, we know what more security and surveillance caused to this country under President Soll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Lileas Graf: "“Let's not forget that President Soll, God bless him, bro..."*)

### Węzeł `[81]`
Mówca: **Narrator**
> "Lileas handed over the report and pointed at a highlighted section in the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Lileas Graf: "“The investigation revealed a very troubling fact. The fu..."*)

### Węzeł `[82]`
**[WYBÓR GRACZA: "“What does this mean?”"]** — Mówca: **Player**
> "“What does this mean?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lileas Graf: "“That the communist superpower is meddling in our affairs.”"*)

### Węzeł `[83]`
**[WYBÓR GRACZA: "“Are you sure?”"]** — Mówca: **Player**
> "“Are you absolutely sure?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Lileas Graf: "“Yes, we have found the cash trail.”"*)

### Węzeł `[84]`
**[WYBÓR GRACZA: "“This is proof that they are meddling in our affairs.”"]** — Mówca: **Player**
> "“This is proof that they are meddling in our affairs.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[76]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lileas Graf: "“Exactly.”"*)

### Węzeł `[85]`
Mówca: **Lileas Graf**
> "“That the communist superpower is meddling in our affairs.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“Several Red Youth members with ties to United Contana ha..."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“As we feared, the political atmosphere has worsened.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Nia Morgna: "“The reports around the country indicate that tensions ar..."*)

### Węzeł `[87]`
Mówca: **Lileas Graf**
> "“Yes, we have found the cash trail.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“Several Red Youth members with ties to United Contana ha..."*)

### Węzeł `[88]`
Mówca: **Lileas Graf**
> "“Exactly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Lileas Graf: "“Several Red Youth members with ties to United Contana ha..."*)

### Węzeł `[89]`
Mówca: **Lileas Graf**
> "“Several Red Youth members with ties to United Contana have been detained, and the information extracted from them points to a preparation for a communist uprising in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: "“It isn't unusual for the superpowers to influence other ..."*)

### Węzeł `[90]`
Mówca: **Nia Morgna**
> "“I went over the report in detail. It would be wrong to jump to conclusions about a clear foreign interference yet. United Contana has humanitarian and cultural ties with many countries including Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Player: "“I trust Ms. Graf's judgement. United Contana is clearly ..."*)
  - -> `[78]` (*Player: "“I also don't want to jump to conclusions immediately. We..."*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> "“It isn't unusual for the superpowers to influence other nations but I think this case is a little far-fetched. The left lacks popular support in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]` (*Narrator: "Nia eagerly lifted her hand. I motioned for her to speak."*)

### Węzeł `[92]`
Mówca: **Lileas Graf**
> "“Our police chief Karl Greiser has linked the funding channel to the United Contana Consulate in Benfi.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lileas Graf: "“As we all know, the enemies of Sordland are many, but we..."*)

### Węzeł `[93]`
Mówca: **Lileas Graf**
> "“As we all know, the enemies of Sordland are many, but we also have threats inside the country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Player: "“We need to remain vigilant.”"*)
  - -> `[94]` (*Player: "“As the government we have all the power to deal with any..."*)
  - -> `[69]` (*Player: "“Our country always had issues, this is a part of our job.”"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“As the government we have all the power to deal with any threat.”"]** — Mówca: **Player**
> "“As the government we have all the power to deal with any threat that we face.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Nia Morgna: "“If we give up essential freedoms to purchase temporary s..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: "“We need to remain vigilant.”"]** — Mówca: **Player**
> "“We need to remain vigilant as a people and nation.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[93]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Nia Morgna: "“If we give up essential freedoms to purchase temporary s..."*)

### Węzeł `[96]`
Mówca: **Nia Morgna**
> "“If we give up essential freedoms to purchase temporary security, we deserve neither freedoms nor security.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: "“This is debatable. But yes, we know what more security a..."*)

### Węzeł `[97]`
Mówca: **Lileas Graf**
> "“Let's not forget that President Soll, God bless him, brought stability after a long period of bloodshed and chaos. But moving on...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lileas Graf: "“Our highest internal threat comes from the estimated 200..."*)

### Węzeł `[98]`
Mówca: **Lucian Galade**
> "“This is worrying. Very worrying.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Player: "“Can we make any direct correlations between the BFF and ..."*)
  - -> `[100]` (*Player: "“It was expected that Rumburg would undermine us, but thi..."*)
  - -> `[101]` (*Player: "“We need to keep level-headed with Rumburg. They are look..."*)
  - -> `[104]` (*Player: "“We can't let anyone meddle with our internal stability.”"*)

### Węzeł `[99]`
Mówca: **Lileas Graf**
> "“Many suspected links exist between the Bludish Freedom Front and the Workers' Party of Bludia, but we don't have concrete proof yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Narrator: "Lileas pointed to page three in the report."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“It was expected that Rumburg would undermine us, but this is too far.”"]** — Mówca: **Player**
> "“It was expected that Rumburg would undermine us, but this is too far.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Lileas Graf: "“I agree, the prospect of arming our population against u..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“We need to keep level-headed with Rumburg. They are looking for reasons to take action.”"]** — Mówca: **Player**
> "“We need to keep level-headed with Rumburg. They are looking for reasons to take action.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lileas Graf: "“They will play dirty while we play nice. It is a battle ..."*)

### Węzeł `[102]`
Mówca: **Lileas Graf**
> "“I agree, the prospect of arming our population against us is a step too far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: "“This is grave news, but we must be careful not to stoke ..."*)

### Węzeł `[103]`
Mówca: **Lileas Graf**
> "“They will play dirty while we play nice. It is a battle we will lose.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: "“This is grave news, but we must be careful not to stoke ..."*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“We can't let anyone meddle with our internal stability.”"]** — Mówca: **Player**
> "“We can't let anyone meddle with our internal stability.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lileas Graf: "“Our security services are doing their best to prevent fu..."*)

### Węzeł `[105]`
Mówca: **Lileas Graf**
> "“Our security services are doing their best to prevent further attempts.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: "“This is grave news, but we must be careful not to stoke ..."*)

### Węzeł `[106]`
Mówca: **Lucian Galade**
> "“I have my concerns about Rumburg too. We need strong allies to withstand such a superior power. They are our nemesis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Iosef Lancea: "“That is an understatement. Times are changing and war is..."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "I arrived in front of the doors leading to the Situation Room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_1927NeverAgain = true"*)

### Węzeł `[108]`
Mówca: **Narrator**
> "The Minister of Interior, Lileas Graf and the Minister of Justice and Law, Nia Morgna would join us for the first part, the law enforcement briefing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Narrator: "For the second part the Minister of Defense, Iosef Lancea..."*)

### Węzeł `[109]`
Mówca: **Lucian Galade**
> "“Sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: "“Let's begin.”"*)
  - -> `[111]` (*Player: "“Please take your seats.”"*)
  - -> `[112]` (*Player_Italic: "Nod at Lucian."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Everyone in the room sat down except for Lucian. He put o..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Please take your seats.”"]** — Mówca: **Player**
> "“Please take your seats.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Everyone in the room sat down except for Lucian. He put o..."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "Nod at Lucian."]** — Mówca: **Player_Italic**
> "I nodded at Lucian and sat down."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[109]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Narrator: "Everyone in the room sat down except for Lucian. He put o..."*)

### Węzeł `[113]`
Mówca: **Narrator**
> "Everyone in the room sat down except for Lucian. He put on his glasses and went through the documents in front of him. Shortly after, he raised his head to address the attendees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: "“Mr. President. Ladies. We will kick off today's meeting ..."*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> "“I am assuming everyone has already been over the agenda. We all have busy schedules. So without further ado, I will jump into our first topic.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“As we feared, the political atmosphere has worsened.”"*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> "“Mr. President. Ladies. We will kick off today's meeting with the internal security briefing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: "“I am assuming everyone has already been over the agenda...."*)

### Węzeł `[116]`
Mówca: **Narrator**
> "Lileas Graf cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lileas Graf: "“It is unfortunate, but it was likely that an incident wo..."*)

### Węzeł `[117]`
**[WYBÓR GRACZA: "“Can we make any direct correlations between the BFF and Rumburg?”"]** — Mówca: **Player**
> "“Can we make any direct correlations between the BFF and Rumburg?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[98]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Lileas Graf: "“Not yet but we have suspects that indicate such a correl..."*)

### Węzeł `[118]`
**[WYBÓR GRACZA: "“They are insignificant. Not worth our attention.”"]** — Mówca: **Player**
> "“They are insignificant. Not worth our attention.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf), `[53]` (Lileas Graf), `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: "“I would be careful with underestimating them, sir. They ..."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> "“I would be careful with underestimating them, sir. They might cause legitimate unrest if this goes on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Nia Morgna: "“These gangs exist because corruption is so common in our..."*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> "“While I agree it would make Sordland a better place, it will not be easy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Nia Morgna: "“These gangs exist because corruption is so common in our..."*)

### Węzeł `[121]`
Mówca: **Lileas Graf**
> "“Well, this concludes the topics for the internal portion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Lucian Galade: "“Thank you for the updates, Mrs. Graf, Mrs. Morgna.”"*)

### Węzeł `[122]`
Mówca: **Narrator**
> "For the second part the Minister of Defense, Iosef Lancea would join with a few high-ranking officials including the Chief of the Armed Forces Valken Kruger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Narrator: "I opened the door. Lucian, Nia and Lileas rose from their..."*)

### Węzeł `[123]`
Mówca: **Narrator**
> "He smiled at the gesture and bowed his head in respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Iosef tapped his foot impatiently. He seemed uneasy with ..."*)

### Węzeł `[124]`
Mówca: **Narrator**
> "Iosef and Valken took their seats at the table while the rest of the officers stood by the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Iosef Lancea: "“Mr. President. The situation at the western and northern..."*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Military == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Military == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Iosef Lancea: "“Do not forget that during the election you promised to f..."*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Military == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Iosef Lancea: "“During the election you said nothing about focusing on o..."*)

### Węzeł `[128]`
Mówca: **Iosef Lancea**
> "“Do not forget that during the election you promised to focus on the military. I expect that word to be kept for the defense of our nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: "“I am a man of my word, Iosef.”"*)
  - -> `[132]` (*Player: "“As you said times change, Iosef. We will see.”"*)

### Węzeł `[129]`
Mówca: **Iosef Lancea**
> "“During the election you said nothing about focusing on our military. I ask you to reconsider and to increase the military budget. The future and safety of Sordland is in your hands.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Player: "“I am a man of my word, Iosef.”"*)
  - -> `[136]` (*Player: "“Maybe you are right. Defense of our nation is more impor..."*)
  - -> `[135]` (*Player: "“As you said times change, Iosef. We will see.”"*)

### Węzeł `[130]`
Mówca: **Iosef Lancea**
> "“That is an understatement. Times are changing and war is coming, Mr. President, whether we like it or not. We must be prepared.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Military == true"*)

### Węzeł `[131]`
**[WYBÓR GRACZA: "“I am a man of my word, Iosef.”"]** — Mówca: **Player**
> "“I am a man of my word, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Iosef Lancea: "“Of course you are and that is why I follow you, Mr. Pres..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: "“As you said times change, Iosef. We will see.”"]** — Mówca: **Player**
> "“As you said before, times change, Iosef. We will see.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Iosef's face instantly soured."*)

### Węzeł `[133]`
Mówca: **Iosef Lancea**
> "“Of course you are and that is why I follow you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Valken Kruger: "“The only way we can guarantee the national survival is t..."*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Iosef's face instantly soured."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Valken Kruger: "“The only way we can guarantee the national survival is t..."*)

### Węzeł `[135]`
**[WYBÓR GRACZA: "“As you said times change, Iosef. We will see.”"]** — Mówca: **Player**
> "“As you said before, times change, Iosef. We will see.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Narrator: "A smile brought a glimmer of hope on Iosef's face."*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Maybe you are right. Defense of our nation is more important.”"]** — Mówca: **Player**
> "“Maybe you are right. Defense of our nation is more important.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Iosef Lancea: "“I knew you would understand, Mr. President.”"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“I am a man of my word, Iosef.”"]** — Mówca: **Player**
> "“I am a man of my word, Iosef.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Iosef Lancea: "“That is a valuable trait, Mr. President. However, it wil..."*)

### Węzeł `[138]`
Mówca: **Narrator**
> "A smile brought a glimmer of hope on Iosef's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Valken Kruger: "“Our forces would crumble under a decrease and Rumburg wo..."*)

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“That is a valuable trait, Mr. President. However, it will not help when the enemy armies are invading our cities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Valken Kruger: "“Our forces would crumble under a decrease and Rumburg wo..."*)

### Węzeł `[140]`
Mówca: **Iosef Lancea**
> "“I knew you would understand, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Valken Kruger: "“Our forces would crumble under a decrease and Rumburg wo..."*)

### Węzeł `[141]`
Mówca: **Iosef Lancea**
> "“Valken, we should go to the Ministry and get further updates from our branches.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Valken Kruger: "“Understood. Raising military readiness is the first call..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "They saluted and left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Rumburg was already testing us and the reports from the I..."*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Rumburg had decided to close their consulate in Lachaven."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)

### Węzeł `[144]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "His handshake was firm, strong and confident."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Iosef tapped his foot impatiently. He seemed uneasy with ..."*)

### Węzeł `[145]`
Mówca: **Narrator**
> "Everyone fell silent when a soldier entered the room and let Iosef Lancea know that a call had come through from the Ministry."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Iosef Lancea: "“Excuse me, Mr. President.”"*)

### Węzeł `[146]`
Mówca: **Lileas Graf**
> "“I shall be honest with you. With our current capabilities, we may not be able to prevent the further arming of separatists while maintaining order in Bergia, Nargis and Agnland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“True but I am not fully convinced that would be the right choice.”"]** — Mówca: **Player**
> "“True but I am not fully convinced that would be the right choice.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Lileas Graf: "“If threats from separatists and violent thugs aren't cau..."*)

### Węzeł `[148]`
**[WYBÓR GRACZA: "“These threats seem more direct than a few bribes.”"]** — Mówca: **Player**
> "“These threats seem more direct than a few bribes.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]` (*Lileas Graf: "“They are, and they need all the attention they can get f..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“We will stick to that promise, especially in light of all this information.”"]** — Mówca: **Player**
> "“We will stick to that promise, especially in light of all this information.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Lileas Graf: "“We will rid our country from separatists and violent thu..."*)

### Węzeł `[150]`
Mówca: **Narrator**
> "Lileas Graf sighed deeply."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Lileas Graf: "“I shall be honest with you. With our current capabilitie..."*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Promise_TermFocus_Security == true"*)
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Promise_TermFocus_Security == true)"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Promise_TermFocus_Security == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Security"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Lileas Graf: "“You promised to increase Sordland's security and law enf..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Promise_TermFocus_Security == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Security"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Lileas Graf: "“If the law enforcement budget isn't increased, I can't b..."*)

### Węzeł `[154]`
Mówca: **Lileas Graf**
> "“You promised to increase Sordland's security and law enforcement budget. You must keep this promise.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“We will stick to that promise, especially in light of al..."*)
  - -> `[147]` (*Player: "“True but I am not fully convinced that would be the righ..."*)

### Węzeł `[155]`
Mówca: **Lileas Graf**
> "“If the law enforcement budget isn't increased, I can't be fully responsible for what happens. Our police units are spread thin as is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Player: "“In light of this information, I might increase the law e..."*)
  - -> `[156]` (*Player: "“You will do your job whatever happens. Don't come to me ..."*)

### Węzeł `[156]`
**[WYBÓR GRACZA: "“You will do your job whatever happens. Don't come to me with excuses.”"]** — Mówca: **Player**
> "“You will do your job whatever happens. Don't come to me with excuses.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Lileas Graf: "“My job is to keep you fully informed, and this is the re..."*)

### Węzeł `[157]`
**[WYBÓR GRACZA: "“In light of this information, I might increase the law enforcement budget.”"]** — Mówca: **Player**
> "“In light of this information, I might increase the law enforcement budget.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[155]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Lileas Graf: "“We will rid our country from separatists and violent thu..."*)

### Węzeł `[158]`
Mówca: **Lileas Graf**
> "“We will rid our country from separatists and violent thugs if you support us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: "“I wish you would stop using the word 'thugs', Lileas. Th..."*)

### Węzeł `[159]`
Mówca: **Lileas Graf**
> "“If threats from separatists and violent thugs aren't cause for serious concern on your end, I don't know what will be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: "“I wish you would stop using the word 'thugs', Lileas. Th..."*)

### Węzeł `[160]`
Mówca: **Lileas Graf**
> "“We will rid our country from separatists and violent thugs if you do so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: "“I wish you would stop using the word 'thugs', Lileas. Th..."*)

### Węzeł `[161]`
Mówca: **Lileas Graf**
> "“My job is to keep you fully informed, and this is the reality. My experience and expertise in keeping our country safe from violent thugs can only go so far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Nia Morgna: "“I wish you would stop using the word 'thugs', Lileas. Th..."*)

### Węzeł `[162]`
Mówca: **Nia Morgna**
> "“I wish you would stop using the word 'thugs', Lileas. The real problem is corruption, which is fuelling the gang violence and is very likely the reason why these weapons were smuggled in. A higher budget could help us end that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: "“Valid points. Corruption is the root of all evil, after ..."*)
  - -> `[172]` (*Player: "“Your Ministry must tackle the issue with persistence Ms...."*)
  - -> `[148]` (*Player: "“These threats seem more direct than a few bribes.”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Valid points. Corruption is the root of all evil, after all.”"]** — Mówca: **Player**
> "“Valid points. Corruption is the root of all evil, after all.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Lileas Graf: "“We can look into corruption once the weapons have been f..."*)

### Węzeł `[164]`
Mówca: **Lileas Graf**
> "“They are, and they need all the attention they can get from our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Lilieas and Nia were openly scowling at each other. Lilea..."*)

### Węzeł `[165]`
Mówca: **Lileas Graf**
> "“We can look into corruption once the weapons have been found and the gangs have been beaten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Nia Morgna: "“Just like previous administrations, kicking the can down..."*)

### Węzeł `[166]`
Mówca: **Narrator**
> "Lileas pointed to page three in the report."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Lileas Graf: "“Our intelligence intercepted two crates filled with weap..."*)

### Węzeł `[167]`
Mówca: **Lileas Graf**
> "“Our intelligence intercepted two crates filled with weapons close to the Rumburg border. They were filled with military-grade KA-74s.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lileas Graf: "“We expect that more have been smuggled in. A group of Bl..."*)

### Węzeł `[168]`
Mówca: **Lucian Galade**
> "“Rumburg has been acting aggressively in the region for a long time. I am not surprised that they would attempt to weaponize the Bludish people against us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Lucian Galade: "“This is worrying. Very worrying.”"*)

### Węzeł `[169]`
Mówca: **Lileas Graf**
> "“I am doing my best, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Lileas Graf sighed deeply."*)

### Węzeł `[170]`
**[WYBÓR GRACZA: "“Lileas, I trust that you can handle them.”"]** — Mówca: **Player**
> "“Lileas, I trust that you can handle them.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[40]` (Lileas Graf), `[53]` (Lileas Graf), `[54]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Lileas Graf: "“I am doing my best, sir.""*)

### Węzeł `[171]`
Mówca: **Nia Morgna**
> "“We are, but it needs all the attention it can get from our administration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Lilieas and Nia were openly scowling at each other. Lilea..."*)

### Węzeł `[172]`
**[WYBÓR GRACZA: "“Your Ministry must tackle the issue with persistence Ms. Morgna.”"]** — Mówca: **Player**
> "“Your Ministry must tackle the issue with persistence, Ms. Morgna.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[162]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Nia Morgna: "“We are, but it needs all the attention it can get from o..."*)

### Węzeł `[173]`
Mówca: **Nia Morgna**
> "“Just like previous administrations, kicking the can down the road... This is what's destroying our institutions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]` (*Narrator: "Lilieas and Nia were openly scowling at each other. Lilea..."*)

### Węzeł `[174]`
Mówca: **Lucian Galade**
> "“It seems like they want to increase the pressure both externally and internally.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]` (*Węzeł Logiki Narracyjnej: "LookAtModeOff();"*)

### Węzeł `[175]`
Mówca: **Valken Kruger**
> "“Our forces would crumble under a decrease and Rumburg would be much more compelled to exploit our weakness.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Valken Kruger: "“Our country hasn't fallen to any invading force for two-..."*)

### Węzeł `[176]`
Mówca: **Valken Kruger**
> "“The only way we can guarantee the national survival is through a more capable military force against Rumburg.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Valken Kruger: "“Our country hasn't fallen to any invading force for two-..."*)

### Węzeł `[177]`
Mówca: **Valken Kruger**
> "“Our country hasn't fallen to any invading force for two-hundred years, you cannot let it happen, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Lucian Galade: "“We should find regional allies like Valgsland or Lespia ..."*)

### Węzeł `[178]`
Mówca: **Lucian Galade**
> "“We should find regional allies like Valgsland or Lespia to deter Rumburg. There are several options on the table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Player: "“Rumburg wouldn't attack any nation allied with any super..."*)
  - -> `[180]` (*Player: "“Sordland must stand on its own two feet and be able to d..."*)
  - -> `[185]` (*Player: "“These options should be considered.”"*)

### Węzeł `[179]`
**[WYBÓR GRACZA: "“Rumburg wouldn't attack any nation allied with any superpower.”"]** — Mówca: **Player**
> "“Rumburg wouldn't attack any nation allied with any superpower.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]` (*Iosef Lancea: "“One shudders at the sacrifices they would require us to ..."*)

### Węzeł `[180]`
**[WYBÓR GRACZA: "“Sordland must stand on its own two feet and be able to defend itself.”"]** — Mówca: **Player**
> "“Sordland must stand on its own two feet and be able to defend itself.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Iosef Lancea: "“Of the same mind, sir.”"*)

### Węzeł `[181]`
Mówca: **Iosef Lancea**
> "“Of the same mind, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Valken Kruger: "“We stand strong as we've always done.”"*)

### Węzeł `[182]`
Mówca: **Valken Kruger**
> "“We stand strong as we've always done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Everyone fell silent when a soldier entered the room and ..."*)

### Węzeł `[183]`
Mówca: **Valken Kruger**
> "“We have no true friends outside these borders.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Everyone fell silent when a soldier entered the room and ..."*)

### Węzeł `[184]`
Mówca: **Iosef Lancea**
> "“They could be considered, but why pander to others when we can solve these issues ourselves?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]` (*Valken Kruger: "“We have no true friends outside these borders.”"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: "“These options should be considered.”"]** — Mówca: **Player**
> "“These options should be considered.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[178]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Iosef Lancea: "“They could be considered, but why pander to others when ..."*)

### Węzeł `[186]`
Mówca: **Valken Kruger**
> "“Yes, but what is difference between losing your independence to one or the other?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Narrator: "Everyone fell silent when a soldier entered the room and ..."*)

### Węzeł `[187]`
Mówca: **Iosef Lancea**
> "“One shudders at the sacrifices they would require us to make.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]` (*Valken Kruger: "“Yes, but what is difference between losing your independ..."*)

### Węzeł `[188]`
Mówca: **Valken Kruger**
> "“Understood. Raising military readiness is the first call of action. If there is truly an extraordinary attempt, we will relay it to you immediately and wait for further orders, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Player: "“Make sure they know we are observant and ready.”"*)
  - -> `[197]` (*Player: "“Go and show them the might of the Sordish Armed Forces.”"*)
  - -> `[189]` (*Player: "“Your service is appreciated, gentlemen.”"*)
  - -> `[208]` (*Player: "“Remain calm. Make sure not to escalate things further. N..."*)

### Węzeł `[189]`
**[WYBÓR GRACZA: "“Your service is appreciated, gentlemen.”"]** — Mówca: **Player**
> "“Your service is appreciated, gentlemen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]` (*Iosef Lancea: "“Thank you, Mr. President. You shall be updated if the si..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""Iosef, welcome.""]** — Mówca: **Player**
> ""Iosef, welcome.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Iosef Lancea: ""I brought General Kruger with me due to the escalation o..."*)

### Węzeł `[191]`
Mówca: **Iosef Lancea**
> ""I brought General Kruger with me due to the escalation on our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "General Kruger stepped forward and saluted. He had a stro..."*)

### Węzeł `[192]`
Mówca: **Iosef Lancea**
> "“Excuse me, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]` (*Narrator: "Iosef left the room to answer."*)

### Węzeł `[193]`
Mówca: **Narrator**
> "Iosef left the room to answer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Narrator: "A few minutes later he entered the room again. His expres..."*)

### Węzeł `[194]`
Mówca: **Narrator**
> "A few minutes later he entered the room again. His expression had changed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Iosef Lancea: "“Mr. President. There has been Rumburgian military activi..."*)

### Węzeł `[195]`
Mówca: **Iosef Lancea**
> "“Mr. President. There has been Rumburgian military activity close to the Narbel border. I just spoke with the local commander.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Iosef Lancea: "“Valken, we should go to the Ministry and get further upd..."*)

### Węzeł `[196]`
Mówca: **Iosef Lancea**
> "“Thank you, Mr. President. You shall be updated if the situation escalates.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Valken Kruger: "“Hail Sordland!”"*)

### Węzeł `[197]`
**[WYBÓR GRACZA: "“Go and show them the might of the Sordish Armed Forces.”"]** — Mówca: **Player**
> "“Go and show them the might of the Sordish Armed Forces.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Iosef Lancea: "“We will. You can be sure of that.”"*)

### Węzeł `[198]`
Mówca: **Iosef Lancea**
> "“We will. You can be sure of that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Valken Kruger: "“Hail Sordland!”"*)

### Węzeł `[199]`
**[WYBÓR GRACZA: "“Make sure they know we are observant and ready.”"]** — Mówca: **Player**
> "“Make sure they know we are observant and ready.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Valken Kruger: "“'Always watching, always ready' is our motto, sir.”"*)

### Węzeł `[200]`
Mówca: **Valken Kruger**
> "“'Always watching, always ready' is our motto, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Valken Kruger: "“Hail Sordland!”"*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Rumburg was already testing us and the reports from the Interior indicate interference inside our borders. Communists, Nationalists, Bludish rebels, Rumburg expansionism? What was next?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Narrator: "Sordland had always been a key piece in the chessboard of..."*)

### Węzeł `[202]`
Mówca: **Narrator**
> "Sordland had always been a key piece in the chessboard of the global rivalry between Arcasia and United Contana. But in the recent years, there was no such aggression from Rumburg. Not at these levels at least."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]` (*Narrator: "All it takes is one tiny spark to start the flames of war."*)

### Węzeł `[203]`
Mówca: **Valken Kruger**
> "“Hail Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Iosef Lancea: "“Hail!”"*)

### Węzeł `[204]`
Mówca: **Narrator**
> "All it takes is one tiny spark to start the flames of war."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Narrator: "The phone rang."*)

### Węzeł `[205]`
Mówca: **Narrator**
> "The phone rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Rumburg had decided to close their consulate in Lachaven."*)

### Węzeł `[206]`
Mówca: **Lucian Galade**
> "“What is the status on the Bernard Circas investigation?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Lileas Graf: "“I have received news this morning that the investigation..."*)

### Węzeł `[207]`
**[WYBÓR GRACZA: "“Radical? Sordland just lost a great writer. For what?”"]** — Mówca: **Player**
> "“Radical? Sordland just lost a great writer. For what?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[71]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lileas Graf: "“It is unfortunate, but it was likely that an incident wo..."*)

### Węzeł `[208]`
**[WYBÓR GRACZA: "“Remain calm. Make sure not to escalate things further. Nobody wants a war.”"]** — Mówca: **Player**
> "“Remain calm. Make sure not to escalate things further. Nobody wants a war.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[188]` (Valken Kruger)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Iosef Lancea: "“We will exercise utmost caution, Mr. President.”"*)

### Węzeł `[209]`
Mówca: **Iosef Lancea**
> "“We will exercise utmost caution, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Valken Kruger: "“Hail Sordland!”"*)

### Węzeł `[210]`
Mówca: **Iosef Lancea**
> "“Hail!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "They saluted and left the room."*)

### Węzeł `[211]`
Mówca: **Lileas Graf**
> "“Not yet but we have suspects that indicate such a correlation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: "“This is grave news, but we must be careful not to stoke ..."*)

### Węzeł `[212]`
Mówca: **Nia Morgna**
> "“These gangs exist because corruption is so common in our country. They buy our police officers and slip by checkpoints.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Lileas Graf sighed deeply."*)

### Węzeł `[213]`
Mówca: **Nia Morgna**
> "“These gangs exist because corruption is so common in our country. They buy our police officers and slip by checkpoints.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Narrator: "Lileas Graf sighed deeply."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Order_Nationwide_Revolt = true;
BaseGame.Situation_Order_Nationwide_Quelled = false;
BaseGame.Situation_Order_Nationwide_Protests = false;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Order_Nationwide_Revolt"] = true;
Variable["BaseGame.Situation_Order_Nationwide_Quelled"] = false;
Variable["BaseGame.Situation_Order_Nationwide_Protests"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Lucian Galade: "“What is the status on the Bernard Circas investigation?”"*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_DiplomaticPressure = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Situation_Diplomacy_DiplomaticPressure"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.FactionReport_Turn02_ATO_ArcasiaICBM = true"*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Vesord_UCConsulate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Vesord_UCConsulate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_DiplomaticPressure = true"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_InfrastructureRumours = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_InfrastructureRumours"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_EconomicCrisis = true"*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_EconomicCrisis = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_EconomicCrisis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_LT_GangViolence = true"*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_LT_GangViolence = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_LT_GangViolence"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_E_UnderhallNo1 = true"*)

### Węzeł `[220]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_E_UnderhallNo1 = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_E_UnderhallNo1"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_G_RumburgClosesConsulate = true"*)

### Węzeł `[221]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_1927NeverAgain = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_1927NeverAgain"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Narrator: "Today's security briefing was arranged in two parts, star..."*)

### Węzeł `[222]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_G_RumburgClosesConsulate = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_G_RumburgClosesConsulate"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Vesord_UCConsulate = true"*)

### Węzeł `[223]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]` (*Węzeł Logiki Narracyjnej: "BaseGame.Decision_Turn01_InfrastructureProject_Invest == ..."*)
  - -> `[225]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Decision_Turn01_InfrastructureProject_Invest =..."*)

### Węzeł `[224]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Decision_Turn01_InfrastructureProject_Invest == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_InfrastructureRumours = true"*)

### Węzeł `[225]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Decision_Turn01_InfrastructureProject_Invest == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Decision_Turn01_InfrastructureProject_Invest"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_EconomicCrisis = true"*)

### Węzeł `[226]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_University_Political_Socialist == false"*)
  - -> `[228]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_University_Political_Socialist == false)"*)

### Węzeł `[227]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_University_Political_Socialist == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_University_Political_Socialist"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Player: "“The Red Youth are clearly to blame since they triggered ..."*)

### Węzeł `[228]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_University_Political_Socialist == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_University_Political_Socialist"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[229]`
Mówca: **Narrator**
> "Nia eagerly lifted her hand. I motioned for her to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: "“I went over the report in detail. It would be wrong to j..."*)

### Węzeł `[230]`
Mówca: **Narrator**
> "Lilieas and Nia were openly scowling at each other. Lileas turned back to her notes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lileas Graf: "“Well, this concludes the topics for the internal portion.”"*)

### Węzeł `[231]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 2;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I arrived in front of the doors leading to the Situation ..."*)

### Węzeł `[232]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.FactionReport_Turn02_ATO_ArcasiaICBM = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.FactionReport_Turn02_ATO_ArcasiaICBM"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_SnO_SecurityOverview = true"*)

### Węzeł `[233]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == false"*)
  - -> `[235]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Studyplace_Lachaven_Economics == false)"*)

### Węzeł `[234]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Studyplace_Lachaven_Economics == false`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 2;"*)

### Węzeł `[235]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Studyplace_Lachaven_Economics == false)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Studyplace_Lachaven_Economics"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]` (*Węzeł Logiki Narracyjnej: "BaseGame.Economy -= 1;"*)

### Węzeł `[236]`
Mówca: **Nia Morgna**
> ""Unfortunately, Governor Bron is directly causing the tensions to increase with his increasingly anti-Bludish stance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]` (*Lileas Graf: ""I must remind you Governor Bron is directly responsible ..."*)

### Węzeł `[237]`
Mówca: **Lileas Graf**
> ""The governor of Bergia, Phelix Bron, is already taking the necessary measures to counter the threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Lucian Galade: "“Rumburg has been acting aggressively in the region for a..."*)

### Węzeł `[238]`
Mówca: **Nia Morgna**
> ""He is misusing the powers given to him by Tarquin Soll. The insane authority of the governor is surely a root cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]` (*Lucian Galade: ""It would be very difficult to revoke the special status ..."*)

### Węzeł `[239]`
Mówca: **Lileas Graf**
> ""I must remind you Governor Bron is directly responsible for the arrest of Dewlen Arge, the previous leader of the BFF.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]` (*Lileas Graf: ""It's true that his methods can be extreme at times, but ..."*)

### Węzeł `[240]`
Mówca: **Lileas Graf**
> ""It's true that his methods can be extreme at times, but it was his policies that kept the region peaceful over the last decade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]` (*Nia Morgna: ""He is misusing the powers given to him by Tarquin Soll. ..."*)

### Węzeł `[241]`
Mówca: **Lucian Galade**
> ""It would be very difficult to revoke the special status of Bergia under the current circumstances, Ms. Morgna. The presidents no longer have the authority Tarquin Soll enjoyed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]` (*Nia Morgna: ""For now, yes. But with enough justification for it, it w..."*)

### Węzeł `[242]`
Mówca: **Nia Morgna**
> ""For now, yes. But with enough justification for it, it would be possible. Anyway... We will be discussing this at a later time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]` (*Player: ""Tell me more about the Special Zone.""*)
  - -> `[252]` (*Player: ""No. I'd like to hear more.""*)
  - -> `[253]` (*Player: ""Bergia has always been the region of chaos and trouble. ..."*)

### Węzeł `[243]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""The discrimination Bergia suffers is maddening. We should find a way to revoke the 'special' status of Bergia one way or another.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]` (*Nia Morgna: ""I will do my best, Mr. President.""*)

### Węzeł `[244]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'd rather not disturb the status quo while we're facing all these threats.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]` (*Lucian Galade: ""I agree. We shouldn't rush anything on such a divisive t..."*)

### Węzeł `[245]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Governor Bron and his special powers deserve credit for the current peace in the region.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]` (*Lucian Galade: ""The fact that he is an important USP member also makes h..."*)

### Węzeł `[246]`
Mówca: **Nia Morgna**
> ""I will do my best, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]` (*Węzeł Logiki Narracyjnej: "BaseGame.Intention_RevokeBergiaSpecialZone = true"*)

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""I agree. We shouldn't rush anything on such a divisive topic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Nia gestured at Lileas."*)

### Węzeł `[248]`
Mówca: **Lucian Galade**
> ""The fact that he is an important USP member also makes him a possible ally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Nia gestured at Lileas."*)

### Węzeł `[249]`
Mówca: **Narrator**
> "Nia gestured at Lileas."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]` (*Nia Morgna: ""What is the second most important threat?""*)

### Węzeł `[250]`
Mówca: **Nia Morgna**
> ""What is the second most important threat?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Lileas Graf: "“It is the gang violence that is threatening the Nargis a..."*)

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Tell me more about the Special Zone.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Nia Morgna: ""As you know, Bergia was given a special status by Tarqui..."*)

### Węzeł `[252]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No. I'd like to hear more.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Nia Morgna: ""As you know, Bergia was given a special status by Tarqui..."*)

### Węzeł `[253]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Bergia has always been the region of chaos and trouble. We must be careful.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[242]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]` (*Nia Morgna: ""As you know, Bergia was given a special status by Tarqui..."*)

### Węzeł `[254]`
Mówca: **Nia Morgna**
> ""As you know, Bergia was given a special status by Tarquin Soll after the full-scale uprising by the BFF against the Sordish government in '35.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]` (*Lileas Graf: ""Those couple years were disastrous for Bergia. Dewlen Ar..."*)

### Węzeł `[255]`
Mówca: **Lileas Graf**
> ""Those couple years were disastrous for Bergia. Dewlen Arge and the BFF declared war on us, openly attacked our people and occupied entire cities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]` (*Lucian Galade: ""It was a massive uprising but I'd like to point out the ..."*)

### Węzeł `[256]`
Mówca: **Lucian Galade**
> ""It was a massive uprising but I'd like to point out the longest time they were in control of a city was two weeks. I wouldn't call that an occupation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]` (*Nia Morgna: ""Despite the arrest of Dewlen Arge in '44 and the BFF cea..."*)

### Węzeł `[257]`
Mówca: **Nia Morgna**
> ""Despite the arrest of Dewlen Arge in '44 and the BFF ceasing its activities, the special status of the region were never revoked.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]` (*Nia Morgna: ""Today, the Special Zone of Bergia gives the governor ins..."*)

### Węzeł `[258]`
Mówca: **Nia Morgna**
> ""Today, the Special Zone of Bergia gives the governor insane amounts of authority. He was in trouble with the law before for not following the central government's authority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]` (*Lileas Graf: ""Unfortunately, Bergia also has its own police forces dir..."*)

### Węzeł `[259]`
Mówca: **Lileas Graf**
> ""Unfortunately, Bergia also has its own police forces directly commanded by Governor Bron. They are not part of my ministry and only cooperate when they are forced to do so. This is a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]` (*Lileas Graf: ""Even though our forces have the authority to serve in Be..."*)

### Węzeł `[260]`
Mówca: **Lileas Graf**
> ""Even though our forces have the authority to serve in Bergia, the Special Zone leaves the security of Bergia mostly in the hands of the governor. That leaves my hands tied.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]` (*Player: ""The discrimination Bergia suffers is maddening. We shoul..."*)
  - -> `[244]` (*Player: ""I'd rather not disturb the status quo while we're facing..."*)
  - -> `[261]` (*Player: ""We must reverse this situation. It is absurd that the Mi..."*)
  - -> `[245]` (*Player: ""Governor Bron and his special powers deserve credit for ..."*)

### Węzeł `[261]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We must reverse this situation. It is absurd that the Ministry of Interior doesn't have full control over Bergia's security.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[260]` (Lileas Graf)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]` (*Lileas Graf: ""I agree. I have some ideas about it already. But we can ..."*)

### Węzeł `[262]`
Mówca: **Lileas Graf**
> ""I agree. I have some ideas about it already. But we can talk about that at a later time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Nia gestured at Lileas."*)

### Węzeł `[263]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAtModeOff();`
- **Efekt skryptowy (`userScript`):** `LookAtModeOff();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Valken Kruger: "”Mr. President, if I may?“"*)

### Węzeł `[264]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `LookAt("Sordland_Country_Rumburg");`
- **Efekt skryptowy (`userScript`):** `LookAt("Sordland_Country_Rumburg");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Iosef Lancea: "“Rumburg has been acting increasingly expansionist in the..."*)

### Węzeł `[265]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Intention_RevokeBergiaSpecialZone = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Intention_RevokeBergiaSpecialZone"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]` (*Narrator: "Nia gestured at Lileas."*)

### Węzeł `[266]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Erzaren_RiseInGolcondism = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Erzaren_RiseInGolcondism"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Studyplace_Lachaven_Economics == false"*)

### Węzeł `[267]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[268]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Economy -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "I arrived in front of the doors leading to the Situation ..."*)
