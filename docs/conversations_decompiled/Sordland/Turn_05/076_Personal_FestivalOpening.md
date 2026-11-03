# Sordland/Turn05/Personal_FestivalOpening

- **ID konwersacji:** `76`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 05`
- **Lokalizacja pliku:** `Sordland/Turn_05/076_Personal_FestivalOpening.md`
- **Liczba węzłów dialogowych:** 423
- **Liczba wyborów gracza:** 81

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[37]** Curtan Leste

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn05_ReligiousHarmony_Signed`
- `BaseGame.Country_Unrest`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Turn03_EnT_Education_Budget_Decrease`
- `BaseGame.Turn03_EnT_Healthcare_Budget_Decrease`
- `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGame.Turn04_SnO_LE_Balanced_Decreased`
- `BaseGame.Turn04_SnO_LE_Balanced_Increased`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Democratic`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Sollist`
- `BaseGame.Turn05_Personal_Festival_Force`
- `BaseGame.Turn05_Personal_Festival_LesteKicked`
- `BaseGame.Turn05_Personal_Festival_LesteLeft`
- `BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked`
- `BaseGameSupport.News_Turn05_HP_GruniReturnsNormal`
- `BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators`
- `BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill`
- `BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased`
- `BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced`
- `BaseGameSupport.Report_Turn05_Estord_Unrest`
- `BaseGameSupport.Report_Turn05_Holsord_EducationNegative`
- `BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative`
- `BaseGameSupport.Report_Turn05_Lachaven_NoUnrest`
- `BaseGameSupport.Report_Turn05_Uziren_Refugees`
- `GameCondition.Turn05_A_DamageControl`
- `GameCondition.Turn05_Personal_BenfiFestival`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 45

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Relations_Monica_SupportedAtFestival`
- `BaseGame.Sollist`
- `BaseGameSupport.Report_Turn05_Estord_Unrest`
- `BaseGameSupport.Report_Turn05_Lachaven_NoUnrest`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[131]` (Curtan Leste): `Variable["BaseGame.Turn05_Personal_Festival_Force"] = true; Variable["BaseGame.Turn05_Personal_Fe...`
- Węzeł `[204]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- Węzeł `[205]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- Węzeł `[206]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- Węzeł `[207]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- Węzeł `[217]` (Curtan Leste): `Variable["GameCondition.Turn05_Personal_BenfiFestival"] = true;`
- Węzeł `[226]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- Węzeł `[227]` (Curtan Leste): `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- *...oraz 37 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Curtan Leste)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[418]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Curtan Leste)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Our motorcade slowly made its way towards the magnificent Benfi High Arts Center. Night was falling, and the festival was about to begin. I flipped through the brochure that had been given to us at the hotel."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[4]`
Mówca: **Narrator**
> "As soon as Serge opened the door, we were enveloped by the roar of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[5]`
Mówca: **Narrator**
> "She nervously eyed the waiting crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[6]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[8]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[9]`
Mówca: **Narrator**
> "Since I'd refused to let her make the opening speech, her attitude toward me had changed. She now only spoke to me if I asked her a question, or if it was something important concerning the children."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[20]`
  - -> `[408]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“Don't worry. You're going to be fine.""]** — Mówca: **Player**
> "“Don't worry. You're going to be fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“Do not mess this up.”"]** — Mówca: **Player**
> "“Do not mess this up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Hold her hand."]** — Mówca: **Player_Italic**
> "I took her hand in mine and gave it a firm squeeze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[13]`
Mówca: **Narrator**
> "She smiled and turned her head to look out the window once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[14]`
Mówca: **Narrator**
> "Monica swallowed hard. Her eyes grew wider."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Narrator**
> "She gave me a smile, looking somewhat comforted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Monica**
> "“Thanks, Anton. I appreciate it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[17]`
Mówca: **Monica**
> "“I will do my best.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Are you still angry about my decision?”"]** — Mówca: **Player**
> "“Are you still angry about my decision?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "Say nothing."]** — Mówca: **Player_Italic**
> "I said nothing and waited for Serge to open the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Will you ever forgive me? I told you my reasons.""]** — Mówca: **Player**
> ""Will you ever forgive me? I told you my reasons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[21]`
Mówca: **Monica**
> "“I know, and I understand. It's just going to take me some time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Narrator**
> "She clearly did not want to pursue this topic any further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "As soon as Serge opened the door, we were enveloped by the roar of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[24]`
Mówca: **Narrator**
> "The Benfi Festival was one of the biggest events of the year. It originally marked the start of the annual religious pilgrimage, a weeks-long journey still undertaken by devout Nurists. But today it was better known as a cultural celebration that drew thousands of revelers to the city."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[25]`
Mówca: **Narrator**
> "As the car slowed, a coterie of reporters and security guards rushed to meet us. I turned my attention to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[26]`
Mówca: **Narrator**
> "We followed the guards through the cavernous white halls until we came to a set of arched doors leading to the auditorium. We waited outside as security did a quick sweep of the area, then headed in."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[29]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[333]`

### Węzeł `[30]`
Mówca: **Monica**
> "“I'm going to find my seat.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[31]`
Mówca: **Monica**
> "“So, this is it. I will finally stand on the same platform as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Monica**
> "“A platform where Sordland's women will have their voices heard and acknowledged for the first time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“Good luck.”"]** — Mówca: **Player**
> "“Good luck.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I hope this is not a mistake.”"]** — Mówca: **Player**
> "“I hope this is not a mistake.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[395]`

### Węzeł `[35]`
Mówca: **Monica**
> "“We will see.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Monica brushed past me, took her seat in the front row and crossed her arms. I walked alone to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The two of us proceeded to the podium. I spoke first, delivering a short paragraph about the importance of Benfi and the festival to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "I then introduced Monica. Thunderous applause echoed around the auditorium as she stepped to the microphone. I exited the stage and found my seat.... right next to Curtan Leste."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Narrator**
> "I concluded by inviting Curtan Leste, the Mayor of Anrica, to the podium. I stepped down and joined Monica in the front row. Her arms were still folded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[40]`
Mówca: **Narrator**
> "I spoke for just a minute, reading a paragraph my speechwriter had churned out about the importance of the festival and Benfi to Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[41]`
Mówca: **Monica**
> "“Ladies and gentlemen, as the First Lady of Sordland, I welcome all of you to the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "The crowd erupted again, clapping and cheering."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[43]`
Mówca: **Monica**
> "“This festival holds a very important place in all of our hearts. It is a celebration of art, music, theater -- but above all, it is a celebration of the people of Benfi, of their free and open-minded spirit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Monica**
> "“As we all unite for the festivities, we must not forget the values that have inspired them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Monica**
> "“Today marks the beginning of the Week of the Spirit. A time for vitality, growth, and new beginnings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[46]`
Mówca: **Monica**
> "“I stand on this podium today to speak about change. About a new beginning for our society.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Monica**
> ""To truly move forward, we must make a break from old traditions and strive towards equality for all. Equal rights, equal pay, equal access to education--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[48]`
Mówca: **Narrator**
> "The crowd was hanging on to her every word, but the mayor of Anrica and his entourage didn't seem as impressed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[49]`
Mówca: **Monica**
> "“Sordland calls itself a free country. Yet half of its citizens are still barred from enjoying the same freedoms that the other half takes for granted. I refer to myself and my fellow women.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "A rumble went through the crowd. Scattered applause mixed with murmurs of discontent."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[51]`
Mówca: **Curtan Leste**
> "“I will not let this woman besmirch the traditions upon which our great country was built.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[104]`

### Węzeł `[52]`
Mówca: **Curtan Leste**
> "“You are not a politician. You are not a speaker. You are merely a woman who's lucky enough to be married to the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Curtan Leste**
> "“Your place is not at at this podium. It is at home, tending to your husband and children.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[54]`
Mówca: **Curtan Leste**
> "“Mrs. Rayne, what right do you possibly have to pass judgement on our values as Sordish citizens?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[55]`
Mówca: **Narrator**
> "The crowd was growing rowdier. Some booed and jeered at Curtan's words, others whooped in approval."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Monica**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "Monica froze completely. The audience grew louder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[58]`
Mówca: **Curtan Leste**
> "“Welcome to the first day of the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
Mówca: **Curtan Leste**
> "“This is a night for the people of Benfi -- indeed, for the people of Sordland -- to put aside their differences and come together in celebration.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Curtan Leste**
> "“Yet as we unite for the festivities, we must remember the real reason we are gathered here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[61]`
Mówca: **Narrator**
> "He paused for a moment to let the crowd cheer, and his eyes briefly met mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`
  - -> `[81]`

### Węzeł `[62]`
Mówca: **Curtan Leste**
> "“This festival was founded around the principles of our cherished religion, Nurity. Yet over the years, it has been severed from its sacred roots and become something else. Something more perverse.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Curtan Leste**
> "“An excuse for public drunkenness and grotesque displays of the flesh. An occasion for young women to parade their bodies and engage in lascivious behavior.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[64]`
Mówca: **Narrator**
> "The crowd was becoming restless. Many of the younger attendees were murmuring in disagreement, while a few of the older ones were nodding vigorously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[65]`
Mówca: **Narrator**
> "The crowd fell silent. The people were giving their full attention to what he had to say."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[66]`
Mówca: **Curtan Leste**
> "“Perversion hidden under the guise of art is not befitting the beautiful city of --”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[67]`
Mówca: **Monica**
> "“Mr. Leste, it is not young women who are a disgrace to this fine festival, but you. You and your backwards, puritanical attitudes, which have been holding this country back for far too long--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[89]`
  - -> `[91]`

### Węzeł `[68]`
Mówca: **Monica**
> "“Women of Sordland, we must not let people like Mr. Leste use religion as a justification to demean and oppress us. Our time has come!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "Shocked gasps ran through the crowd. A few people rose and applauded. Curtan Leste waited to speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "“Monica, that's enough.”"]** — Mówca: **Player**
> "“Monica, that's enough.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I kept watching in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Monica**
> "“What do you mean, enough? I've barely even started.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Narrator**
> "I looked at the podium to see Curtan Leste's piercing gaze on me. There would surely be a price to pay for this."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Curtan Leste**
> "“Mr. President, could you please control your wife before she embarrasses herself any further?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[225]`
  - -> `[223]`
  - -> `[222]`

### Węzeł `[75]`
Mówca: **Curtan Leste**
> "“I think Mrs. Rayne is forgetting her place.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[76]`
Mówca: **Monica**
> ""What do you think my place is, Mr. Leste? The kitchen? This festival is not about your retrograde traditions. We are living in modern times now. It's 1954.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Monica**
> "“And it isn't *your* place to decide how the people of Benfi -- especially the women -- should be celebrating their own festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[78]`
Mówca: **Narrator**
> "The next few minutes were a blur of handshakes, photos and reporters' questions. The onlookers cheered as we walked the red carpet to the newly built arts center."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[79]`
**[WYBÓR GRACZA: "“Break a leg!”"]** — Mówca: **Player**
> "“Break a leg!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`

### Węzeł `[80]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "Look away."]** — Mówca: **Player_Italic**
> "I looked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[82]`
Mówca: **Narrator**
> "As he went on, I could see Monica become increasingly agitated."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Monica**
> "“What in the hell is he talking about? Lascivious behavior? What century does he think we live in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[85]`
  - -> `[86]`

### Węzeł `[84]`
**[WYBÓR GRACZA: "“Ssshh. Quiet.”"]** — Mówca: **Player**
> "“Ssshh. Quiet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA: "“I don't know. Just let it be.”"]** — Mówca: **Player**
> "“I don't know. Just let it be.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
**[WYBÓR GRACZA: "Pretend not to hear her."]** — Mówca: **Player_Italic**
> "I pretended not to hear her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Narrator**
> "Monica turned back to watching the speech, a frown on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[88]`
Mówca: **Curtan Leste**
> "“As I said, perversion hidden under the guise of art is not be--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“Ssshh. Monica. Please sit down.”"]** — Mówca: **Player**
> "“Ssshh. Monica. Please sit down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“Monica, sit down. You're making a fool of yourself.”"]** — Mówca: **Player**
> "“Monica, sit down. You're making a fool of yourself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "Watch the events unfold."]** — Mówca: **Player_Italic**
> "I stayed in my seat and watched the events unfold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[92]`
Mówca: **Monica**
> "“No, I will not sit down this time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Curtan Leste leaned over and hissed into my ear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[94]`
Mówca: **Curtan Leste**
> "“Mr. President, I am afraid you have made a great mistake. There will be consequences.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`
  - -> `[96]`
  - -> `[97]`

### Węzeł `[95]`
**[WYBÓR GRACZA: "“Are you threatening me, Curtan?”"]** — Mówca: **Player**
> "“Are you threatening me, Curtan?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“What kind of consequences?”"]** — Mówca: **Player**
> "“What kind of consequences?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "Ignore him."]** — Mówca: **Player_Italic**
> "I did not pay any attention to Curtan and simply pretended to not hear him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[98]`
Mówca: **Curtan Leste**
> "“No, I am merely telling what will happen. Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Curtan Leste**
> ""Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I kept my eyes on the stage. When the applause subsided, Monica resumed her speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[101]`
Mówca: **Curtan Leste**
> ""Your little stunt has lost you my support in the Assembly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Mr. Leste. Please sit down.”"]** — Mówca: **Player**
> "“Mr. Leste. Please sit down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Curtan, get back in your goddamn seat!""]** — Mówca: **Player**
> "“Curtan, get back in your goddamn seat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "Watch the events unfold."]** — Mówca: **Player_Italic**
> "I sat down and watched the events unfold."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[105]`
Mówca: **Curtan Leste**
> "“No, Anton. I can no longer sit idly by. We are past that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[106]`
Mówca: **Narrator**
> "The entire hall fell silent. The mayor of Anrica rose and spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Curtan turned towards the audience, speaking loudly enough to be heard without a microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Monica turned to face the audience, speaking loud enough to be heard without a microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[109]`
Mówca: **Narrator**
> "On the front page, there was the face of Curtan Leste, mayor of Anrica. He was a Benfi native who had a longstanding relationship with the city's current mayor, and had been personally invited to make tonight's opening speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[110]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[113]`
Mówca: **Narrator**
> "Monica's face was featured on the front page. But the schedule on the inside still said that Curtan Leste, mayor of Anrica, would be making the opening remarks. My last-minute announcement that my wife would be replacing Curtan must have caused some confusion at the print shop."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[114]`
Mówca: **Narrator**
> "The mayor was still standing defiantly in the front row."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[118]`
  - -> `[119]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“Enough, Mr. Leste! Let her speak!""]** — Mówca: **Player**
> "“Enough, Mr. Leste! Let her speak!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Mr. Leste. Please calm down, take your seat, and let her finish. Now.”"]** — Mówca: **Player**
> "“Mr. Leste. Please calm down, take your seat, and let her finish. Now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[117]`
Mówca: **Narrator**
> "The room immediately quieted down again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[120]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Mr. Leste. Do I have to teach you basic manners? Have you forgotten what you learned in kindergarten?""]** — Mówca: **Player**
> "“Mr. Leste. Do I have to teach you basic manners? Have you forgotten what you learned in kindergarten?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`

### Węzeł `[119]`
**[WYBÓR GRACZA: "“Thank you for the speech, Monica. You've done... enough.""]** — Mówca: **Player**
> "“Thank you for the speech, Monica. You've done... enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Monica, please continue your speech.”"]** — Mówca: **Player**
> "“Monica, please continue your speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Curtan, if you don't sit down now and let her speak, I swear I will...”"]** — Mówca: **Player**
> "“Curtan, if you don't sit down, I swear I will...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Curtan Leste**
> "“You swear you will...what, Mr. President?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`
  - -> `[125]`

### Węzeł `[123]`
**[WYBÓR GRACZA: "“...make you pay.”"]** — Mówca: **Player**
> "“...make you pay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“...have you removed.”"]** — Mówca: **Player**
> "“...have you removed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "Stare into his eyes menacingly."]** — Mówca: **Player_Italic**
> "I stared into his eyes menacingly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Curtan Leste**
> "“Is this what you do to people who protect Sordish values? To those with different opinions? Have them removed?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[130]`
  - -> `[152]`

### Węzeł `[127]`
Mówca: **Narrator**
> "He did not even flinch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[128]`
Mówca: **Curtan Leste**
> "“Is that a threat?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[134]`
  - -> `[135]`

### Węzeł `[129]`
Mówca: **Curtan Leste**
> "“How dare you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Order the guards to escort him out."]** — Mówca: **Player_Italic**
> "I ordered the guards to escort Curtan and his entourage out of the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[131]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force = true;
BaseGame.Turn05_Personal_Festival_LesteKicked = true; BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] = true;
Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] = true;
Variable["BaseGameSupport.Journal_Turn05_Scandal_CurtanKicked"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "My security guards immediately surrounded Curtan and his entourage."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“It's what I do to upstarts who fail to show restraint.""]** — Mówca: **Player**
> "“It's what I do to upstarts who fail to show restraint.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Yes, it is.”"]** — Mówca: **Player**
> "“Yes, it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
**[WYBÓR GRACZA: "Do not reply."]** — Mówca: **Player_Italic**
> "I did not reply to his question."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“No. It is a request.”"]** — Mówca: **Player**
> "“No. It is a request.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Curtan Leste**
> "“Then you have just made an enemy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[138]`
Mówca: **Curtan Leste**
> "“Then I respectfully decline. I will not stand idly by as our Sordish values are being tested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Curtan Leste**
> "“Especially by our very own president and his harlot of a wife.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[167]`

### Węzeł `[140]`
Mówca: **Narrator**
> "Curtan grabbed his coat and made his way to the exit. The men who had been sitting with him got up and followed him out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[141]`
Mówca: **Curtan Leste**
> "“I will not stand idly by as our Sordish values are being tested.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Curtan Leste**
> "“Especially by our very own president and his harlot of a wife!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`
  - -> `[178]`

### Węzeł `[143]`
Mówca: **Curtan Leste**
> "“Do you realize what you are doing right now?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[144]`
Mówca: **Curtan Leste**
> "“You are threatening a member of the Assembly. A member of your own party.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[145]`
Mówca: **Curtan Leste**
> "“What a damn shame.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Curtan Leste**
> "“Congratulations, Mr. President. You have just made a new enemy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[147]`
Mówca: **Curtan Leste**
> "“To a mayor of Sordland. To a member of your own party...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[148]`
Mówca: **Curtan Leste**
> "“You'll pay for this, Anton! I swear on my name.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Narrator**
> "As he was being dragged out of the venue, his voice echoed in the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[150]`
Mówca: **Curtan Leste**
> "“Do you hear me?! You will pay! I--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "The door closed behind them. The crowd began to whisper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""Is rudeness a Sordish value now? Is impropriety?""]** — Mówca: **Player**
> ""Is rudeness a Sordish value now? Is impropriety?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[153]`
Mówca: **Narrator**
> "The crowd was booing Curtan loudly now. He looked around the room and let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Curtan Leste**
> "“My apologies, Mr. President. Mrs. First Lady. I crossed a line.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Monica had regained her composure by now. She took her place at the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Monica**
> "“My heartfelt apologies to you as well, Mr. Leste. I assure you, my intention was not to offend anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[157]`
Mówca: **Narrator**
> "Curtan smiled faintly. Monica turned to the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Monica**
> "“I hope one day we shall all be able to set aside our differences as we have done today...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Monica**
> "“And walk towards a happier, brighter future for all of Sordland's citizens, male and female alike. We must all remember: the future cannot exist without the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Monica**
> "“And I believe we're witnessing the meeting of our glorious past and our bright future right here in Benfi today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[161]`
Mówca: **Monica**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Narrator**
> "“Vectern sis da!“. Everyone in the hall, including Curtan, finished the decades-old saying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[163]`
Mówca: **Narrator**
> "The crowd erupted in cheers. Even Curtan started clapping."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[164]`
Mówca: **Narrator**
> "People started chanting Monica's name, and the band broke into the official festival anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[165]`
**[WYBÓR GRACZA: "“Curtan, let's talk about this.”"]** — Mówca: **Player**
> "“Curtan, let's talk about this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Curtan Leste**
> "“It's too late, Mr. President. Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[167]`
**[WYBÓR GRACZA: "“Is rudeness a Sordish value now? Is impropriety?”"]** — Mówca: **Player**
> "“Is rudeness a Sordish value now? Is impropriety?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[168]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Monica Speech Reconciliation)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[169]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Monica Speech Curtan Leaves)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[170]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[171]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[172]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""Is rudeness a Sordish value now? Is impropriety?""]** — Mówca: **Player**
> ""Is rudeness a Sordish value now? Is impropriety?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[174]`
**[WYBÓR GRACZA: "“That's the last straw, Curtan -- get out of my sights immediately!""]** — Mówca: **Player**
> "“That's the last straw, Curtan -- get out of my sights immediately!"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[175]`
Mówca: **Curtan Leste**
> ""Mr. President, this is a free country. I refuse to leave.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[176]`
Mówca: **Monica**
> "“Especially a senior member of the Assembly such as yourself, who has pledged his life to the betterment of our country.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[177]`
Mówca: **Monica**
> "“Ladies and gentlemen, I am proud to officially open the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[178]`
**[WYBÓR GRACZA: "“Please do not make me repeat myself.”"]** — Mówca: **Player**
> "“Please do not make me repeat myself.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[179]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[180]`
Mówca: **Narrator**
> "The crowd erupted in laughter. Curtan's face turned red."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[181]`
Mówca: **Narrator**
> "Monica gaped at me, looking as if she'd been slapped in the face. I leaned over to the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`
  - -> `[350]`

### Węzeł `[182]`
Mówca: **Narrator**
> "I started walking back to my seat. Monica brushed past me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[186]`
  - -> `[185]`
  - -> `[187]`

### Węzeł `[183]`
Mówca: **Narrator**
> "I had to do something. I walked up to the stage and stood beside my wife at the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[184]`
**[WYBÓR GRACZA: "“Wait. Don't go. I'm sorry.”"]** — Mówca: **Player**
> "“Wait. Don't go. I'm sorry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[185]`
**[WYBÓR GRACZA: "Grab her arm to stop her."]** — Mówca: **Player_Italic**
> "I grabbed her arm and she stopped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
**[WYBÓR GRACZA: "“You knew this was going to happen.”"]** — Mówca: **Player**
> "“You knew this was going to happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[187]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing to stop her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[188]`
Mówca: **Monica**
> "“I-- I have to go to the washroom.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "She stormed down the aisle and out the auditorium door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Narrator**
> "She looked back at me, her face streaked with tears."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[191]`
Mówca: **Narrator**
> "I wanted to follow her out. But out of presidential courtesy, I stayed in my seat until the opening ceremony concluded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Narrator**
> "I was about to leave when I felt a hand on my right shoulder. It was Curtan with a smile on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[193]`
Mówca: **Curtan Leste**
> "“Thank you for having my back, sir. Rest assured that I will have yours as well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[195]`
  - -> `[197]`
  - -> `[198]`

### Węzeł `[194]`
**[WYBÓR GRACZA: "“Not now, Curtan.”"]** — Mówca: **Player**
> "“Not now, Curtan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[195]`
**[WYBÓR GRACZA: "“Much appreciated.""]** — Mówca: **Player**
> ""Much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
Mówca: **Curtan Leste**
> "“Sometimes sacrifices need to be made for the greater good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[197]`
**[WYBÓR GRACZA: "“The greater good doesn't seem that great right now.”"]** — Mówca: **Player**
> "“The greater good doesn't seem that great right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Don't make me regret this.”"]** — Mówca: **Player**
> "“Don't make me regret this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[199]`
Mówca: **Curtan Leste**
> "“Yes, I understand.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[200]`
Mówca: **Curtan Leste**
> "“I am glad we are on the same page.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[201]`
Mówca: **Curtan Leste**
> "“It never does. Regardless, this was necessary.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[202]`
Mówca: **Curtan Leste**
> "“I will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[203]`
Mówca: **Narrator**
> "We walked out of the auditorium together."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[204]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[205]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[206]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[207]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[208]`
Mówca: **Narrator**
> "Having regained her composure, Monica stepped back behind the microphone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Monica**
> "“Ladies and gentlemen, this incident only serves to demonstrate how visibly divided our country is today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Monica**
> "“My intention was not to offend or harm anyone. It is unfortunate that even the mention of modern ideals still does not resonate with many in Sordland.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[211]`
Mówca: **Monica**
> "“I hope we can set aside our differences one day...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[377]`

### Węzeł `[212]`
Mówca: **Monica**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[213]`
Mówca: **Narrator**
> "“Vectern sis da!“ Most of the audience finished the decades-old saying, but nervous whispers still emanated from around the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[214]`
Mówca: **Narrator**
> "As Serge drove me back to the hotel, I hoped that the consequences of my actions today would not be too harsh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[215]`
Mówca: **Narrator**
> "I hoped that I could reconcile with Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Narrator**
> "But I knew she might never forgive me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[217]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_Personal_BenfiFestival = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_Personal_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[320]`

### Węzeł `[218]`
Mówca: **Narrator**
> "The opening event was finally finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "But I knew Curtan would never forget what happened today."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[220]`
Mówca: **Narrator**
> "The opening event was finally finished."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[221]`
Mówca: **Narrator**
> "But my troubles with Curtan were not."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[222]`
**[WYBÓR GRACZA: "“You know what, Curtan? My wife is absolutely right.”"]** — Mówca: **Player**
> "“You know what, Curtan? My wife is absolutely right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[223]`
**[WYBÓR GRACZA: "“I'm so sorry about this, Mr. Leste. Please finish your speech.”"]** — Mówca: **Player**
> "“I'm so sorry about this, Mr. Leste. Please finish your speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“Monica, get back in your goddamn seat!""]** — Mówca: **Player**
> "“Monica, get back in your goddamn seat!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[225]`
**[WYBÓR GRACZA: "“Monica, we've been over this. Now is not the time. Sit down, please.”"]** — Mówca: **Player**
> "“Monica, we've been over this. Now is not the time. Sit down, please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[226]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[228]`
Mówca: **Monica**
> "“I--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[229]`
Mówca: **Narrator**
> "Monica looked at me, surprise registering on her face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[230]`
Mówca: **Monica**
> "“Thank you, Anton.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "“But we will take up her concerns at a later time. Please finish your speech.”"]** — Mówca: **Player**
> "“But we will take up her concerns at a later time. Please finish your speech.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[232]`
**[WYBÓR GRACZA: "“Your task was to give an opening speech, not a moral lecture.”"]** — Mówca: **Player**
> "“Your task was to give an opening speech, not a moral lecture.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[233]`
Mówca: **Narrator**
> "I turned to Curtan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`
  - -> `[234]`
  - -> `[232]`

### Węzeł `[234]`
**[WYBÓR GRACZA: "“Now, please, get your speech over with already.”"]** — Mówca: **Player**
> "“Now, please, get your speech over with already.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Curtan Leste**
> "“I will, Mr. President. If you'll allow it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Narrator**
> "He looked at me threateningly before continuing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[237]`
Mówca: **Curtan Leste**
> "“Thank you, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[238]`
Mówca: **Curtan Leste**
> "“I will finish my speech if you'll allow it, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`
  - -> `[240]`

### Węzeł `[239]`
**[WYBÓR GRACZA: "“Go on.”"]** — Mówca: **Player**
> "“Go on.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[240]`
**[WYBÓR GRACZA: "“That's up to the people of Benfi, isn't it?""]** — Mówca: **Player**
> "“That's up to the people of Benfi, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Narrator**
> "I turned around to look at the crowd. The people immediately started booing Curtan."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[242]`
Mówca: **Curtan Leste**
> "“How very generous of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[243]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Curtan Speech)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[245]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[246]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[247]`
Mówca: **Narrator**
> "He ignored them and continued with his speech."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[248]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[249]`
Mówca: **Curtan Leste**
> "“Benfi has always been a beacon of culture, tradition and religion. Many battles have been fought over this precious city.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[250]`
Mówca: **Narrator**
> "The crowd was in uproar. I had to lean over to catch Monica's next words."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[251]`
Mówca: **Monica**
> "“I'm *so* sorry, Anton. Next time, I'll stay in the kitchen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[253]`
Mówca: **Narrator**
> "She sat back down, seething. Curtan's voice filled the hall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[254]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Speech])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[255]`
Mówca: **Curtan Leste**
> "“Army after army has tried to claim it for their own, but we fought back and won each time.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[256]`
Mówca: **Curtan Leste**
> "“We stand here thanks to the strong men who were able to protect their families, their lands, their way of living.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Curtan Leste**
> "“Every day, I praise God that we have succeeded so far.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Scattered applause broke out from some of the older members of the audience."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[259]`
Mówca: **Curtan Leste**
> "“Yet the traditions that form the very fabric of our society are being tested. Even as I speak!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[260]`
Mówca: **Curtan Leste**
> "“We must stay true to our values so that Sordland can prevail. So that Benfi can prevail!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Curtan Leste**
> "“With these at the forefront, I am convinced that Sordland will continue to be the greatest nation in the world!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Curtan Leste**
> "“I invite every single one of you to celebrate our roots and our traditions at this holy Benfi Festival!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Curtan Leste**
> "“I hereby declare the festival open! Praise God! Praise Sordland! Praise Benfi!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[264]`
Mówca: **Narrator**
> "I leaned over to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`
  - -> `[336]`

### Węzeł `[265]`
**[WYBÓR GRACZA: "“He's a bit extreme, but he is right. We owe everything to God.”"]** — Mówca: **Player**
> "“He's a bit extreme, but he is right. We owe everything to God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[266]`
**[WYBÓR GRACZA: "“He sounds more like a priest than a politician.”"]** — Mówca: **Player**
> "“He sounds more like a priest than a politician.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[341]`

### Węzeł `[267]`
Mówca: **Monica**
> "“I do not like it when the two collide.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[268]`
Mówca: **Monica**
> "“He's a fanatic. Right or not, that's never any good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[269]`
Mówca: **Narrator**
> "He looked pointedly at Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[270]`
Mówca: **Narrator**
> "“Vectern sis da!“. Most of the people in the hall finished the decades-old saying, including me. Monica's lips moved, but she didn't say the words out loud."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Curtan Leste**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[272]`
Mówca: **Narrator**
> "He exited the stage as the band struck up the official festival anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[273]`
Mówca: **Narrator**
> "I spent the rest of the evening alternately watching the festivities and conversing with local politicians. By the time we got back to the hotel, I was exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[274]`
Mówca: **Narrator**
> "But thanks to the festivities still raging outside -- and the sound of Monica tossing and turning beside me -- I couldn't sleep at all."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[275]`
Mówca: **Narrator**
> "There were film screenings, concerts, theater and dance performances, art exhibitions, and celebrity-studded nightly galas. The opening ceremonies were broadcast on TV and watched by millions."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[276]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Curtan Kicked Out)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[277]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Kicked Out])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[278]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Kicked Out])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[279]`
Mówca: **Narrator**
> "The two of us glared angrily at each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`

### Węzeł `[280]`
Mówca: **Curtan Leste**
> "“Or what? You'll have me kicked out?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`
  - -> `[282]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "“That is exactly what I am doing. Guards!""]** — Mówca: **Player**
> "“That is exactly what I am doing. Guards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[282]`
**[WYBÓR GRACZA: "“You will stay and watch the speech. Without interrupting it.”"]** — Mówca: **Player**
> "“You will stay and watch the speech. Without interrupting it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[283]`
Mówca: **Curtan Leste**
> "“I will not stay where I am not wanted. Clearly that's the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[284]`
Mówca: **Narrator**
> "Curtan's response was nearly drowned out by the booing crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "Order the guards to kick him out."]** — Mówca: **Player_Italic**
> "I ordered my guards to kick Curtan out."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[286]`
**[WYBÓR GRACZA: "“Then you will stay and watch the speech. Without interrupting it.”"]** — Mówca: **Player**
> "“Then you will stay and watch the speech. Without interrupting it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[287]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Kicked Out])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[288]`
Mówca: **Narrator**
> "He tried to reply, but he was drowned out by the boos of the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
Mówca: **Curtan Leste**
> "“I will not stay where I am not wanted. Clearly that's the case.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[290]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[291]`
Mówca: **Curtan Leste**
> ""Goodye, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[292]`
Mówca: **Narrator**
> "He looked around the room and let out a deep sigh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[293]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[295]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion <= 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[296]`
Mówca: **Monica**
> ""Whatever you say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[297]`
Mówca: **Narrator**
> "She didn't reply at all. She clearly did not want to pursue this topic any further."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[298]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[299]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[300]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[301]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[302]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 4)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 4;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[303]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`
  - -> `[305]`

### Węzeł `[304]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_Force == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_Force"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[305]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_Force == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_Force"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[306]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: GameCondition.Turn05_A_DamageControl = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn05_A_DamageControl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[307]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`
  - -> `[309]`

### Węzeł `[308]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[309]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Bill_Turn05_ReligiousHarmony_Signed == true && BaseGame.Reform_EmergencyDecree_Banned_Bluds == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Bill_Turn05_ReligiousHarmony_Signed"] == true  and  Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[310]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Deyr_WPBProtestBill"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[311]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Uziren_Refugees = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Uziren_Refugees"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[312]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`

### Węzeł `[313]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Education_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[314]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Education_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Education_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[315]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[316]`
  - -> `[317]`

### Węzeł `[316]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`

### Węzeł `[317]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_Healthcare_Budget_Decrease == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_Healthcare_Budget_Decrease"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[318]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_EducationNegative = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_EducationNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[315]`

### Węzeł `[319]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Holsord_HealthcareNegative"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[320]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`
  - -> `[322]`

### Węzeł `[321]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[322]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[323]`

### Węzeł `[323]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`
  - -> `[325]`

### Węzeł `[324]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Country_Unrest > 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Country_Unrest"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[325]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Country_Unrest > 0))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Country_Unrest"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[326]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Estord_Unrest = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_Unrest"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[327]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Lachaven_NoUnrest = true;
BaseGameSupport.News_Turn05_HP_GruniReturnsNormal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Lachaven_NoUnrest"] = true;
Variable["BaseGameSupport.News_Turn05_HP_GruniReturnsNormal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[415]`

### Węzeł `[328]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteLeft = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteLeft"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[329]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[330]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[331]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[332]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[333]`
Mówca: **Narrator**
> "I had been asked to make a quick set of remarks introducing Curtan Leste. I beckoned Monica to join me on the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[334]`
Mówca: **Monica**
> "“Enough!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`

### Węzeł `[335]`
Mówca: **Narrator**
> "The hall fell silent. Monica rose and continued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[336]`
**[WYBÓR GRACZA: "“I praise God he's only allowed to speak for another two minutes.”"]** — Mówca: **Player**
> "“I praise God he's only allowed to speak for another two minutes.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[337]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[339]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[340]`
Mówca: **Narrator**
> "Monica said nothing, her gaze fixed forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[341]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[342]`
  - -> `[343]`

### Węzeł `[342]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[343]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[344]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`
  - -> `[346]`

### Węzeł `[345]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[347]`
Mówca: **Narrator**
> "Monica stifled a short laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[348]`
Mówca: **Curtan Leste**
> ""Enough!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[349]`
**[WYBÓR GRACZA: ""Mr. Leste, I believe you had a speech prepared?""]** — Mówca: **Player**
> ""Mr. Leste, I believe you had a speech prepared?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[350]`
**[WYBÓR GRACZA: ""I declare this festival officially open!""]** — Mówca: **Player**
> ""I declare this festival officially open!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[351]`

### Węzeł `[351]`
Mówca: **Narrator**
> "After some confusion, the band broke into the official festival anthem. The crowd cheered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[352]`
Mówca: **Narrator**
> "Smiling triumphantly, Curtan strode to the podium."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[353]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Leste Persuasion)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[354]`
Mówca: **Curtan Leste**
> ""I'm only doing what I feel is right to protect my country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`
  - -> `[355]`
  - -> `[357]`

### Węzeł `[355]`
**[WYBÓR GRACZA: ""You feel it's right to berate a woman? The president's wife, at that?""]** — Mówca: **Player**
> ""You feel it's right to berate a woman? The president's wife, at that?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[356]`
**[WYBÓR GRACZA: ""And I feel it's right to have you thrown out. Guards!""]** — Mówca: **Player**
> ""And I feel it's right to have you thrown out. Guards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[359]`

### Węzeł `[357]`
**[WYBÓR GRACZA: ""Sordland does not need your protection.""]** — Mówca: **Player**
> ""Sordland does not need your protection.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`

### Węzeł `[358]`
Mówca: **Curtan Leste**
> ""Her ideas are dangerous, Anton. They'll lead us down a dark path.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[360]`
  - -> `[361]`
  - -> `[362]`

### Węzeł `[359]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Kicked Out])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""Your ideas, on the other hand, will lead us back to the Dark Ages.""]** — Mówca: **Player**
> ""Your ideas, on the other hand, will lead us back to the Dark Ages.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""Maybe they will, maybe they won't. The only thing for certain is that you won't garner sympathy by making a scene.""]** — Mówca: **Player**
> ""Maybe they will, maybe they won't. The only thing for certain is that you won't garner sympathy by making a scene.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[362]`
**[WYBÓR GRACZA: ""I'll show you a dark path. Guards!""]** — Mówca: **Player**
> ""I'll show you a dark path. Guards!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[363]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Reconciliation])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[364]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Curtan Kicked Out])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[365]`
Mówca: **Curtan Leste**
> ""Without our traditions, we are lost.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[366]`
  - -> `[367]`
  - -> `[368]`

### Węzeł `[366]`
**[WYBÓR GRACZA: ""And without change, we are fossils. Now please, sit down.""]** — Mówca: **Player**
> ""And without change, we are fossils. Now please, sit down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[367]`
**[WYBÓR GRACZA: ""My administration has not lost sight of tradition. You'll have to trust me, Curtan.""]** — Mówca: **Player**
> ""My administration has not lost sight of tradition. You'll have to trust me, Curtan.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[368]`
**[WYBÓR GRACZA: ""How about you get lost yourself?""]** — Mówca: **Player**
> ""How about you get lost yourself?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[369]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Reconciliation])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[370]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Reconciliation])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[371]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Monica Speech Curtan Leaves])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[372]`
Mówca: **Narrator**
> "Curtan scowled at me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Curtan Leste**
> ""Very well. I will not stay where I am clearly not wanted.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[374]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Leste Persuasion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[375]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Leste Persuasion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[376]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: Jump to: [Leste Persuasion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[377]`
Mówca: **Monica**
> "“And walk towards a happier, brighter future for all of Sordland's citizens, male and female alike. We must all remember: the future cannot exist without the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`

### Węzeł `[378]`
Mówca: **Monica**
> "“And I believe we're witnessing the meeting of our glorious past and our bright future right here in Benfi today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[379]`

### Węzeł `[379]`
Mówca: **Monica**
> "“Ladies and gentlemen, I am proud to officially open the Benfi Festival.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[380]`
Mówca: **Narrator**
> "I let Monica and my entourage know we'd be flying straight back to Holsord. I was in for yet another sleepless night."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[381]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`
  - -> `[383]`

### Węzeł `[382]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn05_Personal_Festival_LesteKicked == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`

### Węzeł `[383]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn05_Personal_Festival_LesteKicked == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn05_Personal_Festival_LesteKicked"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[385]`

### Węzeł `[384]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Democratic -= 1;
BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] - 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[385]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[386]`
  - -> `[387]`

### Węzeł `[386]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_SupportedAtFestival == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_SupportedAtFestival == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_SupportedAtFestival"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[388]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Democratic += 1;
BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Democratic"] = Variable["BaseGame.Democratic"] + 1;
Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[389]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[390]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: // Filler to organize nodes)*
- **Efekt (`userScript`):** `-- Filler to organize nodes;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[391]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[392]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[393]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[394]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[395]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[396]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[397]`
  - -> `[398]`

### Węzeł `[397]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[399]`

### Węzeł `[398]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true || BaseGame.Turn04_SnO_LE_Balanced_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_GangViolenceReduced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[400]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`
  - -> `[402]`

### Węzeł `[401]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[402]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Decreased == true || BaseGame.Turn04_SnO_LE_Balanced_Decreased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true  or  Variable["BaseGame.Turn04_SnO_LE_Balanced_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[403]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Estord_GangViolenceIncreased"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[404]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`
  - -> `[406]`

### Węzeł `[405]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`

### Węzeł `[406]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[407]`
Mówca: **Narrator**
> "Since Gloria had convinced me to cancel her opening speech, things between us had been strained. She'd barely said a word to me all day."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[20]`

### Węzeł `[408]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`
  - -> `[410]`

### Węzeł `[409]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[410]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[411]`
**[WYBÓR GRACZA: ""I told you about what Gloria said. The change you want is coming.""]** — Mówca: **Player**
> ""I told you about what Gloria said. The change you want is coming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[412]`
Mówca: **Monica**
> ""When, Anton? In all her time in Assembly, has she proposed even one women's rights law?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[413]`
Mówca: **Monica**
> ""If you ask me, she's gotten a bit too comfortable being one of the only women in the men's club.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`

### Węzeł `[414]`
Mówca: **Monica**
> ""Let me have a word with her after all this. I'll show her who's shrill.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[415]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Valgen", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Valgen","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[416]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Borin", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Borin","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`

### Węzeł `[417]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: RemoveTokenStatus("Sordland_City_Benfi", "City_WidespreadProtests");)*
- **Efekt (`userScript`):** `RemoveTokenStatus("Sordland_City_Benfi","City_WidespreadProtests");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[418]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn05_Deyr_SuspectedCooperators"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[419]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Booing");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Booing");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[420]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: PlaySoundEffect("Murmuring");)*
- **Efekt (`userScript`):** `PlaySoundEffect("Murmuring");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[421]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[422]`
Mówca: **Curtan Leste**
*(Węzeł logiki narracyjnej: EnableNews("G_WehlenDeploysForces"))*
- **Efekt (`userScript`):** `EnableNews("G_WehlenDeploysForces");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`
