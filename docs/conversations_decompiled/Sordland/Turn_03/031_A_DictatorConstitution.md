# Sordland/Turn03/A_DictatorConstitution

- **ID konwersacji:** `31`
- **StoryPack:** `Sordland`
- **Tura:** `Tura 03`
- **Lokalizacja pliku:** `Sordland/Turn_03/031_A_DictatorConstitution.md`
- **Liczba węzłów dialogowych:** 157
- **Liczba wyborów gracza:** 52

---

## 1. Uczestnicy Sceny

- **[4]** Petr Vectern
- **[5]** Player *(Gracz)*
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
- Węzeł `[153]` -> **[32] Sordland/Turn03/Dictator Post Discussion** (../Turn_03/032_Dictator_Post_Discussion.md), Węzeł `[1]`

---

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[7]` | **"“Greetings.”"** | `[6]` **Narrator**: "Not long after, Petr and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Petr Vectern**: ""Good morning! Time to finally g..." |
| `[8]` | **"“Finally!”"** | `[6]` **Narrator**: "Not long after, Petr and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Petr Vectern**: ""Good morning! Time to finally g..." |
| `[13]` | **"“Good morning everybody.”"** | `[6]` **Narrator**: "Not long after, Petr and Lucian ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[3]` **Petr Vectern**: ""Good morning! Time to finally g..." |
| `[15]` | **""Maybe we shouldn't mess with the Court much to keep them on our side.""** | `[20]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[30]` **Petr Vectern**: ""Yes, we'll need the help of som..." |
| `[19]` | **""We could add the Assembly in the process but make impeachment possible only with ..."** | `[20]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[24]` **Lucian Galade**: ""That's a good idea. That'd make..." |
| `[26]` | **""No, I think we should respect this law.""** | `[89]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[72]` **Petr Vectern**: ""I agree. This really has no imp..." |
| `[35]` | **""I don't aim to leave any time soon. We keep the unlimited terms.""** | `[85]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[42]` **Lucian Galade**: ""I agree, we could keep that in."" |
| `[39]` | **""What if we don't succeed? The Court can have me impeached for this.""** | `[20]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[38]` **Lucian Galade**: ""Yes, they are already trying to..." |
| `[40]` | **""We'll get rid of this law entirely.""** | `[20]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[41]` **Lucian Galade**: ""I see."" |
| `[46]` | **""We could introduce a confidence vote.""** | `[43]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[48]` **Lucian Galade**: ""That is not bad idea. As long a..." |
| `[47]` | **""I agree. We should involve the Assembly more in the process.""** | `[43]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Lucian Galade**: ""Some reformists suggested that ..." |
| `[55]` | **""Term Limits?""** | `[85]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Lucian Galade**: ""Yes. Tarquin Soll governed for ..." |
| `[57]` | **""Because we could use it too.""** | `[73]` **Petr Vectern**: ""That would be enough to hold hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[36]` **Petr Vectern**: ""Unlikely to have 100% vote to p..." |
| `[58]` | **""We should definitely work to decrease the threshold to some degree.""** | `[51]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[70]` **Lucian Galade**: ""That's a possibility. It might ..." |
| `[59]` | **""Do you think it would really hurt the party?""** | `[51]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[69]` **Lucian Galade**: ""A decrease would definitely hur..." |
| `[60]` | **""A decrease is out of the question.""** | `[51]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[74]` **Petr Vectern**: ""Yeah, it should be."" |
| `[61]` | **""Regardless of him, I see no problem with having a special title for great heroes.""** | `[72]` **Petr Vectern**: ""I agree. This really has no imp..."<br>`[73]` **Petr Vectern**: ""That would be enough to hold hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Petr Vectern**: ""You're right..."" |
| `[62]` | **""Yes, he is a hero for Sordland.""** | `[72]` **Petr Vectern**: ""I agree. This really has no imp..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[25]` **Petr Vectern**: ""You're right..."" |
| `[63]` | **""It's not unfair that former Presidents get some special treatment.""** | `[75]` **Petr Vectern**: ""Oh, so you want to use the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Petr Vectern**: ""Yeah, that's fair."" |
| `[64]` | **""After pushing aggressive changes, I may need the same immunity.""** | `[75]` **Petr Vectern**: ""Oh, so you want to use the same..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[34]` **Petr Vectern**: ""Yeah, that's fair."" |
| `[76]` | **""Every President should gain that title after their term.""** | `[89]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Petr Vectern**: ""Oh, so you want to use the same..." |
| `[77]` | **""We could keep the title but take away the immunity clause.""** | `[89]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[73]` **Petr Vectern**: ""That would be enough to hold hi..." |
| `[81]` | **""We should abolish this position.""** | `[89]` **Petr Vectern**: ""I think some of the reformists ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[65]` **Petr Vectern**: ""The reformists would like that."" |
| `[82]` | **""We should respect their immunity.""** | `[37]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[98]` **Petr Vectern**: ""That might be the best thing to..." |
| `[83]` | **""I will instead give the President the ability to replace Judges as necessary.""** | `[37]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[119]` **Lucian Galade**: ""That's very bold, sir. But I li..." |
| `[92]` | **""Uh-oh.""** | `[85]` **Lucian Galade**: ""For now I'll move onto the next..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Lucian Galade**: ""Yes. Tarquin Soll governed for ..." |
| `[95]` | **""I may need to think a bit longer about this.""** | `[21]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[68]` **Petr Vectern**: ""Sure. You'll have some time bef..." |
| `[96]` | **""We should crush the Old Guards to clear ways for further reforms.""** | `[37]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[115]` **Petr Vectern**: ""Hell yes, we should."" |
| `[97]` | **""Maybe we shouldn't make the Supreme Court our enemies just yet.""** | `[37]` **Petr Vectern**: ""If we can remove their immunity..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[120]` **Lucian Galade**: ""That is a fair concern. We'll n..." |
| `[99]` | **""We should strengthen the decrees further, so they have priority over statute law.""** | `[21]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Lucian Galade**: ""That is pretty powerful, indeed..." |
| `[100]` | **""Don't worry. With these reforms, we will be even more popular.""** | `[87]` **Petr Vectern**: ""You would be opening their way ..."<br>`[117]` **Lucian Galade**: ""Well, we can't know these for s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[112]` **Petr Vectern**: ""I hope so."" |
| `[101]` | **""We can't just give away our majority like that anyway.""** | `[87]` **Petr Vectern**: ""You would be opening their way ..."<br>`[88]` **Petr Vectern**: ""An increase on the other hand i..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Petr Vectern**: ""Of course not."" |
| `[102]` | **""We can't allow communists to enter the Assembly.""** | `[87]` **Petr Vectern**: ""You would be opening their way ..."<br>`[88]` **Petr Vectern**: ""An increase on the other hand i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[114]` **Lucian Galade**: ""Yes, it could be destabilizing."" |
| `[103]` | **""We should open their way and unite the left.""** | `[87]` **Petr Vectern**: ""You would be opening their way ..."<br>`[88]` **Petr Vectern**: ""An increase on the other hand i..."<br>*(oraz 1 innych węzłów)* | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[109]` **Narrator**: "Lucian couldn't hide the surpris..." |
| `[107]` | **""I don't think presidential decrees need any reforms.""** | `[21]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[90]` **Lucian Galade**: ""Me neither. I think it's import..." |
| `[108]` | **""Yes, we can make it dependent on enabling acts.""** | `[21]` **Petr Vectern**: ""We could try to balance it with..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[93]` **Lucian Galade**: ""Mr. Ricter will probably demand..." |
| `[110]` | **""We should keep using the threshold to our advantage.""** | `[88]` **Petr Vectern**: ""An increase on the other hand i..."<br>`[117]` **Lucian Galade**: ""Well, we can't know these for s..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[104]` **Lucian Galade**: ""I agree, sir."" |
| `[111]` | **""It's fine as it is.""** | `[43]` **Lucian Galade**: ""So there is no reason to change..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: ""I guess so."" |
| `[116]` | **""We could simply increase it.""** | `[51]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Lucian Galade**: ""10% seems already too high for ..." |
| `[121]` | **"“Let's start.”"** | `[5]` **Lucian Galade**: ""After your modifications, we wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[14]` **Narrator**: "After placing the committee's re..." |
| `[122]` | **"“Can we go over each of the points that are in discussion for the draft?”"** | `[5]` **Lucian Galade**: ""After your modifications, we wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lucian Galade**: ""Well, apart from the first two ..." |
| `[124]` | **"“I thank you all for your input.”"** | `[125]` **Petr Vectern**: ""Well, regardless of what you de..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[127]` **Narrator**: "After placing the committee's re..." |
| `[126]` | **"“Let's start working on the draft.”"** | `[125]` **Petr Vectern**: ""Well, regardless of what you de..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[127]` **Narrator**: "After placing the committee's re..." |
| `[130]` | **"“Good morning, Livia.”"** | `[129]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[139]` **Livia Suno**: ""How are you today, sir?"" |
| `[131]` | **""How are you today?""** | `[129]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[134]` **Livia Suno**: ""Fine, thank you."" |
| `[133]` | **"“I'm perfectly fine.""** | `[137]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[139]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[149]` **Livia Suno**: ""Good to hear."" |
| `[138]` | **""Nothing's been decided yet.""** | `[136]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Livia Suno**: ""I hope you'll keep me informed...." |
| `[143]` | **"“I'll take that into consideration.""** | `[136]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[140]` **Livia Suno**: ""I hope you'll keep me informed...." |
| `[145]` | **"“I'm about to make stressful decisions. So, not feeling that great.”"** | `[137]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[139]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[132]` **Livia Suno**: ""Sorry to hear."" |
| `[146]` | **"“It's none of your business, Livia.""** | `[136]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Livia Suno**: ""Understood. I'll take your coat..." |
| `[147]` | **"“I feel better now that I've seen you, Livia.""** | `[137]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[139]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[144]` **Narrator**: "She averted her eyes away from m..." |
| `[150]` | **"“You'll find out along with the rest of Sordland, sweetheart.""** | `[136]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[141]` **Livia Suno**: ""Understood. I'll take your coat..." |

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
  - -> `[9]` (*Narrator: "I was walking to my office, since today was the day to ed..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Petr Vectern**
> ""Good morning! Time to finally get this proposal going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Petr placed the draft in front of me."*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Petr placed the draft in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Lucian Galade: ""After your modifications, we will be starting the proces..."*)

### Węzeł `[5]`
Mówca: **Lucian Galade**
> ""After your modifications, we will be starting the process, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Player: "“Let's start.”"*)
  - -> `[122]` (*Player: "“Can we go over each of the points that are in discussion..."*)

### Węzeł `[6]`
Mówca: **Narrator**
> "Not long after, Petr and Lucian arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Player: "“Greetings.”"*)
  - -> `[8]` (*Player: "“Finally!”"*)
  - -> `[13]` (*Player: "“Good morning everybody.”"*)

### Węzeł `[7]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Petr Vectern: ""Good morning! Time to finally get this proposal going.""*)

### Węzeł `[8]`
**[WYBÓR GRACZA: "“Finally!”"]** — Mówca: **Player**
> "“Finally!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Petr Vectern: ""Good morning! Time to finally get this proposal going.""*)

### Węzeł `[9]`
Mówca: **Narrator**
> "I was walking to my office, since today was the day to edit and make the final changes for the proposal to change the Constitution of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_BenfiFestival = true"*)

### Węzeł `[10]`
Mówca: **Narrator**
> "The reform committee finally bore tangible results and the draft of the changes were about to be presented."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "I walked in the marble corridors of the Palace, thinking ..."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the massive steps we were about to take."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Narrator: "My secretary Livia greeted me at the entrance to my office."*)

### Węzeł `[12]`
Mówca: **Narrator**
> "My secretary Livia greeted me at the entrance to my office."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Livia Suno: ""Good morning, Mr. President.""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[6]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[3]` (*Petr Vectern: ""Good morning! Time to finally get this proposal going.""*)

### Węzeł `[14]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_DictatorConstitution");"*)

### Węzeł `[15]`
**[WYBÓR GRACZA: ""Maybe we shouldn't mess with the Court much to keep them on our side.""]** — Mówca: **Player**
> ""Maybe we shouldn't mess with the Court much to keep them on our side.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[30]` (*Petr Vectern: ""Yes, we'll need the help of some of the Judges in the pr..."*)

### Węzeł `[16]`
Mówca: **Lucian Galade**
> ""We could try to make the impeachment process more difficult or entirely get rid of it. A change like this would give you free reign. However, that might be going a little too far.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[18]` (*Petr Vectern: ""This law is particularly dangerous for you in this case...."*)

### Węzeł `[17]`
Mówca: **Lucian Galade**
> ""We can start talking about Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Lucian Galade: ""We could try to make the impeachment process more diffic..."*)

### Węzeł `[18]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[20]` (*Petr Vectern: ""...They will be looking for anything they can declare un..."*)

### Węzeł `[19]`
**[WYBÓR GRACZA: ""We could add the Assembly in the process but make impeachment possible only with an absolute majority.""]** — Mówca: **Player**
> ""We could add the Assembly in the process but make impeachment only possible with an absolute majority.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Lucian Galade: ""That's a good idea. That'd make impeachment close to imp..."*)

### Węzeł `[20]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""What if we don't succeed? The Court can have me impeache..."*)
  - -> `[40]` (*Player: ""We'll get rid of this law entirely.""*)
  - -> `[19]` (*Player: ""We could add the Assembly in the process but make impeac..."*)
  - -> `[15]` (*Player: ""Maybe we shouldn't mess with the Court much to keep them..."*)

### Węzeł `[21]`
Mówca: **Petr Vectern**
> ""We could try to balance it with the reformists and make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Player: ""I don't think presidential decrees need any reforms.""*)
  - -> `[108]` (*Player: ""Yes, we can make it dependent on enabling acts.""*)
  - -> `[99]` (*Player: ""We should strengthen the decrees further, so they have p..."*)
  - -> `[95]` (*Player: ""I may need to think a bit longer about this.""*)

### Węzeł `[22]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Lucian Galade: ""According to the Constitution, the Member of Honor not o..."*)

### Węzeł `[23]`
Mówca: **Lucian Galade**
> ""We will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Lucian Galade: ""Now I'll move unto the 8th Section. We are reaching the ..."*)

### Węzeł `[24]`
Mówca: **Lucian Galade**
> ""That's a good idea. That'd make impeachment close to impossible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[25]`
Mówca: **Petr Vectern**
> ""You're right...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[26]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Petr Vectern: ""I agree. This really has no importance for the new Const..."*)

### Węzeł `[27]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Lucian Galade: ""We will leave it to the President to decide.""*)

### Węzeł `[28]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Lucian Galade: ""So there is no reason to change this unless you want to ..."*)

### Węzeł `[29]`
Mówca: **Lucian Galade**
> ""But of course, I don't.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[30]`
Mówca: **Petr Vectern**
> ""Yes, we'll need the help of some of the Judges in the process. Keeping some of their powers might make them more willing to get in dialogue with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[31]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Lucian Galade: ""It's the question about the immunity of the Judges. Whil..."*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""I'll move on to Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[28]` (*Lucian Galade: ""This is regarding the appointment of ministers. Currentl..."*)

### Węzeł `[33]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Petr Vectern: ""If we can remove their immunity or define an impeachment..."*)

### Węzeł `[34]`
Mówca: **Petr Vectern**
> ""Yeah, that's fair.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Lucian Galade: ""I agree, we could keep that in.""*)

### Węzeł `[36]`
Mówca: **Petr Vectern**
> ""Unlikely to have 100% vote to pass. But I hear you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[37]`
Mówca: **Petr Vectern**
> ""If we can remove their immunity or define an impeachment process, we could clean the Court from Orso and his gang.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Player: ""We should respect their immunity.""*)
  - -> `[83]` (*Player: ""I will instead give the President the ability to replace..."*)
  - -> `[96]` (*Player: ""We should crush the Old Guards to clear ways for further..."*)
  - -> `[97]` (*Player: ""Maybe we shouldn't make the Supreme Court our enemies ju..."*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are expecting reforms. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""Yes, they are already trying to hit you since they are e..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""We'll get rid of this law entirely.""]** — Mówca: **Player**
> ""We'll get rid of this law entirely.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[20]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[41]` (*Lucian Galade: ""I see.""*)

### Węzeł `[41]`
Mówca: **Lucian Galade**
> ""I see.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""I'll move on to Section 4.""*)

### Węzeł `[42]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[27]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[43]`
Mówca: **Lucian Galade**
> ""So there is no reason to change this unless you want to sell this to the opposition parties. Sharing the power with the Assembly may make them sympathetic to you. This might be important for the NFP as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Player: ""It's fine as it is.""*)
  - -> `[46]` (*Player: ""We could introduce a confidence vote.""*)
  - -> `[47]` (*Player: ""I agree. We should involve the Assembly more in the proc..."*)

### Węzeł `[44]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. The party, and I mean, not even Albin wants us to change the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Lucian Galade: ""Not wrong. The ten percent threshold is what that allowe..."*)

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""I'm sure some of the reformists may support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[46]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Lucian Galade: ""That is not bad idea. As long as we are the majority in ..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Lucian Galade: ""Some reformists suggested that the Assembly should nomin..."*)

### Węzeł `[48]`
Mówca: **Lucian Galade**
> ""That is not bad idea. As long as we are the majority in the Assembly, that does not change too much.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""I'm sure some of the reformists may support that.""*)

### Węzeł `[49]`
Mówca: **Lucian Galade**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Petr Vectern: ""Of course, according to the ratio of the party's in gove..."*)

### Węzeł `[50]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[51]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""We could simply increase it.""*)
  - -> `[58]` (*Player: ""We should definitely work to decrease the threshold to s..."*)
  - -> `[59]` (*Player: ""Do you think it would really hurt the party?""*)
  - -> `[60]` (*Player: ""A decrease is out of the question.""*)

### Węzeł `[52]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible. We could try working with them but it is simpler to keep the law.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Petr Vectern: ""Yes, but this is a delicate matter. The party, and I mea..."*)

### Węzeł `[53]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Lucian Galade: ""But of course, I don't.""*)

### Węzeł `[54]`
Mówca: **Petr Vectern**
> ""Two major left parties; the Communist Party of Sordland and the Workers Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Petr Vectern: ""Decreasing the threshold might mean opening their way in..."*)

### Węzeł `[55]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""Yes. Tarquin Soll governed for twenty years. It seems hi..."*)

### Węzeł `[56]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Lucian Galade: ""We are at the 6th. This is about the presidential decree..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""Because we could use it too.""]** — Mówca: **Player**
> ""Because we could use it too.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[73]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[36]` (*Petr Vectern: ""Unlikely to have 100% vote to pass. But I hear you.""*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold to some degree.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold to some degree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""That's a possibility. It might make the reformists more ..."*)

### Węzeł `[59]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Lucian Galade: ""A decrease would definitely hurt our position in the fut..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""A decrease is out of the question.""]** — Mówca: **Player**
> ""A decrease is out of the question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Petr Vectern: ""Yeah, it should be.""*)

### Węzeł `[61]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Petr Vectern), `[73]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""You're right...""*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[72]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Petr Vectern: ""You're right...""*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""It's not unfair that former Presidents get some special treatment.""]** — Mówca: **Player**
> ""It's not unfair that former Presidents get some special treatment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""Yeah, that's fair.""*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[75]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Petr Vectern: ""Yeah, that's fair.""*)

### Węzeł `[65]`
Mówca: **Petr Vectern**
> ""The reformists would like that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Petr Vectern: ""Well, regardless of what you decide, we will need to wor..."*)

### Węzeł `[66]`
Mówca: **Lucian Galade**
> ""That is pretty powerful, indeed. That may scare some of our ministers too if you decide to *rule by decree.*""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[67]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds and Mr. Garaci may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""Sure. You'll have some time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[69]`
Mówca: **Lucian Galade**
> ""A decrease would definitely hurt our position in the future. If another party is elected to the Assembly, our projected vote would be closer to the real vote, which is significantly lesser.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""Two major left parties; the Communist Party of Sordland ..."*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""That's a possibility. It might make the reformists more willing to consider the changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Petr Vectern: ""But don't forget that the Communist Party of Sordland an..."*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""But if we keep the same voter base, say a 15% threshold, it would keep NFP out of the Assembly, leaving only two parties. Unless, Frens also falls back behind. But I doubt that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Lucian Galade: ""Well, we can't know these for sure. In the last election..."*)

### Węzeł `[72]`
Mówca: **Petr Vectern**
> ""I agree. This really has no importance for the new Constitution. Also, Soll was a hero for many Sords, whether we like it or not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[62]` (*Player: ""Yes, he is a hero for Sordland.""*)
  - -> `[61]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)

### Węzeł `[73]`
Mówca: **Petr Vectern**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such the title then?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)
  - -> `[57]` (*Player: ""Because we could use it too.""*)

### Węzeł `[74]`
Mówca: **Petr Vectern**
> ""Yeah, it should be.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Petr Vectern: ""Two major left parties; the Communist Party of Sordland ..."*)

### Węzeł `[75]`
Mówca: **Petr Vectern**
> ""Oh, so you want to use the same privilege after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[64]` (*Player: ""After pushing aggressive changes, I may need the same im..."*)
  - -> `[63]` (*Player: ""It's not unfair that former Presidents get some special ..."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Petr Vectern: ""Oh, so you want to use the same privilege after all.""*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Petr Vectern: ""That would be enough to hold him accountable for his act..."*)

### Węzeł `[78]`
Mówca: **Lucian Galade**
> ""10% seems already too high for many, sir. An increase may bring too much attention on the amendments.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""But if we keep the same voter base, say a 15% threshold,..."*)

### Węzeł `[79]`
Mówca: **Lucian Galade**
> ""I don't know how, but sure.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[80]`
Mówca: **Petr Vectern**
> ""But don't forget that the Communist Party of Sordland and the Worker's Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[87]` (*Petr Vectern: ""You would be opening their way into the parliament in th..."*)

### Węzeł `[81]`
**[WYBÓR GRACZA: ""We should abolish this position.""]** — Mówca: **Player**
> ""We should abolish this position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[89]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[65]` (*Petr Vectern: ""The reformists would like that.""*)

### Węzeł `[82]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[98]` (*Petr Vectern: ""That might be the best thing to do for now. If we agitat..."*)

### Węzeł `[83]`
**[WYBÓR GRACZA: ""I will instead give the President the ability to replace Judges as necessary.""]** — Mówca: **Player**
> ""I will instead give the President the ability to replace Judges as necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[119]` (*Lucian Galade: ""That's very bold, sir. But I like it.""*)

### Węzeł `[84]`
Mówca: **Lucian Galade**
> ""We are at the 6th. This is about the presidential decrees. You already know that the reformists want them to be removed or limited. But I'm guessing you do not want any changes to your already powerful decrees, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Petr Vectern: ""We could try to balance it with the reformists and make ..."*)

### Węzeł `[85]`
Mówca: **Lucian Galade**
> ""For now I'll move onto the next one: Term Limits."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[92]` (*Player: ""Uh-oh.""*)
  - -> `[55]` (*Player: ""Term Limits?""*)
  - -> `[35]` (*Player: ""I don't aim to leave any time soon. We keep the unlimite..."*)

### Węzeł `[86]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[88]` (*Petr Vectern: ""An increase on the other hand is more complex. NFP could..."*)

### Węzeł `[87]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Player: ""Don't worry. With these reforms, we will be even more po..."*)
  - -> `[101]` (*Player: ""We can't just give away our majority like that anyway.""*)
  - -> `[102]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[103]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[88]`
Mówca: **Petr Vectern**
> ""An increase on the other hand is more complex. NFP could be out of the Assembly but that would mean PFJP's seats would get higher too, if we're left with only two parties in the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""We should keep using the threshold to our advantage.""*)
  - -> `[101]` (*Player: ""We can't just give away our majority like that anyway.""*)
  - -> `[102]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[103]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[89]`
Mówca: **Petr Vectern**
> ""I think some of the reformists really want to try him for his crimes during his terms. Especially against the Bludish. This law really has symbolic importance for both them and the Sollists.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Player: ""We should abolish this position.""*)
  - -> `[26]` (*Player: ""No, I think we should respect this law.""*)
  - -> `[77]` (*Player: ""We could keep the title but take away the immunity clause.""*)
  - -> `[76]` (*Player: ""Every President should gain that title after their term.""*)

### Węzeł `[90]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[91]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has it. He gave it to himself right after his military coup. This law is basically made to save the Colonel.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[89]` (*Petr Vectern: ""I think some of the reformists really want to try him fo..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[85]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Lucian Galade: ""Yes. Tarquin Soll governed for twenty years. It seems hi..."*)

### Węzeł `[93]`
Mówca: **Lucian Galade**
> ""Mr. Ricter will probably demand that we remove them completely. I doubt that this would be enough to get him to sit down with us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Lucian Galade: ""For now I'll move onto the next one: Term Limits."*)

### Węzeł `[94]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Petr Vectern: ""That's why only Tarquin Soll has it. He gave it to himse..."*)

### Węzeł `[95]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""Sure. You'll have some time before we start writing the ..."*)

### Węzeł `[96]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Petr Vectern: ""Hell yes, we should.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[37]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[120]` (*Lucian Galade: ""That is a fair concern. We'll need to sway some of their..."*)

### Węzeł `[98]`
Mówca: **Petr Vectern**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""We should strengthen the decrees further, so they have priority over statute law.""]** — Mówca: **Player**
> ""We should strengthen the decrees further, so they have priority over statute law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Lucian Galade: ""That is pretty powerful, indeed. That may scare some of ..."*)

### Węzeł `[100]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern), `[117]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Petr Vectern: ""I hope so.""*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that anyway.""]** — Mówca: **Player**
> ""We can't just give away our majority like that anyway.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern), `[88]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Petr Vectern: ""Of course not.""*)

### Węzeł `[102]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern), `[88]` (Petr Vectern), `[117]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[114]` (*Lucian Galade: ""Yes, it could be destabilizing.""*)

### Węzeł `[103]`
**[WYBÓR GRACZA: ""We should open their way and unite the left.""]** — Mówca: **Player**
> ""We should open their way and unite the left.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[87]` (Petr Vectern), `[88]` (Petr Vectern), `[117]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[109]` (*Narrator: "Lucian couldn't hide the surprised look on his face."*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""I agree, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""I guess so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[106]` (*Petr Vectern: ""Even Mr. Clavin and our party's reformist wing has no pr..."*)

### Węzeł `[106]`
Mówca: **Petr Vectern**
> ""Even Mr. Clavin and our party's reformist wing has no problems with the current law. USP would fully support that decision. I guess we could also persuade Mr. Kibener somehow.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[107]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[90]` (*Lucian Galade: ""Me neither. I think it's important that the President ca..."*)

### Węzeł `[108]`
**[WYBÓR GRACZA: ""Yes, we can make it dependent on enabling acts.""]** — Mówca: **Player**
> ""Yes, we can make it dependent on enabling acts.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[21]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Lucian Galade: ""Mr. Ricter will probably demand that we remove them comp..."*)

### Węzeł `[109]`
Mówca: **Narrator**
> "Lucian couldn't hide the surprised look on his face."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Lucian Galade: ""I don't know how, but sure.""*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""We should keep using the threshold to our advantage.""]** — Mówca: **Player**
> ""We should keep using the threshold to our advantage.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[88]` (Petr Vectern), `[117]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""I agree, sir.""*)

### Węzeł `[111]`
**[WYBÓR GRACZA: ""It's fine as it is.""]** — Mówca: **Player**
> ""It's fine as it is.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""I guess so.""*)

### Węzeł `[112]`
Mówca: **Petr Vectern**
> ""I hope so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[113]`
Mówca: **Petr Vectern**
> ""Of course not.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[114]`
Mówca: **Lucian Galade**
> ""Yes, it could be destabilizing.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Lucian Galade: ""You'll have some time to think about your decision, sir.""*)

### Węzeł `[115]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""We could simply increase it.""]** — Mówca: **Player**
> ""We could simply increase it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[51]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Lucian Galade: ""10% seems already too high for many, sir. An increase ma..."*)

### Węzeł `[117]`
Mówca: **Lucian Galade**
> ""Well, we can't know these for sure. In the last elections, the Communist Party of Sordland and the Workers Party of Bludia both had close to ten percent. One of them may very well increase their votes in the next years.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""We should keep using the threshold to our advantage.""*)
  - -> `[100]` (*Player: ""Don't worry. With these reforms, we will be even more po..."*)
  - -> `[102]` (*Player: ""We can't allow communists to enter the Assembly.""*)
  - -> `[103]` (*Player: ""We should open their way and unite the left.""*)

### Węzeł `[118]`
Mówca: **Lucian Galade**
> ""You'll have some time to think about your decision, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Narrator: "Lucian continued with the next section."*)

### Węzeł `[119]`
Mówca: **Lucian Galade**
> ""That's very bold, sir. But I like it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[120]`
Mówca: **Lucian Galade**
> ""That is a fair concern. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[121]`
**[WYBÓR GRACZA: "“Let's start.”"]** — Mówca: **Player**
> "“Let's start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[122]`
**[WYBÓR GRACZA: "“Can we go over each of the points that are in discussion for the draft?”"]** — Mówca: **Player**
> "“Can we go over each of the points that are in discussion for the draft?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[5]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: ""Well, apart from the first two sections of decreasing th..."*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> ""Well, apart from the first two sections of decreasing the Supreme Court's authority and limiting the presidential vetoes... Other sections are up to debate.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Lucian Galade: ""We can start talking about Section 3. This is about the ..."*)

### Węzeł `[124]`
**[WYBÓR GRACZA: "“I thank you all for your input.”"]** — Mówca: **Player**
> "“I thank you all for your input.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[125]`
Mówca: **Petr Vectern**
> ""Well, regardless of what you decide, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Player: "“Let's start working on the draft.”"*)
  - -> `[124]` (*Player: "“I thank you all for your input.”"*)

### Węzeł `[126]`
**[WYBÓR GRACZA: "“Let's start working on the draft.”"]** — Mówca: **Player**
> "“Let's start working on the draft.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[125]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[127]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_DictatorConstitution");"*)

### Węzeł `[128]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_BenfiFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Narrator: "The reform committee finally bore tangible results and th..."*)

### Węzeł `[129]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Player: "“Good morning, Livia.”"*)
  - -> `[131]` (*Player: ""How are you today?""*)

### Węzeł `[130]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Livia Suno: ""How are you today, sir?""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[129]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[134]` (*Livia Suno: ""Fine, thank you.""*)

### Węzeł `[132]`
Mówca: **Livia Suno**
> ""Sorry to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[133]`
**[WYBÓR GRACZA: "“I'm perfectly fine.""]** — Mówca: **Player**
> "“I'm perfectly fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Livia Suno), `[139]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Livia Suno: ""Good to hear.""*)

### Węzeł `[134]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Livia Suno: ""More importantly, how are you, sir?""*)

### Węzeł `[135]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I entered my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[6]` (*Narrator: "Not long after, Petr and Lucian arrived."*)

### Węzeł `[136]`
Mówca: **Livia Suno**
> ""Mr. Rayne -- can you give me a hint about your reform plans? If you ask me, taking away the judges' immunity is long overdue, but it might anger a lot of people in these halls...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[150]` (*Player: "“You'll find out along with the rest of Sordland, sweethe..."*)
  - -> `[143]` (*Player: "“I'll take that into consideration.""*)
  - -> `[138]` (*Player: ""Nothing's been decided yet.""*)
  - -> `[146]` (*Player: "“It's none of your business, Livia.""*)

### Węzeł `[137]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“I'm perfectly fine.""*)
  - -> `[145]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[147]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[138]`
**[WYBÓR GRACZA: ""Nothing's been decided yet.""]** — Mówca: **Player**
> ""Nothing's been decided yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Livia Suno: ""I hope you'll keep me informed. I'll take your coat now.""*)

### Węzeł `[139]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[133]` (*Player: "“I'm perfectly fine.""*)
  - -> `[145]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[147]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[140]`
Mówca: **Livia Suno**
> ""I hope you'll keep me informed. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Livia left to hang up my coat. I entered my office and sa..."*)

### Węzeł `[141]`
Mówca: **Livia Suno**
> ""Understood. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Narrator: "Livia left to hang up my coat. I entered my office and sa..."*)

### Węzeł `[142]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Livia Suno: ""Mr. Rayne -- can you give me a hint about your reform pl..."*)

### Węzeł `[143]`
**[WYBÓR GRACZA: "“I'll take that into consideration.""]** — Mówca: **Player**
> "“I'll take that into consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Livia Suno: ""I hope you'll keep me informed. I'll take your coat now.""*)

### Węzeł `[144]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Livia Suno: ""Thank you, Mr. President.""*)

### Węzeł `[145]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Livia Suno), `[139]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[132]` (*Livia Suno: ""Sorry to hear.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“It's none of your business, Livia.""]** — Mówca: **Player**
> "“It's none of your business, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Livia Suno: ""Understood. I'll take your coat now.""*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Livia Suno), `[139]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Narrator: "She averted her eyes away from me and smiled."*)

### Węzeł `[148]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[149]`
Mówca: **Livia Suno**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“You'll find out along with the rest of Sordland, sweetheart.""]** — Mówca: **Player**
> "“You'll find out along with the rest of Sordland, sweetheart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[136]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Livia Suno: ""Understood. I'll take your coat now.""*)

### Węzeł `[151]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Pre_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[14]` (*Narrator: "After placing the committee's report and my own notes in ..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Pre_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Narrator: "After placing the committee's report and my own notes in ..."*)

### Węzeł `[153]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_DictatorConstitution");`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_DictatorConstitution");`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[154]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ReformProposal_Open = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.ReformProposal_Open"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;"*)

### Węzeł `[155]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[156]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Węzeł Logiki Narracyjnej: "End();"*)
