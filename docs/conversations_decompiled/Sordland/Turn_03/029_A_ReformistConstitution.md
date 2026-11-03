# Sordland/Turn03/A_ReformistConstitution

- **ID konwersacji:** `29`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/029_A_ReformistConstitution.md`
- **Liczba węzłów dialogowych:** 163
- **Liczba wyborów gracza:** 56

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
- **[9]** Nia Morgna
- **[10]** Narrator
- **[38]** Lucian Galade
- **[41]** Livia Suno

---

## 2. Zmienne Gry (Stan Narracyjny)

### Czytane zmienne warunkowe (`conditionsString`):
- *Brak sprawdzanych zmiennych.*

### Modyfikowane zmienne stanu (`userScript`):
- `BaseGame.ReformProposal_Open`
- `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis`
- `BaseGameSupport.News_Turn03_LT_BenfiFestival`
- `GameCondition.Turn03_A_Pre_Constitution`

### Skoki między-konwersacyjne:
- Węzeł `[159]` -> **[30] Sordland/Turn03/Reformist Post Discussion** (../Turn_03/030_Reformist_Post_Discussion.md), Węzeł `[1]`

---

## 3. Podsumowanie Węzłowe i Kluczowe Odgałęzienia

- **Węzły kończące (Terminal Nodes):** 1
- **Węzły modyfikujące stan gry:** 7

**Węzły wykonujące kluczowe operacje skryptowe:**
- Węzeł `[152]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- Węzeł `[157]` (Lucian Galade): `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- Węzeł `[158]` (Lucian Galade): `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- Węzeł `[159]` (Lucian Galade): `ShowPagedDecisionsPanel("Panel_ReformistConstitution"); -- Shows Paged Decisions Panel with the n...`
- Węzeł `[160]` (Lucian Galade): `Variable["BaseGame.ReformProposal_Open"] = true;`
- Węzeł `[161]` (Lucian Galade): `End();`
- Węzeł `[162]` (Lucian Galade): `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`

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
> "I was walking to my office, since today was the day to edit and make the final changes for the proposal to change the Constitution of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]`

### Węzeł `[4]`
Mówca: **Narrator**
> "Not long after, Petr, Lucian and Nia arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]`
  - -> `[6]`
  - -> `[30]`

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Finally!”"]** — Mówca: **Player**
> "“Finally!”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the huge decisions I was going to take."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]`

### Węzeł `[8]`
Mówca: **Narrator**
> "At the entrance to my office, my secretary Livia greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]`

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]`

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""Good morning! Time to finally get this proposal going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]`

### Węzeł `[11]`
Mówca: **Narrator**
> "The reform committee finally bore tangible results and the draft of the changes were about to be presented to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]`

### Węzeł `[12]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]`
  - -> `[14]`

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]`

### Węzeł `[14]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]`

### Węzeł `[15]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]`

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[20]`

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]`
  - -> `[18]`
  - -> `[20]`

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]`

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I'm perfectly fine.""]** — Mówca: **Player**
> "“I'm perfectly fine.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]`

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]`

### Węzeł `[21]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]`

### Węzeł `[22]`
Mówca: **Livia Suno**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[23]`
Mówca: **Livia Suno**
> ""Sorry to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[24]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]`

### Węzeł `[25]`
**[WYBÓR GRACZA: "“You'll find out with the rest of Sordland, sweetheart.""]** — Mówca: **Player**
> "“You'll find out with the rest of Sordland, sweetheart.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I'll take that into consideration.""]** — Mówca: **Player**
> "“I'll take that into consideration.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Nothing's been decided yet.""]** — Mówca: **Player**
> ""Nothing's been decided yet.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]`

### Węzeł `[28]`
**[WYBÓR GRACZA: "“That's none of your business, Livia.""]** — Mówca: **Player**
> "“That's none of your business, Livia.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]`

### Węzeł `[29]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I entered my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]`

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]`

### Węzeł `[31]`
Mówca: **Narrator**
> "Petr placed the draft in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]`

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""After your modifications, we will be starting the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]`
  - -> `[147]`

### Węzeł `[33]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""I have suggested to bring some limitations to decrees regarding their applicability. While we keep them, we should try to make sure that they will only be used in emergency situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]`

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[36]`
**[WYBÓR GRACZA: ""It's just a title, Mrs. Morgna.""]** — Mówca: **Player**
> ""It's just a title, Mrs. Morgna.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Mr. President. Unless you wish to be like Colonel Soll after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]`

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""We could start talking about Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]`

### Węzeł `[39]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[40]`
**[WYBÓR GRACZA: ""If our own democracy is the reason of our downfall, we will have to accept it.""]** — Mówca: **Player**
> ""If our own democracy is the reason of our downfall, we will have to accept it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]`

### Węzeł `[41]`
**[WYBÓR GRACZA: ""It's not unfair that former Presidents get some special treatment.""]** — Mówca: **Player**
> ""It's not unfair that former Presidents get some special treatment.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""It is a matter of both when we have the Communist Party and the Workers Party of Bludia getting more than five percent vote in the last elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]`

### Węzeł `[43]`
Mówca: **Petr Vectern**
> ""Well, regardless of what Mr. Rayne decides, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]`
  - -> `[150]`

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Most reformists want the impeachment to be initiated by the Assembly. They think they do not have any power over potential rogue presidents that would abuse their power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]`
  - -> `[47]`

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""Don't forget that the Communist Party and the Workers Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]`

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""You're right. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP was barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[47]`
**[WYBÓR GRACZA: ""The Assembly should have oversight over the President.""]** — Mówca: **Player**
> ""The Assembly should have oversight over the President, it is the most democratic institution.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Not sure if it is correct to chastise the President this much though.""]** — Mówca: **Player**
> ""Not sure if it is correct to chastise the President this much though.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]`

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]`
  - -> `[41]`

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such a title, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]`
  - -> `[36]`

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""The reformists would be completely behind that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""I agree. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP is barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[53]`
Mówca: **Nia Morgna**
> ""Do you want to protect Tarquin Soll, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]`
  - -> `[35]`

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]`

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]`

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We could even remove impeachment altogether.""]** — Mówca: **Player**
> ""We could even remove impeachment altogether, I can get total immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]`

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I agree, we should abolish this position.""]** — Mówca: **Player**
> ""I agree, we should abolish this position.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]`

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]`

### Węzeł `[60]`
**[WYBÓR GRACZA: ""We should define a better impeachment process.""]** — Mówca: **Player**
> ""We should define a more refined impeachment process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]`

### Węzeł `[61]`
Mówca: **Nia Morgna**
> ""I think this is a national matter, Mr. Rayne. Not a partisan one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]`

### Węzeł `[62]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]`

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]`

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]`

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Maybe reforms are not a great idea after all.""]** — Mówca: **Player**
> ""Maybe the reforms are not a great idea after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]`

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""Many Sordish citizens feel they're not represented in the Assembly. This is a matter of representative democracy in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]`

### Węzeł `[67]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]`

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]`
  - -> `[65]`
  - -> `[60]`
  - -> `[57]`

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""We must get rid of this senseless law that protects him. He should be able to face justice for the atrocities that had taken place during his rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]`
  - -> `[62]`
  - -> `[63]`
  - -> `[64]`

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Of course that would also mean that USP might lose its majority in the Assembly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]`
  - -> `[97]`
  - -> `[92]`
  - -> `[90]`

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has that title. He gave it to himself right after his military coup. This law is basically made to save the Colonel and it has a symbolic importance for Sordland because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]`

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]`

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Mr. Ricter and his PFJP definitely wants to see change on this topic. They find our 10% threshold to be antidemocratic. Which is something I also agree with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]`

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]`

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""I agree with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[76]`
**[WYBÓR GRACZA: ""This is out of the question.""]** — Mówca: **Player**
> ""This is out of the question.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]`

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]`

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""While I do not have strong opinions about this point, these reforms are vital for the future of our democracy, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are aware about the current wind of change. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]`

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""Yes, we will be collaboratively working on the specifics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""That is a better strategy. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]`

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]`

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]`

### Węzeł `[87]`
**[WYBÓR GRACZA: ""They should be able to be impeached. Why do I get to be impeached but not them?""]** — Mówca: **Player**
> ""They should be able to be impeached. Why do I get to be impeached but not them?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]`

### Węzeł `[88]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]`

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]`

### Węzeł `[90]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly and endanger Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]`

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I don't think that's a wise idea to include in the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]`

### Węzeł `[92]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that.""]** — Mówca: **Player**
> ""We can't just give away our majority like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""We will make sure the Old Guards won't control the Court any longer, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[94]`
Mówca: **Petr Vectern**
> ""Well, they need absolute immunity in theory. But look at what reality got us? We've got to deal with the most corrupt Chief Justice in the world, with no chance to deal with him!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]`
  - -> `[87]`
  - -> `[88]`
  - -> `[89]`

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Section 6. This is about the presidential decrees. Reformists demand more limitations to the President's executive powers. Mr. Ricter has demanded them to be completely removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]`

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Uhm. The next one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]`

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]`

### Węzeł `[98]`
**[WYBÓR GRACZA: ""We'll work with the reformists to limit the use of decrees.""]** — Mówca: **Player**
> ""We'll work with the reformists to limit the use of decrees.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]`

### Węzeł `[99]`
**[WYBÓR GRACZA: ""But the high threshold is the reason why Sordish politics has become so isolated.""]** — Mówca: **Player**
> ""But the high threshold is the reason why Sordish politics has become isolated to this degree.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]`

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""While I agree that the current court members are *problematic*, this is no way to resolve it. The law is supposed to ensure the judiciary's independence by giving legal protection so they can't be pressured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]`

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold for better representation.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold for better representation in our democracy.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]`

### Węzeł `[102]`
Mówca: **Nia Morgna**
> ""I do not support taking away their power for yourself, Mr. President. The judiciary must be independent and long-lasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]`

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]`

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]`

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]`

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]`

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Even Soll knew he had to leave, but we will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]`
  - -> `[114]`
  - -> `[109]`

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]`

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I will take my time and seriously consider the options before settling on one.""]** — Mówca: **Player**
> ""I will take my time and seriously consider the options before settling on one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Yes, he did. But it took a long time.""]** — Mówca: **Player**
> ""Yes, he did. But it took a long time.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[111]`
Mówca: **Nia Morgna**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]`

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""There is definitely a demand to involve the Assembly in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]`
  - -> `[120]`
  - -> `[119]`

### Węzeł `[113]`
Mówca: **Lucian Galade**
> ""It could be destabilising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]`

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I agree. People should be able to elect the same person if they want to.""]** — Mówca: **Player**
> ""I agree. People should be able to elect the same person if they want to.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]`

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]`

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]`

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]`

### Węzeł `[118]`
Mówca: **Nia Morgna**
> ""We can't allow somebody like Soll holding unto his seat for two decades again. We should establish limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]`

### Węzeł `[120]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]`

### Węzeł `[121]`
Mówca: **Lucian Galade**
> ""They want us to include previously non-existing term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[122]`
**[WYBÓR GRACZA: ""That's going a bit too far.""]** — Mówca: **Player**
> ""I think that's going a bit too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]`

### Węzeł `[123]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]`

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""I hope it works out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""I know it is a delicate matter, sir. But you still have time to think about these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]`

### Węzeł `[127]`
Mówca: **Nia Morgna**
> ""I agree. We can't allow somebody like Soll holding unto his seat for two decades again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]`

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""We could also make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]`
  - -> `[98]`
  - -> `[77]`

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[130]`
Mówca: **Nia Morgna**
> ""That was my suggestion as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]`

### Węzeł `[131]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]`

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]`

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Term limits are necessary.""]** — Mówca: **Player**
> ""Term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]`

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]`

### Węzeł `[135]`
Mówca: **Nia Morgna**
> ""Maybe. But Mr. Ricter doesn't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]`

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. The party, and I mean, not even Albin wants us to change the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]`

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""Next one is Section 7. Term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]`
  - -> `[132]`
  - -> `[133]`
  - -> `[134]`

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Mr. Clavin and our party's reformist wing has no problems with the current law. I'm sure PFJP can be persuaded too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]`

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]`
  - -> `[101]`
  - -> `[106]`
  - -> `[76]`

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""I'm sure the reformists would completely support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[141]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""Frens will probably demand that we remove them completely. But he forgets that Sordland is a Presidential Republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[143]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]`

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""If the entire package is to their liking, I don't think Frens will resist his own. He wouldn't say no to such major changes just because of a few small details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]`

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""Sure. You'll have a long time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]`

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Let's start.”"]** — Mówca: **Player**
> "“Let's start.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]`

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Can we go over each of the points that are in discussion for the draft?”"]** — Mówca: **Player**
> "“Can we go over each of the points that are in discussion for the draft?”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]`

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""Well, apart from the first two sections of decreasing the Supreme Court's authority and limiting the presidential vetoes... Nothing else has been agreed on unanimously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]`

### Węzeł `[149]`
**[WYBÓR GRACZA: "“Let's start working on the draft.”"]** — Mówca: **Player**
> "“Let's start working on the draft.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[150]`
**[WYBÓR GRACZA: "“I thank you all for your input.”"]** — Mówca: **Player**
> "“I thank you all for your input.”"
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]`

### Węzeł `[151]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]`

### Węzeł `[152]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_LT_BenfiFestival = true)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]`

### Węzeł `[153]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]`

### Węzeł `[154]`
Mówca: **Livia Suno**
> ""Mr. Rayne -- can you give me a hint about your reform plans? If you ask me, taking away the judges' immunity is long overdue, but it might anger a lot of people in these halls...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]`
  - -> `[26]`
  - -> `[27]`
  - -> `[28]`

### Węzeł `[155]`
Mówca: **Livia Suno**
> ""Understood. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[156]`
Mówca: **Livia Suno**
> ""I hope you'll keep me informed. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]`

### Węzeł `[157]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Pre_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]`

### Węzeł `[158]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: GameCondition.Turn03_A_Pre_Constitution = true)*
- **Efekt (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]`

### Węzeł `[159]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: ShowPagedDecisionsPanel("Panel_ReformistConstitution");

// Shows Paged Decisions Panel with the name in database)*
- **Efekt (`userScript`):** `ShowPagedDecisionsPanel("Panel_ReformistConstitution");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> **[SKOK DO INNEJ ROZMOWY]** Conv `30` (*Sordland/Turn03/Reformist Post Discussion*), Węzeł `[1]`

### Węzeł `[160]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGame.ReformProposal_Open = true)*
- **Efekt (`userScript`):** `Variable["BaseGame.ReformProposal_Open"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]`

### Węzeł `[161]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: End();)*
- **Efekt (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]`

### Węzeł `[162]`
Mówca: **Lucian Galade**
*(Węzeł logiki narracyjnej: BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;)*
- **Efekt (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]`
