# Sordland/Turn09/Personal_PetrGoesMissing

- **ID konwersacji:** `180`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 09`
- **Lokalizacja pliku:** `Sordland/Turn_09/180_Personal_PetrGoesMissing.md`
- **Liczba węzłów dialogowych:** 294
- **Liczba wyborów gracza:** 93

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[11]** Monica
- **[28]** Evelyn Vectern
- **[38]** Lucian Galade
- **[56]** Karl Greiser

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Fired_KarlGreiser`
- `BaseGame.Media_Censored`
- `BaseGame.Petr_Dead`
- `BaseGame.Relations_Monica_Opinion`
- `BaseGame.Turn08_SecondScandal_PetrForcedResign`
- `BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr`
- `BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway`
- `BaseGameIsolated.Turn09_PetrMissing_CalledKarl`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn09_PetrMissing_CalledKarl`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned`
- `BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern`
- `BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP`
- `BaseGameSupport.Journal_Turn09_Petr_Learned`
- `BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed`
- `BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed`
- `BaseGameSupport.Report_Turn09_Holsord_Petr_Missing`
- `GameCondition.Turn09_Personal_PetrGoesMissing`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 2
- **Węzły modyfikujące stan gry:** 8

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[66]` (Lucian Galade): `Variable["GameCondition.Turn09_Personal_PetrGoesMissing"] = true;`
- Węzeł `[185]` (Lucian Galade): `Variable["BaseGameSupport.Journal_Turn09_Petr_Learned"] = true;`
- Węzeł `[186]` (Lucian Galade): `Variable["BaseGameSupport.Report_Turn09_Holsord_Petr_Missing"] = true;`
- Węzeł `[267]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed"] = true; Variable["BaseGameSuppor...`
- Węzeł `[271]` (Lucian Galade): `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = true; Variable["BaseGam...`
- Węzeł `[275]` (Lucian Galade): `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = true; Variable["BaseGa...`
- Węzeł `[281]` (Lucian Galade): `End();`
- Węzeł `[282]` (Lucian Galade): `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Player)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Lucian Galade)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "Midnight. I was in the living room watching the tail end of a news report when I heard the phone ring."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[4]`
Mówca: **Evelyn Vectern**
> "“Hello. Anton?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
Mówca: **Narrator**
> "I sighed and walked over to the phone, wondering who could be calling me this late."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[6]`
Mówca: **Narrator**
> "I picked it up."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`
  - -> `[8]`

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Hello. Who is this?”"]** — Mówca: **Player**
> "“Hello. Who is this?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Don't you know what time it is?”"]** — Mówca: **Player**
> "“Don't you know what time it is?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[9]`
Mówca: **Evelyn Vectern**
> "“This is Evelyn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Evelyn Vectern**
> "“Sorry for calling so late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`
  - -> `[12]`

### Węzeł `[11]`
**[WYBÓR GRACZA: "“If you wanted to talk to Monica, she's sleeping right now.”"]** — Mówca: **Player**
> "“If you wanted to talk to Monica, she's sleeping right now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[12]`
**[WYBÓR GRACZA: "“Is something wrong?”"]** — Mówca: **Player**
> "“Is something wrong?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[13]`
Mówca: **Evelyn Vectern**
> "“Actually, I was calling for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[14]`
Mówca: **Evelyn Vectern**
> "“Yes. No. I don't know, actually.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`
  - -> `[15]`
  - -> `[16]`

### Węzeł `[15]`
**[WYBÓR GRACZA: "“Can't this wait until the morning?”"]** — Mówca: **Player**
> "“Can't this wait until the morning?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[16]`
**[WYBÓR GRACZA: "“Spit it out, woman. What's going on?”"]** — Mówca: **Player**
> "“Spit it out, woman. What's going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[17]`
**[WYBÓR GRACZA: ""All right. Let's talk.”"]** — Mówca: **Player**
> ""All right. Let's talk.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[18]`
Mówca: **Evelyn Vectern**
> "“I don't think it can. I didn't know who to call.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[19]`
Mówca: **Evelyn Vectern**
> "“The thing is, I was supposed to meet with Petr today to hand him the signed divorce papers.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Evelyn Vectern**
> "“But he didn't come to our designated meeting point. I figured he might have been too drunk to remember, so I went to the apartment he's been renting -- but he wasn't there either.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Evelyn Vectern**
> "“I asked around. The landlord, the neighbors, his friends...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[22]`
Mówca: **Evelyn Vectern**
> "“No one knows where he is.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[23]`
Mówca: **Evelyn Vectern**
> "“Trust me, Anton, I couldn't be more excited to be rid of this man. But I can't close off this chapter of my life without his cooperation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[68]`
  - -> `[69]`

### Węzeł `[24]`
**[WYBÓR GRACZA: "“I'm sure he'll turn up.""]** — Mówca: **Player**
> "“I'm sure he'll turn up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“Get some sleep, Evelyn.”"]** — Mówca: **Player**
> "“Get some sleep, Evelyn.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“Good night.”"]** — Mówca: **Player**
> "“Good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[27]`
Mówca: **Evelyn Vectern**
> "“Goodbye.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[28]`
Mówca: **Narrator**
> "The line dropped."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[29]`
Mówca: **Narrator**
> "As I put down the phone, Monica sleepily approached with a glass of water in her hand."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[30]`
Mówca: **Monica**
> "“Who was that? Is everything all right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`
  - -> `[114]`

### Węzeł `[31]`
**[WYBÓR GRACZA: "“Yes, just a work call. Sorry for waking you up.”"]** — Mówca: **Player**
> "“Yes, just a work call. Sorry for waking you up.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[32]`
**[WYBÓR GRACZA: "“It's fine. Go back to bed.""]** — Mówca: **Player**
> "“It's fine. Go back to bed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[33]`
**[WYBÓR GRACZA: "“It was Evelyn. She said Petr went missing.”"]** — Mówca: **Player**
> "“It was Evelyn. She said Petr went missing.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[34]`
Mówca: **Monica**
> "“Missing? Drowning his sorrows, I wager.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Monica**
> "“I'm surprised she still cares about him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`
  - -> `[37]`
  - -> `[38]`

### Węzeł `[36]`
**[WYBÓR GRACZA: "“She's a middle-aged woman. What kind of a life will she have without a husband?”"]** — Mówca: **Player**
> "“She's a middle-aged woman. What kind of a life will she have without a husband?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[37]`
**[WYBÓR GRACZA: "“She was a good influence on him.”"]** — Mówca: **Player**
> "“She was a good influence on him.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[38]`
**[WYBÓR GRACZA: "“Whatever. Not my problem.”"]** — Mówca: **Player**
> "“Whatever. Not my problem.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
Mówca: **Narrator**
> "Monica looked at me strangely."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[40]`
Mówca: **Monica**
> "“For a while.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Narrator**
> "Monica shrugged."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Narrator**
> "She made her way upstairs."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[43]`
Mówca: **Narrator**
> "She looked at me in confusion and anger."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Monica**
> "“I will.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[45]`
Mówca: **Monica**
> "“Don't worry about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[46]`
**[WYBÓR GRACZA: "Call Karl to ask him about Petr."]** — Mówca: **Player_Italic**
> "I picked up the phone and dialled Karl's number."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[282]`

### Węzeł `[47]`
**[WYBÓR GRACZA: "Go to sleep."]** — Mówca: **Player_Italic**
> "I followed Monica to the bedroom and pulled the covers over my head."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[48]`
**[WYBÓR GRACZA: "Continue watching TV."]** — Mówca: **Player_Italic**
> "I continued to watch TV."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[49]`
Mówca: **Narrator**
> "I went to bed after a few hours."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[50]`
Mówca: **Narrator**
> "I quickly fell asleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[51]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Karl Greiser**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[54]`
**[WYBÓR GRACZA: "“I need you to find someone.”"]** — Mówca: **Player**
> "“I need you to find someone.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[55]`
Mówca: **Karl Greiser**
> "“Not a problem, sir. I only sleep for three fifteen-minute intervals per night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[56]`
Mówca: **Karl Greiser**
> "“What can I do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[57]`
Mówca: **Karl Greiser**
> "“As you wish.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "I heard the faint rustling of a notepad being opened."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Karl Greiser**
> "“Who do you want found, sir?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
**[WYBÓR GRACZA: "“Petr. Petr Vectern. The ex-Vice President.”"]** — Mówca: **Player**
> "“Petr. Petr Vectern. The ex-Vice President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Karl Greiser**
> "“As you command. I will report my findings shortly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Karl Greiser**
> "“Have a good night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""Thank you for your help. As always.""]** — Mówca: **Player**
> ""Thank you for your help. As always.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[64]`
**[WYBÓR GRACZA: "“Very well. I will be waiting.”"]** — Mówca: **Player**
> "“Very well. I will be waiting.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[65]`
Mówca: **Narrator**
> "He hung up. I put away the phone and went down to the bedroom to get some sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[66]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn09_Personal_PetrGoesMissing = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn09_Personal_PetrGoesMissing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[276]`

### Węzeł `[67]`
Mówca: **Narrator**
> "I heard a soft voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[68]`
**[WYBÓR GRACZA: "“He's probably just with some other girl.""]** — Mówca: **Player**
> "“He's probably just with some other girl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
**[WYBÓR GRACZA: "“This isn't my problem.""]** — Mówca: **Player**
> "“This isn't my problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Evelyn Vectern**
> ""I don't know, Anton. He was in bad shape after your press conference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[71]`
Mówca: **Evelyn Vectern**
> ""You forced him to resign rather than admit you couldn't tell your own secretary was a spy. It kind of is your problem, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[72]`
Mówca: **Evelyn Vectern**
> ""Can't you get your police contacts to look into this? Just to be on the safe side?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: ""All right. If it'll give you peace of mind, I will.""]** — Mówca: **Player**
> ""All right. If it'll give you peace of mind, I will.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[74]`
**[WYBÓR GRACZA: ""You're being paranoid, Evelyn. Let's just wait a few more days and see if he turns up.""]** — Mówca: **Player**
> ""You're being paranoid, Evelyn. Let's just wait a few more days and see if he turns up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Evelyn Vectern**
> ""Thanks, Anton. That'd be great.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[279]`

### Węzeł `[76]`
Mówca: **Evelyn Vectern**
> ""You're right. I'll try to relax.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[279]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I knew, by the way. About all his affairs. I'm so sorry I never came to you about it.""]** — Mówca: **Player**
> ""I knew, by the way. About all his affairs. I'm so sorry I never came to you about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[78]`
**[WYBÓR GRACZA: ""I never had any idea he was cheating on you before this, by the way. You know I would've come to you about it.""]** — Mówca: **Player**
> ""I never had any idea he was cheating on you before this, by the way. You know I would've come to you about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[79]`
Mówca: **Evelyn Vectern**
> ""Boys will be boys. Isn't that what they say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[80]`
Mówca: **Narrator**
> "Her voice sounded tired."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[25]`

### Węzeł `[81]`
Mówca: **Evelyn Vectern**
> ""I'm sure you would have.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Opinion < 1)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Opinion"] < 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[84]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Opinion < 1))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Opinion"] < 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[85]`
Mówca: **Monica**
> ""I don't sleep much these days anyway.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""Honestly, probably a pretty fabulous one.""]** — Mówca: **Monica**
> ""Honestly, probably a pretty fabulous one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[87]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`
  - -> `[89]`

### Węzeł `[88]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`

### Węzeł `[89]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]`

### Węzeł `[90]`
Mówca: **Evelyn Vectern**
> ""It's about Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`
  - -> `[93]`

### Węzeł `[92]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[93]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn08_LiviaPetrGone_Excuse_RanAway"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
Mówca: **Evelyn Vectern**
> ""It's been weeks since he and that woman ran away, hasn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
Mówca: **Evelyn Vectern**
> ""I was told I couldn't finalize the divorce until he signs the papers. So I went to the apartment he's been renting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Evelyn Vectern**
> ""He wasn't there. Actually, it looked like nobody had been living there for weeks. I called the housekeeper at his villa in Erlory, and she told me the same thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
Mówca: **Evelyn Vectern**
> ""He's not some sort of escape artist. He's instantly recognizable. And you said you had your best men on the case.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Evelyn Vectern**
> ""Be honest, Anton. What really happened to him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""I-- I don't know. I'll have this looked into at once.""]** — Mówca: **Player**
> ""I-- I don't know. I'll have this looked into at once.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Evelyn. You're being paranoid.""]** — Mówca: **Player**
> ""Evelyn. You're being paranoid.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""Everything I know, I already said at my press conference.""]** — Mówca: **Player**
> ""Everything I know, I already said at my press conference.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[102]`
Mówca: **Evelyn Vectern**
> ""No, I don't think I am.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[103]`
Mówca: **Evelyn Vectern**
> ""Then maybe something else is going on that neither of us know about.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Evelyn Vectern**
> ""I'd appreciate that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Evelyn Vectern**
> ""Honestly, I couldn't be more excited to be rid of the man. But I'll never get closure if I can't track him down.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`
  - -> `[107]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Forget closure! Hit the town! Live a little!""]** — Mówca: **Player**
> ""Forget closure! Hit the town! Live a little!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I understand.""]** — Mówca: **Player**
> ""I understand.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Evelyn Vectern**
> ""That's not how this works, and you know it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[109]`
Mówca: **Evelyn Vectern**
> ""I have a few journalist contacts left over from my Holsord Post days. I'm thinking of asking them to investigate this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""No need to get them involved. I'll do it myself.""]** — Mówca: **Player**
> ""No need to get them involved. I'll do it myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
**[WYBÓR GRACZA: ""That's a great idea. Let me know if they come up with any leads.""]** — Mówca: **Player**
> ""That's a great idea. Let me know if they come up with any leads.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Evelyn Vectern**
> ""All right. Let me know what you can find.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[279]`

### Węzeł `[113]`
Mówca: **Evelyn Vectern**
> ""Of course.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[78]`
  - -> `[279]`

### Węzeł `[114]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[116]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[116]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[117]`
**[WYBÓR GRACZA: ""It was Evelyn. She's got some crackpot theories about what happened to Petr.""]** — Mówca: **Player**
> ""It was Evelyn. She's got some crackpot theories about what happened to Petr.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[118]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`
  - -> `[47]`
  - -> `[48]`

### Węzeł `[120]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[121]`
Mówca: **Narrator**
> "I went to my private study, picked up the phone and called Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[122]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Karl Greiser**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`
  - -> `[125]`
  - -> `[213]`

### Węzeł `[124]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA: "“Evelyn's getting suspicious.”"]** — Mówca: **Player**
> "“Evelyn's getting suspicious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[126]`
Mówca: **Karl Greiser**
> "“What can I do?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`
  - -> `[213]`

### Węzeł `[127]`
Mówca: **Karl Greiser**
> "“Not a problem, sir. I only sleep for three fifteen-minute intervals per night.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[128]`
Mówca: **Karl Greiser**
> ""As we discussed, Mr. Vectern has been well and properly disposed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`
  - -> `[130]`

### Węzeł `[129]`
**[WYBÓR GRACZA: ""Evelyn's going to investigate this, Karl.""]** — Mówca: **Player**
> ""Evelyn's going to investigate this, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[130]`
**[WYBÓR GRACZA: ""I told Evelyn not to investigate this, but I don't know how much longer I can hold her off.""]** — Mówca: **Player**
> ""I told Evelyn not to investigate this, but I don't know how much longer I can hold her off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[131]`
Mówca: **Karl Greiser**
> ""Would you like her to be disposed of as well, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`
  - -> `[133]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""Good lord, no.""]** — Mówca: **Player**
> ""Good lord, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Well, maybe...""]** — Mówca: **Player**
> ""Well, maybe...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[134]`
Mówca: **Karl Greiser**
> ""Frankly, sir, I would advise against it. It would only lead to more unnecessary suspicions.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[135]`
Mówca: **Karl Greiser**
> ""Here's what I would suggest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[136]`
Mówca: **Karl Greiser**
> ""We still have Mr. Vectern's wedding ring and a sample of his handwriting. It would be fairly easy to plant evidence of his death by suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
**[WYBÓR GRACZA: ""That would be much appreciated.""]** — Mówca: **Player**
> ""That would be much appreciated.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
**[WYBÓR GRACZA: ""What are you waiting for? Get on it!""]** — Mówca: **Player**
> ""What are you waiting for? Get on it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[139]`
Mówca: **Karl Greiser**
> ""I'll begin right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[140]`
Mówca: **Narrator**
> "As I was eating breakfast the next morning, the phone rang."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[215]`

### Węzeł `[141]`
Mówca: **Narrator**
> "I picked up. It was Karl."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Karl Greiser**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[143]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[148]`
  - -> `[147]`

### Węzeł `[145]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[283]`

### Węzeł `[146]`
**[WYBÓR GRACZA: ""Well? Is it done?""]** — Mówca: **Player**
> ""Well? Is it done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[147]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[148]`
**[WYBÓR GRACZA: ""Morning, Karl.""]** — Mówca: **Player**
> ""Morning, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[149]`
**[WYBÓR GRACZA: ""Well? Did you find him?""]** — Mówca: **Player**
> ""Well? Did you find him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[150]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[151]`
**[WYBÓR GRACZA: ""Morning, Karl.""]** — Mówca: **Player**
> ""Morning, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[286]`

### Węzeł `[152]`
Mówca: **Karl Greiser**
> ""I've done what we agreed on, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[153]`
Mówca: **Karl Greiser**
> ""Indeed it is, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[154]`
Mówca: **Karl Greiser**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[155]`
Mówca: **Karl Greiser**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Karl Greiser**
> ""I have some unfortunate news regarding Mr. Vectern.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Karl Greiser**
> ""Not exactly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[158]`
Mówca: **Karl Greiser**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were found on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[159]`
Mówca: **Karl Greiser**
> ""We surmise that he took his own life.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`
  - -> `[174]`
  - -> `[175]`

### Węzeł `[160]`
Mówca: **Karl Greiser**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were planted on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[162]`
  - -> `[163]`

### Węzeł `[161]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Do you think Evelyn will be convinced?""]** — Mówca: **Player**
> ""Do you think Evelyn will be convinced?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[163]`
**[WYBÓR GRACZA: ""Good job.""]** — Mówca: **Player**
> ""Good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[164]`
Mówca: **Karl Greiser**
> ""The man was obviously in an unstable state before. I don't think it's a stretch of the imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[165]`
Mówca: **Karl Greiser**
> ""We kept it vague. Asking forgiveness from you and Evelyn, that sort of thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[166]`
Mówca: **Karl Greiser**
> ""Just carrying out my duty, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`
  - -> `[168]`

### Węzeł `[167]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[168]`
**[WYBÓR GRACZA: ""I'll tell Evelyn the news. Thanks again for your help and discretion.""]** — Mówca: **Player**
> ""I'll tell Evelyn the news. Thanks again for your help and discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[169]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[170]`
Mówca: **Karl Greiser**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started mentally rehearsing what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[172]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started mentally rehearsing what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[173]`
**[WYBÓR GRACZA: ""No! Not Petr!""]** — Mówca: **Player**
> ""No! Not Petr!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[174]`
**[WYBÓR GRACZA: ""Oh, no. I was afraid of that.""]** — Mówca: **Player**
> ""Oh, no. I was afraid of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[175]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`

### Węzeł `[176]`
Mówca: **Karl Greiser**
> ""He wished it to be read by Evelyn alone, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[177]`
Mówca: **Karl Greiser**
> ""I'm sorry for your loss, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Karl Greiser**
> ""Would you like to break the news to Mrs. Vectern or should I?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[179]`

### Węzeł `[179]`
**[WYBÓR GRACZA: ""I'll tell Evelyn. Thanks again for your help.""]** — Mówca: **Player**
> ""I'll tell Evelyn. Thanks again for your help.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[180]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[181]`
Mówca: **Karl Greiser**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started thinking about what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[183]`
Mówca: **Narrator**
> "Karl hung up. With a heavy heart, I started thinking about what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[184]`
Mówca: **Karl Greiser**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[185]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Journal_Turn09_Petr_Learned = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Journal_Turn09_Petr_Learned"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[268]`

### Węzeł `[186]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Report_Turn09_Holsord_Petr_Missing = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Report_Turn09_Holsord_Petr_Missing"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[187]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`
  - -> `[189]`

### Węzeł `[188]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[189]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[190]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[193]`
Mówca: **Narrator**
> "I went to my private study, picked up the phone and called Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[194]`
Mówca: **Narrator**
> "The phone rang for only a few seconds."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Lucian Galade**
> "“Yes, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[198]`
  - -> `[212]`

### Węzeł `[196]`
**[WYBÓR GRACZA: "“Sorry for calling this late.”"]** — Mówca: **Player**
> "“Sorry for calling this late.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Lucian Galade**
> "“Not a problem, sir. I sleep next to the phone in case I'm ever needed.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[203]`

### Węzeł `[198]`
**[WYBÓR GRACZA: "“Evelyn's getting suspicious.”"]** — Mówca: **Player**
> "“Evelyn's getting suspicious.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[199]`
Mówca: **Lucian Galade**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[214]`

### Węzeł `[200]`
Mówca: **Lucian Galade**
> ""We still have Petr's wedding ring and a sample of his handwriting. It would be fairly easy for the SSP to plant evidence of his death by suicide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[204]`
  - -> `[202]`

### Węzeł `[201]`
**[WYBÓR GRACZA: ""Well, maybe...""]** — Mówca: **Player**
> ""Well, maybe...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[210]`

### Węzeł `[202]`
**[WYBÓR GRACZA: ""What are you waiting for? Get on it!""]** — Mówca: **Player**
> ""What are you waiting for? Get on it!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[203]`
Mówca: **Lucian Galade**
> "“What's going on?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`
  - -> `[212]`

### Węzeł `[204]`
**[WYBÓR GRACZA: ""Can you ask the new chief?""]** — Mówca: **Player**
> ""Can you ask the new chief?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[205]`
**[WYBÓR GRACZA: ""I told Evelyn not to investigate, but I don't know how much longer I can hold her off.""]** — Mówca: **Player**
> ""I told Evelyn not to investigate, but I don't know how much longer I can hold her off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[206]`
Mówca: **Lucian Galade**
> ""Here's what I would suggest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[200]`

### Węzeł `[207]`
**[WYBÓR GRACZA: ""Good lord, no.""]** — Mówca: **Player**
> ""Good lord, no.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[208]`
Mówca: **Lucian Galade**
> ""The last I knew of it, Mr. Vectern had been well and properly disposed of.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[209]`
  - -> `[205]`

### Węzeł `[209]`
**[WYBÓR GRACZA: ""Not well enough. Evelyn's going to investigate this.""]** — Mówca: **Player**
> ""Not well enough. Evelyn's going to investigate this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[211]`

### Węzeł `[210]`
Mówca: **Lucian Galade**
> ""Frankly, sir, that would only lead to more unnecessary suspicions. And as someone who had to spend a good stretch of his career putting up with Mr. Vectern, I do feel a certain kinship with Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[206]`

### Węzeł `[211]`
Mówca: **Lucian Galade**
> ""I hope you're not suggesting the SSP dispose of her as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[207]`
  - -> `[201]`

### Węzeł `[212]`
**[WYBÓR GRACZA: "“Remember that thing with Petr? Turns out Karl didn't cover his tracks.”"]** — Mówca: **Player**
> "“Remember that thing with Petr? Turns out Karl didn't cover his tracks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[208]`

### Węzeł `[213]`
**[WYBÓR GRACZA: "“Remember that thing with Petr? Turns out you didn't cover your tracks.”"]** — Mówca: **Player**
> "“Remember that thing with Petr? Turns out you didn't cover your tracks.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[214]`
Mówca: **Narrator**
> "He hung up. I put away the phone and went down to the bedroom to get some sleep."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[215]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[216]`
  - -> `[217]`

### Węzeł `[216]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Fired_KarlGreiser == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Fired_KarlGreiser"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[255]`

### Węzeł `[217]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Fired_KarlGreiser == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Fired_KarlGreiser"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[218]`
**[WYBÓR GRACZA: ""I'll tell Evelyn the news. Thanks again for your help and discretion.""]** — Mówca: **Player**
> ""I'll tell Evelyn the news. Thanks again for your help and discretion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[252]`

### Węzeł `[219]`
**[WYBÓR GRACZA: ""He was a prick who didn't deserve you.""]** — Mówca: **Player**
> ""He was a prick who didn't deserve you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[230]`

### Węzeł `[220]`
Mówca: **Lucian Galade**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[221]`
  - -> `[223]`
  - -> `[222]`

### Węzeł `[221]`
**[WYBÓR GRACZA: ""Well? Is it done?""]** — Mówca: **Player**
> ""Well? Is it done?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[231]`

### Węzeł `[222]`
**[WYBÓR GRACZA: ""That was fast.""]** — Mówca: **Player**
> ""That was fast.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[233]`

### Węzeł `[223]`
**[WYBÓR GRACZA: ""Morning, Lucian.""]** — Mówca: **Player**
> ""Morning, Lucian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[229]`

### Węzeł `[224]`
Mówca: **Narrator**
> "Evelyn hung up. With a heavy heart, I started thinking about what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[225]`
**[WYBÓR GRACZA: ""Did you find him?""]** — Mówca: **Player**
> ""Did you find him?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[239]`

### Węzeł `[226]`
**[WYBÓR GRACZA: ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""]** — Mówca: **Player**
> ""Can you call Evelyn and tell her? I'm not sure I'm up to the task.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[253]`

### Węzeł `[227]`
**[WYBÓR GRACZA: ""No! Not Petr!""]** — Mówca: **Player**
> ""No! Not Petr!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[228]`
Mówca: **Evelyn Vectern**
> ""I'm sorry for yours, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[229]`
Mówca: **Lucian Galade**
> ""The SSP has complied with our request, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[230]`
Mówca: **Evelyn Vectern**
> ""Maybe not. But he didn't deserve to go out like this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[263]`

### Węzeł `[231]`
Mówca: **Lucian Galade**
> ""Indeed it is, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[232]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[244]`

### Węzeł `[233]`
Mówca: **Lucian Galade**
> ""Indeed, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[241]`

### Węzeł `[234]`
Mówca: **Lucian Galade**
> ""They kept it vague. Asking forgiveness from you and Evelyn, that sort of thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[218]`

### Węzeł `[235]`
**[WYBÓR GRACZA: ""Oh, no. I was afraid of that.""]** — Mówca: **Player**
> ""Oh, no. I was afraid of that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[238]`

### Węzeł `[236]`
Mówca: **Narrator**
> "Lucian hung up. With a heavy heart, I started mentally rehearsing what I would say to Monica."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[237]`
**[WYBÓR GRACZA: ""I'm so sorry for your loss.""]** — Mówca: **Player**
> ""I'm so sorry for your loss.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[228]`

### Węzeł `[238]`
Mówca: **Evelyn Vectern**
> ""I just can't believe it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[219]`

### Węzeł `[239]`
Mówca: **Evelyn Vectern**
> ""Not exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[240]`
**[WYBÓR GRACZA: ""Morning, Evelyn.""]** — Mówca: **Player**
> ""Morning, Evelyn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[259]`

### Węzeł `[241]`
Mówca: **Lucian Galade**
> ""His wedding ring, a half-empty bottle of pills, and a handwritten note were planted on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[245]`
  - -> `[249]`
  - -> `[250]`

### Węzeł `[242]`
Mówca: **Lucian Galade**
> ""The man was obviously in an unstable state before. I don't think it's a stretch of the imagination.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[218]`

### Węzeł `[243]`
Mówca: **Evelyn Vectern**
> ""A friend of mine in Erlory convinced local police to scour the area. They found Petr's wedding ring along with a half-empty bottle of pills and a handwritten note on a bridge overlooking the Unger River.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[251]`

### Węzeł `[244]`
Mówca: **Evelyn Vectern**
> ""He wanted it to be for my eyes only.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[237]`

### Węzeł `[245]`
**[WYBÓR GRACZA: ""What did the note say?""]** — Mówca: **Player**
> ""What did the note say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[234]`

### Węzeł `[246]`
**[WYBÓR GRACZA: ""Any news?""]** — Mówca: **Player**
> ""Any news?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[260]`

### Węzeł `[247]`
Mówca: **Lucian Galade**
> ""I hope we never have to speak of this again, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[226]`
  - -> `[218]`

### Węzeł `[248]`
Mówca: **Narrator**
> "Lucian hung up. With a heavy heart, I started mentally rehearsing what I would say to Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[249]`
**[WYBÓR GRACZA: ""Do you think Evelyn will be convinced?""]** — Mówca: **Player**
> ""Do you think Evelyn will be convinced?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[242]`

### Węzeł `[250]`
**[WYBÓR GRACZA: ""Good job.""]** — Mówca: **Player**
> ""Good job.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[247]`

### Węzeł `[251]`
Mówca: **Evelyn Vectern**
> ""They think-- they're telling me he...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[262]`

### Węzeł `[252]`
Mówca: **Lucian Galade**
> ""Of course, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[248]`

### Węzeł `[253]`
Mówca: **Lucian Galade**
> ""Right away, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[236]`

### Węzeł `[254]`
Mówca: **Narrator**
> "I picked up. It was Lucian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[220]`

### Węzeł `[255]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[256]`
  - -> `[257]`

### Węzeł `[256]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[254]`

### Węzeł `[257]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[258]`

### Węzeł `[258]`
Mówca: **Narrator**
> "I picked up. It was Evelyn."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[225]`
  - -> `[240]`
  - -> `[246]`

### Węzeł `[259]`
Mówca: **Evelyn Vectern**
> ""Hi again, Anton.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[260]`
Mówca: **Evelyn Vectern**
> ""Unfortunately, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[261]`

### Węzeł `[261]`
Mówca: **Narrator**
> "Evelyn's voice wavered."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[243]`

### Węzeł `[262]`
Mówca: **Narrator**
> "She trailed off."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[227]`
  - -> `[235]`
  - -> `[232]`

### Węzeł `[263]`
Mówca: **Evelyn Vectern**
> ""I need a moment. I'll talk to you soon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[224]`

### Węzeł `[264]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[265]`
  - -> `[266]`

### Węzeł `[265]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Media_Censored == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Media_Censored"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[267]`

### Węzeł `[266]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Media_Censored == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Media_Censored"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[267]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed = true; BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn09_ST_Petr_SuicideConfirmed"] = true;
Variable["BaseGameSupport.News_Turn09_LT_Petr_SuicideConfirmed"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[268]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[269]`
  - -> `[270]`

### Węzeł `[269]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[271]`

### Węzeł `[270]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_SecretState_Kill_Petr"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[272]`

### Węzeł `[271]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Killed"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[272]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[273]`
  - -> `[274]`

### Węzeł `[273]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[275]`

### Węzeł `[274]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrForcedResign == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[275]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide = true;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned = false;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern = false;
BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed = false;

BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP = true;
BaseGameSupport.Codex_Characters_Others_EvelynVectern = false;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Suicide"] = true;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Resigned"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern"] = false;
Variable["BaseGameSupport.Codex_Characters_Cabinet_PetrVectern_Dismissed"] = false;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern_PetrnotVP"] = true;
Variable["BaseGameSupport.Codex_Characters_Others_EvelynVectern"] = false;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[276]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[277]`
  - -> `[278]`

### Węzeł `[277]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Petr_Dead"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[264]`

### Węzeł `[278]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn08_SecondScandal_PetrForcedResign == true || BaseGame.Petr_Dead == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn08_SecondScandal_PetrForcedResign"] == true  or  Variable["BaseGame.Petr_Dead"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[281]`

### Węzeł `[279]`
**[WYBÓR GRACZA: ""I'm sorry about what happened between you two.""]** — Mówca: **Player**
> ""I'm sorry about what happened between you two.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[280]`

### Węzeł `[280]`
Mówca: **Evelyn Vectern**
> ""Thanks, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[281]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[282]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_PetrMissing_CalledKarl = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[283]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[284]`
  - -> `[285]`

### Węzeł `[284]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[151]`
  - -> `[150]`

### Węzeł `[285]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn09_PetrMissing_CalledKarl == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn09_PetrMissing_CalledKarl"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[287]`
  - -> `[288]`
  - -> `[289]`

### Węzeł `[286]`
Mówca: **Karl Greiser**
> ""This isn't easy for me to say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[287]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Hello, Karl.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[288]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[292]`

### Węzeł `[289]`
**[WYBÓR GRACZA]** — Mówca: **Player**
> ""Please tell me you have good news.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[290]`

### Węzeł `[290]`
Mówca: **Karl Greiser**
> ""Unfortunately not, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[291]`
Mówca: **Karl Greiser**
> ""I was contacted last night by Holsord Post journalists asking about the whereabouts of Mr. Vectern. Apparently his ex-wife had been worrying.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[293]`

### Węzeł `[292]`
Mówca: **Karl Greiser**
> ""You may want to sit down, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[291]`

### Węzeł `[293]`
Mówca: **Karl Greiser**
> ""I sent some of my men to investigate, and, well...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
