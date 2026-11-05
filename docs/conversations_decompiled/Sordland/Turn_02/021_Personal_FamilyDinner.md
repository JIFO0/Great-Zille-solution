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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[8]` | **""There's my beautiful princess!”"** | `[6]` **Deana**: "“Papa! You're home!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I lifted Deana up and hugged her..." |
| `[9]` | **""There's my bright little daughter!""** | `[6]` **Deana**: "“Papa! You're home!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Narrator**: "I lifted Deana up and hugged her..." |
| `[10]` | **"Lift and hug her."** | `[6]` **Deana**: "“Papa! You're home!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[12]` **Narrator**: "She was growing fast. Lifting he..." |
| `[13]` | **"“How was school?”"** | `[12]` **Narrator**: "She was growing fast. Lifting he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Deana**: ""Boring. I liked my old school b..." |
| `[14]` | **"“Where is your mother?”"** | `[12]` **Narrator**: "She was growing fast. Lifting he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Deana**: "“Mama's in the kitchen making di..." |
| `[15]` | **"“Oof! That's enough of that. You're a big girl now!”"** | `[12]` **Narrator**: "She was growing fast. Lifting he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[16]` **Narrator**: "She started laughing." |
| `[24]` | **"“Darling, you shouldn't have. What do we have a cook for?""** | `[23]` **Narrator**: "Monica approached me and kissed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Monica**: "“I felt like going grocery shopp..." |
| `[25]` | **"“How was your day, dear?”"** | `[23]` **Narrator**: "Monica approached me and kissed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[27]` **Monica**: "“Terrific. I finally got to do s..." |
| `[26]` | **"“Mmm, I'm hungry! When's dinner?”"** | `[23]` **Narrator**: "Monica approached me and kissed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Monica**: "“Hello to you too, Anton. It's a..." |
| `[32]` | **"“Mmm. It's my lucky day. What's the occasion?”"** | `[31]` **Narrator**: "It was absolutely my favorite di..."<br>`[182]` **Narrator**: "It was absolutely my favorite di..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[35]` **Monica**: "“No occasion. I just wanted to c..." |
| `[33]` | **""Where's the Kebij?""** | `[31]` **Narrator**: "It was absolutely my favorite di..."<br>`[182]` **Narrator**: "It was absolutely my favorite di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[37]` **Monica**: ""What, you and Petr didn't booze..." |
| `[34]` | **"Kiss her on the cheek."** | `[31]` **Narrator**: "It was absolutely my favorite di..."<br>`[182]` **Narrator**: "It was absolutely my favorite di..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[157]` **Monica**: ""I just wanted to cheer everyone..." |
| `[48]` | **"Knock on the door."** | `[47]` **Narrator**: "Loud rock 'n' roll music echoed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Narrator**: "There was no response." |
| `[49]` | **"Open the door."** | `[47]` **Narrator**: "Loud rock 'n' roll music echoed ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Narrator**: "The door was locked." |
| `[52]` | **"Knock on the door."** | `[50]` **Narrator**: "The door was locked." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Narrator**: "There was no response." |
| `[54]` | **"Open the door."** | `[51]` **Narrator**: "There was no response." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Narrator**: "The door was locked." |
| `[56]` | **"“Franc, turn down that racket and open the door!”"** | `[50]` **Narrator**: "The door was locked."<br>`[51]` **Narrator**: "There was no response."<br>*(oraz 3 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[57]` **Narrator**: "The stereo in Franc's room click..." |
| `[58]` | **"Knock on the door again."** | `[51]` **Narrator**: "There was no response."<br>`[53]` **Narrator**: "There was no response."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "There was still no response." |
| `[62]` | **"“Food is ready.”"** | `[61]` **Franc**: "“What do you want?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[67]` **Franc**: "“Great. I'm starving.”" |
| `[63]` | **""Hand over those cigarettes and join your family for dinner.”"** | `[61]` **Franc**: "“What do you want?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Franc**: "“You smoke, don't you? I'm old e..." |
| `[65]` | **"“I am your father and you will respond when I ask for you!”"** | `[61]` **Franc**: "“What do you want?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Franc**: "“Sorry, Dad -- I mean, Father. I..." |
| `[76]` | **"“And what would you have us do?”"** | `[80]` **Narrator**: "Deana's lower lip started trembl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[79]` **Franc**: "“I don't know. Talk about it. Ma..." |
| `[77]` | **"“And yet, we are all still alive.”"** | `[80]` **Narrator**: "Deana's lower lip started trembl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Franc**: "“For now. But how long until thi..." |
| `[78]` | **"“You will not raise your voice to me, young man.”"** | `[80]` **Narrator**: "Deana's lower lip started trembl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Franc**: "“But it's the truth!”" |
| `[92]` | **"“Honestly, would that really be so bad?""** | `[91]` **Monica**: "“Can you imagine doing the same ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[96]` **Narrator**: "Monica measured me with her eyes..." |
| `[93]` | **"“I don't want this country to suffer under another Soll.”"** | `[91]` **Monica**: "“Can you imagine doing the same ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[97]` **Monica**: "“Agreed. That must never happen ..." |
| `[94]` | **"“20 years of this? I'd be dead!""** | `[91]` **Monica**: "“Can you imagine doing the same ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[159]` **Narrator**: "I realized my poor choice of wor..." |
| `[99]` | **"“Franc, sit down. Now!”"** | `[83]` **Narrator**: "Franc got up from his seat." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[108]` **Narrator**: "Franc took his seat again, scowl..." |
| `[100]` | **"“Fine, let's talk about it. Sit down.”"** | `[83]` **Narrator**: "Franc got up from his seat." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[108]` **Narrator**: "Franc took his seat again, scowl..." |
| `[101]` | **"“Franc. Where are you going?”"** | `[83]` **Narrator**: "Franc got up from his seat." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[102]` **Franc**: "“I'm going back to my room.”" |
| `[103]` | **"“You'd waste your mother's delicious cooking?”"** | `[102]` **Franc**: "“I'm going back to my room.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[106]` **Franc**: "“I'm not hungry.”" |
| `[104]` | **"“You are going nowhere.”"** | `[102]` **Franc**: "“I'm going back to my room.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[108]` **Narrator**: "Franc took his seat again, scowl..." |
| `[105]` | **""Go, then. And don't even think about coming out until you've learned to show some..."** | `[102]` **Franc**: "“I'm going back to my room.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[84]` **Franc**: ""You don't care! You don't care ..." |
| `[107]` | **"“Alright. Sit down. Let's talk.”"** | `[106]` **Franc**: "“I'm not hungry.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Franc took his seat again, scowl..." |
| `[109]` | **""Whatever. Do as you like.""** | `[106]` **Franc**: "“I'm not hungry.”" | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[84]` **Franc**: ""You don't care! You don't care ..." |
| `[110]` | **"“Don't worry. We are going to be fine.”"** | `[108]` **Narrator**: "Franc took his seat again, scowl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Franc**: "“How are we possibly going to be..." |
| `[111]` | **"“Do you think I would let us go down so easily?”"** | `[108]` **Narrator**: "Franc took his seat again, scowl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Narrator**: "Franc smirked." |
| `[112]` | **"“I know it was a close call, but everything is under control.”"** | `[108]` **Narrator**: "Franc took his seat again, scowl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Franc**: "“How? How is it under control?”" |
| `[114]` | **"“You don't need to know the details.”"** | `[113]` **Franc**: "“How? How is it under control?”"<br>`[149]` **Franc**: "“Can you at least tell me if som..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[118]` **Franc**: "“No! It's always like this.”" |
| `[115]` | **"“My security assured me that they took all the necessary steps.”"** | `[113]` **Franc**: "“How? How is it under control?”"<br>`[122]` **Franc**: "“But it's not up to you, is it?”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[117]` **Franc**: "“The same security that let a pe..." |
| `[116]` | **"“It was one rogue shooter. We were not even the target.”"** | `[113]` **Franc**: "“How? How is it under control?”"<br>`[122]` **Franc**: "“But it's not up to you, is it?”"<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Franc**: "“But what if we were?”" |
| `[124]` | **"“Just trust me.”"** | `[122]` **Franc**: "“But it's not up to you, is it?”"<br>`[123]` **Franc**: "“How are we possibly going to be..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Narrator**: "He sighed." |
| `[136]` | **"“I promise if there truly is any threat to this family, you will be the first to k..."** | `[161]` **Monica**: "“He's scared, Anton. And frankly..."<br>`[162]` **Monica**: ""You make plenty of rash decisio..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[139]` **Narrator**: "She got up, stood behind me and ..." |
| `[137]` | **"“All you need to worry about is putting more delicious dinner on our table.”"** | `[161]` **Monica**: "“He's scared, Anton. And frankly..."<br>`[162]` **Monica**: ""You make plenty of rash decisio..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[175]` **Narrator**: "Monica frowned at me and left to..." |
| `[138]` | **"“I worry too, Monica. Things might escalate.”"** | `[161]` **Monica**: "“He's scared, Anton. And frankly..."<br>`[162]` **Monica**: ""You make plenty of rash decisio..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[139]` **Narrator**: "She got up, stood behind me and ..." |
| `[140]` | **"Bang on the door."** | `[59]` **Narrator**: "There was still no response." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[57]` **Narrator**: "The stereo in Franc's room click..." |
| `[141]` | **"“Why not? We could live like kings.”"** | `[91]` **Monica**: "“Can you imagine doing the same ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Monica_Opinion"] = Variable[...` | `[142]` **Narrator**: "Monica measured me with her eyes..." |
| `[146]` | **"“Franc. You know I would never let anything happen to you or Deana. Even if it cos..."** | `[80]` **Narrator**: "Deana's lower lip started trembl..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[147]` **Franc**: "“I know, I know, but still...”" |
| `[151]` | **""It was only one bad man, Deana. And yes, he's gone now.""** | `[150]` **Deana**: ""Papa, are the bad men gone?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Deana**: ""Okay, Papa."" |
| `[152]` | **""I will never let anyone hurt you, ever.""** | `[150]` **Deana**: ""Papa, are the bad men gone?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Deana**: ""Okay, Papa."" |
| `[153]` | **""Yes, your papa took care of everything!""** | `[150]` **Deana**: ""Papa, are the bad men gone?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[154]` **Deana**: ""Okay, Papa."" |
| `[163]` | **""He should feel lucky he has a father who cares about him. I never had that.""** | `[165]` **Monica**: "“Anton, he is still young.”" | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]` | *Brak zmian stanu* | `[161]` **Monica**: "“He's scared, Anton. And frankly..." |
| `[164]` | **""He's had every opportunity I never did. Why is he still acting out?""** | `[165]` **Monica**: "“Anton, he is still young.”" | `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`<br>`(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false` | *Brak zmian stanu* | `[161]` **Monica**: "“He's scared, Anton. And frankly..." |
| `[166]` | **""I know. But there's not much longer we can shield him from the ugliness of the wo..."** | `[165]` **Monica**: "“Anton, he is still young.”" | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]` | *Brak zmian stanu* | `[161]` **Monica**: "“He's scared, Anton. And frankly..." |
| `[173]` | **""My father would've given me hell for that kind of insubordination.""** | `[165]` **Monica**: "“Anton, he is still young.”" | `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`<br>`(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false` | *Brak zmian stanu* | `[161]` **Monica**: "“He's scared, Anton. And frankly..." |
| `[174]` | **""That's what worries me. I made plenty of rash decisions when I was his age.""** | `[165]` **Monica**: "“Anton, he is still young.”" | `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]` | *Brak zmian stanu* | `[162]` **Monica**: ""You make plenty of rash decisio..." |
| `[183]` | **"“Turn those records up louder next time, won't you? I don't think the neighbors he..."** | `[61]` **Franc**: "“What do you want?”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[184]` **Franc**: "“Ha ha.”" |
| `[185]` | **""As long as you live in this house, you'll do as I command!”"** | `[64]` **Franc**: "“You smoke, don't you? I'm old e..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["...` | `[189]` **Narrator**: "Franc heaved a sigh, handed me t..." |
| `[186]` | **""I'm trying to quit that nasty habit. You ought to stop while you still can.”"** | `[64]` **Franc**: "“You smoke, don't you? I'm old e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "Franc heaved a sigh, handed me t..." |
| `[187]` | **""I'm just asking you to wait until you're out of the house.”"** | `[64]` **Franc**: "“You smoke, don't you? I'm old e..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[189]` **Narrator**: "Franc heaved a sigh, handed me t..." |
| `[190]` | **""You mean --""** | `[27]` **Monica**: "“Terrific. I finally got to do s..."<br>`[28]` **Monica**: "“I felt like going grocery shopp..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[197]` **Monica**: ""Yes! Zabla!""<br>`[198]` **Monica**: ""Yes! Svabli!""<br>*(oraz 1 innych odgałęzień)* |

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
  - -> `[3]` (*Narrator: "After a long day at the palace, I was finally home. I tha..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "After a long day at the palace, I was finally home. I thanked Serge and walked through the front gates, nodding at the two guards as I went by."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "Even as I turned the doorknob, I could hear Deana rushing..."*)

### Węzeł `[4]`
Mówca: **Monica**
> "“Deana, what did I tell you? No running in the house.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Deana: "“Yes, Mama.”"*)

### Węzeł `[5]`
Mówca: **Franc**
> "“All right, all right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "He unlocked and opened the door."*)

### Węzeł `[6]`
Mówca: **Deana**
> "“Papa! You're home!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Player: ""There's my beautiful princess!”"*)
  - -> `[9]` (*Player: ""There's my bright little daughter!""*)
  - -> `[10]` (*Player_Italic: "Lift and hug her."*)

### Węzeł `[7]`
Mówca: **Narrator**
> "Even as I turned the doorknob, I could hear Deana rushing down the stairs to greet me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "I opened the door and there she was, standing in front of..."*)

### Węzeł `[8]`
**[WYBÓR GRACZA: ""There's my beautiful princess!”"]** — Mówca: **Player**
> ""There's my beautiful princess!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I lifted Deana up and hugged her while trying to put the ..."*)

### Węzeł `[9]`
**[WYBÓR GRACZA: ""There's my bright little daughter!""]** — Mówca: **Player**
> ""There's my bright little daughter!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I lifted Deana up and hugged her while trying to put the ..."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "Lift and hug her."]** — Mówca: **Player_Italic**
> "I lifted Deana up and hugged her while trying to put the keys in the tray next to the entrance."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "She was growing fast. Lifting her up was no longer as eas..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I lifted Deana up and hugged her while trying to put the keys in the tray next to the entrance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "She was growing fast. Lifting her up was no longer as eas..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "She was growing fast. Lifting her up was no longer as easy as it once was."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“How was school?”"*)
  - -> `[14]` (*Player: "“Where is your mother?”"*)
  - -> `[15]` (*Player: "“Oof! That's enough of that. You're a big girl now!”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“How was school?”"]** — Mówca: **Player**
> "“How was school?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Deana: ""Boring. I liked my old school better.""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: "“Where is your mother?”"]** — Mówca: **Player**
> "“Where is your mother?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Deana: "“Mama's in the kitchen making dinner.""*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Oof! That's enough of that. You're a big girl now!”"]** — Mówca: **Player**
> "“Oof! That's enough of that. You're a big girl now!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "She started laughing."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "She started laughing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Deana: "“That's right! I'm a big girl now!”"*)

### Węzeł `[17]`
Mówca: **Deana**
> "“That's right! I'm a big girl now!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I put her down and her expression turned serious."*)

### Węzeł `[18]`
Mówca: **Narrator**
> "I put her down and her expression turned serious."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Deana: ""Papa, are the bad men gone?""*)

### Węzeł `[19]`
Mówca: **Deana**
> ""Boring. I liked my old school better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I put her down and her expression turned serious."*)

### Węzeł `[20]`
Mówca: **Deana**
> "“Mama's in the kitchen making dinner.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Narrator: "I put her down and her expression turned serious."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "Monica appeared next to the kitchen door. She was wearing an apron and holding a spatula in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Monica: "“Deana, what did I tell you? No running in the house.”"*)

### Węzeł `[22]`
Mówca: **Deana**
> "“Yes, Mama.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "Monica approached me and kissed me on the cheek. A tantal..."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "Monica approached me and kissed me on the cheek. A tantalizing smell wafted from the kitchen behind her."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Player: "“Darling, you shouldn't have. What do we have a cook for?""*)
  - -> `[25]` (*Player: "“How was your day, dear?”"*)
  - -> `[26]` (*Player: "“Mmm, I'm hungry! When's dinner?”"*)

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Darling, you shouldn't have. What do we have a cook for?""]** — Mówca: **Player**
> "“Darling, you shouldn't have. What do we have a cook for?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Monica: "“I felt like going grocery shopping, just like old times...."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“How was your day, dear?”"]** — Mówca: **Player**
> "“How was your day, dear?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Monica: "“Terrific. I finally got to do some grocery shopping, jus..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Mmm, I'm hungry! When's dinner?”"]** — Mówca: **Player**
> "“Mmm, I'm hungry! When's dinner?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[23]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Monica: "“Hello to you too, Anton. It's almost done. I'm making yo..."*)

### Węzeł `[27]`
Mówca: **Monica**
> "“Terrific. I finally got to do some grocery shopping, just like old times. And I'm making your favorite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""You mean --""*)

### Węzeł `[28]`
Mówca: **Monica**
> "“I felt like going grocery shopping, just like old times. And besides, she can't make your favorite like I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""You mean --""*)

### Węzeł `[29]`
Mówca: **Monica**
> "“Hello to you too, Anton. It's almost done. I'm making your favorite.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]` (*Player: ""You mean --""*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Zabla was one of my hometown's specialties -- a chickpea stew topped with beef braised in tomatoes and Bergian spices, traditionally served in a clay pot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "It was absolutely my favorite dish -- especially paired w..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "It was absolutely my favorite dish -- especially paired with Kebij, a potent unfiltered wine from my region."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“Mmm. It's my lucky day. What's the occasion?”"*)
  - -> `[33]` (*Player: ""Where's the Kebij?""*)
  - -> `[34]` (*Player_Italic: "Kiss her on the cheek."*)

### Węzeł `[32]`
**[WYBÓR GRACZA: "“Mmm. It's my lucky day. What's the occasion?”"]** — Mówca: **Player**
> "“Mmm. It's my lucky day. What's the occasion?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Monica: "“No occasion. I just wanted to cheer everyone up a bit.""*)

### Węzeł `[33]`
**[WYBÓR GRACZA: ""Where's the Kebij?""]** — Mówca: **Player**
> ""Where's the Kebij?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1;"*)

### Węzeł `[34]`
**[WYBÓR GRACZA: "Kiss her on the cheek."]** — Mówca: **Player_Italic**
> "I kissed Monica on the cheek."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[31]` (Narrator), `[182]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1;"*)

### Węzeł `[35]`
Mówca: **Monica**
> "“No occasion. I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Her smile faded, and she lowered her voice so that Deana ..."*)

### Węzeł `[36]`
Mówca: **Monica**
> "“Especially after what happened at the ball.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Monica: "“I am worried, Anton. For you, for the children -- and fo..."*)

### Węzeł `[37]`
Mówca: **Monica**
> ""What, you and Petr didn't booze it up enough back at the palace?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Monica: ""Anyway, I just wanted to cheer everyone up a bit.""*)

### Węzeł `[38]`
Mówca: **Narrator**
> "Her smile faded, and she lowered her voice so that Deana wouldn't hear."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Monica: "“Especially after what happened at the ball.”"*)

### Węzeł `[39]`
Mówca: **Monica**
> "“I am worried, Anton. For you, for the children -- and for the country.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Narrator: "Deana suddenly appeared next to us."*)

### Węzeł `[40]`
Mówca: **Narrator**
> "Deana suddenly appeared next to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Deana: "“Mama.”"*)

### Węzeł `[41]`
Mówca: **Deana**
> "“Mama.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Monica: "“Yes, sweetheart?”"*)

### Węzeł `[42]`
Mówca: **Monica**
> "“Yes, sweetheart?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Deana: "“I'm hungry!”"*)

### Węzeł `[43]`
Mówca: **Deana**
> "“I'm hungry!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Monica: "“We'll eat in just a minute. Will you help me set the tab..."*)

### Węzeł `[44]`
Mówca: **Monica**
> "“We'll eat in just a minute. Will you help me set the table?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Monica: "“Anton, can you tell Franc to come down for dinner? He's ..."*)

### Węzeł `[45]`
Mówca: **Monica**
> "“Anton, can you tell Franc to come down for dinner? He's been sulking in his room all day.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Monica started taking out the plates while I headed upsta..."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Monica started taking out the plates while I headed upstairs to fetch my son."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Narrator: "Loud rock 'n' roll music echoed down the hallway from his..."*)

### Węzeł `[47]`
Mówca: **Narrator**
> "Loud rock 'n' roll music echoed down the hallway from his room. I caught a faint hint of cigarette smoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Player_Italic: "Open the door."*)
  - -> `[48]` (*Player_Italic: "Knock on the door."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: "Knock on the door."]** — Mówca: **Player_Italic**
> "I knocked on the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Narrator: "There was no response."*)

### Węzeł `[49]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I tried to open the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[47]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Narrator: "The door was locked."*)

### Węzeł `[50]`
Mówca: **Narrator**
> "The door was locked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Player_Italic: "Knock on the door."*)
  - -> `[56]` (*Player: "“Franc, turn down that racket and open the door!”"*)

### Węzeł `[51]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Knock on the door again."*)
  - -> `[56]` (*Player: "“Franc, turn down that racket and open the door!”"*)
  - -> `[54]` (*Player_Italic: "Open the door."*)

### Węzeł `[52]`
**[WYBÓR GRACZA: "Knock on the door."]** — Mówca: **Player_Italic**
> "I knocked on the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Narrator: "There was no response."*)

### Węzeł `[53]`
Mówca: **Narrator**
> "There was no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Knock on the door again."*)
  - -> `[56]` (*Player: "“Franc, turn down that racket and open the door!”"*)

### Węzeł `[54]`
**[WYBÓR GRACZA: "Open the door."]** — Mówca: **Player_Italic**
> "I tried to open the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Narrator: "The door was locked."*)

### Węzeł `[55]`
Mówca: **Narrator**
> "The door was locked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Italic: "Knock on the door again."*)
  - -> `[56]` (*Player: "“Franc, turn down that racket and open the door!”"*)

### Węzeł `[56]`
**[WYBÓR GRACZA: "“Franc, turn down that racket and open the door!”"]** — Mówca: **Player**
> "“Franc, turn down that racket and open the door!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Narrator), `[51]` (Narrator), `[53]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The stereo in Franc's room clicked off."*)

### Węzeł `[57]`
Mówca: **Narrator**
> "The stereo in Franc's room clicked off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Franc: "“All right, all right.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "Knock on the door again."]** — Mówca: **Player_Italic**
> "I knocked on the door again."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Narrator), `[53]` (Narrator), `[55]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "There was still no response."*)

### Węzeł `[59]`
Mówca: **Narrator**
> "There was still no response."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Player_Italic: "Bang on the door."*)
  - -> `[56]` (*Player: "“Franc, turn down that racket and open the door!”"*)

### Węzeł `[60]`
Mówca: **Narrator**
> "He unlocked and opened the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Franc: "“What do you want?”"*)

### Węzeł `[61]`
Mówca: **Franc**
> "“What do you want?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: "“Food is ready.”"*)
  - -> `[183]` (*Player: "“Turn those records up louder next time, won't you? I don..."*)
  - -> `[65]` (*Player: "“I am your father and you will respond when I ask for you!”"*)
  - -> `[63]` (*Player: ""Hand over those cigarettes and join your family for dinn..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: "“Food is ready.”"]** — Mówca: **Player**
> "“Dinner's ready.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Franc: "“Great. I'm starving.”"*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Hand over those cigarettes and join your family for dinner.”"]** — Mówca: **Player**
> ""Hand over those cigarettes and join your family for dinner.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Franc: "“You smoke, don't you? I'm old enough to do what I want!""*)

### Węzeł `[64]`
Mówca: **Franc**
> "“You smoke, don't you? I'm old enough to do what I want!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]` (*Player: ""As long as you live in this house, you'll do as I command!”"*)
  - -> `[186]` (*Player: ""I'm trying to quit that nasty habit. You ought to stop w..."*)
  - -> `[187]` (*Player: ""I'm just asking you to wait until you're out of the house.”"*)

### Węzeł `[65]`
**[WYBÓR GRACZA: "“I am your father and you will respond when I ask for you!”"]** — Mówca: **Player**
> "“I am your father and you will respond when I ask for you!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Franc: "“Sorry, Dad -- I mean, Father. It won't happen again.”"*)

### Węzeł `[66]`
Mówca: **Franc**
> "“Sorry, Dad -- I mean, Father. It won't happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[67]`
Mówca: **Franc**
> "“Great. I'm starving.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Franc headed downstairs to the dining room and I followed..."*)

### Węzeł `[68]`
Mówca: **Narrator**
> "Franc headed downstairs to the dining room and I followed after."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The table was prepared and Monica was ladling food onto t..."*)

### Węzeł `[69]`
Mówca: **Narrator**
> "The table was prepared and Monica was ladling food onto the plates."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Monica: "“Come on. Have a seat. It won't be as tasty if it's cold.”"*)

### Węzeł `[70]`
Mówca: **Monica**
> "“Come on. Have a seat. It won't be as tasty if it's cold.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "As we started eating, the room went quiet. Monica's cooki..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "As we started eating, the room went quiet. Monica's cooking was as delicious as ever, but I had the feeling that wasn't the reason nobody spoke."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Narrator: "Monica was the first to break the silence."*)

### Węzeł `[72]`
Mówca: **Narrator**
> "Monica was the first to break the silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Monica: "“Say, did you know that they refurbished the grocery store?”"*)

### Węzeł `[73]`
Mówca: **Narrator**
> "Franc suddenly slammed his hands on the table, rattling the plates. Monica, Deana and I stared at him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Franc: "“So, this is how it's going to be? We're just going to si..."*)

### Węzeł `[74]`
Mówca: **Franc**
> "“So, this is how it's going to be? We're just going to sit here like nothing happened?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Franc: ""Dad, you could have been killed. Mom could have been kil..."*)

### Węzeł `[75]`
Mówca: **Franc**
> ""Dad, you could have been killed. Mom could have been killed. Any one of us could have died!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Narrator: "Deana's lower lip started trembling. Monica put her hand ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“And what would you have us do?”"]** — Mówca: **Player**
> "“And what would you have us do?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Franc: "“I don't know. Talk about it. Maybe.”"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“And yet, we are all still alive.”"]** — Mówca: **Player**
> "“And yet, we are all still alive.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Franc: "“For now. But how long until this happens again?”"*)

### Węzeł `[78]`
**[WYBÓR GRACZA: "“You will not raise your voice to me, young man.”"]** — Mówca: **Player**
> "“You will not raise your voice to me, young man.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Franc: "“But it's the truth!”"*)

### Węzeł `[79]`
Mówca: **Franc**
> "“I don't know. Talk about it. Maybe.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Franc got up from his seat."*)

### Węzeł `[80]`
Mówca: **Narrator**
> "Deana's lower lip started trembling. Monica put her hand on Franc's shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: "“Franc. You know I would never let anything happen to you..."*)
  - -> `[76]` (*Player: "“And what would you have us do?”"*)
  - -> `[77]` (*Player: "“And yet, we are all still alive.”"*)
  - -> `[78]` (*Player: "“You will not raise your voice to me, young man.”"*)

### Węzeł `[81]`
Mówca: **Franc**
> "“For now. But how long until this happens again?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Franc got up from his seat."*)

### Węzeł `[82]`
Mówca: **Franc**
> "“But it's the truth!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[83]`
Mówca: **Narrator**
> "Franc got up from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: "“Franc, sit down. Now!”"*)
  - -> `[100]` (*Player: "“Fine, let's talk about it. Sit down.”"*)
  - -> `[101]` (*Player: "“Franc. Where are you going?”"*)

### Węzeł `[84]`
Mówca: **Franc**
> ""You don't care! You don't care what happens to me or Deana or anyone else--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Monica: "“Franc, honey, we can talk about this--”"*)

### Węzeł `[85]`
Mówca: **Monica**
> "“Franc, honey, we can talk about this--”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Franc: "“No, it's too late! Ugh, I hate this family.""*)

### Węzeł `[86]`
Mówca: **Franc**
> "“No, it's too late! Ugh, I hate this family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner = true"*)

### Węzeł `[87]`
Mówca: **Narrator**
> "He stormed out of the dining room. Deana started crying. Monica soothed her for a bit, then plopped her in front of the living room TV and returned to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Monica: "“Anton, he is still young.”"*)

### Węzeł `[88]`
Mówca: **Narrator**
> "I opened the door and there she was, standing in front of me with expectant eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Deana: "“Papa! You're home!”"*)

### Węzeł `[89]`
Mówca: **Monica**
> "“Say, did you know that they refurbished the grocery store?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Monica: "“I don't know if you remember the owner -- he's been ther..."*)

### Węzeł `[90]`
Mówca: **Monica**
> "“I don't know if you remember the owner -- he's been there every day for the past 30 years.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Monica: "“Can you imagine doing the same job for so long? What if ..."*)

### Węzeł `[91]`
Mówca: **Monica**
> "“Can you imagine doing the same job for so long? What if you were president for 20 years, for example?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: "“Honestly, would that really be so bad?""*)
  - -> `[93]` (*Player: "“I don't want this country to suffer under another Soll.”"*)
  - -> `[94]` (*Player: "“20 years of this? I'd be dead!""*)
  - -> `[141]` (*Player: "“Why not? We could live like kings.”"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Honestly, would that really be so bad?""]** — Mówca: **Player**
> "“Honestly, would that really be so bad?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I don't want this country to suffer under another Soll.”"]** — Mówca: **Player**
> "“I don't want this country to suffer under another Soll.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Monica: "“Agreed. That must never happen again.”"*)

### Węzeł `[94]`
**[WYBÓR GRACZA: "“20 years of this? I'd be dead!""]** — Mówca: **Player**
> "“20 years of this? I'd be dead!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 1"*)

### Węzeł `[95]`
Mówca: **Monica**
> "“Anyway, the grocer really is a nice person. He threw in some extra vegetables with my--""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Narrator: "Franc suddenly slammed his hands on the table, rattling t..."*)

### Węzeł `[96]`
Mówca: **Narrator**
> "Monica measured me with her eyes for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“Anyway, the grocer really is a nice person. He threw in ..."*)

### Węzeł `[97]`
Mówca: **Monica**
> "“Agreed. That must never happen again.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“Anyway, the grocer really is a nice person. He threw in ..."*)

### Węzeł `[98]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_Personal_FamilyDinner = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_Personal_FamilyDinner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[99]`
**[WYBÓR GRACZA: "“Franc, sit down. Now!”"]** — Mówca: **Player**
> "“Franc, sit down. Now!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[100]`
**[WYBÓR GRACZA: "“Fine, let's talk about it. Sit down.”"]** — Mówca: **Player**
> ""Fine, let's talk about it. Sit down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Franc. Where are you going?”"]** — Mówca: **Player**
> "“Franc. Where are you going?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[83]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Franc: "“I'm going back to my room.”"*)

### Węzeł `[102]`
Mówca: **Franc**
> "“I'm going back to my room.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Player: "“You'd waste your mother's delicious cooking?”"*)
  - -> `[104]` (*Player: "“You are going nowhere.”"*)
  - -> `[105]` (*Player: ""Go, then. And don't even think about coming out until yo..."*)

### Węzeł `[103]`
**[WYBÓR GRACZA: "“You'd waste your mother's delicious cooking?”"]** — Mówca: **Player**
> "“You'd waste your mother's delicious cooking?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Franc: "“I'm not hungry.”"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“You are going nowhere.”"]** — Mówca: **Player**
> "“You are going nowhere.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[105]`
**[WYBÓR GRACZA: ""Go, then. And don't even think about coming out until you've learned to show some respect!""]** — Mówca: **Player**
> ""Go, then. And don't even think about coming out until you've learned to show some respect!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[102]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[106]`
Mówca: **Franc**
> "“I'm not hungry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: "“Alright. Sit down. Let's talk.”"*)
  - -> `[109]` (*Player: ""Whatever. Do as you like.""*)

### Węzeł `[107]`
**[WYBÓR GRACZA: "“Alright. Sit down. Let's talk.”"]** — Mówca: **Player**
> "“Alright. Sit back down. Let's talk.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Franc took his seat again, scowling."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Franc took his seat again, scowling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Player: "“I know it was a close call, but everything is under cont..."*)
  - -> `[110]` (*Player: "“Don't worry. We are going to be fine.”"*)
  - -> `[111]` (*Player: "“Do you think I would let us go down so easily?”"*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""Whatever. Do as you like.""]** — Mówca: **Player**
> "“Whatever. Do as you like.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[106]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[110]`
**[WYBÓR GRACZA: "“Don't worry. We are going to be fine.”"]** — Mówca: **Player**
> "“Don't worry. We are going to be fine.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Franc: "“How are we possibly going to be fine?”"*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“Do you think I would let us go down so easily?”"]** — Mówca: **Player**
> "“Do you think I would let us go down so easily?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Narrator: "Franc smirked."*)

### Węzeł `[112]`
**[WYBÓR GRACZA: "“I know it was a close call, but everything is under control.”"]** — Mówca: **Player**
> "“I know it was a close call, but everything is under control.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[108]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Franc: "“How? How is it under control?”"*)

### Węzeł `[113]`
Mówca: **Franc**
> "“How? How is it under control?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“You don't need to know the details.”"*)
  - -> `[115]` (*Player: "“My security assured me that they took all the necessary ..."*)
  - -> `[116]` (*Player: "“It was one rogue shooter. We were not even the target.”"*)

### Węzeł `[114]`
**[WYBÓR GRACZA: "“You don't need to know the details.”"]** — Mówca: **Player**
> "“You don't need to know the details.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Franc), `[149]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Franc: "“No! It's always like this.”"*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "“My security assured me that they took all the necessary steps.”"]** — Mówca: **Player**
> "“My security assured me that they took all the necessary steps.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Franc), `[122]` (Franc), `[123]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Franc: "“The same security that let a person get shot in front of..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“It was one rogue shooter. We were not even the target.”"]** — Mówca: **Player**
> "“It was one rogue shooter. We were not even the target.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[113]` (Franc), `[122]` (Franc), `[123]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Franc: "“But what if we were?”"*)

### Węzeł `[117]`
Mówca: **Franc**
> "“The same security that let a person get shot in front of the palace?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: "“Franc. Listen to your father. If your father says we don..."*)

### Węzeł `[118]`
Mówca: **Franc**
> "“No! It's always like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[119]`
Mówca: **Franc**
> "“But what if we were?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: "“Franc. Listen to your father. If your father says we don..."*)

### Węzeł `[120]`
Mówca: **Narrator**
> "Franc smirked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[121]`
Mówca: **Franc**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Franc: "“But it's not up to you, is it?”"*)

### Węzeł `[122]`
Mówca: **Franc**
> "“But it's not up to you, is it?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“My security assured me that they took all the necessary ..."*)
  - -> `[116]` (*Player: "“It was one rogue shooter. We were not even the target.”"*)
  - -> `[124]` (*Player: "“Just trust me.”"*)

### Węzeł `[123]`
Mówca: **Franc**
> "“How are we possibly going to be fine?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player: "“My security assured me that they took all the necessary ..."*)
  - -> `[116]` (*Player: "“It was one rogue shooter. We were not even the target.”"*)
  - -> `[124]` (*Player: "“Just trust me.”"*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Just trust me.”"]** — Mówca: **Player**
> "“Just trust me.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[122]` (Franc), `[123]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Narrator: "He sighed."*)

### Węzeł `[125]`
Mówca: **Narrator**
> "He sighed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: "“Franc. Listen to your father. If your father says we don..."*)

### Węzeł `[126]`
Mówca: **Narrator**
> "Monica turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Monica: "“We all have to trust each other.”"*)

### Węzeł `[127]`
Mówca: **Monica**
> "“Franc. Listen to your father. If your father says we don't need to worry, then we don't need to worry.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Monica: "“You have to trust him.”"*)

### Węzeł `[128]`
Mówca: **Monica**
> "“You have to trust him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Narrator: "Monica turned to me."*)

### Węzeł `[129]`
Mówca: **Monica**
> "“We all have to trust each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Narrator: "Things calmed down a bit at the table. We finished our fo..."*)

### Węzeł `[130]`
Mówca: **Narrator**
> "Things calmed down a bit at the table. We finished our food in silence."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Narrator: "Franc got up first and retreated back to his room. Monica..."*)

### Węzeł `[131]`
Mówca: **Narrator**
> "Time would tell."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)

### Węzeł `[132]`
Mówca: **Narrator**
> "Had I been lying to Franc and Deana? Was the threat to my family truly over?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Time would tell."*)

### Węzeł `[133]`
Mówca: **Narrator**
> "I sat alone at the table and drained my glass of Kebij."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner == true"*)

### Węzeł `[134]`
Mówca: **Narrator**
> "Franc got up first and retreated back to his room. Monica lifted Deana up and plopped her in front of the living room TV before returning to the table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "She sat down across from me."*)

### Węzeł `[135]`
Mówca: **Narrator**
> "She sat down across from me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Monica: "“Anton, he is still young.”"*)

### Węzeł `[136]`
**[WYBÓR GRACZA: "“I promise if there truly is any threat to this family, you will be the first to know.”"]** — Mówca: **Player**
> "“I promise if there truly is any threat to this family, you will be the first to know.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Monica), `[162]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 2"*)

### Węzeł `[137]`
**[WYBÓR GRACZA: "“All you need to worry about is putting more delicious dinner on our table.”"]** — Mówca: **Player**
> "“All you need to worry about is putting more delicious dinner on our table.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Monica), `[162]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[138]`
**[WYBÓR GRACZA: "“I worry too, Monica. Things might escalate.”"]** — Mówca: **Player**
> "“I worry too, Monica. Things might escalate.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[161]` (Monica), `[162]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion += 2"*)

### Węzeł `[139]`
Mówca: **Narrator**
> "She got up, stood behind me and massaged my shoulders for a moment before leaving me alone in the dining room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I sat alone at the table and drained my glass of Kebij."*)

### Węzeł `[140]`
**[WYBÓR GRACZA: "Bang on the door."]** — Mówca: **Player_Italic**
> "I banged on the door."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[59]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1;"*)

### Węzeł `[141]`
**[WYBÓR GRACZA: "“Why not? We could live like kings.”"]** — Mówca: **Player**
> "“Why not? We could live like kings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[91]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[212]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Monica_Opinion -= 1"*)

### Węzeł `[142]`
Mówca: **Narrator**
> "Monica measured me with her eyes for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“Anyway, the grocer really is a nice person. He threw in ..."*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_ST_ProtestsInGruni = true;
BaseGameSupport.News_Turn02_R_UnrestinSordland = true;
BaseGameSupport.News_Turn02_LT_PoliticalChaos = true;
BaseGameSupport.News_Turn02_HP_Protests = true;
BaseGameSupport.FactionReport_Turn02_CSP_WorkersRights = true;
BaseGameSupport.CountryReport_Turn02_Morella_SendsCondolencesCircas = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_ST_ProtestsInGruni"] = true;
Variable["BaseGameSupport.News_Turn02_R_UnrestinSordland"] = true;
Variable["BaseGameSupport.News_Turn02_LT_PoliticalChaos"] = true;
Variable["BaseGameSupport.News_Turn02_HP_Protests"] = true;
Variable["BaseGameSupport.FactionReport_Turn02_CSP_WorkersRights"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Morella_SendsCondolencesCircas"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_Personal_FamilyDinner = true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Franc headed downstairs to the dining room and I followed..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Narrator: "Franc got up from his seat."*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Franc. You know I would never let anything happen to you or Deana. Even if it costs me my life.”"]** — Mówca: **Player**
> "“Franc. You know I would never let anything happen to you or Deana. Even if it costs me my life.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[80]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Franc: "“I know, I know, but still...”"*)

### Węzeł `[147]`
Mówca: **Franc**
> "“I know, I know, but still...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Franc: "“Can you at least tell me if something's being done about..."*)

### Węzeł `[149]`
Mówca: **Franc**
> "“Can you at least tell me if something's being done about this? It was real close, dad.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Player: "“You don't need to know the details.”"*)
  - -> `[115]` (*Player: "“My security assured me that they took all the necessary ..."*)
  - -> `[116]` (*Player: "“It was one rogue shooter. We were not even the target.”"*)

### Węzeł `[150]`
Mówca: **Deana**
> ""Papa, are the bad men gone?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Player: ""It was only one bad man, Deana. And yes, he's gone now.""*)
  - -> `[152]` (*Player: ""I will never let anyone hurt you, ever.""*)
  - -> `[153]` (*Player: ""Yes, your papa took care of everything!""*)

### Węzeł `[151]`
**[WYBÓR GRACZA: ""It was only one bad man, Deana. And yes, he's gone now.""]** — Mówca: **Player**
> ""It was only one bad man, Deana. And yes, he's gone now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deana: ""Okay, Papa.""*)

### Węzeł `[152]`
**[WYBÓR GRACZA: ""I will never let anyone hurt you, ever.""]** — Mówca: **Player**
> ""I will never let anyone hurt you, ever.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deana: ""Okay, Papa.""*)

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Yes, your papa took care of everything!""]** — Mówca: **Player**
> ""Yes, your papa took care of everything!""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[150]` (Deana)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Deana: ""Okay, Papa.""*)

### Węzeł `[154]`
Mówca: **Deana**
> ""Okay, Papa.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Narrator: "Deana dashed down the hallway."*)

### Węzeł `[155]`
Mówca: **Narrator**
> "Deana dashed down the hallway."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Deana: ""Mama! Papa's here!""*)

### Węzeł `[156]`
Mówca: **Deana**
> ""Mama! Papa's here!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "Monica appeared next to the kitchen door. She was wearing..."*)

### Węzeł `[157]`
Mówca: **Monica**
> ""I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Her smile faded, and she lowered her voice so that Deana ..."*)

### Węzeł `[158]`
Mówca: **Monica**
> ""Anyway, I just wanted to cheer everyone up a bit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Narrator: "Her smile faded, and she lowered her voice so that Deana ..."*)

### Węzeł `[159]`
Mówca: **Narrator**
> "I realized my poor choice of words too late. Monica looked down at her plate."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Monica: "“Anyway, the grocer really is a nice person. He threw in ..."*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Franc: ""You don't care! You don't care what happens to me or Dea..."*)

### Węzeł `[161]`
Mówca: **Monica**
> "“He's scared, Anton. And frankly, he isn't the only one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“I promise if there truly is any threat to this family, y..."*)
  - -> `[137]` (*Player: "“All you need to worry about is putting more delicious di..."*)
  - -> `[138]` (*Player: "“I worry too, Monica. Things might escalate.”"*)

### Węzeł `[162]`
Mówca: **Monica**
> ""You make plenty of rash decisions now, too. Franc's not the only one who's scared, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Player: "“I promise if there truly is any threat to this family, y..."*)
  - -> `[137]` (*Player: "“All you need to worry about is putting more delicious di..."*)
  - -> `[138]` (*Player: "“I worry too, Monica. Things might escalate.”"*)

### Węzeł `[163]`
**[WYBÓR GRACZA: ""He should feel lucky he has a father who cares about him. I never had that.""]** — Mówca: **Player**
> ""He should feel lucky he has a father who cares about him. I never had that.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]`
- **Kontekst wejściowy (poprzednik):** `[165]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: "“He's scared, Anton. And frankly, he isn't the only one.”"*)

### Węzeł `[164]`
**[WYBÓR GRACZA: ""He's had every opportunity I never did. Why is he still acting out?""]** — Mówca: **Player**
> ""He's had every opportunity I never did. Why is he still acting out?""
- **Wymagania odblokowania (kod gry):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false` AND `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: "“He's scared, Anton. And frankly, he isn't the only one.”"*)

### Węzeł `[165]`
Mówca: **Monica**
> "“Anton, he is still young.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich"*)

### Węzeł `[166]`
**[WYBÓR GRACZA: ""I know. But there's not much longer we can shield him from the ugliness of the world.""]** — Mówca: **Player**
> ""I know. But there's not much longer we can shield him from the ugliness of the world.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]`
- **Kontekst wejściowy (poprzednik):** `[165]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: "“He's scared, Anton. And frankly, he isn't the only one.”"*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Lachaven_Rich"*)
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Lachaven_Rich)"*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Lachaven_Rich`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Player: ""He should feel lucky he has a father who cares about him..."*)
  - -> `[166]` (*Player: ""I know. But there's not much longer we can shield him fr..."*)
  - -> `[174]` (*Player: ""That's what worries me. I made plenty of rash decisions ..."*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Lachaven_Rich)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)

### Węzeł `[170]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle"*)
  - -> `[172]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle)"*)

### Węzeł `[171]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""I know. But there's not much longer we can shield him fr..."*)
  - -> `[174]` (*Player: ""That's what worries me. I made plenty of rash decisions ..."*)
  - -> `[173]` (*Player: ""My father would've given me hell for that kind of insubo..."*)

### Węzeł `[172]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Player: ""I know. But there's not much longer we can shield him fr..."*)
  - -> `[174]` (*Player: ""That's what worries me. I made plenty of rash decisions ..."*)
  - -> `[164]` (*Player: ""He's had every opportunity I never did. Why is he still ..."*)

### Węzeł `[173]`
**[WYBÓR GRACZA: ""My father would've given me hell for that kind of insubordination.""]** — Mówca: **Player**
> ""My father would've given me hell for that kind of insubordination.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"]` AND `(Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]) == false`
- **Kontekst wejściowy (poprzednik):** `[165]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Monica: "“He's scared, Anton. And frankly, he isn't the only one.”"*)

### Węzeł `[174]`
**[WYBÓR GRACZA: ""That's what worries me. I made plenty of rash decisions when I was his age.""]** — Mówca: **Player**
> ""That's what worries me. I made plenty of rash decisions when I was his age.""
- **Wymagania odblokowania (kod gry):** `Variable["BaseGame.Prologue_Birthplace_Lachaven_Rich"]`
- **Kontekst wejściowy (poprzednik):** `[165]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Monica: ""You make plenty of rash decisions now, too. Franc's not ..."*)

### Węzeł `[175]`
Mówca: **Narrator**
> "Monica frowned at me and left to join Deana."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Narrator: "I sat alone at the table and drained my glass of Kebij."*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Narrator: "Monica frowned at me and left to join Deana."*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Narrator: "He stormed out of the dining room. Deana started crying. ..."*)

### Węzeł `[178]`
Mówca: **Narrator**
> "I could have lost my son back at the palace. Maybe he was right to be mad. Was the threat to my family truly over?"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Narrator: "Time would tell."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_MadAtDinner == true"*)
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Relations_Franc_MadAtDinner == true)"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_MadAtDinner == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Relations_Franc_MadAtDinner"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Narrator: "I could have lost my son back at the palace. Maybe he was..."*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Relations_Franc_MadAtDinner == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Relations_Franc_MadAtDinner"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Narrator: "Had I been lying to Franc and Deana? Was the threat to my..."*)

### Węzeł `[182]`
Mówca: **Narrator**
> "It was absolutely my favorite dish -- especially paired with Kebij, a potent unfiltered wine from Bergia."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Player: "“Mmm. It's my lucky day. What's the occasion?”"*)
  - -> `[33]` (*Player: ""Where's the Kebij?""*)
  - -> `[34]` (*Player_Italic: "Kiss her on the cheek."*)

### Węzeł `[183]`
**[WYBÓR GRACZA: "“Turn those records up louder next time, won't you? I don't think the neighbors heard.”"]** — Mówca: **Player**
> "“Turn those records up louder next time, won't you? I don't think the neighbors heard.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[61]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]` (*Franc: "“Ha ha.”"*)

### Węzeł `[184]`
Mówca: **Franc**
> "“Ha ha.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion += 1;"*)

### Węzeł `[185]`
**[WYBÓR GRACZA: ""As long as you live in this house, you'll do as I command!”"]** — Mówca: **Player**
> ""As long as you live in this house, you'll do as I command!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]` (*Węzeł Logiki Narracyjnej: "BaseGame.Relations_Franc_Opinion -= 1"*)

### Węzeł `[186]`
**[WYBÓR GRACZA: ""I'm trying to quit that nasty habit. You ought to stop while you still can.”"]** — Mówca: **Player**
> ""I'm trying to quit that nasty habit. You ought to stop while you still can.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Franc heaved a sigh, handed me the packet and headed down..."*)

### Węzeł `[187]`
**[WYBÓR GRACZA: ""I'm just asking you to wait until you're out of the house.”"]** — Mówca: **Player**
> ""I'm just asking you to wait until you're out of the house.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[64]` (Franc)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Franc heaved a sigh, handed me the packet and headed down..."*)

### Węzeł `[188]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]` (*Narrator: "Franc heaved a sigh, handed me the packet and headed down..."*)

### Węzeł `[189]`
Mówca: **Narrator**
> "Franc heaved a sigh, handed me the packet and headed downstairs. I followed him to the living room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Narrator: "The table was prepared and Monica was ladling food onto t..."*)

### Węzeł `[190]`
**[WYBÓR GRACZA: ""You mean --""]** — Mówca: **Player**
> ""You mean --""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[27]` (Monica), `[28]` (Monica), `[29]` (Monica)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)

### Węzeł `[191]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Deyr_Poor == true"*)
  - -> `[193]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)"*)

### Węzeł `[192]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Deyr_Poor == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]` (*Monica: ""Yes! Zabla!""*)

### Węzeł `[193]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Deyr_Poor == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Deyr_Poor"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)

### Węzeł `[194]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Birthplace_Holsord_Middle == true"*)
  - -> `[196]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)"*)

### Węzeł `[195]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Birthplace_Holsord_Middle == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]` (*Monica: ""Yes! Svabli!""*)

### Węzeł `[196]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Birthplace_Holsord_Middle == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Birthplace_Holsord_Middle"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]` (*Monica: ""Yes! Lorscha!""*)

### Węzeł `[197]`
Mówca: **Monica**
> ""Yes! Zabla!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Zabla was one of my hometown's specialties -- a chickpea ..."*)

### Węzeł `[198]`
Mówca: **Monica**
> ""Yes! Svabli!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]` (*Narrator: "Svabli was a classic Holsord delicacy -- vegetables and c..."*)

### Węzeł `[199]`
Mówca: **Monica**
> ""Yes! Lorscha!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]` (*Narrator: "Lorscha was a Lachaven specialty usually reserved for spe..."*)

### Węzeł `[200]`
Mówca: **Narrator**
> "Svabli was a classic Holsord delicacy -- vegetables and creamy sheep cheese sandwiched between thin layers of dough."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "It was absolutely my favorite dish -- especially paired w..."*)

### Węzeł `[201]`
Mówca: **Narrator**
> "Lorscha was a Lachaven specialty usually reserved for special occasions -- a rich seafood stew with a heady garlic and paprika kick."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Narrator: "It was absolutely my favorite dish -- especially paired w..."*)

### Węzeł `[202]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_EnT_Economy_Planned == true"*)
  - -> `[204]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_EnT_Economy_Planned == true)"*)

### Węzeł `[203]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_EnT_Economy_Planned == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_E_Planned = true"*)

### Węzeł `[204]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_EnT_Economy_Planned == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_ProtestsInGruni = true; Ba..."*)

### Węzeł `[205]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_E_Planned = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_E_Planned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_ST_ProtestsInGruni = true; Ba..."*)

### Węzeł `[206]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Monica: ""What, you and Petr didn't booze it up enough back at the..."*)

### Węzeł `[207]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Monica: ""I just wanted to cheer everyone up a bit.""*)

### Węzeł `[208]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Narrator: "The stereo in Franc's room clicked off."*)

### Węzeł `[209]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Narrator: "Franc headed downstairs to the dining room and I followed..."*)

### Węzeł `[210]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "Monica measured me with her eyes for a moment."*)

### Węzeł `[211]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "I realized my poor choice of words too late. Monica looke..."*)

### Węzeł `[212]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "Monica measured me with her eyes for a moment."*)

### Węzeł `[213]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Franc took his seat again, scowling."*)

### Węzeł `[214]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Franc took his seat again, scowling."*)

### Węzeł `[215]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Franc took his seat again, scowling."*)

### Węzeł `[216]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion += 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Franc: "“No.”"*)

### Węzeł `[217]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Franc_Opinion -= 1`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Franc_Opinion"] = Variable["BaseGame.Relations_Franc_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Monica: "“Franc. Listen to your father. If your father says we don..."*)

### Węzeł `[218]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Relations_Monica_Opinion += 2`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Relations_Monica_Opinion"] = Variable["BaseGame.Relations_Monica_Opinion"] + 2;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Narrator: "She got up, stood behind me and massaged my shoulders for..."*)

### Węzeł `[219]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)
