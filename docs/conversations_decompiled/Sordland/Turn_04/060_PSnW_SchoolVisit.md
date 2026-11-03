# Sordland/Turn04/PSnW_SchoolVisit

- **ID konwersacji:** `60`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/060_PSnW_SchoolVisit.md`
- **Liczba węzłów dialogowych:** 183
- **Liczba wyborów gracza:** 32

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[33]** Girl
- **[38]** Lucian Galade
- **[40]** Ciara Walda
- **[43]** Boy
- **[63]** Principal

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_EmergencyDecree_Banned_Bluds`
- `BaseGame.Reform_EmergencyDecree_Banned_RY`
- `BaseGame.Reform_EmergencyDecree_Banned_YS`
- `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg`
- `BaseGame.Reform_EmergencyDecree_SuspendedProtests`
- `BaseGame.Situation_Diplomacy_Energy_PriceBalanced`
- `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation`
- `BaseGame.Turn02_InT_Corporation_TaurusHolding`
- `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`
- `BaseGame.Turn04_SnO_LE_Interior_Decreased`
- `BaseGame.Turn04_SnO_LE_Interior_Increased`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Public_Opinion`
- `BaseGame.Sollist`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`
- `BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler`
- `BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler_BanRY`
- `BaseGameSupport.FactionReport_Turn04_CSP_CritiqueMeftiemITZ`
- `BaseGameSupport.News_Turn04_E_Energy_PriceBalance`
- `BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations`
- `BaseGameSupport.News_Turn04_E_Energy_PriceSurge`
- `BaseGameSupport.News_Turn04_G_QinalBlamesPMCs`
- `BaseGameSupport.News_Turn04_HP_PrayerLanguageBill`
- `BaseGameSupport.News_Turn04_HP_SchoolVisit`
- `BaseGameSupport.News_Turn04_LT_RYArrested`
- `BaseGameSupport.News_Turn04_LT_YSArrested`
- `BaseGameSupport.News_Turn04_R_DeyrLockdown`
- `BaseGameSupport.News_Turn04_R_SollPortrait`
- `BaseGameSupport.News_Turn04_R_SollPortrait_A`
- `BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_BannedProtests`
- `BaseGameSupport.News_Turn04_ST_GiraltWineReveal`
- `BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal`
- `BaseGameSupport.Report_Turn04_Erlory_GiraltUnveilsWine`
- `BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget`
- `BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget`
- `BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo`
- `GameCondition.Turn04_PSnW_SchoolVisit`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 21

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Sollist`
- `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait`
- `BaseGameSupport.News_Turn04_E_Energy_PriceBalance`
- `BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations`
- `BaseGameSupport.News_Turn04_E_Energy_PriceSurge`
- `BaseGameSupport.News_Turn04_R_SollPortrait`
- `BaseGameSupport.News_Turn04_R_SollPortrait_A`
- `BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal`
- `BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget`
- `BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[3]` (Ciara Walda): `Variable["GameCondition.Turn04_PSnW_SchoolVisit"] = true;`
- Węzeł `[113]` (Ciara Walda): `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1; Variable["BaseGame.Public_Opinio...`
- Węzeł `[114]` (Ciara Walda): `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] = true;`
- Węzeł `[117]` (Ciara Walda): `Variable["BaseGameSupport.News_Turn04_HP_SchoolVisit"] = true;`
- Węzeł `[121]` (Ciara Walda): `Variable["BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal"] = true;`
- Węzeł `[128]` (Ciara Walda): `Variable["BaseGameSupport.News_Turn04_R_SollPortrait_A"] = true;`
- Węzeł `[129]` (Ciara Walda): `Variable["BaseGameSupport.News_Turn04_R_SollPortrait"] = true;`
- Węzeł `[133]` (Ciara Walda): `Variable["BaseGameSupport.News_Turn04_R_DeyrLockdown"] = true;`
- *...oraz 13 innych węzłów ze skryptami.*

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Ciara Walda)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_PSnW_SchoolVisit = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_PSnW_SchoolVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[4]`
Mówca: **Narrator**
> "As part of the planned program, we arrived in Leiren to visit a middle school."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[5]`
Mówca: **Narrator**
> "The prestigious Toren Hill School was situated close to the suburbs just outside of the city centre. The building was flanked by two hills, each beautifully dotted with shrubs and flowers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Lucian, Ciara and I got out of our cars and met at the entrance. Our presence had not gone unnoticed. Apart from our guards, there were at least ten reporters following us around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“That must be the principal. Right this way, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "The principal was a man of short stature with a bushy moustache and a pair of glasses. He approached us quickly, but was stopped by the security guards. They started patting him down and searching him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[11]`

### Węzeł `[9]`
Mówca: **Principal**
> "“Mr. President. Such an honor to meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[12]`

### Węzeł `[10]`
**[WYBÓR GRACZA: "“That won't be necessary. Let him through.”"]** — Mówca: **Player**
> "“That won't be necessary. Let him through.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "Wait for them to finish."]** — Mówca: **Player_Italic**
> "I waited for them to finish searching the principal. One of the guards turned to me and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Shake his hand and smile for the cameras."]** — Mówca: **Player_Italic**
> "We shook hands and I turned around to smile for the cameras. Reporters instantly snapped a few photos."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Principal**
> "“Welcome to our humble school.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[16]`
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Sorry about the security guards. It's a necessity. Standard procedure.”"]** — Mówca: **Player**
> "“Sorry about the security guards. It's a necessity. Standard procedure.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It's good to be here.”"]** — Mówca: **Player**
> "“It's good to be here.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“It's a pleasure to meet you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Principal**
> "“Excellent. You must be Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[20]`
Mówca: **Principal**
> "“And Ms. Walda. So good of you to come all the way out here.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Ciara Walda**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[22]`
Mówca: **Narrator**
> "As we entered the students started singing the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[23]`
Mówca: **Narrator**
> "After the anthem finished. All of the students immediately snapped to attention and turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“Looks more like a military institution than a school.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[25]`
Mówca: **Principal**
> "“Exactly. That's what we pride ourselves on. Discipline has the utmost importance in our school.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Some discipline never hurt anyone.”"]** — Mówca: **Player**
> "“A little discipline never hurt anyone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“We need more educated people, not soldiers.”"]** — Mówca: **Player**
> "“We need more educated people, not soldiers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Ciara Walda**
> "“On that we are aligned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[30]`
Mówca: **Ciara Walda**
> "“Up to a point, perhaps. Look at these kids.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Ciara frowned and shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[32]`
Mówca: **Narrator**
> "A boy and a girl went up to the stage and grabbed their microphones. The students turned to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Principal**
> "“I can assure you that our students are very well educated. In fact our school is one of the top ten middle schools in the entirety of Sordland.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[34]`
Mówca: **Principal**
> "“Glad you liked it, Mr. President.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Principal**
> "“Now, we will watch the students take their daily Student Oath.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
Mówca: **Principal**
> "“I can assure you that our students are very well educated. In fact our school is one of the top ten middle schools in all of Sordland.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[37]`
Mówca: **Boy**
> "“I am a Sord! My strength lies in my blood!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Girl**
> "“I will respect our honorable elders! I will protect the young!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Boy**
> "“My life belongs to Sordland now and it will belong to it forever!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Girl**
> "“I will always follow the guiding light!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Boy**
> "“Of Colonel Soll and the Great Sords!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Girl**
> "“A Morgna wes core! Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`
  - -> `[44]`
  - -> `[45]`

### Węzeł `[43]`
**[WYBÓR GRACZA: "Clap loudly."]** — Mówca: **Player_Italic**
> "I started clapping loudly. Everyone joined."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod at the kids."]** — Mówca: **Player_Italic**
> "I nodded at the kids."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[45]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Ciara Walda**
> "“What? No one even remembers it after they graduate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“Words to remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[48]`
Mówca: **Principal**
> "“If you wish to follow me, we will take a look at one of our classrooms.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "Through the hallways, we made our way to classroom 7-A. As soon as I entered the whole classroom rose up and snapped to attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Sit down, please.”"]** — Mówca: **Player**
> "“Sit down please.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[51]`
**[WYBÓR GRACZA: "“At ease.”"]** — Mówca: **Player**
> "“At ease.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "The students sat down. The same boy and girl walked up to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[53]`
Mówca: **Principal**
> "“These are our top students and our top class. This here is my son.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[54]`
Mówca: **Narrator**
> "The boy came before me and saluted me like a military officer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[55]`
Mówca: **Principal**
> "“Tell Mr. President what you want to be.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Boy**
> "“Mr. President! I want to be a general, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Boy**
> "“I am ready to sacrifice myself for my country and you, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[60]`

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Good. You will make a fine soldier in the future. At ease, general!”"]** — Mówca: **Player**
> "“Good. You will make a fine soldier in the future. At ease, general!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
**[WYBÓR GRACZA: "“This is nonsense. What are you teaching to these students?”"]** — Mówca: **Player**
> "“This is nonsense. What are you teaching to these students?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I will do whatever I can to not let that happen.”"]** — Mówca: **Player**
> "“I will do whatever I can to not let that happen.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
Mówca: **Principal**
> "“Was it not to your liking? I'm so sorry, Mr. President.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[62]`
Mówca: **Narrator**
> "The principal looked extremely surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[63]`
Mówca: **Narrator**
> "The principal squeezed his son's shoulders and the boy looked up and smiled to his father. He patted him on the back and sent him off to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[64]`
Mówca: **Boy**
> "“Thank you, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[65]`
Mówca: **Ciara Walda**
> "“This is simply ridiculous. You are raising soldiers here, not students!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[66]`
Mówca: **Principal**
> "“I am so sorry. I will immediately perform disciplinary actions.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Ciara Walda**
> "“How about you, young lady? What do you think about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[68]`
Mówca: **Principal**
> "“She is our top student in this school. Her excellent grades are to--.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“I didn't ask you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[70]`
Mówca: **Girl**
> "“I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[71]`
Mówca: **Girl**
> "“I'm sick of having to knit and sew while the boys learn science and chemistry. I'm smarter than all of them. Why do I have to take these stupid handcraft classes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Principal**
> "“Ssssh! Do you know who you are talki-“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[73]`
Mówca: **Ciara Walda**
> "“Shut up. Let her speak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[74]`
Mówca: **Girl**
> "“My math and reading scores are the best in the school. But they won't let me take the classes I want, just because I'm a girl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[75]`
Mówca: **Girl**
> ""I want to be a scientist! Not some soldier's wife!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[77]`
  - -> `[81]`

### Węzeł `[76]`
**[WYBÓR GRACZA: "“You heard her, Mr. Principal. You will make the necessary changes. At once.”"]** — Mówca: **Player**
> "“You heard her, Mr. Principal. You will make the necessary changes. At once.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“But knitting and sewing are important skills to have for a woman.”"]** — Mówca: **Player**
> "“But knitting and sewing are important skills to have for a woman.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Narrator**
> "Ciara's eyes were shooting daggers at me. She looked back at the girl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I will personally check back and ensure that the changes are made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[80]`
Mówca: **Principal**
> "“As you wish, sir. At once.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We need more people like you in this country. I applaud your determination.”"]** — Mówca: **Player**
> "“We need more people like you in this country. I applaud your determination.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[82]`
Mówca: **Ciara Walda**
> "“Don't worry. We will talk in private later, okay?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[83]`
Mówca: **Principal**
> "“Yes, sir.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[84]`
Mówca: **Ciara Walda**
> "“We need more than words. We need action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Girl**
> "“Okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“Well then. Unfortunately we are almost out of time. We have other meetings to attend to today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[87]`
Mówca: **Ciara Walda**
> "“Concrete action. We need to protect girls like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Narrator**
> "The cameras flashed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[89]`
Mówca: **Narrator**
> "The cameras flashed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Thank you for the warm welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Lucian. Let's leave.”"]** — Mówca: **Player**
> "“Lucian. Let's leave.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Thank you for the tour.”"]** — Mówca: **Player**
> "“Thank you for the tour.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Ciara Walda**
> "“Mr. President. Lucian. Please go ahead. I would like to speak with the girl alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`
  - -> `[93]`

### Węzeł `[95]`
Mówca: **Principal**
> "“Thank you for visiting our school, sir.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Principal**
> "“Come on class. One. Two.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Boy**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[98]`
Mówca: **Narrator**
> "All students in the classroom yelled but the boy whom I met was the loudest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[99]`
Mówca: **Narrator**
> "After another round of photos we departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[100]`
Mówca: **Narrator**
> "I looked around the classroom and saw a large portrait of Colonel Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`
  - -> `[111]`

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Take that down.”"]** — Mówca: **Player**
> "“Take that down.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[102]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[103]`
Mówca: **Principal**
> "“But, sir. That's a portrait of Colonel Soll. We can't just take it down.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[104]`
  - -> `[106]`

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Don't make me repeat my words.”"]** — Mówca: **Player**
> "“Don't make me repeat my words.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Lucian. Do it.”"]** — Mówca: **Player**
> "“Lucian. Do it.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[106]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Even the reporters looked confused for a minute, before taking many photos of the portrait being taken down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian took the frame down and gave it to the principal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Narrator**
> "The principal reluctantly took the portrait down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Narrator**
> "Ciara was smiling and when she realised I was looking at her, she nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[111]`
**[WYBÓR GRACZA: "“An excellent portrait of Colonel Soll. Very lifelike.”"]** — Mówca: **Player**
> "“An excellent portrait of Colonel Soll. Very lifelike.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Principal**
> "“Thank you.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[113]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Sollist -= 1;
BaseGame.Public_Opinion -= 1;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[115]`
**[WYBÓR GRACZA: "Leave."]** — Mówca: **Player_Italic**
> "I left the classroom."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[117]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_SchoolVisit = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_SchoolVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[120]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[121]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[122]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[125]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`
  - -> `[127]`

### Węzeł `[126]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_SollPortrait_A = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_SollPortrait_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[129]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_SollPortrait = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_SollPortrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[130]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[133]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_DeyrLockdown = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_DeyrLockdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[134]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`
  - -> `[136]`

### Węzeł `[135]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_RY)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[136]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_RY))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[137]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Banned_YS)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[139]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Banned_YS))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[140]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_RYArrested = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_RYArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[141]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_LT_YSArrested = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_YSArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_HP_PrayerLanguageBill = true; BaseGameSupport.FactionReport_Turn04_CSP_CritiqueMeftiemITZ = true;
BaseGameSupport.News_Turn04_G_QinalBlamesPMCs = true;
BaseGameSupport.Report_Turn04_Erlory_GiraltUnveilsWine = true;
BaseGameSupport.News_Turn04_ST_GiraltWineReveal = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_PrayerLanguageBill"] = true;
Variable["BaseGameSupport.FactionReport_Turn04_CSP_CritiqueMeftiemITZ"] = true;
Variable["BaseGameSupport.News_Turn04_G_QinalBlamesPMCs"] = true;
Variable["BaseGameSupport.Report_Turn04_Erlory_GiraltUnveilsWine"] = true;
Variable["BaseGameSupport.News_Turn04_ST_GiraltWineReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[143]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[145]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[146]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[149]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_BannedProtests = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_BannedProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[152]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`
  - -> `[154]`

### Węzeł `[153]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[154]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[155]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[156]`
Mówca: **Principal**
> "“Education is the premise of progress, in all societies, in all families.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[157]`
Mówca: **Narrator**
> "At the entrance, the school's motto was inscribed on the wall in giant letters. “Instreten sis er Anginicar av Gereigna, int olla Almergwolltene, int olla Mexis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[158]`
Mówca: **Narrator**
> "Ciara bristled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[159]`
Mówca: **Narrator**
> "She bent down and gently addressed the young student."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Ciara Walda**
> "“What do you think about your school? Just between us girls.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[161]`
Mówca: **Narrator**
> "Ciara's presence had emboldened the girl. She went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[162]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`
  - -> `[164]`

### Węzeł `[163]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Increased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[164]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Increased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[165]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_SnO_LE_Interior_Decreased == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[167]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_SnO_LE_Interior_Decreased == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[168]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler = false; BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler_BanRY = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler"] = false;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler_BanRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[169]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: PlaySoundEffect("SingNationalAnthem");)*
- **Efekt (`userScript`):** `PlaySoundEffect("SingNationalAnthem");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[170]`
Mówca: **Narrator**
> "The principal proudly looked at them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[171]`
Mówca: **Principal**
> "“Marvelous, my dear students.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[172]`
Mówca: **Narrator**
> "We walked through the gates. There were many students lined up in front of the stairs of the main building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[173]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[174]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`
  - -> `[176]`

### Węzeł `[175]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[176]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[177]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`
  - -> `[179]`

### Węzeł `[178]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[179]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: !(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[180]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Energy_PriceBalance = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceBalance"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[181]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[182]`
Mówca: **Ciara Walda**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_E_Energy_PriceSurge = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceSurge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`
