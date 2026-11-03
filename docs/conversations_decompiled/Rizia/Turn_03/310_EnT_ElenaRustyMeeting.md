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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 17

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Economy_PromiseNoMiningRegs`
- `RiziaDLCIsolated.Turn03_RustyConvo_Zille`
- `RiziaDLCSupport.News_Turn03_G_PalesGas`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[135]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] = true;`
- Węzeł `[137]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] = true;`
- Węzeł `[139]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] = true;`
- Węzeł `[141]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] = true;`
- Węzeł `[192]` (Paskal Beniwoll): `End();`
- Węzeł `[196]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- Węzeł `[197]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- Węzeł `[201]` (Paskal Beniwoll): `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- *...oraz 9 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "On the banks of the Zpana River in Bronaz stood Palas Verana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Almost as opulent as my own palace, it had once served as a summer residence for my ancestors, the Rubaz family."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Today it was the home of Russello "Rusty" Montoro. The CEO of Rizian Royal Gold, and the wealthiest commoner in the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I stepped out onto the deck of the Rizania as the yacht approached the palace's private dock. Hugo and Elena were already there, gazing out at the grounds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Hugo Toras**
> ""I can't believe what I'm seeing. Palas Verana without its water garden is no palace at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Elena Werner**
> ""I think it's an improvement, myself. But what do you make of this, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "I looked in the direction she was indicating. The water garden, once a tranquil oasis filled with blossoming flowers and gently burbling fountains, had been replaced with a gigantic gold-tiled swimming pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`
  - -> `[12]`
  - -> `[169]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Hideous. I hate new money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Seems practical. I never understood the appeal of water gardens anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why don't we have one of these at Palas Rezna?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
Mówca: **Hugo Toras**
> ""Because we have taste.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[14]`
Mówca: **Elena Werner**
> ""They're attractive, to be sure. But at the height of summer, looking at fountains you can't swim in is just torturous.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[15]`
Mówca: **Hugo Toras**
> ""I'd be surprised if Mr. Montoro even used it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[16]`
Mówca: **Narrator**
> "The gold magnate's red hair was streaked with grey, but his eyes had a youthful mischief about them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[17]`
Mówca: **Russello Montoro**
> ""On behalf of all of us at the esteemed Rizian Royal Gold corporation, I do hereby extend my cordial greetings to your royal delegation...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "He trailed off with a grin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Russello Montoro**
> ""Heck, I was never one for formalities. Welcome to my palace, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`
  - -> `[219]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a pleasure, Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[22]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You certainly have made it yours, haven't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Russello Montoro**
> ""Oh, the pool? I can't stand swimming myself. Get sunburned at the drop of a hat. The grandkids love it, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Narrator**
> "He turned to Hugo and Elena."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Russello Montoro**
> ""Your Grace, Madam Treasurer. Haven't had a sit-down with you two since the last gentleman wore the crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Hugo Toras**
> ""You must mean my honorable brother, His Majesty King Valero. May he rest in peace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Narrator**
> "My uncle gritted his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[28]`
Mówca: **Elena Werner**
> ""Now, Hugo. Rusty paid his respects at the funeral like everyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "She shook Rusty's hand. He beckoned for us to sit as his valets brought over water and fresh fruit."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[105]`
  - -> `[104]`
  - -> `[224]`

### Węzeł `[30]`
Mówca: **Russello Montoro**
> ""Rusty, please. Calling me 'Mr. Montoro' is like trying to put an elevator in an outhouse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[31]`
Mówca: **Russello Montoro**
> ""Now. As you know, Rizian Royal Gold boasts a long, proud history of cooperation with the Crown.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`
  - -> `[228]`
  - -> `[367]`

### Węzeł `[32]`
Mówca: **Russello Montoro**
> ""That deal was your father's idea, Your Majesty. All I was asking for was fair compensation for what my company lost. As any CEO would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Russello Montoro**
> ""My point being. As a trusted business associate, there's something I need to bring to your attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Russello Montoro**
> ""Feast your eyes on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Narrator**
> "He picked up a piece of paper from the table next to him. It was a flyer with a few sentences written in both Rizian and Wehzek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A Malenyevist. A dangerous figure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The first female Prime Minister of Morella. A pioneer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's not a threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[39]`
Mówca: **Russello Montoro**
> ""A pioneering pain in both of our behinds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Russello Montoro**
> ""Right, Your Majesty. Banning propaganda in Rizia won't stop what's happening on her side of the border.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Russello Montoro**
> ""Woman's never picked up a chisel in her life, and she suddenly knows how to run the MITZ.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`

### Węzeł `[43]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[44]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Decision_Turn02_MalenyevistPropaganda_Ban"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Russello Montoro**
> ""That's right, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[46]`
Mówca: **Russello Montoro**
> ""She wouldn't be if she stuck to governing Morella. You know, like she was elected to do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[47]`
Mówca: **Russello Montoro**
> ""Supervisors at my mines have gotten word that the workers are holding after-hours meetings. On the subject of 'unsafe conditions'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[49]`
  - -> `[48]`
  - -> `[230]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Have you tried, let's see, improving those conditions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""They should be grateful to be employed at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The first step to unionizing?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Russello Montoro**
> ""Don't know if I'd go that far. But the more employees put their heads together, the more dangerous their ideas get.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[52]`
Mówca: **Russello Montoro**
> ""They were before. Someone's been putting ideas in their heads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Russello Montoro**
> ""I mean, we would if they brought up the subject with us directly. But seems they'd rather conspire amongst themselves.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[54]`
Mówca: **Elena Werner**
> ""Have there been any accidents lately? Anything that might have triggered this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "Rusty snorted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Russello Montoro**
> ""Accidents have been part of this job since the dawn of time. Used to say you weren't a real miner until you were missing a finger.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`
  - -> `[58]`
  - -> `[59]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's barbaric.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you need all ten of them for, anyway?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you ever even work in the mines yourself, Rusty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Russello Montoro**
> ""As long as you've got enough to swing a pickaxe.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Rusty slowly held up his left hand. His little finger had been lopped off at the second joint."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[62]`
Mówca: **Russello Montoro**
> ""That's reality. Not all of us have estates to live off, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Narrator**
> "Hugo cleared his throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Hugo Toras**
> ""Do you have a request of His Majesty, Mr. Montoro? Or have you merely invited us here to complain?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[65]`
Mówca: **Russello Montoro**
> ""Not complain. Warn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[66]`
Mówca: **Russello Montoro**
> ""If I'm right, they're about to propose a big new batch of workplace regulations. Not just for RRG, but for everyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How much revenue would RRG stand to lose?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We still have the Meftiem International Trade Zone, don't we? The rules wouldn't apply there.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The company will rebound when we get Zille back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[70]`
Mówca: **Russello Montoro**
> ""Hard to say. Implementing the regulations themselves would cost a pretty penny.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Russello Montoro**
> ""And what do you think will happen if we pass those costs on to our trading partners? They'll hit the road faster than my first ex-wife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[72]`
Mówca: **Russello Montoro**
> ""Well, that's the other thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Russello Montoro**
> ""Sure, RRG isn't a direct stakeholder in the Trade Zone. But we're involved enough to be highly worried about Alma Saltana.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[74]`
Mówca: **Russello Montoro**
> ""We'll see about that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[75]`
Mówca: **Narrator**
> "Elena raised her eyebrows."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Elena Werner**
> ""We have been seeing more global competition on the gold market, unfortunately.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[77]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Aren't most RRG miners labor hands from foreign countries? Would the regulations even apply to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[78]`
Mówca: **Elena Werner**
> ""Morella doesn't have unilateral power over the International Trade Zone. Rizia, Lespia and Valgsland all have a say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Russello Montoro**
> ""And guess which one of those Ms. Saltana has been cozying up to on this subject?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Russello Montoro**
> ""If she and Hegel get their way, Rizia will either lose its mining rights or our boys will have to pray to Malenyev before going to work every morning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[83]`
  - -> `[82]`
  - -> `[81]`

### Węzeł `[81]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Actually, Malenyev is a staunch atheist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[82]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That still leaves us and Lespia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[83]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She should have the right to determine how gold is mined in her own country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Gold Regs Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[123]`
  - -> `[126]`
  - -> `[129]`

### Węzeł `[85]`
Mówca: **Russello Montoro**
> ""They most certainly would, now that labor hands have the same protections as honest-to-goodness Rizians.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[86]`
Mówca: **Russello Montoro**
> ""25 years ago, that little nub of land was home to some of the fattest gold veins my company's ever found. But Nur knows what shape it's in now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[87]`
Mówca: **Hugo Toras**
> ""It's Chancellor Hegel's influence that is concerning. Malenyevism has a way of spilling over borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[88]`
Mówca: **Elena Werner**
> ""It's hard to say if we can count on Lespia's cooperation. Of course they abhor Valgsland, but we don't have the friendliest history with them either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[89]`
Mówca: **Hugo Toras**
> ""Another reason to keep his influence far from our borders.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No matter what, our revenue from the region takes a hit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Hugo Toras**
> ""And the CSP will claim another victory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Elena Werner**
> ""The political aspect isn't as concerning to me as the loss of access to our most important mines. We have to keep a close eye on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[93]`
Mówca: **Russello Montoro**
> ""She's started calling for regulation over there as well. Or worse, nationalization.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[94]`
Mówca: **Elena Werner**
> ""We'll have to keep a close eye on this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[95]`
Mówca: **Russello Montoro**
> ""Honestly, Your Majesty, I just about ate my boot when you made that decree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Russello Montoro**
> ""My fellow businessmen and I lost enough money granting all kinds of benefits to folks who don't even understand how lucky they are to work here. Giving them more would damn near bankrupt us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Elena Werner**
> ""A little extreme, don't you think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Elena Werner**
> ""I agree we shouldn't impose more regulations than necessary, but investing in safer and healthier employees could lead to profit in the long term. Foreigners included.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It has indeed been a mutually beneficial partnership. I intend to keep it that way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Was it 'cooperation' when you wrested away a third of the kingdom's stake?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't overinflate your company's importance. We have other resources.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Russello Montoro**
> ""Glad we're on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[103]`
Mówca: **Russello Montoro**
> ""But only one is in the name of the national anthem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[104]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's the occasion?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[105]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I suppose you haven't invited us over here to marvel at your renovations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So how's business?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[107]`
Mówca: **Russello Montoro**
> ""Neat, aren't they? But no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Russello Montoro**
> ""I couldn't help noticing you've been crisscrossing the kingdom lately. And no royal tour would be complete without a visit to my modest little hideaway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[109]`
Mówca: **Russello Montoro**
> ""A shame Her Highness couldn't make it. Too occupied with her latest beau?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[110]`
Mówca: **Hugo Toras**
> ""One dance does not a 'beau' make. We'd appreciate it if you didn't speculate about Princess Vina's romantic prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Russello Montoro**
> ""We'll get to that, Your Majesty. Settle down, have a drink first.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[112]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please tell me what this meeting is about. We don't have all day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[113]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's quite all right, Hugo. My daughter does happen to have her eye on a special someone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Agreed. My daughter is a private person and her love life is strictly off-limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[115]`
Mówca: **Russello Montoro**
> ""Lucky man. Anyway, I'll cut to the chase.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Russello Montoro**
> ""Well, all right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "He sat back and unbuttoned the top button of his shirt."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[118]`
Mówca: **Elena Werner**
> ""But for now, our product is of high enough quality that Rumburg is willing to pay more for it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Hugo Toras**
> ""Yes, but if the price rises further still? I'd rather not admit it, but Mr. Montoro may have a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_RustyConvo_Revenue == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_RustyConvo_ITZ == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Zille == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Zille == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_RustyConvo_Zille == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[129]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[131]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers == true && RiziaDLCIsolated.Turn03_RustyConvo_ITZ == true && RiziaDLCIsolated.Turn03_RustyConvo_Zille == true && RiziaDLCIsolated.Turn03_RustyConvo_Revenue == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] == true  and  Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Revenue = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Revenue"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_ITZ = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_ITZ"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_Zille = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_Zille"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn03_RustyConvo_GuestWorkers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaDLCIsolated.Turn03_RustyConvo_G ...])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[143]`
Mówca: **Russello Montoro**
> ""Look, I won't press the issue any further. Just hope you'll do the right thing if this ever lands in your lap.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Narrator**
> "Rusty took a big bite out of a watermelon slice. He wiped the juice off his chin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Elena pushed her chair back and stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""An increased stake in RRG in exchange for refusing regulations? If I didn't know better, I'd think you were trying to bribe the government.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[147]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the company's in as much trouble as you mentioned, it's no wonder you're so eager to sell us our stake back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[148]`
Mówca: **Russello Montoro**
> ""Who knows? If all goes well, I might be persuaded to sell you back the share the honorable King Valero sold me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[149]`
Mówca: **Russello Montoro**
> ""Your Majesty. How crass do you think I am?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[150]`
Mówca: **Russello Montoro**
> ""You misunderstand me, Your Majesty. We're not in trouble. Yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me make one thing clear, *Russello*. You are only running RRG by the grace of Rizia's royal family. Everything you have, we can take away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[152]`
Mówca: **Elena Werner**
> ""I'm going to recuse myself from this part of the conversation. Where's the ladies' room?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Russello Montoro**
> ""Just inside. If you've never sat on a solid gold toilet, you're in for a treat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[154]`
Mówca: **Narrator**
> "A valet escorted Elena out. Hugo, Rusty and I glanced at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`
  - -> `[151]`
  - -> `[161]`

### Węzeł `[155]`
Mówca: **Hugo Toras**
> ""I think our friend *Rusty* here is perilously close to oversteppng his bounds.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "He let out a sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Hugo Toras**
> ""But cooperation with RRG served King Valero well in the past. Even after selling part of the royal stake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Elena stepped back onto the terrace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Elena Werner**
> ""That was... colder than I expected. I hope I haven't missed much?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Narrator**
> "Hugo practically sprang from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[161]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think of all this, Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[162]`
Mówca: **Russello Montoro**
> ""You're a smart man, Your Grace. You and I should go out for beers someday.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "Hugo looked like he'd swallowed something unpleasant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[164]`
Mówca: **Hugo Toras**
> ""It's been a delight, but we must be headed back to Porte Drazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Russello Montoro**
> ""And here I was about to ask you to stay for lunch. So soon, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`
  - -> `[168]`

### Węzeł `[166]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I think we're just about finished here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[167]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't worry. You'll be hearing from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[168]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Please excuse my uncle's hastiness. Lunch would be lovely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[169]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remind me. How did a man like him take over the most powerful corporation in Rizia?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Elena Werner**
> ""He's got a knack for being in the right place at the right time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Hugo Toras**
> ""Legend has it he worked his way up from regional mine supervisor in a series of backroom deals and boardroom betrayals.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[172]`
Mówca: **Russello Montoro**
> ""This is about more than just a few disgruntled miners. Rumor has it the RPP's picking up the cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[173]`
Mówca: **Narrator**
> "Rusty smirked in triumph."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[174]`
Mówca: **Russello Montoro**
> ""Sorry, Your Grace. Got to pretend to be civil to me a while longer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[175]`
Mówca: **Russello Montoro**
> ""That we are. Enjoy the trip back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`
  - -> `[183]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Economy_PromiseNoMiningRegs == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Russello Montoro**
> ""Far from it, if you ask me. But enjoy the trip back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`
  - -> `[183]`

### Węzeł `[180]`
Mówca: **Russello Montoro**
> ""Not if you hear from me first, eh?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you, Rusty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Goodbye, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[183]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Until next time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "I could see him cheerfully waving from the veranda as Hugo, Elena and I stepped back on board the yacht."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[185]`
Mówca: **Narrator**
> "Hugo and Elena sat back down as the valets began bringing out our midday meal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_DancedWithManus == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Vina_DancedWithManus == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Vina_DancedWithManus"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Russello Montoro**
> ""A shame Her Highness couldn't make it. Has she finally found a beau back home in the capital?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[190]`
Mówca: **Hugo Toras**
> ""We'll thank you not to speculate about Princess Vina's romantic prospects.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`
  - -> `[112]`

### Węzeł `[191]`
Mówca: **Russello Montoro**
> ""Well, all right. I'll cut to the chase, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Welfare_LaborHandsLegalized"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[198]`
Mówca: **Russello Montoro**
> ""They're fixing to have it that way, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Russello Montoro**
> ""The folks pushing for these restrictions -- I mean regulations -- are a mix of labor hands and honest-to-goodness Rizians. With some support from the Sazons to boot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Russello Montoro**
> ""I see what they're going for. I really do. But giving them everything they want would set a dangerous example.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[201]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_UpInTheAir", "R_UpInTheAir_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_UpInTheAir","R_UpInTheAir_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCSupport.News_Turn03_G_PalesGas = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCSupport.News_Turn03_G_PalesGas"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[203]`
Mówca: **Narrator**
> "Suddenly, a group of armed men exited the palace in single file. They positioned themself at equal intervals around the dock."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[204]`
Mówca: **Narrator**
> "They followed us with their eyes as we disembarked and walked towards the palace veranda."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[205]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good morning, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[206]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's your rank? Where did you serve?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`
  - -> `[209]`

### Węzeł `[208]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_JoinedMilitary == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_JoinedMilitary"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[209]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_JoinedMilitary == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_JoinedMilitary"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[210]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You will bow before your king, you insolent lowlife.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[211]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Palantor... Are you Arcasian?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[212]`
Mówca: **Narrator**
> "He didn't move a muscle. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[213]`
Mówca: **Narrator**
> "He stared at me with a look of non-comprehension. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[214]`
Mówca: **Narrator**
> "He stared at me with a look of non-comprehension. There was a rustle behind me as Titus shifted his weight, on high alert."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[216]`
Mówca: **Narrator**
> "Rusty rose from where he'd been sitting and rushed over to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Russello Montoro**
> ""Antoine! That's no way to treat our royal visitors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Narrator**
> "The guard reluctantly bowed and stepped aside. Rusty ushered us past him, shaking his head as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[219]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You say I'm welcome. Your guards send a different message.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[220]`
Mówca: **Russello Montoro**
> ""I know what it seems like, but they're looking out for your safety as well as mine. Can't be too careful after what happened in Wehlen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[221]`
Mówca: **Narrator**
> "As I passed the largest guard, I noticed he was wearing a badge that read 'Palantor Security Solutions.'""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`
  - -> `[211]`
  - -> `[210]`
  - -> `[207]`

### Węzeł `[222]`
Mówca: **Hugo Toras**
> ""Yes. 'Beers'. I would... enjoy that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[223]`
Mówca: **Russello Montoro**
> ""There you go! With your father, it was always 'Russello' this and 'Mr. Montoro' that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[224]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Let me say this straight away. Your wealth may excuse your lack of manners in some circles, but not with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Narrator**
> "He looked stricken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Russello Montoro**
> ""I do beg your pardon. I never did have time for fancy etiquette classes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[227]`
Mówca: **Narrator**
> "Elena struggled to keep a pleasant expression on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[228]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was the Crown's to begin with. Queen Lyza never should have privatized it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Russello Montoro**
> ""Your grandmother was a savvy dame. She saw an innovator and reached out her hand, 'stead of her fist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[230]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That's troubling. Workers in this country should have a right to safety.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[231]`
Mówca: **Russello Montoro**
> ""They already do, Your Majesty. Someone's been stirring up trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[232]`
Mówca: **Russello Montoro**
> ""First week on the job in Argno. Thought I'd save time by fixing a blockage in one of the ore processors. Reached right in, and wouldn't you know? It started working again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[233]`
Mówca: **Russello Montoro**
> ""But did I blame RRG for my own boneheaded stupidity? Your Majesty, I did not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[234]`
Mówca: **Russello Montoro**
> ""Duke Hugo, why don't you show her the way? Maybe have a gander at my latest art acquisitions while you're at it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[235]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Manus_ConstitutionalMonarchy == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Manus_ConstitutionalMonarchy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[238]`
Mówca: **Narrator**
> "He winked at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[239]`

### Węzeł `[239]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sure Ms. Werner can find her own way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[240]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go on, Hugo. I'll be fine out here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Hugo Toras**
> ""She certainly can. I'll stay right here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Hugo looked at us both warily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[243]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Elena Werner");)*
- **Efekt (`userScript`):** `RemoveConversant("Elena Werner");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[244]`
Mówca: **Hugo Toras**
> ""Very well. Ms. Werner?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Elena gave him a nod. The two of them headed towards the palace doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Elena Werner");
RemoveConversant("Hugo Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Elena Werner");
RemoveConversant("Hugo Toras");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[247]`
Mówca: **Narrator**
> "I watched them go inside. When I turned my attention back to Rusty, I saw him studying me intently."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[251]`
  - -> `[249]`
  - -> `[263]`

### Węzeł `[248]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there something you've been keeping from me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If the people want regulations, I'm not going to get in their way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[250]`
Mówca: **Russello Montoro**
> ""I could ask you the same question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[251]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're beginning to test my patience, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[252]`
Mówca: **Russello Montoro**
> ""Wait, Your Majesty. You're going to want to hear this next part.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[253]`
Mówca: **Russello Montoro**
> ""I heard you're thinking of bringing some pretty big changes to Rizia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[258]`
  - -> `[257]`
  - -> `[268]`

### Węzeł `[254]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""How do you know about that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[255]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm planning changes. Changes that will keep people like you from hoarding wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[257]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to dignify that with a response.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[258]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What exactly did you hear?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[259]`
Mówca: **Russello Montoro**
> ""But there's something else the people want more. Isn't there, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Narrator**
> "He looked around to make sure all of our guards were out of earshot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[261]`
Mówca: **Russello Montoro**
> ""So I was right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[262]`
Mówca: **Russello Montoro**
> ""People like me have bankrolled every major power shift since 1823. Arcasia, Qinal, Lespia... you name it, there's a fat wallet behind it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[263]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I am not opposed to working together. But I want it to be on my terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[264]`
Mówca: **Russello Montoro**
> ""This is just the beginning, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[265]`
Mówca: **Russello Montoro**
> ""And if you really do want to pull the rug out from under the Rizian nobility, you're going to need the fattest wallet of all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[266]`
Mówca: **Russello Montoro**
> ""You don't have to respond. Just hear me out for a second.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[267]`
Mówca: **Russello Montoro**
> ""All I know is, the word 'reform' has come up in connection with your name once or twice. And I don't mean the branch of Dastnurity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[268]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If I did have such plans in store, what business would it be of yours?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[269]`
Mówca: **Russello Montoro**
> ""Aha! So I'm right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[270]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Go to hell, Mr. Montoro.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[271]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Russello Montoro**
> ""As you command, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[273]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The rumors are exaggerated. Any reforms I put in place will be minor at the very most.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Russello Montoro**
> ""Minor or not, you know as well as I do that the nobility in this country doesn't take kindly to change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Narrator**
> "He triumphantly gestured at himself. On seeing Hugo striding back towards us, he adopted a more serious posture."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[276]`
Mówca: **Russello Montoro**
> ""You're going to need someone in your corner. Someone with resources to burn and no scruples about burning them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[277]`
Mówca: **Russello Montoro**
> ""Just letting you know that I'm on your side. Or I could be, if you let me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[278]`
Mówca: **Russello Montoro**
> ""I am so, so, sorry. You can take the guards out of Arcasia, but you can't... well, you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[279]`
Mówca: **Russello Montoro**
> ""Do you need an occasion to catch up with an old friend?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[280]`
Mówca: **Hugo Toras**
> ""Since when are you worried about the Rizian People's Party, Mr. Montoro?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`
  - -> `[283]`
  - -> `[284]`

### Węzeł `[281]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""He's right to be worried. With Manus Sazon in charge, the party could become a real threat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""His Grace is right. The RPP doesn't have the power to change anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The party wants to bring the workers' demands to the highest level of government. Admirable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The miners don't need the RPP to help them. I'm the King. I can better their situation in an instant.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[285]`
Mówca: **Russello Montoro**
> ""You can. But should you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[286]`
Mówca: **Russello Montoro**
> ""Only in theory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[287]`
Mówca: **Russello Montoro**
> ""Except the public's mind.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[288]`
Mówca: **Russello Montoro**
> ""Not if we steer them in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == false && RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == false  and  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Russello Montoro**
> ""Better to focus on breaking new ground, if you ask me. That mining survey of yours was a good start...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[293]`
Mówca: **Russello Montoro**
> ""Qalus, on the other hand, is looking *very* promising. That survey of yours was a stroke of genius.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[294]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  
(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_ConductMiningSurveys == true && 
(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_ConductMiningSurveys"] == true  and  
(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[297]`
Mówca: **Russello Montoro**
> ""Better to focus on breaking new ground, if you ask me. Rumor has it your relatives in Valenqiris might be sitting on some *extremely* valuable real estate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[298]`
Mówca: **Russello Montoro**
> ""That said, the more unnecessary requirements we have to meet to extract that gold, the less of it you get to keep.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[299]`
Mówca: **Russello Montoro**
> ""Will they make anyone safer? Doubtful. Will they be a death blow to our bottom line? One hundred percent.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[300]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I still don't understand what you're getting at.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[301]`
Mówca: **Russello Montoro**
> ""If the rumors are true, Your Majesty... I see huge potential for both of us to win big.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[302]`
Mówca: **Russello Montoro**
> ""Hell, do you know how much growth we're missing out on because international investors don't want to mess with an absolute monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[303]`
Mówca: **Russello Montoro**
> ""I'm on your side. Or I could be, if you let me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[304]`
Mówca: **Hugo Toras**
> ""I take it as a positive sign that Mr. Montoro is open to renegotiating that stake. And I agree that over-regulation of our industries would hamper businesses while emboldening workers to a dangerous degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[305]`
Mówca: **Narrator**
> "He gave me a crooked smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[306]`
Mówca: **Russello Montoro**
> ""I know, Your Majesty. Every single day, I'm grateful for the privilege I've been given.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[307]`
Mówca: **Russello Montoro**
> ""I would like nothing more than to pay it forward. Let RRG keep running the way we always have, and I swear I'll return the favor in triplicate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[308]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`

### Węzeł `[311]`
Mówca: **Russello Montoro**
> ""My pal Gus Manger told me he saw potential in your reign. I'm inclined to agree with him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Russello Montoro**
> ""If you keep on making deals and let us run our business the way we always have... well, just imagine a gold swimming pool in every Rizian backyard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[313]`
Mówca: **Russello Montoro**
> ""We're in this together. What's good for Rizian Royal Gold is good for Rizian royals. And vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[314]`

### Węzeł `[314]`
Mówca: **Russello Montoro**
> ""Just let us keep running things the way we always have, and we'll take care of the rest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[315]`
Mówca: **Hugo Toras**
> ""I wouldn't have taken you for an art connoisseur. Mr. Montoro. That Kolores fresco in your hallway is stunning.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Narrator**
> "He cut himself off upon seeing Hugo striding back towards us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[317]`
Mówca: **Russello Montoro**
> ""Yeah, well. My pal Gus Manger convinced me it was a good investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[318]`
Mówca: **Narrator**
> "He cracked a smile."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[319]`
Mówca: **Narrator**
> "Hugo shuddered quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. If I'd known you'd invited me here only to wheedle favors out of me, I would have saved myself the trip.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[321]`
Mówca: **Russello Montoro**
> ""Give me a hint, Your Majesty. Is the Crown on our side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[320]`
  - -> `[324]`
  - -> `[340]`

### Węzeł `[322]`
Mówca: **Narrator**
> "He spread his arms wide."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[323]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're indeed in this together. Keep supplying the kingdom with gold, and I will take care of any obstacles in RRG's way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[324]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only side I'm on is that of ordinary, hard-working Rizians. I want what is best for them, even if our gold reserves suffer.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[325]`
Mówca: **Russello Montoro**
> ""If I'm wrong, go ahead and tell me to go to hell. All you nobles do, anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[255]`
  - -> `[300]`
  - -> `[270]`
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Tyrant += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Tyrant"] = Variable["RiziaDLC.PersonalValue_Tyrant"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[327]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd never utter such blasphemous words. But I'm not interested in discussing this with you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Religious += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Religious"] = Variable["RiziaDLC.PersonalValue_Religious"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Narrator**
> "He shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[330]`
Mówca: **Russello Montoro**
> ""Suit yourself, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Situation_Economy_Sordland_ResortDeal == true || RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Situation_Economy_Sordland_ResortDeal"] == true  or  Variable["RiziaDLC.Situation_Diplomacy_Sordland_WineWhiskeyDeal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[334]`
Mówca: **Russello Montoro**
> ""He told me he had very high hopes for your reign, by the way. Hopes that I myself share.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Russello Montoro**
> ""He doesn't have any hard feelings about you turning down his deals, by the way. But he hopes you'll keep the door open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[336]`
Mówca: **Russello Montoro**
> ""If you keep on making deals and let us run our business the way we always have... well, just imagine a gold swimming pool in every Rizian backyard.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Narrator**
> "Hugo shuddered quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[323]`
  - -> `[320]`
  - -> `[340]`

### Węzeł `[338]`
Mówca: **Russello Montoro**
> ""And so do I. Especially when it comes to that thing we were just discussing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`
  - -> `[323]`
  - -> `[320]`
  - -> `[340]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I appreciate everything RRG has done for the Crown. But I owe it to the Rizian people to take the concerns of the workers into consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not going to make any promises one way or the other.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[341]`
Mówca: **Narrator**
> "He nodded, unperturbed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[342]`
Mówca: **Russello Montoro**
> ""Fine and dandy, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[343]`
Mówca: **Russello Montoro**
> ""Favors? I'm sorry if I gave you the wrong impression. This was only supposed to be a friendly chat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[344]`
Mówca: **Russello Montoro**
> ""Much appreciated, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[345]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Economy_PromiseNoMiningRegs = true; RiziaDLCSupport.Journal_Turn03_Rusty_PromiseNoRegs = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Economy_PromiseNoMiningRegs"] = true;
Variable["RiziaDLCSupport.Journal_Turn03_Rusty_PromiseNoRegs"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[346]`
Mówca: **Narrator**
> "He gestured towards a number of floral-patterned chairs that had been set out on the terrace, overlooking the pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[347]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`
  - -> `[349]`

### Węzeł `[348]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanAmount > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[350]`
Mówca: **Russello Montoro**
> ""And I didn't hear you complaining about my manners when you were accepting my money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[365]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanAmount > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[354]`
Mówca: **Russello Montoro**
> ""Plus, y'know, you did accept a big chunk of change from me lately. Thought you might want to come meet your benefactor in person.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[365]`

### Węzeł `[355]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[357]`

### Węzeł `[356]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanAmount > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanAmount"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[357]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanAmount > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanAmount"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[358]`
Mówca: **Russello Montoro**
> ""By the way, no rush on paying back that loan I gave you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`
  - -> `[365]`

### Węzeł `[359]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, thank you for your offer. You'll get your repayment in due time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[360]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a disgrace that my father allowed you to accumulate so much wealth. The King of Rizia should not have to stoop to borrowing from a commoner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[361]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Borrowing from RRG does not mean you and I are entering into any kind of *arrangement*. You should know that upfront.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Russello Montoro**
> ""You're a valuable shareholder in my business, Your Majesty. You want our arrangement to stop there, it will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[363]`
Mówca: **Russello Montoro**
> ""It was nothing. I know you and Ms. Werner will put the cash to good use.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[364]`
Mówca: **Russello Montoro**
> ""Hey, it's not like I didn't work for it. And besides, I know you and Ms. Werner will double that money in no time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[365]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's impolite of you to bring that up here. We shall speak no more of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`

### Węzeł `[366]`
Mówca: **Russello Montoro**
> ""All right. My lips are sealed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[367]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`
  - -> `[369]`

### Węzeł `[368]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[369]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanOfferCount > 0 && RiziaDLC.Rusty_LoanAmount == 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanOfferCount"] > 0  and  Variable["RiziaDLC.Rusty_LoanAmount"] == 0) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[370]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You say cooperation, I say usury. Did you try to pull that 'loan' trick with my father?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Russello Montoro**
> ""Trick, Your Majesty? I was only trying to give us both a leg up. You've got to spend money to make money, as I'm sure you know.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[372]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanOfferCount < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Rusty_LoanOfferCount < 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Rusty_LoanOfferCount"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Rusty_LoanOfferCount < 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Rusty_LoanOfferCount"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[375]`
Mówca: **Russello Montoro**
> ""And by the way. Should you ever find yourself low on Crown funds, don't hesitate to reach out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[376]`
Mówca: **Russello Montoro**
> ""RRG aside, I've been fortunate enough to have made some very profitable investments. Happy to share the wealth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[377]`
Mówca: **Russello Montoro**
> ""Don't get me wrong, Your Majesty -- my personal finances will be just fine. It's your revenue stream I'm looking out for here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[378]`
Mówca: **Russello Montoro**
> ""And don't forget. You ever find yourself low on Crown funds again, the bank of Rusty is still open.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[379]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[381]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed == true || RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Completed"] == true  or  Variable["RiziaDLC.Policy_RD_Economy_QalusGoldMine_Project"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[382]`
Mówca: **Russello Montoro**
> ""Qalus, on the other hand, is looking *very* promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[383]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: SetRichPresence("Meeting the CEO of Royal Rizian Gold by his gold-tiled pool", "Palas Verana", "Bronaz");)*
- **Efekt (`userScript`):** `SetRichPresence("Meeting the CEO of Royal Rizian Gold by his gold-tiled pool","Palas Verana","Bronaz");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
