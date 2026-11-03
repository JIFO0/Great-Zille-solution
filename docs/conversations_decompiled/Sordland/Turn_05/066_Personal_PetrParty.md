# Sordland/Turn05/Personal_PetrParty

- **ID konwersacji:** `66`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/066_Personal_PetrParty.md`
- **Liczba węzłów dialogowych:** 426
- **Liczba wyborów gracza:** 84

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[29]** Ewald Alphonso
- **[35]** Gus Manger

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Accepted_PersonalInvestment2`
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses`
- `BaseGame.Decision_Turn04_GruniRuralDev_NoFunding`
- `BaseGame.Decision_Turn05_SPAid_AcceptArcasia`
- `BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana`
- `BaseGame.Faction_Oligarchs_Content`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Economy_EnergyProtectionAct_10Percent`
- `BaseGame.Policy_Economy_PromotePlanned`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Arcasia`
- `BaseGame.Reform_EmergencyDecree_PoliceAuthority`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Relations_Ewald_Discontent`
- `BaseGame.Relations_Ewald_PromiseNotHarsherEPA`
- `BaseGame.Relations_Walter_Promise_CompanyFulfilled`
- `BaseGame.Situation_Law_MediaBias`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`
- `BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia`
- `BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone`
- `BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment`
- `BaseGame.Turn04_EnT_TaxBreak_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses`
- `BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations`
- `BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses`
- `BaseGame.Turn04_PSnW_Education_Privatization`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Accepted_PersonalInvestment2`
- `BaseGame.Economy`
- `BaseGame.PersonalWealth`
- `BaseGame.Turn05_P_FCAnrica`
- `BaseGame.Turn05_P_Underhall`
- `BaseGame.Turn05_P_Vineyard`
- `BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica`
- `BaseGameSupport.Journal_Turn05_GusInvestment_Underhall`
- `BaseGameSupport.Journal_Turn05_GusInvestment_Winery`
- `BaseGameSupport.News_Turn05_G_ArcasiaAid`
- `BaseGameSupport.News_Turn05_G_UCAid`
- `BaseGameSupport.News_Turn05_HP_BFFPropaganda`
- `BaseGameSupport.News_Turn05_R_StateWarYS`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment`
- `BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment`
- `BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal`
- `BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal`
- `BaseGameSupport.Report_Turn05_Erzaren_PoliceReport`
- `BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold`
- `BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect`
- `BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult`
- `BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools`
- `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill`
- `BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A`
- `GameCondition.Turn05_Personal_PetrParty`
- `GameCondition.Turn06_Personal_ReturnOfInvestment2`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 39

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Economy`
- `BaseGame.PersonalWealth`
- `BaseGameSupport.News_Turn05_R_StateWarYS`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[144]` (Petr Vectern): `Variable["BaseGame.Turn05_P_Underhall"] = true; Variable["BaseGameSupport.Journal_Turn05_GusInves...`
- Węzeł `[145]` (Petr Vectern): `Variable["BaseGame.Turn05_P_FCAnrica"] = true; Variable["BaseGameSupport.Journal_Turn05_GusInvest...`
- Węzeł `[146]` (Petr Vectern): `Variable["BaseGame.Turn05_P_Vineyard"] = true; Variable["BaseGameSupport.Journal_Turn05_GusInvest...`
- Węzeł `[160]` (Petr Vectern): `Variable["GameCondition.Turn05_Personal_PetrParty"] = true;`
- Węzeł `[186]` (Petr Vectern): `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A"] = true;`
- Węzeł `[187]` (Petr Vectern): `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill"] = true;`
- Węzeł `[191]` (Petr Vectern): `Variable["BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect"] = true; Variable["BaseGameSuppo...`
- Węzeł `[195]` (Petr Vectern): `Variable["BaseGameSupport.Report_Turn05_Erzaren_PoliceReport"] = true;`
- *...oraz 31 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Petr Vectern)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Petr Vectern**
> "“Anton! Finally! Now the real party can start. Come on in!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Thank you, Petr. What's next? A choir? A marching band?”"]** — Mówca: **Player**
> "“Thank you, Petr. What's next? A choir? A marching band?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Far from becoming accustomed to my workload as president, I only felt more and more snowed under as the weeks passed. It had been ages since I had any time to myself."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "Gesture at one of the waitresses to come over."]** — Mówca: **Player_Italic**
> "I gestured at one of the waitresses to come over."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I was starting to lose my focus, and my temper was growing increasingly thin. Petr was the first to realize I needed a break."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "After much cajoling, he finally persuaded me to come to a meeting of his new venture: Gentlemen's Club."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "For the past few months, he'd been hosting a salon of sorts, not just for politicians and businessmen but also for artists, entertainers -- people of taste, he told me with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "There was only one rule: no wives or girlfriends allowed. Hence the name."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[11]`
Mówca: **Narrator**
> "And so I found myself in front of his new luxury villa in Erlory. Very loud jazz music emanated from inside. I waited and waited. Finally Petr opened the door. I could smell the whiskey on his breath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[12]`
Mówca: **Narrator**
> "We walked through the corridors of his mansion. Statues and paintings lined the stark white walls. An arched window provided a view of the neatly manicured grounds, complete with a swimming pool."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[13]`
Mówca: **Petr Vectern**
> "“Gentlemen! A minute of your time please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[14]`
Mówca: **Narrator**
> "As soon as I entered, Petr closed the door and turned to the small crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[15]`
Mówca: **Petr Vectern**
> "“I now have the privilege to present to you... The man himself... The fourth President of Sordland, Mr. Anton Rayne!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "I'd known him for long enough to understand that he was more than a little drunk. He made an elaborate mock-curtsy as I passed him and walked into the room. The music stopped, and I felt everyone's eyes on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[17]`
  - -> `[18]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“And I present to you, Petr Vectern. The first alcoholic Vice President of Sordland.”"]** — Mówca: **Player**
> "“And I present to you, Petr Vectern. The first alcoholic Vice President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Good evening.”"]** — Mówca: **Player**
> "“Good evening.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[19]`
Mówca: **Narrator**
> "My joke didn't sit well with Petr, nor the crowd. There was a short awkward silence before he continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
Mówca: **Petr Vectern**
> "“No. I'm saving those for your funeral.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Petr laughed very hard at his own grim joke before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Petr Vectern**
> "“Dear members, please give a warm welcome to our very special guest! If I may, Anton. Here, take this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "He handed me a glass of whiskey and put his hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[24]`
Mówca: **Petr Vectern**
> "“Let me show you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[25]`
Mówca: **Narrator**
> "Petr nodded at me and turned to the attendees."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
Mówca: **Petr Vectern**
> "“Anton Rayne might have the power to make presidential decrees, but, I, Petr Vectern, the president of this club, now declare this party started! Music! Go!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Narrator**
> "The band started up again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "After greeting the crowd around me, I felt a hand on my shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[29]`
Mówca: **Petr Vectern**
> "“That chandelier was made in the 18th century. Can you believe it? There's even a hedge maze in the garden!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“What's the story behind the chandelier?”"]** — Mówca: **Player**
> "“What's the story behind the chandelier?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“How are you paying for all of this?”"]** — Mówca: **Player**
> "“How are you paying for all of this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“An 18th-century chandelier? A hedge maze? A little much, isn't it?”"]** — Mówca: **Player**
> "“An 18th-century chandelier? A hedge maze? A little much, isn't it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[33]`
Mówca: **Narrator**
> "A grand Lespian marble staircase led up to the second story. Petr gestured at the massive crystal chandelier hanging overhead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[34]`
Mówca: **Petr Vectern**
> "“I don't know and I don't care. It just looks expensive and I like it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Petr Vectern**
> "“I'll let you in on a secret. Gus Manger has a lot of contacts in real estate. He brokered an amazing price for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Petr Vectern**
> "“Ah, come on, Anton. You only live once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
Mówca: **Petr Vectern**
> "“He'll also be here tonight, by the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[39]`
  - -> `[38]`
  - -> `[44]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""What did you promise him in return?""]** — Mówca: **Player**
> ""What did you promise him in return?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> "“Perfect. I've been looking for a chance to speak with him about investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[40]`
Mówca: **Petr Vectern**
> "“Only my money.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Narrator**
> "We continued walking until we circled back to where we had started."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> "“So, what do you think of my little hideaway?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[47]`
  - -> `[46]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "“Not bad. Not bad at all.”"]** — Mówca: **Player**
> "“Not bad. Not bad at all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Living in a lavish mansion while my country suffers is not for me.”"]** — Mówca: **Player**
> "“Living a lavish lifestyle while my country suffers is not for me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
> "“I understand completely. That's why I've donated 30 percent of my vice presidential salary to charities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`
  - -> `[220]`
  - -> `[226]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Frankly, I find it disgusting.""]** — Mówca: **Player**
> "“Frankly, I find it disgusting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "“It's amazing, but I'd hardly call it a hideaway. More like a palace.”"]** — Mówca: **Player**
> "“It's amazing, but I'd hardly call it a hideaway. More like a palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Petr Vectern**
> "“Jealous, are we? Like I said, you could have a place just like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
Mówca: **Petr Vectern**
> "“It definitely doesn't rival yours.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[50]`
Mówca: **Petr Vectern**
> "“Thanks! You know that you, Monica and the kids are always welcome here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Petr Vectern**
> "“Anyway, let's get back to the party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Petr Vectern**
> "“I arranged for some caviar to be brought in from Lespia. You're going to love it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "He opened the door to the main hall, and we rejoined the other guests. The music was louder now, and the mood decidedly more inebriated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Cocktail waitresses were carrying around plates of canapés, wearing dresses that left little to the imagination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[6]`
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Narrator**
> "She was in her mid-twenties, wearing red lipstick, her blonde hair neatly tied into a ponytail. On her plate were toast points slathered in the Lespian caviar Petr had mentioned."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“I thought this was a *Gentlemen*'s Club.”"]** — Mówca: **Player**
> "“I thought this was a *Gentlemen*'s Club.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "“So this is what you've been hiding from Evelyn.”"]** — Mówca: **Player**
> "“So this is what you've been hiding from Evelyn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Petr Vectern**
> "“Lespian caviar, best in the world! I'm telling you, Anton, there are few pleasures in life that are this...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> "“No one is hiding anything. She knows how important it is for men like us to blow off steam once in a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He averted his gaze for a second before calling over one of the waitresses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[61]`
Mówca: **Petr Vectern**
> "“Would you rather get served by wrinkly old men? Sweetheart! Over here!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Narrator**
> "He waved at one of the waitresses, and she came over to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[63]`
Mówca: **Narrator**
> "As the waitress left us to serve another attendee, she flashed a quick smile at Petr over her shoulder. He smiled back, a little too broadly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[64]`
Mówca: **Petr Vectern**
> "“Oh look, there's Gus. Why don't you go talk to him? I'll be back in a minute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“Petr. I am warning you. Don't make a mistake.”"]** — Mówca: **Player**
> "“Petr. I am warning you. Don't make a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“Where are you going?”"]** — Mówca: **Player**
> "“Where are you going?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[67]`
Mówca: **Petr Vectern**
> "“Mistake? What are you talking about? I'm just going to the... washroom. See you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "He left the room and I headed over to Gus."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Gus Manger was standing next to a couple of men that I recognized as banking industry magnates. As I approached, all of them turned to me and bowed their heads."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Gus Manger**
> "“Mr. President. A toast to our new member, everyone!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Gus and I clinked our glasses as the people around us raised theirs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`
  - -> `[74]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“You don't seem at all surprised to see me here.”"]** — Mówca: **Player**
> "“You don't seem at all surprised to see me here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“How long have you been a member?”"]** — Mówca: **Player**
> "“How long have you been a member?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“I heard this mansion is a result of your connections.”"]** — Mówca: **Player**
> "“I heard this mansion is a result of your connections.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Gus Manger**
> "“That's right. I do have a wide network in real estate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[76]`
Mówca: **Petr Vectern**
> "“We all know why we're gathered here tonight. To celebrate life. To have a brief escape from our tumultuous professions.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Petr Vectern**
> "“I personally don't know any better cure for stress than a little drink.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[82]`
  - -> `[81]`

### Węzeł `[78]`
Mówca: **Petr Vectern**
> "“Now. The tradition dictates that as the club president, I have to remind you of our house rules. There are three. No politics. No wives. No one sober! Cheers!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Narrator**
> "Petr drank the whiskey in his glass in one go."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[85]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "“Only a little one?”"]** — Mówca: **Player**
> "“Only a little one?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Raise your glass."]** — Mówca: **Player_Italic**
> "I raised my glass and the rest of the crowd followed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“I'll drink to that!”"]** — Mówca: **Player**
> "“I'll drink to that!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Narrator**
> "A few people in the crowd chuckled and some raised their glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[84]`
Mówca: **Narrator**
> "People in the crowd laughed and raised their glasses."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "Drain your glass."]** — Mówca: **Player_Italic**
> "I followed suit and drained my glass. It was immediately replenished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "Sip your whiskey."]** — Mówca: **Player_Italic**
> "I took a sip from my whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[87]`
Mówca: **Gus Manger**
> "“Since the beginning. It's a fun gathering, and quite lucrative at times.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[88]`
Mówca: **Gus Manger**
> "“That's because Petr told me you were going to come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Gus Manger**
> "“He also told me that you might be interested in potential opportunities such as, well... this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Narrator**
> "He opened his arms, gesturing at our opulent surroundings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Gus Manger**
> "“You might've heard from Petr that I arranged the deal for this mansion.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[92]`
Mówca: **Gus Manger**
> "“Petr told me a couple of weeks ago that you might be interested in potential opportunities such as, well... this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[93]`
Mówca: **Gus Manger**
> "“Let's take a walk. The balcony has an amazing view of Erlory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Narrator**
> "We left the room and made our way to the balcony. On the way, he took out two cigars and held one out for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "Take the cigar."]** — Mówca: **Player_Italic**
> "I took the cigar and started smoking it. Mixed with the taste of whiskey, it was delicious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "Refuse the cigar."]** — Mówca: **Player_Italic**
> "I turned the cigar down. Gus lit up his own and started smoking."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "We went out to the balcony. All of Erlory was at our feet. From this vantage point, I was able to see how expansive the building plot was. The swimming pool and the hedge maze were visible from here."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> "Leaning over the railing, I admired the view for a moment before Gus spoke up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[99]`
Mówca: **Gus Manger**
> "“Real estate is the best investment anyone can make. With the current economic situation, it only makes sense to put your money into such a tangible asset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Gus Manger**
> "“But I also have a few other opportunities for you to make a side profit, if real estate doesn't interest you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Gus Manger**
> "“Is there any chance I can convince you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[102]`
Mówca: **Gus Manger**
> "“I would be delighted to discuss a similar arrangement with you. In fact, I have prepared a document with my own personal favorite opportunities.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[103]`
Mówca: **Petr Vectern**
> "“He'll have a once-in-a-lifetime deal ready for you. He always does.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[104]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[106]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn01_InT_Investment_Railway == true || BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses == true || BaseGame.Relations_Walter_Promise_CompanyFulfilled == true || BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true) && BaseGame.Reform_EmergencyDecree_Embargo_Arcasia == false || BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn01_InT_Investment_Railway"] == true  or  Variable["BaseGame.Decision_Turn02_EconomicRelief_BailedBusinesses"] == true  or  Variable["BaseGame.Relations_Walter_Promise_CompanyFulfilled"] == true  or  Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true)  and  Variable["BaseGame.Reform_EmergencyDecree_Embargo_Arcasia"] == false  or  Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[170]`
  - -> `[169]`

### Węzeł `[107]`
Mówca: **Gus Manger**
> "“I would have been delighted to work with you, but unfortunately a deal won't be possible at this time. Not from me or my contacts at least.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Gus Manger**
> "“The Gasom affair notwithstanding, you've shown plenty of generosity to Sordish businesses. You deserve a chance to profit personally from their gains.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[131]`
  - -> `[119]`
  - -> `[118]`

### Węzeł `[109]`
**[WYBÓR GRACZA: "“Why is that?”"]** — Mówca: **Player**
> "“Why is that?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“I thought as much.”"]** — Mówca: **Player**
> "“I thought as much.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[111]`
Mówca: **Gus Manger**
> "“There have been some issues with my business, Mr. Rayne. Nothing life-or-death. But the hard work I put on the cancelled railway took up so much of my time that I've had to postpone some projects. I'm sure you understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I understand.”"]** — Mówca: **Player**
> "“I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“Think of it as an investment.”"]** — Mówca: **Player**
> "“Think of it as an investment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Gus Manger**
> "“It's unfortunate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[115]`
Mówca: **Gus Manger**
> "“I have already made my investment. Unfortunately, I have yet to see a return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[116]`
Mówca: **Gus Manger**
> "“I know you're wondering about the deal Petr made. In a nutshell, thanks to my network he was able to procure this house for half the asking price, which would've been impossible under any other circumstances.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[117]`
Mówca: **Gus Manger**
> ""Let me be direct.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“I'm glad my investment decisions are paying off.”"]** — Mówca: **Player**
> "“I'm glad my investment decisions are paying off.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“I am not looking to make any investments at the moment.”"]** — Mówca: **Player**
> "“I am not looking to make any investments at the moment.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[121]`
Mówca: **Gus Manger**
> "“Cheers to investments paying off, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Narrator**
> "He downed his whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[123]`
Mówca: **Gus Manger**
> "“No, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[124]`
Mówca: **Gus Manger**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“No. That's my final answer.”"]** — Mówca: **Player**
> "“No. That's my final answer.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
**[WYBÓR GRACZA: "“All right. Let me see what you have available.”"]** — Mówca: **Player**
> "“All right. Let me see what you have available.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[127]`
Mówca: **Gus Manger**
> "“Very well. I won't push further.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[128]`
Mówca: **Gus Manger**
> "“Let's talk about the details, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
Mówca: **Narrator**
> "He downed his whiskey."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Gus Manger**
> "“If you'll excuse me now, I will go refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[131]`
**[WYBÓR GRACZA: "“What's in it for you?”"]** — Mówca: **Player**
> "“What's in it for you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Gus Manger**
> "“Nothing, Mr. President. It's a simple thank you for supporting me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[133]`
Mówca: **Gus Manger**
> "“If you'll excuse me, I'm going to refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Gus opened his briefcase and pulled out a thin dossier. He showed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Gus Manger**
> ""There's also the option of a football partnership. I already own a large portion of FC Anrica, and I'm doing my best to make them champions. Buying in would be more expensive than the vineyard, but this season will bring a lot of returns, I'm quite positive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[136]`
Mówca: **Gus Manger**
> "“My biggest opportunity, though, is the possibility to buy shares in Underhall Construction. My connections ensured me that this would not be open to the public and would benefit you greatly. As you know, they are the biggest construction company in Sordland...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Gus Manger**
> ""My first offer is, of course, real estate. There is a vineyard close to Erlory, about a one-hour drive from here, that also includes a very large villa. A beautiful plot, but rather neglected, so there would be a fair amount of renovation costs. On the bright side, you would be able to produce your own wine. The previous owner was Giralt of Ribery, a world-renowned vintner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[138]`
Mówca: **Gus Manger**
> "“Give me the word, and I will start the procurement process. But we must act quickly as these options might soon disappear off the market.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[142]`

### Węzeł `[139]`
**[WYBÓR GRACZA: "“Football sounds exciting. I'll invest in FC Anrica.” [-2 Personal Wealth]"]** — Mówca: **Player**
> "“Football sounds exciting. I'll invest in FC Anrica.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "“I'll invest in Underhall Construction.” [-2 Personal Wealth]"]** — Mówca: **Player**
> "“I'll invest in Underhall Construction.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“The vineyard in Erlory. I've always wanted to have my own wine. And it sounds peaceful and quiet.” [-1 Personal Wealth]"]** — Mówca: **Player**
> "“The vineyard in Erlory. I've always wanted to have my own wine. And it sounds peaceful and quiet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[142]`
**[WYBÓR GRACZA: "“On second thought, I don't want to do this now.”"]** — Mówca: **Player**
> "“On a second thought, I don't want to do this now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[143]`
Mówca: **Gus Manger**
> "“Very well. Do not blame me if they are not available at a later date.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Underhall = true; BaseGameSupport.Journal_Turn05_GusInvestment_Underhall = true; BaseGame.Accepted_PersonalInvestment2 = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_P_Underhall"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_Underhall"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_FCAnrica = true; BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica = true; BaseGame.Accepted_PersonalInvestment2 = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_P_FCAnrica"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_FCAnrica"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[146]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_P_Vineyard = true; BaseGameSupport.Journal_Turn05_GusInvestment_Winery = true; BaseGame.Accepted_PersonalInvestment2 = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_P_Vineyard"] = true;
Variable["BaseGameSupport.Journal_Turn05_GusInvestment_Winery"] = true;
Variable["BaseGame.Accepted_PersonalInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[147]`
Mówca: **Gus Manger**
> "“Excellent. I will start the process right away. Now if you'll excuse me, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Gus Manger**
> "“If you'll excuse me, I'm going to refresh my drink. See you around.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Narrator**
> "He left to rejoin the party. Alone on the balcony, I looked out over Erlory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "Suddenly, I heard a rustling from the hedge maze below."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "I looked down and saw a silhouette. Two silhouettes, actually, so close together they seemed to be entangled. I squinted and tried to get a better look. It was definitely two people kissing, but I couldn't see either of their faces."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "I returned to the party and spent some time mingling with the other guests, engaging them in small talk about their businesses, their children, their relationships."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[153]`
Mówca: **Narrator**
> "Just then, Petr came up from behind us and threw an arm around each of our shoulders."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[154]`
Mówca: **Narrator**
> "He poured us two large glasses of whiskey, and we drank them in one go. Throughout the party, we drank and drank. Just like old times."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "I woke up the next day with a pounding headache and more than a few regrets."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Narrator**
> "My recollections of the evening were hazy, but there was one important detail that kept coming back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "The red lipstick on Petr's collar."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Narrator**
> "But maybe my memory was playing tricks on me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[159]`
Mówca: **Narrator**
> "I took a bite. It was rich, salty, tasting of pure seaside. I could almost hear the sound of waves and seagulls."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[160]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Personal_PetrParty = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Personal_PetrParty"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[161]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[177]`
  - -> `[139]`

### Węzeł `[163]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[164]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[167]`
Mówca: **Petr Vectern**
> "“Anton! Finally! Come in, relax, take a break from this crisis!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[168]`
**[WYBÓR GRACZA: "“I'd like to make a similarly profitable arrangement myself.”"]** — Mówca: **Player**
> "“I'd like to make a similarly profitable arrangement myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[169]`
**[WYBÓR GRACZA: "“That cheap, huh?”"]** — Mówca: **Player**
> "“That cheap, huh?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[170]`
**[WYBÓR GRACZA: ""You're wrong. I wasn't wondering.""]** — Mówca: **Player**
> ""You're wrong. I wasn't wondering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Gus Manger**
> "“Very well, then.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[172]`
**[WYBÓR GRACZA: "“I don't think I can afford an investment right now.”"]** — Mówca: **Player**
> "“I don't think I can afford an investment right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Gus Manger**
> "“Really?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[174]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[176]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[177]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: (BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[179]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !((BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true || BaseGame.Media_SordlandToday_Bias == true) && BaseGame.Faction_Oligarchs_Content == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true  or  Variable["BaseGame.Media_SordlandToday_Bias"] == true)  and  Variable["BaseGame.Faction_Oligarchs_Content"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[180]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[183]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[187]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_BludishProtestBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[188]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`
  - -> `[190]`

### Węzeł `[189]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[191]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect = true;
BaseGameSupport.News_Turn05_R_StateWarYS = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_HPEditorSuspect"] = true;
Variable["BaseGameSupport.News_Turn05_R_StateWarYS"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[192]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[194]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_PoliceAuthority == true || BaseGame.Reform_EmergencyDecree_SuspendedProtests == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_PoliceAuthority"] == true  or  Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[195]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Erzaren_PoliceReport = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Erzaren_PoliceReport"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[196]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[198]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[199]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[200]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`
  - -> `[202]`

### Węzeł `[201]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[202]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[205]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[206]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Vetoed_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[207]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_ReligionBill_Signed_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[208]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[210]`

### Węzeł `[209]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[210]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_PetrParty_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[212]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_Personal_ReturnOfInvestment2 = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[213]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[214]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[215]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.PersonalWealth"] = Variable["BaseGame.PersonalWealth"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[216]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`
  - -> `[218]`

### Węzeł `[217]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[218]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[219]`
**[WYBÓR GRACZA: "“Really?”"]** — Mówca: **Player**
> "“Really?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
**[WYBÓR GRACZA: "“I don't believe you.”"]** — Mówca: **Player**
> "“I don't believe you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Petr Vectern**
> "“That's what it says on my tax forms, at least.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[222]`
Mówca: **Petr Vectern**
> ""...Sensual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Narrator**
> "His eyes were still fixed on her, with an expression I remembered from our many nights out together as students."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[224]`
Mówca: **Petr Vectern**
> ""Oh, just to the washroom. See you shortly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[225]`
Mówca: **Gus Manger**
> ""I knew you'd come around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[226]`
**[WYBÓR GRACZA: "“That's nice of you.”"]** — Mówca: **Player**
> "“That's nice of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[227]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_ArcasiaAid = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_ArcasiaAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[228]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_G_UCAid = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_G_UCAid"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[229]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  and  Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[231]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptArcasia == true && BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptArcasia"] == true  and  Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[232]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[234]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana == true && BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_SPAid_AcceptUnitedContana"] == true  and  Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[235]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_Education_Privatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_Education_Privatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_Education_Privatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[238]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_EducationPrivatizationResult"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[239]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_Personal_ReturnOfInvestment2 = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[240]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_InT_Investment_Railway == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[242]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_InT_Investment_Railway == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Gus Manger**
> "“There have been some issues with my business, Mr. Rayne. Nothing life-or-death. But I've been putting so much work into advancing rural development that I've had to postpone some projects. I'm sure you understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[244]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[246]`

### Węzeł `[245]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[246]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[247]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 2;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 2;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[248]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[249]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[251]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[252]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[254]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxIncrease_LargeCorporations"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[256]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`
  - -> `[258]`

### Węzeł `[257]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[258]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_EnT_TaxBreak_SmallMediumBusinesses"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[259]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Economy -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[260]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[261]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: GameCondition.Turn06_Personal_ReturnOfInvestment2 = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn06_Personal_ReturnOfInvestment2"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[262]`
Mówca: **Gus Manger**
> ""You must know that the offered price is not suitable for every client.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[263]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_FireInvestigationHold"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[264]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: PlaySoundEffect("MansionParty");)*
- **Efekt (`userScript`):** `PlaySoundEffect("MansionParty");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[265]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Sarna_BFFPropagandaInSchools"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_HP_BFFPropaganda = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_HP_BFFPropaganda"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[267]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[268]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: SetRichPresence("Signed a bill which restricts religious freedoms", "Maroon Palace", "Holsord");)*
- **Efekt (`userScript`):** `SetRichPresence("Signed a bill which restricts religious freedoms","Maroon Palace","Holsord");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[269]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why am I not surprised? Gus the wheeler and dealer would be right at home at a party like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[270]`
Mówca: **Petr Vectern**
> ""Hell, half of the guests here owe their considerable riches to him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[271]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone == true || BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_LargeSordlandInvestmentAlone"] == true  or  Variable["BaseGame.Turn03_EnT_Gasom_CoInvestmentRizia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[274]`
Mówca: **Gus Manger**
> "“Your willingness to invest in Gasom showed you were a man after my own heart. I'd love to talk about how my network can benefit you personally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`
  - -> `[131]`
  - -> `[119]`
  - -> `[118]`

### Węzeł `[275]`
Mówca: **Narrator**
> "I realized it had been a while since Petr left. I looked around, but couldn't find him. Instead, my eyes landed on Ewald Alphonso."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[276]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: AddConversant("Ewald Alphonso");)*
- **Efekt (`userScript`):** `AddConversant("Ewald Alphonso");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Narrator**
> "With a reluctant look in his eyes, the former president walked over to meet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[284]`
  - -> `[285]`
  - -> `[283]`

### Węzeł `[278]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_Discontent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_Discontent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[280]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_Discontent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_Discontent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[281]`
Mówca: **Narrator**
> "With a smile, the former president walked over to meet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`
  - -> `[284]`
  - -> `[285]`
  - -> `[283]`

### Węzeł `[282]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. Alphonso. I didn't know you were a member of Petr's club.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[283]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Mr. President. Is that an empty glass I see in your hand?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[284]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Isn't a party like this a little low-class for a man like you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[285]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know the rules. No politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[286]`
Mówca: **Ewald Alphonso**
> ""I'm not. Gus and I were having a business dinner, and he convinced me to come along afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Ewald Alphonso**
> ""The surroundings are a little tacky, I admit. But Gus convinced me the networking opportunities would be unparalleled.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[288]`
Mówca: **Ewald Alphonso**
> ""I saw you speaking to Mr. Manger earlier.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`
  - -> `[298]`

### Węzeł `[289]`
Mówca: **Ewald Alphonso**
> ""I'm trying to pace myself. Gus and I split a bottle of Rizian wine over dinner before heading here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[290]`
Mówca: **Ewald Alphonso**
> ""No politics. But plenty of side deals, it seems.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[291]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_PersonalInvestment2 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Accepted_PersonalInvestment2 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Accepted_PersonalInvestment2"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[293]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Accepted_PersonalInvestment2 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Accepted_PersonalInvestment2"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[294]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""That's right. He offered me some lucrative investment opportunities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[295]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, he and I are going into business together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[296]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Just briefly. I wasn't interested in what he was offering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[297]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He seems used to making deals with sitting presidents. But he and I won't be going into business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`

### Węzeł `[298]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We talked, yes. It's always nice to get to know one's ministers outside of the Maroon Palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[299]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`
  - -> `[301]`

### Węzeł `[300]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[301]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[302]`
Mówca: **Ewald Alphonso**
> ""Hmm. Interesting that you'd take him up on that while ignoring the far more lucrative opportunity to invest in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[303]`
Mówca: **Ewald Alphonso**
> ""Why not? Seems like a natural progression after our Gasom deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[304]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[306]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[307]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act shows your carelessness with that particular investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[340]`
  - -> `[341]`

### Węzeł `[308]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[310]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[311]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act -- despite your promise to me -- shows your carelessness with that particular investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[340]`
  - -> `[341]`

### Węzeł `[312]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`

### Węzeł `[314]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_EnergyProtectionAct_10Percent == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_EnergyProtectionAct_10Percent"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[315]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act proves that a profitable Gasom was never your goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[340]`
  - -> `[341]`

### Węzeł `[316]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`
  - -> `[318]`

### Węzeł `[317]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[318]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Ewald_PromiseNotHarsherEPA == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Ewald_PromiseNotHarsherEPA"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[319]`
Mówca: **Ewald Alphonso**
> ""Although your tightening of the Energy Protection Act -- despite your promise to me -- proves that a profitable Gasom was never your goal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`
  - -> `[340]`
  - -> `[341]`

### Węzeł `[320]`
Mówca: **Ewald Alphonso**
> ""At any rate, it's doing fine without Sordland's input. A shame that only its international investors will benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`
  - -> `[338]`
  - -> `[339]`

### Węzeł `[321]`
Mówca: **Ewald Alphonso**
> ""We're seeing growing interest from international investors, by the way. I'm optimistic about the results of Sordland's investment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`
  - -> `[335]`
  - -> `[336]`

### Węzeł `[322]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`
  - -> `[324]`

### Węzeł `[323]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Ewald Alphonso**
> ""It figures. I don't know why he thought you'd be interested in other investments after you passed on the Gasom opportunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[326]`
Mówca: **Ewald Alphonso**
> ""Interesting. I would have thought you'd be interested in other opportunities after investing in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[327]`
Mówca: **Ewald Alphonso**
> ""We had a good chat together back in Narbel, as I recall.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`
  - -> `[330]`

### Węzeł `[329]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[330]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[331]`
Mówca: **Ewald Alphonso**
> ""Before you turned down the opportunity to invest in Gasom, that is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[332]`
Mówca: **Ewald Alphonso**
> ""Resulting in your very wise decision to invest Sordish money in Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[333]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""No politics, remember?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[334]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Terrific. I'm looking forward to a big payoff.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[335]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm glad that Sordland could help your company thrive.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[336]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Enjoy our bailout, Mr. Alphonso. It'll be your only one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`

### Węzeł `[337]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""And you, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[338]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I still stand by my decision. There were better uses for that money.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[339]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Yes, perhaps Sordland should've invested. But it's too late for regrets.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[340]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'm sorry about that. My party forced me to do it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`

### Węzeł `[341]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Unlike you, I know better than to mess with a successful Tarquin Soll policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
Mówca: **Ewald Alphonso**
> ""I know how much pressure the USP can exert. But I also know that with a little courage, resistance is possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`

### Węzeł `[343]`
Mówca: **Ewald Alphonso**
> ""It seems your courage failed you. And you, in turn, have failed Gasom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[344]`
Mówca: **Ewald Alphonso**
> ""That policy put a chokehold on Sordish businesses. Thanks to you, it is doing so again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[345]`
Mówca: **Ewald Alphonso**
> ""That goes without saying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[346]`
Mówca: **Ewald Alphonso**
> ""Better uses, maybe. But not more profitable ones.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[347]`
Mówca: **Ewald Alphonso**
> ""It's not too late to remember to take more risks in the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[348]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[349]`
Mówca: **Ewald Alphonso**
> ""No politics. But this conversation is not over.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[350]`
Mówca: **Ewald Alphonso**
> ""As I've told you, this isn't a bailout. You'll get your money back and then some.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[351]`
Mówca: **Ewald Alphonso**
> ""And vice versa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[352]`
Mówca: **Ewald Alphonso**
> ""I can't tell you for sure how big it will be. But our projections are looking good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[353]`
Mówca: **Petr Vectern**
> ""Look at you two! Sordland's bright future and its ancient, ancient past.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`
  - -> `[355]`
  - -> `[356]`
  - -> `[357]`

### Węzeł `[354]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. Behave yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[361]`

### Węzeł `[355]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's been an hour. Where were you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[356]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""My apologies, Mr. Alphonso. My vice president's had a bit too much to drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`

### Węzeł `[357]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Another brilliant zinger, Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[358]`
Mówca: **Petr Vectern**
> ""I told you. The washroom. Trust me, you'd rather not know the details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[359]`
Mówca: **Petr Vectern**
> ""That's what I'm here for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[360]`
Mówca: **Petr Vectern**
> ""Pardon me, Mr. President, but I've had exactly enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[361]`
Mówca: **Petr Vectern**
> ""Yes, Mr. President. Right away, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Petr Vectern**
> ""Well, Mr. Alphonso? Have you been enjoying my hospitality?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[363]`
Mówca: **Narrator**
> "Alphonso smiled politely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[364]`
Mówca: **Ewald Alphonso**
> ""Indeed I have, Mr. Vectern. You've put together one hell of a gathering.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[365]`
Mówca: **Ewald Alphonso**
> ""If you'll excuse me, I'm going to have a quick word with the CEO of Sordish Petroleum.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`
  - -> `[368]`

### Węzeł `[366]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""He's here, too? What a party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[367]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Have fun mingling. It was good to see you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""We'll talk soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[369]`
Mówca: **Narrator**
> "Alphonso gave a brusque wave and walked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[370]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: RemoveConversant("Ewald Alphonso");)*
- **Efekt (`userScript`):** `RemoveConversant("Ewald Alphonso");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[371]`
Mówca: **Narrator**
> "Petr shifted his weight unsteadily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`
  - -> `[374]`

### Węzeł `[373]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[374]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true || BaseGame.Prologue_Party_Takeover_PublicBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Petr Vectern**
> ""Nice guy. I almost feel bad about the way we took him down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[379]`
  - -> `[378]`

### Węzeł `[376]`
Mówca: **Petr Vectern**
> ""Nice guy. A shitty president, but a nice guy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`
  - -> `[379]`
  - -> `[378]`

### Węzeł `[377]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Was that you in the hedge maze, Petr?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[378]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Why didn't you tell me Ewald Alphonso was coming?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I will give you one more chance. Where were you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[380]`
Mówca: **Petr Vectern**
> ""I didn't know! Gus brought him along. And when a former president of Sordland knocks on your door, you can't exactly turn him away.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`
  - -> `[388]`

### Węzeł `[381]`
Mówca: **Narrator**
> "Petr assumed a patient look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Petr Vectern**
> ""Well, Mr. President, when too much Sordish whiskey meets too much Lespian caviar, it can lead to a gastrointestinal imbroglio the likes of which the world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`
  - -> `[386]`

### Węzeł `[383]`
Mówca: **Petr Vectern**
> ""What are you talking about?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`
  - -> `[386]`

### Węzeł `[384]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""While you were gone, I saw two people kissing in the hedge maze outside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[385]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""I'll be direct. Were you with the waitress?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[386]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""You know what? Never mind. Let's get another drink.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[387]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Next time, I want to be able to vet your guest list. You're risking a breach of national security with these parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""It's fine. I was happy to see him. But it was definitely a surprise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[389]`
Mówca: **Petr Vectern**
> ""Anton. Can't a man have some fun outside of work?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[390]`
Mówca: **Petr Vectern**
> ""Now you're speaking my language.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[391]`
Mówca: **Petr Vectern**
> ""That's what I'm aiming for with these parties. All kinds of unexpected, stimulating encounters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`

### Węzeł `[392]`
Mówca: **Petr Vectern**
> ""What? No, no. How could you even think that? I'm a married man.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[393]`
Mówca: **Petr Vectern**
> ""Huh. Probably a couple of kitchen staff getting frisky with each other. What do I even pay them for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""All right. If you say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[395]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Petr. You know you can tell me anything.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[396]`
Mówca: **Petr Vectern**
> ""But sure. If it'll make you happy, I'll tighten my villa's border control policy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Narrator**
> "He contorted the side of his face in an attempt at a wink."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[398]`
Mówca: **Petr Vectern**
> ""Now who wants a drink? Besides me, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[399]`
Mówca: **Narrator**
> "I thought I saw his cheerful expression slip for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[400]`
Mówca: **Petr Vectern**
> ""Yeah. I know. Trust me, it's nothing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[401]`
Mówca: **Petr Vectern**
> ""I do say so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`

### Węzeł `[402]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`
  - -> `[404]`

### Węzeł `[403]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[404]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Gasom_OnlyRiziaInvestment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[405]`
Mówca: **Ewald Alphonso**
> ""No politics. But your returns are not looking good, to say the least.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[406]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[410]`

### Węzeł `[408]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn04_GruniRuralDev_NoFunding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn04_GruniRuralDev_NoFunding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[409]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_GoodNoInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[410]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[412]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[413]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Law_MediaBias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Law_MediaBias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[415]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Law_MediaBias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Law_MediaBias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[416]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadNoInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[417]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_GreatInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[418]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn05_ST_GruniRuralDev_BadInvestment"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[419]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`
  - -> `[421]`

### Węzeł `[420]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`

### Węzeł `[421]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromotePlanned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[422]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`
  - -> `[424]`

### Węzeł `[423]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Economy_PromotePlanned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Economy_PromotePlanned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[424]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Economy_PromotePlanned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Economy_PromotePlanned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[425]`
Mówca: **Petr Vectern**
*(Węzeł logiki narracyjnej: BaseGame.Economy += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Economy"] = Variable["BaseGame.Economy"] + 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
