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

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 5
- **Węzły modyfikujące stan gry:** 3

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[22]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- Węzeł `[45]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- Węzeł `[67]` (Paskal Beniwoll): `Variable["RiziaDLC.Diplomacy_Rumburg_RefuseKA74License"] = true;`

---

## 4. Pełna Struktura Grafu Dialogowego

Punkt wejścia: `Entry 0 [START]`

### Węzeł `[0]`
**[START / ROOT]** (Ovid Grecer)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]`

### Węzeł `[1]`
**[INPUT / WEJŚCIE SCENY]** (Paskal Beniwoll)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Emmerich Hegel (R)**
> ""Increased activity by the Bludish Freedom Front, for example, would be a most unwelcome distraction for Mr. Smolak.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`
  - -> `[5]`
  - -> `[6]`
  - -> `[7]`

### Węzeł `[4]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""So it's true that you've been providing aid to the BFF?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[5]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""What do you mean by 'activity'? I don't want any more innocents to be hurt.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[6]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Cooperating with the Bluds? There's got to be another way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[7]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Creating instability in the north of Wehlen would indeed divert his focus from Zille.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[8]`
Mówca: **Beatrice Livingston (R)**
> ""I'm afraid the Bluds often have no choice but to go to extremes. We cannot control them, only provide them with the tools for liberation.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[33]`
  - -> `[27]`
  - -> `[31]`

### Węzeł `[9]`
Mówca: **Beatrice Livingston (R)**
> ""The Bluds are engaged in a lengthy struggle against a regime that outnumbers and outguns them. We're interested in leveling that playing field.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[33]`
  - -> `[31]`

### Węzeł `[10]`
Mówca: **Beatrice Livingston (R)**
> ""They have suffered under Wehlen's regime just as the people of Zille have. One need not agree with all of their aims to have sympathy with their cause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[33]`
  - -> `[27]`
  - -> `[31]`

### Węzeł `[11]`
Mówca: **Beatrice Livingston (R)**
> ""And Rizia would appear entirely blameless.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`
  - -> `[31]`

### Węzeł `[12]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm not convinced. Do you have any other suggestions?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[13]`
Mówca: **Beatrice Livingston (R)**
> ""You wouldn't have to deal with any BFF leaders directly. Merely channel a small contribution through our existing avenues.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[14]`
  - -> `[12]`

### Węzeł `[14]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We're not like you. We don't meddle in other countries' internal disputes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[15]`
Mówca: **Emmerich Hegel (R)**
> ""One more thing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Emmerich Hegel (R)**
> ""Your enterprising new war councilor has submitted an inquiry to our defense department regarding our KA-74 rifles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[17]`
Mówca: **Emmerich Hegel (R)**
> ""Yet you're only in this predicament because your father begged Wehlen to meddle in Rizia's. Curious.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[18]`
**[WYBÓR GRACZA: ""You make a convincing case. I'm interested." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""You make a convincing case. I'm interested.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[19]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""This sounds suspiciously like we'd be funding your goals, not ours.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]`

### Węzeł `[20]`
Mówca: **Emmerich Hegel (R)**
> ""Frankly, Rizia stands to benefit more from a destabilized Wehlen than Rumburg does. For the moment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[21]`
Mówca: **Emmerich Hegel (R)**
> ""Marvelous. Would you like to hear my other proposal?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[36]`
  - -> `[40]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_FundBFF = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Of course. I wouldn't let a member of my council go rogue like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[24]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I don't remember. So many items pass my desk in a day.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[25]`
Mówca: **Emmerich Hegel (R)**
> ""I agree. You should commend your councilor for her initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[26]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Absolutely not. Duchess Azaro is grasping beyond her station.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[27]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Their zealotry makes me uncomfortable. But the enemy of my enemy is my friend.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[28]`
Mówca: **Beatrice Livingston (R)**
> ""Evil is in the eye of the beholder. There are those who have called me evil for maintaining Rumburg's monarchy at an age when global trends run to the contrary. You too, I suspect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[29]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Are they currently planning anything? I've heard no news of them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[30]`
Mówca: **Narrator**
> "Beatrice took a sip of tea with her little finger extended. She gave a satisfied nod, then continued."
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[31]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Still, if President Smolak were to have even the slightest suspicion of ties between us and the BFF, our chances for a peaceful transfer of Zille would evaporate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[32]`
Mówca: **Emmerich Hegel (R)**
> ""I do have one more proposal for you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`
  - -> `[42]`
  - -> `[40]`

### Węzeł `[33]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Perhaps you can countenance unleashing such an evil. I cannot.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[34]`
Mówca: **Beatrice Livingston (R)**
> ""The imprisonment of their leader Dewlan Arge put a damper on their operations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`

### Węzeł `[35]`
Mówca: **Beatrice Livingston (R)**
> ""From what our inside sources tell us, they have been regrouping. Gathering ammunition and recruits until they are again strong enough to take on their oppressors.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[36]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I very much would.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[37]`
Mówca: **Beatrice Livingston (R)**
> ""There are those who've called me a zealot for daring to unite the lands of Northern Merkopa. It is all in the eye of the beholder.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[38]`
Mówca: **Emmerich Hegel (R)**
> ""We're already supplying your military with the latest models. But Ms. Azaro suggested that Rizia purchase a license to manufacture the weapons on its own soil.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`

### Węzeł `[39]`
Mówca: **Emmerich Hegel (R)**
> ""Did you approve this inquiry, Your Majesty?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`
  - -> `[24]`
  - -> `[26]`
  - -> `[49]`

### Węzeł `[40]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I truly appreciate your offer of help. But I have decided to deal with Wehlen on my own.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[41]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll go in on funding the BFF. That's all I'm prepared to do for now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[42]`
**[WYBÓR GRACZA: ""No, you should go visit with Vina. But I will go in on funding the BFF after all." [-1 Budget]"]** — Mówca: **Player_Romus**
> ""No, you should go visit with Vina. But I will go in on funding the BFF after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[43]`
Mówca: **Narrator**
> "Beatrice gave me an appraising look."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[44]`
Mówca: **Beatrice Livingston (R)**
> ""My, what a pleasant surprise. I'll see to it at once.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Wehlen_FundBFF = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Wehlen_FundBFF"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[46]`
Mówca: **Narrator**
> "Beatrice drew herself upright."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[47]`

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
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[50]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Very well. Let me hear it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]`

### Węzeł `[51]`
Mówca: **Emmerich Hegel (R)**
> ""Well, you should commend your councilor for her initiative.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[52]`
Mówca: **Emmerich Hegel (R)**
> ""We don't normally issue such licenses, but for Rizia, we might consider an exception.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`
  - -> `[61]`
  - -> `[60]`

### Węzeł `[53]`
Mówca: **Emmerich Hegel (R)**
> ""Well, you two have raised an interesting possibility.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[54]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'm averse to the idea of manufacturing assault rifles. But such a license could prove useful.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]`

### Węzeł `[55]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist > 0)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`
  - -> `[57]`

### Węzeł `[56]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.PersonalValue_Pacifist > 0)*
- **Warunek (`conditionsString`):** `Variable["RiziaDLC.PersonalValue_Pacifist"] > 0`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[59]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(RiziaDLC.PersonalValue_Pacifist > 0))*
- **Warunek (`conditionsString`):** `(Variable["RiziaDLC.PersonalValue_Pacifist"] > 0) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`

### Węzeł `[58]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""We need to be able to up our arms supply the moment disaster strikes. And this would save us the headache of gun shipping.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`

### Węzeł `[59]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""Forget that inquiry ever happened. I don't want Rizian factories making deadly weapons.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[60]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""No. I'd rather keep purchasing weapons from Rumburg as usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[61]`
**[WYBÓR GRACZA]** — Mówca: **Player_Romus**
> ""I'll get back to you if and when we have the capability to make those rifles.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[62]`
Mówca: **Emmerich Hegel (R)**
> ""Then we shall continue selling you those weapons as usual.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[63]`
Mówca: **Emmerich Hegel (R)**
> ""Perfect.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[64]`
Mówca: **Emmerich Hegel (R)**
> ""Precisely my thoughts.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[65]`
Mówca: **Emmerich Hegel (R)**
> ""Nobody *wants* to use KA-74s. But when the need arises, nothing else will do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[66]`
Mówca: **Emmerich Hegel (R)**
> ""Suit yourself. I'm only bringing this up because your staff asked about it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[67]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: RiziaDLC.Diplomacy_Rumburg_RefuseKA74License = true)*
- **Efekt (`userScript`):** `Variable["RiziaDLC.Diplomacy_Rumburg_RefuseKA74License"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[68]`
Mówca: **Emmerich Hegel (R)**
> ""And family members help each other out. Almost unconditionally.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[69]`
Mówca: **Emmerich Hegel (R)**
> ""See about acquiring facilities in which to make the weapons, and I'll see what I can do.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Emmerich Hegel (R)**
> ""Remember, Your Majesty, my sister may be gone, but I am still proud to call House Toras my family.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[71]`
Mówca: **Narrator**
> "She drew closer to me. Her emeralds glinted in the lamplight."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[72]`
Mówca: **Emmerich Hegel (R)**
> ""See you at supper.""
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*
