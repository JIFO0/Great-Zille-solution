# Rizia/Turn 2/Pabel Valero Poisoning Talk

- **ID konwersacji:** `301`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 02`
- **Lokalizacja pliku:** `Rizia/Turn_02/301_Pabel_Valero_Poisoning_Talk.md`
- **Liczba węzłów dialogowych:** 198
- **Liczba wyborów gracza:** 44

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[95]** Player_Romus *(Gracz)*
- **[101]** Pabel Adria

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.Prologue_Relations_PabelBoss`
- `RiziaDLC.Prologue_Relations_PabelFriend`
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Relations_Pabel_YourMajesty`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Relations_Pabel`
- `RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper`
- `RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects`

### Skoki między-konwersacyjne:
- Węzeł `[2]` -> **[300] Rizia/Turn 2/P_VinaAtMonqiz** (../Turn_02/300_P_VinaAtMonqiz.md), Węzeł `[523]`
- Węzeł `[45]` -> **[300] Rizia/Turn 2/P_VinaAtMonqiz** (../Turn_02/300_P_VinaAtMonqiz.md), Węzeł `[182]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 10
- **Węzły modyfikujące stan gry:** 11

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `RiziaDLC.Relations_Pabel`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[83]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] = true;`
- Węzeł `[84]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] = true;`
- Węzeł `[85]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] = true;`
- Węzeł `[86]` (Paskal Beniwoll): `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] = true;`
- Węzeł `[114]` (Paskal Beniwoll): `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] = true;`
- Węzeł `[141]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- Węzeł `[147]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- Węzeł `[151]` (Paskal Beniwoll): `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- *...oraz 3 innych węzłów ze skryptami.*

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `300` (*Rizia/Turn 2/P_VinaAtMonqiz*), Węzeł `[523]`

### Węzeł `[3]`
Mówca: **Narrator**
> "The door slowly opened and Pabel entered, a fluffy towel in his arms. He hung it on a hook on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]`

### Węzeł `[4]`
Mówca: **Pabel Adria**
> ""Your Majesty... How much have you been told about your father's death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[11]`

### Węzeł `[5]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`
  - -> `[7]`

### Węzeł `[6]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[7]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Pabel Adria**
> ""Listen, Rom... How much have they told you about your father's death?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`
  - -> `[10]`
  - -> `[11]`

### Węzeł `[9]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""It was a heart attack. What else would I need to know?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[10]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I haven't cared enough to go digging around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[11]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Not a lot. Do you suspect something?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[12]`
Mówca: **Pabel Adria**
> ""Well, this is what I know...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[13]`
Mówca: **Pabel Adria**
> ""Funny you should mention digging.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[14]`
Mówca: **Pabel Adria**
> ""That was the official explanation, yes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`

### Węzeł `[15]`
Mówca: **Pabel Adria**
> ""Back when my dad was still alive, he showed me every single plant in the Palas Rezna gardens.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Pabel Adria**
> ""You remember my father, the groundskeeper. When I was younger, he showed me every single plant in the gardens of Palas Rezna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[17]`
Mówca: **Pabel Adria**
> ""One of them was mandragora. Big green leaves, pretty purple flowers.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]`

### Węzeł `[18]`
Mówca: **Pabel Adria**
> ""He told me you can make an extract from its roots. A little bit helps you sleep. More than that causes delirium. And a lot stops your heart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[21]`
  - -> `[20]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I think I see where this is going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[20]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why didn't you ever tell me about this plant?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[21]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Mandragora? You've been reading too many fantasy novels.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[22]`
Mówca: **Pabel Adria**
> ""You were the royal heir. Why would you need to know about gardening?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[23]`
Mówca: **Pabel Adria**
> ""The name sounds silly, I know. That's why it stuck in my head all these years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[24]`
Mówca: **Pabel Adria**
> ""After he died, I went out to the part of the garden where my father had planted the mandragora. Nothing but a smooth patch of dirt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[25]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""When was the last time you saw the plants?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Who was around the palace that night?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[27]`
Mówca: **Pabel Adria**
> ""There were only a few people King Valero trusted by the end. If my suspicions are correct, it means one of them took advantage of that trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[28]`
Mówca: **Pabel Adria**
> ""You may be right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[29]`
Mówca: **Pabel Adria**
> ""And all of those people are still in your inner circle today.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`
  - -> `[99]`
  - -> `[100]`
  - -> `[101]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`
  - -> `[32]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[32]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[33]`
Mówca: **Pabel Adria**
> ""I only spoke to you when I was spoken to, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[34]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you. You're dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[35]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Is there another reason you wanted to come in?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[36]`
Mówca: **Narrator**
> "I noticed an identical towel on the hook next to it."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`
  - -> `[35]`
  - -> `[37]`

### Węzeł `[37]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Two towels? Are you crazy, Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[38]`
Mówca: **Narrator**
> "He took a step closer to the tub, conscientiously keeping his eyes on the wall."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Pabel Adria**
> ""Actually, there was something I wanted to bring up. Without any guards around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[41]`
  - -> `[42]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Why? Don't you trust the Golden Guard?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Sounds serious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

### Węzeł `[42]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'd really rather not have company in here, Pabel. Save the talk for another day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[43]`
Mówca: **Pabel Adria**
> ""If... if you insist.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Narrator**
> "He backed out the door, bowing slightly as he did so."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [RiziaDLC.Relations_Pabel -= 1])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `300` (*Rizia/Turn 2/P_VinaAtMonqiz*), Węzeł `[182]`

### Węzeł `[46]`
Mówca: **Pabel Adria**
> ""I don't know whom I can trust, to be honest.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[47]`
Mówca: **Pabel Adria**
> ""It might be. Or it might not be. I'm not sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[48]`
Mówca: **Narrator**
> "There was a small stool next to the tub. He moved over to it and sat with his back to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
  - -> `[50]`

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Well? What did you want to tell me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No need for modesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Pabel Adria**
> ""Oh. Pardon me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Narrator**
> "Pabel turned around, still taking care to look only at my face. He spoke the next words slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[53]`
Mówca: **Narrator**
> "Pabel spoke the next words slowly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[195]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[56]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[57]`
Mówca: **Pabel Adria**
> ""I know it seems preposterous, but....""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
Mówca: **Pabel Adria**
> ""When I attended to your father on his sickbed, he didn't seem like a man suffering from heart failure. He was in a complete daze, as if he didn't even recognize me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[59]`
Mówca: **Pabel Adria**
> ""A few months before that, maybe. I remembered the flowers blooming.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Could someone have slipped it in his supper?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I've heard enough. It sounds like his paranoia was rubbing off on you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[62]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""All right. Let's say Father was indeed poisoned. What would be the motivation?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[63]`
Mówca: **Pabel Adria**
> ""The Queen Mother, obviously. Grand Wiseman Ignacius. Titus and his men...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[197]`

### Węzeł `[64]`
Mówca: **Narrator**
> "Pabel grimaced."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
**[WYBÓR GRACZA: """]** — Mówca: **Pabel Adria**
> ""So quite the list. Not including me, of course."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[66]`
Mówca: **Pabel Adria**
> ""I was tasting all of His Majesty's food at that time. So whoever it was would have had to be very creative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[67]`
Mówca: **Pabel Adria**
> ""So yes, it's possible their disappearance had nothing to do with the King's death.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[68]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Valero Poison Qs)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`
  - -> `[74]`
  - -> `[77]`
  - -> `[80]`
  - -> `[88]`

### Węzeł `[69]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If he was poisoned, the coroner would have caught it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[70]`
Mówca: **Pabel Adria**
> ""Mandragora is a naturally occurring substance. It may not have raised a flag.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[71]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`
  - -> `[73]`

### Węzeł `[72]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[73]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[74]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`
  - -> `[76]`

### Węzeł `[75]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[76]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[77]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`
  - -> `[79]`

### Węzeł `[78]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[79]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[80]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`
  - -> `[82]`

### Węzeł `[81]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[85]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[87]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Valero Poison Qs])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[88]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[90]`

### Węzeł `[89]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`
  - -> `[62]`

### Węzeł `[90]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects == true || RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Coroner"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Supper"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Suspects"] == true  or  Variable["RiziaDLCIsolated.Turn02_ValeroPoisonQs_Plants"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[91]`
Mówca: **Pabel Adria**
> ""We both know His Majesty had a long list of enemies.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Pabel Adria**
> ""But the goal could simply have been to put you on the throne.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`
  - -> `[94]`
  - -> `[95]`

### Węzeł `[93]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So I have a secret friend in the palace.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[94]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Or I'm next.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[95]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Nobody wanted me to be King that badly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[97]`

### Węzeł `[96]`
Mówca: **Pabel Adria**
> ""But please, look out for yourself nonetheless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[97]`
Mówca: **Pabel Adria**
> ""No matter what, I would urge you to look out for yourself.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""I see. I'm going to have to look into this further." [Potential Investigation]"]** — Mówca: **Player_Romus**
> ""I see. I'm going to have to look into this further.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[99]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Even if you're right, this isn't worth pursuing. Nobody's going to murder me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[100]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not seeing it, Pabel. It's too fantastical.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[101]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Wait. What if *you* did it and you're trying to throw me off your trail?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[102]`
Mówca: **Pabel Adria**
> ""Of course. I would never hide anything from you. You and I go too far back for that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[103]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`
  - -> `[105]`

### Węzeł `[104]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[105]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Pabel Adria**
> ""Of course, Your Majesty. Your well-being is of the utmost importance to me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[107]`
Mówca: **Narrator**
> "Pabel drew his breath in through his teeth."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[108]`
Mówca: **Pabel Adria**
> ""I hope you're right.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`
  - -> `[139]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[112]`
Mówca: **Pabel Adria**
> ""It's indeed a stretch, Your Majesty. Please forget I broached the subject, then.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[113]`
Mówca: **Pabel Adria**
> ""You're right, Romus. Forget I even brought it up.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`
  - -> `[140]`

### Węzeł `[114]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Security_ValeroPoisoningTalk_BelievedPabel"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[115]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> "'I *know* I'm right. Who would possibly want to kill me?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[190]`

### Węzeł `[116]`
Mówca: **Narrator**
> "I heard Pabel sigh quietly."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[117]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`
  - -> `[119]`

### Węzeł `[118]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]`

### Węzeł `[119]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[120]`
Mówca: **Pabel Adria**
> ""I can assure you of my innocence, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[121]`
Mówca: **Pabel Adria**
> ""Why would I even be telling you all this, then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[122]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`
  - -> `[124]`

### Węzeł `[123]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[124]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[125]`
Mówca: **Pabel Adria**
> ""We may not be the close confidantes we once were, but I'll always have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[150]`
  - -> `[138]`

### Węzeł `[126]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel < 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`
  - -> `[128]`

### Węzeł `[127]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel < 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel"] < 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[128]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel < 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel"] < 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[129]`
Mówca: **Pabel Adria**
> ""Trust me, old friend. I'll always have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[135]`
  - -> `[150]`
  - -> `[138]`

### Węzeł `[130]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`

### Węzeł `[131]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelBoss == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[132]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelBoss == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelBoss"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`

### Węzeł `[133]`
Mówca: **Pabel Adria**
> ""Yes, you tormented me in childhood. But as the royal butler, it's my job to have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[137]`
  - -> `[149]`
  - -> `[138]`

### Węzeł `[134]`
Mówca: **Pabel Adria**
> ""I am the royal butler. It's my job to have your back.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`
  - -> `[150]`
  - -> `[138]`

### Węzeł `[135]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Bi mare volu...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[185]`

### Węzeł `[136]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Speaking of backs, can you give mine a scrub while you're here?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[163]`

### Węzeł `[137]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I was your superior. As I am now. Don't try to rise above your station.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[138]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""If you've said all you have to say, you're dismissed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[139]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thank you for bringing it up with me regardless, though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[140]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I will. Gladly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[142]`
Mówca: **Pabel Adria**
> ""I was only looking out for your own well-being.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Pabel nodded."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`
  - -> `[145]`

### Węzeł `[144]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Thanks for bringing it to my attention.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[145]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you think I should do next?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[146]`
Mówca: **Pabel Adria**
> ""I wish I knew. Try to find out as much as you can without raising suspicion, I guess.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[147]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[148]`
Mówca: **Pabel Adria**
> ""I'll keep an ear out myself. Palace gossip gets around.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[149]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm sorry about that. I didn't know any better.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[150]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Remember I'm still your superior. Don't try to rise above your station.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel += 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] + 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel -= 1)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Relations_Pabel"] = Variable["RiziaDLC.Relations_Pabel"] - 1;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[153]`
Mówca: **Narrator**
> "A pained expression flashed across his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Pabel Adria**
> ""I would never presume to do that, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Pabel Adria**
> ""I'll take my leave now. I hope the water is still warm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[156]`
Mówca: **Pabel Adria**
> ""Past is past, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`
  - -> `[159]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[159]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[160]`
Mówca: **Pabel Adria**
> ""I...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`

### Węzeł `[161]`
Mówca: **Narrator**
> "He paused for a moment."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[162]`
Mówca: **Pabel Adria**
> ""No, that's everything. I'll take my leave before the bathwater gets cold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[163]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[165]`

### Węzeł `[164]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[165]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Prologue_Relations_PabelFriend == true && RiziaDLC.Relations_Pabel > 1))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Prologue_Relations_PabelFriend"] == true  and  Variable["RiziaDLC.Relations_Pabel"] > 1) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[166]`
Mówca: **Pabel Adria**
> ""With pleasure, my king.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[167]`
Mówca: **Pabel Adria**
> ""Right away, Your Majesty.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[168]`
Mówca: **Narrator**
> "He took a warm, soapy washcloth and carefully ran it over my back and shoulders. I felt the day's tension leaving my body."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[169]`
Mówca: **Narrator**
> "He took a warm, soapy washcloth and scrubbed my back in a businesslike manner."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[170]`
Mówca: **Pabel Adria**
> ""I'll take my leave before your water gets too cold.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[175]`
  - -> `[176]`

### Węzeł `[171]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Pabel?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[179]`

### Węzeł `[172]`
Mówca: **Narrator**
> "He quietly exited the room, leaving me to finish my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[173]`
Mówca: **Pabel Adria**
> ""That's everything, Your Majesty. I hope your bathwater is still warm.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[174]`
Mówca: **Narrator**
> "He finished the phrase with a gentle smile, then rose from his seat."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[175]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Butler!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[177]`

### Węzeł `[176]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""See you later.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[172]`

### Węzeł `[177]`
Mówca: **Narrator**
> "He laughed."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[178]`

### Węzeł `[178]`
Mówca: **Pabel Adria**
> ""What is it, Mr. Manger?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[186]`

### Węzeł `[179]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[180]`
  - -> `[181]`

### Węzeł `[180]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == true)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[182]`

### Węzeł `[181]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == true))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[183]`

### Węzeł `[182]`
Mówca: **Pabel Adria**
> ""Romus?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[186]`

### Węzeł `[183]`
Mówca: **Pabel Adria**
> ""Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[184]`
  - -> `[186]`

### Węzeł `[184]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Stay and chat? Baths are boring alone.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[188]`

### Węzeł `[185]`
Mówca: **Pabel Adria**
> ""...un oxit solu.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[174]`

### Węzeł `[186]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm happy there's one member of my inner circle I can trust.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[187]`

### Węzeł `[187]`
Mówca: **Narrator**
> "He bowed his head in gratitude and quietly exited, leaving me to finish my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[188]`
Mówca: **Pabel Adria**
> ""As my king commands.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[189]`

### Węzeł `[189]`
Mówca: **Narrator**
> "He sat down. We kept talking as I finished my bath."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[190]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[191]`
  - -> `[192]`

### Węzeł `[191]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Relations_Pabel_YourMajesty == false)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[193]`

### Węzeł `[192]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.Relations_Pabel_YourMajesty == false))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.Relations_Pabel_YourMajesty"] == false) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[194]`

### Węzeł `[193]`
Mówca: **Pabel Adria**
> ""You're the king, Romus. You can't lift a finger without making an enemy of someone somewhere.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[194]`
Mówca: **Pabel Adria**
> ""I beg your pardon, Your Majesty, but you're the king. Enemies come with the territory.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[196]`

### Węzeł `[195]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Uncertainty", "R_Uncertainty_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Uncertainty","R_Uncertainty_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[196]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlayLoopedMusic("R_Sunrise", "R_Sunrise_Loop");)*
- **Efekt (`userScript`):** `PlayLoopedMusic("R_Sunrise","R_Sunrise_Loop");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[197]`
Mówca: **Pabel Adria**
> ""Lucita Azaro was also in town, meeting with your uncle to discuss the interim security councilor position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`
