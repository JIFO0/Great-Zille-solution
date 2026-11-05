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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[10]` | **"“That won't be necessary. Let him through.”"** | `[8]` **Narrator**: "The principal was a man of short..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Principal**: "“Mr. President. Such an honor to..." |
| `[11]` | **"Wait for them to finish."** | `[8]` **Narrator**: "The principal was a man of short..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Principal**: "“Mr. President. Such an honor to..." |
| `[12]` | **"Shake his hand."** | `[9]` **Principal**: "“Mr. President. Such an honor to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Principal**: "“Welcome to our humble school.”" |
| `[13]` | **"Shake his hand and smile for the cameras."** | `[9]` **Principal**: "“Mr. President. Such an honor to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[14]` **Principal**: "“Welcome to our humble school.”" |
| `[15]` | **"“Sorry about the security guards. It's a necessity. Standard procedure.”"** | `[14]` **Principal**: "“Welcome to our humble school.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Principal**: "“Excellent. You must be Mr. Gala..." |
| `[16]` | **"“It's good to be here.”"** | `[14]` **Principal**: "“Welcome to our humble school.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Principal**: "“Excellent. You must be Mr. Gala..." |
| `[17]` | **"“Let's begin.”"** | `[14]` **Principal**: "“Welcome to our humble school.”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Principal**: "“Excellent. You must be Mr. Gala..." |
| `[26]` | **"“Some discipline never hurt anyone.”"** | `[25]` **Principal**: "“Exactly. That's what we pride o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[158]` **Narrator**: "Ciara bristled." |
| `[27]` | **"“Very good.”"** | `[25]` **Principal**: "“Exactly. That's what we pride o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[31]` **Narrator**: "Ciara frowned and shook her head." |
| `[28]` | **"“We need more educated people, not soldiers.”"** | `[25]` **Principal**: "“Exactly. That's what we pride o..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Ciara Walda**: "“On that we are aligned.”" |
| `[43]` | **"Clap loudly."** | `[42]` **Girl**: "“A Morgna wes core! Vectern sis ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucian Galade**: "“Words to remember.”" |
| `[44]` | **"Nod at the kids."** | `[42]` **Girl**: "“A Morgna wes core! Vectern sis ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucian Galade**: "“Words to remember.”" |
| `[45]` | **"Do nothing."** | `[42]` **Girl**: "“A Morgna wes core! Vectern sis ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[47]` **Lucian Galade**: "“Words to remember.”" |
| `[50]` | **"“Sit down, please.”"** | `[49]` **Narrator**: "Through the hallways, we made ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The students sat down. The same ..." |
| `[51]` | **"“At ease.”"** | `[49]` **Narrator**: "Through the hallways, we made ou..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Narrator**: "The students sat down. The same ..." |
| `[58]` | **"“Good. You will make a fine soldier in the future. At ease, general!”"** | `[57]` **Boy**: "“I am ready to sacrifice myself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Boy**: "“Thank you, sir!”" |
| `[59]` | **"“This is nonsense. What are you teaching to these students?”"** | `[57]` **Boy**: "“I am ready to sacrifice myself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[62]` **Narrator**: "The principal looked extremely s..." |
| `[60]` | **"“I will do whatever I can to not let that happen.”"** | `[57]` **Boy**: "“I am ready to sacrifice myself ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[64]` **Boy**: "“Thank you, sir!”" |
| `[76]` | **"“You heard her, Mr. Principal. You will make the necessary changes. At once.”"** | `[75]` **Girl**: ""I want to be a scientist! Not s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Principal**: "“As you wish, sir. At once.“" |
| `[77]` | **"“But knitting and sewing are important skills to have for a woman.”"** | `[75]` **Girl**: ""I want to be a scientist! Not s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Narrator**: "Ciara's eyes were shooting dagge..." |
| `[81]` | **"“We need more people like you in this country. I applaud your determination.”"** | `[75]` **Girl**: ""I want to be a scientist! Not s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Ciara Walda**: "“We need more than words. We nee..." |
| `[91]` | **"“Very well.”"** | `[94]` **Ciara Walda**: "“Mr. President. Lucian. Please g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Principal**: "“Thank you for visiting our scho..." |
| `[92]` | **"“Lucian. Let's leave.”"** | `[94]` **Ciara Walda**: "“Mr. President. Lucian. Please g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Principal**: "“Thank you for visiting our scho..." |
| `[93]` | **"“Thank you for the tour.”"** | `[94]` **Ciara Walda**: "“Mr. President. Lucian. Please g..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[95]` **Principal**: "“Thank you for visiting our scho..." |
| `[101]` | **"“Take that down.”"** | `[100]` **Narrator**: "I looked around the classroom an..." | *Brak (Dostępna bezwarunkowo)* | `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist...`<br>`Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPo...` | `[103]` **Principal**: "“But, sir. That's a portrait of ..." |
| `[102]` | **"Don't say anything."** | `[100]` **Narrator**: "I looked around the classroom an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[86]` **Lucian Galade**: "“Well then. Unfortunately we are..." |
| `[104]` | **"“Don't make me repeat my words.”"** | `[103]` **Principal**: "“But, sir. That's a portrait of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "The principal reluctantly took t..." |
| `[105]` | **"“Lucian. Do it.”"** | `[103]` **Principal**: "“But, sir. That's a portrait of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[108]` **Narrator**: "Lucian took the frame down and g..." |
| `[106]` | **"“I gave you an order.”"** | `[103]` **Principal**: "“But, sir. That's a portrait of ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "The principal reluctantly took t..." |
| `[111]` | **"“An excellent portrait of Colonel Soll. Very lifelike.”"** | `[100]` **Narrator**: "I looked around the classroom an..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Principal**: "“Thank you.“" |
| `[115]` | **"Leave."** | `[97]` **Boy**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "After another round of photos we..." |
| `[116]` | **"“Vectern sis da!”"** | `[97]` **Boy**: "“A Morgna wes core!”" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[99]` **Narrator**: "After another round of photos we..." |

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
  - -> `[4]` (*Narrator: "As part of the planned program, we arrived in Leiren to v..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn04_PSnW_SchoolVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn04_PSnW_SchoolVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]` (*Węzeł Logiki Narracyjnej: "End();"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "As part of the planned program, we arrived in Leiren to visit a middle school."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)

### Węzeł `[5]`
Mówca: **Narrator**
> "The prestigious Toren Hill School was situated close to the suburbs just outside of the city centre. The building was flanked by two hills, each beautifully dotted with shrubs and flowers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Lucian, Ciara and I got out of our cars and met at the en..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Lucian, Ciara and I got out of our cars and met at the entrance. Our presence had not gone unnoticed. Apart from our guards, there were at least ten reporters following us around."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Lucian Galade: "“That must be the principal. Right this way, sir.”"*)

### Węzeł `[7]`
Mówca: **Lucian Galade**
> "“That must be the principal. Right this way, sir.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "The principal was a man of short stature with a bushy mou..."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "The principal was a man of short stature with a bushy moustache and a pair of glasses. He approached us quickly, but was stopped by the security guards. They started patting him down and searching him."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Player: "“That won't be necessary. Let him through.”"*)
  - -> `[11]` (*Player_Italic: "Wait for them to finish."*)

### Węzeł `[9]`
Mówca: **Principal**
> "“Mr. President. Such an honor to meet with you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player_Italic: "Shake his hand and smile for the cameras."*)
  - -> `[12]` (*Player_Italic: "Shake his hand."*)

### Węzeł `[10]`
**[WYBÓR GRACZA: "“That won't be necessary. Let him through.”"]** — Mówca: **Player**
> "“That won't be necessary. Let him through.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Principal: "“Mr. President. Such an honor to meet with you.”"*)

### Węzeł `[11]`
**[WYBÓR GRACZA: "Wait for them to finish."]** — Mówca: **Player_Italic**
> "I waited for them to finish searching the principal. One of the guards turned to me and nodded."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Principal: "“Mr. President. Such an honor to meet with you.”"*)

### Węzeł `[12]`
**[WYBÓR GRACZA: "Shake his hand."]** — Mówca: **Player_Italic**
> "We shook hands."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Principal: "“Welcome to our humble school.”"*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "Shake his hand and smile for the cameras."]** — Mówca: **Player_Italic**
> "We shook hands and I turned around to smile for the cameras. Reporters instantly snapped a few photos."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[9]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Principal: "“Welcome to our humble school.”"*)

### Węzeł `[14]`
Mówca: **Principal**
> "“Welcome to our humble school.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Player: "“Sorry about the security guards. It's a necessity. Stand..."*)
  - -> `[16]` (*Player: "“It's good to be here.”"*)
  - -> `[17]` (*Player: "“Let's begin.”"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Sorry about the security guards. It's a necessity. Standard procedure.”"]** — Mówca: **Player**
> "“Sorry about the security guards. It's a necessity. Standard procedure.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Principal: "“Excellent. You must be Mr. Galade.”"*)

### Węzeł `[16]`
**[WYBÓR GRACZA: "“It's good to be here.”"]** — Mówca: **Player**
> "“It's good to be here.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Principal: "“Excellent. You must be Mr. Galade.”"*)

### Węzeł `[17]`
**[WYBÓR GRACZA: "“Let's begin.”"]** — Mówca: **Player**
> "“Let's begin.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[14]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Principal: "“Excellent. You must be Mr. Galade.”"*)

### Węzeł `[18]`
Mówca: **Lucian Galade**
> "“It's a pleasure to meet you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Principal: "“And Ms. Walda. So good of you to come all the way out he..."*)

### Węzeł `[19]`
Mówca: **Principal**
> "“Excellent. You must be Mr. Galade.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Lucian Galade: "“It's a pleasure to meet you.”"*)

### Węzeł `[20]`
Mówca: **Principal**
> "“And Ms. Walda. So good of you to come all the way out here.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Ciara Walda: "“Thank you.”"*)

### Węzeł `[21]`
Mówca: **Ciara Walda**
> "“Thank you.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Narrator: "At the entrance, the school's motto was inscribed on the ..."*)

### Węzeł `[22]`
Mówca: **Narrator**
> "As we entered the students started singing the national anthem."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]` (*Narrator: "The principal proudly looked at them."*)

### Węzeł `[23]`
Mówca: **Narrator**
> "After the anthem finished. All of the students immediately snapped to attention and turned to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Ciara Walda: "“Looks more like a military institution than a school.”"*)

### Węzeł `[24]`
Mówca: **Ciara Walda**
> "“Looks more like a military institution than a school.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Principal: "“Exactly. That's what we pride ourselves on. Discipline h..."*)

### Węzeł `[25]`
Mówca: **Principal**
> "“Exactly. That's what we pride ourselves on. Discipline has the utmost importance in our school.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: "“Some discipline never hurt anyone.”"*)
  - -> `[27]` (*Player: "“Very good.”"*)
  - -> `[28]` (*Player: "“We need more educated people, not soldiers.”"*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Some discipline never hurt anyone.”"]** — Mówca: **Player**
> "“A little discipline never hurt anyone.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Narrator: "Ciara bristled."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: "“Very good.”"]** — Mówca: **Player**
> "“Very good.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Ciara frowned and shook her head."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“We need more educated people, not soldiers.”"]** — Mówca: **Player**
> "“We need more educated people, not soldiers.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[25]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Ciara Walda: "“On that we are aligned.”"*)

### Węzeł `[29]`
Mówca: **Ciara Walda**
> "“On that we are aligned.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Principal: "“I can assure you that our students are very well educate..."*)

### Węzeł `[30]`
Mówca: **Ciara Walda**
> "“Up to a point, perhaps. Look at these kids.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Principal: "“I can assure you that our students are very well educate..."*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Ciara frowned and shook her head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Principal: "“Glad you liked it, Mr. President.“"*)

### Węzeł `[32]`
Mówca: **Narrator**
> "A boy and a girl went up to the stage and grabbed their microphones. The students turned to them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Boy: "“I am a Sord! My strength lies in my blood!”"*)

### Węzeł `[33]`
Mówca: **Principal**
> "“I can assure you that our students are very well educated. In fact our school is one of the top ten middle schools in the entirety of Sordland.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Principal: "“Now, we will watch the students take their daily Student..."*)

### Węzeł `[34]`
Mówca: **Principal**
> "“Glad you liked it, Mr. President.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Principal: "“Now, we will watch the students take their daily Student..."*)

### Węzeł `[35]`
Mówca: **Principal**
> "“Now, we will watch the students take their daily Student Oath.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Narrator: "A boy and a girl went up to the stage and grabbed their m..."*)

### Węzeł `[36]`
Mówca: **Principal**
> "“I can assure you that our students are very well educated. In fact our school is one of the top ten middle schools in all of Sordland.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Principal: "“Now, we will watch the students take their daily Student..."*)

### Węzeł `[37]`
Mówca: **Boy**
> "“I am a Sord! My strength lies in my blood!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Girl: "“I will respect our honorable elders! I will protect the ..."*)

### Węzeł `[38]`
Mówca: **Girl**
> "“I will respect our honorable elders! I will protect the young!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Boy: "“My life belongs to Sordland now and it will belong to it..."*)

### Węzeł `[39]`
Mówca: **Boy**
> "“My life belongs to Sordland now and it will belong to it forever!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Girl: "“I will always follow the guiding light!”"*)

### Węzeł `[40]`
Mówca: **Girl**
> "“I will always follow the guiding light!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Boy: "“Of Colonel Soll and the Great Sords!”"*)

### Węzeł `[41]`
Mówca: **Boy**
> "“Of Colonel Soll and the Great Sords!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Girl: "“A Morgna wes core! Vectern sis da!”"*)

### Węzeł `[42]`
Mówca: **Girl**
> "“A Morgna wes core! Vectern sis da!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Player_Italic: "Clap loudly."*)
  - -> `[44]` (*Player_Italic: "Nod at the kids."*)
  - -> `[45]` (*Player_Italic: "Do nothing."*)

### Węzeł `[43]`
**[WYBÓR GRACZA: "Clap loudly."]** — Mówca: **Player_Italic**
> "I started clapping loudly. Everyone joined."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“Words to remember.”"*)

### Węzeł `[44]`
**[WYBÓR GRACZA: "Nod at the kids."]** — Mówca: **Player_Italic**
> "I nodded at the kids."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“Words to remember.”"*)

### Węzeł `[45]`
**[WYBÓR GRACZA: "Do nothing."]** — Mówca: **Player_Italic**
> "I did nothing."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[42]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Lucian Galade: "“Words to remember.”"*)

### Węzeł `[46]`
Mówca: **Ciara Walda**
> "“What? No one even remembers it after they graduate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Principal: "“If you wish to follow me, we will take a look at one of ..."*)

### Węzeł `[47]`
Mówca: **Lucian Galade**
> "“Words to remember.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Ciara Walda: "“What? No one even remembers it after they graduate.”"*)

### Węzeł `[48]`
Mówca: **Principal**
> "“If you wish to follow me, we will take a look at one of our classrooms.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Narrator: "Through the hallways, we made our way to classroom 7-A. A..."*)

### Węzeł `[49]`
Mówca: **Narrator**
> "Through the hallways, we made our way to classroom 7-A. As soon as I entered the whole classroom rose up and snapped to attention."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player: "“Sit down, please.”"*)
  - -> `[51]` (*Player: "“At ease.”"*)

### Węzeł `[50]`
**[WYBÓR GRACZA: "“Sit down, please.”"]** — Mówca: **Player**
> "“Sit down please.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The students sat down. The same boy and girl walked up to..."*)

### Węzeł `[51]`
**[WYBÓR GRACZA: "“At ease.”"]** — Mówca: **Player**
> "“At ease.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Narrator: "The students sat down. The same boy and girl walked up to..."*)

### Węzeł `[52]`
Mówca: **Narrator**
> "The students sat down. The same boy and girl walked up to us."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Principal: "“These are our top students and our top class. This here ..."*)

### Węzeł `[53]`
Mówca: **Principal**
> "“These are our top students and our top class. This here is my son.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Narrator: "The boy came before me and saluted me like a military off..."*)

### Węzeł `[54]`
Mówca: **Narrator**
> "The boy came before me and saluted me like a military officer."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Principal: "“Tell Mr. President what you want to be.“"*)

### Węzeł `[55]`
Mówca: **Principal**
> "“Tell Mr. President what you want to be.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Boy: "“Mr. President! I want to be a general, sir!”"*)

### Węzeł `[56]`
Mówca: **Boy**
> "“Mr. President! I want to be a general, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Boy: "“I am ready to sacrifice myself for my country and you, s..."*)

### Węzeł `[57]`
Mówca: **Boy**
> "“I am ready to sacrifice myself for my country and you, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Player: "“This is nonsense. What are you teaching to these students?”"*)
  - -> `[58]` (*Player: "“Good. You will make a fine soldier in the future. At eas..."*)
  - -> `[60]` (*Player: "“I will do whatever I can to not let that happen.”"*)

### Węzeł `[58]`
**[WYBÓR GRACZA: "“Good. You will make a fine soldier in the future. At ease, general!”"]** — Mówca: **Player**
> "“Good. You will make a fine soldier in the future. At ease, general!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Boy)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Boy: "“Thank you, sir!”"*)

### Węzeł `[59]`
**[WYBÓR GRACZA: "“This is nonsense. What are you teaching to these students?”"]** — Mówca: **Player**
> "“This is nonsense. What are you teaching to these students?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Boy)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Narrator: "The principal looked extremely surprised."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: "“I will do whatever I can to not let that happen.”"]** — Mówca: **Player**
> "“I will do whatever I can to not let that happen.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[57]` (Boy)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Boy: "“Thank you, sir!”"*)

### Węzeł `[61]`
Mówca: **Principal**
> "“Was it not to your liking? I'm so sorry, Mr. President.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The cameras flashed."*)

### Węzeł `[62]`
Mówca: **Narrator**
> "The principal looked extremely surprised."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Principal: "“Was it not to your liking? I'm so sorry, Mr. President.“"*)

### Węzeł `[63]`
Mówca: **Narrator**
> "The principal squeezed his son's shoulders and the boy looked up and smiled to his father. He patted him on the back and sent him off to his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Narrator: "The cameras flashed."*)

### Węzeł `[64]`
Mówca: **Boy**
> "“Thank you, sir!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Narrator: "The principal squeezed his son's shoulders and the boy lo..."*)

### Węzeł `[65]`
Mówca: **Ciara Walda**
> "“This is simply ridiculous. You are raising soldiers here, not students!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Principal: "“I am so sorry. I will immediately perform disciplinary a..."*)

### Węzeł `[66]`
Mówca: **Principal**
> "“I am so sorry. I will immediately perform disciplinary actions.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Ciara Walda: "“How about you, young lady? What do you think about this?”"*)

### Węzeł `[67]`
Mówca: **Ciara Walda**
> "“How about you, young lady? What do you think about this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Principal: "“She is our top student in this school. Her excellent gra..."*)

### Węzeł `[68]`
Mówca: **Principal**
> "“She is our top student in this school. Her excellent grades are to--.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Ciara Walda: "“I didn't ask you.""*)

### Węzeł `[69]`
Mówca: **Ciara Walda**
> "“I didn't ask you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Narrator: "She bent down and gently addressed the young student."*)

### Węzeł `[70]`
Mówca: **Girl**
> "“I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Girl: "“I'm sick of having to knit and sew while the boys learn ..."*)

### Węzeł `[71]`
Mówca: **Girl**
> "“I'm sick of having to knit and sew while the boys learn science and chemistry. I'm smarter than all of them. Why do I have to take these stupid handcraft classes?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Principal: "“Ssssh! Do you know who you are talki-“"*)

### Węzeł `[72]`
Mówca: **Principal**
> "“Ssssh! Do you know who you are talki-“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Ciara Walda: "“Shut up. Let her speak.”"*)

### Węzeł `[73]`
Mówca: **Ciara Walda**
> "“Shut up. Let her speak.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Narrator: "Ciara's presence had emboldened the girl. She went on."*)

### Węzeł `[74]`
Mówca: **Girl**
> "“My math and reading scores are the best in the school. But they won't let me take the classes I want, just because I'm a girl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Girl: ""I want to be a scientist! Not some soldier's wife!""*)

### Węzeł `[75]`
Mówca: **Girl**
> ""I want to be a scientist! Not some soldier's wife!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: "“You heard her, Mr. Principal. You will make the necessar..."*)
  - -> `[77]` (*Player: "“But knitting and sewing are important skills to have for..."*)
  - -> `[81]` (*Player: "“We need more people like you in this country. I applaud ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: "“You heard her, Mr. Principal. You will make the necessary changes. At once.”"]** — Mówca: **Player**
> "“You heard her, Mr. Principal. You will make the necessary changes. At once.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Principal: "“As you wish, sir. At once.“"*)

### Węzeł `[77]`
**[WYBÓR GRACZA: "“But knitting and sewing are important skills to have for a woman.”"]** — Mówca: **Player**
> "“But knitting and sewing are important skills to have for a woman.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Narrator: "Ciara's eyes were shooting daggers at me. She looked back..."*)

### Węzeł `[78]`
Mówca: **Narrator**
> "Ciara's eyes were shooting daggers at me. She looked back at the girl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Ciara Walda: "“Don't worry. We will talk in private later, okay?”"*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> "“I will personally check back and ensure that the changes are made.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Principal: "“Yes, sir.“"*)

### Węzeł `[80]`
Mówca: **Principal**
> "“As you wish, sir. At once.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: "“I will personally check back and ensure that the changes..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: "“We need more people like you in this country. I applaud your determination.”"]** — Mówca: **Player**
> "“We need more people like you in this country. I applaud your determination.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Girl)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Ciara Walda: "“We need more than words. We need action.”"*)

### Węzeł `[82]`
Mówca: **Ciara Walda**
> "“Don't worry. We will talk in private later, okay?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Girl: "“Okay.”"*)

### Węzeł `[83]`
Mówca: **Principal**
> "“Yes, sir.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[84]`
Mówca: **Ciara Walda**
> "“We need more than words. We need action.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Ciara Walda: "“Concrete action. We need to protect girls like this.”"*)

### Węzeł `[85]`
Mówca: **Girl**
> "“Okay.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[86]`
Mówca: **Lucian Galade**
> "“Well then. Unfortunately we are almost out of time. We have other meetings to attend to today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: "“Thank you for the warm welcome.”"*)

### Węzeł `[87]`
Mówca: **Ciara Walda**
> "“Concrete action. We need to protect girls like this.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Narrator: "The cameras flashed once again."*)

### Węzeł `[88]`
Mówca: **Narrator**
> "The cameras flashed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Ciara Walda: "“This is simply ridiculous. You are raising soldiers here..."*)

### Węzeł `[89]`
Mówca: **Narrator**
> "The cameras flashed once again."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Narrator: "I looked around the classroom and saw a large portrait of..."*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> "“Thank you for the warm welcome.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Ciara Walda: "“Mr. President. Lucian. Please go ahead. I would like to ..."*)

### Węzeł `[91]`
**[WYBÓR GRACZA: "“Very well.”"]** — Mówca: **Player**
> "“Very well.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Principal: "“Thank you for visiting our school, sir.“"*)

### Węzeł `[92]`
**[WYBÓR GRACZA: "“Lucian. Let's leave.”"]** — Mówca: **Player**
> "“Lucian. Let's leave.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Principal: "“Thank you for visiting our school, sir.“"*)

### Węzeł `[93]`
**[WYBÓR GRACZA: "“Thank you for the tour.”"]** — Mówca: **Player**
> "“Thank you for the tour.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Ciara Walda)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Principal: "“Thank you for visiting our school, sir.“"*)

### Węzeł `[94]`
Mówca: **Ciara Walda**
> "“Mr. President. Lucian. Please go ahead. I would like to speak with the girl alone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Player: "“Very well.”"*)
  - -> `[92]` (*Player: "“Lucian. Let's leave.”"*)
  - -> `[93]` (*Player: "“Thank you for the tour.”"*)

### Węzeł `[95]`
Mówca: **Principal**
> "“Thank you for visiting our school, sir.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Principal: "“Come on class. One. Two.“"*)

### Węzeł `[96]`
Mówca: **Principal**
> "“Come on class. One. Two.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Narrator: "All students in the classroom yelled but the boy whom I m..."*)

### Węzeł `[97]`
Mówca: **Boy**
> "“A Morgna wes core!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Player_Italic: "Leave."*)
  - -> `[116]` (*Player: "“Vectern sis da!”"*)

### Węzeł `[98]`
Mówca: **Narrator**
> "All students in the classroom yelled but the boy whom I met was the loudest."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]` (*Boy: "“A Morgna wes core!”"*)

### Węzeł `[99]`
Mówca: **Narrator**
> "After another round of photos we departed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_SchoolVisit = true"*)

### Węzeł `[100]`
Mówca: **Narrator**
> "I looked around the classroom and saw a large portrait of Colonel Soll."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Player: "“Take that down.”"*)
  - -> `[102]` (*Player_Italic: "Don't say anything."*)
  - -> `[111]` (*Player: "“An excellent portrait of Colonel Soll. Very lifelike.”"*)

### Węzeł `[101]`
**[WYBÓR GRACZA: "“Take that down.”"]** — Mówca: **Player**
> "“Take that down.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Sollist -= 1; BaseGame.Public_Opinion -= 1;"*)

### Węzeł `[102]`
**[WYBÓR GRACZA: "Don't say anything."]** — Mówca: **Player_Italic**
> "I didn't say anything."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“Well then. Unfortunately we are almost out of time. We h..."*)

### Węzeł `[103]`
Mówca: **Principal**
> "“But, sir. That's a portrait of Colonel Soll. We can't just take it down.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Player: "“Lucian. Do it.”"*)
  - -> `[104]` (*Player: "“Don't make me repeat my words.”"*)
  - -> `[106]` (*Player: "“I gave you an order.”"*)

### Węzeł `[104]`
**[WYBÓR GRACZA: "“Don't make me repeat my words.”"]** — Mówca: **Player**
> "“Don't make me repeat my words.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "The principal reluctantly took the portrait down."*)

### Węzeł `[105]`
**[WYBÓR GRACZA: "“Lucian. Do it.”"]** — Mówca: **Player**
> "“Lucian. Do it.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "Lucian took the frame down and gave it to the principal."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: "“I gave you an order.”"]** — Mówca: **Player**
> "“I gave you an order.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[103]` (Principal)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "The principal reluctantly took the portrait down."*)

### Węzeł `[107]`
Mówca: **Narrator**
> "Even the reporters looked confused for a minute, before taking many photos of the portrait being taken down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Narrator: "Ciara was smiling and when she realised I was looking at ..."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "Lucian took the frame down and gave it to the principal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Even the reporters looked confused for a minute, before t..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "The principal reluctantly took the portrait down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Narrator: "Even the reporters looked confused for a minute, before t..."*)

### Węzeł `[110]`
Mówca: **Narrator**
> "Ciara was smiling and when she realised I was looking at her, she nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“Well then. Unfortunately we are almost out of time. We h..."*)

### Węzeł `[111]`
**[WYBÓR GRACZA: "“An excellent portrait of Colonel Soll. Very lifelike.”"]** — Mówca: **Player**
> "“An excellent portrait of Colonel Soll. Very lifelike.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[100]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Principal: "“Thank you.“"*)

### Węzeł `[112]`
Mówca: **Principal**
> "“Thank you.“"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Lucian Galade: "“Well then. Unfortunately we are almost out of time. We h..."*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Sollist -= 1;
BaseGame.Public_Opinion -= 1;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Sollist"] = Variable["BaseGame.Sollist"] - 1;
Variable["BaseGame.Public_Opinion"] = Variable["BaseGame.Public_Opinion"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait = true"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Principal: "“But, sir. That's a portrait of Colonel Soll. We can't ju..."*)

### Węzeł `[115]`
**[WYBÓR GRACZA: "Leave."]** — Mówca: **Player_Italic**
> "I left the classroom."
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Boy)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "After another round of photos we departed."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: "“Vectern sis da!”"]** — Mówca: **Player**
> "“Vectern sis da!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Boy)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Narrator: "After another round of photos we departed."*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_SchoolVisit = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_SchoolVisit"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == ..."*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == ..."*)
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait =..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_PSnW_SchoolVisit_TookDownSollPortrait"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Media_SordlandToday_Bias == true"*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Media_SordlandToday_Bias == true)"*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Media_SordlandToday_Bias == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Media_SordlandToday_Bias == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_ST_SollPortrait_NoDeal = true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Path == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Path == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Path == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_SollPortrait_A = true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Path == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_SollPortrait = true"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_SollPortrait_A = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_SollPortrait_A"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY"*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_SollPortrait = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_SollPortrait"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY"*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_Bluds == true"*)
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)"*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_Bluds == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_DeyrLockdown = true"*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_Bluds == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_Bluds"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The prestigious Toren Hill School was situated close to t..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_DeyrLockdown = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_DeyrLockdown"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Narrator: "The prestigious Toren Hill School was situated close to t..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_RY"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_RY)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_RY`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_RYArrested = true"*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_RY)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_RY"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS"*)
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Banned_YS)"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Banned_YS`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"]`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_LT_YSArrested = true"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Banned_YS)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Banned_YS"]) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_PrayerLanguageBill = true;..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_RYArrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_RYArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahle..."*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_LT_YSArrested = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_LT_YSArrested"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_HP_PrayerLanguageBill = true;..."*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_HP_PrayerLanguageBill = true; BaseGameSupport.FactionReport_Turn04_CSP_CritiqueMeftiemITZ = true;
BaseGameSupport.News_Turn04_G_QinalBlamesPMCs = true;
BaseGameSupport.Report_Turn04_Erlory_GiraltUnveilsWine = true;
BaseGameSupport.News_Turn04_ST_GiraltWineReveal = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_HP_PrayerLanguageBill"] = true;
Variable["BaseGameSupport.FactionReport_Turn04_CSP_CritiqueMeftiemITZ"] = true;
Variable["BaseGameSupport.News_Turn04_G_QinalBlamesPMCs"] = true;
Variable["BaseGameSupport.Report_Turn04_Erlory_GiraltUnveilsWine"] = true;
Variable["BaseGameSupport.News_Turn04_ST_GiraltWineReveal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == t..."*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)

### Węzeł `[146]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)

### Węzeł `[147]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudget"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)
  - -> `[150]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == tr..."*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_Banned..."*)

### Węzeł `[150]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_SuspendedProtests == true && BaseGame.Turn02_InT_Corporation_TaurusHolding == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_SuspendedProtests"] == true  and  Variable["BaseGame.Turn02_InT_Corporation_TaurusHolding"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_BannedProtests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_R_WorkersRights_Vetoed_BannedProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true"*)
  - -> `[154]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)"*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_EmergencyDecree_Embargo_Rumburg == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_EmergencyDecree_Embargo_Rumburg"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_PSnW_SchoolVisit = true"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn04_Holsord_RumburgEmbargo"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn04_PSnW_SchoolVisit = true"*)

### Węzeł `[156]`
Mówca: **Principal**
> "“Education is the premise of progress, in all societies, in all families.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]` (*Narrator: "We walked through the gates. There were many students lin..."*)

### Węzeł `[157]`
Mówca: **Narrator**
> "At the entrance, the school's motto was inscribed on the wall in giant letters. “Instreten sis er Anginicar av Gereigna, int olla Almergwolltene, int olla Mexis.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Principal: "“Education is the premise of progress, in all societies, ..."*)

### Węzeł `[158]`
Mówca: **Narrator**
> "Ciara bristled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Ciara Walda: "“Up to a point, perhaps. Look at these kids.”"*)

### Węzeł `[159]`
Mówca: **Narrator**
> "She bent down and gently addressed the young student."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]` (*Ciara Walda: "“What do you think about your school? Just between us gir..."*)

### Węzeł `[160]`
Mówca: **Ciara Walda**
> "“What do you think about your school? Just between us girls.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Girl: "“I-”"*)

### Węzeł `[161]`
Mówca: **Narrator**
> "Ciara's presence had emboldened the girl. She went on."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Girl: "“My math and reading scores are the best in the school. B..."*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Increased == true"*)
  - -> `[164]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)"*)

### Węzeł `[163]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Increased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_IncreasedPoliceBudg..."*)

### Węzeł `[164]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Increased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Increased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true"*)

### Węzeł `[165]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn04_SnO_LE_Interior_Decreased == true"*)
  - -> `[167]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true)"*)

### Węzeł `[166]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn04_SnO_LE_Interior_Decreased == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn04_Holsord_DecreasedPoliceBudg..."*)

### Węzeł `[167]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn04_SnO_LE_Interior_Decreased == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn04_SnO_LE_Interior_Decreased"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_SuspendedProtests == true..."*)

### Węzeł `[168]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler = false; BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler_BanRY = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler"] = false;
Variable["BaseGameSupport.Codex_Characters_PartyLeaders_DenisStahler_BanRY"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_EmergencyDecree_Banned_YS"*)

### Węzeł `[169]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `PlaySoundEffect("SingNationalAnthem");`
- **Efekt skryptowy (`userScript`):** `PlaySoundEffect("SingNationalAnthem");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Narrator: "As we entered the students started singing the national a..."*)

### Węzeł `[170]`
Mówca: **Narrator**
> "The principal proudly looked at them."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]` (*Principal: "“Marvelous, my dear students.”"*)

### Węzeł `[171]`
Mówca: **Principal**
> "“Marvelous, my dear students.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Narrator: "After the anthem finished. All of the students immediatel..."*)

### Węzeł `[172]`
Mówca: **Narrator**
> "We walked through the gates. There were many students lined up in front of the stairs of the main building."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]` (*Węzeł Logiki Narracyjnej: "PlaySoundEffect("SingNationalAnthem");"*)

### Węzeł `[173]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[174]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true"*)
  - -> `[176]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)"*)

### Węzeł `[175]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Energy_PriceBalance = true;"*)

### Węzeł `[176]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceBalanced == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceBalanced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)

### Węzeł `[177]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]` (*Węzeł Logiki Narracyjnej: "BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true"*)
  - -> `[179]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation ==..."*)

### Węzeł `[178]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations = ..."*)

### Węzeł `[179]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Situation_Diplomacy_Energy_PriceFluctuation == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Situation_Diplomacy_Energy_PriceFluctuation"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn04_E_Energy_PriceSurge = true;"*)

### Węzeł `[180]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Energy_PriceBalance = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceBalance"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[181]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceFluctuations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)

### Węzeł `[182]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn04_E_Energy_PriceSurge = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn04_E_Energy_PriceSurge"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn03_EnT_LawEnforcement_Budget_Increase == true"*)
