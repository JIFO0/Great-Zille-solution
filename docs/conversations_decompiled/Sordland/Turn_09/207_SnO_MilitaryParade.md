# Sordland/Turn09/SnO_MilitaryParade

- **ID konwersacji:** `207`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/207_SnO_MilitaryParade.md`
- **Liczba węzłów dialogowych:** 306
- **Liczba wyborów gracza:** 59

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[54]** Serge Wolkner
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Ending_Coup`
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Prologue_Military_Order_Accomplished`
- `BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff`
- `BaseGame.Relations_Iosef_Enemy`
- `BaseGame.Situation_Military_ExperiencedGenerals`
- `BaseGame.Situation_Military_GreenGenerals`
- `BaseGame.Situation_Military_ModernisedAirForce`
- `BaseGame.Situation_Military_ModernisedArmy`
- `BaseGame.Situation_Military_OutdatedMilitaryEquipment`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGameIsolated.Turn09_A_Parade_IosefWithYou`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Death`
- `BaseGameIsolated.Turn09_SollTrial_Guilty_Prison`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Enable_SergeFuneral`
- `BaseGame.Turn09_MilitaryParade_AssassinationAttempt`
- `BaseGame.Turn09_MilitaryParade_SergeDead`
- `BaseGameIsolated.Turn09_A_Parade_IosefWithYou`
- `BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination`
- `BaseGameSupport.Journal_Turn09_MilitaryParade_Survived`
- `BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead`
- `BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination`
- `BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination`
- `BaseGameSupport.Report_Turn09_Holsord_Assassination`
- `BaseGameSupport.Report_Turn09_Holsord_Parade`
- `GameCondition.Turn09_SnO_MilitaryParade`
- `GameCondition.Turn10_Personal_SergeFuneral`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 17

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[185]` (Iosef Lancea): `Variable["GameCondition.Turn09_SnO_MilitaryParade"] = true;`
- Węzeł `[189]` (Iosef Lancea): `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] = true;`
- Węzeł `[267]` (Iosef Lancea): `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] = true;`
- Węzeł `[268]` (Iosef Lancea): `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] = true;`
- Węzeł `[290]` (Iosef Lancea): `Variable["BaseGame.Enable_SergeFuneral"] = true; Variable["GameCondition.Turn10_Personal_SergeFun...`
- Węzeł `[291]` (Iosef Lancea): `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead"] = true;`
- Węzeł `[292]` (Iosef Lancea): `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_Survived"] = true;`
- Węzeł `[293]` (Iosef Lancea): `Variable["BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination"] = true; Variable["BaseGam...`
- *...oraz 9 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Iosef Lancea)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Iosef Lancea)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "It was an unusual day for the residents of Holsord. Regularly used streets and avenues were blocked off by the military personnel. Many shops and cafes were closed and once crowded stores were now empty. Instead, thousands of residents in Holsord were concentrated in one street, Victory Avenue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Stretching out through the heart of Holsord, people on both sides of the road were waving their Sordish flags proudly for the military parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I was getting prepared to embark on my trip. It was going to be a short drive down the Victory Avenue until we reached Maroon Palace. My company for this trip was Iosef with Serge, as usual, driving the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Let's get this over with.”"]** — Mówca: **Player**
> "“Let's get this over with.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "Nod."]** — Mówca: **Player_Italic**
> "I nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[8]`
Mówca: **Iosef Lancea**
> "“Mr. President. We are almost ready.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Serge Wolkner**
> "“Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[10]`
Mówca: **Narrator**
> "Iosef approached me. He was wearing his decorated ceremony outfit. He carried a sword with a goat head at the handle and his pistol by his hip. He put on his cap."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[11]`
Mówca: **Narrator**
> "Serge appeared from the entrance and joined us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
Mówca: **Iosef Lancea**
> "“We will depart right after the tank column.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[6]`
  - -> `[15]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good.”"]** — Mówca: **Player**
> "“Good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
Mówca: **Narrator**
> "After hearing the loud thump of a book falling down to the floor, he turned to a couple of privates that were doing the preparations on the schedule and started walking in their direction."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Rumburg will think twice after today.”"]** — Mówca: **Player**
> "“Rumburg will think twice after today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Iosef Lancea**
> "“They will tremble before the Sordish military might.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[17]`
Mówca: **Narrator**
> "Iosef nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[18]`
Mówca: **Iosef Lancea**
> "“Private! Can't you do your job properly?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[19]`
Mówca: **Narrator**
> "I watched the young soldiers perform a lousy salute to Iosef."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Iosef Lancea**
> "“WHAT IS THAT SALUTE SOLDIER? WATCH! THIS IS A REAL SALUTE!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "He performed an excellent salute and after scolding the privates he walked back."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[25]`

### Węzeł `[22]`
Mówca: **Iosef Lancea**
> "“Old habits die hard.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[23]`
**[WYBÓR GRACZA: "“Strict as ever.”"]** — Mówca: **Player**
> "“Strict as ever.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“Doesn't give me much confidence that our soldiers do not even know how to properly salute.”"]** — Mówca: **Player**
> "“Doesn't give me much confidence that our soldiers do not even know how to properly salute.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Is it time yet?”"]** — Mówca: **Player**
> "“Is it time yet?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
Mówca: **Iosef Lancea**
> "“I will have him educated.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[27]`
Mówca: **Iosef Lancea**
> "“Very soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[28]`
Mówca: **Serge Wolkner**
> "“Mr. Lancea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Serge performed a salute to Iosef which made Iosef smile under his moustache."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Iosef Lancea**
> "“At ease, Mr. Wolkner.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Iosef Lancea**
> "“Are we ready to depart yet?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Serge Wolkner**
> "“Yes, sir. Follow me please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Narrator**
> "We started following Serge through the corridors."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Serge Wolkner**
> "“Mr. President. Have you seen the tanks? Our planes too?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Serge Wolkner**
> "“Rumburg will be so scared when they see this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“Yes, Serge. I have seen it.”"]** — Mówca: **Player**
> "“Yes, Serge. I have seen it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“That is the plan.”"]** — Mówca: **Player**
> "“That is the plan.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“I sure hope so.”"]** — Mówca: **Player**
> "“I sure hope so.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Serge Wolkner**
> "“A great one, I'd say.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Serge Wolkner**
> "“My kids were very excited to wake up today. You know. To see the planes fly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Serge Wolkner**
> "“I am sure, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[42]`
Mówca: **Iosef Lancea**
> "“Serge, where did you do your military service?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Serge Wolkner**
> "“Morna. 7th Artillery Squadron. I still talk with many of my friends from those days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Iosef Lancea**
> "“The camaraderie of military is never forgotten. I'm still in touch with my friends from basic training as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Serge Wolkner**
> "“What about you, sir? Where did you serve?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[46]`
Mówca: **Iosef Lancea**
> "“All over Sordland. You know, Mr. President was under my command once. Gumren Outpost.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[47]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[49]`

### Węzeł `[48]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Military_Order_Accomplished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[49]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Military_Order_Accomplished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Military_Order_Accomplished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Unfortunately, I do. Rough times.”"]** — Mówca: **Player**
> "“I do. Rough times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“Who can forget about Major Lancea? We called him 'The Relentless'.”"]** — Mówca: **Player**
> "“Who can forget about Major Lancea? We called him 'The Relentless'.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
Mówca: **Iosef Lancea**
> "“Indeed. Those were rough times.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[53]`
Mówca: **Iosef Lancea**
> "“Good old days.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[54]`
Mówca: **Narrator**
> "Iosef let out a long laugh."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“Do you remember those days?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[50]`
  - -> `[51]`

### Węzeł `[57]`
Mówca: **Iosef Lancea**
> "“I also remember, Mr. President did not like to execute direct orders from his superiors.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“I did what needed to be done.”"]** — Mówca: **Player**
> "“I did what needed to be done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“It's in the past now.”"]** — Mówca: **Player**
> "“It's in the past now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Let's cut the chit chat and do what we are here to do.”"]** — Mówca: **Player**
> "“Let's cut the chit chat and do what we are here to do.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“Which was disobeying orders. But I won't delve into the past.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“True.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[63]`
Mówca: **Iosef Lancea**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[64]`
Mówca: **Serge Wolkner**
> "“We are here, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[65]`
Mówca: **Narrator**
> "We exited the building and walked over to the clearance where the black Kadila, the presidential car, was waiting. It was decorated properly for the event and the top canopy had been removed so that we could stand and wave to people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[66]`
Mówca: **Narrator**
> "We entered the car and Serge started the engine. Iosef was standing right next to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[67]`
Mówca: **Narrator**
> "A group of ten, maybe twelve latest technology S-16 fighter jets flew above our heads and I thought that the engine sounds was going to leave me deaf. Loud footsteps of the marching soldiers were followed by loud noises coming from tank engines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[68]`
Mówca: **Narrator**
> "We waited for a few minutes for the announcement. Finally, it was our turn. On both sides of the Victory Avenue there were numerous citizens cheering my name, waving their Sordish flags."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`
  - -> `[69]`
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "Wave."]** — Mówca: **Player_Italic**
> "I waved to the people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[70]`
**[WYBÓR GRACZA: "Salute."]** — Mówca: **Player_Italic**
> "I saluted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[71]`
**[WYBÓR GRACZA: "Raise your fist."]** — Mówca: **Player_Italic**
> "I raised my fist."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[72]`
Mówca: **Narrator**
> "We kept our slow and steady pace. We were almost at the Artor S. Wisci statue several hundred meters away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[73]`
Mówca: **Narrator**
> "The convoy continued. As I looked around and saw that there was a military truck parked next to the statue in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: "“Hey Iosef, is that truck part of the parade?”"]** — Mówca: **Player**
> "“Hey Iosef, is that truck part of the parade?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
**[WYBÓR GRACZA: "Shrug it off."]** — Mówca: **Player_Italic**
> "I shrugged it off. It was probably nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“Yes it is, sir. Although I am not sure why it is not following the motorcade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[77]`
Mówca: **Iosef Lancea**
> "“I will make sure they are punished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "We continued and neared the statue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[79]`
Mówca: **Narrator**
> "The truck was standing in the middle of the road blocking the parade a few dozen meters in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Narrator**
> "His jaw was clenched and his hand was slowly making its way to the gun on his hip."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“Was this scheduled?”"]** — Mówca: **Player**
> "“Was this scheduled?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[82]`
**[WYBÓR GRACZA: "“What is going on? Do you see the truck?”"]** — Mówca: **Player**
> "“What is going on? Do you see the truck?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Iosef Lancea**
> "“No.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[84]`
Mówca: **Iosef Lancea**
> "“Something is not right.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“What on earth is going on with that truck? Bring the guards at once. Do you copy?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Narrator**
> "His other hand went to his radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“I radioed the instru-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[88]`
Mówca: **Narrator**
> "Three men who jumped out of the truck started running towards our car. They were holding KA-74's pointed right at us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[89]`
Mówca: **Narrator**
> "In a split second Iosef pulled his pistol and shot at the gunmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“SERGE! FLOOR IT! NOW!”"]** — Mówca: **Player**
> "<shout>“SERGE! FLOOR IT! NOW!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[298]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"]** — Mówca: **Player**
> "<shout>“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Narrator**
> "Serge quickly accelerated the car. The gunmen started firing and my ears started ringing. The sounds of the bullet impacts were horrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[93]`
Mówca: **Narrator**
> "Serge reversed the car at full speed and ducked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`
  - -> `[257]`
  - -> `[256]`

### Węzeł `[94]`
Mówca: **Iosef Lancea**
> "<shout>“MR. PRESIDENT. ARE YOU OKAY?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Iosef Lancea**
> "<shout>“ANSWER ME.”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`
  - -> `[97]`
  - -> `[136]`

### Węzeł `[96]`
**[WYBÓR GRACZA: "“I'm okay.”"]** — Mówca: **Player**
> "“I'm okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“What just happened!?”"]** — Mówca: **Player**
> "“What just happened!?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Iosef Lancea**
> "“Thank God! He is alive!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[99]`
Mówca: **Iosef Lancea**
> "“Are you injured? Do you feel any pain?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I checked my body and didn't feel any injuries. I shook my head. I saw the wound on Iosef's right shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Narrator**
> "He was bleeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`
  - -> `[110]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "“Nevermind me. Are you alright?”"]** — Mówca: **Player**
> "“Nevermind me. Are you alright?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[103]`
**[WYBÓR GRACZA: "“Are we safe?”"]** — Mówca: **Player**
> "“Are we safe?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Iosef Lancea**
> "“It's just a bullet in the shoulder, sir. Nothing critical.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“We are for now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "The car horn wouldn't stop blaring. I looked over to the driver's seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
Mówca: **Iosef Lancea**
> "“Mr. President. I'm sorr-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Serge's head was leaning against the wheel, completely motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[113]`
  - -> `[112]`

### Węzeł `[110]`
**[WYBÓR GRACZA: "“What happened to the attackers?”"]** — Mówca: **Player**
> "“What happened to the attackers?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[111]`
Mówca: **Iosef Lancea**
> "“They are dead. I got one of them the guards handled the other two.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[112]`
**[WYBÓR GRACZA: "“THEY WILL PAY FOR THIS.”"]** — Mówca: **Player**
> "“THEY WILL PAY FOR THIS.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
**[WYBÓR GRACZA: "“No. This can't be true.”"]** — Mówca: **Player**
> "“No. This can't be true.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Iosef Lancea**
> "“They will, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Iosef Lancea**
> "“I'm afraid it is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[116]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Narrator**
> "They started taking care of Iosef and put him on a stretcher. He was yelling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Iosef Lancea**
> "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Iosef Lancea**
> "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE FIRST ONE TO RESPOND?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[120]`
Mówca: **Narrator**
> "Iosef was put in an ambulance and taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I watched the medics pull out Serge's lifeless body from the car and place it into a black body bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[122]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[123]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[125]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[126]`
Mówca: **Narrator**
> "They started firing and my ears started ringing. I could hear the bullets impacting the car as we reversed and hit a roadblock behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[127]`
Mówca: **Narrator**
> "I dared to look up for a second and saw that Iosef had his pistol drawn, shooting back at the attackers. I checked my body and didn't feel any injuries."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[128]`
Mówca: **Narrator**
> "I saw the wound on Iosef's right shoulder. He was shot."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA: "“I SAID GET DOWN!”"]** — Mówca: **Player**
> "<shout>“I SAID GET DOWN!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "Pull him back to the cover."]** — Mówca: **Player_Italic**
> "I tried to pull him back to the cover but he didn't flinch."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Narrator**
> "As he stumbled, he pointed his pistol, aimed and then fired at the gunmen."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[132]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. There was a complete silence and the screams from of the crowd subdued."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
**[WYBÓR GRACZA: "“Are they dead? Is it over?”"]** — Mówca: **Player**
> "“Are they dead? Is it over?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Iosef, are you okay?”"]** — Mówca: **Player**
> "“Iosef, are you okay?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[135]`
Mówca: **Narrator**
> "There was a muffled sound from the front seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[136]`
**[WYBÓR GRACZA: "“Is everyone alright!?”"]** — Mówca: **Player**
> "“Is everyone alright!?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[137]`
Mówca: **Narrator**
> "Iosef turned to me after grunting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Narrator**
> "Iosef turned to me after grunting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[139]`
Mówca: **Iosef Lancea**
> "“I've been better, sir. Got two of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[140]`
Mówca: **Iosef Lancea**
> "“I got two of them.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[141]`
Mówca: **Serge Wolkner**
> "“What just happene-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Serge Wolkner**
> "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[143]`

### Węzeł `[143]`
**[WYBÓR GRACZA: "“I'm fine. Are you injured?”"]** — Mówca: **Player**
> "“I'm fine. Are you injured?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[144]`
**[WYBÓR GRACZA: "“No, Serge. I won't be fine until they pay for what they have done.”"]** — Mówca: **Player**
> "“No, Serge. I won't be fine until they pay for what they have done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Serge Wolkner**
> "“No injuries, sir. Thank God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Narrator**
> "He patted himself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[147]`
Mówca: **Serge Wolkner**
> "“They will pay, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Serge Wolkner**
> "“Mr. Lancea is a tough cookie to crack.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[149]`
Mówca: **Iosef Lancea**
> "“I'm not dead yet.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[150]`
Mówca: **Narrator**
> "He grunted in pain again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[151]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Narrator**
> "They started taking care of Iosef and put him on a stretcher. He was yelling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Iosef Lancea**
> "<shout>“HOW CAN YOU LET THIS HAPPEN? IDIOTS, ALL OF YOU!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Narrator**
> "Iosef was put in an ambulance and taken away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[155]`
Mówca: **Iosef Lancea**
> "“YOU CAN'T EVEN PROTECT YOUR OWN PRESIDENT! WHY WAS I THE FIRST ONE TO RESPOND?!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[156]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Narrator**
> "I was finally placed in an ambulance as well and was rushed to the hospital."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[158]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_OutdatedMilitaryEquipment == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_OutdatedMilitaryEquipment == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[160]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_OutdatedMilitaryEquipment == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_OutdatedMilitaryEquipment"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[161]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ModernisedAirForce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[163]`

### Węzeł `[162]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ModernisedAirForce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_ModernisedAirForce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[163]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_ModernisedAirForce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ModernisedAirForce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[164]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ModernisedArmy == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ModernisedArmy == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_ModernisedArmy"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_ModernisedArmy == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ModernisedArmy"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[167]`
Mówca: **Narrator**
> "A couple of old propeller planes flew above our heads and I thought whether the planes were older than me. Loud footsteps of the marching soldiers were followed by loud noises coming from tank engines."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[168]`
Mówca: **Narrator**
> "The tanks came into my view. They were top of the line modern battle tanks. Their shining armour under the sun invigorated national pride."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[169]`
Mówca: **Narrator**
> "The tanks came into my view. They were not the most modern models however they displayed our military might. I couldn't even finish my thought and one of the tanks broke down and had to be towed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[170]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ExperiencedGenerals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_ExperiencedGenerals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_ExperiencedGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[172]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_ExperiencedGenerals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_ExperiencedGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[173]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Military_GreenGenerals == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Military_GreenGenerals"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Military_GreenGenerals == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Military_GreenGenerals"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[176]`
Mówca: **Narrator**
> "On the way to the car, generals and admirals were lined up on both sides of the carpet. The atmosphere immediately changed when these experienced men who fought many times for their country saluted me. I saluted back with respect."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[177]`
Mówca: **Narrator**
> "On the way to the car, generals and admirals were lined up on both sides of the carpet. I was surprised by the young age of some generals. I wondered whether they have even seen any action."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[178]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They did not even have matching guns. Iosef turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Iosef Lancea**
> "“This is all result of the cuts, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[180]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They looked proud and stout in the new infantry uniforms and with brand-new rifles."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[181]`
Mówca: **Narrator**
> "We continued on as per the schedule and finally arrived at the Maroon Palace which marked the end of the parade."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[182]`
Mówca: **Narrator**
> "People of Holsord dispersed to their homes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Narrator**
> "A clear message was sent to Rumburg by the display of our military might."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[184]`
Mówca: **Narrator**
> "We were about to see whether it would be enough or not."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_SnO_MilitaryParade = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_SnO_MilitaryParade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`

### Węzeł `[186]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[188]`

### Węzeł `[187]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Iosef_Enemy == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Iosef_Enemy"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Iosef_Enemy == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Iosef_Enemy"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[189]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[190]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[192]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[193]`
Mówca: **Narrator**
> "We exited the building and walked over to the clearance where the black Kadila, the presidential car, was waiting. It was decorated properly for the event and the top canopy had been removed so that I could stand and wave to people."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[194]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[196]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Narrator**
> "I entered the car and Serge started the engine. Iosef saluted me. We were on our way shortly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Iosef Lancea**
> "“Good luck, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Narrator**
> "The car started rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[200]`
Mówca: **Narrator**
> "The car started rolling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[201]`
Mówca: **Narrator**
> "Even though there were many walls and trees in between the car and the crowd, I was able to hear the deafening sounds of cheering Sordish citizens. Gradually we made our way to the starting point."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[202]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[204]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Narrator**
> "A group of soldiers saluted me as we passed by. They did not even have matching guns."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[206]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[208]`

### Węzeł `[207]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[208]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_A_Parade_IosefWithYou == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_A_Parade_IosefWithYou"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`

### Węzeł `[209]`
Mówca: **Narrator**
> "The convoy continued. As I looked around and saw that there was a military truck parked next to the statue in the distance."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`

### Węzeł `[210]`
Mówca: **Narrator**
> "We continued and neared the statue."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[211]`
**[WYBÓR GRACZA: "“Hey Serge, is that truck part of the parade?”"]** — Mówca: **Player**
> "“Hey Serge, is that truck part of the parade?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[213]`

### Węzeł `[212]`
**[WYBÓR GRACZA: "Shrug it off."]** — Mówca: **Player_Italic**
> "I shrugged it off. It was probably nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[213]`
Mówca: **Serge Wolkner**
> "“I think so, Mr. President. Although I am not sure why it's parked.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[214]`
Mówca: **Narrator**
> "The truck was standing in the middle of the road blocking the parade a few dozen meters in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`
  - -> `[217]`

### Węzeł `[215]`
**[WYBÓR GRACZA: "“Was this scheduled?”"]** — Mówca: **Player**
> "“Was this scheduled?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[216]`
Mówca: **Serge Wolkner**
> "“I- I don't think so, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[217]`
**[WYBÓR GRACZA: "“What is going on? Do you see the truck?”"]** — Mówca: **Player**
> "“What is going on? Do you see the truck?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[218]`
Mówca: **Serge Wolkner**
> "“I- I don't know, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[219]`
Mówca: **Narrator**
> "His jaw was clenched and he was intently watching."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`

### Węzeł `[220]`
Mówca: **Serge Wolkner**
> "“Something's wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[221]`
Mówca: **Narrator**
> "Serge then picked up the radio."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`

### Węzeł `[222]`
Mówca: **Serge Wolkner**
> "“There seems to be a truck on the way. Is this part of the schedu-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[223]`

### Węzeł `[223]`
Mówca: **Narrator**
> "Three men who jumped out of the truck started running towards our car. They were holding KA-74's pointed right at us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`
  - -> `[229]`

### Węzeł `[224]`
**[WYBÓR GRACZA: "“SERGE! FLOOR IT! NOW!”"]** — Mówca: **Player**
> "<shout>“SERGE! FLOOR IT! NOW!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[302]`

### Węzeł `[225]`
Mówca: **Narrator**
> "Serge quickly accelerated the car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Narrator**
> "Gunmen started firing and my ears started ringing. The sounds of the bullet impacts were horrifying."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[227]`
Mówca: **Narrator**
> "There was a complete silence followed by screams from the crowd."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[228]`
Mówca: **Narrator**
> "The car hit one of the soldiers. We were about to crash into the truck in-front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`
  - -> `[231]`
  - -> `[251]`

### Węzeł `[229]`
**[WYBÓR GRACZA: "“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”"]** — Mówca: **Player**
> "<shout>“REVERSE! GET DOWN! THEY ARE GONNA SHOOT!”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[230]`
Mówca: **Narrator**
> "I regained consciousness after the crash. The muffled screams from the crowd combined with the car horn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[231]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to the God."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[232]`
Mówca: **Narrator**
> "Serge reversed the car at full speed and ducked."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`
  - -> `[253]`
  - -> `[252]`

### Węzeł `[233]`
Mówca: **Narrator**
> "They started firing and my ears started ringing. I could hear the bullets impacting the car as we reversed and hit a roadblock behind us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`

### Węzeł `[234]`
Mówca: **Serge Wolkner**
> "“They will pay, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[235]`
**[WYBÓR GRACZA: "“I'm fine. Are you injured?”"]** — Mówca: **Player**
> "“I'm fine. Are you injured?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[236]`
Mówca: **Narrator**
> "There was a muffled sound from the front seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[237]`
Mówca: **Serge Wolkner**
> "“What just happene-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[238]`
Mówca: **Serge Wolkner**
> "“No injuries, sir. Thank God.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[239]`
Mówca: **Serge Wolkner**
> "<shout>“SIR! ARE YOU ALRIGHT?”</shout>"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`
  - -> `[235]`

### Węzeł `[240]`
**[WYBÓR GRACZA: "“No, Serge. I won't be fine until they pay for what they have done.”"]** — Mówca: **Player**
> "“No, Serge. I won't be fine until they pay for what they have done.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[241]`
Mówca: **Narrator**
> "He pat himself down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[242]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me and Serge. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[243]`
Mówca: **Narrator**
> "The car was dotted with bullet holes. The bodies of dead gunmen were in-front of it. It was a miracle that no one died."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[244]`
Mówca: **Narrator**
> "The car horn just wouldn't stop. I looked over to the driver seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[245]`
Mówca: **Narrator**
> "Serge's head was leaning against the wheel, completely motionless."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`

### Węzeł `[246]`
Mówca: **Narrator**
> "I froze."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[247]`
Mówca: **Narrator**
> "Trails of blood were leading to the dead gunmen behind the presidential car."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[249]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Emergency medical teams arrived and started examining me. After confirming that we had no injuries, I stood up and took a look around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[249]`
Mówca: **Narrator**
> "I watched the medics pull out Serge's lifeless body from the car and into a black body bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[250]`
**[WYBÓR GRACZA: "Hold on as tightly as you can."]** — Mówca: **Player_Italic**
> "I held on as tight as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[251]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[303]`

### Węzeł `[252]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[253]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to the God."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[254]`
**[WYBÓR GRACZA: "Duck down."]** — Mówca: **Player_Italic**
> "I ducked down as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[255]`
**[WYBÓR GRACZA: "Duck down."]** — Mówca: **Player_Italic**
> "I ducked down as fast as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[256]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[257]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to God."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[304]`

### Węzeł `[258]`
Mówca: **Narrator**
> "Looking at the benches where the new officers of the General Staff was sitting at, I saw Tarquin Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[259]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == false  and  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[261]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_SollTrial_Guilty_Death == false && BaseGameIsolated.Turn09_SollTrial_Guilty_Prison == false ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Death"] == false  and  Variable["BaseGameIsolated.Turn09_SollTrial_Guilty_Prison"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[262]`
Mówca: **Narrator**
> "From this distance it was hard to tell, but he tipped his hat off to me and I could swear that he was smiling."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[263]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`
  - -> `[265]`

### Węzeł `[264]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[265]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_PresiPower_Strong_PurgeGeneralStaff"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`

### Węzeł `[266]`
Mówca: **Narrator**
> "Looking at the benches where the General Staff was sitting at, I saw Tarquin Soll sitting next to General Valken."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[267]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[268]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_AssassinationAttempt = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn09_MilitaryParade_AssassinationAttempt"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[269]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[272]`
Mówca: **Narrator**
> "I saluted the high ranking military staff and attaches from CSP. We shook hands before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[273]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[276]`
Mówca: **Narrator**
> "I saluted the high ranking military staff and attaches from ATO. We shook hands before proceeding."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[277]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[278]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. My head was spinning and my ears were still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[279]`
Mówca: **Narrator**
> "The car hit one of the soldiers. We were about to crash into the truck in front of us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`
  - -> `[280]`
  - -> `[281]`

### Węzeł `[280]`
**[WYBÓR GRACZA: "Start praying."]** — Mówca: **Player_Italic**
> "I started praying to God."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[281]`
**[WYBÓR GRACZA: "Close your eyes."]** — Mówca: **Player_Italic**
> "I closed my eyes."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[282]`
Mówca: **Narrator**
> "A brief gunfight ensued outside as the police and soldiers rushed over to secure the vehicle. Iosef fired several more times towards the gunmen. My head was spinning and my ears were still ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[283]`
**[WYBÓR GRACZA: "Hold on as tightly as you can."]** — Mówca: **Player_Italic**
> "I held on as tight as I could."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[284]`
Mówca: **Narrator**
> "I regained consciousness after the crash. The muffled screams from the crowd combined with the car horn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[285]`
**[WYBÓR GRACZA: "“He did nothing wrong.”"]** — Mówca: **Player**
> "“He did nothing wrong.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[286]`
Mówca: **Iosef Lancea**
> "“He served his country until the very end.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[287]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`
  - -> `[289]`

### Węzeł `[288]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Turn09_MilitaryParade_SergeDead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[289]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn09_MilitaryParade_SergeDead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn09_MilitaryParade_SergeDead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[290]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Enable_SergeFuneral = true; GameCondition.Turn10_Personal_SergeFuneral = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Enable_SergeFuneral"] = true;
Variable["GameCondition.Turn10_Personal_SergeFuneral"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`

### Węzeł `[291]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_SurvivedSergeDead"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[292]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_MilitaryParade_Survived = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_MilitaryParade_Survived"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[293]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination = true;
BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination = true;
BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_R_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_LT_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.News_Turn09_HP_MilitaryParade_Assassination"] = true;
Variable["BaseGameSupport.CountryReport_Turn10_Agnolia_CondolencesAssasination"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[294]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Holsord_Assassination = true; BaseGameSupport.Report_Turn09_Holsord_Parade = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_Assassination"] = true;
Variable["BaseGameSupport.Report_Turn09_Holsord_Parade"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[295]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`
  - -> `[297]`

### Węzeł `[296]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: BaseGame.Ending_Coup == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Ending_Coup"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[297]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: !(BaseGame.Ending_Coup == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Ending_Coup"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[298]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushStart");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[299]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushEnd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushEnd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[300]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlayCustomMapMusic("Map_Music_Tense");)*
- **Efekt (`userScript`):** `PlayCustomMapMusic("Map_Music_Tense");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[301]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[302]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushStart");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[303]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushEnd");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushEnd");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[304]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushStart");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[305]`
Mówca: **Iosef Lancea**
*(Węzeł logiki narracyjnej: PlaySoundEffect("AmbushStart");)*
- **Efekt (`userScript`):** `PlaySoundEffect("AmbushStart");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`
