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

## 3. Kompletne Zestawienie Opcji Dialogowych Gracza i Wymagań

> Każda opcja dialogowa została przeanalizowana pod kątem wymagań logicznych w silniku gry (warunki Lua na węzłach wejściowych i bramkach warunkowych).

| Węzeł | Treść Opcji Gracza (Menu / Kwestia) | Kontekst (Z jakiej wypowiedzi) | Wymagania Odblokowania (Warunki z Kodu Gry) | Skutki Skryptowe (`userScript`) | Cel / Następna Kwestia |
|---|---|---|---|---|---|
| `[5]` | **"“Greetings.”"** | `[4]` **Narrator**: "Not long after, Petr, Lucian and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Nia Morgna**: ""Good morning, Mr. President."" |
| `[6]` | **"“Finally!”"** | `[4]` **Narrator**: "Not long after, Petr, Lucian and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Nia Morgna**: ""Good morning, Mr. President."" |
| `[13]` | **"“Good morning, Livia.”"** | `[12]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[17]` **Livia Suno**: ""How are you today, sir?"" |
| `[14]` | **""How are you today?""** | `[12]` **Livia Suno**: ""Good morning, Mr. President."" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[15]` **Livia Suno**: ""Fine, thank you."" |
| `[18]` | **"“I'm about to make stressful decisions. So, not feeling that great.”"** | `[16]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[17]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[23]` **Livia Suno**: ""Sorry to hear."" |
| `[19]` | **"“I'm perfectly fine.""** | `[16]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[17]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[22]` **Livia Suno**: ""Good to hear."" |
| `[20]` | **"“I feel better now that I've seen you, Livia.""** | `[16]` **Livia Suno**: ""More importantly, how are you, ..."<br>`[17]` **Livia Suno**: ""How are you today, sir?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[21]` **Narrator**: "She averted her eyes away from m..." |
| `[25]` | **"“You'll find out with the rest of Sordland, sweetheart.""** | `[154]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Livia Suno**: ""Understood. I'll take your coat..." |
| `[26]` | **"“I'll take that into consideration.""** | `[154]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Livia Suno**: ""I hope you'll keep me informed...." |
| `[27]` | **""Nothing's been decided yet.""** | `[154]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[156]` **Livia Suno**: ""I hope you'll keep me informed...." |
| `[28]` | **"“That's none of your business, Livia.""** | `[154]` **Livia Suno**: ""Mr. Rayne -- can you give me a ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[155]` **Livia Suno**: ""Understood. I'll take your coat..." |
| `[30]` | **"“Good morning everybody.”"** | `[4]` **Narrator**: "Not long after, Petr, Lucian and..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[9]` **Nia Morgna**: ""Good morning, Mr. President."" |
| `[35]` | **""Regardless of him, I see no problem with having a special title for great heroes.""** | `[50]` **Nia Morgna**: ""That would be enough to hold hi..."<br>`[53]` **Nia Morgna**: ""Do you want to protect Tarquin ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." |
| `[36]` | **""It's just a title, Mrs. Morgna.""** | `[50]` **Nia Morgna**: ""That would be enough to hold hi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." |
| `[39]` | **""After pushing aggressive changes, I may need the same immunity.""** | `[49]` **Nia Morgna**: ""I'm sorry, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." |
| `[40]` | **""If our own democracy is the reason of our downfall, we will have to accept it.""** | `[70]` **Lucian Galade**: ""Of course that would also mean ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[75]` **Nia Morgna**: ""I agree with you, Mr. President."" |
| `[41]` | **""It's not unfair that former Presidents get some special treatment.""** | `[49]` **Nia Morgna**: ""I'm sorry, Mr. President?"" | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." |
| `[47]` | **""The Assembly should have oversight over the President.""** | `[44]` **Nia Morgna**: ""Most reformists want the impeac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""This law is particularly danger..." |
| `[48]` | **""Not sure if it is correct to chastise the President this much though.""** | `[44]` **Nia Morgna**: ""Most reformists want the impeac..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[55]` **Petr Vectern**: ""This law is particularly danger..." |
| `[54]` | **""Yes, he is a hero for Sordland.""** | `[53]` **Nia Morgna**: ""Do you want to protect Tarquin ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." |
| `[57]` | **""We could even remove impeachment altogether.""** | `[68]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[91]` **Lucian Galade**: ""I don't think that's a wise ide..." |
| `[58]` | **""I agree, we should abolish this position.""** | `[69]` **Nia Morgna**: ""We must get rid of this sensele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[51]` **Nia Morgna**: ""The reformists would be complet..." |
| `[60]` | **""We should define a better impeachment process.""** | `[68]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[81]` **Nia Morgna**: ""Yes, we will be collaboratively..." |
| `[62]` | **""No, I think we should respect this law.""** | `[69]` **Nia Morgna**: ""We must get rid of this sensele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[53]` **Nia Morgna**: ""Do you want to protect Tarquin ..." |
| `[63]` | **""We could keep the title but take away the immunity clause.""** | `[69]` **Nia Morgna**: ""We must get rid of this sensele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[50]` **Nia Morgna**: ""That would be enough to hold hi..." |
| `[64]` | **""Every President should gain that title after their term.""** | `[69]` **Nia Morgna**: ""We must get rid of this sensele..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[49]` **Nia Morgna**: ""I'm sorry, Mr. President?"" |
| `[65]` | **""Maybe reforms are not a great idea after all.""** | `[68]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[78]` **Nia Morgna**: ""While I do not have strong opin..." |
| `[67]` | **""What if we don't succeed? The Court can have me impeached for this.""** | `[68]` **Petr Vectern**: ""...They will be looking for any..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[80]` **Lucian Galade**: ""Yes, they are already trying to..." |
| `[76]` | **""This is out of the question.""** | `[139]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[66]` **Nia Morgna**: ""Many Sordish citizens feel they..." |
| `[77]` | **""I may need to think a bit longer about this.""** | `[128]` **Petr Vectern**: ""We could also make it dependent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[145]` **Petr Vectern**: ""Sure. You'll have a long time b..." |
| `[86]` | **""We should respect their immunity.""** | `[94]` **Petr Vectern**: ""Well, they need absolute immuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[84]` **Nia Morgna**: ""That might be the best thing to..." |
| `[87]` | **""They should be able to be impeached. Why do I get to be impeached but not them?""** | `[94]` **Petr Vectern**: ""Well, they need absolute immuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[85]` **Petr Vectern**: ""Exactly."" |
| `[88]` | **""We should crush the Old Guards to clear ways for further reforms.""** | `[94]` **Petr Vectern**: ""Well, they need absolute immuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[83]` **Petr Vectern**: ""Hell yes, we should."" |
| `[89]` | **""Maybe we shouldn't make the Supreme Court our enemies just yet.""** | `[94]` **Petr Vectern**: ""Well, they need absolute immuni..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[82]` **Lucian Galade**: ""That is a better strategy. We'l..." |
| `[90]` | **""We can't allow communists to enter the Assembly.""** | `[70]` **Lucian Galade**: ""Of course that would also mean ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[113]` **Lucian Galade**: ""It could be destabilising."" |
| `[92]` | **""We can't just give away our majority like that.""** | `[70]` **Lucian Galade**: ""Of course that would also mean ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[126]` **Lucian Galade**: ""I know it is a delicate matter,..." |
| `[97]` | **""Don't worry. With these reforms, we will be even more popular.""** | `[70]` **Lucian Galade**: ""Of course that would also mean ..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[124]` **Lucian Galade**: ""I hope it works out, Mr. Presid..." |
| `[98]` | **""We'll work with the reformists to limit the use of decrees.""** | `[128]` **Petr Vectern**: ""We could also make it dependent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[142]` **Petr Vectern**: ""Frens will probably demand that..." |
| `[99]` | **""But the high threshold is the reason why Sordish politics has become so isolated.""** | `[139]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[46]` **Nia Morgna**: ""You're right. Even after Soll's..." |
| `[101]` | **""We should definitely work to decrease the threshold for better representation.""** | `[139]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[52]` **Nia Morgna**: ""I agree. Even after Soll's resi..." |
| `[106]` | **""Do you think it would really hurt the party?""** | `[139]` **Lucian Galade**: ""Not wrong. The ten percent thre..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[61]` **Nia Morgna**: ""I think this is a national matt..." |
| `[109]` | **""I will take my time and seriously consider the options before settling on one.""** | `[107]` **Lucian Galade**: ""Even Soll knew he had to leave,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: ""Now I'll move unto the 8th Sect..." |
| `[110]` | **""Yes, he did. But it took a long time.""** | `[107]` **Lucian Galade**: ""Even Soll knew he had to leave,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: ""Now I'll move unto the 8th Sect..." |
| `[114]` | **""I agree. People should be able to elect the same person if they want to.""** | `[107]` **Lucian Galade**: ""Even Soll knew he had to leave,..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[105]` **Lucian Galade**: ""Now I'll move unto the 8th Sect..." |
| `[116]` | **""I don't think presidential decrees need any reforms.""** | `[128]` **Petr Vectern**: ""We could also make it dependent..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[129]` **Lucian Galade**: ""Me neither. I think it's import..." |
| `[119]` | **""I agree. We should involve the Assembly more in the process.""** | `[112]` **Nia Morgna**: ""There is definitely a demand to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[111]` **Nia Morgna**: ""Some reformists suggested that ..." |
| `[120]` | **""We could introduce a confidence vote.""** | `[112]` **Nia Morgna**: ""There is definitely a demand to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[130]` **Nia Morgna**: ""That was my suggestion as well."" |
| `[122]` | **""That's going a bit too far.""** | `[112]` **Nia Morgna**: ""There is definitely a demand to..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[135]` **Nia Morgna**: ""Maybe. But Mr. Ricter doesn't t..." |
| `[131]` | **""Uh-oh.""** | `[137]` **Lucian Galade**: ""Next one is Section 7. Term lim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[123]` **Lucian Galade**: ""Yes. Tarquin Soll governed for ..." |
| `[132]` | **""I don't aim to leave any time soon. We keep the unlimited terms.""** | `[137]` **Lucian Galade**: ""Next one is Section 7. Term lim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[125]` **Lucian Galade**: ""I agree, we could keep that in."" |
| `[133]` | **""Term limits are necessary.""** | `[137]` **Lucian Galade**: ""Next one is Section 7. Term lim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[127]` **Nia Morgna**: ""I agree. We can't allow somebod..." |
| `[134]` | **""Term Limits?""** | `[137]` **Lucian Galade**: ""Next one is Section 7. Term lim..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[121]` **Lucian Galade**: ""They want us to include previou..." |
| `[146]` | **"“Let's start.”"** | `[32]` **Lucian Galade**: ""After your modifications, we wi..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[33]` **Narrator**: "After placing the committee's re..." |
| `[147]` | **"“Can we go over each of the points that are in discussion for the draft?”"** | `[32]` **Lucian Galade**: ""After your modifications, we wi..." | *Brak (Dostępna bezwarunkowo)* | *Brak zmian stanu* | `[148]` **Lucian Galade**: ""Well, apart from the first two ..." |
| `[149]` | **"“Let's start working on the draft.”"** | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[151]` **Narrator**: "After placing the committee's re..." |
| `[150]` | **"“I thank you all for your input.”"** | `[43]` **Petr Vectern**: ""Well, regardless of what Mr. Ra..." | *Brak (Dostępna bezwarunkowo)* | `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;` | `[151]` **Narrator**: "After placing the committee's re..." |

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
  - -> `[3]` (*Narrator: "I was walking to my office, since today was the day to ed..."*)

### Węzeł `[2]`
**[OUTPUT / WYJŚCIE ZE SCENY]** (System / OUTPUT)
- **Połączenia wychodzące:** *Brak (Węzeł końcowy)*

### Węzeł `[3]`
Mówca: **Narrator**
> "I was walking to my office, since today was the day to edit and make the final changes for the proposal to change the Constitution of Sordland."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[152]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_LT_BenfiFestival = true"*)

### Węzeł `[4]`
Mówca: **Narrator**
> "Not long after, Petr, Lucian and Nia arrived."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[5]` (*Player: "“Greetings.”"*)
  - -> `[6]` (*Player: "“Finally!”"*)
  - -> `[30]` (*Player: "“Good morning everybody.”"*)

### Węzeł `[5]`
**[WYBÓR GRACZA: "“Greetings.”"]** — Mówca: **Player**
> "“Greetings.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""Good morning, Mr. President.""*)

### Węzeł `[6]`
**[WYBÓR GRACZA: "“Finally!”"]** — Mówca: **Player**
> "“Finally!”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""Good morning, Mr. President.""*)

### Węzeł `[7]`
Mówca: **Narrator**
> "I walked in the marble corridors of the Palace, thinking about the huge decisions I was going to take."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[8]` (*Narrator: "At the entrance to my office, my secretary Livia greeted me."*)

### Węzeł `[8]`
Mówca: **Narrator**
> "At the entrance to my office, my secretary Livia greeted me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[12]` (*Livia Suno: ""Good morning, Mr. President.""*)

### Węzeł `[9]`
Mówca: **Nia Morgna**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[10]` (*Petr Vectern: ""Good morning! Time to finally get this proposal going.""*)

### Węzeł `[10]`
Mówca: **Petr Vectern**
> ""Good morning! Time to finally get this proposal going.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[31]` (*Narrator: "Petr placed the draft in front of me."*)

### Węzeł `[11]`
Mówca: **Narrator**
> "The reform committee finally bore tangible results and the draft of the changes were about to be presented to me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[7]` (*Narrator: "I walked in the marble corridors of the Palace, thinking ..."*)

### Węzeł `[12]`
Mówca: **Livia Suno**
> ""Good morning, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[13]` (*Player: "“Good morning, Livia.”"*)
  - -> `[14]` (*Player: ""How are you today?""*)

### Węzeł `[13]`
**[WYBÓR GRACZA: "“Good morning, Livia.”"]** — Mówca: **Player**
> "“Good morning, Livia.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[17]` (*Livia Suno: ""How are you today, sir?""*)

### Węzeł `[14]`
**[WYBÓR GRACZA: ""How are you today?""]** — Mówca: **Player**
> ""How are you today?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[12]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[15]` (*Livia Suno: ""Fine, thank you.""*)

### Węzeł `[15]`
Mówca: **Livia Suno**
> ""Fine, thank you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[16]` (*Livia Suno: ""More importantly, how are you, sir?""*)

### Węzeł `[16]`
Mówca: **Livia Suno**
> ""More importantly, how are you, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“I'm perfectly fine.""*)
  - -> `[18]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[20]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[17]`
Mówca: **Livia Suno**
> ""How are you today, sir?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[19]` (*Player: "“I'm perfectly fine.""*)
  - -> `[18]` (*Player: "“I'm about to make stressful decisions. So, not feeling t..."*)
  - -> `[20]` (*Player: "“I feel better now that I've seen you, Livia.""*)

### Węzeł `[18]`
**[WYBÓR GRACZA: "“I'm about to make stressful decisions. So, not feeling that great.”"]** — Mówca: **Player**
> "“I'm about to make stressful decisions. So, not feeling that great.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Livia Suno), `[17]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[23]` (*Livia Suno: ""Sorry to hear.""*)

### Węzeł `[19]`
**[WYBÓR GRACZA: "“I'm perfectly fine.""]** — Mówca: **Player**
> "“I'm perfectly fine.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Livia Suno), `[17]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[22]` (*Livia Suno: ""Good to hear.""*)

### Węzeł `[20]`
**[WYBÓR GRACZA: "“I feel better now that I've seen you, Livia.""]** — Mówca: **Player**
> "“I feel better now that I've seen you, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[16]` (Livia Suno), `[17]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[21]` (*Narrator: "She averted her eyes away from me and smiled."*)

### Węzeł `[21]`
Mówca: **Narrator**
> "She averted her eyes away from me and smiled."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[24]` (*Livia Suno: ""Thank you, Mr. President.""*)

### Węzeł `[22]`
Mówca: **Livia Suno**
> ""Good to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[23]`
Mówca: **Livia Suno**
> ""Sorry to hear.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[24]`
Mówca: **Livia Suno**
> ""Thank you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[153]` (*Narrator: "She paused before taking my coat. It looked like she had ..."*)

### Węzeł `[25]`
**[WYBÓR GRACZA: "“You'll find out with the rest of Sordland, sweetheart.""]** — Mówca: **Player**
> "“You'll find out with the rest of Sordland, sweetheart.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Livia Suno: ""Understood. I'll take your coat now.""*)

### Węzeł `[26]`
**[WYBÓR GRACZA: "“I'll take that into consideration.""]** — Mówca: **Player**
> "“I'll take that into consideration.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Livia Suno: ""I hope you'll keep me informed. I'll take your coat now.""*)

### Węzeł `[27]`
**[WYBÓR GRACZA: ""Nothing's been decided yet.""]** — Mówca: **Player**
> ""Nothing's been decided yet.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[156]` (*Livia Suno: ""I hope you'll keep me informed. I'll take your coat now.""*)

### Węzeł `[28]`
**[WYBÓR GRACZA: "“That's none of your business, Livia.""]** — Mówca: **Player**
> "“That's none of your business, Livia.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[154]` (Livia Suno)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[155]` (*Livia Suno: ""Understood. I'll take your coat now.""*)

### Węzeł `[29]`
Mówca: **Narrator**
> "Livia left to hang up my coat. I entered my office and sat down."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[4]` (*Narrator: "Not long after, Petr, Lucian and Nia arrived."*)

### Węzeł `[30]`
**[WYBÓR GRACZA: "“Good morning everybody.”"]** — Mówca: **Player**
> "“Good morning everybody.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[4]` (Narrator)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[9]` (*Nia Morgna: ""Good morning, Mr. President.""*)

### Węzeł `[31]`
Mówca: **Narrator**
> "Petr placed the draft in front of me."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[32]` (*Lucian Galade: ""After your modifications, we will be starting the process.""*)

### Węzeł `[32]`
Mówca: **Lucian Galade**
> ""After your modifications, we will be starting the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[146]` (*Player: "“Let's start.”"*)
  - -> `[147]` (*Player: "“Can we go over each of the points that are in discussion..."*)

### Węzeł `[33]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_ReformistConstitution");  ..."*)

### Węzeł `[34]`
Mówca: **Nia Morgna**
> ""I have suggested to bring some limitations to decrees regarding their applicability. While we keep them, we should try to make sure that they will only be used in emergency situations.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[128]` (*Petr Vectern: ""We could also make it dependent on an enabling act from ..."*)

### Węzeł `[35]`
**[WYBÓR GRACZA: ""Regardless of him, I see no problem with having a special title for great heroes.""]** — Mówca: **Player**
> ""Regardless of him, I see no problem with having a special title for great heroes.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Nia Morgna), `[53]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[36]`
**[WYBÓR GRACZA: ""It's just a title, Mrs. Morgna.""]** — Mówca: **Player**
> ""It's just a title, Mrs. Morgna.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[50]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[37]`
Mówca: **Nia Morgna**
> ""Mr. President. Unless you wish to be like Colonel Soll after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[96]` (*Lucian Galade: ""Uhm. The next one...""*)

### Węzeł `[38]`
Mówca: **Lucian Galade**
> ""We could start talking about Section 3. This is about the impeachment process of the President. Currently, in cases of high treason and breaking the Constitution, the Supreme Court may impeach and try the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[44]` (*Nia Morgna: ""Most reformists want the impeachment to be initiated by ..."*)

### Węzeł `[39]`
**[WYBÓR GRACZA: ""After pushing aggressive changes, I may need the same immunity.""]** — Mówca: **Player**
> ""After pushing aggressive changes, I may need the same immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[40]`
**[WYBÓR GRACZA: ""If our own democracy is the reason of our downfall, we will have to accept it.""]** — Mówca: **Player**
> ""If our own democracy is the reason of our downfall, we will have to accept it.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[75]` (*Nia Morgna: ""I agree with you, Mr. President.""*)

### Węzeł `[41]`
**[WYBÓR GRACZA: ""It's not unfair that former Presidents get some special treatment.""]** — Mówca: **Player**
> ""It's not unfair that former Presidents get some special treatment.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[49]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[42]`
Mówca: **Petr Vectern**
> ""It is a matter of both when we have the Communist Party and the Workers Party of Bludia getting more than five percent vote in the last elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[56]` (*Petr Vectern: ""Decreasing the threshold might mean opening their way in..."*)

### Węzeł `[43]`
Mówca: **Petr Vectern**
> ""Well, regardless of what Mr. Rayne decides, we will need to work together to push this agenda.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[149]` (*Player: "“Let's start working on the draft.”"*)
  - -> `[150]` (*Player: "“I thank you all for your input.”"*)

### Węzeł `[44]`
Mówca: **Nia Morgna**
> ""Most reformists want the impeachment to be initiated by the Assembly. They think they do not have any power over potential rogue presidents that would abuse their power.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[48]` (*Player: ""Not sure if it is correct to chastise the President this..."*)
  - -> `[47]` (*Player: ""The Assembly should have oversight over the President.""*)

### Węzeł `[45]`
Mówca: **Petr Vectern**
> ""Don't forget that the Communist Party and the Workers Party of Bludia both had close to ten percent vote in the last election.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[59]` (*Petr Vectern: ""You would be opening their way into the parliament in th..."*)

### Węzeł `[46]`
Mówca: **Nia Morgna**
> ""You're right. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP was barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""Don't forget that the Communist Party and the Workers Pa..."*)

### Węzeł `[47]`
**[WYBÓR GRACZA: ""The Assembly should have oversight over the President.""]** — Mówca: **Player**
> ""The Assembly should have oversight over the President, it is the most democratic institution.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""This law is particularly dangerous for you in this case...."*)

### Węzeł `[48]`
**[WYBÓR GRACZA: ""Not sure if it is correct to chastise the President this much though.""]** — Mówca: **Player**
> ""Not sure if it is correct to chastise the President this much though.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[44]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[55]` (*Petr Vectern: ""This law is particularly dangerous for you in this case...."*)

### Węzeł `[49]`
Mówca: **Nia Morgna**
> ""I'm sorry, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[39]` (*Player: ""After pushing aggressive changes, I may need the same im..."*)
  - -> `[41]` (*Player: ""It's not unfair that former Presidents get some special ..."*)

### Węzeł `[50]`
Mówca: **Nia Morgna**
> ""That would be enough to hold him accountable for his actions but why would you want to keep such a title, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[35]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)
  - -> `[36]` (*Player: ""It's just a title, Mrs. Morgna.""*)

### Węzeł `[51]`
Mówca: **Nia Morgna**
> ""The reformists would be completely behind that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[52]`
Mówca: **Nia Morgna**
> ""I agree. Even after Soll's resignation, we still have three parties in the Assembly. Even Mr. Kibener's NFP is barely elected.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""Don't forget that the Communist Party and the Workers Pa..."*)

### Węzeł `[53]`
Mówca: **Nia Morgna**
> ""Do you want to protect Tarquin Soll, Mr. President?""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[54]` (*Player: ""Yes, he is a hero for Sordland.""*)
  - -> `[35]` (*Player: ""Regardless of him, I see no problem with having a specia..."*)

### Węzeł `[54]`
**[WYBÓR GRACZA: ""Yes, he is a hero for Sordland.""]** — Mówca: **Player**
> ""Yes, he is a hero for Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[53]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[43]` (*Petr Vectern: ""Well, regardless of what Mr. Rayne decides, we will need..."*)

### Węzeł `[55]`
Mówca: **Petr Vectern**
> ""This law is particularly dangerous for you in this case. We will be going against the Old Guard, and if we prove to be successful in the Assembly...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[68]` (*Petr Vectern: ""...They will be looking for anything they can declare un..."*)

### Węzeł `[56]`
Mówca: **Petr Vectern**
> ""Decreasing the threshold might mean opening their way into the Assembly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""Of course that would also mean that USP might lose its m..."*)

### Węzeł `[57]`
**[WYBÓR GRACZA: ""We could even remove impeachment altogether.""]** — Mówca: **Player**
> ""We could even remove impeachment altogether, I can get total immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[91]` (*Lucian Galade: ""I don't think that's a wise idea to include in the refor..."*)

### Węzeł `[58]`
**[WYBÓR GRACZA: ""I agree, we should abolish this position.""]** — Mówca: **Player**
> ""I agree, we should abolish this position.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[51]` (*Nia Morgna: ""The reformists would be completely behind that.""*)

### Węzeł `[59]`
Mówca: **Petr Vectern**
> ""You would be opening their way into the parliament in the future if you were to decrease the threshold. It is important that you realize this.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[70]` (*Lucian Galade: ""Of course that would also mean that USP might lose its m..."*)

### Węzeł `[60]`
**[WYBÓR GRACZA: ""We should define a better impeachment process.""]** — Mówca: **Player**
> ""We should define a more refined impeachment process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[81]` (*Nia Morgna: ""Yes, we will be collaboratively working on the specifics.""*)

### Węzeł `[61]`
Mówca: **Nia Morgna**
> ""I think this is a national matter, Mr. Rayne. Not a partisan one.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[42]` (*Petr Vectern: ""It is a matter of both when we have the Communist Party ..."*)

### Węzeł `[62]`
**[WYBÓR GRACZA: ""No, I think we should respect this law.""]** — Mówca: **Player**
> ""No, I think we should respect this law.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[53]` (*Nia Morgna: ""Do you want to protect Tarquin Soll, Mr. President?""*)

### Węzeł `[63]`
**[WYBÓR GRACZA: ""We could keep the title but take away the immunity clause.""]** — Mówca: **Player**
> ""We could keep the title but take away the immunity clause.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[50]` (*Nia Morgna: ""That would be enough to hold him accountable for his act..."*)

### Węzeł `[64]`
**[WYBÓR GRACZA: ""Every President should gain that title after their term.""]** — Mówca: **Player**
> ""Every President should gain that title after their term.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[69]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[49]` (*Nia Morgna: ""I'm sorry, Mr. President?""*)

### Węzeł `[65]`
**[WYBÓR GRACZA: ""Maybe reforms are not a great idea after all.""]** — Mówca: **Player**
> ""Maybe the reforms are not a great idea after all.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[78]` (*Nia Morgna: ""While I do not have strong opinions about this point, th..."*)

### Węzeł `[66]`
Mówca: **Nia Morgna**
> ""Many Sordish citizens feel they're not represented in the Assembly. This is a matter of representative democracy in Sordland.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[45]` (*Petr Vectern: ""Don't forget that the Communist Party and the Workers Pa..."*)

### Węzeł `[67]`
**[WYBÓR GRACZA: ""What if we don't succeed? The Court can have me impeached for this.""]** — Mówca: **Player**
> ""What if we don't succeed? The Court can have me impeached for this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[68]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[80]` (*Lucian Galade: ""Yes, they are already trying to hit you since they are a..."*)

### Węzeł `[68]`
Mówca: **Petr Vectern**
> ""...They will be looking for anything they can declare unconstitutional to tackle you. All they need is the Supreme Court to impeach you.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[67]` (*Player: ""What if we don't succeed? The Court can have me impeache..."*)
  - -> `[65]` (*Player: ""Maybe reforms are not a great idea after all.""*)
  - -> `[60]` (*Player: ""We should define a better impeachment process.""*)
  - -> `[57]` (*Player: ""We could even remove impeachment altogether.""*)

### Węzeł `[69]`
Mówca: **Nia Morgna**
> ""We must get rid of this senseless law that protects him. He should be able to face justice for the atrocities that had taken place during his rule.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[58]` (*Player: ""I agree, we should abolish this position.""*)
  - -> `[62]` (*Player: ""No, I think we should respect this law.""*)
  - -> `[63]` (*Player: ""We could keep the title but take away the immunity clause.""*)
  - -> `[64]` (*Player: ""Every President should gain that title after their term.""*)

### Węzeł `[70]`
Mówca: **Lucian Galade**
> ""Of course that would also mean that USP might lose its majority in the Assembly, sir.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[40]` (*Player: ""If our own democracy is the reason of our downfall, we w..."*)
  - -> `[97]` (*Player: ""Don't worry. With these reforms, we will be even more po..."*)
  - -> `[92]` (*Player: ""We can't just give away our majority like that.""*)
  - -> `[90]` (*Player: ""We can't allow communists to enter the Assembly.""*)

### Węzeł `[71]`
Mówca: **Petr Vectern**
> ""That's why only Tarquin Soll has that title. He gave it to himself right after his military coup. This law is basically made to save the Colonel and it has a symbolic importance for Sordland because of it.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[69]` (*Nia Morgna: ""We must get rid of this senseless law that protects him...."*)

### Węzeł `[72]`
Mówca: **Lucian Galade**
> ""According to the Constitution, the Member of Honor not only has legal immunity but the state also covers most of their expenses as well as providing security at all times. It can only be given to someone by an absolute majority vote in the Assembly and the approval of the President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[71]` (*Petr Vectern: ""That's why only Tarquin Soll has that title. He gave it ..."*)

### Węzeł `[73]`
Mówca: **Nia Morgna**
> ""Mr. Ricter and his PFJP definitely wants to see change on this topic. They find our 10% threshold to be antidemocratic. Which is something I also agree with.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[136]` (*Petr Vectern: ""Yes, but this is a delicate matter. The party, and I mea..."*)

### Węzeł `[74]`
Mówca: **Lucian Galade**
> ""And the last one is the question about Soll's legacy. Basically his *Member of Honor* law. It gave him absolute immunity even when he's retired. He is a permanent member of the Assembly as well, but luckily he doesn't really attend anymore.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[72]` (*Lucian Galade: ""According to the Constitution, the Member of Honor not o..."*)

### Węzeł `[75]`
Mówca: **Nia Morgna**
> ""I agree with you, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Lucian continued with the next section."*)

### Węzeł `[76]`
**[WYBÓR GRACZA: ""This is out of the question.""]** — Mówca: **Player**
> ""This is out of the question.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[66]` (*Nia Morgna: ""Many Sordish citizens feel they're not represented in th..."*)

### Węzeł `[77]`
**[WYBÓR GRACZA: ""I may need to think a bit longer about this.""]** — Mówca: **Player**
> ""I may need to think a bit longer about this.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[145]` (*Petr Vectern: ""Sure. You'll have a long time before we start writing th..."*)

### Węzeł `[78]`
Mówca: **Nia Morgna**
> ""While I do not have strong opinions about this point, these reforms are vital for the future of our democracy, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Section 4.""*)

### Węzeł `[79]`
Mówca: **Petr Vectern**
> ""But it would be tougher to persuade the judges with this. Mrs. Edmonds may not want to cooperate with you if they believe you're going to get rid of them afterwards.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[80]`
Mówca: **Lucian Galade**
> ""Yes, they are already trying to hit you since they are aware about the current wind of change. But we aim to cooperate with some of the judges to make sure that doesn't happen.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[93]` (*Nia Morgna: ""We will make sure the Old Guards won't control the Court..."*)

### Węzeł `[81]`
Mówca: **Nia Morgna**
> ""Yes, we will be collaboratively working on the specifics.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Section 4.""*)

### Węzeł `[82]`
Mówca: **Lucian Galade**
> ""That is a better strategy. We'll need to sway some of their members to succeed after all.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[83]`
Mówca: **Petr Vectern**
> ""Hell yes, we should.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[84]`
Mówca: **Nia Morgna**
> ""That might be the best thing to do for now. If we agitate the Court further, we might lose our chances with Mrs. Edmonds as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[74]` (*Lucian Galade: ""And the last one is the question about Soll's legacy. Ba..."*)

### Węzeł `[85]`
Mówca: **Petr Vectern**
> ""Exactly.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[79]` (*Petr Vectern: ""But it would be tougher to persuade the judges with this..."*)

### Węzeł `[86]`
**[WYBÓR GRACZA: ""We should respect their immunity.""]** — Mówca: **Player**
> ""We should respect their immunity.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[84]` (*Nia Morgna: ""That might be the best thing to do for now. If we agitat..."*)

### Węzeł `[87]`
**[WYBÓR GRACZA: ""They should be able to be impeached. Why do I get to be impeached but not them?""]** — Mówca: **Player**
> ""They should be able to be impeached. Why do I get to be impeached but not them?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[85]` (*Petr Vectern: ""Exactly.""*)

### Węzeł `[88]`
**[WYBÓR GRACZA: ""We should crush the Old Guards to clear ways for further reforms.""]** — Mówca: **Player**
> ""We should crush the Old Guards to clear ways for further reforms in Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[83]` (*Petr Vectern: ""Hell yes, we should.""*)

### Węzeł `[89]`
**[WYBÓR GRACZA: ""Maybe we shouldn't make the Supreme Court our enemies just yet.""]** — Mówca: **Player**
> ""Maybe we shouldn't make the Supreme Court our enemies just yet. Let's keep the reforms light.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[94]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[82]` (*Lucian Galade: ""That is a better strategy. We'll need to sway some of th..."*)

### Węzeł `[90]`
**[WYBÓR GRACZA: ""We can't allow communists to enter the Assembly.""]** — Mówca: **Player**
> ""We can't allow communists to enter the Assembly and endanger Sordland.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[113]` (*Lucian Galade: ""It could be destabilising.""*)

### Węzeł `[91]`
Mówca: **Lucian Galade**
> ""I don't think that's a wise idea to include in the reforms.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[37]` (*Nia Morgna: ""Mr. President. Unless you wish to be like Colonel Soll a..."*)

### Węzeł `[92]`
**[WYBÓR GRACZA: ""We can't just give away our majority like that.""]** — Mówca: **Player**
> ""We can't just give away our majority like that.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: ""I know it is a delicate matter, sir. But you still have ..."*)

### Węzeł `[93]`
Mówca: **Nia Morgna**
> ""We will make sure the Old Guards won't control the Court any longer, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Section 4.""*)

### Węzeł `[94]`
Mówca: **Petr Vectern**
> ""Well, they need absolute immunity in theory. But look at what reality got us? We've got to deal with the most corrupt Chief Justice in the world, with no chance to deal with him!""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[86]` (*Player: ""We should respect their immunity.""*)
  - -> `[87]` (*Player: ""They should be able to be impeached. Why do I get to be ..."*)
  - -> `[88]` (*Player: ""We should crush the Old Guards to clear ways for further..."*)
  - -> `[89]` (*Player: ""Maybe we shouldn't make the Supreme Court our enemies ju..."*)

### Węzeł `[95]`
Mówca: **Lucian Galade**
> ""Section 6. This is about the presidential decrees. Reformists demand more limitations to the President's executive powers. Mr. Ricter has demanded them to be completely removed.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[34]` (*Nia Morgna: ""I have suggested to bring some limitations to decrees re..."*)

### Węzeł `[96]`
Mówca: **Lucian Galade**
> ""Uhm. The next one...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[103]` (*Lucian Galade: ""Section 4.""*)

### Węzeł `[97]`
**[WYBÓR GRACZA: ""Don't worry. With these reforms, we will be even more popular.""]** — Mówca: **Player**
> ""Don't worry. With these reforms, we will be even more popular.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[70]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[124]` (*Lucian Galade: ""I hope it works out, Mr. President.""*)

### Węzeł `[98]`
**[WYBÓR GRACZA: ""We'll work with the reformists to limit the use of decrees.""]** — Mówca: **Player**
> ""We'll work with the reformists to limit the use of decrees.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[142]` (*Petr Vectern: ""Frens will probably demand that we remove them completel..."*)

### Węzeł `[99]`
**[WYBÓR GRACZA: ""But the high threshold is the reason why Sordish politics has become so isolated.""]** — Mówca: **Player**
> ""But the high threshold is the reason why Sordish politics has become isolated to this degree.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[46]` (*Nia Morgna: ""You're right. Even after Soll's resignation, we still ha..."*)

### Węzeł `[100]`
Mówca: **Nia Morgna**
> ""While I agree that the current court members are *problematic*, this is no way to resolve it. The law is supposed to ensure the judiciary's independence by giving legal protection so they can't be pressured.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[94]` (*Petr Vectern: ""Well, they need absolute immunity in theory. But look at..."*)

### Węzeł `[101]`
**[WYBÓR GRACZA: ""We should definitely work to decrease the threshold for better representation.""]** — Mówca: **Player**
> ""We should definitely work to decrease the threshold for better representation in our democracy.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[52]` (*Nia Morgna: ""I agree. Even after Soll's resignation, we still have th..."*)

### Węzeł `[102]`
Mówca: **Nia Morgna**
> ""I do not support taking away their power for yourself, Mr. President. The judiciary must be independent and long-lasting.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[100]` (*Nia Morgna: ""While I agree that the current court members are *proble..."*)

### Węzeł `[103]`
Mówca: **Lucian Galade**
> ""Section 4.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[108]` (*Lucian Galade: ""This is regarding the appointment of ministers. Currentl..."*)

### Węzeł `[104]`
Mówca: **Lucian Galade**
> ""It's the question about the immunity of the Judges. While the Anti-Old Guard sentiment is increasing, there are talks that taking away their immunity would give us authority over judiciary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[102]` (*Nia Morgna: ""I do not support taking away their power for yourself, M..."*)

### Węzeł `[105]`
Mówca: **Lucian Galade**
> ""Now I'll move unto the 8th Section. We are reaching the end.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[104]` (*Lucian Galade: ""It's the question about the immunity of the Judges. Whil..."*)

### Węzeł `[106]`
**[WYBÓR GRACZA: ""Do you think it would really hurt the party?""]** — Mówca: **Player**
> ""Do you think it would really hurt the party?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[139]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[61]` (*Nia Morgna: ""I think this is a national matter, Mr. Rayne. Not a part..."*)

### Węzeł `[107]`
Mówca: **Lucian Galade**
> ""Even Soll knew he had to leave, but we will leave it to the President to decide.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[110]` (*Player: ""Yes, he did. But it took a long time.""*)
  - -> `[114]` (*Player: ""I agree. People should be able to elect the same person ..."*)
  - -> `[109]` (*Player: ""I will take my time and seriously consider the options b..."*)

### Węzeł `[108]`
Mówca: **Lucian Galade**
> ""This is regarding the appointment of ministers. Currently, the President is free to appoint anyone from the members of the Assembly. Nobody else is involved with the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[112]` (*Nia Morgna: ""There is definitely a demand to involve the Assembly in ..."*)

### Węzeł `[109]`
**[WYBÓR GRACZA: ""I will take my time and seriously consider the options before settling on one.""]** — Mówca: **Player**
> ""I will take my time and seriously consider the options before settling on one.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Now I'll move unto the 8th Section. We are reaching the ..."*)

### Węzeł `[110]`
**[WYBÓR GRACZA: ""Yes, he did. But it took a long time.""]** — Mówca: **Player**
> ""Yes, he did. But it took a long time.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Now I'll move unto the 8th Section. We are reaching the ..."*)

### Węzeł `[111]`
Mówca: **Nia Morgna**
> ""Some reformists suggested that the Assembly should nominate the ministers before the President approves them.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[141]` (*Petr Vectern: ""Of course, according to the ratio of the party's in gove..."*)

### Węzeł `[112]`
Mówca: **Nia Morgna**
> ""There is definitely a demand to involve the Assembly in the process.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[122]` (*Player: ""That's going a bit too far.""*)
  - -> `[120]` (*Player: ""We could introduce a confidence vote.""*)
  - -> `[119]` (*Player: ""I agree. We should involve the Assembly more in the proc..."*)

### Węzeł `[113]`
Mówca: **Lucian Galade**
> ""It could be destabilising.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[126]` (*Lucian Galade: ""I know it is a delicate matter, sir. But you still have ..."*)

### Węzeł `[114]`
**[WYBÓR GRACZA: ""I agree. People should be able to elect the same person if they want to.""]** — Mówca: **Player**
> ""I agree. People should be able to elect the same person if they want to.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[107]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[105]` (*Lucian Galade: ""Now I'll move unto the 8th Section. We are reaching the ..."*)

### Węzeł `[115]`
Mówca: **Lucian Galade**
> ""The fifth section is about our infamous electoral threshold. Most reformists want to lower the threshold as much as possible.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[73]` (*Nia Morgna: ""Mr. Ricter and his PFJP definitely wants to see change o..."*)

### Węzeł `[116]`
**[WYBÓR GRACZA: ""I don't think presidential decrees need any reforms.""]** — Mówca: **Player**
> ""I don't think presidential decrees need any reforms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[128]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[129]` (*Lucian Galade: ""Me neither. I think it's important that the President ca..."*)

### Węzeł `[117]`
Mówca: **Petr Vectern**
> ""Hey, if people keep electing one person, that means they really are content. The masses are scared of change.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[107]` (*Lucian Galade: ""Even Soll knew he had to leave, but we will leave it to ..."*)

### Węzeł `[118]`
Mówca: **Nia Morgna**
> ""We can't allow somebody like Soll holding unto his seat for two decades again. We should establish limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[119]`
**[WYBÓR GRACZA: ""I agree. We should involve the Assembly more in the process.""]** — Mówca: **Player**
> ""I agree. We should involve the Assembly more in the process.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[111]` (*Nia Morgna: ""Some reformists suggested that the Assembly should nomin..."*)

### Węzeł `[120]`
**[WYBÓR GRACZA: ""We could introduce a confidence vote.""]** — Mówca: **Player**
> ""We could introduce a confidence vote.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[130]` (*Nia Morgna: ""That was my suggestion as well.""*)

### Węzeł `[121]`
Mówca: **Lucian Galade**
> ""They want us to include previously non-existing term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Nia Morgna: ""We can't allow somebody like Soll holding unto his seat ..."*)

### Węzeł `[122]`
**[WYBÓR GRACZA: ""That's going a bit too far.""]** — Mówca: **Player**
> ""I think that's going a bit too far.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[112]` (Nia Morgna)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[135]` (*Nia Morgna: ""Maybe. But Mr. Ricter doesn't think so.""*)

### Węzeł `[123]`
Mówca: **Lucian Galade**
> ""Yes. Tarquin Soll governed for twenty years. It seems his magic is slowly vanishing from the minds of the people, for they believe term limits are necessary.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[118]` (*Nia Morgna: ""We can't allow somebody like Soll holding unto his seat ..."*)

### Węzeł `[124]`
Mówca: **Lucian Galade**
> ""I hope it works out, Mr. President.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Lucian continued with the next section."*)

### Węzeł `[125]`
Mówca: **Lucian Galade**
> ""I agree, we could keep that in.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[126]`
Mówca: **Lucian Galade**
> ""I know it is a delicate matter, sir. But you still have time to think about these.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[143]` (*Narrator: "Lucian continued with the next section."*)

### Węzeł `[127]`
Mówca: **Nia Morgna**
> ""I agree. We can't allow somebody like Soll holding unto his seat for two decades again.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[117]` (*Petr Vectern: ""Hey, if people keep electing one person, that means they..."*)

### Węzeł `[128]`
Mówca: **Petr Vectern**
> ""We could also make it dependent on an enabling act from the Assembly. Sure, it would make the whole process longer but as long as we have a majority, nothing really changes.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[116]` (*Player: ""I don't think presidential decrees need any reforms.""*)
  - -> `[98]` (*Player: ""We'll work with the reformists to limit the use of decre..."*)
  - -> `[77]` (*Player: ""I may need to think a bit longer about this.""*)

### Węzeł `[129]`
Mówca: **Lucian Galade**
> ""Me neither. I think it's important that the President can act quickly on matters of national importance.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""Next one is Section 7. Term limits.""*)

### Węzeł `[130]`
Mówca: **Nia Morgna**
> ""That was my suggestion as well.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[140]` (*Petr Vectern: ""I'm sure the reformists would completely support that.""*)

### Węzeł `[131]`
**[WYBÓR GRACZA: ""Uh-oh.""]** — Mówca: **Player**
> ""Uh-oh.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[123]` (*Lucian Galade: ""Yes. Tarquin Soll governed for twenty years. It seems hi..."*)

### Węzeł `[132]`
**[WYBÓR GRACZA: ""I don't aim to leave any time soon. We keep the unlimited terms.""]** — Mówca: **Player**
> ""I don't aim to leave any time soon. We keep the unlimited terms.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[125]` (*Lucian Galade: ""I agree, we could keep that in.""*)

### Węzeł `[133]`
**[WYBÓR GRACZA: ""Term limits are necessary.""]** — Mówca: **Player**
> ""Term limits are necessary.""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[127]` (*Nia Morgna: ""I agree. We can't allow somebody like Soll holding unto ..."*)

### Węzeł `[134]`
**[WYBÓR GRACZA: ""Term Limits?""]** — Mówca: **Player**
> ""Term Limits?""
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[137]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[121]` (*Lucian Galade: ""They want us to include previously non-existing term lim..."*)

### Węzeł `[135]`
Mówca: **Nia Morgna**
> ""Maybe. But Mr. Ricter doesn't think so.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[138]` (*Petr Vectern: ""Mr. Clavin and our party's reformist wing has no problem..."*)

### Węzeł `[136]`
Mówca: **Petr Vectern**
> ""Yes, but this is a delicate matter. The party, and I mean, not even Albin wants us to change the threshold. They think that... this would destroy our party in the long term.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[139]` (*Lucian Galade: ""Not wrong. The ten percent threshold is what that allowe..."*)

### Węzeł `[137]`
Mówca: **Lucian Galade**
> ""Next one is Section 7. Term limits.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[131]` (*Player: ""Uh-oh.""*)
  - -> `[132]` (*Player: ""I don't aim to leave any time soon. We keep the unlimite..."*)
  - -> `[133]` (*Player: ""Term limits are necessary.""*)
  - -> `[134]` (*Player: ""Term Limits?""*)

### Węzeł `[138]`
Mówca: **Petr Vectern**
> ""Mr. Clavin and our party's reformist wing has no problems with the current law. I'm sure PFJP can be persuaded too.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[144]` (*Petr Vectern: ""If the entire package is to their liking, I don't think ..."*)

### Węzeł `[139]`
Mówca: **Lucian Galade**
> ""Not wrong. The ten percent threshold is what that allowed us to control half of the Assembly with around one third of the majority in the elections.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[99]` (*Player: ""But the high threshold is the reason why Sordish politic..."*)
  - -> `[101]` (*Player: ""We should definitely work to decrease the threshold for ..."*)
  - -> `[106]` (*Player: ""Do you think it would really hurt the party?""*)
  - -> `[76]` (*Player: ""This is out of the question.""*)

### Węzeł `[140]`
Mówca: **Petr Vectern**
> ""I'm sure the reformists would completely support that.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[141]`
Mówca: **Petr Vectern**
> ""Of course, according to the ratio of the party's in government. In our case, it's only us.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[142]`
Mówca: **Petr Vectern**
> ""Frens will probably demand that we remove them completely. But he forgets that Sordland is a Presidential Republic.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""Next one is Section 7. Term limits.""*)

### Węzeł `[143]`
Mówca: **Narrator**
> "Lucian continued with the next section."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[95]` (*Lucian Galade: ""Section 6. This is about the presidential decrees. Refor..."*)

### Węzeł `[144]`
Mówca: **Petr Vectern**
> ""If the entire package is to their liking, I don't think Frens will resist his own. He wouldn't say no to such major changes just because of a few small details.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[115]` (*Lucian Galade: ""The fifth section is about our infamous electoral thresh..."*)

### Węzeł `[145]`
Mówca: **Petr Vectern**
> ""Sure. You'll have a long time before we start writing the final proposal together.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[137]` (*Lucian Galade: ""Next one is Section 7. Term limits.""*)

### Węzeł `[146]`
**[WYBÓR GRACZA: "“Let's start.”"]** — Mówca: **Player**
> "“Let's start.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[157]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[147]`
**[WYBÓR GRACZA: "“Can we go over each of the points that are in discussion for the draft?”"]** — Mówca: **Player**
> "“Can we go over each of the points that are in discussion for the draft?”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[32]` (Lucian Galade)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[148]` (*Lucian Galade: ""Well, apart from the first two sections of decreasing th..."*)

### Węzeł `[148]`
Mówca: **Lucian Galade**
> ""Well, apart from the first two sections of decreasing the Supreme Court's authority and limiting the presidential vetoes... Nothing else has been agreed on unanimously.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[38]` (*Lucian Galade: ""We could start talking about Section 3. This is about th..."*)

### Węzeł `[149]`
**[WYBÓR GRACZA: "“Let's start working on the draft.”"]** — Mówca: **Player**
> "“Let's start working on the draft.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[150]`
**[WYBÓR GRACZA: "“I thank you all for your input.”"]** — Mówca: **Player**
> "“I thank you all for your input.”"
- **Wymagania odblokowania:** *Brak (Dostępna bezwarunkowo)*
- **Kontekst wejściowy (poprzednik):** `[43]` (Petr Vectern)
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[158]` (*Węzeł Logiki Narracyjnej: "GameCondition.Turn03_A_Pre_Constitution = true"*)

### Węzeł `[151]`
Mówca: **Narrator**
> "After placing the committee's report and my own notes in front of me, I buried myself in the papers."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[159]` (*Węzeł Logiki Narracyjnej: "ShowPagedDecisionsPanel("Panel_ReformistConstitution");  ..."*)

### Węzeł `[152]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_LT_BenfiFestival = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_LT_BenfiFestival"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[11]` (*Narrator: "The reform committee finally bore tangible results and th..."*)

### Węzeł `[153]`
Mówca: **Narrator**
> "She paused before taking my coat. It looked like she had something on her mind."
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[154]` (*Livia Suno: ""Mr. Rayne -- can you give me a hint about your reform pl..."*)

### Węzeł `[154]`
Mówca: **Livia Suno**
> ""Mr. Rayne -- can you give me a hint about your reform plans? If you ask me, taking away the judges' immunity is long overdue, but it might anger a lot of people in these halls...""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[25]` (*Player: "“You'll find out with the rest of Sordland, sweetheart.""*)
  - -> `[26]` (*Player: "“I'll take that into consideration.""*)
  - -> `[27]` (*Player: ""Nothing's been decided yet.""*)
  - -> `[28]` (*Player: "“That's none of your business, Livia.""*)

### Węzeł `[155]`
Mówca: **Livia Suno**
> ""Understood. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Livia left to hang up my coat. I entered my office and sa..."*)

### Węzeł `[156]`
Mówca: **Livia Suno**
> ""I hope you'll keep me informed. I'll take your coat now.""
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[29]` (*Narrator: "Livia left to hang up my coat. I entered my office and sa..."*)

### Węzeł `[157]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Pre_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[33]` (*Narrator: "After placing the committee's report and my own notes in ..."*)

### Węzeł `[158]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `GameCondition.Turn03_A_Pre_Constitution = true`
- **Efekt skryptowy (`userScript`):** `Variable["GameCondition.Turn03_A_Pre_Constitution"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[151]` (*Narrator: "After placing the committee's report and my own notes in ..."*)

### Węzeł `[159]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `ShowPagedDecisionsPanel("Panel_ReformistConstitution");

// Shows Paged Decisions Panel with the name in database`
- **Efekt skryptowy (`userScript`):** `ShowPagedDecisionsPanel("Panel_ReformistConstitution");
-- Shows Paged Decisions Panel with the name in database;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[1]` (*System / INPUT: "input"*)

### Węzeł `[160]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGame.ReformProposal_Open = true`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGame.ReformProposal_Open"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[162]` (*Węzeł Logiki Narracyjnej: "BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;"*)

### Węzeł `[161]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `End();`
- **Efekt skryptowy (`userScript`):** `End();`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[2]` (*System / OUTPUT: "output"*)

### Węzeł `[162]`
**[WĘZEŁ LOGIKI NARRACYJNEJ]**
*Tytuł logiczny:* `BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis = true;`
- **Efekt skryptowy (`userScript`):** `Variable["BaseGameSupport.News_Turn03_E_EPA_PotentialsAnalysis"] = true;`
- **Połączenia wychodzące (`outgoingLinks`):**
  - -> `[161]` (*Węzeł Logiki Narracyjnej: "End();"*)
