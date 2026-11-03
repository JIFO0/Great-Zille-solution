# Sordland/Turn04/A_ConvinceGloria

- **ID konwersacji:** `58`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 04`
- **Lokalizacja pliku:** `Sordland/Turn_04/058_A_ConvinceGloria.md`
- **Liczba węzłów dialogowych:** 561
- **Liczba wyborów gracza:** 118

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[34]** Gloria Tory

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Country_Unrest`
- `BaseGame.Media_SordlandToday_Bias`
- `BaseGame.PersonalWealth`
- `BaseGame.Policy_Welfare_EducationPrivatization`
- `BaseGame.Prologue_Party_Congress_Soll`
- `BaseGame.Promise_Diplomacy_East`
- `BaseGame.Reform_Autocrat_Path`
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Gloria_Law_Decrees_Default`
- `BaseGame.Reform_Gloria_Law_Honorary_Default`
- `BaseGame.Reform_Gloria_Law_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Threshold_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Default`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Ministers_Assembly`
- `BaseGame.Reform_Law_Ministers_ConfidenceVote`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Turn01_EnT_Economy_Planned`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.Reform_Gloria_Convinced`
- `BaseGame.Reform_Gloria_Law_Decrees_Default`
- `BaseGame.Reform_Gloria_Law_Honorary_Default`
- `BaseGame.Reform_Gloria_Law_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Gloria_Law_Threshold_Default`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Reform_Law_Honorary_Abolished`
- `BaseGame.Reform_Law_Honorary_Default`
- `BaseGame.Reform_Law_Honorary_NoImmunity`
- `BaseGame.Reform_Law_Honorary_Presidents`
- `BaseGame.Reform_Law_Impeachment_Assembly`
- `BaseGame.Reform_Law_Impeachment_Default`
- `BaseGame.Reform_Law_Impeachment_Harder`
- `BaseGame.Reform_Law_Impeachment_Removed`
- `BaseGame.Reform_Law_Judges_Impeachment_Assembly`
- `BaseGame.Reform_Law_Judges_Impeachment_Default`
- `BaseGame.Reform_Law_Judges_Impeachment_President`
- `BaseGame.Reform_Law_Threshold_15`
- `BaseGame.Reform_Law_Threshold_3`
- `BaseGame.Reform_Law_Threshold_8`
- `BaseGame.Reform_Law_Threshold_Default`
- `BaseGame.Relations_Gloria_Promise_Justice`
- `BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled`
- `BaseGame.Turn04_P_Monica_Benfi_Speech`
- `BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria`
- `BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria`
- `BaseGameSupport.News_Turn04_ST_BFFCallToNations`
- `BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal`
- `GameCondition.Turn04_A_Convince_Gloria`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 7
- **Węzły modyfikujące stan gry:** 28

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `BaseGame.Reform_Gloria_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Default`
- `BaseGame.Reform_Law_Decrees_Removed`
- `BaseGame.Reform_Law_Decrees_Stronger`
- `BaseGame.Reform_Law_Decrees_Weaker`
- `BaseGame.Relations_Gloria_Promise_Justice`
- `BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[376]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Gloria_Convinced"] = true;`
- Węzeł `[404]` (Paskal Beniwoll): `Variable["BaseGame.Relations_Gloria_Promise_Justice"] = true;`
- Węzeł `[439]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria"] = true;`
- Węzeł `[440]` (Paskal Beniwoll): `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria"] = true;`
- Węzeł `[443]` (Paskal Beniwoll): `Variable["GameCondition.Turn04_A_Convince_Gloria"] = true;`
- Węzeł `[447]` (Paskal Beniwoll): `Variable["BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal"] = true;`
- Węzeł `[457]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- Węzeł `[458]` (Paskal Beniwoll): `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- *...oraz 20 innych węzłów ze skryptami.*

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
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I arrived at the Grand National Assembly, which was only a five-minute drive away from the Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[559]`

### Węzeł `[4]`
Mówca: **Gloria Tory**
> ""Good to see you here, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Narrator**
> "Today, I had a private meeting with Gloria Tory, one of the leading figures of the USP, to get her approval for the proposal. She was also key in reaching 150 signatures to propose the new Constitution, as she had extensive control over our party's conservative and moderate wings."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "As I walked through the corridors of the Grand National Assembly, I was confronted by my memories of the historic building. Despite being a member of Assembly not long ago, it now felt like the distant past."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked into the left wing of the Assembly which currently acted as the quarters of the USP. Gloria's office was the first one inside."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "I knocked on the door and entered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[436]`
  - -> `[437]`
  - -> `[438]`

### Węzeł `[9]`
Mówca: **Narrator**
> "It was a small, neatly organised office. There were small figurines, photos and plants around the place. It had a homey feel, unlike my own Assembly office when I had worked there."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Narrator**
> "On her gesture, I took a seat. The chair was very uncomfortable."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA: ""How are you doing, Mrs. Tory?""]** — Mówca: **Player**
> ""How are you doing, Mrs. Tory?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[12]`
Mówca: **Gloria Tory**
> ""We both know why we are here. You want me to give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[393]`

### Węzeł `[13]`
**[WYBÓR GRACZA: ""I love what you did with the office.""]** — Mówca: **Player**
> ""I love what you did with the office.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[14]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[15]`
Mówca: **Gloria Tory**
> ""I'm fine, Mr. Rayne. How are you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`
  - -> `[19]`
  - -> `[21]`

### Węzeł `[16]`
Mówca: **Gloria Tory**
> ""*A woman's touch* they call it. Like men cannot have a sense of tidiness or style.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[17]`
Mówca: **Gloria Tory**
> ""Anyway, let's keep this simple, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[18]`
Mówca: **Gloria Tory**
> ""...Which might actually be true.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[19]`
**[WYBÓR GRACZA: ""I'm fine too, thank you.""]** — Mówca: **Player**
> ""I'm fine too, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[20]`
**[WYBÓR GRACZA: ""I'm very happy to see you, Mrs. Tory. It's been a while.""]** — Mówca: **Player**
> ""I'm very happy to see you, Mrs. Tory. It's been a while.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[21]`
**[WYBÓR GRACZA: ""As good as I can be.""]** — Mówca: **Player**
> ""As good as I can be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Gloria Tory**
> ""Indeed, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[441]`

### Węzeł `[23]`
Mówca: **Gloria Tory**
> ""That's what we all strive for.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[24]`
**[WYBÓR GRACZA: ""Not as good as you imagine.""]** — Mówca: **Player**
> ""Not as good as you imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[25]`
**[WYBÓR GRACZA: ""It's better, what can I say?""]** — Mówca: **Player**
> ""It's better, what can I say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[26]`
**[WYBÓR GRACZA: ""The chair is fine, but the work that comes with it is insane.""]** — Mówca: **Player**
> ""The chair is fine, but the work that comes with it is insane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Gloria Tory**
> ""Well, you knew about that, didn't you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[28]`
Mówca: **Gloria Tory**
> ""I'm sure it doesn't give you back pains the way ours do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[29]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of the USP would support your rushed reforms. Don't you realize they go directly against the wishes of the founder of this party and the state?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[30]`
**[WYBÓR GRACZA: ""The reforms are not against anyone. It's all in the name of democracy.""]** — Mówca: **Player**
> ""The reforms are not against anyone. It's all in the name of democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[31]`
**[WYBÓR GRACZA: ""Mrs. Tory, I need you to help me here.""]** — Mówca: **Player**
> ""Mrs. Tory, I need you to help me here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[32]`
**[WYBÓR GRACZA: ""My reforms are very critical for the future of Sordland, Mrs. Tory.""]** — Mówca: **Player**
> ""My reforms are very critical for the future of Sordland, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[33]`
Mówca: **Gloria Tory**
> ""In the name of democracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[34]`
Mówca: **Gloria Tory**
> ""You'd like the USP to disintegrate, wouldn't you, Mr. Rayne?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Gloria Tory**
> ""Even though you owe everything to Colonel Soll, I think you never liked him, nor the party he built.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`
  - -> `[123]`

### Węzeł `[36]`
Mówca: **Gloria Tory**
> ""So you want me to help you destroy what our party has worked so hard to build?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[37]`
Mówca: **Gloria Tory**
> ""They are certainly critical for destroying what our party has worked so hard to build.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[38]`
**[WYBÓR GRACZA: ""There is nothing personal about this, Mrs. Tory.""]** — Mówca: **Player**
> ""There is nothing personal about this, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""I would never betray our party.""]** — Mówca: **Player**
> ""I would never betray our party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""How dare you suggest I never liked Soll? I'm a proud Sollist.""]** — Mówca: **Player**
> ""How dare you suggest I never liked Soll? I'm a proud Sollist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[41]`
Mówca: **Gloria Tory**
> ""You claim that, Mr. Rayne, but the Sollists already know who you are working with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Gloria Tory**
> ""Whatever you intend to do, you will be facing quite the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Gloria Tory**
> ""That's all I can say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[49]`

### Węzeł `[44]`
**[WYBÓR GRACZA: ""I'm sure we can make a deal.""]** — Mówca: **Player**
> ""I'm sure we can make a deal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.PersonalWealth >= 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.PersonalWealth"] >= 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.PersonalWealth >= 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.PersonalWealth"] >= 1) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Perhaps I could change your thoughts on the matter...with some well placed investments?""]** — Mówca: **Player**
> ""Perhaps I could change your mind on the matter...with some well placed investments?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
**[WYBÓR GRACZA: ""You must understand that these reforms are a necessity. Let me explain.""]** — Mówca: **Player**
> ""You must understand that these reforms are a necessity. Let me explain.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[50]`
Mówca: **Gloria Tory**
> ""How?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`
  - -> `[52]`
  - -> `[53]`

### Węzeł `[51]`
**[WYBÓR GRACZA: ""We need these reforms to fix our problems with the unrestricted power of the Supreme Court.""]** — Mówca: **Player**
> ""We need these reforms to fix our problems with the unrestricted power of the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[52]`
**[WYBÓR GRACZA: ""The people of Sordland demanded change. The USP must give them what they want. We need the people's support.""]** — Mówca: **Player**
> ""The people of Sordland demanded change. The USP must give them what they want. We need the people's support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[53]`
**[WYBÓR GRACZA: ""The USP is a party that knows how to react in changing times. We must lead the nation into the future.""]** — Mówca: **Player**
> ""The USP is a party that knows how to react in changing times. We must lead the nation into the future.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[54]`
Mówca: **Gloria Tory**
> ""The Supreme Court is already doing what it can to preserve Soll's values.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[55]`
Mówca: **Gloria Tory**
> ""You think you can bribe me, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Gloria Tory**
> ""For your safety, I hope that nobody heard that. The walls here are not as thick as in your palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[49]`

### Węzeł `[57]`
Mówca: **Gloria Tory**
> ""I'm not so sure about that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`
  - -> `[60]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[60]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[61]`
Mówca: **Gloria Tory**
> ""Especially when you're trying to decrease the electoral threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Gloria Tory**
> ""You must know this will mean bringing the communists into the Assembly. You probably have a deal with either them or... maybe the PFJP. Frens seemed to be positive about giving you support too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`
  - -> `[67]`
  - -> `[68]`
  - -> `[70]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[66]`
Mówca: **Gloria Tory**
> ""Especially considering the fact that you're trying to change the Member of Honor laws. This is clearly a move against President Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""I have no deal with anyone.""]** — Mówca: **Player**
> ""I have no deal with anyone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
**[WYBÓR GRACZA: ""You're pointing fingers without even thinking.""]** — Mówca: **Player**
> ""You're pointing fingers without even thinking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[69]`
**[WYBÓR GRACZA: ""The decrease is important to democratize our elections.""]** — Mówca: **Player**
> ""The decrease is important to democratize our elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
**[WYBÓR GRACZA: ""I can reconsider the decrease in the threshold.""]** — Mówca: **Player**
> ""I can reconsider the decrease in the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[71]`
Mówca: **Gloria Tory**
> ""I don't know how your acts can even be justified inside the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[72]`
Mówca: **Gloria Tory**
> ""There is no problem here except the ones you are creating with Mr. Ricter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[73]`
Mówca: **Gloria Tory**
> ""I am aware that our popularity has been on the decline.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[74]`
Mówca: **Gloria Tory**
> ""But I blame it on this administration, Mr. Rayne. Plus, these reforms are not about the people, are they?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[75]`
Mówca: **Gloria Tory**
> ""That's for the party to decide. Not you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[76]`
Mówca: **Gloria Tory**
> ""I seriously do not know if the conservatives would be willing to support you at all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[77]`
Mówca: **Gloria Tory**
> ""Oh, you will *reconsider*?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""Yes, I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Yes, I'll remove the change to the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[79]`
**[WYBÓR GRACZA: ""Will that ensure your support?""]** — Mówca: **Player**
> ""Will that ensure your support?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Gloria Tory**
> ""I don't know what to say before seeing a commitment from you, Mr. Rayne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
**[WYBÓR GRACZA: ""The same goes for me.""]** — Mówca: **Player**
> ""The same goes for me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[82]`
**[WYBÓR GRACZA: ""First I need to know if I'll have your support.""]** — Mówca: **Player**
> ""First I need to know if I'll have your support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[83]`
Mówca: **Gloria Tory**
> ""I don't know if I can promise anything before I see action from you. Especially with all these issues you're creating for the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[84]`
Mówca: **Gloria Tory**
> ""That's a step in the right direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[85]`
Mówca: **Gloria Tory**
> ""I'm sure it isn't. It must be about some other Member of Honor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Very well. I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Very well. I'll remove the change to the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
  - -> `[92]`

### Węzeł `[91]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Gloria Tory**
> ""Decreasing the threshold to 3% is unacceptable. You will be bringing all of the marginal parties into the Assembly and reducing our majority.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Gloria Tory**
> ""I do not support an election threshold of 8%. This sets a dangerous situation for us, as both the WPB and the CPS will gain more power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[95]`
Mówca: **Gloria Tory**
> ""I cannot allow you to destroy our party. Either this point is removed entirely or there will be no discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[97]`
  - -> `[79]`

### Węzeł `[96]`
Mówca: **Gloria Tory**
> ""I'd rather leave the threshold as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[97]`
  - -> `[79]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""That is not up to you, Mrs. Tory. My proposed threshold stays.""]** — Mówca: **Player**
> ""That is not up to you, Mrs. Tory. My proposed threshold stays.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[101]`
Mówca: **Gloria Tory**
> ""All I can promise is that the conservatives will definitely oppose you unless you remove that clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`
  - -> `[103]`

### Węzeł `[102]`
**[WYBÓR GRACZA: ""Fine, I'll remove the change to the threshold." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine, I'll remove the change to the threshold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[457]`

### Węzeł `[103]`
**[WYBÓR GRACZA: ""I cannot promise that.""]** — Mówca: **Player**
> ""I cannot promise that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`
  - -> `[106]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[556]`

### Węzeł `[106]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[107]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GloriaFail)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[294]`

### Węzeł `[108]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[110]`
Mówca: **Gloria Tory**
> ""That's too bad. Yet you still want our support...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true)*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_3"] == false  or  Variable["BaseGame.Reform_Law_Threshold_8"] == false)  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[113]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Threshold_3 == false || BaseGame.Reform_Law_Threshold_8 == false) && 
BaseGame.Reform_Law_Impeachment_Removed == false && BaseGame.Reform_Law_Decrees_Stronger == false && BaseGame.Reform_Law_Judges_Impeachment_Default == true && BaseGame.Reform_Law_Honorary_Default == true
))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Threshold_3"] == false  or  Variable["BaseGame.Reform_Law_Threshold_8"] == false)  and  
Variable["BaseGame.Reform_Law_Impeachment_Removed"] == false  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == false  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == true  and  Variable["BaseGame.Reform_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[114]`
Mówca: **Gloria Tory**
> ""We both know why you are here. You need my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[310]`

### Węzeł `[115]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[118]`
Mówca: **Gloria Tory**
> ""We both know why you are here. You want me to give you my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of this party should support your rushed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[121]`
  - -> `[120]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""These reforms are very critical for the future of Sordland, Mrs. Tory.""]** — Mówca: **Player**
> ""These reforms are very critical for the future of Sordland, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[121]`
**[WYBÓR GRACZA: ""Mrs. Tory, I need you to help me here.""]** — Mówca: **Player**
> ""Mrs. Tory, I need you to help me here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""We need these reforms for our democracy.""]** — Mówca: **Player**
> ""We need these reforms for our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[125]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[126]`
Mówca: **Gloria Tory**
> ""Democracy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[127]`
Mówca: **Gloria Tory**
> ""I don't know if I can be of any help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[128]`
Mówca: **Gloria Tory**
> ""I tend to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[129]`
Mówca: **Gloria Tory**
> ""What you are doing seems more like a move against the Supreme Court.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[130]`
Mówca: **Gloria Tory**
> ""That's what I think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[49]`

### Węzeł `[131]`
Mówca: **Gloria Tory**
> ""There are issues with the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[134]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Gloria Tory**
> ""Let's see if we can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_Default == false || 
BaseGame.Reform_Law_Honorary_Default == false
))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_Default"] == false  or  
Variable["BaseGame.Reform_Law_Honorary_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Gloria Tory**
> ""I do not support this proposal the way it currently stands. But you seem to be willing to talk, so let's talk.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[140]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`
  - -> `[142]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[143]`
Mówca: **Gloria Tory**
> ""...But your changes to the Member of Honor laws are a major obstacle. We obviously can't condone any threats against Colonel Tarquin Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA: ""This is a shame. I was hoping we could work together.""]** — Mówca: **Player**
> ""This is a shame. I was hoping we could work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[145]`
Mówca: **Gloria Tory**
> ""You want to punish him for the aggressive policies he pursued in the past? Is that the intention here? You can't win this fight, Mr. President. Soll built this republic in the midst of blood and chaos. He demands respect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`
  - -> `[144]`
  - -> `[146]`
  - -> `[188]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""I have no intention of putting Colonel Soll on trial.""]** — Mówca: **Player**
> ""I have no intention of putting Colonel Soll on trial.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""This is not about Soll.""]** — Mówca: **Player**
> ""This is not about Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[148]`
Mówca: **Gloria Tory**
> ""You should at least remove the changes to the Member of Honor laws, or there will be no further discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`
  - -> `[151]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true || BaseGame.Reform_Law_Honorary_NoImmunity == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true  or  Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[152]`
Mówca: **Gloria Tory**
> ""You can't just target our founder and expect our support. If this point is not removed, expect a grand opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`
  - -> `[154]`
  - -> `[153]`

### Węzeł `[153]`
**[WYBÓR GRACZA: ""Why are you against all this, Mrs. Tory? I was thinking we could work together.""]** — Mówca: **Player**
> ""Why are you against all this, Mrs. Tory? I was thinking we could work together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[154]`
**[WYBÓR GRACZA: ""This is not about him.""]** — Mówca: **Player**
> ""This is not about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[155]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[156]`
Mówca: **Gloria Tory**
> ""I'm trying my best to work with you, Mr. President. Yet you're not listening to your own party members.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[157]`
Mówca: **Gloria Tory**
> ""So, you're not removing the clause from the proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[502]`
  - -> `[159]`

### Węzeł `[158]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[458]`

### Węzeł `[159]`
**[WYBÓR GRACZA: ""No. We could talk about the other clauses instead.""]** — Mówca: **Player**
> ""No. We could talk about the other clauses instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[160]`
Mówca: **Gloria Tory**
> ""It seems you don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[162]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GloriaDiscussion)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[165]`
Mówca: **Gloria Tory**
> ""Great. Now, we can start talking for real.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`

### Węzeł `[169]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[429]`

### Węzeł `[173]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`
  - -> `[175]`

### Węzeł `[174]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[235]`

### Węzeł `[175]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[176]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_ConfidenceVote == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_ConfidenceVote == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`

### Węzeł `[178]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_ConfidenceVote == true ))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_ConfidenceVote"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[179]`
Mówca: **Gloria Tory**
> ""I must say that I wouldn't have given the Assembly the right to nominate ministers. This can create a lot of problems for future governments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[180]`
Mówca: **Gloria Tory**
> ""I must say that I like the changes regarding the appointment of ministers. That's one positive aspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[183]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Assembly == true || BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[184]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Assembly == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`
  - -> `[186]`

### Węzeł `[185]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Ministers_Assembly == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[186]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Ministers_Assembly == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Ministers_Assembly"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Gloria Tory**
> ""I must say that I expected some sort of a reform regarding the appointment of ministers. I am surprised that you're ignoring the large support behind that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[232]`

### Węzeł `[188]`
**[WYBÓR GRACZA: ""What makes you think that I don't respect him?""]** — Mówca: **Player**
> ""What makes you think that I don't respect him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[201]`

### Węzeł `[189]`
Mówca: **Gloria Tory**
> ""Isn't it? You have promised to reform our government branches, yet your proposal points to another agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[144]`
  - -> `[146]`

### Węzeł `[190]`
Mówca: **Gloria Tory**
> ""Then why are you taking away his title? Why strike against an old man who has fought all his life for our country?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`
  - -> `[208]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[193]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Abolished == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Abolished"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Gloria Tory**
> ""Then why are you taking his immunity away? He isn't even a public figure since he retired from politics. What prompted you to include this in your so called 'democracy' package?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`
  - -> `[207]`
  - -> `[208]`

### Węzeł `[195]`
Mówca: **Gloria Tory**
> ""So was I, Mr. President. I remember when you proudly defended the USP's values. Yet it seems that it was just politics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`
  - -> `[212]`
  - -> `[213]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`
  - -> `[198]`

### Węzeł `[197]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Congress_Soll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Gloria Tory**
> ""Somehow I always knew it wasn't going to happen. I still remember how you backstabbed President Soll in favor of the incompetency of Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[200]`
Mówca: **Gloria Tory**
> ""I expected that you would go this route already.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[223]`
  - -> `[224]`

### Węzeł `[201]`
Mówca: **Gloria Tory**
> ""Are you seriously asking me this, Mr. President? I thought we were talking about *your* proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[202]`

### Węzeł `[202]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`
  - -> `[204]`

### Węzeł `[203]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Prologue_Party_Congress_Soll == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Prologue_Party_Congress_Soll"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[204]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Prologue_Party_Congress_Soll == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Prologue_Party_Congress_Soll"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[205]`

### Węzeł `[205]`
Mówca: **Gloria Tory**
> ""Don't forget that I was there when you backstabbed President Soll in favour of the incompetency of Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[206]`
**[WYBÓR GRACZA: ""The Member of Honor laws are unnecessary and undemocratic. This is not about Soll.""]** — Mówca: **Player**
> ""The Member of Honor laws are unnecessary and undemocratic. This is not about Soll.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[217]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""How about you answer me this: Why did Soll grant himself absolute immunity and protection? What is he scared of?""]** — Mówca: **Player**
> ""How about you answer me this: Why did Soll grant himself absolute immunity and protection? What is he scared of?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[218]`

### Węzeł `[208]`
**[WYBÓR GRACZA: ""Let's calm down. I am here to listen to your concerns.""]** — Mówca: **Player**
> ""Let's calm down. I am here to listen to your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""What are you talking about? There is no *agenda*.""]** — Mówca: **Player**
> ""What are you talking about? There is no *agenda*.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`

### Węzeł `[210]`
Mówca: **Gloria Tory**
> ""Anyway... I am not going to drag this out for any longer. Will you listen to the party or keep pushing your own agenda?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[511]`

### Węzeł `[211]`
**[WYBÓR GRACZA: ""It was different back then.""]** — Mówca: **Player**
> ""It was different back then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[212]`
**[WYBÓR GRACZA: ""Everything is politics, Mrs. Tory. You of all people must know this.""]** — Mówca: **Player**
> ""Everything is politics, Mrs. Tory. You of all people must know this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[213]`
**[WYBÓR GRACZA: ""Let's calm down. I am here to listen to your concerns.""]** — Mówca: **Player**
> ""Let's calm down. I am here to listen to your concerns.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[214]`
Mówca: **Gloria Tory**
> ""Well, I've already stated my concerns, Mr. President. Let's listen to you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[224]`

### Węzeł `[215]`
Mówca: **Gloria Tory**
> ""I know it very well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[224]`

### Węzeł `[216]`
Mówca: **Gloria Tory**
> ""Oh, I'm sure there isn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[222]`
  - -> `[220]`
  - -> `[221]`
  - -> `[224]`

### Węzeł `[217]`
Mówca: **Gloria Tory**
> ""Soll is the only Member of Honor. This is automatically about him.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`
  - -> `[221]`
  - -> `[224]`

### Węzeł `[218]`
Mówca: **Gloria Tory**
> ""Maybe it was a security mechanism against traitors like...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[219]`
Mówca: **Narrator**
> "She cleared her throat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[220]`
**[WYBÓR GRACZA: ""Look, I promise that we won't touch him. But these ancient laws should be removed.""]** — Mówca: **Player**
> ""Look, I promise that we won't touch him. But these ancient laws should be removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""You win, Mrs. Tory. If this earns me your support, I will remove this point from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You win, Mrs. Tory. If this earns me your support, I will remove this point from the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""Spare me your sarcasm.""]** — Mówca: **Player**
> ""Spare me your sarcasm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Then why are you so surprised?""]** — Mówca: **Player**
> ""Then why are you so surprised?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[224]`
**[WYBÓR GRACZA: ""Come on, let's try to find some common ground.""]** — Mówca: **Player**
> ""Come on, let's try to find some common ground.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`

### Węzeł `[225]`
Mówca: **Gloria Tory**
> ""Fine. Let's talk about your other points.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`

### Węzeł `[226]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""Fine. I'll remove the changes to the Member of Honor laws from the proposal." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. I'll remove the changes to the Member of Honor laws from the proposal.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[459]`

### Węzeł `[228]`
Mówca: **Gloria Tory**
> ""Great. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[229]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[230]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GloriaTalkAboutSoll)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[231]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaTalkAboutSoll])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[232]`
Mówca: **Gloria Tory**
> ""But moving on...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[233]`
Mówca: **Gloria Tory**
> ""It is unbelievable that you are taking away the immunity of the Justices. A big mistake.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[448]`

### Węzeł `[234]`
Mówca: **Gloria Tory**
> ""Even though the Assembly is elected by the people, it does not hold enough judicial insight and neutrality to impeach Justices. The separation of powers shouldn't be damaged.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[235]`
Mówca: **Gloria Tory**
> ""It is also unbelievable that you are strengthening the already powerful presidential decrees. I don't know what your plans are, but I can easily say that I don't like it. This can go in a very bad direction.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[236]`
Mówca: **Gloria Tory**
> ""The fact that you are removing the possibility of your impeachment is not right. Giving yourself absolute immunity while in office is too bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[237]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`
  - -> `[239]`

### Węzeł `[238]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`

### Węzeł `[239]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[424]`

### Węzeł `[240]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`
  - -> `[242]`

### Węzeł `[241]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Removed == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Removed"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[242]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Removed == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Removed"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[243]`
Mówca: **Gloria Tory**
> ""I don't see anything *democratic* here, Mr. President. Can you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[246]`
  - -> `[247]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[244]`
Mówca: **Gloria Tory**
> ""Not to mention that you are removing presidential decrees. I don't know who pressured you into that, but clearly that person has more influence on you than anyone else.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[245]`
Mówca: **Gloria Tory**
> ""On top of all that, you are removing the possibility of your own impeachment. Giving yourself absolute immunity while in office. That's bold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""It seems our understanding of democracy is very different.""]** — Mówca: **Player**
> ""It seems our understanding of democracy is very different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[247]`
**[WYBÓR GRACZA: ""This will benefit the party.""]** — Mówca: **Player**
> ""This will benefit the party.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[248]`
**[WYBÓR GRACZA: ""What I see is a bright future for Sordland. We need to be united.""]** — Mówca: **Player**
> ""What I see is a bright future for Sordland. We need to be united.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[250]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Let's change the topic and discuss how I can make you and the conservatives happy.""]** — Mówca: **Player**
> ""Let's change the topic and discuss how I can make you and the conservatives happy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`

### Węzeł `[250]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`
  - -> `[252]`

### Węzeł `[251]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[252]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[253]`
Mówca: **Gloria Tory**
> ""Who are you kidding? This proposal is designed for your own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[254]`
Mówca: **Gloria Tory**
> ""I continue to disagree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[255]`
Mówca: **Gloria Tory**
> ""Looks like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Gloria Tory**
> ""By listening to our concerns and acting on them? I represent the conservative wing of the party, Mr. President. You should realize that you're not interacting with just one person here.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[257]`

### Węzeł `[257]`
Mówca: **Gloria Tory**
> ""So what are you thinking about? Are you ready to make changes to your proposal or should we keep talking past each other?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[262]`
  - -> `[265]`
  - -> `[258]`

### Węzeł `[258]`
**[WYBÓR GRACZA: ""Mrs. Tory, please try to understand me. I cannot give concessions now.""]** — Mówca: **Player**
> ""Mrs. Tory, please try to understand me. I cannot give concessions now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[259]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[270]`

### Węzeł `[261]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[262]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`
  - -> `[264]`

### Węzeł `[263]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`

### Węzeł `[264]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Gloria_Law_Decrees_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[265]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[266]`
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[267]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[268]`
**[WYBÓR GRACZA: ""I will remove the changes about the impeachment of the presidents." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""I will remove the changes about the impeachment of the presidents.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[462]`

### Węzeł `[269]`
**[WYBÓR GRACZA: ""You're right. I will not strengthen presidential decrees. Let's keep it as it is." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You're right. I will not strengthen presidential decrees. Let's keep it as it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[461]`

### Węzeł `[270]`
**[WYBÓR GRACZA: ""Fine. We will not touch the immunity of the Justices. Let's remove that point." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""Fine. We will not touch the immunity of the Justices. Let's remove that point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[460]`

### Węzeł `[271]`
Mówca: **Gloria Tory**
> ""That is certainly a step in the right direction...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[272]`
Mówca: **Gloria Tory**
> ""Finally. The proposal is starting to make some sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[273]`
Mówca: **Gloria Tory**
> ""Finally. The proposal is starting to make some sense.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[274]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`
  - -> `[276]`

### Węzeł `[275]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[276]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[277]`
Mówca: **Gloria Tory**
> ""...But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[278]`
Mówca: **Gloria Tory**
> ""Let me give you some advice, Mr. President. Giving yourself the same title as Tarquin Soll will not make you a hero. You have not earned that title nor the immunity and the protection it brings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[279]`

### Węzeł `[279]`
Mówca: **Gloria Tory**
> ""Remove the changes to the Member of Honor laws from the proposal before it becomes public. Let's not damage our party nor your reputation further. This will only bring you ridicule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Gloria Tory**
> ""And there is no way that the Assembly or the Supreme Court would vote for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[285]`
  - -> `[286]`
  - -> `[287]`

### Węzeł `[281]`
Mówca: **Gloria Tory**
> ""You know what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[497]`

### Węzeł `[282]`
Mówca: **Narrator**
> "She raised an eyebrow and then took a look at the proposal on her table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[406]`

### Węzeł `[283]`
Mówca: **Narrator**
> "She took a long look at the proposal on her table."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[416]`

### Węzeł `[284]`
Mówca: **Gloria Tory**
> ""You are a stubborn man. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[299]`

### Węzeł `[285]`
**[WYBÓR GRACZA: ""You are right. That is one risky topic. I will remove it." [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You are right. That is one risky topic. I will remove it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[463]`

### Węzeł `[286]`
**[WYBÓR GRACZA: ""You can believe what you will, Mrs. Tory. Just tell me if you will give us support or not.""]** — Mówca: **Player**
> ""You can believe what you will, Mrs. Tory. Just tell me if you will give us support or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[287]`
**[WYBÓR GRACZA: ""You might be right but that will not stop me from trying. I wish you'd join me in this endeavour.""]** — Mówca: **Player**
> ""You might be right but that will not stop me from trying. I wish you'd join me in this endeavour.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[288]`
Mówca: **Gloria Tory**
> ""I'm glad we are on the same page.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[289]`

### Węzeł `[289]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaConvinced])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[290]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaConvinced])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[291]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[296]`

### Węzeł `[293]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[294]`
Mówca: **Gloria Tory**
> ""All right, Mr. President. I'm sorry I won't be able to help you. I wish you luck gathering the signatures you need.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[381]`

### Węzeł `[295]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[296]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[297]`
  - -> `[298]`

### Węzeł `[297]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[405]`

### Węzeł `[298]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`

### Węzeł `[299]`
Mówca: **Gloria Tory**
> ""There is one other way for you to gain my support.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[300]`

### Węzeł `[300]`
Mówca: **Gloria Tory**
> ""Put my name at the top of the list of Supreme Court Justice candidates. In case of a vacancy in the Supreme Court, I want to be appointed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[301]`
  - -> `[302]`
  - -> `[303]`
  - -> `[304]`

### Węzeł `[301]`
**[WYBÓR GRACZA: ""If that's going to assure your support, you have my word.""]** — Mówca: **Player**
> ""If that's going to assure your support, you have my word.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[306]`

### Węzeł `[302]`
**[WYBÓR GRACZA: ""That's it? That's easy. Consider it done.""]** — Mówca: **Player**
> ""That's it? That's easy. Consider it done.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[308]`

### Węzeł `[303]`
**[WYBÓR GRACZA: ""That's a deal, Mrs. Tory. I'll expect your votes in return.""]** — Mówca: **Player**
> ""That's a deal, Mrs. Tory. I'll expect your votes in return.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[307]`

### Węzeł `[304]`
**[WYBÓR GRACZA: ""I can't do that.""]** — Mówca: **Player**
> ""I can't do that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[557]`

### Węzeł `[305]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[306]`
Mówca: **Gloria Tory**
> ""I'll hold you to that promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[307]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[308]`
Mówca: **Gloria Tory**
> ""No need to flaunt, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[404]`

### Węzeł `[309]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaConvinced])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[370]`

### Węzeł `[310]`
Mówca: **Gloria Tory**
> ""I reviewed your proposal in detail. It's a fine draft. Your changes aren't major enough to cause any difficulties.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[311]`
Mówca: **Gloria Tory**
> ""I can get you the signatures needed for the proposal. I'll talk to the other conservatives.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[312]`

### Węzeł `[312]`
Mówca: **Gloria Tory**
> ""I hope there won't be any surprises though, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[313]`
  - -> `[314]`
  - -> `[315]`
  - -> `[316]`

### Węzeł `[313]`
**[WYBÓR GRACZA: ""Glad to hear that, Mrs. Tory.""]** — Mówca: **Player**
> ""Glad to hear that, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[314]`
**[WYBÓR GRACZA: ""What surprises?""]** — Mówca: **Player**
> ""What surprises?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[315]`
**[WYBÓR GRACZA: ""Your lack of faith in me is disappointing.""]** — Mówca: **Player**
> ""Your lack of faith in me is disappointing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[318]`

### Węzeł `[316]`
**[WYBÓR GRACZA: ""I assure you, there is nothing you should be concerned about.""]** — Mówca: **Player**
> ""I assure you, there is nothing you should be concerned about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[317]`

### Węzeł `[317]`
Mówca: **Gloria Tory**
> ""I'll hold you to that promise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[334]`

### Węzeł `[318]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[319]`
  - -> `[320]`

### Węzeł `[319]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[321]`

### Węzeł `[320]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[324]`

### Węzeł `[321]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[322]`
  - -> `[323]`

### Węzeł `[322]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[327]`

### Węzeł `[323]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[330]`

### Węzeł `[324]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, I do not see eye to eye with your other policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[325]`

### Węzeł `[325]`
Mówca: **Gloria Tory**
> ""Especially the continuation of Alphonso's free market reforms...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[326]`

### Węzeł `[326]`
Mówca: **Gloria Tory**
> ""You have seen the recession. It's proven that this experiment doesn't work. But anyway...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[327]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, I do not see eye to eye with your other policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[328]`

### Węzeł `[328]`
Mówca: **Gloria Tory**
> ""Especially your promotion of eastern values. Getting closer to United Contana will definitely create huge problems for us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[329]`

### Węzeł `[329]`
Mówca: **Gloria Tory**
> ""I hope you are not going to follow through with that idea to the end. Flirting with the Malenyevists will only bring us trouble.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[330]`
Mówca: **Gloria Tory**
> ""We have to calculate every possibility, Mr. President. After all, this is Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[331]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[332]`
  - -> `[333]`

### Węzeł `[332]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Promise_Diplomacy_East == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Promise_Diplomacy_East"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[338]`

### Węzeł `[333]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Promise_Diplomacy_East == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Promise_Diplomacy_East"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[334]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[335]`
  - -> `[336]`

### Węzeł `[335]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[331]`

### Węzeł `[336]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[337]`

### Węzeł `[337]`
Mówca: **Gloria Tory**
> ""I just hope you won't continue Alphonso's destruction of the country with your economic policies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[338]`
Mówca: **Gloria Tory**
> ""I just hope you won't flirt with the Malenyevists. Your promotion of eastern values was troubling.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[339]`

### Węzeł `[339]`
Mówca: **Gloria Tory**
> ""Of course, I can't guarantee that all the conservatives of the party will vote for your constitutional changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[558]`

### Węzeł `[340]`
Mówca: **Gloria Tory**
> ""That will depend to some extent on your policies. But the signatures, at least, are as good as gathered.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[343]`
  - -> `[342]`
  - -> `[341]`

### Węzeł `[341]`
**[WYBÓR GRACZA: ""Signatures are not enough. We'll need all the votes from the USP.""]** — Mówca: **Player**
> ""Signatures are not enough. We'll need all the votes from the USP.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[344]`

### Węzeł `[342]`
**[WYBÓR GRACZA: ""Which policies make you concerned?""]** — Mówca: **Player**
> ""Which policies make you concerned?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[343]`
**[WYBÓR GRACZA: ""Thank you.""]** — Mówca: **Player**
> ""Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[346]`

### Węzeł `[344]`
Mówca: **Gloria Tory**
> ""Well, that's politics for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[345]`

### Węzeł `[345]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[347]`

### Węzeł `[346]`
Mówca: **Narrator**
> "She smiled and nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[356]`

### Węzeł `[347]`
Mówca: **Gloria Tory**
> ""I'll do what I can.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[357]`

### Węzeł `[348]`
Mówca: **Gloria Tory**
> ""I am completely against your efforts to privatize our educational institutions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[352]`

### Węzeł `[349]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationPrivatization == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[350]`
  - -> `[351]`

### Węzeł `[350]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Policy_Welfare_EducationPrivatization == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[348]`

### Węzeł `[351]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Policy_Welfare_EducationPrivatization == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Policy_Welfare_EducationPrivatization"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[353]`

### Węzeł `[352]`
Mówca: **Gloria Tory**
> ""The State must be responsible for educating its citizens. Your reform will corrupt our education system and bring foreign influence...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[354]`

### Węzeł `[353]`
Mówca: **Gloria Tory**
> ""I am concerned about the Oligarchs and the state of our economy. I am worried that they may influence you for their own benefit.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[355]`

### Węzeł `[354]`
Mówca: **Gloria Tory**
> ""But we'll discuss that later. What we expect from you is not to pursue further privatization. If you start privatizing health care or state-owned corporations, I doubt I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`

### Węzeł `[355]`
Mówca: **Gloria Tory**
> ""We expect you to succeed where Alphonso failed in resisting their siren call. If you start privatizing health care or state-owned corporations, I doubt I can help you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[358]`
  - -> `[359]`
  - -> `[360]`
  - -> `[361]`

### Węzeł `[356]`
Mówca: **Gloria Tory**
> ""Before we finish...There is one thing I need to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[357]`
Mówca: **Gloria Tory**
> ""Before we finish... There is one thing I need to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[349]`

### Węzeł `[358]`
**[WYBÓR GRACZA: ""Don't worry. That won't happen.""]** — Mówca: **Player**
> ""Don't worry. That won't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[368]`

### Węzeł `[359]`
**[WYBÓR GRACZA: ""I can't promise anything. These decisions depend on the circumstances.""]** — Mówca: **Player**
> ""I can't promise anything. These decisions depend on the circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[360]`
**[WYBÓR GRACZA: ""I am not Alphonso.""]** — Mówca: **Player**
> ""I am not Alphonso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[364]`

### Węzeł `[361]`
**[WYBÓR GRACZA: ""It will happen one way or another.""]** — Mówca: **Player**
> ""It will happen one way or another.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[362]`

### Węzeł `[362]`
Mówca: **Gloria Tory**
> ""For the sake of your reforms, you'd better hope that it doesn't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[363]`
Mówca: **Gloria Tory**
> ""I know. That's why I want to see you succeed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[364]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[365]`
  - -> `[366]`

### Węzeł `[365]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn01_EnT_Economy_Planned == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[363]`

### Węzeł `[366]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn01_EnT_Economy_Planned == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn01_EnT_Economy_Planned"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[367]`

### Węzeł `[367]`
Mówca: **Gloria Tory**
> ""Yes. Different names, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[368]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[371]`

### Węzeł `[369]`
Mówca: **Gloria Tory**
> ""I believe I can give you the help you require.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[423]`

### Węzeł `[370]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GloriaConvinced)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[369]`

### Węzeł `[371]`
Mówca: **Narrator**
> "She stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[372]`

### Węzeł `[372]`
Mówca: **Gloria Tory**
> ""I believe I've made myself clear. Thanks for stopping by, Mr. President. I hope you'll hold your promises.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[373]`

### Węzeł `[373]`
Mówca: **Narrator**
> "She extended her hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[374]`

### Węzeł `[374]`
Mówca: **Narrator**
> "Once I shook her hand, she immediately sat back down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[376]`

### Węzeł `[375]`
Mówca: **Gloria Tory**
> ""But now I need to get back to my duties. If you'll excuse me, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[378]`
  - -> `[379]`
  - -> `[377]`

### Węzeł `[376]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Convinced"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[375]`

### Węzeł `[377]`
**[WYBÓR GRACZA: ""I'll be expecting your wing's support, Mrs. Tory.""]** — Mówca: **Player**
> ""I'll be expecting your wing's support, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[378]`
**[WYBÓR GRACZA: ""I understand. I'll leave you to it.""]** — Mówca: **Player**
> ""I understand. I'll leave you to it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[379]`
**[WYBÓR GRACZA: ""Goodbye, Mrs. Tory. Thank you.""]** — Mówca: **Player**
> ""Goodbye, Mrs. Tory. Thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[380]`

### Węzeł `[380]`
Mówca: **Narrator**
> "She only responded with a nod as I left her office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[434]`

### Węzeł `[381]`
Mówca: **Narrator**
> "She suddenly stood up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[382]`

### Węzeł `[382]`
Mówca: **Gloria Tory**
> ""I must get back to work. Thanks for stopping by, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[383]`

### Węzeł `[383]`
Mówca: **Narrator**
> "She extended her hand to me for a handshake."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[384]`
  - -> `[385]`
  - -> `[386]`
  - -> `[387]`

### Węzeł `[384]`
**[WYBÓR GRACZA: "Shake her hand."]** — Mówca: **Player_Italic**
> "I stood up and shook her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[390]`

### Węzeł `[385]`
**[WYBÓR GRACZA: "Walk away without shaking her hand."]** — Mówca: **Player_Italic**
> "I stood up and walked away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[389]`

### Węzeł `[386]`
**[WYBÓR GRACZA: ""I am not finished.""]** — Mówca: **Player**
> ""I am not finished.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[387]`
**[WYBÓR GRACZA: ""I'm not going anywhere until you give me the signatures.""]** — Mówca: **Player**
> ""I'm not going anywhere until you give me the signatures.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[388]`

### Węzeł `[388]`
Mówca: **Gloria Tory**
> ""Please do not humiliate yourself further, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[398]`
  - -> `[397]`
  - -> `[399]`

### Węzeł `[389]`
Mówca: **Gloria Tory**
> ""What happened to manners?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[391]`

### Węzeł `[390]`
Mówca: **Gloria Tory**
> ""This doesn't mean we won't be able to cooperate on other matters. I hope to speak again soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[391]`
Mówca: **Gloria Tory**
> ""Suit yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[392]`
Mówca: **Narrator**
> "I left her room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[401]`

### Węzeł `[393]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[394]`
  - -> `[395]`

### Węzeł `[394]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[396]`

### Węzeł `[395]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[396]`
Mówca: **Gloria Tory**
> ""I don't see why the backbone of this party should support your rushed reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`
  - -> `[31]`
  - -> `[32]`

### Węzeł `[397]`
**[WYBÓR GRACZA: ""You will give me the signatures. I don't care if it's willingly or not.""]** — Mówca: **Player**
> ""You will give me the signatures. I don't care if it's willingly or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[398]`
**[WYBÓR GRACZA: ""Don't forget who you are talking to.""]** — Mówca: **Player**
> ""Don't forget who you are talking to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[400]`

### Węzeł `[399]`
**[WYBÓR GRACZA: ""Goodbye.""]** — Mówca: **Player**
> ""Goodbye.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[400]`
Mówca: **Gloria Tory**
> ""I'd rather not reply to that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[392]`

### Węzeł `[401]`
Mówca: **Narrator**
> "Albin and the reformist wing was my last hope to get the needed 150 signatures for the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[402]`

### Węzeł `[402]`
Mówca: **Narrator**
> "Even then, it looked quite uncertain if we could get 166 votes in the Assembly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[403]`

### Węzeł `[403]`
Mówca: **Narrator**
> "I went outside. Serge drove me back to the palace, where I met Lucian and told him the bad news."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[439]`

### Węzeł `[404]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Gloria_Promise_Justice = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Relations_Gloria_Promise_Justice"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[309]`

### Węzeł `[405]`
Mówca: **Gloria Tory**
> ""My conscience doesn't allow me to help the spread of Malenyevism.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[295]`

### Węzeł `[406]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[407]`
  - -> `[408]`

### Węzeł `[407]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[408]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Decrees_Stronger == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Decrees_Stronger"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[413]`

### Węzeł `[409]`
Mówca: **Gloria Tory**
> ""Then there will be no further discussion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[262]`
  - -> `[265]`
  - -> `[410]`

### Węzeł `[410]`
**[WYBÓR GRACZA: ""I can't give you what you want, Mrs. Tory.""]** — Mówca: **Player**
> ""I can't give you what you want, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[412]`

### Węzeł `[411]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[412]`
Mówca: **Gloria Tory**
> ""Too bad. I thought we were close to an arrangement.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[411]`

### Węzeł `[413]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[414]`
  - -> `[415]`

### Węzeł `[414]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[409]`

### Węzeł `[415]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[274]`

### Węzeł `[416]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false))*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[417]`
  - -> `[418]`

### Węzeł `[417]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: (BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false)  and  (Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false)`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[419]`

### Węzeł `[418]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !((BaseGame.Reform_Law_Impeachment_Removed == true && BaseGame.Reform_Gloria_Law_Impeachment_Default == false) && (BaseGame.Reform_Law_Judges_Impeachment_Default == false && BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == false)))*
- **Warunek (`conditionsString`):** `((Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  and  Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == false)  and  (Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false  and  Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == false)) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[419]`
Mówca: **Gloria Tory**
> ""...But not quite enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[422]`

### Węzeł `[420]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GloriaDemandHub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[421]`

### Węzeł `[421]`
Mówca: **Gloria Tory**
> ""I can't support you giving yourself absolute immunity while taking the Court's away. This is unacceptable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`
  - -> `[262]`
  - -> `[265]`
  - -> `[258]`

### Węzeł `[422]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDemandHub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[420]`

### Węzeł `[423]`
Mówca: **Narrator**
> "She repositioned herself on the chair."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[499]`

### Węzeł `[424]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[425]`
  - -> `[426]`

### Węzeł `[425]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[426]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Impeachment_Removed == true || BaseGame.Reform_Law_Judges_Impeachment_Default == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Impeachment_Removed"] == true  or  Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[427]`

### Węzeł `[427]`
Mówca: **Gloria Tory**
> ""I don't see any real reform here, Mr. President. Do you?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[428]`
  - -> `[247]`
  - -> `[248]`
  - -> `[249]`

### Węzeł `[428]`
**[WYBÓR GRACZA: ""It seems our understanding of reform is very different.""]** — Mówca: **Player**
> ""It seems our understanding of reform is very different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[429]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[430]`
  - -> `[431]`

### Węzeł `[430]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Presidents == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[278]`

### Węzeł `[431]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Honorary_Presidents == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Honorary_Presidents"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[433]`

### Węzeł `[432]`
Mówca: **Gloria Tory**
> ""You know what...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[433]`
Mówca: **Narrator**
> "She took a look at the proposal."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[432]`

### Węzeł `[434]`
Mówca: **Narrator**
> "The conservative side was handled, but to get to the 150 signatures I needed, I would still have to deal with Albin Clavin and the reformist wing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[435]`

### Węzeł `[435]`
Mówca: **Narrator**
> "I went outside. Serge drove me back to the palace, where I met Lucian and told him about the progress I'd made with Gloria."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[440]`

### Węzeł `[436]`
**[WYBÓR GRACZA: ""Good morning, Mrs. Tory.""]** — Mówca: **Player**
> ""Good morning, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[437]`
**[WYBÓR GRACZA: ""Hello Gloria.""]** — Mówca: **Player**
> ""Hello Gloria.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[438]`
**[WYBÓR GRACZA: ""Here I am.""]** — Mówca: **Player**
> ""Here I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[439]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_FailedToConvinceGloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[440]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn04_Reforms_ConvincedGloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[443]`

### Węzeł `[441]`
Mówca: **Narrator**
> "She smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[442]`

### Węzeł `[442]`
Mówca: **Gloria Tory**
> ""So. How does the presidential chair compare to the ones in the Assembly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`
  - -> `[26]`

### Węzeł `[443]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn04_A_Convince_Gloria = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn04_A_Convince_Gloria"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[444]`

### Węzeł `[444]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[445]`
  - -> `[446]`

### Węzeł `[445]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_SordlandToday_Bias"] == true  and 
Variable["BaseGame.Reform_Autocrat_Path"] == false  and 
Variable["BaseGame.Country_Unrest"] <= 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[447]`

### Węzeł `[446]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_SordlandToday_Bias == true &&
BaseGame.Reform_Autocrat_Path == false &&
BaseGame.Country_Unrest <= 0

))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_SordlandToday_Bias"] == true  and 
Variable["BaseGame.Reform_Autocrat_Path"] == false  and 
Variable["BaseGame.Country_Unrest"] <= 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[447]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_RayneStopsUnrest_Deal"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[489]`

### Węzeł `[448]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[449]`
  - -> `[450]`

### Węzeł `[449]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_President == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[454]`

### Węzeł `[450]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Judges_Impeachment_President == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[451]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[452]`
  - -> `[453]`

### Węzeł `[452]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_15 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_15"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[456]`

### Węzeł `[453]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_15 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_15"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[454]`
Mówca: **Gloria Tory**
> ""A President that has the power to impeach Justices will be very dangerous in the future. We shouldn't damage the separation of powers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[455]`

### Węzeł `[455]`
Mówca: **Gloria Tory**
> ""This is something I cannot accept.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[240]`

### Węzeł `[456]`
Mówca: **Gloria Tory**
> ""Increasing the threshold to 15 percent ought to mollify a lot of lifetime USP members. It secures our advantageous position and further consolidates it by leaving other parties out.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[311]`

### Węzeł `[457]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[458]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Honorary_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[459]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Honorary_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[460]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`

### Węzeł `[461]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Decrees_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[462]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[463]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Honorary_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[288]`

### Węzeł `[464]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_3 = false; BaseGame.Reform_Law_Threshold_8 = false; BaseGame.Reform_Law_Threshold_15 = false)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_3"] = false;
Variable["BaseGame.Reform_Law_Threshold_8"] = false;
Variable["BaseGame.Reform_Law_Threshold_15"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[465]`

### Węzeł `[465]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[466]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Threshold_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[467]`
  - -> `[468]`

### Węzeł `[467]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Threshold_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[464]`

### Węzeł `[468]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Law_Threshold_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[471]`

### Węzeł `[469]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[470]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[471]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Honorary_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[472]`
  - -> `[473]`

### Węzeł `[472]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Honorary_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[476]`

### Węzeł `[473]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Law_Honorary_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Honorary_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[474]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Default = true;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[475]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Judges_Impeachment_Assembly = false;
BaseGame.Reform_Law_Judges_Impeachment_President = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Judges_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Judges_Impeachment_President"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[469]`

### Węzeł `[476]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Abolished = false; BaseGame.Reform_Law_Honorary_NoImmunity = false; BaseGame.Reform_Law_Honorary_Presidents = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Honorary_Abolished"] = false;
Variable["BaseGame.Reform_Law_Honorary_NoImmunity"] = false;
Variable["BaseGame.Reform_Law_Honorary_Presidents"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[477]`

### Węzeł `[477]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Honorary_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Honorary_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[480]`

### Węzeł `[478]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Impeachment_Removed = false; BaseGame.Reform_Law_Impeachment_Assembly = false; BaseGame.Reform_Law_Impeachment_Harder = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Impeachment_Removed"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Assembly"] = false;
Variable["BaseGame.Reform_Law_Impeachment_Harder"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[474]`

### Węzeł `[479]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Decrees_Stronger = false; BaseGame.Reform_Law_Decrees_Removed = false; BaseGame.Reform_Law_Decrees_Weaker = false;)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Law_Decrees_Stronger"] = false;
Variable["BaseGame.Reform_Law_Decrees_Removed"] = false;
Variable["BaseGame.Reform_Law_Decrees_Weaker"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[470]`

### Węzeł `[480]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[481]`
  - -> `[482]`

### Węzeł `[481]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[478]`

### Węzeł `[482]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Law_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[486]`

### Węzeł `[483]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[484]`
  - -> `[485]`

### Węzeł `[484]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[475]`

### Węzeł `[485]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Judges_Impeachment_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[486]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Decrees_Default == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[487]`
  - -> `[488]`

### Węzeł `[487]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Decrees_Default == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[479]`

### Węzeł `[488]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Law_Decrees_Default == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Law_Decrees_Default"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[483]`

### Węzeł `[489]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[490]`
  - -> `[491]`

### Węzeł `[490]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Convinced == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Gloria_Convinced"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[466]`

### Węzeł `[491]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Gloria_Convinced == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Gloria_Convinced"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[560]`

### Węzeł `[492]`
Mówca: **Gloria Tory**
> ""The conservatives will be expecting a lot from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[493]`
  - -> `[494]`
  - -> `[496]`

### Węzeł `[493]`
**[WYBÓR GRACZA: ""I will be expecting a lot from conservatives as well.""]** — Mówca: **Player**
> ""I will be expecting a lot from conservatives as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[494]`
**[WYBÓR GRACZA: ""Of course.""]** — Mówca: **Player**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[495]`
Mówca: **Gloria Tory**
> ""Good.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[451]`

### Węzeł `[496]`
**[WYBÓR GRACZA: ""Whatever you need, Mrs. Tory.""]** — Mówca: **Player**
> ""Whatever you need, Mrs. Tory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[495]`

### Węzeł `[497]`
Mówca: **Gloria Tory**
> ""I feel extra generous today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[498]`
Mówca: **Gloria Tory**
> ""Just don't forget, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[492]`

### Węzeł `[499]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[500]`
  - -> `[501]`

### Węzeł `[500]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[519]`

### Węzeł `[501]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn04_P_Monica_Benfi_Speech == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[502]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[503]`
  - -> `[504]`

### Węzeł `[503]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[506]`

### Węzeł `[504]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8 == true || BaseGame.Reform_Law_Threshold_3 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true  or  Variable["BaseGame.Reform_Law_Threshold_3"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[505]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[507]`

### Węzeł `[506]`
**[WYBÓR GRACZA: ""No, this is too important to me. But what if I remove the change to the threshold instead?" [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""No, this is too important to me. But what if I remove the change to the threshold instead?" [CHANGE THE REFORM]"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[505]`

### Węzeł `[507]`
Mówca: **Gloria Tory**
> ""Good. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[508]`

### Węzeł `[508]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[509]`
Mówca: **Gloria Tory**
> ""It seems you don't understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[517]`

### Węzeł `[510]`
**[WYBÓR GRACZA: ""No. We could talk about the other clauses instead.""]** — Mówca: **Player**
> ""No. We could talk about the other clauses instead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[509]`

### Węzeł `[511]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[512]`
  - -> `[513]`

### Węzeł `[512]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Law_Threshold_8 == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Reform_Law_Threshold_8"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[514]`

### Węzeł `[513]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Reform_Law_Threshold_8 == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Reform_Law_Threshold_8"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[510]`

### Węzeł `[514]`
**[WYBÓR GRACZA: ""You win. How about I remove the change to the threshold instead?" [CHANGE THE REFORM]"]** — Mówca: **Player**
> ""You win. How about I remove the change to the threshold instead?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[515]`

### Węzeł `[515]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Reform_Gloria_Law_Threshold_Default = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Reform_Gloria_Law_Threshold_Default"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[518]`

### Węzeł `[516]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaDiscussion])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[517]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[518]`
Mówca: **Gloria Tory**
> ""Good. Now, we can start talking.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[516]`

### Węzeł `[519]`
Mówca: **Gloria Tory**
> ""I do have one condition. I want you to cancel that speech you were planning for your wife at the Benfi Festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[520]`

### Węzeł `[520]`
Mówca: **Gloria Tory**
> ""Mayor Leste is not only popular in Benfi, he's one of the most influential members of the USP's conservative wing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[521]`

### Węzeł `[521]`
Mówca: **Gloria Tory**
> ""We wouldn't want to upset him, would we?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[522]`
  - -> `[523]`
  - -> `[524]`
  - -> `[525]`

### Węzeł `[522]`
**[WYBÓR GRACZA: ""What does he have to do with anything?""]** — Mówca: **Player**
> ""What does he have to do with anything?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[523]`
**[WYBÓR GRACZA: ""I don't care if he's upset.""]** — Mówca: **Player**
> ""I don't care if he's upset.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[524]`
**[WYBÓR GRACZA: ""Mrs. Tory, please. You're being unreasonable.""]** — Mówca: **Player**
> ""Mrs. Tory, please. You're being unreasonable.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[526]`

### Węzeł `[525]`
**[WYBÓR GRACZA: ""Fine. I'll have Monica taken off the schedule and let him speak.""]** — Mówca: **Player**
> ""Fine. I'll have Monica taken off the schedule and let him speak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[528]`

### Węzeł `[526]`
Mówca: **Gloria Tory**
> ""He's not the only person who would be upset, Mr. President. You know that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[527]`

### Węzeł `[527]`
Mówca: **Gloria Tory**
> ""If you want conservative support, you cannot let the First Lady speak in Mr. Leste's stead.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[532]`
  - -> `[536]`

### Węzeł `[528]`
Mówca: **Gloria Tory**
> ""Wonderful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[529]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[530]`

### Węzeł `[530]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [GloriaFail])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[531]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn04_P_Monica_Benfi_Speech = false;
BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.Turn04_P_Monica_Benfi_Speech"] = false;
Variable["BaseGame.Turn04_A_Monica_Benfi_Speech_Cancelled"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[498]`

### Węzeł `[532]`
**[WYBÓR GRACZA: ""No. I won't let my wife down like that.""]** — Mówca: **Player**
> ""No. I won't let my wife down like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[533]`
Mówca: **Gloria Tory**
> ""Tell me, why does she want to do this speech so badly?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[534]`
  - -> `[541]`
  - -> `[543]`

### Węzeł `[534]`
**[WYBÓR GRACZA: ""She wants to give Sordish women a voice.""]** — Mówca: **Player**
> ""She wants to give Sordish women a voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[535]`

### Węzeł `[535]`
Mówca: **Gloria Tory**
> ""So do I. But this is not the way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[536]`
**[WYBÓR GRACZA: ""This isn't about her, it's about women's rights. I thought you'd understand.""]** — Mówca: **Player**
> ""This isn't about her, it's about women's rights. I thought you'd understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[537]`

### Węzeł `[537]`
Mówca: **Gloria Tory**
> ""Believe me, I understand. More than your wife, even.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[533]`

### Węzeł `[538]`
Mówca: **Gloria Tory**
> ""I've spent nearly two decades in this Assembly. I know how real change happens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[539]`

### Węzeł `[539]`
Mówca: **Gloria Tory**
> ""The old conservative men who hold the power in this government will not listen to Mrs. Rayne's speech and suddenly have a change of heart. Rather the opposite.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[545]`

### Węzeł `[540]`
**[WYBÓR GRACZA: ""All right. I'll tell Monica the speech is off.""]** — Mówca: **Player**
> ""All right. I'll tell Monica the speech is off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[553]`

### Węzeł `[541]`
**[WYBÓR GRACZA: ""She wants First Lady to be more than just a ceremonial position.""]** — Mówca: **Player**
> ""She wants First Lady to be more than just a ceremonial position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[542]`

### Węzeł `[542]`
Mówca: **Gloria Tory**
> ""And why should it be? What does your wife know about politics?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[543]`
**[WYBÓR GRACZA: ""Does it matter? She's my wife. If it's important to her, it's important to me.""]** — Mówca: **Player**
> ""Does it matter? She's my wife. If it's important to her, it's important to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[544]`

### Węzeł `[544]`
Mówca: **Gloria Tory**
> ""As important as the change you claim to be fighting for?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[538]`

### Węzeł `[545]`
Mówca: **Gloria Tory**
> ""They'll see a shrill, hectoring housewife who slept with the President for a spot on that stage and is now hopelessly out of her depth.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[546]`
  - -> `[547]`
  - -> `[554]`

### Węzeł `[546]`
**[WYBÓR GRACZA: ""That's unfair. Monica's been campaigning for women's rights since I met her.""]** — Mówca: **Player**
> ""That's unfair. Monica's been campaigning for women's rights since I met her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[548]`

### Węzeł `[547]`
**[WYBÓR GRACZA: ""You might have a point.""]** — Mówca: **Player**
> ""You might have a point.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[548]`
Mówca: **Gloria Tory**
> ""I'm just telling you what others will think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[549]`
Mówca: **Gloria Tory**
> ""Listen, I do believe the status of women could improve during your administration. Your education minister has been gathering ideas for a bill that appears quite promising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[550]`

### Węzeł `[550]`
Mówca: **Gloria Tory**
> ""But you've got to have patience. Having Monica speak now will be detrimental for all of us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[551]`

### Węzeł `[551]`
Mówca: **Gloria Tory**
> ""Just let Mayor Leste have his little moment in the spotlight. His time will be over soon enough.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[540]`
  - -> `[552]`

### Węzeł `[552]`
**[WYBÓR GRACZA: ""No. Monica will speak at the festival.""]** — Mówca: **Player**
> ""No. Monica will speak at the festival.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[529]`

### Węzeł `[553]`
Mówca: **Gloria Tory**
> ""Thank you. Trust me, it's for the best.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[531]`

### Węzeł `[554]`
**[WYBÓR GRACZA: ""You sound bitter. I'm sorry your path to the top wasn't as easy as hers.""]** — Mówca: **Player**
> ""You sound bitter. I'm sorry your path to the top wasn't as easy as hers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[555]`

### Węzeł `[555]`
Mówca: **Gloria Tory**
> ""It wasn't. But that has nothing to do with it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[549]`

### Węzeł `[556]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[557]`
Mówca: **Gloria Tory**
> ""Then we are at an impasse.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[305]`

### Węzeł `[558]`
Mówca: **Gloria Tory**
> ""I have serious reservations about privatizing healthcare or the Sordish State Corporation. The support of my faction can change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[340]`

### Węzeł `[559]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn04_ST_BFFCallToNations = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn04_ST_BFFCallToNations"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[560]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`
