# Rizia/Turn 3/NOTES

- **ID konwersacji:** `306`
- **StoryPack:** `Rizia`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Rizia/Turn_03/306_NOTES.md`
- **Liczba węzłów dialogowych:** 72
- **Liczba wyborów gracza:** 26

---

## 1. Uczestnicy Sceny

- **[10]** Narrator
- **[78]** Emmerich Hegel (R)
- **[92]** Beatrice Livingston (R)
- **[95]** Player_Romus *(Gracz)*

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `RiziaDLC.PersonalValue_Pacifist`

### Modyfikowane zmienne stanu (`userScript`):
- `RiziaDLC.Diplomacy_Rumburg_RefuseKA74License`
- `RiziaDLC.Diplomacy_Wehlen_FundBFF`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[4]` | **""So it's true that you've been providing aid to the BFF?""** | `[3]` **Emmerich Hegel (R)**: ""Increased activity by the Bludi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Beatrice Livingston (R)**: ""The Bluds are engaged in a leng..." |
| `[5]` | **""What do you mean by 'activity'? I don't want any more innocents to be hurt.""** | `[3]` **Emmerich Hegel (R)**: ""Increased activity by the Bludi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[8]` **Beatrice Livingston (R)**: ""I'm afraid the Bluds often have..." |
| `[6]` | **""Cooperating with the Bluds? There's got to be another way.""** | `[3]` **Emmerich Hegel (R)**: ""Increased activity by the Bludi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[10]` **Beatrice Livingston (R)**: ""They have suffered under Wehlen..." |
| `[7]` | **""Creating instability in the north of Wehlen would indeed divert his focus from Zi..."** | `[3]` **Emmerich Hegel (R)**: ""Increased activity by the Bludi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[11]` **Beatrice Livingston (R)**: ""And Rizia would appear entirely..." |
| `[12]` | **""I'm not convinced. Do you have any other suggestions?""** | `[13]` **Beatrice Livingston (R)**: ""You wouldn't have to deal with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Beatrice took a sip of tea with ..." |
| `[14]` | **""We're not like you. We don't meddle in other countries' internal disputes.""** | `[13]` **Beatrice Livingston (R)**: ""You wouldn't have to deal with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Emmerich Hegel (R)**: ""Yet you're only in this predica..." |
| `[18]` | **""You make a convincing case. I'm interested." [-1 Budget]"** | `[13]` **Beatrice Livingston (R)**: ""You wouldn't have to deal with ..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;` | `[21]` **Emmerich Hegel (R)**: ""Marvelous. Would you like to he..." |
| `[19]` | **""This sounds suspiciously like we'd be funding your goals, not ours.""** | `[13]` **Beatrice Livingston (R)**: ""You wouldn't have to deal with ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[20]` **Emmerich Hegel (R)**: ""Frankly, Rizia stands to benefi..." |
| `[23]` | **""Of course. I wouldn't let a member of my council go rogue like that.""** | `[39]` **Emmerich Hegel (R)**: ""Did you approve this inquiry, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Emmerich Hegel (R)**: ""Well, you two have raised an in..." |
| `[24]` | **""I don't remember. So many items pass my desk in a day.""** | `[39]` **Emmerich Hegel (R)**: ""Did you approve this inquiry, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Emmerich Hegel (R)**: ""Well, you should commend your c..." |
| `[26]` | **""Absolutely not. Duchess Azaro is grasping beyond her station.""** | `[39]` **Emmerich Hegel (R)**: ""Did you approve this inquiry, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Emmerich Hegel (R)**: ""Well, you should commend your c..." |
| `[27]` | **""Their zealotry makes me uncomfortable. But the enemy of my enemy is my friend.""** | `[8]` **Beatrice Livingston (R)**: ""I'm afraid the Bluds often have..."<br>`[10]` **Beatrice Livingston (R)**: ""They have suffered under Wehlen..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[37]` **Beatrice Livingston (R)**: ""There are those who've called m..." |
| `[29]` | **""Are they currently planning anything? I've heard no news of them.""** | `[8]` **Beatrice Livingston (R)**: ""I'm afraid the Bluds often have..."<br>`[9]` **Beatrice Livingston (R)**: ""The Bluds are engaged in a leng..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Beatrice Livingston (R)**: ""The imprisonment of their leade..." |
| `[31]` | **""Still, if President Smolak were to have even the slightest suspicion of ties betw..."** | `[8]` **Beatrice Livingston (R)**: ""I'm afraid the Bluds often have..."<br>`[9]` **Beatrice Livingston (R)**: ""The Bluds are engaged in a leng..."<br>*(oraz 2 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[13]` **Beatrice Livingston (R)**: ""You wouldn't have to deal with ..." |
| `[33]` | **""Perhaps you can countenance unleashing such an evil. I cannot.""** | `[8]` **Beatrice Livingston (R)**: ""I'm afraid the Bluds often have..."<br>`[9]` **Beatrice Livingston (R)**: ""The Bluds are engaged in a leng..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[28]` **Beatrice Livingston (R)**: ""Evil is in the eye of the behol..." |
| `[36]` | **""I very much would.""** | `[21]` **Emmerich Hegel (R)**: ""Marvelous. Would you like to he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Beatrice took a sip of tea with ..." |
| `[40]` | **""I truly appreciate your offer of help. But I have decided to deal with Wehlen on ..."** | `[21]` **Emmerich Hegel (R)**: ""Marvelous. Would you like to he..."<br>`[32]` **Emmerich Hegel (R)**: ""I do have one more proposal for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Narrator**: "Beatrice drew herself upright." |
| `[41]` | **""I'll go in on funding the BFF. That's all I'm prepared to do for now.""** | `[21]` **Emmerich Hegel (R)**: ""Marvelous. Would you like to he..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Emmerich Hegel (R)**: ""I understand. We're playing a l..." |
| `[42]` | **""No, you should go visit with Vina. But I will go in on funding the BFF after all...."** | `[32]` **Emmerich Hegel (R)**: ""I do have one more proposal for..." | *Brak (Dostępna bezwarunkowo)* | `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;` | `[43]` **Narrator**: "Beatrice gave me an appraising l..." |
| `[49]` | **""I did not. But it's not a bad idea.""** | `[39]` **Emmerich Hegel (R)**: ""Did you approve this inquiry, Y..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Emmerich Hegel (R)**: ""I agree. You should commend you..." |
| `[50]` | **""Very well. Let me hear it.""** | `[32]` **Emmerich Hegel (R)**: ""I do have one more proposal for..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Narrator**: "Beatrice took a sip of tea with ..." |
| `[54]` | **""I'm averse to the idea of manufacturing assault rifles. But such a license could ..."** | `[52]` **Emmerich Hegel (R)**: ""We don't normally issue such li..." | `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0` | *Brak zmian stanu* | `[65]` **Emmerich Hegel (R)**: ""Nobody *wants* to use KA-74s. B..." |
| `[58]` | **""We need to be able to up our arms supply the moment disaster strikes. And this wo..."** | `[52]` **Emmerich Hegel (R)**: ""We don't normally issue such li..." | `(Variable["RiziaDLC.PersonalValue_Pacifist"] > 0) == false` | *Brak zmian stanu* | `[64]` **Emmerich Hegel (R)**: ""Precisely my thoughts."" |
| `[59]` | **""Forget that inquiry ever happened. I don't want Rizian factories making deadly we..."** | `[52]` **Emmerich Hegel (R)**: ""We don't normally issue such li..." | `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0` | *Brak zmian stanu* | `[62]` **Emmerich Hegel (R)**: ""Then we shall continue selling ..." |
| `[60]` | **""No. I'd rather keep purchasing weapons from Rumburg as usual.""** | `[52]` **Emmerich Hegel (R)**: ""We don't normally issue such li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Emmerich Hegel (R)**: ""Suit yourself. I'm only bringin..." |
| `[61]` | **""I'll get back to you if and when we have the capability to make those rifles.""** | `[52]` **Emmerich Hegel (R)**: ""We don't normally issue such li..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[63]` **Emmerich Hegel (R)**: ""Perfect."" |

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (System / START)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (System / INPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Emmerich Hegel (R)**
> ""Increased activity by the Bludish Freedom Front, for example, would be a most unwelcome distraction for Mr. Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Player_Romus: ""So it's true that you've been providing aid to the BFF?""*)
  - -> `[5]` (*Player_Romus: ""What do you mean by 'activity'? I don't want any more in..."*)
  - -> `[6]` (*Player_Romus: ""Cooperating with the Bluds? There's got to be another way.""*)
  - -> `[7]` (*Player_Romus: ""Creating instability in the north of Wehlen would indeed..."*)

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it's true that you've been providing aid to the BFF?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Beatrice Livingston (R): ""The Bluds are engaged in a lengthy struggle against a re..."*)

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean by 'activity'? I don't want any more innocents to be hurt.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Beatrice Livingston (R): ""I'm afraid the Bluds often have no choice but to go to e..."*)

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cooperating with the Bluds? There's got to be another way.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Beatrice Livingston (R): ""They have suffered under Wehlen's regime just as the peo..."*)

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Creating instability in the north of Wehlen would indeed divert his focus from Zille.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[3]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Beatrice Livingston (R): ""And Rizia would appear entirely blameless.""*)

### Węzeł `[8]`
Mówca: **Beatrice Livingston (R)**
> ""I'm afraid the Bluds often have no choice but to go to extremes. We cannot control them, only provide them with the tools for liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Are they currently planning anything? I've heard no news..."*)
  - -> `[33]` (*Player_Romus: ""Perhaps you can countenance unleashing such an evil. I c..."*)
  - -> `[27]` (*Player_Romus: ""Their zealotry makes me uncomfortable. But the enemy of ..."*)
  - -> `[31]` (*Player_Romus: ""Still, if President Smolak were to have even the slighte..."*)

### Węzeł `[9]`
Mówca: **Beatrice Livingston (R)**
> ""The Bluds are engaged in a lengthy struggle against a regime that outnumbers and outguns them. We're interested in leveling that playing field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Are they currently planning anything? I've heard no news..."*)
  - -> `[33]` (*Player_Romus: ""Perhaps you can countenance unleashing such an evil. I c..."*)
  - -> `[31]` (*Player_Romus: ""Still, if President Smolak were to have even the slighte..."*)

### Węzeł `[10]`
Mówca: **Beatrice Livingston (R)**
> ""They have suffered under Wehlen's regime just as the people of Zille have. One need not agree with all of their aims to have sympathy with their cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Player_Romus: ""Are they currently planning anything? I've heard no news..."*)
  - -> `[33]` (*Player_Romus: ""Perhaps you can countenance unleashing such an evil. I c..."*)
  - -> `[27]` (*Player_Romus: ""Their zealotry makes me uncomfortable. But the enemy of ..."*)
  - -> `[31]` (*Player_Romus: ""Still, if President Smolak were to have even the slighte..."*)

### Węzeł `[11]`
Mówca: **Beatrice Livingston (R)**
> ""And Rizia would appear entirely blameless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Player_Romus: ""Their zealotry makes me uncomfortable. But the enemy of ..."*)
  - -> `[31]` (*Player_Romus: ""Still, if President Smolak were to have even the slighte..."*)

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not convinced. Do you have any other suggestions?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Beatrice took a sip of tea with her little finger extende..."*)

### Węzeł `[13]`
Mówca: **Beatrice Livingston (R)**
> ""You wouldn't have to deal with any BFF leaders directly. Merely channel a small contribution through our existing avenues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player_Romus: ""This sounds suspiciously like we'd be funding your goals..."*)
  - -> `[18]` (*Player_Romus: ""You make a convincing case. I'm interested." [-1 Budget]"*)
  - -> `[14]` (*Player_Romus: ""We're not like you. We don't meddle in other countries' ..."*)
  - -> `[12]` (*Player_Romus: ""I'm not convinced. Do you have any other suggestions?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not like you. We don't meddle in other countries' internal disputes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Emmerich Hegel (R): ""Yet you're only in this predicament because your father ..."*)

### Węzeł `[15]`
Mówca: **Emmerich Hegel (R)**
> ""One more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Emmerich Hegel (R): ""Your enterprising new war councilor has submitted an inq..."*)

### Węzeł `[16]`
Mówca: **Emmerich Hegel (R)**
> ""Your enterprising new war councilor has submitted an inquiry to our defense department regarding our KA-74 rifles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Emmerich Hegel (R): ""We're already supplying your military with the latest mo..."*)

### Węzeł `[17]`
Mówca: **Emmerich Hegel (R)**
> ""Yet you're only in this predicament because your father begged Wehlen to meddle in Rizia's. Curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Emmerich Hegel (R): ""I do have one more proposal for you.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: ""You make a convincing case. I'm interested." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""You make a convincing case. I'm interested.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_FundBFF = true"*)

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds suspiciously like we'd be funding your goals, not ours.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[13]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Emmerich Hegel (R): ""Frankly, Rizia stands to benefit more from a destabilize..."*)

### Węzeł `[20]`
Mówca: **Emmerich Hegel (R)**
> ""Frankly, Rizia stands to benefit more from a destabilized Wehlen than Rumburg does. For the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Emmerich Hegel (R): ""I do have one more proposal for you.""*)

### Węzeł `[21]`
Mówca: **Emmerich Hegel (R)**
> ""Marvelous. Would you like to hear my other proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Player_Romus: ""I'll go in on funding the BFF. That's all I'm prepared t..."*)
  - -> `[36]` (*Player_Romus: ""I very much would.""*)
  - -> `[40]` (*Player_Romus: ""I truly appreciate your offer of help. But I have decide..."*)

### Węzeł `[22]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_FundBFF = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Emmerich Hegel (R): ""Marvelous. Would you like to hear my other proposal?""*)

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I wouldn't let a member of my council go rogue like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Emmerich Hegel (R): ""Well, you two have raised an interesting possibility.""*)

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. So many items pass my desk in a day.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Emmerich Hegel (R): ""Well, you should commend your councilor for her initiati..."*)

### Węzeł `[25]`
Mówca: **Emmerich Hegel (R)**
> ""I agree. You should commend your councilor for her initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Emmerich Hegel (R): ""We don't normally issue such licenses, but for Rizia, we..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. Duchess Azaro is grasping beyond her station.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Emmerich Hegel (R): ""Well, you should commend your councilor for her initiati..."*)

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their zealotry makes me uncomfortable. But the enemy of my enemy is my friend.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Beatrice Livingston (R)), `[10]` (Beatrice Livingston (R)), `[11]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Beatrice Livingston (R): ""There are those who've called me a zealot for daring to ..."*)

### Węzeł `[28]`
Mówca: **Beatrice Livingston (R)**
> ""Evil is in the eye of the beholder. There are those who have called me evil for maintaining Rumburg's monarchy at an age when global trends run to the contrary. You too, I suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Beatrice Livingston (R): ""You wouldn't have to deal with any BFF leaders directly...."*)

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are they currently planning anything? I've heard no news of them.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Beatrice Livingston (R)), `[9]` (Beatrice Livingston (R)), `[10]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Beatrice Livingston (R): ""The imprisonment of their leader Dewlan Arge put a dampe..."*)

### Węzeł `[30]`
Mówca: **Narrator**
> "Beatrice took a sip of tea with her little finger extended. She gave a satisfied nod, then continued."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, if President Smolak were to have even the slightest suspicion of ties between us and the BFF, our chances for a peaceful transfer of Zille would evaporate.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Beatrice Livingston (R)), `[9]` (Beatrice Livingston (R)), `[10]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Beatrice Livingston (R): ""You wouldn't have to deal with any BFF leaders directly...."*)

### Węzeł `[32]`
Mówca: **Emmerich Hegel (R)**
> ""I do have one more proposal for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Player_Romus: ""Very well. Let me hear it.""*)
  - -> `[42]` (*Player_Romus: ""No, you should go visit with Vina. But I will go in on f..."*)
  - -> `[40]` (*Player_Romus: ""I truly appreciate your offer of help. But I have decide..."*)

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you can countenance unleashing such an evil. I cannot.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[8]` (Beatrice Livingston (R)), `[9]` (Beatrice Livingston (R)), `[10]` (Beatrice Livingston (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Beatrice Livingston (R): ""Evil is in the eye of the beholder. There are those who ..."*)

### Węzeł `[34]`
Mówca: **Beatrice Livingston (R)**
> ""The imprisonment of their leader Dewlan Arge put a damper on their operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Beatrice Livingston (R): ""From what our inside sources tell us, they have been reg..."*)

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""From what our inside sources tell us, they have been regrouping. Gathering ammunition and recruits until they are again strong enough to take on their oppressors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Beatrice Livingston (R): ""You wouldn't have to deal with any BFF leaders directly...."*)

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I very much would.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Beatrice took a sip of tea with her little finger extende..."*)

### Węzeł `[37]`
Mówca: **Beatrice Livingston (R)**
> ""There are those who've called me a zealot for daring to unite the lands of Northern Merkopa. It is all in the eye of the beholder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Beatrice Livingston (R): ""You wouldn't have to deal with any BFF leaders directly...."*)

### Węzeł `[38]`
Mówca: **Emmerich Hegel (R)**
> ""We're already supplying your military with the latest models. But Ms. Azaro suggested that Rizia purchase a license to manufacture the weapons on its own soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Emmerich Hegel (R): ""Did you approve this inquiry, Your Majesty?""*)

### Węzeł `[39]`
Mówca: **Emmerich Hegel (R)**
> ""Did you approve this inquiry, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Player_Romus: ""Of course. I wouldn't let a member of my council go rogu..."*)
  - -> `[24]` (*Player_Romus: ""I don't remember. So many items pass my desk in a day.""*)
  - -> `[26]` (*Player_Romus: ""Absolutely not. Duchess Azaro is grasping beyond her sta..."*)
  - -> `[49]` (*Player_Romus: ""I did not. But it's not a bad idea.""*)

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I truly appreciate your offer of help. But I have decided to deal with Wehlen on my own.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel (R)), `[32]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Narrator: "Beatrice drew herself upright."*)

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll go in on funding the BFF. That's all I'm prepared to do for now.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Emmerich Hegel (R): ""I understand. We're playing a long game, but expect a re..."*)

### Węzeł `[42]`
**[WYBÓR GRACZA: ""No, you should go visit with Vina. But I will go in on funding the BFF after all." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""No, you should go visit with Vina. But I will go in on funding the BFF after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Wehlen_FundBFF = true"*)

### Węzeł `[43]`
Mówca: **Narrator**
> "Beatrice gave me an appraising look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Beatrice Livingston (R): ""My, what a pleasant surprise. I'll see to it at once.""*)

### Węzeł `[44]`
Mówca: **Beatrice Livingston (R)**
> ""My, what a pleasant surprise. I'll see to it at once.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Wehlen_FundBFF = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Narrator: "Beatrice gave me an appraising look."*)

### Węzeł `[46]`
Mówca: **Narrator**
> "Beatrice drew herself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]` (*Beatrice Livingston (R): ""I respect your wish to handle things your way. I do hope..."*)

### Węzeł `[47]`
Mówca: **Beatrice Livingston (R)**
> ""I respect your wish to handle things your way. I do hope all goes well.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[48]`
Mówca: **Emmerich Hegel (R)**
> ""I understand. We're playing a long game, but expect a return on the investment.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[49]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I did not. But it's not a bad idea.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[39]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Emmerich Hegel (R): ""I agree. You should commend your councilor for her initi..."*)

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Let me hear it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Narrator: "Beatrice took a sip of tea with her little finger extende..."*)

### Węzeł `[51]`
Mówca: **Emmerich Hegel (R)**
> ""Well, you should commend your councilor for her initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Emmerich Hegel (R): ""We don't normally issue such licenses, but for Rizia, we..."*)

### Węzeł `[52]`
Mówca: **Emmerich Hegel (R)**
> ""We don't normally issue such licenses, but for Rizia, we might consider an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist > 0"*)
  - -> `[61]` (*Player_Romus: ""I'll get back to you if and when we have the capability ..."*)
  - -> `[60]` (*Player_Romus: ""No. I'd rather keep purchasing weapons from Rumburg as u..."*)

### Węzeł `[53]`
Mówca: **Emmerich Hegel (R)**
> ""Well, you two have raised an interesting possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Emmerich Hegel (R): ""We don't normally issue such licenses, but for Rizia, we..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm averse to the idea of manufacturing assault rifles. But such a license could prove useful.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[52]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Emmerich Hegel (R): ""Nobody *wants* to use KA-74s. But when the need arises, ..."*)

### Węzeł `[55]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.PersonalValue_Pacifist > 0"*)
  - -> `[57]` (*Węzeł Logiki Narracyjnej: "!(RiziaDLC.PersonalValue_Pacifist > 0)"*)

### Węzeł `[56]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.PersonalValue_Pacifist > 0`
- **Warunek bezpośredni (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player_Romus: ""I'm averse to the idea of manufacturing assault rifles. ..."*)
  - -> `[59]` (*Player_Romus: ""Forget that inquiry ever happened. I don't want Rizian f..."*)

### Węzeł `[57]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `!(RiziaDLC.PersonalValue_Pacifist > 0)`
- **Warunek bezpośredni (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Pacifist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player_Romus: ""We need to be able to up our arms supply the moment disa..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to be able to up our arms supply the moment disaster strikes. And this would save us the headache of gun shipping.""
- **Wymagania odblokowania (kod gry):** `(Variable["RiziaDLC.PersonalValue_Pacifist"] > 0) == false`
- **Kontekst wejściowy (poprzednik):** `[52]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Emmerich Hegel (R): ""Precisely my thoughts.""*)

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forget that inquiry ever happened. I don't want Rizian factories making deadly weapons.""
- **Wymagania odblokowania (kod gry):** `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0`
- **Kontekst wejściowy (poprzednik):** `[52]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Emmerich Hegel (R): ""Then we shall continue selling you those weapons as usual.""*)

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'd rather keep purchasing weapons from Rumburg as usual.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Emmerich Hegel (R): ""Suit yourself. I'm only bringing this up because your st..."*)

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll get back to you if and when we have the capability to make those rifles.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[52]` (Emmerich Hegel (R))
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]` (*Emmerich Hegel (R): ""Perfect.""*)

### Węzeł `[62]`
Mówca: **Emmerich Hegel (R)**
> ""Then we shall continue selling you those weapons as usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_RefuseKA74License = true"*)

### Węzeł `[63]`
Mówca: **Emmerich Hegel (R)**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "She drew closer to me. Her emeralds glinted in the lampli..."*)

### Węzeł `[64]`
Mówca: **Emmerich Hegel (R)**
> ""Precisely my thoughts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Emmerich Hegel (R): ""See about acquiring facilities in which to make the weap..."*)

### Węzeł `[65]`
Mówca: **Emmerich Hegel (R)**
> ""Nobody *wants* to use KA-74s. But when the need arises, nothing else will do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Emmerich Hegel (R): ""See about acquiring facilities in which to make the weap..."*)

### Węzeł `[66]`
Mówca: **Emmerich Hegel (R)**
> ""Suit yourself. I'm only bringing this up because your staff asked about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Węzeł Logiki Narracyjnej: "RiziaDLC.Diplomacy_Rumburg_RefuseKA74License = true"*)

### Węzeł `[67]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `RiziaDLC.Diplomacy_Rumburg_RefuseKA74License = true`
- **Efekt skryptowy (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_RefuseKA74License"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "She drew closer to me. Her emeralds glinted in the lampli..."*)

### Węzeł `[68]`
Mówca: **Emmerich Hegel (R)**
> ""And family members help each other out. Almost unconditionally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Emmerich Hegel (R): ""See you at supper.""*)

### Węzeł `[69]`
Mówca: **Emmerich Hegel (R)**
> ""See about acquiring facilities in which to make the weapons, and I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Narrator: "She drew closer to me. Her emeralds glinted in the lampli..."*)

### Węzeł `[70]`
Mówca: **Emmerich Hegel (R)**
> ""Remember, Your Majesty, my sister may be gone, but I am still proud to call House Toras my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Emmerich Hegel (R): ""And family members help each other out. Almost unconditi..."*)

### Węzeł `[71]`
Mówca: **Narrator**
> "She drew closer to me. Her emeralds glinted in the lamplight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Emmerich Hegel (R): ""Remember, Your Majesty, my sister may be gone, but I am ..."*)

### Węzeł `[72]`
Mówca: **Emmerich Hegel (R)**
> ""See you at supper.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
