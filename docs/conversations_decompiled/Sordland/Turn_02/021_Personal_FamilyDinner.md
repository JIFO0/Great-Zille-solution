# Sordland/Turn02/Personal_FamilyDinner

- **ID konwersacji:** `21`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/021_Personal_FamilyDinner.md`
- **Liczba węzłów dialogowych:** 220
- **Liczba wyborów gracza:** 61

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[20]** Deana
- **[31]** Franc

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Prologue_Birthplace_Deyr_Poor`
- `BaseGame.Prologue_Birthplace_Holsord_Middle`
- `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- `BaseGame.Relations_Franc_MadAtDinner`
- `BaseGame.Turn01_EnT_Economy_Planned`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Relations_Franc_MadAtDinner`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGameSupport.CountryReport_Turn02_Morella_SendsCondolencesCircas`
- `BaseGameSupport.FactionReport_Turn02_CSP_WorkersRights`
- `BaseGameSupport.News_Turn02_E_Planned`
- `BaseGameSupport.News_Turn02_HP_Protests`
- `BaseGameSupport.News_Turn02_LT_PoliticalChaos`
- `BaseGameSupport.News_Turn02_R_UnrestinSordland`
- `BaseGameSupport.News_Turn02_ST_ProtestsInGruni`
- `GameCondition.Turn02_Personal_FamilyDinner`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 24

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Relations_Franc_MadAtDinner`
- `BaseGame.Relations_Franc_Opinion`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGameSupport.News_Turn02_R_UnrestinSordland`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[98]` (Deana): `Variable["GameCondition.Turn02_Personal_FamilyDinner"] = true;`
- Węzeł `[143]` (Deana): `Variable["BaseGameSupport.News_Turn02_ST_ProtestsInGruni"] = true; Variable["BaseGameSupport.News...`
- Węzeł `[144]` (Deana): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- Węzeł `[145]` (Deana): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- Węzeł `[148]` (Deana): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- Węzeł `[160]` (Deana): `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- Węzeł `[176]` (Deana): `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- Węzeł `[177]` (Deana): `Variable["BaseGame.Relations_Franc_MadAtDinner"] = true;`
- *...oraz 16 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Deana)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After a long day at the palace, I was finally home. I thanked Serge and walked through the front gates, nodding at the two guards as I went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[4]`
Mówca: **Monica**
> "“Deana, what did I tell you? No running in the house.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[5]`
Mówca: **Franc**
> "“All right, all right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[6]`
Mówca: **Deana**
> "“Papa! You're home!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`
  - -> `[9]`
  - -> `[10]`

### Węzeł `[7]`
Mówca: **Narrator**
> "Even as I turned the doorknob, I could hear Deana rushing down the stairs to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[8]`
**[WYBÓR GRACZA: ""There's my beautiful princess!”"]** — Mówca: **Player**
> ""There's my beautiful princess!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA: ""There's my bright little daughter!""]** — Mówca: **Player**
> ""There's my bright little daughter!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "Lift and hug her."]** — Mówca: **Player_Italic**
> "I lifted Deana up and hugged her while trying to put the keys in the tray next to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Narrator**
> "I lifted Deana up and hugged her while trying to put the keys in the tray next to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Narrator**
> "She was growing fast. Lifting her up was no longer as easy as it once was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“How was school?”"]** — Mówca: **Player**
> "“How was school?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Where is your mother?”"]** — Mówca: **Player**
> "“Where is your mother?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Oof! That's enough of that. You're a big girl now!”"]** — Mówca: **Player**
> "“Oof! That's enough of that. You're a big girl now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Narrator**
> "She started laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Deana**
> "“That's right! I'm a big girl now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Narrator**
> "I put her down and her expression turned serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[19]`
Mówca: **Deana**
> ""Boring. I liked my old school better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Deana**
> "“Mama's in the kitchen making dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[21]`
Mówca: **Narrator**
> "Monica appeared next to the kitchen door. She was wearing an apron and holding a spatula in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[22]`
Mówca: **Deana**
> "“Yes, Mama.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Narrator**
> "Monica approached me and kissed me on the cheek. A tantalizing smell wafted from the kitchen behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Darling, you shouldn't have. What do we have a cook for?""]** — Mówca: **Player**
> "“Darling, you shouldn't have. What do we have a cook for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“How was your day, dear?”"]** — Mówca: **Player**
> "“How was your day, dear?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Mmm, I'm hungry! When's dinner?”"]** — Mówca: **Player**
> "“Mmm, I'm hungry! When's dinner?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[27]`
Mówca: **Monica**
> "“Terrific. I finally got to do some grocery shopping, just like old times. And I'm making your favorite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[28]`
Mówca: **Monica**
> "“I felt like going grocery shopping, just like old times. And besides, she can't make your favorite like I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[29]`
Mówca: **Monica**
> "“Hello to you too, Anton. It's almost done. I'm making your favorite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Zabla was one of my hometown's specialties -- a chickpea stew topped with beef braised in tomatoes and Bergian spices, traditionally served in a clay pot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Narrator**
> "It was absolutely my favorite dish -- especially paired with Kebij, a potent unfiltered wine from my region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Mmm. It's my lucky day. What's the occasion?”"]** — Mówca: **Player**
> "“Mmm. It's my lucky day. What's the occasion?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Where's the Kebij?""]** — Mówca: **Player**
> ""Where's the Kebij?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[34]`
**[WYBÓR GRACZA: "Kiss her on the cheek."]** — Mówca: **Player_Italic**
> "I kissed Monica on the cheek."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`

### Węzeł `[35]`
Mówca: **Monica**
> "“No occasion. I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Monica**
> "“Especially after what happened at the ball.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
Mówca: **Monica**
> ""What, you and Petr didn't booze it up enough back at the palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[38]`
Mówca: **Narrator**
> "Her smile faded, and she lowered her voice so that Deana wouldn't hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[39]`
Mówca: **Monica**
> "“I am worried, Anton. For you, for the children -- and for the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Narrator**
> "Deana suddenly appeared next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Deana**
> "“Mama.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Monica**
> "“Yes, sweetheart?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Deana**
> "“I'm hungry!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Monica**
> "“We'll eat in just a minute. Will you help me set the table?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Monica**
> "“Anton, can you tell Franc to come down for dinner? He's been sulking in his room all day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Monica started taking out the plates while I headed upstairs to fetch my son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[47]`
Mówca: **Narrator**
> "Loud rock 'n' roll music echoed down the hallway from his room. I caught a faint hint of cigarette smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[48]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Knock on the door."]** — Mówca: **Player_Italic**
> "I knocked on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I tried to open the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Narrator**
> "The door was locked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`
  - -> `[56]`

### Węzeł `[51]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: "Knock on the door."]** — Mówca: **Player_Italic**
> "I knocked on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I tried to open the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Narrator**
> "The door was locked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[56]`

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Franc, turn down that racket and open the door!”"]** — Mówca: **Player**
> "“Franc, turn down that racket and open the door!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Narrator**
> "The stereo in Franc's room clicked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "Knock on the door again."]** — Mówca: **Player_Italic**
> "I knocked on the door again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "There was still no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`
  - -> `[56]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He unlocked and opened the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Franc**
> "“What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`
  - -> `[183]`
  - -> `[65]`
  - -> `[63]`

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Food is ready.”"]** — Mówca: **Player**
> "“Dinner's ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Hand over those cigarettes and join your family for dinner.”"]** — Mówca: **Player**
> ""Hand over those cigarettes and join your family for dinner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Franc**
> "“You smoke, don't you? I'm old enough to do what I want!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`
  - -> `[187]`

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I am your father and you will respond when I ask for you!”"]** — Mówca: **Player**
> "“I am your father and you will respond when I ask for you!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Franc**
> "“Sorry, Dad -- I mean, Father. It won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[67]`
Mówca: **Franc**
> "“Great. I'm starving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Narrator**
> "Franc headed downstairs to the dining room and I followed after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Narrator**
> "The table was prepared and Monica was ladling food onto the plates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Monica**
> "“Come on. Have a seat. It won't be as tasty if it's cold.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Narrator**
> "As we started eating, the room went quiet. Monica's cooking was as delicious as ever, but I had the feeling that wasn't the reason nobody spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Narrator**
> "Monica was the first to break the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[73]`
Mówca: **Narrator**
> "Franc suddenly slammed his hands on the table, rattling the plates. Monica, Deana and I stared at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Franc**
> "“So, this is how it's going to be? We're just going to sit here like nothing happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Franc**
> ""Dad, you could have been killed. Mom could have been killed. Any one of us could have died!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“And what would you have us do?”"]** — Mówca: **Player**
> "“And what would you have us do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“And yet, we are all still alive.”"]** — Mówca: **Player**
> "“And yet, we are all still alive.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[78]`
**[WYBÓR GRACZA: "“You will not raise your voice to me, young man.”"]** — Mówca: **Player**
> "“You will not raise your voice to me, young man.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Franc**
> "“I don't know. Talk about it. Maybe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Deana's lower lip started trembling. Monica put her hand on Franc's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[76]`
  - -> `[77]`
  - -> `[78]`

### Węzeł `[81]`
Mówca: **Franc**
> "“For now. But how long until this happens again?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
Mówca: **Franc**
> "“But it's the truth!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[83]`
Mówca: **Narrator**
> "Franc got up from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[84]`
Mówca: **Franc**
> ""You don't care! You don't care what happens to me or Deana or anyone else--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[85]`
Mówca: **Monica**
> "“Franc, honey, we can talk about this--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[86]`
Mówca: **Franc**
> "“No, it's too late! Ugh, I hate this family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[87]`
Mówca: **Narrator**
> "He stormed out of the dining room. Deana started crying. Monica soothed her for a bit, then plopped her in front of the living room TV and returned to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[88]`
Mówca: **Narrator**
> "I opened the door and there she was, standing in front of me with expectant eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[89]`
Mówca: **Monica**
> "“Say, did you know that they refurbished the grocery store?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Monica**
> "“I don't know if you remember the owner -- he's been there every day for the past 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Monica**
> "“Can you imagine doing the same job for so long? What if you were president for 20 years, for example?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`
  - -> `[94]`
  - -> `[141]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Honestly, would that really be so bad?""]** — Mówca: **Player**
> "“Honestly, would that really be so bad?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I don't want this country to suffer under another Soll.”"]** — Mówca: **Player**
> "“I don't want this country to suffer under another Soll.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“20 years of this? I'd be dead!""]** — Mówca: **Player**
> "“20 years of this? I'd be dead!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[95]`
Mówca: **Monica**
> "“Anyway, the grocer really is a nice person. He threw in some extra vegetables with my--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[96]`
Mówca: **Narrator**
> "Monica measured me with her eyes for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[97]`
Mówca: **Monica**
> "“Agreed. That must never happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[98]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: GameCondition.Turn02_Personal_FamilyDinner = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn02_Personal_FamilyDinner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Franc, sit down. Now!”"]** — Mówca: **Player**
> "“Franc, sit down. Now!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Fine, let's talk about it. Sit down.”"]** — Mówca: **Player**
> ""Fine, let's talk about it. Sit down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Franc. Where are you going?”"]** — Mówca: **Player**
> "“Franc. Where are you going?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[102]`
Mówca: **Franc**
> "“I'm going back to my room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`
  - -> `[104]`
  - -> `[105]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“You'd waste your mother's delicious cooking?”"]** — Mówca: **Player**
> "“You'd waste your mother's delicious cooking?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“You are going nowhere.”"]** — Mówca: **Player**
> "“You are going nowhere.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Go, then. And don't even think about coming out until you've learned to show some respect!""]** — Mówca: **Player**
> ""Go, then. And don't even think about coming out until you've learned to show some respect!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[106]`
Mówca: **Franc**
> "“I'm not hungry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`
  - -> `[109]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Alright. Sit down. Let's talk.”"]** — Mówca: **Player**
> "“Alright. Sit back down. Let's talk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Franc took his seat again, scowling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[110]`
  - -> `[111]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Whatever. Do as you like.""]** — Mówca: **Player**
> "“Whatever. Do as you like.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Don't worry. We are going to be fine.”"]** — Mówca: **Player**
> "“Don't worry. We are going to be fine.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Do you think I would let us go down so easily?”"]** — Mówca: **Player**
> "“Do you think I would let us go down so easily?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I know it was a close call, but everything is under control.”"]** — Mówca: **Player**
> "“I know it was a close call, but everything is under control.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[113]`
Mówca: **Franc**
> "“How? How is it under control?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[114]`
**[WYBÓR GRACZA: "“You don't need to know the details.”"]** — Mówca: **Player**
> "“You don't need to know the details.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "“My security assured me that they took all the necessary steps.”"]** — Mówca: **Player**
> "“My security assured me that they took all the necessary steps.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“It was one rogue shooter. We were not even the target.”"]** — Mówca: **Player**
> "“It was one rogue shooter. We were not even the target.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[117]`
Mówca: **Franc**
> "“The same security that let a person get shot in front of the palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[118]`
Mówca: **Franc**
> "“No! It's always like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[119]`
Mówca: **Franc**
> "“But what if we were?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Franc smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[121]`
Mówca: **Franc**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Franc**
> "“But it's not up to you, is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Franc**
> "“How are we possibly going to be fine?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`
  - -> `[124]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Just trust me.”"]** — Mówca: **Player**
> "“Just trust me.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Narrator**
> "Monica turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Monica**
> "“Franc. Listen to your father. If your father says we don't need to worry, then we don't need to worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Monica**
> "“You have to trust him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[129]`
Mówca: **Monica**
> "“We all have to trust each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Narrator**
> "Things calmed down a bit at the table. We finished our food in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Time would tell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[132]`
Mówca: **Narrator**
> "Had I been lying to Franc and Deana? Was the threat to my family truly over?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Narrator**
> "I sat alone at the table and drained my glass of Kebij."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[134]`
Mówca: **Narrator**
> "Franc got up first and retreated back to his room. Monica lifted Deana up and plopped her in front of the living room TV before returning to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Narrator**
> "She sat down across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“I promise if there truly is any threat to this family, you will be the first to know.”"]** — Mówca: **Player**
> "“I promise if there truly is any threat to this family, you will be the first to know.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[137]`
**[WYBÓR GRACZA: "“All you need to worry about is putting more delicious dinner on our table.”"]** — Mówca: **Player**
> "“All you need to worry about is putting more delicious dinner on our table.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[138]`
**[WYBÓR GRACZA: "“I worry too, Monica. Things might escalate.”"]** — Mówca: **Player**
> "“I worry too, Monica. Things might escalate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[139]`
Mówca: **Narrator**
> "She got up, stood behind me and massaged my shoulders for a moment before leaving me alone in the dining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[140]`
**[WYBÓR GRACZA: "Bang on the door."]** — Mówca: **Player_Italic**
> "I banged on the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Why not? We could live like kings.”"]** — Mówca: **Player**
> "“Why not? We could live like kings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]`

### Węzeł `[142]`
Mówca: **Narrator**
> "Monica measured me with her eyes for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[143]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_ST_ProtestsInGruni = true;
BaseGameSupport.News_Turn02_R_UnrestinSordland = true;
BaseGameSupport.News_Turn02_LT_PoliticalChaos = true;
BaseGameSupport.News_Turn02_HP_Protests = true;
BaseGameSupport.FactionReport_Turn02_CSP_WorkersRights = true;
BaseGameSupport.CountryReport_Turn02_Morella_SendsCondolencesCircas = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_ProtestsInGruni"] = true;
Variable["BaseGameSupport.News_Turn02_R_UnrestinSordland"] = true;
Variable["BaseGameSupport.News_Turn02_LT_PoliticalChaos"] = true;
Variable["BaseGameSupport.News_Turn02_HP_Protests"] = true;
Variable["BaseGameSupport.FactionReport_Turn02_CSP_WorkersRights"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Morella_SendsCondolencesCircas"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[144]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[145]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Franc. You know I would never let anything happen to you or Deana. Even if it costs me my life.”"]** — Mówca: **Player**
> "“Franc. You know I would never let anything happen to you or Deana. Even if it costs me my life.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Franc**
> "“I know, I know, but still...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Franc**
> "“Can you at least tell me if something's being done about this? It was real close, dad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`
  - -> `[115]`
  - -> `[116]`

### Węzeł `[150]`
Mówca: **Deana**
> ""Papa, are the bad men gone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`
  - -> `[153]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""It was only one bad man, Deana. And yes, he's gone now.""]** — Mówca: **Player**
> ""It was only one bad man, Deana. And yes, he's gone now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I will never let anyone hurt you, ever.""]** — Mówca: **Player**
> ""I will never let anyone hurt you, ever.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Yes, your papa took care of everything!""]** — Mówca: **Player**
> ""Yes, your papa took care of everything!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Deana**
> ""Okay, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> "Deana dashed down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Deana**
> ""Mama! Papa's here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[157]`
Mówca: **Monica**
> ""I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[158]`
Mówca: **Monica**
> ""Anyway, I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[159]`
Mówca: **Narrator**
> "I realized my poor choice of words too late. Monica looked down at her plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[160]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[161]`
Mówca: **Monica**
> "“He's scared, Anton. And frankly, he isn't the only one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[162]`
Mówca: **Monica**
> ""You make plenty of rash decisions now, too. Franc's not the only one who's scared, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`
  - -> `[138]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""He should feel lucky he has a father who cares about him. I never had that.""]** — Mówca: **Player**
> ""He should feel lucky he has a father who cares about him. I never had that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[164]`
**[WYBÓR GRACZA: ""He's had every opportunity I never did. Why is he still acting out?""]** — Mówca: **Player**
> ""He's had every opportunity I never did. Why is he still acting out?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[165]`
Mówca: **Monica**
> "“Anton, he is still young.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I know. But there's not much longer we can shield him from the ugliness of the world.""]** — Mówca: **Player**
> ""I know. But there's not much longer we can shield him from the ugliness of the world.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[167]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Lachaven_Rich)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[166]`
  - -> `[174]`

### Węzeł `[169]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Lachaven_Rich))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[170]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[174]`
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[174]`
  - -> `[164]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""My father would've given me hell for that kind of insubordination.""]** — Mówca: **Player**
> ""My father would've given me hell for that kind of insubordination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""That's what worries me. I made plenty of rash decisions when I was his age.""]** — Mówca: **Player**
> ""That's what worries me. I made plenty of rash decisions when I was his age.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[175]`
Mówca: **Narrator**
> "Monica frowned at me and left to join Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[176]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[177]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[178]`
Mówca: **Narrator**
> "I could have lost my son back at the palace. Maybe he was right to be mad. Was the threat to my family truly over?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[179]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_MadAtDinner == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[181]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Franc_MadAtDinner == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[182]`
Mówca: **Narrator**
> "It was absolutely my favorite dish -- especially paired with Kebij, a potent unfiltered wine from Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`
  - -> `[34]`

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Turn those records up louder next time, won't you? I don't think the neighbors heard.”"]** — Mówca: **Player**
> "“Turn those records up louder next time, won't you? I don't think the neighbors heard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Franc**
> "“Ha ha.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[185]`
**[WYBÓR GRACZA: ""As long as you live in this house, you'll do as I command!”"]** — Mówca: **Player**
> ""As long as you live in this house, you'll do as I command!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[186]`
**[WYBÓR GRACZA: ""I'm trying to quit that nasty habit. You ought to stop while you still can.”"]** — Mówca: **Player**
> ""I'm trying to quit that nasty habit. You ought to stop while you still can.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[187]`
**[WYBÓR GRACZA: ""I'm just asking you to wait until you're out of the house.”"]** — Mówca: **Player**
> ""I'm just asking you to wait until you're out of the house.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "Franc heaved a sigh, handed me the packet and headed downstairs. I followed him to the living room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[190]`
**[WYBÓR GRACZA: ""You mean --""]** — Mówca: **Player**
> ""You mean --""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Deyr_Poor == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[193]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Deyr_Poor == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Birthplace_Holsord_Middle == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[196]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Birthplace_Holsord_Middle == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[197]`
Mówca: **Monica**
> ""Yes! Zabla!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[198]`
Mówca: **Monica**
> ""Yes! Svabli!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[199]`
Mówca: **Monica**
> ""Yes! Lorscha!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Narrator**
> "Svabli was a classic Holsord delicacy -- vegetables and creamy sheep cheese sandwiched between thin layers of dough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Lorscha was a Lachaven specialty usually reserved for special occasions -- a rich seafood stew with a heady garlic and paprika kick."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[202]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[204]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[205]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn02_E_Planned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn02_E_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[206]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[207]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[208]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[209]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[210]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[211]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[212]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[213]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[214]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[215]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[216]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion += 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[217]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Franc_Opinion -= 1)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[218]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion += 2)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[219]`
Mówca: **Deana**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
