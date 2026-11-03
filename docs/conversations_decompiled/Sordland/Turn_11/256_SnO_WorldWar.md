# Sordland/Turn11/SnO_WorldWar

- **ID konwersacji:** `256`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 11`
- **Lokalizacja pliku:** `Sordland/Turn_11/256_SnO_WorldWar.md`
- **Liczba węzłów dialogowych:** 174
- **Liczba wyborów gracza:** 21

---

## 1. Uczestnicy Sceny

- **[5]** Player *(Gracz)*
- **[6]** Player_Italic *(Gracz)*
- **[10]** Narrator
- **[24]** Dwight Walker
- **[47]** Leon Malenyev
- **[62]** Iosef Lancea

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- `BaseGame.Joined_ATO`
- `BaseGame.Joined_CSP`
- `BaseGame.Relations_Monica_Divorce`
- `BaseGame.Turn07_Personal_University_Abroad_Arcasia`
- `BaseGame.Turn07_Personal_University_Abroad_UnitedContana`
- `BaseGame.Turn07_Personal_University_Home_Public`
- `BaseGame.Turn10_SnO_FrancPulledToHolsord`
- `BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh`
- `BaseGame.Turn10_SnO_Phase1_Pincer`
- `BaseGame.Turn10_SnO_Phase2_TakeDome`
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGameIsolated.Turn11_SnO_Letter`
- `BaseGameIsolated.Turn11_SnO_Newspaper`
- `GameCondition.Turn11_SnO_WorldWar`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 4
- **Węzły modyfikujące stan gry:** 6

**Główne modyfikowane wskaźniki i kluczowe flagi:**
- `GameCondition.Turn11_SnO_WorldWar`

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[22]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- Węzeł `[31]` (Paskal Beniwoll): `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- Węzeł `[135]` (Paskal Beniwoll): `Variable["GameCondition.Turn11_SnO_WorldWar"] = true;`
- Węzeł `[166]` (Paskal Beniwoll): `PlaySoundEffect("LineDropDead");`
- Węzeł `[167]` (Paskal Beniwoll): `PlaySoundEffect("LineDropDead");`
- Węzeł `[168]` (Paskal Beniwoll): `End();`

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
> "The mood was merry in the Maroon Palace."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]`

### Węzeł `[4]`
**[WYBÓR GRACZA: "“Surely that should be no threat to our victory, right?”"]** — Mówca: **Player**
> "“Surely that should be no threat to our victory, right?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[5]`
Mówca: **Iosef Lancea**
> "“Good morning, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[6]`
Mówca: **Narrator**
> "Since the beginning of the war, we had received nothing but good news. Our army's initial successes were followed by further battlefield victories deeper in Rumburg territory."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I strolled casually into my office and closed the door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[8]`
Mówca: **Narrator**
> "Iosef entered my office for our daily war briefing. He had an unusually serious look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`

### Węzeł `[9]`
Mówca: **Narrator**
> "The daily stack of newspapers was on my desk along with a letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[10]`
Mówca: **Narrator**
> "The first thing I saw was the headline: "Conqueror Rayne", written in giant letters."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[11]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Information Hub)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`
  - -> `[18]`
  - -> `[34]`

### Węzeł `[12]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical plan, in his own words, 'Maradunen Schlium', caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Thornbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "Read the newspaper."]** — Mówca: **Player_Italic**
> "I picked up the newspaper on top of the stack."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[14]`
**[WYBÓR GRACZA: "Open the letter."]** — Mówca: **Player_Italic**
> "I opened the letter."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`

### Węzeł `[15]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`
  - -> `[17]`

### Węzeł `[16]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`

### Węzeł `[17]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Newspaper == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[18]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == false)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[20]`

### Węzeł `[19]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == false)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]`

### Węzeł `[20]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Letter == false))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == false) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[21]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: Jump to: [Information Hub])*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[22]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[23]`
Mówca: **Narrator**
> "I continued reading."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[24]`
Mówca: **Narrator**
> "'P.S.: Mom is fine and Deana might have a boyfriend.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[25]`
Mówca: **Narrator**
> "I recognized Franc's handwriting immediately."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[26]`

### Węzeł `[26]`
Mówca: **Narrator**
> ""Dear Father. I hope this letter finds you well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[27]`
Mówca: **Narrator**
> ""I just have one request: When Rumburg surrenders and you meet Queen Beatrice, give her a big fat middle finger from me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[28]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`
  - -> `[30]`

### Węzeł `[29]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Home_Public == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`

### Węzeł `[30]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Home_Public == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Home_Public"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[31]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Newspaper = true)*
- **Efekt (`userScript`):** `Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[32]`
Mówca: **Narrator**
> "Smiling, I shoved the papers to the side of my desk. I heard a knock on my door."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[33]`
Mówca: **Narrator**
> ""...After a string of triumphant victories, Rumburg's defeat seems to be imminent. We eagerly await the day when we can welcome our soldiers back home. Celebrations of Rumburg's defeat have already begun...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[34]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[35]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[36]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGameIsolated.Turn11_SnO_Letter == true && BaseGameIsolated.Turn11_SnO_Newspaper == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGameIsolated.Turn11_SnO_Letter"] == true  and  Variable["BaseGameIsolated.Turn11_SnO_Newspaper"] == true) == false`
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[37]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Pincer == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`
  - -> `[39]`

### Węzeł `[38]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_Pincer == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[39]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_Pincer == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_Pincer"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`

### Węzeł `[40]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]`
  - -> `[42]`

### Węzeł `[41]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[42]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase1_AssaultTzarsbourgh"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[170]`

### Węzeł `[43]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his radical pincer attack plan caught the enemy off guard. Our troops immediately broke their ranks and started marching towards Thornbourgh...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[44]`
Mówca: **Narrator**
> "'Best Regards, Franc Rayne.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[45]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`
  - -> `[47]`

### Węzeł `[46]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_Arcasia == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[47]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_Arcasia == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_Arcasia"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[48]`
Mówca: **Narrator**
> "I put down the paper to take a sip from my coffee."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[49]`
Mówca: **Narrator**
> ""Experts anticipate that the siege of Thornbourgh will be the last push that will drive Rumburg into a full and unconditional surrender...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`

### Węzeł `[50]`
Mówca: **Narrator**
> ""Is that how you old folks do it? I know I could've just called, but writing feels more appropriate for the occasion.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[51]`
Mówca: **Narrator**
> "'I wanted to congratulate you on our approaching victory over Rumburg. We showed them who they were messing with.'"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[52]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`
  - -> `[54]`

### Węzeł `[53]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]`

### Węzeł `[54]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn07_Personal_University_Abroad_UnitedContana == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn07_Personal_University_Abroad_UnitedContana"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]`

### Węzeł `[55]`
Mówca: **Narrator**
> "He gestured towards two generals from ATO. Our alliance had been critical to our successes in the field. We saluted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[56]`
Mówca: **Iosef Lancea**
> "“We have a couple of guests here today.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[57]`

### Węzeł `[57]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[59]`

### Węzeł `[58]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[59]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[60]`

### Węzeł `[60]`
Mówca: **Narrator**
> "He gestured towards two generals from CSP. Our alliance had been critical to our successes in the field. We saluted each other."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[61]`
Mówca: **Iosef Lancea**
> "“As you know, we are nearing a total victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]`

### Węzeł `[62]`
Mówca: **Iosef Lancea**
> "“But, there is a problem. A large one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[63]`

### Węzeł `[63]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]`
  - -> `[65]`

### Węzeł `[64]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[65]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`

### Węzeł `[66]`
Mówca: **Iosef Lancea**
> "“We received reports yesterday that CSP ramped up their support of Rumburg by delivering a thousand tonnes of military equipment to their northern port.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[67]`
Mówca: **Iosef Lancea**
> "“We received reports yesterday that ATO ramped up their support of Rumburg by delivering a thousand tonnes of military equipment by cargo plane.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[68]`
Mówca: **Iosef Lancea**
> "“They have officially declared that they will be joining the war. It is possible that Sordland will be open to an attack from the sea.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[69]`
Mówca: **Iosef Lancea**
> "“They have officially declared that they will be joining the war. It is possible that Sordland will be open to an attack from the south and west.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[70]`
Mówca: **Iosef Lancea**
> "“We may be at the Thornbourgh's doorstep, but the CSP's involvement could lose us this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[72]`
  - -> `[4]`
  - -> `[73]`

### Węzeł `[71]`
Mówca: **Iosef Lancea**
> "“We may be at the Thornbourgh's doorstep, but the ATO's involvement could lose us this war.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[77]`
  - -> `[72]`
  - -> `[4]`
  - -> `[73]`

### Węzeł `[72]`
**[WYBÓR GRACZA: "“We have come this far. We will not fall back now.”"]** — Mówca: **Player**
> "“We have come this far. We will not fall back now.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[73]`
**[WYBÓR GRACZA: "“Keep on pressing. I don't care who we are fighting against. Rumburg is finished.”"]** — Mówca: **Player**
> "“Keep on pressing. I don't care who we are fighting against. Rumburg is finished.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[76]`

### Węzeł `[74]`
Mówca: **Iosef Lancea**
> "“I agree. We need Rumburg to capitulate as quickly as possible.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[75]`
Mówca: **Iosef Lancea**
> "“Have faith in the Sordish Armed Forces and our allies, Mr. President. We will bring you victory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[76]`
Mówca: **Iosef Lancea**
> "“As you command.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[77]`
**[WYBÓR GRACZA: "“Maybe we should end this war before things escalate.”"]** — Mówca: **Player**
> "“Maybe we should end this war before things escalate.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[78]`
Mówca: **Iosef Lancea**
> "“I think we are in far too deep for that, Mr. President.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[79]`
Mówca: **Iosef Lancea**
> "“But I'm afraid that we may be past the point where we can finish the war quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[80]`
Mówca: **Iosef Lancea**
> "“The CSP's involvement is not a good sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[81]`
Mówca: **Iosef Lancea**
> "“If this escalates further and the clashes between the two factions continue, we may end up in a war the likes of which this world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[82]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`
  - -> `[84]`

### Węzeł `[83]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[84]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`

### Węzeł `[85]`
Mówca: **Iosef Lancea**
> "“If this escalates further and the clashes between the two factions continue, we may end up in a war the likes of which this world has never seen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]`

### Węzeł `[86]`
Mówca: **Iosef Lancea**
> "“The ATO's involvement is not a good sign.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[87]`
Mówca: **Iosef Lancea**
> "“A 'world war', one might call it. The war to end all wars.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]`
  - -> `[88]`
  - -> `[90]`

### Węzeł `[88]`
**[WYBÓR GRACZA: "“Sordland will end all wars when we win this one.”"]** — Mówca: **Player**
> "“Sordland will end all wars when we win this one.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[89]`
**[WYBÓR GRACZA: "“I don't even want to entertain the idea. I hope it does not come to that.”"]** — Mówca: **Player**
> "“I don't even want to entertain the idea. I hope it does not come to that.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[90]`
**[WYBÓR GRACZA: "“You might be right. If the ATO and CSP go up against each other, they won't stop until one side wins.""]** — Mówca: **Player**
> "“You might be right. If the ATO and CSP go up against each other, they won't stop until one side wins.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[91]`
Mówca: **Iosef Lancea**
> "“Say what you will, sir... this is an increasing possibility.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]`

### Węzeł `[92]`
Mówca: **Iosef Lancea**
> "“My colleagues here agree that this conflict has the potential to reach far beyond Sordland and Rumburg.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`
  - -> `[93]`
  - -> `[97]`

### Węzeł `[93]`
**[WYBÓR GRACZA: "“I am not worried. We are winning. Let's be a bit more cheerful.”"]** — Mówca: **Player**
> "“I am not worried. We are winning a war. Let's be a bit more cheerful.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[94]`
**[WYBÓR GRACZA: "“If what you said happens, do we have what it takes to come out in the winning side?”"]** — Mówca: **Player**
> "“If what you said happens, do we have what it takes to come out in the winning side?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[95]`
Mówca: **Iosef Lancea**
> "“Sir. Never before have such large armies clashed against each other.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[96]`
Mówca: **Iosef Lancea**
> "“Frankly, I don't know what would be the outcome. This is unknown territory.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]`

### Węzeł `[97]`
**[WYBÓR GRACZA: "“You are making me anxious, Iosef.”"]** — Mówca: **Player**
> "“You are making me anxious, Iosef.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[98]`
Mówca: **Narrator**
> "The phone started ringing."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[99]`
Mówca: **Narrator**
> "It was the blue phone, a direct connection to Dwight Walker."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[100]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[101]`
  - -> `[102]`

### Węzeł `[101]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`

### Węzeł `[102]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[103]`
Mówca: **Narrator**
> "It was the red phone, a a direct connection to Leon Malenyev."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[104]`
Mówca: **Narrator**
> "This line was used only for extremely urgent calls and emergencies."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[105]`
Mówca: **Iosef Lancea**
> "“Please excuse us, Mr. President. We will continue this soon.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]`

### Węzeł `[106]`
Mówca: **Narrator**
> "They left the room."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[107]`
**[WYBÓR GRACZA: "Pick up the phone."]** — Mówca: **Player_Italic**
> "I picked up the phone."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Narrator**
> "I heard Dwight Walker's voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[109]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[111]`

### Węzeł `[110]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[111]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[112]`
Mówca: **Narrator**
> "I heard Leon Malenyev's voice from the other end."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[113]`
Mówca: **Dwight Walker**
> "“Mr. President. Listen to me. There is no time to waste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]`

### Węzeł `[114]`
Mówca: **Dwight Walker**
> "“Five minutes ago, our radar detected a missile launch towards Holsord from the unoccupied territories near Thornbourgh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[115]`
Mówca: **Dwight Walker**
> "“Please get... to... safety immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[160]`

### Węzeł `[116]`
Mówca: **Dwight Walker**
> "“The... intel... confirmed....”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[117]`
Mówca: **Dwight Walker**
> "“...can't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
  - -> `[118]`

### Węzeł `[118]`
**[WYBÓR GRACZA: "“Hello?”"]** — Mówca: **Player**
> "“Hello?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[119]`
Mówca: **Dwight Walker**
> "“...don't... coming...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`
  - -> `[120]`

### Węzeł `[120]`
**[WYBÓR GRACZA: "“Hello. Can you hear me?”"]** — Mówca: **Player**
> "“Hello. Can you hear me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[121]`
Mówca: **Dwight Walker**
> "“...I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[166]`

### Węzeł `[122]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[123]`
Mówca: **Narrator**
> "Then the sirens began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[124]`
Mówca: **Leon Malenyev**
> "“Mr. President. Listen to me. There is no time to waste.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[125]`
Mówca: **Leon Malenyev**
> "“Five minutes ago, our radar detected a missile launch towards Holsord from the unoccupied territories near Thornbourgh.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[126]`
Mówca: **Leon Malenyev**
> "“Please get... to... safety immediately.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[165]`

### Węzeł `[127]`
Mówca: **Leon Malenyev**
> "“The... intel... confirmed....”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[128]`
Mówca: **Leon Malenyev**
> "“...I-”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[167]`

### Węzeł `[129]`
Mówca: **Leon Malenyev**
> "“...can't...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[164]`
  - -> `[130]`

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Hello?”"]** — Mówca: **Player**
> "“Hello?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[131]`
Mówca: **Narrator**
> "Then the sirens began."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[132]`
Mówca: **Narrator**
> "The line dropped dead."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`

### Węzeł `[133]`
Mówca: **Leon Malenyev**
> "“...don't... coming...”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]`
  - -> `[163]`

### Węzeł `[134]`
**[WYBÓR GRACZA: "“Hello. Can you hear me?”"]** — Mówca: **Player**
> "“Hello. Can you hear me?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[135]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: GameCondition.Turn11_SnO_WorldWar = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn11_SnO_WorldWar"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[168]`

### Węzeł `[136]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`
  - -> `[138]`

### Węzeł `[137]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_FrancPulledToHolsord == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[138]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_FrancPulledToHolsord == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_FrancPulledToHolsord"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[139]`
Mówca: **Narrator**
> ""Everyone at Camp Strongarm is talking about the war, obviously. And they're talking about me. Not in a good way.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[140]`
Mówca: **Narrator**
> ""But there's nothing I can do to change any of that now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]`

### Węzeł `[141]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`
  - -> `[143]`

### Węzeł `[142]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_ATO == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_ATO"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[147]`

### Węzeł `[143]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_ATO == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_ATO"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[144]`
Mówca: **Narrator**
> ""I can't help but think about all my friends and squadmates on the front lines. I know I'm lucky to be deployed here in Holsord, but part of me wishes I could be there fighting with them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[145]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[146]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being the son of the commander-in-chief of the winning side.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[147]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in Arcasia. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[148]`
Mówca: **Narrator**
> ""Everyone's talking about the war here in United Contana. I have to say it feels pretty nice being part of the winning coalition.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[149]`
Mówca: **Narrator**
> ""Everyone's talking about the war here at school. I know I complain about how hard it is being your son sometimes, but I have to say it feels pretty nice right now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[150]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`
  - -> `[152]`

### Węzeł `[151]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Joined_CSP == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Joined_CSP"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[152]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Joined_CSP == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Joined_CSP"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`

### Węzeł `[153]`
Mówca: **Narrator**
> ""That said... I can't help but think about all the guys who're still dying over there. That could be me. Considering how badly I flunked my exams, it probably should be me.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[154]`
Mówca: **Narrator**
> ""Still... I wonder if you and the other bigwigs back in Holsord know the real cost of this war. It's not just that I could've died. It's that some of the things I've done make me wish I had.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[155]`
Mówca: **Narrator**
> ""It's hard for me and the other guys to sleep at night. I can only hope the memories will go away with time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[156]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`
  - -> `[158]`

### Węzeł `[157]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Relations_Monica_Divorce == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Relations_Monica_Divorce"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[158]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Relations_Monica_Divorce == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Relations_Monica_Divorce"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[159]`
Mówca: **Iosef Lancea**
> "“And I'm afraid that we may be past the point where we can finish the war quickly.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[160]`
Mówca: **Narrator**
> "I heard the crackling of static. President Walker's words were becoming harder to distinguish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`

### Węzeł `[161]`
**[WYBÓR GRACZA: "“Is everything all right?”"]** — Mówca: **Player**
> "“I didn't quite catch that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]`

### Węzeł `[162]`
**[WYBÓR GRACZA: ""Mr. Walker! What's going on?""]** — Mówca: **Player**
> ""Mr. Walker! What's going on?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[163]`
**[WYBÓR GRACZA: "“Comrade Malenyev! Is everything all right?""]** — Mówca: **Player**
> "“Comrade Malenyev! Is everything all right?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[164]`
**[WYBÓR GRACZA: "“I didn't quite catch that.""]** — Mówca: **Player**
> "“I didn't quite catch that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]`

### Węzeł `[165]`
Mówca: **Narrator**
> "I heard the crackling of static. Malenyev's words were becoming harder to distinguish."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[166]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("LineDropDead");)*
- **Efekt (`userScript`):** `PlaySoundEffect("LineDropDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`

### Węzeł `[167]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: PlaySoundEffect("LineDropDead");)*
- **Efekt (`userScript`):** `PlaySoundEffect("LineDropDead");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]`

### Węzeł `[168]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[169]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy. Our troops were victorious in their assault and tipped the scales in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[170]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[171]`
  - -> `[172]`

### Węzeł `[171]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: BaseGame.Turn10_SnO_Phase2_TakeDome == true)*
- **Warunek (`conditionsString`):** `Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[173]`

### Węzeł `[172]`
Mówca: **Paskal Beniwoll**
*(Węzeł logiki narracyjnej: !(BaseGame.Turn10_SnO_Phase2_TakeDome == true))*
- **Warunek (`conditionsString`):** `(Variable["BaseGame.Turn10_SnO_Phase2_TakeDome"] == true) == false`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[169]`

### Węzeł `[173]`
Mówca: **Narrator**
> ""Defense minister Iosef Lancea was the man of the hour as his superior strategies broke the morale of the enemy at Dome. Following that operation, our troops were victorious in their assaults towards their capital and tipped the scales in our favor.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`
