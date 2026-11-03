# Sordland/Turn11/SnO_RumburgWarWin

- **ID konwersacji:** `245`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/245_SnO_RumburgWarWin.md`
- **Liczba węzłów dialogowych:** 292
- **Liczba wyborów gracza:** 31

---

## 1. Uczestnicy Sceny

- **[3]** Patricio Alvarez
- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[17]** Wiktor Smolak
- **[18]** Maartin Van Hoorten
- **[26]** Emmerich Hegel
- **[49]** Beatrice Livingston

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Agnolia_Alliance`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Lespia_Alliance`
- `BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.RumburgIncident_DeclareWar`
- `BaseGame.Rumburg_AlliesCalledToWar`
- `BaseGame.Situation_Law_BludishReconciliation`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh`
- `BaseGame.Turn10_SnO_Phase1_Pincer`
- `BaseGame.Turn10_SnO_Phase2_TakeDome`
- `BaseGame.Valgsland_Alliance`
- `BaseGame.Wehlen_JointOperation`
- `BaseGame.Wehlen_PeaceConference`
- `BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton`
- `BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting`
- `BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Ending_ElectionSpeech`
- `BaseGame.Shown_MiddleFinger_ToQueen`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`
- `GameCondition.Turn11_SnO_RumburgWarWin`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `GameCondition.Turn11_SnO_RumburgWarWin`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[50]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_SnO_RumburgWarWin"] = true;`
- Węzeł `[51]` (Paskal Beniwoll): `Variable["BaseGame.Ending_ElectionSpeech"] = true; ;`
- Węzeł `[64]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- Węzeł `[65]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- Węzeł `[256]` (Paskal Beniwoll): `-- continue;`
- Węzeł `[282]` (Paskal Beniwoll): `PlaySoundEffect("TrainWhistle");`
- Węzeł `[283]` (Paskal Beniwoll): `End();`
- Węzeł `[284]` (Paskal Beniwoll): `Variable["BaseGame.Shown_MiddleFinger_ToQueen"] = true;`
- *...oraz 3 innych węzłów ze skryptami.*

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
  - -> `[52]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "With a final whistle, the Maroon Train came to a stop in the middle of the Forest of October."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[4]`
Mówca: **Narrator**
> "I opened the window to look outside. The air was cool and I enjoyed the smell of nature for a brief moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I straightened my jacket as she approached."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
Mówca: **Narrator**
> "With a haughty sniff, she turned around and left the wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[7]`
Mówca: **Narrator**
> "A few minutes later, another train pulled in behind ours and stopped with a whistle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[8]`
Mówca: **Narrator**
> "She looked much older and more tired than the last time I had seen her. Clearly, the war had taken its toll on her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Beatrice Livingston**
> "“Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "She put her hand forward."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Kiss her hand."]** — Mówca: **Player_Italic**
> "I kissed her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Gesture towards the wagon."]** — Mówca: **Player_Italic**
> "I gestured towards the wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“What's wrong with being out in nature?""]** — Mówca: **Player**
> "“What's wrong with being out in nature?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Beatrice Livingston**
> "“You couldn't have chosen a better location, could you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`
  - -> `[16]`
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“You are here to sign your capitulation. You will meet me wherever I please.”"]** — Mówca: **Player**
> "“You are here to sign your capitulation. You will meet me wherever I please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
Mówca: **Beatrice Livingston**
> "“Don't take me for a fool, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“Shut up. I don't want to spend any more time than I need with you.”"]** — Mówca: **Player**
> "“Shut up. I don't want to spend any more time than I need with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Beatrice Livingston**
> "“Hah. Such vulgarity. Barbarians, all of you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Beatrice Livingston**
> "“As if your victory was not enough, you felt compelled to drag me out to the middle of a forest to cement it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Beatrice Livingston**
> "“And not just any forest, of course.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Beatrice Livingston**
> "“This is the same place where the ceasefire was signed for the 15-Day War.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Beatrice Livingston**
> "“You really are trying to humiliate me, aren't you?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[29]`
  - -> `[30]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Of course not. This is a simple coincidence. That's all.”"]** — Mówca: **Player**
> "“Of course not. This is a simple coincidence. That's all.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
Mówca: **Beatrice Livingston**
> "“Give me the bloody papers. I can't stand breathing the same air as you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[32]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Ms. Livingston, you are forgetting the protocol. I expect you to say please first.”"]** — Mówca: **Player**
> "“Ms. Livingston, you are forgetting the protocol. I expect you to say please first.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“You are not being a good loser, Ms. Livingston.”"]** — Mówca: **Player**
> "“You are not being a good loser, Ms. Livingston.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[28]`
Mówca: **Beatrice Livingston**
> "“You're not only a barbarian, you're a liar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[29]`
**[WYBÓR GRACZA: "“Yes, I am. So what? What can you do without your country, Queen of Rumburg?”"]** — Mówca: **Player**
> "“Yes, I am. So what? What can you do without your country, Queen of Rumburg?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Let's just get to the signing.""]** — Mówca: **Player**
> "“Let's just get to the signing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[31]`
Mówca: **Narrator**
> "She struggled to come up with a response, then gave up and sighed heavily."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "Hand her the papers."]** — Mówca: **Player_Italic**
> "I handed her the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[33]`
Mówca: **Beatrice Livingston**
> "“Oh, come on. Such childish behavior.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[32]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "“I said, say please.”"]** — Mówca: **Player**
> "“I said, say please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[35]`
Mówca: **Beatrice Livingston**
> "“Please... hand me the papers, Mr. Rayne.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
Mówca: **Narrator**
> "Beatrice angrily scribbled her signature and put down the pen before passing on the document. I signed the agreement and gave it to my assistant."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[37]`
Mówca: **Narrator**
> "The witnesses were called for the signing of the agreement titled the 'Treaty of Rayne'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[38]`
Mówca: **Beatrice Livingston**
> "“There you go. Are you quite satisfied?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[27]`
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: "“Yes, I am happy.”"]** — Mówca: **Player**
> "“Yes, I am happy.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[40]`
Mówca: **Beatrice Livingston**
> "“I'm sure you would act the same way if you were in my place.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[41]`
Mówca: **Beatrice Livingston**
> "“I hereby proclaim that you can go fuck yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[42]`
**[WYBÓR GRACZA: "“I don't want to see your face again.”"]** — Mówca: **Player**
> "“I don't want to see your face again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Beatrice Livingston**
> "“Rest assured, you will not.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "“Before you go, there is one more thing.”"]** — Mówca: **Player**
> "“Before you go, there is one more thing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Beatrice Livingston**
> "“What is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[125]`
  - -> `[266]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "“Don't ever forget who your Suzerain is.”"]** — Mówca: **Player**
> "“Don't ever forget who your Suzerain is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Beatrice Livingston**
> "“I won't forget.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[48]`
Mówca: **Narrator**
> "She paused for a second and glared at me in pure fury."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[49]`
Mówca: **Beatrice Livingston**
> "“Oh, trust me...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[50]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_RumburgWarWin = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_SnO_RumburgWarWin"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`

### Węzeł `[51]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Ending_ElectionSpeech = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Ending_ElectionSpeech"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[52]`
Mówca: **Narrator**
> "My cabin rocked gently as the Maroon Train sped through the leafy outskirts of Estord."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "An assistant knocked sharply, then slid the door open. He approached my desk and handed me the day's newspaper and a letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
Mówca: **Narrator**
> "The first thing I saw was the headline: 'Conqueror Rayne' written in giant letters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Information Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[61]`
  - -> `[102]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "Read the newspaper."]** — Mówca: **Player_Italic**
> "I took a look at the newspaper."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
**[WYBÓR GRACZA: "Open the letter."]** — Mówca: **Player_Italic**
> "I opened the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Newspaper == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[61]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Letter == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Information Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I continued reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[68]`
Mówca: **Narrator**
> ""...After the triumphant victory of our soldiers, President Rayne welcomed them back home in Holsord. The entire country has broken out in celebration of Rumburg's defeat...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[69]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Pincer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Pincer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_Pincer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[75]`
Mówca: **Narrator**
> ""...Defense minister Iosef Lancea was the man of the hour as his radical pincer attack plan caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Rumburg's capital...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[76]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical plan, in his own words, 'Maradunen Schlium', caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Rumburg's capital...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[77]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy. Our troops were victorious in their assault and tipped the scales in our favor. Soon after, they were on their way to Rumburg's capital...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[78]`
Mówca: **Narrator**
> ""Experts are still analyzing the particulars of the victory, but there is one fact they agree on: The siege of Thornbourgh was the turning point that drove Rumburg into where they are now. A full and unconditional surrender...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Narrator**
> ""...President Rayne is currently on his way to sign the capitulation agreement. The historic moment will be taking place in the exact same location as the signing of the 15-Day War's ceasefire. The Forest of October...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "I put down the paper to take a sip from my coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[81]`
Mówca: **Narrator**
> "I recognized Franc's handwriting immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[82]`
Mówca: **Narrator**
> ""Dear Father. I hope this letter finds you well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Narrator**
> "'I wanted to congratulate you on our victory against Rumburg. We showed them who they were messing with.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Narrator**
> ""Is that how you old folks say it? I know I could have called, but a letter felt more appropriate for the occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[96]`
Mówca: **Narrator**
> ""Everyone's talking about the war here at school. I know I complain about how hard it is being your son sometimes, but I have to say it feels pretty nice right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> ""That said... I can't help but think about all the guys who died. That could've been me over there. Considering how badly I flunked my exams, it probably should've been me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Narrator**
> ""But there's nothing I can do to change any of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Narrator**
> "'All I can ask is this: When you see the Queen, give her a big fat middle finger from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "'Best Regards, Franc Rayne.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[101]`
Mówca: **Narrator**
> "'P.S.: Mom is fine and Deana might have a boyfriend.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[105]`
Mówca: **Narrator**
> "Smiling, I shoved the papers to the side of my desk. I heard another knock on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "The assistant let me know that we had almost arrived at our destination."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[107]`
Mówca: **Narrator**
> "I stepped out of my cabin and exited the wagon to greet my esteemed guests."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`
  - -> `[110]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Agnolia_Alliance"] == true  or 
Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Lespia_Alliance == true || 
BaseGame.Agnolia_Alliance == true ||
BaseGame.Valgsland_Alliance == true || BaseGame.Wehlen_JointOperation == true) && BaseGame.Rumburg_AlliesCalledToWar == true))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Lespia_Alliance"] == true  or  
Variable["BaseGame.Agnolia_Alliance"] == true  or 
Variable["BaseGame.Valgsland_Alliance"] == true  or  Variable["BaseGame.Wehlen_JointOperation"] == true)  and  Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Narrator**
> "I stepped out of my cabin and exited the wagon to await the Queen of Rumburg."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[112]`
Mówca: **Narrator**
> "Queen Beatrice stepped out of the front-most wagon."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[113]`
Mówca: **Narrator**
> "We shook hands and waited in silence for the Queen's arrival."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[114]`
Mówca: **Narrator**
> "We entered the train cabin where the signing would take place. It was dominated by a polished mahogany writing desk. I took my seat on one side of it; the Queen took hers on the other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[115]`
Mówca: **Narrator**
> ""I can't help but think about all my friends and squadmates on the front lines. I know I'm lucky to be deployed here in Holsord, but part of me wishes I could've fought with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[116]`
Mówca: **Narrator**
> ""Still... I wonder if you and the other bigwigs back in Holsord know the real cost of this war. It's not just that I could've died. It's that some of the things I did make me wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> ""It's hard for me and the other guys to sleep at night. I can only hope the memories will go away with time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_FrancPulledToHolsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[121]`
Mówca: **Narrator**
> ""Everyone at Camp Strongarm is talking about the war, obviously. And they're talking about me. Not in a good way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Please accept this pen as a reminder of this historic occasion.""]** — Mówca: **Player**
> "“Please accept this pen as a reminder of this historic occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[129]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[133]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false)))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false)))*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_JointOperation"] == true  and  (Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  (Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false))`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_JointOperation == true && (BaseGame.Situation_Law_BludishReconciliation == true || (BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization == true && BaseGame.Turn04_SnO_LE_Interior_Decreased == false))))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_JointOperation"] == true  and  (Variable["BaseGame.Situation_Law_BludishReconciliation"] == true  or  (Variable["BaseGame.Reform_PresiPower_Default_BergiaSpecialZone_Centralization"] == true  and  Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == false))) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[137]`
Mówca: **Narrator**
> ""...no matter what, Wehlen came to Sordland's aid in its time of need. This is definitely the start of a new and lasting alliance in the region, Wiktor Smolak proclaimed...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[144]`
Mówca: **Patricio Alvarez**
> "“President Rayne. Let's get this over with as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[145]`
Mówca: **Narrator**
> "Patricio Alvarez stepped out of the wagon next to mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[146]`
Mówca: **Emmerich Hegel**
> "“President Rayne. Let's get this over with as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Narrator**
> "Emmerich Hegel stepped out of the wagon next to mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[148]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_PeaceConference == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`
  - -> `[153]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_PeaceConference == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_PeaceConference"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[153]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_PeaceConference == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_PeaceConference"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Maartin Van Hoorten arrived at the clearing near the tracks."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Maartin Van Hoorten**
> "“Mr. President. The time has finally come.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Wiktor Smolak walked over with his arms open. He was smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[160]`
Mówca: **Wiktor Smolak**
> "“I can't wait to see the look of defeat on her face.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[161]`
Mówca: **Wiktor Smolak**
> "“Anton! My friend! It's certainly been a long ride but finally, we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[162]`
Mówca: **Wiktor Smolak**
> "“Anton! My friend! It's certainly been a long ride but finally, we are here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[169]`
Mówca: **Narrator**
> ""...Lespia leader Patricio Alvarez raised his fist alongside President Rayne after the victory parade in a display of unity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Narrator**
> ""...Valgsland leader Emmerich Hegel raised his fist alongside President Rayne after the victory parade in a display of unity...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[174]`
Mówca: **Narrator**
> ""...PM Maartin Van Hoorten proclaimed that peace had finally arrived in Eastern Merkopa...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[175]`
Mówca: **Narrator**
> "I remembered the jubilant welcome ceremony and smiled. I flipped the page."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_AlliesCalledToWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Beatrice Livingston**
> ""Part I ... Section II ... Reparations ... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Rumburg_AlliesCalledToWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Rumburg_AlliesCalledToWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Rumburg_AlliesCalledToWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[183]`
Mówca: **Narrator**
> "The witnesses were called for the signing of the agreement titled the 'Treaty of Estord'."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[184]`
Mówca: **Beatrice Livingston**
> ""Sordland's government affirms and the Rumburg accepts the responsibility of Rumburg for causing for the losses and damages...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Beatrice Livingston**
> ""You want us to pay reparations for a war that you declared!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[188]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[189]`
Mówca: **Beatrice Livingston**
> ""Section V... Sordland's Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[190]`
Mówca: **Beatrice Livingston**
> ""This is outrageous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[191]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the cities of Tzarsbourgh, Dome, and their respective surrounding territories...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[192]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`
  - -> `[196]`
  - -> `[195]`

### Węzeł `[193]`
**[WYBÓR GRACZA: "“Ms. Livingston, it seems you are not fully comprehending the situation. I am not asking!”"]** — Mówca: **Player**
> "“Ms. Livingston, it seems you are not fully comprehending the situation. I am not asking!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[194]`
**[WYBÓR GRACZA: ""Ms. Livingston, would you rather we continue to march toward Thornbourgh so that we can sign the treaty there?""]** — Mówca: **Player**
> ""Ms. Livingston, would you rather we continue to march toward Thornbourgh so that we can sign the treaty there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[195]`
**[WYBÓR GRACZA: ""I don't think you are in any position to negotiate.""]** — Mówca: **Player**
> ""I don't think you are in any position to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
**[WYBÓR GRACZA: ""Ms. Livingston, I can replace you with someone else and have that person sign the treaty instead.""]** — Mówca: **Player**
> ""Ms. Livingston, I can replace you with someone else and have that person sign the treaty instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Beatrice Livingston**
> ""I will remember this, Rumburg will remember this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[201]`
Mówca: **Beatrice Livingston**
> ""Part I... Section II... Reparations... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Beatrice Livingston**
> ""Sordland's government and its allies affirm and Rumburg accepts the responsibility for causing for the losses and damages...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[203]`
Mówca: **Beatrice Livingston**
> ""Section V... Sordland's Front...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[204]`
Mówca: **Beatrice Livingston**
> ""You want us to pay reparations for a war that you declared!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[205]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`

### Węzeł `[206]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.RumburgIncident_DeclareWar == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.RumburgIncident_DeclareWar"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`

### Węzeł `[207]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.RumburgIncident_DeclareWar == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.RumburgIncident_DeclareWar"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[208]`
Mówca: **Beatrice Livingston**
> ""This is outrageous!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`

### Węzeł `[209]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the cities of Tzarsbourgh, Dome, and their respective surrounding territories to the Republic of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[210]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[211]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`
  - -> `[213]`

### Węzeł `[212]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Agnolia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Agnolia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[213]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Agnolia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Agnolia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[214]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the city of Tzarsbourgh and its surrounding territories to the Republic of Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[215]`
Mówca: **Beatrice Livingston**
> ""...recognizing the moral obligation to redress the wrong done by Rumburg in 1921, both to the rights of Agnolia and to the wishes of the population of Dome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Beatrice Livingston**
> ""Section VII... Dome...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[217]`
Mówca: **Beatrice Livingston**
> ""The territories shall be restored to the Republic of Agnolia... ""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Beatrice Livingston**
> ""You want our two major cities in the south? This will cripple us for years to come.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Maartin Van Hoorten**
> ""It is only natural that you return what you have taken from us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[220]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_PeaceConference == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[222]`

### Węzeł `[221]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Wehlen_PeaceConference == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Wehlen_PeaceConference"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[222]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Wehlen_PeaceConference == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Wehlen_PeaceConference"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[223]`
Mówca: **Maartin Van Hoorten**
> ""The people of Dome will finally be freed from your tyrannical rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[224]`
Mówca: **Wiktor Smolak**
> ""Oh, it's not done yet, *my Queen*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Wiktor Smolak**
> ""Have a look at Section IX. I believe it is titled 'The Wehzek People'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Beatrice Livingston**
> ""Rumburg will immediately surrender the territories surrounding Datefort to Wehlen in accordance with the wishes of the Wehzek people living in these territories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[227]`
Mówca: **Beatrice Livingston**
> ""What is this madness? What about all the Rumburgian and Bludish people living there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[228]`
Mówca: **Wiktor Smolak**
> ""That is none of your business.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`
  - -> `[231]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn05_FPnT_Wehlen_CallsAnton"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[232]`
Mówca: **Wiktor Smolak**
> ""I'm sure that my friend Anton and I can come to another agreement similar to the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[233]`
Mówca: **Wiktor Smolak**
> ""I'm sure that President Rayne and I can come to another agreement similar to the last one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[234]`
Mówca: **Beatrice Livingston**
> ""You not only intended to commit a genocide of the Bludish people, but of Rumburgians as well. I won't stand for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[235]`
Mówca: **Wiktor Smolak**
> ""That will depend on how they behave, don't you agree?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[236]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`
  - -> `[238]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Valgsland_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Valgsland_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Valgsland_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Valgsland_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[239]`
Mówca: **Emmerich Hegel**
> ""You won't be in any position to worry about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[240]`
Mówca: **Emmerich Hegel**
> ""It is due time to free the Rumburgian people from your tyrannical rule. The workers' revolution is about to begin.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[241]`
Mówca: **Beatrice Livingston**
> ""Section X... The People's Revolution.... The Queen of Rumburg will immediately abdicate and transfer her authority to the newly established National Liberation Committee that will be elected by the people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[242]`
Mówca: **Beatrice Livingston**
> ""The Republic of Valgsland, as a representative of the CSP, will work closely with Rumburg's new government to advise and oversee this transition of power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Beatrice Livingston**
> ""You want to destroy Rumburg with your poisonous ideology.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[244]`
**[WYBÓR GRACZA: ""I don't think you are in any position to negotiate.""]** — Mówca: **Player**
> ""I don't think you are in any position to negotiate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[245]`
**[WYBÓR GRACZA: "“Ms. Livingston, it seems you do not fully comprehend the situation. We are not asking!""]** — Mówca: **Player**
> "“Ms. Livingston, it seems you do not fully comprehend the situation. We are not asking!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Ms. Livingston, would you rather we continue our march towards Thornbourgh so that we can sign the treaty there?""]** — Mówca: **Player**
> ""Ms. Livingston, would you rather we continue our march towards Thornbourgh so that we can sign the treaty there?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[247]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[249]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[250]`
Mówca: **Beatrice Livingston**
> ""I will remember this. Rumburg will remember this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[251]`
**[WYBÓR GRACZA: ""Ms. Livingston, we can always replace you with someone else and have that person sign the treaty instead.""]** — Mówca: **Player**
> ""Ms. Livingston, we can always replace you with someone else and have that person sign the treaty instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Lespia_Alliance == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Lespia_Alliance"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[254]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Lespia_Alliance == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Lespia_Alliance"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[255]`
Mówca: **Patricio Alvarez**
> ""Ms. Livingston, we only want to assure peace in the region.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: // continue)*
- **Efekt (`userScript`):** `-- continue;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[247]`
  - -> `[244]`

### Węzeł `[257]`
Mówca: **Beatrice Livingston**
> ""Section X... Status of Forces Agreement... Rumburg grants, and ATO accepts, the right, upon the coming into force of this Treaty, to deploy ATO land, air and sea forces in and about Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Beatrice Livingston**
> ""During the exercise of the right ... Rumburg will not grant, without the prior consent of ATO, any bases or any rights, powers or authority whatsoever, in or relating to bases or the right of garrison or of maneuver, or transit of ground, air or naval forces to any third power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[259]`
Mówca: **Beatrice Livingston**
> ""Do you realize what this will do to us? We'll lose our freedom, our ability to defend ourselves, our economic independence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[260]`
Mówca: **Patricio Alvarez**
> ""That's not all. You missed a couple of points from Section II, Reparation. Let me summarize it for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Patricio Alvarez**
> ""According to Section II, Rumburg will remove all tariffs on Lespian products being sold in any Rumburgian territories.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[262]`
Mówca: **Patricio Alvarez**
> ""The Republic of Lespia will have priority access to Rumburg's market.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[263]`
Mówca: **Patricio Alvarez**
> ""Furthermore, all Lespian companies established in any territories of Rumburg will enjoy a 10-year tax-free period.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[264]`
Mówca: **Beatrice Livingston**
> ""Wait, what's this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[265]`
Mówca: **Beatrice Livingston**
> ""Wait, what's this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[268]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Letter == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[269]`
**[WYBÓR GRACZA: "Give her the middle finger."]** — Mówca: **Player_Italic**
> "I raised my middle finger in the Queen's face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""That's from my son.""]** — Mówca: **Player**
> ""That's from my son.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
**[WYBÓR GRACZA: ""My parting gift from Sordland.""]** — Mówca: **Player**
> ""My parting gift from Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[272]`
Mówca: **Beatrice Livingston**
> ""Well, I never...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[273]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_SnO_Soll_JoinMeeting"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[276]`
Mówca: **Narrator**
> ""Of course, the real credit goes to Colonel Tarquin Soll, who selflessly came out of retirement to aid in the war plans.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[277]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`
  - -> `[279]`

### Węzeł `[278]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[279]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn10_SnO_Deivid_JoinMeeting"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[280]`
Mówca: **Narrator**
> ""Credit as well goes to Foreign Minister Deivid Wisci, whose insight into Sordland's allies proved invaluable. He certainly deserves a long and peaceful retirement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[281]`
Mówca: **Narrator**
> "She laid out the treaty and began to read the document."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[282]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("TrainWhistle");)*
- **Efekt (`userScript`):** `PlaySoundEffect("TrainWhistle");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[283]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[284]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Shown_MiddleFinger_ToQueen = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Shown_MiddleFinger_ToQueen"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[285]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Sordland_Event_RumburgWar");)*
- **Efekt (`userScript`):** `DisableToken("Sordland_Event_RumburgWar");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: DisableToken("Sordland_Event_RumburgInvasion");)*
- **Efekt (`userScript`):** `DisableToken("Sordland_Event_RumburgInvasion");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[290]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy at Dome. Following that operation, our troops were victorious in their assaults towards their capital and tipped the scales in our favor. Soon after, they were routing the enemy in the fields around Thornbourgh...'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateCountryRelationship("Sordland_Country_Rumburg", "Hostile");)*
- **Efekt (`userScript`):** `UpdateCountryRelationship("Sordland_Country_Rumburg","Hostile");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
