# Rizia/Turn 2/Pre-Meeting Talk With Vina Or Estela

- **ID konwersacji:** `297`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/297_Pre-Meeting_Talk_With_Vina_Or_Estela.md`
- **Liczba węzłów dialogowych:** 200
- **Liczba wyborów gracza:** 79

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[64]** Estela Toras
- **[79]** Vina Toras
- **[93]** Player_Romus_Italic *(Gracz)*
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_StayedOnCouncil`
- `RiziaDLC.Vina_OnCouncil`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.LeaningValue_Democratic`
- `RiziaDLC.PersonalValue_Malenyevist`
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_TookBookAway`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[296] Rizia/Turn 2/FPnT_DiplomacyBriefing** (../Turn_02/296_FPnT_DiplomacyBriefing.md), Węzeł `[4]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 12

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Vina`
- `RiziaDLC.Relations_Vina_TookBookAway`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[73]` (Paskal Beniwoll): `RemoveConversant("Estela Toras"); ;`
- Węzeł `[93]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- Węzeł `[95]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- Węzeł `[98]` (Paskal Beniwoll): `RemoveConversant("Vina Toras"); ;`
- Węzeł `[104]` (Paskal Beniwoll): `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- Węzeł `[133]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- Węzeł `[161]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- Węzeł `[171]` (Paskal Beniwoll): `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- *...oraz 4 innych węzłów ze skryptami.*

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
  - -> `[32]`

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `296` (*Rizia/Turn 2/FPnT_DiplomacyBriefing*), Węzeł `[4]`

### Węzeł `[3]`
**[WYBÓR GRACZA: "Talk to Vina."]** — Mówca: **Player_Romus_Italic**
> "I made my way to the stone arch and sat down next to my daughter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[4]`
Mówca: **Estela Toras**
> ""I'm surprised you haven't died of boredom yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`
  - -> `[5]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Got a cigarette?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm discussing the fate of the country. How could I be bored?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's only a matter of time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
Mówca: **Estela Toras**
> ""Is the Grand Wiseman Nurist?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[9]`
Mówca: **Narrator**
> "She lit two cigarettes and handed one to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[10]`
Mówca: **Estela Toras**
> ""The fate of the country depends on tax rates and trade agreements, I see. Wake me when there's a war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[11]`
Mówca: **Estela Toras**
> ""If your uncle was any more pleased with the sound of his own voice, he'd be a parakeet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Estela Toras**
> ""Seriously, I hope you're faring well thus far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[14]`
  - -> `[13]`
  - -> `[38]`

### Węzeł `[13]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Do you trust Hugo?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Did you know about the Golden Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's a lot to take in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[16]`
Mówca: **Estela Toras**
> ""You're asking the wrong person. Don't forget, he positively loathes me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Estela Toras**
> ""Of course, darling. They're a little unnerving at first, but that Titus fellow would take a bullet for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[18]`
Mówca: **Narrator**
> "She stormed off, leaving me to my own thoughts. Before I knew it, it was time for the council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Good to see you outside of the council chambers. Do you have any questions about the past few meetings?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[20]`
Mówca: **Estela Toras**
> ""With that said, he was nothing but loyal to your father. And that loyalty extends to anyone with the last name Toras, personal squabbles aside.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`
  - -> `[27]`

### Węzeł `[21]`
Mówca: **Estela Toras**
> ""Even more so for Vina, I imagine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`
  - -> `[28]`
  - -> `[35]`

### Węzeł `[22]`
Mówca: **Estela Toras**
> ""Now picture your daughter having to fill her head with that drivel. Aren't you glad you kept her off the Council?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`
  - -> `[29]`

### Węzeł `[23]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`
  - -> `[25]`

### Węzeł `[24]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[25]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm relieved to hear that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I wouldn't be so sure, myself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[28]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can tell she's struggling, but she'll learn.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't know. Maybe it would have been a valuable experience.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[30]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I bet you're wishing you'd never asked to come to my meetings, right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[31]`
Mówca: **Vina Toras**
> ""What are you talking about? It's been fascinating!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[32]`
Mówca: **Narrator**
> "To my left, I saw Vina reading a book on a bench beneath a decorative stone arch. In the date palm grove to my right, I caught a glimpse of my mother."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]`
  - -> `[50]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, she's lucky not to have to deal with it all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sorry if Uncle Hugo made you feel uncomfortable the other day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, I'm starting to regret giving in to her.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What's that you've been reading?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[37]`
Mówca: **Estela Toras**
> ""Let's hope it never comes to that. It'd be a waste of a spectacular torso.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[39]`

### Węzeł `[38]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're sitting on so much money. Why didn't Father do anything with it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`

### Węzeł `[39]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Better his than mine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Spectacular? I hadn't noticed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[41]`
Mówca: **Estela Toras**
> ""He was paralyzed at the end. By the weight of all the decisions he had made, and the fear of making a faulty one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[42]`
Mówca: **Estela Toras**
> ""Nearly losing you had a momentous effect on him. On us both.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`
  - -> `[45]`
  - -> `[46]`

### Węzeł `[43]`
Mówca: **Narrator**
> "A bell chimed in the distance. It was time for the meeting to begin."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[44]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I *did* lose my wife. I managed to keep myself together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[45]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I can respect that. I haven't been the same since losing Lena.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And now I've got to pick up all of his slack.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[47]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's keeping up just fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[48]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Listen, I'll give the book back to you. But don't let anyone else catch you reading it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[49]`
**[WYBÓR GRACZA: "Take the book and look at it."]** — Mówca: **Player_Romus_Italic**
> "I snatched the book out of Vina's bag."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[50]`
**[WYBÓR GRACZA: "Talk to your mother."]** — Mówca: **Player_Romus_Italic**
> "I made my way to the palm grove and tapped my mother on the shoulder."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[51]`
Mówca: **Vina Toras**
> ""That's okay. I know he means well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Narrator**
> "She hurriedly shoved the book she was reading into her handbag. On the cover were the words "Ce Faximi" -- "What Are We To Do?" in Rizian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[36]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Vina Toras**
> ""Oh! Greetings, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[57]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Show me that book. Now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Narrator**
> "Vina sheepishly fished the book out of her bag and handed it to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[59]`
Mówca: **Narrator**
> "I took a closer look at the cover. Beneath the title were the words, "A Collection of Proposals by L. Chavatangakwunua.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`
  - -> `[62]`
  - -> `[63]`
  - -> `[99]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The uprising didn't succeed because the Rizian people knew what was good for them. A strong leader and strong laws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`

### Węzeł `[61]`
Mówca: **Vina Toras**
> ""No! You can't do that!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chava-what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[63]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This had better not be what I think it is.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[64]`
Mówca: **Narrator**
> "She bit her lip nervously."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`
  - -> `[86]`
  - -> `[78]`
  - -> `[102]`

### Węzeł `[65]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It failed because it lacked cohesion. Every faction was fighting for something different.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[66]`
Mówca: **Vina Toras**
> ""Look at what he writes here. True systemic change can only be accomplished with the wholehearted support of the working class.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[67]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Workers did join the protests. But yes, the initial spark came from naval officers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]`

### Węzeł `[68]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You don't need to bother with this. You're a princess, not an intellectual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enroll in etiquette classes. Learn how to bake. The possibilities are endless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[70]`
Mówca: **Vina Toras**
> ""You can't control what I read, you know. I'm a grown woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[192]`

### Węzeł `[71]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. But don't let anyone else catch you reading it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[72]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It would be easier if I knew whom I could trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Estela Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Estela Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[74]`
Mówca: **Vina Toras**
> ""It's not as extreme as his later work. He wrote it right before changing his last name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[75]`
Mówca: **Vina Toras**
> ""He changed it to Malenyev right after this was published.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[76]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is dangerous propaganda, Vina. Don't you realize Malenyev and his followers hate people like you and me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[77]`
Mówca: **Vina Toras**
> ""Isn't that why it's important to know how they think?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[78]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You know, I've always been curious about Malenyevism. Do you think it's compatible with monarchy?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[79]`
Mówca: **Vina Toras**
> ""Do you think that's why the uprising in Rizia failed? Because workers weren't the ones leading the charge?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
  - -> `[60]`
  - -> `[67]`
  - -> `[68]`

### Węzeł `[80]`
Mówca: **Vina Toras**
> ""You wouldn't allow me onto the council. There are only so many balls I can attend. What else am I supposed to do?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[89]`
  - -> `[69]`

### Węzeł `[81]`
Mówca: **Vina Toras**
> ""Endlessly dull, you mean. Will you please give me my book back?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[106]`

### Węzeł `[82]`
Mówca: **Narrator**
> "Vina gave me a conspiratorial nod."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[83]`
Mówca: **Vina Toras**
> ""I won't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[84]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""That name sounds familiar.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[85]`
Mówca: **Vina Toras**
> ""This was one of his first tracts. He wrote it right before changing his name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[86]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And? Are you learning anything interesting?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[87]`
Mówca: **Vina Toras**
> ""They thought that was what they wanted. Because nobody bothered to teach them otherwise.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[88]`
Mówca: **Vina Toras**
> ""And aristocrats working for their own gain, right? Like your kidnappers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is no way for a Toras to be carrying on. I'm taking this book away from you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[90]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I knew you'd learn more off the council than on it. Keep it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[91]`
Mówca: **Estela Toras**
> ""Chin up, now. I'll see you at supper.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Narrator**
> "My mother raised her parasol and strode away."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[93]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[94]`
Mówca: **Narrator**
> "Vina stared at me in disbelief for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[95]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[96]`
Mówca: **Vina Toras**
> ""I will. Enjoy the boring meetings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[97]`
Mówca: **Narrator**
> "She took the book and walked away, leaving me to my own thoughts. Before I knew it, it was time for the council meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[98]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RemoveConversant("Vina Toras");)*
- **Efekt (`userScript`):** `RemoveConversant("Vina Toras");
;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Where did you find this?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[100]`
Mówca: **Vina Toras**
> ""It was just lying around in the library. One of his supporters must have had it translated into Rizian.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`

### Węzeł `[101]`
Mówca: **Vina Toras**
> ""Of course, he wrote this right before he changed his name to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[102]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Malenyev? What happened to Queen Lyza?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Vina Toras**
> ""I've read all her writings already. And this one applies to our modern era far more.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`

### Węzeł `[105]`
Mówca: **Narrator**
> "Vina stared at me in disbelief for a second, then smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[106]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. Find another use of your time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[107]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's overwhelming at times. But I trust the council to help me decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[108]`
Mówca: **Narrator**
> "She lowered the black lace parasol she was holding and linked her arm through mine."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[109]`
Mówca: **Narrator**
> "She reached into her handbag and pulled out a slim paperback. On its cover were the words "Ce Faximi", or "What Are We To Do?" in Rizian."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_StayedOnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[112]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_StayedOnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_StayedOnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[113]`
Mówca: **Vina Toras**
> ""I have plenty. But I'll figure them out on my own time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`

### Węzeł `[114]`
Mówca: **Vina Toras**
> ""All of this council stuff is old hat for you, isn't it? You've even served with some of the same people before.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`
  - -> `[138]`
  - -> `[135]`
  - -> `[141]`

### Węzeł `[115]`
Mówca: **Estela Toras**
> ""One more thing, darling...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[116]`
Mówca: **Narrator**
> "I took a closer look at the cover. Beneath the title were the words, "A Collection of Proposals by L. Chavatangakwunua.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`
  - -> `[124]`
  - -> `[126]`
  - -> `[125]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Vina_OnCouncil == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Vina_OnCouncil"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Vina_OnCouncil == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Vina_OnCouncil"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[120]`
Mówca: **Estela Toras**
> ""I found this in Vina's room after she went to lunch. Her way of rebelling against you for not letting her on the council, I assume.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[121]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is this what I think it is?.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[175]`

### Węzeł `[122]`
Mówca: **Estela Toras**
> ""She was too quiet. I worried she was up to something.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[123]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm the king. Every decision I make is the right decision.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[124]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Chava-what?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[125]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What were you doing snooping around my daughter's room?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[126]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""She's been reading this? Interesting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[127]`
Mówca: **Estela Toras**
> ""I remember hearing that name a long time ago. Before he changed it to Malenyev.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[178]`
  - -> `[176]`
  - -> `[180]`

### Węzeł `[128]`
Mówca: **Vina Toras**
> ""Oh! Hello, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[30]`
  - -> `[34]`

### Węzeł `[129]`
Mówca: **Vina Toras**
> ""This must be overwhelming for you as well. So many decisions to make.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[136]`
  - -> `[107]`
  - -> `[72]`

### Węzeł `[130]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A long time ago. Frankly, they should have retired by now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[131]`
Mówca: **Vina Toras**
> ""Any good monarch listens to the will of the public. Queen Lyza always said that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`
  - -> `[146]`
  - -> `[132]`
  - -> `[140]`

### Węzeł `[132]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Queen Lyza wasn't a saint. She had her flaws.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[133]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[134]`
Mówca: **Vina Toras**
> ""By the time she was my age, she'd already been queen for a year. Imagine!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Yes, it's easy enough. I'm the king. What I say goes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Don't you worry about me. Focus on keeping your own head above water.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[137]`
Mówca: **Vina Toras**
> ""I know. But it's still an inspiring legacy to live up to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's different now that I'm the one in charge.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course I will. They're the best hope we have for giving Rizians an actual voice.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wise words from a wise woman.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[141]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was naive back then. Now I don't know whom I can trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Vina Toras**
> ""Lyza acted, too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[143]`
Mówca: **Vina Toras**
> ""You can always trust me, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[144]`
Mówca: **Vina Toras**
> ""Ms. Werner and Mr. Esquibel may be old, but what they were saying made a lot of sense to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""A good monarch listens. A great monarch acts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[146]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""And if the will of the public is for there to be no monarch at all? What then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[147]`
Mówca: **Vina Toras**
> ""If you rule as well as she did, that won't ever become a problem.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[148]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lead the way, Your Highness.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[149]`
Mówca: **Vina Toras**
> ""I will. I've been taking notes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not against the opposition because of House Sazon. I'm against it because it's the opposition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[151]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll take their opinions into consideration. But I'm the one with the final say.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[152]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I might, but I don't want anything to do with your friend Mr. Sazon.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Vina Toras**
> ""Why do you have it out for House Sazon? Just because one duke plotted against the king doesn't mean the whole family is evil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[154]`
  - -> `[155]`
  - -> `[150]`

### Węzeł `[154]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Lucas put a taint on his entire house. I won't discuss this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[155]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It's not all of the Sazons. Manus in particular strikes me as suspicious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[156]`
Mówca: **Vina Toras**
> ""Suspicious? He wants to work with you. Why not at least hear what he has to say?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[157]`
Mówca: **Vina Toras**
> ""Oh. Right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[158]`
Mówca: **Vina Toras**
> ""Okay, Father.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[159]`
Mówca: **Vina Toras**
> ""What do you think of the House of Delegates? Will you go talk to them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[151]`
  - -> `[160]`
  - -> `[152]`

### Węzeł `[160]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The only reason I would do that is to find out the opposition's weaknesses.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[162]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The Sazons have never truly been a royal house. Their ancestor had no claim to the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[163]`
Mówca: **Narrator**
> "A clock chimed in the distance. It was time for the meeting."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`
  - -> `[148]`

### Węzeł `[164]`
Mówca: **Vina Toras**
> ""I can't imagine how it feels to hold all that power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[165]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Enough chit-chat. Let's go.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[166]`
Mówca: **Vina Toras**
> ""The royal heir doesn't always have to be the king's son. Sometimes there are special circumstances.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[167]`
Mówca: **Vina Toras**
> ""Um... not really. A society ruled by a king is the embodiment of everything Malenyevists hate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[168]`
Mówca: **Vina Toras**
> ""But it's useful to know how they think, isn't it?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[169]`
Mówca: **Vina Toras**
> ""I mean... of course it's all rubbish. But it does make one think.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[170]`
Mówca: **Vina Toras**
> ""The student and workers' movement was more aligned with Malenyevism, but the nobles who rebelled were in favor of Arcasian democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[89]`
  - -> `[90]`
  - -> `[69]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.LeaningValue_Democratic -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.LeaningValue_Democratic"] = Variable["RiziaDLC.LeaningValue_Democratic"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[173]`
Mówca: **Estela Toras**
> ""And reading Malenyevist tracts is definitely 'something'.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[178]`
  - -> `[182]`
  - -> `[180]`

### Węzeł `[174]`
Mówca: **Estela Toras**
> ""That's an underreaction, wouldn't you say? Malenyevist tracts belong in an incinerator, not your daughter's bedroom.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[176]`
  - -> `[182]`
  - -> `[177]`

### Węzeł `[175]`
Mówca: **Estela Toras**
> ""I can see why he changed it to 'Malenyev', That's one unholy mass of letters.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`
  - -> `[178]`
  - -> `[176]`
  - -> `[180]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""There were Malenyevists involved in the '26 uprising, weren't there? It could be useful to learn how the enemy thinks.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`

### Węzeł `[177]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""You're right, Mother. I'm sure it's pure garbage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[186]`

### Węzeł `[178]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Vina's a smart girl. She wouldn't be reading this if there weren't value in it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[179]`
Mówca: **Estela Toras**
> ""That's what I'm worried about, dear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[180]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I see. Well, better this than Arcasian garbage.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[181]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Malenyevist += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.PersonalValue_Malenyevist"] = Variable["RiziaDLC.PersonalValue_Malenyevist"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[182]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""The man had some good ideas. Maybe his vision of a more egalitarian society isn't entirely incompatible with monarchy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[183]`
Mówca: **Estela Toras**
> ""My dear, I'm no scholar, but I do know there's a direct correlation between this fellow's line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[184]`
Mówca: **Estela Toras**
> ""The workers and students were inspired by Malenyevism. The nobles who got involved were pushing for Arcasian-style democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[185]`
Mówca: **Estela Toras**
> ""I'm no scholar myself. But I do know the former leads to more royal beheadings than the latter.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[186]`
Mówca: **Estela Toras**
> ""It's more than that, dear. Garbage won't cut off your head in the middle of the night.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Estela Toras**
> ""So what should I do with the book?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`
  - -> `[193]`

### Węzeł `[188]`
Mówca: **Estela Toras**
> ""My dear, I'm no scholar, but I do know there's a direct correlation between this fellow's line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[189]`
Mówca: **Estela Toras**
> ""They're like cannons at that age. You've got to mind the direction they're pointed in, or there'll be hell to pay when they go off.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[190]`
Mówca: **Estela Toras**
> ""Very well. But I do suggest having a chat with her about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`

### Węzeł `[191]`
Mówca: **Narrator**
> "She put the book back in her purse."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[193]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Put it back where you found it. Vina's allowed to read what she wants in her free time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[194]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This is dangerous propaganda. You were right to bring it to my attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[195]`
Mówca: **Estela Toras**
> ""I try to stay out of ideological debates. But I do know there's a direct correlation between this line of thinking and royal beheadings.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[196]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Give it to me. Vina shouldn't be exposed to such ideas.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[197]`
Mówca: **Estela Toras**
> ""Good thinking, Romus.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[198]`

### Węzeł `[198]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Vina_TookBookAway = true;
RiziaDLC.Relations_Vina -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Vina_TookBookAway"] = true;
Variable["RiziaDLC.Relations_Vina"] = Variable["RiziaDLC.Relations_Vina"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[199]`

### Węzeł `[199]`
Mówca: **Narrator**
> "She handed the book to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`
