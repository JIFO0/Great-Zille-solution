# Sordland/Turn01/Start_Inauguration

- **ID konwersacji:** `6`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 01`
- **Lokalizacja pliku:** `Sordland/Turn_01/006_Start_Inauguration.md`
- **Liczba węzłów dialogowych:** 134
- **Liczba wyborów gracza:** 39

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[8]** Orso Hawker
- **[10]** Narrator
- **[54]** Serge Wolkner

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Party_CampaignedForAlphonso`
- `BaseGame.Prologue_Party_Takeover_Backstab`
- `BaseGame.Prologue_Party_Takeover_Diplomatic`
- `BaseGame.Prologue_Party_Takeover_PublicBlame`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Promise_Diplomacy_None`
- `BaseGame.Promise_Diplomacy_West`
- `BaseGame.Promise_TermFocus_Military`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Capitalist`
- `BaseGame.Malenyevist`
- `BaseGame.Sollist`
- `BaseGameSupport.Codex_Characters_Others_SergeWolkner`
- `BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace`
- `BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport`
- `BaseGameSupport.News_Turn01_E_Infrastructure`
- `BaseGameSupport.News_Turn01_E_Sollonomics`
- `BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes`
- `BaseGameSupport.News_Turn01_HP_Speech_ChangeHope`
- `BaseGameSupport.News_Turn01_HP_Speech_DireSituation`
- `BaseGameSupport.News_Turn01_HP_Speech_Unity`
- `BaseGameSupport.News_Turn01_LT_NewAssembly`
- `BaseGameSupport.News_Turn01_R_AnotherUSP`
- `BaseGameSupport.News_Turn01_ST_President_Deyr`
- `BaseGameSupport.News_Turn01_ST_President_Holsord`
- `BaseGameSupport.News_Turn01_ST_President_Lachaven`
- `BaseGameSupport.Report_Turn01_Arvory_LackofInvestment`
- `BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers`
- `BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues`
- `BaseGameSupport.Report_Turn01_Holsord_StaffGathers`
- `BaseGameSupport.Report_Turn01_Lachaven_Port`
- `BaseGameSupport.Report_Turn01_Laren_LowProduction`
- `GameCondition.Turn01_Start_Inauguration`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 20

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`
- `BaseGameSupport.News_Turn01_E_Sollonomics`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[44]` (Orso Hawker): `Variable["GameCondition.Turn01_Start_Inauguration"] = true;`
- Węzeł `[74]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_HP_Speech_DireSituation"] = true;`
- Węzeł `[75]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_HP_Speech_ChangeHope"] = true; ;`
- Węzeł `[76]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_HP_Speech_Unity"] = true;`
- Węzeł `[80]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_ST_President_Deyr"] = true;`
- Węzeł `[84]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_ST_President_Holsord"] = true;`
- Węzeł `[85]` (Orso Hawker): `Variable["BaseGameSupport.News_Turn01_ST_President_Lachaven"] = true;`
- Węzeł `[86]` (Orso Hawker): `Variable["BaseGameSupport.Report_Turn01_Laren_LowProduction"] = true;`
- *...oraz 12 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Orso Hawker)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Orso Hawker)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "In the distance, the Maroon Palace stood on top of the famous Hill of Pride. I had no way of knowing what future awaited me there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I looked at my family. My son and daughter, Franc and Deana, were next to Monica, my wife. Her eyes were glimmering with pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[5]`
Mówca: **Narrator**
> "As my thoughts slowly faded away, the reality of the situation dawned on me. Orso Hawker, the Chief Justice of the Supreme Court, was waiting for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Orso Hawker**
> "“The time for the oath has come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`
  - -> `[9]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“I am ready.”"]** — Mówca: **Player**
> "“I am ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“It has indeed.”"]** — Mówca: **Player**
> "“It has indeed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[9]`
**[WYBÓR GRACZA: "“Let’s start.”"]** — Mówca: **Player**
> "“Let’s start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Orso Hawker**
> "“Please repeat after me. I do solemnly swear...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“I do solemnly swear...”"]** — Mówca: **Player**
> "“I do solemnly swear that I will respectfully execute the office of the President of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Orso Hawker**
> "“And to the best of my ability, preserve, protect and defend...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“And to the best of my ability, preserve, protect and defend...”"]** — Mówca: **Player**
> "“And to the best of my ability, preserve, protect and defend the people and the constitution of the Republic of Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Orso Hawker**
> "“You may now deliver your inauguration speech, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Thank you.”"]** — Mówca: **Player**
> "“Thank you, Mr. Hawker.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[93]`
  - -> `[94]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It is an honor.”"]** — Mówca: **Player**
> "“It is an honor, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[93]`
  - -> `[94]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Good, let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`
  - -> `[93]`
  - -> `[94]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Dear citizens of Sordland!”"]** — Mówca: **Player**
> "“Dear citizens of Sordland!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "The crowd looked very eager to listen to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[21]`
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“The idea of unity.”"]** — Mówca: **Player**
> "“For many generations, this country and its long history have kept us tied to an idea – the idea of unity, and our people’s right for a free and prosperous life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[21]`
**[WYBÓR GRACZA: "“The current dire situation.”"]** — Mówca: **Player**
> "“We are enduring economic hardship like never before, and today, our nation is falling apart. Our people – we –suffer in this dire situation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[22]`
**[WYBÓR GRACZA: "“Change and hope.”"]** — Mówca: **Player**
> "“You, the people, have chosen. Together, we will bring prosperity and reform to our nation. It is a time of hope, it is a time of change.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“It is time for a united and powerful Sordland once again!”"]** — Mówca: **Player**
> "“It is time for a united and powerful Sordland once again!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Change now, not in the next decade, or years. Today!”"]** — Mówca: **Player**
> "“Change now, not in the next decade or years. Today!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Our capacity as a nation has never been greater!”"]** — Mówca: **Player**
> "“Our capacity as a nation has never been greater!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> "Hundreds of thousands cheered. They were shouting my name in unison. I felt the responsibility, the power and the burden all at the same time."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[72]`
  - -> `[73]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Nice to meet you, Serge.”"]** — Mówca: **Player**
> "“Nice to meet you, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“It's a pleasure.”"]** — Mówca: **Player**
> "“It's a pleasure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Serge Wolkner**
> "“It's an honor.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[30]`
Mówca: **Serge Wolkner**
> "“The pleasure is all but mine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[31]`
Mówca: **Narrator**
> "The motorcade began to move. On the way, Serge proceeded to explain his duties as a driver."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“Every time I look at it, I am reminded of my duty to this nation.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[33]`
  - -> `[34]`
  - -> `[66]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“So do I, Serge. It is the beating heart of the nation after all.”"]** — Mówca: **Player**
> "“So do I, Serge. It is the beating heart of the nation after all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“We all owe a great debt to the men who led the country from here.”"]** — Mówca: **Player**
> "“We all owe a great debt to the men who led the country from here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA: "“It is in good hands now.”"]** — Mówca: **Player**
> "“It is in good hands now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[36]`
Mówca: **Serge Wolkner**
> "“I am sure of that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Serge Wolkner**
> "“Well said, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Serge Wolkner**
> "“Their service will not be forgotten.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Narrator**
> "The car drove past the majestic gates, continued uphill to the entrance and stopped in front of the doors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[40]`
Mówca: **Serge Wolkner**
> "“Have a great day, Mr. President. A Morgna wes core.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[41]`
**[WYBÓR GRACZA: "“Goodbye.”"]** — Mówca: **Player**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“See you soon.”"]** — Mówca: **Player**
> "“See you soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Narrator**
> "I made my way upstairs through the extravagant corridors of the palace. Marble and engraved wooden finishes decorated the interior."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[44]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: GameCondition.Turn01_Start_Inauguration = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn01_Start_Inauguration"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> "“Hello, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[46]`
Mówca: **Serge Wolkner**
> "“If you'll allow me to introduce myself, I am Serge, your new driver.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[62]`
  - -> `[28]`

### Węzeł `[47]`
Mówca: **Serge Wolkner**
> "“We will be heading towards the palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[48]`
Mówca: **Serge Wolkner**
> "“Isn't it a beauty? The Maroon Palace.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "“If we stand together, we prevail.”"]** — Mówca: **Player**
> "“In the past, there have been times of survival – times of conflict and economic hardship too – but whenever we stood together, we prevailed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[100]`
  - -> `[103]`
  - -> `[106]`
  - -> `[98]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“The issues that plague us.”"]** — Mówca: **Player**
> "“We still have insufficient infrastructure – houses without electricity, without water. We have crime in our streets, unemployment within the youth, and we still have injustices in the government that plague us.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[100]`
  - -> `[103]`
  - -> `[106]`
  - -> `[98]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Our capabilities.”"]** — Mówca: **Player**
> "“Our workers are no less productive than a decade ago. Our capable minds are no less inventive, our products and services no less requested than they were last week, last month, or last year.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[100]`
  - -> `[103]`
  - -> `[106]`
  - -> `[98]`

### Węzeł `[52]`
Mówca: **Narrator**
> "I still felt euphoric from the aftermath of my speech. Hearing my new title made me smile even more."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[53]`
Mówca: **Narrator**
> "I took a long look at the people of Sordland to burn this moment into my memory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[54]`
Mówca: **Narrator**
> "The presidential state car was a jet black Kadilla with flags of Sordland above the front headlights. Next to it, a man was holding the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[55]`
Mówca: **Narrator**
> "As minutes passed by, I found myself lost in thought again, barely paying attention to what he was saying. He suddenly gestured out the window."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[56]`
Mówca: **Narrator**
> "He was right. Sunlight glinted off the palace's many maroon-coloured domes. It was so bright that I had to look away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Serge got out of the car and opened the door for me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Then I turned towards the key people who made it all possible. Of course, each individual was promised an important position in my government."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[59]`
Mówca: **Narrator**
> "Two weeks had passed since we won the election."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[60]`
Mówca: **Narrator**
> "And now I was about to be sworn in as the 4th President of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Narrator**
> "Thousands were watching the inauguration ceremony and cheering my name: Anton Rayne."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“At ease, Serge.”"]** — Mówca: **Player**
> "“At ease, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Serge Wolkner**
> "“As you wish, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Narrator**
> "One of the presidential guards came by to notify me that it was time to leave. I made my way to the leading car in the motorcade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[65]`
Mówca: **Narrator**
> "He respectfully bowed his head before opening the car door and gesturing inside. I entered the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[66]`
**[WYBÓR GRACZA: "“It's just a building, Serge.”"]** — Mówca: **Player**
> "“It's just a building, Serge.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Serge Wolkner**
> "“You are right, Mr. President. I don't know much about architecture, but for me, it's the most beautiful building in all of Holsord.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[68]`
Mówca: **Narrator**
> "He referred to the famous Sordish phrase from the times of revolution; "A Morgna wes core, Vectern sis da!" which meant "Morning will come, Victory is close.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`
  - -> `[69]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "The die was cast."]** — Mówca: **Player_Italic**
> "The die was cast and there my story began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "Raise fist."]** — Mówca: **Player_Italic**
> "I raised my fist in the air, which triggered a huge burst of applause."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Italic**
> "I waved at the crowd, which made the people cheer louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "Enjoy the moment."]** — Mówca: **Player_Italic**
> "Taking a deep breath in, I enjoyed the moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[74]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_HP_Speech_DireSituation = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_DireSituation"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[75]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_HP_Speech_ChangeHope = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_ChangeHope"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[76]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_HP_Speech_Unity = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_HP_Speech_Unity"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[77]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[79]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[80]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_President_Deyr = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Deyr"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[81]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_President_Holsord = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Holsord"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[85]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_ST_President_Lachaven = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_ST_President_Lachaven"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[86]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Laren_LowProduction = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Laren_LowProduction"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Lachaven_Port = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Lachaven_Port"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Arvory_LackofInvestment = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Arvory_LackofInvestment"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[89]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_LogisticalIssues"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[90]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Others_SergeWolkner = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Others_SergeWolkner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[91]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Locations_Landmarks_MaroonPalace"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[92]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn01_E_Sollonomics = true;
BaseGameSupport.News_Turn01_E_Infrastructure = true;
BaseGameSupport.News_Turn01_LT_NewAssembly = true;
BaseGameSupport.News_Turn01_R_AnotherUSP = true;
BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport = true;
BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn01_E_Sollonomics"] = true;
Variable["BaseGameSupport.News_Turn01_E_Infrastructure"] = true;
Variable["BaseGameSupport.News_Turn01_LT_NewAssembly"] = true;
Variable["BaseGameSupport.News_Turn01_R_AnotherUSP"] = true;
Variable["BaseGameSupport.FactionReport_Turn01_ATO_HumanRightsReport"] = true;
Variable["BaseGameSupport.News_Turn01_HP_CampaignBill_HaltedWorkResumes"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Brothers and sisters!”"]** — Mówca: **Player**
> "“Brothers and sisters!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“My fellow Sords!”"]** — Mówca: **Player**
> "“My fellow Sords!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“I promise you, we *will* stop the recession and eliminate poverty!”"]** — Mówca: **Player**
> "“I promise you, we *will* stop the recession and eliminate poverty!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“The future awaits us! It's time to turn our faces to the east!”"]** — Mówca: **Player**
> "“The future awaits us! It's time to turn our faces to the east!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“The future awaits us! It's time to turn our faces to the west!”"]** — Mówca: **Player**
> "“The future awaits us! It's time to turn our faces to the west!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[98]`
**[WYBÓR GRACZA: "“First, we must rewrite our broken Constitution from 1929!”"]** — Mówca: **Player**
> "“First, we must rewrite our broken Constitution from 1929!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“The future awaits us! Sordland is above all in the world!”"]** — Mówca: **Player**
> "“The future awaits us! Sordland is above all in the world!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[100]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[102]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[103]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[105]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[106]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[108]`

### Węzeł `[107]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_None == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_None"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[108]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_None == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_None"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[109]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[111]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_West == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_West"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[114]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_West == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_West"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[115]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Malenyevist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Malenyevist"] = Variable["BaseGame.Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[116]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Capitalist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Capitalist"] = Variable["BaseGame.Capitalist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[117]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Sollist += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[118]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Promise_TermFocus_Military == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_TermFocus_Military"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_TermFocus_Military == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_TermFocus_Military"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_FocusStaffGathers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[122]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn01_Holsord_StaffGathers = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn01_Holsord_StaffGathers"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[123]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso, who gave me a slight nod. Tarquin Soll was also invited, but as expected, he didn’t leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[124]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[126]`

### Węzeł `[125]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[126]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Takeover_Backstab == true && BaseGame.Prologue_Party_Takeover_PublicBlame == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Takeover_Backstab"] == true  and  Variable["BaseGame.Prologue_Party_Takeover_PublicBlame"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[129]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_CampaignedForAlphonso == true || BaseGame.Prologue_Party_Takeover_Diplomatic == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_CampaignedForAlphonso"] == true  or  Variable["BaseGame.Prologue_Party_Takeover_Diplomatic"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso. Tarquin Soll was also invited, but as expected, he didn’t leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[131]`
Mówca: **Narrator**
> "I saw my previous rival and former president, Ewald Alphonso. Tarquin Soll was also invited, but as expected, he didn't leave his island retreat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[132]`
Mówca: **Narrator**
> "My footsteps echoed in the colossal halls. The guards bowed their heads in respect as I opened the massive doors to my new office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[133]`
Mówca: **Orso Hawker**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
