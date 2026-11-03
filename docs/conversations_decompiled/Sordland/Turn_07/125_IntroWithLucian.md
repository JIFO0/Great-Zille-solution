# Sordland/Turn07/IntroWithLucian

- **ID konwersacji:** `125`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 07`
- **Lokalizacja pliku:** `Sordland/Turn_07/125_IntroWithLucian.md`
- **Liczba węzłów dialogowych:** 124
- **Liczba wyborów gracza:** 28

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[10]** Narrator
- **[38]** Lucian Galade

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Decision_Turn05_AutocratEmergency_Extend`
- `BaseGame.Decision_Turn06_Megaproject_Benfi`
- `BaseGame.Decision_Turn06_Megaproject_Conriat`
- `BaseGame.Decision_Turn06_Megaproject_Morna`
- `BaseGame.Decision_Turn06_Megaproject_Sarna`
- `BaseGame.Reform_Autocrat_CourtVote_Success`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Reform_Court_Success`

### Modyfikowane zmienne stanu (`userScript`):
- *Brak modyfikowanych zmiennych.*

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[4]`
- Węzeł `[5]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[11]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[13]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[62]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[63]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`
- Węzeł `[95]` -> **[115] Sordland/Turn07/A_ResultsMeeting** (../Turn_07/115_A_ResultsMeeting.md), Węzeł `[3]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 4

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[120]` (Paskal Beniwoll): `UpdateProgress("Progress_InternationalAirport", 50); -- Updates token effect progress to the give...`
- Węzeł `[121]` (Paskal Beniwoll): `UpdateProgress("Progress_IndustrialZone", 50); -- Updates token effect progress to the given valu...`
- Węzeł `[122]` (Paskal Beniwoll): `UpdateProgress("Progress_SeaPort", 50); -- Updates token effect progress to the given value in PE...`
- Węzeł `[123]` (Paskal Beniwoll): `UpdateProgress("Progress_AgriculturalZone", 50); -- Updates token effect progress to the given va...`

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
  - -> `[71]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[4]`

### Węzeł `[3]`
Mówca: **Lucian Galade**
> ""Especially all that lobbying work. But it's nothing to break me down, sir. Trust me, I'm fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[4]`
**[WYBÓR GRACZA: ""Anything you want to say before we go in?""]** — Mówca: **Player**
> ""Anything you want to say before we go in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[6]`
**[WYBÓR GRACZA: ""Thank you, Lucian. You look tired. How are you holding up?""]** — Mówca: **Player**
> ""Thank you, Lucian. You look tired. How are you holding up?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: ""I couldn't have done it without you.""]** — Mówca: **Player**
> ""I couldn't have done it without you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[8]`
Mówca: **Lucian Galade**
> ""It's nothing, sir. I am ready and able as always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`
  - -> `[12]`
  - -> `[14]`

### Węzeł `[9]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[10]`
**[WYBÓR GRACZA: ""Good to know. I need you at your full potential.""]** — Mówca: **Player**
> ""Good to know. I need you at your full potential.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[12]`
**[WYBÓR GRACZA: ""I hope so, Lucian. I can't have my team get worn out at a time like this.""]** — Mówca: **Player**
> ""I hope so, Lucian. I can't have my team get worn out at a time like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[13]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""Are you sure? You can be honest with me.""]** — Mówca: **Player**
> ""Are you sure? You can be honest with me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""I'm always honest with you, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[18]`
Mówca: **Lucian Galade**
> ""Of course, sir. I'll be doing my best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[4]`

### Węzeł `[19]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Mr. Vice President must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[20]`
Mówca: **Lucian Galade**
> ""Please sir, don't be like that. You'll get through this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Reform_Court_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Reform_Court_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Reform_Court_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Reform_Court_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Vice President Vectern must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[25]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Mr. Vice President must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[26]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[28]`

### Węzeł `[27]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""No, sir. Just keep your cool with the cabinet. I believe concerns will be raised in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[90]`
  - -> `[77]`

### Węzeł `[30]`
Mówca: **Lucian Galade**
> ""I can't let them bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`
  - -> `[33]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[33]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[35]`
Mówca: **Lucian Galade**
> ""No, sir. Everything is under control. But I'm sure the ministers will raise their concerns at the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[58]`
  - -> `[57]`

### Węzeł `[36]`
Mówca: **Narrator**
> "He gestured at the door with the files he held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[37]`
Mówca: **Lucian Galade**
> ""There's not much to say, sir. We should find a way to restrain the Supreme Court from impeaching you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[39]`
Mówca: **Lucian Galade**
> ""I have already been doing my best to find ways around it. Please stay composed and do not worry.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`
  - -> `[84]`
  - -> `[83]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""Thank you, Lucian.""]** — Mówca: **Player**
> ""Thank you, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""It is an emergency... What do they expect?""]** — Mówca: **Player**
> ""It is an emergency... What do they expect?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""]** — Mówca: **Player**
> ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""I'll admit, this last year was tough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Autocrat_Path == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Autocrat_Path"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Autocrat_Path == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Autocrat_Path"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[48]`
Mówca: **Narrator**
> "He stared down at the floor for a few seconds and then gestured at the door with the files he held."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Especially all that work with the Old Guard. But it's nothing to break me down, sir. Trust me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[50]`
**[WYBÓR GRACZA: ""We need their trust. We have to do something to prove our capabilities.""]** — Mówca: **Player**
> ""We need their trust. We have to do something to prove our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""Alright. Let's go to the meeting and hear these concerns out.""]** — Mówca: **Player**
> ""Alright. Let's go to the meeting and hear these concerns out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[52]`
Mówca: **Narrator**
> "He fixed his tie."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[4]`

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Some Sollists have also been nagging our ministers about the short-lived state of emergency, which they believe has only worsened the situation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[79]`
  - -> `[69]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""I'm afraid we're trapped. Our future is up to the Old Guard now.""]** — Mówca: **Player**
> ""I'm afraid we're trapped. Our future is up to the Old Guard now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Alright. Let's get on with this meeting then.""]** — Mówca: **Player**
> ""Alright. Let's get on with this meeting then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[56]`
**[WYBÓR GRACZA: ""We will resist, Lucian. Don't you worry. Nothing will happen to us.""]** — Mówca: **Player**
> ""We will resist, Lucian. Don't you worry. Nothing will happen to us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Alright, let's go in and hear them out.""]** — Mówca: **Player**
> ""Alright, let's go in and hear them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Concerns? It doesn't sound like everything is under control.""]** — Mówca: **Player**
> ""Concerns? It doesn't sound like everything is under control.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[60]`
Mówca: **Lucian Galade**
> ""Thank you for your trust in me. However, this is a very important matter, sir. I cannot take it easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[61]`
Mówca: **Lucian Galade**
> ""Such radical changes towards the end of our term is not advised, sir. But we could talk about these in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[62]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[64]`
Mówca: **Lucian Galade**
> ""Our failure of the reforms had a huge impact on public opinion. And also on some of the ministers, from the looks of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[65]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's discuss that in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""The cabinet has gathered in the White Room, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I'm ready. Let's go.""]** — Mówca: **Player**
> ""I'm ready. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[68]`
Mówca: **Lucian Galade**
> ""The Vice President will be opening the session soon. We can go in whenever you're ready.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[4]`
  - -> `[6]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""]** — Mówca: **Player**
> ""They don't even have the guts to face me. If the party doesn't fall in line, we must consider radical changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""The party is quite discontent about the whole situation. They believe your presidency has destroyed the USP's prestige.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[51]`
  - -> `[42]`

### Węzeł `[71]`
Mówca: **Narrator**
> "Lucian stood upright, holding a large folder of files under his arm. He bowed in acknowledgement."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""You already knew and expected this, I presume. I just wanted to give you a heads up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[79]`
  - -> `[69]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""We need their trust. We have to do something to prove our capabilities.""]** — Mówca: **Player**
> ""We need their trust. We have to do something to prove our capabilities.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""No, sir. I don't believe there's anything we didn't expect. However, our failure of the reforms had a huge impact on public opinion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[75]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[76]`
Mówca: **Lucian Galade**
> ""I only want to congratulate you again, sir. You wrote history.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[7]`
  - -> `[81]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""Alright, let's go in and hear them out.""]** — Mówca: **Player**
> ""Alright, let's go in and hear them out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Alright. Let's go to the meeting and hear these concerns out.""]** — Mówca: **Player**
> ""Alright. Let's go to the meeting and hear these concerns out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Such radical change towards the end of our term is not advised, sir. But we could talk about this in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We have done it together.""]** — Mówca: **Player**
> ""We have done it together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""But we can't allow them to bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`

### Węzeł `[83]`
**[WYBÓR GRACZA: ""Do you really think they can impeach me?""]** — Mówca: **Player**
> ""Do you really think they can impeach me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[84]`
**[WYBÓR GRACZA: ""It doesn't sound like it's going well.""]** — Mówca: **Player**
> ""It doesn't sound like it's going well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
**[WYBÓR GRACZA: ""I trust you Lucian. Take it easy.""]** — Mówca: **Player**
> ""I trust you Lucian. Take it easy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[86]`
Mówca: **Lucian Galade**
> ""Of course, sir. Let's discuss that in the meeting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
> ""The investigation has already been opened against you, sir. But I'm sure nothing will come out of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
> ""You are right, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
> ""I think we should go, sir. Vice President Vectern must have started the session already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""What concerns?""]** — Mówca: **Player**
> ""What concerns?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[91]`
**[WYBÓR GRACZA: ""What are you saying? Should I be expecting something?""]** — Mówca: **Player**
> ""What are you saying? Should I be expecting something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
> ""No, sir. Thank *you* for reforming the constitution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""They declared that the state of emergency was unlawful, sir. Theoretically, they can do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[94]`
Mówca: **Narrator**
> "He slightly bowed his head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GoToMeeting])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `115` (*Sordland/Turn07/A_ResultsMeeting*), Węzeł `[3]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""The party is quite discontent about the administration since we have not pursued any constitutional reforms. They believe your presidency has destroyed the USP's prestige.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[97]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn05_AutocratEmergency_Extend == true && BaseGame.Reform_Autocrat_CourtVote_Success == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn05_AutocratEmergency_Extend"] == true  and  Variable["BaseGame.Reform_Autocrat_CourtVote_Success"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[100]`
Mówca: **Lucian Galade**
> ""We can't let them bring you down however they like. We must resist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[55]`
  - -> `[54]`

### Węzeł `[101]`
Mówca: **Narrator**
> "He gestured to the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`

### Węzeł `[102]`
Mówca: **Lucian Galade**
> ""There are members of the cabinet that are quite discontent about the state of emergency, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Benfi == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Benfi == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Benfi"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[106]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[107]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[108]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Conriat == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Conriat == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Conriat"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[113]`
Mówca: **Narrator**
> "He looked exhausted."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Morna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Morna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Morna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Decision_Turn06_Megaproject_Sarna == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Decision_Turn06_Megaproject_Sarna == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Decision_Turn06_Megaproject_Sarna"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[120]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_InternationalAirport", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_InternationalAirport", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[121]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_IndustrialZone", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_IndustrialZone", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_SeaPort", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_SeaPort", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: UpdateProgress("Progress_AgriculturalZone", 50);

// Updates token effect progress to the given value in PERCENTAGE(eg: 50%))*
- **Efekt (`userScript`):** `UpdateProgress("Progress_AgriculturalZone", 50);
-- Updates token effect progress to the given value in PERCENTAGE(eg: 50%);`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`
