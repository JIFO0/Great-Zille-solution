# Sordland/Turn02/A_ReformBriefing

- **ID konwersacji:** `14`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Sordland/Turn_02/014_A_ReformBriefing.md`
- **Liczba węzłów dialogowych:** 150
- **Liczba wyborów gracza:** 24

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Bill_Turn01_CampaignFinance_Signed`
- `BaseGame.Prologue_Speech_Democracy_Liberal`
- `BaseGame.Reform_Autocrat_Intention`
- `BaseGame.Reform_Dictator_Intention`
- `BaseGame.Turn01_InT_Investment_Highway`
- `BaseGame.Turn01_InT_Investment_Railway`
- `BaseGame.Turn02_FPnT_Consulate_Retaliate`
- `BaseGame.Turn02_InT_Corporation_SordishState`
- `BaseGame.Turn02_InT_Corporation_UnderhallConstruction`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Autocrat_SetUpMeeting`
- `BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure`
- `BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm`
- `BaseGameSupport.News_Turn02_E_REEPotential`
- `BaseGameSupport.News_Turn02_G_IyotakePlanMixed`
- `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan`
- `BaseGameSupport.News_Turn02_R_GasomJobsRisk`
- `BaseGameSupport.News_Turn02_R_WPBElectoralProtests`
- `BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential`
- `BaseGameSupport.Report_Turn02_Holsord_L1_SSC`
- `BaseGameSupport.Report_Turn02_Holsord_L1_Taurus`
- `BaseGameSupport.Report_Turn02_Holsord_L1_Underhall`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_SSC`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus`
- `BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall`
- `BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter`
- `BaseGameSupport.Report_Turn02_Morbel_NaturePreservation`
- `GameCondition.Turn02_A_ReformBriefing`

### Skoki między-konwersacyjne:
- Węzeł `[57]` -> **[16] Sordland/Turn02/AutocratSection** (../Turn_02/016_AutocratSection.md), Węzeł `[1]`
- Węzeł `[58]` -> **[15] Sordland/Turn02/DictatorSection** (../Turn_02/015_DictatorSection.md), Węzeł `[1]`
- Węzeł `[147]` -> **[17] Sordland/Turn02/ReformistSection** (../Turn_02/017_ReformistSection.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[17]` | **""Are you waiting behind the door to come at the exact right second?""** | `[16]` **Narrator**: "Lucian arrived exactly on the ho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[19]` **Lucian Galade**: ""I'm sorry, sir?"" |
| `[18]` | **""Good afternoon, Lucian.""** | `[16]` **Narrator**: "Lucian arrived exactly on the ho..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Narrator**: "He took a seat on the table and ..." |
| `[20]` | **""Forget it. How are you, today?""** | `[19]` **Lucian Galade**: ""I'm sorry, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Lucian Galade**: ""I'm good, Mr. President. Thanks..." |
| `[21]` | **""You seem to be arriving at the exact second all our meetings start.""** | `[19]` **Lucian Galade**: ""I'm sorry, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Lucian Galade**: ""Punctuality is important for me..." |
| `[26]` | **""How does it look?""** | `[24]` **Lucian Galade**: ""We should begin the meeting as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[29]` **Lucian Galade**: ""Well, the situation is quite co..." |
| `[27]` | **""What results?""** | `[24]` **Lucian Galade**: ""We should begin the meeting as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Lucian Galade**: ""The reform committee already dr..." |
| `[28]` | **""Good.""** | `[24]` **Lucian Galade**: ""We should begin the meeting as ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[33]` **Narrator**: "A few minutes later, Petr and Ni..." |
| `[39]` | **""What's that supposed to mean?""** | `[36]` **Nia Morgna**: ""We are making clear progress he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "She leaned slightly towards me." |
| `[40]` | **""I've already explained my intentions.""** | `[36]` **Nia Morgna**: ""We are making clear progress he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "She leaned slightly towards me." |
| `[41]` | **""A final decision hasn't been made yet.""** | `[36]` **Nia Morgna**: ""We are making clear progress he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "She leaned slightly towards me." |
| `[44]` | **""I would.""** | `[36]` **Nia Morgna**: ""We are making clear progress he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[60]` **Narrator**: "She leaned slightly towards me." |
| `[52]` | **""With all due respect, I'll be the judge of that.""** | `[50]` **Nia Morgna**: ""We worked hard to create a draf..."<br>`[51]` **Nia Morgna**: ""With all due respect, you shoul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Petr cut in before Nia could speak." |
| `[53]` | **""Thanks for the advice, Mrs. Morgna.""** | `[50]` **Nia Morgna**: ""We worked hard to create a draf..."<br>`[51]` **Nia Morgna**: ""With all due respect, you shoul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Petr cut in before Nia could speak." |
| `[54]` | **""I'll see what we can do.""** | `[50]` **Nia Morgna**: ""We worked hard to create a draf..."<br>`[51]` **Nia Morgna**: ""With all due respect, you shoul..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[59]` **Narrator**: "Petr cut in before Nia could speak." |
| `[66]` | **""Your service is appreciated.""** | `[65]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[67]` | **""If we do this, I promise, you will be kings.""** | `[65]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[68]` | **""Together we will make Sordland great.""** | `[65]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[71]` **Petr Vectern**: ""Yes we will!"" |
| `[69]` | **""Thanks for the meeting, gentlemen.""** | `[65]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""Thank you for your time, sir."" |
| `[76]` | **""Your service is appreciated.""** | `[62]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: ""Thank you for the kind words, s..." |
| `[77]` | **""If we do this, we will be remembered as heroes.""** | `[62]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: ""Yes! The Heroes of Sordland!"" |
| `[78]` | **""Together we will democratize Sordland.""** | `[62]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Nia Morgna**: ""And you have my full support, M..." |
| `[79]` | **""Thanks for the meeting, everybody.""** | `[62]` **Lucian Galade**: ""I think this was yet another fr..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lucian Galade**: ""Thank you for your time, sir."" |
| `[98]` | **""Yes. Set up a meeting with Orso Hawker. We need the Old Guards.""** | `[97]` **Lucian Galade**: ""So, sir, are we scheduling a me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[101]` **Lucian Galade**: ""Yes sir."" |
| `[99]` | **""No. Let him come to me. I am sure he will come begging.""** | `[97]` **Lucian Galade**: ""So, sir, are we scheduling a me..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[100]` **Lucian Galade**: ""Yes... sir."" |

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
  - -> `[10]` (*Narrator: "I came a little early to the meeting room before anybody ..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn02_A_ReformBriefing = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn02_A_ReformBriefing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Retaliate == true"*)

### Węzeł `[4]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true || BaseGame.Re..."*)
  - -> `[6]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Dictator_Intention == true || BaseGame...."*)

### Węzeł `[5]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Dictator_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Nia Morgna: ""Mr. President, I've heard from Mr. Galade that you're no..."*)

### Węzeł `[6]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Dictator_Intention == true || BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Dictator_Intention"] == true  or  Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""Mr. President, our committee meetings were really fruitf..."*)

### Węzeł `[7]`
Mówca: **Nia Morgna**
> ""Mr. President, I've heard from Mr. Galade that you're not intending to support the democratic reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Nia Morgna: ""Our committee meetings have been really fruitful, and we..."*)

### Węzeł `[8]`
Mówca: **Petr Vectern**
> ""There is a lot to talk about the future of this process. Let us begin to tackle the points of contention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Dictator_Intention == true || BaseGame.Re..."*)

### Węzeł `[9]`
Mówca: **Narrator**
> "The reforms were slowly becoming the most significant expectation of my government. We would be changing Soll's Constitution of '29."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "Most people nowadays blamed the constitution for the outs..."*)

### Węzeł `[10]`
Mówca: **Narrator**
> "I came a little early to the meeting room before anybody showed up. We had scheduled a meeting to discuss the progress of the reform committee regarding the new Constitution."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)

### Węzeł `[11]`
Mówca: **Narrator**
> "Most people nowadays blamed the constitution for the outstanding problems of the country."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "On the other hand, the reformists in the Assembly had bee..."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "On the other hand, the reformists in the Assembly had been getting louder about their demands. What I knew for sure was that I needed to do something about this encroaching chaos before it swallowed me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Narrator: "Meanwhile, Lucian, Petr and Nia had been leading the comm..."*)

### Węzeł `[13]`
Mówca: **Narrator**
> "Meanwhile, Lucian, Petr and Nia had been leading the committee to prepare an initial draft for the constitutional amendments. I was intrigued to hear their results."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "There was a knock on the door. It was Lucian."*)

### Węzeł `[14]`
Mówca: **Narrator**
> "There was a knock on the door. It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Lucian Galade: ""Good afternoon, sir.""*)

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Good afternoon, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Narrator: "Lucian arrived exactly on the hour mark again. His punctu..."*)

### Węzeł `[16]`
Mówca: **Narrator**
> "Lucian arrived exactly on the hour mark again. His punctuality could almost be described as obsessive."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Player: ""Good afternoon, Lucian.""*)
  - -> `[17]` (*Player: ""Are you waiting behind the door to come at the exact rig..."*)

### Węzeł `[17]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Are you waiting behind the door to come at the exact right second?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Lucian Galade: ""I'm sorry, sir?""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""Good afternoon, Lucian.""]** — Mówca: **Player**
> ""Good afternoon, Lucian.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He took a seat on the table and took out a bunch of docum..."*)

### Węzeł `[19]`
Mówca: **Lucian Galade**
> ""I'm sorry, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Player: ""Forget it. How are you, today?""*)
  - -> `[21]` (*Player: ""You seem to be arriving at the exact second all our meet..."*)

### Węzeł `[20]`
**[WYBÓR GRACZA: ""Forget it. How are you, today?""]** — Mówca: **Player**
> ""Forget it. How are you, today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""I'm good, Mr. President. Thanks for asking.""*)

### Węzeł `[21]`
**[WYBÓR GRACZA: ""You seem to be arriving at the exact second all our meetings start.""]** — Mówca: **Player**
> ""You seem to be arriving at the exact second all our meetings start.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[19]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""Punctuality is important for me, sir. I'm just doing my ..."*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""Punctuality is important for me, sir. I'm just doing my job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He took a seat on the table and took out a bunch of docum..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""I'm good, Mr. President. Thanks for asking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Narrator: "He took a seat on the table and took out a bunch of docum..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""We should begin the meeting as soon as Mrs. Morgna and Vice President Vectern arrive. We finally have some results from the reform committee.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]` (*Player: ""How does it look?""*)
  - -> `[27]` (*Player: ""What results?""*)
  - -> `[28]` (*Player: ""Good.""*)

### Węzeł `[25]`
Mówca: **Narrator**
> "He took a seat on the table and took out a bunch of documents, spreading them on the long table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""We should begin the meeting as soon as Mrs. Morgna and V..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""How does it look?""]** — Mówca: **Player**
> ""How does it look?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""Well, the situation is quite complicated. But I'm sure w..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""What results?""]** — Mówca: **Player**
> ""What results?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Lucian Galade: ""The reform committee already drafted the amendments for ..."*)

### Węzeł `[28]`
**[WYBÓR GRACZA: ""Good.""]** — Mówca: **Player**
> ""Good.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[24]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "A few minutes later, Petr and Nia also arrived."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""Well, the situation is quite complicated. But I'm sure we will make it work, just like we accomplished many things before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""We'll go over the details regarding the new constitution..."*)

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""The reform committee already drafted the amendments for the new Constitution thanks to the help of the members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""But the situation is still quite complicated politically..."*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""But the situation is still quite complicated politically. We'll go over the details in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "A few minutes later, Petr and Nia also arrived."*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""We'll go over the details regarding the new constitution in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "A few minutes later, Petr and Nia also arrived."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "A few minutes later, Petr and Nia also arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Narrator: "After a short chat, everybody sat down and took out their..."*)

### Węzeł `[34]`
Mówca: **Narrator**
> "After a short chat, everybody sat down and took out their notes. I knew it was going to be a long meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Petr Vectern: ""There is a lot to talk about the future of this process...."*)

### Węzeł `[35]`
Mówca: **Nia Morgna**
> ""Our committee meetings have been really fruitful, and we already started on the constitutional draft together with the feedback from all the political parties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Nia Morgna: ""We are making clear progress here. You wouldn't really b..."*)

### Węzeł `[36]`
Mówca: **Nia Morgna**
> ""We are making clear progress here. You wouldn't really block our hard work, would you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""I've already explained my intentions.""*)
  - -> `[39]` (*Player: ""What's that supposed to mean?""*)
  - -> `[44]` (*Player: ""I would.""*)
  - -> `[41]` (*Player: ""A final decision hasn't been made yet.""*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Mr. President, our committee meetings were really fruitful, and we already started working on the constitutional draft together with the reformists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Nia Morgna: ""They demanded a little too much, but we've had success w..."*)

### Węzeł `[38]`
Mówca: **Nia Morgna**
> ""They demanded a little too much, but we've had success with Frens Ricter to create a realistic draft that could potentially go through the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: ""A *little*? They demanded to rewrite the whole Constitut..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What's that supposed to mean?""]** — Mówca: **Player**
> ""What's that supposed to mean?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "She leaned slightly towards me."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""I've already explained my intentions.""]** — Mówca: **Player**
> ""I've already explained my intentions.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "She leaned slightly towards me."*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""A final decision hasn't been made yet.""]** — Mówca: **Player**
> ""A final decision hasn't been made yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "She leaned slightly towards me."*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""A *little*? They demanded to rewrite the whole Constitution!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Petr Vectern: ""Mr. Ricter's deputy even suggested removing the term 'So..."*)

### Węzeł `[43]`
Mówca: **Nia Morgna**
> ""I also didn't like their theatrics but the requests were definitely not outrageous. They were just not realistic in today's political circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]` (*Nia Morgna: ""Nonetheless, Mr. Vice President, thanks for your convinc..."*)

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I would.""]** — Mówca: **Player**
> ""I would.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[36]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]` (*Narrator: "She leaned slightly towards me."*)

### Węzeł `[45]`
Mówca: **Nia Morgna**
> ""This is our once in a lifetime chance to change the Constitution of Tarquin Soll, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)

### Węzeł `[46]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Węzeł Logiki Narracyjnej: "BaseGame.Prologue_Speech_Democracy_Liberal == true"*)
  - -> `[48]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Prologue_Speech_Democracy_Liberal == true)"*)

### Węzeł `[47]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Prologue_Speech_Democracy_Liberal == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: ""You campaigned to bring real democracy to Sordland.""*)

### Węzeł `[48]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Prologue_Speech_Democracy_Liberal == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Prologue_Speech_Democracy_Liberal"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Nia Morgna: ""We worked hard to create a draft together with the leade..."*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""You campaigned to bring real democracy to Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Nia Morgna: ""With all due respect, you should hold that promise you m..."*)

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""We worked hard to create a draft together with the leaders of our party and the opposition. Nothing else is more important for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""Thanks for the advice, Mrs. Morgna.""*)
  - -> `[52]` (*Player: ""With all due respect, I'll be the judge of that.""*)
  - -> `[54]` (*Player: ""I'll see what we can do.""*)

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""With all due respect, you should hold that promise you made to the Sordish people.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Player: ""Thanks for the advice, Mrs. Morgna.""*)
  - -> `[52]` (*Player: ""With all due respect, I'll be the judge of that.""*)
  - -> `[54]` (*Player: ""I'll see what we can do.""*)

### Węzeł `[52]`
**[WYBÓR GRACZA: ""With all due respect, I'll be the judge of that.""]** — Mówca: **Player**
> ""With all due respect, I'll be the judge of that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Nia Morgna), `[51]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Petr cut in before Nia could speak."*)

### Węzeł `[53]`
**[WYBÓR GRACZA: ""Thanks for the advice, Mrs. Morgna.""]** — Mówca: **Player**
> ""Thanks for the advice, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Nia Morgna), `[51]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Petr cut in before Nia could speak."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'll see what we can do.""]** — Mówca: **Player**
> ""I'll see what we can do.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Nia Morgna), `[51]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Narrator: "Petr cut in before Nia could speak."*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""If I may continue, Mr. President. We've discussed the possibilities of your intentions with Mr. Galade.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_Intention == true"*)
  - -> `[58]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Reform_Autocrat_Intention == true)"*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_Intention == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Intention"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[58]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Reform_Autocrat_Intention == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Intention"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[59]`
Mówca: **Narrator**
> "Petr cut in before Nia could speak."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""If I may continue, Mr. President. We've discussed the po..."*)

### Węzeł `[60]`
Mówca: **Narrator**
> "She leaned slightly towards me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Nia Morgna: ""This is our once in a lifetime chance to change the Cons..."*)

### Węzeł `[61]`
Mówca: **Narrator**
> "I took a seat on the centre chair in the vacant meeting room as I waited for them to show up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Narrator: "The reforms were slowly becoming the most significant exp..."*)

### Węzeł `[62]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]` (*Player: ""Your service is appreciated.""*)
  - -> `[77]` (*Player: ""If we do this, we will be remembered as heroes.""*)
  - -> `[78]` (*Player: ""Together we will democratize Sordland.""*)
  - -> `[79]` (*Player: ""Thanks for the meeting, everybody.""*)

### Węzeł `[63]`
Mówca: **Lucian Galade**
> ""But now we have a better picture of your intentions, sir. I will start reaching out to my contacts to make a draft that works for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Lucian Galade: ""I'll present your input to the USP leaders and the Natio..."*)

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""I'll present your input to the USP leaders and the National Front. In a few months, you would have the draft on your desk to make the final changes yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Lucian Galade: ""I think this was yet another fruitful meeting, sir. I tr..."*)

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""I think this was yet another fruitful meeting, sir. I trust your judgement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Player: ""Your service is appreciated.""*)
  - -> `[67]` (*Player: ""If we do this, I promise, you will be kings.""*)
  - -> `[68]` (*Player: ""Together we will make Sordland great.""*)
  - -> `[69]` (*Player: ""Thanks for the meeting, gentlemen.""*)

### Węzeł `[66]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""If we do this, I promise, you will be kings.""]** — Mówca: **Player**
> ""If we do this, I promise, you will be kings.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[68]`
**[WYBÓR GRACZA: ""Together we will make Sordland great.""]** — Mówca: **Player**
> ""Together we will make Sordland great.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""Yes we will!""*)

### Węzeł `[69]`
**[WYBÓR GRACZA: ""Thanks for the meeting, gentlemen.""]** — Mówca: **Player**
> ""Thanks for the meeting, gentlemen.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[65]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""Thank you for your time, sir.""*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""Thank you, Anton.""*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""Yes we will!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""I'm sure you will lead us to greatness, sir. Thanks for ..."*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: ""You can count on us, Anton.""*)

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""I'm sure you will lead us to greatness, sir. Thanks for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Your service is appreciated.""]** — Mówca: **Player**
> ""Your service is appreciated.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""Thank you for the kind words, sir.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""If we do this, we will be remembered as heroes.""]** — Mówca: **Player**
> ""If we do this, we will be remembered as heroes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: ""Yes! The Heroes of Sordland!""*)

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Together we will democratize Sordland.""]** — Mówca: **Player**
> ""Together we will democratize Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Nia Morgna: ""And you have my full support, Mr. President.""*)

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Thanks for the meeting, everybody.""]** — Mówca: **Player**
> ""Thanks for the meeting, everybody.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[62]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""Thank you for your time, sir.""*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Thank you for the kind words, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""You can count on us, Anton.""*)

### Węzeł `[81]`
Mówca: **Petr Vectern**
> ""Thank you, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Nia Morgna: ""You have my support, Mr. President.""*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""Thank you for your time, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Petr Vectern: ""Thank you, Anton.""*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""You can count on us, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Nia Morgna: ""Yes, Mr. President.""*)

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""And you have my full support, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Petr Vectern: ""Ours too, of course.""*)

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Yes! The Heroes of Sordland!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Narrator: "He laughed."*)

### Węzeł `[86]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[87]`
Mówca: **Nia Morgna**
> ""You have my support, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""Yes, sir. Thank you for your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[89]`
Mówca: **Petr Vectern**
> ""Ours too, of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Lucian Galade: ""Yes, sir. Thank you for your time.""*)

### Węzeł `[90]`
Mówca: **Nia Morgna**
> ""Yes, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I think this is where we'll call it, sir.""*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Lucian Galade: ""Have a good day.""*)

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Narrator: "They left the room."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""I think this is where we'll call it, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""Have a good day.""*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Narrator: "They left the room."*)

### Węzeł `[95]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_ReformBriefing = true"*)

### Węzeł `[96]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_ReformBriefing = true"*)

### Węzeł `[97]`
Mówca: **Lucian Galade**
> ""So, sir, are we scheduling a meeting with Chief Justice Orso Hawker?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Player: ""Yes. Set up a meeting with Orso Hawker. We need the Old ..."*)
  - -> `[99]` (*Player: ""No. Let him come to me. I am sure he will come begging.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""Yes. Set up a meeting with Orso Hawker. We need the Old Guards.""]** — Mówca: **Player**
> ""Yes. Set up a meeting with Orso Hawker. We need the Old Guards.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]` (*Lucian Galade: ""Yes sir.""*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""No. Let him come to me. I am sure he will come begging.""]** — Mówca: **Player**
> ""No. Let him come to me. I am sure he will come begging.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[97]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Lucian Galade: ""Yes... sir.""*)

### Węzeł `[100]`
Mówca: **Lucian Galade**
> ""Yes... sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""We will keep the reform committee working in the meantim..."*)

### Węzeł `[101]`
Mówca: **Lucian Galade**
> ""Yes sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Węzeł Logiki Narracyjnej: "BaseGame.Reform_Autocrat_SetUpMeeting = true"*)

### Węzeł `[102]`
Mówca: **Petr Vectern**
> ""We will keep the reform committee working in the meantime so that it doesn't look like we are completely shutting everything down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Yes, that's important. If we can't cooperate with the Ol..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Yes, that's important. If we can't cooperate with the Old Guards, we could always return to the table.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Narrator: "Lucian grabbed his notes and carefully placed them in his..."*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I think we should get to work, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Petr Vectern: ""Yes. Thanks for the meeting.""*)

### Węzeł `[105]`
Mówca: **Narrator**
> "Lucian grabbed his notes and carefully placed them in his briefcase."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""I think we should get to work, sir.""*)

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""Yes. Thanks for the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: ""Have a good day.""*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Have a good day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Narrator: "They left the room."*)

### Węzeł `[108]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn02_A_ReformBriefing = true"*)

### Węzeł `[109]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Reform_Autocrat_SetUpMeeting = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.Reform_Autocrat_SetUpMeeting"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Petr Vectern: ""We will keep the reform committee working in the meantim..."*)

### Węzeł `[110]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Highway == true"*)
  - -> `[112]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Highway == true)"*)

### Węzeł `[111]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Highway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Highway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[112]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Highway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Highway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[113]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[115]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[114]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)

### Węzeł `[115]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[116]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[118]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[117]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Lachaven_H3_SSC = true"*)

### Węzeł `[118]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[119]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[121]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[120]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall = true"*)

### Węzeł `[121]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus = true"*)

### Węzeł `[122]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)
  - -> `[124]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction =..."*)

### Węzeł `[123]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Holsord_L1_Underhall = true"*)

### Węzeł `[124]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_UnderhallConstruction == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_UnderhallConstruction"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Holsord_L1_Taurus = true"*)

### Węzeł `[125]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_SordishState == true"*)
  - -> `[127]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_InT_Corporation_SordishState == true)"*)

### Węzeł `[126]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_InT_Corporation_SordishState == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Holsord_L1_SSC = true"*)

### Węzeł `[127]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_InT_Corporation_SordishState == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_InT_Corporation_SordishState"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_InT_Corporation_UnderhallConstruction == ..."*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Lachaven_H3_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[129]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[130]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Lachaven_H3_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[131]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Holsord_L1_SSC = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_SSC"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[132]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Holsord_L1_Underhall = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Underhall"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[133]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Holsord_L1_Taurus = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Holsord_L1_Taurus"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Narrator: "I took a seat on the centre chair in the vacant meeting r..."*)

### Węzeł `[134]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn02_FPnT_Consulate_Retaliate == true"*)
  - -> `[136]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn02_FPnT_Consulate_Retaliate == true)"*)

### Węzeł `[135]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn02_FPnT_Consulate_Retaliate == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClos..."*)

### Węzeł `[136]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn02_FPnT_Consulate_Retaliate == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn02_FPnT_Consulate_Retaliate"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[137]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure = true; BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.CountryReport_Turn02_Rumburg_CondemnsClosure"] = true;
Variable["BaseGameSupport.CountryReport_Turn02_Valgsland_UrgesCalm"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)

### Węzeł `[138]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Węzeł Logiki Narracyjnej: "BaseGame.Turn01_InT_Investment_Railway == true"*)
  - -> `[140]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Turn01_InT_Investment_Railway == true)"*)

### Węzeł `[139]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Turn01_InT_Investment_Railway == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Turn01_InT_Investment_Railway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential..."*)

### Węzeł `[140]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Turn01_InT_Investment_Railway == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Turn01_InT_Investment_Railway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[141]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.Report_Turn02_Conriat_IndustrialPotential"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)

### Węzeł `[142]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Węzeł Logiki Narracyjnej: "BaseGame.Bill_Turn01_CampaignFinance_Signed == true"*)
  - -> `[144]` (*Węzeł Logiki Narracyjnej: "!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)"*)

### Węzeł `[143]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.Bill_Turn01_CampaignFinance_Signed == true`
- **Warunek bezpośredni (`conditionsString`):** `Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_R_WPBElectoralProtests = true"*)

### Węzeł `[144]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(BaseGame.Bill_Turn01_CampaignFinance_Signed == true)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["BaseGame.Bill_Turn01_CampaignFinance_Signed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true; ..."*)

### Węzeł `[145]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_R_WPBElectoralProtests = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_R_WPBElectoralProtests"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true; ..."*)

### Węzeł `[146]`
Mówca: **Petr Vectern**
> ""Mr. Ricter's deputy even suggested removing the term 'Sord' from the constitution completely.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Nia Morgna: ""I also didn't like their theatrics but the requests were..."*)

### Węzeł `[147]`
Mówca: **Nia Morgna**
> ""Nonetheless, Mr. Vice President, thanks for your convincing arguments we seem to have reached a common ground already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[148]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[149]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn02_HP_MangerRevealsPlan = true;
BaseGameSupport.News_Turn02_G_IyotakePlanMixed = true;
BaseGameSupport.News_Turn02_E_REEPotential = true;
BaseGameSupport.News_Turn02_R_GasomJobsRisk = true;
BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter = true;
BaseGameSupport.Report_Turn02_Morbel_NaturePreservation = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn02_HP_MangerRevealsPlan"] = true;
Variable["BaseGameSupport.News_Turn02_G_IyotakePlanMixed"] = true;
Variable["BaseGameSupport.News_Turn02_E_REEPotential"] = true;
Variable["BaseGameSupport.News_Turn02_R_GasomJobsRisk"] = true;
Variable["BaseGameSupport.Report_Turn02_Lenkurg_DuruBoatEncounter"] = true;
Variable["BaseGameSupport.Report_Turn02_Morbel_NaturePreservation"] = true;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Węzeł Logiki Narracyjnej: "End();"*)
